using InsoniaLiteraria04.Database;
using InsoniaLiteraria04.Model;
using InsoniaLiteraria04.View;
using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InsoniaLiteraria04.CardView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AscencaoSoberCardView : Frame
    {
        DBFireViews dbViews;
        DBFireComentarios dbComentario;
        public AscencaoSoberCardView()
        {
            InitializeComponent();
            dbComentario = new DBFireComentarios();
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
            await Navigation.PushModalAsync(new AscencaoSoberView.AnscensaoSoberDetailsPage());
            await Task.Delay(500);
            await Navigation.RemovePopupPageAsync(loadingPage);
        }

        public async void quantidadeMensagens()
        {
            int contagem = 0;

            lblContagem2.Text = contagem.ToString();

            try
            {
                var listAsync = await dbComentario.mostrarQuantidadeComentariosTotal("AscensaoSober");

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
               
                var listAsyncV = await dbViews.mostrarQuantidadeViewTotal("AscensaoSober");

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