using InsoniaLiteraria04.Constantes;
using InsoniaLiteraria04.Database;
using InsoniaLiteraria04.Helper;
using Rg.Plugins.Popup.Extensions;
using System;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InsoniaLiteraria04.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PerfilPage : ContentPage
    {
        DBFireCapitulos serviceCapitulos;
        DBFireUsuario serviceUsuario;
        CapsConstantes capConstantes;
        public PerfilPage()
        {
            InitializeComponent();
            inicializarImagens();
            serviceCapitulos = new DBFireCapitulos();
            serviceUsuario = new DBFireUsuario();
            capConstantes = new CapsConstantes();
            carregarConstantes();
            carregarUsuario();
            mostrarEstadoHistorias();
        }

        public async void carregarConstantes()
        {
            try
            {
                capConstantes = await serviceCapitulos.carregarCapituloConstante();
            } catch (Exception ex)
            {
                capConstantes.AnjoMorte = "0";
                capConstantes.ApenasDance = "0";
                capConstantes.AscencaoSober = "0";
                capConstantes.EsseMundo = "0";
                capConstantes.Estranha = "0";
                capConstantes.NoEscuro = "0";
                capConstantes.Resenhas = "0";
                capConstantes.SegDistantes = "0";
                capConstantes.SegInternos = "0";
                capConstantes.SegObscuros = "0";
                capConstantes.SuaMusica = "0";
            }
        }

        //inicializar as imagens como visibilidade falsa.
        public void inicializarImagens()
        {
            stlAscensaoSober.IsVisible = false;
            stlAnjoMorte.IsVisible = false;
            stlApenasDance.IsVisible = false;
            stlEscuro.IsVisible = false;
            stlEstranha.IsVisible = false;
            stlMundo.IsVisible = false;
            stlSuaMusica.IsVisible = false;
            stlObscuros.IsVisible = false;
            stlDistantes.IsVisible = false;
            stlInternos.IsVisible = false;
            stlAnjoMorteF.IsVisible = false;
            stlApenasDanceF.IsVisible = false;
            stlAscensaoSoberF.IsVisible = false;
            stlEscuroF.IsVisible = false;
            stlEstranhaF.IsVisible = false;
            stlMundoF.IsVisible = false;
            stlSuaMusicaF.IsVisible = false;
            stlObscurosF.IsVisible = false;
            stlDistantesF.IsVisible = false;
            stlInternosF.IsVisible = false;
            stlSemLendo.IsVisible = true;
            stlSemFinalizadas.IsVisible = true;
            stlAguardando.IsVisible = true;
        }

        async void carregarUsuario()
        {
            image_profile.Source = "capaprofile.jpg";
            lblNome.Text = "NOME";
            lblUsername.Text = "username";
            lblDataCadastro.Text = "";

            try
            {
                var listAsyncFoto = await serviceUsuario.mostrarFotoPerfil(UserLocalData.userUID);

                if (listAsyncFoto != null)
                {
                    image_profile.Source = listAsyncFoto.ImageUrl.ToString();
                }

                var listAsyncDados = await serviceUsuario.coletarDadosUsuario(UserLocalData.userUID);

                if (listAsyncDados != null)
                {
                    lblNome.Text = listAsyncDados.Nome.ToUpper();
                    lblUsername.Text = listAsyncDados.Username.ToLower();
                    lblDataCadastro.Text = "Cadastrado em " + Convert.ToDateTime(listAsyncDados.Data_cadastro).ToString("d");
                }
            }
            catch (Exception)
            {
                await DisplayAlert("ERRO", "SEUS DADOS NÃO FORAM CARREGADOS CORRETAMENTE. VERIFIQUE A CONEXÃO COM A INTERNET!", "OK");
            }
        }

        private async Task<int> verificarCapitulo(string usuario, string nomeHistoria)
        {
            int capitulo = 0;

            try
            {
                var listAsync = await serviceCapitulos.proximoCapitulo(usuario, nomeHistoria);

                if (listAsync != null)
                {
                    if (listAsync.Count > 0)
                    {
                        var listaOrdenada = listAsync.OrderBy(i => i.Capitulo).ToList();

                        for (int i = 1; i <= listaOrdenada.Count; i++)
                        {
                            var listPrincipal = listaOrdenada[listaOrdenada.Count - i];

                            var capituloNaoFormato = listPrincipal.Capitulo.ToString();
                            capitulo = Convert.ToInt32(capituloNaoFormato) + 1;

                            if (listPrincipal.Lido.ToString() == "true")
                            {
                                break;
                            }
                        }
                    }
                }
                return capitulo;
            } catch (Exception)
            {
                return capitulo;
            }
        }

        public void mostrarEstadoHistorias()
        {
            mostrarFinalizadasAnjoMorte();
            mostrarFinalizadasAscencaoSober();
            mostrarFinalizadasApenasDance();
            mostrarFinalizadasEscuro();
            mostrarFinalizadasEsseMundo();
            mostrarFinalizadasSuaMusica();
            mostrarFinalizadasEstranha();
            mostrarFinalizadasObscuros();
            mostrarFinalizadasInternos();
            mostrarFinalizadasDistantes();
        }

        public async void mostrarFinalizadasAscencaoSober()
        {
            var task = verificarCapitulo(UserLocalData.userUID, "AscensaoSober");
            int result = await task;

            if (result != 0)
            {
                if (result > Convert.ToInt32(capConstantes.AscencaoSober))
                {
                    stlAscensaoSoberF.IsVisible = true;
                    stlAguardando.IsVisible = false;
                } else
                {
                    decimal capitulo = result;
                    decimal total = Convert.ToInt32(capConstantes.AscencaoSober) + 1;
                    decimal porcentagem = Math.Ceiling(100 * capitulo / total);

                    porcentagem = porcentagem / 100;

                    BarraProgressoSober.Progress = Convert.ToDouble(porcentagem);

                    stlAscensaoSober.IsVisible = true;
                    stlSemLendo.IsVisible = false;
                }
            }
        }

        public async void mostrarFinalizadasAnjoMorte()
        {
            var task = verificarCapitulo(UserLocalData.userUID, "AnjoMorte");
            int result = await task;

            if (result != 0)
            {
                if (result > Convert.ToInt32(capConstantes.AnjoMorte))
                {
                    stlAnjoMorteF.IsVisible = true;
                    stlAguardando.IsVisible = false;
                } else
                {
                    decimal capitulo = result;
                    decimal total = Convert.ToInt32(capConstantes.AnjoMorte) + 1;
                    decimal porcentagem = Math.Ceiling(100 * capitulo / total);

                    porcentagem = porcentagem / 100;

                    BarraProgressoAnjo.Progress = Convert.ToDouble(porcentagem);

                    stlAnjoMorte.IsVisible = true;
                    stlSemLendo.IsVisible = false;
                }
            }
        }

        public async void mostrarFinalizadasEsseMundo()
        {
            var task = verificarCapitulo(UserLocalData.userUID, "EsseMundoVaiMudar");
            int result = await task;

            if (result != 0)
            {
                if (result > Convert.ToInt32(capConstantes.EsseMundo))
                {
                    stlMundoF.IsVisible = true;
                    stlSemFinalizadas.IsVisible = false;
                } else
                {
                    decimal capitulo = result;
                    decimal total = Convert.ToInt32(capConstantes.EsseMundo) + 1;
                    decimal porcentagem = Math.Ceiling(100 * capitulo / total);

                    porcentagem = porcentagem / 100;

                    BarraProgressoMundo.Progress = Convert.ToDouble(porcentagem);

                    stlMundo.IsVisible = true;
                    stlSemLendo.IsVisible = false;
                }
            }
        }

        public async void mostrarFinalizadasSuaMusica()
        {
            var task = verificarCapitulo(UserLocalData.userUID, "SuaMusicaSalvou");
            int result = await task;

            if (result != 0)
            {
                if (result > Convert.ToInt32(capConstantes.SuaMusica))
                {
                    stlSuaMusicaF.IsVisible = true;
                    stlSemFinalizadas.IsVisible = false;
                } else
                {
                    decimal capitulo = result;
                    decimal total = Convert.ToInt32(capConstantes.SuaMusica) + 1;
                    decimal porcentagem = Math.Ceiling(100 * capitulo / total);

                    porcentagem = porcentagem / 100;

                    BarraProgressoMusica.Progress = Convert.ToDouble(porcentagem);

                    stlSuaMusica.IsVisible = true;
                    stlSemLendo.IsVisible = false;
                }
            }
        }

        public async void mostrarFinalizadasEscuro()
        {
            var task = verificarCapitulo(UserLocalData.userUID, "NoEscuro");
            int result = await task;

            if (result != 0)
            {
                if (result > Convert.ToInt32(capConstantes.NoEscuro))
                {
                    stlEscuroF.IsVisible = true;
                    stlAguardando.IsVisible = false;
                } else
                {
                    decimal capitulo = result;
                    decimal total = Convert.ToInt32(capConstantes.NoEscuro) + 1;
                    decimal porcentagem = Math.Ceiling(100 * capitulo / total);

                    porcentagem = porcentagem / 100;

                    BarraProgressoEscuro.Progress = Convert.ToDouble(porcentagem);

                    stlEscuro.IsVisible = true;
                    stlSemLendo.IsVisible = false;
                }
            }
        }

        public async void mostrarFinalizadasObscuros()
        {
            var task = verificarCapitulo(UserLocalData.userUID, "SegObscuros");
            int result = await task;

            if (result != 0)
            {
                if (result > Convert.ToInt32(capConstantes.SegObscuros))
                {
                    stlObscurosF.IsVisible = true;
                    stlSemFinalizadas.IsVisible = false;
                } else
                {
                    decimal capitulo = result - 1;
                    decimal total = Convert.ToInt32(capConstantes.SegObscuros);
                    decimal porcentagem = Math.Ceiling(100 * capitulo / total);

                    porcentagem = porcentagem / 100;

                    BarraProgressoObscuros.Progress = Convert.ToDouble(porcentagem);

                    stlObscuros.IsVisible = true;
                    stlSemLendo.IsVisible = false;
                }
            }
        }

        public async void mostrarFinalizadasDistantes()
        {
            var task = verificarCapitulo(UserLocalData.userUID, "SegDistantes");
            int result = await task;

            if (result != 0)
            {
                if (result > Convert.ToInt32(capConstantes.SegDistantes))
                {
                    stlDistantesF.IsVisible = true;
                    stlSemFinalizadas.IsVisible = false;
                } else
                {
                    decimal capitulo = result;
                    decimal total = Convert.ToInt32(capConstantes.SegDistantes) + 1;
                    decimal porcentagem = Math.Ceiling(100 * capitulo / total);

                    porcentagem = porcentagem / 100;

                    BarraProgressoDistantes.Progress = Convert.ToDouble(porcentagem);

                    stlDistantes.IsVisible = true;
                    stlSemLendo.IsVisible = false;
                }
            }
        }

        public async void mostrarFinalizadasInternos()
        {
            var task = verificarCapitulo(UserLocalData.userUID, "SegInternos");
            int result = await task;

            if (result != 0)
            {
                if (result > Convert.ToInt32(capConstantes.SegInternos))
                {
                    stlInternosF.IsVisible = true;
                    stlAguardando.IsVisible = false;
                } else
                {
                    decimal capitulo = result;
                    decimal total = Convert.ToInt32(capConstantes.SegInternos) + 1;
                    decimal porcentagem = Math.Ceiling(100 * capitulo / total);

                    porcentagem = porcentagem / 100;

                    BarraProgressoInternos.Progress = Convert.ToDouble(porcentagem);

                    stlInternos.IsVisible = true;
                    stlSemLendo.IsVisible = false;
                }
            }
        }
        public async void mostrarFinalizadasEstranha()
        {
            var task = verificarCapitulo(UserLocalData.userUID, "Estranha");
            int result = await task;

            if (result != 0)
            {
                if (result > Convert.ToInt32(capConstantes.Estranha))
                {
                    stlEstranhaF.IsVisible = true;
                    stlAguardando.IsVisible = false;
                } else
                {
                    decimal capitulo = result - 1;
                    decimal total = Convert.ToInt32(capConstantes.Estranha);
                    decimal porcentagem = Math.Ceiling(100 * capitulo / total);

                    porcentagem = porcentagem / 100;

                    BarraProgressoEstranha.Progress = Convert.ToDouble(porcentagem);

                    stlEstranha.IsVisible = true;
                    stlSemLendo.IsVisible = false;
                }
            }
        }

        public async void mostrarFinalizadasApenasDance()
        {
            var task = verificarCapitulo(UserLocalData.userUID, "ApenasDance");
            int result = await task;

            if (result != 0)
            {
                if (result > Convert.ToInt32(capConstantes.ApenasDance))
                {
                    stlApenasDanceF.IsVisible = true;
                    stlAguardando.IsVisible = false;
                } else
                {
                    decimal capitulo = result -1;
                    decimal total = Convert.ToInt32(capConstantes.ApenasDance);
                    decimal porcentagem = Math.Ceiling(100 * capitulo / total);

                    porcentagem = porcentagem / 100;

                    BarraProgressoDance.Progress = Convert.ToDouble(porcentagem);

                    stlApenasDance.IsVisible = true;
                    stlSemLendo.IsVisible = false;
                }
            }
        }

        private async void imgLendo_Tapped(object sender, EventArgs e)
        {
            var loadingPage = new LoadingPopupPage();
            await Navigation.PushPopupAsync(loadingPage);
            await Task.Delay(500);
            await Navigation.PushModalAsync(new PrincipalPage(0));
            await Navigation.RemovePopupPageAsync(loadingPage);
        }

        private async void imgMundo_Tapped(object sender, EventArgs e)
        {
            var loadingPage = new LoadingPopupPage();
            await Navigation.PushPopupAsync(loadingPage);
            await Task.Delay(500);
            await Navigation.PushModalAsync(new EsseMundoView.EsseMundoDetailsPage());
            await Navigation.RemovePopupPageAsync(loadingPage);
        }

        private async void imgSuaMusica_Tapped(object sender, EventArgs e)
        {
            var loadingPage = new LoadingPopupPage();
            await Navigation.PushPopupAsync(loadingPage);
            await Task.Delay(500);
            await Navigation.PushModalAsync(new SuaMusicaView.SuaMusicaDetailsPage());
            await Navigation.RemovePopupPageAsync(loadingPage);
        }

        private async void imgEscuro_Tapped(object sender, EventArgs e)
        {
            var loadingPage = new LoadingPopupPage();
            await Navigation.PushPopupAsync(loadingPage);
            await Task.Delay(500);
            await Navigation.PushModalAsync(new NoEscuro.NoEscuroDetailsPage());
            await Navigation.RemovePopupPageAsync(loadingPage);
        }

        private async void imgAscensaoSober_Tapped(object sender, EventArgs e)
        {
            var loadingPage = new LoadingPopupPage();
            await Navigation.PushPopupAsync(loadingPage);
            await Task.Delay(500);
            await Navigation.PushModalAsync(new AscencaoSoberView.AnscensaoSoberDetailsPage());
            await Navigation.RemovePopupPageAsync(loadingPage);
        }

        private async void imgAnjoMorte_Tapped(object sender, EventArgs e)
        {
            var loadingPage = new LoadingPopupPage();
            await Navigation.PushPopupAsync(loadingPage);
            await Task.Delay(500);
            await Navigation.PushModalAsync(new AnjoMorteView.AnjoMorteDetaisPage());
            await Navigation.RemovePopupPageAsync(loadingPage);
        }

        private async void imgApenasDance_Tapped(object sender, EventArgs e)
        {
            var loadingPage = new LoadingPopupPage();
            await Navigation.PushPopupAsync(loadingPage);
            await Task.Delay(500);
            await Navigation.PushModalAsync(new MenusView.MenuApenasDancePage());
            await Navigation.RemovePopupPageAsync(loadingPage);
        }

        private async void imgObscuros_Tapped(object sender, EventArgs e)
        {
            var loadingPage = new LoadingPopupPage();
            await Navigation.PushPopupAsync(loadingPage);
            await Task.Delay(500);
            await Navigation.PushModalAsync(new SegredosObscurosView.SegredosObscurosDetailsPage());
            await Navigation.RemovePopupPageAsync(loadingPage);
        }

        private async void imgDistantes_Tapped(object sender, EventArgs e)
        {
            var loadingPage = new LoadingPopupPage();
            await Navigation.PushPopupAsync(loadingPage);
            await Task.Delay(500);
            await Navigation.PushModalAsync(new SegredosDistantesView.SegredosDistantesDetailsPage());
            await Navigation.RemovePopupPageAsync(loadingPage);
        }

        private async void imgInternos_Tapped(object sender, EventArgs e)
        {
            var loadingPage = new LoadingPopupPage();
            await Navigation.PushPopupAsync(loadingPage);
            await Task.Delay(500);
            await Navigation.PushModalAsync(new SegredosInternosView.SegredosInternosDetailsPage());
            await Navigation.RemovePopupPageAsync(loadingPage);
        }

        private async void imgEstranha_Tapped(object sender, EventArgs e)
        {
            var loadingPage = new LoadingPopupPage();
            await Navigation.PushPopupAsync(loadingPage);
            await Task.Delay(500);
            await Navigation.PushModalAsync(new MenusView.MenuEstranhaPage());
            await Navigation.RemovePopupPageAsync(loadingPage);
        }

        public async void clkGoAjuste(object sender, EventArgs e)
        {
            var loadingPage = new LoadingPopupPage();
            await Navigation.PushPopupAsync(loadingPage);
            await Task.Delay(500);
            await Navigation.PushModalAsync(new ConfiguracoesPage());
            await Navigation.RemovePopupPageAsync(loadingPage);
        }

    }
}