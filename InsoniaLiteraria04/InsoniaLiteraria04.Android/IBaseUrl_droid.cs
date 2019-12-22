using InsoniaLiteraria04.Droid;
using InsoniaLiteraria04.Global;
using Xamarin.Forms;

[assembly: Dependency(typeof(IBaseUrl_droid))]

namespace InsoniaLiteraria04.Droid
{
    public class IBaseUrl_droid : IBaseUrl
    {
        public string Get()
        {
            return "file:///android_asset/";
        }
    }
}