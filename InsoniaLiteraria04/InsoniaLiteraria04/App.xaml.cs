using Firebase.Xamarin.Auth;
using InsoniaLiteraria04.Database;
using InsoniaLiteraria04.Global;
using InsoniaLiteraria04.Helper;
using InsoniaLiteraria04.Model;
using InsoniaLiteraria04.View;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Push;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace InsoniaLiteraria04
{
    public partial class App : Application
    {
        const string CONFIG_KEY = "AIzaSyA_1DIKQWRzxIR_irLqGL6lduZPu5Fwobk";
        public static FirebaseAuthProvider firebaseAuthProvider = new FirebaseAuthProvider(new FirebaseConfig(CONFIG_KEY));

        public App()
        {
            InitializeComponent();

            DBFire service = new DBFire();

            if (!string.IsNullOrEmpty(UserLocalData.userToken))
            {
                MainPage = new PrincipalPage();

                AppCenter.Start("android=5688ae49-6c8c-4c4b-88ea-11a199ed571b", typeof(Push));

                AppCenter.GetInstallIdAsync().ContinueWith(installId =>
                {
                    Usuario_Notificacao notify = new Usuario_Notificacao();

                    notify.Id = UserLocalData.userUID;
                    notify.Id_Notificacao = installId.Result.ToString();
                    notify.Username = UserLocalData.userEmail.Replace("@insonialiteraria.com", "");

                    service.salvarIDNotificacao(notify, UserLocalData.userUID);

                });
            }
            else
            {
                MainPage = new MainPage();
            }

        }

        protected override void OnStart()
        {
            #region Handle PushNotificationReceived Event
            if (!AppCenter.Configured)
            {
                Push.PushNotificationReceived += OnPushNotificationRecieved;
            }
            #endregion

            #region Startar o serviço de push
            AppCenter.Start("android=5688ae49-6c8c-4c4b-88ea-11a199ed571b", typeof(Push));

            #endregion
        }

        private void OnPushNotificationRecieved(object sender, PushNotificationReceivedEventArgs e)
        {

            Xamarin.Forms.Device.BeginInvokeOnMainThread(() =>
            {
                //DependencyService.Get<IMessage>().ShortTime(e.Message);
                //Current.MainPage.DisplayAlert(e.Title, e.Message, "OK");
            });
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
