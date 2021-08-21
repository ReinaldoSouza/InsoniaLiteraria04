using Rg.Plugins.Popup.Extensions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InsoniaLiteraria04.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrincipalPage : TabbedPage
    {
        public PrincipalPage (int flagInicial)
        {
            InitializeComponent();
            if (flagInicial == 1)
            {
                carregarApresentacao();
            }
           
        }

        async void carregarApresentacao()
        {
            var apresentacoPage = new ApresentacaoPopupPage();
            await Navigation.PushPopupAsync(apresentacoPage);
        }
    }
}