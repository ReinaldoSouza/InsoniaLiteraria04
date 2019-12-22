using InsoniaLiteraria04.Database;
using InsoniaLiteraria04.Global;
using InsoniaLiteraria04.Helper;
using InsoniaLiteraria04.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InsoniaLiteraria04.SegredosDistantesView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrologoPage : ContentPage
    {
        DBFire service;

        public PrologoPage()
        {
            InitializeComponent();
            service = new DBFire();
            mostrarCapituloSalvo("SegDistantes", "Capitulo0");
            var message = "Só venha para cá se você já tiver lido Segredos Obscuros";
            DependencyService.Get<IMessage>().LongTime(message);
            htmlPage.Html = @"<html><body>
<p><b>Para:</b> Temperance G. 
<br><b>De:</b> Jason P.
<br><b>Assunto:</b> dklshgnsjkygs</p>
<p>Espero que você leia esse e-mail assim que você acordar. Eu só quero dizer que, bom, eu vou voltar para a Califórnia com a Lisa, mas espero que fique bem. Eu vou ligar o tempo todo, eu prometo e quando você sair do hospital, vou estar aí para rir da sua cara, claro.
<br>Já tô sentindo saudades</p>
<p>Jason.</p>
<center><h4>--*--</h4></center>
<p><b>Para:</b> Temperance G. 
<br><b>De:</b> Jason P.
<br><b>Assunto:</b> dlhsoiaasklalssn</p>
<p>Sua mãe me disse que saiu do hospital. Ela também disse que você foi para o Canadá estudar medicina, isso é incrível, quer dizer, você é bem inteligente então vai dar certo.
<br>Boa sorte para você. Eu estou torcendo.
<br>Ah, mais uma coisa: Eu fui aí, sabia? Mas você já tinha ido, SUA IDIOTA INFELIZ, QUAL É O SEU PROBLEMA? VOCÊ AO MENOS LEU O MEU E-MAIL? Claro que não, sua mãe também me disse que você não usa mais o computador por... você sabe porquê. Espero que um dia você me responda.
<br>Ah, e com isso, você é a segunda pessoa que me deixa esse ano. Caso queira saber, eu também mando mensagens para Emily, claro que mais picantes e... Isso não vem ao caso. E não, não estamos namorando. Distância é um saco.
<br>Não sinto mais saudades</p>
<p>Jason.</p>
<center><h4>--*--</h4></center>
<p><b>Para:</b> Temperance G. 
<br><b>De:</b> Jason P.
<br><b>Assunto:</b> sakhlyihawoinkald</p>
<p>Olha só, me respondeu, e eu nem precisei esperar por um ano todo.
<br>Que pena que o Nathan te largou porque, não importa o que você me diga, duvido que foi você que largou ele. 
<br>Que bom que você está gostando da faculdade, é o seu melhor momento, então aproveita. Eu estou aqui em casa, brigando com o meu pai dia sim e no outro também, mas a gente sobrevive. Além do mais, eu estou trabalhando em um supermercado, o que não é muito bom porque aparece umas velhas lá que me irritam muito.
<br>Eu fui até Nova York visitar a Emily, eu sei foi um pouco errado porque da última vez que a gente se falou, a gente concordou que iriamos esquecer um ao outro, porque distância é um saco, mas... Ela está tão, mas tão maravilhosa na faculdade que eu tive vontade de grudar nela e nunca mais desgrudar, mas eu não fiz isso. A gente não voltou nem nada, mas dormimos juntos. E foi incrível, quer os detalhes? Lógico que não e eu não transo e conto. Mas eu acabei de te contar agora então a teoria está errada. Tô confuso.
<br>Outra coisa, se eu ficar com gripe, você já vai saber me medicar?</p>
<p>Jason.</p>
<center><h4>--*--</h4></center>
<p><b>Para:</b> Temperance G. 
<br><b>De:</b> Jason P.
<br><b>Assunto:</b> slaçiosnsdlihsd</p>
<p>Você reprovou em uma matéria? Sério? Que vergonha. Eu estou sentindo vergonha de você. Eu estou aqui falando para todo mundo todo orgulhoso que tenho uma amiga médica e aí você me diz que pegou uma DP? E se forem se consultar com você e você cortar o braço errado? Que horror!
<br>Emily me ligou ontem e me chamou para uma festa que os universitários vão dar e parece ser bem legal. Eu tenho um dinheiro para ir, mas eu não sei se... Você acha que eu devo? Eu quero ir, eu quero chegar lá, sair da festa e ficar com aquela garota a noite toda. Faz meses, mas eu não consigo parar de pensar nela, parece uma doença. Você sabe como se cura? Claro que não, você tem uma DP. 
<br>Ah, eu estou agora perto de Stanford, é. Não, eu não estou na faculdade ainda, é que eu saí de casa e estou morando no sofá da Lisa. É meio desconfortável, mas pelo menos não preciso ouvir gritos o dia todo, e eu estou do lado de uma amiga para variar que não fica com DP, que vergonha!</p>
<p>Jason.</p>
<center><h4>--*--</h4></center>
<p><b>Para:</b> Temperance G. 
<br><b>De:</b> Jason P.
<br><b>Assunto:</b> çuooighkhi</p>
<p>Eu descobri que eu sou um ótimo garçom. Eu consigo segurar duas bandejas agora sem derrubar nenhuma ou quase... que seja.
<br>Como você está? Eu notei que não fala mais “dele” e isso é bom, isso é muito bom. Namorando muita gente? Pode dizer. Não, não é? Garota, você precisa de um homem, médicos também namoram. 
<br>Você não vai acreditar em quem apareceu no restaurante ontem. Emily disse que estava com uma folga e veio nos visitar. Pela primeira vez, eu senti o clima estranho como se a gente estivesse... A gente está se enganando, não está? Eu quero seguir em frente, eu quero sim. Eu fico olhando para as garotas que a Lisa leva em casa para estudar e tal, e são muito lindas, mas, sei lá. 
<br>Se ela seguisse em frente também seria mais fácil porque aí eu saberia que a página virou, mas ela não me ajuda. Quem eu quero enganar? Se ela seguir em frente, eu morro.
<br>Mais uma coisa, eu estou com uma dor na panturrilha, não pode ser câncer, pode?</p>
<p>Jason.</p>
<center><h4>--*--</h4></center>
<p><b>Para:</b> Temperance G. 
<br><b>De:</b> Jason P.
<br><b>Assunto:</b> jksoighsgolihd</p>
<p>Espero que você tenha sobrevivido à semana de provas. Pouca gente sobrevive. 
<br>Olha, eu preciso falar com você sobre um assunto que eu sei que não vai gostar porque é uma coisa meio batida, mas... Às vezes, eu sinto que a Lisa ainda não superou o Cabelo Ruim, ela não é mais tão alegre quanto era, ela perdeu alguma coisa. Isso é normal? Também acontece com você? Não precisa responder se não quiser, é que eu queria fazer algo para ajudar e eu não sei o que. 
<br>Você podia ter feito psicologia e não medicina, seria muito mais útil. Me ajudaria.
<br>Eu não falo com a Emily faz dois meses. A última mensagem que eu mandei para ela eu disse que devíamos parar de nos ver e de conversar, pelo menos por um tempo. Foi errado, não foi? A gente se ama então temos que lutar para dar certo, não é? Me ajuda aqui. Droga.
<br>Ah, e a dor não passou. Seu primeiro e único paciente está trocando de médico. Sinto muito.</p>
<p>Jason.</p>
<center><h4>--*--</h4></center>
<p><b>Para:</b> Temperance G. 
<br><b>De:</b> Jason P.
<br><b>Assunto:</b> dskhseohyai.,fjbwluflah</p>
<p>Gostei das fotos que me mandou, até parecia uma médica de verdade. Manda umas fotos de cadáveres aí, preciso assustar umas pessoas.
<br<E olha a novidade. Seu melhor amigo voltou aos seus antigos e ótimos hábitos. Eu saí com a Lisa ontem para uma festa da faculdade dela e adivinha? Eu superei os veteranos na pegação e olha que eu nem contei. Eu fui o máximo. 
<br>Universitárias são demais. Bêbadas, desconhecidas e fáceis, melhores tipos de mulheres. 
<br>Espero que esteja bem. Ah e não, ainda não sei o que eu vou fazer da minha vida, mas eu estou ótimo. Eu estou trabalhando em uma locadora agora, é, elas ainda existem, que horror.
<br>Tossir por dois dias não é princípio de tuberculose, é?</p>
<p>Jason.</p>
</body></html>";

        }

        public void clkAbrirComentar(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new EsseMundoView.MyPopupPage("SegDistantes", "0"));
        }

        public void clkIrMenu(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MenusView.MenuSegredosDistantesPage());
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
                    LerCapitulo("0", "true");
                    //var message1 = "CAPÍTULO LIDO";
                    //DependencyService.Get<IMessage>().ShortTime(message1);
                }
                else
                {
                    LerCapitulo("0", "false");
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
                    Historia = "SegDistantes"
                }, UserLocalData.userUID, "SegDistantes", "Capitulo" + capitulo);

                if (status == "true")
                {
                    var listAsync = await service.mostrarQuantidadeLeituras("SegDistantes");

                    if (listAsync != null)
                    {
                        var contagem = Convert.ToInt32(listAsync.Quantidade);

                        await service.SomarLeituras(new QuantidadeLeituras()
                        {
                            Quantidade = contagem + 1
                        }, "SegDistantes");
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
            }
            catch (Exception ex)
            {
                await DisplayAlert("ERRO!", "NÃO CONSEGUIMOS CARREGAR INFORMAÇÕES ADICIONAIS", "OK");
            }
        }

    }
}