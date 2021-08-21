using InsoniaLiteraria04.Constantes;
using InsoniaLiteraria04.Control;
using InsoniaLiteraria04.Database;
using InsoniaLiteraria04.Global;
using InsoniaLiteraria04.Helper;
using InsoniaLiteraria04.Model;
using InsoniaLiteraria04.View;
using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace InsoniaLiteraria04.ComentariosView
{
    public partial class ComentariosPage : ContentPage
    {
        DBFireComentarios serviceComentario;
        DBFireUsuario serviceUsuario;
        string historia1;
        string capitulo1;
        ObservableCollection<Comentarios> list = new ObservableCollection<Comentarios>();

        public ComentariosPage(string historia, string capitulo)
        {
            InitializeComponent();
            AdmobControl admobControl = new AdmobControl()
            {
                AdUnitId = AppConstants.BannerId
            };
            serviceComentario = new DBFireComentarios();
            serviceUsuario = new DBFireUsuario();
            _list.BindingContext = list;
            carregarComentarios(historia, capitulo);
            capitulo1 = capitulo;
            historia1 = historia;

        }

        async void carregarComentarios(string historia, string capitulo)
        {
            lblMensagem.IsVisible = false;

            list.Clear();

            try
            {
                ldlCarregar.IsRunning = true;
                ldlCarregar.IsVisible = true;

                var listAsync = await serviceComentario.mostrarComentarios(historia, capitulo);

                var lista1 = listAsync.ToList();

                lista1 = (from c in lista1
                          orderby c.Data descending
                          select c).ToList();

                if (list != null)
                {
                    foreach (var item in lista1)
                    {
                        if (item.Usuario_id == UserLocalData.userUID)
                        {
                            item.Excluir = true;
                        }
                        else
                        {
                            item.Excluir = false;
                        }

                        var listAsync3 = await serviceUsuario.mostrarFotoPerfil(item.Usuario_id);

                        if (listAsync3 != null)
                        {
                            item.Imagem = listAsync3.ImageUrl.ToString();
                        }
                        else
                        {
                            item.Imagem = "capaprofile.jpg";
                        }

                        item.Respostas = "VER RESPOSTAS (" + isNull(item.Respostas, "0") + ")";

                        list.Add(item);
                    }

                    if (list.Count > 0)
                    {
                        ldlCarregar.IsRunning = false;
                        ldlCarregar.IsVisible = false;
                        lblMensagem.IsVisible = false;
                    }
                    else
                    {
                        ldlCarregar.IsRunning = false;
                        ldlCarregar.IsVisible = false;
                        lblMensagem.IsVisible = true;
                    }

                }
                else
                {
                    ldlCarregar.IsRunning = false;
                    ldlCarregar.IsVisible = false;
                    lblMensagem.IsVisible = true;
                }
            }
            catch (Exception ex)
            {
                lblMensagem.IsVisible = true;
                list.Clear();
                ldlCarregar.IsRunning = false;
                ldlCarregar.IsVisible = false;
                await DisplayAlert("AVISO!", "OS COMENTÁRIOS NÃO FORAM CARREGADOS! VERIFIQUE SUA CONEXÃO COM A INTERNET", "OK");
            }

        }

        public void clkComentar(object sender, EventArgs e)
        {
            if (txtComentar.Text != null)
            {
                if (txtComentar.Text.Trim() != "")
                {
                    Comentar(historia1, capitulo1);
                }
            }
        }

        async void Comentar(string historia, string capitulo)
        {
            var loadingPage = new LoadingPopupPage();
            await Navigation.PushPopupAsync(loadingPage);

            try
            {
                await DependencyService.Get<IAdmobInterstitialAds>().Display(AppConstants.InterstitialAdId);

                await serviceComentario.comentar(new Comentarios()
                {
                    Id = DateTime.Now.ToString("ddMMyyyyHHmmss") + historia + capitulo + UserLocalData.userUID,
                    Usuario_id = UserLocalData.userUID,
                    Usuario = UserLocalData.userEmail.Replace("@insonialiteraria.com", ""),
                    Mensagem = txtComentar.Text,
                    Data = DateTime.Now.ToString("dd/MM/yyyy H:mm"),
                    Respostas = "0"
                }, historia, capitulo);
                txtComentar.Text = "";

                var listAsyncTotal = await serviceComentario.mostrarQuantidadeComentariosTotal(historia);

                if (listAsyncTotal != null)
                {
                    var contagemTotal = Convert.ToInt32(listAsyncTotal.Quantidade);

                    await serviceComentario.SomarComentariosTotal(new QuantidadeComentarioTotal()
                    {
                        Quantidade = contagemTotal + 1
                    }, historia);
                } else
                {
                    await serviceComentario.SomarComentariosTotal(new QuantidadeComentarioTotal()
                    {
                        Quantidade = 1
                    }, historia);
                }

                var listAsyncCap = await serviceComentario.mostrarQuantidadeComentarios(historia, capitulo);

                if (listAsyncCap != null){
                    var contagemCapitulo = Convert.ToInt32(listAsyncCap.Quantidade);

                    await serviceComentario.SomarComentarios(new QuantidadeComentario()
                    {
                        Quantidade = contagemCapitulo + 1
                    }, historia, capitulo);
                }

                carregarComentarios(historia, capitulo);
                await Task.Delay(1000);
                await Navigation.RemovePopupPageAsync(loadingPage);
            }
            catch (Exception ex)
            {
                await DisplayAlert("ERRO!", "NÃO FOI POSSÍVEL COMENTAR", "OK");
                await Navigation.RemovePopupPageAsync(loadingPage);
            }
        }

        async void clkFechar(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        async void clkRespostas(object sender, EventArgs e)
        {
            var loadingPage = new LoadingPopupPage();
            await Navigation.PushPopupAsync(loadingPage);

            try
            {
                Button button = (Button)sender;
                var parametro = button.CommandParameter;
                var ide = parametro.ToString();

                var listComentarioId = await serviceComentario.MostrarComentarioPrincipal(historia1, capitulo1, ide);

                await Navigation.PushModalAsync(new RespostasPage(listComentarioId, historia1, capitulo1));
                await Task.Delay(500);
                await Navigation.RemovePopupPageAsync(loadingPage);
            } catch (Exception ex)
            {
                await DisplayAlert("ERRO!", "Problema em consultar respostas. Favor tentar novamente.", "OK");
                await Task.Delay(500);
                await Navigation.RemovePopupPageAsync(loadingPage);
            }
           
        }

        async void clkExcluirComentario(object sender, EventArgs e)
        {
            var loadingPage = new LoadingPopupPage();
            await Navigation.PushPopupAsync(loadingPage);

            try
            {
                Button button = (Button)sender;
                var parametro = button.CommandParameter;
                var ide = parametro.ToString();

                var listComentarioId = await serviceComentario.MostrarComentarioPrincipal(historia1, capitulo1, ide);

                var usuario = listComentarioId.Usuario_id.ToString();

                if (usuario == UserLocalData.userUID)
                {
                    await serviceComentario.ExcluirComentar(historia1, capitulo1, ide);
                    carregarComentarios(historia1, capitulo1);

                    var listAsyncTotal = await serviceComentario.mostrarQuantidadeComentariosTotal(historia1);

                    if (listAsyncTotal != null)
                    {
                        var contagemTotal = Convert.ToInt32(listAsyncTotal.Quantidade);

                        await serviceComentario.SomarComentariosTotal(new QuantidadeComentarioTotal()
                        {
                            Quantidade = contagemTotal - 1
                        }, historia1);
                    }

                    var listAsyncCap = await serviceComentario.mostrarQuantidadeComentarios(historia1, capitulo1);

                    if (listAsyncCap != null)
                    {
                        var contagemCapitulo = Convert.ToInt32(listAsyncCap.Quantidade);

                        await serviceComentario.SomarComentarios(new QuantidadeComentario()
                        {
                            Quantidade = contagemCapitulo - 1
                        }, historia1, capitulo1);
                    }
                }

                await Task.Delay(500);
                await Navigation.RemovePopupPageAsync(loadingPage);
            }
            catch (Exception ex)
            {
                await DisplayAlert("ERRO!", "Problema em excluir seu comentário. Favor tentar novamente.", "OK");
                await Task.Delay(500);
                await Navigation.RemovePopupPageAsync(loadingPage);
            }
        }

        public void atualizarComentarios(object sender, EventArgs e)
        {
            carregarComentarios(historia1, capitulo1);
            _list.IsRefreshing = false;
        }

        public static string isNull(string Expression, string Value)
        {
            if (Expression == null)
            {
                return Value;
            }
            else
            {
                return Expression;
            }
        }
    }
}