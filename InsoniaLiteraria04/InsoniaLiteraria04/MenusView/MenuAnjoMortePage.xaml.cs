using InsoniaLiteraria04.AnjoMorteView;
using InsoniaLiteraria04.Constantes;
using InsoniaLiteraria04.Control;
using InsoniaLiteraria04.Database;
using InsoniaLiteraria04.Global;
using InsoniaLiteraria04.Model;
using InsoniaLiteraria04.View;
using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InsoniaLiteraria04.MenusView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuAnjoMortePage : ContentPage
	{
        DBFireViews serviceViews;
        DBFireComentarios serviceComentarios;
        DBFireMenus serviceMenus;
        ObservableCollection<OpcoesMenu> ListaMenu = new ObservableCollection<OpcoesMenu>();
        ObservableCollection<QuantidadeViews> ListaViews = new ObservableCollection<QuantidadeViews>();
        ObservableCollection<QuantidadeComentario> ListaComentarios = new ObservableCollection<QuantidadeComentario>();

        public MenuAnjoMortePage ()
		{
			InitializeComponent();
            AdmobControl admobControl = new AdmobControl()
            {
                AdUnitId = AppConstants.BannerId
            };

            serviceViews = new DBFireViews();
            serviceComentarios = new DBFireComentarios();
            serviceMenus = new DBFireMenus();
            _list.BindingContext = ListaMenu;
            carregarViews();
        }

        public async void carregarViews()
        {
            try
            {
                ListaViews.Clear();
                ListaComentarios.Clear();

                var listAsyncMenu = await serviceMenus.mostrarMenu("AnjoMorte");
                var listMenu = listAsyncMenu.ToList();

                var listAsyncViews = await serviceViews.mostrarQuantidadeCapitulo("AnjoMorte");
                var lista1 = listAsyncViews.ToList();

                foreach (var item in lista1)
                {
                    ListaViews.Add(item);
                }

                var listAsyncComents = await serviceComentarios.mostrarComentarioCapitulo("AnjoMorte");
                var lista2 = listAsyncComents.ToList();

                foreach (var item2 in lista2)
                {
                    ListaComentarios.Add(item2);
                }

                ListaMenu.Clear();

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.PrincipalPage,
                    Descricao = "Aproveite e escolha outra história para ler!",
                    Titulo = "Voltar Para a Tela Principal",
                    Imagem = "menu_voltar.png",
                    Status = false
                });

                foreach (var menu in listMenu)
                {
                    ListaMenu.Add(new OpcoesMenu
                    {
                        Codigo = Convert.ToInt32(menu.codigo),
                        Descricao = null,
                        Titulo = menu.titulo,
                        Imagem = "menuanjomorte.jpg",
                        Views = ListaViews[Convert.ToInt32(menu.codigo)].Quantidade.ToString(),
                        Capitulos = ListaComentarios[Convert.ToInt32(menu.codigo)].Quantidade.ToString(),
                        Status = true
                    });
                }

            } catch (Exception ex)
            {
                await DisplayAlert("AVISO!", "O MENU NÃO FOI CARREGADO! VERIFIQUE SUA CONEXÃO COM A INTERNET", "OK");

                ListaMenu.Clear();

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.PrincipalPage,
                    Descricao = "Aproveite e escolha outra história para ler!",
                    Titulo = "Voltar Para a Tela Principal",
                    Imagem = "menu_voltar.png",
                    Status = false
                });
            }
        }

        public void atualizarMenu(object sender, EventArgs e)
        {
            carregarViews();
            _list.IsRefreshing = false;
        }

        public async void IrParaCapitulo(object sender, SelectedItemChangedEventArgs e)
        {
            try
            {
                var loadingPage = new LoadingPopupPage();
                await Navigation.PushPopupAsync(loadingPage);

                
                for (var i = 0; i < 1; i++)
                {
                    await DependencyService.Get<IAdmobInterstitialAds>().Display(AppConstants.InterstitialAdId);
                }

                var item = (OpcoesMenu)e.SelectedItem;
                var codigo = item.Codigo;

                if (codigo == -1)
                {
                    await Navigation.PushModalAsync(new PrincipalPage(0));
                }
                else 
                {
                    await Navigation.PushModalAsync(new Capitulo1Page(codigo));
                }
                await Task.Delay(500);
                await Navigation.RemovePopupPageAsync(loadingPage);
            }
            catch (Exception ex)
            {
                await DisplayAlert("erro", ex.Message, "ok");
            }
        }
    }
}