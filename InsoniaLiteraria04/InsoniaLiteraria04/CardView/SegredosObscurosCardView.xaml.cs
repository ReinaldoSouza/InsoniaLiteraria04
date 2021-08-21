using InsoniaLiteraria04.View;
using System;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Extensions;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using InsoniaLiteraria04.Database;
using System.Linq;
using InsoniaLiteraria04.Model;

namespace InsoniaLiteraria04.CardView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SegredosObscurosCardView : Frame
	{
        DBFireViews dbViews;
        DBFireComentarios dbComentario;
        public SegredosObscurosCardView ()
		{
			InitializeComponent ();
            dbViews = new DBFireViews();
            dbComentario = new DBFireComentarios();
            quantidadeMensagens();
            quantidadeView();
        }

        private async void Card_Tapped(object sender, EventArgs e)
        {
            var loadingPage = new LoadingPopupPage();
            await Navigation.PushPopupAsync(loadingPage);
            await Navigation.PushModalAsync(new SegredosObscurosView.SegredosObscurosDetailsPage());
            await Task.Delay(500);
            await Navigation.RemovePopupPageAsync(loadingPage);
        }

        public async void quantidadeMensagens()
        {
            int contagem = 0;

            lblContagem2.Text = contagem.ToString();

            try
            {
                var listAsync = await dbComentario.mostrarQuantidadeComentariosTotal("SegObscuros");


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
            
                var listAsyncV = await dbViews.mostrarQuantidadeViewTotal("SegObscuros");

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