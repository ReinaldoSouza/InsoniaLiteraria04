using InsoniaLiteraria04.Database;
using InsoniaLiteraria04.Global;
using InsoniaLiteraria04.Helper;
using InsoniaLiteraria04.Model;
using Rg.Plugins.Popup.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InsoniaLiteraria04.EsseMundoView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class IntroducaoPage : ContentPage
    {
        DBFire service;

        public IntroducaoPage ()
		{
			InitializeComponent ();
            service = new DBFire();
            mostrarCapituloSalvo("EsseMundoVaiMudar", "Capitulo0");
            htmlPage.Html = @"<html><body>
            <p><i>“Não, você não sabe como é
                    <br>Bem-vindos à minha vida”
                    <br><b>Welcome To My Life – Simple Plan</b></i></p>
<br>
<p>“A vida pode ser engraçada às vezes. Eu sempre digo isso. Mas eu nunca parei para pensar que essa frase pode ter mais de um significado e assim, eu posso acabar sendo mal interpretado.</p>
<p>Quer dizer, não é a vida, propriamente dita, que é engraçada e sim as coisas que a compõe.
<p>Por exemplo, se me dissessem uns cinco anos atrás que aos vinte e poucos anos, eu estaria casado, com a família perfeita e com a vida que eu nunca pensaria em ter ou pelo menos, não tão cedo, eu não acreditaria. É engraçado, mas não foi a vida a responsável por isso e sim, eu. Não foi o destino ou qualquer outra palavra mirabolante para o “tinha que ser assim”. Foram minhas escolhas, para o bem e para o mal.
<p>Muitos podem dizer que eu não tenho bem a família perfeita e você pode tirar essa conclusão também depois de saber alguns fatos, mas para ser sincero, não me importa. Eu a considero perfeita, apesar de tudo.
<p>Eu consigo tirar o melhor de cada situação e isso é o que importa. Acabou que eu estou descobrindo dia após dia que essa é a melhor vida que eu poderia ter e como dizem em várias músicas, eu não mudaria nada.
<p>Você pode pensar então, tipo, “ah, então a vida dele é perfeita e fácil, por isso ele não quer mudar.”, mas não foi bem assim.Não foi fácil e continua não sendo e eu sei que nunca vai ser. Aconteceu muita coisa, e quando eu digo muita coisa, eu quero dizer, muita coisa mesmo. Mas eu acredito em consequência e mudar o passado não seria bem a solução. Eu sou assim hoje e me orgulho, se eu tivesse tido algo de diferente no passado, talvez eu não fosse como eu sou e acho que não seria tão bom.
<p>Eu nem sei por onde começar porque quando eu penso nisso tudo, me vêm milhares de cenas na minha cabeça. Memórias boas, memórias ruins... Os detalhes, eu amo os detalhes. Talvez isso seja um problema, eu ser um contador de histórias que ama detalhes, vou ficar cinco anos contando a história de um só dia, vão me odiar por isso.</p>
<center><h4>--*--</h4></center>
<p>Bom, meu nome é William. William Jones, mas todo mundo me chama de Will. Em casa, na escola, na rua, até mesmo quando perguntam meu nome, eu digo “só Will”, e quando me chamam de William, parece que estão falando com outra pessoa ou brigando comigo, é engraçado. É só um nome, por que tantas regras?
<p>Minha família é muito grande, eu sempre digo que se fôssemos pobres e se morássemos em uma casa pequena, teríamos grandes problemas familiares. Não que sejamos ricos ou coisa do tipo, mas também não somos pobres, digamos que estamos na média.
<p>Eu tenho cinco irmãos. É, tenho certeza que esse número te assustou, mas eu te alertei, minha família é grande. A diferença de idade entre a gente é bem curta então sempre falamos para os nossos pais que eles não tinham televisão em casa na época que nascemos, afinal, foi um atrás do outro literalmente. Eu sou o mais velho ou quase isso, você pode perguntar “como assim?”, mas calma, eu vou explicar melhor.
<p>Depois de mim, veio o Christopher que chamamos sempre de Chris, eu costumo irritá-lo e chamá-lo de Christine às vezes. Ele, na época, tinha dezesseis, eu tinha dezessete, mas estudávamos no mesmo ano e compartilhávamos algumas aulas. Eu não levava os estudos muito a sério então repeti um ano, na verdade foi só para eu bancar o rebelde sem causa. Ele é o mais inteligente de todos nós, chega a ser assustador e impossível de competir, mas a gente competia o tempo todo sobre qualquer coisa, era assustador.
<p>Depois do Chris, veio a Amanda, a garotinha da família. Devia ser difícil e um pouco estranho para a Mandy, como eu a chamo, estar cercada de garotos, mas o que é mais estranho é que ela é a minha irmã mais próxima. A gente tem uma ligação que eu não tenho com mais ninguém. Somos parecidos em quase tudo, até na aparência. Meus irmãos têm cabelos bem pretos e lisos e olhos pretos que puxaram da minha mãe, já a Mandy e eu temos os cabelos mais claros do mundo em um formato meio ondulado e olhos claros que herdamos do nosso pai.
<p>Depois da Amanda veio o Kevin. Ele era o tipo de garoto que andava nas nuvens às vezes. Quando a gente era pequeno, ele era o mais inocente e o mais manipulado. A gente se aproveitava muito disso. Às vezes, eu gostaria de ser como ele, sem preocupações, só alegria, bom, pelo menos era o modo que eu via, claro que a vida dele não era bem assim.
<p>Depois do Kevin, veio o Matthew. O Matt é o mais novo, ele veio alguns anos depois do nascimento de Kevin. Ainda me lembro de carrega-lo no colo para cima e para baixo. Agora jogamos bola juntos.
<p>Meu quinto irmão se chama Sebastian, ou Seb, como preferir. Ele não é meu irmão de verdade. Meus pais adotaram ele quando tinha treze anos e ele tem dois anos a mais que eu. A história dele não é muito boa, seus pais biológicos eram problemáticos e ele acabou vindo morar na minha casa, mas eu o considero como irmão do mesmo jeito. Às vezes é bom não ser o irmão mais velho, mas às vezes até dele eu preciso bancar o irmão mais velho, é complicado.</p>
<center><h4>--*--</h4></center>
<p>Bom, eu me apresentei, apresentei a minha família. Vocês já devem achar que a história só gira em torno da gente e eu tenho certeza que você quer muito saber como eu sou e o que eu gosto de fazer, mas eu vou deixar vocês descobrirem sozinhos, eu acho melhor assim, mais divertido. Assim você se surpreende.
<p>Você quer descobrir?”.</p>
</body></html>";
        }

        public void clkAbrirComentar(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MyPopupPage("EsseMundoVaiMudar", "0"));
        }

        public void clkIrMenu(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MenusView.MenuEsseMundoPage());
        }

        public void clkAbrirProximo(object sender, EventArgs e)
        {
           Navigation.PushModalAsync(new Capitulo1Page(1));
        }

        public void clkSalvar(object sender, EventArgs e)
        {
            try
            {
                if (chkCapitulo.IsChecked == true)
                {
                    LerCapitulo("Capitulo0", "true");
                    //var message1 = "CAPÍTULO LIDO";
                    //DependencyService.Get<IMessage>().ShortTime(message1);
                }
                else
                {
                    LerCapitulo("Capitulo0", "false");
                    //var message = "VOCÊ DESMARCOU UM CAPÍTULO";
                    //DependencyService.Get<IMessage>().ShortTime(message);

                }
            }
            catch (Exception ex)
            {
                DisplayAlert("ERRO!", "PROBLEMA EM SALVAR CAPÍTULO. TENTE NOVAMENTE", "OK");
            }
        }

        async void LerCapitulo(string capitulo, string status)
        {
            try
            {
                await service.salvarCapitulo(new CapituloLido()
                {
                    Lido = status,
                    Capitulo = 0,
                    Historia = "EsseMundoVaiMudar"
                }, UserLocalData.userUID, "EsseMundoVaiMudar", capitulo);

                if (status == "true")
                {
                    var listAsync = await service.mostrarQuantidadeLeituras("EsseMundoVaiMudar");

                    if (listAsync != null)
                    {
                        var contagem = Convert.ToInt32(listAsync.Quantidade);

                        await service.SomarLeituras(new QuantidadeLeituras()
                        {
                            Quantidade = contagem + 1
                        }, "EsseMundoVaiMudar");
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        async void mostrarCapituloSalvo(string historia, string capitulo)
        {

            try
            {
                var listAsync = await service.mostrarStatusCapitulo(historia, capitulo, UserLocalData.userUID);

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
            catch (Exception ex)
            {
                await DisplayAlert("ERRO!", "NÃO CONSEGUIMOS CARREGAR INFORMAÇÕES ADICIONAIS", "OK");
            }
        }
    }
}