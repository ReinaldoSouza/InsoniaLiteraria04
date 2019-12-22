using Android.App;
using Android.OS;

namespace InsoniaLiteraria04.Droid
{

    [Activity(Theme = "@style/Theme.Splash",
             MainLauncher = true,
             NoHistory = true,
             Icon = "@drawable/iconeApp")]

    public class SplashActivity : Activity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            System.Threading.Thread.Sleep(500);
            StartActivity(typeof(MainActivity));
        }
    }
}