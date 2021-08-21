using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using System;
using Xamarin.Essentials;
using Xamarin.Forms.Xaml;

namespace InsoniaLiteraria04.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ApresentacaoPopupPage : PopupPage
    {
        public ApresentacaoPopupPage()
        {
            InitializeComponent();
        }

        async void clkIniciar(object sender, EventArgs e)
        {
            await Navigation.PopPopupAsync();
        }

        async void imgInstagram_Tapped(object sender, EventArgs e)
        {
                var uri = new Uri("https://www.instagram.com/insonialiterariia/?hl=pt-br");
                await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);

            
        }
    }
}