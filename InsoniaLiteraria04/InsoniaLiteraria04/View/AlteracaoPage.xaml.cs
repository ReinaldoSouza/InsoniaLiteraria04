using InsoniaLiteraria04.Database;
using InsoniaLiteraria04.Helper;
using Rg.Plugins.Popup.Extensions;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InsoniaLiteraria04.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlteracaoPage : ContentPage
    {
        DBFireUsuario serviceUsuario;
        int condicao;

        public AlteracaoPage(int numero)
        {
            InitializeComponent();
            condicao = numero;
            serviceUsuario = new DBFireUsuario();

                if (condicao == 1)
                {
                    lblCabecalho.Text = "Seu nome é muito importante para a sua identificação. Altere para o nome correto.";
                }
                else
                {
                    lblCabecalho.Text = "Seu e-mail está salvo no nosso banco de dados para o caso de precisarmos entrar em contato com você eventualmente. Por favor, verifique se seu e-mail está correto.";
                }

                TrazerInformacoes();
        }

        async void TrazerInformacoes()
        {
            try
            {
                var listAsyncDados = await serviceUsuario.coletarDadosUsuario(UserLocalData.userUID);

                if (condicao == 1)
                {
                    if (listAsyncDados != null)
                    {
                        txtInformacoes.Text = listAsyncDados.Nome;
                    }
                }
                else
                {
                    if (listAsyncDados != null)
                    {
                        txtInformacoes.Text = listAsyncDados.Email.ToLower();
                    }
                }
            } catch (Exception ex)
            {
                txtInformacoes.Text = "";
            } 
        }

        async void clkAlterar(object sender, EventArgs e)
        {
            var loadingPage = new LoadingPopupPage();
            await Navigation.PushPopupAsync(loadingPage);
            await Task.Delay(2000);

            try
            {
                var listAsyncDados = await serviceUsuario.coletarDadosUsuario(UserLocalData.userUID);

                if (condicao == 1)
                {
                    await serviceUsuario.AlterarPerfil(UserLocalData.userUID, new Model.Usuario()
                    {
                        Nome = txtInformacoes.Text,
                        Username = UserLocalData.userEmail.Replace("@insonialiteraria.com", "").ToString(),
                        Password = listAsyncDados.Password,
                        Email = listAsyncDados.Email.ToLower(),
                        Data_cadastro = listAsyncDados.Data_cadastro
                    });
                }
                else
                {
                    await serviceUsuario.AlterarPerfil(UserLocalData.userUID, new Model.Usuario()
                    {
                        Nome = listAsyncDados.Nome,
                        Username = UserLocalData.userEmail.Replace("@insonialiteraria.com", "").ToString(),
                        Password = listAsyncDados.Password,
                        Email = txtInformacoes.Text,
                        Data_cadastro = listAsyncDados.Data_cadastro
                    });
                }

                await DisplayAlert("Insônia Literária", "Alteração feita com sucesso.", "OK");
                await Navigation.PushModalAsync(new ConfiguracoesPage());
                await Navigation.RemovePopupPageAsync(loadingPage);

            } catch (Exception ex)
            {
                await DisplayAlert("Erro", "Ocorreu um erro na sua alteração. Verifique sua internet e tente novamente", "Ok");
                await Navigation.RemovePopupPageAsync(loadingPage);
            }
        }
        async void clkFechar(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ConfiguracoesPage());
            
        }
    }
}