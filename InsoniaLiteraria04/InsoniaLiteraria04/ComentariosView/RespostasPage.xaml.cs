using InsoniaLiteraria04.Constantes;
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
using Xamarin.Forms.Xaml;

namespace InsoniaLiteraria04.ComentariosView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RespostasPage : ContentPage
    {
        DBFireComentarios serviceComentario;
        DBFireUsuario serviceUsuario;
        string historia1;
        string capitulo1;
        Comentarios coment;
        ObservableCollection<Resposta> list = new ObservableCollection<Resposta>();

        public RespostasPage(Comentarios comentario, string historia, string capitulo)
        {
            InitializeComponent();
            serviceComentario = new DBFireComentarios();
            serviceUsuario = new DBFireUsuario();
            _list.BindingContext = list;
            coment = new Comentarios();
            coment = comentario;
            capitulo1 = capitulo;
            historia1 = historia;
            carregarComentarioPrincipal(coment);
            carregarRespostas(historia, capitulo);
        }

        public async void carregarComentarioPrincipal(Comentarios comentId)
        {
            try
            {
                var listAsync = await serviceUsuario.mostrarFotoPerfil(comentId.Usuario_id);

                if (listAsync != null)
                {
                    image_profile.Source = listAsync.ImageUrl.ToString();
                }
                else
                {
                    image_profile.Source = "capaprofile.jpg";
                }

                lblComentario.Text = comentId.Mensagem.ToString();
                lblUsuario.Text = comentId.Usuario.ToString();
                lblData.Text = comentId.Data.ToString();
            } catch (Exception ex)
            {
                await DisplayAlert("ERRO!", ex.Message, "OK");
            }
        }

        public void clkComentar(object sender, EventArgs e)
        {
            if (txtComentar.Text != null)
            {
                if (txtComentar.Text.Trim() != "")
                {
                    Responder(historia1, capitulo1);
                }
            }
        }

        async void Responder(string historia, string capitulo)
        {
            var loadingPage = new LoadingPopupPage();
            await Navigation.PushPopupAsync(loadingPage);

            try
            {
                
                await DependencyService.Get<IAdmobInterstitialAds>().Display(AppConstants.InterstitialAdId);              

                await serviceComentario.responder(new Resposta()
                {
                    Id = DateTime.Now.ToString("ddMMyyyyHHmmss") + historia1 + capitulo1 + UserLocalData.userUID,
                    Usuario_id = UserLocalData.userUID,
                    Usuario = UserLocalData.userEmail.Replace("@insonialiteraria.com", ""),
                    Mensagem = txtComentar.Text,
                    Data = DateTime.Now.ToString("dd/MM/yyyy H:mm")
                }, historia1, capitulo1, coment.Id);
                txtComentar.Text = "";

                var listAsyncTotal = await serviceComentario.mostrarQuantidadeComentariosTotal(historia);

                if (listAsyncTotal != null)
                {
                    var contagemTotal = Convert.ToInt32(listAsyncTotal.Quantidade);

                    await serviceComentario.SomarComentariosTotal(new QuantidadeComentarioTotal()
                    {
                        Quantidade = contagemTotal + 1
                    }, historia);
                }
                else
                {
                    await serviceComentario.SomarComentariosTotal(new QuantidadeComentarioTotal()
                    {
                        Quantidade = 1
                    }, historia);
                }

                var listAsyncCap = await serviceComentario.mostrarQuantidadeComentarios(historia, capitulo);

                if (listAsyncCap != null)
                {
                    var contagemCapitulo = Convert.ToInt32(listAsyncCap.Quantidade);

                    await serviceComentario.SomarComentarios(new QuantidadeComentario()
                    {
                        Quantidade = contagemCapitulo + 1
                    }, historia, capitulo);
                }

                var quantidadeRespostas = Convert.ToInt32(coment.Respostas) + 1;

                coment.Respostas = quantidadeRespostas.ToString();

                await serviceComentario.AlterarQuantidadeRespostas(coment, historia1, capitulo1);

                carregarRespostas(historia, capitulo);
                await Task.Delay(1000);
                await Navigation.RemovePopupPageAsync(loadingPage);
            }
            catch (Exception ex)
            {
                await DisplayAlert("ERRO!", ex.Message, "OK");
                await Navigation.RemovePopupPageAsync(loadingPage);
            }
        }

        async void carregarRespostas(string historia, string capitulo)
        {
            lblMensagem.IsVisible = false;

            list.Clear();

            try
            {
                ldlCarregar.IsRunning = true;
                ldlCarregar.IsVisible = true;

                var listAsync = await serviceComentario.mostrarRespostas(historia, capitulo, coment.Id);

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

        async void clkExcluirResposta(object sender, EventArgs e)
        {
            var loadingPage = new LoadingPopupPage();
            await Navigation.PushPopupAsync(loadingPage);

            try
            {
                Button button = (Button)sender;
                var parametro = button.CommandParameter;
                var ide = parametro.ToString();

                var listComentarioId = await serviceComentario.MostrarRespostaPrincipal(historia1, capitulo1, coment.Id, ide);

                var usuario = listComentarioId.Usuario_id.ToString();

                if (usuario == UserLocalData.userUID)
                {
                    await serviceComentario.ExcluirResposta(historia1, capitulo1, coment.Id, ide);
                    carregarRespostas(historia1, capitulo1);

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

                    var quantidadeRespostas = Convert.ToInt32(coment.Respostas) - 1;

                    coment.Respostas = quantidadeRespostas.ToString();

                    await serviceComentario.AlterarQuantidadeRespostas(coment, historia1, capitulo1);
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
            carregarRespostas(historia1, capitulo1);
            _list.IsRefreshing = false;
        }

        async void clkFechar(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}