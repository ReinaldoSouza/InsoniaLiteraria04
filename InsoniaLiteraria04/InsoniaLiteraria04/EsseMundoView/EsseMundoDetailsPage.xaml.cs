using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using InsoniaLiteraria04.Database;
using System.Collections.ObjectModel;
using InsoniaLiteraria04.Model;
using InsoniaLiteraria04.Helper;
using System.Threading.Tasks;
using InsoniaLiteraria04.View;
using Rg.Plugins.Popup.Extensions;
using System.Linq;

namespace InsoniaLiteraria04.EsseMundoView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EsseMundoDetailsPage : ContentPage
    {
        DBFire service;
        ObservableCollection<ProximoCapitulo> list = new ObservableCollection<ProximoCapitulo>();
        public EsseMundoDetailsPage()
        {
            InitializeComponent();
            service = new DBFire();
            _list.BindingContext = list;
            MostrarProximoCapitulo(UserLocalData.userUID);
        }

        private async void imgPlaylist_Tapped(object sender, EventArgs e)
        {
            var uri = new Uri("https://open.spotify.com/user/reinaldosouza09/playlist/0kndO5dQ97xaOmq8io2g6J?si=RWiKyg10RJuwradzDwRxrQ");
            await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }

        private async Task<int> MostrarProximoCapitulo(string usuario)
        {
            int capitulos;
            capitulos = 0;

            try
            {
                var listAsync = await service.proximoCapitulo(usuario, "EsseMundoVaiMudar");

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
                            if (capitulos == 48)
                            {
                                capituloDescricao = "ESPERO QUE VOCÊ TENHA GOSTADO...";
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

            if (result >= 48)
            {
                result = 47;
            }

                if (result == 0)
                {
                    await Navigation.PushModalAsync(new IntroducaoPage());
                }
                else if (result >= 1 && result <= 6)
                {
                    await Navigation.PushModalAsync(new Capitulo1Page(result));
                }
                else if (result >= 7 && result <= 12)
                {
                    await Navigation.PushModalAsync(new Capitulo2Page(result));
                }
                else if (result >= 13 && result <= 18)
                {
                    await Navigation.PushModalAsync(new Capitulo3Page(result));
                }
                else if (result >= 19 && result <= 24)
                {
                    await Navigation.PushModalAsync(new Capitulo4Page(result));
                }
                else if (result >= 25 && result <= 30)
                {
                    await Navigation.PushModalAsync(new Capitulo5Page(result));
                }
                else if (result >= 31 && result <= 36)
                {
                    await Navigation.PushModalAsync(new Capitulo6Page(result));
                }
                else if (result >= 37 && result <= 42)
                {
                    await Navigation.PushModalAsync(new Capitulo7Page(result));
                }
                else if (result >= 43 && result <= 47)
                {
                    await Navigation.PushModalAsync(new Capitulo8Page(result));
                }

            await Task.Delay(1000);
                await Navigation.RemovePopupPageAsync(loadingPage);
            
        }
    }
}