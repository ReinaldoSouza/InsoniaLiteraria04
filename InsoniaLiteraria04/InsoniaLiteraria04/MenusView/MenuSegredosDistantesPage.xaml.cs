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
    public partial class MenuSegredosDistantesPage : ContentPage
    {
        DBFireViews serviceViews;
        DBFireComentarios serviceComentarios;
        ObservableCollection<OpcoesMenu> ListaMenu = new ObservableCollection<OpcoesMenu>();
        ObservableCollection<QuantidadeViews> ListaViews = new ObservableCollection<QuantidadeViews>();
        ObservableCollection<QuantidadeComentario> ListaComentarios = new ObservableCollection<QuantidadeComentario>();

        public MenuSegredosDistantesPage()
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

                var listAsyncViews = await serviceViews.mostrarQuantidadeCapitulo("SegDistantes");

                var lista1 = listAsyncViews.ToList();

                foreach (var item in lista1)
                {
                    ListaViews.Add(item);
                }

                var listAsyncComents = await serviceComentarios.mostrarComentarioCapitulo("SegDistantes");

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
                    Descricao = "Caixa de Entrada de Temperance",
                    Titulo = "PRÓLOGO",
                    Imagem = "menudistantes.png",
                    Views = ListaViews[MenuConstantes.Prologo].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Prologo].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo1,
                    Descricao = "Decepção",
                    Titulo = "CAPÍTULO 1",
                    Imagem = "menudistantes.png",
                    Views = ListaViews[MenuConstantes.Capitulo1].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo1].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo2,
                    Descricao = "Vida Nova",
                    Titulo = "CAPÍTULO 2",
                    Imagem = "menudistantes.png",
                    Views = ListaViews[MenuConstantes.Capitulo2].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo2].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo3,
                    Descricao = "Segredos",
                    Titulo = "CAPÍTULO 3",
                    Imagem = "menudistantes.png",
                    Views = ListaViews[MenuConstantes.Capitulo3].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo3].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo4,
                    Descricao = "Fracasso",
                    Titulo = "CAPÍTULO 4",
                    Imagem = "menudistantes.png",
                    Views = ListaViews[MenuConstantes.Capitulo4].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo4].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo5,
                    Descricao = "Coração",
                    Titulo = "CAPÍTULO 5",
                    Imagem = "menudistantes.png",
                    Views = ListaViews[MenuConstantes.Capitulo5].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo5].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo6,
                    Descricao = "Time de Dois",
                    Titulo = "CAPÍTULO 6",
                    Imagem = "menudistantes.png",
                    Views = ListaViews[MenuConstantes.Capitulo6].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo6].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo7,
                    Descricao = "Aprendizado",
                    Titulo = "CAPÍTULO 7",
                    Imagem = "menudistantes.png",
                    Views = ListaViews[MenuConstantes.Capitulo7].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo7].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo8,
                    Descricao = "Qualquer Lugar, Menos Aqui",
                    Titulo = "CAPÍTULO 8",
                    Imagem = "menudistantes.png",
                    Views = ListaViews[MenuConstantes.Capitulo8].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo8].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo9,
                    Descricao = "Demissão",
                    Titulo = "CAPÍTULO 9",
                    Imagem = "menudistantes.png",
                    Views = ListaViews[MenuConstantes.Capitulo9].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo9].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo10,
                    Descricao = "Perseguição",
                    Titulo = "CAPÍTULO 10",
                    Imagem = "menudistantes.png",
                    Views = ListaViews[MenuConstantes.Capitulo10].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo10].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo11,
                    Descricao = "Reencontro",
                    Titulo = "CAPÍTULO 11",
                    Imagem = "menudistantes.png",
                    Views = ListaViews[MenuConstantes.Capitulo11].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo11].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo12,
                    Descricao = "Presente de Grego",
                    Titulo = "CAPÍTULO 12",
                    Imagem = "menudistantes.png",
                    Views = ListaViews[MenuConstantes.Capitulo12].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo12].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo13,
                    Descricao = "Ano Novo",
                    Titulo = "CAPÍTULO 13",
                    Imagem = "menudistantes.png",
                    Views = ListaViews[MenuConstantes.Capitulo13].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo13].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo14,
                    Descricao = "Término",
                    Titulo = "CAPÍTULO 14",
                    Imagem = "menudistantes.png",
                    Views = ListaViews[MenuConstantes.Capitulo14].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo14].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo15,
                    Descricao = "Desastre",
                    Titulo = "CAPÍTULO 15",
                    Imagem = "menudistantes.png",
                    Views = ListaViews[MenuConstantes.Capitulo15].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo15].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo16,
                    Descricao = "Deixar Para Lá e Desistir",
                    Titulo = "CAPÍTULO 16",
                    Imagem = "menudistantes.png",
                    Views = ListaViews[MenuConstantes.Capitulo16].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo16].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo17,
                    Descricao = "Obsessão",
                    Titulo = "CAPÍTULO 17",
                    Imagem = "menudistantes.png",
                    Views = ListaViews[MenuConstantes.Capitulo17].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo17].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo18,
                    Descricao = "No Caminho",
                    Titulo = "CAPÍTULO 18",
                    Imagem = "menudistantes.png",
                    Views = ListaViews[MenuConstantes.Capitulo18].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo18].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo19,
                    Descricao = "Regras da Festa",
                    Titulo = "CAPÍTULO 19",
                    Imagem = "menudistantes.png",
                    Views = ListaViews[MenuConstantes.Capitulo19].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo19].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo20,
                    Descricao = "Pense Grande Ou Vá Para Casa",
                    Titulo = "CAPÍTULO 20",
                    Imagem = "menudistantes.png",
                    Views = ListaViews[MenuConstantes.Capitulo20].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo20].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo21,
                    Descricao = "Amizade Dupla",
                    Titulo = "CAPÍTULO 21",
                    Imagem = "menudistantes.png",
                    Views = ListaViews[MenuConstantes.Capitulo21].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo21].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo22,
                    Descricao = "Tempos Difíceis",
                    Titulo = "CAPÍTULO 22",
                    Imagem = "menudistantes.png",
                    Views = ListaViews[MenuConstantes.Capitulo22].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo22].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo23,
                    Descricao = "Terremoto",
                    Titulo = "CAPÍTULO 23",
                    Imagem = "menudistantes.png",
                    Views = ListaViews[MenuConstantes.Capitulo23].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo23].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo24,
                    Descricao = "Pós-Tremor",
                    Titulo = "CAPÍTULO 24",
                    Imagem = "menudistantes.png",
                    Views = ListaViews[MenuConstantes.Capitulo24].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo24].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo25,
                    Descricao = "Fazer Direito",
                    Titulo = "CAPÍTULO 25",
                    Imagem = "menudistantes.png",
                    Views = ListaViews[MenuConstantes.Capitulo25].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo25].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo26,
                    Descricao = "O Melhor",
                    Titulo = "CAPÍTULO 26",
                    Imagem = "menudistantes.png",
                    Views = ListaViews[MenuConstantes.Capitulo26].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo26].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo27,
                    Descricao = "Dia D",
                    Titulo = "CAPÍTULO 27",
                    Imagem = "menudistantes.png",
                    Views = ListaViews[MenuConstantes.Capitulo27].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo27].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo28,
                    Descricao = "Guerra",
                    Titulo = "CAPÍTULO 28",
                    Imagem = "menudistantes.png",
                    Views = ListaViews[MenuConstantes.Capitulo28].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo28].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo29,
                    Descricao = "Apagado",
                    Titulo = "CAPÍTULO 29",
                    Imagem = "menudistantes.png",
                    Views = ListaViews[MenuConstantes.Capitulo29].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo29].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo30,
                    Descricao = "Inauguração",
                    Titulo = "CAPÍTULO 30",
                    Imagem = "menudistantes.png",
                    Views = ListaViews[MenuConstantes.Capitulo30].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo30].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo31,
                    Descricao = "Bônus",
                    Titulo = "CAPÍTULO 31",
                    Imagem = "menudistantes.png",
                    Views = ListaViews[MenuConstantes.Capitulo31].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo31].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo32,
                    Descricao = "Karaokê",
                    Titulo = "CAPÍTULO 32",
                    Imagem = "menudistantes.png",
                    Views = ListaViews[MenuConstantes.Capitulo32].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo32].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo33,
                    Descricao = "Último",
                    Titulo = "CAPÍTULO 33",
                    Imagem = "menudistantes.png",
                    Views = ListaViews[MenuConstantes.Capitulo33].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo33].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo34,
                    Descricao = "Culpado",
                    Titulo = "CAPÍTULO 34",
                    Imagem = "menudistantes.png",
                    Views = ListaViews[MenuConstantes.Capitulo34].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo34].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo35,
                    Descricao = "Boas e Más Notícias",
                    Titulo = "CAPÍTULO 35",
                    Imagem = "menudistantes.png",
                    Views = ListaViews[MenuConstantes.Capitulo35].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo35].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo36,
                    Descricao = "Céu",
                    Titulo = "CAPÍTULO 36",
                    Imagem = "menudistantes.png",
                    Views = ListaViews[MenuConstantes.Capitulo36].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo36].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo37,
                    Descricao = "Vivendo",
                    Titulo = "CAPÍTULO 37",
                    Imagem = "menudistantes.png",
                    Views = ListaViews[MenuConstantes.Capitulo37].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo37].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo38,
                    Descricao = "Fugida",
                    Titulo = "CAPÍTULO 38",
                    Imagem = "menudistantes.png",
                    Views = ListaViews[MenuConstantes.Capitulo38].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo38].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo39,
                    Descricao = "Realidade",
                    Titulo = "CAPÍTULO 39",
                    Imagem = "menudistantes.png",
                    Views = ListaViews[MenuConstantes.Capitulo39].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo39].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo40,
                    Descricao = "Caminhos Cruzados",
                    Titulo = "CAPÍTULO 40",
                    Imagem = "menudistantes.png",
                    Views = ListaViews[MenuConstantes.Capitulo40].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo40].Quantidade.ToString(),
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
                    await Navigation.PushModalAsync(new SegredosDistantesView.Capitulo1Page(codigo));
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