using InsoniaLiteraria04.Database;
using InsoniaLiteraria04.Helper;
using InsoniaLiteraria04.Model;
using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InsoniaLiteraria04.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CadastroPage : ContentPage
	{
        DBFireConta db;
        DBFireUsuario dbUsuario;
        PopupPage loadingPage = new LoadingPopupPage();
        ObservableCollection<Usuario> ListaUsuarios = new ObservableCollection<Usuario>();
        public CadastroPage()
		{
			InitializeComponent ();
            db = new DBFireConta();
            dbUsuario = new DBFireUsuario();
        }

        async void clkCriarConta(object sender, EventArgs e)
        {

            await Navigation.PushPopupAsync(loadingPage);
            await Task.Delay(5000);

            try
            {

                ListaUsuarios.Clear();
                UserLocalData.removeDataAll();

                if (txtNomeCadastro.Text == null || txtEmailCadastro.Text == null || txtUsernameCadastro.Text == null || txtSenhaCadastro.Text == null)
                {
                    throw new Exception("Preencha os campos obrigatórios.");
                } else
                {
                    if (txtNomeCadastro.Text.Trim() == "" || txtEmailCadastro.Text.Trim() == "" || txtUsernameCadastro.Text.Trim() == "" || txtSenhaCadastro.Text.Trim() == "")
                    {
                        throw new Exception("Preencha os campos obrigatórios.");
                    }
                }

                if (txtSenhaCadastro.Text.Trim().Length < 6)
                {
                    txtSenhaCadastro.Text = "";
                    throw new Exception("Sua senha não é forte o suficiente. Por favor, insira mais de 6 caracteres.");
                };

                var listAsyncUsuarios = await dbUsuario.mostrarUsuariosCadastrados();

                var lista = listAsyncUsuarios.ToList();

                var lista2 = from usuario in lista
                             where usuario.Email == txtEmailCadastro.Text.Trim().ToLower()
                             select usuario;

                foreach (var item in lista2)
                {
                    ListaUsuarios.Add(item);
                }

                if (ListaUsuarios != null)
                {
                    if (ListaUsuarios.Count > 0)
                    {
                        txtEmailCadastro.Text = "";
                        throw new Exception("O E-Mail indicado já está cadastrado em nosso banco de dados. Cadastre um E-Mail Direfente ou solicite sua senha na tela de Login.");
                    }
                }

                await db.createUser(txtUsernameCadastro.Text.Trim() + "@insonialiteraria.com", txtSenhaCadastro.Text.Trim());

                await db.criarConta(UserLocalData.userUID, new Usuario()
                {
                    Nome = txtNomeCadastro.Text,
                    Email = txtEmailCadastro.Text.ToLower(),
                    Username = txtUsernameCadastro.Text,
                    Password = txtSenhaCadastro.Text,
                    Data_cadastro = DateTime.Now.ToString()
                });
                await DisplayAlert("Parabéns!", "Sua Conta Foi Criada!", "OK");
                await Navigation.PushModalAsync(new PrincipalPage(1));
                await Navigation.RemovePopupPageAsync(loadingPage);

            }
            catch (Exception ex)
            {
                await Navigation.RemovePopupPageAsync(loadingPage);
                await DisplayAlert("Erro", ex.Message, "OK");
            }
            
        }

    }
}