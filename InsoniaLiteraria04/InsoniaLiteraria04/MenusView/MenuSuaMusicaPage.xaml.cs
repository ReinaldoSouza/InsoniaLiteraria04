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
    public partial class MenuSuaMusicaPage : ContentPage
    {
        DBFireViews serviceViews;
        DBFireComentarios serviceComentarios;
        ObservableCollection<OpcoesMenu> ListaMenu = new ObservableCollection<OpcoesMenu>();
        ObservableCollection<QuantidadeViews> ListaViews = new ObservableCollection<QuantidadeViews>();
        ObservableCollection<QuantidadeComentario> ListaComentarios = new ObservableCollection<QuantidadeComentario>();
        public MenuSuaMusicaPage()
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

                var listAsyncViews = await serviceViews.mostrarQuantidadeCapitulo("SuaMusicaSalvou");

                var lista1 = listAsyncViews.ToList();

                foreach (var item in lista1)
                {
                    ListaViews.Add(item);
                }

                var listAsyncComents = await serviceComentarios.mostrarComentarioCapitulo("SuaMusicaSalvou");

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
                    Descricao = "Sem Título",
                    Titulo = "PRÓLOGO",
                    Imagem = "menusuamusica.JPG",
                    Views = ListaViews[MenuConstantes.Prologo].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Prologo].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo1,
                    Descricao = "Amor é Isso, Isso é Amor",
                    Titulo = "CAPÍTULO 1",
                    Imagem = "menusuamusica.JPG",
                    Views = ListaViews[MenuConstantes.Capitulo1].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo1].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo2,
                    Descricao = "Amanhã Isso Pode Mudar",
                    Titulo = "CAPÍTULO 2",
                    Imagem = "menusuamusica.JPG",
                    Views = ListaViews[MenuConstantes.Capitulo2].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo2].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo3,
                    Descricao = "E Que Você Tenha Um Feliz Natal",
                    Titulo = "CAPÍTULO 3",
                    Imagem = "menusuamusica.JPG",
                    Views = ListaViews[MenuConstantes.Capitulo3].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo3].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo4,
                    Descricao = "E A Tendência é Piorar Daqui Para Frente",
                    Titulo = "CAPÍTULO 4",
                    Imagem = "menusuamusica.JPG",
                    Views = ListaViews[MenuConstantes.Capitulo4].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo4].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo5,
                    Descricao = "Para Todo Sempre",
                    Titulo = "CAPÍTULO 5",
                    Imagem = "menusuamusica.JPG",
                    Views = ListaViews[MenuConstantes.Capitulo5].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo5].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo6,
                    Descricao = "Não Tem Ninguém Em Casa",
                    Titulo = "CAPÍTULO 6",
                    Imagem = "menusuamusica.JPG",
                    Views = ListaViews[MenuConstantes.Capitulo6].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo6].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo7,
                    Descricao = "Para Fazer Você Sentir O Meu Amor",
                    Titulo = "CAPÍTULO 7",
                    Imagem = "menusuamusica.JPG",
                    Views = ListaViews[MenuConstantes.Capitulo7].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo7].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo8,
                    Descricao = "Então Me Acorde Quando Tudo Acabar",
                    Titulo = "CAPÍTULO 8",
                    Imagem = "menusuamusica.JPG",
                    Views = ListaViews[MenuConstantes.Capitulo8].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo8].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo9,
                    Descricao = "Aqui Estou Eu, Vivo",
                    Titulo = "CAPÍTULO 9",
                    Imagem = "menusuamusica.JPG",
                    Views = ListaViews[MenuConstantes.Capitulo9].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo9].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo10,
                    Descricao = "Se Apoie Em Mim",
                    Titulo = "CAPÍTULO 10",
                    Imagem = "menusuamusica.JPG",
                    Views = ListaViews[MenuConstantes.Capitulo10].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo10].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo11,
                    Descricao = "Todo Mundo Mente",
                    Titulo = "CAPÍTULO 11",
                    Imagem = "menusuamusica.JPG",
                    Views = ListaViews[MenuConstantes.Capitulo11].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo11].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo12,
                    Descricao = "Por Que Você Tem Que Deixar As Coisas Tão Complicadas?",
                    Titulo = "CAPÍTULO 12",
                    Imagem = "menusuamusica.JPG",
                    Views = ListaViews[MenuConstantes.Capitulo12].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo12].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo13,
                    Descricao = "Quebrado",
                    Titulo = "CAPÍTULO 13",
                    Imagem = "menusuamusica.JPG",
                    Views = ListaViews[MenuConstantes.Capitulo13].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo13].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo14,
                    Descricao = "É Assim Que O Amor Deveria Ser",
                    Titulo = "CAPÍTULO 14",
                    Imagem = "menusuamusica.JPG",
                    Views = ListaViews[MenuConstantes.Capitulo14].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo14].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo15,
                    Descricao = "Só Continue Respirando",
                    Titulo = "CAPÍTULO 15",
                    Imagem = "menusuamusica.JPG",
                    Views = ListaViews[MenuConstantes.Capitulo15].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo15].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo16,
                    Descricao = "Diga Alguma Coisa, Estou Desistindo de Você",
                    Titulo = "CAPÍTULO 16",
                    Imagem = "menusuamusica.JPG",
                    Views = ListaViews[MenuConstantes.Capitulo16].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo16].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo17,
                    Descricao = "Com Tanto Para Fazer, Você Estaria Perdendo e Nós Sentindo A Sua Falta",
                    Titulo = "CAPÍTULO 17",
                    Imagem = "menusuamusica.JPG",
                    Views = ListaViews[MenuConstantes.Capitulo17].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo17].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo18,
                    Descricao = "Esse É O Maior Show",
                    Titulo = "CAPÍTULO 18",
                    Imagem = "menusuamusica.JPG",
                    Views = ListaViews[MenuConstantes.Capitulo18].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo18].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo19,
                    Descricao = "Fantasmas Flutuam Ao Nosso Redor",
                    Titulo = "CAPÍTULO 19",
                    Imagem = "menusuamusica.JPG",
                    Views = ListaViews[MenuConstantes.Capitulo19].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo19].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo20,
                    Descricao = "Não Restou Mais Nada Dentro do Meu Peito, Mas Está Tudo Bem",
                    Titulo = "CAPÍTULO 20",
                    Imagem = "menusuamusica.JPG",
                    Views = ListaViews[MenuConstantes.Capitulo20].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo20].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo21,
                    Descricao = "Amor, Você Está Perfeita Hoje à Noite",
                    Titulo = "CAPÍTULO 21",
                    Imagem = "menusuamusica.JPG",
                    Views = ListaViews[MenuConstantes.Capitulo21].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo21].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo22,
                    Descricao = "Diga O Que Você Precisa Dizer",
                    Titulo = "CAPÍTULO 22",
                    Imagem = "menusuamusica.JPG",
                    Views = ListaViews[MenuConstantes.Capitulo22].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo22].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo23,
                    Descricao = "Como Salvar Uma Vida",
                    Titulo = "CAPÍTULO 23",
                    Imagem = "menusuamusica.JPG",
                    Views = ListaViews[MenuConstantes.Capitulo23].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo23].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo24,
                    Descricao = "Só Respire",
                    Titulo = "CAPÍTULO 24",
                    Imagem = "menusuamusica.JPG",
                    Views = ListaViews[MenuConstantes.Capitulo24].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo24].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo25,
                    Descricao = "Eu Vou Estar Aqui Por Você",
                    Titulo = "CAPÍTULO 25",
                    Imagem = "menusuamusica.JPG",
                    Views = ListaViews[MenuConstantes.Capitulo25].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo25].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo26,
                    Descricao = "Sem Você, Eu Sou Só Uma Música Triste",
                    Titulo = "CAPÍTULO 26",
                    Imagem = "menusuamusica.JPG",
                    Views = ListaViews[MenuConstantes.Capitulo26].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo26].Quantidade.ToString(),
                    Status = true
                });
                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo27,
                    Descricao = "Se Você Me Pedir Para Ficar, Eu Fico",
                    Titulo = "CAPÍTULO 27",
                    Imagem = "menusuamusica.JPG",
                    Views = ListaViews[MenuConstantes.Capitulo27].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo27].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo28,
                    Descricao = "Eu Estou Só A Uma Ligação De Distância",
                    Titulo = "CAPÍTULO 28",
                    Imagem = "menusuamusica.JPG",
                    Views = ListaViews[MenuConstantes.Capitulo28].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo28].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo29,
                    Descricao = "Eu Ficarei do Seu Lado",
                    Titulo = "CAPÍTULO 29",
                    Imagem = "menusuamusica.JPG",
                    Views = ListaViews[MenuConstantes.Capitulo29].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo29].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo30,
                    Descricao = "Depois de Todo Esse Tempo, Eu Ainda Estou A fim de Você",
                    Titulo = "CAPÍTULO 30",
                    Imagem = "menusuamusica.JPG",
                    Views = ListaViews[MenuConstantes.Capitulo30].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo30].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo31,
                    Descricao = "Se Esse Amor é Doloroso, Então Vamos Nos Ferir Essa Noite",
                    Titulo = "EPÍLOGO 1",
                    Imagem = "menusuamusica.JPG",
                    Views = ListaViews[MenuConstantes.Capitulo31].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo31].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo32,
                    Descricao = "Você é Minha e Eu Sou Seu",
                    Titulo = "EPÍLOGO 2",
                    Imagem = "menusuamusica.JPG",
                    Views = ListaViews[MenuConstantes.Capitulo32].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo32].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo33,
                    Descricao = "Eu Finalmente Encontrei Você",
                    Titulo = "EPÍLOGO 3",
                    Imagem = "menusuamusica.JPG",
                    Views = ListaViews[MenuConstantes.Capitulo33].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo33].Quantidade.ToString(),
                    Status = true
                });

                ListaMenu.Add(new OpcoesMenu
                {
                    Codigo = MenuConstantes.Capitulo34,
                    Descricao = "Quando Olho Nos Seus Olhos, Me Sinto Seguro",
                    Titulo = "EPÍLOGO 4",
                    Imagem = "menusuamusica.JPG",
                    Views = ListaViews[MenuConstantes.Capitulo34].Quantidade.ToString(),
                    Capitulos = ListaComentarios[MenuConstantes.Capitulo34].Quantidade.ToString(),
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
                    await Navigation.PushModalAsync(new SuaMusicaView.Capitulo1Page(codigo));
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