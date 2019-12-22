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

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InsoniaLiteraria04.NoEscuro
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NoEscuroDetailsPage : ContentPage
    {
        DBFire service;
        ObservableCollection<ProximoCapitulo> list = new ObservableCollection<ProximoCapitulo>();
        public NoEscuroDetailsPage ()
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
                var listAsync = await service.proximoCapitulo(usuario, "NoEscuro");

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
                                capituloDescricao = "VOCÊ AINDA NÃO COMEÇOU A HISTÓRIA";
                            }
                            if (capitulos > 0)
                            {
                                capituloDescricao = "PRÓXIMO: CAPÍTULO " + capitulos.ToString();
                            }
                            if (capitulos == 6)
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

        async void IrParaCapitulo(object sender, EventArgs e)
        {
            var task = MostrarProximoCapitulo(UserLocalData.userUID);
            int result = await task;

            var loadingPage = new LoadingPopupPage();
            await Navigation.PushPopupAsync(loadingPage);

            if (result >= 6)
            {
                result = 5;
            }

            if (result == 0)
            {
                await Navigation.PushModalAsync(new PrologoPage());
            }
            else if (result >= 1 && result <= 5)
            {
                await Navigation.PushModalAsync(new Capitulo1Page(result));
            }
            
            await Task.Delay(1000);
            await Navigation.RemovePopupPageAsync(loadingPage);

        }
    }
}