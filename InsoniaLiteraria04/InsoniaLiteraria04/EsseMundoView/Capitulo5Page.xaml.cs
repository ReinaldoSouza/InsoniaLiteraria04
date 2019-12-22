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
	public partial class Capitulo5Page : ContentPage
	{
        DBFire service;
        public int condicao;

        public Capitulo5Page (int numero)
		{
			InitializeComponent ();
            service = new DBFire();
            condicao = numero;
            mostrarCapituloSalvo("EsseMundoVaiMudar", "Capitulo" + numero.ToString());

            if (numero == 25)
            {
                lblTitulo.Text = "Capítulo 25 - Eu Quero Que Você Seja Mais Feliz";
                htmlPage.Html = @"<html>
<body>
<p><i>“Então só por um minuto
<br>Eu quero mudar de ideia porque isso não parece certo para mim
<br>Eu quero levantar seu espírito
<br>Eu quero te ver sorrir, mas saiba que isso significa que eu terei que partir
<br>Ultimamente, eu ando pensando
<br>Eu quero que você seja mais feliz”
<br><b>Happier – Marshmello e Bastille</b></i></p>
<br>
<p>Era muito estranho para Will não namorar mais a Emily. Era esquisito andar por aqueles corredores sozinho. Não que eles ficassem grudados o tempo todo, mas estar lá e saber que não se encontraria com ela para se beijarem escondidos em alguma sala vazia ou para irem para a biblioteca fazer algo chato era muito estranho. 
<p>- Eu queria mesmo falar com você. – Amanda abordou Will no corredor enquanto ele ia para a sala de aula.
<p>- Bom dia, Mandy. Você está bem? – Will estava mal-humorado então não ligou nenhum pouco de ser sarcástico com a irmã.
<p>- Eu te daria “bom dia” em casa se você ao menos aparecesse por lá. Onde esteve nesses três dias? – Ela estava irritada.
<p>- Você não é nossos pais.
<p>- Onde esteve? – Ela o ignorou e ficou ainda mais irritada.
<p>- Estou dormindo no Jason.
<p>- Aquele infeliz.
<p>- Eu pedi para ele não contar.
<p>- Mas...
<p>- Amigos acima de namoradas. É a regra.
<p>- Eu acho essa regra uma grande porcaria. 
<p>- Por que você está tão brava?
<p>- Porque sim. O Kevin...
<p>- Não quero falar sobre isso. – Will a cortou imediatamente.
<p>- Ótimo. Você já falou com a Emily? – Will sabia que Amanda não ia conseguir se segurar. Até demorou mais do que ele imaginou.
<p>- Não.
<p>- Por que não?
<p>- A gente terminou, Mandy. Se eu for falar com ela, vai parecer que eu estou atrás dela tipo um ex namorado perturbado. 
<p>- Então vai deixar por isso mesmo?
<p>- O que quer que eu faça? Do que vai adiantar eu ir falar com ela? Nós dois já falamos tudo o que queríamos. Não tem mais nada. 
<p>- Mas... – Amanda não sabia o que dizer. 
<p>- Olha, eu não quero me preocupar com a Emily agora. 
<p>- Isso não está certo. 
<p>- É, não está, mas é assim que as coisas são, lide com isso. Agora eu tenho uma aula para ver.
<p>Will estava realmente querendo prestar atenção no que aquele professor de Sociologia estava dizendo, mas estava difícil. Em algum lugar da sua cabeça, Emily ainda estava lá, lutando para ainda ter importância, para não ser esquecida.</p>
<center><h4>--*--</h4></center>
<p>Jason e Amanda estavam almoçando juntos em uma mesa afastada de todo mundo. Depois da briga de luta livre de três dias atrás, os irmãos Jones não estavam mais almoçando juntos. Na verdade, estavam mais separados do que nunca.
<p>- Eu estou irritada. – Amanda jogou os talheres com bastante força em seu prato já vazio.
<p>- Amanda...
<p>- A gente tem que fazer alguma coisa. Eu não posso...
<p>- Não há nada que a gente possa fazer. Além do mais, pode estragar as coisas ainda mais. – Jason havia passado os últimos três dias ouvindo aquilo e dizendo a mesma coisa. Ele era contra a qualquer tipo de intromissão naquele caso. – Não é da nossa conta.
<p>- Will está mal. Ele é meu irmão e seu melhor amigo, é da nossa conta sim. 
<p>- Eu sei que você quer ajudar, está bem? – Ele estava tentando acalmá-la o máximo possível. – Mas talvez eles precisem disso. 
<p>- Como assim?
<p>- Eles estão juntos desde que se conheceram. Talvez eles precisem de um tempo separados para, sei lá, decidirem o que realmente querem. Colocar as coisas no lugar.
<p>- Mas aí a Giovanna vai achar que venceu.
<p>- Mas ela não venceu. Will nunca voltaria com ela, principalmente agora. Como está o Kevin?
<p>- Ainda com o olho roxo. – Amanda falou em tom de deboche. 
<p>- Péssimo.
<p>- O que me lembra... Por que não me disse que o Will estava na sua casa esse tempo todo? Eu deveria imaginar, mas como você não me disse nada...
<p>- Amanda, o Will precisava de um tempo e ele me pediu para não dizer nada. Amigos acima de...
<p>- De namoradas, eu sei. – Amanda o completou bufando. – Regra ridícula. 
<p>- Olha, eu sei que você está preocupada e só quer ajudar o Will. Eu te amo por isso, mas a gente não pode fazer nada.
<p>- O quê?
<p>- A gente não pode fazer nada. – Jason repetiu.
<p>- Não, antes disso.
<p>- Eu sei que está preocupada e só quer ajudar.
<p>- Depois disso. A parte que você diz que me ama.
<p>- Ah, essa parte. – Jason não ficou envergonhado. – Eu te amo, achei que fosse óbvio. 
<p>- É, só que achar não é a mesma coisa que ouvir. 
<p>- Quer ouvir de novo? Eu te amo.
<p>- Eu também te amo. – Ela sorriu. – Mas ainda estou brava. 
<p>- Quando é que você não está brava? – Ele também riu.</p>
<center><h4>--*--</h4></center>
<p>Will já havia dado três voltas naquela mesma estante na biblioteca e estava perdendo a paciência. 
<p>- Você está perdido? – Sebastian apareceu de trás de uma das estantes com um livro na mão. – Precisa de um mapa?
<p>- Como querem que a gente leia livros se é tão difícil encontrar o que você procura aqui? – Will respondeu bravo.
<p>- Quer ajuda? O que você está procurando? – Sebastian começou a olhar os rótulos dos livros.
<p>- A Emily. – Will evitou olhar para Sebastian e seu olhar de reprovação.
<p>- Já falou com ela?
<p>- Eu não vou falar com ela. 
<p>- Eu sinto muito.
<p>- Não precisa dizer isso. – Will estava começando a se irritar com os olhares de dó que recebia sempre que o nome de Emily aparecia na conversa. – A gente só terminou. Não é como se ela tivesse me tirado um rim. Eu vou ficar bem.
<p>- Eu sei, é que agora o seu coração está partido.
<p>- Meu coração está bem. Está até batendo mais rápido que o normal.
<p>- Sabe que não é literal. 
<p>- Olha, esquece isso, tá bom? Eu vou ficar bem. – Will repetiu.
<p>- E quanto ao Kevin?
<p>- O que tem ele?
<p>- Já conversou com ele? 
<p>- Não, e nem vou.
<p>- Will. – Sebastian voltou com seu olhar de reprovação.
<p>- O quê? Para que eu vou ir lá falar com ele? Para ouvir de novo que sou uma pessoa horrível e que tenho inveja do relacionamento dele com a Giovanna? – Will não gritou, mas para um lugar em silêncio absoluto, ele falou alto demais. 
<p>- Eu sei que está bravo.
<p>- Eu estou puto. Sabe, depois que eu bati nele, eu entrei em choque e percebi que fui longe demais, mas depois que eu me recuperei, eu só queria poder bater mais, por isso não voltei para casa. 
<p>- Vocês se livraram de uma boa, sabia? Têm sorte dos nossos pais estarem em lua de mel, sei lá, e que só voltarão mês que vem. Até lá o rosto do Kevin vai estar curado e vocês não vão ter que explicar nada. 
<p>- Onde isso é sorte? Sorte eu teria se o rosto dele ficasse deformado para o resto da vida.
<p>- Para de dizer essas coisas. Ele ainda é seu irmão.
<p>- Então isso se torna uma desculpa para qualquer bobagem que ele fizer?
<p>- Eu faço bobagem o tempo todo e você sempre me dá uma segunda chance. 
<p>- Não é a mesma coisa.
<p>- Por quê? Porque o problema dele não é com drogas?
<p>- Não, porque ele é um idiota.
<p>- Will!
<p>Naquele momento, a voz de Emily começou a gritar na cabeça de Will. “Você não dá a mínima para o seu irmão”.
<p>- Tudo bem, eu vou falar com ele. Está feliz? – Sebastian parecia estar, mas Will não. Na verdade, ele precisaria ficar muito mais calmo do que estava naquele momento se quisesse ter uma conversa civilizada com Kevin.</p>
<center><h4>--*--</h4></center>
<p>Mesmo contra a sua própria vontade, Emily decidiu voltar para a escola para o segundo tempo. Ela sabia que chegar atrasada não ia ajudar em evitar pessoas de acordo com a sua última experiência, o problema é que ela ficou andando pela praia por duas horas até finalmente decidir que devia voltar para a escola.
<p>Seu armário ainda estava sem tinta e instantaneamente ela lembrou de Will e imaginou ele ali sozinho raspando com o que quer que fosse, aquelas letras em preto que formavam “Vadia Caipira” bem grande na porta do seu armário. 
<p>Ela respirou fundo. Não pensaria naquilo. 
<p>Mas não pensar em Will estava cada vez mais difícil.
<p>Emily abriu seu armário e encontrou algo que ela não esperava. Algumas fotos dela com Will estavam pregadas com fita nas paredes do armário. Ela reconheceu aquelas fotos. Eles viviam tirando quando estavam entediados e ele escolheu as piores para colocar ali e mesmo assim era um ato romântico. Jogado no armário, havia uma rosa murcha e um cartão com as palavras “Antes de te comprar uma tranca nova, eu tinha que fazer isso. Amo você.”.
<p>A maioria das pétalas já havia caído, foi então que ela caiu na realidade e percebeu que aquilo já fazia um tempo e que considerando a situação atual, era bem errado. 
<p>- Olha só, você voltou. – Quinn falou da outra ponta do corredor. – Se cansou de passar o dia todo com nossos pais falando no seu ouvido? 
<p>- Na verdade, eu percebi que estava me tornando uma turista na escola como você. Isso sim eu não poderia aceitar. – Emily sorriu.
<p>- Você me diz as coisas mais lindas, maninha. 
<p>- Idiota. 
<p>- O que você estava vendo concentrada de tão interessante?
<p>- Nada. – Emily fechou imediatamente seu armário. – Podemos conversar depois? Preciso ir para a aula. 
<p>- Claro. Como quiser. 
<p>- Não faz isso.
<p>- O quê?
<p>- O que você sempre faz. Não me trata como se eu fosse frágil.
<p>- Eu só disse “como quiser”. – Mas Emily sabia que aquela simples frase significava ainda mais. – Tá, tudo bem. Eu estou preocupada com você.
<p>- Eu estou bem. 
<p>- Já viu o Will?
<p>- Acabei de ver. Tchau.
<p>Emily saiu andando mais rápido para evitar perguntas que ela não tinha respostas.</p>
<center><h4>--*--</h4></center>
<p>Will estava inquieto. 
<p>Não estava pronto para ir para a casa ainda, mas também não queria ir para a casa do Jason, mesmo não querendo se intrometer, o amigo fazia umas perguntas que ele odiava responder. 
<p>Ele poderia dormir ali na praia. Não estava muito quente, nem muito frio, a temperatura perfeita. A areia não falava e o mar não ficava encarando, era perfeito para ele. 
<p>- O que você está fazendo uma hora dessas na praia sozinho? – Will ouviu uma voz atrás dele. Uma voz que era familiar, mas que ele não podia dizer que conhecia.
<p>- Eu posso te perguntar a mesma coisa. – Ele virou o pescoço e viu a garota. 
<p>- Sou nova aqui. Queria conhecer a praia. 
<p>- Melissa, não é? – Ele se lembrou.
<p>- Ou Melinda, como preferir. – Ela se sentou ao lado dele com um pouco de cuidado. – Estão procurando por você. Acho que até já te ligaram. 
<p>- É, eu geralmente ignoro esse tipo de ligação. – Will sorriu. – Sebastian disse que você é tímida. Como conseguiu me abordar aqui sem gaguejar?
<p>- Não é assim que funciona. É mais fácil em lugares abertos e com uma pessoa só. O que faz aqui?
<p>- Eu acabei de terminar um namoro. Não posso ficar aqui me lamentando?
<p>- É claro que pode. O país é livre. 
<p>- É. 
<p>- Você não está bem. 
<p>- E chegou nessa conclusão porque...
<p>- Pessoas que estão bem não ficam sozinhas na praia à noite.
<p>- Às vezes, ficam. Vai dizer que sente muito?
<p>- Não se não quiser ouvir.
<p>- Ótimo. 
<p>- Além do mais, não é o fim do mundo.
<p>- Claro e o mundo ainda está cheio de garotas. 
<p>- Eu não ia dizer isso. – Melissa riu. – Eu ia dizer que talvez seja só uma fase ruim e que se vocês se amam de verdade, vão voltar. 
<p>- E se a gente não voltar?
<p>- Aí sim, o mundo está cheio de garotas, mas eu não sou uma delas, ouviu? – Ela completou rapidamente. – Fiquei sabendo da sua fama. 
<p>- Do que mais ficou sabendo?
<p>- Que você é uma pessoa legal.
<p>- Tenho certeza de que não te disseram isso na escola. Além do mais, eu bati no meu irmão. – Will não estava se considerando uma pessoa tão legal naquele momento.
<p>- Todo mundo que tem irmão sente vontade de fazer isso, ainda bem que sou filha única. 
<p>- Quer saber um segredo? Eu fiz ela terminar comigo. Eu forcei e insisti até ela dizer que queria terminar e no final, eu só aceitei.
<p>- Que saco. 
<p>- Nossa, valeu. – Will fez um sinal de “joia” para ela.
<p>- O que você quer que eu diga?
<p>- Eu sei lá. É que eu estou acostumado com o Jason e com as suas frases feitas de consolo.
<p>- Por que não está falando com ele então?
<p>- Eu não sei. Eu nunca... Eu já namorei antes, já rompi, mas nada se compara com isso que eu estou sentindo.
<p>- Você está se sentindo incompleto, com um vazio que não parece que um dia vai ser preenchido, mesmo que no futuro você volte a ser feliz. 
<p>- Ainda bem que você explicou porque eu não conseguiria. – Os dois riram. – Me conta a sua história. 
<p>- Eu perdi meu namorado há dois anos. Ele morreu em um assalto. 
<p>- Eu digo “eu sinto muito”?
<p>- A gente tinha acabado de terminar. E quando eu soube da notícia, achei que ia doer menos, mas...
<p>- Deu do mesmo jeito.
<p>- Um dia ele estava lá e no outro não. Eu ainda achava que fôssemos voltar, tínhamos brigado por uma bobagem, eu nem lembro mais o porquê. 
<p>- Eu sinto muito. – Ele finalmente disse.
<p>- Às vezes eu me pego pensando. O que poderia ter acontecido se ele não tivesse morrido? Será que a gente teria voltado? Estaríamos felizes?
<p>- Você nunca vai saber
<p>- Eu sei. Mas vamos focar no seu problema, o meu já foi. – Ela se recompôs.
<p>- Eu não quero superá-la. Eu a amo e isso não vai mudar tão cedo.
<p>- E o que pretende fazer a respeito?
<p>- Esperar.
<p>- Até quando? 
<p>- Eu não sei.</p>
<center><h4>--*--</h4></center>
<p>- Jason? Está acordado?
<p>Will estava deitado em um saco de dormir no chão do lado da cama de Jason. Já era quase uma hora da manhã. Ele não tinha muito espaço para se mexer e não estava conseguindo dormir também.
<p>- Infelizmente sim. – Jason não demorou para responder. – Acho que você está me passando seus problemas com o sono. – Will ouviu o amigo se mexer na cama. – Sabe, eu passei esses últimos dias tentando convencer a Amanda a não se intrometer no seu rompimento com a Emily, disse que não era da nossa conta, mas eu não sei se eu tenho razão.
<p>- Não há nada que vocês possam fazer.
<p>- É o que eu disse a ela. Mas na realidade, falta bem pouco para eu te ajudar a bater no Kevin.
<p>Os dois soltaram uma gargalhada.
<p>- Seb quer que eu vá falar com ele. Disse que ele é meu irmão e merece uma segunda chance. Que ele é família. – Will ficou esperando Jason dizer que era a coisa certa a se fazer, mas ele não disse. – Não concorda com ele?
<p>- Eu acho que dizer que é família não é bem uma desculpa plausível. É como se meu pai voltasse e dissesse que eu teria que perdoá-lo por ele ser meu pai, por ser família. Não faz muito sentido.
<p>- A Giovanna fez a cabeça dele. – Will estava tentando se convencer daquilo.
<p>- Foi ele que pichou o armário da Emily. Amanda me contou. 
<p>- Por que eu não estou surpreso? 
<p>- Porque você já está bravo. Eu acho que você deve ir falar com ele. Não para pedir desculpas ou tentar perdoá-lo, só para conversar.
<p>- E o que eu vou dizer a ele?
<p>- Não importa. Pelo menos, não vai estar fugindo.
<p>- Eu não estou fugindo. 
<p>- Está, sim.</p> 
<center><h4>--*--</h4></center>
<p>As palavras de Jason não fizeram Will dormir melhor, mas com certeza, lhe deu uma clareza. Não que falar com seu irmão era seu principal objetivo do dia, mas quando o viu de mãos dadas com Giovanna no corredor da escola naquela manhã, ao invés de mudar seu caminho para evitá-los, ele resolveu chamá-lo para conversar.
<p>- O que você quer? – O rosto de Kevin ainda tinha vestígios dos socos que levou do irmão.
<p>- Ah... – Ele não queria usar as palavras “eu queria me desculpar com você”. – Eu queria dizer que eu sinto muito pelo o que aconteceu. 
<p>- Por qual parte?
<p>- Eu não devia ter batido em você. Não foi certo. – Will o encarou. – E... Eu estava com raiva e não estava pensando direito. Não estou dizendo que não bateria em você de novo, só que... eu sinto muito. 
<p>- É essa a desculpa que eu vou conseguir?
<p>- Na verdade, eu queria me desculpar por outra coisa. – Ele olhou de Giovanna para Kevin. – Me desculpa por não sermos próximos o suficiente para que isso não acontecesse. Nós nunca... 
<p>- Como assim? – Kevin franziu a testa. 
<p>Era como se as palavras estivessem presas na garganta de Will e ele estivesse empurrando com toda a força para elas saírem. 
<p>- Sempre foi só você e o Chris. Nunca fomos nós dois ou nós três. Eu sempre estive com a Amanda, o Sebastian... o Jason. Eu até tenho uma intimidade com o Chris, mas a gente... – Ele encarou o irmão de novo. – A gente nunca teve a chance. E eu sinto muito por isso. Eu queria que fosse diferente, mas não é. Você é meu irmão e eu te amo, mas... eu mal te conheço e você não me conhece. 
<p>- Conheço sim.
<p>- Não, não conhece. Se me conhecesse, nunca diria aquelas coisas para mim. Se eu te conhecesse, eu saberia da sua paixão pela Giovanna. Acho que eu me senti mal por brigar com você, mais por você ser o meu irmão, não por eu me importar com você. Por isso, eu peço desculpas. 
<p>- Will... 
<p>Kevin não sabia o que dizer, mas Will também não ficou lá esperando ele dizer alguma coisa.</p>
<center><h4>--*--</h4></center>
<p>Will matou as últimas duas aulas e foi para a gruta. Conversar com Kevin havia tirado toda a sua energia.
<p>Mal sabia ele que precisaria de mais um pouco de energia quando chegasse no seu refúgio. Will estava andando pela areia tão distraído com as conchas no chão que só percebeu que seu lugar estava ocupado quando já era tarde demais. 
<p>Emily estava sentada na última pedra e quando ele finalmente a viu, seus olhares se cruzaram. 
<p>- Não precisa ir embora! – Ela gritou assim que percebeu que ele pretendia dar meia volta e ir embora. – O lugar é seu! Eu que deveria ir!
<p>- Ah, não! – Ele gritou ainda no chão. – É nosso, lembra?! Tanto meu quanto seu!
<p>Os dois se olharam por alguns segundos.
<p>- Pode subir se quiser! – Emily finalmente disse.
<p>Will começou a escalar as pedras. “O que eu estava fazendo lá? A gente tinha acabado de terminar, não deveríamos nos ver. Eu deveria dizer algo? A gente conversaria normalmente? Eu nem sabia o que dizer.”.
<p>- Oi.
<p>- Oi.
<p>Os dois se olharam envergonhados e ficaram sentados um do lado do outro por algumas horas. O céu foi escurecendo e a brisa começou a ficar mais gelada. Os dois, em silêncio até aquele momento, pareciam estar fazendo uma aposta imaginaria de quem seria o primeiro a se levantar e se despedir. 
<p>- Você... – Emily se impressionou e se assustou ao mesmo tempo quando Will começou a falar. – Você está bem? Tem ido à escola? 
<p>- Eu fui ontem e hoje no primeiro tempo. Eu... vi o que fez no meu armário.
<p>- Ah... – Ele demorou um pouco para se lembrar. Parecia que já fazia uma década desde aquele dia. – Eu me esqueci completamente de tirar, eu sinto muito.
<p>- Não, tudo bem. 
<p>- Eu não deveria estar aqui, mas eu estou.
<p>- Você está.
<p>- Sabe, você tinha razão. Eu não dou a mínima para o Kevin.
<p>- Will, não foi isso que eu quis dizer. – Emily tentou se desculpar.
<p>- Eu bati nele. – Will continuou.
<p>- Eu soube. 
<p>- Eu bati e por um momento, eu não quis parar. Depois eu entrei em choque, e quando me recuperei, eu quis bater mais. Isso nunca teria acontecido com... Não importa. 
<p>- Não é justo, eu sei. Não pode se culpar por isso.
<p>- Mas é o que eu faço.
<p>- Will, você não é uma pessoa ruim, muito menos um irmão ruim. Você tenta mais do que qualquer um. – Emily ainda tinha aquele olhar de impressionada no rosto. – Isso é mais do que qualquer um poderia pedir. A vida é complicada e bagunçada, não dá para criar laços com todo mundo, mesmo que você queira. 
<p>- Então eu tenho que aceitar que a vida é uma droga e que eu nunca...
<p>- Não. Você pode desistir hoje e tentar de novo amanhã. 
<p>- Sinto sua falta. – Foi instantâneo. Pulou da boca dele. – Sinto falta de conversar com você, tudo fica mais simples quando eu te escuto. 
<p>- Eu também sinto a sua.
<p>- Sabe, eu não quero depois de tudo, fingir que você não existiu e te ignorar ou andar por outros caminhos para não ver você todos os dias. Eu não vou conseguir fazer isso. Acha que a gente consegue voltar a ser amigo? 
<p>- Não custa tentar, eu acho.
<p>- Eu prometo que não vou ficar atrás de você o tempo todo. 
<p>- Tudo bem. – Ela não sabia bem o que responder.
<p>- Tá bom. – Muito menos ele. – Eu quero que seja feliz. Se nos separar for a solução, ótimo.
<p>- Você me fez feliz, Will. A mais feliz. – Ela quase sorriu. 
<p>- Que bom. – Ele sorriu.</p>
</body>
</html>";
            }

            if (numero == 26)
            {
                lblTitulo.Text = "Capítulo 26 - Você Não Fez Nada Para Eu Te Amar Menos";
                htmlPage.Html = @"<html>
<body>
<p><i>“Volte quando puder
<br>Deixe para lá, você vai entender
<br>Você não fez nada para eu te amar menos
<br>Então volte quando puder
<br>Volte, eu vou te ajudar a levantar
<br>Deixe para lá e segure minha mão
<br>Se tudo o que você queria fosse a mim, eu não te daria nada menos
<br>Então volte quando puder”
<br><b>Come Back When You Can – Barcelona</b></i></p>
<br>
<p>“Alguma vez você já se arrependeu de se apaixonar por alguém? A decepção foi tão grande que você preferiu fingir que tudo nunca existiu? Às vezes você se apaixona e nem sempre é para sempre, na maioria das vezes nem é recíproco. Pessoas mudam, amam outras pessoas. Você já ficou preso a imagem do seu antigo amor ou idealizou algo que seria quase impossível de acontecer? Já conseguiu aceitar e superar? 
<p>Você nunca sabe exatamente se vale a pena lutar por determinado amor. Ela pode ser a única para você naquela hora, mas talvez mude. Isso não é necessariamente errado. Quantas vezes você já mudou de opinião sobre algo que tinha certeza? Várias.”.</p>
<br>
<p>- Onde estava? Você está bem? Jason disse que você não foi para casa dele, então eu imaginei que voltaria, mas você... – Amanda estava esperando Will chegar, sentada na beira da cama dele. Ela estava um pouco apreensiva e ao mesmo tempo esperançosa. 
<p>- A noite está linda. Para que ficar preso em casa? – Will se sentou ao lado da irmã, mas não estava achando a noite tão linda como tentou demonstrar para ela. – Falei com a Emily. 
<p>- Vocês voltaram? – Ela arregalou os olhos.
<p>- Sem querer ofender, mas se a gente tivesse voltado, eu não estaria aqui com você agora.
<p>- Vocês vão resolver isso.
<p>- Eu não sei mais. Acho que não. 
<p>- Por que diz isso?
<p>- A gente tentou e não deu certo. – Will, pela primeira vez, se sentia sem esperança nenhuma falando aquilo.
<p>- Por causa da...
<p>- Não foi só por causa da Giovanna. Eu me recuso a acreditar nisso. 
<p>- E então? 
<p>- Agora eu preciso seguir com a minha vida. Não deve ser tão difícil.
<p>- Como vai fazer isso? – Amanda estava preocupada.
<p>- Eu não faço ideia. Decidimos que vamos tentar ser amigos. Ideia ridícula. 
<p>- Concordo.</p>
<center><h4>--*--</h4></center>
<p>Quinn ouviu Emily contar a conversa que teve com Will em completo silêncio. Geralmente ela não fazia isso, mas foi como se lhe faltasse palavras para comentar no meio do discurso. No final, ela respirou fundo antes de falar qualquer coisa.
<p>- Deve ter sido difícil para vocês.
<p>- É, foi um pouco. – Emily concordou. Ela estava deitada na cama junto com a irmã, elas sempre faziam isso quando uma precisava de apoio da outra. 
<p>- Então é isso? Vocês acabaram desse jeito? Sabe que não precisa.
<p>- Eu preciso de um tempo. Preciso colocar as coisas no lugar e...
<p>- Sabe que isso é uma desculpa, não é? Você fala “tempo” só porque não quer dizer “término” em voz alta. 
<p>- Não importa.
<p>- Emily, você acha que quando você se resolver, daqui mil anos, ele vai estar te esperando? Não é assim que funciona.
<p>- Eu não quero que ele me espere. – Mentira. – Se ele encontrar outra pessoa, eu vou ficar feliz por ele.
<p>- Besteira. Você só está desistindo.
<p>- Não se trata disso. 
<p>- Olha, a Giovanna é uma vadia e além disso, é uma valentona. Você já brigou com valentonas antes. 
<p>- Não por causa de um cara. Eu não quero e nem vou descer a esse nível. 
<p>- Você não ama o Will o suficiente? 
<p>- É claro que eu amo. – Emily respondeu ofendida.
<p>- Não parece. Porque ele já lutou por você várias vezes. Não vejo um equilíbrio aqui.
<p>- Por que não vai para o seu quarto? Preciso dormir, estou cansada. – Emily se irritou com o que Quinn disse.
<p>- Ótimo. Conversa maravilhosa. – Quinn se levantou da cama também irritada. – Quer saber? Você teve sorte e está jogando ela no lixo. Todas essas pessoas, até mesmo talvez nosso pai, estão com inveja do que vocês dois têm, porque queriam ter também. Sabe o quão é difícil amar alguém e ser amado no mesmo nível? 
<p>Emily não respondeu. Ao invés disso, ela virou o corpo e escondeu o rosto de Quinn. 
<p>- Boa noite. – Ela falou.
<p>- Boa noite. – Quinn respondeu enquanto saía do quarto.</p>
<center><h4>--*--</h4></center>
<p>- Ashley, espera! – Chris gritou pela namorada do topo da escada. Ela, que estava passando despreocupada pelo corredor olhando os avisos que a escola colava nas paredes, se assustou.
<p>- O que aconteceu?
<p>- Preciso falar com você. – Ele parecia sério quando a alcançou.
<p>- Não pode esperar? Eu estou atrasada para ir à aula.
<p>- É rápido. Preciso que peça para Giovanna deixar de sair com o Kevin.
<p>- O quê? Eu não vou fazer isso.
<p>- Você precisa.
<p>- Não. – Ashley achou aquilo o cumulo do ridículo. – Não vou me meter.
<p>- Ash, você sabe o que aconteceu na minha casa. Will e Kevin saíram no soco por causa dela.
<p>- Olha, isso não me interessa. – Aparentemente, ela não dava a mínima para aquele acontecimento.
<p>- Por favor.
<p>- Eu não me meto nas coisas dela e ela não se mete nas minhas. 
<p>- A amizade de vocês é meio estranha. – Chris franziu a testa.
<p>- Pelo menos, eu tenho amigas.
<p>- O que quer dizer com isso?
<p>- Deixa para lá. – Tinha dias que Ashley pedia para Deus um amigo para o namorado, assim ele largaria do pé dela.
<p>- Você ao menos sabe que o que ela está fazendo é errado, não sabe?
<p>- Errado por quê?
<p>- Ela não gosta do Kevin. Ela só quer torturar o Will. 
<p>- Isso é o que você pensa.
<p>- Olha, eu conheço ela, não sou idiota. Mas ela venceu, Will está sozinho agora, ela pode deixar o Kevin em paz.
<p>- Will largou a Emily? – Ashley arregalou os olhos.
<p>- Ao contrário.
<p>- Olha, eu preciso ir para a aula.
<p>- Ash...
<p>- Tchau.
<p>Ashley deu as costas para Chris e saiu andando com passos rápidos. Ela precisava encontrar sua amiga o mais rápido possível.</p>
<center><h4>--*--</h4></center>
<p>- Will.
<p>Giovanna estava esperando assim que Will saiu da sala de aula, parada em frente ao armário dele.
<p>- O que você quer? – Mesmo de leve, ele a empurrou para sair da sua frente e conseguir abrir o armário para guardar seus livros.
<p>- Quero saber como você está. – Ela falou manso.
<p>- Meu estado não te interessa. 
<p>- Fiquei sabendo que você e a Emily terminaram. Eu sinto muito.
<p>- Olha, chega. – Will não estava tão irritado como da última vez que a viu, mas ainda não queria ficar no mesmo lugar que ela por mais de cinco segundos. – Se veio aqui bancar a coitadinha, cai fora, porque eu não acredito. Se veio pedir desculpas, cai fora, eu também não quero suas desculpas. Se veio aqui para dizer que quer ser minha amiga, cai fora também, porque você é a última pessoa com quem eu gostaria de ter amizade. Na verdade, você nem está nessa lista.
<p>- Não precisa me tratar assim.
<p>- Não, é exatamente assim que você merece ser tratada. – Ele a encarou. – E mais uma coisa, você gosta de levar fora e ser pisada? Ótimo, então fica no meu pé, eu aguento, mas se eu te vir chegando perto da Emily ou fazendo qualquer coisa que a afete, as coisas vão ficar complicadas para você.
<p>- Eu só estava tentando te ajudar. Ela não é a garota certa para você.
<p>- E você é? – Ele já sabia a resposta que ia receber. – Quando isso vai entrar na sua cabeça? Eu não sinto mais nada por você a não ser pena. Não importa que eu tenha terminado com a Emily, voltar com você não é uma opção.
<p>- Mas...
<p>- Fica lá com o Kevin, já que ele é o único que você consegue enganar. 
<p>Will pegou seus livros, fechou seu armário e seguiu rumo a sua próxima aula.</p>
<center><h4>--*--</h4></center>
<p>- Oi, tudo bem? – Emily estava com um bolinho na mão quando se sentou ao lado de Will no degrau de uma escada bem isolada. Ele não havia ido almoçar e pelo lugar que estava, com certeza estava tentando se esconder.
<p>- Bem. – Ele olhou para o bolinho e instantaneamente lembrou de uma conversa com ela uns meses atrás quando falavam como haviam se apaixonado um pelo outro. 
<p>- Está se escondendo?
<p>- Na verdade, estou pensando em como matar o meu irmão e não ser preso. Eu posso alegar legitima defesa só por ele ser um otário? Que é para o bem da humanidade? 
<p>- Eu acho que não. – Ela riu. 
<p>- Eu sei, é estranho, mas se eu não pensar nisso, vou ter que voltar a pensar em... 
<p>- Eu sei. – Ela o olhou bem nos olhos. – Eu te trouxe um bolinho. Pensei que poderia ser o nosso acordo de paz, sei lá, – Ela estendeu a mão.
<p>- Muito obrigado. Como nos velhos tempos. – Ele bateu seu ombro no dela e deu um leve sorriso para tentar descontrair. 
<p>- Eu não quero fazer nada que... E você está bem com isso?
<p>- Você está? 
<p>- Vou estar se você estiver. – Ela também sorriu.
<p>- Sabe, quando eu cheguei aqui de manhã, pensei em andar por outros caminhos só para não me encontrar com você no corredor.
<p>- Sabe que não é assim que a amizade funciona, não é?
<p>- Eu estou meio perdido. Percebi que não gosto muito de ficar sozinho. Eu fiquei com a Giovanna por um bom tempo porque não queria ficar sozinho e agora eu estou aqui. Odeio isso. – Mesmo com o clima estranho, Will sabia que ainda podia ser sincero com Emily.
<p>- Sabe, é bom ficar sozinho às vezes. Ouvir seus próprios pensamentos, agir por conta própria. 
<p>- Eu faço merda quando ajo por conta própria. 
<p>- Eu sei disso.
<p>Os dois começaram a rir.
<p>- Eu prometo que não vou sair por aí ficando com alguém só para tentar preencher esse vazio. Eu não sou mais assim.
<p>- Eu também estou me sentindo vazia. E uma parte de mim quer muito... – Mas ela não conseguiu terminar a frase.
<p>- Esse bolinho é muito bom. – Will o colocou todo na boca e fez uma careta enquanto tentava mastigar e isso fez Emily rir. Ele ainda era muito bom naquilo.</p>
<center><h4>--*--</h4></center>
<p>- Vocês conhecem o Will mais do que eu. Me digam, por que ele não está lutando pela Emily?
Melissa estava sentada em uma mesa no pátio junto com Jason e Sebastian. Os três estavam jogando papo fora enquanto o sinal não tocava. Ela havia acabado de descobrir que Will e Emily agora eram só amigos. 
<p>- Eu acho que ele está dando um espaço para ela. – Jason respondeu. – Não sei se é o certo, mas...
<p>- Eu acho ridículo. – Melissa continuou.
<p>- É difícil convencer o Will do contrário, principalmente quando a insegurança dele ataca. – Ele completou.
<p>- Como assim?
<p>- Will sempre conseguiu a garota que ele queria. – Sebastian respondeu. – Então ele conheceu e se apaixonou pela Emily. Ele não está sabendo lidar com isso, nunca soube, na verdade.
<p>- Emily confunde muito o Will. – Jason falou. – Com ela, ele sentiu coisas que nunca tinha sentido. Tudo mudou.
<p>- Eu sempre quis mudar um garoto. É um dos meus objetivos de vida. – Melissa brincou.
<p>- Eu não acho que a Emily o mudou. – Jason refletiu. – Esse Will estava lá em algum lugar, só não tinha encontrado alguém para quem valesse a pena mostrar esse lado. 
<p>- Nossa. – Sebastian arregalou os olhos enquanto lia uma mensagem que tinha recebido no celular. – Acabei esquecendo. Preciso falar para Quinn que não vamos poder sair hoje. Tenho que ir para São Francisco.
<p>- O que vai fazer lá? – Melissa ficou interessada.
<p>- Ah... – Ele corou. – Eu vou... passar no médico. Exames de rotina. – Mentiu.
<p>- Podemos ir juntos. Também preciso ir lá. Comprar umas coisas para minha mãe.
<p>- Tá, podemos sim. – Sebastian concordou.
<p>- Só tomem cuidado. – Jason falou. – Vi no noticiário de manhã que a probabilidade de chover à tarde é grande. 
<p>- Estamos em LA, aqui nunca chove. – Sebastian riu.</p> 
<center><h4>--*--</h4></center>
<p>A mente de Emily estava bem longe enquanto seu professor discursava um texto interminável de algum escritor famoso que ela não ouviu o nome e isso continuou na outra aula e na outra e assim por diante até o almoço. 
<p>Quando o último sinal tocou, ela correu direto para a biblioteca. Pegou um livro na estante, o mais pesado que ela encontrou, se sentou em uma mesa isolada de todo mundo e começou a ler. Se aquilo desse certo, talvez nem iria para as próximas aulas, ficaria ali por muito tempo. Mas não deu.
<p>- Não consegue me tirar da cabeça, não é? – Will estava a observando sentado na cadeira a sua frente. – Eu sei, pode ser difícil. 
<p>- Sai daqui. – Ela falou baixinho enquanto mantinha sua visão só no livro. 
<p>- Não dá. Você me quer aqui. 
<p>- Não quero.
<p>- Ah, quer sim. Se não quisesse, eu não estaria aqui. Parece complicado, mas é bem simples.
<p>- Ai, meu Deus. – Emily bufou. – O que você quer de mim? – Ela fechou o livro com força, o colocou na mesa e encarou Will que estava sorrindo para ela. 
<p>- Acho que não é bem essa a pergunta a ser feita. 
<p>- Ah é? Então qual é? – Emily falava cada vez mais baixo. Não queria ser a louca que falava sozinha.
<p>- O que você quer de mim? Porque não importa o que eu faça, você ainda... você me afasta.
<p>- Para. – Ela fechou os olhos na esperança que aquela voz sumisse também junto com a imagem. 
<p>- Eu fui sincero com você, te contei tudo. – Will continuou. – Eu te mostrei algo que eu nunca tinha mostrado para ninguém. Você foi a primeira a realmente dizer que meu sonho não é bobo e você não sabe o quanto aquilo me ajudou, o quanto aquilo me fez amar você. 
<p>- Para. – Ela suplicou ainda de olhos fechados. 
<p>- Eu não ligo para a Giovanna, eu não ligo para o Kevin nem para o seu pai nem para todo mundo nessa escola ridícula, eu ligo para você e como você faz eu me sentir. – Ela abriu os olhos e o encarou. Ele não sorria mais, estava sério. – Eu te amo e você sabe disso, eu gritei aqui, na verdade, para todo mundo ouvir. Eu não sou idiota, eu sei que amor não é tudo, mas agora, pelo menos agora, deveria ser o suficiente. 
<p>- Não é tão simples.
<p>- Por quê? Só porque está com medo? Eu também estou, eu estou apavorado, mas... Acha mesmo que somos melhores separados? Acha mesmo que vale a pena largar tudo, esquecer disso só para não ter medo? Essa sensação, acha que lutar por ela não é importante? 
<p>- Não é medo.
<p>- Então o que é? Dúvida? 
<p>- Não. Eu te amo e não tenho dúvida disso. 
<p>- Viu como isso foi fácil de dizer? O que estamos fazendo, Ems? – Ele franziu a testa.
<p>- Eu não sei. 
<p>- Sinto sua falta.
<p>Ela também sentia, mas não podia dizer em voz alta.</p>
<center><h4>--*--</h4></center>
<p>Will já estava ficando com raiva daquela aula de história. Nada do que aquele professor falava o interessava, nem sabia em que década estava naquele momento. Seu pé batia freneticamente no pé da carteira enquanto olhava de um lado para o outro bufando como se estivesse em busca de ajuda. 
<p>Por um minuto, ele parou, sua mente ficou vazia e rapidamente se preencheu com uma música... <i>Learning to Breathe</i>. Por que aquela música apareceu justo naquele momento? A música que ele cantou quando Emily o conheceu de verdade.
<p>- William? William? – Ele ouviu uma voz o chamando bem de longe e aumentando aos poucos até que...
<p>- Oi! – Ele quase pulou da cadeira de susto.
<p>- Estou te interrompendo? – O professor estava em pé parado na frente da sua carteira.
<p>- Não, por quê?
<p>- Você estava cantando. – Ele respondeu e todos dentro da sala começaram a rir irritando ainda mais o professor.
<p>- Mil perdões, professor, mas alguém precisa animar isso aqui, não é? – Ele sorriu tentando lançar um deboche saudável.
<p>- Vai continuar cantando ou prefere sair? – O professor continuou sério.
<p>- Acho que a segunda opção me parece uma boa escolha.
<p>- Ótimo.
<p>Will fechou seu caderno, colocou na mochila junto com a caneta jogada no canto da carteira, se levantou, pegou uma das alças da mochila, a colocou nas costas e saiu da sala sem fazer muito alarde e sem olhar de novo para o professor. 
<p>Os corredores estavam vazios e silenciosos, dignos de filmes de terror se a luz do sol não estivesse os iluminando fortemente. 
<p>- Will? – Quinn vinha em sua direção também com a mochila nas costas, porém sorridente.
<p>- O que está fazendo aqui?
<p>- Aparentemente, eu não posso ficar mandando mensagens em aula. – Ela revirou os olhos. 
<p>- Não vou te julgar. Também fui convidado a me retirar. – Ele brincou. – Parece que não dá para cantar na aula de história. 
<p>- Falou com a Emily? Eu soube da conversa ridícula que tiveram. 
<p>- Não foi ridícula. Foi madura. 
<p>- Madura? Ah, conta outra. 
<p>- Foi o que me sobrou. Não tenho mais jogadas. 
<p>- Ela te ama, você sabe disso, não sabe?
<p>- Sei. – Ele sorriu. – Mas isso não muda nossa situação. Pelo menos, não agora.
<p>- O que vai fazer hoje à noite? 
<p>- Nada. 
<p>- Vamos sair então. O Sebastian vai para São Francisco...
<p>- Terapia. Acho que eu deveria ir junto. – Brincou. – O que tem em mente? 
<p>- Beber até cair? – Ela levantou a sobrancelha.
<p>- Ótima ideia.</p>
<center><h4>--*--</h4></center>
<p>Emily abriu seu armário para guardar os livros e ficou alguns segundos olhando para as fotos pregadas nos cantos até sorrir. 
<p>- Emily, podemos conversar?
<p>Ela se assustou com Kevin chegando sem aviso que fechou bem rápido o armário provocando um barulho maior do que deveria.
<p>- O que você quer? – Ela tirou o sorriso do rosto e ficou séria.
<p>- Eu fiquei, ah, sabendo que, ah, o diretor está investigando, ah, para encontrar o culpado que, ah, pichou o seu armário. – Ele falava bem envergonhado.
<p>- E...
<p>- Eu sei que você acha que foi a Giovanna e disse isso a ele, mas foi eu. Eu que escrevi aquelas coisas no seu armário. 
<p>- Tudo bem. – Emily não demonstrou nenhuma emoção. 
<p>- Eu sinto muito. Se você quiser, eu vou na diretoria e confesso tudo.
<p>- Não precisa. E se depender de mim, o diretor não vai saber que é você. Já passou. 
<p>- Obrigado. 
<p>- Só me diz uma coisa. – Emily não conseguiu evitar. – Foi você que teve a ideia ou só foi manipulado?
<p>- A Giovanna não sabia de nada. 
<p>- Não foi isso que eu perguntei.
<p>- Eu sei exatamente o que você perguntou. E só quer um pretexto para culpá-la. 
<p>- Você a ama mesmo, não é? – Ela estava impressionada. Aquele garoto estava completamente cego de amor.
<p>- Amo. 
<p>- Kevin, eu não tenho nada contra você, eu mal te conheço, na verdade, mas... Não segue esse caminho.
<p>- Que caminho? Está se referindo a minha briga com o Will? 
<p>- Estou me referindo a tudo. Ela só está usando você. 
<p>- Não é verdade.
<p>- É, e você sabe que é. No final, eu é que sinto muito.</p>
<center><h4>--*--</h4></center>
<p>- Precisamos conversar. 
<p>- Chris, se for sobre a Giovanna...
<p>Chris voltou a correr atrás da namorada no final do horário. Ela já estava no portão da escola quando ele a alcançou. 
<p>- É exatamente sobre ela e sobre tudo o que está acontecendo. 
<p>- Eu já disse que não vou falar com ela. – Ashley estava irritada.
<p>- E eu quero saber o porquê.
<p>- Eu já te disse isso também. Eu não me meto nessas coisas. 
<p>- Está mentindo. – Chris estava sério.
<p>- Não estou!
<p>- Você a incentiva a fazer isso? A apoia?
<p>- Não. 
<p>- Você só se cala então? Finge que não vê?
<p>- Não, eu... – Ashley não sabia o que dizer. – Ela é uma ótima pessoa, só tem alguns problemas. Todo mundo tem problemas, ela não pode ser julgada por isso. 
<p>- Problemas? Ela está jogando com os meus dois irmãos e você sabe disso, não é algo questionável, é uma certeza. Como então você pode ser amiga de alguém assim?
<p>- Você não tem o direito de dizer isso dela. Você não é perfeito. 
<p>- Ela te apoiava enquanto você me traía?
<p>Ashley arregalou os olhos. Chris nunca falava sobre aquele assunto, os dois sempre agiam como se aquelas fases nunca tivessem acontecido. 
<p>- Chris...
<p>- Ou você apoia o que ela está fazendo ou você não liga. As duas opções são horríveis. 
<p>- Então o quê? Vai terminar comigo? Porque você é perfeito e moralista? – Ashley começou a falar alto. – Eu nunca falei nada quando você brigava com o Will mesmo estando errado, eu te apoiava porque é isso que eu faço. Eu apoio as pessoas que eu amo. 
<p>- Não. Você só não se importa. Você realmente me ama? – Chris sabia a resposta.
<p>- Mas é claro. 
<p>- Então por que me traiu?
<p>- Chris, já falamos sobre isso. Eu só...
<p>- Não precisa responder. – Chris respirou fundo para segurar o choro. – Acabou. Nós dois.
<p>- O quê?
<p>- Eu vi meus dois irmãos socando um ao outro por causa da sua amiga, da garota que você diz ser uma boa pessoa, da garota que você apoia, da garota que colocou um copo de tequila ou sei lá o que na frente do Sebastian só para ele tomar. 
<p>- Eu não sabia disso... Chris, eu sinto muito.
<p>- Não precisa. – Ele voltou a respirar fundo. – Você está livre, Ash. Eu sei todos os comentários... Eu só fingia não ouvir. Eu sou o seu namorado chato e sem graça, aquele que todos conseguem ser melhores.
<p>- Eu nunca disse isso.
<p>- Disse sim. 
<p>- Mas nunca foi sério.
<p>- Tchau, Ashley. – Dessa vez, foi Chris que virou as costas e deixou a namorada falando sozinha.</p>
<center><h4>--*--</h4></center>
<p>- Você é a Emily, não é? – Melissa abordou Emily ainda no corredor. Com aquele barulho, ela precisou tocar em seu braço e falar um pouco mais alto.
<p>- Sou sim. – Emily franziu a testa. Ela já imaginava o pior chegando.
<p>- Eu sou a Melissa. Sou nova aqui. 
<p>- Muito prazer. – Ela ainda não sabia do que se tratava aquela conversa e estava um pouco perdida.
<p>- Olha, eu preciso falar com você sobre o Will. 
<p>- Ah, entendi. Os rumores são verdadeiros, a gente namorou, mas já terminamos e somos só... amigos agora. Está tudo bem. – Ela até estranhou por ter demorado tanto para alguém vir falar com ela sobre aquilo.
<p>- Não entendi.
<p>- Você não veio aqui para saber disso?
<p>- Não, até porque eu meio que já sei. Eu não estou a fim do Will se é isso que você acha. – Melissa pensou naquilo e achou ridículo, quase soltou uma gargalhada. 
<p>- Então...
<p>- Olha, eu estava lá na hora da briga com aquela outra garota. Eu vi tudo. 
<p>- E...
<p>- Na verdade, eu nem sei o que eu estou fazendo aqui. É que eu passei o dia todo com o Jason e o Sebastian e eles não paravam de dizer o quanto vocês dois juntos são... – Ela soltou um suspiro. – Eu não conheço vocês, mas...
<p>- Mas...
<p>- Você está arrependida, não está?
<p>- Eu... – Emily não se sentia bem em falar sobre aquilo com uma até então desconhecida.
<p>- Tá, não precisa ser sincera comigo, só seja com você mesma. Tem uma coisa que eu sempre digo para as pessoas... Se você ainda não enxergou o ponto final, é porque ainda não acabou. 
<p>- O que você...
<p>- Só pensa nisso, tá bom? 
<p>- Tá.
<p>Emily não soube responder à altura e não importou, já que Melissa foi embora correndo antes mesmo de se despedir.</p>
<center><h4>--*--</h4></center>
<p>- Bom, estamos preparados para a suposta chuva. 
<p>Jason apareceu na sua sala de estar com um pote enorme de pipoca e se sentou no sofá ao lado de Amanda.
<p>- Você não tem nenhum filme bom. – Amanda olhava para os DVDs espalhados na mesa de centro da sala.
<p>- Achei que gostasse de romances.
<p>- Eu gosto, mas não de romance de garotas de dezesseis anos. – Ela reclamou.
<p>- Você tem dezesseis anos.
<p>- Cala boca. – Amanda jogou um punhado de pipoca em cima de Jason e começou a rir enquanto pegava um DVD aleatório e colocava no aparelho. – O filme não importa, a companhia sim.
<p>- Então talvez fosse melhor chamar mais gente. – Jason brincou.
<p>- Coma essa pipoca e fique quieto. – Ela riu.
<p>- Corrigindo, você é a melhor companhia.
<p>- Assim está melhor. – Ela se sentou no sofá de novo e o beijou.
<p>O filme não tinha nem começado a passar os créditos iniciais quando a campainha tocou. 
<p>- Quem será? – Amanda se levantou irritada.
<p>- Nem imagino. Minha mãe vai trabalhar no segundo turno hoje e ela tem a chave. – Jason também se levantou para atender a porta. 
<p>Assim que abriu a porta, Jason preferiu não ter aberto. Desejou voltar no tempo, ignorar a campainha e continuar assistindo aquele filme sem graça. Qualquer filme era melhor do que aquilo que ele tinha acabado de sentir.
<p>- Oi, Jason. – O homem sorriu para Jason, com os olhos cheios de lágrimas, emocionado.
<p>- Pai? – Jason nem piscou. – O que faz aqui?
<p>- Eu vim te ver.
<p>- Agora?
<p>- Senti sua falta.</p>
<br>
<p>“Existem momentos na sua vida que você precisa tomar uma grande decisão. Ficar ou fugir, dizer sim ou não, bater ou apanhar. Existem momentos onde você não pode hesitar, não pode esperar nem fingir que não está acontecendo. 
<p>Mas ao mesmo tempo, existem momentos em que é melhor você parar e esperar que ele passe, ignorar, às vezes é melhor. Torcer para que ele vá embora e nunca mais volte. 
<p>Como saber qual momento é qual? É simples, você não sabe.”.</p>
</body>
</html>";
            }

            if (numero == 27)
            {
                lblTitulo.Text = "Capítulo 27 - Como Se Fôssemos Os Únicos No Mundo";
                htmlPage.Html = @"<html>
<body>
<p><i>“Estamos vivendo ao máximo
<br>Bonnie e Clyde não se comparam a nós
<br>Porque estamos voando alto, sentindo a adrenalina
<br>Porque nós fazemos o que queremos
<br>Ligamos o rádio
<br>Porque a música do Petty nos deixou apaixonados
<br>E dançamos como se fôssemos os únicos no mundo”
<br><b>Only Ones Left In The World – Tyler Hilton</b></i></p>
<br>
<p>“Houve uma época na minha vida em que tudo o que eu queria era me trancar no quarto, ligar o som no último volume e ficar lá. Eu não queria falar nem ver ninguém, queria ficar sozinho e me imaginar em um mundo onde só eu existia. Eu sei, não é nada saudável. 
<p>Quando eu finalmente fiz isso, percebi que o problema maior não era as outras pessoas que me rodeavam, era eu mesmo. Eu não me amava o suficiente para deixar alguém me amar. Eu não confiava em mim mesmo. Não foi um bom momento, mas me ajudou a perceber uma coisa. Embora lute o dia todo pela sua independência no mundo, de noite você vai precisar de alguém com quem contar e vai precisar que esse alguém precise de você também. É como dizem por aí: nenhum homem é uma ilha. Todos nós precisamos de companhia, uma vez ou outra.”.</p>
<br>
<p>- <i>Está chovendo muito aqui!</i> – Angie estava muito animada do lado da janela. Ela amava chuva. 
<p>Sua mãe havia ensinado ela a fazer uma chamada de vídeo. Em determinado momento, só ouvir a voz de Will não era mais o suficiente para ela. Seu rosto preenchia quase cem por cento do vídeo, mas uma parte mínima da janela atrás dela aparecia, e às vezes dava para ver os relâmpagos que aconteciam do lado de fora. 
<p>- É, eu sei. O hospital não é tão longe daqui. – Will sorriu. Ele estava sentado em uma cadeira ao lado do balcão da cozinha. Seus cotovelos se apoiavam no mármore enquanto segurava o celular com as duas mãos para falar com Angie. – Está chovendo aí do mesmo jeito que está chovendo aqui.
<p>- <i>Você está em casa? Sua família também? Minha mãe disse que é muito perigoso sair de casa com essa tempestade. Pode acontecer um acidente.</i> – Ela arregalou os olhos.
<p>- Pior que é verdade. Mas só eu estou em casa. Meus pais estão viajando com o meu irmão menor e meus outros irmãos estão espalhados por aí. 
<p>- <i>Não está preocupado?</i>
<p>- Não. – Will sabia exatamente onde todos poderiam estar. Amanda na casa do Jason, Chris na casa da Ashley, Kevin em algum shopping com a Giovanna e Sebastian ainda estava no trânsito lento vindo de São Francisco. – Eles sabem se cuidar. São bem crescidos.
<p>- <i>Não saia de casa, viu, mocinho?</i>
<p>- Sim, senhora. – Ele sorriu.
<p>- <i>Senhorita.</i> – Ela apontou o dedo para a tela. – <i>Boa noite, Will.</i>
<p>- Boa noite, Angie. 
<p>Will desligou o telefone. 
<p>A chuva estava bem pesada mesmo. Ele ouvia o barulho do vento tentando passar pelas frestas das janelas e portas. O sinal da televisão estava fora do ar, a energia havia acabado fazia alguns minutos e o resto da sua bateria no celular havia ido para o saco depois da ligação de Angie. Era como se estivesse ilhado na sua própria casa. 
<p>Ele quase pulou da cadeira quando ouviu a campainha tocar várias vezes sem parar. Sua caminhada até o outro lado da casa para atender a porta foi bem rápida por causa da sua curiosidade. Quem seria louco o suficiente para sair de casa naquele temporal e por quê?
<p>- Emily?
<p>- Oi. – Além de molhada da cabeça aos pés, Emily estava sem fôlego e um pouco vermelha. Tinha corrido na esperança de se molhar menos ou por menos tempo, talvez. 
<p>- O que faz aqui? – Ele deu espaço para ela entrar. O barulho da chuva foi abafado depois que voltou a fechar a porta.
<p>- Eu precisava muito falar com você. 
<p>- Ems, está caindo o mundo lá fora. É perigoso sair desse jeito, você...
<p>- Olha, em primeiro lugar, não está chovendo quando eu saí de casa. – Ela começou a andar pelo corredor que levava até a sala, mas parou no meio do caminho. Estava pingando e ela não queria molhar o chão, mais do que já tinha molhado. 
<p>- Eu duvido, você não mora tão longe.
<p>- Olha, que seja. – Ela estava agitada também. 
<p>- O que aconteceu? 
<p>- Eu sou uma idiota. 
<p>- Você não enfrentou uma chuva para vir me dizer o que nós dois já sabemos, não é? – Ele mostrou um sorriso.
<p>- Você não tem o direito de fazer piada agora. – Ela arregalou os olhos e estava um pouco séria. 
<p>- Tá, olha, vai no banheiro, se seca, eu vou pegar algumas roupas secas da Amanda, talvez... Você vai ficar gripada.
<p>- Esquece a gripe, esquece a chuva. Eu amo você. 
<p>- Tá bom. – Will não estava entendendo muito bem aquela situação.
<p>- Não, você não entendeu. Eu vim até aqui para dizer que eu te amo. 
<p>- Eu... eu sei que você me ama. 
<p>- Quebrei a promessa. 
<p>- Ems, não... – Will não sabia muito bem o que dizer. 
<p>- Eu estava enganada. Não quero ficar sem você. 
<p>- Tem certeza disso? – Will ainda não tinha assimilado aquela última frase quando perguntou. 
<p>- Eu estou aqui, não estou? Não me importa meu pai, nem a Giovanna, nem o Kevin, nem meio mundo, eu só quero ficar com...
<p>Will foi até ela e a beijou. 
<p>- Deus, eu estava querendo muito que você dissesse isso. – Ele suspirou.</p>
<center><h4>--*--</h4></center>
<p>- Cadê as velas quando a gente quer encontrá-las? – Jason batia as portas e as gavetas do armário da cozinha em sua busca incansável pelas velas com o seu celular em outra mão em uma espécie de lanterna. 
<p>- Jason, se acalma. – Amanda o seguia de perto. 
<p>- Está escuro e eu preciso de uma vela. – Ele falava irritado.
<p>- Eu sei por que está nervoso, e não é por causa de uma vela. – Amanda pegou no pulso do namorado o impedindo de bater mais uma gaveta.
<p>- Tem razão. Minha mãe, ela... na rua nessa chuva. Vou precisar sair para ir atrás dela.
<p>- Nem pensar! – Ela deu uma ordem. – Além do mais, ela já ligou. Disse que vai ficar no trabalho até a chuva parar. Ela está bem.
<p>- Não vai ficar quando chegar em casa. 
<p>- Jason. 
<p>- Ele está na minha sala, Amanda! – Jason gritou como se não se importasse com a outra pessoa na sala escutando. – Sentado no meu sofá! Como se nada tivesse acontecido! 
<p>- Eu sei. – Amanda segurou seu ombro tentando passar para ele um pouco de conforto.
<p>- O que eu vou fazer? – Ele tremia agora. Sua raiva estava se transformando em vontade de chorar.
<p>- Ele é seu pai, vá conversar com ele. Não foi isso que você sempre quis?
<p>- Não. Eu não posso, Amanda. Eu não... Eu não quero isso.
<p>- Eu entendo, mas ele está aqui. 
<p>- Por quê? Eu não entendo. Por que agora? – Ele tinha parado de gritar. 
<p>- Você não vai saber se não falar com ele.
<p>- Eu não quero falar com ele. Eu quero que ele vá embora. – Parecia mais uma súplica do que um simples comentário.
<p>- Tudo o que você sempre quis foi ter o seu pai de volta. Agora você o tem.
<p>- E eu não quero mais. Eu quero ele fora daqui. 
<p>- Ele não pode ir embora, Jason. Está um inferno lá fora. Não pode expulsá-lo. 
<p>- Eu realmente não sei o que fazer.
<p>- Só... tenta se acalmar. – Amanda o abraçou. – Uma coisa de cada vez. – E naquele momento ela percebeu que a noite seria bem longa.</p> 
<center><h4>--*--</h4></center>
<p>Sebastian e Melissa estavam parados no meio da longa fila de carros na interestadual que os levaria de volta para Los Angeles. Alguns guardas de trânsito estavam passando entre as filas avisando que o pedágio estava fechado por tempo indeterminado devido fortes chuvas na outra cidade. 
<p>- Ai, eu estou cansado de ficar parado. – Sebastian se mexia no banco incomodado.
<p>- Eu estou é com sono. – Melissa riu.
<p>- Se não tivéssemos parado para tomar sorvete, com certeza teríamos chegado antes da chuva em casa. – Ele resmungou. – Eu também estou com sono.
<p>- Você não pode ter sono, é o motorista.
<p>- Eu tenho costume de dormir cedo, tá bom? Os remédios me dão sono.
<p>- Seus remédios são para que mesmo?
<p>- Vitaminas. Eu era um pouco desnutrido quando criança. – Sebastian tinha essa desculpa na ponta da língua.
<p>- Imagino. – Melissa percebeu a mentira, mas deixou passar. – Ai, vamos sair daqui. – Ela se desfez do cinto de segurança.
<p>- Eu bem que queria, mas você está vendo alguma saída? – O sono deixava Sebastian um pouco ranzinza. – Caso não tenha percebido, está tudo parado.
<p>- Sai do carro. Ele não vai para lugar nenhum mesmo. 
<p>- Estamos no meio da estrada. 
<p>- Podemos ao menos ver as estrelas. 
<p>- O quê?
<p>- Em Los Angeles está chovendo, mas aqui não. Eu adoro ver as estrelas. – Ela abriu a porta do carro e saiu.
<p>- O quê? Não! Espera!
<p>Sebastian tirou o cinto de segurança bem rápido, tirou a chave da ignição, saiu do carro, o trancou e correu atrás dela.</p>
<center><h4>--*--</h4></center>
<p>- Ninguém está ouvindo a porta?! Parece que não! – Quinn desceu as escadas correndo para atender a porta. Depois da queda de luz, ela havia se trancado no quarto de Emily para dar a ela alguma cobertura. – Quem será uma hora dessas?
<p>Quinn abriu a porta e se assustou.
<p>- Chris? O que faz aqui?
<p>- A Emily está aqui? – Ele estava ensopado e sem fôlego.
<p>- Não. Ela foi para sua casa, na verdade, falar com o Will. – Quinn estava achando tudo meio estranho. – O que você quer com ela?
<p>- Acho melhor então eu voltar para casa.
<p>- Não, espera. Sua casa não é tão perto assim para você andar nessa chuva. Pode ser perigoso.
<p>- Não tem problema.
<p>- Entra e espera a chuva passar. 
<p>- Seus pais não se importam?
<p>- Já devem estar dormindo. Além do mais, é o Will e o Sebastian que meu pai odeia. – Quinn riu.
<p>- Tudo bem. – Ele entrou com um pouco de cuidado. Estava completamente molhado e jogando água para todo lado.
<p>- O que aconteceu para você resolver correr na chuva? – Quinn perguntou assim que voltou para a sala com uma toalha tirada do banheiro.
<p>- Eu já estava na rua e... Eu terminei com a Ashley.
<p>- Sério? Por quê?
<p>- Eu cansei. – Chris começou a tirar o excesso de água com a toalha.
<p>- Nossa, isso parece um motivo bem fútil. – Quinn franziu a testa.
<p>- Não, eu não me cansei dela, eu me cansei de tudo. Houve uma época em que eu preferia ficar com ela mesmo ela não gostando de mim. – Ele abaixou a cabeça aparentemente envergonhado de olhar nos olhos de Quinn. 
<p>- Isso é estranho.
<p>- Eu sei. Ninguém nunca entendeu. Ela me traiu algumas vezes e eu perdoei. Eu não acreditava que ela fosse realmente mudar, eu só queria ficar com ela apesar disso. 
<p>- Eu conheço alguém bem parecido com você. – Ela olhou discretamente para o teto. 
<p>- Eu sei como eu sou, tá legal? Eu não sou a pessoa mais gentil e feliz do mundo e sei que muitos não suportam ficar perto de mim por muito tempo, mas ela...
<p>- Suportava. Independente de tudo.
<p>- Exato. – Chris perdeu a luta em tentar se secar. – É, eu acho que me secar desse jeito não vai dar certo.
<p>- Vamos lá para cima. Talvez eu tenha algum moletom que caiba em você até suas roupas secarem.
<p>- São rosa?
<p>- São secos.</p>
<center><h4>--*--</h4></center>
<p>Will estava encostado em uma das vigas brancas de madeira que segurava o telhado da varanda. Ele observava os pingos de chuva caindo enquanto pensava em Emily que estava dentro da casa. 
<p>- Eu peguei umas roupas da Amanda, espero que ela não se importe. – Emily apareceu na varanda enxugando os cabelos com uma toalha. 
<p>- É a Amanda, é claro que vai se importar. – Will sorriu.
<p>- O que está fazendo aqui? Acho melhor esperar lá dentro a chuva passar. 
<p>- Eu não estava esperando, eu só estava... pensando. – Will não parecia tão animado quanto alguns minutos atrás. 
<p>- Pensando em quê?
<p>- Em nós. – Ele encarou Emily. – O que acontece agora? 
<p>- Como assim?
<p>- Tudo isso, foi incrível você ter aparecido aqui no meio da chuva dizendo aquelas palavras, foi incrível te beijar de novo, eu estava querendo muito te beijar, e embora tenha recusado a minha ajuda para trocar de roupa... – Ele sorriu. – Tudo isso foi muito bom, mas... o que vai acontecer daqui para frente?
<p>Emily ficou em silêncio. 
<p>- Você terminou comigo por causa de várias coisas e essas coisas não vão sumir nem mudar só porque você apareceu aqui essa noite. O que mudou? O que está acontecendo? Você está a fim de outra tentativa e vai pular fora na primeira oportunidade? Eu não quero isso. Acho que um término só basta para mim.
<p>- Eu amo você.
<p>- Eu sei que ama, mas isso não provou ser suficiente na primeira vez, por que será agora? O que eu fiz exatamente para fazer você mudar de ideia?
<p>- Você não fez nada, na verdade. 
<p>- Você me deixa muito confuso. – Will colocou a mão na cabeça e respirou fundo.
<p>- Eu... eu quero uma segunda chance. 
<p>- Esse é o problema. É claro que eu vou te dar essa segunda chance e uma terceira e uma quarta... Mas é assim que a gente vai continuar? 
<p>Emily voltou a ficar em silêncio.
<p>- Emily, eu preciso que me diga. Eu sei como eu sou, tá legal? Eu posso te fazer muito feliz, eu sei que eu posso, mas nesse meio... Eu não sou perfeito e nada do que me rodeia é. Se você topar ficar comigo, é isso que você vai conseguir. Um garoto problemático que ama você mais que tudo nessa vida. – Ele a olhou com ternura e depois voltou a ficar sério. – Mas eu preciso saber se você vai entrar nessa comigo totalmente ou vai ficar com um pé para fora. 
<p>- Eu topo. – Os dois ficaram se olhando e Will não conseguiu comprar aquilo. – Você não acredita, não é?
<p>- Eu quero acreditar. Porque eu te amo e, sei lá, eu quero passar o resto da minha vida com você. – Will fechou os olhos. – Eu não acredito que eu disse isso. 
<p>- Ai, meu Deus. – Emily arregalou os olhos. – Eu também. – Ela falou baixinho.
<p>- O quê? – Will franziu a testa. 
<p>Emily saiu da varanda e foi em direção a chuva. 
<p>- Emily, volta para cá, você acabou de se secar!
<p>- Eu também! – Ela gritou. – EU TAMBÉM QUERO PASSAR O RESTO DA MINHA VIDA COM VOCÊ! 
<p>- Você é muito doida, sabia disso? – Will foi até ela. As gotas de chuvas estavam caindo mais fortes do que parecia. 
<p>- Meu pai está errado porque ele não sabe nem um quarto do que eu sei sobre você. – Ela falou assim que Will chegou perto dela. – Você é a pessoa mais maravilhosa desse mundo.
<p>- Para. – Will estava ficando envergonhado.
<p>- Que se dane a Giovanna, o Kevin, aquelas garotas, ninguém sabe de nada. Você tinha razão esse tempo todo. Todo mundo pode achar que somos ridículos, mas não somos. Somos...
<p>- Lindos. Você ainda se lembra disso? – Will riu.
<p>- Eu topo. Eu topo ficar com esse garoto problemático que me ama mais que tudo nessa vida porque eu também o amo. Acredita em mim agora?
<p>- Eu sempre vou acreditar em você. – Ele a beijou. 
<p>- Não, espera. Acho melhor a gente fazer isso lá dentro. – Emily tentava tirar a água do rosto inutilmente.
<p>- O quê? Por quê? – Will não entendeu. – Beijo na chuva é a coisa mais romântica que um casal pode fazer.
<p>- Ah é? Você é alto demais e eu tenho que olhar para cima para poder te beijar. Uma gota quase me deixou cega agora. – Ela riu.
<p>- Nos filmes, parece ser mais fácil. 
<p>- Será que é falta de prática? Então eu acho que a gente devia tentar de novo. 
<p>- Já que você insiste. 
<p>Os dois voltaram a se beijar e aparentemente, a chuva não foi um incomodo.</p>
<center><h4>--*--</h4></center>
<p>- Cadê a sua mãe?
<p>Richard, sentado no sofá, encarava Jason que estava do outro lado da sala, em pé perto da porta.
<p>- Está no trabalho. Vai esperar a chuva passar. – De repente, Jason sentiu que aquela sala estava pequena demais para os dois. A casa estava. Queria mais do que tudo que aquela chuva passasse para ele poder fugir dali.
<p>- Poderíamos tomar um café. – Amanda se sentou no sofá também para tentar quebrar o gelo. – Pensando bem, eu não sei fazer café sem cafeteira. – Ela deu um sorriso sem graça.
<p>- Eu posso fazer. – Richard fez menção de se levantar.
<p>- Você não vai tocar em nada da cozinha. – Jason falou alto e sério. – O que faz aqui? Vai dizer que se importa?
<p>- Eu me importo.
<p>- Então chegou uns anos atrasado.
<p>- Filho, eu sinto muito. – Richard não parava de encarar o filho. Queria tocá-lo de alguma maneira.
<p>- Eu também. – Jason continuava sério. – Eu seria uma pessoa ruim se te expulsasse daqui nessa chuva? Levando em conta o histórico, eu acho que não.
<p>- Acho melhor a gente se acalmar. – Amanda estava assustada. Geralmente o descontrolado da relação era ela. – Jason, por que não vem aqui se sentar do meu lado?
<p>- Filho, eu sei que está chateado.
<p>- Chateado? Chateado? – Jason quase riu. – Eu fico chateado quando tiro nota baixa em alguma prova. 
<p>- Filho...
<p>- Cadê a sua esposa? Amante? Sei lá como você a chama agora.
<p>- Eu a larguei.
<p>- Acho que na verdade ela que te largou, você ficou sozinho e agora não tem para onde ir, por isso está aqui.
<p>- Filho, é mais complicado que isso.
<p>- Para de me chamar de filho, você não é meu pai. Eu não tenho pai. – Jason começou a respirar fundo sem parar. Ele estava a um passo de explodir. 
<p>- Filho...
<p>- Olha, quer saber, se te expulsar é errado, eu que vou sair então, porque eu não aguento ficar aqui. – Jason abriu a porta da casa.
<p>- Jason, espera. – Amanda se levantou do sofá. – Sair nessa chuva é muito perigoso.
<p>- Filho, me escuta. – Richard se levantou também.
<p>- Eu não quero te escutar! Eu quero que vá embora! – Ele gritou. – Eu não preciso mais de você. 
<p>- Não é verdade.
<p>- Por que voltou, hein? Cansou da sua vida de solteiro? Finalmente lembrou que tem um filho? Está com remorso? Se eu disser que te perdoo, você vai embora feliz?
<p>- Eu me arrependo muito de como as coisas aconteceram. Se você soubesse o quanto eu senti a sua falta nesses anos todos...
<p>- Sentiu minha falta? – Jason segurou o choro. – Meu telefone não mudou, pai, muito menos meu endereço. Eu estava aqui esse tempo todo, onde você estava? Uma ligação, eu só precisava de uma ligação, mas você nunca ligou. – Ele olhou para o pai e só conseguiu sentir mágoa. – Não venha me dizer que sentiu a minha falta. Eu precisei de você e você não estava aqui. Agora eu não preciso mais, agora eu quero que vá embora, agora eu odeio você. 
<p>- Eu nunca quis isso.
<p>- Ninguém te obrigou a ir embora. Aparentemente você queria isso sim. Agora quem não te quer aqui sou eu. – Jason segurou a maçaneta e falou assim que viu Amanda indo em direção a ele. – Relaxa, Amanda, eu não vou sair na chuva, só vou ficar aqui do lado de fora, porque não consigo respirar o mesmo ar que ele. 
<p>Jason saiu de casa e bateu forte a porta.</p>
<center><h4>--*--</h4></center>
<p>- Se um monte de formigas subir em cima de mim, eu vou culpar você. 
<p>Sebastian estava há alguns minutos reclamando de se deitar no gramado ao lado do acostamento da rodovia. Melissa só olhava para ele e ria a cada reclamação que ela ouvia.
<p>- Qual é a graça de ficar aqui olhando para o céu afinal?
<p>- Estrelas são lindas. – Melissa olhou feio para ele.
<p>- Não vejo nada demais. 
<p>- Vocês, homens, têm muitos problemas.
<p>- Os homens em geral eu não sei, mas eu, com certeza. – Ele riu. 
<p>- Que tipo de problema?
<p>- Todos que você possa imaginar. 
<p>- Você curte zoofilia e essas coisas?
<p>- O quê!? Não! – Sebastian fez uma cara de nojo.
<p>- Então não é todo tipo. – Melissa caiu na gargalhada. – Qual é o problema? 
<p>- Bom, vamos começar por uma coisa. - Sebastian ficou sério e pensativo. – Eu às vezes acho que se eu morrer, vai ser melhor para todo mundo. Vão parar de se preocupar comigo. 
<p>- Tudo bem, isso é muito autodepreciativo. – Ela parou de rir. – Fala sobre isso com a sua terapeuta?
<p>- Terapeuta? – Sebastian ficou surpreso.
<p>- É. Não foi com ela que você se consultou hoje? Ou ele, eu não sei dizer. 
<p>- Como você sabe?
<p>- Exames de rotina. Vitaminas porque você era uma criança desnutrida. Sua cara contando todas essas mentiras. Acha mesmo que colou?
<p>- Eu achei que sim. 
<p>- Se uma pessoa mente sobre o médico, só pode ser um terapeuta ou psicólogo, como quiser chamar. A não ser que tenha ido fazer exame de toque ou tenha uma doença venérea. 
<p>- Terapeuta. 
<p>- Por que mentiu? Tá, eu sei que a gente acabou de se conhecer, mas...
<p>- Exatamente por isso. Não é uma coisa que a gente conta para alguém que acabamos de conhecer. 
<p>- Depende. Eu não me importo em saber disso. A não ser que você seja algum maníaco em reabilitação. Eu não acredito muito em segundas chances nesses casos então eu seria obrigada a sair correndo. 
<p>- Não, pode ficar tranquila quanto a isso.
<p>- Então... – Ela ficou esperando ele contar o real motivo, mas ele enrolou.
<p>- A história é longa.
<p>- O trânsito está parado e sem horário para voltar a rodar. Estamos aqui deitados olhando estrelas. Acho que temos tempo e eu tenho uma fama de ser bem compreensiva.
<p>Ela lhe deu um sorriso e de repente Sebastian se sentiu mais confiante em contar a ela o que realmente acontecia com ele.
<p>- Eu... eu meio que... eu sou um viciado em reabilitação. Sete meses e contando. 
<p>- Como isso aconteceu? – Sebastian ficou surpreso por Melissa não ficar horrorizada e querer terminar com a conversa o quanto antes. 
<p>- A família do Will me adotou quando eu vim para Los Angeles me tratar depois que o serviço tutelar me tirou dos meus pais. Eu não os culpo, os meus pais, eles não tinham ideia do que estavam fazendo. 
<p>- Eu imagino.
<p>- Meu pai era um alcoólatra que batia na minha mãe o tempo todo. Então ela me batia para acabar com as frustrações. Quando eu começava a chorar de dor, ela me enchia de drogas para eu dormir. Uma hora eu comecei a fazer isso sozinho. As drogas acabaram virando a resposta para tudo. 
<p>- Você já teve... – Melissa falou com cautela.
<p>- Uma overdose? Algumas vezes. Digamos que eu sou um cara de sorte. – Mas ele não falou com um tom de felicidade.
<p>- Você se considera um peso?
<p>- Eu fico mal e levo todo mundo junto comigo para o fundo do poço. 
<p>- E acha que se morrer, todos vão ficar bem? É a coisa mais ridícula que eu já ouvi. Essas pessoas amam você.
<p>- Eu sei disso e estou vivo graças a elas. Eu até às vezes me imagino como um garoto normal, sem problemas, sem experiências ruins. Só um garoto.
<p>- Eu acho que Deus não te dá nada além do que você pode carregar.
<p>- Diz isso para todo mundo que se mata todos os dias. 
<p>- Bom, eu só acho que se você fosse um garoto normal, não estaria aqui em Los Angeles, não teria conhecido sua família, não estaria namorando a Quinn e definitivamente não estaríamos tendo essa conversa.
<p>- Mas minha vida seria melhor. Eu não ia me sentir estranho o tempo todo. Não teria que fingir estar feliz quando não estou. Não teria preocupações. 
<p>- Eu não sou uma viciada, mas eu me sinto estranha na maior parte do tempo, eu tenho que fingir estar feliz quando não estou e esse rosto de anjo esconde muitas preocupações. – Ela sorriu. 
<p>- Isso me deixa mais para baixo.
<p>- Não deveria. Todo mundo luta por alguma coisa. Todo mundo tem problemas. O que parece simples para você pode ser o fim do mundo para a outra pessoa. 
<p>- Então eu tenho que aceitar que nasci para ser um covarde e um perdedor?
<p>- Você não é nenhuma dessas coisas. – Melissa segurou na mão dele gelada. – Você sobreviveu mesmo contra todas as probabilidades. Não foi sorte, foi você. Você é um guerreiro, é um vencedor. Não deve se considerar menos que isso. 
<p>- Acha mesmo isso?
<p>- Eu tenho certeza. E saiba que não está sozinho.
<p>- Obrigado. – Sebastian sorriu. – Parece que me deitar aqui no chão não foi tão ruim. 
<p>- Viu só? Reclamou à toa.</p>
<center><h4>--*--</h4></center>
<p>- Você namorava lá em Nashville?
<p>Chris estava deitado no tapete ao lado da cama de Emily onde Quinn estava deitada.
<p>- Por que está me perguntando isso? – Ela franziu a testa.
<p>- Ashley foi a minha primeira namorada. E eu nem sei como eu consegui fazê-la gostar de mim. 
<p>- É, eu já namorei alguns. – Quinn começou a falar antes que Chris caísse de novo na sua festa de autopiedade. – Acho que nesse quesito, eu sou mais parecida com o Will. 
<p>- Você ama o Sebastian? 
<p>- Eu gosto muito dele. Demais até, mas por que está perguntando isso?
<p>- Curiosidade. – Chris enrolou.
<p>- O que você queria com a Emily? Tentar ficar com ela?
<p>- O quê? Não! Queria me desculpar e tentar convencê-la a voltar com o Will.
<p>- O quê? – Quinn se levantou da cama com a tamanha surpresa. – Essa função geralmente é do Jason ou do Sebastian, até mesmo da Amanda. 
<p>- Você estava lá quando o Will socou o Kevin. Aquilo nunca deveria ter acontecido. A Giovanna está fazendo coisas e a Ashley sabe disso e deve apoiá-la. E eu como namorado dela, a apoio mesmo que não querendo.
<p>- Chris, ninguém acha que você apoia as coisas que a Giovanna faz. A gente só não gosta de você porque você é chato. – Ela sorriu. 
<p>- Eu era muito próximo do Will quando éramos crianças, mas em algum momento fomos para lados opostos. Ainda somos próximos, ele sabe quem eu sou e eu sei quem ele é, mas não conseguimos conversar por dez minutos sem brigar.
<p>- Cinco minutos, na verdade. 
<p>- Will antes da Emily nunca teria cantado na frente da família toda. Isso é importante, eu vi como ele ficou.
<p>- Olha só, você não é só chato, é fofo também. Já quero apertar suas bochechas. – Quinn voltou a deitar. 
<p>- Você nunca amou nenhum dos seus namorados em Nashville?
<p>- Nossa, de novo com esse assunto? 
<p>- Já?
<p>- Eu também já fui traída, Chris. Eu estava tão cega que nem na minha irmã eu acreditei. Acho que foi uma das nossas piores brigas. Eu até entendo o Kevin por isso e sei que no final ele vai sofrer. 
<p>- Infelizmente. 
<p>- É, é uma pena. – Quinn suspirou. – Mas é só um coração partido, a gente supera.
<p>- Supera mesmo? – Chris não tinha tanta certeza naquele momento.
<p>- Nós precisamos, não é?</p>
<center><h4>--*--</h4></center>
<p>- Está ouvindo isso?
Will e Emily foram se deitar no tapete da sala depois que perceberam que aquele sofá era pequeno demais para os dois. O braço dele estava em volta dela enquanto ela usava seu ombro como travesseiro. A chuva já tinha praticamente passado. Agora dava para ouvir as gotas das telhas escorrendo e pingando no chão e o vento que já tinha diminuído. 
<p>- As gotas de chuva? – Will perguntou. 
<p>- Tirando isso.
<p>- Não ouço nada. – Will tentou forçar mais sua audição, mas no final, não ouviu mais nada mesmo.
<p>- Exatamente. É como se o mundo estivesse vazio, parado.
<p>- Não, é só a minha casa mesmo. – Will riu. 
<p>- Você já desejou que o mundo parasse só por um segundo. 
<p>- Já. – Will ficou sério. – Muitas vezes. Agora é uma dessas vezes. 
<p>- Ah é? – Emily se virou para olhar para ele.
<p>- Daqui a pouco, a chuva vai passar completamente, as luzes vão voltar, o telefone vai começar a tocar, alguém vai chegar em casa, você vai ter que ir embora. E tudo o que eu quero é que esse momento, o agora, dure para sempre. Não queria me levantar. Queria ficar aqui com você até minhas costas doerem.
<p>- Senti sua falta. – Emily suspirou enquanto seus lábios tocavam suavemente os lábios do namorado.
<p>- Eu também senti a sua. 
<p>- Sabe, eu não gosto muito de silêncio. Talvez seja porque minha casa sempre foi barulhenta.
<p>- Eu tenho mil irmãos, sei o que é ter casa barulhenta. – Will riu. – E embora eu goste também, às vezes eu curto um silêncio. Mas quando nos casar, eu quero que a gente tenha uns cinco filhos, para nunca mais vivermos em silencio. 
<p>- Cinco filhos? – Emily ficou surpresa.
<p>- O quê? Você não quer?
<p>- É claro que eu quero, mas não cinco. É de mim que eles vão sair. – Ela brincou. – Não sabia que queria ter filhos, mas pensando bem, você é uma graça com a Angie.
<p>- Eu não sou o único. Sabe, eu nunca pensei nisso, na verdade, mas sei lá, deve ser legal uma criança te chamar de pai.
<p>- Será que vamos ser bons pais?
<p>- Eu acho que sim. Não vamos ser perfeitos, mas... vamos dar o nosso possível e vamos amá-los não importa o que aconteça. Isso é o que importa, pelo menos é o que eu acho. Além do mais, eu vou ficar muito orgulhoso quando meu filho chegar em casa e dizer que beijou uma garota.
<p>- Isso só vai acontecer quando ele tiver vinte anos.
<p>- Eu espero que não, senão ele vai ter problemas.
<p>- Will!
<p>- Emily. – Ele sorriu.
<p>- E se tivermos uma filha? Vai ficar orgulhoso quando ela chegar dizendo que começou a namorar.
<p>- Vamos até fazer uma festa, se ela tiver trinta anos, é claro. Minha filha não vai namorar adolescentes como eu.
<p>- Por que não? – Emily estava quase rindo.
<p>- Droga, eu estou falando como o seu pai agora, não estou?
<p>- Está, sim. 
<p>- Eu quero uma família, Ems. E eu quero uma com você. – Will a olhava como se admirasse cada traço do seu rosto.
<p>- Se você já tivesse um anel, eu até aceitaria me casar com você agora. – Ela sorriu.
<p>- Eu estou falando sério.
<p>- Eu sei que está e eu também. Eu te amo e eu sei que vou te amar daqui cinquenta anos.
<p>- Como sabe? 
<p>- Eu só sei. 
<p>Emily voltou a colocar a cabeça no ombro de Will e os dois ficaram em silêncio olhando para o lustre no teto. Eles adormeceram depois de um tempo.</p>
<br>
<p>“Às vezes temos um momento e a nossa cabeça faz de tudo para absorver cada detalhe daquilo porque sabe que não vai durar e não sabe quando vai acontecer de novo. Eu me lembro exatamente de tudo daquela noite. A posição em que estávamos deitados no chão. O vento entrando na fresta da janela e me deixando com um pouco de frio. Minha camiseta velha dos Rolling Stones que a Emily vestia depois de molhar de novo as roupas na chuva. O cheiro de morango do cabelo dela e como o meu coração estava acelerado só de sentir ela do meu lado. Eu ainda me lembro de tudo, de cada palavra e de como ali tudo mudou. 
<p>O mundo parou naquele momento. Todos sumiram. Só nós ficamos e naquela hora estava tudo bem. Eu queria que durasse para sempre, nós dois queríamos. E de uma certa forma durou porque aquela sensação nunca foi embora, ainda está comigo até hoje. Meu coração acelera só de sentir o toque dela e às vezes, em um lugar cheio de pessoas, tudo o que eu vejo é ela, como se... fôssemos os únicos no mundo.”.</p>
</body>
</html>";
            }

            if (numero == 28)
            {
                lblTitulo.Text = "Capítulo 28 - Mas É Difícil Quando Se é Jovem";
                htmlPage.Html = @"<html>
<body>
<p><i>“Nós dois sabemos que vou longe demais
<br>Como quando eu destruí seu carro
<br>E quase briguei com seu pai
<br>Quando ele me empurrou no jardim
<br>E todas aquelas noites em que escapamos
<br>Para nos encontrarmos no bar
<br>Não se preocupe, meu amor, estamos aprendendo a amar
<br>Mas é difícil quando se é jovem”
<br><b>Young - The Chainsmokers</b></i></p>
<br>
<p>Will sentiu alguém o chacoalhando com uma mão bem pesada. Ele abriu os olhos, sua visão ainda estava bem embaçada. A primeira coisa que fez foi olhar para a janela ao seu lado, o sol ainda não tinha nascido. Depois olhou para quem o acordou.
<p>- Amanda? 
<p>- Preciso que levante e vá falar com o Jason. Ele está lá fora. – Amanda sussurrou.
<p>- Que horas são? – Ele também sussurrou. Não queria acordar Emily que ainda dormia em cima de seu braço. 
<p>- Quase quatro. A chuva já parou.
<p>- E ele não pode esperar o sol nascer como qualquer pessoa normal?
<p>- Não, e quando souber do que se trata, vai entender.
<p>Will encarou a irmã e ela realmente parecia preocupada. Não poderia ser uma brincadeira qualquer ou algo sem importância. 
<p>- Tudo bem, você venceu. – Ele começou a se levantar bem devagar e com muito cuidado para não acordar Emily.
<p>- A noite foi boa, hein? – Amanda então sorriu.
<p>- Maravilhosa. – Ele retribuiu o sorriso.</p>
<center><h4>--*--</h4></center>
<p>Jason estava sentado nos degraus da entrada da casa no lado de fora. Will se sentou ao lado dele e finalmente entendeu o que sua irmã estava dizendo. Os olhos do amigo estavam muito vermelhos e pela cara dele, não parecia ser de sono.
<p>- Você está bem? Andou chorando?
<p>- Um pouco. – Jason passou as mãos no rosto achando que ainda tinham lágrimas escorrendo.
<p>- O que aconteceu?
<p>- É o meu pai. 
<p>- Ele morreu? – Will arregalou os olhos.
<p>- Não. – Jason hesitou. – Ele voltou. 
<p>- O quê? Como assim? Por quê? – Will abriu a boca por causa do choque. 
<p>- Eu não sei. Eu não sei de nada. 
<p>Will ficou em silêncio. Ele não sabia o que dizer nem fazer, não estava mesmo esperando por aquilo. Ficou então ao lado do amigo e percebeu que era exatamente o que Jason queria. Só a companhia. 
<p>Will se lembrava muito bem do dia em que o pai de Jason foi embora. Os dois eram pequenos e ele não entendeu nada na época. Jason sempre falava do pai, o quanto ele adorava levar o filho para jogar bola e como ele contava todo dia histórias de ninar. Ele sempre fazia grandes surpresas nos aniversários de Jason. Era sempre assim. 
<p>Richard havia combinado com o filho que levaria ele para ver o letreiro de Hollywood. Jason só falava disso o tempo todo, nas coisas que ele veria, nas fotos e no passeio, mas no grande dia, o pai cancelou tudo dizendo que precisava viajar por causa do trabalho. 
<p>Mas não era uma simples viagem a negócios. Os dois garotos viram ele colocando todas as suas roupas nas malas enquanto a mãe não parava de chorar e gritar ao mesmo tempo. Não foi uma cena muito bonita de ver. Então veio o “adeus, filho” bem rapidamente, e de algum jeito, Jason sabia que o pai dele não ia mais voltar. Depois de um tempo, ele acabou descobrindo que seu pai deixou sua mãe por outra mulher, o que só piorou a situação.
<p>Will sabia que não tinha sido o adeus do pai que magoou Jason e sim o esquecimento. Ele nunca admitia, mas sempre ficava esperando o pai telefonar pelo menos no aniversário ou simplesmente mandar um cartão ou um presente de Natal, mas isso nunca aconteceu.</p>
<center><h4>--*--</h4></center>
<p>- Não precisava me trazer até a porta de casa. 
<p>O sol já estava nascendo. Sebastian e Melissa estavam parados na frente da porta da casa dela enquanto ela procurava sua chave na bolsa. Os dois pareciam muito cansados.
<p>- Está brincando? É o meu dever.
<p>- Era o seu dever também falar ontem com a minha mãe no telefone para dizer que eu estava segura? – Melissa ria. 
<p>- Com certeza e agora eu vou ficar aqui esperando ela aparecer só para dizer que você está entregue sã e salva como prometido.
<p>- Você não vai fazer isso. Cai fora daqui. – Melissa colocou a chave na fechadura.
<p>- De jeito nenhum. – Sebastian riu. – Olha, falando sério agora, eu queria te agradecer.
<p>- Pelo o quê?
<p>- Você sabe, pelas coisas que você disse. Foi muito importante para mim ouvir aquilo. 
<p>- Tudo bem, não precisa agradecer. A não ser que você resolva me dar dinheiro por isso, aí eu aceito.
<p>- Isso não vai acontecer. 
<p>- Bom, eu também tenho que te agradecer.
<p>- Mas eu não fiz nada. 
<p>- Exatamente. Obrigada por não abusar de mim enquanto eu dormia. – Ela sorriu.
<p>- Palhaça.
<p>- Disponha. Sempre que quiser conversar, eu vou estar aqui.
<p>- Sempre mesmo? Às vezes eu surto três da manhã. 
<p>- Se você prometer que vai ouviu os meus surtos às quatro da manhã, eu escuto os seus às três. – Ela abriu um sorriso. 
<p>- Combinado.</p>
<center><h4>--*--</h4></center>
<p>- Por que a minha cama está bagunçada?
<p>Emily entrou no seu quarto pronta para tomar banho e se arrumar para ir à escola quando deu de cara com a sua cama não estando do jeito que deixou na noite passada.
<p>- O quê? – Quinn estava deitada na cama um pouco nervosa.
<p>- Você dormiu aqui ontem? E por que tem um cobertor no tapete? – Emily pegou a coberta do chão e colocou em cima da cama.
<p>- Ah, é que... – A irmã começou a pensar em uma desculpa. – Eu fiquei aqui caso nossos pais viessem conferir... Alguém teria que estar deitada aqui para...
<p>- Eu liguei para eles ontem avisando. – Emily a cortou.
<p>- Sério?
<p>- Foi você que atendeu. – Ela sabia que Quinn estava mentindo. – Quem dormiu aqui?
<p>- O que contou para os nossos pais? – Quinn enrolou. – Duvido que nosso pai aceitaria você dormindo com o Will.
<p>- Eu menti. Disse que ia ficar no quarto da Amanda, que os pais dele estavam lá... Esse tipo de coisa. 
<p>- Entendi.
<p>- Agora, para de enrolar. Quem dormiu aqui?
<p>- Chris.
<p>- Chris? Que Chris? – Emily demorou para associar o nome com a pessoa porque seria muito absurdo pensar que... – Espera um pouco, o Chris, nosso Chris?
<p>- Existe outro Chris?
<p>- Por que o irmão do Will dormiu aqui? – Emily estava confusa.
<p>- Ele terminou com a Ashley.
<p>- E...
<p>- Ele não tinha para onde ir.
<p>- Que tal a casa dele? Não sabia que vocês eram melhores amigos. 
<p>- Olha, só para constar, ele veio aqui atrás de você. – Quinn apontou o dedo para a irmã.
<p>- De mim? Achei que a gente não se dava bem. Eu pelo menos não me dou bem com ele. Nossos pais sabem disso?
<p>- É claro que não. Está maluca?
<p>- E o Sebastian?
<p>- Ele não precisa saber. Não aconteceu nada. Além do mais, ele passou a noite toda na estrada com a tal Melissa.
<p>- É, o Will falou que eles ficaram presos no trânsito em São Francisco.
<p>- Ou em um hotel barato.
<p>- Está com ciúmes? – Emily riu.
<p>- Você não estaria?
<p>- Acho que não. 
<p>- Tudo bem então, eu sou a paranoica. Agora me conta, como foi a sua noite?
<p>- Perfeita.
<p>Emily se sentou na cama mesmo bagunçada para conversar com a irmã e contar todos os detalhes da noite passada.</p>
<center><h4>--*--</h4></center>
<p>Sebastian entrou em casa quase sem fôlego. Ele havia recebido uma mensagem de Will. Código vermelho. Jason e Will estavam sentados no sofá. Os dois estavam em silêncio. Jason observava fixamente suas mãos enquanto Will parecia paralisado olhando para o amigo.
<p>- Seu pai voltou? – Sebastian só ia realmente acreditar se Jason falasse. 
<p>- Sim. – Jason falou sem emoção.
<p>- E o que você vai fazer?
<p>- O que você faria se seus pais voltassem? – Ele retrucou um pouco irritado.
<p>- Sairia correndo. O que ele quer? – Sebastian continuou fazendo perguntas.
<p>- Eu não sei.
<p>- Mas não conversaram ontem? Ele ainda está na sua casa?
<p>- Eu já disse que não sei. – Jason ficou bravo.
<p>- Ele vai ficar por muito tempo? Onde ele está ficando?
<p>- Eu já disse que eu não sei! – Jason gritou.
<p>- Vamos todos nos acalmar. – Will falou logo. – Jay, o que você quer fazer agora? A gente vai te apoiar.
<p>- Eu preciso ficar sozinho. – Jason se levantou e foi em direção a porta. – Por favor, não vão atrás de mim. Eu vou ficar bem. Só preciso de um tempo.
<p>- Nossa. – Sebastian ficou observando Jason ir embora. – Que loucura.
<p>- Nem me fale. – Will estava se sentindo impotente, não tinha ideia do que poderia fazer para ajudar e essa sensação estava o matando por dentro.</p>
<center><h4>--*--</h4></center>
<p>- O pai do Jason voltou? – Emily ficou bem chocada com a notícia.
<p>Will estava esperando por ela no portão assim que ela chegou na escola. Diferente do que ele normalmente faria por serem namorados, ele a beijou na bochecha e não na boca e nem segurou sua mão. Só caminhou ao seu lado. Ela percebeu a diferença, mas preferiu não comentar.
<p>- Acho que por isso que choveu. – Will esperava que Emily não começasse a fazer um milhão de perguntas. Ele não saberia responder.
<p>- Ele deve estar péssimo.
<p>- Péssimo é apelido. Imagino como foi para ele encontrar o pai depois de tanto tempo.
<p>- E o que ele quer? Se desculpou, pelo menos?
<p>- Eu não sei. Basicamente, eu fiquei do lado do Jason a manhã toda em silêncio enquanto ele olhava sem foco para qualquer outro lugar. A situação está bem ruim.
<p>- Sabe quem também deve estar péssimo e em uma situação ruim? O Chris.
<p>- Chris? O meu Chris? Por quê?
<p>Os dois pararam em frente ao armário de Emily para ela poder pegar seus livros. Will deu um pequeno sorriso quando viu que as fotos que havia colocado lá alguns dias atrás ainda estavam no mesmo lugar que deixou.
<p>- Ele terminou com a Ashley. – Emily explicou.
<p>- Como é que é? – Will ficou surpreso. Esse era o tipo de coisa que ele achou que nunca aconteceria. – Como você sabe?
<p>- A Quinn me contou. Ele foi lá em casa ontem no meio da chuva.
<p>- Que louco. 
<p>O sinal do começo das aulas tocou.
<p>- Olha, eu preciso ir. Tenho que dar a volta para pegar meus livros bem rápido senão vou me atrasar.
<p>- Tudo bem. – Emily estranhou de novo. Ela sabia que Will não ligava em se atrasar para a aula, mas não sabia por que ele não queria levá-la até a porta da sala de aula como costumava fazer. – Vai conversar com o Chris?
<p>- Vou ver o que aconteceu. 
<p>- Tudo bem. A gente se vê depois?
<p>- Claro.
<p>Will acenou e saiu andando rápido pelo corredor. 
<p>- Tudo bem então. – Emily franziu a testa. Ou ele estava mesmo com muita pressa ou simplesmente não queria beijá-la.</p>
<center><h4>--*--</h4></center>
<p>- Will me disse que você não apareceu na aula hoje, o que houve?
<p>Amanda encontrou Jason parado segurando bem firme o cadeado do seu armário. Ele parecia estar lá já fazia um tempo e até se assustou quando ela apareceu e começou a falar.
<p>- Ah, eu não estava com cabeça para ir para aula. Vou tentar ir nessa. 
<p>- Você está bem? Eu te liguei e...
<p>- Eu sei, só queria ficar um pouco sozinho. Pensar. – Jason deu um sorriso forçado. – Ele não apareceu hoje. Talvez tenha ido embora de novo. Talvez ele tenha desistido.
<p>- Pode ser sincero comigo. Me diz o que está sentindo.
<p>- Foi um choque ele voltar, mas agora eu estou bem.
<p>- Jason...
<p>- Ele não vai me derrubar, Amanda. De novo não. 
<p>- Olha, eu sei que você não está bem, mas eu não vou ficar forçando você a falar sobre isso e... pensar sobre isso, então... só saiba que eu estou aqui se quiser conversar e que eu não vou deixar ele te derrubar.
<p>- Eu te amo muito, sabia? – Jason beijou Amanda. – Mesmo se eu me afastar um pouco, se lembre disso. Nada disso é sua culpa, eu só estou...
<p>- Eu sei. Só não se fecha, por favor. 
<p>- Tá bom. Agora eu tenho que correr, minha próxima aula já vai começar. 
<p>Jason se despediu da namorada e saiu correndo, mas não havia levado nenhum livro do armário, nem ao menos um caderno.</p>
<center><h4>--*--</h4></center>
<p>- O que está fazendo almoçando sozinha? – Quinn colocou a sua bandeja de comida na mesa e se sentou ao lado da irmã. Aquela mesa era uma das mais escondidas do refeitório.
<p>- Nada, eu só queria um momento de paz. – Emily disfarçou um sorriso. A grande verdade era que não havia encontrado Will e Amanda também não estava por perto.
<p>- Quer que eu vá embora, então?
<p>- Eu nunca tenho o que eu quero. – Ela riu.
<p>- Irritante.
<p>De repente, Quinn fechou a cara e apertou bem forte o garfo que estava segurando. Ela começou a encarar o vazio.
<p>- Para quem você está olhando? – Emily tentou olhar para a direção que a irmã estava olhando.
<p>- Para o casal mais feliz do mundo na fila para pegar comida.
<p>- O quê? Quem é o casal mais feliz do mundo?
<p>- Sebastian e Melissa.
<p>- O quê? – Emily estava totalmente perdida.
<p>- Eles passaram a noite toda juntos. Ele me buscou em casa? Não! Quando eu cheguei aqui, ele já estava grudado nessa garota.
<p>Sebastian e Melissa estavam a alguns metros de distância daquela mesa. Quinn não gostava nada de ver os dois conversando e rindo. 
<p>- Primeiro, talvez ele não tenha tido tempo de te buscar. Ele e o Will estavam com o Jason. Sabia que o pai dele voltou?
<p>- O quê? – Quinn arregalou os olhos. – Por essa, eu não esperava.
<p>- E segundo, eles são amigos. O que de mal tem nisso?
<p>- É só olhar para ela. Está querendo roubar ele de mim. – Quinn esqueceu completamente do problema de Jason e voltou para o seu.
<p>- Quinn, para de ser paranoica. Eu não gosto nadinha desse seu lado.
<p>- Ele passou a noite toda com ela. – Ela falou bem devagar como se a irmã tivesse algum retardo mental.
<p>- Pelo menos ele te contou. Contou para ele que o Chris passou a noite no seu quarto?
<p>- Era no seu quarto e não é relevante. 
<p>- Quinn!
<p>- Não aconteceu nada. 
<p>- Exatamente. E por que você acha que com eles aconteceu?
<p>- Sei lá, por ele ser homem... por ser viciado, sei lá? – Quinn percebia o quão aquilo era ridículo, mas disse mesmo assim.
<p>- Ele é viciado em drogas, não em sexo. Para com isso. E conta logo para ele.
<p>- Contar o quê? – Amanda apareceu colocando a bandeja na mesa e se sentado do outro lado de Emily.
<p>- Nada. – Quinn falou com cara feia.
<p>- Que o Chris passou a noite na minha casa ontem com a Quinn.
<p>- O quê? Por quê? – Amanda abriu a boca chocada.
<p>- Ele terminou com a Ashley. – Quinn explicou. 
<p>- Sério? Isso é de longe a melhor coisa que ele fez na vida. Aleluia. – Amanda ficou feliz. – Mas pensando bem, ele deve estar bem mal. 
<p>- Sim. – Quinn concordou. – E como está o Jason?
<p>- Ele quer ficar sozinho. Não posso forçar a minha companhia, mesmo querendo muito.
<p>- Talvez seja melhor para ele. – Quinn concordou de novo.
<p>- Mas cadê o Will? – Amanda voltou sua atenção para Emily. – Por que ele não está aqui? Achei que tinham voltado.
<p>- Eu não sei onde ele se meteu. – Emily deu de ombros. – Deve estar tentando forçar a companhia dele com o Jason. 
<p>- Ele não está te evitando, está? – Amanda conseguia muito bem decifrar as pessoas.
<p>- Não é bem evitando, mas ele está um pouco distante. Achei melhor não perguntar nada sobre isso. 
<p>- Ou está com medo da resposta. – Amanda deu um sorriso falso. 
<p>- Não enche.
<p>- Olha, podemos esquecer isso e falar mal da Melissa? – Quinn ignorou a cara feia da irmã e olhou para Amanda.
<p>- Mas é lógico. – Ela sim ficou animada com a conversa.</p>
<center><h4>--*--</h4></center>
<p>- O que está fazendo aqui? – Jason entrou na sala de aula, ainda escura, e viu Will sentado na última carteira ao lado da janela.
<p>- Eu posso te perguntar a mesma coisa.
<p>- Só esperando a aula começar. – Jason se sentou na frente dele.
<p>- O mesmo. 
<p>Os dois ficaram em silêncio por alguns segundos, depois Jason se virou para poder olhar para Will.
<p>- Eu sei que eu estou de mal humor e não quero ter que lidar com multidões e estou me escondendo dela, mas de quem você está se escondendo?
<p>- Emily. – Will falou bem baixinho e com muita vergonha.
<p>- O quê? Você me disse que tinham voltado.
<p>- E voltamos, mas...
<p>- Mas...
<p>- Eu não quero que as pessoas saibam. Pararam um pouco de mexer com ela, se souberem que voltamos a namorar, talvez tudo volte, então... acho melhor a gente não chamar tanta atenção.
<p>- Falou para ela sobre isso?
<p>- Ela vai entender, é para o bem dela.
<p>- Isso significa que não. 
<p>- Eu estou fazendo isso por ela. Não tem por que ela ficar com raiva.
<p>- Isso é frescura. Ou vocês estão juntos ou não. Não tem meio termo, pelo menos, não deveria ter.
<p>- Eu sei. Eu achei que depois de ontem ficaria tudo bem, mas aí... Não estamos mais no chão da minha sala fingindo que ninguém mais existe e que tudo de ruim desapareceu. É a vida real agora e ela não é tão boa.
<p>- Essa é a coisa mais ridícula que eu já ouvi. 
<p>- Olha, eu não quero que ela sofra. Eu conheço essas garotas, elas não são fáceis. Eu sei muito bem disso, já fiquei com metade delas.
<p>- Talvez mais da metade.
<p>- Precisamos dar um tempo em toda essa demonstração de amor em público. É a melhor coisa a se fazer. – Will já estava convencido disso. 
<p>- Achei que você não queria dar um tempo. Achei que queria tudo ou nada. Qual é o próximo passo? Começar a ignorá-la até que... – Jason aumentou a voz.
<p>- Jason, calma. Eu não vou abandoná-la. Eu não sou seu pai se é o que está dizendo. Desculpa. – Ele finalizou com um olhar de condolências. 
<p>- Eu odeio o olhar que você faz. Não quero sua pena.
<p>- Não é pena. Se você quiser, a gente vai agora bater naquele desgraçado. 
<p>- Cala a boca. – Jason sorriu.</p>
<center><h4>--*--</h4></center>
<p>- Chris, espera!
<p>Emily correu para acompanhá-lo quando o viu indo embora no fim da aula. 
<p>- Emily? Oi. – Chris achou estranho ver Emily atrás dele. – Aconteceu alguma coisa?
<p>- Quinn me contou o que aconteceu. Você terminou com a Ashley. 
<p>- É. – Ele não demostrou muita emoção.
<p>- Como você está?
<p>- Melhor do que eu achei que estaria. Foi bom conversar com a sua irmã.
<p>- Imagino. Você queria falar comigo?
<p>- É. – Ele respirou fundo. – Queria falar sobre o Will e que você precisa...
<p>- A gente voltou ontem. Ou quase isso. – Depois das fugidas e ignoradas de Will, Emily não sabia mais se eles realmente haviam voltado.
<p>- Ah, isso é... bom. Na verdade, era sobre isso que eu queria falar então...
<p>- Por quê? Por que apareceu na minha casa no meio da chuva só para me pedir para voltar com o seu irmão? – Emily estava com essa dúvida desde aquela manhã.
<p>- É, eu sei. Por que eu faria isso? Sou o irmão idiota do Will que você odeia.
<p>- Eu não odeio você, só não gosto muito. – Ela riu. 
<p>- Eu mereço isso. A verdade é que... eu estava muito mal e o Will sempre diz que você é ótima para falar e escutar então eu pensei... por que não pedir ajuda?
<p>- Ainda precisa de ajuda? Você está bem mesmo?
<p>- Eu terminei com o amor da minha vida. Eu definitivamente não estou bem. E sabe qual é a pior parte? Eu realmente achei que ela viria atrás de mim, mas... não veio. Na verdade, ela nem olhou na minha cara. 
<p>- Ela não pode ser o amor da sua vida. – Emily não sabia bem se podia ser completamente sincera, mas continuou mesmo assim. – Ela não ama você, pelo menos não do jeito que você a ama. 
<p>- Você deve me achar um idiota por perdoar ela depois de todas aquelas coisas que eu sei que você sabe.
<p>- Você não é idiota. Só ama a pessoa errada, isso acontece. 
<p>- Sabe, eu passei o dia todo não prestando atenção na aula e tentando fazer uma lista no meu caderno. Uma lista dos motivos que alguma garota teria para querer namorar comigo. Essa lista tem um total de zero itens. 
<p>- Para. Você não é ruim.
<p>- Você sabe que eu sou. 
<p>- Não, não é. E eu acredito que existe alguém nesse mundo que vai nos aceitar exatamente do jeito que somos.
<p>- Isso é papo furado.
<p>- Não é não. Olha só o seu irmão, ele é doido e mesmo assim, eu o amo. – Os dois começaram a rir. – E não ia querer ele de um jeito diferente. 
<p>- Então você acha que alguém vai aparecer para mim também?
<p>- Sim. E você não pode aceitar menos do que isso.
<p>- Obrigado. – Chris sorriu.</p>
<center><h4>--*--</h4></center>
<p>Emily passou a tarde toda no seu quarto lendo. Ela estava tão concentrada que nem percebeu que já havia escurecido quando colocou suas anotações em seu criado-mudo e pegou uma toalha no guarda-roupa para tomar um banho. 
<p>- Emily.
<p>Ela ouviu a voz de Will a chamando e se assustou. A cabeça dele estava na ponta de sua janela. Ele sorria enquanto parecia fazer bastante força para se manter pendurado naquele local.
<p>- O que está fazendo aqui a essa hora? – Emily foi até ele.
<p>- Não vá dormir. Tenho uma coisa para gente fazer.
<p>- Tem noção de que horas são? Você nem deveria estar aqui agora, Will.
<p>- Falou a garota que apareceu na minha porta à noite e debaixo de chuva. Vem, pula a janela.
<p>- O quê? Mas... Para onde vamos?
<p>- Eu estava no hospital com a Angie e ela me disse que nunca viu o mar.
<p>- Will, ela não pode ir à praia. As bactérias e...
<p>- Eu sei de tudo isso. – Will a cortou. – Não vamos pisar na areia, só vamos passar perto. Roubei o carro do meu pai. 
<p>- Mas...
<p>- E também tem a Ponte Golden Gate.
<p>- Quer ir até São Francisco hoje? – Emily arregalou os olhos.
<p>- Cadê o seu instinto de aventureira? 
<p>- Como conseguiu autorização do hospital? Eu me lembro que no Natal a gente teve que assinar um milhão de papéis e...
<p>- A gente pulou a janela, assim como você vai fazer agora. – Emily se preparou para lhe dar uma bronca. – E antes que você me bata, a mãe dela sabe e autorizou contanto que a gente volte amanhã de manhã.
<p>- Mas...
<p>- Eu vou ir de qualquer jeito, mas não vai ser o mesmo sem você.
<p>Will fez um bico que Emily não conseguiu resistir.
<p>- Me dá cinco minutos.
<p>- Essa é a minha garota. – Ele comemorou.</p>
<center><h4>--*--</h4></center>
<p>Estava uma noite muito bonita. O céu muito estrelado. 
<p>Angie estava com o rosto grudado na janela ansiosa para poder ver a praia. 
<p>- Vocês sabem que é loucura, não é? – Emily falava um pouco preocupada, mas mesmo assim parecia muito feliz. 
<p>- O que é a vida sem loucuras? – Will gritou animado. 
<p>Will viu Angie pelo espelho retrovisor quando chegaram perto da praia. Seus olhos estavam arregalados e sua boca estava bem aberta. Ela estava com as mãos bem firmes no vidro da janela. Nem piscava, não queria perder nada.
<p>- Ela é linda! – Mesmo de noite, ela conseguia ver cada detalhe. O barulho bem longe das ondas, o vento... Ela quase conseguia sentir qual era a sensação de pisar na areia.
<p>- É sim. – Will concordou. – Agora que você já viu a praia, temos uma longa viagem até São Francisco. 
<p>- Vocês são loucos! – Emily mexia a cabeça em negação. 
<p>- Liga o rádio. Quero cantar a música de Natal de novo. – Angie pularia do banco de tanta excitação se não estivesse presa pelo cinto de segurança.
<p>Will ligou o rádio, deixou na primeira estação que encontrou e aumentou o volume. Não houve uma vez que começou a tocar uma música e ele foi obrigado a tirar porque não gostava, aquela tática nunca o decepcionou. Não decepcionaria agora.
<p>- Eu não conheço essa música. – Angie franziu a testa.
<p>- Essa é simplesmente uma das melhores músicas do mundo! – Will gritou.
<p>- Talvez nos anos 90. – Emily riu.
<p>- Música não envelhece. Vamos lá. <i>Da-da-da-da-da-da-da, da-da-da-da-da!</i> Eu sei que você conhece. – Ele olhou para a namorada.
<p>Os três começaram a seguir o ritmo e cantar o começo da música. Angie cantava os “da-da-da” fora de sincronia, mas ninguém estava se importando com esse detalhe.
<p>- <i>Estamos conversando à toa!</i> Vamos lá! <i>Eu não sei o que dizer, eu vou dizer mesmo assim.</i>
<p>- <i>Hoje não é o meu dia para te encontrar.</i> – Emily riu. - <i>Estamos nos afastando... Eu vou atrás de você, meu amor!</i>
<p>Angie olhava de um para outro sorrindo.
<p>- <i>Me aceite...</i>
<p>- <i>Me aceite!</i> – Emily gritou.
<p>- <i>Venha comigo...</i>
<p>- <i>Me aceite!</i>
<p>- <i>Eu vou embora... Em um dia ou dois...</i>
<p>Angie aprendeu a música bem rápido e no segundo refrão ela já estava cantando junto. 
<p>- <i>Oh, as coisas que você diz...</i> – Will amava aquela parte. – <i>É a vida ou só um jeito de espantar minhas preocupações? Você é tudo que eu preciso me lembrar.</i>
<p>- <i>Você está se afastando.</i> – Emily olhou para Will enquanto cantava e ele nem percebeu. - <i>Mas eu irei atrás de você mesmo assim!</i>
<p>- <i>Me aceite...</i>
<p>- <i>Me aceite!</i> – Emily e Angie cantaram juntas.
<p>- <i>Venha comigo...</i>
<p>- <i>Me aceite!</i>
<p>- <i>Eu vou embora...</i> – Os três cantaram juntos enquanto Will abaixava a capota do carro para sentirem o vento no rosto. – <i>Em um dia ou dois...</i></p>
<center><h4>--*--</h4></center>
<p>Angie não aguentou e acabou dormindo antes mesmo de chegarem em São Francisco. Ela dormia com um sorriso no rosto que Will nunca imaginou que veria. Quando estavam no meio do caminho, Emily e ele perceberam que não adiantaria chegar até a ponte e acordá-la no meio da madrugada.
<p>- Vamos para casa? – Emily perguntou assim que viu Will fazendo o retorno.
<p>- Ah, eu tenho uma ideia melhor.
<p>Uma hora depois, estavam estacionados em um Cine Drive-In assistindo um filme que nem sabiam o nome. Will havia pegado uma coberta que estava jogada no banco de trás da picape e se deitou com as meninas, uma de cada lado, na caçamba abaixada para assistirem o filme de um jeito mais confortável. Angie dormia segurando bem forte com uma das suas mãos a camisa dele. Emily também o abraçava, mas fingia estar prestando atenção no filme. 
<p>- Sabe, eu estou gostando disso. – Emily finalmente falou depois de um tempo. – Podíamos vir para cá uma vez a cada mês.
<p>- Depois do acampamento com a van, eu tive que roubar a picape do meu pai. – Will riu. – Ainda bem que ele não está em casa, senão já estaria me ligando.
<p>- Pelo menos, você não esqueceu da gasolina dessa vez. – Ela brincou.
<p>- Acho que sou mais responsável quando tem criança na jogada. 
<p>- Bom saber. – Ela voltou a ver o filme. Mas algo estava a incomodando e se não falasse naquele momento, não conseguiria falar mais. – Sabe, eu fiquei surpresa por você ter aparecido hoje na minha janela.
<p>- Eu sei, eu sou louco. Apareço nas horas mais...
<p>- Não por isso. Eu percebi, mesmo você não dizendo.
<p>- Percebeu o quê?
<p>- Will. – Emily levantou a cabeça para poder ver melhor o namorado. – Você ficou distante o dia todo. Tão distante que eu nem sabia se havíamos voltado ou não. 
<p>- Acho que te devo desculpas.
<p>- Eu não quero isso, só quero saber por quê.
<p>- Bom... – Will respirou fundo. – Na verdade, eu sou um idiota. Eu pensei que... Eu entendo o que você passou com aquelas garotas e... Eu não queria que tivesse que passar de novo. 
<p>- Mas...
<p>- Eu te amo e quero muito ficar com você, mas eu não queria chamar muita atenção para você na escola. Eu achei que... Eu sei lá.
<p>- Isso é nobre, mas eu não te pedi para fazer isso e sei que você não quer fazer.
<p>- Mas...
<p>- Eu não me quero me esconder. Vai parecer que estamos com vergonha. 
<p>- Não importa. Não me importa o que falam.
<p>- Exatamente. Não deveríamos nos importar. Eu sei que vai ter horas que vai ser um saco, eu sei que elas vão voltar a me encher e vai haver dias que eu vou estar no meu limite, eu sei disso, mas... Eu te amo e não quero esconder isso. 
<p>- Nem eu. Eu quero que todos saibam o quão sortudo eu sou.
<p>- É, você precisa. – Emily riu.
<p>Will a beijou. Ele sentiu Angie se mexer do outro lado dele.
<p>- Ah, hoje foi o melhor... dia... da minha...vida. – Angie falou baixinho ainda com os olhos fechado. – Eu... amo... vocês.
<p>- Você é a minha garota favorita, eu também te amo. – Will a abraçou mais forte.
<p>- Nós também te amamos, querida. – Emily segurou na mão dela.
<p>Os três ficaram lá deitados até o último filme acabar às quatro da manhã. O sol nasceu enquanto ainda estavam na estrada voltando para Los Angeles e mesmo com a luz do sol atrapalhando sua visão, Will estava muito feliz. 
<p>Eles chegaram no hospital e Angie correu para abraçar a mãe que abriu um sorriso bem grande quando viu sua filha chegando bem feliz. Ela agradeceu os dois só com o olhar, era o bastante. 
<p>Enquanto estavam no carro a caminho da casa de Emily, Will teve a mesma sensação da noite da chuva, que aquele momento poderia não acabar, mas ele acabou assim que chegaram no portão. Harry estava do lado de fora, de braços cruzados, com uma cara muito brava, esperando por eles. Emily havia se esquecido de pedir para Quinn dar cobertura a ela na noite passada.
<p>- Pai. – Emily saiu do carro um pouco receosa.
<p>- Onde passou a noite? – Harry, embora muito bravo, não gritou. Não queria fazer uma cena no meio da rua. – Entre em casa agora, vamos conversar. E você... – Ele apontou para Will que estava do outro lado do carro um pouco assustado.
<p>- Harry, eu....
<p>- Eu não quero saber. – Harry não o deixou falar.
<p>- Pai, não fizemos nada demais. Só...
<p>- Primeiro, você não pode desaparecer e não dar nenhuma explicação. E segundo, você não pode passar a noite fora de casa... ainda mais com ele.
<p>- Harry, a gente...
<p>- Cala a boca! – Ele quase cuspiu. 
<p>- Pai, está exagerando.
<p>- Já disse que vamos conversar lá dentro. – Ele a olhou com muito ódio. – E você... espero que esteja feliz. 
<p>- Na verdade, eu estou mesmo. – Will sorriu. – Eu estou muito feliz. 
<p>- O quê? – Harry franziu a testa. Emily olhou para o namorado sorrindo, ela sabia exatamente o que ele ia falar.
<p>- Eu amo a sua filha. Muito. E ela me ama então, sim. Eu estou muito feliz. E quero que quando as pessoas me virem sorrindo, saibam que o motivo é ela. A sua linda filha. 
<p>- Vai para casa, garoto. – Harry não desfez da cara feia, mas não parecia mais tão bravo. 
<p>- Sim, senhor. – Will sorriu ainda mais e piscou para Emily que também sorria.</p>
<center><h4>--*--</h4></center>
<p>- Oi, querido, a gente pode conversar?
<p>Quinn se sentou ao lado de Sebastian na primeira aula, Sociologia. 
<p>- Claro. A aula não vai ser tão interessante assim. – Sebastian riu.
<p>- Preciso te contar uma coisa. – Ela estava um pouco retraída. – Eu menti para você, não menti exatamente, eu só escondi a verdade.
<p>- Como assim? – Sebastian franziu a testa. 
<p>- O Chris apareceu em casa depois de terminar com a Ashley. A chuva estava muito forte e ele acabou dormindo lá. Não fica bravo.
<p>- Eu não estou bravo. Eu sei que ele dormiu na sua casa. – Sebastian estava tranquilo. Na verdade, ele achava que o assunto não era de grande importância. 
<p>- Você sabe? – Ela ficou surpresa.
<p>- Sim, ele me contou ontem. Na verdade, ele me disse que você foi bem legal com ele. Obrigado por isso. Ele já estava mal e... precisava de um ombro amigo. 
<p>- Um cara dormiu na minha casa, por que não está tendo um ataque?
<p>- Porque esse cara é meu irmão. – Sebastian riu. – E porque eu confio em você e sei que não aconteceu nada. E porque eu passei a noite toda em um carro com a Melissa e você confiou em mim. 
<p>- Eu tinha alternativa? – Ela levantou uma das sobrancelhas.
<p>- Eu te adoro e confio em você.
<p>- Que lindo. – Ela sorriu.</p>
<center><h4>--*--</h4></center>
<p>Will havia decidido matar a primeira aula naquele dia e sabia que seu amigo estava querendo a mesma coisa. Foi fácil convencer Jason de sair de casa para dar uma volta na praia. Os dois acabaram sentados na areia molhada jogando conversa fora.
<p>- Que bom que vocês voltaram, de verdade agora.
<p>- É, eu estou bem feliz. – Will havia contado o que fez na noite passada e o que falou para Harry de manhã.
<p>- E aquela garota, a Angie, deve te considerar um super-herói.
<p>- Não, super-herói não. Só a melhor pessoa do mundo e ela não está errada. – Os dois começaram a rir. – Ela é incrível também. 
<p>- É, eu sei. 
<p>- Eu soube que o Chris terminou com a Ashley. Se prepare para as cantadas dela agora.
<p>- Há-há-há. Como ele está?
<p>- Eu ainda não me encontrei com ele. Preciso descobrir o que eu vou falar antes de falar, de fato.
<p>- E o Kevin?
<p>- Espero que ele me convide, pelo menos, para o casamento. 
<p>- É uma possibilidade bem remota. – Jason brincou. – Já disse que amo o seu relacionamento com a sua família?
<p>- Eu tenho é sorte.
<p>- Verdade. – Jason começou a olhar para o chão. 
<p>- Ele voltou a aparecer? – Will não era de fazer cerimônia para perguntar algo sério.
<p>- Ele me ligou ontem à tarde. Eu não atendi.
<p>- Como está a sua mãe?
<p>- Trancada no quarto chorando sem parar. Eu amo a minha família.
<p>- É horrível. – Will balançou a cabeça em negação.
<p>- Você sabe que teve um tempo em que eu achei que era um péssimo filho? Quando isso passou, eu comecei a culpar a minha mãe.
<p>- Depois se sentiu uma droga. – Will se lembrava muito bem daquela época. 
<p>- Exatamente. Nada do que ele faça agora vai me fazer esquecer tudo de horrível que eu senti quando ele foi embora. Na verdade, a presença dele só vai trazer à tona tudo de novo. Eu não quero voltar a me odiar ou precisar lidar com ele indo embora de novo.
<p>- A proposta de ir lá bater nele ainda está de pé. – Will tentou uma descontração. 
<p>- Valeu. Olha, eu sei que você não quer estar aqui. Acabou de reatar com a Emily depois de uma briga bem chata... Você quer estar com ela.
<p>- Eu estou onde eu quero estar. Não vai se livrar de mim, meu amigo. Estamos grudados um no outro. 
<p>- É o karma? – Jason sorriu.
<p>- Bom, sempre que eu digo que quero ficar sozinho, na verdade, eu quero dizer para você ficar e você sempre fica. 
<p>- Não somos iguais.
<p>- E não precisamos ser, mas você merece ter o melhor amigo dessa vida, então eu estou tentando.
<p>- Sabe, eu posso não ter tido o meu pai, mas eu tive você, obrigado.
<p>- Não. O sortudo aqui sou eu.
<p>Will colocou seu braço em volta do amigo e os dois encararam o mar. Não precisavam falar mais nada, só precisavam estar um do lado do outro.</p>
<br>
<p>“Jason é o meu melhor amigo desde que eu me lembro e isso é muito tempo. Na verdade, ele é o meu irmão mesmo que não tenhamos os mesmos pais nem o mesmo sangue ou qualquer laço familiar. Escolhemos isso então quem se importa? Nós não.
<p>Ele sempre me aconselha quando eu preciso. Sempre deixa tudo só para me ajudar, não importa a hora nem lugar. Ele sempre está comigo, mesmo às vezes não estando de verdade. Ele me irrita e muito, diga-se de passagem, não concordamos com quase nada, mas isso não diminui o amor que sentimos um pelo outro. Quando eu preciso contar algo, a coisa mais boba e ridícula, é para ele que eu conto. Não é real até eu contar para ele. 
<p>É bom saber que nessa droga de mundo, eu tenho alguém com quem contar. Alguém que vai fazer de tudo para me salvar e me tirar da escuridão quando eu precisar e que sempre vai ter fé em mim, mesmo quando até eu não tiver.
<p>É incrível ter alguém para conversar, para brincar, alguém para assistir futebol no fim de semana. Eu não assisto futebol, muito menos ele, mas sei que ele iria assistir se eu chamasse. 
<p>É maravilhoso saber que não estou sozinho nessa vida e que alguém sempre vai estar lá para me aguentar nos meus piores dias. No meu fundo do poço, vai ser a mão dele que estará estendida para tentar me puxar. 
<p>O melhor de tudo é retribuir, poder fazer o mesmo e saber que eu também sei ser o melhor amigo que o meu melhor amigo precisa e merece. Eu amo e não tenho a mínima ideia do que seria a minha vida sem ele. Na verdade, eu nem consigo pensar nessa possibilidade. 
<p>Sempre dizemos que somos nós contra o mundo até o fim. O mundo que se cuide então, porque não existe irmandade melhor que essa. Na verdade, o mundo não tem a menor chance contra a gente. “.</p>
</body>
</html>";
            }

            if (numero == 29)
            {
                lblTitulo.Text = "Capítulo 29 - Minha Vida Seria Uma Droga Sem Você";
                htmlPage.Html = @"<html>
<body>
<p><i>“Porque nós devemos ficar juntos agora, é
<br>Para sempre unidos aqui de alguma forma, é
<br>Você tem um pedaço de mim
<br>E, sinceramente
<br>Minha vida seria uma droga sem você”
<br><b>My Life Would Suck Without You - Kelly Clarkson</b></i></p>
<br>
<p>- Podem me dizer por que vocês estão aqui?
<p>Emily e Will estavam sentados de frente para o diretor. Emily estava nervosa, nunca havia se metido em problemas a ponto de ser mandada para a diretoria, a famosa briga que ela teve com Giovanna não chegou aos ouvidos do diretor e o episódio com a pichação no seu armário não a fez ir para aquela sala forçada, mas Will estava tranquilo, já tinha ido para aquela sala muitas vezes. Já conhecia a mobília de cor. 
<p>- Ah, bom... Bom... na verdade... – Ela gaguejava. 
<p>- Eu subi numa árvore e escalei até a janela da sala de aula que a Emily estava. Eu geralmente escalo coisas por ela. – Will tentou falar o mais sério possível, mas segurava o riso com muita força e isso demonstrava.
<p>- Foi o que eu soube. Por quê?
<p>- Eu precisava entregar um bilhete para ela. Mensagem de texto não daria o mesmo impacto.
<p>- Era importante?
<p>- Era. Pelo menos, para mim.
<p>- Cadê o bilhete? – O diretor estendeu a mão. 
<p>- Meu professor pegou. – Emily finalmente falou. Ainda estava assustada.
<p>- Bom, eu vou pedir para ele...
<p>- Não tem problema. Eu me lembro exatamente o que eu escrevi. Posso dizer para você. – Will sorriu de bom grado.
<p>- Então diga.
<p>- Bom... – Will se virou para Emily. – “Ems, a gente não se vê faz mais de meia hora e eu estou com saudades. Mal posso esperar para poder te encontrar e poder te beijar, ver seus lindos olhos azuis que me deixam louco, seu sorriso perfeito que me deixa mais apaixonado do que eu já sou e ouvir a sua voz que me deixa com vontade de...”.
<p>- Já chega. – O diretor o interrompeu. – Eu não sou contra o amor, por isso só vou dar uma advertência, mas se acontecer de novo... que não aconteça de novo.
<p>- Não posso prometer nada.
<p>- Will. – Emily olhou feio para o namorado.
<p>- Estou sendo sincero. – Ele riu.
<p>- Deem o fora da minha sala. 
<p>- Sim, senhor. – Emily foi a primeira a se levantar e a sair da sala bem rápido.
<p>- Isso se chama romantismo, diretor. – Will gritou já na porta.
<p>O diretor começou a rir quando os dois já estavam fora da sala dele. Esse era o preço por trabalhar perto de adolescentes com os hormônios a flor da pele. Cada dia uma história diferente e bem inusitada.</p>
<center><h4>--*--</h4></center>
<p>- O que você está fazendo?
<p>Amanda encontrou Jason sentado em uma das mesas na biblioteca. Ele parecia bem concentrado no livro que estava lendo. Ela não imaginava que ele mal sabia o que estava lendo e que a sua cabeça estava bem longe dali. 
<p>- Tentando ler um pouco.
<p>- Bom, eu vou ficar aqui te admirando enquanto lê. Só não interpreta os personagens, é estranho. – Amanda se sentou ao lado dele sorrindo.
<p>- Pode deixar.
<p>Os dois ficaram ali por alguns minutos em silêncio até que Amanda voltou a falar.
<p>- Jason, olha, eu não sei direito o que você quer de mim.
<p>- Como assim?
<p>- Tudo o que está acontecendo com o seu... problema. Eu não sei o que fazer. Não quero ser a namorada grudenta e irritante, mas também não quero que pense que eu não me interesso, porque...
<p>- Eu sei. – Jason sorriu. – Eu sei que se importa. Não se preocupe com isso.
<p>- Eu me preocupo com você, mas eu não sei o que fazer nem dizer em uma situação dessas.
<p>- Me leva para sair então.
<p>- O quê? – Amanda quase riu.
<p>- Vamos para algum lugar, faça o seu melhor para me distrair. – Ele pegou na mão dela.
<p>- Acho que posso tentar fazer isso. Amanhã?
<p>- Combinado.</p>
<center><h4>--*--</h4></center>
<p>Quinn estava procurando um rosto conhecido no refeitório para se sentar junto para almoçar quando viu Sebastian e Melissa sentados juntos tendo uma conversa que parecia muito divertida, estavam rindo muito. Quando ela chegou perto deles, tentou disfarçar, mas aquilo a irritava completamente.
<p>- Oi. O que é tão divertido? – Quinn se sentou ao lado de Sebastian e o beijou, mais para marcar território do que por costume.
<p>- Melissa e eu estamos combinando de ir à feira de gibis mês que vem. Fiquei sabendo que vai ter muitos clássicos e raros lá.
<p>- Gibis? Que interessante. – Quinn não sabia que Sebastian gostava de gibis até aquele momento. Ficou surpresa. 
<p>- É, eu ia direto em uma que tinha em Ohio. – Melissa estava animada. – Quando descobri que tinha uma aqui, fiquei tão...
<p>- Eu quase nunca vou. Will e Jason não gostam muito de gibis e não gosto de ir sozinho.
<p>- Quem gosta de gibis? – Quinn comentou baixinho.
<p>- Para, Quinn. Você vai adorar. – Sebastian cutucou a namorada. 
<p>- O quê? Eu vou também?
<p>- Se você quiser, é claro.
<p>- Você vai gostar bastante. – Melissa sorriu para ela.
<p>- Então eu vou. – Quinn fingiu entusiasmo. A última coisa que ela queria era ir em uma feira ver coisas que ela não gostava e aturar seu namorado ao lado daquela garota de outra cidade.</p>
<center><h4>--*--</h4></center>
<p>- Eu vou te dizer uma coisa bem óbvia. Na verdade, a mais óbvia. Se não quer ir a essa feira, você só precisa dizer isso a ele.
<p>Quinn havia acabado de contar seus planos futuros com o namorado para a irmã enquanto iam juntas para a casa depois da escola. 
<p>- E deixar ele passar o dia todo com a Melissa-rouba-namorados? Nunca. – Quinn praticamente cuspia fogo. 
<p>- Você é muito exagerada. Pelo o que eu sei, Melissa nunca fez nada que deu a entender que gosta do Sebastian. – Emily revirava os olhos enquanto pensava o quanto sua irmã estava doida. – Além do mais, ela é amiga do Will e do Jason também.
<p>- E para você tudo bem?
<p>- Contanto que ela não venha tentar me bater no meio da rua, eu estou bem. Ela é até legal, diferente da Amanda que vive me olhando feio ou me dando patadas.
<p>- Achei que fossem melhores amigas. – Quinn riu.
<p>- Vocês que são.
<p>- É. – Quinn concordou.
<p>- Quinny, você vai mesmo a essa feira? Parece ser a coisa mais chata do mundo.
<p>- Eu vou e ainda vou marcar meu território. 
<p>- Você agora virou um cachorro? E quanto aquela conversa sua com o Sebastian sobre confiança? Ele não tentou fazer xixi em você na frente do Chris.
<p>- Eu confio no Sebastian, não confio nela.
<p>- O que acha que ela vai fazer?
<p>- Ela é uma garota e ele é idiota. Pode fazer qualquer coisa.
<p>- Quinn, não viaja. Nem toda garota é vadia ou como você.
<p>- A questão aqui é que eu ralei muito para conseguir conquistar o Sebastian, não vou deixar uma qualquer roubar ele de mim por muito menos.
<p>- Então ele é um prêmio? Que discurso romântico esse seu.
<p>Mas Quinn não respondeu a irmã como deveria.</p>
<center><h4>--*--</h4></center>
<p>Chris não estava prestando atenção na aula. 
<p>Sua cabeça doía e tudo o que ele não queria era ficar em uma sala onde a duas fileiras de distância estava Ashley olhando para a lousa como se nada tivesse acontecido. 
<p>Faltava ainda mais duas aulas, porém preferiu pegas suas coisas e ir embora. Suas notas eram impecáveis, ele poderia se dar a esse luxo pelo menos um dia. 
<p>Will já estava em casa sentado no sofá vendo televisão quando Chris chegou. 
<p>- Já está aqui? – Chris arregalou os olhos quando o viu. Achou que teria a casa sozinha só para ele por algumas horas.
<p>- É. As aulas estavam um saco hoje, vou tentar de novo amanhã.
<p>- Pensei que seu plano era se formar esse ano. – Chris se sentou ao lado dele.
<p>- E é. Posso me dar o luxo de faltar a aula um dia.
<p>- Não, não pode. Eu posso. 
<p>- Olá, Chris, você está bem? – Will tentou mudar de assunto. – Devíamos começar a conversa assim. 
<p>- Estou. E quanto a você? A gente não conversa desde...
<p>- É, eu sei. O soco no Kevin. Como ele está? 
<p>- Saindo bem cedo e chegando bem tarde. Deixa só nossos pais voltarem que ele vai ver. 
<p>- Por que matou aula? Você abomina essas coisas.
<p>- Dor de cabeça. Acho que a chuva que eu tomei vai me deixar com gripe.
<p>- Dois dias depois? Esse vírus é meio lerdo. – Will franziu a testa. – Para de mentir. Eu sei que o que aconteceu. Pretendia, sei lá, me contar?
<p>- Quem te disse? A Ashley?
<p>- Claro, enquanto fazíamos as unhas no cabeleireiro. Somos melhores amigos. – Will usou da sua ironia. Ele mal conversava com Ashley com o irmão por perto, imagina sem ele. – Todo mundo sabe menos eu. Você falou até com a minha namorada e não comigo.
<p>- Eu te magoei? Me desculpa não pensar em você enquanto estava tentando resolver meu problema.
<p>- Está perdoado. 
<p>- Sua vida está ótima, não é? – Chris o encarou.
<p>- Está sim. 
<p>- Por que você sempre tem tudo e eu não? – Chris ficou sério. – Eu terminei com a Ashley por sua causa.
<p>- Ah, qual é, Chris? Você não fez isso por mim.
<p>- Fiz sim. Eu estava com raiva da sua briga com o Kevin e a Giovanna e eu achei que... – Ele não conseguiu terminar a frase.
<p>- Se fez isso por mim, pode desfazer. Não quero que termine com a Ashley, quer dizer, eu até quero, mas... isso não vem ao caso agora.
<p>- Para de fazer piada.
<p>- Não é piada.
<p>- Ela me deixou, Will. 
<p>- Mas foi você que...
<p>- Mas ela não se importou. A gente namorou por dois anos, eu acho que ela poderia, ao menos, sentir muito. Mas ela não sente.
<p>- Você não sabe.
<p>- Eu sei, sim e sei também por que ela não sente. Porque eu sou uma porcaria. Não consegui nem fazer uma garota me amar. 
<p>- Não diz isso. 
<p>- Por que não se é a verdade? Foi por isso que eu não te contei. Você nunca entenderia, sua vida é perfeita, até quem você não quer não sai do seu pé. 
<p>- Sim, até porque você ia adorar ter uma Giovanna no seu pé. Para de falar besteira. Além do mais, sua vida não se resume a uma garota. É patético pensar assim.
<p>- Patético? – Chris estava ficando irritado. – Você ficou acabado quando a Emily terminou com você. Até bateu no Kevin.
<p>- Eu não bati nele por causa disso e você sabe. Você ouviu o que ele disse e antes disso, você sabe muito bem o que aconteceu no Natal. Não se faça de sonso. E você não terminou com a Ashley por minha causa, você terminou porque cansou de não ser correspondido. 
<p>- Para.
<p>- É, eu fiquei mal e você tem todo o direito de ficar também, mas não fala que você é uma porcaria, porque não é verdade. Sabe quantas vezes eu me senti um imbecil perto de você? Milhares de vezes.
<p>- Do que você está falando?
<p>- Chris, você é o filho perfeito. Quando eu chegava com o meu mísero C-, você chegava com um A+.
<p>- Mas...
<p>- Você sempre foi o mais inteligente, sempre soube o que queria fazer com a vida e isso sempre deixou nossos pais orgulhosos enquanto eu me sentia um lixo por querer ser alguém que não teria um futuro muito promissor. 
<p>- Will...
<p>- A verdade é que eu sempre tive inveja de você. Eu sou o mais velho, aquele que todos deveriam se espelhar, mas na real, eu sou aquele que ninguém quer ser. E não faz essa cara de espanto, porque você sempre fez questão de jogar isso na minha cara, o quanto eu era idiota, o quanto eu não prestava. Você fez isso a minha vida toda. 
<p>- Não é bem assim. 
<p>- É exatamente assim, Chris. A gente se dá bem exatamente por cinco minutos e depois a gente se ataca, só nunca saímos no soco. E aí tem o Kevin que me trocou pela namorada. Eu não dou a mínima para os estudos ou faculdade, mas eu sou pressionado dia após dia porque aparentemente tudo se resume em ser advogado, engenheiro ou, sei lá, médico. É, a minha vida é perfeita. – Will não estava bravo, mas precisava falar aquilo. Estava entalado já fazia um tempo.
<p>- Eu nunca...  Eu te amo, tá bom? Só que é muito difícil viver perto de você. Eu sou ótimo na escola, minhas notas são mesmo impecáveis, mas o que eu sou além disso? Eu não tenho amigos como você, ninguém gosta de mim.
<p>- Não é verdade.
<p>- É, sim. É de você que todo mundo gosta. Eu só sou seu irmão nerd. Sempre foi você que as garotas escolhiam, você nunca foi o último a ser escolhido para o time de futebol. Eu não sei o que é ter um amigo que faria tudo por mim assim como você tem o Jason, eu não tenho alguém que me ame como a Emily te ama. Minhas notas impecáveis são tudo o que eu tenho. – Os olhos de Chris começaram a ficar vermelhos e cheios de lágrimas. 
<p>- Você é incrível. A Ashley não... não era para você. E eu sei que você vai amar alguém e vai ser correspondido um dia.
<p>- Um dia? Quando? Porque eu acho que...
<p>- Chris, qual é? Você tem dezessete anos. Sua vida acabou de começar. Não é como se fosse um solteirão de quarenta anos.
<p>- Mas é como eu me sinto. Fiquei muito tempo com a Ashley porque eu achei que nunca ninguém ia ao menos gostar de mim, quanto mais me amar.
<p>- Eu me sentia assim com a Giovanna. Exatamente assim. E olha o que aconteceu. Você não sabe. 
<p>- Mas...
<p>- Você merece alguém que te ame. Na verdade, todos nós merecemos, a gente só...
<p>- Esquece às vezes. 
<p>- É. E eu também te amo e faria tudo por você. Você foi o primeiro bebê que eu vi na vida. Eu ficava olhando você no berço pensando em quando iriamos começar a conversar sobre coisas de irmãos.
<p>- Você era muito pequeno, não pode se lembrar disso.
<p>- Eu não me lembro, mas me parece ser uma coisa que eu faria. – Will sorriu.
<p>- Idiota. – Chris sorriu também.
<p>- Panaca.
<p>Os dois se abraçaram. Fazia muito tempo que os dois não se abraçavam.</p>
<center><h4>--*--</h4></center>
<p>Quando a noite chegou, Will não conseguia ficar na cama. O problema não era a falta de sono e sim a falta de outra coisa. Quando ele percebeu, já estava na rua indo em direção a casa de Emily. 
<p>- O que está fazendo aqui? – Emily sorriu quando viu o rosto de Will em sua janela.
<p>- Eu te acordei?
<p>- Não. – Ela já estava de pijama e com o cabelo solto pronta para se deitar.
<p>- Sabe, eu estava em casa sozinho e de repente me deu uma vontade de ficar deitado com você. 
<p>- Ah é? – Ela abriu a janela para Will conseguir entrar. – Na verdade, eu também estava com vontade de ficar deitada com você.
<p>- Então hoje é o seu dia de sorte. 
<p>- Will, não. – Emily já balançou a cabeça. – Se meu pai te pegar aqui, ele mata você.
<p>- Relaxa. Além do mais, eu acho que não consigo mais dormir sem você do meu lado, então vamos ter que nos arriscar. A alternativa é nunca mais dormir. 
<p>- Você é louco. 
<p>Os dois se deitaram na cama. Will tirou os sapatos com os próprios pés e os dois levaram um susto com o barulho dos sapatos caindo no chão.
<p>- Meu pai vai matar a gente. – Emily repetiu. 
<p>- O que é o amor sem riscos? – Will riu. – Sabe, eu conversei com o Chris hoje. Não brigamos.
<p>- É sério? – Emily ficou impressionada.
<p>- Muito sério. Foi até uma conversa decente. Fazia muito tempo que isso não acontecia. Vai ver eu não sou um irmão tão ruim assim. 
<p>- Estou feliz por você. Agora só falta um. 
<p>- É. – Will sabia que em relação ao Kevin, a aproximação ia ser bem mais difícil, quase impossível. – E o que você fez hoje?
<p>- Nada demais. Quinn me contou as loucuras dela, depois fiquei aqui estudando...
<p>- O de sempre. Sabe, eu estava pensando em roubar de novo a Angie amanhã do hospital para a gente dar uma volta. O que você acha?
<p>- Vou ter que deixar vocês na mão. Vou em uma palestra amanhã em Palm Springs. 
<p>- O quê? Palestra sobre o quê? Por que não me disse? Eu posso te levar.
<p>- Não, a Quinn vai me levar. Sei que você não gosta dessas coisas. 
<p>- Bom, não vai ser o mesmo sem você, mas eu vou fazer o possível para ela não sentir sua falta.
<p>- Ridículo. – Emily o abraçou mais forte. – Você falou sério quando disse que dormiria aqui?
<p>- Falei. Eu quero te ver de manhã cheia de remela e mal hálito.
<p>- Cala a boca. – Ela riu.</p>
<center><h4>--*--</h4></center>
<p>- Sebastian me contou que o seu pai voltou. – Melissa sabia que Jason não ia tocar naquele assunto com ela logo de manhã, mas percebeu que ele estava precisando falar mesmo assim.
<p>- É. – Ele respirou fundo. Os dois haviam chegado bem cedo na escola e agora estavam dando voltas e mais voltas pelos corredores esperando a hora da aula chegar. 
<p>- Eu sei que não está bem, mas como a sua mãe está lidando com isso?
<p>- Trabalhando vinte e quatro horas por dia. Acho até que ela está me evitando.
<p>- Por quê? 
<p>- Para não precisar conversar comigo, mostrar que está abalada. 
<p>- Olha, eu sei que todo mundo está dizendo isso, mas...
<p>- Eu sei, você sente muito. – Jason a completou. Estava mesmo todo mundo dizendo aquilo para ele, mas por algum motivo ele não se irritou com Melissa por ter que ouvir aquilo de novo. 
<p>- Isso e... você vai ficar bem.
<p>- Contanto que ele vá embora logo.
<p>- É isso mesmo que você quer? Tipo, não vai ficar mal se ele for embora de novo e você nem chegar a falar com ele direito?
<p>- E se eu voltar a falar, me apegar e... ele for embora de novo? Acho que pode ser pior. 
<p>- E se ele não for embora? E se ele realmente quer ficar com você?
<p>- Ainda não consigo acreditar nisso, mas quem sabe, sei lá, com o tempo...
<p>- Sabe, você é muito forte. Se fosse comigo, eu estaria morrendo de chorar nesse momento.
<p>Os d<p>ois começaram a rir. 
<p>- Eu já chorei demais. Nem sei se ainda consigo.</p>
<center><h4>--*--</h4></center>
<p>Will se surpreendeu quando viu Ashley parada em frente ao seu armário quando chegou ali. Os dois nunca foram muito de conversar, nem mesmo na época que ele namorava Giovanna. 
<p>- Ashley, oi. – Ele franziu a testa. – Aconteceu alguma coisa?
<p>- Bom dia para você também. – Ela sorriu um pouco nervosa.
<p>- Então veio aqui para me desejar bom dia? – Ele foi até seu armário para pegar seus livros.
<p>- Como está o Chris?
<p>- Por que não pergunta para ele? 
<p>- Ele terminou comigo.
<p>- Eu soube.
<p>- Se ele acha...
<p>- O que quer de mim, Ashley? – Will a encarou. – Você sabe por que terminaram. Se eu tivesse certeza que você o ama, eu me meteria, conversaria com ele sobre isso. 
<p>- Eu o amo.
<p>- Não. Você nunca o amou. Talvez tenha gostado, sei lá, mas nunca passou disso. Agora está triste porque se acostumou com ele e sente falta, mas não é amor.
<p>- Você não sabe nada sobre mim. 
<p>- Sei tudo o que eu preciso saber. 
<p>- Mas...
<p>- Por favor, não seja como a Giovanna. Você não merece isso. Segue em frente, se apaixone finalmente. 
<p>- Talvez eu faça isso. – Ela fez pouco caso. – Ele está bem?
<p>- Ele te ama. Como acha que ele está?</p>
<center><h4>--*--</h4></center>
<p>- Melissa, oi.
<p>Emily correu pelo corredor para alcançar a garota que estava indo para a sua classe.
<p>- Oi. – Ela abriu um sorriso.
<p>- Olha, esses últimos dias foram uma loucura e eu nem tive tempo de te agradecer.
<p>- Me agradecer?
<p>- Você foi a única pessoa que realmente me fez pensar nas coisas que eu estava fazendo. Então... 
<p>- Soube que voltaram. 
<p>- É. Voltamos. – Emily também sorriu. – E eu estou muito feliz. 
<p>- Que bom. Fico feliz por você também. 
<p>Emily estava prestes a se despedir para poder ir para a sua aula quando foi interrompida por Quinn que parecia muito cansada. Ela respirava com um pouco de dificuldade e estava suando. Havia procurado por Melissa pela escola toda.
<p>- Quinn, você está bem?
<p>Melissa achou que a garota estava prestes a ter um treco. 
<p>- Eu preciso falar com você.
<p>- É sobre a feira? Seb ficou mesmo de me falar sobre os detalhes e tal.
<p>- É sobre a feira sim, mas não é nenhum recado do Seb. – Quinn estava bem séria e Emily sentiu um calafrio só de pensar no rumo que aquela conversa poderia tomar. 
<p>- Então o que é? – Melissa sabia que ela e Quinn não eram amigas e que não tinham muitos assuntos para conversar.
<p>- Não quero que você vá.
<p>- O quê? – Melissa e Emily falaram juntas.
<p>- Sebastian é meu namorado e é comigo que ele tem que sair. Acho que passar a noite com ele em um carro já bateu a sua cota.
<p>- Quinn, eu não estou entendendo, você...
<p>- Eu quero que se afaste dele. – Emily arregalou os olhos. – Não precisa fingir que não o conhece, só quero que não grude nele o tempo todo. Eu tenho prioridade.
<p>- Me desculpa, eu nunca quis atrapalhar.
<p>- Não é o que parece porque está atrapalhando.
<p>- Quinn! – Emily quase gritou.
<p>- Tudo bem, não vai acontecer de novo. – Melissa falou também bem séria.  
<p>- Ótimo. Olha, não é nada pessoal, é que...
<p>- É claro que não. – Melissa concordou. – Agora mesmo eu vou procurá-lo para dizer que eu tenho compromisso e não vou poder ir à feira.
<p>- Obrigada. – Quinn tentou ser educada.
<p>- Não precisa.
<p>Melissa se despediu de Emily só com o olhar e foi embora. 
<p>- Você perdeu o juízo? – Emily pegou bem forte no braço da irmã ao ponto de deixar uma marca vermelha. 
<p>- O quê? – Quinn se fez de desentendida.
<p>- Qual é a sua? Não pode fazer isso. Desde quando você virou a louca que diz quem o Sebastian pode conversar ou não? Isso é ridículo.
<p>- Emily, eu já estou cheia. Eles passam vinte horas por dia conversando e nas quatro horas que ele está comigo, ele só fala dela. O que quer que eu faça?
<p>- Que converse com ele, não que haja feito louca. 
<p>- Eu sei o que eu estou fazendo, tá bom? – Quinn se soltou da irmã. – E só para você saber, nem todo namorado é como o Will.
<p>- O que isso quer dizer?
<p>- Sebastian não é o Will. Eu não preciso imaginar defeitos nele para arranjar briga.
<p>- Eu não...
<p>- Tchau.</p>
<center><h4>--*--</h4></center>
<p>- Nossa, você sabe mesmo escolher lugares para a gente ir. Vou deixar você bolar todos os nossos encontros a partir de agora. 
<p>Amanda e Jason estavam no <i>CyberGame</i>. Uma cafeteria muito conhecida em Los Angeles para todos os públicos. Além de ser uma lanchonete para quem quisesse tomar um café diferente ou reunir os amigos, ainda havia uma pequena biblioteca, um cinema reservado com filmes antigos nos fundos e uma sala de jogos que era onde o casal estava naquele momento. 
<p>- Eu me lembrei que quando éramos pequenos, você e o Will jogavam vídeo game o tempo todo dizendo que era relaxante, então eu tive essa ideia. – Amanda estava escolhendo o controle que ia pegar para jogar.
<p>- Vídeo game é o meu segundo amor. – Jason a beijou e depois se sentou na cadeira para jogar. – E você é o primeiro. 
<p>- Bom mesmo. Porque eu não quero ser trocada por nenhuma amiguinha que...
<p>- Ei. – Jason chamou Amanda para realidade. – Primeiro, do que você está falando? E segundo, meu amor é todo para você e só para você. Não tenha dúvidas disso. 
<p>- Não tenho mais. – Ela se sentou na cadeira ao lado dele. – Agora vamos jogar logo essa luta porque eu quero acabar com você. 
<p>- Ah, mas não vai mesmo. – Jason começou a rir. 
<p>- Ai, que maravilha. – Ela começou a bater palmas.
<p>- O que foi?
<p>- Está se divertindo. Era tudo o que eu queria. 
<p>- Você tem esse dom.
<p>- Bom, não querendo estragar o clima, mas já estragando... – Amanda não conseguia se segurar. – Já falou com ele?
<p>- Ainda não. – Jason não fechou a cara como Amanda achou que ele faria. – Eu ainda não estou pronto. Se ele ficar por um tempo, talvez eu fique pronto, mas se ele for embora, vou agradecer por não ter me aproximado.
<p>- Você sofreu muito e está com medo de sofrer de novo e isso é completamente normal. Só não quero que se arrependa. Eu conheço você e sei que isso vai acontecer quando perceber que já é tarde demais. 
<p>- E se ele for embora?
<p>- E se ele não for?
<p>- O que é pouco provável.
<p>- Pelo menos você fez a sua parte. E se ele te deixar de novo, primeiro, o Will bate nele e segundo, você não vai estar sozinho dessa vez. 
<p>- Eu te amo.
<p>- Agora pare de dizer óbvio e vamos jogar.
<p>- Tudo bem. – Jason voltou a se animar.</p>
<center><h4>--*--</h4></center>
<p>- Olha, se não é a nerd que curte essas coisas de nerd. – Will chegou perto de Melissa no refeitório enquanto estavam na fila para o almoço. Ela estava tão pensativa que nem percebeu ele se aproximando.
<p>- O quê?
<p>- Sebastian me disse que você curte essas coisas. Ele finalmente não está mais sozinho. – Ele riu. 
<p>- Ah, sim. – Ela continuava pensativa.
<p>- Está tudo bem?
<p>- Sabe quando você pensa que está fazendo algo certo e de repente percebe que está fazendo errado?
<p>- A história da minha vida. O que fez de errado?
<p>- Cadê a Emily? – Melissa estava um pouco lenta para algumas coisas que só depois de alguns minutos sentiu a falta da namorada do amigo.
<p>- Ela foi embora mais cedo com a Quinn. Vão para uma palestra em Palm Springs. Outra nerd. – Ele riu. – Agora fala, o que fez de errado?
<p>- Na verdade, eu não acho que fiz algo errado. Quer dizer que eu não posso mais ter amigos?
<p>- Sua mãe não gosta das suas amizades, é isso? – Will não estava entendendo muito bem aquela conversa. 
<p>- Não é isso, é que... – Melissa hesitou. – Só porque eu sou sua amiga, não quer dizer que eu quero te roubar dela.
<p>- Dela? De quem? Dá para ser mais clara? Eu não sou muito inteligente para esses surtos de mulheres. 
<p>Melissa pegou no braço de Will e o puxou para fora da fila e para longe de qualquer um para que ninguém mais ouvisse a conversa dos dois.
<p>- Você acha que eu sou uma vadia?
<p>- Você não ficou mais clara com essa pergunta. Do que está falando?
<p>- Emily tem ciúmes de mim?
<p>- Não que eu saiba. 
<p>- Pararia de falar comigo se ela mandasse você fazer isso?
<p>- Emily nunca faria isso, ela não é assim. Além do mais, ela aguenta uma ex namorada maluca, você é fichinha para ela. – Will brincou. – Não vejo por que ela teria ciúmes. Ela falou com você sobre isso?
<p>- Não, só estou usando vocês como exemplo. 
<p>- E eu não entendi nada.
<p>- É a Quinn. – Melissa falou baixinho. – Ela não quer que eu fique muito com o Sebastian. 
<p>- Por que não?
<p>- Ela acha que eu estou tentando roubar ele dela. É uma desculpa ridícula. 
<p>- E o que ele acha disso? – Will sabia que o irmão nunca concordaria com uma atitude dessas.
<p>- Eu não sei. Não contei para ele. 
<p>- Ele precisa saber. Eu até achei que ele já tinha conversado com a Quinn sobre isso. – Will coçou a cabeça.
<p>- Aparentemente ela o ignorou. 
<p>- Eu não vou dizer que a Quinn tem razão, até porque ela está agindo feito uma louca, mas... Você está interessada nele?
<p>- Como assim?
<p>- Ah, qual é, Mel? Foi uma pergunta bem clara. 
<p>- Somos amigos. Ele foi a primeira pessoa com quem eu realmente conversei. Óbvio que eu iria ficar mais próxima dele. 
<p>- Tudo bem.
<p>- A gente se dá bem, muito bem, na verdade. 
<p>- Eu já disse que está tudo bem. O que aconteceu com vocês naquele dia da chuva? – Will estava desconfiado.
<p>- Nada, a gente só conversou.
<p>- É, ele me disse sobre o que conversaram. E eu me surpreendi quando ele me disse que se abriu com você. Ele mal se abre comigo. 
<p>- Onde quer chegar?
<p>- Você gosta dele e talvez ache que ele também gosta de você. 
<p>- Eu não acho nada. Somos amigos, só isso. – Ela começou a ficar exaltada. – Mas eu vou me afastar, porque eu não quero atrapalhar ninguém. 
<p>- Tem certeza? Porque ele precisa saber o que está acontecendo antes de você fazer qualquer coisa.
<p>- Já está decidido.
<p>- Você não gosta mesmo dele? 
<p>- Não, não desse jeito. 
<p>- Bom, se você está falando, eu acredito, não é?
<center><h4>--*--</h4></center>
<p>- Me diz de novo porque você está em uma palestra em outra cidade no meio da semana. O que tem de tão importante aí?
<p>Will e Angie estavam em uma ligação de vídeo com Emily. Os dois estavam estacionados com o carro em frente a praia. Ela era ainda mais bonita a luz do sol, como disse Angie. Will havia passado em um drive-thru e comprou dois lanches vegetarianos e suco de laranja sem açúcar. Ele não gostava daquele tipo de coisa, mas segundo as orientações da mãe, isso era a única refeição diferente que Angie poderia comer e ele não queria que ela ficasse com vontade quando visse seu hamburguer escorrendo gordura e seu refrigerante borbulhando. 
<p>- <i>Eu já te disse. Estava esperando por essa palestra há meses.</i> – Emily não parecia tão empolgada quanto queria parecer.
<p>- Acho que ela está mentindo. – Angie falou com a boca cheia.
<p>- Também acho.
<p>- <i>Vocês são muito chatos, sabiam disso?</i> – Ela olhou para os lados. – <i>Olha, o intervalo já acabou. Eu tenho que ir.</i>
<p>- Que hora volta para casa? – Will perguntou.
<p>- <i>Lá para às sete, se não pegarmos trânsito.</i>
<p>- A gente se vê no seu quarto às nove, então. – Ele piscou e ela retribuiu com um sorriso.
<p>- <i>Tchau. Amo vocês!</i>
<p>- Também. – Will e Angie responderam juntos.
<p>Emily desligou a chamada. 
<p>Os dois ficaram em silêncio por um tempo enquanto comiam. Angie olhava para a praia sem ao menos piscar.
<p>- É a primeira vez na vida que eu me sento nesse banco da frente. – Angie examinava com cuidado o seu assento. – Will, quando eu vou poder dirigir um carro?
<p>- Quando você for adulta.
<p>- Quando você virou adulto?
<p>- Posso te responder isso daqui uns cinco anos? – Will riu, mas Angie continuou séria. – O que foi?
<p>- Eu quero dirigir um carro. Quero poder sair sozinha, ter um trabalho. Essas coisas de adulto.
<p>- Olha, primeiro, eu quero que você saiba que ser adulto é um pouco superestimado. 
<p>- Como assim? – Ela levantou uma das sobrancelhas. 
<p>- Quando você vira adulto, quer voltar a ser criança. Trabalho é um saco, você vai ficar sem tempo e sem dinheiro para sair e pode até aprender a dirigir, mas comprar um carro não é tão fácil. Você vai ver.
<p>- Estou me cansando de ficar no hospital. Eu já até me esqueci de algumas coisas da minha casa. 
<p>- Eu sei que é ruim, mas eles estão de ajudando e logo você vai ficar curada. Te prometo que quando isso acontecer, no mesmo dia, eu te levo para o mar, vou comprar até uma prancha de surf.
<p>- Vai me ensinar a surfar? – Ela arregalou os olhos.
<p>- Na verdade, vamos aprender juntos. – Will riu. – Sabe, não pense muito nisso. Faça como eu, viva um dia de cada vez. 
<p>- Você faz isso?
<p>- Sim, não faço ideia do que vou fazer amanhã nem quando eu for adulto. – Ele sorriu para ela.
<p>- Podemos ligar o rádio?
<p>- Mas é claro.</p>
<center><h4>--*--</h4></center>
<p>Deitados na cama, Emily mudava de assunto toda a hora que Will começava a perguntar sobre a tão misteriosa palestra. Lá para a meia-noite, ele já tinha desistido de tentar falar sobre aquilo e começou a seguir com a conversa normalmente. 
<p>- Bom, eu briguei com a Quinn hoje. Ela está ficando louca. Quer saber o que ela fez?
<p>- Deixa eu tentar adivinhar. – Will fingiu estar se concentrando. – Ela está com ciúmes da Melissa ficando com o Sebastian, você acha que é exagero, mas ela te ignora. 
<p>- Sim e...
<p>- E talvez ela tenha pedido para a Melissa se afastar, mas não conversou com o Sebastian sobre isso. 
<p>- Como fez isso? – Emily ficou impressionada. 
<p>- Telepatia. 
<p>- Mas é claro. – Ela riu.
<p>- Correndo um sério risco de você querer me afastar da Melissa também, eu falei com ela mais cedo e me disse que a Quinn pediu para ela se afastar do Sebastian.
<p>- O que mais ela disse?
<p>- Que vai se afastar.
<p>- Isso não é ridículo? Quer dizer...
<p>- Talvez não. – Will falou um pouco pensativo. Emily se surpreendeu de novo, ela tinha certeza que o namorado ficaria do lado dela. 
<p>- O quê?
<p>- Eu realmente acho que o Sebastian gosta mesmo da Quinn, então é melhor a Melissa se afastar um pouco.
<p>- O que uma coisa tem a ver com a outra? E a confiança?
<p>- Mas isso não se trata de traição. Eu conheço meu irmão, ele morre antes de trair a Quinn. A questão aqui é que se afastar talvez seja melhor para a Melissa.
<p>- Por quê?
<p>- Ela negou, mas não conseguiu esconder completamente. Ela sente alguma coisa pelo Seb. 
<p>- Entendi aonde quer chegar. 
<p>- É, sentimentos são confusos e traiçoeiros. E Angie querendo crescer.
<p>- O quê? – Emily sorriu. 
<p>- Disse que quer ser adulta e fazer coisas de adulto. Ela acha que é um paraíso. Mal sabe que vai ficar um pouco decepcionada. 
<p>- Ah, para. Não é tão ruim. Estamos aqui, não é? – Emily o abraçou.
<p>- É e é muito bom, na verdade, mas nem todo mundo tem a nossa sorte.
<p>- É uma pena.
<p>Os dois adormeceram depois de um tempo. Foi como se tivesse passado alguns segundos quando acordaram assustados com o barulho da campainha do celular de Emily tocando.
<p>- Que horas são? – Emily ainda com olhos fechados tentava alcançar o celular no criado mudo.
<p>Will colocou o braço para fora da cama e pegou seu celular que estava no chão ao lado de seus sapatos. Estava desligado e sem bateria.
<p>- Quem será uma hora dessas? Alô? – Emily atendeu. 
<p>Will ficou observando Emily no telefone. Ela despertou quase que instantaneamente enquanto ouvia a outra pessoa. 
<p>- O que aconteceu? – Will estava começando a se preocupar.
<p>Emily ficou no telefone o tempo todo em silêncio, até que disse “sim”, depois “tudo bem” e desligou. 
<p>- O que aconteceu? – Ele repetiu. 
<p>- Era a... – Ela apontou para o celular com a ligação desligada. – A Angie... Ela acabou de morrer.</p>
</body>
</html>";
            }

            if (numero == 30)
            {
                lblTitulo.Text = "Capítulo 30 - Eu Vou Te Encontrar Lá";
                htmlPage.Html = @"<html>
<body>
<p><i>“Eu vou te encontrar lá
<br>Não importa onde a vida me leve
<br>Eu vou te encontrar lá
<br>E mesmo se eu precisar de você aqui
<br>Eu vou te encontrar lá”
<br><b>Meet You There - Simple Plan</b></i></p>
<br>
<p>“Morte. Uma coisa que todo mundo sabe que vai chegar um dia, mas quase ninguém está pronto para encará-la. É aquela mesma história, nem todo mundo consegue lidar com ela, pelo menos, não imediatamente. É complicado. 
<p>O mais complicado é que você acaba se tornando o centro das atenções.  O morto não é tão importante, mas sim como você vai superar. Você está sofrendo ou está totalmente indiferente. 
<p>Luto. Você nunca sabe quando acaba ou se um dia acaba. Você também não sabe quando é a hora certa de voltar ao normal. Precisa lidar com as condolências e compaixão de outros enquanto está sofrendo, mas é julgado assim que mostra um sorriso. Não está sentindo o suficiente, você deveria estar sofrendo. Alguém que você ama morreu. Não tem o direito de sorrir.”.
<br>
<p>Will segurava o seu celular sem bateria muito forte enquanto tentava colocar seus sapatos, sentado na cama. Ele tremia.
<p>- Will. – Emily colocou a mão no ombro dele ainda deitada. Ela também tremia um pouco e estava pálida.
<p>- Eu sabia, eu sabia. – Ele falava baixinho para si mesmo enquanto balançava a cabeça negativamente. 
<p>- Will. – Emily repetiu.
<p>- Eu sabia. – Ele falou mais alto, mas sua voz falhava. – Eu não deveria ter me apegado tanto. Eu não... Eu sabia que ela ia morrer e que isso ia acabar comigo.
<p>- Eu...
<p>- Ela morreu, Ems. A Angie morreu.
<p>Will nunca havia perdido alguém que amava antes. Ele se sentia horrível e ao mesmo tempo estava estagnado, dormente, como se nada daquilo fosse real, como se ele fosse acordar daqui algumas horas percebendo que aquilo tudo não passava de um sonho ruim, um pesadelo. Ela era só uma criança, como podia morrer daquele jeito? Não estava certo, não era justo.</p>
<center><h4>--*--</h4></center>
<p>Angie havia feito muitos amigos no hospital, incluindo médicos e enfermeiras. Muitos haviam se comovido com a sua história. Sua mãe nunca rejeitou ajuda de ninguém e sempre foi muito prestativa com os outros. Não era à toa que o cemitério estava lotado às nove da manhã naquele sábado. 
<p>Sua mãe se recusou a fazer um velório. Não ia aguentar. Assim que o corpo foi liberado, às dez e meia da noite da sexta, a equipe da funerária o recolheu e levou para o cemitério. A mãe entrou naquela sala gelada e que cheirava à morte para se despedir de sua filha já preparada para ser colocada em um pequeno caixão. Ela nunca havia se sentido tão sozinha na vida dela como naquele momento. Sua única filha, sua única família havia morrido, havia ido embora. 
<p>Will estava se segurando já fazia muito tempo. Havia ficado com aquela mulher o tempo todo desde que recebeu a ligação. Tentou consolá-la ao máximo e embora fosse muito difícil, segurou o choro, pegou na mão dela e a acompanhou em todos os lugares que ela precisava ir. Foi cansativo.
<p>O enterro foi a coisa mais triste que ele já presenciou na vida. Emily o olhava como se ele fosse um bebê que precisava de cuidados ou como se ele fosse ter um treco a qualquer momento. Ele não sabia diferenciar.
<p>Assim que o padre terminou a cerimônia, o caixão foi enterrado e o cemitério começou a se esvaziar. Mais da metade daquelas pessoas, viveriam as suas vidas normalmente em no máximo dois dias, era o mais provável. Para os médicos, aquilo era quase rotina. Will não sabia como seria para ele, mas sabia que para a mãe, aquele dia nunca acabaria.</p>
<center><h4>--*--</h4></center>
<p>- Achei que levaria ela para casa. – Emily se referiu à mãe de Angie quando entrou no carro junto com Will.
<p>- Ela vai ficar um pouco aqui, depois vai voltar com o padre. Disse que eu estou liberado. – Ele soltou um riso. 
<p>- Como você está?
<p>- Não pergunte se não quiser que eu te pergunte também. 
<p>Os dois respiraram fundo.
<p>- Como isso foi acontecer? – Emily segurava suas mãos no colo.
<p>- Eu não faço ideia. 
<p>A morte de Angie foi repentina até mesmo para os médicos. Ela começou a reclamar de dor de cabeça no meio da noite. Sua mãe ficou assustada e chamou as enfermeiras de plantão. Resolveram levá-la para fazer uma tomografia só por precaução. 
<p>No meio do caminho, ela começou a se contorcer, seu nariz começou a sangrar e minutos depois perdeu a consciência. Não havia mais atividade cerebral quando entrou na sala para fazer o exame. 
<p>Will fez menção de ligar o rádio.
<p>- Por favor, não. – Emily encostou de leve na mão dele. 
<p>- Tudo bem.</p>
<center><h4>--*--</h4></center>
<p>Emily entrou em seu quarto.
<p>Para quem não dormia há quarenta e oito horas, ver a sua cama ainda com os cobertores jogados seria um paraíso, ela se deitaria e dormiria o resto do dia, mas não foi isso que ela fez. Sua cabeça doía e seu corpo estava quase cedendo, mas Emily dobrou seus cobertores e colocou dentro do seu guarda-roupa. 
<p>Então se sentou no pé da cama e começou a olhar para o nada. 
<p>- Emily, você está bem? – Quinn entrou no quarto da irmã com um pouco de cautela. – Mamãe fez um chá. Estamos todos lá embaixo caso precise conversar. 
<p>Emily não respondeu. Continuou imóvel olhando para algo sem ao menos piscar. 
<p>- Emily, você precisa de alguma coisa? Cadê o Will? Ele... – Quinn percebeu que ela não estava ouvindo e se aproximou mais. – Você precisa...
<p>- Eu preciso de... – Emily se levantou em um pulo que assustou a irmã e foi até a sua estante. – Eu preciso de um saco de lixo. 
<p>Ela começou a pegar alguns livros e apostilas que estavam amontoadas na estante e os jogou em cima da cama.
<p>- Preciso jogar isso no lixo. 
<p>- Mas... – Quinn se aproximou da cama para poder ler os títulos dos livros e saber do que aquilo tudo se tratava. – Emily, são seus livros e suas pesquisa sobre... – Ela não sabia se podia ser clara e dizer a palavra “câncer”.
<p>- São lixo. – Ela respondeu sem ao menos olhar para a irmã.
<p>- Emily...
<p>- Eu fui uma idiota esse tempo todo. Eu gastei dias e dias lendo e pesquisando coisas e... Eu realmente achei que encontraria uma solução. Eu, uma garota de dezesseis anos do ensino médio, acharia uma solução que médicos formados não acharam. O quão estupido é isso?
<p>- Você só queria ajudar.
<p>- Eu estava me iludindo. Porque no final, essa droga... – Ela pegou um dos livros na mão e jogou na parede assustando novamente Quinn. – Não adiantou de nada. 
<p>- Não é verdade.
<p>- Eu fui a uma palestra sobre câncer do outro lado do estado enquanto ela morria bem aqui. De novo, eu fui uma inútil.
<p>- Não diz isso.
<p>Quinn sabia exatamente o que a irmã estava pensando. As duas já haviam passado por isso quando o avô delas morreu pela mesma doença só que em um órgão diferente. Aquela doença que não deixava absolutamente ninguém de fora. Ela sentia a dor da irmã, o luto, mas estava pisando em ovos ali e sabia que em algum minuto, um livro a atingiria. 
<p>- Eu sei que você está triste e...
<p>- Eu não estou triste, Quinn. Eu estou com raiva, com muita raiva. Com tanta raiva que eu acho que a minha cabeça vai explodir.
<p>- Precisa se acalmar. 
<p>- Isso é tão injusto. – Emily colocou as mãos na cabeça e elas estavam trêmulas. 
<p>- Eu sei. Mas você não pode se culpar nem nada parecido. Você não poderia ter feito nada. Eu sei que depois do vovô...
<p>- Não é como o vovô. – Emily a interrompeu. – Não é nada parecido com a morte do vovô.
<p>- É, eu sei. O vovô sofreu mais e...
<p>- Não era isso que eu ia dizer. – Emily a encarou. Seus olhos estavam vermelhos e as lágrimas estavam presas. – Ele cresceu. Ele trabalhou, se apaixonou, teve uma família, se divertiu, conheceu vários lugares, foi à uma droga de praia, viu seus filhos crescerem e seus netos. Tudo o que a Angie conhecia era um quarto de hospital e a praia através de uma janela. Até mesmo o cabelo, ela não teve o direito de ter. Me diz o porquê, Quinn.
<p>- Não sei.
<p>- Então não pode me ajudar. – Emily respirou fundo. – Ela era só uma criança. Não é justo, não deveria ser assim. Ela merecia mais. Ela merecia mais do que essa droga de mundo deu para ela. 
<p>- Eu sinto muito.
<p>Quinn foi em direção a irmã para abraçá-la quando percebeu que ela estava prestes a desabar.
<p>- Não. Sai daqui. – Emily se afastou. 
<p>- Emily.
<p>- SAI DAQUI! – Ela gritou. – EU NÃO QUERO SUA AJUDA! Eu não quero nada. 
<p>Quinn, aos poucos, saiu do quarto e fechou a porta. Sabia que a irmã não ia fazer nenhuma loucura a não ser chorar sem parar, mas mesmo assim ficou no corredor muito preocupada e com algo ruim preso na garganta. 
<p>O telefone de Emily jogado na cama começou a tocar. 
<p>- Will?
<p>- <i>Eu havia me esquecido completamente que meu celular estava sem bateria.</i> – Ele riu. – <i>Carreguei no carro. Liguei caso...</i> – Mas ele não sabia por que tinha ligado. 
<p>- Está tudo bem? – Sabia que não.
<p>- <i>Ah... Eu não vou poder ir aí essa noite. Na verdade, acho que nem vou conseguir dormir, eu só...</i> – Sua voz estava fraca.
<p>- Onde você está?
<p>- <i>Estou na estrada. Me deu uma vontade enorme de ir até São Francisco ver a ponte Golden Gate.</i> 
<p>- Will... – Emily conseguiu ouvir bem ao fundo o som do rádio tocando.
<p>- <i>Eu ia te chamar, mas...</i>
<p>- Tudo bem. 
<p>Os dois ficaram em silêncio na ligação por alguns segundos só ouvindo a respiração um do outro. 
<p>- <i>A gente podia ir ao cinema amanhã à noite. Faz tempo que não fazemos isso. Ouvi dizer que está passando um filme legal.</i> – Will tentou deixar a conversa normal.
<p>- Tá, pode ser. 
<p>- <i>Me desculpa.</i> – Ele finalmente falou. Percebeu então que foi por isso que ele ligou, afinal de contas.
<p>- Por quê?
<p>- <i>Eu deveria estar aí com você, mas eu não sou a melhor companhia agora. Na verdade...</i> – Emily o ouviu assoar o nariz. Com certeza, estava chorando ou segurando o choro. – <i>Eu sinto muito.</i>
<p>- Eu também.</p>
<center><h4>--*--</h4></center>
<p>A viagem dos pais Jones com o filho mais novo para o Canadá estava programada para ser por um mês que acabou se tornando dois meses e seriam três se não tivessem recebido a ligação de Amanda dizendo que “a garotinha doente amiga do Will” havia morrido e que ele ia explodir a qualquer momento. Foram exatamente essas as palavras que Amanda usou no telefone. 
<p>- Cadê ele? – Karen jogou as malas que segurava no pé da escada da sala e foi em direção aos filhos que estavam sentados no sofá com Jason e Quinn.
<p>- Ele mandou uma mensagem. – Amanda respondeu enquanto abraçava sua mãe. – Disse que estava bem e que não precisávamos nos preocupar. Só queria ficar sozinho agora. 
<p>- Mas... – Ela olhou para os outros e quando viu que Jason e Sebastian estavam lá, ficou mais nervosa. Will odiava ficar sozinho. 
<p> Ele vai ficar bem, mãe. – Sebastian também se levantou para abraçar a mãe.
<p>- Eu o ouvi falando com a Emily por telefone antes de eu sair de casa. – Quinn falou. Seu rosto também transparecia preocupação. 
<p>- E como ela está? – Karen perguntou.
<p>- Arrancando os cabelos, me expulsou do quarto e tudo, mas vai ficar bem. Eu sei.
<p>Matt entrou em casa e subiu as escadas correndo com uma sacola. Eram seus videogames que ele havia comprado e mal esperava a hora para jogá-los. 
<p>Robert entrou na casa uns minutos depois com o restante das malas e as colocou exatamente onde sua esposa havia deixado as outras. Foi até a sala, abraçou todo mundo e foi para a cozinha em silêncio. 
<p>- Ele fica assim até quando ouve a notícia de morte de uma criança na televisão. – Amanda explicou. – Imagine com uma criança que um de nós conhecia.
<p>- Eu vou para a cozinha fazer algo para comer e esperar pelo Will. – Karen ainda estava um pouco desnorteada enquanto ia para a cozinha.
<p>- Finalmente vamos comer algo decente depois de semanas. – Kevin respirou aliviado.
<p>- A última coisa que o Will vai querer quando chegar vai ser comer. – Jason comentou.
<p>- Ele está tão mal assim? – Kevin perguntou.
<p>- Saberia se tivesse ido ao enterro. – Sebastian falou com a cara fechada. 
<p>- Ah, qual é? – Kevin ficou inquieto. – Eu odeio enterro, ainda mais de alguém que eu nem conheço.
<p>- Ninguém gosta de enterro. – Amanda se levantou do sofá. – A diferença é que você não se importa. 
<p>- Eu me importo sim. Eu tinha uma festa para ir com a Giovanna hoje à noite e eu estou aqui. 
<p>- Eu posso estar errada... – Quinn comentou. – Mas acho que está aqui porque seus pais voltaram e não deixariam você ir a essa festa se soubessem da existência dela.</p>
<center><h4>--*--</h4></center>
<p>Will estacionou o mais perto que conseguiu da ponte. Saiu do carro, se sentou no capô e ficou observando aquele lugar todo. Já estava anoitecendo quando ele chegou e naquele momento o céu já estava completamente escuro. As lágrimas caiam descontroladamente dos seus olhos e ele já havia desistindo de tentar fazer parar ou de tentar limpar o rosto. 
<p>Passou um tempo tentando lembrar de alguma piada, de algo interessante que fizesse ele sair de orbita e esquecer o mundo real pelo menos por alguns segundos, mas também desistiu depois de um tempo. Aqueles carros passando pela ponte... era estranho pensar que aquelas pessoas e as outras ao redor do mundo estavam tendo um dia normal como qualquer outro enquanto ele estava totalmente destruído por dentro. 
<p>Seu celular vibrou no bolso de sua calça. Só quando ele colocou a mão do bolso, sentiu a textura do pano da calça e percebeu que não estava de jeans, ainda estava usando aquela calça preta ridícula, aquela camisa social amassada e uma gravata frouxa. Até o traje de enterro era ruim. 
<p>- Oi? – Ele atendeu.
<p>- <i>Sou eu.</i> – Jason respondeu. – <i>Estou no viva-voz com o Seb. Você está bem?</i>
<p>- Eu disse para não se preocuparem.
<p>- <i>Nossos pais chegaram.</i> – Sebastian falou. 
<p>- Amanda deve ter feito um drama no telefone. – Will balançou a cabeça em negação. – Não era necessário. 
<p>- <i>Onde você está?</i> – Jason perguntou. – <i>Queremos ficar com você para...</i>
<p>- Se disser “dar apoio”, eu vou desligar.
<p>- <i>Somos um time, Will. É o que fazemos.</i> – Sebastian retrucou. 
<p>- Eu sei e... eu amo vocês por isso, mas se eu ficar por perto, vai ser pior. – Ele respirou fundo.
<p>- <i>Will...</i> – Sebastian tinha algo preso e precisava falar. – <i>Me desculpa. Eu sei que... Todas as vezes que eu quase morri e... Eu fui atrás disso e fiz besteira e...</i> – Ele começou a falar mais fraco. – <i>Eu sinto muito.</i>
<p>- <i>Vamos parar com isso.</i> – Jason o interrompeu. – <i>Não precisa ficar pior do que já está.</i>
<p>- Eu... – Will começou a falar. – Eu realmente não sei o que eu estou sentindo. É como se tudo... todo o resto fosse exagero. Pensar em qualquer coisa agora seria tão... Tudo isso vai passar, não é? Mas a morte... Eu sabia que ela ia morrer. – Ele assoou o nariz. – Eu sabia o tempo todo, eu deveria estar... 
<p>- <i>Você não está se culpando, está?</i> – Jason perguntou.
<p>- Eu estava. Ela estava muito agitada nesses últimos dias por minha causa e eu achei que... Mas os médicos e a mãe dela me disseram que isso não a prejudicou. Era uma bomba-relógio e poderia ter explodido até com ela dormindo. Sabe, eu queria estar com raiva ou em negação, mas não estou de nenhum desses jeitos. Eu estou me sentindo vazio e... estou chorando sem parar que nem um idiota olhando para uma ponte ridícula. 
<p>- <i>Will, volta para casa.</i> – Sebastian falou. – <i>Precisa deixar a gente cuidar de você.</i>
<p>- <i>Ninguém merece sofrer sozinho.</i> – Jason completou.
<p>- Eu sei. 
<p>Will olhou para o céu. Será que ela estava lá? Ele ainda tinha tanta coisa para dizer...</p>
<center><h4>--*--</h4></center>
<p>- Será que eles vão ficar lá em cima por muito tempo? – Amanda olhava sem piscar para as escadas. 
<p>- Esse é o pior sábado à noite da história. – Quinn bufou. 
<p>- Poderíamos ir a essa tal festa que o Kevin disse. Acho que se forçarmos um pouco, ele dá o endereço. – Chris se levantou do sofá.
<p>- Ir a uma festa agora não é meio que um desrespeito? – Amanda levantou a sobrancelha.
<p>- Não. Quer dizer, não podemos fazer mais nada. Acho que parte do luto é viver ao máximo. Não somos de ir a festas, ir a uma é viver ao máximo para gente. Pelo menos hoje. – Chris explicou. 
<p>- Eu passo. – Amanda fez que não com a cabeça. – Vou ficar por aqui e esperar pelo Will.
<p>- Vamos, Quinn. – Chris insistiu.
<p>- Ah, não sei, não. A Emily está... E tem o Sebastian, preciso falar com ele e...
<p>- Ele e o Jason vão ficar à noite toda com o Will no telefone. 
<p>- Verdade. – Amanda concordou. – Se ele perguntar, eu digo aonde foram.
<p>- Não acha que ele vai ficar com raiva? – Quinn perguntou. 
<p>- Na verdade, ele vai ficar aliviado por ver você se divertindo. – Amanda disse. 
<p>- Tá, tudo bem. – Quinn se levantou.
<p>- Isso. – Chris comemorou. 
<p>- Espera um pouco. Se seus pais não deixam o Kevin ir a essa festa, por que deixariam você?
<p>- Porque eu sou o responsável do grupo. – Chris falou.
<p>- Verdade. – Amanda fez cara feia.</p>
<center><h4>--*--</h4></center>
<p>Will conseguiu cochilar por alguns minutos até ser acordado com a luz do sol na sua cara. Ele precisava voltar para casa em algum momento. Ele olhou para seu celular, eram seis da manhã. A notificação de uma mensagem de voz recebida ainda estava lá no topo da tela. 
<p>Ele mentiu para Jason quando disse que não se sentia culpado. Ele não mentiu totalmente, mas mesmo assim... Ele sabia que a morte de Angie não tinha sido sua culpa, mas quebrou uma promessa. Quando ele deu seu número de telefone, disse que a atenderia a qualquer dia e a qualquer hora, mas não a atendeu na hora que ela mais precisava. 
<p>Angie havia deixado uma mensagem de voz que ele só foi perceber no dia anterior depois do enterro quando finalmente carregou seu celular zerado. O que ela havia falado para ele minutos antes de morrer? Ele tinha medo de ouvir. 
<p>Ele ligou o carro, mas ainda não estava pronto para ir para casa. Não sabia para onde ir nem o que fazer.</p>
<center><h4>--*--</h4></center>
<p>- O que faz aqui? – Emily atendeu Jason em seu portão de manhã bem intrigada. 
<p>- Bom, já que o Will ainda está em algum lugar que ninguém sabe onde é, eu pensei em passar aqui para ver como você está, a não ser que ele esteja...
<p>- Não. Ele não veio para cá. Entra. 
<p>Os dois foram até a varanda e se sentaram na cadeira de balanço que Harry havia instalado recentemente. Aquele balanço era a única coisa que fazia Emily se lembrar de Nashville e ela adorava. 
<p>- Quinn me disse que ontem você... 
<p>- Não foi o meu melhor momento. – Ela deu um sorriso amarelo.
<p>- Está mais calma hoje?
<p>- Jason...
<p>- Pode conversar comigo. 
<p>- Você está passando uma barra com o seu pai, eu não deveria... – Emily estava dando desculpas.
<p>- Nada disso importa agora. 
<p>- Mas...
<p>- Eu também senti raiva quando soube e eu nem era próximo dela, então nem consigo imaginar o que você sentiu. 
<p>- Eu era pequena quando meu avô morreu e muitas das coisas que aconteceu com ele eu só fui entender depois que cresci. Quando conheci a Angie, eu achei que... achei que podia fazer alguma coisa. Mas a verdade é que ela já tinha sido sentenciada e eu só estava tentando encontrar um furo no processo. 
<p>- Eu entendo.
<p>- Bom, vamos olhar pelo lado positivo, não é? Agora eu sei mais sobre cérebros e tumores cerebrais do que as pessoas comuns. 
<p>- Eu realmente queria dizer que isso tudo que você está sentindo vai passar, mas eu não sei se vai. – Jason pegou na mão dela.
<p>- Eu nem sei se eu quero que passe. 
<p>- Emily, não diz isso.
<p>- Assim que eu aceitar, eu vou voltar a viver a minha vida e eventualmente, eu vou me esquecer. – Ela respirou fundo. – Um dia, eu vou acordar e vou demorar para me lembrar da cor dos olhos dela, da voz dela. Meu avô tinha um cheiro... eu me deitava com ele e... quando ele morreu, eu até comprei o perfume que ele usava, mas não adiantou, não ficou o mesmo cheiro e agora eu nem me lembro mais qual era. Eu me esqueci de alguns traços e detalhes... 
<p>- O que ela significou para você sempre vai ficar aí e é isso que importa. 
<p>- Eu não sei. 
<p>- E você não é burra nem ingênua por achar... por querer que ela não morresse. Quando amamos alguém, nunca queremos que acabe de maneira nenhuma.</p>
<center><h4>--*--</h4></center>
<p>Emily passou o dia todo sentada naquela cadeira de balanço pensando no que conversou com Jason e já estava quase entrando em casa quando ouviu o barulho da campainha no portão. 
<p>- Acho que não ia conseguir pular seu muro hoje. – Will havia estacionado na frente da casa e estava parado no portão segurando um saco cheio de pães doce que ele comprou no meio do caminho.
<p>- Bom, acho que meu pai não vai se importar.
<p>Os dois foram para a varanda. Assim que Will se sentou na cadeira de balanço, Emily se sentou do seu lado e se encostou em seu peito enquanto ele colocava seu braço em volta dela.
<p>- Esse pão está muito gostoso. – Emily falou de boca cheia.
<p>- É, sim. Foi a minha refeição de hoje. 
<p>- Onde esteve?
<p>- Por aí. Eu deveria ter chegado mais cedo, mas eu me perdi. – Will mostrou um leve sorriso. – Como você está? Ouvi dizer que andou gritando com as pessoas. Estou aqui, pode gritar comigo agora.
<p>- Não me tente. – Emily riu. – É, eu estou com raiva, mas vai passar. E quanto a você? Seus olhos estão...
<p>- É, eu dirigi até parar de chorar. Eu acho que... não vou chorar por um bom tempo. 
<p>- O que a gente vai fazer, Will? Eu estou com uma coisa presa na garganta, um...
<p>- Vazio. Eu sei como é. – Will ficou em silêncio por alguns segundos antes de continuar. – Hoje de manhã, quando eu acordei no carro, eu meio que... eu esqueci. E aí quando eu percebi onde eu estava, eu me lembrei. Foi como... sentir aquele balde de água gelada no meu corpo de novo. E tudo o que eu queria era que você estivesse comigo.
<p>- Eu te amo.
<p>- Eu te amo mais.</p>
<center><h4>--*--</h4></center>
<p>Karen deu um abraço muito apertado em Will quando o viu entrando em casa na segunda de manhã. Ela resolveu poupá-lo da bronca de sumir e não dar noticias para ninguém por dois dias. Will percebeu que sentia falta daquele abraço e de tê-la por perto e voltou a chorar de novo. Aconteceu bem mais cedo do que ele imaginava. 
<p>Amanda estava esperando por ele em seu quarto quando chegou. Ela estava deitada em um dos lados da cama, parecia ter dormido ali a noite toda. 
<p>- Eu expulsei aqueles idiotas daqui. – Ela falou baixinho para ele. 
<p>Will tirou seus sapatos, o terno e a gravata e se deitou ao lado da irmã. Ele a envolveu em seus braços e sorriu. Ela retribuiu o sorriso e o abraçou. Amanda não diria nada, sabia que ele não queria ouvir, só ficou ali ao lado dele esperando que ele se curasse de algo incurável.</p>
<center><h4>--*--</h4></center>
<p>- Você acredita no Céu?
<p>Sebastian e Jason estavam caminhando até a escola naquela manhã. Sebastian estava bem pensativo desde a morte de Angie e ficou ainda mais depois da conversa com Will pelo telefone dois dias atrás. 
<p>- Claro, estou olhando para ele agora. – Jason ficou confuso.
<p>- Não, eu estou falando de Céu e Deus, o paraíso e essas coisas.
<p>- Acredito. 
<p>- Acha também que se fizermos alguma coisa errada, vamos para o inferno? Acha que eu vou para o inferno por ser um viciado?
<p>- Primeiro, você está em recuperação, já deve valer muita coisa. E segundo, acho que não é assim que funciona. Acho que depois da morte, teremos nossa recompensa.
<p>- Então por que ninguém quer morrer?
<p>- Por que está me perguntando essas coisas? – Jason começou a rir. – Vai procurar um padre para te responder isso.
<p>- Queria saber se, no final, vamos nos encontrar de novo, todos juntos, andando nas nuvens.
<p>- Vamos nos encontrar de um jeito ou de outro. Não acredita nisso?
<p>- Às vezes não. – Sebastian respirou fundo. – Todas às vezes que eu quase morri, eu fiquei com tanto medo, mesmo que eu... Às vezes acho que não tem nada depois da morte, que vai ser como um sono eterno. 
<p>- Não gosto de pensar assim. Não me dá esperança e a vida é um saco demais para ficarmos sem esperança. 
<p>- Pode ser. 
<p>- Seb, você é uma pessoa boa. – Jason sabia exatamente o que o amigo estava pensando. – Você não vai ser castigado. 
<p>- Assim eu espero.</p>
<center><h4>--*--</h4></center>
<p>- Oi, como você está? – Melissa encontrou Emily pegando seus livros no armário para a primeira aula. 
<p>- A vida não pode parar, não é? – Emily mostrou um sorriso um pouco sem graça. 
<p>- Queria ter ido falar com você antes, mas achei que precisava de um tempo.
<p>- É, eu precisava mesmo, mas agora... – Ela não estava bem, não podia responder isso. – Estou melhor. Melhor que ontem, pelo menos. 
<p>- Quer conversar?
<p>- Na verdade, eu queria ouviu as suas coisas.
<p>- Como assim?
<p>Emily fechou seu armário, pegou no braço de Melissa e começaram a andar pelo corredor.
<p>- Já falou com o Sebastian?
<p>- Não, aconteceu todo esse lance com a Angie, aí teve o funeral, eu não achei que... 
<p>- Olha, eu estou um pouco instável, então posso gritar com você uma ou duas vezes, mas... Me conta, o que vai fazer?
<p>- Ele me mandou mensagens o final de semana todo, eu respondi dizendo que estava ocupada, que não podia conversar, dei desculpas. 
<p>- Melissa.
<p>- Eu preciso me afastar, mas não sei como.
<p>- Gosta dele?
<p>Melissa desviou seu olhar e ficou em silêncio.
<p>- Eu sei, eu sou irmã da Quinn, mas não vou contar nada, eu juro. 
<p>- Eu... – Ela hesitou. – Eu acho que gosto, mas eu não vou fazer nada a respeito. Eu não sou o tipo de pessoa que...
<p>- Eu sei. 
<p>- Eu não sou a primeira pessoa a gostar de alguém sem ser reciproco. Não é grande coisa. 
<p>- Olha, normalmente eu concordaria com você, mas agora... – Emily não achava aquilo uma boa ideia. – Não acho que se afastar seja a coisa certa.
<p>- Mas Emily...
<p>- Precisa ao menos dizer. Ele precisa saber o que está acontecendo. Você precisa dizer que gosta dele. 
<p>- Não concordo.
<p>- A vida é curta e ao mesmo tempo muito longa, mas a gente não pode deixar de dizer o que sente, é o mais importante. Eu sei que é difícil, mas... 
<p>- Você está de luto. Todos os seus conselhos vão ser sobre viver ao máximo o mais rápido que puder. 
<p>- E se ele também gostar de você? Se e quando você disser, ele perceber que... Garotos são burros. 
<p>- Você está me dizendo que eu devo ir até o namorado da sua irmã e dizer que gosto dele. Tem ideia do quão ridículo isso é?
<p>- Você gosta de alguém e não quer dizer a ele. Isso também é ridículo.</p>
<center><h4>--*--</h4></center>
<p>- Você sabe que é o meu melhor amigo, não sabe?
<p>Will encontrou Jason almoçando sozinho no refeitório.
<p>- Gosto quando nossas conversas começam assim. – Jason riu.
<p>- Cadê todo mundo? – Will se sentou ao lado dele.
<p>- Estão por aí. – Jason comia despreocupado. – Está tudo bem?
<p>- É, está. 
<p>- Então porque disse que sou seu melhor amigo como se um de nós fosse morrer hoje?
<p>- Porque acho importante dizer. 
<p>- Se é o que está dizendo. – Jason riu. 
<p>- Você se lembra?
<p>- De quê?
<p>- De como ficamos assim. Nós dois. 
<p>- Mas é claro. Um bando de garotos começou a me perturbar, depois se juntaram para me bater. Aí apareceu alguém sei lá de onde para me defender. Eu não sabia porque, na verdade, quando ele chegou achei que ia me bater também, mas não. E no final, ele apanhou junto comigo. – Os dois riram.
<p>- Eram mil contra dois. A gente não tinha a menor chance.
<p>- Nunca ninguém tinha feito isso por mim. 
<p>- Você me ensinou matemática, eu te devia isso. 
<p>- Posso dizer que te amo agora?
<p>- Não. É meloso demais. – Will começou a rir. 
<p>- Olha só para você. Já está rindo e como se quisesse mesmo.
<p>- É. – Will respirou fundo. – Sabe, eu estava pensando. A Angie vivia em um hospital e em todo o momento estava cheia de vida. Ela não ia querer que eu ficasse chorando pelos cantos. 
<p>- Verdade. Ela ia querer você sorrindo e comemorando a vida que tem.
<p>- Exato. Ela acreditava no Céu, então talvez esteja lá agora.
<p>- Ela está.</p>
<center><h4>--*--</h4></center>
<p>Will estava esperando Emily do lado de fora da sala de aula dela no final do dia. Aquela tinha sido a pior semana sem nenhuma dúvida e tudo o que ele queria naquele momento era ficar com ela.
<p>- Oi, estava esperando por você.
<p>- Oi. Não te vi o dia todo, onde esteve? – Ela o cumprimentou com um beijo. 
<p>- Ah, nada de importante. Vamos dar o fora daqui?
<p>- Para onde quer ir?
<p>- Acontece que... eu convenci meu pai a emprestar o carro com tanque cheio. Isso não acontece sempre então a gente tem que aproveitar. – Ele sorriu e só aquilo a convenceu. 
<p>Will pegou a interestadual e seguiu em frente. 
<p>- Para onde estamos indo mesmo? – Emily tentava reconhecer as cidades escritas nas placas, mas não fazia ideia de onde eram aqueles nomes.
<p>- Você sabia que em uma cidade no norte da Califórnia tem a maior estatua de alumínio do mundo? – Will falou como se fosse a coisa mais empolgante do mundo.
<p>- Não. Eu não fazia ideia disso. – Ela riu.
<p>- Vai se surpreender então. 
<p>Quase que por impulso, Emily ligou o rádio.
<p>- Tem certeza? – Will perguntou. 
<p>- Não é a mesma coisa sem música.
<p>A viagem era longa e aquele rádio cantou de tudo. Assim que ligaram, a música <i>In Too Deep</i> já estava em seu último refrão. Logo após ela, o DJ disse algo sobre horas de música sem parar por um bom tempo. <i>Gives You Hell, Crazy, Welcome to The Black Parade, When I Come Around, The Anthem </i> foram algumas que eles cantaram praticamente gritando e com o som no último volume. 
<p>Quando <i>View From Heaven</i> começou a tocar, eles foram pegos desprevenidos e ficaram em silêncio até a voz de Ryan Key aparecer.
<p>- Fizemos uma aposta. Se a gente conhece, a gente canta. – Will finalmente falou. 
<p>- Por nossa conta em risco. – Ela sorriu. 
<p>- <i>Passeios tarde da noite, completamente sozinho no meu carro... Não consigo evitar começar a cantar todas as nossas músicas favoritas...</i>
<p>- <i>E melodias no ar cantando que a vida é injusta... Às vezes eu ainda não consigo acreditar que você se foi.</i> – Uma lágrima escorreu no rosto de Emily.
<p>- <i>E eu tenho certeza que a visão do Céu vence o inferno que é daqui.</i> – Ele respirou fundo – <i>E se todos nós acreditássemos no Céu, talvez conseguíssemos aguentar mais um ano.</i> Sua vez. – Ele olhou para Emily quando ela ficou em silêncio.
<p>- <i>Eu espero que esteja tudo bem aí no Céu, porque está um inferno aqui em baixo... Eu espero te encontrar no Céu, porque eu estou perdida sem você aqui.</i>
<p>Will aumentou mais ainda o volume do rádio e os dois começaram a gritar, até ficarem roucos, o restante da canção.</p>
<center><h4>--*--</h4></center>
<p>- Sabe qual foi a melhor parte de ver a estátua de alumínio?
<p>- Qual? – Will já segurou a risada porque sabia que uma piada ruim estava chegando pelo tom de voz da namorada. 
<p>- Saber que nem todo alumínio serve para fazer papel-alumínio.
<p>- Essa piada foi péssima.
<p>- Não foi uma piada. – Emily riu.
<p>- Não mesmo, porque não teve graça nenhuma.
<p>Os dois estavam deitados no bagageiro da picape estacionados em algum lugar entre Califórnia e Nevada. Os dois olhavam para o céu estrelado e aproveitavam o silêncio comendo biscoitos que compraram no meio da estrada.
<p>- Já está tarde, precisamos voltar. Seu pai vai me matar.
<p>- Desde quando se preocupa com o meu pai? – Ela riu de novo. 
<p>- Desde que eu descobri que ele pode arrancar meu pescoço. 
<p>- Relaxa, temos carta branca. Nossa amiga com câncer morreu. 
<p>- Cedo demais. – Ele apertou mais seu abraço. – Eu estava pensando, a gente podia fazer mais.
<p>- Como assim?
<p>- Eu não estou dizendo para sermos amigos de outra criança com câncer, mas, sei lá. Fazer algo para manter a memória dela viva. 
<p>- Sabe, eu estava pensando sobre isso também. Cheguei até a pesquisar e... parece que todo ano em San Diego, acontece uma corrida beneficente em prol das crianças com câncer. São vinte quilômetros.
<p>- Corrida, é sério? Eu odeio correr.
<p>- Eu até gosto. 
<p>- Estamos falando de vinte quilômetros. – Will fez uma careta. – Mas... eu topo. Podemos fazer isso.
<p>- Que bom que disse isso, porque eu já escrevi a gente. É em agosto. 
<p>- O quê?
<p>- Pela minha defesa, você escreveu a gente para dirigir uma van no Natal.
<p>- Está desculpada. – Ele riu. 
<p>- Eu vi também que em Nova York rola um show beneficente onde os cantores...
<p>- Não. – Will a interrompeu. – Isso eu não vou fazer. 
<p>- Eu imaginei.
<p>- Acho melhor a gente ir para casa, começar uma dieta e correr toda manhã. Ai, eu vou suar.
<p>- Ah, para de chorar. – Emily riu. – Eu preciso te dizer uma coisa. – Ela ficou séria então. 
<p>- O que foi?
<p>- A palestra que eu fui foi dada por um neurocirurgião e ele falou sobre extração de tumores e eu esperava... uma luz no fim do túnel. Eu fiz algumas pesquisas e...
<p>- Você é mais incrível do que achei que fosse. 
<p>- Para.
<p>- É verdade. Mas eu já suspeitava. Vi você tirar fotos do prontuário dela no hospital. – Ele riu.
<p>- O quê? Por que não me disse nada? 
<p>- Todos nós temos segredos. Tudo bem você ficar com o seu. Mas já que compartilhou o seu comigo, acho que...
<p>- O quê?
<p>- Tem uma mensagem de voz no meu celular faz uma semana. Angie me ligou e, como meu celular estava sem bateria, ela deixou um recado. Eu passei a semana toda tentando adivinhar o que ela falou, a parte boa e a parte ruim. Eu não sei o que fazer. 
<p>- Me dá seu celular. – Emily estendeu a mão.
<p>Will tirou o celular do bolso da calça e entregou para a namorada sem fazer perguntas. 
<p>- Acho que tentar adivinhar não é a melhor escolha. 
<p>- <i>Você tem uma mensagem. Se quiser ouvi-la, digite “1”.</i>
<p>Emily digitou assim que ouviu a voz eletrônica. 
<p>- <i>Oi, Will, sou eu. Eu sei que está tarde, mas...</i> – A voz de Angie estava fraca, porém ela não parecia triste. – <i>Eu estou indo fazer um exame. Meu nariz está com sangue, muito sangue, eu não sei porque. Não se preocupa comigo, tá bom? Minha mãe já faz isso por todos nós. Eu estou sim com um pouco de medo, eu te liguei para ficar mais calma. Ainda bem que não atendeu, senão você já estaria correndo para vir para cá e isso não ia me deixar mais calma...</i>
<p>Will apertou a mão de Emily mais forte. Ele conseguia visualizar o rosto de Angie na tela do telefone dizendo aquelas coisas. 
<p>- <i>...Minha mãe sempre disse que eu não podia reprimir meus sentimentos, que eu sempre tenho que dizer o que eu sinto então... Eu te amo, Will e amo a Ems também e quero muito ser amiga de vocês para o resto da minha vida. Tudo isso foi muito especial para mim. Amo suas histórias e amo ouvir você tocar violão. Você ainda vai fazer um show e eu vou estar lá dizendo que sou amiga intima do cantor famoso.</i> – Ela pausou. Com certeza, tinha sentido outra pontada na cabeça. – <i>Eu estou dizendo essas coisas, mas eu sei que vou ficar bem, eu sou forte e corajosa, você já me disse isso antes e eu acredito. E mesmo que as coisas não deem certo... A gente se encontra no Céu, tá bom? Eu te amo muito, muito, muito, muito mesmo...</i>
<p>A mensagem acabou. 
<p>- Que bom que eu ouvi isso com você. – Will soltou um riso. 
<p>- Que bom que estou com você. – Emily respondeu.</p>
<br>
<p>“Uma vez eu ouvi de alguém que o luto tem várias fases. Primeiro vem a negação, depois a raiva, a depressão, a barganha e por fim, a aceitação. 
<p>A negação é o mecanismo de defesa. “Eu estou bem”, “Não se preocupe”, “Não estou sentindo nada”. É a coisa mais complicada. Uma hora você não vai mais conseguir negar e vai precisar encarar o que está acontecendo estando pronto ou não.
<p>Raiva. Você grita, se culpa, culpa alguém, às vezes até parte para o soco. Não é saudável, mas é o seu jeito de fugir, de tentar se livrar do peso que está sentindo. Você se sente sufocado. Tudo é uma grande mentira e ninguém está fazendo o suficiente. Ninguém fez o suficiente. 
<p>Depressão. A tristeza te consome. Você percebe que acabou. Aquela pessoa nunca mais vai estar do seu lado, você nunca mais vai vê-la ou conversar com ela. Ela simplesmente não existe mais e a vida não continua, nem para ela e parece que nem para você e tudo o que você pode fazer é se lamentar.
<p>Barganha, negociação, qualquer coisa referente a isso. Se você acredita em Deus, fará várias promessas a ele. Faz planos, pensa em se tornar uma pessoa melhor, viver a vida de um jeito melhor. Na maioria das vezes, quando esse sentimento passa, essas promessas e planos acabam se tornando palavras vazias. Seu medo de viver ao máximo volta e você continua sendo a mesma pessoa de sempre. 
<p>Aceitação. Tudo vai ficar bem no final. Muitas pessoas acreditam que é destino, e essas outras coisas, não importa, contanto que a dor diminua, tudo é válido. O importante é perceber que não importa o que aconteça, quem você perdeu não foi totalmente embora, essa pessoa está com você o tempo todo e em todo lugar e isso é uma coisa boa. Ninguém vive para sempre, mas podemos permanecer vivos em quem nos ama, pelo menos em espirito.”. 
</body>
</html>";
            }

        }

        public void clkAbrirComentar(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MyPopupPage("EsseMundoVaiMudar", condicao.ToString()));
        }

        public void clkAbrirProximo(object sender, EventArgs e)
        {
            if (condicao+1 > 30)
            {
                Navigation.PushModalAsync(new Capitulo6Page(condicao+1));
            } else
            {
                Navigation.PushModalAsync(new Capitulo5Page(condicao+1));
            }
        }

        public void clkIrMenu(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MenusView.MenuEsseMundoPage());
        }

        public void clkSalvar(object sender, EventArgs e)
        {
            try
            {
                if (chkCapitulo.IsChecked == true)
                {
                    LerCapitulo(condicao.ToString(), "true");
                    ////var message1 = "CAPÍTULO LIDO";
                    //DependencyService.Get<IMessage>().ShortTime(message1);
                }
                else
                {
                    LerCapitulo(condicao.ToString(), "false");
                    ////var message = "VOCÊ DESMARCOU UM CAPÍTULO";
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
                    Historia = "EsseMundoVaiMudar"
                }, UserLocalData.userUID, "EsseMundoVaiMudar", "Capitulo" + capitulo);
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