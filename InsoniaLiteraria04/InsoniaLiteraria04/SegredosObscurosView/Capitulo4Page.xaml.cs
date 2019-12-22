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
    public partial class Capitulo4Page : ContentPage
    {
        DBFire service;
        public int condicao;

        public Capitulo4Page(int numero)
        {
            InitializeComponent();
            service = new DBFire();
            condicao = numero;
            mostrarCapituloSalvo("SegObscuros", "Capitulo" + numero.ToString());

            if (numero == 16)
            {
                lblTitulo.Text = "Capítulo 16 - Reconciliação";
                htmlPage.Html = @"<html><body>
<p>Jason encostou perto do armário de Emily enquanto ela pegava seus livros para ir para a aula.
<p>- Bom dia. – Ele sorriu.
<p>- Bom dia. – Ela estava séria.
<p>- Você pediu um tempo. Já está pronta?
<p>- Isso é pressão.
<p>- Não, isso é vontade de saber se você me perdoou ou não.
<p>- Não vai ser na hora que você quer. – Emily ficou irritada. – Eu preciso pensar.
<p>- Mas...
<p>- Jason, relaxa, tá bom?
<p>- Eu não vou ficar te esperando para o resto da vida. – Jason se irritou também.
<p>- Eu não pedi para você esperar.
<p>Emily bateu bem forte a porta do seu armário e isso meio que assustou o Jason. Ela nem se despediu antes de ir embora. Ele tinha dito a coisa errada.</p>
<center><h4>--*--</h4></center>
<p>- Ela me deu um fora de novo.
<p>- Tem certeza que foi um fora? Pode ter sido um sai para lá. – Brandon não queria rir, mas estava difícil. Ele achava que Jason ficava muito engraçado com raiva.
<p>Os dois estavam assistindo a aula de Geografia, mas Jason nem fazia questão de falar baixo, diferente de Brandon que só sabia sussurrar.
<p>- Eu vou te dar um sai para lá com um soco daqui a pouco. – Jason fechou o punho e apontou para Brandon.
<p>- Relaxa, eu só estou tentando aliviar a tensão.
<p>- Então não faça isso.
<p>- O que quer que eu faça então? – Brandon ficou confuso.
<p>- Sei lá, me diz o que fazer, meus amigos costumam fazer isso.
<p>- Olha, eu não sou muito bom quando o assunto é mulher.
<p>- Já deu para perceber isso. – Jason não perdia a piada.
<p>- Você não sabe mesmo como tratar um amigo, não é? Por que eu deveria saber então? Além do mais, você que levou um fora, eu tenho uma namorada muito linda. – Brandon sorriu orgulhoso.
<p>- Mas isso não dependeu de você para acontecer então é meio triste. – Jason tirou o sorriso da cara de Brandon.
<p>- Cala essa boca.
<p>- Não estou a fim.
<p>- Olha, vamos voltar a falar sobre a Emily.
<p>- Tudo bem, mas antes, eu tenho uma curiosidade. – Jason começou a olhar para o cabelo de Brandon.
<p>- Qual?
<p>- No inverno, você não precisa usar touca, não é? O cabelo já faz esse efeito.
<p>- Eu desisto.
<p>- Está bem, me desculpa.
<p>- Me deixa ver se posso te ajudar. O que a Emily disse exatamente?
<p>- Disse que ela não pediu para eu ficar esperando.
<p>- Bom, vai ver ela quer que você siga em frente. – Brandon deu a ideia.
<p>- Tem razão. É tão obvio. Ela não vai me perdoar, só quer me enrolar até eu ficar com outra e ela colocar a culpa em mim e sair como vítima.
<p>- Tudo bem, então vamos pensar em como fazer isso e...
<p>- Qual é? – Jason interrompeu Brandon. – Eu sou mestre em seguir em frente.
<p>- Como assim?
<p>- Te mostro depois.
<p>Assim que a aula acabou, Jason piscou para Brandon e saiu da sala como um foguete, Brandon correu para tentar acompanha-lo. Ele viu Jason andando pelos corredores todo cheio de pose e parando perto da primeira garota bonita que viu.
<p>- Oi. – Jason cumprimentou a garota sorrindo.
<p>- Oi. – Ela também sorriu.
<p>- Bom, eu sou o...
<p>- Jason, eu sei. – A garota parecia empolgada. – Meu nome é Vanessa.
<p>- Muito prazer. Olha, eu estava te olhando ali e não consegui ficar longe. Eu tinha que te conhecer.
<p>- Sério? – Ela ficou animada.
<p>- Você sabe impressionar um cara. – Jason sorriu. – Eu estava pensando se você gostaria de sair comigo mais tarde e me impressionar mais. O que você acha disso?
<p>- Eu iria adorar.
<p>- Quer dizer que é assim? – Emily apareceu atrás de Vanessa. – Eu não te perdoo e você já corre atrás de outra? – Então ela sumiu.
<p>- Que bom. Então a gente combina. – Jason tentou ignorar a aparição de Emily balançando a cabeça.
<p>- Tudo bem, me liga. – Vanessa marcou o telefone dela na mão de Jason com uma caneta.
<p>- Isso, liga para ela. – Emily apareceu de novo no mesmo lugar com os braços cruzados. – Faz um favor e me esquece.
<p>- Sai daqui. – Jason falou baixinho.
<p>Vanessa achou estranho e olhou para trás, mas não tinha ninguém atrás dela.
<p>- Está tudo bem? – Vanessa estava preocupada.
<p>- Ah, muito bem.
<p>- Exatamente, muito bem. – Emily parecia brava. – Parece que o que você sentia por mim não era tão importante assim.
<p>- É claro que era e ainda é. – Jason falou para o nada.
<p>- Com quem você está falando? Você está bem? – Vanessa estava se sentindo perdida.
<p>- Então por que está atrás dessa garota? – Emily encarou Jason. – Você já desistiu?
<p>- Sai da minha cabeça! – Jason gritou e Emily desapareceu.
<p>- Olha, depois a gente se fala. – Vanessa saiu de lá assustada.
<p>- Não, espera! – Mas Vanessa ignorou Jason e foi embora.
<p>- O que foi isso? – Brandon se aproximou de Jason, ele tinha ouvido tudo.
<p>- Esse sou eu falando com o meu anjo da guarda ou o fantasma da culpa, sei lá.
<p>- O quê?
<p>- Eu estou perdido, Brandon. – Jason encarava Emily que estava sorrindo para ele como uma vencedora.</p>
<center><h4>--*--</h4></center>
<p>- Então é isso. Se o resultado desse cálculo for que nem o do primeiro, a conta está certa.
<p>Lisa continuava a ensinar matemática para o Kol na biblioteca.
<p>- Nossa, você deveria ser a nova professora da escola, porque é muito mais fácil aprender com você.
<p>- Não exagera. É só um jeito diferente.
<p>- Eu só sei que o que eu não aprendia, você conseguiu me ensinar.
<p>- Bom, é ótimo você ter aprendido, assim meu trabalho está feito. – Lisa sorriu.
<p>- Ah, você podia me ensinar outra coisa, sei lá. – Kol parecia desesperado.
<p>- Relaxa, Kol. A matemática acabou, mas a amizade não. Podemos falar de outra coisa.
<p>- Podemos ir ver alguns cachorros vira-latas na praça hoje. O que você acha?
<p>- Eu adoro cachorros.
<p>- Isso foi um sim?
<p>- Foi.</p>
<center><h4>--*--</h4></center>
<p>- Quer dizer que você vai sair com o Kol?
<p>- Vou.
<p>Lisa e Jason estavam conversando na sala de aula.
<p>- Mesmo depois que ele admitiu que estava a fim de você?
<p>- Já resolvemos isso, tá bom? Ele interpretou mal e já está tudo explicado.
<p>- Se você está dizendo. – Jason ainda estava com o pé atrás. – O Cabelos Ao Vento não é a sua melhor opção, mas ele é melhor do que o Kol estranho.
<p>- O Kol é muito legal, tá bom? Mas eu amo o Bran.
<p>- Ama mesmo?
<p>- Amo. Amo mesmo. – Lisa confirmou.
<p>- Sorte a sua.
<p>- Falando em amor, e quanto a Emily?
<p>- Por que você associou...
<p>- Jason. – Lisa fez sua cara de reprovação.
<p>- Ela não quer falar comigo.
<p>- É, o Bran me disse que você foi chamar outra para sair. Qual é o seu problema? – Lisa bateu na cabeça do Jason.
<p>- Ai! Além do mais, foi ideia do seu namorado cabeludo.
<p>- E desde quando você ouve conselhos do Bran? Eu amo o cara, mas ele não entende nada disso.
<p>- Eu estou desesperado. Não sei mais o que fazer. O que eu tenho que fazer? Me diz.
<p>- Olha, você acha que sabe tudo sobre garotas, mas você também não sabe de nada.
<p>- Como?
<p>- Ela gosta de você e só quer saber se você gosta dela do mesmo jeito.
<p>- Eu já disse que gosto. – Jason fechou a cara.
<p>- Dizer não basta. Você tem que provar. Desistir e chamar outra garota para sair não é um jeito de provar.
<p>- Mas eu não sei o que fazer.
<p>- Você sabe sim, peça desculpas ao estilo Jason.
<p>- Eu não costumo pedir desculpas.
<p>- Aprenda então.
<p>- Tudo bem, acho que posso fazer isso. Eu já vi em filmes. Eu só tenho que comprar flores e tudo resolvido.
<p>- Nem toda garota aceita ser comprada.
<p>- Você não entende nada.
<p>- Eu não entendo nada? – Lisa arregalou os olhos.</p>
<center><h4>--*--</h4></center>
<p>- Oi. – Jason encontrou com Emily nos corredores.
<p>- Jason, eu já disse...
<p>- São para você. – Jason mostrou para Emily um buque de rosas. – Amarelas, suas favoritas. Eu até matei uma aula para ir comprar.
<p>- Não precisava disso. – Emily parecia ter gostado, mas ainda não estava feliz.
<p>- É claro que precisava. Eu estou tentando te impressionar.
<p>- E me impressionou. Mas flores não vão consertar as coisas.
<p>- Mas são muitas flores. – Jason apontava para o buque. – Toma.
<p>Emily aceitou o buque.
<p>- São lindas.
<p>- Eu sei. – Jason já estava cantando vitória. – Você gostou?
<p>- Claro. – Emily não conseguia falar algo ruim depois daquele gesto.
<p>- Eu sabia que ia dar certo. E a Lisa dizendo que você não ia ceder depois de um buque de flores. Ela não sabe de nada. – Ele gargalhou.
<p>- Pensando bem, eu odeio receber flores de manhã. – Emily jogou as flores no chão.
<p>- O quê? – Jason se espantou.
<p>- Não me compre com flores, está bem?
<p>E antes de Emily sair, ela ainda pisou nas flores.
<p>- Sabe quanto custou essas flores? – Jason gritava enquanto Emily ia embora. – Você me deve cem pratas!</p>
<center><h4>--*--</h4></center>
<p>- Olha, eu estava enganado, está bem?
<p>- Sério?
<p>Jason se sentou ao lado de Emily na aula de Literatura.
<p>- Eu não deveria ter tentado te comprar com flores. Não era a minha intenção. Me desculpa. – Ele estava falando bem devagar com medo de qualquer reação que Emily tivesse.
<p>- Eu te desculpo por isso.
<p>- Por isso eu te trouxe chocolates. – Jason colocou na mesa de Emily uma caixa de bombons em formato de coração.
<p>- Jason...
<p>- São aqueles crocantes. Eu sei que você gosta porque no piquenique eu levei um monte deles e você comeu tudo.
<p>- E quanto a parte de “eu não deveria tentar te comprar”? – Emily não acreditava no que estava vendo.
<p>- Mas são chocolates. Toda garota gosta de chocolates.
<p>- Como presente, não suborno.
<p>- Tudo bem. – Jason pegou a caixa de bombom de volta. – Você me deixou com vontade de comer chocolate naquele dia porque não deixou nenhum para mim. Agora eu como esses sozinho. – Jason começou a engolir os bombons sem nem ao menos mastigar.
<p>- Faça bom proveito. – Emily segurou a risada.</p>
<center><h4>--*--</h4></center>
<p>- Olha só o que eu consegui.
<p>Jason chegou todo animado perto de Emily na aula de Inglês segurando dois ingressos.
<p>- O que é isso? – Ela não parecia tão interessada.
<p>- Dois ingressos para uma viagem de balão. Nós vamos hoje à tarde.
<p>- Nós?
<p>- Você e eu.
<p>- Aonde você arranjou um balão nessa cidade? – Emily não estava surpresa, mas ficou curiosa.
<p>- Não foi fácil. – Ele enfatizou isso. – Mas eu conheço umas pessoas.
<p>- Não gosto de altura, e se o balão furar?
<p>- Você é meio que um anjo. Pode voar.
<p>- E você é meio que um galinha. Ah, droga, esqueci que galinhas não voam.
<p>- Isso é um não? – Ele já estava desistindo.
<p>- Absolutamente não.
<p>- Mas foi tão difícil...
<p>- Leva a garota que você chamou para sair hoje de manhã. Ela só sabia falar disso no banheiro.
<p>- Ah, não é o que você pensa.
<p>- O que eu penso, Jason? – Emily ficou séria.
<p>- É um balão. – Ele fez cara de dó e sorriu ao mesmo tempo.
<p>- Não. – Emily se levantou da sua cadeira e foi se sentar do outro lado da sala de aula.
<p>- Que saco. – Jason rasgou os ingressos em um ataque de raiva.</p>
<center><h4>--*--</h4></center>
<p>- Me desculpa.
<p>- Pelo que agora?
<p>Jason foi falar com Emily quando ela estava no seu armário guardando suas coisas para ir almoçar.
<p>- Eu não deveria ter comido seus bombons. Foi criancice da minha parte.
<p>- Estavam bons?
<p>- Uma delícia, agora sei porque você gosta tanto deles. – Jason suspirou.
<p>- Bom saber. – Emily riu.
<p>- Emily, eu estou cansado. O que eu tenho que fazer? Eu não quero mais joguinhos. Só me diz o que eu tenho que fazer que eu faço.
<p>- Você não entende? Eu não quero flores nem bombons e...
<p>- Talvez um cachorro. Aqueles filhotes.
<p>- Não. – Emily riu.
<p>- Então o quê?
<p>- Eu não posso dizer o que você tem que fazer, Jason. Não é assim que funciona.
<p>- Então eu tenho que adivinhar o que você quer? Como isso é o certo? Eu não sou a Jean Grey, você sabe disso, não é?
<p>- Você não precisa de superpoderes. Eu não quero que você se sinta obrigado a me pedir desculpas, nem desculpas vazias. Eu quero algo real.
<p>- O que eu sinto por você é real.
<p>- E como você quer que eu acredite nisso? Você desconfiou de mim depois mesmo dizendo que gostava de mim foi atrás de outras garotas. Quer mesmo que eu acredite que suas desculpas são verdadeiras?
<p>- Eu só faço burrada, eu sei disso, mas eu quero consertar, mas eu não sei como. Eu não sou muito inteligente.
<p>- Não precisa ser inteligente para isso.
<p>Emily fechou a porta do seu armário e foi embora.</p>
<center><h4>--*--</h4></center>
<p>- Ela pisou nas suas flores? – Temperance ficou impressionada. – Estou começando a gostar dessa garota. Ela tem atitude.
<p>Jason, Temperance, Lisa e Brandon estavam almoçando juntos no refeitório.
<p>- Você comeu os bombons que eram para ela? – Lisa voltou a bater no Jason. – Qual é o seu problema, garoto?
<p>- Ela não queria. Eu não podia jogar fora. – Jason se explicou.
<p>- Ainda acho que você deveria seguir em frente. – Brandon opinou. – É o que ela está demonstrando que quer.
<p>- Amor, eu te amo, mas cala a boca. – Lisa beijou o rosto do namorado e fez cara de dó.
<p>- Eu levo um tapa e ele leva um beijo?
<p>- Compre para ela um bolo. – Temperance sugeriu. – E se ela não quiser, dá ele para mim. – Depois sorriu. – Eu estou com muita vontade de comer um bolo.
<p>- Só se for na sua cara. Ela já disse que não quer ser comprada.
<p>- Chama ela para sair. – Lisa deu outra ideia. – Faz algo romântico nesse encontro.
<p>- Primeiro, ela nunca vai aceitar sair comigo, não com esse humor.
<p>- Nossa, que garota difícil. – Temperance já não tinha mais ideias. – Será que ela aceita uma serenata?
<p>- Você podia sei lá, gritar no meio dos corredores. – Brandon riu.
<p>- E um livro? Garotas gostam de livros. – Lisa continuava pensando.
<p>- Um cartão romântico?
<p>- Talvez fogos de artificio.
<p>- Você podia prender ela em algum quarto escuro...
<p>E enquanto os amigos davam ideias, Jason não prestava mais atenção.
<p>- Carregue a mochila dela.
<p>- Enfeite o armário dela, coloque coisas rosinhas, fotos, vi isso numa série.
<p>- Faça um poema. Super romântico.
<p>De repente, Jason subiu em cima da mesa.
<p>- O que você está fazendo? – Lisa se assustou.
<p>- Garoto, desce daí, isso só funciona em High School Musical. – Temperance falou logo também assustada.
<p>- Pessoal, eu preciso de atenção aqui! – Jason começou a falar, mas a conversa no refeitório estava muito alta. – PESSOAL! Pe... PESSOAAAAAAAAAAAALLLL! – Ele gritou e de repente todos ficaram em silêncio e começaram a olhar para ele um pouco assustados e curiosos. – Valeu. Eu gostaria de dizer umas coisas.
<p>- Vai se candidatar a presidente estudantil? – Alguém gritou.
<p>- Fica quieto e vai escovar os dentes, você fede. – Jason não queria ser interrompido. – Bom, vocês devem saber quem eu sou. Meu nome é Jason, mais conhecido como O Cara, ou como eu gosto de falar, A Fonte dos Posts do Blogueiro. – Jason fez piada de si próprio. – Eu tenho que dizer que ultimamente está acontecendo algumas coisas comigo e eu estou mais confuso do que o normal.
<p>- O que está acontecendo? – Ninguém estava entendendo nada.
<p>- Eu quero pedir desculpas a todas as garotas por aqui e dizer que elas não vão mais poder sonhar em sair comigo, porque eu estou apaixonado. – Todos ficaram espantados. – É isso mesmo, Jason está apaixonado, podem dizer que é mentira ou brincadeira, mas não é, é verdade e ela... – Jason olhou para Emily que estava do outro lado do refeitório almoçando sozinha. – Ela está me olhando com aquela cara de “eu vou te matar se não descer daí, vou te matar também se falar meu nome”. – Emily começou a olhar para os lados toda envergonhada. – A verdade é que eu queria me desculpar e ela não aceitou minhas flores nem meus chocolates, nem meu passeio de balão, minha próxima tentativa era levar um suco para ela, mas ela provavelmente jogaria ele na minha cabeça, então eu meio que fiquei sem saber o que fazer. Mas agora eu sei. Eu não preciso dessas coisas para provar que eu gosto muito dela, basta ela olhar nos meus olhos. – Jason encarou Emily e todo mundo percebeu com quem ele estava falando. – E agora ela está com aquela cara de “você está me confundindo. O que está acontecendo?”. Eu sou um idiota e sempre faço besteira, eu odeio admitir, mas essa não vai ser a única vez que eu vou ter que subir em uma mesa e pedir desculpas, mas eu estou tentando ser alguém melhor e eu acho que por ela vale a pena.
<p>- Que lindo. – Lisa e Temperance falaram juntas.
<p>- Você não precisa dizer nada, porque eu sei que era isso que você queria que eu fizesse. – Emily sorriu. – Não exatamente isso, mas você me conhece, eu sou muito exagerado. Se eu não fizer um show, prefiro não fazer nada. – Jason riu. – Você sabe que eu posso te machucar, mas eu quero muito te fazer feliz, isso é tudo o que eu quero agora. – Emily continuava calada. – E agora você está com aquela cara “Eu não sei o que dizer para você.”. – Jason fez uma pausa. – Só diga que me perdoa e que topa se apaixonar comigo, porque se você topar, eu prometo mergulhar de cabeça, porque comigo é tudo ou nada.
<p>- Nossa, até eu me emocionei agora. – Lisa e Temperance riram do comentário de Brandon.
<p>Jason desceu da mesa e foi em direção a Emily.
<p>- Diz alguma coisa. – Jason olhou para Emily.
<p>- Eu não sei o que dizer, lembra?
<p>- Sua cara já diz tudo.
<p>- Ah, é? Minha cara diz o quê? – Emily estava sorrindo enquanto se levantava da cadeira toda envergonhada.
<p>- Sua cara diz “me beija agora”. – Jason sorriu vitorioso.
<p>- Ela não diz isso. – Emily riu. – Mas ela diz que te perdoa e que também está apaixonada por você.
<p>- Ouviram isso, pessoal?! - Jason voltou a gritar e Emily se assustou. – Ela está apaixonada por mim!
<p>- Cala essa boca. – Emily ficou com vergonha.
<p>- Posso te beijar agora?
<p>- Não.
<p>- Então vai ter que ser a força.
<p>- Nem pensar.
<p>Emily então o beijou. E de repente, por algum motivo que Jason desconhecia, o beijo dela era muito melhor do que o beijo dele.
<p>Todo mundo começou a bater palmas.
<p>- Meu Deus, que vergonha. – Emily estava começando a ficar vermelha. – Olha as coisas que você faz.
<p>- Eu não vou me desculpar por isso. Além do mais, somos incríveis, merecemos palmas mesmo.
<p>- Idiota.</p>
<br>
<p><i>“<b>É, PARECE QUE ESTAMOS EM CONTOS DE FADAS:</b> Eu estou muito orgulhoso de você, Jason. Parece que você finalmente virou gente e conseguiu a garota. Estou torcendo por vocês, é sério. A parte ruim é que agora minha vida está sem propósito, de quem eu vou revelar as verdades agora? De quem eu vou contar os segredos? Tá na cara que você vai ficar careta e sem graça com esse namoro. Aceito sugestões dos meus grandes amigos, até mais.”.</i> – Tesouro de Segredos Obscuros.</p>
</body></html>";
            }

            if (numero == 17)
            {
                lblTitulo.Text = "Capítulo 17 - Mudança de Alvo";
                htmlPage.Html = @"<html><body>
<p>Quando chegou em Dallas, Jason nunca imaginou que seria atacado por um blogueiro anônimo, nem que viraria amigo de uma CDF e pior, ele nunca imaginou que se apaixonaria por uma garota que faria ele se desafiar de todos os jeitos. Em Los Angeles, ele nunca lutou por uma garota, ele nunca subiu em uma mesa para se declarar, ele nunca se desculpou na vida. As coisas na vida eram engraçadas, isso não saía mais da cabeça dele.
<p>- Olha, não é tão difícil.
<p>- Já chega, eu estou cansado de tabela periódica.
<p>Outra coisa que Jason nunca tinha feito em Los Angeles era estudar. Jason tinha sido obrigado a estudar para uma recuperação de Química, e Emily já estava deixando ele louco com todas aquelas fórmulas, siglas e coisas de química quando ficaram até mais tarde na biblioteca para estudar. Ele sentia saudade de quando química para ele era só H2O e CO2
<p>- Você precisa aprender se quiser passar nessa matéria. Quer mesmo repetir o último ano? – Emily já tinha repetido isso tantas vezes que Jason já nem ligava mais.
<p>- É claro que eu não quero repetir o último ano.
<p>- Então vamos estudar, porque eu gosto de caras inteligentes.
<p>- E eu gosto de garotas que gostam de ir ao cinema e não na biblioteca.
<p>- Não vamos sair daqui até você aprender isso.
<p>- Você trouxe a sua cama, não é?
<p>- Não, mas eu uso você como colchão.
<p>- Quer dizer que você vai deitar em cima de mim? – Jason se animou. – Isso começou a ficar interessante.
<p>- Faça esses exercícios. – Emily jogou o livro de Química em cima de Jason. – E depois me mostre. – Ela foi educada depois.
<p>- Amor, do jeito que você está falando, eu te mostro até o céu.
<p>- Eu me contento com os seus exercícios de química, obrigada. – Emily riu. – E não me chame de “amor”.
<p>- Ai, você me deixa louco. Eu vou querer um chamego e um carinho mais tarde.
<p>- Faça logo.
<p>- Não mande em mim. – Jason fez uma cara de bravo que não convencia. – Mas isso pode ser bom em algumas ocasiões.
<p>- Você fala demais e está tentando me enrolar. Eu não estou vendo os exercícios sendo feitos.
<p>- Tem muita química rolando agora, você não acha? Isso é exercício prático, coração.
<p>- Não me chame de “coração”.
<p>- Quer que eu te chame como?
<p>- De Emily.
<p>- Mas é o seu nome.
<p>- Exato, não é tão burro quanto eu pensei. Agora faça os exercícios.
<p>- Você não vai parar, não é?
<p>- Não.
<p>- Você é muito chata.
<p>- Essa sou eu.
<p>- Não tinha isso no seu currículo.
<p>- Contrate outra então. – Emily deu um sorriso maldoso.
<p>- Olha, eu tenho recebido muitos currículos. Muitas garotas lá foram estão doidas por esse emprego.
<p>- Elas sabem que não tem nenhum benefício?
<p>- Tudo depende das necessidades de cada um.
<p>- Como você consegue? – Emily tentou segurar a risada, mas não conseguiu.
<p>- O quê? Ser adorável?
<p>- Não, falar tanta besteira. Isso também não estava no seu currículo.
<p>- Segredo, eu geralmente minto no meu currículo.
<p>- Imaginei. – Emily riu e revirou os olhos. – Agora...
<p>- Faça os exercícios. Eu já sei.
<p>- Olha só, está aprendendo.
<center><h4>--*--</h4></center>
<p>Mas enquanto Emily fazia de tudo para Jason aprender Química, do outro lado da cidade Lisa e Kol andavam pela praça dando o que sobrou do saco de pipoca para os pombos que toda hora pousavam por perto.
<p>- Não acredito que me convenceu a ir ao cinema. -  Lisa jogava algumas pipocas no chão enquanto comia outras.
<p>- Eu queria muito assistir aquele filme. – Kol riu. – Você gostou? Porque eu adorei.
<p>- Na verdade, o filme foi muito bom. E o cinema daqui é muito legal também.
<p>- Verdade. Mas melhor do que o filme foi a companhia.
<p>- Para. – Lisa ficou sem graça. – Você está me mimando demais. Me comprou sorvete, me levou ao cinema, quando o Jason faz isso é porque ele quer alguma coisa e eu sempre arranjo problemas.
<p>- Sou um amigo sem interesses.
<p>- Ainda bem.
<p>Os dois se sentaram em um banco.
<p>- Então é verdade o que estão dizendo? O Jason se declarou mesmo na frente de todos para a Emily? – Kol riu só de imaginar a cena.
<p>- É sim, você devia ter visto. Foi tão lindo. Me orgulhei dele. – Lisa riu.
<p>- Eu não gosto muito do cara, mas eu tenho que admitir que ele é muito corajoso, pouca gente faz isso.
<p>- Eu mesma não teria coragem. Quer dizer, eu não ligo de me declarar para alguém, mas fazer isso na frente de todos são outros quinhentos. E se a pessoa me rejeitar? Imagina a cara que eu ia fazer, é assustador.
<p>- Para mim, já é difícil até me declarar para alguém.
<p>- Eu sempre fui atrás do que eu queria. Eu odeio ter esse sentimento de querer fazer alguma coisa e não poder fazer, por isso eu não penso muito antes de fazer, lido com as consequências depois. – Lisa ficou sem jeito de falar daquele jeito. – Eu julgo tanto o Jason por isso e faço igual.
<p>Kol ficou meio que admirando Lisa falar tudo aquilo. Por que era tão fácil ficar olhando para ela e imaginar? Por que era difícil dizer logo?
<p>- Você tem atitude. Não tem medo de assustar alguém?
<p>- Eu assusto? – Lisa ficou surpresa. Ela nunca tinha pensado nisso.
<p>- Bom, eu ainda estou aqui então não me assustou.
<p>- Acho que não assustei o Bran também já que ele ficou.
<p>- Ele tem muita sorte de ter você.
<p>- Nem tanta sorte assim.
<p>- Sem ser modesta, por favor. Qualquer um teria muita sorte e felicidade só de ficar perto de você. –Kol não sabia disfarçar.
<p>- Acho melhor eu ir embora. – Lisa ficou desconfortável. – Está ficando tarde.
<p>- Espera.
<p>- O quê? Vai me pagar um hambúrguer agora? – Lisa brincou para disfarçar o clima estranho que estava.
<p>- Você está muito apaixonada pelo Brandon?
<p>- Por que quer saber? – Lisa ficou confusa e não estava gostando do rumo daquela conversa. Por que ela não se levantava do banco e ia embora?
<p>- Você já pensou que poderia se apaixonar por outra pessoa? Às vezes, acontece.
<p>- Eu estou muito feliz com a Bran, eu não sei se vai ser para sempre, mas ele é quem eu preciso agora.
<p>- E quanto a mim?
<p>- Como assim?
<p>- Nunca pensou que poderia precisar de mim?
<p>- Kol...
<p>- Me diz que eu não estou entendendo errado. A gente tem saído direto e conversamos o tempo todo. Eu estou imaginando isso tudo?
<p>- Somos amigos, é normal. Eu achei que a gente já tinha conversado sobre isso.
<p>- Não é não.
<p>- Kol, olha...
<p>- Pela primeira vez desde que a Andressa morreu, eu não me sinto culpado por gostar de alguém.
<p>- Você não pode gostar de mim.
<p>- Não é uma coisa que eu possa escolher. – Kol se aproximou mais de Lisa.
<p>- É melhor eu ir.
<p>- Antes eu preciso ter certeza de uma coisa.
<p>- Do que você está falando?
<p>Foi rápido, e talvez Lisa só ficou parada lá porque ficou em choque, ela não tinha gostado, na verdade, ela não poderia gostar. Kol parecia ter juntado toda a sua coragem em um ato só. Ele esperava que Lisa retribuísse o beijo, talvez como reflexo ou como vontade mesmo, mas isso não aconteceu, Lisa ficou lá imóvel, chocada, olhando para ele com muita apreensão e decepção.
<p>- Lisa, eu...
<p>Se Kol beijou Lisa sem nenhum aviso, ela tinha que retribuir de alguma forma e o seu tapa também foi sem aviso, mesmo Kol já esperando por isso.
<p>- Lembra da nossa amizade? Ela acabou. – Lisa ficou séria. – Que tipo de pessoa você acha que eu sou?
<p>Lisa se levantou do banco e foi embora.</p>
<center><h4>--*--</h4></center>
<p>- Eu não sei quantas ligações o carbono faz, mas que droga!
<p>Jason estava tacando todos os seus livros de química na parede do quarto quando Lisa entrou lá de surpresa e assustada. Jason achou que Lisa estava assustada com a bagunça que ele estava fazendo, mas não estava nem perto de acertar o motivo.
<p>- A gente pode conversar? – Lisa parecia ter acabado de sair de uma maratona de tão nervosa e elétrica que estava.
<p>- Eu não posso agora, eu estou terminando minha lição de química.
<p>- Está me trocando por química?
<p>- Na verdade, eu estou te trocando pela Emily. Ela que está me fazendo fazer essa droga.
<p>- Eu faço os exercícios para você depois, tá bom?
<p>- Continue. – Jason se interessou.
<p>- Só preciso do meu amigo agora.
<p>- Parece ser sério. – Jason olhou para o rosto de Lisa e finalmente percebeu sua preocupação. – Sou todo ouvidos. – Jason se sentou na cama ao lado de Lisa. – O que houve?
<p>- Você já gostou de mim?
<p>- O quê? – Jason não esperava por isso.
<p>- Tipo, quando morávamos em Los Angeles, a gente passava o tempo todo junto. Íamos a praia, íamos aos lançamentos de filmes, lanchonetes, sorveterias, shoppings... – Lisa falava descontroladamente.
<p>- Tudo bem, eu já entendi. Éramos dois solitários.
<p>- Eu estou falando sério, Jay. Você já sentiu algo a mais?
<p>- Você já? – Jason não estava entendendo aquela conversa.
<p>- Só me responde.
<p>- Olha, se esse é o seu jeito de dizer que percebeu que estava apaixonada por mim a vida toda, eu tenho que dizer que você está um pouco atrasada, e eu gosto mesmo da Emily, mas a amizade continua. – Jason riu, ele sabia que não era isso que ela queria falar.
<p>- O Kol me beijou. – Lisa parou de enrolar.
<p>- Por essa eu não esperava. Como?
<p>- Com a boca.
<p>- Nossa, ainda bem que não foi com o nariz. – Jason foi irônico.
<p>- Fomos ao cinema, e depois ao parque, e ele veio com umas conversas e de repente estava me beijando. – Lisa falava sem respirar.
<p>- Vocês foram ao cinema? – Jason falou querendo julgar.
<p>- Qual é o problema? Você e eu vamos ao cinema o tempo todo.
<p>- É diferente. Quantas vezes eu preciso te dizer isso? Lisa, eu não estava tentando te conquistar. Na verdade, eu falava algumas coisas e se te conquistasse seria meio que um bônus, mas eu estava lá mais pela amizade. Não tinha maldade.
<p>- Eu estou me sentindo culpada. Acho que eu dei esperanças para ele.
<p>- Você não me disse que já tinham conversado sobre isso?
<p>- Mas a gente conversou. Eu não sei o que aconteceu. Isso é horrível. – Lisa estava prestes a ter um colapso.
<p>- O cara te beijou mesmo sabendo que você tem namorado. O culpado é ele.
<p>- Ele se sente só e carente.
<p>- Exato. Está tão desesperado que se apaixonaria até pela vendedora que diz “volte sempre”. A culpa não é sua.
<p>- O que eu faço? Conto para o Bran?
<p>- Se contar para o Brandon, ele vai se descabelar, o penteado dele já não é um dos melhores e se ele se descabelar, vai ser pior.
<p>- Eu estou falando sério.
<p>- O que você fez depois do beijo?
<p>- Sai correndo.
<p>- Antes disso. – Jason queria mais detalhes.
<p>- Dei um tapa nele. – Lisa estava se sentindo mais culpada agora.
<p>- Essa é a minha garota. – Jason riu. – Mas ainda bem que foi no parque e não no cinema, senão vocês iriam ser Sandy e Junior 2.0 cantando Splish Splash.
<p>- Será que dá para ficar sério? Isso não tem graça nenhuma.
<p>- Eu estou sério. Quem foi que disse que o Kol era um problema? Eu mesmo. Então você tem que se afastar desse cara e torcer para o Cabelo Para Cima não descobrir.
<p>- Não vou conseguir mentir para ele. Acho melhor contar a verdade. Mentira tem perna curta.
<p>- Pode ser, e se ele souber por outra pessoa vai ser pior.
<p>- É.
<p>- Pode fazer meus exercícios agora?
<p>Lisa olhou com cara de reprovação.
<p>- Você prometeu.
<p>- Emily vai gostar de saber disso?
<p>- Não custava tentar. – Jason voltou a pegar os livros do chão.</p>
<br>
<p><i>“<b>EU DISSE QUE VOLTARIA, NÃO DISSE? </b> Bom, pessoal, eu não vou citar nomes, nem nada, mas parece que está tendo um troca-troca de casais por aqui, fiquem ligados. Pelo que eu fiquei sabendo, após a morte da sua querida amada, Kol está jogando por todos os lados agora, será que ele desistiu de sofrer e resolveu ser o novo pegador do Colégio Carmel? Bom, é provável, porque até as comprometidas estão na sua mira. Muito cuidado, amigos, não queremos ver garotos traídos e magoados por aqui, satisfaçam as suas namoradas, por favor. Para deixar claro, isso não me surpreende, agora que o Jason está castrado, alguém precisa ser o novo cachorro da escola, o que me surpreende é ser o Kol, queridinho de todos. Bom, vamos aguardar para mais informações.”.</i> – Tesouro de Segredos Obscuros.</p>
<br>
<p>- Espera um pouco, o blogueiro é conselheiro amoroso agora? – Temperance estava rindo lendo o novo post do blog enquanto caminhava pelos corredores da escola naquela manhã. É claro que mesmo lendo, seus olhos de vez em quando, olhavam ao redor a procura de Nathan.
<p>- Tempe, eu preciso da sua ajuda e é urgente. – Jason desviava correndo das pessoas para chegar até Temperance.
<p>- O que houve?
<p>- O que você sabe sobre química?
<p>- Tudo.
<p>- Ótimo, você tem umas coisas para fazer para mim.
<p>- Eu não vou fazer suas lições de química. – Temperance cortou logo.
<p>- Por que não?
<p>- Porque nas provas eu não vou poder te ajudar.
<p>- É só me passar as respostas por mensagem de texto. – Jason sempre sugeria isso, mas nunca tinha sucesso.
<p>- Já disse que não.
<p>- Depois que você começou a namorar, ficou mais chata que o normal.
<p>- Eu não estou namorando.
<p>- Ainda não? – Jason ficou surpreso. - Garota, eu já falei que você precisa superar a paixão que sente por mim.
<p>- E eu já falei que você precisa enxergar que nem toda garota se sente atraída por você.
<p>- Claro. – Jason riu da “piada” de Temperance.
<p>- Parando de falar besteira, você viu o que o blogueiro falou sobre o Kol?
<p>- Não, eu não vi mais nada do Blog desde que voltei com a Emily. Eu estou com paz de espirito. – Jason sorriu.
<p>- Lindo, maravilhoso e adorável. – Temperance fez cara de nojo. – Ele meio que disse que o Kol está atrás de garotas comprometidas.
<p>- Então você está livre. – Jason continuou brincando.
<p>- Sabe de alguma coisa?
<p>- Olha, eu não quero falar sobre o Kol, nem sobre a Lisa...
<p>- Lisa? O que ela tem a ver?
<p>- Nem sobre a Lisa, nem sobre a Maddie ou o Cabelo de Juba. – Jason pensou rápido. – Quero falar sobre Química e o quanto você pode me ajudar.
<p>- Quer começar um namoro enganando a sua namorada?
<p>- É só um exercício idiota.
<p>- E ela está confiando que você vai fazer, achando que você pode.
<p>- Ela é ingênua, eu já entendi.
<p>- Faz a droga do exercício.
<p>- Tá bom.
<p>Jason saiu resmungando como se a sua mãe tivesse mandado ele lavar a louça pela terceira vez.</p>
<center><h4>--*--</h4></center>
<p>- Por que o blogueiro está em cima de você? – Maddie correu atrás de Kol que estava indo para a escola mais cedo e mais rápido.
<p>- Do que você está falando?
<p>- O blogueiro postou coisas horríveis de você agora de manhã. Por que ele fez isso?
<p>- Eu vou lá saber? – Mas Kol achava que sabia ou mais ou menos.
<p>- Ele quase nunca fala de você. Agora fez um post exclusivo só para você.
<p>- O que ele disse?
<p>- Que você queria ser o novo pegador ou algo assim. – Maddie falou com ar de desprezo, ela odiava caras desse tipo.
<p>- Ele está viajando.
<p>- Talvez, mas ontem você chegou muito tarde. Onde você estava?
<p>- Você é a minha mãe agora?
<p>- Só estou preocupada. – Maddie ficou indignada, Kol não costumava falar assim com ela.
<p>- Não precisa se preocupar, eu não sou um bebê.
<p>- Eu só vou te avisar uma coisa. Se você virar uma nova versão estranha do Jason, eu mato você.
<p>- Você não sabe do que está falando.</p>
<center><h4>--*--</h4></center>
<p>- Oi. – Nathan surpreendeu Temperance que estava concentrada em sua leitura em uma das mesas que ficava no meio do pátio.
<p>- Oi. Tudo bem?
<p>- Acabei de chegar. Está lendo o quê?
<p>- Uma coisa boba. – Ela fechou o livro.
<p>- Espero não ter atrapalhado.
<p>- Você não atrapalha nunca. – Temperance se sentiu boba dizendo isso.
<p>- Bom saber. – Nathan sorriu. – Ontem à noite, eu fiquei com vontade de ligar para você e conversar.
<p>- Devia ter ligado. Eu teria atendido.
<p>- Vou me lembrar disso na próxima vez.
<p>- Quando vai ser a próxima vez? – Temperance nem percebeu que disse aquilo.
<p>- Essa noite me parece ótimo.
<p>- Vou ficar com o telefone na mão esperando.
<p>- E que tal agora eu ficar aqui vendo você ler?
<p>- Tudo bem. – Ela sorriu.
<p>- Só não interprete os personagens, é um pouco assustador.
<p>- Então se prepare para se assustar.</p>
<center><h4>--*--</h4></center>
<p>- “Vou ficar com o telefone na mão esperando”? “Então se prepare para se assustar”? Que droga é essa? – Jason sabia mesmo deixar Temperance para baixo.
<p>Ela chegou na sala de aula toda animada para contar a conversa que teve com Nathan para seu amigo, mas ele não encarou como ela queria.
<p>- O que você queria que eu fizesse? – Ela ficou indignada.
<p>- Sei lá, desse um beijo nele, ou tirasse o sutiã, qualquer coisa menos isso.
<p>- Ele sorriu depois que eu disse, tá? – Temperance queria deixar muito claro que ela estava certa.
<p>- Porque ele é um bobão.
<p>- Não diz isso dele, não o conhece.
<p>- Já conheço o suficiente para saber que ele é mais lerdo que você.
<p>- Estamos indo devagar. – Temperance vivia de explicações.
<p>- Não, vocês estão parados. Estão piores que câmera lenta. Você está andando muito com o Brandon.
<p>- Oi, gente. – Maddie se aproximou dos dois.
<p>- Oi, Maddie. – Temperance sorriu.
<p>- Oi. – Jason falou “oi” só pela educação que ele quase não tinha.
<p>- Jason, a gente pode conversar? – Maddie parecia séria, não estava com aquela cara alegre ou debochada quando falava com Jason.
<p>- Parece sério.
<p>- E é.
<p>- Bom, gente. Eu vou sentar ali do outro lado. – Temperance pegou suas coisas, se levantou da cadeira e sentou em uma carteira mais para frente da lousa para deixar os dois a sós.
<p>- O que está acontecendo? – Jason ficou curioso.
<p>- Ficou sabendo que o blogueiro parou de falar de você e agora está atacando o meu irmão?
<p>- Eu ouvi dizer, estou até planejando a minha festa de “Viva a Liberdade”. O que eu tenho a ver com isso? Quer que eu dê dicas para o Kol de como lidar com isso? É só sair gritando com todo mundo, ajuda.
<p>- Não, eu quero saber uma coisa. Desistiu de descobrir quem é o blogueiro?
<p>- É claro que não, mas eu não tenho pistas no momento.
<p>- É porque está sozinho nisso. Precisa de ajuda. – Maddie parecia ansiosa.
<p>- E você quer me ajudar?
<p>- Eu não vou deixar o blogueiro mexer com o meu irmão.
<p>- Sabe, você às vezes me assusta.
<p>- Vai me ajudar ou não? Posso pedir para outra pessoa.
<p>- Eu não seria eu se não quisesse descobrir quem é o blogueiro, é claro que eu topo, mesmo sendo com você.</p>
<center><h4>--*--</h4></center>
<p>Jason e Maddie passaram a tarde toda no computador do Brandon lendo os posts do blogueiro.
<p>- Temos que ir logo. O Vassoura de Pelo vai voltar daqui a pouco e ele não vai gostar de saber que invadimos o quarto dele. – Jason estava apressando Maddie.
<p>- Achei que ele sabia que estávamos aqui.
<p>- Bom, ele não sabe. Na verdade, ele não sabe de muita coisa que está acontecendo.
<p>- Como assim? – Maddie percebeu que Jason queria dizer alguma coisa.
<p>- Acho que eu sei o que o blogueiro quis dizer no post sobre o seu irmão. Eu não sei como ele descobriu, ele não deu muitos detalhes para não entregar tudo, mas de algum jeito ele sabe.
<p>- Não entendi. – Maddie ficou confusa.
<p>- Ontem, o Kol beijou a Lisa e levou um tapa de presente.
<p>- O quê?
<p>- É, o seu irmão não é tão santo quanto você pensa.
<p>- Cala a boca, você não conhece o meu irmão.
<p>- Eu nunca fiquei com uma garota que tinha namorado. Na verdade, uma vez eu fiquei com uma garota que queria fazer ciúme para o ex, mas isso é diferente e não vem ao caso agora.
<p>- Ele precisa de um amor. Não pode culpa-lo.
<p>- Que hipócrita, se eu tivesse feito isso, você estaria me julgando, mas como é o seu irmão... Olha, eu não me importo dele encontrar um amor. Mas como o Brandon vai ficar quando descobrir que o seu irmão beijou a namorada dele?
<p>- Eu...
<p>- Você defenderia o Brandon se a situação fosse ao contrário?
<p>- Virou o cara certinho agora?
<p>- Não, longe disso, mas como eu disse, as pessoas e você me julgam tanto e são iguais ou até piores que eu. Você me julga, mas o seu irmãozinho querido beijou uma garota comprometida. E eu vou repetir isso muitas vezes até você assumir que é errado.
<p>- Por que ainda estamos conversando? Vamos nos focar no blogueiro. Não estávamos com pressa?
<p>- A verdade dói, eu sei disso. Talvez isso faça você repensar.
<p>- Eu sempre vou defender o meu irmão. Quem me garante que a Lisa não encheu ele de esperanças?
<p>- E eu sempre vou defender a Lisa. Se ela pedir para ele se afastar e ele não escutar, eu vou precisar ter uma conversinha com ele.
<p>- Isso é uma ameaça?
<p>- Não. Vamos nos focar no blogueiro. – Jason ficou sério.</p>
<center><h4>--*--</h4></center>
<p>- Oi.
<p>- Oi.
<p>Lisa se encontrou com a Emily na lanchonete perto de casa.
<p>- Antes que estranhe e pergunte como eu te liguei, eu falo logo, roubei seu número no celular do Jason.
<p>- Eu imaginei isso. Não a parte do roubo, mas... – Emily estava curiosa. – O que foi?
<p>- Eu queria conversar com alguém. Eu geralmente converso com o Jason, mas tem coisas que ele não entende. E eu não tenho muitas amigas por aqui. – Lisa se endireitou na cadeira. – Na verdade, eu nem tenho amigas. Eu não converso muito com a Temperance e... Eu posso falar com você?
<p>- É claro. Na verdade, eu também não tenho muitas amigas então te entendo.
<p>- O Kol me beijou e eu estou me sentindo culpada.
<p>- Você contou para o Brandon?
<p>- Ainda não, eu acho que tenho que contar, mas eu tenho medo do que ele vai achar e...
<p>- O que você sente pelo Brandon?
<p>- Eu o amo.
<p>- O que você sentiu com o beijo do Kol?
<p>- Nada. Foi tão inesperado. Algo na minha cabeça me diz que eu deveria ter adivinhado e que eu incentivei ele a fazer isso, por isso está vindo a culpa.
<p>- Primeiro, eu acho que deveria contar ao Brandon e explicar. Se ele te ama, ele vai confiar e acreditar em você. Se você esconder isso dele e ele descobrir por outra pessoa vai ser pior.
<p>- Eu sei. Eu só não quero estragar tudo. O Kol deve me odiar agora.
<p>- Você tem que parar de pensar no Kol. Ele errou, você precisa se afastar e esquecer.
<p>- Ele já perdeu uma namorada e...
<p>- Lisa, pare de pensar nos outros. Eu sei que pode parecer egoísta, mas às vezes, você precisa se concentrar em você. Ele não pensou em você quando te beijou.
<p>- Eu sou uma idiota.
<p>- Ótimo, admitir é o primeiro passo.
<p>As duas começaram a rir.
<p>- Agora vamos comer. Eu estou morrendo de fome. – Emily já estava olhando para todo lado procurando um garçom.
<p>- Ótimo, depois falamos de como está com o Jason.
<p>- Essa não.</p>
<center><h4>--*--</h4></center>
<p>- Eu fiz os exercícios, tá bom?
<p>Jason se encontrou com Emily no parque naquela noite. Ele estava com o seu caderno aberto na folha dos exercícios e entregou a ela logo que se sentou no banco.
<p>- Que bom.
<p>- Mas eu tenho que admitir que eu tentei encontrar as respostas na internet, quase convenci a Lisa e a Tempe a fazer eles para mim, porque eu estava ficando louco.
<p>- Mas você fez sozinho. Você fez sozinho, não é?
<p>- Fiz. E quando eu me concentrei, eu percebi que nem era tão difícil. Eu tive aula disso e estava guardado em algum lugar no meu cérebro. Aí eu me empolguei e terminei os meus cálculos de matemática também que estavam atrasados.
<p>- É sério? – Emily ficou chocada.
<p>- Muito sério. Olha só o que você faz comigo. – Jason sorriu.
<p>- Eu estou orgulhosa. Merece até um beijo.
<p>- Você sabia que durante o beijo, você movimenta vinte e nove músculos, e dezessete deles são na língua?
<p>- Não. – Emily ficou impressionada.
<p>- E você sabia que os batimentos cardíacos aceleram, fazendo uma espécie de exercício para o coração enquanto a gente beija? E que um beijo muito bom, tipo o meu, gasta em média doze calorias?
<p>- Estudou biologia também? Desde quando ficou tão aplicado nos estudos?
<p>- Desde que você disse que gosta de caras inteligentes. Estou tentando deixar verdadeiras as mentiras que eu coloquei no meu currículo.
<p>- Isso foi incrível.
<p>- Eu sou um fofo, eu sei. – Jason sorriu.
<p>Então Jason a beijou.
<p>A noite estava linda, calma. Não havia ninguém naquele parque a não ser os dois. Jason e Emily não pretendiam sair dali tão cedo. Um sair de perto do outro naquele momento estava fora de cogitação.</p>
</body></html>";
            }

            if (numero == 18)
            {
                lblTitulo.Text = "Capítulo 18 - Briga";
                htmlPage.Html = @"<html><body>
<p>Jason e Maddie tinham passado a tarde toda na biblioteca da escola.
<p>Ele havia conseguido copiar todos os posts do blogueiro do computador do Brandon para um pen-drive e agora eles estavam lendo um por um tentando não perder nenhum detalhe sem a preocupação de Brandon interromper os dois no quarto dele.
<p>- Pelas dicas, eu tenho certeza que o blogueiro é a Rosana.
<p>- Quem é Rosana? – Jason não entendia nada que Maddie falava.
<p>- Rosana é a minha parceira no laboratório de Química. – Maddie explicou.
<p>- Nunca ouvi falar.
<p>- Já deve ter ficado com ela. – Maddie falou como se Jason se lembrasse de todos os nomes das garotas com quem ficou.
<p>- Ela é uma garota, então provavelmente sim. – Jason concordou. – Mas por que acha que é ela?
<p>- O modo como o blogueiro escreve. Ela escreve igualzinho.
<p>- O blogueiro escreve de um jeito normal, o mesmo jeito que todo adolescente escreve. Qualquer um nessa escola pode ser o blogueiro. Até eu ou você.
<p>- Você acha? – Maddie ainda não estava convencida.
<p>- Já lemos isso um milhão de vezes, não vamos encontrar pistas aqui. – Jason já estava ficando impaciente.
<p>- Talvez a gente precise se concentrar em quem ele falou.
<p>- Ele falou de todo mundo, tá bom? Não tem nenhuma exceção. – Jason reclamou sendo pessimista.
<p>- Qual é a sua próxima ideia?
<p>- Roubar todos os celulares da escola.
<p>- Uma ideia que funcione, por favor. – Maddie olhou com cara de reprovação.
<p>- Ele me vigia. De algum modo, ele consegue ouvir as minhas conversas, podemos começar por aí.
<p>- O blogueiro é alguém próximo a você.
<p>- Olha, no começo eu achava que sim, mas depois eu pensei melhor.
<p>- Como assim?
<p>- Eu já fiquei com uma garota no banheiro feminino, ela poderia muito bem ter colocado uma escuta na minha roupa, até na minha cueca.
<p>- Que nojo.
<p>- Já fiquei com uma garota na arquibancada do ginásio, nada impediria ela de colocar uma escuta no meu bolso. Ah, eu já fiquei com uma garota que...
<p>- O quê? Vai dizer que ela poderia ter colocado uma escuta no seu cabelo? – Maddie revirou os olhos.
<p>- Não, eu só ia dizer que ela beijava bem. – Jason sorriu, mas Maddie não gostou da piada.
<p>- Não teve graça.
<p>- Acho que você só vê graça quando uma galinha bota ovo.
<p>- Que saco, eu não acredito que eu estou fazendo isso com você.
<p>- Reclame menos, tá bom? Já basta eu.
<p>- Olha, eu vou te dizer uma coisa...
<p>Mas Jason não estava mais prestando atenção. Seus olhos estavam de novo na tela do computador lendo os posts do blogueiro.</p>
<center><h4>--*--</h4></center>
<p>Já era de manhã e Jason, como sempre, estava atrasado. Lisa tinha ido para escola mais cedo, ela queria evitar a continuação da conversa que os dois não terminaram na noite passada.
<p>- Você precisa contar para o Cabelo de Pelúcia que o Kol te beijou. – Jason insistia.
<p>- E se ele ficar bravo? E se ele terminar comigo?
<p>- Tá, você não vai ter mais seu fornecedor de cabelo para fazer perucas naturais, mas e daí? Vai mentir para ele o resto da vida?
<p>- Nesses momentos eu preciso do Jason mentiroso e irresponsável.
<p> Nesses momentos eu preciso da Lisa que pensa com a cabeça e que não tem medo das consequências. – Jason rebatia sempre qualquer argumento.
<p>Bom, isso não adiantou de nada. Lisa ainda não tinha decidido contar para Brandon sobre o episódio com o Kol e Jason nem sabia se ela um dia ia decidir contar. Ela estava certa? Errada? Bom, Jason costumava tentar entender o lado da amiga, então resolveu ficar de fora dos problemas dela, mesmo não concordando.
<p>Ele olhou no relógio e viu que estava mais atrasado do que de costume (droga de cabelo arrepiado!). Sem mesmo terminar de tomar o café da manhã, Jason enfiou uma torrada na boca, colocou a mochila nas costas e saiu correndo. Ele tinha que fazer uma coisa antes de ir para a escola.
<p>- Oi.
<p>- O que faz aqui?
<p>Emily ficou surpresa quando estava saindo de casa e deu de cara com Jason a esperando encostado em uma das árvores que ficava de frente à sua casa.
<p>- A gente marcou de se encontrar? Eu não me lembro. – Emily estava confusa.
<p>- Eu quis fazer uma surpresa. – Jason sorriu.
<p>- Eu odeio surpresas. – Emily foi até ele e o beijou.
<p>- E eu adoro seus beijos. – Jason fez a cara mais boba que ele conseguiu no momento.
<p>- Idiota.
<p>- Eu vim te buscar para irmos para a escola juntos.
<p>- Mas isso vai parecer para todo mundo que estamos sérios.
<p>Jason sabia exatamente o que Emily queria ouvir com esse comentário.
<p>- Gata, nós estamos sérios. – Jason riu.
<p>- Não me chame de “gata” também. – Emily riu junto.
<p>- Fofa? – Jason deu a ideia.
<p>- Não.
<p>- Querida?
<p>- Muito falso.
<p>- Bebê?
<p>- Muito... dengoso. – Emily fez cara de quem iria vomitar só em pensar que poderia ser chamada de “bebê”.
<p>- Linda?
<p>- Não.
<p>- Olha só, Ems, assim fica difícil.
<p>- Mas eu sou difícil, GATO. – Ela brincou.
<p>- Eu gostei de “gato”, mas prefiro “lindão”.
<p>- Cala essa boca.</p>
<center><h4>--*--</h4></center>
<p>- E você está fazendo isso com a Maddie porque...
<p>- Porque eu quero descobrir quem é o blogueiro e parece que a Maddie é a única que está focada nisso também.
<p>Jason e Temperance estavam indo para a sala para assistirem uma aula de literatura que Jason fazia questão de dizer a cada dez minutos que odiava.
<p>- Achei que se odiassem.
<p>- Não, só eu odeio ela. Ela tenta conseguir a minha amizade. – Ele ficou presunçoso.
<p>Temperance não concordava nem entendia Jason e Maddie trabalhando juntos nem tendo algo em comum, isso era muito estranho para ela imaginar.
<p>- Já pensou o que vão fazer quando descobrirem quem é o blogueiro?
<p>- Bom, eu vou dar uns socos nele, aí eu deixo o resto para a Maddie decidir o que vai fazer, já vou ficar feliz com os socos.
<p>- E quais são as pistas que vocês têm até agora?
<p>- Nenhuma. – Jason fez cara de triste. – E eu já estou cansando de passar o tempo com aquela garota. Passa o dia todo falando do Kol, ou das vacas, ou “como a minha fazenda é incrível.”.
<p>- Pena de você. – Temperance riu. – Mas ela não é tão ruim, até que gosto dela.
<p>- Se case com ela então, vai que rola, já que com o Nathan não está rolando.
<p>- Mas com o Nathan vai rolar.
<p>- Um pouco antes da formatura?
<p>- Não enche. E quando pretendem descobrir quem é o blogueiro? Depois da formatura?
<p>- Eu vou ignorar o que você disse agora.
<p>- Olha, eu não quero te desanimar mais do que você já está, mas ainda acho que descobrir a identidade desse cara é algo impossível.
<p>- Voar é impossível. Isso no máximo é um pouco difícil.
<p>- Boa sorte então.
<p>- Se você tivesse aceitado me ajudar a descobrir quem era o blogueiro, eu não teria que sacrificar o meu tempo com a Maddie, então eu vou sim precisar de muita “boa sorte”.
<p>- Que exagero. Não faz drama.
<p>- Não faz drama? – Jason imitou Temperance. – Você não me conhece mesmo, não é? – Ele riu.</p>
<center><h4>--*--</h4></center>
<p>- Lisa!
<p>Brandon correu atrás de Lisa no corredor da escola. Parecia que ela não estava escutando ele gritando o nome dela.
<p>- Querido, oi. – Lisa sorriu quando viu Brandon.
<p>- O que aconteceu? Você parece que está me evitando.
<p>- Do que está falando? Claro que não. – Ela tentou disfarçar.
<p>- Sério? Você não fala comigo desde ontem. – Brandon sabia quando Lisa mentia.
<p>- Eu estou com muita coisa para fazer. Não foi por mal.
<p>- Eu sei que não foi. – Brandon a beijou. – Mas pode falar comigo que eu te ajudo a fazer essas coisas. Namorado é para isso.
<p>- Eu sei, e é por isso que eu te amo.
<p>- Eu também te amo. Para onde está indo agora?
<p>- Estou indo para o laboratório agora para a minha aula de química. – Lisa sorriu desanimada.
<p>- Que tal isso? A gente pode matar essa aula, podemos passear, passar um tempo juntos. – Brandon pegou na mão dela.
<p>- Eu ia adorar, mas eu não posso faltar nessa aula, eu tenho uma atividade que...
<p>- Está me enrolando.
<p>- Eu não estou, eu juro. Podemos deixar isso para outro dia?
<p>- Tudo bem então. A gente se vê no almoço?
<p>- Claro.
<p>Lisa soltou sua mão de Brandon e se afastou antes mesmo de se despedir.<p>
<center><h4>--*--</h4></center>
<p>- Você vai passar outra tarde inteira na biblioteca com a Maddie de novo?
<p>Emily não gostou que Jason cancelou seus planos com ela para aquela tarde. Os dois estavam almoçando juntos.
<p>- Contra a minha vontade. Sabe que eu preferia ficar com você.
<p>- Sei. – Emily fingiu não acreditar. – Já estou começando a duvidar disso.
<p>- Não fale isso nem de brincadeira. – Jason fez cara de assustado. – Olha, eu prometo que isso vai acabar logo. Nós estamos quase conseguindo.
<p>- Mentira, vocês não conseguiram nada até agora.
<p>- Verdade. – Jason concordou com a namorada. – E está até me assustando ter que passar mais tempo com ela do que com você, mas isso pode mudar. Podemos sair à noite. O que você acha?
<p>- Olha...
<p>- Ou... – Jason não deixou Emily falar. – Podemos ficar em casa mesmo. A gente assiste alguma coisa, depois podemos ir para o quarto, sei lá. – Jason falou como se não quisesse nada demais.
<p>- Você está tentando me levar para a cama?
<p>- Para o quarto tecnicamente. Onde também tem uma cama.
<p>Emily deu um tapa na cara de Jason.
<p>- Ai! – Ele riu.
<p>- Eu não sou fácil, tá bom?
<p>- Mas eu sou, então se você quiser me levar para a cama, é só pedir. – Jason brincou.
<p>- Quer levar outro tapa?
<p>- Não.
<p>- Ótimo. Então podemos voltar a falar sério?
<p>- Eu nunca deixei de falar sério.
<p>- Tudo bem. – Emily ignorou a piada. – Agora correndo o risco de ser acusada de ser o blogueiro de novo, eu vou dizer uma coisa.
<p>- O quê?
<p>- Não acha que devia deixar para lá? Você finalmente está livre. O blogueiro nem está falando mais sobre você.
<p>- Talvez eu esteja livre e ele não venha me atacar de novo. Mas e quanto às outras pessoas? Elas não estão livres. Ele vai atacar essas pessoas como me atacou.
<p>- Quer dizer que você não é tão egoísta assim. – Emily ficou orgulhosa.
<p>- Óbvio, além do mais, quando eu desmascarar o blogueiro, todo mundo vai me agradecer e me venerar. Eu vou ser o rei da escola.
<p>- Retiro o que eu disse.
<p>Jason riu.</p>
<center><h4>--*--</h4></center>
<p>- O que você está fazendo? – Jason estava vendo Maddie apertar todas as teclas do teclado do computador compulsivamente.
<p>- Eu estou atualizando a página do blogueiro para ver o que ele vai postar.
<p>- Quando ele postar algo, você vai saber. – Jason se virou para o celular, uma mensagem de texto tinha chegado.
<p><i>“Ainda está aí com a Maddie?”</i> Emiily escreveu.
<p>- Ele esfriou um pouco. Não postou mais nada. – Maddie estava quase falando sozinha, Jason não estava prestando atenção sentado do seu lado.
<p><i>“Estou sim, por quê?”</i> Jason respondeu Emily.
<p>- Quero descobrir quem ele é mais que tudo nessa vida.
<p>- É. – Jason resolveu fazer algum barulho para dizer que estava ouvindo o que Maddie falava.
<p><i>“Está tão calor aqui.”</i> Jason riu ao ler a mensagem de Emily.
<p>- Do que está rindo? – Maddie não entendeu.
<p>- Nada, só estou pensando alto.
<p><i>“Você está em casa, tire a roupa e fique confortável, tire uma foto e me mande depois, quero ver se é melhor que a minha imaginação.”.</i>
<p>- Eu estou muita cansada disso tudo. Meu irmão está muito mal.
<p>- É, eu também. – Jason não estava escutando.
<p><i>“Lógico... que não, se contente com a sua imaginação por enquanto.”.</i>
<p><i>“Minha imaginação pode ser muito fértil.”. </i>Jason imaginou Emily rindo ao ler isso.
<p>- O Kol só quer viver na dele. Agora o blogueiro está entrando na sua zona de conforto e ele não vai saber lidar com isso. E eu não sei o que fazer. – Se Jason estivesse escutando, ele estaria mandando Maddie calar a boca e limpar as lágrimas.
<p><i>“Você precisa de um banho de água gelada.”.</i>
<p>- Não sei porque ele resolveu se apaixonar pela Lisa. Ele sabia que ia dar rolo. Coitado.
<p><i>“Contanto que você vá comigo, eu vou tomar banho com muito prazer.”.</i>
<p><i>“Olha só quem vai levar uns tapas quando me encontrar.”.</i>
<p><i>“Prefiro arranhões, se é que me entende.”.</i>
<p>- Eu me sinto inútil por não poder ajuda-lo, acho que por isso eu estou assim, tão obcecada com o blogueiro. Acho que desse jeito, eu estou pelo menos tentando fazer alguma coisa.
<p><i>“A Maddie está te deixando muito animadinho, hein?”</i>
<p>- Eu sei que você me entende. – Maddie limpou as lágrimas.
<p><i>“É, eu estou bem animado, mas não é por causa dela. Eu ainda estou imaginando você com calor e sem roupa.”.</i>
<p>Jason achou estranho quando olhou para Maddie e ela estava chorando.
<p>- É, é horrível. – Ele resolveu então falar para não dar tanto na cara que ele não estava prestando atenção no drama de Maddie.
<p>- Você nem prestou atenção no que eu disse. – Maddie limpou as lágrimas brava.
<p>- O que eu perdi? Seu drama com a preocupação com o Kol e blábláblá? Eu já ouvi isso várias vezes. Você já percebeu que seu irmão não tem dez anos? Quando o blogueiro falava de mim, eu merecia, mas agora que é com o seu irmão, ele é o vilão? O Kol beijou uma garota comprometida.
<p>- Então a Lisa é a vítima?
<p>- Boiadeira, não tem nenhuma vítima aqui. Acorda.
<p>Maddie ficou em silêncio depois disso e continuou teclando sem parar.</p>
<center><h4>--*--</h4></center>
<p>- Podemos conversar?
<p>Maddie parou na frente de Lisa enquanto ela andava pelo pátio em direção ao portão de saída. Ela tinha enrolado um pouco dentro da escola na esperança de não encontrar Brandon na hora da saída.
<p>- Claro, mas pode ser depois? Agora eu estou com um pouco de pressa e...
<p>- Tem que ser agora. – Maddie não saiu da frente de Lisa.
<p>- Pode ser rápido então?
<p>- Vai ser rápido, não quero ficar muito tempo perto de você. – Maddie estava séria. Lisa nunca tinha visto ela assim.
<p>- O quê? Como assim?
<p>- Eu não quero ficar muito tempo perto de você. Vai que ser vadia é contagioso.
<p>- Do que está falando?
<p>- Você seduziu o meu irmão e depois pulou fora como se não quisesse nada.
<p>- Olha, você está muito enganada, eu...
<p>- Não fez nada? Foi a vítima de tudo isso? Menos, Lisa, bem menos. – Maddie cruzou os braços.
<p>- Tudo bem, você não pode chegar aqui, botar a banca toda e achar que pode falar assim comigo. – Lisa não estava gostando do rumo dessa conversa.
<p>- Gente como você só entende um tipo de conversa.
<p>- Gente como eu? – Lisa riu. – Eu não sei o que você ouviu, mas eu não tenho nada a ver com isso. Eu estava tentando ser gentil e uma amiga. Você queria que eu fizesse isso, que eu fosse amiga do seu irmão porque ele andava solitário. Isso foi tudo o que eu fiz.
<p>- Só porque você brinca de casinha com o Jason, não quer dizer que você pode se insinuar para todo mundo.
<p>- Escuta aqui...
<p>- Não, escuta aqui você. Quero você longe do meu irmão. A última coisa que ele precisa é de uma patricinha fazendo ele de gato e sapato. – Maddie apontou o dedo na cara de Lisa.
<p>- Você está perdendo a noção. Não sabe do que está dizendo. Dias atrás, você estava toda sorridente e me agradecendo por eu ser legal com o seu irmão. – Lisa estava confusa.
<p>- Não sabe o quanto eu me arrependo. Se eu soubesse, tinha cortado o mal pela raiz e já tinha acabado com a sua raça.
<p>- Eu não quero brigar com você, nem descer ao seu nível. Eu vou mesmo me afastar do Kol, você não precisa vir me pedir.
<p>- O Brandon já sabe o que você fez? – Maddie ameaçou.
<p>- Deixa o Brandon fora disso.
<p>- Blogueiro! – Maddie começou a gritar no meio do pátio. – Eu sei que você está por aí e pode me escutar! Espalhe a notícia que a Lisa é uma vagabunda sem graça que quer todos aos seus pés!
<p>- Cale a boca. – Lisa deu um tapa na cara de Maddie. Ela não queria chegar a isso. Se arrependeu assim que fez.
<p>- Você já chegou com o Jason e com a desculpa de que são só amigos, depois conquistou o Bran, e não sendo o suficiente, seduziu o Kol! Como consegue dividir a cama com os três? Sua vadia!
<p>- Cala essa boca!
<p>Lisa teria pulado em cima de Maddie, ela até se assustou com a sua reação, mas Jason chegou bem na hora para impedir que as duas saíssem no tapa.
<p>- Me solta, Jason, eu vou acabar com ela!
<p>Lisa estava tremendo de raiva enquanto Jason a segurava com muita força.
<p>- Lisa, se acalma. – Jason falou baixinho para Lisa.
<p>- Solta ela, Jason. Deixa ela perder a pose de garotinha. – Maddie também estava tremendo de raiva.
<p>- Maddie, sai daqui. – Jason falou sério.
<p>- O quê? Vai defender ela? Depois de tudo o que ela fez? Ela está te usando também. Eu preciso...
<p>- Me desculpa, eu não quero sua proteção, Super-Galinheira. Sai daqui. – Jason continuava segurando Lisa.
<p>- Então vão se danar.
<p>Maddie foi embora furiosa.
<p>- Eu não acredito que isso aconteceu. – Lisa desabou. Jason sentiu que ainda não era hora de soltá-la e a abraçou mais forte.
<p>- Vai dar tudo certo. O Brandon vai entender.
<p>- E se ele não entender? – Lisa continuava a chorar.
<p>- Aí eu vou lá e acabo com ele, porque amigos fazem isso, pelo menos eu faço.</p>
<center><h4>--*--</h4></center>
<p>Era a primeira aula do dia. Brandon ficou na porta da sala até ver Kol entrando, depois disso foi se sentar ao seu lado.
<p>- Oi, Kol.
<p>- Bran, oi. Tudo bem? – Kol deu um sorriso por educação.
<p>- Tudo ótimo. E você? – Brandon foi educado. Ele não queria mesmo saber como o Kol estava.
<p>- Também. A gente não conversa faz um tempo.
<p>- É verdade, parece que você prefere a companhia da minha namorada. – Brandon deu um sorriso falso.
<p>- Como assim? – Kol se fez de desentendido.
<p>- Bom... – Brandon se aproximou mais de Kol e falou mais baixo. – Da próxima vez que querer beijar a minha namorada, pense em um lugar mais escondido do que um parque.
<p>- Olha, Brandon, me desculpa, eu...
<p>- Fica longe dela, eu não vou ser tão legal se tiver que falar de novo com você.
<p>- Bran...
<p>- Fica longe, está escutando?
<p>Brandon se levantou e se sentou do outro lado da sala. Aquela raiva que ele geralmente sentia estava começando a se apossar dele de novo e aquilo deixava ele louco. Por que o Kol fez aquilo? Por que a Lisa não contou para ele? Por um momento ele sentiu vontade de pular em cima de Kol e arrancar os dentes dele. Ele apertou a caneta bem forte, seus dedos ficaram brancos de tanta força que ele estava usando, então respirou fundo e tentou se concentrar. Kol teria o que ele merecia mais tarde.</p>
<center><h4>--*--</h4></center>
<p>- Temperance, eu posso me sentar aqui? – Maddie encontrou Temperance na biblioteca e resolveu ir até ela para conversar.
<p>- Na verdade, eu estou esperando o Nate.
<p>- Vai ser rapidinho. Eu tenho uma grande novidade.
<p>- O que foi? – Temperance não estava tão animada como Maddie.
<p>- Eu descobri quem é o blogueiro. – Ela se sentou ao lado da garota.
<p>- O quê? – Temperance se assustou com a informação. – O Jason também...
<p>- Não, não estamos mais juntos nisso. Ele resolveu ficar do lado da Lisa. – Maddie parecia uma mulher despeitada.
<p>- O que a Lisa tem a ver com isso?
<p>- Nada. Só que eu não gostei que ele ficou do lado dela mesmo ela sendo a errada da história toda, então resolvi continuar sozinha.
<p>- São melhores amigos, é claro que ele ficaria do lado dela seja lá o que aconteceu.
<p>- Não o defenda também.
<p>- Olha, Maddie, o que você quer? O blogueiro não me interessa.
<p>- Você não entende? Descobrindo quem é o blogueiro, podemos fazer tudo o que queremos. – Os olhos de Maddie brilhavam.
<p>- Eu não entendi onde quer chegar nem porque quer compartilhar isso comigo.
<p>- Eu percebi, tá bom? – Maddie fez uma cara de dó.
<p>- Percebeu o quê?
<p>- Que depois que o Bran e a Lisa começaram a namorar, você meio que ficou de lado.
<p>- Isso não é verdade, acontece que eles namoram, é normal passarem mais tempo juntos.
<p>- Com a ajuda do blogueiro, eu posso me vingar e você pode ter o seu melhor amigo de volta. Você ganha até o Jason de presente se a gente fazer direito.
<p>- Pare de rodeios. Diga logo o que está fazendo.
<p>- Eu vou me juntar ao blogueiro e destruir a Lisa. – Maddie parecia ter esse plano há muito tempo.
<p>- O quê? Isso é insano. O que ela fez para você?
<p>- Magoou o meu irmão.
<p>- Sabe que o Kol não é nenhum bebê de coração partido, não é? Ele não é tão frágil assim e inocente.
<p>- Está comigo ou não? Eu sei que não gosta da Lisa então nem me vem com o seu discurso de amiguinhas.
<p>- Eu não sou a melhor amiga da Lisa, isso é um fato. – Temperance estava séria. – Mas também não sou sua amiga, somos colegas, até menos. Eu não vou me meter nessa sua cruzada estranha contra ela. Me deixa fora disso.
<p>- Eu devia mesmo saber que você é uma medrosa.
<p>- Todo mundo se surpreende. Eu também não sabia que você era, seja lá o que você é agora, alguém que me dá pena.
<p>Temperance assistiu uma Maddie revoltada sair da biblioteca. Ela sabia que Nathan chegaria a qualquer momento, mas enquanto esperava várias coisas começaram a passar pela sua cabeça. Maddie sabia mesmo quem era o blogueiro? E até onde ela iria para se vingar da Lisa? Temperance deveria contar isso para Jason ou era exatamente isso que Maddie esperaria que ela fizesse? Isso era loucura demais. Esse blogueiro já tinha mexido muito na vida das pessoas, mas destruir alguém que ela conhecia e até se importava, isso seria um absurdo.</p>
</body></html>";
            }

            if (numero == 19)
            {
                lblTitulo.Text = "Capítulo 19 - Amor";
                htmlPage.Html = @"<html><body>
<p>Dia dos namorados. Aquele dia em que todo mundo fica romântico e pensa em corações. Preparam surpresas românticas para os seus amores, compram presentes e se sentem forçados a mostrar o amor que sentem pelo outro.</p>
<br>
<p>Jason nunca comemorou o dia dos namorados com alguém em particular. Ele sempre teve essa ideia na cabeça de que dia dos namorados era para se passar solteiro, assim seria uma data normal como qualquer outra, nem para ser feriado essa droga prestava, ele se irritava com isso. Na verdade, ele sempre, estrategicamente, terminava seus “namoros” antes do grande dia, se é que se pode chamar as relações que ele tinha de namoros. Jason foi criado com dois pais que mal se suportavam, eram dois carros, dois quartos, nem comiam juntos, até pareciam dos solteiros que dividiam a casa.
<p>Para que casar se você vai ter uma vida mais infeliz do que já tem? Ele estava muito feliz saindo com uma garota em um dia e no outro não precisar dar satisfações porque já estava atrás de outra. Mas e agora com a Emily? Esse seria o seu primeiro dia dos namorados com uma namorada de verdade. O que ele deveria fazer? E se ele estragasse tudo por falta de experiência e tato? Será que ele estava enganado com essa história que romance é uma droga? Além do mais, ele adorava romance quando estava com Emily, na verdade, ele adorava tudo quando estava com ela.
<br>
<p>Brandon e Temperance tinham um ritual para os dias dos namorados desde que tinham doze anos. Como sabia que não arranjaria um encontro romântico para a tal data, Brandon preferia passar o dia todo assistindo filmes de terror junto com Temperance, e em hora em hora, eles começavam a se perguntar o que os casais bregas e românticos estariam fazendo, algo que faria eles querer vomitar, é claro. Mas agora estava tudo diferente. Brandon finalmente estava namorando, pelo menos era isso que todo mundo pensava, e Temperance, bem, ela estava a fim do Nathan. Seria aquela hora certa para chama-lo para sair? No dia dos namorados? É claro que não. Seria ridículo, feio, totalmente brega e sem originalidade. Mas então, Temperance? Quando seria a hora certa? Nunca, pensava ela.
<br>
<p>Lisa sempre foi apaixonada pelo dia dos namorados desde que descobriu o significado dessa data. Ela namorou um cara por dois anos. Jason até se cansava de tanto que ela falava sobre ele. “Ele é incrível, tão meigo, sensível, inteligente, cavalheiro, é o amor da minha vida, quero ficar com ele para sempre.”. Ainda era possível que Lisa se lembrasse do seu primeiro dia dos namorados com ele. Foi o melhor dia da vida dela. Ele a levou ao cinema e comprou flores, chocolates, teve aquele discurso romântico que ela tanto amava. Ele era o cara certo na época. Mas o seu mundo desabou um ano depois na mesma data. O príncipe encantado disse que queria terminar, que estava cansado daquela coisa, que estava a fim de outra pessoa. Lisa tinha preparado uma surpresa para compensar tudo o que ele fez no outro ano, mas os planos dela caíram por terra. Sua noite terminou vendo Jason não atendendo ligações de garotas enquanto comia os lanches que ela tinha feito para o piquenique perfeito com o amor da sua vida. Agora tudo estava diferente, ela tinha encontrado um outro amor, Brandon. Ela voltaria a amar aquele feriado? Talvez sim, talvez não.
<br>
<p>- Acorda!
<p>Os olhos de Jason, que ainda estavam meio entreabertos por causa da sonolência, viram uma Lisa bem agitada balançando ele para levantar da cama.
<p>- O que foi? – Jason quase sussurrou de tanta preguiça.
<p>- O que vai fazer hoje?
<p>- Eu nem acordei ainda. E o seu joelho está apertando a minha perna.
<p>Lisa nunca tinha paciência para acordar Jason, ele tinha um sono pesado. Uma vez, ela ficou gritando o nome dele por quase dez minutos, ele não moveu um músculo, ela nunca teve coragem de jogar água fria nele ou algo assim. Então ela fazia o que qualquer um fazia, pelo menos era o que ela achava. Ela subia em cima dele e começava a chacoalha-lo até ele abrir os olhos e começar a reclamar.
<p>- Então trate de acordar. Você acha que o Bran terminou comigo?
<p>- Você me acordou para falar do Cabelo de Arame de Caderno?
<p>- Ele não me atende desde ontem. Acho que ele já sabe sobre a briga com a Maddie e tudo o que ela falou.
<p>- Relaxa, ninguém vai acreditar em uma garota que fala com os animais.
<p>- Ele deve me odiar. – Jason estava imaginando a hora que Lisa resolveria chorar e deitar em cima dele.
<p>- Por quê? Você deu um tapa no Semancol.
<p>- Não adiantou de nada. Aparentemente, ninguém liga para isso.
<p>- Ignora isso. Uma hora eles esquecem.
<p>- Não quero ficar brigada com o Bran hoje.
<p>- Por que hoje seria especial? – Jason bocejou.
<p>- Porque hoje é dia dos namorados.
<p>- Ah, que ótimo, me acorde amanhã, boa noite. – Jason voltou a fechar os olhos.
<p>- Ah, não. – Lisa chacoalhou ele contra a cama. – O que combinou com a Emily para hoje?
<p>- Por que quer saber?
<p>- Porque eu não vou ter nada e quero me animar com o seu.
<p>- Não falamos sobre isso na verdade. Acho que ela nem sabia também.
<p>- Ela é uma garota. É claro que ela sabe.
<p>- Eu não quero comemorar essa droga, é tão chato. – Jason choramingou.
<p>- Você tem uma namorada, aceite isso.
<p>- Sai de cima de mim.
<p>- Me obrigue.
<p>- Olha, você é a minha melhor amiga, mas ainda sim é uma garota e você está em cima de mim.
<p>- Ai, que nojo. – Lisa saiu de cima de Jason. – Será que esse vai ser o pior dia dos namorados de novo? – Ela parecia triste.
<p>- É só um dia, daqui um ano vai ter outro. É tipo aniversário.
<p>- Você não entende.
<p>- Ainda bem.</p>
<center><h4>--*--</h4></center>
<p>- Como descobriu que o Kol beijou a Lisa? – Brandon estava contando para Temperance no café da manhã na casa dela sobre sua situação. Temperance ficou surpresa por ele já saber de tudo antes da namorada contar.
<p>- Eu vi. Eu estava passando pelo parque, estava na hora certa no lugar certo, eu acho. – Ele falou sem emoção.
<p>- Vai me dizer que não estava espionando? – Temperance estava desconfiada.
<p>- Não, eu juro que não. Eu não acredito que isso aconteceu e pior, ela nem se importou em me contar, agora ela só me evita ou conversa estranho comigo.
<p>- Talvez ela esteja com medo de você reagir mal.
<p>- Ou significou alguma coisa. – Brandon parecia ver que o término do seu namoro estava próximo.
<p>- Vocês precisam conversar.
<p>- Não hoje. Hoje é o dia dos nossos filmes.
<p>- Não vai ter filme hoje. Só fazemos isso porque éramos solteiros, mas agora você tem uma namorada.
<p>- Eu nem sei mais se eu tenho.
<p>- Ela está esperando que você diga algo, Bran. Parem de fugir um do outro. É muita criancice.
<p>- Você deveria me apoiar, não me criticar.
<p>- Então para de fazer besteira que eu te apoio.</p>
<center><h4>--*--</h4></center>
<p>- Oi.
<p>Emily foi surpreendida quando Jason chegou e se sentou ao seu lado na aula de Biologia após roubar um beijo dela.
<p>- Oi. – Ela sorriu.
<p>- O que está fazendo? – Jason viu que Emily estava lendo algumas anotações.
<p>- É que eu tenho que apresentar um trabalho na próxima aula e eu estou dando uma revisada.
<p>- É só falar qualquer coisa e tirar um C. Os professores dão essa nota só pela sua coragem de se levantar e falar. – Jason não dava muita importância para isso.
<p>- Não. – Ela olhou de cara feia.
<p>- Tudo bem. – Ele riu. Sabia que ela ia falar isso. – O que você quer fazer hoje à tarde?
<p>- Por quê? – Emily não entendeu a pergunta.
<p>- Ah, por nada. Passamos todas as tardes juntos então eu estou perguntando o que você quer fazer hoje. Afinal hoje é uma tarde comum como todas as outras.
<p>- Tudo bem, eu já entendi. – Emily parou aquela explicação toda. – Não precisamos fazer nada demais. Eu nem gosto do dia dos namorados.
<p>- É sério? – Jason ficou surpreso. – Porque a gente combinou de aprender essas coisas de namorados juntos e eu não faço ideia do que os casais fazem nesse dia.
<p>- Fazem besteiras. Isso tudo é só uma data idiota para forçar todo mundo a ser romântico por um dia. Como se demonstrar amor fosse só para o dia dos namorados.
<p>- É exatamente isso que eu penso. – Jason estava impressionado. – Somos mesmo almas gêmeas.
<p>- Se você está dizendo. – Ela riu.
<p>- Perfeito. Eu não tinha mesmo pensado em nada. – Mas de repente o sorriso de Jason saiu do seu rosto bem rápido. – Isso é um teste?
<p>- Jason, não. Eu não vivo só para testar você. Eu estou bem, é sério.
<p>- Tem certeza? – Jason ainda estava desconfiado.
<p>- Tenho.
<p>- Tudo bem, então.
<p>Mas talvez por culpa ou até por vontade de comemorar a data com a namorada, Jason não sentiu que estava tudo perfeito. Aquilo não parecia certo.
<p>- Olha, talvez a gente devesse comemorar.
<p>- O quê? – Emily não esperava por isso.
<p>- Quer dizer, somos namorados. Deveríamos comemorar.
<p>- Se você quiser.
<p>- Só se você quiser.
<p>- Eu já disse que não quero.
<p>- Quando começamos a namorar, falamos que iriamos aprender a ser namorados melhores. Parece a coisa certa a fazer. Namorados fazem isso.
<p>- Tudo bem então. – Emily achou melhor não discutir. – O que tem em mente?
<p>- Como eu disse, nada, mas relaxa, eu penso em alguma coisa.
<p>- Só me mantenha atualizada. – Emily não tentou fingir que estava empolgada. – Ai, droga. – Emily se levantou.
<p>- O que foi?
<p>- Esqueci o meu livro no armário. Eu vou lá buscar antes de começar a aula.
<p>- Não quer que eu vá junto? – Jason se levantou também.
<p>- Não, não precisa. Não nascemos grudados.
<p>- Você destrói o meu romantismo, sabia?
<p>- Não enche. – Ela riu.
<p>- Tudo bem. – Ele voltou a se sentar.
<p>- Eu já volto. – Emily beijou Jason de leve como se fosse por hábito. – Te amo. – E saiu da sala correndo para buscar o livro.
<p>- Que? – Jason tentou entender o que ouviu. Não podia ser o que ele achava que era.</p>
<center><h4>--*--</h4></center>
<p>- Eu não entendi muito bem, mas ele não quer falar com a Lisa agora. – Temperance deu de ombros.
<p>- Namorados comemoram o dia dos namorados juntos. Pelo menos eu acho. Pelo menos é o que eu vou fazer, eu acho. – Jason estava pensativo.
<p>Jason e Temperance estavam almoçando juntos.
<p>- Ele está magoado. – Ela defendeu Brandon.
<p>- A culpa não foi da Lisa. – Ele defendeu Lisa.
<p>- Eu não estou falando que foi, só acho que ela devia ter contado.
<p>- Ela estava com medo, mas eu também disse para ela contar.
<p>- Olha, eu não quero ser mais uma inimiga da Lisa, tá bom?
<p>- Como assim, mais uma? – Jason não entendeu.
<p>- É que a Maddie... ah, deixa para lá.
<p>- O que você vai fazer hoje? – Jason perguntou.
<p>- Nada.
<p>- Achei que fosse sair com o Nathan.
<p>- Não posso chamar o Nathan para sair no dia dos namorados.
<p>- Não pode hoje nem nunca, não é? – Jason revirou os olhos. – Minha filha, você não pode ficar esperando para o resto da vida, nem ser aquela garota sem graça que só vai tomar atitude quando ele já estiver com outra.
<p>- Por que eu tenho que fazer tudo? Por que ele não me chama para sair?
<p>- Feminismo, poder feminino, sei lá e porque ele é um otário. Eu vou te contar uma história muito interessante, às vezes quando você se apaixona por um otário, você tem que fazer tudo sozinha, é, a vida não é justa, lide com isso. – Jason sorriu.
<p>- Sem graça. E o que você vai fazer hoje? Algo romântico?
<p>- Não, por que disse isso? – Ele se assustou.
<p>- Hoje é dia dos namorados e você está com a Emily... acorda!
<p>- Vamos terminar com ela até o fim do dia. – Jason piscou para Temperance.
<p>- O quê? – Ela parecia chocada.
<p>- É a melhor coisa que a gente pode fazer. A gente nem se ama nem nada. – Jason riu sem graça.
<p>- O quê?
<p>- A gente não se ama. – Jason repetiu com mais força.
<p>- Você está bem?
<p>- Estou ótimo.
<p>- Jason...
<p>- Eu já disse que estou ótimo.
<p>- Se você está falando, eu acredito. – Temperance achou tudo muito estranho, mas resolveu ficar quieta e não brigar com o amigo.</p>
<center><h4>--*--</h4></center>
<p>- Esse livro é interessante, eu já li. – Jason se sentou na mesa de Nathan na biblioteca. Ele estava lendo um livro de umas mil páginas, pelo que Jason percebeu.
<p>- Sério? Não me conte o final.
<p>- Eu nem poderia. Quando eu estava no final, eu já tinha esquecido o começo. – Jason começou a rir. – Então eu nem me lembro do final agora.
<p>- Você não leu, não é verdade? – Nathan perdeu a animação.
<p>- É claro que não. Eu tenho uma vida.
<p>- Ler também é vida.
<p>- Se você está dizendo. Olha, vamos falar de homem para homem agora. – Jason pegou o livro da mão de Nathan e o fechou.
<p>- Eu vou perder a página... – Nathan resmungou.
<p>- Depois você acha, pode ficar tranquilo. Todas têm palavras. Se você gosta tanto de ler, não vai ligar de ler tudo desde o começo.
<p>- O que você quer? – Nathan cruzou os braços e ficou sério.
<p>- Quero que tire os olhos do seu livro e acorde para a vida. Eu não acredito que eu precisei chegar aqui para dizer isso para você.
<p>- Do que está falando? – Nathan parecia perdido.
<p>- Você é gay?
<p>- Não.
<p>- Tudo bem se você for, não vou te julgar.
<p>- Eu não sou.
<p>- Então por que ainda não pegou a Temperance?
<p>- Pegar? – Nathan não entendia nada do que Jason falava.
<p>- Você é de onde? Júpiter?
<p>- Não dá para se viver em Júpiter. É um planeta gasoso. – Nathan riu, achou que era uma piada.
<p>- Nossa, que coisa mais desinteressante. – Jason coçou a cabeça. – Do que adianta tirar 10 em ciências e 0 na vida?
<p>- Não tiro 0 na vida.
<p>- A Temperance está a fim de você. – Jason quase gritou. Ainda bem que a biblioteca estava vazia.
<p>- O quê? É sério?
<p>- Ah, cara, fala sério. Ela só falta gemer quando você está perto.
<p>- Está exagerando.
<p>- Talvez, mas ela gosta de você. Deve ser a sua inteligência ou qualquer coisa. Porque eu estou falando com você por dois minutos e já estou querendo me matar.
<p>- Somos diferentes. – Nathan continuava sério.
<p>- Agradeço a Deus por isso.
<p>- O quê?
<p>- E aí, vai ficar com a Temperance ou não? Se quiser, eu te dou até camisinha se você tiver vergonha de comprar.
<p>- Como assim?
<p>- Ah, não, não vamos ter essa conversa, tá bom? Temos limites. Isso o seu pai te ensina ou você procura na internet como todo mundo.
<p>- Eu não posso chamar a Temperance para sair. Somos amigos.
<p>- E daí? Não gosta dela?
<p>- Não é essa a questão. – Nathan ficou relutante. – Ela é muito legal. Não quero perder a amizade.
<p>- Então você prefere ficar no quarto brincando sozinho, é isso?
<p>- O quê?
<p>- Quantos anos você tem, garoto? Dez?
<p>- Não fala assim comigo.
<p>- Cara, eu vou ser bem direto. Se você gosta da garota, fique com ela, simples assim. Só é complicado se você complica. E a amizade... tem várias por aí.
<p>- Por que está fazendo isso?
<p>- Porque a Tempe é minha amiga e porque eu estou... fugindo da minha namorada.
<p>- Por quê?
<p>- Preciso terminar com ela. – Jason sorriu sem graça.
<p>- Por quê?
<p>- Ela disse que me amava, pode uma coisa dessas?
<p>- Não entendi. – Nathan ficou confuso.
<p>- Deixa para lá. Continua lendo seu livrinho, tá bom? – Jason colocou o livro na mão de Nathan. – Mas chama a Temperance para sair.</p>
<center><h4>--*--</h4></center>
<p>- Vai terminar com a Emily? – Lisa não podia acreditar.
<p>- Vou. – Jason e Lisa estavam voltando para casa depois da aula. – Já até cancelei nossos planos para o dia dos namorados por mensagem. Não foi muito difícil, eu nem tinha muitos planos.
<p>- E quando eu acho que você não pode ficar mais ridículo, você fica.
<p>- Por que está dizendo isso? – Jason se indignou.
<p>- E por que você vai terminar com ela?
<p>- Ela disse que me amava. – Jason quase sussurrou.
<p>- O quê? Nossa. – Lisa ficou impressionada.
<p>- Não se diz uma coisa dessas, não é verdade?
<p>- Por que não? Vocês estão juntos faz um tempo.
<p>- Não é tempo suficiente. – Jason estava parecendo um louco desesperado.
<p>- Qual é o problema com você?
<p>- Nunca ninguém disse que me amava, você sabe disso.
<p>- Algumas já disseram. – Lisa riu.
<p>- Mas não era de verdade. Só falavam no desespero, sei lá. E eu nunca disse que amava alguém também.
<p>- Você disse que entraria nessa de cabeça. – Lisa se lembrou de um recente discurso de Jason para Emily. – Está voltando agora?
<p>- Talvez eu tenha exagerado, talvez tenha sido a adrenalina. Eu não penso no que eu falo, tá bom? E eu estava em cima de uma mesa, eu tinha que ser incrível. Agora eu percebi que não estamos na mesma página.
<p>- Não a ama? – Lisa sabia o que o amigo ia responder, mas sabia o que ele realmente sentia também.
<p>- Eu gosto muito dela, tá bom? Ela é incrível, inteligente, divertida, eu gosto de estar com ela, mas amor é uma coisa muito forte e eu acho que ainda é muito cedo.
<p>- Devia estar falando isso para ela e não para mim.
<p>- Você é muita chata.
<p>- Eu estou sem namorado. Aguente a minha chatice. Além do mais, não foi difícil para mim dizer que amava o Brandon.
<p>- Lisa, você diz “eu te amo” para todo mundo.
<p>- Não digo nada.
<p>- Diz sim. – Ele rebateu.
<p>- Cala a boca.</p>
<center><h4>--*--</h4></center>
<p>- Tudo bem, a sua namorada ou ex, sei lá, está me deixando louco.
<p>Jason foi na casa de Brandon naquela tarde. Tudo para não pensar muito no que faria em relação a Emily. Ele preferia ficar se preocupando com os problemas dos outros do que com os dele.
<p>- Do que está falando?
<p>Jason encontrou Brandon no seu computador secreto. Não ficou surpreendido.
<p>- Quando você e a Lisa vão se acertar? – Ele se sentou na cama para ficar de frente com o garoto.
<p>- Eu não sei. – Brandon parecia emburrado.
<p>- Guarde seu orgulho no cabelo e vá falar com ela.
<p>- Ela me traiu.
<p>- Não exatamente, e se você viu tudo, deveria saber.
<p>- Temperance te contou.
<p>- Ela é uma linguaruda, sabemos disso. Me poupe o choque. – Jason não fez um grande caso daquilo.
<p>- Olha...
<p>- Quem foi que disse que Lisa e Kol saírem juntos era uma má ideia e ninguém se importou? Eu. Sim, eu quero você dizendo “Jason, você tinha razão esse tempo todo.”.
<p>- Eu não vou dizer isso. – Brandon olhou com cara feia.
<p>- Me contento com uma nota de cinquenta.
<p>- Cala a boca.
<p>- Vocês são ridículos. – Jason riu. – Tá, eu não dou a mínima para essa data idiota, mas vocês se amam e deviam estar juntos hoje e não de frescura um com o outro.
<p>- Cuida da sua namorada que eu cuido da minha.
<p>- É por isso que eu não sou altruísta. Não importa o que eu faça para ajudar, as pessoas sempre são mal-agradecidas.
<p>- Eu não quero a sua ajuda. Eu quero um tempo.
<p>- A vida é curta demais para você pedir um tempo. Amanhã ela pode desistir de você e seguir em frente.
<p>- Então ela não me amava de verdade.
<p>- Ou só se cansou de esperar quem não a amava.
<p>- Mas eu amo.
<p>- Ótima maneira de demonstrar. Porque está acabando com esse seu amor de um jeito rápido e fácil demais
<p>- Você se acha um expert em namoro?
<p>- Não, mas você também não é expert em beleza e tem esse cabelo ridículo, todos temos falhas, mas eu tento ajudar.
<p>- Você me odeia, por que quer me ajudar?
<p>- Eu não sou altruísta, lembra? Eu estou fugindo da Emily, te ajudar é um bônus. – Jason se deitou na cama.
<p>- Fugindo por que?
<p>- Como se sentiu quando a Lisa disse que te amava? – Jason ficou encarando o lustre do teto.
<p>- Eu adorei, já que eu a amava também.
<p>- Você não sentiu nem um medinho?
<p>- Não.
<p>- Parece tão simples para vocês.
<p>- Se você sente, é simples.
<p>- Vamos parar de falar de mim. – Jason não gostava muito de conselhos. – Vá falar com a Lisa. Ela ainda tem esperanças de que essa data seja perfeita.
<p>- Eu não posso.
<p>- Então eu vou arrancar os seus dentes um por um. E quando os dentes acabarem, eu arranco seus cabelos, arame por arame.
<p>- Eu estou com medo.
<p>- Não vai perde-la se é isso que te assusta, já que ela está com o mesmo medo. Vocês vão se acertar. Eu sei disso.
<p>- Como?
<p>- Eu conheço a Lisa mais do que ninguém, e quando ela diz que ama, ela ama de verdade.
<p>- E você?
<p>- O que tem eu? – Jason não entendeu.
<p>- Você a ama?
<p>- É claro que eu amo a Lisa, mas como amigo, relaxa.
<p>- Eu estou falando da Emily.
<p>- Eu não sei.
<p>- Jason, ou você a ama ou não. Não existe um “não sei”.
<p>- Talvez vocês inferiores a mim...
<p>- Que? – Brandon riu.
<p>- Talvez vocês não sejam os únicos com medo. Definitivamente não são os únicos.</p>
<center><h4>--*--</h4></center>
<p>Temperance tinha acabado de tirar as pipocas da panela e colocado em um balde grande e já estava indo se acomodar no sofá. A pilha de DVDs de filmes de terror estava em cima da estante. A televisão já estava ligada e o aparelho já estava pronto para introduzir um disco. Ela só estava esperando Brandon chegar.
<p>- Oi.
<p>Temperance levou um susto quando foi atender a porta e não era seu amigo que estava do lado de fora.
<p>- Oi, Temperance. – Nathan sorriu.
<p>- O que faz aqui? A gente combinou alguma coisa? – Ela ficou um pouco perdida. Não estava arrumada, estava sem maquiagem, com uma roupa que só usava para dormir e seu cabelo estava enrolado em um coque mal feito.
<p>- Bom, eu estava sozinho em casa e pensei, por que não passar na Temperance hoje?
<p>- Geralmente, as pessoas quando ficam sozinhas pensam nisso. – Temperance riu. Era sempre mais fácil rir com Nathan por perto.
<p>- Eu estou atrapalhando?
<p>- Não, é claro que não. – Temperance até se esqueceu que estava esperando por Brandon. – Entra. Eu estava me preparando para o meu Cinema em Casa.
<p>- Ótimo programa. – Nathan então deixou à mostra um bombom na palma da mão. – É para você.
<p>- Muito obrigada. – Temperance pegou o bombom da mão de Nathan. – “Seja minha namorada”. – Ela leu o que estava escrito no bombom.
<p>- Eu comprei na lojinha aqui perto. Não quis chegar de mãos abanando.
<p>- Eu imaginei isso.
<p>- É, não quer dizer que...
<p>- Claro que não. – Temperance completou.
<p>Os dois se sentaram no sofá.
<p>- O que vai assistir?
<p>- Ah, tem uns filmes de terror que lançaram que são muito bons. – Ela estava com um pouco de nervoso. Ainda bem que seus pais sempre saíam em noites de dia dos namorados.
<p>- Vai ver filmes de terror no dia dos namorados? – Nathan ficou impressionado.
<p>- Podemos ver comedia romântica então.
<p>- Terror é muito melhor. – Ele sorriu.
<p>- Que bom. A última coisa que eu quero assistir é uma comédia romântica. – Temperance foi colocar o filme.
<p>- Você deve estar achando estranho eu ter aparecido, não é?
<p>- Não. – Temperance mentia muito mal. – Um pouco, na verdade.
<p>- E deve quer saber porque eu realmente vim.
<p>- Bom, sim. – Ela riu sem graça.
<p>- Hoje, alguém me disse que se eu gosto de uma garota, eu tenho que ficar com ela, simples assim.
<p>- Quer dizer que...
<p>- Eu gosto de você e eu quero ficar com você. – Ele falou sem pausas.
<p>- Ai, meu Deus. Não. – Temperance ficou apavorada.
<p>- Você não quer ficar comigo?
<p>- Não, é que... Você... Eu... – Temperance começou a gaguejar. – A gente não... eu não...
<p>- Se quiser, eu vou embora. – Nathan então ficou constrangido.
<p>- Não, o problema é comigo. Eu não estava esperando por isso e você chegou dizendo e.... – Temperance não conseguia terminar a frase.
<p>- Você não gosta de mim?
<p>- Eu gosto.... eu... é que...Me beija, por favor.
<p>- O quê? – Nathan não esperava por isso.
<p>- Não me faça repetir. – Temperance já estava sem fôlego.
<p>- Se é o que você quer.
<p>- É o que eu quero. – Ela estava meio louca.
<p>- Então tá. – Nathan não se mexeu.
<p>- Então tá. – Temperance ficou esperando o beijo chegar.
<p>“O que o Jason faria?” Nathan se perguntou. “Provavelmente tentaria arrancar as roupas dela enquanto a beijava” ele pensou. “Mas eu não vou fazer isso.”.
<p>Então Nathan beijou Temperance. A garota agradeceu aos céus que Nathan fez isso de surpresa, porque se fosse planejado, ela provavelmente teria se esquivado só por reflexo, ainda bem que ela não fez isso. Ela queria aquele beijo já fazia tempo. Sim, aquilo finalmente salvou a data que ela tanto detestava.</p>
<center><h4>--*--</h4></center>
<p>- Achei que nunca mais falaria comigo.
<p>- Eu posso te surpreender.
<p>Lisa estava de frente a um tanto fechado Brandon parado na sua porta. Pela sua expressão, Lisa percebeu que ele já sabia de tudo.
<p>- O que você quer? Terminar de vez? – Lisa estava brava.
<p>- Não, eu quero nos salvar. Porque eu te amo e você também me ama.
<p>- Eu não traí você. Não sei o que você ouviu, mas eu não te traí.
<p>- Eu não ouvi nada, eu vi. Eu vi vocês dois naquele parque. Eu vi vocês dois se beijando. Ninguém me contou, eu vi. – Mesmo querendo conversar, Brandon não conseguiu deixar de acusar.
<p>- Ele me beijou, eu não correspondi. – Lisa explicou logo.
<p>- Mas eu fiquei mal.
<p>- Eu entendo. Mas não precisava me ignorar.
<p>- Você mentiu para mim. Não contou. Além do mais, você me ignorou primeiro. Acha que foi fácil falar com você sabendo de tudo e sabendo que você estava me escondendo? Não foi.
<p>- Não queria te deixar bravo. Eu não sabia que essa coisa toda com a Maddie ia acontecer. A verdade é que eu estava tentando esquecer.
<p>- Mas não dá, tá bom? Aconteceu, não dá para apagar.
<p>- Eu sei. – Lisa não sabia se devia chamar Brandon para entrar.
<p>- Sentiu alguma coisa por ele?
<p>- É claro que não, a não ser repulsa.
<p>- Então por que não me contou? Eu acreditaria em você.
<p>- Eu nem sempre faço as coisas certas. Eu não sou perfeita... mas eu te amo.
<p>- Você não pode usar essa desculpa para tudo.
<p>- Isso não é uma desculpa. E você disse que queria nos salvar, mas até agora só está na defensiva. – Lisa parecia sem esperanças para essa conversa.
<p>- Eu não sei se eu estou pronto para esquecer e começar tudo de novo.
<p>- O que quer que eu faça então?
<p>- Fica um pouco longe de mim. – Essa não era a ideia inicial de Brandon, mas ele não conseguiu evitar. - Não vou conseguir lidar com a sua presença por um tempo.
<p>- Tudo bem. – Lisa fechou a cara.
<p>- Lisa...
<p>- Então saia daqui. Não quero te incomodar com a minha presença.
<p>Lisa bateu a porta com força. Ainda bem que Brandon estava longe do batente senão teria feito um machucado no nariz.</p>
<center><h4>--*--</h4></center>
<p>- Emily!
<p>Jason gritou. Para que tocar a campainha? Para que bater palmas? Gritar era muito melhor.
<p>- Emily!
<p>Jason olhava fixamente para a porta da casa de Emily na esperança de ver ela saindo para falar com ele. Já estava anoitecendo e as luzes de fora da casa já estavam acesas.
<p>- Emily!
<p>- O que foi? – Emily saiu na janela do seu quarto um pouco assustada.
<p>- Quero falar com você!
<p>- Existe o telefone. Afinal ele serviu quando você precisou cancelar nossos planos para hoje. – Emily foi fria.
<p>- Você está brava? Disse que tinha entendido.
<p>- Eu menti, tá bom?
<p>- Mas... Olha, deixa para lá, tá bom? Desci aqui, o que eu quero falar não dá para falar por telefone.
<p>- Por quê? É em linguagem de sinais?
<p>- Desce aqui.
<p>- Eu não vou descer. Eu vou me despedir educadamente e pedir para você ir embora, amanhã na escola a gente conversa.
<p>- Não! Você precisa descer. Eu estou aqui, então você precisa descer!
<p>- Jason, já está tarde.
<p>- Desce. – Jason sorriu e respirou fundo. Estava cansado de tanto gritar.
<p>Emily fechou a janela. Ele esperou quieto por alguns segundos, ela demorou para abrir a porta e sair de casa, mas ele nunca duvidou de que ela faria isso.
<p>- O que foi? – Ela não se aproximou muito dele. Ficou em uma distancia um pouco grande e com os braços cruzados.
<p>- Não pode ficar brava comigo.
<p>- Ah não? E por quê?
<p>- Sabe que a culpa disso tudo é sua, não sabe?
<p>- O quê? – Emily finalmente ficou confusa.
<p>- Você disse que me amava. Como queria que eu reagisse depois disso?
<p>- O quê? Eu não disse nada.
<p>- Ah, agora vai dizer que não disse? – Jason ficou bravo. – Você se levantou, disse que já voltava, me beijou e disse “te amo”. Esqueceu disso?
<p>- Ah, isso... Eu não esqueci. – Emily não ficou sem graça. – Eu disse, tá bom, o que importa? Não é nada demais.
<p>- É claro que é. Você não diz “eu te amo” como uma “boa tarde”, você diz “eu te amo” porque realmente sente. Você sente?
<p>- Se eu não sentisse, eu não teria falado. Eu geralmente falo o que eu sinto para as pessoas.
<p>- Eu também. Semanas atrás eu fiz uma declaração para você.
<p>- E eu adorei.
<p>- Você me ama? – Jason parecia decepcionado.
<p>- Amo. – Emily parecia decidida.
<p>- Droga.
<p>- Por que “droga”? – Ela se aproximou um pouco.
<p>- Você não pode me amar, eu não sou alguém para se amar, para falar a verdade. Eu vou te encher de dor de cabeça.
<p>- Eu não estou te entendendo. Você disse que queria entrar de cabeça nisso.
<p>- Todo mundo está usando isso contra mim agora? Eu não penso em tudo o que eu falo. – Jason repetiu sua desculpa. – E essas coisas... eu não falei sério, é tipo, dizer que eu levaria um tiro por você. Ninguém faz isso na vida real.
<p>- Eu não te entendo. – Emily percebeu o quanto Jason estava assustado.
<p>- Por que você me ama?
<p>- Como assim?
<p>- Olha, hoje eu passei o dia todo tentando juntar a Tempe com o tal de Nate, tentando fazer o Brandon e a Lisa reatarem e tentar tirar isso da cabeça...
<p>- “Isso” seria nós?
<p>- Se eu te amasse, e eu estou dizendo “se”, eu saberia por que, mas eu não consigo entender porque você me ama.
<p>- Eu só amo, não tenho uma razão. Eu simplesmente amo.
<p>- Eu sinto muito.
<p>- Tudo bem. – Emily parecia mesmo que não estava abalada. – Eu entrei nessa já sabendo que tinha um prazo de validade e...
<p>- Olha, não me entenda mal.
<p>- E como eu faço isso?
<p>- Eu gosto muito de você, eu adoro ficar com você, você me faz rir, me faz pensar e querer me esforçar, você me faz ser alguém melhor e eu gosto disso. Droga, eu gastei horas estudando e nunca tinha feito isso.
<p>- Jason, não precisa falar isso e...
<p>- Eu sou muito feliz do seu lado, e esse seu sorriso é coisa de outro mundo. – Mesmo um pouco brava, Emily sorriu. – Quando eu acordo, eu penso nesse sorriso e ele me anima, e então eu te vejo e sempre quando nos despedimos você sorri de novo, é a melhor hora do meu dia, às vezes eu até falo algo ridículo só para você rir e eu admirar.
<p>- Eu já entendi.
<p>- Cara, você é um idiota. – Jason pensou alto.
<p>- O quê?
<p>- Eu amo tudo o que você é. Eu amo o jeito como você briga comigo e como vive teimando comigo, eu amo as suas histórias bobas, pelo menos as que eu presto atenção. Eu amo saber que mesmo sem assunto, você vai ficar falando vinte e quatro horas por dia se eu deixar, eu amo quando eu chego aqui no domingo bem cedo e vejo a sua cara de quem acaba de acordar com esse cabelo bagunçado que só Deus salva. – Jason riu e fez Emily rir também. – Eu amo o jeito que você me olha, é um jeito diferente, você me chama de bobo, mas não me acha um bobo. Eu amo o fato de que sempre posso ter você na minha vida pelo menos enquanto eu não estrago tudo. Eu amo que você seja a minha namorada.
<p>- Acabou? – Emily sabia que não.
<p>- Mais do que tudo isso, eu amo você.
<p>- Ama?
<p>- Eu devia ter te dito isso hoje de manhã. Eu devia ter dito isso naquele dia em cima da mesa. Eu não devia ter duvidado do que eu sinto. Eu amo você.
<p>- Diz de novo. – Emily sorriu.
<p>- Eu amo você.
<p>- Viu? Não é tão difícil. – Ela caminhou até ele.
<p>- Eu amo você.
<p>- Eu também amo você.
<p>Jason então a beijou.
<p>- Você faz ser fácil amar você. – Emily estava quase sem fôlego.
<p>- É um dom.
<p>Emily riu.
<p>- Garota, você conseguiu.
<p>- É um dom. – Ela levantou as sobrancelhas.
<p>- E que dom.</p>
</body></html>";
            }

            if (numero == 20)
            {
                lblTitulo.Text = "Capítulo 20 - Revelação";
                htmlPage.Html = @"<html><body>
<p>Jason acordou disposto naquele dia.
<p>O sol já estava batendo na janela e seu quarto já estava todo iluminado, mas isso não o incomodava. Seu namoro com a Emily estava perfeito, o blogueiro tinha parado de falar sobre ele, pelas mensagens que recebia de Temperance o tempo todo, parecia que Nathan finalmente tinha tomado alguma atitude e ele estava feliz pela amiga, Lisa parecia mais concentrada nos estudos e na sua própria vida e Jason ficou contente por ela não estar chorando pelos quatro cantos da casa por causa do término com o Brandon no dia dos namorados. “Eu vou superar”, ela falava sempre que alguém olhava para ela com cara de dó. E a coisa que estava deixando Jason mais feliz era que estava longe dos pais.
<p>Lisa sempre falava que estava com saudades dos pais e da irmã mais nova que deixou em Los Angeles, ela sempre ficava no telefone por horas conversando com os pais e a irmã, mas Jason não sentia essa necessidade. A falta que ele sentia dos pais era zero, sua mãe fala com ele por telefone todos os dias, mas Jason não costumava dar muitos detalhes da sua vida ali mesmo ela reclamando o tempo todo, seu pai sempre estava ocupado fazendo algo muito importante para não falar no telefone ou estava viajando. Jason não gostava muito da ideia de sua mãe sozinha por muito tempo, mas também não podia ser falso ao ponto de dizer que não estava gostando daquela folga que os pais deram a ele se mudando para Dallas.</p>
<center><h4>--*--</h4></center>
<p>- Vocês se pegaram hoje de novo? – Jason fazia essa pergunta para Temperance sempre que os dois se encontravam desde o dia dos namorados. Dessa vez foi em frente o armário dela. Ele veio como um raio e quase fez ela derrubar todos os seus livros no chão.
<p>- Quer parar? A gente só se beijou... uma vez. – E ela sempre dava a mesma resposta irritada.
<p>- Você o deixou tão entediado assim? Ele vai achar que você é puritana. Ou ele que está recusando? Será ele o puritano? Eu me surpreenderia. – Jason riu.
<p>- Quer calar essa boca? Como está a Lisa? – Temperance não parecia interessada na Lisa, mas sabia que Jason se importava com ela então...
<p>- Melhor do que eu pensei. Ela é forte.
<p>- Espero que ela continue forte. – Ela não queria tocar no assunto, mas esconder seria pior.
<p>- Como assim? O Brandon te disse alguma coisa? Ele já está com outra?
<p>- O problema não é com o Brandon. Ele está depressivo demais para pensar em qualquer coisa.
<p>- Tem falado com ele?
<p>- Sabe como é difícil finalmente sentir uma felicidade no amor e não poder compartilhar com o seu melhor amigo porque ele está brigado com o amor e amargo? Não estamos conversando muito sobre essas coisas. Ele nem sabe nada sobre o Nate.
<p>- Você tem que ser que nem eu. Seja um egoísta, não ligue para os sentimentos dos outros e espalhe aos quatro ventos que está apaixonado.
<p>- Ai, que preguiça de você. – Temperance revirou os olhos. – Mas como eu ia dizendo, o problema não é o Bran. A Maddie está muito brava e quer se vingar.
<p>- Ah, ela? – Jason fez pouco caso e até fingiu gargalhar. – Eu não me assustaria com a Maddie e sua vingança. Ela não tem cara que faz um plano maligno. Ela nem tem cara de quem faz um plano.
<p>- Ela disse que sabe quem é o blogueiro.
<p>- Ela está mentindo. A gente não descobriu nada. – Jason não levava a Maddie a sério de jeito nenhum.
<p>- Ela disse que descobriu depois que vocês brigaram.
<p>- Você acreditou nela?
<p>- Ela me deixou na dúvida. Estava bem convincente.
<p>- Olha, a Maddie, por alguma razão que eu acho que é porque ninguém quer tirar a virgindade dela, resolveu ser a babá meio maluca do irmão que é estranho. Ela ficou psicótica. É nessas horas que eu agradeço por não ter irmã. Mas eu não acho que ela tenha mente maligna, é só olhar para a cara dela. Parece uma tapada.
<p>- Não julgue pelas aparências.
<p>- Você me julgou.
<p>- Tá, quando eu te conheci eu achei que você era um idiota, metido e egocêntrico que só pensava em mulher, me desculpa.
<p>- Está desculpada
<p>- Fui irônica, você é isso mesmo.
<p>- Mas sou um amor de pessoa. – Jason sorriu.
<p>- Não é não.
<p>- Olha, acho que vou falar com a Maddie. Dar um chega para lá nela. Colocar ela de volta no mundo real.
<p>- E se ela quiser se vingar de você também?
<p>- É a Maddie. O que ela pode fazer? Jogar leite de cabra em mim?
<p>Temperance não respondeu, mas parecia preocupada. Será que a Maddie sabia mesmo quem era o blogueiro?</p>
<center><h4>--*--</h4></center>
<p>- Maddie!
<p>Jason gritou Maddie no meio do corredor da escola. Ela parou de andar e se virou para ele que vinha correndo em sua direção.
<p>- O que foi? Veio se desculpar? – Maddie olhou com cara feia para Jason.
<p>- Primeiro, isso nunca vai acontecer, e segundo, isso nunca vai acontecer.
<p>- Então o que você quer?
<p>- Pare de bancar a louca vingadora e pare de mentir que sabe quem é o blogueiro.
<p>- Mas eu sei quem é.
<p>- Não descobrimos nada. Você está blefando. – Jason não acreditava em Maddie.
<p>- Eu descobri depois que você desistiu. – Maddie se sentia melhor que Jason.
<p>- Quem é, então? – Jason sabia que ela ia enrolar.
<p>- Eu não vou contar para você.
<p>- Não vai porque não sabe.
<p>- Escuta aqui...
<p>- Não, escuta aqui você. – Jason não tinha muita paciência. – Olha, Maddie, você é uma chata, irritante, um pé no saco, fala mais do que deve, aparece do nada atrapalhando as pessoas e me dá náusea ficar olhando para você por mais de cinco segundos... Até esqueci o que eu ia falar depois desses adjetivos... – Ele fez uma pausa. – Ah tá, você não é o tipo de garota que se revolta.
<p>- Você não me conhece. – Maddie encarou Jason.
<p>- Graças a Deus. Olha, quer um conselho? Deixa o Kol cuidar da vida dele e lidar com o que ele faz. Fica na tua.
<p>- Não se mete na nossa vida.
<p>- Eu me meto quando você começa a se meter com a Lisa. Deixa ela em paz.
<p>- Ela vai pagar pelo que ela fez.
<p>- Como sabe que o blogueiro vai trabalhar com você? – Jason tentou entrar na fantasia da garota.
<p>- Vou chantageá-lo. Se ele não me ajudar, eu exponho ele.
<p>- Ele é o blogueiro. Não vai aceitar sua chantagem, ele vai dar um jeito para se esconder.
<p>- Não, o Nathan não é tão inteligente assim. – Maddie falou quase que para ela mesma.
<p>- O quê? – Jason fingiu não ouvir.
<p>- Nada. Eu não disse nada.
<p>- Eu sei o que você fez aqui. Disse o nome do Nathan para eu sair que nem louco atrás dele e bater nele e essas coisas que eu costumo fazer, mas eu não vou cair nessa. Você não é capaz de me enganar com essa sua mente pequena.
<p>- Mas é verdade. Ele é o blogueiro.
<p>- Sim, e foi o Papai Noel que quebrou um pedaço do gelo da Antártica para virar um iceberg flutuante e afundar o Titanic.
<p>- Eu estou falando sério. Você vai se surpreender.
<p>- Olha só garota, eu não tenho medo de você, você é uma ninguém para mim, e sabe o que eu fazia com ninguéns que mexiam comigo na minha outra escola? Coisas ruins.
<p>- Não pode me bater. – Maddie parecia assustada.
<p>- Eu não vou bater em você. – Jason achou ridícula essa ideia. – Mas quando se trata de tirar as pedras que ficam no meu pé, eu sou um gênio.
<p>- Você que está me ameaçando agora?
<p>- Só estou fazendo o que eu sei fazer melhor. Combatendo fogo com fogo.
<p>- Não tenho medo de você.
<p>- Não é para ter medo. É para ser inteligente. Cai fora.</p>
<center><h4>--*--</h4></center>
<p>- Eu não entendo. Por que ela está fazendo? – Emily ouvia a história de Jason detalhe por detalhe enquanto tentavam estudar para uma prova de matemática que teriam em duas horas.
<p>- Falta de namorado, deve ser isso.
<p>- Não acho que isso tenha a ver. – Emily riu. – Vai ver ela é muito ligada ao irmão.
<p>- Ligada até demais. Eu queria fazer uma referência a Game Of Thrones, mas não sei o nome daqueles irmãos que transam.
<p>- Cala a boca.
<p>- O que será que aquele idiota do Kol contou para ela? Que ele está de coração partido?
<p>- Não faço ideia, mas você não vai conseguir pará-la.
<p>- Eu sei. As que se fazem de boba são as piores.
<p>- O que vai fazer então?
<p>- Alertar a Lisa para ela ficar preparada.
<p>- Me diz uma coisa, eu fiquei muito curiosa quanto a isso. A Maddie deu a entender que o blogueiro é o Nathan. Por que não acreditou como sempre? – Emily ficou surpresa com essa parte.
<p>- Porque ela estava mentindo. Eu não ia sair batendo em alguém por engano.
<p>- Você sempre bate em alguém por engano. – Emily riu.
<p>- Tudo bem, depois do que aconteceu com a gente, eu estou tentando ir com calma. Ter certeza antes de acusar. Eu aprendo com os meus erros, tá bom? – Jason sorriu.
<p>- Eu estou orgulhosa. – Emily o beijou.
<p>- Mas e se ele for o blogueiro?
<p>- Jason...
<p>- E se ele só se aproximou da Tempe para colher informações da gente?
<p>- Jason...
<p>- Faz sentido.
<p>- Para. – Emily olhou séria.
<p>- Você está defendendo ele. Vocês estão juntos nisso?
<p>- Sério? – Emily não viu graça.
<p>- Eu estou brincando, baby.
<p>- Sem o “baby”. – E mais uma tentativa de Jason para apelidos ia para o ralo.
<p>- Tudo bem.
<p>O celular de Jason começou a vibrar em seu bolso.
<p>- O que foi? – Emily percebeu que Jason mudou de expressão de repente.
<p>- O Bran me ensinou a colocar um alerta no blog e agora o meu celular está avisando. – Jason pegava o celular do seu bolso.
<p>- Nossa, quer dizer que o blogueiro acordou de novo?
<p>- Espero que ele tenha sido atacado por um Boa Noite Cinderela. – Jason começou a ler o post.
<p>- O que está escrito? – Emily tentou ler junto com o namorado, mas ele era muito alto para ela poder enxergar a tela do celular dele.
<p>- Aquela garota não pode estar falando a verdade.
<p>- Como assim?
<p>- O blogueiro acabou de falar mal da Lisa.
<p>- O quê? – Emily pegou o celular da mão de Jason. – Acha que a Maddie está envolvida?
<p>- Vamos descobrir.</p>
<br>
<p><i>“<b>NOVIDADES, PESSOAL:</b> Boatos estão rolando por aí dizendo que a nossa Lisa está brincando com dois garotos ao mesmo tempo. Como será que ela faz isso? Será que o perfume dela é muito bom ou será outra coisa dela que é boa? Bom, mesmo assim, eu aconselho as garotas do Carmel a pedir ajuda a nossa amiga, afinal ela sabe das coisas. Agora me diga uma coisa, Lisa, é legal ser a nova vadia da escola? Realizou o seu sonho? Ou você está atrás do terceiro? Só saiba que eu estou aqui a sua disposição, gata. Ainda bem que a Sem conseguiu tirar o Jason dessa.”.</i> – Tesouro de Segredos Obscuros.</p>
<br>
<p>- O que você tem a ver com isso?
<p>Jason colocou a tela do celular dele na cara da Maddie que estava na sala de aula estudando.
<p>- O quê? Nada. – Maddie se assustou.
<p>- Fala a verdade. – Jason ficou vermelho.
<p>- Jason, calma. – Emily estava atrás dele como se fosse uma consciência estranha.
<p>- Eu ainda nem falei com o blogueiro. Eu juro.
<p>- Ah é? Então ele está te ajudando por conta própria? O blogueiro é o seu irmão?
<p>- O quê? É claro que não. – Maddie ficou chocada com a dedução de Jason.
<p>- Jason, isso está exagerado demais até para você. – Emily olhou para Jason com aquela cara de “Pare enquanto pode”.
<p>- Faz sentindo. – Ele olhou para Emily.
<p>- Não. – Emily o fuzilou com os olhos.
<p>- Então me diz, - Ele voltou a encarar Maddie. – Você quer se vingar da Lisa e se juntar ao blogueiro, de repente assim do nada, o blogueiro resolve falar mal da Lisa, como eu não associo ele a você?
<p>- Ele está me ajudando. Isso é bom. – Maddie parecia nervosa, mas um pouco satisfeita.
<p>- Você está feliz por não precisar fazer muito trabalho. – Jason sacou logo.
<p>- Como assim?
<p>- Você não sabe quem é o blogueiro, mas está feliz por ele estar falando da Lisa. Você é uma farsa. – Ele quase gritou.
<p>- Tudo bem, eu confesso, eu peguei uma pista errada.
<p>- Então você não sabe quem é o blogueiro? – Emily falou.
<p>- Não, mas eu achei que sabia. – Maddie lamentou.
<p>- Olha só garota, para. Está começando a ficar feio para você. – Jason apontou o dedo na cara de Maddie.
<p>- O quê?
<p>- Você é uma ridícula.
<p>- Jason. – Emily queria que Jason maneirasse.
<p>- Não, é verdade. – Jason ignorou Emily. – Eu estou começando a ficar com pena de você. É como se você não tivesse nada para fazer na vida e resolvesse travar uma guerra inútil e sem lógica com a Lisa só para ficar ocupada com alguma coisa e não precisar ficar no quarto o dia todo chorando.
<p>- Jason, já chega. – Emily pegou no braço do namorado. – Vamos embora, ela não tem nada a ver com isso.
<p>- Pelo menos, eu venci. – Maddie então falou.
<p>- Aproveite então. – Jason olhou feio para ela.
<p>Emily puxou Jason pelo braço até saírem da sala.
<p>- Emily, chega. Não precisa bancar a minha anti-raiva. Eu não ia bater nela se é isso que você está pensando. – Jason estava bravo.
<p>- Eu não estou preocupada com ela. Eu estou preocupada com o blogueiro.
<p>- Deveria, porque quando eu o achar, vou encher ele de porrada.</p>
<center><h4>--*--</h4></center>
<p>- Sabe, eu estava pensando que podíamos ao cinema qualquer dia desses. – Nathan falou como se não quisesse nada.
<p>Ele tinha corrido para alcançar Temperance quando ela saiu da sala para ir até o refeitório almoçar.
<p>- Pode ser bom, além do mais tem muitos lançamentos que eu quero ver. – Temperance estava animada.
<p>- Não, vamos assistir um filme chato.
<p>- Por quê? – Ela não entendeu.
<p>- Assim não vai fazer falta as partes que vamos perder do filme.
<p>- Como assim?
<p>- Ah... – Nathan não ia conseguir explicar. – Que filme você quer ver? – Ele resolveu mudar de assunto.
<p>- Você escolhe então.
<p>- Combinado.</p>
<center><h4>--*--</h4></center>
<p>- Ai, eu estou ficando louco. – Jason estava guardando a sua mochila no armário.
<p>- Jason, calma. – Emily percebia a tensão no ar.
<p>- Quando esse blogueiro vai nos deixar em paz?
<p>- Talvez quando nos formarmos.
<p>- Que notícia acolhedora. – Jason resmungou. – Só faltam alguns meses então.
<p>- Não temos muito o que fazer.
<p>- Depois de tanto tempo quieto, por que ele resolveu falar mal da Lisa agora?
<p>- Bom, a Maddie pareceu estar falando a verdade, não acho que ela tenha alguma coisa a ver com isso.
<p>- É, eu sei. Nem para isso aquela garota presta. – Ele falou derrotado.
<p>- Para.
<p>- A linha direta. – Ele arregalou os olhos enquanto tentava empurrar a mochila dentro do armário.
<p>- O quê?
<p>- A linha direta. O blogueiro deve ter ouvido a conversa que eu tive com a Maddie, assim como ele escuta todas as minhas outras conversas. Então atacou a Lisa.
<p>- Não faz sentido.
<p>- Ele sabia que a Maddie ia tentar procura-lo, então ele resolveu ajuda-la antes para ela ficar quieta no canto dela. – Jason começou a pensar nas coisas.
<p>- Como ele faz isso?
<p>- Isso eu já não sei, mas ele faz.
<p>Jason ficou parado um pouco, ele parecia estar pensando em alguma coisa. Então, sem nenhum aviso, ele começou a tocar no seu corpo membro por membro.
<p>- O que está fazendo? – Emily ficou observando Jason bagunçando seu cabelo, passar a mão pelo seu próprio rosto, pelo pescoço, depois nos braços, peito e barriga. – Olha, eu sei que você se ama muito, mas não precisa ficar se tocando aqui. – Emily ficou desconfortável por ele estar fazendo aquilo no meio do corredor da escola.
<p>- Engraçadinha. – Jason começou a passar as mãos pelas suas pernas, depois tirou o tênis e apertou seu pé.
<p>- O que você está fazendo?
<p>- Ele com certeza colocou uma escuta em mim. Não tem outra explicação.
<p>- Na sua bunda? – Emily ficou olhando Jason apertar a sua própria bunda.
<p>- Bom, é que uma vez eu fiquei com uma garota lá no armário de vassouras e ela ficou apertando, vai que ela colocou uma escuta aqui e eu não percebi?
<p>- Eu poderia viver sem saber disso.
<p>O sinal tocou.
<p>- Olha só, vamos para aula. Depois você se toca de novo. – Emily fez uma cara de nojo.
<p>- Eu tive uma ideia melhor. – Jason fechou o seu armário. – Você me ajuda. Vamos para sua casa, eu tiro a roupa e você me examina da cabeça aos pés.
<p>- Hoje, não.
<p>- Talvez amanhã?
<p>- Jason, não.
<p>- Tudo bem, mas se o blogueiro continuar ouvindo o que a gente fala, a culpa vai ser sua.
<p>- Eu posso conviver com isso. Vamos logo para a aula e para de falar besteira.
<p>- Tá bom.
<p>- Não, espera. Você guardou as minhas anotações de cálculo na sua mochila.
<p>- Droga. – Jason voltou a abrir seu armário.
<p>Ele tentou tirar os papéis sem colocar a mochila para fora, mas estava impossível, seu armário não era uma coisa muito organizada. Jason puxou a mochila e não conseguiu tirá-la do armário.
<p>- O que houve? – Emily viu Jason enfiar a cabeça toda dentro do armário.
<p>- Meu chaveiro está preso no vão do armário.
<p>- Que ótimo. Vai, estamos atrasados.
<p>- Calma, mulher. – Jason começou a puxar a mochila com toda força e conseguiu solta-la do armário. – Ai, droga!
<p>Jason viu seu chaveiro se partir em 50 pedaços conforme eles iam caindo no chão.
<p>- Ai. – Emily se abaixou para pegar o chaveiro a procura de algum conserto.
<p>- Já era.
<p>- Concordo. – Emily juntou tudo na palma da sua mão.
<p>- O que é isso? – Jason apontou para uma luzinha vermelha que ficava piscando entre os destroços.
<p>- Parece ser um chip de computador.
<p>- Eu não sabia que o chaveiro brilhava no escuro. – Jason parecia mais desapontado por ter quebrado o chaveiro.
<p>- Não é isso. Sei lá, parece uma... – Emily pensou bem antes de falar.
<p>- Uma escuta? – Jason percebeu logo.
<p>- Agora tudo faz sentido.
<p>- Eu não largo essa mochila para nada. Era tão obvio. Mas espera, como conseguiram colocar a escuta aqui?
<p>- Devia ter algum compartimento. Quando o chaveiro quebrou, ele se rompeu. – Emily examinava o chaveiro com todo o cuidado.
<p>- Então ele já veio assim?
<p>- Parece que sim. Onde você comprou?
<p>- Eu não comprei. Eu... Eu ganhei. – As mãos de Jason começaram a tremer. Ele sentiu que podia desmaiar a qualquer momento.
<p>- Quem te deu?
<p><i>“Que chaveiro legal”.</i> – Jason se lembrou.
<p><i>“Então pode ficar com ele, eu não gosto muito.”.</i> – Jason lembrou de Temperance dando a ele o chaveiro e sorrindo.
<p><i>“Você me dando um presente? Assim eu vou ter que te beijar para retribuir.”.</i> – Ele gostaria de ter esquecido.
<p>- Quem te deu o chaveiro, Jason? – Emily voltou a perguntar.
<p>- Temperance.</p>
<center><h4>--*--</h4></center>
<p>- Oi.
<p>Jason interrompeu a leitura silenciosa de Temperance na biblioteca.
<p>- Oi. – Temperance sorriu fechando o livro. – Tudo bem?
<p>- Tudo ótimo. – Jason não estava com cara de que estava tudo ótimo.
<p>- O que você tem? – Temperance percebeu.
<p>- É que o chaveiro que você me deu quebrou.
<p>- Chaveiro? – Temperance demorou para lembrar. – Ah, o que aconteceu?
<p>- Ele enroscou no meu armário.
<p>- Que pena.
<p>- Toma. – Jason jogou os restos do chaveiro na mesa onde Temperance estava.
<p>- O que você está fazendo? – Temperance se assustou.
<p>- Eu ainda tenho a escuta se você quiser. – Jason fechou a cara.
<p>- O quê?
<p>- Aquela escuta que o blogueiro usou para ouvir as minhas conversas.
<p>- Jason...
<p>- Era o chaveiro esse tempo todo. O seu chaveiro.
<p>- Eu não... – Temperance não conseguia terminar a frase.
<p>- Você é o blogueiro. – Os olhos de Jason começaram a arder.
<p>- Você não...
<p>- Me diz que eu estou errado.
<p>- Jason...
<p>- Me diz que te deram esse chaveiro, me diz que encontrou ele na rua, jogado no chão, qualquer coisa.
<p>- Jason... – Temperance começou a chorar.
<p>- Mente para mim. Me diz que não é você. Fala, ainda!
<p>- Eu...
<p>- Eu defendi você. – Jason a encarou e colocou força em cada palavra. – Eu acreditei em você. Achei que fosse a minha amiga.
<p>- Eu sou.
<p>- Não é não! – Jason gritou. Não importava que estava na biblioteca. – Você deve ter adorado me ver confuso e nervoso. Deve ter rido de mim sempre que eu tinha os meus acessos de raiva. O Brandon sabe?
<p>- Você não entende.
<p>- Não entendo o quê? Por que fez isso? Anda, fala! Não se contentou em ser invisível? Por que me odiou tanto? Por que me enganou? Por que fingiu gostar de mim? O que foi que eu fiz para você? – Temperance ficou quieta. – Responde! – Jason gritou de novo.
<p>Temperance tremeu na cadeira.
<p>- Me desculpa.
<p>- Desculpa? – Jason lutou contra suas lágrimas. – Você acabou com a minha vida. Você me fez de idiota sendo legal e conselheira, rindo de mim. Me deixou paranoico, você acompanhou como aquilo mexeu com a minha cabeça e o mal que me fez. Eu não... Eu nunca vou te perdoar. Eu odeio você.
<p>- Eu não queria te magoar. – Temperance tentou limpar o rosto.
<p>- Você me decepcionou. Eu sempre achei que você estaria ao meu lado, que você estava do meu lado, mas desde o começo, foi você que estava contra mim. – Jason respirou fundo, nenhuma lágrima escorreu embora elas quisessem cair. – Eu espero que você consiga tudo o que quer, também espero que fique sozinha porque é isso que você merece.
<p>- Jason... – Temperance continuava a chorar.
<p>- Para de chorar! Para de fingir que sente muito, que está arrependida. Você não sente nada disso. Você nem se importa comigo. Mas isso é bom, eu também não me importo mais com você.
<p>- Me deixa te explicar.
<p>- Cansei das suas mentiras. Só mais uma pergunta: quem você acha que é para fazer isso com as pessoas? Um ser superior?
<p>- Você não entende. – Ela repetiu.
<p>- Ah, eu entendo. Você não passa de uma garota mimada e ridícula que sente prazer em acabar com a vida dos outros. Não acredito que queria fazer uma amizade com alguém como você. – Jason pegou a escuta do bolso e jogou no chão. – Que pena, Temperance, vai ter que me espionar de outro jeito agora.
<p>Jason foi embora sem olhar para trás.
<p>- Jason, espera! Jason... – Tempe não conseguiu parar de chorar. – Você não entendeu. Jason!</p>
<center><h4>--*--</h4></center>
<p>- O que aconteceu?
<p>Brandon estava sentado em uma das mesas do pátio todo pensativo quando viu Temperance passar com muita pressa perto dele. Ele teve a impressão de a ver soluçar, então a seguiu.
<p>- Vai matar aula? – Brandon gritou quando já estavam no estacionamento.
<p>- Não quero mais ficar aqui.
<p>- Tempe, o que aconteceu?
<p>- O maldito blog aconteceu. – Temperance gritou.
<p>- O quê? Falaram de você ou...
<p>- Jason nunca mais vai falar comigo e com razão.
<p>- O que ele tem a ver com isso? – Brandon não estava entendendo nada. – Tempe, o que...
<p>- Ele acha que eu sou o blogueiro. E agora ele me odeia.
<p>- Por que ele acha isso?
<p>- Porque quando ele perguntou, eu meio que confirmei.
<p>- Por que fez isso? – Brandon ficou surpreso. – Você não é o blogueiro.
<p>- Eu não sou, mas você é. – Temperance estava muito séria. Brandon estava com medo dela explodir a qualquer momento.
<p>- Não sei do que está falando. Está ficando paranoica que nem o Jason?
<p>- Não. Hoje ele me mostrou que o chaveiro que eu dei para ele tinha uma escuta.
<p>- Escuta?
<p>- O blogueiro sempre usava as conversas do Jason contra ele, mas como? Quem contava? A gente sempre se perguntava isso.
<p>- Tempe, você não está falando nada com nada.
<p>- Você me deu aquele chaveiro na primeira semana de aula quando o blogueiro começou a falar do Jason. Você sabia, de algum jeito, que eu daria o chaveiro para ele ou que ele falaria coisas para mim.
<p>- Eu não sou o blogueiro. – Mas Temperance não acreditava mais.
<p>- Depois de tudo que passamos nessa escola, eu até entendo você querer agir desse jeito, mesmo que no anonimato. Mas você escondeu isso de mim. Você falou coisas sobre mim.
<p>- Eu não fiz por mal. – Brandon então percebeu que não adiantava mais mentir. Não tinha mais sentindo.
<p>- Fez por bem então? Você está se ouvindo? De algum jeito você se tornou um Brandon asqueroso que um dia foi o meu melhor amigo. Como isso aconteceu?
<p>- Você não ia entender se eu contasse.
<p>- Eu não ia julgar. Talvez tentaria te convencer que... Só queria que tivesse confiado em mim. – Temperance não estava triste, estava decepcionada.
<p>- Eu posso explicar. Vamos, eu posso te dizer e...
<p>- Eu não vou a lugar nenhum com você. Você julga todo mundo, se acha melhor que os outros, mas na verdade é pior que todos, porque se esconde atrás de uma droga de um computador e faz mal as pessoas.
<p>- Não é bem assim.
<p>- Sabe qual é a pior parte? Hoje, eu perdi os meus dois melhores amigos. O Jason nunca mais vai falar comigo, já você... Eu é que não quero mais olhar para a sua cara.
<p>- Tempe. – Brandon pedia perdão com o olhar.
<p>- Acabou, Brandon. Acabou.
<p>Temperance deu as costas para Brandon e saiu correndo até o portão da escola.</p>
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
            if (condicao + 1 > 20)
            {
                Navigation.PushModalAsync(new Capitulo5Page(condicao + 1));
            }
            else
            {
                Navigation.PushModalAsync(new Capitulo4Page(condicao + 1));
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