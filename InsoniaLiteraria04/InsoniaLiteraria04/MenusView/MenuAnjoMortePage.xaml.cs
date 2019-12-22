using InsoniaLiteraria04.AnjoMorteView;
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
	public partial class MenuAnjoMortePage : ContentPage
	{
        public MenuAnjoMorteViewModel ViewModel;

        public MenuAnjoMortePage ()
		{
			InitializeComponent ();
            this.ViewModel = new MenuAnjoMorteViewModel();
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
                    await Navigation.PushModalAsync(new Capitulo1Page(codigo));
                }
                else if (codigo == 1)
                {
                    await Navigation.PushModalAsync(new Capitulo1Page(codigo));
                }
                else if (codigo == 2)
                {
                    await Navigation.PushModalAsync(new Capitulo1Page(codigo));
                }
                else if (codigo == 3)
                {
                    await Navigation.PushModalAsync(new Capitulo1Page(codigo));
                }
                else if (codigo == 4)
                {
                    await Navigation.PushModalAsync(new Capitulo1Page(codigo));
                }
                else if (codigo == 5)
                {
                    await Navigation.PushModalAsync(new Capitulo1Page(codigo));
                }
                else if (codigo == 6)
                {
                    await Navigation.PushModalAsync(new Capitulo1Page(codigo));
                }
                else if (codigo == 7)
                {
                    await Navigation.PushModalAsync(new Capitulo2Page(codigo));
                }
                else if (codigo == 8)
                {
                    await Navigation.PushModalAsync(new Capitulo2Page(codigo));
                }
                else if (codigo == 9)
                {
                    await Navigation.PushModalAsync(new Capitulo2Page(codigo));
                }
                else if (codigo == 10)
                {
                    await Navigation.PushModalAsync(new Capitulo2Page(codigo));
                }
                else if (codigo == 11)
                {
                    await Navigation.PushModalAsync(new Capitulo2Page(codigo));
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