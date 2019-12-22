using InsoniaLiteraria04.Database;
using InsoniaLiteraria04.Helper;
using InsoniaLiteraria04.Model;
using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InsoniaLiteraria04.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CadastroPage : ContentPage
	{
        PopupPage loadingPage = new LoadingPopupPage();
        public CadastroPage ()
		{
			InitializeComponent ();
        }

        async void clkCriarConta(object sender, EventArgs e)
        {
            await Navigation.PushPopupAsync(loadingPage);
            await Task.Delay(5000);

            try
            {
                if (txtNomeCadastro.Text == null || txtEmailCadastro.Text == null || txtUsernameCadastro.Text == null || txtSenhaCadastro.Text == null)
                {
                    throw new Exception("PREENCHA OS CAMPOS OBRIGATÓRIOS");
                };

                if (txtSenhaCadastro.Text.Length < 6)
                {
                    throw new Exception("SENHA NÃO É FORTE O SUFICIENTE. VERIFIQUE SE ELA TEM MAIS DE 6 CARACTERES");
                };


                criarCadastro();

            }
            catch (Exception ex)
            {
                await Navigation.RemovePopupPageAsync(loadingPage);
                await DisplayAlert("ERRO", ex.Message, "OK");
            }
            
        }

        async void criarCadastro()
        {
            var db = new DBFire();

            await db.createUser(txtUsernameCadastro.Text + "@insonialiteraria.com", txtSenhaCadastro.Text);

            await db.criarConta(UserLocalData.userUID, new Usuario()
            {
                Nome = txtNomeCadastro.Text,
                Email = txtEmailCadastro.Text,
                Username = txtUsernameCadastro.Text,
                Password = txtSenhaCadastro.Text
            });
            await DisplayAlert("PARABÉNS!", "SUA CONTA FOI CRIADA", "OK");
            await Navigation.PushModalAsync(new LoginPage());
            await Navigation.RemovePopupPageAsync(loadingPage);

        }

        public async void clkGoLogin(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new LoginPage());
        }
    }
}