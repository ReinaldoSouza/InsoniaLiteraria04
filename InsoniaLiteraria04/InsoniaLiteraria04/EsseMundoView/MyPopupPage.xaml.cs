using InsoniaLiteraria04.Database;
using InsoniaLiteraria04.Helper;
using InsoniaLiteraria04.Model;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace InsoniaLiteraria04.EsseMundoView
{
    public partial class MyPopupPage : ContentPage
    {
        DBFire service;
        string historia1;
        string capitulo1;
        ObservableCollection<Comentarios> list = new ObservableCollection<Comentarios>();

        public MyPopupPage(string historia, string capitulo)
        {
            InitializeComponent();
            service = new DBFire();
            _list.BindingContext = list;
            carregarComentarios(historia, capitulo);
            capitulo1 = capitulo;
            historia1 = historia;
            
        }

        async void carregarComentarios(string historia, string capitulo)
        {
            try
            {
                ldlCarregar.IsRunning = true;
                ldlCarregar.IsVisible = true;

                var listAsync = await service.mostrarComentarios(historia, capitulo);

                if (list != null)
                {
                    foreach (var item in listAsync)
                    {
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
                await DisplayAlert("AVISO!", "OS COMENTÁRIOS NÃO FORAM CARREGADOS! VERIFIQUE SUA CONEXÃO COM A INTERNET", "OK");
            }
            
        }

        public void clkComentar(object sender, EventArgs e)
        {
            Comentar(historia1, capitulo1);
        }

        async void Comentar(string historia, string capitulo)
        {
            try
            {
                await service.comentar(new Comentarios()
                {
                    Usuario = UserLocalData.userEmail.Replace("@insonialiteraria.com", ""),
                    Mensagem = txtComentar.Text,
                    Data = DateTime.Now.ToString("dd/MM/yyyy H:mm")
                }, historia, capitulo);
                txtComentar.Text = "";

                var listAsync = await service.mostrarQuantidadeMensagem(historia);

                if (listAsync != null)
                {
                    var contagem = Convert.ToInt32(listAsync.Quantidade);

                    await service.SomarComentarios(new QuantidadeComentario()
                    {
                        Quantidade = contagem + 1
                    }, historia);
                }

                list.Clear();
                carregarComentarios(historia, capitulo);
            }
            catch (Exception ex)
            {
                await DisplayAlert("ERRO!", "NÃO FOI POSSÍVEL COMENTAR", "OK");
            }
        }

        async void clkFechar(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

    }
}