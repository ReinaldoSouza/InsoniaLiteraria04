﻿using InsoniaLiteraria04.View;
using System;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Extensions;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using InsoniaLiteraria04.Database;
using System.Linq;

namespace InsoniaLiteraria04.CardView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SegredosObscurosCardView : Frame
	{
        DBFire db;
        public SegredosObscurosCardView ()
		{
			InitializeComponent ();
            db = new DBFire();
            quantidadeMensagens();
            quantidadeLendo();
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            boxCardColor.HeightRequest = boxCardColor.Width / 16 * 9;
            imgCard.HeightRequest = imgCard.Width / 16 * 9;

        }

        private async void Card_Tapped(object sender, EventArgs e)
        {
            var loadingPage = new LoadingPopupPage();
            await Navigation.PushPopupAsync(loadingPage);
            await Navigation.PushModalAsync(new SegredosObscurosView.SegredosObscurosDetailsPage());
            await Task.Delay(5000);
            await Navigation.RemovePopupPageAsync(loadingPage);
        }

        public async void quantidadeMensagens()
        {
            int contagem = 0;

            lblContagem2.Text = contagem.ToString();

            try
            {
                var listAsync = await db.mostrarQuantidadeMensagem("SegObscuros");


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

        public async void quantidadeLendo()
        {
            int contagem = 0;

            lblContagem.Text = contagem.ToString();

            try
            {
                var listAsync = await db.mostrarQuantidadeLeituras("SegObscuros");


                if (listAsync != null)
                {
                    contagem = Convert.ToInt32(listAsync.Quantidade);


                    lblContagem.Text = contagem.ToString();
                }

            }
            catch (Exception ex)
            {
                lblContagem.Text = contagem.ToString();
            }
        }
    }
}