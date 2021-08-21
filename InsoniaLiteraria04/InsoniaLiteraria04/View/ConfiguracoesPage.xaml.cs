using InsoniaLiteraria04.Database;
using InsoniaLiteraria04.Helper;
using InsoniaLiteraria04.Model;
using Plugin.Media;
using Plugin.Media.Abstractions;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InsoniaLiteraria04.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConfiguracoesPage : ContentPage
    {

        DBFireUsuario serviceUsuario;
        DBFireConta db;
        MediaFile file;

        public ConfiguracoesPage()
        {
            InitializeComponent();
            db = new DBFireConta();
            serviceUsuario = new DBFireUsuario();
            carregarUsuario();
        }


        async void carregarUsuario()
        {
            image_profile.Source = "capaprofile.jpg";
            lblUsername.Text = UserLocalData.userEmail.Replace("@insonialiteraria.com", "").ToUpper();
            lblVersao.Text = VersionTracking.CurrentVersion;
            lblNomeUsuario.Text = "NOME";
            lblEmail.Text = "email@email.com.br";

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
                    lblNomeUsuario.Text = listAsyncDados.Nome.ToUpper();
                    lblEmail.Text = listAsyncDados.Email.ToLower();
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("ERRO", "SEUS DADOS NÃO FORAM CARREGADOS CORRETAMENTE. VERIFIQUE A CONEXÃO COM A INTERNET!", "OK");
                image_profile.Source = "capaprofile.jpg";
                lblNomeUsuario.Text = "NOME";
                lblUsername.Text = "USERNAME";
                lblVersao.Text = "0.0";
                lblEmail.Text = "email@email.com.br";
            }
        }

        public async void ClkPegueFotoGaleria(object sender, EventArgs e)
        {
            var status = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Photos);
            if (status != Plugin.Permissions.Abstractions.PermissionStatus.Granted)
            {
                var results = await CrossPermissions.Current.RequestPermissionsAsync(Permission.Photos);

                if (results.ContainsKey(Permission.Photos))
                    status = results[Permission.Photos];
            }

            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                await DisplayAlert("Erro", "Sem Permissão Galeria", "OK");
                return;
            }

            try
            {
                file = await CrossMedia.Current.PickPhotoAsync();
                if (file == null)
                {
                    return;
                }

                image_profile.Source = ImageSource.FromStream(() =>
                {
                    var imageStram = file.GetStream();
                    return imageStram;
                });

                await serviceUsuario.SalvarImagem(file.GetStream(), "imagem_perfil.jpg");

            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "OK");
            }
        }

        async void clkSair(object sender, EventArgs e)
        {
            var action = await DisplayAlert("Insônia Literária", "Deseja mesmo sair da sua conta?", "Sim", "Não");
            if (action)
            {
                UserLocalData.removeDataAll();
                await Navigation.PushModalAsync(new MainPage());
            }
            
        }

        async void clkExcluir(object sender, EventArgs e)
        {
            var action = await DisplayAlert("Insônia Literária", "Se sua conta for excluída, todos os seus dados e progressos de leitura serão excluídos. Certeza de deseja excluir a sua conta?", "Sim", "Não");
            if (action)
            {
                await db.excluirConta(new ExcluirConta() 
                                        { Usuario_id = UserLocalData.userUID,
                                        Excluir = "SIM"
                                        });
                UserLocalData.removeDataAll();
                await Navigation.PushModalAsync(new MainPage());
            }
        }

        async void clkFechar(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new PrincipalPage(0));
        }

        async void clkAlterarNome(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new AlteracaoPage(1));
        }

        async void clkAlterarEmail(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new AlteracaoPage(2));
        }

        async void clkLinkTermosdeUso(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new TermosPage());
        }

        async void imgInstagram_Tapped(object sender, EventArgs e)
        {
            var uri = new Uri("https://www.instagram.com/insonialiterariia/?hl=pt-br");
            await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
    }
}