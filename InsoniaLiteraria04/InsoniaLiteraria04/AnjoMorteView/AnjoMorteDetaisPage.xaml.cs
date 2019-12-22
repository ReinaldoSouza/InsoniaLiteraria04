using InsoniaLiteraria04.Database;
using InsoniaLiteraria04.Helper;
using InsoniaLiteraria04.Model;
using InsoniaLiteraria04.View;
using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InsoniaLiteraria04.AnjoMorteView
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AnjoMorteDetaisPage : ContentPage
    {
        DBFire service;
        ObservableCollection<ProximoCapitulo> list = new ObservableCollection<ProximoCapitulo>();
        public AnjoMorteDetaisPage ()
		{
			InitializeComponent ();
            service = new DBFire();
            _list.BindingContext = list;
            MostrarProximoCapitulo(UserLocalData.userUID);
        }

        private async Task<int> MostrarProximoCapitulo(string usuario)
        {
            int capitulos;
            capitulos = 0;

            try
            {
                var listAsync = await service.proximoCapitulo(usuario, "AnjoMorte");

                if (listAsync != null)
                {

                    if (listAsync.Count == 0)
                    {
                        list.Add(new ProximoCapitulo
                        {
                            nomeCapitulo = "VOCÊ AINDA NÃO COMEÇOU A HISTÓRIA",
                            capituloLido = "VENHA LER AGORA!"
                        });

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
                                capituloDescricao = "VOCÊ AINDA NÃO COMEÇOU a HISTÓRIA";
                            }
                            if (capitulos > 0)
                            {
                                capituloDescricao = "PRÓXIMO: CAPÍTULO " + capitulos.ToString();
                            }
                            if (capitulos == 12)
                            {
                                capituloDescricao = "CAPÍTULOS NOVOS EM BREVE...";
                            }

                            list.Add(new ProximoCapitulo
                            {
                                nomeCapitulo = capituloDescricao, //"CAPÍTULO " + capitulos.ToString(),
                                capituloLido = "CONTINUE LENDO!"
                            });

                            if (listPrincipal.Lido.ToString() == "true")
                            {
                                break;
                            }
                            else
                            {
                                list.Clear();
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
                list.Add(new ProximoCapitulo
                {
                    nomeCapitulo = "VOCÊ AINDA NÃO COMEÇOU A HISTÓRIA",
                    capituloLido = "VENHA LER AGORA!"
                });

                await DisplayAlert("FALHA DE CONEXÃO", "VERIFIQUE SUA CONEXÃO COM A INTERNET", "OK");

                return capitulos = 0;
            }
        }

        private async void imgPlaylist_Tapped(object sender, EventArgs e)
        {
            var uri = new Uri("https://open.spotify.com/user/12162995437/playlist/3SXVyIEaeoGx1SP0FURDZ1?si=YUXhmj5WQNuWdBJqfG70gw");
            await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }

        async void IrParaCapitulo(object sender, EventArgs e)
        {
            var task = MostrarProximoCapitulo(UserLocalData.userUID);
            int result = await task;

            var loadingPage = new LoadingPopupPage();
            await Navigation.PushPopupAsync(loadingPage);

            if (result >= 11)
            {
                result = 11;
            }

            if (result >= 0 && result <= 6)
            {
                await Navigation.PushModalAsync(new Capitulo1Page(result));
            } else if (result >=7 && result <= 11)
            {
                await Navigation.PushModalAsync(new Capitulo2Page(result));
            }

            await Task.Delay(1000);
            await Navigation.RemovePopupPageAsync(loadingPage);

        }
    }
}