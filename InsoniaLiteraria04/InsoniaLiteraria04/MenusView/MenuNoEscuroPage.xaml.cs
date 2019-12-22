using InsoniaLiteraria04.MenusViewModel;
using InsoniaLiteraria04.View;
using Rg.Plugins.Popup.Extensions;
using System;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InsoniaLiteraria04.MenusView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuNoEscuroPage : ContentPage
	{
        public MenuNoEscuroViewModel ViewModel;

		public MenuNoEscuroPage ()
		{
			InitializeComponent ();
            this.ViewModel = new MenuNoEscuroViewModel();
            this.BindingContext = this.ViewModel;
        }

        public async void IrParaCapitulo(object sender, EventArgs e)
        {
            try
            {
                var loadingPage = new LoadingPopupPage();
                await Navigation.PushPopupAsync(loadingPage);

                var codigo = ViewModel.MenuSelecionado.Codigo;

                if (codigo == -1)
                {
                    await Navigation.PushModalAsync(new PrincipalPage());
                }
                else if (codigo == 0)
                {
                    await Navigation.PushModalAsync(new NoEscuro.PrologoPage());
                }
                else if (codigo >= 1 && codigo <= 5)
                {
                    await Navigation.PushModalAsync(new NoEscuro.Capitulo1Page(codigo));
                }

                await Task.Delay(1000);
                await Navigation.RemovePopupPageAsync(loadingPage);
            }
            catch (Exception ex)
            {
                await DisplayAlert("erro", ex.Message, "ok");
            }
        }
    }
}