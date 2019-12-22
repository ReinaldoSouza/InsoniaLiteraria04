using InsoniaLiteraria04.Database;
using InsoniaLiteraria04.EsseMundoView;
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

namespace InsoniaLiteraria04.SegredosObscurosView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Capitulo2Page : ContentPage
    {
        DBFire service;
        public int condicao;

        public Capitulo2Page(int numero)
        {
            InitializeComponent();
            service = new DBFire();
            condicao = numero;
            mostrarCapituloSalvo("SegObscuros", "Capitulo" + numero.ToString());

            if (numero == 6)
            {
                lblTitulo.Text = "Capítulo 6 - Traição";
                htmlPage.Html = @"<html><body>
<p>Jason saiu da sala e correu atrás de Temperance.
<p>- Tempe, espera!
<p>- Sai daqui e não me chama mais de Tempe. – Ela estava com muita raiva e continuou andando.
<p>- Você tem que acreditar em mim. Eu não fiz nada.
<p>- Ah é? Então ele adivinhou?
<p>- Eu não faço ideia, de repente alguém ouviu a gente, sei lá.
<p>- Ninguém ouviu. – Temperance então parou de andar e encarou Jason. – Por que você fez isso?
<p>- Eu nunca faria isso com você.
<p>- Ah é? E por que não? Você não é o imbecil da escola? – Temperance extrapolou.
<p>- É o que você acha?
<p>- É.
<p>- Então que se dane. – Jason foi embora com raiva.
<p>- Você não pode ir embora com raiva! Eu que estou com raiva, não você! – Temperance gritou, mas Jason ignorou.</p>
<center><h4>--*--</h4></center>
<p>- Tempe!
<p>- Jason, vai embora! – Temperance gritou, mas quem estava vindo atrás dela pelos corredores era o Brandon.
<p>- Não é o Jason.
<p>- Só era uma questão de tempo. – Temperance fez cara feia.
<p>- Podemos conversar?
<p>- Não precisamos, porque isso já faz muito tempo. Eu não sinto mais nada por você, só amizade. – Temperance explicou logo.
<p>- Por que nunca me falou isso?
<p>- Bran, você me conhece, eu não sou do tipo que se expressa.
<p>- Temos isso em comum. – Brandon riu. – Só para você não ficar tão mal, eu também era apaixonado por você.
<p>- Somos uma droga. – Temperance tentou brincar.
<p>- Talvez não desse certo.
<p>- Eu não quero perder a sua amizade.
<p>- Nem vai. Eu te amo, Tempe e você vai me aguentar pelo resto da sua vida. – Brandon abraçou forte Temperance.
<p>- Eu também te amo. Então estamos bem?
<p>- Por mim sim, e você?
<p>- Preciso me preparar para a zoação. – Temperance respirou fundo.
<p>- Eu posso afastar todo mundo se quiser.
<p>- Não, isso só vai piorar. Já imagino o blogueiro dizendo “olha só, o príncipe da Tempe a defendendo.”.
<p>- Eu sinto muito. Não queria que passasse por isso.
<p>- Relaxa, não é o fim do mundo. – Temperance sorriu para acalmar Brandon.</p>
<center><h4>--*--</h4></center>
<p>- Eu fiquei em choque.
<p>Lisa e Jason estavam caminhando de volta para casa depois da aula.
<p>- Eu achei normal. Quer dizer, eu também era apaixonado por você. – Jason sorriu.
<p>- E ainda é. – Lisa brincou.
<p>- Só estou esperando a sua declaração.
<p>- Eu beijei o Brandon hoje. – Lisa estava esperando para falar sobre isso desde que encontrou o amigo.
<p>- Sua declaração não deveria começar assim. – Jason fez cara de nojo e depois riu.
<p>- Não, é sério. Antes da Maddie aparecer com a notícia, a gente se beijou.
<p>- Quer dizer que a Maddie Intrometida colocou o narigão na frente?
<p>- Foi. – Lisa riu. – Mas para de falar assim dela.
<p>- Não consigo evitar.
<p>- Por que você não gosta dela?
<p>- Não é que eu não goste. Sei lá.
<p>- Você é muito besta. Ela é um doce de pessoa.
<p>- Tão doce que quando falo com ela fico com diabetes.
<p>- Cala a boca. – Lisa deu um tapa no ombro do amigo. – Sabe, é curioso. Como o blogueiro descobriu sobre o suposto amor da Temperance pelo Bran?
<p>- Ela me contou hoje cedo.
<p>- Então é verdade? – Agora sim Lisa estava chocada.
<p>- Bom, mais ou menos. Ela disse que já superou. Mas eu não sei como o infeliz do blogueiro descobriu. Ela acha que eu contei para alguém.
<p>- E brigou com você? Ela ficou muito brava?
<p>- Digamos que se ela tivesse uma arma, ela teria atirado.
<p>- E o que você vai fazer?
<p>- O que eu posso fazer? – Jason não era muito de correr atrás das pessoas.
<p>- Vocês viraram amigos. O mínimo que você pode fazer é pedir desculpas.
<p>- Por uma coisa que eu não fiz? Ela que devia pedir desculpas por não acreditar em mim.
<p>- Não é assim que funciona.
<p>- Olha, eu vou dar um tempo para ela. Depois a gente resolve.
<p>- Escuta aqui, como você acha que o blogueiro descobriu? – Lisa ficou curiosa.
<p>- Não faço ideia. Não tinha ninguém perto da gente quando ela falou, a não ser que o blogueiro leia mentes. Assim eu vou começar a respeitar ele.
<p>- Será que ele manipula alguma câmera na escola? – Lisa começou a pensar em olhar para os lados procurando por câmeras quando estivesse na escola.
<p>- Se isso for verdade, sem fantasia de sexo em alguma sala de aula vazia. Eu não vou querer algum filme meu vazado por aí. – Jason começou a rir, mas Lisa ficou séria.
<p>- Isso é sério. Ele pode estar invadindo a privacidade das pessoas.
<p>- Ele é um idiota, não duvidaria disso.
<p>- E por que você acha que ele pega tanto no seu pé?
<p>- Porque eu sou lindo e incrível e ele deve ser horrível.
<p>- Humildade chamando.
<p>- Deixa ela continuar chamando. – Lisa riu. – Agora me conte sobre esse beijo. É melhor que o meu?
<p>- Nunca nos beijamos. – Lisa ficou sem entender.
<p>- Então podemos nos beijar agora para você comparar. – Jason fez bico.
<p>- Não. Eu prefiro ficar só com o beijo do Brandon.
<p>- Você está com medo de não conseguir largar a minha boca, isso sim.
<p>- Vamos mudar de assunto?
<p>- Se é o que você quer. – Jason riu.
<p>- Não, eu quero falar mais sobre o beijo. – Lisa estava agitada.
<p>- Que seja, fala. – Jason não estava entusiasmado, mas era um bom ouvinte.
<p>- Eu dei a iniciativa e o beijei.
<p>- Isso foi bom, porque se tivesse esperado pelo Peruca de Lombriga, vocês ainda estariam de mãos dadas.
<p>- Nem todo mundo é atirado como você.
<p>- Um grande erro da sociedade. Me conta como foi. Ele ficou com a língua balançando?
<p>- O quê?
<p>- Eu preciso de algo para fazer piada. Foi só um selinho? Ai, que coisa mais sem graça.
<p>- Estamos indo devagar.
<p>- Tudo bem então. Só vão transar quando tiverem 30 anos. Devagar assim?
<p>- Cala essa boca, não falo mais nada para você.
<p>- Se apaixonou completamente? - Jason insistiu.
<p>- Eu estou gostando dele, mas eu não sei, ele não se abre o suficiente.
<p>- Caras não costumam falar de sentimentos.
<p>- Você não costuma falar de sentimentos.
<p>- Eu não tenho sentimentos ou não sei onde é que está.
<p>- Você tem sim. Só não achou a garota certa.
<p>- E vamos para mais um episódio de A Filosofia de Lisa. – Jason brincou. – Não existe garota certa, existe uma garota gata que a gente pode chegar a gostar, só isso.
<p>- Espero que um dia uma garota te faça ficar perdidamente apaixonado.
<p>- Uma garota já fez isso. – Jason piscou para Lisa.
<p>- Eu estou falando sério.
<p>- Não me joga praga, tá bom? – Jason riu.
<p>Então Jason ficou em silêncio. Por um segundo, ele pensou na garota que conheceu na praça naquela noite e que nunca mais viu. Ele até poderia falar aquilo para Lisa, mas aí ela começaria a enchê-lo de perguntas, e ele não tinha nada para responder, então resolveu ficar calado.</p>
<center><h4>--*--</h4></center>
<p>Brandon acordou animado.
<p>Ele não tinha falado com Lisa desde o beijo por causa do problema com a Temperance e o que se seguiu depois disso, mas ele estava ansioso para falar com ela. Seria a primeira coisa que ele faria quando chegasse na escola.
<p>- Oi. – Brandon se sentou ao lado de Lisa antes da aula começar. – A gente precisa conversar.
<p>- Sobre? – Lisa se fez de desentendida.
<p>- Sobre o beijo que você me deu. – Brandon riu. – Foi bom.
<p>- Não venha me pedir outro.
<p>- Eu não vim pedir.
<p>- Então?
<p>- Eu vim retribuir. – Brandon se aproximou de Lisa e a beijou.
<p>- Já não era sem tempo.
<p>- Eu costumo ser um pouco lerdo.
<p>- Eu percebi. – Lisa riu. – Ainda bem que não demorou tanto assim.
<p>- Posso segurar sua mão agora? – Brandon riu.
<p>- Só longe dos meus pais. – Lisa entrou na brincadeira.
<p>- Vou me esconder então.</p>
<center><h4>--*--</h4></center>
<p>- E aí, amigão? – Jason encontrou Kol lendo um livro sentado em uma das mesas na biblioteca e chegou perto dele animado.
<p>- O que você quer? – Kol nem prestou atenção na animação de Jason e continuou sério lendo seu livro.
<p>- Olha só, Kol, eu quero conversar com você.
<p>- Eu não.
<p>- Vou falar mesmo assim. – Jason estava ficando sem graça. – Eu não sei se você é estranho assim com todo mundo, mas comigo você pode ser mais legal, tipo podemos ir para o shopping azarar garotas e essas coisas todas.
<p>- Não.
<p>- Tudo bem, eu não queria chegar a esse ponto, mas por que você não gosta de mim?
<p>- O quê?
<p>- Todo mundo gosta de mim, exceto algumas pessoas, quer dizer, tem algumas pessoas que... A questão é que eu sou a pessoa mais legal do mundo. – Jason sorriu.
<p>- Eu aposto que seja.
<p>- Olha, a sua irmã me contou que você perdeu uma pessoa importante e...
<p>- Não fale sobre isso. – Kol ficou irritado.
<p>- Está tudo bem, eu entendo. Não sou tão insensível assim. Você quer apoio, eu posso fazer alguém te apoiar, não tem problema.
<p>- Você não se toca, não é?
<p>- Em que sentido? – Jason ficou confuso. – Isso é uma pergunta muito pessoal.
<p>- Eu não quero ser seu amigo.
<p>- Só porque eu te chamei de Cepacol, Caracol e quase agora de Cachecol? Eu posso ser mais criativo no apelido.
<p>- Por que você quer a minha amizade?
<p>- Olha, você pode não acreditar, mas eu já fui fechado assim como você.
<p>- Sério?
<p>- Não. Bom, eu só tentei ser legal, eu vi como você é excluído e isso não é muito bom.
<p>- Está fazendo caridade?
<p>- Não é bem caridade. Se todo mundo ver que eu sou uma pessoa legal sendo legal com você, vão parar de acreditar no que o blogueiro diz.
<p>- Você está me usando?
<p>- Não! Mais ou menos. Mas eu não sou de encher as pessoas, na verdade, eu odeio isso, mas estou fazendo isso com você, então deveria se sentir sortudo.
<p>- Você é um idiota.
<p>- Tem razão, eu sou um idiota. Eu me excluo porque eu perdi alguém e prefiro não me aproximar de mais ninguém, porque pessoas morrem. Ah não, espera um pouco, esse é você.
<p>- Cala a boca, você não entende, e nem precisa. Não somos amigos e eu não preciso do seu apoio. – Kol começou a ficar com muita raiva.
<p>- Todo mundo sofre perdas.
<p>- E todo mundo mata pessoas?
<p>- Aí depende, você quer me matar?
<p>- Não, eu estou querendo dizer que eu já matei.
<p>- Ah, mas é claro. – Jason riu, mas parecia que Kol estava falando sério. – Com faca e tudo?
<p>- Olha, não enche. Eu não quero sua amizade e nem de mais ninguém. Eu estou feliz sendo isolado.
<p>- Eu não vou tentar mais então.
<p>- Não tente. E se falar para alguém sobre o que eu disse...
<p>- Eu vou ser a sua próxima vítima? – Jason completou ainda achando que Kol estava brincando.
<p>- Fica longe.
<p>- Pode deixar.
<p>Jason fez questão de fechar o livro que Kol estava lendo só para irritar.
<p>A biblioteca era muito grande, ele não tinha muito costume de andar muito por lá, mas agora ele precisava. Estava querendo achar alguém que sabia que estaria lá.
<p>- Tempe? – Jason encontrou Temperance em um dos corredores de estantes.
<p>- Eu já disse para não me chamar mais de Tempe. – Ela ainda estava brava.
<p>- Ainda não acredita em mim? Acha que eu contei para alguém?
<p>- Pode não ter contado, mas alguém contou e só postaram para te atingir. Eu nunca tinha sido mencionada naquela miséria de blog até te conhecer.
<p>- De nada, agora você é conhecida.
<p>- Eu não quero ser conhecida, nem popular. Eu quero ser eu e sobreviver ao ensino médio.
<p>- Então a gente vai parar de se falar? É isso que você quer?
<p>- Você sabe que não é isso que eu quero. Mas que escolha eu tenho?
<p>- Tudo bem. – Jason riu para disfarçar o nervoso. - Sabe que a culpa é toda sua, não é?
<p>- O quê? – Temperance ficou surpresa.
<p>- Se você não fosse paradona, não teria escondido o que sentia pelo Bran por tanto tempo e ninguém estaria fazendo tanto caso por isso agora.
<p>- Me desculpa, mas nem todo mundo é sem-vergonha como você. – Temperance retrucou.
<p>- Me desculpa, mas falar que gosta de alguém não é ser sem-vergonha, é ter atitude. – Jason deixou Temperance sem fala.
<p>- Eu...
<p>- Já pensou se um dia o amor da sua vida, ou sei lá como você o chama, passar por você? O que você vai fazer? Ser amiga dele?
<p>- O que quer que eu faça?
<p>- Acorde para a vida. Ninguém tem que adivinhar o que você sente, você simplesmente vai e fala.
<p>- Eu posso levar um fora.
<p>- E daí? Pelo menos tentou. E quem daria um fora em você? Você é inteligente e bonita e beija bem, quer dizer, deve beijar.
<p>- Eu não sou de me arriscar.
<p>- Arriscar faz parte. Correr riscos é bom. Pode acabar dando de cara com algo incrível. Agora já pode dizer que me ama.
<p>- Cala a boca.
<p>- A Tempe legal voltou. – Jason fez cara feia para ela. – E quanto ao blog? Que se dane, fiquei muito tempo me preocupando com essa droga que não vai me adicionar em nada. Olha só.
<p>Jason pegou seu celular e entrou no blog.
<p>- “Garota e garoto pegos no banheiro dos professores”. Quem liga para isso? “Idiotas colando na prova de Matemática”. Todo mundo faz isso. – Temperance começou a rir. – “Beijos na escola...”. Espera aí. – Jason começou a ler.
<p>- O que foi? – Temperance se assustou.
<p>- Espero que a Lisa não veja isso.</p>
<br>
<p><i>“<b>BEIJOS NA ESCOLA:</b> Parece que a nossa linda Lisa além de ser perfeita, ainda é atirada. Boatos dizem que para conseguir um beijo do nosso amigo Cachinhos de Chumbo, ela precisou sequestra-lo, amarra-lo e força-lo a beijá-la. É isso mesmo, minha gente. Foi a garota que deu a iniciativa. Tenho certeza que se dependesse da lerdice do nosso colega, eles ainda estariam andando de mãos dadas pelo colégio. E agora? Será que a Lisa que vai ter que pedir o Brandon em namoro? Tô rindo aqui, foi mal. Bom, e antes de terminar a notícia, eu tenho um bônus. Parece que existe um assassino entre nós, mas isso é papo para outro dia.”.</i> – Tesouro de Segredos Obscuros.</p>
</body></html>";
            }

            if (numero == 7)
            {
                lblTitulo.Text = "Capítulo 7 - Mentira";
                htmlPage.Html = @"<html><body>
<p>Jason deu um soco na primeira estante que viu, alguns livros quase caírem no chão.
<p>- Desgraçado.
<p>- Nossa, o Bran vai ficar morrendo de vergonha. – Temperance estava lendo de novo.
<p>- Que se dane o Cabelo Para Cima, eu preciso falar com a Lisa.
<p>- Jason, eu acho melhor...
<p>- Como você se sentiu quando falaram de você?
<p>- Mas...
<p>- Eu sei que eu me sinto péssimo. Eu tenho que ir. – Jason saiu correndo da biblioteca.</p>
<center><h4>--*--</h4></center>
<p>Brandon estava passando pelos corredores e todo mundo parecia estar olhando para ele e comentando algo. Ele já sentiu um mal pressentimento e se fosse apostar em algo, apostaria no blogueiro.
<p>- Bran, oi. – Maddie veio correndo na direçao dele.
<p>- Maddie, o que está acontecendo?
<p>- Leia o blog da escola.
<p>- Por quê? De quem estão falando? – Brandon parecia ter ficado com medo do comentário de Maddie.
<p>- De você e da Lisa.
<p>- Eu não vou ler essa droga. Eu não quero saber.
<p>- Estão falando que ela é atirada e que você não presta para nada. – Maddie resumiu a notícia mesmo assim.
<p>- O quê?
<p>- Falaram sobre o beijo.
<p>- Ninguém sabe sobre o beijo. – Brandon ficou surpreso.</p>
<center><h4>--*--</h4></center>
<p>- Só você sabia sobre o beijo. – Lisa estava gritando com Jason no meio do pátio da escola sem se importar se alguém parasse para ouvir.
<p>- Eu não sabia que tinham se beijado em um lugar escondido. – Jason se defendeu.
<p>- Eu falo para você sobre o beijo e minutos depois sai no blog? Tem alguma coisa errada nisso.
<p>- O quê? Você está dando uma de Temperance Chata e acha que eu sou informante do blogueiro?
<p>- Não, eu não quero dizer isso.
<p>- Então o que você quer dizer? – Jason odiava brigar com Lisa, mas ela estava merecendo.
<p>- Eu quero dizer que ele está na sua cola. Nada mais que você sabe é seguro.
<p>- Quer dizer que eu virei uma bacia de água furada?
<p>- Não entendi.
<p>- E quando tudo isso virou culpa minha?
<p>- Olha, eu não estou brava com você, eu só estou brava... com você. – Lisa não conseguiu se explicar.
<p>- Ah, saquei. – Jason não sacou nada. – Não me conte mais segredos, tá bom? Até eu estou com medo de mim. E se o blogueiro contar que eu já fiz algumas coisas na sua casa sem você saber, tipo ficar com a sua prima?
<p>- Cala essa boca. – Lisa riu. – Espero que ele conte isso.
<p>- Bom, valeu a pena, você não tem ideia do que ela sabe fazer com...
<p>- Já chega. Menos detalhes.
<p>- Tudo bem. – Jason se calou.
<p>- Bom, o que a gente faz agora?
<p>- Como assim?
<p>- Esse infeliz falou de mim. Eu quero ele descoberto e humilhado.
<p>- Essa é a minha garota. – Jason se animou. – Vamos acabar com ele, mas antes eu tenho que fazer uma coisa.
<p>- O quê?
<p>- Fiquei sabendo que o Kol matou alguém. – Jason sussurrou.
<p>- Sério? O blogueiro mencionou isso. Agora tudo faz sentido.
<p>- É.
<p>- Olha, você não pode falar disso com o Kol, o blogueiro vai saber.
<p>- Eu não vou falar com o Kol. Eu vou ler algumas coisas, o blogueiro não vai saber, a não ser que ele tenha câmeras nas minhas retinas, isso seria assustador.
<p>- Seria. – Lisa fez cara de confusa e começou a rir.</p>
<center><h4>--*--</h4></center>
<p>- Oi, eu posso usar o computador? – Quando Jason chegou na biblioteca, os computadores, que ficavam em uma área para uso dos alunos, estavam todos sendo usados.
<p>- Eu estou usando ele. – A garota que estava no computador olhou feio para ele.
<p>- Emily? – Jason fez cara de espanto.
<p>- Jason? – Emily fez a mesma cara.
<p>- O que você faz aqui? – Ele abriu um sorriso depois.
<p>- Fazendo meu trabalho de filosofia.
<p>- Não sabia que estudava aqui, nunca tinha te visto.
<p>- Eu também nunca te vi aqui, mas quando disse que se chamava Jason, eu já associei com o Jason do blog.
<p>- “Jason do blog”? É assim que os desconhecidos me chamam?
<p>- É a sua fama.
<p>- Então você sabia porque eu estava com raiva naquele dia.
<p>- Eu imaginava.
<p>- E por que não disse nada?
<p>- Eu nem te conheço. – Emily falou o óbvio.
<p>- E por que não me disse que estudava aqui? – Jason ainda não entendia.
<p>- Olha, a gente conversou uma vez, só isso, supera.
<p>- Eu posso usar o computador? – Jason puxou uma cadeira para o lado da Emily e sentou.
<p>- Eu já disse que não.
<p>- É rapidinho. – Jason tomou conta do mouse e do teclado. Emily parecia brava, mas ficou quieta.
<p>- O que você quer? – Emily ficou observando Jason fechar suas janelas na tela.
<p>- Eu quero pesquisar umas notícias da cidade. Você é daqui, né? Nunca ouviu falar de algum assassinato?
<p>- Tipo por bandidos?
<p>- Não, tipo por adolescentes que rimem com Chacol. – Jason era péssimo em ser sútil.
<p>- Que eu saiba não.
<p>- Você conhece a Maddie e o Kol?
<p>- Sim, eles são irmãos, não é?
<p>- Sabe por que o Kol é tão estranho?
<p>- Ele está de luto. Perdeu a namorada em uma explosão no ano passado. Ele ficou tão mal que foi embora para Londres com os avós. Ficaram falando disso por aqui por dias.
<p>- Que tipo de explosão?
<p>- Um vazamento de gás, parece. – Ela pegou o mouse da mão de Jason e tomou controle do computador de novo. – Aqui.
<p>Jason olhou para a notícia estampada na tela do computador. Um vazamento de gás causou uma explosão na casa da garota matando ela e os pais. Não tinha muitos detalhes na notícia, mesmo assim, ele não entendia como que o Kol se culparia disso.
<p>- O blogueiro mencionou isso?
<p>- Não, tenho certeza que ele achou pesado demais.
<p>- Acho que minha pesquisa acabou.
<p>- Posso voltar para o meu trabalho agora? – Emily olhou feio para o Jason.
<p>- Claro, vai em frente, se delicie com filosofia, mas antes, me diga uma coisa.
<p>- Não.
<p>- Você lê o blog? – Ele perguntou mesmo assim.
<p>- Mais ou menos. Não sou viciada, mas de vez em quando eu dou uma olhada, também sou filha de Deus, não é?
<p>- E você acredita no que ele diz?
<p>- Bom, pode ser da maneira como ele acha, mas ele nunca mentiu, pelo menos não que eu saiba.
<p>- Como sabe? Investiga todas as histórias do blogueiro?
<p>- Claro, eu não tenho mais nada para fazer, não é?
<p>-Então...
<p>- No ano passado, a minha melhor amiga brigou com uma garota no corredor, eu acho que ela era uma daquelas que estudam o tempo todo, aí o blogueiro pegou no pé dessa minha amiga até ela não aguentar e sair da escola.
<p>- É a mesma coisa que ele está fazendo comigo. Mas por quê?
<p>- Talvez ele queira defender os oprimidos. – Emily falou sem se importar.
<p>- Ou cansou de assistir pornô o dia todo no quarto.
<p>- Por que tem tanta raiva dele? Quer dizer, todo mundo odeia ele e quer descobrir quem é, mas você exagera.
<p>- Você leu o que ele escreveu sobre mim? É ridículo.
<p>- Quer dizer que ele mentiu? – A pergunta pegou Jason desprevenido. – Você seria o primeiro.
<p>- Bom...
<p>- Quer dizer que você não é insensível?
<p>- Bom, também não é assim...
<p>- Quer dizer que você não troca de namorada o tempo todo e não leva nada a sério?
<p>- Bom, pode até ser, mas...
<p>- Quer dizer que você não é um safado sem vergonha?
<p>- Eu prefiro o termo “conquistador”. – Jason ficou sem jeito.
<p>- Qual é, Jason. Se você não fosse assim, ele não falaria mal de você.
<p>- Não me interessa o que ele pensa. Eu não vou mudar por que ele não gosta de mim assim. Ele nem me conhece. Você nem me conhece. – Jason já estava começando a ficar irritado.
<p>- Quer dizer que é assim que você pretende ser para o resto da vida?
<p>- Olha, eu não perguntei nada para você. – Jason ficou bravo.
<p>- Então sai daqui. Eu nem sei porque ainda estamos conversando. – Emily se virou para a tela do computador e começou a ignorar Jason.
<p>- Olha só, garota, eu não sou insensível nem sem vergonha ou qualquer coisa parecida. Eu vivo a vida.
<p>- Beijando a primeira garota que encontra?
<p>- O pior seria não beijar e ficar pensando em como seria o beijo.
<p>- Se acha que com essa conversinha vai conseguir me beijar, você está muito enganado. Além do mais, se me beijar agora à força, vai levar um soco. – Emily nem olhou para Jason.
<p>- Quer dizer que você não quer me beijar? Porque eu acho que quer. – Jason sorriu.
<p>- Bem que você queria, mas não. Agora sai. – Emily empurrou a cadeira de Jason para longe dela.</p>
<center><h4>--*--</h4></center>
<p>- Oi
<p>- Oi
<p>Lisa e Brandon se encontraram no meio do corredor da escola. Era engraçado como as notícias corriam.
<p>- Não acredito que falaram isso da gente. Você está bem? – Brandon parecia bem envergonhado.
<p>- Está tudo bem. O Jason já aguentou pior.
<p>- Me chamaram de lerdo.
<p>- Você foi um pouco lerdo. – Lisa riu. – Relaxa, estamos juntos, não importa como.
<p>- É, só que agora todo mundo pensa que eu sou um otário. Como o tal do blogueiro descobriu isso?
<p>- Do mesmo jeito que descobriu sobre a Temperance. Eu só contei pro Jason e...
<p>- Você contou isso para o Jason? Por quê?
<p>- Eu conto tudo para o Jason. Somos amigos.
<p>- Mas não precisava falar sobre isso. – Brandon não gostou de saber que Jason sabia de suas coisas.
<p>- Bran, relaxa.
<p>- Agora eu sou uma piada.
<p>- Logo, logo, vão postar outra coisa e o seu lance vai ser esquecido. E além do mais, o Jason logo vai desmascarar esse imbecil.
<p>- Como assim? – Brandon não entendeu. – Ele sabe quem é?
<p>- Não, mas quer descobrir. E quando o Jason coloca uma coisa na cabeça, ele vai até o fim.
<p>- Não é perigoso?
<p>- É um blogueiro da escola, não da máfia. Por que seria perigoso?
<p>- Eu não sei. O cara parece ser capaz de tudo.
<p>- Infelizmente, o Jason também.</p>
<center><h4>--*--</h4></center>
<p>- Oi, Kol. Viu? Eu disse seu nome, já é um progresso. – Jason se sentou na mesa em que Kol e Maddie estavam almoçando.
<p>- Deixa meu irmão em paz.
<p>- Maddie, vai caçar galo, tá bom? Eu não vim brigar, eu só vim dizer que descobri o mistério de vocês.
<p>- O quê? – Kol parecia interessado.
<p>- Sua namorada morreu em uma explosão de gás, eu sei.
<p>- Jason, para. – Maddie alertou.
<p>- Olha, eu sei que o luto é uma droga e eu não sei o que eu posso te dizer para você se sentir melhor ou sei lá, mas você tem que parar de ser assim. Não vai ajudar.
<p>- Me desculpa, não me lembro de ter marcado hora com você. – Kol ficou mais sério do que geralmente era.
<p>- Sabe, com a sua ignorância e tudo mais, eu achava que você fosse um pouco como eu, mas eu percebi que não. Porque eu não afasto as pessoas que querem me ajudar.
<p>- E você quer me ajudar? Disse outro dia que só estava me usando como sua boa ação.
<p>- Era brincadeira. – Mas aquilo não mudou a expressão de Kol. – Olha, que se dane. Você não quer ajuda, você pode ser até uma boa pessoa, mas é um imbecil. Como pode ter uma irmã tão alegre e irritante e ser assim?
<p>- Ei. – Maddie não gostou do comentário.
<p>- Vai fritar ovo, vai.
<p>- Olha, você não entende. O acidente foi culpa minha. – Kol sempre se culpava.
<p>- Não é culpa de ninguém quando acontece um acidente. O próprio nome já diz.
<p>- Eu não tenho carteira de motorista, eu estava dirigindo e mexendo no celular.
<p>“Não chama ele de otário, não chama ele de otário, você está tentando ser um cara legal, não chama ele de otário.”. Jason estava pensando.
<p>- Tudo bem. As coisas acontecem e você precisa lidar com elas. – Jason respirou fundo.
<p>- Ela era o amor da minha vida.
<p>- Você tem 17 anos, vai encontrar muitos amores da sua vida. Eu não estou dizendo que ela não era importante, mas você precisa superar e ser mais simpático com as pessoas.
<p>- Você não é simpático com as pessoas. – Maddie retrucou.
<p>- É o meu charme, mas não funciona para todos. – Jason sorriu.
<p>- Jason, podemos falar? – Brandon chegou por trás de Jason. Ele parecia furioso.
<p>- Agora não dá, Assolan.
<p>- Eu preciso que seja agora. – Brandon puxou Jason pelo braço. Estavam no meio do refeitório.
<p>- Calma, Cabelo de Nós Todos, quer levar outro soco? – Jason se levantou e encarou Brandon.
<p>- Você viu o que você causou? – Brandon tentou sussurrar já que todos estavam prestando atenção na conversa dos dois.
<p>- Eu causo muita coisa, precisa ser mais especifico.
<p>- O lance do blog.
<p>- Ah, aquilo. Aquele post que te chamam de mosca morta? Eu queria ter escrito aquilo.
<p>- Você é um ridículo.
<p>- Pode até ser. Olha, por que você está falando comigo mesmo? Quer que eu te ensine a lavar louça com o seu cabelo?
<p>- Fica longe da Tempe e fica longe da Lisa.
<p>- Sim, senhor. – Jason fez cara de soldado debochado. – Mais alguma coisa? Me pede para ficar longe da Maddie também, por favor.
<p>- Você só faz mal a elas.
<p>- E você quer protege-las? Olha, eu sei que o seu cabelo é volumoso, mas ainda não virou uma caverna onde você pode colocar as duas garotas lá e não soltar mais.
<p>- Então é isso que você quer? Ter a Lisa no blog o tempo todo? Porque é isso que vai acontecer.
<p>- Eu conheço a Lisa há seis anos, você a conhece há quanto tempo? Seis dias? Não venha aqui bancando o machão me mandando ficar longe dela, porque eu só vou me afastar quando ela quiser, está me escutando? Ou tem muito cabelo na sua orelha? Agora cai fora.
<p>- Eu não gosto de você.
<p>- É uma pena, eu estava começando a gostar da sua juba.
<p>Jason sorriu e saiu do refeitório sentindo todos os olhares do lugar em cima dele.</p>
<center><h4>--*--</h4></center>
<p>- O Bran foi brigar com você? – Temperance ouvia Jason de olhos arregalados.
<p>Os dois estavam sentados um do lado do outra na sala esperando a aula de matemática começar.
<p>- Exatamente, seu amigo Cabelo de Bombril me pediu para se afastar de você e da Lisa. Droga, eu agora estou quebrando as regras. – Jason fingiu tristeza.
<p>- Ele é super protetor. E agora namorando a Lisa...
<p>- É, só que nada vai mudar entre a Lisa e eu.
<p>- Mas sabe que ele pode ter razão.
<p>- Você defendendo o Experiência de Cachos Malfeita? Que surpresa.
<p>- O Blogueiro vai pegar no seu pé e no de todos que te rodam, até você desistir. Ele fez isso com uma garota o ano passado quando ela começou a arranjar encrenca comigo.
<p>- Você é a garota que gosta de estudar muito? – Jason se lembrou da história que Emily contou.
<p>- O quê?
<p>- Deixa para lá. O blogueiro te defendeu, que lindo. Mas eu nunca fiz mal para ninguém, ou talvez eu tenha ficado com a irmã dele. Fácil, eu só preciso descobrir se as garotas com quem eu fiquei tem irmãos.
<p>- Você vai perguntar para todas elas?
<p>- Claro, pelo menos as que eu lembrar.
<p>- Que nojo.
<p>- Quando ficar com alguém não vai conseguir parar.
<p>- Filosofia interessante.</p>
<center><h4>--*--</h4></center>
<p>Jason passou correndo no seu armário para pegar seu livro de história, estava atrasado para a aula. Estavam todos falando dele, pareciam estar com cara de desprezo.
<p>- E o blog deve ter atacado de novo. – Ele disse.
<p>- Olá. – Emily passou por ele com o celular na mão.
<p>- Oi, espera. – Ele pegou o livro correndo e alcançou Emily. – Meu celular está sem bateria, você poderia me...
<p>- Você é um idiota. – Emily finalmente falou.
<p>- O quê? O que foi que eu fiz? – Jason pegou o celular da mão dela.
<p>- Acabou com a sua amiga.
<p>- Eu fiz o quê?</p>
<br>
<p><i>“<b>E MAIS SEGREDOS SÃO REVELADOS E EU ESTOU ADORANDO ISSO:</b> Bom, parece que o Jason está disposto a me encontrar. Colega, é só olhar por aí, você vai encontrar seu melhor amigo postando sobre você. Brincadeiras à parte, vamos logo ao que interessa.  Essa notícia é para você que já viu a linda Lisa pelos corredores e nunca chegou a falar com ela, mas morre de vontade de saber como ela é. Bom, segundo fontes bem próximas do melhor amigo dela, Lisa não é o que chamamos de a melhor pessoa do mundo, como amiga ela é nota zero, mas para outras coisas, ela até que sabe fazer bem quando você está entediado (palavras dele e não minhas, viu galera? Eu não sei de nada, só estou repassando o que eu ouvi). Bom, Lisa, eu ainda te amo, mas vamos melhorar né garota? Além do mais, nada a ver Jason e Bran ficarem brigando por você o tempo todo, é tão sem graça, você não vale tudo isso. Valeu pelas informações, Jason, estou te devendo essa.”</i>. – Tesouro de Segredos Obscuros.</p>
<br>
<p>Assim que Jason terminou de ler, seus olhos saíram da tela do celular e foram para Lisa que estava parada na sua frente.
<p>- É verdade? – Ela parecia ter chorado.
<p>- Lisa, é claro que não.
<p>- Eu sei que você não disse para o próprio blogueiro, mas para quem você disse isso?
<p>- Para ninguém. Lisa, eu nunca falaria uma coisa dessa de você para alguém.
<p>- Você deveria ser meu melhor amigo. – Ela estava quase chorando.
<p>- Mas eu sou. – Jason se aproximou dela para tentar ampará-la.
<p>- Fica longe de mim. – Lisa empurrou Jason para a longe e saiu correndo.
<p>- Lisa! – Jason gritou.
<p>Jason respirou fundo e olhou em volta. Só tinha gente julgando ele pelos olhares em todos os lugares.
<p>- Eu não disse isso. – Ele encarou Emily, mal a conhecia, mas precisava que ela acreditasse nele, alguém precisava acreditar nele. – Eu não disse isso para ninguém.
<p>- O blogueiro mentiu, então? – Emily ficou confusa. – Você deve ter irritado muito ele para esse nível de desespero.
<p>- Ele é um filho da mãe. – Jason estava quase explodindo de raiva.</p>
</body></html>";
            }

            if (numero == 8)
            {
                lblTitulo.Text = "Capítulo 8 - Amigos";
                htmlPage.Html = @"<html><body>
<p>Brandon chegou empurrando Jason contra os armários.
<p>- Qual é o seu problema?
<p>Emily se assustou com o ocorrido.
<p>- Calma aí, Cabelo de Macarrão Torrado. – Jason se ajeitou depois de ser pego desprevenido.
<p>- Eu não acredito que você fez isso. – Brandon estava furioso.
<p>- Eu não fiz nada.
<p>- Você é um imbecil.
<p>- Olha só, cai fora. Eu estou sem paciência, e muito menos para você.
<p>- Você vai pagar. Eu não vou deixar você fazer isso com a Lisa. – Brandon não parou de ameaçar.
<p>- Eu não fiz nada. – Jason gritou e todo mundo parou para ouvir.
<p>- Ah, não? E de onde o blogueiro tirou tudo aquilo?
<p>- Sai daqui, Capacete de Cabelo. Sai agora. – Jason estava tentando não socar o Brandon de novo.
<p>- Fica longe da Lisa. – Brandon apontou o dedo em sinal de aviso. – Senão...
<p>- Você vai fazer o quê? – Jason o enfrentou.
<p>- Você vai ver. – Brandou gritou e então foi embora.
<p>- Muda o disco! – Jason gritou.
<p>- Calma. – Emily olhava para Jason assustada.
<p>- O que você quer? – Jason não estava a fim de ser educado naquele momento.
<p>- O quê? – Ela ficou confusa.
<p>- Por que ainda está aqui?
<p>- Achei que você fosse precisar de ajuda.
<p>- Eu estou parecendo que preciso de ajuda? – Jason encarou Emily.
<p>- Não, está parecendo que precisa de uma surra. – Emily ficou brava. – Não está mais aqui quem falou.
<p>Emily deu as costas para ele e foi embora irritada.
<p>- MAS QUE INFERNO! – Jason gritou enquanto tacava sua mochila no chão.</p>
<center><h4>--*--</h4></center>
<p>- Lisa, espera. – Brandon correu atrás de Lisa no meio do pátio da escola.
<p>- Bran, eu preciso ficar sozinha agora. – Lisa começou a chorar.
<p>- Ei, eu não vou te deixar sozinha. – Ele pegou no braço dela para impedi-la de ir embora.
<p>- Por que ele fez isso comigo?
<p>- Eu não sei.
<p>- Eu estou tão decepcionada com ele agora. – Lisa limpou as lágrimas do rosto com as palmas das mãos.
<p>- Olha, eu também estou com raiva, mas na verdade, não acho que ele tenha feito algo assim. Parece meio estranho, até para ele.
<p>- Está defendendo o Jason? – Lisa ficou surpresa e quase não acreditou no que ouviu.
<p>- Não, se lembre, eu estou do seu lado, mas eu acho que, sei lá, isso está muito estranho.
<p>- Eu estou me sentindo horrível.
<p>- Olha, eu estou aqui e nunca vou fazer algo para te magoar.
<p>- Promete?
<p>- Prometo.
<p>Lisa estava muito frágil naquele momento e precisava ouvir aquela promessa de Brandon.
<p>- Eu gosto muito de você e espero que seja o suficiente, porque eu não sei o que fazer para te deixar melhor. Não quero te ver desse jeito.
<p>- Eu também gosto muito de você. – Lisa abraçou Brandon. – Você do meu lado é a melhor coisa agora.</p>
<center><h4>--*--</h4></center>
<p>- Você é um ridículo. – Kol se sentou na mesa em que Jason estava no refeitório.
<p>- Quer uma chance para me xingar? Entra na fila, vai querer uma foto ou um autógrafo? – Jason fechou a cara. Os papeis estavam invertidos?
<p>- Sabe, por um momento, você falando aquelas coisas legais, eu achei que você fosse decente.
<p>- Olha, eu não estou...
<p>- Você fez uma coisa horrível.
<p>- Lembra quando você disse que não queria falar comigo? Por que não volta para essa parte de novo? Você é a última pessoa com quem eu quero falar agora.
<p>- Você muda rápido de opinião. – Kol não disfarçou o tom de deboche.
<p>- Olha, esse sou eu sendo eu mesmo. – Jason o encarou. – Não estou fingindo que me importo com você e nem estou a fim de fazer caridade agora, então some!
<p>- Eu quero mesmo que a Lisa não te perdoe.
<p>- E eu quero que você vá para a delegacia e confesse que você matou a sua namorada. – Jason não pensava mesmo no que falava.
<p>- Bom, eu não vou levar isso a sério porque eu sei que é da boca para fora.
<p>- Não, você não sabe.
<p>- Você está mal e está atacando com o que tem. Isso é normal.
<p>- Foi mal. – Jason se desculpou, mesmo não dando a mínima.
<p>- Olha...
<p>- Você conhece a pessoa por um milhão de anos, e na hora que você precisa, ela não acredita em você. Pelo menos sua namorada está morta e não vai mais te decepcionar.
<p>- Você não pensa antes de falar?
<p>- Eu só quero que você vá embora, mas parece que você sempre faz o oposto do que eu quero.
<p>- Eu não sei o que dizer. Na verdade, você disse uma coisa legal para mim e eu meio que queria te pagar. Mas eu...
<p>- Eu não preciso disso. Você tem razão, não somos amigos. Você não precisa dizer nada.
<p>- Lisa não acreditar em você é o que mais está te irritando?
<p>- Eu não ligo para o que essas pessoas dizem. Quer dizer, eu até ligo, mas eu sei lidar com isso, soco umas paredes, grito, faço drama, a raiva some logo. Mas a Lisa, ela é a minha melhor amiga. Eu acreditaria nela se fosse o caso.
<p>- Nem todo mundo é como você.
<p>- Por que não? Isso facilitaria muito a minha vida. – Kol ficou calado ouvindo ele falar. – Agora, antes que eu peça para você me matar, sai daqui, eu preciso ficar sozinho.
<p>- É muito legal ficar irritando as pessoas, não é? – Jason estava provando do próprio veneno.
<p>- Tudo bem, eu já entendi a mensagem. Você venceu. Pode ir agora?
<p>- Só quando você estiver muito bravo. – Kol riu. O primeiro riso que Jason viu no rosto dele desde que os dois se conheceram.
<p>- O que eu fiz para você? Me odeia tanto assim? – Jason olhou para cima. Ele estava falando com Deus.
<p>- Você não faz ideia. – Kol respondeu no lugar de Deus.
<p>- Cala a boca.</p>
<center><h4>--*--</h4></center>
<p>- Ai, eu sinto muito por não aparecer antes. – Temperance veio correndo atrás de Jason quando ele estava saindo do colégio.
<p>- Tudo bem. – Jason não entendeu o desespero de Temperance.
<p>- Eu estava em uma aula de biologia muito interessante e...
<p>- Já chega. Eu disse que está tudo bem.
<p>- Eu li o que o blogueiro escreveu. Eu sei que ele estava mentindo. – Ela disse logo.
<p>- Fala isso pra Lisa. – Jason estava desanimado.
<p>- A Lisa é uma chata, não merece que...
<p>- Olha, também não precisa falar dela desse jeito.
<p>- Você ainda a defende? – Temperance ficou brava.
<p>- Defendo, tem algum problema com isso?
<p>- Nenhum. – Ela quis evitar um confronto naquele momento.
<p>- Olha, eu estou indo embora, tá bom? – Jason não queria mais falar sobre aquele assunto.
<p>- Ainda faltam três aulas.
<p>- Mas eu quero ir embora. Algum problema? – Ele demonstrou bem que estava sem paciência.
<p>- Ao invés de fugir, talvez devesse ir falar com a Lisa se ela é tão importante assim.
<p>- Olha só, por que não vai ler um livro que você ganha mais?
<p>- Com raiva, você é um saco.
<p>- Então vai embora, não estou te prendendo.
<p>Temperance deu um tapa na cara de Jason.
<p>- Ai!
<p>- Você merece tudo o que está acontecendo com você.
<p>- Olha, tudo bem, eu entendi. Eu virei um idiota.
<p>- Com toda a certeza.
<p>- Todo mundo está achando que eu estou exagerando e que eu estou fazendo drama. – Jason estava descontrolado. – Mas tem um infeliz falando mal de mim na internet e acabando com a minha vida. Eu tenho o direito de fazer o drama que eu quiser.
<p>- Vai falar com ela.
<p>- Não.
<p>- Vai, antes que eu te puxe pelos cabelos.
<p>- Você não alcança meu cabelo e ele não é tão volumoso quanto do Bran.
<p>- Se você parasse de zoar o Bran e usasse esse tempo para fazer as pazes com a sua querida Lisa, vocês já estariam bem agora.
<p>- O que você quer que eu fale para ela?
<p>- A verdade.
<p>- Ela não vai acreditar.
<p>- Então manda ela se lascar.
<p>- Você não entende.
<p>- Ainda bem. </p>
<center><h4>--*--</h4></center>
<p>Jason encontrou Lisa e Brandon sentados em uma mesa na biblioteca estudando. Ele já tinha procurado por ela por toda a escola, mas não esperava que ela estivesse com o namorado, o que pareceu idiota depois que ele percebeu que Brandon não ia querer desgrudar depois dela ser atacada.
<p>- Lisa, eu posso falar com você?
<p>- Eu não posso falar agora. – Lisa ignorou Jason.
<p>- Lisa, qual é? Vai ser rápido. – Jason insistiu.
<p>- Agora não dá.
<p>- Fala sério.
<p>- Eu não quero falar com você. – Lisa só não gritou porque estava na biblioteca, ela se controlou.
<p>- Então é isso?
<p>- É. – Lisa virou a cara.
<p>- Ótimo, é para isso que os amigos servem, né?
<p>- Aparentemente servem para falar mal de você. - Lisa retrucou.
<p>- Tem certeza disso?
<p>- Tanta certeza que eu nem sei mais porque eu me surpreendi com o que aconteceu.
<p>- Quer saber? Que se dane então.
<p>Jason virou as costas e saiu da biblioteca bufando de raiva.
<p>- Jason! – Brandon foi atrás de Jason.
<p>- O que você quer, Sansão antes da chapinha? – Jason estava cansado de falar com ele. – Quer que eu fique longe da Lisa? – Ele imitou a voz de Brandon.
<p>- Eu não quero brigar.
<p>- Que ótimo. – Jason fingiu estar feliz.
<p>- Quer um conselho? Dê um tempo para ela. Não força a barra. Ela vai pensar melhor e vai te procurar.
<p>- Você está bem? - Jason não estava acreditando no que estava ouvindo. – Andou fumando o cabelo, é?
<p>- Eu cansei dessa tensão.
<p>- Você é muito estranho.
<p>- Aceita a trégua. Sei que você também está cansado de brigar.
<p>- Na verdade, brigar é meu exercício matinal, então eu nunca me canso. – Jason não perdia a piada nem naquele momento. – Olha só, Crespinho, eu vou seguir o seu conselho.
<p>- Isso é bom.
<p>- Cuida dela enquanto eu estiver longe.
<p>- Pode deixar.
<p>Jason respirou fundo. Olhou para Brandon e soube o que tinha que fazer.
<p>- Bran, me desculpa, tá bom? Às vezes nem eu me aguento. – Jason sentiu vontade de se desculpar
<p>- Tudo bem. – Brandon sorriu. – Olha só, me chamou de Bran pela primeira vez.
<p>- Não acostuma, não, Cabelo de nega.</p>
<center><h4>--*--</h4></center>
<p>- Olha, eu quero dizer que eu sinto muito e eu acredito que não falou nada daquilo que o blogueiro postou sobre a Lisa. – Maddie se sentou ao lado de Jason na aula de Física.
<p>- Valeu. – Jason até piscou para ela. – Eu só implico com você, por que está sendo legal comigo?
<p>- Você tentou ajudar meu irmão e amigo do meu irmão é meu amigo.
<p>- Por isso que ele não tem nenhum amigo. – Jason deixou escapar. – Foi mal, saiu sem querer.
<p>- Tudo bem. – Maddie sorriu.
<p>- Olha, você também deve ter sofrido, quer dizer, do jeito que você é feliz, devia ter sido grande amiga da namorada do seu irmão.
<p>- É, foi horrível para todos nós.
<p>- Eu sinto muito.
<p>- Ela me ensinou a ser como eu sou.
<p>- Quer dizer que ela era pior que você? – Jason se assustou. – Foi mal de novo.
<p>- Ela era sim. – Maddie riu.
<p>- Você viu a explosão?
<p>- Não, mas receber a notícia foi a pior coisa.
<p>- Eu não imagino como é ouvir esse tipo de coisa.
<p>- Espero que nunca saiba. Não desejo isso para ninguém.
<p>- Me deu até vontade de te abraçar. – Jason sorriu. – Ainda bem que já passou.
<p>- Cala a boca. – Maddie riu.
<p>- Agora falando sério. – Mas Jason estava rindo também. – Você pode ser chata, irritante e um saco, mas continue assim alegre, faz bem.
<p>- Valeu, eu acho. No fundo, você é uma boa pessoa.
<p>- Bem lá no fundo, só preciso ser essa pessoa mais vezes, mas é tão difícil.
<p>- Não é impossível.
<p>- Não diga para ninguém que tivemos essa conversa.
<p>- Combinado. – Maddie riu.</p>
<center><h4>--*--</h4></center>
<p>Ir para casa depois da escola não estava entre as opções que Jason tinha naquele dia. Ele saiu de fininho depois das aulas para ninguém segui-lo ou tentar conversar com ele. Jason queria paz.
<p>A praça que estava toda escura e solitária naquela noite que ele foi lá, agora estava muito diferente. Os raios de sol iluminavam tudo e haviam várias pessoas por lá, algumas caminhando sozinhas, outras acompanhadas de outras pessoas ou animais de estimação, crianças andando de bicicleta ou skate. Barraquinhas de comida e balões, não era uma praça tão ruim, ele pensou.
<p>Seu banco estava ocupado. Emily estava sentado nele lendo um livro bem grosso. Ela estava bem concentrada até ele a interromper.
<p>- Emily? Oi. – Ele estava um pouco acanhado. A última conversa dos dois não tinha sido muito boa.
<p>- Oi. – Emily foi educada.
<p>- Você vem sempre aqui? – Ele sorriu para tentar quebrar o clima ruim.
<p>- Não, mas parece que você sim. – Ela continuou séria.
<p>- Está aqui há muito tempo?
<p>- Não que isso te interesse, mas estou aqui desde a terceira aula.
<p>- Matando aula? Acha bonito isso?
<p>- Era aula de literatura, quem quer isso?
<p>- Aparentemente você, já que está lendo um livro.
<p>- Devia tentar algum dia. Não seria ruim colocar um pouco de cultura na sua cabeça.
<p>- Um romance idiota não é bem cultura.
<p>- Tchau, Jason. – Emily voltou sua atenção para o livro.
<p>Jason achou melhor não tentar forçar mais uma conversa então se afastou. A praça tinha uma lagoa praticamente escondida por árvores. Ele se sentou na grama e ficou observando as garças pousando na água.
<p>Emily foi até a lagoa depois alguns segundos e se sentou perto dele, mas não tão perto.
<p>- Não é um romance idiota. – Ela falou.
<p>- Tudo bem. – Jason respondeu.
<p>- Você está melhor?
<p>- Olha, eu não mordo, sabia? – Jason se aproximou.
<p>- Vai saber. – Emily se afastou um pouco. – Agora responda minha pergunta.
<p>- Não é tão legal quando todo mundo diz que você não é uma boa pessoa, mas eu vou ficar bem um dia.
<p>- Quem liga para o que dizem? Você não é mau, só é um cara insuportável. Tem uma diferença. – Ela sorriu.
<p>- Obrigado, eu acho.
<p>- Mas o que eu sei? Nem te conheço.
<p>- Bom para você.
<p>- Olha, o blogueiro inventou aquilo, tudo bem.
<p>- Você disse que ele nunca mentia.
<p>- Tem que ter uma primeira vez para tudo. A Lisa ainda está brava? – Emily parecia se importar.
<p>- Está, e quando aquela garota fica brava, nem exorcismo ajuda.
<p>- Ela vai cair na real.
<p>- Por que você se importa?
<p>- Ela é sua melhor amiga, não é? Amigos são importantes.
<p>- E cadê os seus?
<p>- Ah... Minha... minha única amiga foi embora por causa do blogueiro.
<p>- Vocês não se falam mais?
<p>- Bom, os horários da escola dela são diferentes e... ela está fazendo um monte de cursos extracurriculares... tem o fuso-horário... a gente mal se fala pelo telefone.
<p>- Eu sou um ótimo ouvinte, se quiser falar sobre qualquer coisa.
<p>- Você é tão engraçado. – Emily começou a rir.
<p>- Por quê? – Jason não entendeu.
<p>- Você parece que tem esse desejo de ser adorado por todo mundo. É estranho. Você força demais.
<p>- Eu odeio quando isso não acontece, por isso goste de mim.
<p>- Eu estou tentando, é sério.
<p>- Ah, qual é? Não é tão difícil. Eu sou a melhor pessoa.
<p>- Mas é claro que é.
<p>- Sabe, você é muito difícil de decifrar. Por que não me deixa saber o que está pensando?
<p>- Eu não vou me abrir com você.
<p>- Não confia em mim?
<p>- Não. E nem é por causa do blogueiro. Eu simplesmente não te conheço.
<p>- Ah, qual é? Você já me viu no meu pior momento. É claro que me conhece. Deixa eu te conhecer.
<p>- Olha, isso não tem sentido. Para que tudo isso? Logo o blogueiro vai te fazer ir embora da escola.
<p>- Eu nunca vou deixar o blogueiro fazer isso comigo. E além do mais, eu nunca te deixaria.
<p>- Ai, meu Deus. – Emily não parava de rir. – Você estragou essa conversa boa com uma cantada barata.
<p>- Esse sou eu, se acostume. – Jason se sentou mais perto de Emily, ela não se afastou. Ou ela não tinha percebido ou não queria se afastar.
<p>- Até que foi bonitinha.
<p>- Eu falei sério.
<p>- Óbvio. Quando o blogueiro vai começar a falar de mim?
<p>- Talvez amanhã. Tudo bem para você?
<p>- Eu não sei, eu morro de medo de pessoas que se escondem atrás de um computador, me dão arrepios. – Emily fingiu medo.
<p>- Relaxa, eu te protejo.
<p>- E acabou de quebrar seu próprio recorde. Atacou de novo.
<p>- E nem é sexta-feira treze.
<p>- Cala a boca. – Emily parecia estar se divertindo.
<p>- Seu sorriso é lindo, alguém já te disse?
<p>- Não. – Emily ficou sem graça.
<p>- Agora fale dos meus olhos castanhos e meu cabelo perfeito. – Jason se aproximou mais.
<p>- Acho melhor não. Primeiro, seu cabelo parece que não conhece um pente e segundo, daqui a pouco você vai estar sentando no meu colo. – Emily se levantou.
<p>- Você fez curso de Quebrar o Clima ou sai naturalmente?
<p>- Sai naturalmente. – Emily sorriu.
<p>- Foi o que eu pensei.</p>
<center><h4>--*--</h4></center>
<p>- A Lisa está muito mal.
<p>Brandon e Temperance estavam em uma loja de CDs. Eles iam ali desde pequenos olhar discos, às vezes ficavam por horas.
<p>- Por que não está com ela? – Temperance parecia cansada de falar na Lisa.
<p>- Ela queria ficar um pouco sozinha. Eu dei um espaço para ela.
<p>- Que namorado perfeito. – Temperance foi sarcástica.
<p>- Olha só o que você perdeu. – Brandon brincou.
<p>- Você não acha que o Jason disse aquilo, né? – Ela mudou de assunto logo.
<p>- Acho que não. Não teria porquê. Mas a Lisa...
<p>- É uma idiota e não entende. – Temperance completou.
<p>- Não é isso. Ela levou um choque. Ela precisa processar um pouco as coisas.
<p>- Namorado defendendo a namorada, que novidade.
<p>- Quer uma novidade bem assustadora? Você defendendo o Jason. Como assim?
<p>- Ele não é como todo mundo pensa.
<p>- Ele já tentou te beijar?
<p>- Não. – Temperance riu. – E nem vai.
<p>- E tudo bem para você?
<p>- Eu não gosto do Jason.
<p>- Claro que não. Afinal ele não é cara para você. Você merece alguém perfeito.
<p>- Espero que esse alguém perfeito já tenha nascido.
<p>- A culpa não é minha que você seja muito exigente. Mas ele vai te encontrar, Tempe, eu sei disso.
<p>- Se você está dizendo, eu acredito.</p>
<center><h4>--*--</h4></center>
<p>Jason subiu as escadas e andou no corredor até seu quarto bem devagar evitando fazer barulho, mas foi em vão. Lisa estava esperando por ele no seu quarto.
<p>- Lisa? – Ele parou na porta quando viu ela sentada na sua cama.
<p>- A gente precisa conversar. – Ela falou.
<p>- Agora você quer falar?
<p>- O que queria que eu fizesse?
<p>- Acreditar em mim seria o mínimo. – Jason estava cansado de se desculpar.
<p>- Acho que é meio impossível.
<p>- Então o que quer falar, Lisa? Quer dizer que me odeia, que está brava, gritar? Eu não preciso disso.
<p>- Eu preciso de um tempo. As pessoas estão me criticando e rindo da minha cara. Já até aconselharam o Brandon a me deixar.
<p>- O Enroladinho não vai te deixar por causa disso.
<p>- Não interessa. Eu estou na boca do povo agora.
<p>- Achei que não se importava com o que as pessoas falavam.
<p>- Me importo tanto quanto você.
<p>- Engraçado dizer isso.
<p>- Todo mundo fala que não se importa, mas a verdade é que é horrível passar pelas pessoas e elas falarem mal de você pelas costas.
<p>- O que eu posso fazer? Me diz que eu faço.
<p>- Quero que saia da minha casa. Eu preciso ficar longe de você por um tempo.
<p>- Lisa, você não pode estar falando sério.
<p>- Jason, eu estou falando muito sério.
<p>- Eu não tenho para onde ir.
<p>- Eu vou pedir para minha tia te dar dinheiro para...
<p>- Não. – Jason ficou sério.
<p>- Jason, não dificulta as coisas.
<p>- Eu estou dificultando as coisas? E sobre todas as vezes que você disse que ficaria do meu lado? Para que se mudou de cidade comigo então se eu não sou tão importante para você?
<p>- Você é importante para mim.
<p>- Não sou, não. Você está me descartando como se eu fosse qualquer um. Nem o benefício da dúvida eu ganhei.
<p>- Eu estou mal.
<p>- Não me interessa nenhum pouco se você está mal! – Jason gritou. – Não me interessa mais nada.
<p>- Jay, eu só te peço um tempo. Eu sei que somos amigos desde sempre e... – Os olhos de Lisa se encheram de lágrimas.
<p>- Parece que somos mais. Só sai do quarto, eu preciso guardar as minhas coisas e achar um lugar para ficar.
<p>- Jason...
<p>- Sai. – Ele não tinha mais vontade de gritar, nem raiva ele tinha mais.
<p>Lisa se levantou da cama e foi em direção a porta
<p>- Eu sinto muito.
<p>- Eu também.
<p>Jason fechou a porta do quarto na cara de Lisa.</p>
</body></html>";
            }

            if (numero == 9)
            {
                lblTitulo.Text = "Capítulo 9 - Culpa";
                htmlPage.Html = @"<html><body>
<p>Lisa tinha dito que precisava de um tempo na amizade com Jason, que precisava de espaço. Agora ele estava no quarto guardando suas coisas na mala. Ele tinha sorte de não ter trazido muita coisa de Los Angeles.
<p>Agora ele tinha três malas, ia sair de casa e só tinha o dinheiro de emergências que seus pais tinham dado a ele. Não ia aceitar o dinheiro que Lisa tentaria dar a ele.
<p>- Tempe, oi. – Jason se encontrou com Temperance na porta da sorveteria.
<p>- Eu quero um sorvete de limão. – Ela já entrou no lugar escolhendo o sorvete que queria.
<p>- É, azedo como você. – Jason estava de muito mal humor. – Eu posso falar dos meus problemas agora?
<p>- O que aconteceu? – Temperance se preparou para ouvir.
<p>- Lisa e eu não somos mais amigos.
<p>- Achei que isso fosse acontecer. – Ela não ficou surpresa.
<p>- Isso é horrível, está bem? Eu não tenho onde morar.
<p>- Ela te expulsou de casa? – Agora sim ela estava surpresa.
<p>- Sim, ela quer um tempo. Estou de malas prontas.
<p>- Eu não acredito que ela fez isso. – Temperance ficou de boca aberta. – Foi bem desnecessário. E agora você vai morar aonde?
<p>- Ah, sei lá. Na casa de uma outra amiga. – Jason sorriu para Temperance.
<p>- Não. – Ela ficou séria.
<p>- Ah, qual é, Tempe. Você não tem nenhum lugar para mim? Um sofá? Um quarto de hospede? Uma poltrona?
<p>- Não.
<p>- Você pode dormir no chão e me emprestar a cama.
<p>- Não. – Temperance não ia mudar de ideia.
<p>- Por que não?
<p>- Meus pais nunca iam deixar você ir morar lá em casa.
<p>- Ah, qual é? A gente não ia dormir junto ou nada disso, a não ser que você queira, sei lá. Eu sou um ótimo hóspede.
<p>- Não.
<p>- Então aonde eu vou morar?
<p>- Tem um viaduto aqui perto que é bem confortável.
<p>- Sério? Por que não se muda para lá então?
<p>- Porque eu tenho uma casa. – Temperance riu. – Agora eu vou pegar o meu sorvete de limão.
<p>- Espero que se engasgue com ele.
<p>- Impossível.
<p>- Então que pegue uma gripe e morra.</p>
<center><h4>--*--</h4></center>
<p>- Vocês não são mais amigos? – Brandon estava consolando Lisa.
<p>Lisa havia ligado para Brandon assim que Jason saiu de casa. Ele foi para lá bem rápido. Encontrou uma Lisa em prantos.
<p>- Eu pedi um tempo. Eu preciso pensar um pouco.
<p>- Eu imagino como deve ser. Eu não sei como eu ficaria se brigasse com a Tempe.
<p>- Eu nunca pensei que a gente brigaria assim.
<p>- E... não está pensando em reconsiderar? – Brandon hesitou um pouco antes de falar.
<p>- Como assim?
<p>- Vai ver o blogueiro entendeu errado ou inventou, sei lá. Não acredita nas desculpas do Jason?
<p>- Eu não sei. O que mais ele vai “inventar” sobre mim? – Lisa ainda não estava pensando em reconsiderar, mesmo sabendo que aquilo doía muito.
<p>- Eu não sei. Mas você acha que isso é culpa do Jason?
<p>- Acho, afinal eu não fiz nada, a não ser que o blogueiro seja uma garota que tem inveja de mim não sei por que.
<p>- Bom, pode ser verdade. Você é perfeita, isso causa um pouco de inveja.
<p>- Para. Eu não sou perfeita.
<p>- Para mim, você é.
<p>- Que fofo. Obrigada.
<p>Brandon beijou Lisa.
<p>- Não parem por minha causa. – Jason interrompeu de cara feia.
<p>Ele passou pelo corredor e como a porta do quarto de Lisa estava aberta, viu Brandon e Lisa se beijando sentados na cama.
<p>- Jason? – Lisa ficou surpresa em vê-lo.
<p>- Relaxa, eu já estou indo. Só vim pegar minhas malas.
<p>- Indo para onde?
<p>- Você me expulsou. Achei que fosse óbvio. – Jason encarou Lisa.
<p>- Jason, eu... Eu não falei sério, eu não quis dizer... – Lisa não esperava por isso.
<p>- Você foi bem clara mais cedo.
<p>- Não, você não precisa ir embora. Eu exagerei por causa da raiva, eu não quero que você saia. Além do mais, você não tem para onde ir. – Lisa se levantou da cama e foi em direção a Jason.
<p>- Olha, eu estou bem, tá bom? Me recomendaram um viaduto ali, parece ser bem confortável. – Jason fazia piada até quando o assunto era sério.
<p>- Não precisa ir. Você não tem para onde ir.
<p>- Eu não preciso de caridade. Eu me arranjo.
<p>- Jason, não faz assim.
<p>- Você que quis brigar, Lisa, eu só estou entrando na sua onda.
<p>Jason pegou suas malas e desceu as escadas. Do andar de cima, Lisa e Brandon ouviram a porta da entrada da casa sendo fechada bem forte.
<p>- Eu não acredito nisso. – Lisa colocou as mãos no rosto e começou a chorar.</p>
<center><h4>--*--</h4></center>
<p>- Maddie, Maddie, querida, oi. – Jason chegou abraçando Maddie no portão da escola.
<p>- O que você quer? – Maddie estranhou Jason sendo legal.
<p>- Somos amigos, não é? Depois daquela nossa conversa e tal... Só quero saber como você está.
<p>- Estou ótima.
<p>- Que bom. Eu fico feliz, muito feliz. – Jason sorriu.
<p>- Esse é o sorriso mais falso que eu já vi. O que você quer?
<p>- Nada. – Jason não mentia bem. – Só, sei lá, saber se você tem um quartinho sobrando na sua casa.
<p>- Por quê?
<p>- Porque eu estou precisando de um lugar para ficar e você é tão legal, que...
<p>- Não, não tem espaço para você na minha casa.
<p>- Ah, qual é, você mora em uma fazenda, não tem nenhuma cabana? Uma rede?
<p>- Estão todos ocupados.
<p>- Por quem? As vacas dormem nas camas agora?
<p>- Não te interessa. Eu não quero que você vá morar na minha casa. – Maddie não ficou séria, falou normalmente.
<p>- Só porque eu falei algumas coisas ruins para você?
<p>- Exatamente por isso.
<p>- Mas achei que a gente estava se dando bem.
<p>- Não, Jason, não. Você não vai morar na minha casa.
<p>- Engole a sua casa então.  – Jason ficou bravo.
<p>- Você está bravo? – Maddie começou a rir. – Se você tivesse sido legal comigo desde o começo...
<p>- Ai, meu Deus. Eu falei umas coisinhas para você, nada demais, não aguenta brincadeira? Cresce um pouco.
<p>- O quê? Olha quem fala, o irresponsável, infantil e imaturo aqui é você. Você que precisa crescer, não eu.
<p>- Valeu, Maddie. – Jason saiu de perto dela emburrado.</p>
<center><h4>--*--</h4></center>
<p>- Ela disse que você precisava crescer? – Emily começou a rir.
<p>Jason viu que ela estava almoçando sozinha na cantina, então se sentou ao lado dela. Os dois começaram a conversar e ele acabou contando a conversa que teve com a Maddie mais cedo.
<p>- Não é hilário? Se eu crescer mais um pouco, eu bato no teto. – Jason riu também.
<p>- Onde você está ficando?
<p>- Eu estou em um hotel aqui perto. Estou pagando com o dinheiro de emergência que meus pais me deram, mas ele está acabando.
<p>- Plano B?
<p>- Dormir com uma garota a cada dia para usar a casa dela. – Jason brincou. Depois chegou a conclusão que não deveria falar isso, principalmente para Emily, mas ela continuou rindo então não foi algo tão ruim.
<p>- Plano C?
<p>- Morar com você.
<p>- O plano B é melhor.
<p>- Eu sou tão ruim assim para ninguém querer morar comigo?
<p>- Bom, quer a verdade?
<p>- Não.
<p>- Você só é legal com as pessoas quando quer algo em troca. – Emily falou mesmo assim.
<p>- Não é verdade.
<p>- Tirando a Lisa.
<p>- Eu sou legal com a Tempe o tempo todo.
<p>- Por quê? – Emily sabia a resposta.
<p>- Porque eu gosto dela e eu tirei 10 no trabalho que fizemos juntos, daqui a pouco vai dar para eu começar a colar dela nas provas. Vou passar de ano fácil. Ai, minha nossa. – Jason percebeu.
<p>- Minha teoria está provada.
<p>- Não está, nada. Eu sou legal com você. – Jason deu outra opção.
<p>- Por quê?
<p>- Porque eu quero ficar com você. Droga.
<p>- Eu te disse.
<p>- Tudo bem, eu aceito. Eu me aproximo das pessoas pelo meu benéfico próprio, mas quem não faz isso?
<p>- Muita gente. Existem pessoas que não são egoístas. – Emily falou como se estivesse contando uma novidade para Jason.
<p>- Mas o que quer que eu faça então?
<p>- Melhore.
<p>- Você poderia me ajudar. – Jason pegou na mão de Emily.
<p>- Desculpa, mas eu não melhoro garotos. Não sou santa, nem madre e muito menos mãe de alguém. – Ela soltou a mão.
<p>- Existe alguém mais difícil que você?
<p>- Acho que não.
<p>- O que eu tenho que fazer para você ficar comigo?
<p>- Sério? Tudo bem. Precisa nascer de novo e ser sincero.
<p>- Mas eu sou sincero.
<p>- Não, você fala frases feitas e o que acha que eu quero ouvir. Só isso.
<p>- Mas é isso que funciona com as garotas.
<p>- Só para as fáceis. E além do mais, nada do que você fala é o que eu quero ouvir.
<p>- O que você quer ouvir então?
<p>- A verdade. Você esconde seu sentimento com a raiva. Você está aqui conversando comigo, mas na verdade, não estamos falando sobre nada. Você usa o sarcasmo, ironia e cantadas baratas. Não é isso que eu quero ouvir.
<p>- Quer que eu diga que estou sofrendo pela Lisa ter me abandonado? Quer que eu diga que eu ligo todos os dias para minha casa, mas meu pai nunca fala comigo porque está ocupado com o trabalho? Quer que eu fale que as coisas que o blogueiro fala de mim me afeta muito porque essa imagem de “bonzão” é uma mentira?
<p>- Pode ser um começo.
<p>- Você quer demais então.
<p>- Como eu vou gostar de você se eu nem sei se esse você é real?
<p>- Você tenta a sorte. E torce pelo melhor.
<p>- Isso não funciona para mim, sinto muito.
<p>Emily pegou sua bandeira e se levantou da mesa.
<p>- Eu não consigo, tá bom? Não consigo me abrir assim. – Jason falou.
<p>- Quer saber um segredo? Quase ninguém consegue.
<p>Emily deu um sorrisinho e então foi embora.</p>
<center><h4>--*--</h4></center>
<p>- Ela te deu um fora? – Temperance estava andando com Jason pelos corredores da escola.
<p>- Não foi bem um fora. Foi um... Sei lá o que foi. – A conversa com Emily ficou na cabeça de Jason o dia todo.
<p>- Foi um fora.
<p>- Não foi um fora coisa nenhuma.
<p>- Foi, sim. – Temperance riu. – Mudando de assunto, você tem uma prova de química amanhã, quer estudar mais tarde?
<p>- Ah, eu acho que não vai dar.
<p>- Por que não?
<p>- Ah, eu conheci uma garota agora a pouco. A gente vai estudar na casa dela mais tarde, se é que me entende. – Jason sorriu.
<p>- Entendo, infelizmente. À noite então, pode ser?
<p>- Bom, a noite também não vai dar.
<p>- Outra garota?
<p>- Bom, essa eu conheci no pátio. Ela disse que os pais dela estão viajando e não gosta de ficar sozinha de noite.
<p>- Você virou guarda costas?
<p>- Por uma garota, eu viro qualquer coisa. Eu sou meio camaleão. – Jason falou com orgulho.
<p>- Na minha opinião, você está tentando preencher o espaço da Lisa com essas garotas.
<p>- Ainda bem que não ligo para sua opinião.
<p>- E mais uma coisa. Você gosta dessa garota aparentemente, mas vai ficar com outras duas garotas? Eu não entendo.
<p>- Você falando assim até parece errado.
<p>- Porque é errado.
<p>- Ah, qual é, a gente pode estudar amanhã antes da aula.
<p>- Tudo bem. Amanhã. – Temperance fez pouco caso, sabia que tinha perdido.
<p>- Está mais preocupada com as minhas notas do que eu.
<p>- É para isso que serve os amigos.
<p>- É, os amigos chatos.</p>
<center><h4>--*--</h4></center>
<p>- O Jason pediu para ir morar com a gente? – Kol não estava acreditando no que a irmã dizia. – Ele deve estar muito desesperado.
<p>Os dois estavam indo para casa depois da escola.
<p>- Pediu. E ainda veio com aquela cara de “vou ser legal, mas quero algo em troca”.
<p>- Quer dizer que a briga com a amiga dele foi séria.
<p>- Até que demorou. Para ser sincera, Lisa é uma heroína por aguentar aquele garoto por tanto tempo.
<p>- Mas agora ele não tem para onde ir. – Kol ficou pensativo.
<p>- Você está conseguindo me deixar com culpa.
<p>- Relaxa, ele não merece a sua culpa. Não é problema nosso.
<p>- Ele não é tão ruim assim. Só não sabe ser legal.
<p>- Está mudando de ideia, não está?
<p>- Estou um pouco. – Maddie sorriu culpada.</p>
<center><h4>--*--</h4></center>
<p>- Bom, a sua casa é muito bonita, Ana.
<p>A garota que Jason conheceu na escola o levou para casa dela. A casa parecia uma mansão se comparada com as outras casas da cidade.
<p>- É porque ainda não viu meu quarto. – Ana deu um sorriso maldoso.
<p>- Se isso for um convite, eu aceito.
<p>- Vamos. – Ana pegou na mão de Jason, os dois subiram as escadas e ela o levou até seu quarto.
<p>Por alguma razão que Jason não sabia, ele não estava se sentindo muito confortável naquela situação, mesmo fingindo estar.
<p>- Bom, vamos ao que interessa. – Ela foi direta. Jogou sua mochila no chão.
<p>- Ah. – Jason não sabia o que falar. – Eu não... Eu esqueci os livros. – Jason se sentou na cama dela.
<p>- Ótimo. – Ana se sentou no colo dele. – Estudar não estava mesmo nos meus planos. – Ana começou a beija-lo.
<p>- Você beija muito bem. – Jason falou entre os beijos.
<p>- Melhor que as outra que você já beijou e não significou nada? – Ela falou.
<p>- O quê? – Ele se assustou com o que ela falou.
<p>- Você beija melhor. Foi o que eu disse. – Ela não deu atenção para o susto dele.
<p>E de repente Jason percebeu que estava ouvindo coisas.
<p>- Eu tenho muita prática. – Jason tentou esquecer e voltou a beijá-la.
<p>- Você acha certo estar aqui se divertindo enquanto sua melhor amiga está em casa chorando? – E ela falou algo estranho de novo.
<p>- Ela deve estar com o Brandon. – Jason já estava ficando assustado.
<p>- Quem? Brandon? Como assim?
<p>- O que foi que você disse mesmo? – Jason fingiu não ouvir. – Devo ter me enganado.
<p>- Eu disse se eu posso tirar a sua camisa.
<p>- Ah, claro. Quer dizer, eu tiro, sem problema. – Mesmo nervoso, Jason desabotoou a camisa e a tirou.
<p>- Ficar comigo é mais interessante do que ficar estudando com a Temperance, né? – O que estava acontecendo com a cabeça de Jason? Ele não sabia mais.
<p>- Com toda certeza, agora me beija e não fala mais nada. – Jason voltou a beijá-la.
<p>- Nossa, com essa atitude, não sei como a Emily te rejeita. Deve ser porque você está comigo agora e não com ela. Você já amadureceu desde a conversa do almoço?
<p>- Sai da minha cabeça! – Jason não aguentou e gritou.
<p>- O quê? – Ana ficou confusa.
<p>- Acho que eu estou ficando louco. – Jason olhava assustado para Ana.
<p>- Eu também acho. – Ela parecia confusa e um pouco brava. – Você está pensando em outra coisa? Não está bom para você?
<p>- Ana, me desculpa, é que... Eu não estou em um bom dia, me desculpa, sério. Acho melhor eu ir embora.
<p>- Volte quando estiver mais concentrado. – Ana saiu do colo do Jason.
<p>- Vou fazer isso.
<p>Jason saiu do quarto de Ana meio envergonhado. Ele nunca tinha dispensado uma garota, principalmente numa situação como aquela. O que estava acontecendo com ele? Aquele geralmente era o plano, ficar com uma garota pra esquecer os problemas. Por que dessa vez não tinha funcionado?</p>
<center><h4>--*--</h4></center>
<p>- Eu estou preocupada, sabia? – Temperance e Brandon estavam jantando na casa dela.
<p>- Com o Jason?
<p>- Sim. Ele está morando em um hotel.
<p>- Por que não traz ele para cá?
<p>- Ah, mas é logico.
<p>- Qual é o problema? – Brandon riu, ele sabia qual era o problema.
<p>- Você se lembra uma vez quando estudamos até tarde e você dormiu no meu sofá?
<p>- Claro, seu pai acordou no meio da noite, me viu e quase me matou. Antes, ele quase teve um ataque cardíaco.
<p>- Foi engraçado.
<p>- Não para mim.
<p>- As coisas estão complicadas. – Temperance então falou.
<p>- Jason é teimoso e orgulhoso, a Lisa nem...
<p>- Sei. – Temperance o interrompeu. – Eu só vou perguntar por perguntar porque eu não me importo, mas como a Lisa está?
<p>- Ela não está soltando fogos de artificio como você imagina. Ela também está triste.
<p>- Ela não acreditou no Jason.
<p>- Você acreditou de primeira? Qual é, a cara dele não nega, ele não me parece confiável.
<p>- Mas ele é. E eu percebi isso depois de semanas, a Lisa conhece ele por anos. Tem uma diferença.
<p>- Você tem certeza? Porque se ele for mesmo, eu posso tentar fazer a Lisa mudar de ideia, mas não quero me arrepender depois.
<p>- Bom, é melhor você não se meter, quer dizer, eu gosto do garoto, mas não coloco minha mão no fogo por ele. Além do mais, a relação é deles, eles devem resolver. Não é um problema nosso.
<p>- Eu só queria ajudar.
<p>- Eu tenho essa vontade às vezes também. Mas não é a melhor escolha. Vamos deixar o tempo passar para ver o que vai acontecer.
<p>- Tempe, você coloca a mão no fogo por mim? – Brandon a testou.
<p>- As duas mãos se for preciso. – Temperance sorriu. – Vou buscar a sobremesa.
<p>Ela se levantou da mesa.
<p>- Tudo bem.</p>
<center><h4>--*--</h4></center>
<p>Emily entrou na cafeteria correndo, encontrou Jason em uma das mesas e se sentou de frente para ele quase sem fôlego.
<p>- Você me mandou uma mensagem estranha, parecia uma emergência. Estava em letras maiúsculas e tudo.
<p>- Espero que esteja feliz. – Jason estava bravo.
<p>- Eu sou uma pessoa feliz normalmente. A felicidade vem do coração. – Ela sorriu.
<p>- Engraçadinha.
<p>- O que foi que eu fiz?
<p>- Está contando para todo mundo que eu estou interessado em você.
<p>- Do que está falando?
<p>- Eu me encontrei com uma garota hoje e eu ia dormir com ela, porque ela era muito BAM!
<p>- O que BAM significa?
<p>- Aí ela olhou para minha cara e disse que você me rejeitava porque eu estava lá com ela.
<p>- Que garota disse isso? – Emily não estava entendendo nada.
<p>- Ah, eu posso ter esquecido o nome dela... Mas isso não vem ao caso.
<p>- Você está maluco.
<p>- Então isso veio da minha cabeça? Eu estou começando a imaginar coisas?
<p>- É bem provável. Isso geralmente acontece quando a pessoa sente culpa.
<p>- Culpa de quê?
<p>- Eu vou lá saber, você que está se sentindo culpado, não eu.
<p>- Você que deveria estar se sentindo culpada.
<p>- Eu? – Emily ficou confusa. – Por quê?
<p>- Por me rejeitar. Se você ficasse comigo, eu não precisaria ficar atrás das outras.
<p>- Me desculpa, então? – Emily fez uma cara séria. – Se eu aceitasse ficar com você, isso duraria por quanto tempo? Duas semanas, dois dias ou duas horas?
<p>- Não é bem assim.
<p>- Você não sabe o nome da garota com quem ia dormir.
<p>- Ah, qual é? Isso não é importante.
<p>- É para mim. Eu não vou ficar com um cara que acha que ser assim está tudo bem.
<p>- Você queria me conhecer. Eu sou assim, e eu só estou te contando essas coisas porque eu não quero mentir. Eu não te entendo. Preferia que eu mentisse?
<p>- Não. Eu ia preferir que você não ficasse com outras garotas enquanto está tentando ficar comigo.
<p>- Ficou com ciúmes? – Jason sorriu.
<p>- Você está indo pelo caminho errado.
<p>- Tudo bem. Eu sou mais do que um cara que só pensa em garotas, tá bem?
<p>- Se você está dizendo. – Emily não estava acreditando.
<p>- É verdade, e para você ver, eu não parei de pensar no que a gente conversou. E isso é horrível, porque eu não quero falar sobre essas coisas e você me faz querer. Você é um demônio.
<p>- O quê? – Emily arregalou os olhos e começou a rir.
<p>- Olha, esquece tudo o que eu disse. Vamos começar de novo.
<p>- Começar o quê? A gente não fez nada. O que aconteceu na casa daquela garota? Você caiu e bateu a cabeça?
<p>Jason não respondeu, fez outra coisa.
<p>- Oi, meu nome é Jason. – Jason estendeu a mão. – Acho que você não me conhece.
<p>- O quê? – Emily não estava entendendo nada.
<p>- Você é a Emily, não é?
<p>- O que você está fazendo?
<p>- Eu estou me apresentando. Eu sou o Jason, você é a Emily? – Ele sorriu.
<p>- Eu... Eu sou, sim. – Emily apertou a mão de Jason.
<p>- Você vem sempre aqui? – Jason riu.
<p>- Sério que você vai começar a conversa assim?
<p>- Bom, como quer conversar? Quer falar dos seus olhos ou os meus?
<p>- Quem é você, Jason?
<p>- Que pergunta difícil. – Jason sorriu envergonhado. – A história é longa.
<p>- Eu tenho tempo.
<p>- Espera um pouco, quer dizer que a gente vai passar a noite toda falando sobre mim?
<p>- Se quiser.
<p>- Está brincando? É o meu papo favorito. Essa vai ser a melhor conversa de todas.
<p>- Idiota. – Emily riu.</p>
<center><h4>--*--</h4></center>
<p>- Onde você estava hoje de manhã? – Temperance chegou furiosa na biblioteca.
<p>- Acho que dormindo. – Jason respondeu. – Tempe, eu adoraria falar com você agora, mas eu tenho a minha prova daqui a pouco.
<p>Jason estava em uma mesa cheia de livros abertos, e seu caderno estava todo cheio de anotações.
<p>- Eu sei. A gente ia estudar junto, lembra?
<p>- Quando? – Jason tinha uma péssima memória.
<p>- Hoje de manhã. – Temperance quase gritou. – E você me deixou plantada. Eu até fiz umas anotações para facilitar o estudo e para você pegar a matéria mais fácil, e...
<p>- Ei, relaxa. Não é grande coisa. É só vinte e cinco por cento da nota.
<p>- Eu mal dormi planejando o estudo.
<p>- Quer saber de uma coisa? Eu também mal dormi essa noite. – Jason estava animado e até esqueceu da bronca.
<p>- Por quê? Você estava mal? – Temperance deixou a raiva de lado. – Devia ter me contado, me desculpa.
<p>- Não, eu estava ótimo. Eu estou ótimo. Eu fiquei com aquela garota que eu conheci na praça a noite toda.
<p>- Retiro as minhas desculpas e acrescento um “eca”.
<p>- A gente não fez nada, tá bom? Ela nem me deu um beijo de boa noite.
<p>- O que fizeram então?
<p>- A gente ficou conversando na cafeteria vinte e quatro horas.
<p>- Sobre o quê?
<p>- Sobre nada. – Jason começou a rir. – A gente começava a falar de alguma coisa e depois sem perceber já mudava para outra.
<p>- Que coisa chata.
<p>- Ela é perfeita e eu aqui indo dormir com outra garota. Eu sou um idiota.
<p>- Pelo menos isso você sabe.
<p>- Ainda está brava comigo?
<p>- Eu sempre estou brava com você.
<p>- Então vai catar coquinho, vai? Eu tenho quinze minutos para estudar.
<p>- Cala a boca. – Temperance jogou um livro em cima de Jason.
<p>- Ai.</p>
<center><h4>--*--</h4></center>
<p>- Jason, a gente pode conversar? – Brandon chamou Jason no corredor e ele até se assustou. Esperava mais um empurrão vindo do nada.
<p>- Olha só, Cabelinho, eu não quero brigar.
<p>- Nem eu, eu quero ajudar.
<p>- Como assim e por quê?
<p>- Meu irmão foi para a faculdade e tem uma cama sobrando no meu quarto se ainda quiser um lugar para ficar.
<p>- O quê? Está me chamando para morar com você? – Jason ficou muito surpreso. – Vai colocar cabelo na minha comida ou algo assim?
<p>- Olha, eu gosto muito da Lisa, e mesmo que ela esteja brigada com você, ela ainda se importa. Eu não estou fazendo isso por você, estou fazendo por ela.
<p>- Isso é estranho. E eu até recusaria, mas eu não tenho muita escolha no momento. Estou quase indo para o Motel Bates para ser morto no chuveiro. Tudo bem, Guga. Eu topo.
<p>- Com uma condição.
<p>- Não vou conseguir parar de fazer piada com o seu cabelo.
<p>- Não é essa a condição.
<p>- Nem vou te ajudar a fazer tranças.
<p>- Seja uma pessoa melhor, essa é a condição. – Brandon falou logo.
<p>- Eu vou ser, Cabelo de Tapete.
<p>- Não faça eu me arrepender.
<p>- Sim, senhor. – Jason imitou um soldado.</p>
<br>
<p><i>“<b>JASON NÃO É MAIS SEM TETO, PESSOAL:</b> Para vocês, garotas que estavam interessadas em conseguir levar nosso amigo Jason para casa, podem ficar decepcionadas, porque ele já encontrou uma casa. Ele não mora mais embaixo da ponte, ele mora com o Brandon, isso mesmo gente, acho que pararam de brigar pela Lisa e resolveram se unir. Será que os dois vão namorar ela agora? Bom, seria interessante, mas parece que o coração do Jason, se é que ele tem um, já foi fisgado e eu já quero conhecer essa garota que vou chamar de A garota mais azarada do mundo.”</i>. – Tesouro de Segredos Obscuros.</p>
</body></html>";
            }

            if (numero == 10)
            {
                lblTitulo.Text = "Capítulo 10 - Colegas de Quarto";
                htmlPage.Html = @"<html><body>
<p>Era oficial, Jason havia se mudado para a casa de Brandon. Eles dividindo o mesmo quarto seria interessante. O quarto de Brandon era bem grande, era o que Jason esperava já que ele dividia com o irmão. Tinha uma estante na parede do lado da cama de Brandon cheia de livros grossos e alguns quadrinhos. Bonecos colecionáveis de heróis muito bem cuidados e arrumados. Do outro lado do quarto, tinha uma cama arrumada, alguns troféus em prateleiras também em cima da cama. O irmão de Brandon parecia gostar muito de esportes.
<p>- Seus pais são bem legais. – Jason comentou enquanto colocava suas roupas na cômoda que Brandon esvaziou.
<p>- Está dizendo isso porque não está aqui o tempo todo. Os pais dos outros sempre são melhores. – Brandon falou sem emoção.
<p>- Olha, depois da minha expulsão na escola, eu poderia ter escolhido estudar na cidade vizinha ou quase do outro lado do país. Olha o que eu escolhi. – Jason brincou.
<p>- Como é Los Angeles? – Brandon nunca tinha saído de Dallas.
<p>- Bom, tem sol, tem praia e a melhor parte...
<p>- Surf?
<p>- Garotas de biquíni por toda a parte.
<p>- Parece bom. – Brandon riu.
<p>- Agora sabe o quanto eu me sacrifiquei.
<p>- Entendo. – Brandon não levou o comentário a sério. – Olha, eu vou ter que sair, fazer umas coisas. Pode ficar à vontade.
<p>- Sério? – Jason olhou em volta do quarto pensando no que poderia fazer sozinho ali.
<p>- Bem sério. Você não parece ser ladrão.
<p>- Eu já roubei uma caneta no primeiro ano. Não me julgue.
<p>- Tudo bem. – Brandon estranhou. – Só não mexe no meu computador, está bem?
<p>- Por quê?
<p>- Porque não. – Ele falou sério.
<p>- Já entendi, você não divide pornografia, tudo bem.
<p>- Por favor. – Brandon estava quase implorando.
<p>- Tá bom.
<p>- Ótimo.
<p>Depois que Brandon saiu, Jason continuou guardando suas coisas, eram poucas então ele terminou logo. Ele queria muito mexer no computador já que era para ele não mexer, mas conseguiu se controlar. Ficou sentado na cama por alguns minutos, leu os títulos dos livros que Brandon tinha, mas nenhum o interessou. Resolveu sair da casa, ficar ali só faria ele ficar pensando em coisas que não deveria.</p>
<center><h4>--*--</h4></center>
<p>- Você levou o Jason para morar com você? – Lisa ficou surpresa com a atitude do Brandon.
<p>Os dois tinham ido na sorveteria tomar um sorvete e depois foram dar uma volta pelo parque.
<p>- Saiu no blog, achei que você já sabia. – Brandon só havia comentado, não sabia que seria uma novidade.
<p>- Depois do que aquele idiota falou sobre mim, eu nunca mais li.
<p>- Bom, pelo menos soube isso por mim. Você está brava?
<p>- Não, é claro que não. Eu estava mesmo preocupada com ele. O Jason não precisava ter saído de casa.
<p>- Ele não ia ficar lá com vocês dois brigados. É o Jason.
<p>- E agora vocês são colegas de quarto? Vocês se batem o tempo todo. Como isso funciona?
<p>- Não funciona. – Brandon riu. – Mas sei lá, eu posso dar uma segunda chance. As piadas sobre o meu cabelo não atingem mais.
<p>- Se você está falando. – Lisa riu.
<p>- E além do mais, isso vai deixar você menos preocupada.
<p>- Vai. Você acha que eu devo ir falar com ele?
<p>- Só se estiver pronta.
<p>- Eu estou sentindo falta dele para ser sincera. Daquele papo idiota sobre garotas, as coisas estranhas que ele faz, as piadas sem graça. Somos amigos há tanto tempo que eu não me via mais sem ele.
<p>- Vocês são muito amigos e se importam um com outro. Vão se resolver, vai ver.
<p>- Eu te adoro. – Lisa beijou Brandon.
<p>- Isso é bom porque eu também te adoro.
<p>- Obrigada.</p>
<center><h4>--*--</h4></center>
<p>- Você morando com o Brandon? Isso vai ser interessante. – Temperance estava rindo da cara do Jason.
<p>Temperance foi a primeira a saber por Jason da novidade. Ele estava indo a casa dela para contar, mas a encontrou no meio do caminho. Ela já estava indo para a casa do Brandon ver como estavam sendo as coisas.
<p>- Olha, o Cabeça de Cobertor de Pelo veio na boa vontade e eu não tinha para onde ir. Eu estou na pior. Meu dinheiro de emergência está acabando e eu ainda nem paguei uma stripper.
<p>- Cala a boca.
<p>- Além do mais, não posso pedir mais dinheiro para os meus pais. Só vou ouvir sermão do meu pai e blábláblá.
<p>- Eu imagino.
<p>- Olha, isso facilita sua vida.
<p>- Como? – Temperance não entendeu.
<p>- Quando você for visitar seu melhor amigo, você também vai ver o seu mais melhor amigo.
<p>- Não existe “mais melhor amigo”.
<p>- No meu vocabulário existe.
<p>- Vocês não vão se matar, né? Porque já brigaram uma vez. – Temperance parecia preocupada.
<p>- Eu posso ser legal, está bom? Não sou horrível o tempo todo.
<p>- Eu duvido.
<p>- Quer dizer que você não me acha legal?
<p>- Digamos que o seu caminho para ser legal é bem longo. Você só é legal com quem quer.
<p>- Óbvio. Por que eu seria legal com quem eu não quero? É burrice.
<p>- Se essa é a sua história. -
<p>- Me desculpa, Senhorita Mais Legal do Mundo. Quem vê parece que você é a Mary Poppins.
<p>- Por que estamos conversando?
<p>- Porque somos tão chatos que ninguém mais aguenta. Foi o que eu ouvi dizer. – Jason bateu seu cotovelo no braço dela.
<p>- Pode ser por isso. – Temperance riu.</p>
<center><h4>--*--</h4></center>
<p>Temperance estava concentrada no seu armário pegando seus livros para a aula de matemática. Depois dos posts do blogueiro sobre ela, ela não costumava mais olhar muito para os lados para evitar ver olhares julgadores vindo na direção dela. Essa foi a razão para não ter visto a chegada de Emily até que fosse tarde demais para ela fugir daquela conversa.
<p>- Temperance, oi.
<p>- Emily? – Temperance não gostou do que viu.
<p>- Você viu o Jason? Eu precisava falar com ele. E como vocês estão sempre juntos...
<p>- Eu não vi. – Temperance foi direta. – O que você quer com ele?
<p>- Bom, não é nada importante.
<p>- Você é a garota da praça. – Temperance então ligou os pontos. – É claro, quando ele te descrevia, eu só pensava “essa garota parece ser uma sonsa”. Como não consegui associar?
<p>- Bom, se você o ver, você poderia...
<p>- Eu tenho cara de correio? Ou na minha testa está escrito “Guia de Como Encontrar O Jason”?
<p>- Calma, não precisa ser grossa. – Emily continuou calma. – Tem algum problema comigo?
<p>- Não, nenhum. Eu nem te conheço muito. A única coisa que eu sei de você é que tem péssimo gosto para amizades, mas isso não vem ao caso agora, não é mesmo?
<p>- Temperance...
<p>- Mas a minha curiosidade é que você nunca vem falar comigo. Achei estranho, só isso.
<p>- Bom...
<p>- O quê?
<p>- A minha amiga Samantha, ela brigava com você o tempo todo. Eu sei disso. Eu vi isso.
<p>- Sua amiga? – Temperance riu. – Ela mesma.
<p>- Mas isso já acabou. Não pode superar?
<p>- Eu já superei. Só não sou legal com estranhos.
<p>- Olha...
<p>- Não, olha você. Naquela época eu era uma garotinha idiota, eu não sou mais ela.
<p>- Não que isso me importe.
<p>- Eu sou a ruim agora?
<p>- Bom, isso não me interessa. Isso faz muito tempo. Você está me atacando sem razão nenhuma.
<p>- Eu tenho muitas razões. O engraçado é você ainda chamar ela de amiga.
<p>- Eu tenho péssimo gosto para amizades. Até vim aqui para dizer se você queria ser minha amiga. – Emily usou o sarcasmo. – Você não tem o direito de falar nada para mim, não me conhece.
<p>- Conheço o suficiente. O Jason sabe o que você fazia? Acho que não, senão não te consideraria um anjo em forma de gente nem colocaria você no céu.
<p>- Me desculpe te incomodar, Miss Perfeição.
<p>Emily se cansou da grosseria e não queria ficar ali batendo boca com a Temperance, então resolveu ir embora.</p>
<center><h4>--*--</h4></center>
<p>- Não precisava ter sido grossa com ela. Ela só veio fazer uma pergunta. – Temperance contou pra Jason sobre sua conversa com a Emily enquanto estavam estudando na biblioteca.
<p>- Você vai defender ela agora?
<p>- Não, eu não vou defender ninguém.
<p>- Ótimo.
<p>- Não, eu vou defender sim. – Jason mudou de opinião. – Ela não fez nada para você. Vai julgá-la pela amiga dela?
<p>- Ela podia ter feito alguma coisa. Sei lá, tentado impedir. As duas eram amigas, não é? – Temperance fez cara de desdém. - Ou sei lá o quê.
<p>- O que realmente aconteceu? Por que esse rancor todo?
<p>- Você não sabe? Pergunta para ela.
<p>- Eu estou perguntando para você. – Jason ficou sério. – Eu não gosto de joguinhos, então me diz logo.
<p>- A Samantha era uma valentona e como toda valentona, achava que podia intimidar todo mundo. Começou quando eu não quis entregar para ela uma cola para a prova de Biologia. Ela se deu mal na prova e de repente achou que eu tinha que pagar por isso.
<p>- Então eu deveria me vingar de você, porque eu fui muito mal na prova de Química porque você não me ajudou a estudar, bom, na verdade, eu dei um bolo em você, mas não vem ao caso.
<p>- Cala a boca e escuta o resto.
<p>- O que ela fez? – Jason voltou a focar.
<p>- Primeiro, ela roubou as minhas anotações depois e rasgou tudo. Me empurrava no corredor. Passava me olhando como se fosse me matar o tempo todo.
<p>- O que o Brandon fazia?
<p>- Ele não sabia. Ninguém sabia.
<p>- Como ninguém percebe essas coisas?
<p>- Todo mundo está ocupado com os seus problemas.
<p>- Mas o blogueiro...
<p>- Eu não acho que ele disse todas aquelas coisas sobre ela por minha causa.
<p>- O que mais ela fez?
<p>- Ela já me deixou trancada no armário de vassouras por três horas. Eu gritava e ninguém me escutava. Uma vez, na aula de teatro, ela rasgou a minha roupa e eu tive que ir para a casa vestida de árvore. – Temperance esperou para Jason rir, mas ele não riu.
<p>- Que horror. Eu sinto muito.
<p>- Já passou.
<p>- O que foi falado dela no blog para ela querer ir embora?
<p>- O blogueiro falou que tinha provas de que ela tinha uma DST. Acabou que ela tinha mesmo e ninguém sabia. Todo mundo começou a se afastar dela, sentir nojo, ela ficou furiosa, começou a atacar mais ainda os mais fracos, e ela tinha algo parecido com Comensais da Morte. – Jason continuou calado. – São um tipo de seguidores...
<p>- Eu assisti Harry Potter. Continua.
<p>- Tudo bem. O problema é que quanto mais o blogueiro falava dela, mas ela vinha para cima de mim, até descobrirem que ela infectou alguém.
<p>- Nossa.
<p>- É esse tipo de gente que a sua namoradinha considera como melhor amiga ou sei lá. Devia rever seus conceitos de perfeição.
<p>- Foi mal, mas meus amigos é uma coisa, eu sou outra. Eu não julgo pelas pessoas que você anda e sim pelo que você faz. Vai por mim, já tive amigos bem piores que essa aí.
<p>- Tudo bem.
<p>- Você não deveria ter passado por isso. – Jason pegou na mão de Temperance. – Eu quero que saiba de uma coisa.
<p>- O quê?
<p>- Enquanto eu estiver aqui, isso nunca mais vai acontecer com você.
<p>- Não preciso de proteção.
<p>- Não tente me impedir, garota. Eu sou imparável.
<p>Temperance riu.</p>
<center><h4>--*--</h4></center>
<p>- Jason, oi. – Maddie veio correndo atrás de Jason no corredor.
<p>- Maddie, tchau.
<p>- Não, espera aí. – Maddie pegou no braço de Jason para ele parar de andar. – Olha, eu mudei de ideia, se você provar que é um cara legal, eu deixo você ir morar na minha casa.
<p>- Vai ter tipo um teste? Posso levar cola?
<p>- Olha, é sério.
<p>- Tudo bem, galinheira, você chegou tarde. Eu já consegui uma casa.
<p>- Sério? – Maddie ficou surpresa.
<p>- Sério. Eu estou morando com o Bran.
<p>- Mas vocês se odeiam.
<p>- Não tanto assim. Ódio é uma palavra muito forte. Eu só não gosto dele. – Jason sorriu. – Mas o que importa é eu ter uma casa para passar a noite.
<p>- A minha casa é melhor.
<p>- Me desculpa, mas o seu sonho de dormir comigo não vai se realizar.
<p>- Eu só estava tentando ser legal.
<p>- Depois de me dar um “não”? Muito legal da sua parte.
<p>- Olha, vai se ferrar então.
<p>- Ai meu Deus, a garota que cospe algodão doce falou isso? As pessoas mudam. – Jason brincou.
<p>- Você me tira do sério.
<p>- Olha a minha cara de preocupado. – Jason sorriu.
<p>- Espero que a Lisa nunca te perdoe. Você não merece.
<p>- E eu espero que o leite das suas vacas seque.</p>
<br>
<p><i>“<b>NOTÍCIAS SOBRE O NOVO AMOR DO JASON, PREPARADOS? </b> Bom, parece que eles estão muito bem. Emily é o que chamamos de A Garota dos Sonhos. Mal se conhecem e já estão passando as noites juntinhos. Cadê os seus pais hein, garotinha? Bom, as fontes são seguras quando eu digo que Jason se deu bem, ele queria uma garota fácil, bom, ele finalmente conseguiu. Jason nos contou com exclusividade, ou quase isso, que ele está muito satisfeito em todos os sentidos. Parabéns, Emily, você é a garota que todos os garotos querem ter.”.</i> – Tesouro de Segredos Obscuros.</p>
<br>
<p>- Eu conversei com a Temperance, ela não quis ser grossa.
<p>Jason e Emily estavam saindo da aula. Eles nem perceberam que estavam todos com o celular na mão e rindo deles.
<p>- Eu não espero desculpas. Eu estou bem.
<p>- E nem ela pretende dar, para falar a verdade, mas ela me contou o que aconteceu com ela e a sua amiga e...
<p>- Jason, eu sei de tudo o que aconteceu. Eu também não gosto disso, mas eu não poderia fazer nada.
<p>- Eu sei.
<p>- Claro que falar com ela não ia me matar.
<p>- Não era seu dever.
<p>- Então era de quem? Todo mundo via e não fazia nada. Se a Samantha era a minha amiga, qual era o meu dever?
<p>- Dar um tapa nela quando ela merecesse. – Jason brincou.
<p>Emily riu.
<p>- Por que está todo mundo olhando para a gente? – Emily começou a olhar para os outros.
<p>- Deixa eu adivinhar. – Jason pegou o celular. – O blogueiro falou da gente.
<p>- Falou o quê? – Emily pegou o celular.
<p>- Te chamou de minha namorada. Olha só ele me ajudando. – Jason só leu isso.
<p>- Cala a boca. Agora me chamaram de fácil. Eu te deixo satisfeita? – Emily terminou de ler o post estampado na tela do celular na mão de Jason.
<p>- Óbvio que não, me deixa insatisfeito. Só levo foras. Olha, eu não falei isso, eu juro. – Jason já foi logo se explicar.
<p>- Tudo bem.
<p>- Tudo bem? – Jason se surpreendeu.
<p>- Tudo bem, eu acredito em você.
<p>- Como é que é? Pode repetir?
<p>- Jason.
<p>- Desculpa, é que eu não estou acostumado com as pessoas acreditando em mim.
<p>- Relaxa. – Emily riu.
<p>- Espera um pouco, você está falando que está tudo bem, mas essa vai ser nossa última conversa porque você está furiosa por dentro?
<p>- Não.
<p>- Você está fingindo que está bem, mas não está?
<p>- Para de ser paranoico. Eu não acredito e nem ligo para o blogueiro. Ele já mentiu antes, não é?
<p>- Você está me enganando. – Jason ainda estava desconfiado.
<p>- Não estou.
<p>- Está sim
<p>- Para. O que você quer que eu faça para provar que está tudo bem e para você calar a boca?
<p>- Me beija. – Ele sorriu mesmo sabendo que ela não ia fazer isso.
<p>Emily então o beijou bem rápido. Pegou ele de surpresa, nem deu para retribuir.
<p>- Acredita agora?
<p>- Ainda não. Precisa me beijar de novo. – Agora ele se preparou.
<p>- Isso não vai acontecer. – Emily riu.
<p>- Por que não? Coisas boas têm que acontecer o tempo todo.
<p>- Pode tirando seu cavalinho da chuva.
<p>Os dois andaram mais um pouco pelo corredor com todos os observando.
<p>- Oi, Emily, querida. – Uma garota chegou por trás de Emily e a beijou no rosto. – Passou na minha frente, né?
<p>- O quê? – Emily ficou sem entender.
<p>- Você é mais fácil do que todo mundo.
<p>- Olha, garotinha... – Jason ia falar.
<p>- Não precisa. – Emily interrompeu Jason. – Eu conheço você? Porque se não conheço, acho melhor você seguir o seu caminho.
<p>- Calma. – A garota riu.
<p>- Calma, nada. Eu não devo nada a você. Se eu sou fácil ou não, é problema meu e não seu, a não ser que você seja a minha mãe. Você é a minha mãe? Não, você não é a minha mãe.
<p>- Eu não sou.
<p>- Não é, mas deve ser mãe de alguém por aí, já que você dorme com todo mundo no primeiro encontro. Quem é fácil agora?
<p>- Eu vou embora. – A garota fechou a cara e foi embora.
<p>- Já devia ter ido! – Emily gritou enquanto a garota desfilava pelo corredor com toda a pose que tinha.
<p>- Nossa, você não precisa de ajuda. – Jason ficou impressionado.
<p>- Nenhum pouco.
<p>- Eu ganho outro beijo agora?
<p>- Bem que você queria, né? – Emily sorriu.
<p>- Achei que você fosse fácil. Até disse isso para o blogueiro, você está me decepcionando. – Jason riu.
<p>- Cala a boca.</p>
<center><h4>--*--</h4></center>
<p>- E aí, como você está lidando com o blogueiro atacando de novo? – Brandon estava mexendo no computador enquanto Jason estava deitado na cama olhando as luzes no teto.
<p>- Bom, hoje não foi um total desastre. A Emily acreditou em mim e não ligou para a droga do post. Uma vitória finalmente.
<p>- Que bom, não é?
<p>- É ótimo para variar. – Jason lembrou de Lisa. – Como vai você com a Lisa?
<p>- Ela é incrível.
<p>- E você é mais parado que uma porta.
<p>- Não é bem assim.
<p>- Ah, qual é, Limpa Pó de Cabelo. Qual é o seu problema?
<p>- Como assim?
<p>- Com as garotas. É timidez? É medo? Falta de autoestima?
<p>- Nem todo mundo é atirado como você.
<p>- Muitos me dizem isso. Estou começando a achar que é um xingamento. – Jason ficou pensativo. – Quer dizer que se a Lisa não tivesse te beijado, vocês ainda não estariam namorando?
<p>- Quer a verdade?
<p>- Foi o que eu perguntei.
<p>- Provavelmente não. – Brandon riu.
<p>- Ah, qual é? Tanto cabelo e nenhuma atitude? Acho que Deus me colocou na sua vida, precisa aprender muito.
<p>- Foi mal, mas você é a última pessoa que eu quero usar como exemplo para ser.
<p>- Qual é o problema em ser como eu?
<p>- Eu gosto de ficar com alguém que signifique algo para mim.
<p>- Olha, sentimento é um saco. Do meu jeito é mais fácil. Você fica com uma garota hoje, mas amanhã você pode fazer o que quiser porque não deve nada a ela. Não tem cobranças, nem ligações chatas, nem conversas bobas e clichês de sentimentos. – Jason revirou os olhos.
<p>- Mas você não sente vontade de ficar com alguém para valer? – Brandon ficou interessado. – Achei que estava gostando da tal da Emily.
<p>- É mais o gosto pela conquista, eu acho. Ela só me dá fora, talvez por isso fiquei interessada nela. E ela sabe disso, por isso faz o que faz. Garotas são previsíveis. – Jason bufou.
<p>- E você se sente bem fazendo isso? Nunca sentiu nada por nenhuma garota que você ficou?
<p>- Eu posso até ter sentido, mas passou muito rápido. Essa vontade de querer ficar com alguém, essa necessidade, eu não quero sentir. Eu curto o momento. A vida não é uma música ou filme romântico.
<p>- E se você perdeu uma grande garota nesse meio tempo?
<p>- Eu vou ter que esperar pela sorte e encontrar outra. É um risco que eu tomo.
<p>- Eu não sei se você é corajoso ou idiota. – Brandon não quis ofender.
<p>- Vai por mim, isso não tem nada de coragem. Eu tenho medo de gostar de verdade de alguém e isso acabar mal, isso não é ser corajoso. Isso é ser medroso, por isso prefiro não me apegar.
<p>- Acho que nós dois somos medrosos, mas de jeitos diferentes.
<p>- Verdade, mas eu me divirto mais. – Jason riu.
<p>- Não vou discutir.
<p>Os dois riram.
<p>- Olha, essa é a primeira vez que a gente conversa e eu não sinto ódio por você. – Brandon percebeu.
<p>- Olha, Cabelo de Leão, essa é a primeira conversa decente que temos e não acabamos com eu querendo te bater.
<p>- Me chamar de Bran te mataria?
<p>- Mataria, sim. Por favor, não tira isso de mim.
<p>- Você estragou o clima. – Brandon voltou para o computador.
<p>- Ainda bem, não ia querer você tentando me beijar.</p>
</body></html>";
            }
        }

        public void clkAbrirComentar(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MyPopupPage("SegObscuros", condicao.ToString()));
        }

        public void clkIrMenu(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MenusView.MenuSegredosObscurosPage());
        }

        public void clkAbrirProximo(object sender, EventArgs e)
        {
            if (condicao + 1 > 10)
            {
                Navigation.PushModalAsync(new Capitulo3Page(condicao + 1));
            }
            else
            {
                Navigation.PushModalAsync(new Capitulo2Page(condicao + 1));
            }
        }

        public void clkSalvar(object sender, EventArgs e)
        {
            try
            {
                if (chkCapitulo.IsChecked == true)
                {
                    LerCapitulo(condicao.ToString(), "true");
                    //var message1 = "CAPÍTULO LIDO";
                    //DependencyService.Get<IMessage>().ShortTime(message1);
                }
                else
                {
                    LerCapitulo(condicao.ToString(), "false");
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
                    Capitulo = condicao,
                    Historia = "SegObscuros"
                }, UserLocalData.userUID, "SegObscuros", "Capitulo" + capitulo);
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