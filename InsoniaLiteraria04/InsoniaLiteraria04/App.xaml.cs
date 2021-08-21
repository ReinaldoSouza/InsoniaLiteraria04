using Firebase.Xamarin.Auth;
using InsoniaLiteraria04.Database;
using InsoniaLiteraria04.Helper;
using InsoniaLiteraria04.View;
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

            DBFireConta service = new DBFireConta();

            if (!string.IsNullOrEmpty(UserLocalData.userToken))
            {
                MainPage = new InicioPage();
            }
            else
            {
                MainPage = new MainPage();
            }

        }

        protected override void OnStart()
        {
            
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
