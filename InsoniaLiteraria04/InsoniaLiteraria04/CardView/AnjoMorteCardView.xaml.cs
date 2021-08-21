using InsoniaLiteraria04.Database;
using InsoniaLiteraria04.Model;
using InsoniaLiteraria04.View;
using Rg.Plugins.Popup.Extensions;
using System;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InsoniaLiteraria04.CardView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnjoMorteCardView : Frame
    {
        DBFireComentarios dbComentarios;
        DBFireViews dbViews;

        public AnjoMorteCardView()
        {
            InitializeComponent();
            dbComentarios = new DBFireComentarios();
            dbViews = new DBFireViews();
            quantidadeMensagens();
            quantidadeView();
        }

        private void Card_Tapped(object sender, EventArgs e)
        {
            mostrarLoading();
        }

        public async void mostrarLoading()
        {
            var loadingPage = new LoadingPopupPage();
            await Navigation.PushPopupAsync(loadingPage);
            await Navigation.PushModalAsync(new AnjoMorteView.AnjoMorteDetaisPage());
            await Task.Delay(500);
            await Navigation.RemovePopupPageAsync(loadingPage);
        }

        public async void quantidadeMensagens()
        {
            int contagem = 0;


            lblContagem2.Text = contagem.ToString();

            try
            {
                var listAsync = await dbComentarios.mostrarQuantidadeComentariosTotal("AnjoMorte");


                if (listAsync != null)
                {
                    contagem = Convert.ToInt32(listAsync.Quantidade);
                  

                    lblContagem2.Text = contagem.ToString();
                }

            }
            catch (Exception ex)
            {
                lblContagem2.Text = contagem.ToString();
            }
        }

        public async void quantidadeView()
        {
            int contador = 0;

            lblContagem3.Text = contador.ToString();

            try
            {
                
                var listAsyncV = await dbViews.mostrarQuantidadeViewTotal("AnjoMorte");

                if (listAsyncV != null)
                {
                    contador = Convert.ToInt32(listAsyncV.Quantidade);
                }

                lblContagem3.Text = contador.ToString();
            }
            catch (Exception ex)
            {
                lblContagem3.Text = contador.ToString();
            }
        }

        
    }
}