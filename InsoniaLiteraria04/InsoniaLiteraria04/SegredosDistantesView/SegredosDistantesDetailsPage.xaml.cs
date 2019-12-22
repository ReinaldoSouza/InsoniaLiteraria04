using InsoniaLiteraria04.Database;
using InsoniaLiteraria04.Global;
using InsoniaLiteraria04.Helper;
using InsoniaLiteraria04.Model;
using InsoniaLiteraria04.View;
using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InsoniaLiteraria04.SegredosDistantesView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SegredosDistantesDetailsPage : ContentPage
    {
        DBFire service;
        ObservableCollection<ProximoCapitulo> list = new ObservableCollection<ProximoCapitulo>();
        public SegredosDistantesDetailsPage()
        {
            InitializeComponent();
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
                var listAsync = await service.proximoCapitulo(usuario, "SegDistantes");

                if (listAsync != null)
                {

                    if (listAsync.Count == 0)
                    {
                        list.Add(new ProximoCapitulo
                        {
                            nomeCapitulo = "VOCÊ AINDA NÃO COMEÇOU ESSA HISTÓRIA",
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

                            if (capitulos == 9)
                            {
                                capituloDescricao = "CAPÍTULOS NOVOS EM BREVE...";
                            }

                            list.Add(new ProximoCapitulo
                            {
                                nomeCapitulo = capituloDescricao, 
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

            if (result == 9)
            {
                result = 8;
            }

            if (result == 0)
            {
                await Navigation.PushModalAsync(new PrologoPage());
            }

            if (result >= 1 && result <= 8)
            {
                await Navigation.PushModalAsync(new Capitulo1Page(result));
            }

            await Task.Delay(1000);
            await Navigation.RemovePopupPageAsync(loadingPage);

        }
    }
}