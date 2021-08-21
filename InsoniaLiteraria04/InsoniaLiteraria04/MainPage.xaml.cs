using InsoniaLiteraria04.View;
using System;
using Xamarin.Forms;

namespace InsoniaLiteraria04
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();            

        }

        public void clkGoLogin(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new LoginPage());
        }

        public void clkGoCadastro(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new CadastroPage());
        }

        async void clkLinkTermosdeUso(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new TermosPage());
        }
    }
}
