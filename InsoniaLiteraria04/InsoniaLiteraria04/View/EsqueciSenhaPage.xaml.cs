using InsoniaLiteraria04.Database;
using InsoniaLiteraria04.Model;
using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InsoniaLiteraria04.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EsqueciSenhaPage : ContentPage
    {
        public EsqueciSenhaPage()
        {
            InitializeComponent();
        }

        public async void clkGoLogin(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new LoginPage());
        }

        public async void clkEsqueciSenha(object sender, EventArgs e)
        {
            var db = new DBFireConta();
            string username = "xxx";

            var loadingPage = new LoadingPopupPage();
            await Navigation.PushPopupAsync(loadingPage);
            await Task.Delay(2000);

            try
            {

                if (txtUsernameCadastro.Text != null )
                {
                    if (txtUsernameCadastro.Text.Trim() != "")
                    {
                        username = txtUsernameCadastro.Text;
                    }
                }

                if (txtEmailCadastro.Text != null || txtNomeCadastro.Text != null)
                {
                    if (txtEmailCadastro.Text.Trim() != "" || txtNomeCadastro.Text.Trim() != "")
                    {

                        await db.resetarSenha(new Informacoes_Senha()
                        {
                            Nome = txtNomeCadastro.Text.Trim(),
                            Email = txtEmailCadastro.Text.Trim(),
                            Username = username.ToString(),
                            Data = DateTime.Now.ToString()

                        });
                        await DisplayAlert("Recuperação de Senha", "Verifique seu e-mail. Em instantes, enviaremos a você um mensagem de verificação de conta. Aguarde.", "OK");
                        await Navigation.PushModalAsync(new LoginPage());
                        await Navigation.RemovePopupPageAsync(loadingPage);
                    }
                    else
                    {
                        throw new Exception("Digite seu e-mail e seu nome por favor. Assim entraremos em contato com você para recuperação de sua senha.");

                    }
                } else
                {
                    throw new Exception("Digite seu e-mail e seu nome por favor. Assim entraremos em contato com você para recuperação de sua senha.");
                }

                


            } catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
                txtEmailCadastro.Text = "";
                txtNomeCadastro.Text = "";
                txtUsernameCadastro.Text = "";
                await Navigation.RemovePopupPageAsync(loadingPage);
            }
        }
    }
}