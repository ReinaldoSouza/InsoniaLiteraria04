using InsoniaLiteraria04.Constantes;
using InsoniaLiteraria04.Control;
using InsoniaLiteraria04.Database;
using InsoniaLiteraria04.Global;
using InsoniaLiteraria04.Helper;
using InsoniaLiteraria04.Model;
using InsoniaLiteraria04.View;
using InsoniaLiteraria04.ComentariosView;
using Rg.Plugins.Popup.Extensions;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InsoniaLiteraria04.EstranhaView
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EstranhaPage : ContentPage
	{
        DBFireCapitulos serviceCapitulos;
        DBFireViews serviceViews;
        public int condicao;

		public EstranhaPage (int numero)
		{
			InitializeComponent();
            AdmobControl admobControl = new AdmobControl()
            {
                AdUnitId = AppConstants.BannerId
            };
            serviceCapitulos = new DBFireCapitulos();
            serviceViews = new DBFireViews();
            condicao = numero;

            if (condicao != 0)
            {
                decimal capitulo = condicao - 1;
                decimal total = Constantes.CapsConstantes.Estranha;
                decimal porcentagem = Math.Ceiling(100 * capitulo / total);

                lblPorcentagem.Text = porcentagem.ToString() + "% LIDO";
            }
            else
            {
                lblPorcentagem.Text = "0% LIDO";
            }

            if (numero == CapsConstantes.Estranha)
            {
                btnCap.Text = "FIM";
            }
            salvarViews(numero);
            mostrarCapituloSalvo("Estranha", "Capitulo" + numero.ToString());

            carregarHistoria(numero);
        }

        public async void carregarHistoria(int capitulo)
        {
            try
            {
                var listAsync = await serviceCapitulos.carregarCapitulo("CAROLINA", "AESTRANHA", "CAPITULO" + capitulo.ToString());
                lblTitulo.Text = listAsync.titulo;
                htmlPage.Html = listAsync.conteudo;
            } catch (Exception)
            {
                await DisplayAlert("Erro.", "Tivemos um problema em carregar o capítulo. Verifique sua conexão com a internet e tente novamente.", "OK");
            }
        }

        public void clkAbrirComentar(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ComentariosPage("Estranha", condicao.ToString()));
        }

        public void clkIrMenu(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MenusView.MenuEstranhaPage());
        }

        async void clkAbrirProximo(object sender, EventArgs e)
        {
            var loadingPage = new LoadingPopupPage();
            await Navigation.PushPopupAsync(loadingPage);
            await Task.Delay(500);

            if (condicao + 1 > CapsConstantes.Estranha)
            {
                await DisplayAlert("CAPÍTULOS!", "VOCÊ CHEGOU NO ÚLTIMO CAPÍTULO. CONFIRA OUTRA HISTÓRIA", "OK");
                await Navigation.PushModalAsync(new MenusView.MenuEstranhaPage());
            }
            else
            {
                await DependencyService.Get<IAdmobInterstitialAds>().Display(AppConstants.InterstitialAdId);
                
                await Navigation.PushModalAsync(new EstranhaPage(condicao + 1));
            }

            await Navigation.RemovePopupPageAsync(loadingPage);
        }

        public void clkSalvar(object sender, EventArgs e)
        {
            try
            {

                if (chkCapitulo.IsChecked == true)
                {
                    LerCapitulo(condicao.ToString(), "true");

                    decimal capitulo = condicao;
                    decimal total = Constantes.CapsConstantes.Estranha;
                    decimal porcentagem = Math.Ceiling(100 * capitulo / total);

                    lblPorcentagem.Text = porcentagem.ToString() + "% LIDO";

                }
                else
                {
                    LerCapitulo(condicao.ToString(), "false");

                    if (condicao == 0)
                    {
                        lblPorcentagem.Text = "0% LIDO";
                    }
                    else
                    {
                        decimal capitulo = condicao - 1;
                        decimal total = Constantes.CapsConstantes.Estranha;
                        decimal porcentagem = Math.Ceiling(100 * capitulo / total);

                        lblPorcentagem.Text = porcentagem.ToString() + "% LIDO";
                    }

                }
            }
            catch (Exception)
            {
                DisplayAlert("ERRO!", "PROBLEMA EM SALVAR CAPÍTULO. TENTE NOVAMENTE", "OK");
            }
        }

        async void LerCapitulo(string capitulo, string status)
        {
            try
            {
                await serviceCapitulos.salvarCapitulo(new CapituloLido()
                {
                    Lido = status,
                    Capitulo = condicao,
                    Historia = "Estranha",
                    DataGravacao = DateTime.Now.ToString()
                }, UserLocalData.userUID, "Estranha", "Capitulo" + capitulo);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        async void salvarViews(int capitulo)
        {
            int quantidade = 0;
            try
            {
                var listAsync = await serviceViews.mostrarQuantidadeView("Estranha", capitulo.ToString());

                if (listAsync != null)
                {

                    quantidade = Convert.ToInt32(listAsync.Quantidade);
                }

                lblViews.Text = quantidade.ToString();

                await serviceViews.SomarViews(new QuantidadeViews()
                {
                    Quantidade = quantidade + 1,
                    Usuario = UserLocalData.userEmail.Replace("@insonialiteraria.com", ""),
                    UltimaData = DateTime.Now.ToString()
                }, "Estranha", capitulo.ToString());

                var listAsyncTotal = await serviceViews.mostrarQuantidadeViewTotal("Estranha");

                if (listAsyncTotal != null)
                {
                    var quantidadeTotal = Convert.ToInt32(listAsyncTotal.Quantidade.ToString());

                    await serviceViews.SomarViewsTotal(new QuantidadeViewsTotal()
                    {
                        Quantidade = quantidadeTotal + 1
                    }, "Estranha");
                }

            }
            catch (Exception)
            {
                lblViews.Text = quantidade.ToString();
            }

        }

        async void mostrarCapituloSalvo(string historia, string capitulo)
        {
            try
            {
                var listAsync = await serviceCapitulos.mostrarStatusCapitulo(historia, capitulo, UserLocalData.userUID);

                if (listAsync != null)
                {
                    if (listAsync.Lido.ToString() == "true")
                    {
                        chkCapitulo.IsChecked = true;
                    }
                    else
                    {
                        chkCapitulo.IsChecked = false;
                    }
                }
            }
            catch (Exception)
            {
                await DisplayAlert("ERRO!", "NÃO CONSEGUIMOS CARREGAR INFORMAÇÕES ADICIONAIS", "OK");
            }
        }

    }
}