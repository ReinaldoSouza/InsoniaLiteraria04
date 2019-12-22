using InsoniaLiteraria04.Database;
using InsoniaLiteraria04.Helper;
using Plugin.Media;
using Plugin.Media.Abstractions;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
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
    public partial class ConfiguracoesPage : ContentPage
    {

        DBFire db;
        MediaFile file;
        private object lblNome;

        public ConfiguracoesPage()
        {
            InitializeComponent();
            image_profile.Source = "capaprofile.jpg";
            db = new DBFire();
            carregarUsuario();
        }

        async void carregarUsuario()
        {
            try
            {
                var listAsync = await db.mostrarUsuarioNome();
                lblNomeUsuario.Text = listAsync.ToUpper();

                var listAsync1 = await db.mostrarUsuarioEmail();
                lblEmail.Text = listAsync1.ToLower();

                var listAsync2 = await db.mostrarUsuarioUsername();
                lblUsername.Text = listAsync2.ToUpper();

                var listAsync3 = await db.mostrarFotoPerfil();

                if (listAsync3 != null)
                {
                    image_profile.Source = listAsync3.ImageUrl.ToString();
                }
                else
                {
                    image_profile.Source = "capaprofile.jpg";
                }

            }
            catch (Exception ex)
            {
                await DisplayAlert("ERRO", "SEUS DADOS NÃO FORAM CARREGADOS. VERIFIQUE A CONEXÃO COM A INTERNET!", "OK");
                image_profile.Source = "capaprofile.jpg";
                lblNomeUsuario.Text = "NOME";
                lblUsername.Text = "USERNAME";
                lblEmail.Text = "email@email.com.br";
            }
        }

        public async void ClkPegueFotoGaleria(object sender, EventArgs e)
        {
            var status = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Photos);
            if (status != PermissionStatus.Granted)
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

                await db.SalvarImagem(file.GetStream(), "imagem_perfil.jpg");

            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "OK");
            }
        }

        public void clkSair(object sender, EventArgs e)
        {
            UserLocalData.removeDataAll();
            Navigation.PushModalAsync(new MainPage());
        }

        async void clkFechar(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}