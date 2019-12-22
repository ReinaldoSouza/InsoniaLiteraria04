using InsoniaLiteraria04.MenusViewModel;
using InsoniaLiteraria04.View;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Rg.Plugins.Popup.Extensions;

namespace InsoniaLiteraria04.MenusView
{
    public partial class MenuEsseMundoPage : ContentPage
	{

        public MenuEsseMundoViewModel ViewModel;

        public MenuEsseMundoPage ()
		{
			InitializeComponent ();
            this.ViewModel = new MenuEsseMundoViewModel();
            this.BindingContext = this.ViewModel;
        }

        public async void IrParaCapitulo(object sender, EventArgs e)
        {
            try {
                var loadingPage = new LoadingPopupPage();
                await Navigation.PushPopupAsync(loadingPage);

                var codigo = ViewModel.MenuSelecionado.Codigo;

                if (codigo == -1)
                {
                    await Navigation.PushModalAsync(new PrincipalPage());
                } else if(codigo == 0)
                {
                    await Navigation.PushModalAsync(new EsseMundoView.IntroducaoPage());
                } //capitulo 1 - 6
                else if (codigo >= 1 && codigo <= 6)
                {
                    await Navigation.PushModalAsync(new EsseMundoView.Capitulo1Page(codigo));
                } //capítulo 7 - 12
                else if (codigo >= 7 && codigo <= 12)
                {
                    await Navigation.PushModalAsync(new EsseMundoView.Capitulo2Page(codigo));
                } //capitulo 13 - 18
                else if (codigo >= 13 && codigo <= 18)
                {
                    await Navigation.PushModalAsync(new EsseMundoView.Capitulo3Page(codigo));
                } // capitulo 19 - 24
                else if (codigo >= 19 && codigo <= 24)
                {
                    await Navigation.PushModalAsync(new EsseMundoView.Capitulo4Page(codigo));
                } // capitulo 25 - 30
                else if (codigo >= 25 && codigo <= 30)
                {
                    await Navigation.PushModalAsync(new EsseMundoView.Capitulo5Page(codigo));
                } // capitulo 31 - 36
                else if (codigo >= 31 && codigo <= 36)
                {
                    await Navigation.PushModalAsync(new EsseMundoView.Capitulo6Page(codigo));
                }   // capitulo 37 - 42
                else if (codigo >= 37 && codigo <= 42)
                {
                    await Navigation.PushModalAsync(new EsseMundoView.Capitulo7Page(codigo));
                }// capitulo 43 - 47
                else if (codigo >= 43 && codigo <= 47)
                {
                    await Navigation.PushModalAsync(new EsseMundoView.Capitulo8Page(codigo));
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