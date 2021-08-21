﻿using InsoniaLiteraria04.Constantes;
using InsoniaLiteraria04.Control;
using InsoniaLiteraria04.Database;
using InsoniaLiteraria04.Global;
using InsoniaLiteraria04.Helper;
using InsoniaLiteraria04.View;
using Rg.Plugins.Popup.Extensions;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InsoniaLiteraria04.SegredosObscurosView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SegredosObscurosDetailsPage : ContentPage
	{
        DBFireCapitulos serviceCapitulos;
        public SegredosObscurosDetailsPage ()
		{
			InitializeComponent ();
            AdmobControl admobControl = new AdmobControl()
            {
                AdUnitId = AppConstants.BannerId
            };
            serviceCapitulos = new DBFireCapitulos();
            lblPorcentagem.Text = "0% LIDO";
            MostrarProximoCapitulo(UserLocalData.userUID);
        }

        private async void imgPlaylist_Tapped(object sender, EventArgs e)
        {
            var uri = new Uri("https://open.spotify.com/playlist/3eeGBeRt921WDjIkqx6Pye?si=v0PUbTVPQlO8qTj84OiibA");
            await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }

        private async Task<int> MostrarProximoCapitulo(string usuario)
        {
            int capitulos;
            capitulos = 0;

            try
            {
                var listAsync = await serviceCapitulos.proximoCapitulo(usuario, "SegObscuros");

                if (listAsync != null)
                {

                    if (listAsync.Count == 0)
                    {
                        lbltitulo.Text = "COMECE AGORA A LER";
                        lbldescricao.Text = "CLIQUE AQUI PARA COMEÇAR!";
                    }
                    else
                    {
                        var listaOrdenada = listAsync.OrderBy(i => i.Capitulo).ToList();

                        for (int i = 1; i <= listaOrdenada.Count; i++)
                        {
                            var listPrincipal = listaOrdenada[listaOrdenada.Count - i];

                            var capituloNaoFormato = listPrincipal.Capitulo.ToString();
                            capitulos = Convert.ToInt32(capituloNaoFormato) + 1;

                            var capituloDescricao = "";

                            if (capitulos == 0)
                            {
                                capituloDescricao = "COMECE AGORA A LER";
                            }
                            
                            if (capitulos > 0)
                            {
                                capituloDescricao = "PRÓXIMO: CAPÍTULO " + capitulos.ToString();
                                decimal capitulo = capitulos - 1;
                                decimal total = Constantes.CapsConstantes.SegObscuros;
                                decimal porcentagem = Math.Ceiling(100 * capitulo / total);

                                lblPorcentagem.Text = porcentagem.ToString() + "% LIDO";
                            }

                            if (capitulos > CapsConstantes.SegObscuros)
                            {
                                capituloDescricao = "ESPERO QUE TENHA GOSTADO...";
                                lblPorcentagem.Text = "100% LIDO";
                            }

                            lbltitulo.Text = capituloDescricao.ToString();
                            lbldescricao.Text = "CLIQUE AQUI E CONTINUE LENDO!";

                            if (listPrincipal.Lido.ToString() == "true")
                            {
                                break;
                            }
                        }
                        return capitulos;
                    }
                    return capitulos;
                }
                return capitulos;
            }
            catch (Exception ex)
            {

                lbltitulo.Text = "COMECE AGORA A LER";
                lbldescricao.Text = "CLIQUE AQUI PARA COMEÇAR!";
                lblPorcentagem.Text = "0% LIDO";

                await DisplayAlert("FALHA DE CONEXÃO", "VERIFIQUE SUA CONEXÃO COM A INTERNET", "OK");

                return capitulos = 0;
            }
        }

        async void IrParaCapitulo(object sender, EventArgs e)
        {
            var task = MostrarProximoCapitulo(UserLocalData.userUID);
            int result = await task;

            var loadingPage = new LoadingPopupPage();
            await Navigation.PushPopupAsync(loadingPage);

            for (var i = 0; i < 1; i++)
            {
                await DependencyService.Get<IAdmobInterstitialAds>().Display(AppConstants.InterstitialAdId);
            }

            if (result == 0)
            {
                result = 1;
            }

            if (result > CapsConstantes.SegObscuros)
            {
                await Navigation.PushModalAsync(new MenusView.MenuSegredosObscurosPage());
            } else
            {
                await Navigation.PushModalAsync(new Capitulo1Page(result));
            }

            await Task.Delay(500);
            await Navigation.RemovePopupPageAsync(loadingPage);

        }

        async void clkFechar(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void clkResetar(object sender, EventArgs e)
        {
            try
            {
                var action = await DisplayAlert("Aviso", "Deseja mesmo resetar essa história?", "Sim", "Não");
                if (action)
                {
                    var loadingPage = new LoadingPopupPage();
                    await Navigation.PushPopupAsync(loadingPage);
                    await serviceCapitulos.resetarSerie(UserLocalData.userUID, "SegObscuros");
                    await Task.Delay(500);
                    await Navigation.PushModalAsync(new PrincipalPage(0));
                    await Navigation.RemovePopupPageAsync(loadingPage);
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("ERRO", "Não foi possível resetar essa história. Favor tentar novamente.", "OK");
            }
        }
    }
}