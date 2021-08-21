using InsoniaLiteraria04.Database;
using InsoniaLiteraria04.Helper;
using InsoniaLiteraria04.Model;
using System;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InsoniaLiteraria04.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InsoniaPage : ContentPage
    {
        public InsoniaPage ()
        {
            InitializeComponent();

            verificarVersao();
        }

        public async Task verificarVersao()
        {
            var currentVersion = VersionTracking.CurrentVersion;

            if (currentVersion != null)
            {
                DBFireConta service = new DBFireConta();

                Versao_App versao = new Versao_App();

                versao.Id = UserLocalData.userUID;
                versao.Nome_Versao = currentVersion.ToString();
                versao.Username = UserLocalData.userEmail.Replace("@insonialiteraria.com", "");
                versao.Data_salvamento = DateTime.Now.ToString();

                var versao_app = currentVersion.Replace(".", "_").ToString();

                await service.salvarVersaoApp(versao, UserLocalData.userUID, versao_app);

                var listAsync = await service.mostrarVersao();

                string app = "";

                if (listAsync != null)
                {
                    app = listAsync.Valor.ToString();
                }

                if (currentVersion.ToString() != app)
                {
                    var action = await DisplayAlert("Nova Atualização", "Confira a nova atualização agora mesmo com capítulos novos e continue lendo com a gente.", "Ok", "Mais Tarde");

                    if (action)
                    {
                        var uri = new Uri("https://play.google.com/store/apps/details?id=com.reinaldosouza.InsoniaLiteraria04");
                        await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
                    }
                }
            } 
        }
    }
}