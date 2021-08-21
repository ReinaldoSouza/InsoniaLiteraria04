using InsoniaLiteraria04.Database;
using InsoniaLiteraria04.Helper;
using Rg.Plugins.Popup.Extensions;
using System;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InsoniaLiteraria04.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InicioPage : ContentPage
    {
        DBFireUsuario serviceUsuario;

        public InicioPage()
        {
            InitializeComponent();
            serviceUsuario = new DBFireUsuario();
            carregarInformacoes();
            telaPrincipal();
        }

        async void telaPrincipal()
        {
            await Task.Delay(5000);
            ldlCarregar.IsVisible = false;
            ldlCarregar.IsRunning = false;
            btnGo.IsVisible = true;
        }

        public async void irParaPrincipal(object sender, EventArgs e)
        {
            var loadingPage = new LoadingPopupPage();
            await Navigation.PushPopupAsync(loadingPage);
            await Task.Delay(500);

            try
            {
                var listAsyncDados = await serviceUsuario.coletarDadosUsuario(UserLocalData.userUID);

                if (listAsyncDados != null)
                {
                    await Navigation.PushModalAsync(new PrincipalPage(0));
                } else
                {
                    await Navigation.PushModalAsync(new MainPage());
                }

            } catch (Exception ex)
            {
                await Navigation.PushModalAsync(new MainPage());
                
            }
            finally
            {
                await Navigation.RemovePopupPageAsync(loadingPage);
            }
        }

        public void carregarInformacoes()
        {
            try
            {
                Random rnd = new Random();
                int card = rnd.Next(36);

                if (card == 0)
                {
                    lblCitacao.Text = "“Todo mundo precisa de um escape, uma hora ou outra.”";
                    lblAutor.Text = "- Esse Mundo Vai Mudar A Sua Vida Um Dia Desses";
                } else if (card == 1)
                {
                    lblCitacao.Text = "“Quando você vai voltar a viver e parar de se lamentar por uma coisa que você não tem culpa?”";
                    lblAutor.Text = "- Anjo da Morte";
                } else if (card == 2)
                {
                    lblCitacao.Text = "“Não adianta ficar pensando em seus arrependimentos e não fazer nada a respeito.”";
                    lblAutor.Text = "- No Escuro";
                } else if (card == 3)
                {
                    lblCitacao.Text = "“Trinta segundos. Talvez menos. Esse foi o tempo que meu coração levou para acordar, depois de quatro meses hibernando.”";
                    lblAutor.Text = "- Anjo da Morte";
                } else if (card == 4)
                {
                    lblCitacao.Text = "“Não sei exatamente o que posso fazer para te ajudar, mas acredito em você.”";
                    lblAutor.Text = "- Segredos Internos";
                } else if (card == 5)
                {
                    lblCitacao.Text = "“Ser otimista. Pensar positivo. Não se deixar abater.”";
                    lblAutor.Text = "- Anjo da Morte";
                } else if (card == 6)
                {
                    lblCitacao.Text = "“E às vezes, em um lugar cheio de pessoas, tudo o que eu vejo é ela, como se... fôssemos os únicos no mundo.”";
                    lblAutor.Text = "- Esse Mundo Vai Mudar A Sua Vida Um Dia Desses";
                } else if (card == 7)
                {
                    lblCitacao.Text = "“Sabe quando a vida parece estar com raiva de você e não perde a mais remota chance de te dar uma rasteira?”";
                    lblAutor.Text = "- A Estranha e Outras Histórias";
                } else if (card == 8)
                {
                    lblCitacao.Text = "“Na verdade, o mundo não tem a menor chance contra nós.”";
                    lblAutor.Text = "- Esse Mundo Vai Mudar A Sua Vida Um Dia Desses";
                } else if (card == 9)
                {
                    lblCitacao.Text = "“Entendi que, muitas vezes, é preciso ser afastado daqueles que mais ama para saber quem realmente te ama de volta.”";
                    lblAutor.Text = "- Anjo da Morte";
                } else if (card == 10)
                {
                    lblCitacao.Text = "“Eu acredito que podemos fazer qualquer coisa.”";
                    lblAutor.Text = "- Esse Mundo Vai Mudar A Sua Vida Um Dia Desses";
                } else if (card == 11)
                {
                    lblCitacao.Text = "“Quanto mais eu tentava afastá-lo, mais ele se mostrava presente.”";
                    lblAutor.Text = "- Anjo da Morte";
                } else if (card == 12)
                {
                    lblCitacao.Text = "“Eu sou uma bagunça. Você não precisa lidar com isso. Eu não recomendaria”";
                    lblAutor.Text = "- Segredos Distantes";
                } else if (card == 13)
                {
                    lblCitacao.Text = "“Ao menos dessa vez, talvez, você possa se perder comigo nessa noite.”";
                    lblAutor.Text = "- A Estranha e Outras Histórias";
                } else if (card == 14)
                {
                    lblCitacao.Text = "“Você me conhece, eu sou muito exagerado. Se eu não fizer um show, prefiro não fazer nada.”";
                    lblAutor.Text = "- Segredos Obscuros";
                } else if (card == 15)
                {
                    lblCitacao.Text = "“Era como se o anjo da morte estivesse ao meu lado com uma arma carregada e apontada para a cabeça das pessoas que eu amava.”";
                    lblAutor.Text = "- Anjo da Morte";
                } else if (card == 16)
                {
                    lblCitacao.Text = "“Alguém era colecionador de máscaras, usava uma para cada situação.”";
                    lblAutor.Text = "- A Estranha e Outras Histórias";
                } else if (card == 17)
                {
                    lblCitacao.Text = "“Quem você prefere? Capitão América ou Homem de Ferro?”";
                    lblAutor.Text = "- Segredos Internos";
                } else if (card == 18)
                {
                    lblCitacao.Text = "“Quanto tempo é necessário para se perceber que você esteve lamentando as coisas erradas?”";
                    lblAutor.Text = "- Anjo da Morte";
                } else if (card == 19)
                {
                    lblCitacao.Text = "“Mas... a vida é louca, por que não sermos também?”";
                    lblAutor.Text = "- No Escuro";
                } else if (card == 20)
                {
                    lblCitacao.Text = "“De vez em quando, seria legal saber que alguém precisa de mim e que sente minha falta quando estou distante.”";
                    lblAutor.Text = "- A Estranha e Outras Histórias";
                }
                else if (card == 21)
                {
                    lblCitacao.Text = "“Uma vez eu prometi cuidar de você e essa promessa ainda está valendo.”";
                    lblAutor.Text = "- Sua Música Salvou A Minha Vida";
                }else if (card == 22)
                {
                    lblCitacao.Text = "“Você era o sol que fazia tudo girar ao seu redor.”";
                    lblAutor.Text = "- Apenas Dance Comigo";
                } else if (card == 23)
                {
                    lblCitacao.Text = "“Posso não ser sempre um livro aberto ou alguém fácil de lidar, mas... Eu vou fazer o possível para estar lá quando você precisar.”";
                    lblAutor.Text = "- Segredos Internos";
                } else if (card == 24)
                {
                    lblCitacao.Text = "“Ele é meu melhor amigo, meu irmão, meu herói, meu apoio. Minha família.”";
                    lblAutor.Text = "- Sua Música Salvou A Minha Vida";
                } else if (card == 25)
                {
                    lblCitacao.Text = "“Você prefere ficar sozinho, assim ninguém consegue enxergar o mentiroso que você é.”";
                    lblAutor.Text = "- Sua Música Salvou A Minha Vida";
                } else if (card == 26)
                {
                    lblCitacao.Text = "“Amar incondicionalmente, alguém consegue amar assim? Através das falhas, dos erros, das decepções? Isso realmente existe?”";
                    lblAutor.Text = "- Sua Música Salvou A Minha Vida";
                } else if (card == 27)
                {
                    lblCitacao.Text = "“Eu estou exatamente onde eu quero estar.”";
                    lblAutor.Text = "- Segredos Internos";
                } else if (card == 28)
                {
                    lblCitacao.Text = "“Quando eu a vi, foi como se eu tivesse dezoito de novo e todas aquelas coisas que eu sentia, eu comecei a... sentir de novo.”";
                    lblAutor.Text = "- No Escuro";
                } else if (card == 29)
                {
                    lblCitacao.Text = "“Você existe para mim. Você é meu irmão e eu mataria e morreria por você.”";
                    lblAutor.Text = "- Sua Música Salvou A Minha Vida";
                } else if (card == 30)
                {
                    lblCitacao.Text = "“Não era algo intencional nem uma resposta a alguma coisa, mas para ele era um sorriso que ela estava dando por estar gostando de ouvir ele cantar aquela música.”";
                    lblAutor.Text = "- Segredos Internos";
                } else if (card == 31)
                {
                    lblCitacao.Text = "“É engraçado pensar que existe uma pessoa que pode te deixar totalmente perdido e nervoso, vulnerável, mas completamente feliz.”";
                    lblAutor.Text = "- Esse Mundo Vai Mudar A Sua Vida Um Dia Desses";
                } else if (card == 32)
                {
                    lblCitacao.Text = "“Eu não sou perfeito e nunca vou ser, então se me perdoar e me aceitar de volta, é isso que vai ter. Alguém cheio de falhas e idiota e apaixonado por você.”";
                    lblAutor.Text = "- Segredos Obscuros";
                } else if (card == 33)
                {
                    lblCitacao.Text = "“Deixar para lá não quer dizer desistir, não é?”";
                    lblAutor.Text = "- Segredos Distantes";
                } else if (card == 34)
                {
                    lblCitacao.Text = "“Eu amo saber que mesmo sem assunto, você vai ficar falando vinte e quatro horas por dia se eu deixar.”";
                    lblAutor.Text = "- Segredos Obscuros";
                } else if (card == 35)
                {
                    lblCitacao.Text = "“Somos a melhor coisa dessa escola, talvez desse planeta, e eu estou falando de um planeta onde existe Ashton Kutcher e Mila Kunis.”";
                    lblAutor.Text = "- Esse Mundo Vai Mudar A Sua Vida Um Dia Desses";
                }
            } catch (Exception ex)
            {
                lblCitacao.Text = "“É bom saber que nossa droga de mundo, eu tenho alguém com quem contar.”";
                lblAutor.Text = "- Esse Mundo Vai Mudar A Sua Vida Um Dia Desses";
            }
            
        }
    }
}