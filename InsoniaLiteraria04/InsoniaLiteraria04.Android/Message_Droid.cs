using Android.Widget;
using InsoniaLiteraria04.Droid;
using InsoniaLiteraria04.Global;
using Xamarin.Forms;

[assembly: Dependency(typeof(Message_Droid))]
namespace InsoniaLiteraria04.Droid
{
    public class Message_Droid : IMessage
    {
        public void LongTime(string message)
        {
            Toast.MakeText(Android.App.Application.Context, message, ToastLength.Long).Show();
        }

        public void ShortTime(string message)
        {
            Toast.MakeText(Android.App.Application.Context, message, ToastLength.Short).Show();
        }

    }
}