using InsoniaLiteraria04.Database;
using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Services;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Push;
using InsoniaLiteraria04.Model;
using InsoniaLiteraria04.Helper;

namespace InsoniaLiteraria04.View
{
    public partial class LoginPage : ContentPage
    {
        DBFire service;

        public LoginPage ()
		{
			InitializeComponent ();
            service = new DBFire();
        }

        async void clkGoPrincipal(object sender, EventArgs e)
        {
            await fazerLogin();
        }

        public async void clkGoCadastro(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new CadastroPage());
            
            
        }

        async Task fazerLogin()
        {
            var loadingPage = new LoadingPopupPage();
            await Navigation.PushPopupAsync(loadingPage);
            await Task.Delay(5000);
            try
            {
                await service.authUser(txtUsernameLogin.Text + "@insonialiteraria.com", txtSenhaLogin.Text);
                App.Current.MainPage = new PrincipalPage();
                await Navigation.RemovePopupPageAsync(loadingPage);

                #region Salvar o ID do App Center 
                salvarIdNtificacao();
                #endregion

            }
            catch (Exception ex)
            {
                txtUsernameLogin.Text = "";
                txtSenhaLogin.Text = "";
                await Navigation.RemovePopupPageAsync(loadingPage);
                await DisplayAlert("ERRO!", "SENHA OU USERNAME INVÁLIDO", "OK");
                Console.WriteLine("Erro (Login)", ex.Message);
            }
            

        }

        public void salvarIdNtificacao()
        {
            AppCenter.GetInstallIdAsync().ContinueWith(installId =>
            {
                Usuario_Notificacao notify = new Usuario_Notificacao();

                notify.Id = UserLocalData.userUID;
                notify.Id_Notificacao = installId.Result.ToString();
                notify.Username = UserLocalData.userEmail.Replace("@insonialiteraria.com", "");

                service.salvarIDNotificacao(notify, UserLocalData.userUID);

            });
        }

        //async void clkMudarSenha(object sender, EventArgs e)
        //{
        //    await MudarSenha();
        //}



        //async Task MudarSenha()
        //{
        //    await service.MudarSenha("reinaldo.s054@gmail.com");
        //}

    }
}