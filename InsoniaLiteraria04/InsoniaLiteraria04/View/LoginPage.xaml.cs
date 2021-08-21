using InsoniaLiteraria04.Database;
using InsoniaLiteraria04.Helper;
using InsoniaLiteraria04.Model;
using Rg.Plugins.Popup.Extensions;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace InsoniaLiteraria04.View
{
    public partial class LoginPage : ContentPage
    {
        DBFireConta service;

        public LoginPage()
		{
			InitializeComponent();
            service = new DBFireConta();
        }

        async void clkGoPrincipal(object sender, EventArgs e)
        {
            await fazerLogin();
        }

        public async void clkGoEsqueciSenha(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new EsqueciSenhaPage());
        }

        async Task fazerLogin()
        {

            var loadingPage = new LoadingPopupPage();
            await Navigation.PushPopupAsync(loadingPage);
            await Task.Delay(3000);
            try
            {
                UserLocalData.removeDataAll();
                await service.authUser(txtUsernameLogin.Text.Trim() + "@insonialiteraria.com", txtSenhaLogin.Text.Trim());
                App.Current.MainPage = new PrincipalPage(0);
                await Navigation.RemovePopupPageAsync(loadingPage);

            }
            catch (Exception ex)
            {
                await Navigation.RemovePopupPageAsync(loadingPage);
                await DisplayAlert("Erro!", "Username ou Senha inválidos. Favor tente novamente.", "OK");
            }


        }

        
        

    }
}