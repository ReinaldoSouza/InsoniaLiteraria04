using InsoniaLiteraria04.Database;
using InsoniaLiteraria04.Helper;
using InsoniaLiteraria04.Model;
using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InsoniaLiteraria04.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PerfilPage : ContentPage
    {
        DBFire db;

        public PerfilPage()
        {
            InitializeComponent();
            inicializarImagens();
            image_profile.Source = "capaprofile.jpg";
            db = new DBFire();
            carregarUsuario();
            mostrarEstadoHistorias();

        }

        public void inicializarImagens()
        {
            imgAnjoMorte.IsVisible = false;
            imgApenasDance.IsVisible = false;
            imgEscuro.IsVisible = false;
            imgEstranha.IsVisible = false;
            imgMundo.IsVisible = false;
            imgObscuros.IsVisible = false;
            imgDistantes.IsVisible = false;
            imgAnjoMorteF.IsVisible = false;
            imgApenasDanceF.IsVisible = false;
            imgEscuroF.IsVisible = false;
            imgEstranhaF.IsVisible = false;
            imgMundoF.IsVisible = false;
            imgObscurosF.IsVisible = false;
            imgDistantesF.IsVisible = false;
            imgSemLendo.IsVisible = true;
            imgSemFinalizadas.IsVisible = true;
            imgAguardando.IsVisible = true;
        }

        async void carregarUsuario()
        {
            try
            {
                var listAsync = await db.mostrarUsuarioNome();
                lblNome.Text = "  " + listAsync.ToUpper() + "  ";

                var listAsync2 = await db.mostrarUsuarioUsername();
                lblUsername.Text = "  " + listAsync2.ToUpper() + "  ";

                var listAsync3 = await db.mostrarFotoPerfil();

                if (listAsync3 != null)
                {
                    image_profile.Source = listAsync3.ImageUrl.ToString();
                }
                else
                {
                    image_profile.Source = "capaprofile.jpg";
                    await DisplayAlert("PERFIL", "Escolha agora uma foto para seu perfil em AJUSTES!", "OK");

                }

            }
            catch (Exception ex)
            {
                await DisplayAlert("ERRO", "SEUS DADOS NÃO FORAM CARREGADOS. VERIFIQUE A CONEXÃO COM A INTERNET!", "OK");
                image_profile.Source = "capaprofile.jpg";
                lblNome.Text = "NOME";
                lblUsername.Text = "USERNAME";
            }
        }

        private async Task<bool> verificarLeituras(string usuario, string nomeHistoria)
        {
            try
            {
                var listAsync = await db.proximoCapitulo(usuario, nomeHistoria);
                if (listAsync != null)
                {
                    if (listAsync.Count != 0)
                    {
                        var estado = listAsync[0].Lido.ToString();

                        if (estado == "true")
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    } else
                    {
                        return false;
                    }

                } else
                {
                    return false;
                }


            } catch (Exception ex)
            {
                return false;
            }
        }

        private async Task<bool> verificarFinalizada(string usuario, string nomeHistoria, int capitulo)
        {
            try
            {

                var listAsync = await db.proximoCapitulo(usuario, nomeHistoria);
                if (listAsync != null)
                {
                    if (listAsync.Count != 0)
                    {
                        var listaOrdenada = listAsync.OrderBy(i => i.Capitulo).ToList();

                        var numero = listaOrdenada[listaOrdenada.Count - 1].Capitulo.ToString();

                        if (Convert.ToInt32(numero) == capitulo)
                        {
                            var estado = listaOrdenada[listaOrdenada.Count - 1].Lido.ToString();

                            if (estado == "true")
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }

            } catch (Exception ex)
            {
                return false;
            }
        }

        public void mostrarEstadoHistorias()
        {
            mostrarFinalizadasAnjoMorte();
            mostrarFinalizadasApenasDance();
            mostrarFinalizadasEscuro();
            mostrarFinalizadasEsseMundo();
            mostrarFinalizadasEstranha();
            mostrarFinalizadasObscuros();
            mostrarFinalizadasDistantes();
        }

        public async void mostrarFinalizadasAnjoMorte()
        {
            var task1 = verificarFinalizada(UserLocalData.userUID, "AnjoMorte", 11);
            bool result1 = await task1;

            var task2 = verificarLeituras(UserLocalData.userUID, "AnjoMorte");
            bool result2 = await task2;

            if (result1 == true)
            {
                imgAnjoMorteF.IsVisible = true;
                imgAguardando.IsVisible = false;
            }
            else
            {
                if (result2 == true)
                {
                    imgAnjoMorte.IsVisible = true;
                    imgSemLendo.IsVisible = false;
                }
            }
        }

        public async void mostrarFinalizadasEsseMundo()
        {
            var task1 = verificarFinalizada(UserLocalData.userUID, "EsseMundoVaiMudar", 47);
            bool result1 = await task1;

            var task2 = verificarLeituras(UserLocalData.userUID, "EsseMundoVaiMudar");
            bool result2 = await task2;

            if (result1 == true)
            {
                imgMundoF.IsVisible = true;
                imgSemFinalizadas.IsVisible = false;
            }
            else
            {
                if (result2 == true)
                {
                    imgMundo.IsVisible = true;
                    imgSemLendo.IsVisible = false;
                }
            }
        }

        public async void mostrarFinalizadasEscuro()
        {
            var task1 = verificarFinalizada(UserLocalData.userUID, "NoEscuro", 5);
            bool result1 = await task1;

            var task2 = verificarLeituras(UserLocalData.userUID, "NoEscuro");
            bool result2 = await task2;

            if (result1 == true)
            {
                imgEscuroF.IsVisible = true;
                imgAguardando.IsVisible = false;
            }
            else
            {
                if (result2 == true)
                {
                    imgEscuro.IsVisible = true;
                    imgSemLendo.IsVisible = false;
                }
            }
        }

        public async void mostrarFinalizadasObscuros()
        {
            var task1 = verificarFinalizada(UserLocalData.userUID, "SegObscuros", 30);
            bool result1 = await task1;

            var task2 = verificarLeituras(UserLocalData.userUID, "SegObscuros");
            bool result2 = await task2;

            if (result1 == true)
            {
                imgObscurosF.IsVisible = true;
                imgSemFinalizadas.IsVisible = false;
            } else
            {

                if (result2 == true)
                {
                    imgObscuros.IsVisible = true;
                    imgSemLendo.IsVisible = false;
                }
            }
        }

        public async void mostrarFinalizadasDistantes()
        {
            var task1 = verificarFinalizada(UserLocalData.userUID, "SegDistantes", 8);
            bool result1 = await task1;

            var task2 = verificarLeituras(UserLocalData.userUID, "SegDistantes");
            bool result2 = await task2;

            if (result1 == true)
            {
                imgDistantesF.IsVisible = true;
                imgAguardando.IsVisible = false;
            }
            else
            {

                if (result2 == true)
                {
                    imgDistantes.IsVisible = true;
                    imgSemLendo.IsVisible = false;
                }
            }
        }

        public async void mostrarFinalizadasEstranha()
        {
            var task1 = verificarFinalizada(UserLocalData.userUID, "Estranha", 6);
            bool result1 = await task1;

            var task2 = verificarLeituras(UserLocalData.userUID, "Estranha");
            bool result2 = await task2;

            if (result1 == true)
            {
                imgEstranhaF.IsVisible = true;
                imgAguardando.IsVisible = false;
            }
            else
            {

                if (result2 == true)
                {
                    imgEstranha.IsVisible = true;
                    imgSemLendo.IsVisible = false;
                }
            }
        }

        public async void mostrarFinalizadasApenasDance()
        {
            var task1 = verificarFinalizada(UserLocalData.userUID, "ApenasDance", 2);
            bool result1 = await task1;

            var task2 = verificarLeituras(UserLocalData.userUID, "ApenasDance");
            bool result2 = await task2;

            if (result1 == true)
            {
                imgApenasDanceF.IsVisible = true;
                imgAguardando.IsVisible = false;
            }
            else
            {

                if (result2 == true)
                {
                    imgApenasDance.IsVisible = true;
                    imgSemLendo.IsVisible = false;
                }
            }
        }


        private async void imgLendo_Tapped(object sender, EventArgs e)
        {
            var loadingPage = new LoadingPopupPage();
            await Navigation.PushPopupAsync(loadingPage);
            await Task.Delay(5000);
            await Navigation.PushModalAsync(new PrincipalPage());
            await Navigation.RemovePopupPageAsync(loadingPage);
        }

        private async void imgMundo_Tapped(object sender, EventArgs e)
        {
            var loadingPage = new LoadingPopupPage();
            await Navigation.PushPopupAsync(loadingPage);
            await Task.Delay(5000);
            await Navigation.PushModalAsync(new EsseMundoView.EsseMundoDetailsPage());
            await Navigation.RemovePopupPageAsync(loadingPage);
        }

        private async void imgEscuro_Tapped(object sender, EventArgs e)
        {
            var loadingPage = new LoadingPopupPage();
            await Navigation.PushPopupAsync(loadingPage);
            await Task.Delay(5000);
            await Navigation.PushModalAsync(new NoEscuro.NoEscuroDetailsPage());
            await Navigation.RemovePopupPageAsync(loadingPage);
        }

        private async void imgAnjoMorte_Tapped(object sender, EventArgs e)
        {
            var loadingPage = new LoadingPopupPage();
            await Navigation.PushPopupAsync(loadingPage);
            await Task.Delay(5000);
            await Navigation.PushModalAsync(new AnjoMorteView.AnjoMorteDetaisPage());
            await Navigation.RemovePopupPageAsync(loadingPage);
        }

        private async void imgApenasDance_Tapped(object sender, EventArgs e)
        {
            var loadingPage = new LoadingPopupPage();
            await Navigation.PushPopupAsync(loadingPage);
            await Task.Delay(5000);
            await Navigation.PushModalAsync(new MenusView.MenuApenasDancePage());
            await Navigation.RemovePopupPageAsync(loadingPage);
        }

        private async void imgObscuros_Tapped(object sender, EventArgs e)
        {
            var loadingPage = new LoadingPopupPage();
            await Navigation.PushPopupAsync(loadingPage);
            await Task.Delay(5000);
            await Navigation.PushModalAsync(new SegredosObscurosView.SegredosObscurosDetailsPage());
            await Navigation.RemovePopupPageAsync(loadingPage);
        }

        private async void imgDistantes_Tapped(object sender, EventArgs e)
        {
            var loadingPage = new LoadingPopupPage();
            await Navigation.PushPopupAsync(loadingPage);
            await Task.Delay(5000);
            await Navigation.PushModalAsync(new SegredosDistantesView.SegredosDistantesDetailsPage());
            await Navigation.RemovePopupPageAsync(loadingPage);
        }

        private async void imgEstranha_Tapped(object sender, EventArgs e)
        {
            var loadingPage = new LoadingPopupPage();
            await Navigation.PushPopupAsync(loadingPage);
            await Task.Delay(5000);
            await Navigation.PushModalAsync(new MenusView.MenuEstranhaPage());
            await Navigation.RemovePopupPageAsync(loadingPage);
        }

        public async void clkGoAjuste(object sender, EventArgs e)
        {
            var loadingPage = new LoadingPopupPage();
            await Navigation.PushPopupAsync(loadingPage);
            await Task.Delay(2000);
            await Navigation.PushModalAsync(new ConfiguracoesPage());
            await Navigation.RemovePopupPageAsync(loadingPage);
        }

    }
}