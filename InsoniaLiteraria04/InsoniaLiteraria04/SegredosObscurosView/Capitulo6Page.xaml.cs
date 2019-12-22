using InsoniaLiteraria04.Database;
using InsoniaLiteraria04.EsseMundoView;
using InsoniaLiteraria04.Global;
using InsoniaLiteraria04.Helper;
using InsoniaLiteraria04.Model;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InsoniaLiteraria04.SegredosObscurosView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Capitulo6Page : ContentPage
	{
        DBFire service;
        public int condicao;

        public Capitulo6Page (int numero)
		{
			InitializeComponent ();
            service = new DBFire();
            condicao = numero;
            mostrarCapituloSalvo("SegObscuros", "Capitulo" + numero.ToString());

            if (numero == 26)
            {
                lblTitulo.Text = "Capítulo 26 - Luto";
                htmlPage.Html = @"<html><body>
<p>Já estava anoitecendo.
<p>Jason e Emily viam o céu escurecer pela janela do quarto dela enquanto estavam deitados na cama.
<p>- Você está bem? – Emily percebeu que Jason estava um pouco inquieto. – A cama está te pinicando?
<p>- Eu só estou um pouco nervoso, ansioso.
<p>- As suas cartas vão chegar.
<p>- É. – Aquilo não fez Jason se sentir melhor.
<p>- Mas não é com isso que você está nervoso.
<p>- Eu também estou pensando no Cabeludo. – Jason estava pensando na última conversa que teve com Brandon mais cedo. – Acho que fui muito grosso com ele.
<p>- E o que você vai fazer a respeito?
<p>- Agora? Acho que nada. – Jason hesitou. – Eu preciso pensar um pouco, se eu for falar com ele agora, posso correr o risco de ser pior dessa vez do que da última.
<p>- Então relaxa, amanhã você fala com ele.
<p>- Acha que eu devo perdoá-lo? Porque eu...
<p>- O que você acha?
<p>- Eu não vou perdoá-lo, só vou... – Jason olhou indeciso para Emily. – Que se dane, amanhã quando eu o ver, vou dar um soco na cara dele, é isso que está faltando.
<p>- Cala a boca. – Ela riu.
<p>O telefone de Jason que estava em cima do criado mudo ao lado da cama de Emily começou a vibrar.
<p>- Meu telefone. – Jason se assustou e pegou o celular. – É a Lisa.
<p>Jason se levantou da cama um pouco desorientado e atendeu o telefone.
<p>- Lisa, oi.
<p><i>- Jason, você não vai acreditar.</i> – A voz de Lisa estava falhando.
<p>- O que foi? Você está chorando? Sua voz está...
<p>A expressão no rosto de Jason foi de confusão para surpresa em dois segundos.
<p>- Jason, o que foi? – Emily ficou assustada quando seu namorado largou o telefone na cama e começou a olhar para o nada. – Jason?
<p>- É o Brandon. – Ele finalmente falou depois de alguns segundos.
<p>- O que aconteceu? Ele quer falar com você?
<p>- Ele está morto. – Jason não acreditou que falou isso em voz alta.
<p>- O quê? Como assim morto?
<p>Se Emily não estivesse vendo a cara de espanto de Jason poderia jurar que era brincadeira.
<p>- Ele morreu. – Jason repetiu.</p>
<center><h4>--*--</h4></center>
<p>- Temperance! Temperance!
<p>Temperance ouvia a voz de Nathan vindo de bem longe, mesmo ele estando do seu lado. Seu celular estava no chão e agora ela nem sabia mais onde estava. As palavras “Temperance, encontramos ele caído no chão” estavam ecoando na sua mente sem parar. Não era possível. Não, ela se negava a tentar entender aquela informação.
<p>- Temperance, quem era no telefone? – Nathan insistiu.
<p>Temperance não respondeu. Ela não podia acreditar. Como assim “encontramos ele caído no chão”? Ele não morreria de uma queda de escada. E se ele ainda estivesse respirando e ninguém percebeu? Era uma brincadeira de mal gosto, só podia ser isso.
<p>- Temperance! – Nathan já estava com medo. Temperance parecia estar em uma espécie de transe. – Quem era no telefone?
<p>- Era a louca da mãe do Brandon. – Temperance respirou fundo. – Estava me passando um trote. Um bem sem graça.
<p>- Trote? Por quê? Por que ela faria isso?
<p>- Porque ela é louca, só por isso. – Ela precisava se prender a isso. Era piada. – Eu preciso ligar para o Brandon. Ouvir a voz dele.
<p>Temperance olhou por todo o chão da cozinha um pouco desnorteada até encontrar o seu celular perto do seu pé.
<p>- Temperance, está tudo bem? – Nathan sabia que Temperance estava estranha. – O que ela disse?
<p>- Ela disse um absurdo, não vale a pena nem repetir.
<p>- Temperance? – Nathan insistiu.
<p>- Ela me disse que o Brandon sofreu um acidente e morreu. Tem como ser mais ridículo que isso?
<p>- O quê?
<p>Temperance pegou o seu telefone e começou a digitar o número de telefone do Brandon no teclado.
<p>- Eu preciso falar com ele.
<p>A ligação foi para a caixa postal.
<center><h4>--*--</h4></center>
<p>Lisa não conseguiu ficar em casa. Aquelas quatro paredes estavam se fechando e ela se sentia sufocada, mas o ar não voltou quando ela saiu de lá. Aquela cidade estava estranha, as ruas não eram mais as mesmas. Lisa tentou se lembrar onde Brandon a levou no primeiro encontro. Ela não conseguiu. O que falaram quando se conheceram?
<p>“Ele te amava e você não o perdoou.”. Os pensamentos gritavam na cabeça de Lisa. “Ele te amava.”. Onde Brandon havia dito a ela que a amava pela primeira vez? Ela não se lembrava.
<p>Não era possível. Brandon não podia estar morto, ele não podia fazer isso com ela. Como? Por quê?
<p>Lisa estava pensando em ligar para Brandon, já estava até com o celular na mão quando ele tocou e era a mãe dele avisando da morte. Não fazia sentido. Lisa limpou os olhos, mas não havia nenhuma lágrima. Nem chorar ela estava conseguindo.
<p>Ela ouviu o seu celular tocar no bolso da calça, mas ela não atendeu. Seria o Jason ou a Emily ou a sua tia perguntando onde ela estava e como ela estava. O garoto que ela amava tinha acabado de morrer, como achavam que ela estava? E para piorar, ela havia brigado com ele. Brandon morreu achando que ela o odiava. Como ela viveria com aquilo?
<p>- Lisa, oi!
<p>Maddie encontrou Lisa no meio da rua.
<p>- Maddie. – Lisa não ficou animada.
<p>- Acho que o universo quer que nós sejamos amigas de novo. A gente vive se encontrando. – Maddie riu.
<p>- Interessante. – Lisa tentou se livrar de Maddie.
<p>- Olha, eu não sei se você já sabe, mas o Brandon me contou que ele é o blogueiro. Na verdade, ele contou para mim e para o meu irmão e...
<p>- Eu já sei. – Lisa queria ficar sozinha e não falar do Brandon. Maddie não estava facilitando para ela.
<p>- Ele é um idiota, não é? Eu não deveria me importar porque ele nunca falou de mim, mas ele já falou de todo mundo, e agora vem na maior cara lavada e diz que é o blogueiro só para todo mundo pegar ódio dele. Você vai perdoá-lo? Porque eu não vou.
<p>- Ele morreu. – Lisa sabia que era o único jeito de fazer ela calar a boca.
<p>- O quê? – Os olhos de Maddie ficaram cheio de lágrimas.
<p>- Ele está morto. – Ela não havia falado isso em voz alta a não ser para o Jason. Agora ela estava no meio da rua gritando que Brandon estava morto. Era estranho ouvir.
<p>- Mas como? Quando?
<p>- Olha, eu não sei. – Lisa foi grossa. – E eu não quero falar sobre isso com você. – Lisa se afastou de Maddie e foi embora.
<p>- Ai meu Deus! – Maddie começou a chorar. – Ai meu Deus.
<p>Maddie não conseguiu mais andar. Seus pés pareciam que estavam pregados no chão. Ela ficou lá parada no meio da rua, com as lágrimas escorrendo, com a mão na boca e com aquela informação que ela não podia acreditar.</p>
<center><h4>--*--</h4></center>
<p>- Lisa, você está me deixando preocupado. Quando receber essa mensagem, me liga.
<p>Esse já era o quinto recado que Jason deixava na caixa postal da amiga.
<p>- Jason, você já encheu de recados o celular da Lisa. Dá um tempo para ela. – Emily aconselhou o namorado. Ela estava sentada na cama o observando andar de um lado para o outro pelo quarto.
<p>- Acho que ela não deveria ficar sozinha. Não deve ser bom para ela.
<p>- Na verdade, ficar sozinha é o que ela precisa. – Emily pegou na mão de Jason. - Você está bem?
<p>- Melhor impossível. – Jason soltou a mão. Estava com raiva.
<p>- Jason...
<p>- Ele... ele realmente achava que eu o odiava, não é?
<p>- Isso não importa agora.
<p>- É claro que importa. Sabe, é horrível saber que uma pessoa morreu achando que você odiava ela.
<p>- Você não o odiava de verdade.
<p>- Naquele momento sim. Eu disse até que ele podia morrer, agora está tudo uma porcaria.
<p>- Não fala assim. Ele não morreu por sua causa.
<p>- Como você sabe?
<p>- Você nem sabe o que aconteceu. Ficar fazendo suposições não vai ajudar em nada.
<p>- Ele não estava doente nem nada. Ele morreu por que então? – Jason ainda não sabia qual era a causa da morte de Brandon, mas sabia que o garoto não tinha simplesmente caído morto no chão.
<p>- Eu não sei, mas você não é o culpado.
<p>- Eu não acredito. E se quando ele foi falar comigo, ele... Ele se matou, não foi?
<p>- Eu não sei. Por que você não liga para a Temperance ou para os pais dele, talvez eles...
<p>- Eu não vou ligar para ninguém.
<p>- Então o que você vai fazer? Ficar se culpando sem saber o que realmente aconteceu?
<p>- É o que eu geralmente faço.
<p>- Olha, pessoas morrem de vários jeitos. Ele pode ter sido assaltado ou... existem colapsos momentâneos que ninguém nunca conseguiu explicar. Você não sabe se... É o Brandon, ele não ia se matar.
<p>Emily estava tentando se convencer também, mas a cada palavra que ela falava, mais ela ficava na dúvida e mais aquela ideia de suicídio tomava forma. Era assustador.</p>
<center><h4>--*--</h4></center>
<p>Temperance se sentou no balanço da varanda. Sua última conversa com o Brandon foi ali.
<p>Ela tinha acabado de voltar da casa dele onde tinha exigido ver o amigo já que não acreditava que ele estava morto, mas o telefone dele ia direto para a caixa postal. A mãe de Brandon estava chorando demais, e o pai dele estava lá preenchendo os papéis para um policial que ainda estava na casa.
<p>- Eu quero ver o Bran. – Temperance chegou na casa desesperada. – Eu preciso ver o Bran.
<p>- Querida... – A mãe de Brandon tentou segura-la.
<p>- Eu preciso vê-lo. – Temperance começou a andar pela casa à procura do amigo. – Eu preciso falar com ele. Eu preciso dizer que sinto muito. – Temperance voltou para a porta chorando. – Cadê ele?
<p>- Querida.
<p>Temperance abraçou a mãe do amigo. De repente, ela percebeu que não era mentira. Brandon estava mesmo morto. Foi como perder a respiração e pisar em falso, ela quase caiu se não estivesse nos braços da mãe de Brandon.
<p>- O que aconteceu? – Temperance limpou o rosto. Ela mal conseguia falar.
<p>- Eu cheguei em casa e encontrei ele caído no chão do meu quarto. – Temperance via a mãe de Brandon se desmoronando. – As embalagens dos meus remédios estavam todas vazias. Ele...
<p>Brandon tinha se suicidado e Temperance não fez nada para impedir. Aquele vazio que ela já estava sentindo só aumentou. Ela não conseguia entender como aquilo tinha acontecido.
<p>Nathan estava esperando Temperance chegar. Ele a observava e se aproximava com um pouco de cautela.
<p>- Como foi lá? – Ele se sentou no balanço ao lado dela.
<p>- É, ele morreu mesmo. – Ela estava fria.
<p>- Você vai ficar bem? – Nathan segurou a mão de Temperance.
<p>- Ele me ligou. – Temperance ignorou a pergunta de Nathan. - Acho que um pouco antes de se matar, ele me ligou.
<p>- Então ele se matou? Como?
<p>- Eu desliguei o telefone na cara dele. – Temperance ignorou Nathan de novo. – Eu desliguei...
<p>- A culpa não foi sua.
<p>- Infelizmente nunca vamos saber, não é?
<p>- Eu sinto muito. Eu sinto muito mesmo.
<p>- Eu também. – Temperance começou a chorar.
<p>- Vai ficar tudo bem. – Nathan a abraçou. – Vai ficar tudo bem.</p>
<center><h4>--*--</h4></center>
<p>O enterro de Brandon foi bem planejado.
<p>Havia muita gente e os boatos de como aquele garoto tinha morrido corriam por todo mundo da cidade e cada história era diferente da outra. Um grupo de jovens estava comentando que Brandon foi encontrado no banheiro com os pulsos cortados, outro grupo falava que ele tinha tido um ataque cardíaco, até histórias de assaltos e de um misterioso assassino estavam rondando o cemitério naquele dia.
<p>Muitos estavam ali só para tentar descobrir a verdadeira causa da morte de Brandon, os amigos que ele não tinha mais estavam todos lá, sua popularidade havia crescido depois que todos descobriram que ele era o blogueiro e o enterro estava lotado.
<p>- Vocês não vão ao enterro? – Temperance estava indo para o enterro quando encontrou Jason e Emily na rua. Os dois estavam caminhando em direção contrária dela.
<p>Jason não havia falado com Temperance desde a morte de Brandon, não sabia como ela estava e até se surpreendeu quando ela se dirigiu a ele na rua. Achava que ela estava o odiando. Depois que as suspeitas do suicídio ficaram mais concretas, Jason se culpava ainda mais pelo ocorrido.
<p>- Eu não. – Jason resmungou. – Eu era a última pessoa que o Brandon queria ver. Na verdade, ele também era a última pessoa que eu queria ver. Não vou ser hipócrita e ir lá chorar no enterro dele como um idiota.
<p>- Eu vou dar uma passada lá depois. – Emily não queria ter que lidar com aquele povo. – Quero evitar a multidão.
<p>- Vocês ficaram sabendo? A mãe dele me disse que encontrou ele caído no chão do quarto dela. – Temperance respirou fundo. – Ele teve uma overdose de remédios.
<p>- Ai meu Deus. – Emily já esperava por um suicídio, mas não deixou de ficar chocada ao ouvir.
<p>- Engraçado, não achei que essas coisas realmente aconteciam. – Jason parecia calmo.
<p>- Ela disse que os médicos não conseguiram salva-lo porque foi encontrado tarde demais. Não tiveram nem chance.
<p>- Eu sinto muito. – Emily falou.
<p>- É. – Temperance olhou para Jason. – Cadê a Lisa?
<p>- Depois que ela me ligou falando da morte, eu não consegui mais falar com ela. Voltou tarde da noite em casa e se trancou no quarto. – Jason explicou. – Eu preferi evitar uma briga e deixei ele lá sozinha se era o que ela queria.
<p>- Eu preciso ir para o enterro. – Temperance então falou depois de um susto.
<p>- Tudo bem. – Jason concordou.
<p>Temperance se despediu, continuou o seu caminho e deixou Jason e Emily para trás.
<p>- Não vai mesmo ao enterro? – Emily sabia que Jason queria ir.
<p>- Não.
<p>- Tem certeza?
<p>- Na verdade, eu preciso beber.</p>
<center><h4>--*--</h4></center>
<p>- Achei que estaria no enterro.
<p>Kol encontrou Lisa no parque. Ele sempre saia para caminhar no parque de manhã nos finais de semana.
<p>- Você me procurou por lá? – Lisa estava sentada em um banco encarando o nada.
<p>- Eu nem fui. – Kol respondeu. – Um enterro por ano já basta.
<p>- Olha, eu quero ser chata, mas não estou em casa nem no enterro porque eu quero ficar sozinha.
<p>- O parque é público. – Kol se sentou no banco ao lado de Lisa.
<p>- Tudo bem, eu vou embora. – Lisa se levantou.
<p>- Não, Lisa, espera. Eu não quero brigar, só conversar.
<p>- Você não entende, não é?
<p>- Eu também perdi o amor da minha vida, eu sei como...
<p>- Não, você não sabe, não. – Lisa começou a chorar. – Você estava ao lado dela. Ela sabia que você a amava.
<p>- Bran também sabia que você o amava, ele entendia que a raiva...
<p>- Se você não tivesse me beijando, a gente não teria brigado e...
<p>- Lisa...
<p>- Me desculpa.
<p>- Tudo bem.
<p>- Não, não está. Eu nem sei porque eu estou falando isso. – Lisa voltou a sentar. – A culpa é toda minha.
<p>- Lisa, a culpa não foi sua.
<p>- Ele se matou, Kol.
<p>- Então os rumores...
<p>- Sim. Ele se matou ontem à tarde depois de brigar comigo. Ele com certeza achou que...
<p>- Você não teria como impedir. Você não podia adivinhar nada disso.
<p>- Você acha que não? Se a gente estivesse bem, ele nunca...
<p>- Ninguém sabia o que passava na cabeça do Bran, nem mesmo você. Ele fez uma coisa ruim e... Você não tinha o dever de perdoá-lo. Ninguém tinha. Ele deveria ter lidado com isso.
<p>- Está dizendo que ele foi fraco? É assim que você quer que eu me sinta melhor?
<p>- Não. Eu só estou dizendo que ninguém sabe de nada. Já vi histórias de pessoas que vivem ótimas vidas e mesmo assim acham que não tem nenhuma saída. Você não fez nada de errado.
<p>- Então por que eu estou me sentindo uma droga?
<p>- Porque você o amava. E perder alguém que você ama é uma droga.
<p>- Eu nunca achei que isso aconteceria. – Lisa limpou as lágrimas do rosto. – É claro que eu sabia que a gente não ia voltar, mas eu achei que quando eu fosse embora, ele ficaria aqui bem e...
<p>- Você vai embora?
<p>- Eu estava na dúvida, sentia que podia mudar de ideia a qualquer momento, mas agora é tudo o que eu mais quero.
<p>- É uma pena.
<p>- Não para mim.</p>
<center><h4>--*--</h4></center>
<p>Brandon já tinha sido enterrado.
<p>O cemitério estava vazio de novo, a não ser por uma garota, Temperance, que ainda continuava parada em frente à sua lápide.
<p>- Todo mundo já foi? – Emily se aproximou da lápide.
<p>- A mãe do Bran queria ficar, mas o marido a levou embora. – Temperance respondeu enxugando as lagrimas rapidamente.
<p>- Como ela está?
<p>- O filho dela morreu, como você quer que ela esteja? – Temperance não estava com paciência para tratar Emily bem. – Já o pai, bom, eles nunca se deram bem, com certeza ele deve ter muito arrependimento agora.
<p>- Eu sinto muito. – Emily olhou para Temperance.
<p>- Eu ouvi muito isso hoje. Agora não faz mais nem efeito.
<p>- Eu imagino.
<p>- O que faz aqui, Emily? Vocês nem conversavam.
<p>- Eu sei. Não é como se eu tivesse perdido alguém importante na minha vida, é que... É uma sensação horrível.
<p>- Agora multiplica essa sensação por mil.
<p>- Olha, você tinha razão desde o começo.
<p>- Do que você está falando? – Temperance já estava exausta. A conversa de Emily não estava fazendo muito sentido.
<p>- Eu fiz o alvoroço. Você me disse que isso não ia acabar bem. Se eu tivesse te escutado e ficado quieta, ninguém nunca descobriria.
<p>- Emily, olha...
<p>- O Jason está se culpando, você está e a Lisa provavelmente também, vocês três brigaram com ele e tudo mais, mas a culpa é minha. Eu fiz ele revelar o segredo dele. Por minha causa, todo mundo começou a odiar ele, e aí ele não aguentou e...
<p>- Se matou. – Temperance terminou a frase.
<p>- Eu não achei que... Eu só queria que ele... – Os olhos de Emily se encheram de lágrimas. – Eu só queria ajudar.
<p>- Você só atrapalhou, não foi? Do que adianta a sua culpa, Emily? Ele não vai voltar à vida por causa disso. – Temperance estava séria.
<p>- Mas eu...
<p>- Se você tivesse ficado com essa boca fechada, ele ainda estaria vivo, isso é um fato. Espero que saiba como conviver com essa culpa de agora em diante.
<p>- Temperance...
<p>- Sai daqui. Você não o matou, mas praticamente entregou os comprimidos para ele.
<p>- Eu sinto...
<p>- Sai daqui! – Temperance gritou após dar um tapa na cara de Emily. – Você matou o meu melhor amigo. Sai daqui. – Ela respirou fundo e não deixou as lágrimas caírem.
<p>Emily engoliu o choro e foi embora.
<p>Temperance respirou fundo e evitou chorar. Sua cabeça pesava muito e sua visão estava começando a ficar borrada, mais que o normal.
<p>- Engraçado, não é? – Ela ouviu uma voz familiar.
<p>- Quem está aí? – Não havia ninguém por perto no cemitério.
<p>- Como consegue deixar a Emily se culpar quando a culpa é toda sua? – Brandon apareceu na frente de Temperance.
<p>- Brandon? – Temperance não conseguia entender. – Ai, meu Deus. Você...
<p>- Eu estou morto e nós dois sabemos por que. Pelo menos, eu sei.
<p>- Bran, eu...
<p>- Todo mundo estava com raiva de mim, mas você foi a primeira a me dar as costas. – Brandon encarou Temperance.
<p>- Eu só...
<p>- Eu aguentaria que todos ficassem contra mim, menos você.
<p>- Não diz isso. – Temperance limpou as lagrimas do rosto. – Eu não dei as costas para você, eu só...
<p>- Eu liguei para você! – Brandon estava alterado. – Eu pedi a sua ajuda! E você desligou na minha cara.
<p>- Eu sinto muito.
<p>- Eu não queria me matar, Tempe. Eu só queria acabar com a dor, porque no fundo, eu tinha esperança que você chegaria lá para me salvar. – Brandon começou a chorar. – Eu fiquei te esperando. Enquanto eu estava lá, perdendo a consciência, eu gritava pela sua ajuda.
<p>- Bran...
<p>- Mas você não apareceu. Eu morri porque você não apareceu. Não culpe ninguém, Tempe. Culpe a si mesma.</p>
<center><h4>--*--</h4></center>
<p>- Eu sabia que não iria ao enterro.
<p>Lisa achou Jason sentado perto do lago. Ele parecia concentrado vendo a água passar e tomando uísque direto da garrafa.
<p>- Enterro é um saco. – Jason virou a garrafa na boca.
<p>- Eu não ia conseguir ir sem você. – Lisa se sentou ao lado de Jason.
<p>- Como me achou aqui?
<p>- Emily me contou que estaria aqui. Você não atendeu o telefone.
<p>- Bem-vinda ao meu mundo. – Jason sorriu. - Eu não achei nenhuma montanha, então o lago tem que bastar.
<p>- Bom...
<p>- A Tempe me contou que ele morreu por causa de uma overdose de remédios. Você sabia disso ontem?
<p>- Eu imaginei que tinha sido alguma coisa assim. A mãe me deu a entender isso. Eu só não te disse porque... Eu não tinha certeza e também não queria acreditar que fosse possível.
<p>- É, eu nunca pensei que essas coisas fossem reais, tipo, quem faz isso?
<p>- Isso nos deixa com outra perspectiva da vida, não é?
<p>- Eu estou com muita vontade de sumir daqui.
<p>- Eu preciso dessa bebida. – Lisa pegou a garrafa da mão de Jason e tomou um grande gole.
<p>- Sabe, eu estava aqui pensando. Será que ele ficou em dúvida?
<p>- O quê?
<p>- O Brandon. Será que na hora ele teve alguma dúvida? Ficou com medo? Ou simplesmente foi lá e fez?
<p>- Eu não sei. – Lisa ainda não tinha parado para pensar naquilo.
<p>- Ele estava triste e queria se matar. Ele devia ter me ligado.
<p>- O quê?
<p>- Ele devia ter me ligado. Eu estava com tanta raiva que eu iria lá e bateria nele até ele morrer, não precisaria dos comprimidos. – Jason estava tremendo de raiva. – Ele devia ter me ligado, eu iria...
<p>- Jason. – Lisa percebeu que Jason estava chorando.
<p>- Ele devia ter me ligado, eu iria lá e ele não... Mas por que ele ligaria para mim? Eu bati nele e disse que ele era um insignificante e que...
<p>- Para, tá bom? Isso só vai deixar a gente pior. Acha que eu também não me culpo? O tempo todo, só que isso não vai traze-lo de volta, nem apagar as coisas que falamos e fizemos.
<p>- Ele é um idiota. – Jason resmungou limpando as lágrimas. – Você me parece muito bem, achei que estaria pior.
<p>- Estou me segurando. Eu sei que se eu começar a chorar, eu não vou conseguir parar. – Lisa virou a garrafa na boca de novo. – Eu o amava, só não o bastante para impedir.
<p>- Eu acho que... Deixa para lá.
<p>Jason abraçou Lisa e os dois continuaram dividindo a garrafa de uísque enquanto os olhares deles seguiam o caminho das águas daquele rio.</p>
<center><h4>--*--</h4></center>
<p>Temperance chegou em casa com dor de cabeça.
<p>- Eu devia ter ficado com você depois do enterro. – Nathan estava esperando no quarto quando Temperance entrou.
<p>- Não, eu precisava ficar um pouco sozinha. – Temperance jogou a bolsa no chão e se sentou na cama junto com Nathan.
<p>- Você está melhor?
<p>- Foi estranho. Eu estava lá, de repente o Bran apareceu e me disse... – Temperance se calou. Ela não queria repetir para Nathan o que Brandon falou para ela. Nem para o Nathan, nem para ninguém.
<p>- Você está triste e querendo muito ver o Bran. Isso foi só coisa da sua cabeça. É normal.
<p>- Eu sei. Só acho que ele vai me perseguir para o resto da vida.
<p>- Você não podia salvá-lo. Você sabe disso, não sabe? Não pode ficar pensando nisso. Você tem que...
<p>- Eu era a melhor amiga dele.
<p>- Você tinha o direito de estar brava. Ele mentiu e te enganou.
<p>- Mas eu não queria que ele morresse. – Temperance estava cansada de chorar.
<p>- Eu sei disso.
<p>- Eu o deixei quando ele mais precisava de mim. Sabe, teve uma época em que ele era o meu único amigo. Agora eu me sinto sozinha.
<p>- Ei, você não está sozinha. – Nathan olhou bem para os olhos de Temperance. – Você tem a mim.
<p>- Mas eu quero ele de volta. Não é justo.
<p>Temperance ouviu o seu celular tocar.
<p>- Alô! – Ela atendeu.
<p>- Tempe? Me ajuda. – A voz de Brandon estava suplicando.
<p>- Bran? – As mãos de Temperance começaram a tremer.
<p>- Não desliga dessa vez, por favor. Me ajuda.
<p>- Me diz o que fazer. – Temperance entrou em desespero.
<p>- Por favor, me ajuda agora. – Brandon chorava
<p>- Temperance? Temperance? – Nate olhava para Temperance assustado.
<p>- O que foi? – Temperance tirou a atenção do celular e percebeu que Nathan estava um pouco confuso.
<p>- O que você está fazendo? – Ele pegou o celular da mão trêmula de Temperance.
<p>- O telefone tocou, era o Bran, ele está me pedindo ajuda.
<p>- O telefone não tocou, Temperance.
<p>- Mas ele está pedindo ajuda. Eu preciso... – Temperance voltou a chorar. – Eu preciso...
<p>- Calma. – Nathan segurou Temperance em seus braços. – Eu estou aqui, vai ficar tudo bem. Vai ficar tudo bem.
<p>E aquelas palavras entravam na cabeça de Temperance, mas não faziam sentido. Nathan precisava soltá-la. Brandon estava precisando de ajuda.</p>
<center><h4>--*--</h4></center>
<p>Jason nunca tinha ido a um cemitério antes nem sabia como era um de verdade. Ele sentiu a sensação ruim assim que chegou, não era um lugar muito agradável de ficar, mesmo com árvores, silencio, uma bela paisagem e um céu limpo.
<p>- Então é aqui que você vai ficar para o resto da vida? – Jason encontrou a lápide de Brandon. – Ou melhor, da morte? Parece aconchegante.
<p>Jason se agachou e ficou de frente com a lápide.
<p>- Bom, acho que merecemos uma última conversa cara a cara, quer dizer, cara a pedra. – Jason tentou rir. – Será que é errado eu ficar aqui fazendo piadas com um morto? Bom, não tão errado quanto se matar, então... Eu não deveria ter dito isso. – Jason começou a pensar. – Todo mundo passa a vida inteira pensando o que acontece depois da morte. Existe o céu? O inferno? Não vem me dizer que você se matou achando que ia para o céu brincar com os anjos? – Jason parou de falar como se estivesse esperando Brandon responder. – Você acreditava nessas coisas? Sabe o que acontece depois da morte? Nada. Você morre e só. Não é uma coisa legal de se acontecer. Sabe, você é um covarde, as coisas ficam ruins e você resolve se matar, assim fica fácil, não é? Você se achava inteligente e melhor que todo mundo, mas a verdade é que você é um fraco, e talvez morrer foi a melhor coisa para você, porque a vida não pega leve com os fracos.
<p>- Está se sentindo melhor depois desse discurso? – Emily estava atrás de Jason.
<p>- Não se pode assustar uma pessoa no cemitério, sabia? – Jason fingiu ter tido um ataque cardíaco.
<p>- Você merece. – Emily parecia brava. – Eu liguei um milhão de vezes para você.
<p>- Depois que eu deixei a Lisa em casa, me deu uma vontade de vir aqui.
<p>- Eu sabia que te encontraria aqui.
<p>- Lógico, você é a minha alma gêmea.
<p>- Exatamente por isso. – Emily se agachou ao lado de Jason.
<p>- Acho que eu precisava disso. Sabe, eu não entendo. Como alguém entra tanto na escuridão a ponto de querer se matar? Ele só tinha dezoito anos, tinha a vida toda pela frente, e agora eu estou falando que nem aqueles psicólogos chatos de palestras anti-suicídio.
<p>- Bom, cada um tem o seu ponto de desespero. Nem todo mundo é tão forte.
<p>- É difícil aceitar. E agora ele morreu e me deixou cheio de dúvidas.
<p>- Dúvidas?
<p>- Ele acabou comigo no blog, mas me deixou ir morar na casa dele, me ajudou a te conquistar e era meu amigo. Talvez ele tivesse dupla personalidade.
<p>- Ou talvez ele só fez uma escolha errada.
<p>- Eu não vou sentir a menor falta do blogueiro. Morreu tarde.
<p>- Jason...
<p>- Mas eu queria o meu amigo de volta.
<p>- Eu sei.
<p>Emily percebeu que Jason tinha algumas lágrimas nos olhos.
<p>- Ele se importava com você.
<p>- Como sabe?
<p>- O único motivo dele ter escondido por tanto tempo é que ele não queria perder a sua amizade.
<p>- Eu disse que ele podia morrer, que eu não ligaria. Eu não falei sério. – Jason limpou as lágrimas antes delas caírem.
<p>- Pensa pelo lado positivo.
<p>- Qual?
<p>- Ele pelo menos te conheceu de verdade.
<p>- Diz como se fosse uma coisa boa.
<p>- Não fala assim. – Emily sorriu.
<p>- Sabe, meu pai sempre dizia que eu era um inútil. Ele tem razão.
<p>- Por quê? – Emily não entendeu.
<p>- Eu nem consegui salvá-lo. Ele precisava de uma pessoa só e eu... Eu não estava lá.
<p>- Você não é completamente inútil.
<p>- Ah é?
<p>- É. – Emily tentou fazer Jason rir. – Você me salvou.
<p>- Quando?
<p>- Quando eu achei que não tinha mais nada para mim, você apareceu naquela praça. Você me salvou naquele dia.
<p>- Não dá para salvar todo mundo, não é?
<p>- Não dá, não.</p>
</body></html>";
            }

            if (numero == 27)
            {
                lblTitulo.Text = "Capítulo 27 - Decisão";
                htmlPage.Html = @"<html><body>
<p>Jason estava na sala de aconselhamento do colégio. Uma mulher que ele nunca tinha visto na vida estava sentada de frente a ele.</p>
<p>- Por que eu estou aqui mesmo?
<p>- Bom, depois dos acontecimentos recentes...
<p>- O suicido do Brandon. – Jason falou logo.
<p>- Exatamente. A direção da escola decidiu que os alunos precisam conversar com um profissional. – A voz dela era calma e serena. Nem parecia de verdade.
<p>- Você é do manicômio? – Jason deu um sorriso sarcástico.
<p>- Não, eu sou uma psicóloga. Doutora Ellen.
<p>- Se eu não responder o que você quer, eu vou acabar preso em algum sanatório? Porque os meus pais ficariam muito felizes com isso.
<p>- Não. Eu estou aqui para conversar e ajudar vocês a passar pelo luto. – A psicóloga estava bem calma.
<p>- Eu passei duas semanas de luto, eu não quero me sentar aqui e reviver tudo. Olha, eu já li sobre isso, as fases do luto e a droga toda. – Jason estava quase se deitando na cadeira e usava seu tom de deboche como sempre. - Eu já passei da fase de negação, na verdade, eu nem neguei, quando falaram que ele estava morto, eu pensei “morreu, que pena”, aí eu fui direto para raiva, e aí eu aceitei. Eu não preciso estar aqui, está perdendo tempo comigo, tem muita gente com depressão lá fora. – Jason se levantou da cadeira.
<p>- Ainda temos meia hora. – A psicóloga fez um gesto com a mão para Jason voltar a sentar e ele se sentou.
<p>- O que você quer que eu diga? Não vou chorar por alguém que acabou comigo.
<p>- Bom, diz aqui que vocês eram amigos. – A doutora pegou a ficha de Jason.
<p>- Nosso relacionamento verdadeiro não está escrito em um papel. Não era uma amizade.
<p>- Me explique então.
<p>- Tipo, éramos amigos, mesmo ele achando que eu era a pior pessoa do mundo.
<p>- Agora eu já entendi a raiva.
<p>- Tudo bem, ele não é o único culpado. Desde que eu cheguei aqui, eu o chamo de apelidos que são muito criativos, mas pode ser que ele tenha se ofendido.
<p>- Que tipo de apelido?
<p>- Cabelo de Macaco... Ah, não, eu ainda não tinha chamado ele assim, mas já estava na lista.
<p>- E por que usava os apelidos?
<p>- Ah, eu estava tentando ser engraçado, eu era novo na escola e queria quebrar o gelo, apelidos traz intimidade. Tudo bem, eu queria irritar, porque a cara dele me dava sono, mas mesmo assim...
<p>- Sente saudades?
<p>- Olha, para falar a verdade, eu sinto sim. Agora fica um monte de apelidos entalados na garganta e eu não tenho para quem dizer porque eu nunca vou encontrar outra pessoa com um cabelo daquele.
<p>- O que vai fazer depois da formatura?
<p>- Nossa, que mudança de assunto. Eu vou curtir as minhas férias. – Jason não conseguia ficar sério.
<p>- Depois das férias?
<p>- Bom, a minha namorada vai para Nova York, então eu me inscrevi em todas as faculdades mais próximas dela.
<p>- Já foi aprovado em alguma?
<p>- Ainda não, mas eu estou esperando as cartas, o correio daqui é uma droga.
<p>- E ir para Nova York é o seu sonho?
<p>- Bom, até uns meses atrás, eu não tinha sonho, minha ideia era ficar por aqui mesmo, cavalgar um pouco, estrelar o remake de Dallas... sei lá, agora ela me deu um propósito.
<p>- Você a ama?
<p>- Sim, foi difícil admitir, mas sim. Ela consegue que eu mostre o melhor de mim, se é que eu tenho algo melhor.
<p>- O que vai acontecer se você não for aceito em nenhuma faculdade e não poder ir para Nova York com ela?
<p>- Ah, eu não sei. – Jason não esperava por aquela pergunta. – Mas eu não vou me matar se é o que está pensando. Tudo bem, isso foi meio insensível.
<p>- Tudo bem, estamos chegando a algum lugar.
<p>- Olha, eu não sou muito bom em me expressar e eu não vou me abrir com alguém que eu mal conheço.
<p>- Eu quero te ajudar.
<p>- Olha, eu não preciso de ajuda. Daqui a duas semanas, eu vou me formar, vou sair daqui, vou para Nova York com a minha namorada, e o Cachinhos no Céu vai ser só uma lembrança. Eu estou bem. – Jason se levantou de novo.
<p>- Ainda falta vinte minutos.
<p>- Vai ficar faltando.
<p>- Jason.
<p>- Olha, eu não estava com vontade de me matar, mas agora eu estou. Você é péssima. Se formou aonde?
<p>Ellen não agiu, ficou olhando Jason sair revoltado da sala.</p>
<center><h4>--*--</h4></center>
<p>- Bom, eu nunca falei com uma psicóloga antes.
<p>Lisa se sentou nervosa logo após entrar na sala da doutora Ellen.
<p>- Fique calma, me trate como sua amiga.
<p>- Amiga? – Lisa achou estranho. – Estranho, mas tudo bem.
<p>- Vamos começar então. – Ellen pegou a ficha de Lisa. – Você era a namorada do Brandon.
<p>- Ex-namorada. – Lisa a corrigiu.
<p>- Terminaram por causa do blog?
<p>- Na verdade, foi antes. Ele foi um ridículo. Quando eu descobri do blog, a gente já estava brigado.
<p>- Você está bem?
<p>- Estou ótima.
<p>- Não parece.
<p>A doutora analisou Lisa e percebeu que ela estava longe de estar bem. Seus olhos estavam inchados, ela com certeza ainda estava chorando com frequência, havia olheiras bem fundas causadas pela falta de dormir e a sua maquiagem quase não existia.
<p>- Então por que perguntou? – Lisa fechou a cara. – O cara que eu amava se matou. Queria que eu estivesse comemorando?
<p>- Se o amava, por que terminaram?
<p>- Porque sim. Eu não vou falar sobre isso com você.
<p>- Quer falar sobre o que então? Sobre o futuro?
<p>- Eu vou voltar para Los Angeles depois da formatura, o lugar de que eu nunca deveria ter saído.
<p>- Por que não quer ficar aqui?
<p>- Deve ser pelo fato de que meu melhor e único amigo vai para Nova York e eu vou ficar aqui sozinha.
<p>- Por que ele é o seu único amigo?
<p>- Ah, deve ser porque eu não tenho outros. – Lisa estava agressiva, ela não era assim.
<p>- Fazer amigos é difícil aqui?
<p>- Pode-se dizer que sim.
<p>- Por quê?
<p>- Eu nem imagino. Eu até tentei, mas aí eu fiz amizade com uma garota que tentou me bater depois, o irmão dela parecia até mais amigável, até fomos ao cinema, mas ele é tão sem noção que me beijou, aí tinha a melhor amiga do meu namorado que me odiava sei lá por que. A única que eu consigo conversar sem problema é a Emily, mas ela também vai embora.
<p>- Em Los Angeles você tinha muitos amigos?
<p>- Eu tinha muitos colegas, nunca ficava sozinha. Sinto falta disso, eu odeio ficar sozinha.
<p>- Mas eu ainda não vi entusiasmo vindo de você para voltar para casa.
<p>- Sabe, eu decidi ir embora quando eu terminei com o Brandon e percebi que era sério. Mas mesmo separados, uma parte de mim ainda queria voltar. Eu tinha essa ideia de que eu estaria no aeroporto, e que nem nos filmes, ele viria correndo me impedir de embora dizendo que estava arrependido. Droga, eu sou mesmo uma garotinha.
<p>- Não tem nada de errado nisso.
<p>- É, só que agora não vai ter ninguém no aeroporto me pedindo para ficar.
<p>- O que vai fazer então?
<p>- Eu preciso seguir em frente. Ele ia querer isso, na verdade ele era um egoísta e não ia querer que eu seguisse em frente, mas eu preciso.
<p>- Ele amava você?
<p>- Bom, eu acho que sim. Ele era um mentiroso, mas ele não mentiu sobre isso, pelo menos eu acho que não.
<p>- Se acha que voltar para casa vai te ajudar, então é o melhor mesmo.
<p>- Como se a sua opinião fosse importar para mim.</p>
<center><h4>--*--</h4></center>
<p>- Você já foi a psicóloga da escola? – Jason se encontrou com Emily no corredor da escola em frente ao armário dela.
<p>- Ainda não, o meu horário é para amanhã, por quê?
<p>- Porque ela me deixou louco.
<p>- Ela não fez o trabalho direito então. – Emily riu.
<p>- Olha só, Ems, o que vai acontecer se eu não for aceito na faculdade?
<p>- Do que está falando?
<p>- Só temos duas semanas e temos dezoito anos. Não deveríamos viver como se fosse o nosso último dia de vida?
<p>- É, eu achei que era brincadeira ou exagero seu, mas a psicóloga deixou você louco mesmo. – Emily olhou para Jason meio confusa.
<p>- Não, quer dizer, olha só para o Brandon, o último dia de vida dele foi horrível.
<p>- Por isso que ele se matou.
<p>- Não, mas e antes? Aposto que ele morreu virgem.
<p>- E por que isso interessa a gente?
<p>- Eu não sei, sabe, é que... Você não sente essa vontade de viver ao extremo?
<p>- Jason, eu sei que a morte do Brandon mexeu com você, mas você não está falando coisa com coisa.
<p>- Se eu morrer amanhã, muitas coisas que eu gostaria de ter feito, eu não fiz.
<p>- Por exemplo...
<p>- Pular de Bungee jumping...
<p>- Podemos fazer isso.
<p>- Fazer sexo em uma sala de aula vazia.
<p>- Não podemos fazer isso. – Emily olhou com cara de reprovação.
<p>- Não custava tentar.
<p>- Olha, para com esse papo, temos todo tempo do mundo.
<p>- O Brandon também achava que tinha.
<p>- É diferente. Não é como se ele estivesse fazendo planos e de repente, um meteoro caiu na cabeça dele.
<p>- Eu amo você. – Jason sentiu uma vontade de dizer isso.
<p>- Eu sei disso. Agora vamos para aula. Você está me assustando.
<p>- E se eu não for aceito na faculdade?
<p>- Vamos pensar nisso se realmente acontecer. Não adianta se preocupar à toa.
<p>- Sim, senhora.</p>
<center><h4>--*--</h4></center>
<p>- Essa é a sua segunda perda? – A doutora Ellen estava avaliando a ficha de Kol.
<p>- Mais ou menos. Minha namorada morreu o ano passado, mas o Brandon não era tão meu amigo assim. – Kol ainda não sabia o que estava fazendo naquela sala.
<p>- Quer dizer que a morte dele não te afetou?
<p>- Também não é assim, eu não sou insensível. Éramos colegas de escola, é claro que eu fiquei chateado, mas se ele escolheu se matar, quem sou eu para contestar?
<p>- O que sentiu quando a sua namorada morreu?
<p>- Achei que estávamos aqui para falar da morte do Brandon.
<p>- Estamos aqui para falar de perdas e você sofreu uma perda.
<p>- Ela era o amor da minha vida, íamos nos casar, ela morreu, final trágico. Mas eu já superei. – Kol estava nervoso. Não queria dizer o que não devia.
<p>- Como?
<p>- Bom, voltando para casa. Eu fui embora para longe para esquecer, aí eu voltei, são e salvo.
<p>- E quanto aos seus amigos?
<p>- Afastei todos depois da morte da Andressa.
<p>- Isso é superar?
<p>- Eu me apaixonei de novo, tá bom? Só que não deu certo.
<p>- Outra desilusão amorosa.
<p>- É, talvez o amor não seja para mim. – Kol estava se cansando de conversar.
<p>- Ou você está se auto sabotando.
<p>- Como assim?
<p>- Por que não deu certo dessa vez?
<p>- Ela tinha um namorado. Ela foi legal comigo e aí eu pensei... O importante é que eu estraguei tudo.
<p>- E agora vai se fechar de novo?
<p>- Eu não quero ficar sozinho para o resto da vida se é o que você está pensando. – Kol encarou a psicóloga.
<p>- Ninguém quer isso, Kol, mas se você não superar, as coisas vão ficar difíceis. Olhe ao seu redor, o mundo é lindo lá fora. Eu não estou falando para você sair e se apaixonar agora, mas você pode se divertir.
<p>- Eu não sei, eu sempre achei que me divertir seria um desrespeito a ela.
<p>- Se ela te amava como você diz que amava, desrespeito seria se trancar para o mundo e ficar vendo a vida passar. Você é jovem e está vivo, então viva.</p>
<center><h4>--*--</h4></center>
<p>Jason estava na biblioteca. Suas provas já tinham acabado e ele não precisava mais fazer nenhum trabalho, mas ficar ali, mesmo parecendo estranho, deixava ele mais calmo.
<p>- Jason, oi. – Nathan se sentou perto de Jason.
<p>- Nathan, oi. Você podia se levantar? Eu estou esperando a minha namorada.
<p>- Vai ser bem rápido.
<p>- Olha, é mentira, a Emily não vai chegar. Eu só não quero falar com você.
<p>- A gente não se fala há um tempo.
<p>- É, eu também senti saudade, pode ir agora?
<p>- É sobre a Temperance.
<p>- Olha, ela não quer falar comigo. Eu já liguei um milhão de vezes e ela não atendeu. – Mas Jason não estava nervoso com isso.
<p>- Você sabe por...
<p>- Talvez seja porque o amigo dela me odiava, e aí ele morreu depois de eu mandar ele fazer isso, mas é só um palpite.
<p>- Ela não está bem. – Nathan parecia mesmo preocupado.
<p>- Ela está triste, eu entendo. É normal.
<p>- Não, é mais do que isso. Ela está um pouco perturbada e eu não sei o que dizer ou o que fazer.
<p>- E você acha que eu sei? – Jason ficou confuso.
<p>- Você a conhece mais do que eu, e depois do Bran, você é o único amigo que ela tem. Vai me dizer que não se importa mais com ela?
<p>- É claro que eu me importo com a Tempe. É que... Encará-la vai ser uma droga. Eu não estou a fim de confronto nesse momento.
<p>- Eu só preciso de uma ajuda. Eu não pediria se eu não achasse que fosse sério.
<p>- Tá, tudo bem. Vou ver o que eu posso fazer.
<p>- Ótimo. Muito obrigado.
<p>- Disponha.</p>
<center><h4>--*--</h4></center>
<p>- Você é a irmã do Kol?
<p>- Exatamente.
<p>Maddie estava inquieta sentada naquela cadeira. A psicóloga ficava encarando e ela não gostava disso.
<p>- Bom, vocês são gêmeos?
<p>- Ah, não. Ele foi reprovado um ano.
<p>- Ah entendi. Vocês são unidos?
<p>- Muito.
<p>- Que bom.
<p>- É. – Maddie estava nervosa.
<p>- Olha, eu sei que é difícil encarar a sua dor e a dor dele ao mesmo tempo.
<p>- A Andressa era a minha melhor amiga, é claro que eu sofri.
<p>- E quanto ao Brandon?
<p>- Eu o conhecia desde criança, não éramos íntimos nem nada do tipo, mas a gente se conhecia.
<p>- A morte dele te afetou de que jeito?
<p>- Bom, me veio um arrependimento.
<p>- Arrependimento? – Ellen não entendeu.
<p>- É, quer dizer, a nossa amizade poderia ter sido melhor, mas eu não fiz questão e nem ele, mas se nós fossemos amigos mesmo, talvez ele teria conversado comigo e eu poderia ter convencido ele que a vida ainda é boa.
<p>- Sabe que não é culpa sua, não sabe?
<p>- A única coisa que eu sei é que não foi culpa dele. Ele não escolheu se matar só porque acordou de mal humor, quem faz isso? Mas ele precisava ouvir alguma coisa e aquilo faria a diferença.
<p>- Mas vocês não eram próximos, então por que se preocupa com isso?
<p>- Porque eu falo demais o tempo todo, aí quando precisam mesmo ouvir algo, eu fico sem saber o que dizer e me calo. Quando o Bran me disse que era o blogueiro, eu não disse nada, só coisas ruins. Naquela hora, ele precisa ouvir alguma coisa, pelo menos um “tudo bem”, “relaxa”, “vai passar”, mas eu fiquei olhando para a cara dele como se ele fosse a pior pessoa do mundo.
<p>- Mas naquela hora para você, ele era?
<p>- Não, eu só fiquei em choque. Eu percebi que podia ter ajudado, mas já era tarde demais.
<p>- Você não ajudou o Brandon, mas pode ajudar outras pessoas. Você ajudou o seu irmão.
<p>- Você acha mesmo que eu ajudei o meu irmão?
<p>- Bom, ele entrou em uma depressão depois da morte da namorada, ele podia ter feito o pior, mas você disse as palavras certas para ele e você o apoiou.
<p>- Eu me senti bem com isso, em ajudar o meu irmão.
<p>- Que bom. – Ellen sorriu para Maddie.</p>
<center><h4>--*--</h4></center>
<p>- O que faz aqui? – Temperance viu Jason chegando pela varanda da casa dela.
<p>- Bom, você não me atende, achei melhor vir pessoalmente. – Jason se sentou ao lado de Temperance no balanço. – Além do mais, eu nunca perco uma oportunidade de matar aula.
<p>- Eu estou bem.
<p>- Não foi isso que eu ouvi dizer.
<p>- Meu melhor amigo morreu, me desculpe eu não estar rindo à toa. – Temperance estava com a cara fechada.
<p>- Podia ter me ligado, me mandado mensagem, qualquer coisa.
<p>- Foi mal, mas você é a última pessoa que eu quero ver.
<p>- Por quê? Por que eu sou aquele que disse que ele podia morrer e minutos depois ele morreu? Talvez eu seja profeta ou hipnótico. Será que Deus está se comunicando através de mim?
<p>- Quer calar a boca?
<p>- Me responde então.
<p>- Você é o meu único amigo agora. – Os olhos de Temperance se encheram de lágrimas.
<p>- Tempe...
<p>- E eu estou com medo de dizer alguma coisa idiota e fazer você morrer também.
<p>- Eu nunca me mataria. Eu sei que o mundo não vai sobreviver sem eu nele. – Jason sorriu para a amiga, mas ela não demonstrou nenhuma reação. – Ei, a culpa não foi sua. Todos nós falamos coisas que não foram legais.
<p>- Mas só eu tenho pesadelos agora.
<p>- Vamos superar isso. Eu sei que vamos.
<p>- Como? Ele não vai mais voltar, Jason. E essa dor dentro de mim não vai sumir.
<p>- Você vai superar. – Jason repetiu.
<p>- Não vou, não. Isso só fica maior, a dor, a culpa, a saudade, só aumenta.
<p>- Não acredito que eu vou dizer isso, mas... Já falou com a psicóloga da escola? Pode ser bom para você.
<p>- Eu não vou falar com ela.
<p>- Então me diz o que eu posso fazer para te ajudar.
<p>- Só vai embora.
<p>- Se é o que você quer...
<p>- É o que eu quero.
<p>Jason não sabia mais o que dizer. Temperance não estava mais olhando para ele, estava encarando o nada. Ela limpou as lágrimas e continuou calada até Jason se levantar do balanço.
<p>- Eu vou estar aqui se quiser conversar. Se quiser gritar com alguém, é só me chamar. Se sentir vontade de chorar, eu compro o lenço no caminho.
<p>Jason ficou esperando Temperance responder, mas ela continuou calada.
<p>- A gente se vê, Tempe.</p>
<center><h4>--*--</h4></center>
<p>- E como ela está?
<p>Jason estava contando para Emily sua conversa com Temperance enquanto os dois caminhavam até a sala de aula.
<p>- Mal. Eu não sei o que fazer para ajudar.
<p>- Eu não sei, talvez ela só precise de um tempo. – Emily sugeriu.
<p>- Ou esperar só piore a situação dela. Ela não quer falar nem fazer outra coisa. Nathan disse que ela fica parada e olhando para o nada o tempo todo e às vezes surta dizendo que está vendo o Brandon em todos os lugares.
<p>- Isso não é saudável.
<p>- Nem um pouco.
<p>Os dois pararam no meio do corredor.
<p>- O que é isso?
<p>Jason viu um grupo grande de alunos olhando em direção aos armários. Em frente um deles, o armário que era do Brandon, havia algumas velas acesas, flores, ursos de pelúcia, cartazes de “sentimos sua falta” pregados na porta do armário, alguns bilhetes também.
<p>- É sério isso?
<p>- Jason, não. – Emily falou baixinho quando viu Jason indo em direção ao memorial.
<p>- É sério isso? Quem teve essa ideia? – Jason falou alto na frente de todo mundo que parecia estar prestando condolências ao memorial. – Engraçado, não é? Meses atrás ninguém nem olhava para o Brandon, muitos aqui já trataram ele mal ou falou mal dele e agora estão todos chorando dizendo que sentem a falta dele? Vocês gostam mesmo de passar essa vergonha?
<p>Todo mundo começou a olhar para Jason e comentar baixinho entre eles.
<p>- É, eu briguei com o Brandon algumas vezes, mas não estou aqui bancando o bom moço fazendo essa palhaçada. Quem aqui riu e falou mal dele quando descobriu que ele era o blogueiro? Ele falou mal de todos vocês aqui e agora estão “chorando” por ele? Vocês são ridículos.
<p>Jason olhou para o memorial e então o chutou. Foi vela e flor para todo lado. Todo mundo olhou para ele horrorizado.
<p>- É isso que ele merece. E vocês deveriam fingir menos.
<p>- Jason!
<p>Os alunos abriram passagem no corredor para o diretor passar.
<p>- Esse memorial é propriedade da escola. Você não deveria ter feito isso. Você... – O diretor estava um pouco nervoso.
<p>- É sério, diretor? O que vai fazer? Me suspender? Acho que eu não tenho mais tanta aula para perder agora. – Jason o enfrentou.
<p>- Eu permiti esse memorial para que os alunos...
<p>- O quê? Sofressem a morte dele? Ou para ele servir de exemplo?
<p>- Jason...
<p>- Eu sabia que essa merda ia acontecer. Eu avisei para você. Eu avisei que essa droga de blog ia ferrar com tudo, mas você resolveu me ignorar e fingir que não estava acontecendo nada.
<p>- Jason...
<p>- Um memorial não vai apagar isso, diretor. Afinal não era o seu dever colocar ordem na sua escola, não foi isso que você me disse?
<p>- Está suspenso por dois dias. – O diretor continuou sério.
<p>- Mas que ótimo.
<p>Jason deu as costas para ele e saiu pelo corredor dando passos firmes. </p>
<center><h4>--*--</h4></center>
<p>- Então Emily, vamos falar sobre você. – Ellen parecia animada.
<p>- Falar sobre mim? Nossa, eu não esperava por isso. – Emily estava desconfortável naquela sala.
<p>- Bom, você me parece feliz.
<p>- Ah, e eu estou. Eu sei que parece insensível, mas daqui a duas semanas, eu vou sair desse inferno. Eu tenho que comemorar.
<p>- Sua experiência na escola foi ruim?
<p>- Nem um pouco. Na verdade, eu tenho várias lembranças boas. Como quando as garotas me ameaçavam no banheiro. – Emily estava sendo irônica.
<p>- O que aconteceu com essas garotas?
<p>- O blogueiro expulsou elas, depois eu meio que provoquei a morte dele. Quem disse que eu não sei agradecer as pessoas?
<p>- Tudo bem ficar triste.
<p>- Eu passei por um inferno durante anos, eu não podia falar para os meus pais. Eu apanhava, e quando eu não apanhava, eu era ameaçada, todo mundo ficava bem longe de mim, então imagina como foi bom fazer trabalhos em grupo sozinha.
<p>- Emily...
<p>- Enquanto aquelas garotas mexiam com a minha cabeça, chegou uma hora que eu prometi a mim mesma que eu não seria mais fraca, que eu não ia mais chorar por nada. Mas aí uma pessoa que eu conhecia morreu, e aí a Emily não tão forte apareceu de novo.
<p>- E qual é o problema dela?
<p>- Ela é uma droga. Só que a Emily forte voltou depois de um tempo. Essa Emily vai se formar, vai embora dessa cidade e não vai olhar para trás. A morte do Bran foi horrível, mas eu já segui em frente.
<p>- E isso é certo?
<p>- Desculpa, eu não entendi. – Emily encarou a psicóloga.
<p>- Não se considera egoísta por estar bem?
<p>- Chorar não vai fazer ele voltar, e mesmo que ele voltasse, não éramos muito chegados. Eu expus ele, aí todo mundo começou a odiar ele, aí ele se matou. Na verdade, ele é um fraco, não suportou um dia. – Emily quase riu.
<p>- Como você conseguiu suportar?
<p>- Eu via uma saída. Eu sabia que aquelas idiotas ficariam nessa droga de cidade para sempre e eu não. Ele não viu isso. Ele não viu que a vida poderia ser maravilhosa.
<p>- Qual é o seu futuro, Emily?
<p>- Eu vou para Nova York, eu consegui um estágio, e se der tudo certo, eu posso criar uma carreira e ser uma grande empresária.
<p>- Parece brilhante.
<p>- Mas eu nunca vou seguir em frente, não é? – Emily caiu na real. - A morte do Bran sempre vai me tocar de alguma forma.
<p>- Não tem nada de errado em sentir. É bom.
<p>- Mas eu sinto, eu não sou uma pedra de gelo. Eu tenho um namorado e o amo. Tem sido maravilhoso. E eu estou feliz pela primeira vez na vida.
<p>- Mas do mesmo jeito que você sente a felicidade, você tem que se permitir sentir a tristeza também, senão isso vai ficar guardado dentro de você e em alguma hora isso vai explodir e como toda explosão, isso vai te destruir.
<p>- Nada mais pode me destruir.</p>
<center><h4>--*--</h4></center>
<p>- O que está fazendo? – Lisa entrou no quarto de Jason e o encontrou sentado na cama encarando um monte de cartas jogadas no colchão.
<p>- As cartas das faculdades chegaram. – Jason parecia nervoso.
<p>- E...
<p>- E eu não abri nenhuma.
<p>- O que você está esperando? – Lisa se sentou ao lado de Jason.
<p>- E se eu não passar em nenhuma?
<p>- Isso não vai acontecer. Suas notas melhoraram e as faculdades valorizam isso.
<p>- Vai ser um desastre. Eu tenho advertências, expulsões e suspensões no meu histórico. Ganhei mais uma hoje.
<p>- O quê? Como? Por quê?
<p>- Não interessa agora.
<p>- Abre logo essas cartas, só comece a se preocupar quando existir uma preocupação de verdade.
<p>- Para você é fácil falar, sua carta de Stanford já chegou.
<p>- E eu fui aceita. – Lisa sorriu.
<p>- E isso é novidade?
<p>- Para de enrolar e comece a abrir essas cartas.
<p>Jason pegou a primeira carta. Era da Faculdade da Pensilvânia.
<p>- O que diz? – Lisa estava ansiosa. Jason estava lendo a carta.
<p>- As minhas notas não são o suficiente para ser qualificado. Eu fui recusado. – Jason amassou a carta e jogou no chão.
<p>- Ainda tem mais. – Lisa pegou outra carta sendo positiva.
<p>Jason pegou a carta da Faculdade de Yale em Connecticut.
<p>- Eu não tenho cursos extracurriculares o suficiente. O que são cursos extracurriculares? – Jason não acreditava que tinha sido reprovado de novo.
<p>- Eu disse para você entrar no Clube de Debate.
<p>- Eu preferia morrer a entrar naquilo. – Jason já estava ficando preocupado.
<p>- Abre a outra.
<p>Jason já estava tremendo quando abriu a carta de Princeton de Nova Jersey.
<p>- Eu estou na lista de espera. – Ele não parecia animado.
<p>- Isso é bom, não é?
<p>- Claro, se trezentas e sessenta e sete pessoas desistirem de estudar em Princeton, eu entro. – Jason amassou a carta.
<p>- Pensa positivo. E se ocorrer um furacão ou terremoto e matar todas essas pessoas? – Lisa já estava mais nervosa que o Jason.
<p>- Aí eu vou me assustar.
<p>Havia só mais uma carta jogada na cama. Jason sabia que carta era aquela. Era de Columbia em Nova York. Enquanto abria a carta para ler, Jason começou a pensar que se ele fosse aceito naquela faculdade nada mais importava, na verdade seria até o ideal. Poderia viver com a Emily ou pelo menos próximo dela, os dois estariam no mesmo estado, na mesma cidade. Com certeza era um sinal, ele tinha que ser aceito.
<p>- Eu não acredito. – Jason leu a carta duas vezes.
<p>- Então? – Lisa encarava Jason. Seu coração estava batendo muito forte.
<p>- Eles não aceitam alunos que possuem processos criminais na ficha para evitar desconforto com a Associação.
<p>Jason fechou os olhos e colocou as mãos na cabeça. Lisa ficou preocupada olhando o amigo, ele poderia ter um treco a qualquer minuto.
<p>- Jason...
<p>- Eu sou uma droga! – Jason começou a rasgar as cartas.
<p>- Jason, calma. – Lisa tentou fazer Jason se acalmar segurando as mãos dele.
<p>- Você não entende? Eu não sirvo para nada!
<p>- Não é verdade. Existes milhares de faculdades pelo país, você pode se inscrever...
<p>- Para ser recusado por todas elas?
<p>- Jason, isso não vai acontecer.
<p>- Vai sim, Lisa. Porque eu não sou inteligente o suficiente, eu não tenho talento algum e ainda tenho uma ficha criminal. Que faculdade vai me aceitar assim? Eu que deveria me jogar de um precipício agora.
<p>- Isso não tem graça.
<p>- Desculpa, cedo demais.
<p>- Olha, a gente pode esperar, trabalhar melhor no seu currículo e o ano que vem...
<p>- Não. Não vai adiantar.
<p>- O que vai fazer então?
<p>- Olhar nos olhos da Emily e dizer que o namorado dela é um fracassado.
<p>- Jason. – Lisa percebeu que o amigo estava mal.
<p>- Eu não acredito nisso.
<p>- Vai ficar tudo bem. Eu sei que vai. – Lisa abraçou Jason enquanto ele ainda encarava as cartas rasgadas em cima da cama.</p>
<center><h4>--*--</h4></center>
<p>Temperance se sentou na grama ao lado da lápide de Brandon.
<p>- Você devia estar conversando com a psicóloga da escola agora. – Temperance ouviu a voz de Brandon perto dela.
<p>- Eu não estou a fim de falar sobre isso com alguém. Aquela mulher só vai piorar as coisas.
<p>- Então prefere ficar aqui no cemitério conversando com o seu amigo morto? – Brandon se sentou ao lado de Temperance e começou a encará-la.
<p>- É melhor do que ficar em casa sozinha.
<p>- Tempe, você não está sozinha. Você tem o Jason, o Nate.
<p>- É, e sempre que eu estou perto deles só me sinto pior. – Temperance começou a mexer na grama inquieta.
<p>- Pior? Por quê?
<p>- Porque eles são gentis e piedosos comigo e eu odeio isso.
<p>- Eles sabem que você está sofrendo e querem te ajudar a melhorar.
<p>- Eu não quero melhorar! – Temperance gritou. – Eu não mereço melhorar.
<p>- Não vamos começar com esse papo de novo.
<p>- Não, Bran, o papo sempre vai ser esse. Eu te abandonei. Você está aqui por minha causa e...
<p>- É por isso que você está aqui? Por que acha que precisa me fazer companhia?
<p>- Eu...
<p>- Eu não preciso mais de você, Tempe. Eu estou bem.
<p>- Você está morto, não pode estar bem. – Temperance limpou os olhos.
<p>- Ficar aqui não vai me ressuscitar, a não ser que você comece com aqueles rituais satânicos.
<p>- Eu sinto a sua falta.
<p>- Eu também sinto. É uma droga, eu sei, mas eu não vou deixar você se afogar na tristeza.
<p>- Por que não? Eu deixei você. Você tem que estar adorando isso.
<p>- Eu sou o seu melhor amigo. Eu quero te ver feliz, você precisa ser feliz. Você tem um futuro brilhante, tem amigos e um namorado que gosta muito de você.
<p>- Mas eu não tenho mais você. Eu desistiria de tudo para ter você de volta.
<p>- Isso não é possível e eu nunca deixaria você fazer isso se fosse.
<p>- Bran...
<p>- Eu fiz o que eu fiz porque eu achei que não tinha mais solução, que eu não tinha mais vida. Eu estava enganado. Não acabe com a sua vida como eu acabei com a minha. Você sempre foi importante para mim, mas agora você é importante para outras pessoas. Deixe elas te ajudarem.
<p>- Eu te amo.
<p>- Eu também te amo, Tempe.</p>
<center><h4>--*--</h4></center>
<p>Jason subiu as escadas correndo para falar com Emily. A porta do quarto dela estava aberta.
<p>- Sua mãe disse que eu podia subir.
<p>- Jason, oi. – Emily beijou Jason. – Eu não ouvi você chegando.
<p>- Por que será? – Jason viu que o quarto de Emily estava uma bagunça e cheio de caixas no meio do caminho. Ele achou estranho, ela sempre era muito organizada. – O que você está fazendo?
<p>- Eu estou arrumando minhas coisas para quando formos para Nova York.
<p>- Mas já? – Jason ficou surpreso.
<p>- Eu tenho muita coisa e eu odeio fazer tudo em cima da hora. Ah, eu esqueci de te perguntar. O diretor te suspendeu mesmo?
<p>- Eu não voltei lá para confirmar. – Jason riu.
<p>Jason percebeu mesmo que Emily tinha muita coisa. A cama dela estava cheia de roupas em cima e havia sapatos e acessórios jogados pelo quarto todo, e sua estante ainda havia vários livros e dvds que ela ainda não tinha encaixotado.
<p>- Você veio me ajudar? – Emily estava mesmo precisando de ajuda.
<p>- Ah, na verdade, eu vim te contar uma coisa. – As mãos de Jason estavam suadas.
<p>- Que bom, porque eu também quero te contar uma coisa. – Emily parecia animada.
<p>- Fala primeiro então.
<p>- Tudo bem. – Ela ficou mais feliz. – Olha, não se assusta, mas se tudo der certo e nós dois formos para Nova York, pode ser que eu tenha encontrado um lugar para a gente ficar.
<p>- Um lugar? Como assim?
<p>- Eu tenho um primo que mora no Brooklyn e no prédio em que ele mora, estão alugando dois apartamentos.
<p>- Ah, eu já vi em algum lugar que aluguel em Nova York não é barato. – Jason estava com medo de onde aquela conversa chegaria.
<p>- Eu sei, mas a gente pode começar trabalhando em alguma lanchonete ou sei lá, pelo menos até conseguirmos um emprego melhor já que meu estágio não paga muito.
<p>- Bom, parece bom.
<p>- É ótimo, o bairro não é o melhor, mas é só poucos minutos até o centro.
<p>- Você planejou tudo, não é? – Jason não conseguiu disfarçar o seu desanimo, já que ele não iria.
<p>- Mais ou menos. Desculpa, a gente devia conversar sobre isso, você tem alguma outra ideia? – Emily estava muito animada.
<p>- Não, a sua está ótima. Dois apartamentos, legal.
<p>- É, eu não quero forçar a barra, a gente não precisa ir morar junto logo de cara.
<p>- É verdade, mesmo que eu vá passar mais tempo na sua casa do que na minha, mas...
<p>- Vai dar certo. Vai ser como uma aventura. Você estava dizendo isso ontem.
<p>- É.
<p>- Agora, o que você queria me contar?
<p>- Ah, é que as minhas cartas chegaram.
<p>- E... – Emily ficou ansiosa.
<p>- E... – Jason encarou aqueles olhos cheios de alegria de Emily. - Eu fui aceito na Columbia.
<p>- É sério? – Emily sorriu contente.
<p>- É. Para valer.
<p>- Ai que bom! – Emily abraçou Jason. – Eu sabia que você ia conseguir.
<p>- É. – Jason não sabia mais o que falar. Suas mãos suavam mais do que antes.
<p>- Tudo isso, sair daqui e ir para uma cidade grande dá muito medo, que bom que eu vou estar com você. Eu te amo. – Emily beijou Jason para parabeniza-lo.
<p>- Eu também te amo.
<p>O que Jason tinha acabado de fazer?</p>
</body></html>";
            }

            if (numero == 28)
            {
                lblTitulo.Text = "Capítulo 28 - Erro";
                htmlPage.Html = @"<html><body>
<p>Lisa estava muito brava com Jason naquele dia.
<p>Ela andava de um lado para o outro pelo quarto enquanto reclamava, já seu amigo ficou sentado na cama sendo obrigado a ouvir cada palavra.
<p>- Você não consegue ficar um dia sem fazer bobagem? – Lisa balançava a cabeça em negação.
<p>- Eu não consegui dizer, tá bom?
<p>Jason havia contado para Lisa que mentiu para Emily que tinha entrado na faculdade que ele queria.
<p>- Por que não?
<p>- Porque eu sou um covarde.
<p>- Ah, nisso concordamos.
<p>- Eu não sei o que fazer. – Jason deu de ombros. – Me dá uma ajuda ao invés de ficar me julgando.
<p>- Você precisa contar para ela.
<p>- Eu faço tudo, menos isso. Outra ajuda, por favor. – Jason estava nervoso.
<p>- Você é um babaca. – Lisa deu um tapa na cabeça de Jason.
<p>- Ai!
<p>- O que você acha que ela vai fazer quando descobrir tudo?
<p>- Ela não precisa descobrir.
<p>- O que vai fazer em Nova York?
<p>- Ah, eu vou... cantar no metrô? Pode dar certo.
<p>- Jason, me responde uma coisa. – Lisa ficou de frente com ele e o encarou. – Você está triste porque não passou na faculdade ou porque desapontou a Emily? Você queria mesmo entrar nessa faculdade?
<p>- Isso importa?
<p>- É claro que importa. Você não pode ir com a Emily só por ir, só por causa dela. E quanto ao que você realmente quer? Seu sonho? Seu futuro?
<p>- Lisa, qual é? Eu não tenho sonho e essas faculdades me mostraram que eu não tenho um futuro.
<p>- Jason, não é bem assim.
<p>- Eu aqui, em Los Angeles, em Nova York ou qualquer lugar do país, vou ser a mesma coisa: um cara que trabalha pesado pelo resto da vida recebendo um salário mínimo. Nada vai mudar.
<p>- É isso? Você aceita isso? Como se fosse inevitável? – Lisa voltou a balançar a cabeça em negação. – O que vai fazer quando a Emily se tornar uma mulher bem-sucedida? Como vai se sentir?
<p>- Eu não sei.
<p>- Sabe sim. Você vai se sentir um fracassado.
<p>- Lisa, eu já sou um fracassado.
<p>- Não, Jason, você não é. – Lisa chegou a ficar indignada. – Você não é desse jeito. Você é o cara que ficou durante meses criando teorias, suspeitando e infernizando todo mundo para descobrir a identidade daquele maldito blogueiro.
<p>- O que isso tem a ver?
<p>- Eu nunca vi você desistindo de alguma coisa. Agora só por causa de algumas cartas você vai cair fora?
<p>- É uma coisa bem diferente, tá bom?
<p>- Não é, não.
<p>- É sim. O que você quer que eu faça? Faço um protesto na porta da faculdade?
<p>- Não se trata da faculdade. Se trata de você encarar o que você realmente quer e resolver as coisas com a Emily. Contar a verdade. É disso que se trata.
<p>- Olha só, Lisa, só porque somos amigos não quer dizer que somos iguais.
<p>- Do que você está falando?
<p>- Só porque você sabe o que quer do seu futuro e tem certeza que tudo vai ser grandioso, não quer dizer que eu seja assim também.
<p>- Jason...
<p>- O mundo é cruel, não é um conto de fadas onde tudo dá certo. Eu já aceitei isso.
<p>- Já aceitou? – Lisa não estava acreditando no que estava ouvindo. – O que vai fazer então? Vai continuar enganando sua namorada até o dia em que estiverem na estação de trem e você empurrar ela para dentro do trem falando que não pode ir junto? E depois? Vai voltar para Los Angeles e aguentar o seu pai insuportável?
<p>- Para de falar! – Jason deu um grito. – Você está me deixando louco.
<p>- Talvez um hospício seja um ótimo futuro para você.
<p>- Traz a camisa de força então.
<p>Jason se levantou da cama e saiu do quarto.</p>
<center><h4>--*--</h4></center>
<p>Emily sabia que fazer aquilo era um erro, mas mesmo assim lá estava ela batendo na porta de uma casa após dirigir por quase duas horas. Seu coração batia bem rápido e suas mãos tremiam um pouco.
<p>- Emily? O que faz aqui?
<p>Samantha ficou surpresa quando abriu a porta.
<p>- Eu queria conversar com você. – Emily estava com a voz meio tremula.
<p>- Sobre o quê? Quer saber se eu estou pagando por todo o mal que eu te fiz? – Samantha deu um sorriso falso.
<p>- Não. Eu... Na verdade, eu nem sei porque eu vim.
<p>- Pode ir embora então. A não ser que esteja com saudades de apanhar. – Samantha continuou com o seu tom de deboche que Emily conhecia muito bem.
<p>- Parece que você não mudou nada.
<p>- O quê? Você faz parte do “Por onde anda os valentões”? É ajudante do blogueiro agora?
<p>- Ele morreu, na verdade.
<p>- O blog morreu?
<p>- Não, o blogueiro morreu. – Emily sabia que Samantha nem ia se incomodar em perguntar quem era o blogueiro.
<p>- É uma pena. Quem matou? – Ela riu.
<p>- Olha, eu só quero dizer que tudo bem, eu não odeio mais você.
<p>- O que é isso? Acha que eu me importo?
<p>- Bom...
<p>- Acha que eu fico pensando se você me odeia ou não? Que eu me preocupo se você me perdoou? Querida, eu nem ligo para você.
<p>- Não me interessa se você se importa ou não. Eu não estou aqui por você, estou aqui por mim.
<p>- E isso está te fazendo bem?
<p>- Está, na verdade. Eu estou bem, muito bem.
<p>- Você está aqui para jogar na minha cara que venceu na vida, é isso? E com isso tentar ser superior a mim? – Ela começou a gargalhar.
<p>Emily deu as costas para Samantha e foi em direção ao carro e então hesitou. Isso não estava indo como ela queria. Emily não tinha viajado por duas horas para desistir.
<p>- Me desculpa, mas eu preciso saber porquê. – Emily voltou. Samantha ainda estava na porta.
<p>- Por que o quê?
<p>- Por que eu? Havia tantas garotas, por que você escolheu justo eu?
<p>- Porque você era a mais fraca, a mais inocente, era muito divertido ver a sua cara de medo. Era isso que queria ouvir?
<p>- Era exatamente isso, porque você acabou de provar a minha teoria.
<p>- Qual teoria? – Samantha ficou interessada.
<p>- De que você não era uma garota perdida ou sem educação ou com problemas pessoais digna de atenção. Era só uma vadia... e ainda do pior tipo.
<p>- Que tipo?
<p>- O tipo que vai ser para sempre. Eu não tenho ódio de você, eu tenho pena. Porque garotas como você nunca vão se sentir completas com algo.
<p>- Sai daqui antes que eu te dê um tapa.
<p>- Se isso vai fazer você se sentir melhor. Só saiba que independentemente de você me bater agora ou não, a minha vida está perfeita, então você nunca mais vai conseguir estragar isso.
<p>Emily não esperou Samantha responder e foi embora. É, ela tinha razão, depois de desabafar, o peso nos ombros tinha sumido completamente.</p>
<center><h4>--*--</h4></center>
<p>Jason não estava muito bem. Ele geralmente não prestava mesmo atenção na aula, mas agora estava pior. A conversa que ele teve com a Lisa, ou melhor, a briga, não saía da sua cabeça naquele momento.
<p>- Você está bem? – Emily cochichou atrás de Jason.
<p>- Estou ótimo.
<p>Ainda bem que Emily estava sentada atrás dele e não conseguia ver seu rosto senão saberia que ele estava mentindo.
<p>- O que vai fazer mais tarde? – Ela continuou sussurrando.
<p>- Bater a cabeça na parede até eu morrer. – Jason resmungou baixinho.
<p>- O quê?
<p>- Nada, eu não vou fazer nada. Por quê? – Jason se corrigiu.
<p>- Eu estava pensando em te ajudar a fazer as malas. – Emily parecia ansiosa.
<p>- Ainda falta alguns dias, Emily.
<p>- Eu sei, mas você é muito desorganizado, vai acabar esquecendo alguma coisa.
<p>- Eu não tenho muita coisa para guardar, só camisas, calças e cuecas, e uma escova de dentes. – Jason falou irritado.
<p>- Ai, que rabugento. O que você tem hoje?
<p>- É sério, a gente pode fazer isso outro dia. – Jason mudou o tom de voz para parecer mais gentil.
<p>- Tudo bem. Você está bem mesmo?
<p>- Estou sim. – Ele mentiu de novo. – Olha, eu tive uma ideia melhor. Que tal eu ir até a sua casa mais tarde para te ajudar a terminar de arrumar as suas coisas?
<p>- Eu já terminei.
<p>Mesmo sem ver o rosto de Emily, Jason sabia que ela estava sorrindo de orgulho.
<p>- Eu duvido.
<p>- Vai lá para ver então.
<p>- Essa é a ideia. – Ele sorriu.
<p>- Eu estou muito animada. Você está animado? – Ela se mexia bastante na cadeira.
<p>- Claro que eu estou. Vai ser incrível.
<p>- Eu sei. – Ela quase gritou no meio da aula.</p>
<center><h4>--*--</h4></center>
<p>- Temperance, oi. – Lisa encontrou Temperance no meio do corredor da escola. Pela primeira vez, Temperance parecia deslocada naquele lugar.
<p>- O que você quer? Eu estou atrasada. – Temperance não disfarçou a irritação.
<p>- Eu não tenho te visto nesses últimos dias e...
<p>- Minhas notas são perfeitas. Não preciso mais vir aqui com frequência.
<p>- Que legal.
<p>- O que você quer? – Temperance foi direto ao ponto.
<p>- Sabe, eu estou indo embora depois da formatura e a minha mãe quer que eu compre aquelas lembrancinhas bobas da cidade. A gente podia sair à tarde para você me levar em algum lugar que vende isso. – Lisa fez o convite.
<p>- Então você vai embora?
<p>- Vou.
<p>- O Jason também vai?
<p>- Ele ainda está pensando no que vai fazer, na verdade. Ele não falou nada para você?
<p>- Não tenho conversado muito com ele nos últimos dias.
<p>- Ah, mas...
<p>- Bom para vocês. – Ela interrompeu Lisa para cortar logo aquele assunto.
<p>- E quanto a você? Já foi aceita em alguma faculdade?
<p>- Não te interessa. – Temperance fechou a cara. – Olha só, nunca fomos amigas. A gente só se aturava porque você era a namorada do meu melhor amigo, só por isso.
<p>- Talvez tenha sido um erro. Podemos agora...
<p>- Olha, eu não quero ser sua amiga. E nem você quer ser a minha amiga, você só está com pena de mim porque eu estou com os olhos inchados de tanto chorar e eu não durmo há dias.
<p>- Temperance...
<p>- Eu não quero a sua pena, eu não quero nada de você. Vai demorar muito para você ir embora?
<p>- Eu não quero ir embora sabendo que você está assim.
<p>- Você nunca ligou para mim, não comece a se fazer de boa amiga.
<p>- Você que nunca me deu uma chance. Eu só...
<p>- Não precisa fingir. Só porque o Bran morreu não quer dizer que é seu dever cuidar de mim, vocês nem estavam mais namorando. Você odiava ele. – Temperance falava calmamente.
<p>- Eu não vou insistir. Eu nunca desisto dos meus amigos, mas como você mesma disse, nunca fomos amigas.
<p>Temperance tocou no ponto fraco da garota. Aquele ódio que Lisa sentia antes da morte do Brandon a matava todos os dias.
<p>- Ótimo, então pode sair da minha frente.
<p>- Com prazer. – Lisa falou um pouco brava.
<p>Temperance foi embora sem nem olhar para trás.</p>
<center><h4>--*--</h4></center>
<p>Maddie saiu correndo atrás de Jason quando o viu no portão da escola enquanto ele estava saindo.
<p>- Jason, eu posso falar com você? – Ela gritou para tentar pará-lo e conseguir alcança-lo.
<p>- Fala rápido, estou com pressa. – Jason começou a andar mais rápido.
<p>- Espera. – Maddie o alcançou para segurar o seu braço.
<p>- O que foi? – Jason parou.
<p>- Eu não odeio você. – Ela falou quase sem ar de tanto correr.
<p>- Tudo bem. – Jason não entendeu nada. – Posso ir agora?
<p>- Eu estou falando sério. – Maddie ficou brava.
<p>- De onde isso surgiu? Como assim “eu não odeio você”? – Jason resolveu então fingir interesse.
<p>- Eu só quero dizer que não importa todas as vezes que a gente brigou ou você me irritou, não sinto ódio por você.
<p>- E por que você quer falar isso agora?
<p>- Porque tudo está acabando e eu não quero ficar pensando nas coisas quando for tarde.
<p>- Nada está acabando. É o fim do ensino médio, não da vida. O fim da escola é um começo.
<p>- Eu não me imagino fora daqui. É tão assustador.
<p>- Você vai conseguir. É inteligente e talentosa e nem tem um processo criminal na sua ficha.
<p>- Processo criminal? – Maddie não entendeu.
<p>- Deixa para lá. Olha, Maddie, você está falando do ódio, ou melhor, do não-ódio, porque o Brandon se matou?
<p>- Um pouco. Eu conheço o Bran já faz muito tempo, e aí eu percebo que a última conversa que tivemos foi de raiva e eu fico mal. Aquele dia estava horrível, mas ele só precisa de uma frase simples para fazê-lo mudar de ideia, mas ninguém disse.
<p>- É uma pena, mas não dá para mudar essas coisas.
<p>- Mas para a gente não é tarde demais. – Ela sorriu para Jason.
<p>- Maddie, está tudo bem. Eu também não odeio você. Eu gosto de te irritar porque você é mais irritante do que eu.
<p>Maddie se decepcionou porque esperava um elogio melhor do que “mais irritante do que eu”.
<p>- Amigos? – Maddie estendeu a mão para Jason.
<p>- Claro, por que não? – Jason abraçou Maddie.
<p>- Você me abraçou. – Maddie ficou impressionada. – Eu gostei.
<p>- É, eu sei. Meus abraços são muito bons. Posso ir embora agora?
<p>- Claro.
<p>- Ótimo.
<p>Jason se despediu e foi embora.</p>
<center><h4>--*--</h4></center>
<p>Emily tinha razão.
<p>Seu quarto não estava mais bagunçado. A maioria das coisas já estavam encaixotadas em um lado do quarto. Jason estava impressionado.
<p>- Nossa, você é rápida. – Jason deu uma olhada no quarto.
<p>- Pode-se dizer que eu fiquei acordada a noite toda. – Emily estava orgulhosa de si mesma.
<p>- Fez um ótimo trabalho.
<p>- Agora só falta você...
<p>- Eu já disse, camisas e cuecas, só isso. – Jason brincou. – Eu arrumo rapidinho.
<p>- Tudo bem.
<p>- Eu só quero relaxar agora. – Jason se sentou no tapete que ficava no pé da cama.
<p>- Por quê? – Emily ainda sentia que Jason não estava bem.
<p>- A Lisa e eu andamos brigando, eu não gosto muito disso. E tem a Temperance, não sei o que está acontecendo com ela. São só coisas idiotas na minha cabeça.
<p>- Eu sabia que você não estava bem.
<p>- É, você me conhece e isso é uma droga.
<p>- Bom, tem uma coisa que eu não te contei também. – Emily se sentou ao lado dele.
<p>- O quê?
<p>- Eu fui na casa da Samantha ontem.
<p>- O quê? Como? Por quê? – Jason não esperava por isso.
<p>- Sei lá, acho que eu esperava um desfecho.
<p>- E conseguiu?
<p>- Não exatamente, mas eu estou diferente agora.
<p>- Diferente? Como assim?
<p>- Eu sei que você odiou falar com aquela psicóloga, mas ela me ajudou, me fez realmente pensar nas coisas.
<p>- Aquela mulher era louca.
<p>- Aquela mulher disse para eu me expressar, aí eu fui até a casa da Samantha e chamei ela de vadia.
<p>- Nossa. Parabéns. – Jason bateu palmas. – É sempre bom xingar alguém para aliviar a tensão. Por que você não me pediu para ir com você?
<p>- Era uma daquelas que a gente tem que fazer sozinho, sabe?
<p>- Sei. – Jason assentiu.
<p>- Sabe, a minha vida não foi uma das melhores, mas agora ela parece que está dando certo. Eu vou sair dessa cidade, vou realizar os meus sonhos e a melhor parte é que eu estou com você. – Emily beijou o namorado.
<p>- Nova York, você acha que vai dar certo?
<p>- Como assim?
<p>- Não é nada, é só nervosismo, eu acho. A cidade é tão grande.
<p>- Você veio de Los Angeles, conta outra.
<p>- É que... – Jason não sabia muito bem o que dizer. – Você não está nem um pouco nervosa?
<p>- É claro que eu estou, mas isso não vai diminuir a minha felicidade.
<p>- Vamos ficar bem. – Jason tentou encerrar o assunto.
<p>- Eu sei disso. – Emily sorriu.</p>
<center><h4>--*--</h4></center>
<p>- Eu sabia que ia te encontrar aqui. – Nathan andou até Temperance.
<p>Todas as tardes depois da escola, Temperance ia ao cemitério visitar Brandon. Nathan havia ido à casa dela, mas ela não estava então só tinha um lugar onde ela estaria.
<p>- O que você faz aqui? – Temperance estava sentada em cima da mochila que ela jogou no chão.
<p>- Eu queria ficar com você hoje.
<p>- Eu não vou poder.
<p>- Por quê? Está ocupada passando horas no cemitério? – Nathan não queria ser grosso, mas ele não conseguia entender.
<p>- Me deixa sozinha.
<p>- Temperance, eu quero te ajudar.
<p>- Eu não preciso de ajuda.
<p>- Me desculpa, mas precisa sim. – Nathan ficou de frente para Temperance tampando sua visão da lápide e ela ficou irritada. - Olha, eu entendo, ele era o seu melhor amigo e isso afetou muito você, mas você precisa seguir em frente, já faz quase um mês.
<p>- Para você é fácil falar, não o conhecia.
<p>- Sabe que não é assim. É senti muito a morte dele, mas...
<p>- Mas o quê? Eu estou exagerando? Eu estou bancando a vítima para querer a atenção de todo mundo?
<p>- Eu não quero dizer isso.
<p>- Então é o quê?
<p>- Eu...
<p>- Acha que se eu pudesse acabar com isso, eu não acabaria? Porque o que eu mais quero é seguir em frente, Nathan.
<p>- Eu sei que sim.
<p>- Toda noite eu tenho pesadelos e acordo gritando e chorando todas as vezes. Essa coisa está acabando comigo. Eu não consigo mais achar graça em nada. – As lágrimas de Temperance voltaram a escorrer pelo seu rosto. – Às vezes eu tenho vontade de sumir.
<p>- Ei, não diga isso. Eu ainda estou aqui e não vou a lugar nenhum. – Nathan se abaixou para ficar cara a cara com ela.
<p>- Nathan, não me leve a mal, mas...
<p>- Eu sei que está passando por um momento difícil, mas eu vou cuidar de você, não vou te deixar sozinha.
<p>- Eu não sou uma ótima companhia agora.
<p>- Eu não me importo. Eu te amo e vou ficar do seu lado.
<p>- Você me ama? – Era a primeira vez que Temperance tinha ouvido isso de Nathan.
<p>- Amo.
<p>Temperance limpou as lágrimas do rosto.
<p>- Por quanto tempo vai durar? – Temperance encarou o namorado.
<p>- Enquanto você deixar.
<center><h4>--*--</h4></center>
<p>Jason se trancou no quarto assim que chegou em casa depois de passar a tarde toda com a Emily. Ele sabia que Lisa estava o esperando assim que ele chegasse, mas não queria falar com ela naquele momento.
<p>- Jason, precisamos conversar! – Lisa bateu na porta do quarto dele.
<p>- Vai brigar de novo? – Lisa ouviu Jason gritar lá de dentro.
<p>- Só conversar.
<p>- Lisa, eu não estou a fim.
<p>- Por favor.
<p>Jason abriu a porta do quarto e Lisa entrou.
<p>- Falou com a Emily? – Lisa perguntou assim que entrou no quarto.
<p>- Não sobre aquilo. Quer conversar sobre isso de novo?
<p>- Eu quero saber o que você vai fazer. O que eu devo dizer para ela caso ela me pergunte alguma coisa?
<p>- Nada, você não deve dizer nada. Eu mesmo vou dizer quando chegar a hora.
<p>- E quando vai ser a hora?
<p>- Eu não sei! – Jason ficou bravo.
<p>- Jason, você está magoado por não ter passado na faculdade ou porque a Emily vai ficar triste se você não for junto com ela? – Lisa refez a sua pergunta da briga anterior.
<p>- Para de me perguntar isso. – Jason fechou os olhos e se jogou na cama para tentar relaxar.
<p>- Eu preciso saber dessa resposta. Não contou para ela por que está em negação ou por que não quer magoá-la?
<p>- As duas coisas, eu acho. Talvez mais para não a magoar, mas...
<p>- Jason, você está se ouvindo? Sabe que você tem que ir para Nova York porque você quer não porque a Emily vai, não sabe?
<p>- Eu sei disso.
<p>- Eu acho que não. Talvez você só encare isso como a sua única opção.
<p>- Olha, eu não quero falar sobre isso. – Jason cortou Lisa.
<p>- Talvez isso tudo seja um sinal. Talvez você não deva...
<p>- Acha que eu ser recusado em todas as faculdades foi um sinal? – Jason ficou indignado. – Um sinal para que exatamente? O que “Deus” está tentando me mostrar?
<p>- Jason...
<p>- Eu confesso, eu só resolvi ir para Nova York por causa da Emily. Eu não ligo se eu fui aceito para a faculdade ou não, eu nem ia mesmo me inscrever em nenhuma, não fez diferença. Eu a amo e quero ficar com ela. Sim, eu coloco as pessoas que eu amo em primeiro lugar e esqueço de mim. Você sabe muito bem disso. – Jason encarou Lisa.
<p>- Como assim?
<p>- Se eu não tivesse agido sem pensar batendo naquele cara para te defender, eu não teria um processo e nem teria problema de entrar na faculdade.
<p>Jason se arrependeu de dizer o que disse assim que disse.
<p>- Ah, então é isso? Agora a culpa é minha?
<p>- Não, Lisa, eu não quis dizer isso.
<p>- Não, Jason, você quis dizer exatamente isso. – Lisa ficou brava. – Olha, quer saber, eu não vou me importar mais. Você quer mentir? Minta. Quer culpar os outros? Continue fazendo isso. Eu não ligo mais.
<p>- Lisa, me desculpa, eu...
<p>- Não. Da próxima vez, pensa antes de falar.
<p>- E da próxima vez, não venha falar comigo quando eu quero ficar sozinho.
<p>- Você é um ridículo.
<p>- Por que você não se preocupa com as suas coisas? Já arrumou as suas coisas para ir embora? Já comprou passagem?
<p>- O quê?
<p>- Cuida das suas coisas e deixa as minhas comigo.
<p>- Acha mesmo que eu vou conseguir fazer as minhas coisas enquanto você está aí todo enrolado e perdido?
<p>- Eu vou ficar bem.
<p>- O que vai acontecer quando a Emily descobrir a verdade?
<p>- Provavelmente vamos terminar.
<p>- E como você vai lidar com isso?
<p>- Ela é só uma garota, Lisa. Eu vou superar. – Jason estava ficando sem paciência.
<p>- Não é assim tão simples.
<p>- Talvez não para você.
<p>- Não vamos falar do Brandon agora.
<p>- Eu não quero falar sobre ele, eu quero que você saia do meu quarto.
<p>- Ótimo.
<p>Lisa saiu do quarto de Jason bem nervosa.
<p>- Que imbecil você é Jason!
<p>Jason tacou a primeira coisa que viu na parede: o controle remoto da TV.</p>
</body></html>";
            }

            if (numero == 29)
            {
                lblTitulo.Text = "Capítulo 29 - Formatura";
                htmlPage.Html = @"<html><body>
<p>Temperance sentiu seu quarto escuro se iluminar com os raios de sol enquanto ouvia suas cortinas sendo abertas.</p>
<p>- Levanta, raio de sol! – Jason gritou. – Hora de brilhar!
<p>- Vai embora. – Ela resmungou.
<p>- Levanta!
<p>Jason começou a chacoalhar Temperance que ainda estava deitada na cama com o rosto virado para o travesseiro.
<p>- O que você quer? – Temperance resmungou sem nem abrir os olhos.
<p>- A sua mãe me deixou entrar. Ela disse que você está na cama desde ontem à tarde, então levanta, daqui a pouco o lençol vai grudar no seu corpo. – Jason ficou receoso de tirar o cobertor de cima de Temperance. E se ela estivesse sem roupa?
<p>- Vai embora, Jason.
<p>- Nem pensar, o Nathan viajou para buscar a vó dele para a formatura, você não pode ficar sozinha e eu estou tentando evitar a Emily porque só vou contar para ela que não fui aceito na faculdade depois da formatura.
<p>- O quê?
<p>- Deixa para lá. Não vou falar disso agora.
<p>- Olha, nem somos mais tão amigos assim para você ficar me enchendo. – Temperance não estava reagindo.
<p>- Você quer um apelido? É isso que está te faltando? Tudo bem, eu vou te chamar de Alcione. Agora levanta.
<p>- Eu não estou a fim.
<p>- Você quer que eu desça e busque o balde de água fria? Porque eu posso fazer isso. – Jason já estava ficando irritando.
<p>- Tudo bem! – Temperance se virou e olhou para ele com raiva. – Sai do quarto. Eu vou me trocar.
<p>- Por quê?
<p>- Porque eu estou de pijama.
<p>- Levanta e vai para o banheiro.
<p>- Sai!
<p>- Que frescura. Você é uma garota comum, tem peitos como todo mundo.
<p>- Sai daqui! – Temperance jogou um dos seus travesseiros na cara de Jason.
<p>- Tudo bem, eu já vou.
<p>Jason saiu do quarto.</p>
<center><h4>--*--</h4></center>
<p>- Eu não acredito que vai embora. Finalmente eu tenho uma amiga e ela vai embora. – Emily e Lisa estavam tomando café da manhã juntas na cafeteria.
<p>- Isso não é justo. Você também vai embora. – Lisa riu.
<p>- É, essa cidade não é uma das melhores. – Emily fez uma piada.
<p>- E quero esquecer algumas coisas daqui.
<p>- Eu também. Como você está? O Jason disse que vocês brigaram.
<p>- Foi mais como uma discussão, a gente faz isso o tempo todo.
<p>- Ele não quis me contar por quê. Foi sério?
<p>- Às vezes a gente acaba falando coisas que não devemos, tipo coisas sem pensar. Não foi sério, mas você conhece o Jason, quando junta nós dois, o drama é grande.
<p>Emily percebeu que Lisa estava enrolando.
<p>- Entendi. Ansiosa para amanhã? – Emily resolveu então mudar de assunto.
<p>- Muito, o meu baile não foi perfeito, mas espero que a minha formatura seja.
<p>- Os seus pais vão vir?
<p>- Vão, sim. – Lisa parecia feliz por poder ver seus pais de novo depois de tanto tempo.
<p>- Aí você já vai embora com eles?
<p>- Não, eu vou ficar mais um tempo aqui. É que o Jason... – Lisa parou de falar.
<p>- O quê? Jason e eu já vamos para Nova York semana que vem. Combinamos de irmos logo para visitar a faculdade e o novo apartamento.
<p>- É, mas ainda não estou pronta para voltar. – Lisa quase deixou escapar o segredo de Jason. - Nem arrumei as minhas malas ainda. – Ela riu sem graça.
<p>- Eu sei, despedida é uma droga.
<p>- Na verdade, eu nem tenho pessoas para me despedir. Só lembranças.
<p>- Já visitou o túmulo do Bran depois do enterro?
<p>- Eu nem fui ao enterro, esqueceu? – Lisa percebeu que ainda não tinha ido até o cemitério.
<p>- Bom, eu acho que...
<p>- Eu sei que eu tenho que ir lá antes de ir embora, mas eu quero adiar enquanto eu posso. Vai ser as últimas palavras que eu vou falar para ele e eu ainda nem sei o que dizer.
<p>- É difícil, eu entendo.
<p>- Eu às vezes nem acredito que tudo isso aconteceu. Esse ano foi tão longo.
<p>- É. E olha para gente, sobrevivemos a ele. – Emily sorriu. – Vai dar tudo certo. O pior já passou.
<p>- Assim eu espero.</p>
<center><h4>--*--</h4></center>
<p>- Quer dizer que você vai passar o dia todo no meu pé? – Temperance saiu do banheiro e Jason estava sentado na cama dela.
<p>- A ideia é essa. – Jason sorriu.
<p>- Eu posso te expulsar daqui.
<p>- Se preocupe em escovar os dentes primeiro, o que eu acho que você não está fazendo. Um chiclete mastigado bastava. Como o Nathan beija você?
<p>- Me diz o que você quer, eu faço e você vai embora. – Temperance resmungou. Ela estava na porta do quarto, não queria se aproximar muito de Jason.
<p>- Que tal sete minutos no paraíso? – Jason brincou. – Tudo bem, dez.
<p>- Que tal meia hora no inferno?
<p>- Pode ser, eu não sou muito exigente.
<p>- Você é ridículo. – Temperance fez cara de nojo.
<p>- Ah, então a nossa amizade está voltando. Já está me xingando. – Jason riu.
<p>- Olha, Jason, eu sei que você quer me ajudar, mas é sério, eu estou bem.
<p>- Lógico, você está bem e eu passei na faculdade. Você não me engana, tá bom?
<p>- Que história é essa da faculdade? Já falou duas vezes esse assunto.
<p>- Olha, você ainda presta atenção nos outros.
<p>- Fala logo.
<p>- Não estamos aqui para falar de mim. Tudo o que você vai ganhar vai ser comentários sem lógica e sem contexto.
<p>- Você estragou tudo como sempre?
<p>- Engraçadinha.
<p>- Estou te insultando. Não é isso que você quer? – Temperance deu um sorriso maldoso.
<p>- Eu ainda quero muitas coisas, mas vou me contentar com isso por enquanto.
<p>- Ótimo.
<p>- Sabe, ainda bem que eu abri essas janelas. Esse quarto está fedendo.
<p>- Cala essa boca. – Temperance revirou os olhos e voltou para o banheiro.</p>
<center><h4>--*--</h4></center>
<p>Kol estava abrindo uma carta que havia chegado para ele quando Maddie entrou no quarto toda animada.
<p>- Não sabe bater na porta? – Kol olhou para a irmã um pouco bravo.
<p>- Me desculpa, mas eu estou feliz demais para ficar parada em frente à porta. – O sorriso de Maddie estava de orelha a orelha.
<p>- O que houve? – Kol sabia que a irmã era animada, mas agora já estava exagerada.
<p>- O diretor acabou de me ligar, ele disse que eu fui escolhida para ser a oradora da classe.
<p>- Você vai fazer o discurso dos formandos na formatura?
<p>- Exatamente.
<p>- Mas como? – Até o Kol ficou animado pela irmã.
<p>- Eu não sei direito, só sei que eu tenho menos de vinte e quatro horas para escrever um discurso.
<p>- O que você está esperando? Vai.
<p>- O que é isso que você está abrindo? – Maddie viu que Kol estava com uma carta aberta na mão.
<p>- É uma carta de aprovação. Eu fui aceito...
<p>- Em qual faculdade? – Seus olhos brilharam.
<p>- No Exército.
<p>- Exército? – O sorriso de Maddie de repente desapareceu. – Como assim? O papai e a mamãe...
<p>- Eu já falei com eles sobre isso.
<p>- E eles concordaram?
<p>- Falaram que a decisão teria que ser minha.
<p>- Por que está fazendo isso? – Maddie já parecia desesperada.
<p>- Maddie, se acalma.
<p>- Quando ia me contar? Por que está fazendo isso?
<p>- Eu sinto que eu preciso me encontrar.
<p>- Não precisa ir para o Exército para se encontrar. Você só precisa...
<p>- Olha, eu sei que não é o ideal, mas eu estou confiante nisso. – Kol parecia estar seguro do que queria.
<p>- Até você levar um tiro. Você não assiste aos telejornais? Centenas de soldados são mandados para guerra o tempo todo.
<p>- Eu sei os riscos, tá bom? Eu vou ser recruta e aí...
<p>- Não adianta me falar coisas que acha que vai me deixar mais calma. Nada vai me deixar mais calma. Você vai para o Exército.
<p>- Maddie, eu te amo, mas esse pode ser o jeito de eu fazer a diferença.
<p>- Então seja médico, um dono de uma ONG, qualquer coisa menos isso.
<p>- Eu já fiz, tá bom? Não tem como voltar atrás e eu nem quero voltar. Eu já me decidi. Eu sinto muito por você ser contra, mas é a minha vida, e eu escolho...
<p>- Como você quer morrer? – Maddie terminou a frase.
<p>- Muitos soldados viram heróis. Eu só fiz coisa errada na vida, eu não salvei a Andressa, nem o Brandon e a quantidade dos meus amigos é igual a zero. Eu quero ser um herói agora.
<p>- Às vezes os heróis morrem.
<p>- E às vezes eles sobrevivem. Me apoie por favor.
<p>- Eu te apoio, você sabe disso. – Maddie começou a chorar. – Mas eu não quero te perder.
<p>- Você não vai me perder. – Kol abraçou a irmã.</p>
<center><h4>--*--</h4></center>
<p>- Você mentiu para Emily dizendo que tinha sido aceito na faculdade? Que tipo de idiota faz isso? – Temperance estava chocada. - Parece que o seu tipo faz, né?
<p>Jason havia sido vencido pela insistência de Temperance e acabou contando seu problema da faculdade para ela.
<p>- Eu entrei em pânico. – Jason estava tentando se explicar para Temperance.
<p>- Não, entrar em pânico é gritar, sair correndo, não mentir. Quando vai contar a verdade?
<p>- Logo.
<p>- Jason. – Temperance fez cara de reprovação.
<p>- Cuida dos seus problemas que eu cuido dos meus. – Jason já estava cansado de dizer aquilo. – Além do mais, já escreveu o seu discurso para amanhã?
<p>- Eu não vou ser mais a oradora da classe.
<p>- Por que não? – Jason não conhecia outra pessoa mais inteligente que Temperance.
<p>- Bom, eu não fui mais para escola depois... – Temperance respirou fundo. – Minhas ausências me entregaram, aí deram o meu lugar para a segunda na fila. – Temperance não parecia tão triste por isso, na verdade ela nem estava ligando se faria o discurso ou não.
<p>- Não tem nem como recorrer? Eu vou falar com o diretor, afinal, as suas notas...
<p>- Fica na sua, herói de todo mundo, eu não me importo com isso. Eu nem sei o que eu diria, eu não estou no clima de fazer um discurso.
<p>Jason estava quase dizendo para Temperance superar a morte do Brandon, mas ele não queria chegar nesse assunto.
<p>- Bom, se isso te deixa melhor, você não perdeu nada na escola nesses últimos dias.
<p>- O memorial do Bran ainda está no corredor?
<p>- Tiraram ontem.
<p>Jason então se lembrou que precisaram fazer um outro memorial porque o primeiro ele chutou em uma demonstração de raiva.
<p>- Que ótimo.
<p>- E aí? Está preparada para enfrentar a faculdade o ano que vem? – Jason tentou mudar de assunto.
<p>- Não exatamente.
<p>- Para onde você vai?
<p>- Eu fui aceita na Brown. – Temperance falou sem emoção.
<p>- Nossa, que legal. – Jason estava mais animado que ela.
<p>- Eu mandei uma carta para o reitor dizendo que podiam dar a minha vaga para outra pessoa.
<p>- O quê? Por quê? Eu aqui querendo entrar para uma faculdade e você está dispensando a sua vaga?
<p>- Pode pegar minha vaga se quiser.
<p>- Não é assim que funciona.
<p>- Que seja.
<p>- Por que fez isso? Eu achei que você sempre quis...
<p>- O plano sempre foi eu ir para a Brown junto com o Bran.
<p>- Olha, eu não queria falar sobre isso, mas não pode desistir da faculdade só porque o Brandon morreu.
<p>- Você não entende.
<p>- Talvez eu não entenda, mas o que eu sei é que ele se foi e não vai voltar, você precisa seguir com a sua vida. – Jason finalmente disse.
<p>- Ele era o meu...
<p>- Seu melhor amigo, eu sei. – Jason interrompeu. – Não estou falando para você esquece-lo. Só estou falando que a vida continua.
<p>- Não é fácil.
<p>- Eu não estou dizendo que é. Você está triste, eu sei, você sente falta dele, eu sei disso também, mas ele morreu e você está viva, comece a agir como tal, porque em alguma hora você não vai aguentar.
<p>- O que quer que eu faça? Rasgue todas as fotos dele?
<p>- Se isso for fazer você seguir em frente.
<p>- Eu não sei o que vai me fazer seguir em frente.
<p>- Descubra. E só para te dar uma dica, dispensar sua chance de ir para a faculdade não é uma boa ideia.
<p>- O Nathan disse que ama. – De repente Temperance se lembrou disso.
<p>- Sério? E o que você falou?
<p>- Nada.
<p>- Por quê? Você não o ama?
<p>- Eu não sei mais, eu nem penso mais nisso.
<p>- Como assim?
<p>- Deixa para lá.
<p>- Tempe, você não precisa estragar tudo para se punir de alguma forma. Não estraga tudo, tá bom?
<p>- Acho que já estraguei.
<p>Mas nem com isso ela se importava.</p>
<center><h4>--*--</h4></center>
<p>Lisa foi se deitar cedo naquela noite.
<p>Ela estava ansiosa, o dia seguinte seria o grande dia, o último dia. Ela queria que amanhecesse um dia bem ensolarado já que a cerimônia da formatura seria em campo aberto. Lisa não falou com Jason o dia todo, ele havia saído bem cedo de casa e quando chegou, se trancou no quarto. Ela continuava brava, mas sabia que o amigo estava mal, não era um bom momento para estar brava com ele.
<p>Eram duas horas da manhã e Lisa ainda estava acordada virando na cama de um lado para o outro. Seu cérebro ainda estava em alerta, ela não conseguia dormir. Então resolveu descer até a cozinha para tomar um copo de água e lá estava ele sentado no sofá e parecendo que estava pirando.
<p>- Você ainda não dormiu também? – Lisa se sentou ao lado de Jason.
<p>- Eu sei que não vou conseguir então nem deitei. – Jason colocou as mãos no rosto.
<p>- Falou com a Emily hoje?
<p>- Só por mensagem. Algumas coisas sobre a formatura. Cadê seus pais?
<p>- Eles vão chegar amanhã de manhã. – Lisa sorriu.
<p>- Sorte a sua. Minha mãe disse que tem um compromisso que não pode desmarcar e meu pai tem um trabalho muito importante. Eu entendo, é só a formatura do filho deles, não esperavam que fosse acontecer. – Jason estava bravo.
<p>- Eu sinto muito.
<p>- Sabe, eu tinha uma pequena chance de ter uma vida boa. Entrar na faculdade, ir para Nova York, ficar bem longe dos meus pais, morar com a Emily. Uma carta conseguiu estragar tudo isso. Eu estraguei tudo isso.
<p>- Nova York não é a única solução, você sabe disso, além do mais, nem era esse o seu sonho e...
<p>- Vamos falar sobre isso de novo? Eu não tenho sonhos, Lisa. Eu fui criado com o meu pai gritando para mim que eu era uma droga, que eu não prestava para nada, que antes mesmo de terminar o colégio eu morreria por bebidas, por drogas ou por tiros porque eu tinha tendência a isso.
<p>- Mas isso não é verdade.
<p>- Vai saber. Amanhã alguém pode atirar em mim quando eu estiver entrando no ginásio.
<p>- Jason. – Lisa segurou a mão de Jason.
<p>- Eu nunca nem lutei contra ele, eu nunca tentei provar que ele estava errado. Eu matava aula, não fazia provas e quando fazia era sem importância, eu passava noites sem ir para casa, eu brigava por nada com todo mundo, ficava com a primeira garota que eu via. Para ele ficar completamente feliz, só faltou eu engravidar uma garota, largar os estudos e virar um morto de fome.
<p>- Você é o meu melhor amigo e eu me recuso a aceitar que você é um nada. Você tem todo o tempo do mundo para descobrir o que você quer, o que você vai ser e provar para o seu pai que ele estava errado. Você me deve isso.
<p>- Te devo?
<p>- Deve. Porque eu sempre acreditei em você, se fosse para apostar, eu sempre apostaria em você. Jason, você é inteligente, você tem talento...
<p>- Para quê? Qual é o meu talento?
<p>- Lembra de quando te chamaram para fazer parte do time de basquete, mas você não sabia fazer uma cesta?
<p>- Lembro. – Jason não sabia onde Lisa queria chegar.
<p>- Você ficou dois dias naquela quadra jogando a bola para todo lado até aprender a fazer uma droga de cesta. Você diz que nunca tentou provar ao seu pai que ele estava errado, mas eu discordo. Se lembra de quando queria ir ao show daquela banda de rock que só faz barulho e o seu pai disse que nunca te daria o dinheiro?
<p>- Lembro. Eu até disse que conseguiria o dinheiro de um jeito ou de outro.
<p>- Exato. Você foi de porta em porta para pedir um emprego.
<p>- E eu não consegui. – Jason sorriu ao lembrar disso.
<p>- Depois foi até o mercado com a minha bicicleta e começou a ajudar as pessoas com as suas compras para conseguir alguns trocados.
<p>- Verdade, mas não foi o suficiente.
<p>- Aí você montou um bazar e começou a vender as suas roupas. – Lisa começou a rir junto com Jason.
<p>- O bazar foi um sucesso.
<p>- Aí você comprou o ingresso.
<p>- E o show foi cancelado. – Jason riu da sua própria desgraça.
<p>- Isso. Entende aonde eu quero chegar?
<p>- Entendi, minha vida é fodida.
<p>- Não, idiota. Você nunca...
<p>- Eu sei, eu nunca desisto, esse é o meu talento. Grande coisa. O que eu vou fazer com isso? – Jason ainda não estava animado.
<p>- Com isso, você pode fazer qualquer coisa.</p>
<center><h4>--*--</h4></center>
<p>Jason acordou com o sol na sua cara.
<p>Ele havia se esquecido de fechar a cortina antes de dormir. Antes de se levantar da cama, ele ouviu barulhos vindo do andar de baixo, com certeza eram os pais de Lisa que haviam chegado. Tudo que ele não queria era encontrar o Sr. e a Sra. Stilinski e lembrar que seus pais não viriam, então ele se trocou, foi correndo para o banheiro escovar os dentes, voltou para o quarto, trancou a porta e pulou a janela. Um ótimo jeito de fugir dali.</p>
<p></p>
<p>- Você pulou a sua janela e depois entrou pela minha janela?
<p>Jason contava para Emily como ele fugiu de casa enquanto entrava no quarto dela pela janela.
<p>- Isso mesmo.
<p>- Quem é você? O Super-Macaco? – Emily brincou.
<p>- Muito engraçado. Há-há. – Jason fingiu rir. – Você é péssima com apelidos, nunca se esqueça disso.
<p>- Idiota. Olha, eu adoraria te dar atenção agora, mas eu preciso me arrumar, a formatura é daqui a três horas.
<p>- Vai se arrumar três horas antes?
<p>- Eu sempre me arrumo com antecedência.
<p>- E por que sempre chega atrasada quando marcamos um encontro?
<p>- É um charme. – Emily ficou sem graça.
<p>- Sei.
<p>- Você precisa ir para casa se arrumar também.
<p>- Só preciso de trinta minutos. Trinta e um minutos se eu resolver ir de cueca. – Jason sorriu.
<p>- Vou fingir que não ouvi o que você disse.
<p>- Eu posso ficar aqui e te ajudar a escolher a sua roupa.
<p>- Você vai me ajudar a escolher a roupa? – Emily não conseguiu acreditar.
<p>- Lógico, e se quiser, eu te ajudo a tirar a roupa também.
<p>- Sai daqui. – Emily jogou uma almofada na cara de Jason.
<p>- Olha, tudo bem, se você não quer a minha companhia...
<p>- Não quero. – Emily sorriu.
<p>- Eu vou para casa encarar “A Família”. A gente se encontra na escola?
<p>- Claro. – Emily confirmou.
<p>- Eu te amo. – Jason a beijou.
<p>- Eu também te amo.</p>
<center><h4>--*--</h4></center>
<p>- Então como eu fiquei?
<p>Temperance saiu do banheiro vestindo a beca para Nathan ver.
<p>- Você ficou perfeita. Vermelho realmente é a sua cor. – Nathan beijou Temperance.
<p>- Obrigada. – Temperance deu um quase sorriso.
<p>- Bom, que bom que eu te convenci a ir para a formatura.
<p>- Formatura é uma só, não é? – Temperance não estava muito animada. – Você não cansou de dizer isso.
<p>- Vai ser legal.
<p>- Me promete me trazer para casa logo que acabar, eu preciso fazer umas coisas.
<p>- Claro. Esse foi o combinado.
<p>- Tudo bem. Eu vou pegar o meu casaco e a gente já pode ir.
<p>- Vou te esperar lá embaixo.
<p>- Tudo bem. – Temperance voltou para o banheiro.</p>
<center><h4>--*--</h4></center>
<p>O campo de futebol do colégio Carmel naquele dia estava cheio de cadeiras brancas espalhadas para acomodar os formandos e os pais. Em frente as cadeiras havia um pequeno palco onde ficaria os professores e o diretor. Aos poucos os alunos chegavam e se reuniam em grupos para comemorar, se despedir, alguns já estavam chorando.
<p>As cadeiras já estavam quase todas ocupadas quando Jason e Lisa chegaram. Aquela beca estava incomodando Jason.
<p>- Essa beca está pequena demais. – Jason ficava toda hora puxando a beca de um lado para o outro, ele parecia muito desconfortável com aquilo.
<p>- Você que é grande demais, para de mexer, está ótimo assim. – Lisa bateu na mão de Jason para ele parar de desarrumar a roupa.
<p>- Essa gravata também está me incomodando. – Ele afrouxou um pouco o nó da gravata.
<p>- Para, se você mexer, vai parecer um bêbado.
<p>- Prefiro bêbado do que morto asfixiado.
<p>- Exagerado.
<p>- Eu vou procurar a Emily, depois a gente se vê. – Jason estava olhando por todos os lados atrás da namorada.
<p>- Tudo bem, eu já vou me sentar.
<p>- Guarde dois lugares.
<p>- Tudo bem.
<p>Lisa ficou vendo Jason correndo pelo campo. Ela riu em pensar que com aquela capa vermelha, parecia até que ele estava brincando de ser o Super-Homem.
<center><h4>--*--</h4></center>
<p>- Te procurei pela escola toda. A cerimônia já vai começar.
<p>Jason encontrou Emily em frente ao seu armário.
<p>- A escola foi uma droga, mas vou sentir falta dela. – Emily limpava as lágrimas.
<p>- É, quando estivermos velhos, vamos nos lembrar daqui e admitir que era a nossa época mais fácil e a gente reclamava.
<p>- Exatamente isso. – Emily riu.
<p>- Vamos lá fora, depois a gente volta para se despedir, eu trago até uma bomba.
<p>- Você me deixa fazer as honras?
<p>- Mas é lógico. – Jason riu.
<p>- Antes da gente ir, eu preciso te dizer uma coisa. – Emily pegou na mão de Jason.
<p>- O quê?
<p>- Amanhã de manhã eu vou comprar a passagem de trem para Nova York. Você já quer que eu compre a sua também?
<p>- Ah, não precisa.
<p>- Não é incomodo, eu já vou estar lá mesmo.
<p>- Não, é que... – Ele sutilmente soltou sua mão da dela.
<p>- O que foi?
<p>- Emily, você está muito feliz com isso tudo, não está? – As mãos de Jason começaram a suar.
<p>- Mas é claro. Está tudo saindo como a gente queria.
<p>- Você me ama de verdade?
<p>- Por que está me perguntando isso agora? Está parecendo um doido. – Emily estava muito confusa.
<p>- Só me responde.
<p>- Tudo bem, eu te amo. – Ela deu de ombros.
<p>- De verdade? – Jason insistiu.
<p>- De verdade. – Emily concordou.
<p>- Me perdoa pelo o que eu fiz então.
<p>- O que você fez? – Emily ficou desconfiada.
<p>- Eu menti.
<p>- Sobre o quê?
<p>- Eu não fui aceito na Columbia.
<p>- O quê? Por quê? – Emily não parecia exatamente decepcionada.
<p>- É que tem o processo criminal na minha ficha e... eles não aceitam isso.
<p>- Jason, eu sinto muito. Por que você mentiu?
<p>- Bom...
<p>- Onde você foi aceito? – Emily não estava pensando com clareza nas coisas.
<p>- Eu não fui aceito... em nenhuma. – Jason encarou Emily e se preparou para qualquer reação que a namorada fizesse.
<p>- Como assim em nenhuma? – Emily tentou ao extremo ficar calma.
<p>- Emily, eu sinto muito.
<p>- Me explica. Se você não foi aceito em nenhuma, por que você disse... por que você mentiu para mim?
<p>- É que...
<p>- Para qual faculdade você vai então?
<p>- Por enquanto para nenhuma.
<p>- Jason, por que... – Emily não conseguiu terminar a frase. – Você vai para Nova York mesmo assim? – Emily já sabia a resposta.
<p>- Na verdade, eu não vou. Eu...
<p>- Por que disse para mim que iria?
<p>- Emily, você estava muito feliz e eu não queria...
<p>- Estragar tudo? Tarde demais, Jason. – Emily ficou brava. – Você mentiu para mim!
<p>- Eu não queria te decepcionar. Eu não podia dizer que fui rejeitado em todas.
<p>- Por que não? Eu sou a sua namorada, iriamos dar um jeito juntos.
<p>- Mas você não precisa dar um jeito nisso. É um problema meu.
<p>- Somos namorados, seus problemas também são meus, você sabe disso.
<p>- Me desculpa, eu não... Eu não pensei nisso.
<p>- Não, você não pensou. Você nunca pensa, não é? Droga, você me enganou esse tempo todo. Você... Você ficou vendo eu fazer planos e mais planos para nós e ficou quieto como se estivesse tudo bem.
<p>- Eu só queria que você ficasse feliz.
<p>- Eu não estou feliz, Jason! – Emily gritou. – Não me interessa se você foi rejeitado na faculdade, não me interessa se você vai ou não para Nova York, eu só queria que você fosse sincero comigo.
<p>- Eu sei.
<p>- Não sabe, não, senão não teria mentido para mim. Como eu vou confiar em alguém que não me diz a verdade?
<p>- Emily, você está exagerando.
<p>- Acha isso um exagero? – Ela arregalou os olhos. – Eu estava contando com você. Eu achava que você estava nessa comigo. Eu estava morta de medo com tudo isso, mas você estaria do meu lado e aí... Bom, agora não importa.
<p>- Emily, não. Eu não queria que você ficasse magoada.
<p>- Eu fiquei que nem boba planejando o que a gente ia fazer lá, onde a gente iria morar, até arranjei dois apartamentos para não te assustar com o lance de morar junto de repente. E você lá concordando com tudo.
<p>- Você precisa entender.
<p>- Eu não entendo, tá bom?
<p>- Por favor, Ems, não vamos brigar logo agora.
<p>- Ah, e que hora você quer brigar? Me diz porque nosso tempo é curto.
<p>- Por isso. Exatamente por isso eu não quero brigar.
<p>- Você é inacreditável, sabia? – Emily ficou com os olhos vermelhos.
<p>- Você tem que me perdoar. A gente se ama.
<p>- E o que a gente ganha com isso?
<p>- Eu não sei. Eu quero ficar com você.
<p>Emily ficou em silêncio olhando para Jason.
<p>- Eu sinto muito. – Ele repetiu.
<p>- Não importa mais, Jason. Porque daqui alguns dias, eu vou estar bem longe daqui e você só vai ser mais uma lembrança ruim do colégio.
<p>Emily deu as costas para Jason e foi embora correndo.
<p>- Emily, espera! Mas que droga!</p>
<center><h4>--*--</h4></center>
<p>- Senhoras e senhores, eu apresento a vocês a turma de formandos do Colégio Carmel do ano de 2012. - Houve uma salva de palmas após o diretor falar.
<p>Os alunos, um por um, começaram a subir no palco assim que seus nomes eram anunciados para receber o seu diploma e voltar para as suas cadeiras.
<p>- Emily Cooper!
<p>Emily limpou as lágrimas e foi buscar o seu diploma. Sua mãe gritou bem alto quando ela subiu no palco, ela sorriu para a mãe torcendo para descer dali logo. Emily evitou olhar muito para a plateia com medo de cruzar o olhar com Jason.
<p>- Jason Porter!
<p>Jason foi receber o seu diploma. Seus pais não estavam na plateia para o aplaudir, mas Lisa aplaudia muito. Ele conseguiu ver Emily sentada o observando. Ele com certeza era um idiota e tudo o que ele tinha feito naquele ano confirmava.
<p>- Kol Sloane!
<p>Kol subiu animado para pegar o seu diploma. Ele se lembrava em como a Andressa sempre pedia que no dia da formatura ele ficasse muito feliz e orgulhoso já que seria um grande dia. Ficar animado era o jeito dele de honrar a memória dela.
<p>- Maddie Sloane!
<p>Maddie cumprimentou todo mundo que estava sentado nas suas cadeiras em cima do palco antes de ir pegar o diploma. Ela estava muito nervosa, daqui a alguns minutos estaria falando com todo mundo.
<p>- Lisa Stilinski!
<p>Lisa sorriu para todos ao pegar o diploma. Até aquele momento estava tudo perfeito. Ela encontrou Jason na multidão, ele estava aplaudindo e sorrindo para ela. De repente ela se sentiu mais segura.
<p>- Nathan Grey!
<p>Nathan estava muito feliz. Ele se esforçou muito por aquele diploma, ele merecia aquele diploma. Tudo aquilo era só o começo, sua primeira conquista de muitas. Ele só podia comemorar.
<p>- Temperance Granger!
<p>Uns meses atrás, Temperance sonhava com esse momento, mas agora pegando o diploma, ela não estava animada, na verdade, ela só queria que aquilo tudo acabasse para voltar para o seu quarto e terminar o que tinha que fazer que era muito mais importante para ela.
<p>Cada aluno que subia naquele palco para receber o seu diploma estampava um sorriso, às vezes forçado, às vezes verdadeiro, mas não deixavam de sorrir. Muitos pareciam realizados e outros aliviados por passarem por essa fase.
<p>- E por último, Brandon Schmutz, que aonde quer que esteja, merecia estar aqui como todo mundo.
<p>Todo mundo se levantou para uma salva de palmas para homenagear Brandon.</p>
<br>
<p>- Distintos convidados, pais, professores e formandos. Quando eu descobri que seria a oradora da turma, eu confesso que fiquei assustada. Eu pensei: quem sou eu para dizer algo para dar esperança a alguém? Bom, agora eu sei. Eu sou alguém especial, assim como vocês. Somos todos especiais e nós temos o poder, o poder de mudar, de evoluir, de aprender, de agir e o grande poder de sermos quem somos ou quem deveremos ser. Essa é a hora de todos nós nos jogarmos no mundo, de correr riscos, de não ter medo, de perseguir e realizar os nossos sonhos. Não vai ser fácil, mas assim como conquistamos os nossos diplomas, podemos conquistar ainda mais, porque nós somos fortes, porque nós merecemos. Eu não quero ficar aqui uma hora falando coisas que todos nós já sabemos então, eu vou fechar logo a boca. Só quero dizer que a formatura não é o fim, é só o começo, e se você acha que acabou, que é o fim da sua história, comece a escrever outra, porque a nossa vida não é só uma história, é uma saga.
<p>Então Maddie sentiu o calor dos aplausos e sorriu.</p>
</body></html>";
            }

            if (numero == 30)
            {
                lblTitulo.Text = "Capítulo 30 - Caminhos Separados";
                htmlPage.Html = @"<html><body>
<p>Estava tudo uma zona. Era gente gritando, papéis sendo jogados por todo lado, flashes aqui e ali.
<p>- A cerimônia estava ótima. – Jason foi a primeira pessoa que a Sra. Stilinski achou para abraçar. – Parabéns, querido.
<p>- Muito obrigado. – Jason se soltou logo do abraço apertado e tirou o chapéu de formatura que ele odiava.
<p>- Bom, a sua mãe ficou muito triste por não poder vir.
<p>- Eu imagino. – Jason começou a arrumar o cabelo que estava amassado por causa do chapéu.
<p>- Não, é sério. Ela até me fez prometer que eu filmaria cada detalhe da cerimônia.
<p>- É, eu vou ligar para ela depois. Mostrar que eu realmente peguei o diploma.
<p>- Cadê a Lisa? – A mãe dela estava olhando por todos os lados atrás de Lisa.
<p>- Eu não sei. Já deve ter ido para casa pegar as malas. – Jason riu.
<p>- Por que ela faria isso?
<p>- Ah, eu achei que ela já iria embora com vocês, ela ficou dias...
<p>- Não, ela me ligou uns dias atrás e disse que ficaria mais um pouco aqui. – Sra. Stilinski ficou meio confusa.
<p>- Ah é?
<p>- É, ela disse que precisava fazer umas coisas com você. – De repente ela parou de falar, percebeu que já tinha falado demais.
<p>- Ela deve ter falado que eu estava com problemas. Exagero dela, a senhora sabe como ela é.
<p>- É, eu sei. – Ela riu para disfarçar.
<p>- Eu vou conversar com ela e perguntar se ela está louca. – Jason brincou para disfarçar o desconforto também.</p>
<center><h4>--*--</h4></center>
<p>- Está entregue como prometido. – Nathan levou Temperance até o quarto dela.
<p>- Muito obrigada, mas não precisava ter subido até aqui comigo.
<p>- Bom, você podia mudar de ideia e a gente podia sair para comemorar a formatura. – Nathan estava dando essa ideia para Temperance o caminho todo da escola até em casa.
<p>- Talvez mais tarde. Agora eu...
<p>- Precisa fazer uma coisa, eu sei. Quer ajuda?
<p>- Não. Eu vou ficar bem. – Temperance sorriu para disfarçar e fazer Nathan ir embora logo.
<p>- A gente se vê depois então. – Nathan beijou Temperance, se despediu e foi embora.
<p>Temperance esperou Nathan sair do quarto dela para se abaixar e pegar uma caixa de papelão que ela escondia embaixo da cama. Já havia algumas coisas na caixa, como fotos e alguns livros. Temperance começou a olhar pelas gavetas do guarda roupa e prateleiras na estante e pegava coisas como bichos de pelúcia, cartões e até mesmo CDs e peças de roupas e colocava tudo na caixa.
<p>Temperance sabia onde tinha que levá-la.</p>
<center><h4>--*--</h4></center>
<p>- Você perdeu o jantar de comemoração em família. – Lisa chegou em casa bem tarde. Jason estava esperando no sofá.
<p>- É, e você não foi embora com eles. – Jason encarou a amiga.
<p>- Acho que eu vou amanhã. – Lisa se sentou ao lado de Jason.
<p>- Eu menti para a Emily e agora você está mentindo para mim. Eu disse a verdade a ela, agora diga a verdade para mim.
<p>- Você contou para ela? O que ela disse?
<p>- Você primeiro. – Jason insistiu.
<p>- Tudo bem, que tipo de amiga eu seria se eu deixasse você?
<p>- Uma amiga esperta.
<p>- Olha, se a gente trabalhar junto, podemos mexer no seu currículo e em um ano, você vai estar em uma das melhores faculdades do país.
<p>- Você promete? – Jason fingiu entusiasmo.
<p>- Claro. – Lisa se animou.
<p>- Eu não falei sério. – Jason ficou sério. – Olha, se você adiar a sua ida, talvez a faculdade não te aceite mais.
<p>- Não é verdade.
<p>- É, sim. Não pode trancar a matricula antes mesmo de se matricular.
<p>- A gente pensa nisso depois, primeiro...
<p>- Lisa, não. – Jason a interrompeu. – Olha, eu queria ir para Nova York por causa da Emily, só por isso. Eu não tinha planos, nem sabia direito o que iria fazer na faculdade, eu nem sabia se eu queria ir para a faculdade.
<p>- Onde quer chegar?
<p>- Eu não estava fazendo aquilo por mim, estava fazendo por ela. Você tinha razão. Só que agora eu não quero que perca um ano da sua vida por minha causa.
<p>- Não é por sua causa, é por minha causa.
<p>- Lisa. – Jason segurou a mão da amiga. – Você é a minha melhor amiga e eu quero que a sua vida seja perfeita. O que eu não quero é te segurar aqui por mais tempo do que deveria. Eu não sou tão egoísta assim.
<p>- Não se trata disso.
<p>- Eu vou encontrar o meu caminho. Eu sei disso.
<p>- Eu também sei, mas...
<p>- Mas nada. Seus sonhos vão se realizar e eu vou ser o primeiro a te parabenizar, porque amigo é para isso.
<p>- O que ela disse?
<p>- Não importa. Ela vai embora e eu vou ficar, só adiantamos o inevitável.
<p>- Eu sinto muito.
<p>- Para. Não precisa.
<p>- Eu te amo, sabia?
<p>- É lógico que ama. – Jason abraçou Lisa.</p>
<center><h4>--*--</h4></center>
<p>Emily acordou bem cedo naquele dia. Na verdade, ela mal conseguiu dormir pensando na formatura, na viagem, no Jason. Comprar as passagens foi a primeira coisa que veio na cabeça dela assim que ela acordou. Agora que estava sozinha de novo, ela mal podia esperar para sair daquela cidade.
<p>Após comprar as passagens, Emily se encontrou com Lisa na cafeteria que elas sempre costumavam tomar café juntas.
<p>- Então você sabia? – Emily tinha acabado de contar sobre a briga que teve com o Jason.
<p>- Bom, eu estava com ele quando abriu as cartas das faculdades. – Lisa falou sem graça. – Me desculpa, eu disse para ele te contar, mas ele é meu melhor amigo, eu não podia...
<p>- Tudo bem, eu entendo. – Emily não tinha ficado brava. – Você não podia trair o seu amigo.
<p>- E você pretende perdoá-lo quando?
<p>- Eu não sei. Eu vou embora amanhã.
<p>- Mas já? – Lisa ficou surpresa.
<p>- Quanto mais rápido é melhor, não é o que dizem?
<p>- Ninguém diz isso.
<p>- Nada mais me prende aqui, Lisa, e ir embora desse jeito é melhor.
<p>- Como assim melhor?
<p>- Bom...
<p>- Ai, meu Deus, você não está mais brava com o Jason, está? – Lisa sacou tudo.
<p>- Eu nunca deixei de ficar brava com o Jason desde que eu o conheci.
<p>- Emily...
<p>- Faz ser mais fácil assim. Separados, a gente não precisa se despedir e eu sei que se a gente for se despedir ou eu não consigo ou isso vai acabar comigo.
<p>- Sem se despedir, essa é uma boa. – Lisa ficou brava. – Não vai nem pegar as coisas que namorados deixam nas casas dos namorados?
<p>- Eu já deixei as coisas dele tudo em uma caixinha que eu vou levar embora, é claro. – Emily riu.
<p>- Se você quiser, eu pego as suas coisas escondida dele.
<p>- Não, não precisa. Não tem nada demais.
<p>- Eu tenho umas coisas na casa do Brandon também. Quando eu estava arrumando as malas ontem, eu percebi.
<p>- E você pediu para o Jason ir buscá-las. – Emily adivinhou.
<p>- Exatamente.
<p>- E quando você vai embora?
<p>- Logo.
<p>- Vai ao cemitério antes de ir?
<p>- Eu preciso.</p>
<center><h4>--*--</h4></center>
<p>Temperance subiu as escadas segurando a caixa. Aquelas escadas tão familiares, ela subia correndo aqueles degraus quando era pequena ou quando estava muito animada ou ansiosa para ver o melhor amigo.
<p>O quarto do Brandon ainda estava do mesmo jeito. Temperance percebeu que a mãe dele mal havia tocado nas coisas do filho. Havia algumas coisas encaixotas, mas a maioria ainda estava no mesmo lugar. Temperance colocou a sua caixa em cima da cama.
<p>- Bran, cadê você?
<p>- Com quem você está falando?
<p>Temperance olhou para a porta assustada e deu de cara com Jason a olhando parecendo confuso.
<p>- Com ninguém. O que faz aqui?
<p>- Posso te perguntar o mesmo.
<p>- Eu te perguntei primeiro. – Temperance ficou nervosa.
<p>- Bom, estou querendo roubar algumas coisas do morto. – Jason riu, mas Temperance não gostou da brincadeira. – A Lisa percebeu que tinha umas coisas dela aqui. A mãe do Brandon disse que ela colocou tudo em uma caixa perto da porta. – Jason pegou uma pequena caixa do lado da porta. – Sua vez de responder.
<p>- Eu resolvi seguir em frente.
<p>- Por isso veio visitar o quarto dele? – Jason não entendeu. – Não é um bom jeito de...
<p>- Não, eu vim deixar umas coisas. – Temperance apontou para a caixa em cima da cama.
<p>- Que coisas?
<p>- Algumas fotos, alguns presentes de aniversário, natal e essas coisas.
<p>- Não precisa fazer isso. E quando quiser algo para lembrar dele ou sei lá?
<p>- Lembrar me traz dor, eu não quero mais dor. Eu não quero lembrar.
<p>- Tempe, não é assim que as coisas funcionam.
<p>- Você não sabe como as coisas funcionam.
<p>- Bom... – Jason ia concordar com ela.
<p>- Você pode me deixar um pouco sozinha? Eu quero me despedir.
<p>- Tudo bem. Eu vou te esperar lá embaixo.
<p>- Não precisa...
<p>- Eu vou te esperar. – Jason saiu do quarto
<p>Temperance ouviu Jason descer as escadas, então ela se sentou na cama.
<p>- Olha, eu já fui muito no cemitério e mesmo assim eu não consegui superar, então resolvi vir aqui e parece que está dando certo. – Temperance começou a olhar para os detalhes do quarto. – Ainda não comecei a chorar, não é? Me diz o que eu preciso fazer, quer que eu queime tudo? Eu queimo.
<p>- Não precisa queimar nada, Tempe.
<p>Temperance viu Brandon sorrindo para ela em pé perto da janela.
<p>- Sai da minha cabeça, por favor.
<p>- Eu só quero te ajudar.
<p>- Você não está me ajudando. Você só... – Temperance sentiu as lágrimas escorrendo pelo rosto.
<p>- Você estava enganada, eu estava enganado. Você não foi a culpada, nem eu, nem ninguém. Aquela coisa que me destruiu. – Brandon apontou para o seu computador.
<p>Temperance se levantou e ligou o computador.
<p>- O que você quer de mim? – Temperance não entendia nada.
<p>- Só quero te ver bem. Só quero que siga em frente.
<p>- Como?
<p>- Olha para a tela do computador.
<p>Temperance olhou para o computador. Os posts do blogueiro estavam todos espalhados pela tela.
<p>- Isso me matou, Tempe. Isso que acabou comigo. Você não teve culpa nenhuma.
<p>- Mas eu...
<p>- Eu sempre tinha isso guardado e eu não conseguia viver desse jeito. Aí eu achei que se falasse, mesmo que no anonimato, ia me deixar mais leve, mas não adiantou.
<p>- Bran...
<p>- Esse computador é como o meu interior. Ele me pesou ainda mais e me deixou louco. Ele destruiu a minha vida. – Brandon falava calmamente.
<p>- Você quer que eu...
<p>- Destrua ele, destrua ele como ele me destruiu.
<p>- Eu não posso. – Temperance limpou as lágrimas.
<p>- Acaba com isso, Tempe.
<p>- Não.
<p>- Vai. – Brandon começou a ficar bravo. – Acaba logo com isso.
<p>- Não posso.
<p>- Vai, Temperance! – Brandon gritou no ouvido de Temperance.
<p>- Não!
<p>Temperance jogou o monitor do computador no chão.
<p>- Ele causou a minha morte! – Brandon continuava a gritar.
<p>- Para! – Temperance foi até a cama e pegou a caixa. – Me deixa! – Ela jogou a caixa no chão também.
<p>As fotos se espalharam pelo chão. Os CDs até chegaram a sair da embalagem e os livros se abriram no impacto.
<p>- Enquanto você não acabar com isso...
<p>- Você tem que sumir! – Temperance tampou forte os ouvidos com as mãos. – Sai daqui!
<p>- Tempe, eu quero te ajudar!
<p>- Sai! Sai! – Temperance andava de um lado para o outro pelo quarto.
<p>- Tempe!
<p>- Pare! Por favor, pare! – Temperance continuava a gritar. – Socorro! Socorro!
<p>Temperance sentiu alguém segurar os braços dela para ela não quebrar mais nada.
<p>- Tempe, se acalma. – Não era mais a voz de Brandon que a Temperance ouvia. – Tempe, calma.
<p>Jason abraçou Temperance com força para ela parar de se debater.
<p>- Tempe, se acalma.
<p>- Me ajuda. – Temperance estava sussurrando. – Ele vai me deixar louca, me ajuda.
<p>- Eu vou te ajudar. – Jason estava assustado. – Só se acalma.
<p>Temperance encarava Jason com os olhos bem abertos e cheios de lágrimas, mas por alguns instantes Jason podia jurar que Temperance mal o reconhecia pela expressão que ela fazia. Ele não sabia o que fazer.</p>
<center><h4>--*--</h4></center>
<p>- Quer dizer que resolveu estrelar algum filme de guerra?
<p>- Seria uma boa. – Kol riu para Lisa.
<p>Kol já estava cansado de despedidas. Teve que deixar um pai, uma mãe e uma irmã aos prantos em casa. Ele não esperava encontrar Lisa na rodoviária. Ele colocou suas mochilas no chão e foi até Lisa.
<p>- O que faz aqui, Lisa?
<p>- Fui até a sua casa me despedir e a Maddie disse que estaria aqui.
<p>- Não devia ter vindo.
<p>- Tem razão. Mas eu sempre faço coisas que não devo. – Lisa sorriu. – Não acredito que vai virar soldado. Olha só para você.
<p>Kol já estava com o seu uniforme.
<p>- Espero te deixar orgulhosa.
<p>- Eu só espero que você não morra. – Lisa riu de novo.
<p>- Você também já vai embora?
<p>- É, eu vou pegar um avião à noite.
<p>- Olha, eu...
<p>- Não vamos nos despedir com sinto muito ou me desculpa. Você até que foi uma grande companhia para mim.
<p>- Até? Nossa. – Kol riu.
<p>- Você entendeu.
<p>- É, eu entendi. Eu também amei conhecer você. Era tudo o que eu precisava.
<p>- Você vai ficar bem? – Lisa parecia preocupada. – A Maddie estava chorando sem parar.
<p>- Ela vai superar, além do mais, vou estar em casa no Natal.
<p>- Não queira bancar o herói, tá bom? Eles nunca têm futuro.
<p>- Qual é a graça de virar soldado e não querer bancar o herói? – Kol riu.
<p>- Tem razão, não tem graça nenhuma. – Lisa entrou no jogo. – Não achei que diria isso, mas vou sentir a sua falta.
<p>- Eu também vou sentir a sua.
<p>- Quando eu chegar na faculdade e perceber que as fraternidades estão entrando em guerra, eu vou te chamar.
<p>- Acho que eu não me alistei para isso.
<p>- Me mande notícias.
<p>- Mando, sim.
<p>Kol abraçou Lisa.
<p>- Me desculpa pelo beijo.
<p>- Foi o seu primeiro ato de coragem e foi um babaca. Use esse exemplo para a vida. – Lisa bateu no ombro dele.
<p>- Pode deixar.
<p>Lisa ficou observando Kol entrar no ônibus que dentro de algumas horas levaria ele até o campo dos fuzileiros para começar o treinamento. Ela nunca tinha conhecido um soldado antes, era estranho saber que um conhecido dela iria para a guerra. Era angustiante, na verdade.
<p>Seu celular tocou.
<p>- Alô!
<p><i>- Lisa, sou eu.</i> – Jason parecia assustado pelo telefone.
<p>- Jason, o que foi?
<p><i>- É a Tempe, ela está muito mal.</i>
<p>- O que ela tem?
<p><i>- Vem para o hospital agora.</i>
<p>- Que hospital?
<p><i>- Bom... </i>– Jason hesitou. <i>– O hospital psiquiátrico de São Luís.</i></p>
<center><h4>--*--</h4></center>
<p>- Temperance! Temperance!
<p>Nathan entrou que nem um desesperado no quarto do hospital.
<p>- O que aconteceu com você? – Nathan estava nervoso olhando para Temperance.
<p>Temperance estava deitada na cama, já com roupa de hospital. Uma enfermeira estava ao seu lado aplicando uma agulha em uma das suas veias do braço esquerdo. Ela estava quase dormindo e mal ouvia Nathan.
<p>- O que foi que houve? – Nathan tirou os olhos de Temperance e deu uma olhada na sala. Havia um médico na sua frente, Jason, Emily e Lisa estavam em um canto da sala, e ele estava lá, ao lado de Temperance totalmente perdido.
<p>- Você é o que dela? – O médico finalmente se pronunciou.
<p>- Eu sou o namorado dela. – As mãos de Nathan estavam tremendo enquanto segurava a mão gelada de Temperance.
<p>- Bom, a Temperance vai precisar ficar internada. Os pais dela já estão lá fora assinando os papéis.
<p>- O quê? Mas por quê?
<p>- Ela teve um ataque de pânico. – O doutor começou a explicar. – Não conseguimos conter e ela precisou ser dopada.
<p>- Ataque? Como?
<p>- Eu estava lá. – Jason começou a falar. – Ela ficou muito assustada. Gritava sem parar.
<p>- Mas ela estava bem. Ela... ela estava bem. – Nathan começou a chorar.
<p>- Não é permanente. – O doutor advertiu. – Ela só precisa de um tratamento, ela passou por um grande trauma. Ela precisa disso.</p>
<center><h4>--*--</h4></center>
<p>Jason saiu do quarto junto com Lisa e Emily.
<p>- Não acredito que isso aconteceu com ela. – Lisa estava abalada.
<p>- O médico disse que é estresse pós-traumático e que é por pouco tempo, ela vai ficar melhor. – Emily queria ter esperança, mesmo que ainda estivesse um pouco assustada.
<p>- Ela vai melhorar, eu sei disso. – Jason estava olhando Temperance e Nathan pela janela.
<p>- Gente, eu preciso ir. – Emily então falou.
<p>Jason ficou surpreso quando Emily falou que ia embora.
<p>- Mas j-já? – Ele gaguejou.
<p>- Eu vou embora amanhã de manhã, então... – Na verdade, Emily queria mesmo era ficar longe de Jason.
<p>- Claro, é verdade. – Jason começou a evitar contato visual.
<p>Emily e Lisa se abraçaram e se despediram uma da outra.
<p>- Quando chegar em Los Angeles, eu quero fotos. – Emily sorriu para a amiga.
<p>- Pode deixar. – Lisa riu. – Se cuida.
<p>- Tchau, Jason. – Emily olhou para Jason.
<p>- Tchau, Emily.
<p>Jason se sentou no chão assim que Emily foi embora. Lisa se ajoelhou ao seu lado.
<p>- O que foi? – Lisa pegou na mão de Jason.
<p>- Ela está muito mal. Eu sou um péssimo amigo.
<p>- Jason, ela vai ficar bem.
<p>- Eu nunca a vi daquele jeito e nunca achei que veria. Eu achei que ela estava melhorando.
<p>- Ela vai. – Lisa abraçou Jason.
<p>- Eu devia ter ficado do lado dela. Eu devia ter visto isso acontecendo.
<p>- Você fez o possível.
<p>- Não foi o suficiente. Eu ignorei, me afastei.
<p>- Não pensa nisso agora. Pensa que ela está em um hospital, vai receber um tratamento e vai melhorar. – Lisa tentava ser forte mesmo também estando um pouco abalada.
<p>- Você já tem que ir também, não é?
<p>- É, meu voo é daqui algumas horas.
<p>- Então se levanta e vai.
<p>- Sabia que essa vai ser a primeira vez que vamos nos separar desde que viramos amigos?
<p>- É, se isso não atrapalhar a nossa amizade, nada mais vai. – Jason riu.
<p>- Me promete uma coisa?
<p>- Eu vou te ligar todos os dias, eu juro.
<p>- Não é isso, quer dizer, isso também, mas... Me deixe orgulhosa. Não deixe mais nada te impedir de descobrir o que você quer da vida.
<p>- Prometo.
<p>- Olha, eu sei que você vai ficar agora focado na melhora da Temperance junto com o Nate, mas...
<p>- Eu sei, eu vou dar um jeito, pode deixar.
<p>- Eu vou te ligar assim que chegar em casa e me mantenha informada sobre a Temperance.
<p>- Claro. – Jason beijou o rosto de Lisa. – Agora vai embora daqui. – Ele riu.
<p>- Tudo bem. – Lisa se levantou. – Uma última coisa, o trem que ela vai pegar sai às onze da manhã.
<p>- O quê? – Jason se fez de desentendido.
<p>- Você não pode fazer nada pela Temperance agora e pode deixar para resolver o seu futuro a partir de semana que vem, mas o amor da sua vida vai embora amanhã, não deixa acabar desse jeito.
<p>- Mas eu...
<p>- Mas nada. Ela te ama. Não deixa ela ir embora sem saber que você também a ama.
<p>- Ela sabe disso.
<p>- Mas falar mais uma vez não custa nada.</p>
<center><h4>--*--</h4></center>
<p>- Você vai ficar bem, tá bom? – Nathan ainda segurava a mão de Temperance.
<p>- Vai demorar? – Ela estava quase dormindo, mas ainda conseguia ouvir Nathan.
<p>- Não, vai ser bem rápido, eu prometo.
<p>- Você vai embora? – Nathan sabia que Temperance estava falando meio mole por causa dos remédios que ela estava tomando.
<p>- Eu vou ficar aqui e só vou sair quando você puder sair comigo.
<p>- Eu não quero ficar sozinha. – Temperance começou a chorar.
<p>- Não vai. Eu vou sempre estar aqui, lembra?
<p>- Me desculpa.
<p>- Pelo quê?
<p>- Por fazer isso, eu não queria.
<p>- Está tudo bem.
<p>- Me perdoa, por favor. – Temperance suplicou.
<p>- Eu te perdoo. – Nathan resolveu falar logo para ela esquecer.
<p>- Obrigada. – Ela quase não conseguiu sorrir.
<p>- Olha, daqui alguns dias, você vai sair daqui e nós dois vamos juntos para faculdade, vamos sair dessa cidade e vamos ser felizes.
<p>- Como a gente combinou. – Temperance conseguiu sorrir.
<p>- Como a gente combinou. – Nathan repetiu.
<p>- Como a gente combinou... – Temperance fechou os olhos.
<p>- Eu te amo, Temperance.
<p>- Eu também te amo... Bran... você é o meu melhor amigo.
<p>- Eu sei. – Nathan fechou os olhos e tentou lidar com a informação.
<p>Nathan pegou uma cadeira, ficou sentado lá segurando a mão de Temperance e observando ela dormir. Amanhã ela estaria bem melhor, amanhã ela o reconheceria, ele precisava pensar nisso.</p>
<center><h4>--*--</h4></center>
<p>- É, eu demorei, mas eu vim.
<p>Lisa colocou uma orquídea em cima da lápide de Brandon.
<p>- Embora seja estranho e assustador eu só vir aqui à noite. Eu estou tremendo de medo de que apareça alguma alma penada para me assustar, mas eu não podia ir embora sem me despedir. Sabe, eu nunca pensei o que aconteceria com a gente quando fôssemos para faculdades separadas, mas isso de morte era a única coisa que eu achava impossível de acontecer. Eu sei que você me esperava aqui bem antes, tipo no seu enterro, mas eu não consegui, alguma coisa me fazia travar e eu sinto muito por isso, mas eu estou aqui agora, e isso conta, não conta? – Lisa começou a chorar. – Eu te amava, você sabia disso, não sabia? Eu nunca tinha me apaixonado assim por alguém, você me deixava diferente, um diferente bom. Ficar e falar com você era a melhor parte do meu dia. Eu sinto muito por você ter ido tão cedo. Pode parecer loucura, depois de tudo o que aconteceu entre a gente, mas eu ainda tinha esperança, se você tentasse bastante, eu poderia até ceder. Bom, eu já tenho que ir, mas eu sempre vou lembrar de você, sempre, e não como o blogueiro, mas como o cara que eu mais amei na vida.
<p>Lisa fechou os olhos, tentou imaginar Brandon ali parado na sua frente ouvindo tudo o que ela dizia.
<p>- Adeus, Bran. Eu ainda te amo.
<p><i>“Eu também te amo, Lisa.”.</i></p>
<center><h4>--*--</h4></center>
<p>O telefonema de Lisa acordou Jason bem cedo. Ela havia ligado para dizer que já tinha chegado em casa.
<p>Jason saiu de casa sem nem mesmo tomar café. De repente, ele se sentiu sozinho. Sua melhor amiga estava quase do outro lado do país, Temperance estava no hospital e nem o Brandon estava por perto para ele poder irritar ou criticar. Kol havia ido para o exército e a Emily estava prestes a ir embora para sempre.
<p>O que ele ainda fazia lá? Não tinha mais nada para ele ali. Lisa o fez prometer ir se despedir de Emily, mas ele não podia cumprir aquela promessa, isso só ia o destruir mais do que já estava destruído. Já tinha acabado, tudo estava acabado.
<p>Ele se lembrava da primeira vez que tinha ido àquela praça. Era de noite e ele estava com muita raiva de algo que o blogueiro havia falado sobre ele, ele nem lembrava mais o que era. Ver aquelas árvores o irritava mais ainda, ele as derrubaria na época se pudesse. Mas agora ele não estava mais bravo, ele estava triste.
<p>Não havia ninguém por perto, todo mundo ainda estava dormindo, pensou ele. Como ele queria que ela aparecesse...
<p>- O que faz aqui a essa hora? – Maddie deu um susto em Jason.
<p>- Quer que eu tenha um ataque cardíaco? – Jason fechou a cara.
<p>- Me desculpa. Eu estava passando por aqui e vi você.
<p>- Devia ter passado direto. – Jason comentou.
<p>- Que grosseria. Eu estou indo visitar a Temperance. Não quer ir junto?
<p>- Não, eu vou mais tarde.
<p>- Tudo bem. Você está bem? – Maddie não conseguiu deixar de reparar na expressão de Jason que não estava muito boa.
<p>- Não, eu não estou muito bem.
<p>- Eu sei como é. Meu irmão foi para a guerra então eu estou tentando não pensar nisso.
<p>- Como?
<p>- Me concentrando no futuro. Eu vou para a faculdade e serei uma grande veterinária, então um dia um moço vai atropelar um cachorro bem perto do meu consultório, eu vou ajudar a cuidar dele, vamos conversar a noite toda e então vamos nos apaixonar.
<p>- Vão se casar, ter quatro filhos e serem felizes para sempre. – Jason completou.
<p>- Exato.
<p>- Eu queria viajar como você.
<p>- O que você está procurando aqui, Jason?
<p>- Na primeira vez que eu estive aqui, uma garota apareceu do nada e me disse que eu parecia perdido. Ela tinha razão.
<p>- Você ainda está perdido?
<p>- Estou. Mas agora é diferente, eu quero me encontrar.
<p>- Olha, eu não tenho certeza, mas eu acho que você pode tentar se encontrar na estação de trem. – Maddie o aconselhou.
<p>- Eu posso estragar mais do que já estraguei.
<p>- Ou pode consertar. Você nunca vai saber se não ir.
<p>- Você pode estar certa.
<p>- Eu sempre estou.
<p>- Seu irmão vai ficar bem. Vaso ruim não quebra. Ele é durão.
<p>- Eu sei. – Maddie sorriu.</p>
<center><h4>--*--</h4></center>
<p>Emily olhou no relógio. Faltava alguns minutos para o trem sair. Não tinha muita gente na estação e as poucas pessoas que estavam lá estavam quietas. Emily olhava de um lado para o outro o tempo todo, com o celular na mão para não perder nenhuma futura ligação ou mensagem de texto.
<p>- Você parece alguém perdida.
<p>Ela então ouviu uma voz conhecida. Aquela voz que arrepiou todo o seu corpo. Ela não estava mais ansiosa.
<p>Emily ficou observando Jason indo em direção a ela.
<p>- Está enganado. Mas tudo bem, além do mais, você nem me conhece. – Ela fez cara de confusa. Ele tinha respondido do mesmo jeito quando se conheceram há quase um ano. Era engraçado lembrar daquilo.
<p>- Não, mas deveria. Estava procurando alguém?
<p>- Só o meu namorado, ex na verdade.
<p>- Ex por quê? Vocês brigaram?
<p>- Ele estragou tudo e eu estava esperando ele chegar e estragar mais ainda.
<p>- Eu acho que você estava esperando ele chegar e salvar o dia. – Jason bancou o presunçoso.
<p>- Não, ele nunca faz isso. – Emily sorriu.
<p>- Interessante, ele me parece um babaca.
<p>- Ele é.
<p>- Já ligou para ele? – Jason pegou seu celular.
<p>- Não.
<p>- Lógico que não. Vocês dois são idiotas.
<p>- Prefiro não comentar sobre isso.
<p>- Por que não?
<p>- É particular. Eu não falo com estranhos. – Emily fez cara feia. – A não ser que sejam gatos.
<p>- Então você pode falar comigo. – Jason sorriu.
<p>- Convencido. – Emily sorriu. – O que você faz aqui?
<p>- Eu estou procurando a minha namorada.
<p>- Ah é? Eu conheço?
<p>- Acho que não. Mas pensando bem, seus olhos são parecidos com os dela, me deixam louco também.
<p>- Sério?
<p>- Seríssimo, e o seu sorriso... caramba, o seu sorriso é melhor que o dela.
<p>- Nossa, parece que temos muita coisa em comum. – Emily sorriu.
<p>- É, mas você parece ser bem mais chata que ela, se é que isso é possível.
<p>- Eu diria que é possível. Você é maluco, sabia? – Emily saiu do jogo.
<p>- Culpa sua. – Jason sorriu. – Você sabia que eu ia aparecer, não sabia?
<p>- Eu esperava. Na verdade, eu tinha certeza. – Emily riu dela mesma.
<p>- Que bom que me conhece.
<p>- Jason...
<p>- Olha, eu sei que está com raiva de mim e você tem mesmo que estar, mas...
<p>- Eu não quero brigar agora. – Emily pegou nas mãos de Jason. – Me despedir de você vai ser horrível, mas não me despedir vai ser muito pior.
<p>- Mesmo assim não me ligou. – Jason comentou. – Olha, eu passei dias me odiando por ser como eu sou.
<p>- O quê?
<p>- Eu estava tipo, se eu não fizesse tanta besteira, eu não teria problemas e assim eu entraria na faculdade.
<p>- Mas... – Emily sabia que tinha um “mas”.
<p>- Mas esses problemas me fizeram sair de Los Angeles, vir para Dallas e te conhecer. Foi a melhor coisa. Se eu soubesse disso, eu teria batido em um cara anos antes.
<p>- Você é doido. – Emily riu.
<p>- Uma grande parte de mim está querendo me controlar agora. E se essa parte me controlar, eu não vou te deixar ir embora.
<p>- Basta você pedir que eu fico. – Emily olhou nos olhos de Jason.
<p>- Eu não quero que fique. Eu quero que você vá para Nova York e conquiste o mundo, é isso que eu quero. Mas a minha parte egoísta não pensa assim. Ela fica dizendo na minha cabeça: “fica beijando ela até o trem passar.”.
<p>- Podia dar certo.
<p>- Você me ama, eu te amo, do mesmo jeito que você foi a melhor coisa da minha vida, eu também fui a melhor coisa da sua vida.
<p>- Nossa, por que você não me disse que estava tão modesto hoje?
<p>- Não me amaria se eu não fosse assim.
<p>- Eu tenho minhas dúvidas.
<p>- Olha, eu não tenho ideia do que vai ser de mim agora. Talvez eu vire um surfista, ou sei lá. Talvez um médico, um advogado, talvez locutor de rádio...
<p>- Eu vou te dar uma ideia. Saindo daqui, você corre e faz um teste vocacional.
<p>- Ah, eu já fiz uma vez, me disseram que eu deveria ser contador.
<p>- Você colocou no teste que matava quase todas as aulas de matemática?
<p>- Esqueci de mencionar isso. – Os dois começaram a rir. – Sabe, eu não sei o que vai ser de mim, mas eu sei o que vai acontecer com a gente no futuro.
<p>- Sabe?
<p>- Sei. Não importa se vai ser daqui um ano, ou cinco anos, ou dez anos, você e eu vamos ficar juntos no final. Eu sei disso e eu sei que você também sabe.
<p>- Eu sei, sim. – Emily se rendeu.
<p>- Eu ainda vou me tornar o homem dos seus sonhos.
<p>- Você já é o homem dos meus sonhos. – Emily beijou Jason. – Se torne alguém que, além de ser o homem dos meus sonhos, seja quem você merece ser.
<p>- Quem eu mereço ser?
<p>- O homem mais feliz do mundo.
<p>- Então talvez eu vire um palhaço. – Jason brincou.
<p>- Bom, você ficaria bem sexy de nariz vermelho. – Emily riu.
<p>- Verdade.
<p>- Olha, você tem razão, não importa como ou quando, eu vou ter você de volta para me tirar do sério, me irritar e me irritar ainda mais.
<p>- Estou esperando os elogios.
<p>- Eu estou chegando lá. Eu vou ter você de volta para, além de tudo isso, me fazer a garota mais feliz do mundo.
<p>- Eu amo muito você.
<p>- Eu também te amo demais.
<p>Jason abraçou Emily e a beijou. Os dois ouviram a locomotiva do trem começar a fazer barulho e também já dava para ver o vapor saindo.
<p>- Seu plano vai dar certo. – Emily riu.
<p>- Só vou te beijar por mais cinco minutos e a vitória será minha. – Jason também riu.
<p>- Juntos no final?
<p>- Juntos no final. – Jason prometeu.
<p>Emily pegou suas malas que estavam jogadas no chão e entrou no trem. Jason ficou esperando Emily se sentar e abrir a janela.
<p>- Me liga quando chegar? – Jason gritou.
<p>- Eu vou pensar no seu caso.
<p>- Pense com carinho.
<p>- Tá bom. – Emily riu.
<p>- E não converse com nenhum estranho em Nova York, ouviu?
<p>- Mas e se algum deles for o amor da minha vida?
<p>- Eu sou o amor da sua vida! – Jason sorriu quando viu Emily sorrindo.
<p>Jason seguiu o trem com os olhos até ele dar a primeira curva e desaparecer. Agora, ele tinha muito trabalho para fazer. Depois? Bom, depois ele pegaria outro trem.</p>
</body></html>";
            }
        }

        public void clkAbrirComentar(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MyPopupPage("SegObscuros", condicao.ToString()));
        }

        public void clkAbrirProximo(object sender, EventArgs e)
        {
            if (condicao + 1 > 30)
            {
                DisplayAlert("CAPÍTULOS!", "VOCÊ CHEGOU AO ÚLTIMO CAPÍTULO. CONFIRA OUTRA HISTÓRIA", "OK");
            }
            else
            {
                Navigation.PushModalAsync(new Capitulo6Page(condicao + 1));
            }
        }

        public void clkIrMenu(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MenusView.MenuSegredosObscurosPage());
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
                    irParaParteDois();
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

        async void irParaParteDois()
        {
            if (condicao == 30)
            {
                var action = await DisplayAlert("Segredos Obscuros", "Você deseja ir para Segredos Distantes - Parte 2?", "Sim", "Não");
                if (action)
                {
                    await Navigation.PushModalAsync(new SegredosDistantesView.SegredosDistantesDetailsPage());
                }
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