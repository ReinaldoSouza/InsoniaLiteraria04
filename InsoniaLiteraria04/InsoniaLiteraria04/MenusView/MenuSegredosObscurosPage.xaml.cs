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
	public partial class MenuSegredosObscurosPage : ContentPage
	{
        DBFireViews serviceViews;
        DBFireComentarios serviceComentarios;
        ObservableCollection<OpcoesMenu> ListaMenu = new ObservableCollection<OpcoesMenu>();
        ObservableCollection<QuantidadeViews> ListaViews = new ObservableCollection<QuantidadeViews>();
        ObservableCollection<QuantidadeComentario> ListaComentarios = new ObservableCollection<QuantidadeComentario>();

        public MenuSegredosObscurosPage ()
		{
			InitializeComponent ();
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

                var listAsyncViews = await serviceViews.mostrarQuantidadeCapitulo("SegObscuros");

                var lista1 = listAsyncViews.ToList();

                foreach (var item in lista1)
                {
                    ListaViews.Add(item);
                }

                var listAsyncComents = await serviceComentarios.mostrarComentarioCapitulo("SegObscuros");

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
                    Codigo = MenuConstantes.Capitulo1,
                    Descricao = "Recomeços",
                    Titulo = "CAPÍTULO 1",
                    Imagem = "menuobscuro.jpg",
                    Views = ListaViews[MenuConstantes.Capitulo1].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo1].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo2,
                    Descricao = "Raiva",
                    Titulo = "CAPÍTULO 2",
                    Imagem = "menuobscuro.jpg",
                    Views = ListaViews[MenuConstantes.Capitulo2].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo2].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo3,
                    Descricao = "Distração",
                    Titulo = "CAPÍTULO 3",
                    Imagem = "menuobscuro.jpg",
                    Views = ListaViews[MenuConstantes.Capitulo3].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo3].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo4,
                    Descricao = "Escolhas",
                    Titulo = "CAPÍTULO 4",
                    Imagem = "menuobscuro.jpg",
                    Views = ListaViews[MenuConstantes.Capitulo4].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo4].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo5,
                    Descricao = "Verdade",
                    Titulo = "CAPÍTULO 5",
                    Imagem = "menuobscuro.jpg",
                    Views = ListaViews[MenuConstantes.Capitulo5].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo5].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo6,
                    Descricao = "Traição",
                    Titulo = "CAPÍTULO 6",
                    Imagem = "menuobscuro.jpg",
                    Views = ListaViews[MenuConstantes.Capitulo6].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo6].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo7,
                    Descricao = "Mentira",
                    Titulo = "CAPÍTULO 7",
                    Imagem = "menuobscuro.jpg",
                    Views = ListaViews[MenuConstantes.Capitulo7].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo7].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo8,
                    Descricao = "Amigos",
                    Titulo = "CAPÍTULO 8",
                    Imagem = "menuobscuro.jpg",
                    Views = ListaViews[MenuConstantes.Capitulo8].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo8].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo9,
                    Descricao = "Culpa",
                    Titulo = "CAPÍTULO 9",
                    Imagem = "menuobscuro.jpg",
                    Views = ListaViews[MenuConstantes.Capitulo9].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo9].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo10,
                    Descricao = "Colegas de Quarto",
                    Titulo = "CAPÍTULO 10",
                    Imagem = "menuobscuro.jpg",
                    Views = ListaViews[MenuConstantes.Capitulo10].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo10].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo11,
                    Descricao = "Ajuda",
                    Titulo = "CAPÍTULO 11",
                    Imagem = "menuobscuro.jpg",
                    Views = ListaViews[MenuConstantes.Capitulo11].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo11].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo12,
                    Descricao = "Encontros",
                    Titulo = "CAPÍTULO 12",
                    Imagem = "menuobscuro.jpg",
                    Views = ListaViews[MenuConstantes.Capitulo12].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo12].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo13,
                    Descricao = "Confusão",
                    Titulo = "CAPÍTULO 13",
                    Imagem = "menuobscuro.jpg",
                    Views = ListaViews[MenuConstantes.Capitulo13].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo13].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo14,
                    Descricao = "Suspeitas",
                    Titulo = "CAPÍTULO 14",
                    Imagem = "menuobscuro.jpg",
                    Views = ListaViews[MenuConstantes.Capitulo14].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo14].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo15,
                    Descricao = "Passado",
                    Titulo = "CAPÍTULO 15",
                    Imagem = "menuobscuro.jpg",
                    Views = ListaViews[MenuConstantes.Capitulo15].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo15].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo16,
                    Descricao = "Reconciliação",
                    Titulo = "CAPÍTULO 16",
                    Imagem = "menuobscuro.jpg",
                    Views = ListaViews[MenuConstantes.Capitulo16].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo16].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo17,
                    Descricao = "Mudança de Alvo",
                    Titulo = "CAPÍTULO 17",
                    Imagem = "menuobscuro.jpg",
                    Views = ListaViews[MenuConstantes.Capitulo17].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo17].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo18,
                    Descricao = "Briga",
                    Titulo = "CAPÍTULO 18",
                    Imagem = "menuobscuro.jpg",
                    Views = ListaViews[MenuConstantes.Capitulo18].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo18].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo19,
                    Descricao = "Amor",
                    Titulo = "CAPÍTULO 19",
                    Imagem = "menuobscuro.jpg",
                    Views = ListaViews[MenuConstantes.Capitulo19].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo19].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo20,
                    Descricao = "Revelação",
                    Titulo = "CAPÍTULO 20",
                    Imagem = "menuobscuro.jpg",
                    Views = ListaViews[MenuConstantes.Capitulo20].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo20].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo21,
                    Descricao = "Ódio",
                    Titulo = "CAPÍTULO 21",
                    Imagem = "menuobscuro.jpg",
                    Views = ListaViews[MenuConstantes.Capitulo21].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo21].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo22,
                    Descricao = "Dúvida",
                    Titulo = "CAPÍTULO 22",
                    Imagem = "menuobscuro.jpg",
                    Views = ListaViews[MenuConstantes.Capitulo22].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo22].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo23,
                    Descricao = "Dance",
                    Titulo = "CAPÍTULO 23",
                    Imagem = "menuobscuro.jpg",
                    Views = ListaViews[MenuConstantes.Capitulo23].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo23].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo24,
                    Descricao = "Despedida",
                    Titulo = "CAPÍTULO 24",
                    Imagem = "menuobscuro.jpg",
                    Views = ListaViews[MenuConstantes.Capitulo24].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo24].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo25,
                    Descricao = "Luto",
                    Titulo = "CAPÍTULO 25",
                    Imagem = "menuobscuro.jpg",
                    Views = ListaViews[MenuConstantes.Capitulo25].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo25].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo26,
                    Descricao = "Perguntas",
                    Titulo = "CAPÍTULO 26",
                    Imagem = "menuobscuro.jpg",
                    Views = ListaViews[MenuConstantes.Capitulo26].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo26].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo27,
                    Descricao = "Planos",
                    Titulo = "CAPÍTULO 27",
                    Imagem = "menuobscuro.jpg",
                    Views = ListaViews[MenuConstantes.Capitulo7].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo27].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo28,
                    Descricao = "Formatura",
                    Titulo = "CAPÍTULO 28",
                    Imagem = "menuobscuro.jpg",
                    Views = ListaViews[MenuConstantes.Capitulo28].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo28].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo29,
                    Descricao = "Caminhos Separados",
                    Titulo = "CAPÍTULO 29",
                    Imagem = "menuobscuro.jpg",
                    Views = ListaViews[MenuConstantes.Capitulo29].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo29].Quantidade.ToString(),
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
                } else 
                {
                    await Navigation.PushModalAsync(new SegredosObscurosView.Capitulo1Page(codigo));
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