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
	public partial class MenuSegredosObscurosPage : ContentPage
	{
        public MenuSegredosObscurosViewModel ViewModel;

        public MenuSegredosObscurosPage ()
		{
			InitializeComponent ();
            this.ViewModel = new MenuSegredosObscurosViewModel();
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
                } else if (codigo == 1)
                {
                    await Navigation.PushModalAsync(new SegredosObscurosView.Capitulo1Page(codigo));
                } else if (codigo == 2)
                {
                    await Navigation.PushModalAsync(new SegredosObscurosView.Capitulo1Page(codigo));
                } else if (codigo == 3)
                {
                    await Navigation.PushModalAsync(new SegredosObscurosView.Capitulo1Page(codigo));
                } else if (codigo == 4)
                {
                    await Navigation.PushModalAsync(new SegredosObscurosView.Capitulo1Page(codigo));
                } else if (codigo == 5)
                {
                    await Navigation.PushModalAsync(new SegredosObscurosView.Capitulo1Page(codigo));
                } else if (codigo == 6)
                {
                    await Navigation.PushModalAsync(new SegredosObscurosView.Capitulo2Page(codigo));
                } else if (codigo == 7)
                {
                    await Navigation.PushModalAsync(new SegredosObscurosView.Capitulo2Page(codigo));
                } else if (codigo == 8)
                {
                    await Navigation.PushModalAsync(new SegredosObscurosView.Capitulo2Page(codigo));
                } else if (codigo == 9)
                {
                    await Navigation.PushModalAsync(new SegredosObscurosView.Capitulo2Page(codigo));
                } else if (codigo == 10)
                {
                    await Navigation.PushModalAsync(new SegredosObscurosView.Capitulo2Page(codigo));
                } else if (codigo == 11)
                {
                    await Navigation.PushModalAsync(new SegredosObscurosView.Capitulo3Page(codigo));
                } else if (codigo == 12)
                {
                    await Navigation.PushModalAsync(new SegredosObscurosView.Capitulo3Page(codigo));
                } else if (codigo == 13)
                {
                    await Navigation.PushModalAsync(new SegredosObscurosView.Capitulo3Page(codigo));
                } else if (codigo == 14)
                {
                    await Navigation.PushModalAsync(new SegredosObscurosView.Capitulo3Page(codigo));
                } else if (codigo == 15)
                {
                    await Navigation.PushModalAsync(new SegredosObscurosView.Capitulo3Page(codigo));
                }
                else if (codigo == 16)
                {
                    await Navigation.PushModalAsync(new SegredosObscurosView.Capitulo4Page(codigo));
                }
                else if (codigo == 17)
                {
                    await Navigation.PushModalAsync(new SegredosObscurosView.Capitulo4Page(codigo));
                }
                else if (codigo == 18)
                {
                    await Navigation.PushModalAsync(new SegredosObscurosView.Capitulo4Page(codigo));
                }
                else if (codigo == 19)
                {
                    await Navigation.PushModalAsync(new SegredosObscurosView.Capitulo4Page(codigo));
                }
                else if (codigo == 20)
                {
                    await Navigation.PushModalAsync(new SegredosObscurosView.Capitulo4Page(codigo));
                }
                else if (codigo == 21)
                {
                    await Navigation.PushModalAsync(new SegredosObscurosView.Capitulo5Page(codigo));
                }
                else if (codigo == 22)
                {
                    await Navigation.PushModalAsync(new SegredosObscurosView.Capitulo5Page(codigo));
                }
                else if (codigo == 23)
                {
                    await Navigation.PushModalAsync(new SegredosObscurosView.Capitulo5Page(codigo));
                }
                else if (codigo == 24)
                {
                    await Navigation.PushModalAsync(new SegredosObscurosView.Capitulo5Page(codigo));
                }
                else if (codigo == 25)
                {
                    await Navigation.PushModalAsync(new SegredosObscurosView.Capitulo5Page(codigo));
                }
                else if (codigo == 26)
                {
                    await Navigation.PushModalAsync(new SegredosObscurosView.Capitulo6Page(codigo));
                }
                else if (codigo == 27)
                {
                    await Navigation.PushModalAsync(new SegredosObscurosView.Capitulo6Page(codigo));
                }
                else if (codigo == 28)
                {
                    await Navigation.PushModalAsync(new SegredosObscurosView.Capitulo6Page(codigo));
                }
                else if (codigo == 29)
                {
                    await Navigation.PushModalAsync(new SegredosObscurosView.Capitulo6Page(codigo));
                }
                else if (codigo == 30)
                {
                    await Navigation.PushModalAsync(new SegredosObscurosView.Capitulo6Page(codigo));
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