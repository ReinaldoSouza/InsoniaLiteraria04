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
	public partial class MenuEstranhaPage : ContentPage
	{
        public MenuEstranhaViewModel ViewModel;

		public MenuEstranhaPage ()
		{
			InitializeComponent ();
            this.ViewModel = new MenuEstranhaViewModel();
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
                else if (codigo == 1)
                {
                    await Navigation.PushModalAsync(new EstranhaView.EstranhaPage(codigo));
                }
                else if (codigo == 2)
                {
                    await Navigation.PushModalAsync(new EstranhaView.EstranhaPage(codigo));
                }
                else if (codigo == 3)
                {
                    await Navigation.PushModalAsync(new EstranhaView.EstranhaPage(codigo));
                }
                else if (codigo == 4)
                {
                    await Navigation.PushModalAsync(new EstranhaView.EstranhaPage(codigo));
                }
                else if (codigo == 5)
                {
                    await Navigation.PushModalAsync(new EstranhaView.EstranhaPage(codigo));
                }
                else if (codigo == 6)
                {
                    await Navigation.PushModalAsync(new EstranhaView.EstranhaPage(codigo));
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