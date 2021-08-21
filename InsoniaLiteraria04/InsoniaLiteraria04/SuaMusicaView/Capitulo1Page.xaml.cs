﻿using InsoniaLiteraria04.Constantes;
using InsoniaLiteraria04.Control;
using InsoniaLiteraria04.Database;
using InsoniaLiteraria04.ComentariosView;
using InsoniaLiteraria04.Global;
using InsoniaLiteraria04.Helper;
using InsoniaLiteraria04.Model;
using InsoniaLiteraria04.View;
using Rg.Plugins.Popup.Extensions;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InsoniaLiteraria04.SuaMusicaView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Capitulo1Page : ContentPage
    {
        DBFireCapitulos serviceCapitulos;
        DBFireViews serviceViews;
        public int condicao;
        public Capitulo1Page(int numero)
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
                decimal capitulo = condicao;
                decimal total = Constantes.CapsConstantes.SuaMusica + 1;
                decimal porcentagem = Math.Ceiling(100 * capitulo / total);

                lblPorcentagem.Text = porcentagem.ToString() + "% LIDO";
            }
            else
            {
                lblPorcentagem.Text = "0% LIDO";
            }

            if (numero == CapsConstantes.SuaMusica)
            {
                btnCap.Text = "FIM";
            }
            salvarViews(numero);
            mostrarCapituloSalvo("SuaMusicaSalvou", "Capitulo" + numero.ToString());

            carregarHistoria(numero);
        }

        public async void carregarHistoria(int capitulo)
        {
            try
            {
                Historias listAsync = await serviceCapitulos.carregarCapitulo("REINALDO", "SUAMUSICA", "CAPITULO" + capitulo.ToString());
                lblTitulo.Text = listAsync.titulo;
                htmlPage.Html = listAsync.conteudo;
            } catch (Exception)
            {
                await DisplayAlert("Erro.", "Tivemos um problema em carregar o capítulo. Verifique sua conexão com a internet e tente novamente.", "OK");
            }

        }
        public void clkAbrirComentar(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ComentariosPage("SuaMusicaSalvou", condicao.ToString()));
        }

        async void clkAbrirProximo(object sender, EventArgs e)
        {
            var loadingPage = new LoadingPopupPage();
            await Navigation.PushPopupAsync(loadingPage);
            await Task.Delay(500);

            if (condicao + 1 > CapsConstantes.SuaMusica)
            {
                await DisplayAlert("CAPÍTULOS!", "VOCÊ CHEGOU NO ÚLTIMO CAPÍTULO. AGUARDE PARA MAIS CAPÍTULOS", "OK");
                await Navigation.PushModalAsync(new MenusView.MenuSuaMusicaPage());
            }
            else
            {
                await DependencyService.Get<IAdmobInterstitialAds>().Display(AppConstants.InterstitialAdId);
                
                await Navigation.PushModalAsync(new Capitulo1Page(condicao + 1));
            }

            await Navigation.RemovePopupPageAsync(loadingPage);
        }

        public void clkIrMenu(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MenusView.MenuSuaMusicaPage());
        }

        public void clkSalvar(object sender, EventArgs e)
        {
            try
            {
                if (chkCapitulo.IsChecked == true)
                {
                    LerCapitulo(condicao.ToString(), "true");

                    decimal capitulo = condicao + 1;
                    decimal total = Constantes.CapsConstantes.SuaMusica + 1;
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
                        decimal capitulo = condicao;
                        decimal total = Constantes.CapsConstantes.SuaMusica + 1;
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
                    Historia = "SuaMusicaSalvou"
                }, UserLocalData.userUID, "SuaMusicaSalvou", "Capitulo" + capitulo);
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
                var listAsync = await serviceViews.mostrarQuantidadeView("SuaMusicaSalvou", capitulo.ToString());

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
                }, "SuaMusicaSalvou", capitulo.ToString());

                var listAsyncTotal = await serviceViews.mostrarQuantidadeViewTotal("SuaMusicaSalvou");

                if (listAsyncTotal != null)
                {
                    var quantidadeTotal = Convert.ToInt32(listAsyncTotal.Quantidade.ToString());

                    await serviceViews.SomarViewsTotal(new QuantidadeViewsTotal()
                    {
                        Quantidade = quantidadeTotal + 1
                    }, "SuaMusicaSalvou");
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