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
	public partial class MenuNoEscuroPage : ContentPage
	{
        DBFireViews serviceViews;
        DBFireComentarios serviceComentarios;
        ObservableCollection<OpcoesMenu> ListaMenu = new ObservableCollection<OpcoesMenu>();
        ObservableCollection<QuantidadeViews> ListaViews = new ObservableCollection<QuantidadeViews>();
        ObservableCollection<QuantidadeComentario> ListaComentarios = new ObservableCollection<QuantidadeComentario>();

        public MenuNoEscuroPage()
		{
			InitializeComponent();
            AdmobControl admobControl = new AdmobControl()
            {
                AdUnitId = AppConstants.BannerId
            };
            serviceViews = new DBFireViews();
            serviceComentarios = new DBFireComentarios();
            _list.BindingContext = ListaMenu;
            carregarViews();
        }

        public async void carregarViews()
        {
            try
            {
                ListaViews.Clear();
                ListaComentarios.Clear();

                var listAsyncViews = await serviceViews.mostrarQuantidadeCapitulo("NoEscuro");

                var lista1 = listAsyncViews.ToList();

                foreach (var item in lista1)
                {
                    ListaViews.Add(item);
                }

                var listAsyncComents = await serviceComentarios.mostrarComentarioCapitulo("NoEscuro");

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

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Prologo,
                    Descricao = null,
                    Titulo = "PRÓLOGO",
                    Imagem = "menuescuro.JPG",
                    Views = ListaViews[MenuConstantes.Prologo].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Prologo].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo1,
                    Descricao = "Retorno",
                    Titulo = "CAPÍTULO 1",
                    Imagem = "menuescuro.JPG",
                    Views = ListaViews[MenuConstantes.Capitulo1].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo1].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo2,
                    Descricao = "A Mulher No Lago",
                    Titulo = "CAPÍTULO 2",
                    Imagem = "menuescuro.JPG",
                    Views = ListaViews[MenuConstantes.Capitulo2].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo2].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo3,
                    Descricao = "Máscaras",
                    Titulo = "CAPÍTULO 3",
                    Imagem = "menuescuro.JPG",
                    Views = ListaViews[MenuConstantes.Capitulo3].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo3].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo4,
                    Descricao = "A Feira",
                    Titulo = "CAPÍTULO 4",
                    Imagem = "menuescuro.JPG",
                    Views = ListaViews[MenuConstantes.Capitulo4].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo4].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo5,
                    Descricao = "Nostalgia",
                    Titulo = "CAPÍTULO 5",
                    Imagem = "menuescuro.JPG",
                    Views = ListaViews[MenuConstantes.Capitulo5].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo5].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo6,
                    Descricao = "Desconfiança",
                    Titulo = "CAPÍTULO 6",
                    Imagem = "menuescuro.JPG",
                    Views = ListaViews[MenuConstantes.Capitulo6].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo6].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo7,
                    Descricao = "Parceria",
                    Titulo = "CAPÍTULO 7",
                    Imagem = "menuescuro.JPG",
                    Views = ListaViews[MenuConstantes.Capitulo7].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo7].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo8,
                    Descricao = "Estratégia",
                    Titulo = "CAPÍTULO 8",
                    Imagem = "menuescuro.JPG",
                    Views = ListaViews[MenuConstantes.Capitulo8].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo8].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo9,
                    Descricao = "Isca",
                    Titulo = "CAPÍTULO 9",
                    Imagem = "menuescuro.JPG",
                    Views = ListaViews[MenuConstantes.Capitulo9].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo9].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo10,
                    Descricao = "Traição",
                    Titulo = "CAPÍTULO 10",
                    Imagem = "menuescuro.JPG",
                    Views = ListaViews[MenuConstantes.Capitulo10].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo10].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo11,
                    Descricao = "Armadilha",
                    Titulo = "CAPÍTULO 11",
                    Imagem = "menuescuro.JPG",
                    Views = ListaViews[MenuConstantes.Capitulo11].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo11].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo12,
                    Descricao = "Culpa",
                    Titulo = "CAPÍTULO 12",
                    Imagem = "menuescuro.JPG",
                    Views = ListaViews[MenuConstantes.Capitulo12].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo12].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo13,
                    Descricao = "Alerta",
                    Titulo = "CAPÍTULO 13",
                    Imagem = "menuescuro.JPG",
                    Views = ListaViews[MenuConstantes.Capitulo13].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo13].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo14,
                    Descricao = "Medo",
                    Titulo = "CAPÍTULO 14",
                    Imagem = "menuescuro.JPG",
                    Views = ListaViews[MenuConstantes.Capitulo14].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo14].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo15,
                    Descricao = "Subterrâneo",
                    Titulo = "CAPÍTULO 15",
                    Imagem = "menuescuro.JPG",
                    Views = ListaViews[MenuConstantes.Capitulo15].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo15].Quantidade.ToString(),
                    Status = true
                });
            }
            catch (Exception ex)
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
                    await Navigation.PushModalAsync(new NoEscuro.Capitulo1Page(codigo));
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