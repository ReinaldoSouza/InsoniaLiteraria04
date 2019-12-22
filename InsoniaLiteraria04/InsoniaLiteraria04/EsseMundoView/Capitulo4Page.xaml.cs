using InsoniaLiteraria04.Database;
using InsoniaLiteraria04.Global;
using InsoniaLiteraria04.Helper;
using InsoniaLiteraria04.Model;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InsoniaLiteraria04.EsseMundoView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Capitulo4Page : ContentPage
	{
        DBFire service;
        public int condicao;

        public Capitulo4Page (int numero)
		{
			InitializeComponent ();
            service = new DBFire();
            condicao = numero;
            mostrarCapituloSalvo("EsseMundoVaiMudar", "Capitulo" + numero.ToString());

            if (numero == 19)
            {
                lblTitulo.Text = "Capítulo 19 - Cale a Boca e Dance Comigo";
                htmlPage.Html = @"<html>
<body>
<p><i>“Oh, não se atreva a olhar para trás
<br>Só mantenha seus olhos em mim
<br>Eu disse, você está se segurando
<br>Ela disse, cala a boca e dance comigo!
<br>Essa mulher é o meu destino
<br>Ela disse, oh, oh, oh
<br>Cale a boca e dance comigo”
<br><b>Shut Up And Dance – WALK THE MOON</b></i></p>
<br>
<p>Não era a primeira vez naquele dia que Amanda abordava Will sozinho para falar sobre o baile do fim de semana. Ele estava subindo as escadas da sala para ir ao seu quarto naquela tarde quando a irmã o gritou lá da cozinha e correu até ele. Will não tinha uma boa experiência com bailes, seu último foi com Giovanna e foi a pior noite da vida dele, segundo o próprio. Ele havia ficado feliz que Emily não estava a fim de ir também e que nem falava sobre o assunto, mas Amanda não acreditava que estava tudo bem com a namorada do irmão.
<p>- Ela com certeza quer ir, mas resolveu não ir por sua causa.
<p>- Não, ela me disse que não queria. Já te disse. – Will já estava cansado de argumentar sempre com a mesma coisa.
<p>- Ela mentiu.
<p>- Eu conheço minha namorada, está bem?
<p>- Você é homem. Nunca vai conhecer bem uma mulher. Não faz parte da sua natureza. 
<p>- Ela te disse alguma coisa? – Will não ia argumentar contra isso.
<p>- Não.
<p>- Então você fala isso baseado em quê? Por ela ser uma garota e garota gostar de baile?
<p>- Exatamente. – Amanda falou como se fosse óbvio. 
<p>- Tchau, Amanda. – Will continuou subindo as escadas.
<p>- Espera. – Ela correu para ficar na sua frente. – Outra coisa. Pode me arranjar um cara para me levar ao baile? 
<p>- Achei que fosse com a Quinn.
<p>- Ela vai com o Sebastian. Ele convidou ela hoje de manhã.
<p>- É sério? – Will ficou impressionado.
<p>- Olha, eu não sei o que você falou para ele, mas se você disser o mesmo para o Jason, talvez...
<p>- Não. – Will desviou de Amanda e subiu as escadas.
<p>- Will!
<p>- Arranja seu par sozinha. Eu cansei! – Ele gritou já do corredor superior.
<center><h4>--*--</h4></center> 
<p>- Então você não conseguiu convencer o Jason a convidar a Amanda nem o contrário.
<p>- Não. 
<p>Sebastian e Will acordaram bem cedo naquele dia. Na verdade, Sebastian acordou cedo e bateu na porta do quarto do irmão dizendo que precisavam conversar. Compraram café na padaria mais perto e foram caminhar na praia.
<p>- Então vai ser impossível os dois ficarem juntos.
<p>- Nunca se sabe. – Will respondeu. – Talvez os dois lá... talvez se resolvam. 
<p>- É um tiro no escuro. 
<p>- O que nessa vida não é? – Will riu. – Fiquei sabendo que vai com a Quinn. E não foi você que me contou. 
<p>- Eu... – Sebastian ficou envergonhado. – Resolvi dar um tiro no escuro. 
<p>- Bom para você. Achei que ia precisar te dar um soco. 
<p>- Você me deu, na verdade, mas com suas palavras.
<p>- Seb.
<p>- Você tinha razão. Tudo o que você disse. Agora eu tenho que trabalhar nisso. 
<p>- Não precisa trabalhar nisso sozinho. É para isso que irmãos servem, para fazer seu trabalho pesado. – Os dois começaram a rir. 
<p>- O que vai fazer na noite do baile?
<p>- Eu estava planejando algo, mas acho que vou ter que pensar em um plano melhor.
<p>- Por quê?
<p>- Eu achei que a Emily não queria ir ao baile, mas agora, depois de tanto a Amanda falar, estou achando que ela quer, então eu tenho que compensar.
<p>- Ou você pode simplesmente ir ao baile. – Sebastian falou o que achou que seria o óbvio.
<p>- Compensar é melhor. E cala a boca, pelo menos eu tenho uma namorada. 
<p>- Não enche.</p>
<center><h4>--*--</h4></center> 
<p>- Baile é ridículo. – Will parou ao lado do armário de Emily enquanto ela pegava seu livro para a próxima aula. Ele então avistou um cartaz do baile pregado na parede oposta.
<p>- Qual é o seu problema com bailes? – Emily riu. 
<p>- Eu não entendo a existência deles. Pessoas tendo que se vestir a caráter só para dançar com alguém e ser humilhado no final da noite porque não foi rei ou rainha. Além do mais, você tem que passar toda aquela vergonha de convidar alguém. 
<p>- Você tem fobia de bailes?
<p>- Não é fobia.
<p>Emily voltou a rir.
<p>- Olha só, para muita gente, o baile é a melhor noite da vida delas. – Emily entregou um livro para Will segurar e fechou seu armário.
<p>- Ah é?
<p>- É. Você está olhando pelo ângulo errado. 
<p>- Qual é o certo?
<p>- Eu não sei, eu nunca fui a um baile. – Ela riu com um pouco de vergonha.
<p>- Por que não? Acho que a bailefóbica é você.
<p>- Isso nem é uma palavra para começar. – Ela o corrigiu. – E... sei lá, você já viu na televisão aqueles bailes de gala da realeza?
<p>- Claro, é o meu programa favorito de todo sábado à noite.
<p>- Cala a boca. – Ela o empurrou de leve. – A questão é que, em todos os bailes eu recusei os convites, não que foram muitos, mas...
<p>- Por que você não foi?
<p>- Ninguém era digno de me ver de vestido. – Ela riu. – De me fazer ficar horas no salão de beleza para me parecer com alguém que eu não era de verdade. 
<p>- Então eu não sou digno? Por isso não quer ir ao baile? Eu posso sim levantar o martelo.
<p>- Não foi o que eu disse. Eu não quero ir ao baile porque eu não faço questão de ir. Só isso.
<p>- Eu ouvi uma garota da minha sala dizendo que ela gosta de ir ao baile porque se sente linda e desejada. – Will franziu a testa tentando entender o absurdo daquela frase.
<p>- Exatamente. Eu não preciso disso. Eu já me sinto assim.
<p>Emily pegou o livro da mão de Will, se despediu com um beijo e seguiu seu caminho para sua aula, mas deixou o namorado um pouco pensativo.  
<p>A culpa em Will chegou bem na noite do baile. Ele estava do lado de fora da casa de Emily a esperando quando ele se deu conta que todo mundo deveria estar se preparando para o baile, muita gente já devia até estar lá, mas eles não. Seu traje a caráter era uma camiseta, uma bermuda e chinelos.
<p>- Você não quer mesmo ir ao baile, não é? – Emily não parecia triste quando apareceu no portão vestindo algo tão simples quanto ele. 
<p>- Eu não quero. Achei que já tínhamos conversado sobre isso.
<p>- É que todo mundo está falando que você está mentindo.
<p>- Relaxa, eu estou bem.
<p>- Jura? – Will estava com algumas dúvidas.
<p>- Eu juro. Podemos ir agora?
<p>- Tá bom.
<p>- Para onde vamos?
<p>- Que tal você escolher? – Will passou o dia todo tentando ter ideias, mas não conseguiu nenhuma boa o bastante.
<p>- Tudo bem então.</p>
<center><h4>--*--</h4></center> 
<p>Jason estava parado ao lado da bacia do ponche com as mãos no bolso. Ele observava todo mundo dançando no ginásio enquanto batia só um dos pés no chão nervoso demais para ir até a pista de dança.
<p>- Você é o segurança do ponche esse ano? – Amanda se aproximou de Jason.
<p>- O quê? – Ele estava tão distraído olhando para o nada que nem percebeu a presença dela.
<p>- Não quer que batizem o ponche esse ano? – Ela falou um pouco mais alto.
<p>- Não queremos passar a noite no hospital de novo, não é? – Ele colocou um pouco de ponche em um copo e entregou a ela. 
<p>- É verdade, mas eu não vi a Giovanna por aqui.
<p>- Bom, para falar a verdade... – Jason falou antes de Amanda tomar. – Acho que já batizaram. Tomei dois copos e já estou meio tonto. 
<p>- Vai com calma aí, garoto. Eu não vou carregar ninguém até o taxi. – Amanda riu.
<p>- Pode deixar. 
<p>A música estava bem alta. Os dois ficaram lá parados um do lado do outro em silêncio por mais alguns segundos. Jason parecia estar com vergonha de chamar Amanda para dançar, e ela estava com medo dele não aceitar, se ela o chamasse.
<p>- Sabe, eu ainda acho que o Will tem que ficar de olho na Giovanna, principalmente depois da última coisa que ela fez. – Jason tentou usar uma desculpa para puxar assunto.
<p>- Eu também acho, mas você conhece o Will, ele não leva nada a sério.
<p>- Gostaria de ser assim às vezes. Assim eu não me preocuparia com tantas coisas todos os dias.
<p>- Com o que você se preocupa? – Amanda demonstrou interesse.
<p>- Com um monte de coisas.
<p>- Tipo o quê? – Ela insistiu.
<p>- Bom, tipo... tipo... tipo a gente.
<p>- Como assim? – Amanda de repente ficou nervosa.
<p>- Eugostodevocê. – As palavras saíram bem rápido.
<p>- O quê? Eu não entendi nada do que você falou. – Amanda começou a rir para disfarçar o nervosismo. – Tem certeza que só bebeu dois copos?
<p>- Eu gosto de você. Muito. – Ele respirou fundo. – E eu sei que você também gosta de mim.
<p>Jason se virou para Amanda e se aproximou mais dela.
<p>Amanda queria muito dizer que ele estava certo, que ela gostava mesmo dele, jogar tudo para o alto e beijá-lo, mas naquele momento ele não estava sóbrio, pelo menos não totalmente. Se ele estivesse, não estaria dizendo aquelas coisas, não era da natureza de Jason fazer aquele tipo de coisa. 
<p>- Jason, você está um pouco...
<p>- Não, eu estou muito... muito apaixonado por você. Faz muito tempo.
<p>Ele se aproximou mais um pouco e ela não conseguiu resistir. Os dois se beijaram.
<p>- Jason, calma aí. – Amanda se afastou um pouco.
<p>- O que foi? Você não...
<p>- Eu gosto de você. – Ela disse logo antes que ele ficasse com vergonha e fosse embora ou desistisse de tudo. – Mas... você tem certeza? Você nunca...
<p>- Eu tenho absoluta certeza. – Jason estava eufórico, carregado de adrenalina.
<p>- Mas você... vai ter essa mesma opinião amanhã quando estiver sóbrio?
<p>- Eu vou. Vou ter amanhã, depois de amanhã, o ano que vem, a década que vem, no século que vem. E eu estou sóbrio. – Ele sorriu.
<p>- O quê? – Ela ficou mais surpresa ainda.
<p>- Eu não bebi o ponche depois que batizaram. Só sou um idiota.
<p>- Então diz de novo. – Amanda ainda não estava acreditando.
<p>- Eu gosto muito de você, Amanda. É sério. Eu não vou me arrepender de dizer isso.
<p>Amanda ficou encarando Jason por um tempo calada e ainda com uma expressão de incredibilidade.
<p>- Eu... – Ela começou a olhar para todos os lados a procura de uma saída. – Eu preciso ir embora.
<p>- O quê? N... Não.
<p>- Eu preciso digerir isso tudo.  Só porque você demorou, eu tenho que ser rápida? Não é assim que funciona.
<p>- Mas eu achei que... – Jason ficou confuso.
<p>- Eu tenho que ir. 
<p>- Mas eu preciso fazer mais uma coisa.
<p>Então ele a beijou de novo. Ela tentou resistir por um tempo, mas nem Amanda podia ser tão teimosa assim, então acabou cedendo e o retribuiu.</p>
<center><h4>--*--</h4></center> 
<p>Will e Emily estavam sentados na areia da praia. Seus pés se molhavam sempre que uma onda chegava perto deles. 
<p>- Por que quis vir à praia? A gente vem aqui o tempo todo. – Will estava esperando um lugar totalmente novo quando pediu para a namorada sugerir.
<p>- Não importa onde eu estou e sim com quem eu estou.
<p>- É, eu sei que eu sou uma ótima companhia. – Will riu.
<p>- Sabe, ás vezes você força um pouco e fica difícil te amar.
<p>- Impossível. É...
<p>- Eu sei. Nunca é difícil amar você. – Ela beijou o namorado depois de o imitar.
<p>- Exatamente isso. Mas mudando de assunto, estamos aqui sozinhos e no silêncio quando, sei lá, poderíamos estar no baile. – Will olhou para Emily de rabo de olho.
<p>- Não é justo, sabia? Você foi o primeiro a dizer que não queria ir. Agora está me sufocando com essa história.
<p>- Sim, porque terno e gravata me deixam nervoso. 
<p>- É sério? – Ela começou a rir. 
<p>- Olha, diferente da sua história de que ninguém era digno, eu já fui em bailes. E já fui rei. 
<p>- Por que não estou surpresa? – Ela levantou a sobrancelha.
<p>- Só que... no ano passado, eu fui ao baile sozinho. 
<p>- William Jones indo ao baile sozinho? Quem diria? – Ela ficou surpresa.
<p>- Eu tinha acabado de terminar com a Giovanna e minha reputação estava muito baixa. Só que... ela achou que eu tinha ido sozinho porque queria voltar com ela e que eu ia propor isso no baile. Só que a noite foi passando e...
<p>- Você não disse nada. 
<p>- Ela ficou uma fera. Ficou totalmente desiquilibrada. Amanda e ela saíram no tapa no banheiro e a doida rasgou todo o vestido da minha irmã.
<p>- Ela não... – Emily ficou de boca aberta.
<p>- Ela envergonhou o Jason com uma garota que ele estava dançando e ele se sentiu humilhado demais para voltar para o ginásio.
<p>- Nossa, foi um banho de sangue. – Depois das ações que Giovanna efetuou nos últimos dias, Emily nem estava mais surpresa.
<p>- Mas o pior foi que ela batizou o ponche e deu para o Sebastian beber. 
<p>- O quê? – Por essa, ela não esperava.
<p>- Ficamos a noite toda no hospital, Sebastian no soro, chorando sem parar até ficar sóbrio de novo. 
<p>- Tudo bem, isso foi cruel. Não vou mais me surpreender com mais nada que vier da Giovanna.
<p>- Não é só por isso que eu não gosto de bailes. Como eu te disse, gravata me incomoda. 
<p>- Se essa é a sua história. – Ela riu.
<p>- Sabe, mas confessando, eu queria que a gente tivesse sido o rei e a rainha do baile desse ano. Mesmo que fosse para jogarem suco na gente como em Carrie. – Ele sorriu. 
<p>- É, não seria nada mal usar um lindo vestido e maquiagem.
<p>- Quer dizer que eu sou digno? – Will mostrou um sorriso. – Vem comigo.
<p>Ele se levantou do chão e estendeu a mão para ela.
<p>- Para onde vamos?
<p>- Para o baile.
<p>- Will, esquece isso. Já está tarde. O baile já deve estar acabando, talvez até acabado a essa hora.
<p>- Não importa. A gente faz... ele começar de novo. Vem.
<p>- O que isso quer dizer?
<p>- Vem logo. 
<p>- Você é doido. – Ela segurou firme na mão dele e também se levantou.
<p>- Não acredito que ainda se surpreende com isso.</p>
<center><h4>--*--</h4></center> 
<p>Sebastian e Quinn estavam na frente da casa dela. Os dois haviam ido ao baile juntos como dois amigos. Até aquele momento, a noite estava muito boa para eles. 
<p>- Foi bom, não foi? – Sebastian perguntou. – Meu último baile foi uma droga.
<p>- É, eu também gostei bastante. 
<p>- É. – Sebastian estava um pouco nervoso.
<p>- Sabe, não precisava me trazer em casa. Fomos ao baile como amigos. Eu não estava esperando...
<p>- Está muito tarde e não é bom uma garota andar na rua sozinha a essa hora.
<p>- Eu sei me cuidar. – Ela sorriu.
<p>- Eu não tenho dúvidas disso. Mas o que eu posso fazer? Sou um cavalheiro. – Ele brincou.
<p>- Até demais. 
<p>- Bom, eu tenho que ir. A gente se vê depois.
<p>- Claro. 
<p>- Tchau. – Mas ele continuou imóvel como se estivesse esperando por algo.
<p>Quinn se aproximou de Sebastian.
<p>- Eu não vou resistir. – Ela suspirou.
<p>- O quê?
<p>Quinn se aproximou mais e o beijou. Naquele momento, Sebastian sentiu como se estivesse beijando pela primeira vez, ficou tão nervoso que nem conseguiu retribuir direito e tornar aquele beijo decente. 
<p>- Agora boa noite.
<p>- B-boa... noite. – Ele ficou parado na frente da casa esperando Quinn entrar pelo portão. 
<p>Ele ficou um bom tempo ali parado, na verdade. Estava em choque. Depois de um tempo ele viu, pela janela, a luz do quarto de Quinn se acender. Ela abriu a janela e sorriu para ele. Ele retribuiu o sorriso e se imaginou fazendo a cara mais idiota do mundo.</p>
<center><h4>--*--</h4></center> 
<p>Will finalmente pôde dizer que matar aulas todos aqueles anos teve um lado bom. Quando ele e Emily chegaram, a escola já estava trancada. Ele sempre conseguia fugir quando a escola estava trancada, então entrar não seria tão difícil. Enquanto Emily falava “não” o tempo todo, Will pulou o muro e agradeceu por não ter nenhum alarme de invasão. Uma vez lá dentro, ele abriu o portão e Emily entrou ainda com medo.
<p>A escola estava vazia. Will não se preocupou com o zelador. Deveria estar dormindo a essa hora. Os corredores estavam bem sujos. Eram copos vazios jogados no chão, confetes e bexigas estouradas para todo o lado.
<p>O ginásio estava apagado, mas não foi difícil encontrar o interruptor para ligar as luzes. Eles haviam caprichado muito na decoração, pensou Will. Estava tudo impecável.
<p>- Está muito bonito. – Emily olhava para a decoração.
<p>- É, isso é um baile. Viu? Não perdeu nada demais.
<p>- Engraçadinho. É perfeito. Podemos ir embora agora? – O medo dela falou mais alto. 
<p>- Sair do baile sem uma dança? Jamais.
<p>- Que dança? O que você está falando? Não tem música nenhuma.
<p>- É só... é só usar a imaginação. 
<p>- Will... – Ela estava relutante.
<p>- Vai me negar uma dança? – Ele a encarou fingindo estar desapontado, enquanto se divertia por dentro com o medo da namorada. – Já estamos aqui. 
<p>- Tá legal. Mas se nos pegarem...
<p>- Esquece isso. Só dança comigo. 
<p>Os dois ficaram um tempo dançando calados. Estavam em completa sintonia. 
<p>- Que música você está imaginando? – Ela finalmente perguntou.
<p>- <i>Pretty Fly For A White Guy<i>. 
<p>- Essa música nem é lenta. – Eles começaram a rir.
<p>- Mas é um hino. 
<p>- Sabe, eu prefiro o baile assim. Só nosso. – Ela sorriu.
<p>- Eu também. Se estivéssemos em um filme, essa hora a gente ia começar a flutuar. 
<p>- Seus filmes são estranhos assim como suas músicas lentas. – Emily brincou.
<p>- E quanto a você? Que música está pensando? Não me diga que é <i>My Heart Will Go On<i>?
<p>- Não. Embora essa música também seja um hino. – Ela advertiu antes que ele fizesse alguma piada com a música. 
<p>- Então qual é?
<p>- Você não deve conhecer. <i>Heaven</i>. Bryan Adams
<p>- É, eu nunca ouvi falar. – Will franziu a teste. – Canta o começo para eu tentar me lembrar.
<p>- Acho melhor não.
<p>- Vai. Não tem mais ninguém aqui. – Ele pediu.
<p>- Tá bom. Ah... <i>Oh! Pensando em quando éramos jovens... Só existia eu e você. Nós éramos jovens, selvagens e livres...</i>
<p>Will começou a rir.
<p>- Eu não canto tão mal assim. – Ela ficou brava.
<p>- Não é isso, é que... eu te enganei. Eu conheço a música, só queria te ouvir cantar.
<p>- Você é tão...
<p>- <i>Agora nada pode te levar para longe de mim... Nós já estivemos naquela estrada antes, mas agora já acabou</i>. – Will começou a cantar. – <i>E você continua voltando para ter mais...</i>
<p>- Eu odeio você.
<p>- <i>AMOR, VOCÊ É TUDO O QUE EU QUERO!</i> – A voz de Will ecoou pelo ginásio todo.
<p>- O que você está fazendo? – Emily começou a rir depois de levar um susto.
<p>- Cantando com a alma. <i>QUANDO VOCÊ ESTÁ AQUI DEITADA EM MEUS BRAÇOS!</i>
<p>- Sua alma não precisa gritar.
<p>- Tem razão. Vamos voltar a dançar. <i>É difícil de acreditar, estamos no céu.</i> – Os dois voltaram a dançar e Will começou a cantar baixinho.
<p>- <i>E o amor é tudo o que eu preciso.</i>
<p>- <i>E eu o encontrei no seu coração.</i>
<p>- <i>Não é tão difícil de ver, estamos no céu.</i> – Então ela sorriu para ele. – Melhor baile de todos. 
<p>- Eu te amo. – Ele a beijou.</p>
<br>
<p>“Têm certas coisas na vida que são inesquecíveis e insubstituíveis. Amigos de verdade, experiências como seu primeiro beijo, o dia em que você se formou, quando conheceu o amor da sua vida, o dia do seu casamento, o nascimento do seu filho, a realização de um sonho, o momento que você chega aonde queria. Mas o inesquecível não é só repleto de coisas boas, coisas ruins também são difíceis de esquecer. Seu coração partido, uma briga sem reconciliação, a perda de alguém, o pior momento da sua vida até existir outro. 
<p>Existem coisas que quando começam são difíceis de acabar. Como o amor, o ódio, a alegria, a tristeza, mas é tudo relativo. Se você quer ser feliz, por que ainda insiste na tristeza? Para que odiar quando amar é muito melhor? Às vezes, as pessoas preferem o caminho mais fácil. É mais fácil desistir, é mais fácil colocar a culpa em alguém, mas a vida não é fácil, nunca vai ser. Não se acomode com o fácil. Não se acomode com o simples. Com o pouco. Com o mínimo. Vale a pena lutar para ser feliz. Você pode. Vale a pena lutar para ter algo a mais. Para se sentir maravilhado. Vale a pena lutar pelo amor da sua vida. Vale a pena ter algo inesquecível. Vale a pena ser você.”</p>
</body>
</html>";
            }

            if (numero == 20)
            {
                lblTitulo.Text = "Capítulo 20 - (Não) Se Esqueça de Mim";
                htmlPage.Html = @"<html>
<body>
<p><i>“Será que você não vai vir me ver?
<br>Vou estar sozinho, dançando, você sabe disso
<br>Me conte seus problemas e dúvidas
<br>Me entregue tudo, de dentro e de fora
<br>O amor é estanho, tão real no escuro
<br>Pense nas coisas carinhosas que estávamos fazendo
<br>A mudança lenta pode nos separar
<br>Quando a luz entrar dentro do seu coração
<br>Não se esqueça de mim”
<br><b>Don’t You (Forget About Me) – Simple Minds</b></i></p>
<br>
<p>“Eu nunca fui muito fã de aniversário. Não tem nada a ver comigo ficando velho e não gostar disso. Eu simplesmente nunca fui de comemorar. Eu sempre recusei bolos e festas que minha mãe sempre insistia em fazer. Quanto mais normal o dia fosse para mim, melhor era. No final do dia, eu fazia um pedido. Esse era meu ritual. E eu gostava muito dele.”.</p>
<br>
<p>Naquele dia, Will acordou bem cedo.
<p>Saiu de casa antes que todos acordassem. Também não gostava muito de abraços de aniversário. Embora ninguém se importasse e o abraçava mesmo assim. Seu plano era ficar no hospital com a Angie a manhã toda. 
<p>O plano não saiu muito bem como ele queria. Duas horas depois que ele chegou no hospital, Emily mandou uma mensagem de texto perguntando onde ele estava e dizendo que ia buscá-lo.
<p>Angie sorriu e começou a imaginar as maiores festas de aniversários possíveis que a namorada poderia estar organizando para Will. Embora ele ficasse o tempo todo dizendo que ela estava viajando na imaginação, no fundo ele tinha medo que algo parecido acontecesse de verdade.</p>
<center><h4>--*--</h4></center>
<p>Will estava andando de olhos fechados. Foi uma exigência de Emily, e mesmo reclamando a cada passo, ele aceitou fechar os olhos.
<p>- Ems, eu odeio surpresas e você sabe.
<p>- Essa você vai gostar. – Emily parecia feliz e animada.
<p>Ele não sabia para onde estavam indo. Emily não alcançava os olhos de Will para poder tapá-los enquanto andavam, já que era bem menor que ele, por isso aceitou confiar que ele não abriria os olhos mesmo que quisesse muito. Ela segurava firme na mão dele e os dois andavam com cuidado para ele não tropeçar em nada e ela conseguir guiá-lo. 
<p>- Para onde estamos indo? – Ele perguntou.
<p>- É uma surpresa. Já estamos chegando.
<p>- Achei que a gente ia no cinema mais tarde. Esse era o combinado.
<p>- Eu sei. – Ela falou ansiosa.
<p>- Então estamos indo ao cinema? Por que eu estou de olhos fechados?
<p>- Será que dá para você parar de fazer tantas perguntas? A gente já vai chegar.
<p>- Só espero que eu não queira te matar depois que chegarmos. – Will resmungou.
<p>- Não prometo nada. – Ela riu. 
<p>Os dois continuaram andando por mais alguns minutos em silêncio. O silêncio era quebrado às vezes com Emily falando baixinho ao conduzi-lo pelo caminho, “cuidado com o degrau”, “aqui é a calçada”, “não bata no poste”. Depois de um tempo, o que pareceu para Will horas, Emily abriu uma porta.
<p>- Agora você pode abrir os olhos. – Emily falou quase gritando depois de um tempo.
<p>Will abriu os olhos e ouviu um grito em uníssono que ele não queria ouvir.
<p>- SURPRESA!
<p>Estavam na sala de estar da casa dele. Tinha uma faixa azul bem grande com letras em amarelo. “Feliz Aniversário, Will!”. Seus irmãos batiam palmas e riam da desgraça dele. Sua mãe parecia finalmente realizada com aquela pequena festa enquanto seu pai ria muito. Quinn e Jason estavam sentados no sofá encarando Will como se esperasse uma reação diferente da que todos estavam querendo. 
<p>- O que está acontecendo aqui? – Will arregalou os olhos assustado.
<p>- É seu aniversário. – Emily parecia dizer a coisa mais óbvia do mundo. 
<p>- E tínhamos concordado que não ia rolar nada. A gente ia ao cinema. – Will puxou Emily de lado e falou baixo só para ela ouvir.
<p>- Eu disse que ele ia surtar. – Jason falou em um tom sem emoção nenhuma. 
<p>- Pelo menos não tem bolo, não é? – Will respirou aliviado. 
<p>- Bom... – Emily sorriu sem graça.
<p>- <i>Parabéns para você, nessa data querida. Muitas felicidades, muitos anos de vida</i>. – Amanda veio da cozinha com um bolo de chocolate cheio de velinhas já acesas.
<p>- Eu não acredito nisso.
<p>- Antes de brigar com a gente, foi ideia da Emily. – Karen riu enquanto via seu filho fazendo cara feia para toda aquela situação.
<p>- Ems... – Will olhou para namorada como se esperasse que ela pudesse fazer tudo aquilo desaparecer da frente dele.
<p>- Will, fazemos aniversário uma vez por ano. Você está completando dezoito, então eu achei que...
<p>- Bom, como eu já esperava por isso, eu vou colocar o bolo aqui. – Amanda colocou o bolo em cima da mesa de centro da sala. – E vou sair. Tchau e feliz aniversário, maninho.
<p>- Para onde você vai? – Jason levantou a sobrancelha. 
<p>- Não te interessa. – Amanda virou a cara para Jason, deu um beijo de despedida no rosto de Will e saiu de casa. 
<p>- Mandy foi esperta. Se vocês querem continuar vivos, deviam sair também. – Will olhou para cada um dos seus irmãos, depois para Jason e Quinn e voltou a olhar para Emily.
<p>- Bom, eu já vou então. – Jason se levantou. – Vamos, Quinn?
<p>- Estou logo atrás de você. A festa já acabou. – Quinn se levantou rindo e os dois saíram da sala de fininho e foram até a porta de saída.
<p>Kevin, Chris, Sebastian e Matt ficaram mais alguns segundos na sala até que Kevin teve a iniciativa de pegar o bolo e levar para a cozinha. Os outros o seguiram. 
<p>- Bom, Karen, acho melhor a gente ir também. – Robert olhou para Karen. – Vamos deixar os dois conversando.
<p>- Claro, vamos. – Os dois concordaram e foram para cozinha atrás dos outros filhos.
<p>Will ficou encarando a namorada por um tempo até voltar a falar.
<p>- Eu disse que não queria nada, Emily. Todas as mil vezes que você perguntou o que eu queria de aniversário, eu disse que não queria nada.
<p>- Mas eu não entendo...
<p>- Você não precisa entender. Nem tem uma explicação. Eu simplesmente não gosto. – Will quase gritou.
<p>- Por que não?
<p>- Já disse, não tem uma explicação. 
<p>- Tudo bem, eu sinto muito. – Emily se rendeu.
<p>- Tudo bem, eu não estou bravo. Na verdade, eu estou um pouco, mas deixa para lá. Você teve uma boa intenção.
<p>- De boas intenções o inferno está cheio.
<p>- Exatamente, por isso não faça isso de novo. – Will riu para demonstrar que não estava tão bravo assim.
<p>- Bom, já que não está tão bravo, não vai ligar de ganhar um presente.
<p>- Emily, não. – Will implorou.
<p>- Tá bom. – Ela resmungou. – Mas não vai me impedir de te desejar parabéns.
<p>- Eu aguento isso. – Ele sorriu.
<p>- Ótimo. Feliz aniversário. – Ela o abraçou e depois o beijou. – Te amo.
<p>- Muito obrigado e eu também te amo.</p>
<center><h4>--*--</h4></center>
<p>Will ainda conseguiu comer um pedaço do bolo, mas com isso veio o castigo. Sua mãe percebeu que ele não havia ficado tão bravo com a “festinha” surpresa da manhã e resolveu que faria um jantar de aniversário para o filho. Como se isso não fosse um castigo suficiente para Will, ela ainda convidou os pais de Emily para o jantar. Ela estava tão animada que ele não quis estragar a alegria dela. Resolveu então colocar na cabeça que não seria tão ruim.
<p>Karen era muito caprichosa, principalmente quando recebia visitas. A mesa de jantar estava bem arrumada, impecável, e a comida... era o seu melhor prato. Emily chegou com seus pais no horário marcado. Harry olhou para Will com aquela cara rabugenta de sempre.
<p>- Cadê a Quinn? – Will perguntou assim que deu pela falta dela.
<p>- Ela disse que ia vir mais tarde. Ficou de segredinhos no telefone o dia todo. – Emily riu, mas parecia incomodada com a irmã escondendo algo dela.
<p>Todos se sentaram ao redor da mesa. Jason também havia mandando uma mensagem para Will de que chegaria mais tarde. 
<p>- Sejam bem-vindos à minha casa. – Robert se levantou e levantou seu copo em homenagem a Harry e Patrícia. – Que bom que finalmente nos conhecemos.
<p>- O prazer é todo nosso. – Patrícia sorriu. – Emily falou muito bem de vocês. – Ela olhou para Karen que retribuía o sorriso.
<p>- Espero que a gente se dê muito bem. – Harry falou sorrindo. Algo que Will não via com muita frequência. Ele não havia contado para os pais como havia sido conhecer os pais da namorada, em especial o pai. 
<p>- Cadê o Kevin? – Will olhou ao redor da mesa. – Ele nunca perde um jantar.
<p>- Ah, ele disse que ia se atrasar um pouco. – Karen falou. – Disse que ia trazer uma garota. Até deixei um lugar a mais na mesa.
<p>- Kevin tem uma namorada agora? – Chris riu enquanto passava a vasilha de molho para Ashley ao seu lado.
<p>Todos começaram a se servir e por um momento tudo o que era ouvido era o barulho de talheres batendo um no outro e nos pratos. Isso mudou assim que abriram a porta de entrada no outro cômodo.
<p>- Cheguei! – Gritou Kevin já da porta. – E olhem só quem eu trouxe. 
<p>Kevin vinha todo sorridente de mãos dadas com Giovanna que também tinha um sorriso que ia de orelha a orelha.
<p>- Giovanna?! – Amanda não soube disfarçar sua surpresa.
<p>- Nossa. – Sebastian falou baixo do lado de Will.
<p>- Olha, eu sei que foi em cima da hora e... – Kevin olhou para todos, mas parou em Will. Ele tinha um tom de quem estava tentando se desculpar. 
<p>- Está tudo bem. – Will falou logo. – Tem comida para todo mundo. – Ele sorriu para aliviar a tensão. 
<p>Karen e Robert olharam um para o outro como se quisessem falar algo só com o olhar e depois apontaram para dois lugares vagos na mesa para eles se sentarem. Amanda olhou para Will de cara feia. Emily estava chocada demais para falar ou fazer alguma coisa.
<p>- Eu não ia vir, mas o Kevin insistiu tanto... – Giovanna falou envergonhada.
<p>- Mas é claro. – Amanda deu seu sorriso sarcástico. 
<p>Kevin e Giovanna se sentaram. Will tentou deixar as coisas mais normais possíveis e demostrar que não estava se importando com o par repentino do irmão. Amanda, por outro lado, não estava fazendo esse trabalho todo e deixou estampado na sua cara que não estava gostando daquela situação. 
<p>- A comida está muito boa, Karen. – Emily tentou continuar o jantar normalmente.
<p>- Ah, muito obrigada, querida.
<p>- Está muito boa mesmo. – Giovanna sorriu. – Me lembra quando você fazia aquele macarrão maravilhoso e eu tentava... – Ela olhou para Will e parou de falar.
<p>Will sabia o que ela ia dizer. “Tentava dar comida na boca de Will”, uma coisa que ele odiava. É, não estava nada confortável. 
<p>- Bom, eu vou já buscar o bolo. – Amanda se levantou para a surpresa de todo mundo. – Will, vem comigo.
<p>- Eu ainda estou comendo. – Ele falou de boca cheia.
<p>- Vem logo. E você também. – Ela olhou para Emily.
<p>- Eu? Por quê?
<p>- Só vem. 
<p>Ela pegou no braço do irmão que ainda estava mastigando e o empurrou para longe da mesa e foram juntos para a cozinha. Emily se levantou logo depois e os seguiu.</p>
<center><h4>--*--</h4></center>
<p>- Estão todos malucos? – Amanda só não gritou na cozinha porque sabia que os outros na sala de estar iriam ouvi-la. Mas sua vontade era de gritar aos quatro ventos a sua insatisfação.
<p>- Mandy, se acalma. – Will falou calmamente.
<p>- Me acalmar? Aquela cobra está na minha casa. Emily, me ajuda aqui. – Ela olhou para outra pedindo ajuda.
<p>- O quê? – Emily ficou surpresa.
<p>- Você também está achado isso normal?
<p>- Vocês não querem saber a minha opinião. – Emily preferia ficar calada.
<p>- A gente quer, sim. Pode falar. Vai logo. – Amanda estava muito nervosa e andava de um lado para o outro. 
<p>- Bom, ele é seu irmão. – Ela olhou para Will. – E está saindo com a sua ex. Isso é estranho. Não por ser a Giovanna, mas por ser a sua ex. 
<p>- O que tem de estranho? Os dois estão solteiros e se conhecem faz um tempo. Não tem nada de errado. – Will estava tentando se convencer daquilo embora tenha ficado um pouco desconfortável na mesa uns minutos atrás.
<p>- É o seguinte, Will. – Emily respirou fundo. – Se a gente terminasse e de repente você aparecesse na minha casa namorando a Quinn, eu ia te cortar ao meio e depois ia bater nela até ela cair na real. Isso é loucura. 
<p>- Não vamos exagerar. 
<p>- Aquela garota estava tentando dormir com você algumas semanas atrás. – Amanda arregalou os olhos de nervoso.
<p>- Mas não conseguiu. Talvez isso fez ela seguir em frente.
<p>- Eu duvido muito. – Emily comentou.
<p>- Gente, eu não me importo com os dois juntos.
<p>- Bom saber. – Kevin havia acabado de entrar na cozinha. – Will, será que a gente pode conversar a sós?
<p>- Vamos pegar o bolo, Amanda. – Emily falou.
<p>- Claro, eu vou adorar tacar ele na cara de alguém. – Amanda fuzilou Kevin com os olhos.
<p>Emily empurrou Amanda para pegar o bolo e depois as duas saíram da cozinha.
<p>- Me desculpa. – Kevin falou logo.
<p>- Não precisa.
<p>- Mas eu...
<p>- Deveria ter me contado? Com toda a certeza, assim pouparíamos o momento constrangedor de agora a pouco. – Will brincou. 
<p>- Fiquei com medo de você enlouquecer. 
<p>- Eu estou bem. Eu estou com a Emily agora e eu estou apaixonado por ela. 
<p>- Tudo bem. – Kevin respirou aliviado.
<p>- Você gosta dela? De verdade?
<p>- Bastante. 
<p>- Já faz tempo?
<p>- Acho que sim. Eu nunca te disse porque vocês estavam juntos e depois terminaram daquele jeito e...
<p>- Tudo bem. Se gosta dela, vai fundo. Mas antes, tenha certeza que ela gosta de você também. Não quero que se machuque.
<p>- Eu vou descobrir.
<p>- Tá legal. Agora vamos voltar para mesa. Eu estou perdendo meu segundo bolo de aniversário. – Will abraçou o irmão e se deu conta que fazia tempo que não o abraçava.
<p>- Valeu. – Kevin sorriu.
<p>Quando os dois voltaram para a sala, Will teve mais uma surpresa.
<p>- Jason e Quinn? – Os dois estavam sentados do outro lado de Emily, muito contentes e quase abraçados. – O que eu perdi? – Will perguntou para a namorada assim que se sentou.
<p>- Os dois chegaram de mãos dadas. – Emily parecia um pouco constrangida. – Seu aniversário está formando vários casais esse ano.
<p>Will olhou para a irmã. Se ela estava com raiva antes, agora ela parecia que ia explodir.
<p>- Foi mal a demora, Will, nós estávamos um pouco ocupados. – Jason sorriu para mim.
<p>- Eu imagino. – Will franziu a testa. Não conseguia imaginar aquilo.
<p>- Desde quando estão juntos? – Sebastian estava bem desconfortável.
<p>- Desde ontem à noite, na verdade. – Jason brincou e Quinn respondeu a brincadeira com um sorriso. 
<p>- Que ótimo. – Amanda comentou. 
<p>- Nossa, eu nunca quis cortar um bolo como eu quero agora. – Will tentou sair do campo minado que estava aquele jantar.
<p>- Eu não sabia que vocês eram tão íntimos. – Amanda ignorou Will e olhou brava para Quinn se sentindo traída.
<p>- Na verdade, não éramos. – Quinn respondeu. – Mas estávamos conversando ontem e nos entendemos muito bem. 
<p>- Ah, que legal. Eu não sabia que o Jason beijava uma garota e depois ficava com outra. Acho que ele aprendeu isso com o Will. – Amanda estava vermelha.
<p>- O quê? – Will se manifestou. – Me deixa fora dessa.
<p>- Me desculpa, eu não sabia que vocês tinham alguma coisa. – Quinn voltou a falar.
<p>- Não temos nada. – Amanda ficou séria.
<p>- Então qual é o problema? Nós dois estamos livres. 
<p>Emily colocou a mão no rosto. Era um sinal de que aquele jantar de aniversário já estava indo para o fundo do poço. 
<p>- Que bom que vocês dois estão livres. – Sebastian entrou na conversa também bastante afetado. 
<p>Quinn o ignorou.
<p>- O bolo deve estar bom. Que tal a gente...
<p>- Cadê seus pais, Jason? – Harry olhou para Jason.
<p>- Minha mãe está trabalhando hoje. Eu não tenho pai. – Jason respondeu.
<p>- Sua mãe não te ensinou a ser educado e ir falar com os pais da garota que você quer namorar?
<p>- Ah, eu... – Jason ficou envergonhado. 
<p>- Pai, não estamos namorando. – Quinn falou logo. – Só estamos saindo.
<p>- Filha minha não faz isso. 
<p>- Ah, é. Eu esqueci o quão importante é um compromisso. – Quinn continuou falando mesmo depois de levar beliscos no braço da irmã. – Aparentemente, ele só não é importante para você. Caso alguém aqui não saiba, meu pai traiu a minha mãe. – Ela sorriu.
<p>A primeira pessoa para quem Harry olhou foi Will. Os olhares se cruzaram por um tempo e então Will disfarçou e olhou para o outro lado. 
<p>- Acho melhor irmos embora. – Harry se levantou. 
<p>Karen e Robert abriram a boca para falar algo, mas preferiram ficar quietos. O jantar já não estava muito bom para insistir que os convidados ficassem para a sobremesa. 
<p>- Vamos. – Harry chamou sua família e só Patrícia se levantou.
<p>- Eu vou ficar. – Emily falou encarando o pai.
<p>- Eu a levo para casa depois, senhor. – Will comentou.
<p>- Vou ficar também. – Quinn não encarou o pai, parecia até que ela estava com medo. Segurou bem forte a mão da irmã. – Eu sinto muito. – Ela falou baixo para Emily assim que seus pais se levantaram e foram embora.
<p>- Tudo bem. – Emily respondeu no mesmo tom. 
<p>- Seu pai é interessante, Emily. – Giovanna sorriu como se Emily fosse a melhor amiga dela. Amanda revirou os olhos.
<p>- É, meu pai é interessante mesmo. Minha irmã é maluca e o meu namorado tem uma ex que não sai do pé dele. Minha vida nem parece com uma novela. – Emily encarou Giovanna.
<p>- Ah, eu estava passando por umas coisas... – Giovanna tentou se explicar.
<p>- Não precisa se explicar. – Emily se levantou da mesa e foi em direção a cozinha.
<p>- Me desculpe. – Giovanna olhou para Will.
<p>- Bom, vamos comer o bolo? – Robert olhou para o filho pedindo socorro. 
<p>- Estou sem fome. – Amanda se levantou da mesa também e subiu as escadas para o quarto.
<p>- Eu também. – Sebastian se levantou logo após, mas saiu de casa ao invés de ir para o quarto.
<p>- O que está acontecendo aqui? – Chris ficou com um ponto de interrogação na cara tentando entender todo aquele jantar.
<p>- Eu também não estou entendendo nada. – Karen respondeu. 
<p>- Aparentemente, dois idiotas estão fazendo ciúmes para outros dois idiotas. – Will olhou para Jason e Quinn. – Já eu, vou pegar um pedaço de bolo e ir atrás da Emily.</p>
<center><h4>--*--</h4></center>
<p>- Amanda, abra a porta. Vamos conversar. – Jason estava apoiado na porta do quarto de Amanda batendo bem devagarzinho com o nó de um dos dedos.
<p>- O que você quer? – Ela abriu a porta tão rápido que Jason até se assustou.
<p>- Me desculpa.
<p>- Não precisa. Formam um lindo casal.
<p>- Sabe que não estamos juntos de verdade. – Jason respirou fundo. – Queria saber se você gostava mesmo de mim e quando a Quinn e eu pensamos nisso, parecia uma boa ideia. 
<p>- Queria saber se eu gostava de você? Você me beijou e eu retribui.
<p>- E me ignorou por uma semana. Fingiu que nada aconteceu. Eu nem contei para ninguém porque eu comecei a achar que era um sonho. – Jason a encarou. – Te mandei uma mensagem ontem e você...
<p>- Você me mandou um “oi”. Eu te respondi com outro “oi”.
<p>- Olha, eu sou um idiota, tá bom? Eu não sei como fazer isso. 
<p>- Eu também não. Caso você não tenha notado, eu também não costumo namorar.
<p>- Eu quero ficar com você. – Jason foi direto ao assunto. – Só isso que eu quero. Sem joguinhos e bobagens. 
<p>- Respira fundo que passa.
<p>- Não passa e eu também não quero que passe.
<p>Então ela o beijou. 
<p>- Eu esperei muito que dissesse isso, sabia? – Amanda falou ainda com o rosto milímetros de distância do dele.
<p>- Sim, me desculpe.
<p>- Não quero que se desculpe.
<p>- O que você quer então?
<p>- Eu quero você. – E voltou a beijá-lo.</p>
<center><h4>--*--</h4></center>
<p>- Me desculpa, tá bom? – Quinn seguiu Sebastian pela rua, até ele parar e se virar para falar com ela.
<p>- Por ficar com o meu melhor amigo?
<p>- Não estamos juntos. Ele precisa de ajuda e eu também. Foi o plano perfeito.
<p>- Plano perfeito? Como? – Sebastian não entendeu.
<p>- Eu não sei quando parar, tá bom? Você viu o que eu disse do meu pai.
<p>- O que está acontecendo?
<p>- Eu é que te pergunto. Ficou com ciúmes do Jason?
<p>- É claro que eu fiquei. Você me beijou depois do baile e...
<p>- E o quê? Eu dei o primeiro passo. O que você fez depois?
<p>- Eu... – Sebastian ficou sem jeito de respondeu.
<p>- Eu te digo. Por uma semana toda, você me evitou na escola. Acha que eu não percebi? E não respondeu as minhas mensagens. Já estava achando que eu estava agindo feito louca em cima de você.
<p>- Eu sinto muito.
<p>- Eu não faço isso. Tá bom? Os caras ficam atrás de mim, não o contrário. Mas você é tão... – Ela não sabia mais o que dizer.
<p>- Você já pensou em tudo? Porque eu já. Primeiro, seu pai nunca me aceitaria.
<p>- Ele não aceita ninguém, isso não é um problema. 
<p>- Mas eu...
<p>- É você que não se aceita.
<p>- Eu não quero que você fique comigo. É um peso enorme para se carregar.
<p>- Eu queria que você me deixasse decidir, mas parece que você nunca vai ceder.
<p>- Parece que não.
<p>- Que ótimo.
<p>- Quinn, eu queria muito que a gente fosse amigo.
<p>- Eu não preciso de amigos, Sebastian. – Ela falou logo. 
<p>- Eu sinto muito. – Ele repetiu.
<p>- Não precisa. – Ela saiu da frente dele e foi embora.</p>
<center><h4>--*--</h4></center>
<p>- Me desculpe. – Emily falou logo que viu Will entrando na cozinha com um prato de bolo na mão.
<p>- Pelo quê? Você não fez nada.
<p>- Por isso tudo. Eu não devia ter falado daquele jeito com a Giovanna. Na verdade, eu só descontei nela a raiva que eu estava sentindo do meu pai.
<p>- Ele sabe ser um pé no saco, não é? – Will riu.
<p>- É. – Ela riu junto. – Mas eu confesso que vai ser difícil ver essa garota aqui o tempo todo.
<p>- Não precisamos ficar aqui. Podemos começar a morar em acampamentos ou talvez eu compra um trailer.
<p>- Você é muito bobo, sabia? – Ela continuou sorrindo.
<p>- Eu sou, não é?
<p>- Acha mesmo que ela está interessada no Kevin ou é só mais uma maneira de tentar te atingir?
<p>- Pode ser e pode não ser. Só vamos saber com o tempo. E mesmo assim não importa.
<p>- Por que não?
<p>- A única que me atinge aqui é você. E me atinge forte.
<p>- Você sempre sabe o que dizer. 
<p>- Sabe, esse aniversário não foi tão ruim.
<p>- Você está brincando? Até eu peguei trauma de aniversários depois disso. Foi um drama atrás do outro. 
<p>- E nenhum foi nosso. Só nos metemos no dos outros. 
<p>- É, pode ser. 
<p>- Acho que podemos fazer mais uma coisa para fechar meu aniversário com chave de ouro. 
<p>- O que tem em mente?</p>
<center><h4>--*--</h4></center>
<p>Ninguém entendeu nada quando Will saiu da cozinha mandando todo mundo se levantar da mesa e dizendo que precisavam sair. Ele gritou Amanda e Jason e mandou mensagem para Sebastian e Quinn.
<p>Já estava anoitecendo quando todo mundo chegou no hospital. Parecia uma marcha para alguma coisa quando os enfermeiros olharam para a família se aproximando pela porta de vidro na entrada. 
<p>Angie já estava esperando por Will na ala infantil com um enorme violão nas mãos que ela mal conseguia segurar sozinha, mas estava muito animada e com um grande sorriso. 
<p>Eles foram até o salão principal onde havia algumas pessoas. Como da primeira vez que fez isso, Will se sentou em um banquinho e apoiou o violão no seu colo. As outras pessoas puxaram banquinhos também para perto formando uma roda. Algumas crianças se sentaram no chão, enquanto alguns médicos e enfermeiros olhavam um pouco distantes.
<p>Com Emily de um lado, Angie do outro, e sua família toda espalhada ao redor dele e o encarando, Will começou a cantar. 
<p>- <i>Mais um dia que vamos passar juntos. Deixe seus olhos procurarem o melhor de mim. Oh, eu sei que estou mal por causa do clima. Mas, meu amor, eu não vou desistir.</i>
<p>Ele olhava fixamente para seu violão. Emily colocou a mão em seu ombro e começou cantar baixinho junto com ele.
<p>- <i>Passo meus dias amaldiçoando a minha alma. Desejando poder pintar minhas cicatrizes e me tornar inteiro. Oh, eu sei que eu poderia ser melhor. Mas, meu amor, eu não vou desistir.</i>
<p>Will olhou para frente. Jason olhava para ele com uma expressão de orgulho enquanto segurava a mão de Amanda. Sebastian sorria para ele e o mesmo fazia Chris. Seus pais olhavam para ele sem nem ao menos piscar.
<p>- <i>Eu não sou nenhum Super-homem, nem um Espírito Santo. Sou só aquele que te deixa acordada à noite, o que você mais ama. Eu serei o seu homem forte, serei sua Costa Oeste. Vou ser o sol, vou ser as ondas, vou ser aquele que você mais ama... Oh, ei, ei, ei, oh.. Eu serei, eu serei, serei, serei. Eu serei sua Costa Oeste, amor...</i>
<p>Então todos começaram a cantar junto com ele.
<p>- <i>Oh, ei, ei, ei...</i>
<p>- <i>Oh...</i>
<p>- <i>Ei, ei, ei, ei, ei, ei, ei...</i>
<p>- <i>Eu serei, eu serei, serei, serei. Eu serei sua Costa Oeste, amor...</i>
<br>
<p>“Como eu disse, eu nunca fui muito fã de aniversários. Mas isso estava prestes a mudar e eu gostava disso. Gostava muito.”.</p>
</body>
</html>";
            }

            if (numero == 21)
            {
                lblTitulo.Text = "Capítulo 21 - Por Toda A Noite";
                htmlPage.Html = @"<html><body>
<p><i>“Não temos passado, não vamos voltar atrás
<br>Vamos aguentar juntos por toda a noite
<br>E assim que começarmos, o cronômetro vai disparar
<br>E continuará por toda a noite
<br>Não vai terminar até chegar ao fim”
<br><b>All Through The Night – Cindy Lauper</b></i></p>
<br>
<p>Will abordou Emily em um dos corredores da escola logo de manhã naquele dia. Estava eufórico demais até para ele, pensou a namorada. 
<p>- Eu tive uma grande ideia. 
<p>- E isso é bom? – Ela pareceu um pouco desconfiada. 
<p>- Depois do fiasco que foi o meu aniversário mês passado, eu tive uma grande ideia para resolver tudo.
<p>- Tudo o que exatamente? Além do mais, pode resolver tudo isso não deixando mais a sua namorada fazer festas para você. – Emily sorriu sendo irônica. 
<p>- Não, eu acho que ela já se sente culpada o suficiente e não vai mais querer fazer surpresas. 
<p>- Tudo bem, qual é a ideia?
<p>- Vamos todos acampar no final de semana. – Ele voltou a ficar eufórico.
<p>- Defina “acampar” e “todos” quem? – Ela não demonstrou tanta animação quanto Will esperava. Na verdade, Emily ficou o oposto de eufórica. 
<p>- Acampar. Você é do interior, achei que acampava o tempo todo.
<p>- Somos uma família diferente. 
<p>- Ah, qual é? Vai ser divertido. Meu pai levava a gente para acampar o tempo todo quando éramos crianças.
<p>- Meus pais nunca vão deixar eu ir acampar com você sozinha. Eu vou ter que levar a Quinn e...
<p>- Isso, você vai ter que levar a Quinn. – Aquela informação não deixou Will nenhum pouco decepcionado.
<p>- O quê? – Emily ficou confusa.
<p>- E eu levo o Sebastian.
<p>- A última pessoa que a Quinn quer ver agora é o seu irmão. Eles não se falam desde o seu aniversário.
<p>- Por isso mesmo. Eu vou dar um jeito nisso.
<p>- Will, bancar o cupido nunca acaba bem.
<p>- Eu não vou bancar o cupido. Eu só vou deixar os dois juntos em um mesmo lugar. 
<p>- Eles não são animais. Você não pode colocar os dois em um lugar e esperar que cruzem. 
<p>- Olha só, não vamos só nós quatro. Vamos levar o casal novo, Amanda e Jason, meus irmãos, as namoradas deles...
<p>- Quer levar o Kevin e a Giovanna também? – Emily olhou para Will como se não acreditasse no que estava ouvindo.
<p>- Eles precisam ir, assim acaba o clima estranho também. Vamos resolver tudo em uma noite só, não vai ser incrível?
<p>- “Incrível” não é bem a palavra que eu usaria. 
<p>- Seria melhor se você me apoiasse. 
<p>- Me desculpa, mas essa é a pior ideia que você já teve. Nada de bom acontece se você forçar as coisas.
<p>- Eu não vou forçar, vai acontecer naturalmente.
<p>- Você vai colocar dez pessoas juntas no meio do nada, para mim isso parece forçar.
<p>- Você sabe ser estraga-prazeres, não é? Precisa me ajudar.
<p>- Se eu não aceitar, você vai me irritar até eu dizer que sim, não vai?
<p>- Ems, você me conhece tão bem. – Will a beijou e depois se despediu. – Fala com a sua irmã que eu falo com o resto do pessoal.
<p>- Se é o que quer.
<p>- E se anima um pouco.
<p>- Não força a barra.
<p>- Sim, senhora. – Ele sorriu.</p>
<center><h4>--*--</h4></center>
<p>Em menos de meia hora, Will já tinha falado com todo mundo. Amanda e Jason concordaram imediatamente, o humor dos dois havia melhorado muito desde que começaram a namorar e Jason adorava acampar. Sebastian ficou um pouco relutante quando soube que Quinn poderia ir também, mas o irmão conseguiu convencê-lo. Chris seria um problema, mas Will resolveu atacar o outro lado da equação, Ashley. Ela concordou quando viu ele todo animado e disse que convenceria Chris. Kevin foi fácil de convencer também e ele concordou em falar com Giovanna.
<p>- Fez seu trabalho? – Will estava esperando por Emily do lado de fora da sala quando a aula dela acabou.
<p>- Meu trabalho de biologia é só para semana que vem. – Emily gostou de ele estar preocupado com os deveres escolares dela.
<p>- Estou falando do nosso trabalho.
<p>- Temos um trabalho juntos? Mas nem estamos no mesmo ano.
<p>- Eu quis dizer do acampamento. 
<p>- Então você estava falando sério? – Emily demonstrou decepção.
<p>- Ems...
<p>- Calma, eu estou brincando. – Ela gargalhou um pouco, mas ainda não estava muito animada. – Eu falei com a Quinn e ela aceitou.
<p>- É sério? Como conseguiu? Tive que fazer mil promessas para o Seb aceitar.
<p>- Eu falei que você estava me chateando. Ela ficou com pena de mim. 
<p>- Muito engraçado. – Will fingiu um riso. – Agora vai parecer que estamos em um relacionamento abusivo.
<p>- E estamos. Eu abuso de você. – Ela riu.
<p>- Que tal a gente se trancar em alguma sala de aula vazia e você abusar um pouco mais de mim? – Will agarrou a namorada pela cintura.
<p>- Cala a boca. – Ela o beijou.</p>
<center><h4>--*--</h4></center>
<p>Will havia pensando em tudo. No horário, no lugar em que iriam ficar, já havia feito a mala e conferido todos os itens que precisaria levar para o acampamento. Mas no fim da tarde, se lembrou que faltava uma coisa, o transporte. Ele precisava de uma van, a van que seu pai amava tanto.
<p>- Ah, pai, por favor. 
<p>- Eu já disse que não. 
<p>Will sabia que seu pai diria aquilo, mas não custava tentar.
<p>- Eu posso levar vocês.
<p>- Não tem graça assim. Já somos bem crescidinhos.
<p>- Não são maiores de idade. 
<p>- Eu tenho dezoito. 
<p>- E ainda é o mais imaturo. – Seu pai não tinha dúvidas.
<p>- O Sebastian tem... – Will pensou em usar seu irmão mais velho como opção, mas sabia que também não ia funcionar. – Vai ser só por uma noite. Não vai acontecer nada.
<p>- Não.
<p>- Você sempre regula as coisas para mim. Se fosse o Chris, você emprestava. 
<p>- Por que será?
<p>- Porque ele é um tédio e anda a trinta por hora.
<p>- Não está ajudando.
<p>- Eu prometo tomar cuidado. 
<p>- Bom... – Robert respirou fundo. – Se eu deixar, você me promete ter juízo e me ligar quando chegarem lá?
<p>- Eu prometo. 
<p>- Você é um pé no saco, sabia?
<p>- Aprendi com o meu pai. – Will brincou.
<p>- Cuidado, garoto.</p> 
<center><h4>--*--</h4></center>
<p>O caminho era longo. A van era bem grande, logo nenhum dos passageiros estava se sentindo desconfortável. Quinn se sentou ao lado de Amanda e Jason e evitava olhar para Sebastian. Amanda dava olhadas maldosas para Giovanna de vez em quando. 
<p>Emily ainda não aprovava a ideia, mas já tinha se conformado. Ela estava com um sorriso bem grande sentada ao lado de Will, no banco do passageiro.
<p>- Quem está animado?! – Will gritou tentando animar a galera silenciosa. 
<p>- Vou estar mais animada amanhã quando voltarmos para casa. – Quinn falou emburrada.
<p>- Ah, eu estou muito animada. – Amanda falou. – Mal comecei a namorar e já estou indo me esconder no mato com ele. – Ela sorriu para Jason e ele retribuiu.
<p>- Seu irmão mais velho ainda está te vigiando. – Will gritou e todos começaram a rir. 
<p>Quando anoiteceu, a estrada começou a ficar escura e solitária. Estavam cercados por mato.
<p>- Droga, eu perdi a última saída. – Will falou baixinho. 
<p>- O quê? – Emily fingiu não ouvir.
<p>- Nada. – Will disfarçou.
<p>- Estamos perdidos? Will? – Emily quase gritou.
<p>- Não estamos perdidos. Só não chegamos ainda. 
<p>- E onde estamos então? – Emily encarava o namorado.
<p>- Na estrada perto de onde deveríamos estar. Eu só preciso fazer um retorno. – Will olhava fixamente para a estrada.
<p>- E cadê o retorno? 
<p>- O que está acontecendo? – Sebastian falou atrás de Will. 
<p>- Nada. – Will respondeu.
<p>- Estamos perdidos. – Emily falou.
<p>- Não estamos perdidos. Só vamos demorar mais para chegar. – Will quase gritou. Ele já estava ficando irritado. – Eu sei para onde estamos indo.
<p>Alguns minutos se passaram com o carro andando em linha reta. Então, de repente, ele começou a andar mais devagar até parar por completo no meio da estrada. 
<p>- Por que estamos parando? – Chris perguntou olhando pela janela. – Já chegamos?
<p>- Pode ser que, de repente... existe uma possibilidade... – Will olhou para o painel da van.
<p>- Will! – Amanda gritou.
<p>- Eu esqueci de abastecer.
<p>- Como é que é? – Emily entrou em choque.
<p>Todo mundo saiu do carro enquanto Will olhava fixamente para o painel. Não dava para ver absolutamente nada lá fora. A estrada não era iluminada, havia mato por toda parte e não passava nenhum outro carro por ali. 
<p>Os irmãos ajudaram Will a empurrar o carro para o acostamento.
<p>- O que a gente faz agora? – Ashley se desesperou segurando bem forte o braço de Chris.
<p>- Eu vou ligar para o meu pai. – Emily pegou o celular do bolso.
<p>- Claro, vamos dar mais uma oportunidade para ele me criticar. – Will olhou feio para Emily. 
<p>- Então liga para o seu. – Ela reclamou.
<p>- Não posso, prometi a ele que faria tudo certo e seria responsável.
<p>- Parece que você não se saiu muito bem, não é? Que novidade. – Chris resmungou. – Eu vou ligar para o papai.
<p>Chris olhou para a tela do seu celular e ficou decepcionado. 
<p>- Está sem sinal. – Ele avisou.
<p>Todos pegaram os celulares dos bolsos e começaram a verificar. Estavam sem sinal também.
<p>- Gente, relaxa. – Will tentou conter o pânico que estava chegando. – Eu vi um posto alguns quilômetros atrás. Amanhã de manhã, eu vou até lá e busco um pouco de gasolina para gente voltar.
<p>- E vamos acampar no meio da rua? – Chris continuou reclamando.
<p>- Isso, arma sua barraca lá. Vou ficar com a câmera ligada esperando um carro te atropelar. – Will rebateu a implicância do irmão.
<p>- Gente, brigar não adianta nada. – Quinn se posicionou. – O jeito é todo mundo se sentar no canto da estrada e esperar. – Ela pediu para Will abrir o porta-malas. Assim que ele abriu, ela pegou sua mala, a abriu, tirou uma manta de dentro, jogou no chão e se sentou.
<p>- Eu só queria que passasse um carro e que conseguíssemos uma carona. – Sebastian olhava para todos os lados esperançoso.
<p>- Somos muitos. Nenhum carro pararia. Não seria inteligente. – Will avisou.
<p>- Eu estou com muito frio. – Foi a primeira vez que Giovanna falou naquela noite.
<p>- A gente pode tentar acender uma fogueira aqui. Tem álcool no porta-malas. – Jason sugeriu.
<p>Com o tempo, todo mundo se rendeu e começou a se sentar no chão também. Jason e Will juntaram alguns gravetos e fizeram a fogueira. O silêncio tomou conta e tudo o que se ouvia era o crepitar das chamas.
<p>- Vocês são a melhor turma de acampamento do mundo. – Will queria tirar o melhor daquela situação. – Qual é? Temos comida no carro e... vamos falar sobre alguma coisa.
<p>- Tipo o quanto você é idiota? – Chris ainda estava olhando para o celular esperando por uma barra de sinal. – Isso nunca teria acontecido se eu estivesse na liderança.
<p>- Me desculpa, Senhor Eu-Cuido-De-Tudo-E-Sou-Perfeito. Na próxima, você faz isso.
<p>- Não vai ter próxima. Além do mais, eu nunca teria uma ideia idiota como essa. – Chris bufava de raiva.
<p>- Gente, calma. – Amanda sempre tentava apaziguar quando Chris e Will começavam a discutir.
<p>- Eu sabia que ia dar alguma coisa errada. – Chris resmungou.
<p>- Então por que veio? – Will o encarou.
<p>- Porque alguém teria que estar aqui para arrumar a sua merda.
<p>- É, você fez muita coisa sentado aí. – Will se levantou e se afastou do grupo antes que seu instinto forçasse ele a dar um soco no irmão. 
<p>- Para onde você vai? – Emily se levantou e foi atrás dele.
<p>- Eu vou atrás de um posto de gasolina.
<p>- Eu vou com você.
<p>- Não precisa. É melhor você ficar aqui. Não é muito seguro andar por aí sozinho a essa hora.
<p>- Agora que eu quero ir com você. Não pode ir sozinho.
<p>- Não se preocupe. – Will não queria descontar sua raiva na namorada.
<p>- Will!
<p>Jason, percebendo que Will e Emily iam começar uma discussão, se levantou.
<p>- Emily, eu vou com ele.
<p>- Eu já disse que não precisa. – Will olhou feio para o amigo. 
<p>- Eu não estou nem aí. – Jason respondeu.</p>
<center><h4>--*--</h4></center>
<p>- Essa ideia do Will foi ridícula. Era óbvio que alguma coisa ia dar errado. Ele não sabe fazer nada direito. – Chris ficou bem falante depois que Will e Jason se despediram do grupo e foram atrás de um posto de gasolina. Era nítido o tom depreciativo na voz dele e o quanto se divertia em falar aquelas coisas, embora estivesse irritado também. – Às vezes dá vontade de rir da cara dele.
<p>- Acho que o ridículo aqui é você. – Emily falou. 
<p>- Vai defender ele? É sério? Depois disso tudo? 
<p>- É engraçado. Desde que saímos do carro, tudo o que você fez foi reclamar. Se acha o melhor, mas eu não estou vendo você tentando fazer alguma coisa para resolver a situação. – Ela continuou.
<p>- Olha...
<p>- Até a fogueira você ficou olhando alguém fazer para você. – Emily olhou irritada para ele.
<p>- O que quer que eu faça? – Chris fez pouco caso.
<p>- Agora? Eu quero que cale a boca.
<p>- Ei, não fala assim com o meu namorado. – Ashley reclamou. 
<p>- Eu posso me defender sozinho. – Chris retrucou com a namorada e ela também demonstrou chateação.
<p>Emily abriu a boca para falar alguma coisa, mas desistiu no meio do caminho, preferiu não gastar a saliva. Ao invés disso, ela se levantou e entrou no carro. 
<p>- O gênio da minha irmã não é um dos melhores. – Quinn sorriu para Chris e Ashley. – Principalmente com quem ela não gosta. Ela só tem carinha de anjo. 
<p>- Que se dane. – Chris falou baixinho.</p>
<center><h4>--*--</h4></center>
<p>- Eu odeio o Chris. – Will estava andando tão rápido que Jason mal conseguia acompanhar seus passos sem correr um pouco em alguns momentos.
<p>- Não odeia nada. Só está com raiva.
<p>- Eu odeio sim. Eu queria pegar a boca dele e socar ela até ficar sem nenhum dente. – Will fez os gestos dos socos com a mão.
<p>- Sabe que a sua mão também não ia ficar muito boa depois disso, não sabe?
<p>- Eu não estou nem aí. – Ele então respirou fundo para ficar mais calmo. – É um implicante idiota.
<p>- Ele só se acha o melhor e você odeia isso.
<p>- Exatamente. Eu sou o mais velho, eu deveria ser o melhor e não ele. 
<p>- Você realmente acha que ele é melhor que você?
<p>- Não só eu. Até meu pai acha.
<p>- Mas...
<p>- Tem todas aquelas notas impecáveis e provavelmente bolsas e bolsas de estudos no futuro. Ele só faz as coisas corretas e boas... É cansativo olhar para ele. 
<p>- Acha que por isso ele é algum parâmetro de qualidade? – Jason tentava entender a situação.
<p>- Como assim?
<p>- Will, eu não estou dizendo que você é o melhor, mas é você que está indo até o posto de gasolina.
<p>- É diferente. Eu estraguei tudo, então é a minha obrigação arrumar.
<p>- Sim, mas tudo o que ele fez foi te julgar. Literalmente foi a única coisa que ele fez. 
<p>- O quê?
<p>- Ele não é o melhor, só é o mais chato. E quanto as notas e bolsas de estudos... você não liga para isso. Nem faculdade você quer fazer. 
<p>- Esse é o ponto. Até rumo na vida ele tem e eu não. 
<p>- Você precisa parar. – Jason balançou a cabeça negativamente.
<p>- Parar de fazer o quê?
<p>- Seu irmão não é perfeito. Precisa parar de tentar se comparar com ele ou tentar ser melhor que ele. Você é você e ele é ele. Só isso. 
<p>- Não se trata só disso. Eu realmente queria que a gente se desse bem. 
<p>- Ah, qual é? Queria uma amizade com ele? Vocês não têm praticamente nada em comum.  
<p>- Nem a gente. – Will encarou o amigo.
<p>- É diferente. 
<p>- Não deveria. Na verdade, deveria ser mais fácil, ele é família. 
<p>- Isso não quer dizer nada. Você já me disse isso. – Jason colocou suas mãos nos ombros de Will e o olhou firmemente. – Existe a família de sangue e a que você escolhe e as duas podem te amar ou te decepcionar. Nenhuma é melhor que a outra. Sangue não quer dizer nada, não nesse caso. 
<p>- Mas...
<p>- Eu não estou dizendo que você tem que parar de tentar com o seu irmão, eu só estou dizendo que tudo bem deixar para lá às vezes. 
<p>- Tem razão. Ele come pizza com ketchup, como eu vou conseguir ser amigo de alguém que gosta disso? – Will começou a rir. Era tipo um aviso para Jason de que ele já fez o seu trabalho e que agora estava tudo bem.</p>
<center><h4>--*--</h4></center>
<p>- Não precisava falar assim com o meu irmão.
<p>Emily se assustou quando ouviu a voz de Amanda do seu lado no banco do passageiro. Estava tão concentrada nos seus pensamentos olhando para o para-brisas que nem percebeu quando ela entrou no carro. 
<p>- O que você tem a ver com isso? – Emily retrucou.
<p>- Você está bem?
<p>- Desde quando você se interessa? – Emily estava disposta a extravasar toda a sua raiva de uma vez só. – Afinal qual é o seu problema comigo?
<p>- O quê? Eu não tenho problema com você. – Amanda ficou confusa.
<p>- Ah é? Não é o que parece. Desde que nos conhecemos, você faz questão o tempo todo de dizer que não somos amigas. 
<p>- E não somos. 
<p>- Então o que faz aqui? 
<p>- Talvez porque eu deteste menos você do que a Ashley e a Giovanna. 
<p>- Obrigada. – Emily usou seu sarcasmo. – Sabe, pode parecer criancice, mas quando eu comecei a namorar o Will, eu... imaginei que seriamos amigas. 
<p>- É sério?
<p>- Eu não tenho muitos amigos. Na verdade, não tenho nenhum além da minha irmã. Essa coisa de amizade nunca foi fácil para mim. 
<p>- Eu te entendo. – Amanda mexeu seus lábios e se formou um sorriso disfarçado. – Eu queria ser a sua amiga... quando começou a namorar o Will. Acontece que eu também não sou muito boa nisso. 
<p>- É sério?
<p>- Meu irmão fala tão bem de você. Alguma coisa deve ser verdade e não exagero.
<p>- Vou encarar isso como um elogio. – Emily riu. – O que estamos fazendo então? Podemos ser amigas. 
<p>- Ou só não colegas.
<p>- É um progresso. – Emily preferiu não discutir sobre isso.
<p>- É sim. – Dessa vez, Amanda deixou mostrar seu pequeno sorriso.
<p>As duas ouviram uma das portas de trás se abrir. Logo em seguida, pelo retrovisor, viram o rosto de Giovanna aparecendo atrás delas.
<p>- Oi. Vocês estão bem? – Giovanna sorriu.
<p>- Estávamos, né. – Amanda revirou os olhos para o reflexo de Giovanna do retrovisor. 
<p>- Emily, podemos conversar? – Giovanna ignorou o comentário de Amanda e se dirigiu a outra. 
<p>- Sobre o quê? – Emily perguntou por perguntar. Nem demostrou que estava interessada.
<p>- Queria me desculpar. – O tom de voz de Giovanna era o mais doce possível. 
<p>- Tudo bem.
<p>- E queria que você falasse com o Will por mim. Eu não queria que houvesse mágoas entre a gente.
<p>- Fale você com ele, não sou seu correio. 
<p>- Você não se importa?
<p>- Por que eu me importaria? – Emily virou o rosto para olhar para Giovanna que continuava sorrindo.
<p>- Eu sou ex dele. Você não sente ciúmes de mim?
<p>- Eu sinto pena de você.
<p>Amanda não fez questão de esconder o riso pelo comentário de Emily.
<p>- Você sabe que ele só terminou comigo porque estava esperando alguma vadia como você aparecer, não sabe? – Giovanna continuava com seu tom doce.
<p>- Engraçado, eu achava que ele tinha terminado porque você é chata, paranoica e vivia dando ataques desnecessários. – Emily voltou a olhar para frente. – Mas o que é que eu sei, não é verdade?
<p>- Nada. Você não sabe de nada. Você sabia que ela já ficou com uma garota que...
<p>- Olha, se eu quiser saber alguma coisa do Will, eu pergunto para ele. – Emily cortou o papo.
<p>- Isso não vai durar. – Giovanna colocou a cabeça no meio dos dois bancos da frente e encarou Emily. – Vai acabar logo.
<p>- E quando acabar, acha que ele vai voltar para você?
<p>- Ele já voltou ou esqueceu do episodio do quarto dele que você está fingindo que não existiu?
<p>- O que você quer com o Kevin? – Emily a encarou. – Se está usando ele para tentar atingir alguém, desiste. Está fazendo papel boba e ainda iludindo um garoto que não merece.
<p>- Mas eu gosto do Kevin. Eu não posso ficar com os dois irmãos?
<p>- Você é uma vadia. – Amanda finalmente falou. – Eu tenho é dó de quem se envolver com você. Eu tenho dó do Kevin. 
<p>- Ah, Mandy... – Giovanna tirou sua atenção de Emily. – Não tem medo da Ashley tirar o Jason de você também? Ela já quase conseguiu e sabe que o Chris não liga.
<p>- Sai daqui. – Emily não gritou, mas manteve a voz firme. – Sai daqui antes que eu mesma te tire.
<p>- Está me ameaçando?
<p>- Não. Só estou dizendo que posso tirar se eu quiser. 
<p>Giovanna abriu a boca e fez uma expressão de indignação. Mas ainda calada, se retirou do carro. Seu show já havia acabado.
<p>- Como alguém consegue se rebaixar tanto assim?
<p>Amanda ouviu a pergunta de Emily, mas nem conseguiu responder. Nem ela mesma sabia aquela resposta.</p>
<center><h4>--*--</h4></center>
<p>- Por que você me trouxe para cá?
<p>Sebastian chamou Quinn para dar uma volta depois da “briga” entre Emily e Chris. Mesmo com raiva dele, ela não pensou duas vezes e aceitou. No passeio, os dois entraram um pouco na mata para se afastarem dos outros. 
<p>- Achei que você ia acabar batendo no Chris se ele falasse mais alguma coisa inapropriada. – Sebastian quase gaguejou. 
<p>- Não ia matar seu irmão. Pode ficar sossegado. Já você...
<p>- O que tem eu?
<p>- Me conduziu para o meio do mato. Talvez você queira me matar.
<p>- Minha proposta ainda está de pé. Quero ser seu amigo.
<p>- Eu sei.
<p>- Quinn...
<p>- Eu sei que você gosta de mim. Seria tão mais fácil se você simplesmente não gostasse, mas eu vejo. Está no seu rosto, agora mesmo. – Ela olhou para ele.
<p>- Eu estou te protegendo. 
<p>- Eu não preciso de proteção. Eu sou bem grandinha. – Ela sorriu. 
<p>- E doida.
<p>- Eu não gosto de me arrepender. Não gosto de pensar em como poderia ter sido. Eu... – Ela se aproximou um pouco dele. – Eu estou triste pela nossa última conversa e com raiva... Eu vou superar e eu vou me interessar por outro, meu mundo não vai acabar.
<p>- Onde quer chegar com isso?
<p>- Eu queria pelo menos ter uma chance, de dizer que fizemos tudo. Que funcionou independentemente do tempo que a gente ficou junto. Você não imagina a gente junto?
<p>- O tempo todo. – Sebastian se aproximou também, tornando a distância entre os dois quase nula.
<p>- Então para de fugir de mim. 
<p>Sebastian a beijou. 
<p>- Você me deixa louco. – Ele suspirou com os lábios ainda muito pertos dos dela.
<p>- Você me deixa louca também. – Ela também suspirou. – Eu queria muito que fizesse isso.
<p>- Eu sei. – Ele sorriu.
<p>Sebastian voltou a beijá-la com toda a vontade que ele tinha dentro de si e ela o retribuiu na mesma intensidade.</p>
<center><h4>--*--</h4></center>
<p>Quando Will e Jason voltaram para o grupo, Chris e Ashley já estavam quase deitados no saco de dormir que haviam trazido. A primeira coisa que Chris notou foi que a garrafa que estava na mão de Will continuava vazia.
<p>- Sabia que não encontraria gasolina. Está tarde. – Ele olhou com reprovação para Will.
<p>- Amanhã você vai e consegue, que tal? – Will o desafiou. – Cadê os outros?
<p>Kevin e Giovanna estavam deitados em outro saco de dormir ao lado do casal.
<p>- Amanda e Emily estão no carro. A Quinn e o Sebastian eu não sei. – Chris falou. 
<p>Jason foi em direção ao carro assim que ouviu Chris, mas Will não. Ele colocou a garrafa no chão ao lado do irmão, e em silêncio, foi para o meio do mato. 
<p>- Ainda bem que vocês chegaram. – Amanda fez uma cara de alivio quando viu Jason na porta do carro. – Conseguiram a gasolina?
<p>- Não. O posto estava fechado.
<p>- Então vamos ter que passar mesmo a noite aqui? – A expressão de alivio desapareceu.
<p>- Infelizmente sim. – Jason foi até a porta de trás e entrou no carro. 
<p>- Cadê o Will? – Emily olhou ao seu redor e não via sinal do namorado. 
<p>- Eu não sei, acho que deve ter ido atrás do Sebastian e da Quinn. – Jason respondeu.
<p>- Ou se castigar sozinho. – Emily bufou e saiu do carro irritada. 
<p>- Está tudo bem? – Jason perguntou para Amanda.
<p>- Ela bateu boca com o Chris por causa do Will e depois... a Giovanna tentou provocar ela de novo. – Amanda estava sem paciência para falar disso.
<p>- Essa garota não vai desistir.
<p>- Não, não vai. Mas eu não quero falar disso agora. – Amanda passou para o banco de trás para se sentar ao lado do namorado. – Você não vai terminar comigo, vai?
<p>- Por que está dizendo isso? – Jason achou estranho aquela pergunta.
<p>- Só me responde. 
<p>- Eu nunca vou terminar com você. – Jason a beijou.</p>
<center><h4>--*--</h4></center>
<p>- O que está fazendo aqui?
<p>Emily encontrou Will sentado em uma grande pedra no meio do mato. Ele estava de braços cruzados com fones no ouvido e olhando para o céu. 
<p>- Como me achou? – Will tirou um dos fones quando viu Emily na sua frente.
<p>- Deve ser o carma. – Ela sorriu.
<p>- Andar pelo mato a essa hora é perigoso. 
<p>- Eu não tenho medo.
<p>A pedra era grande o suficiente para os dois, então ela se sentou ao lado dele e pegou um dos fones.
<p>- O que está escutando e como você tem internet nesse fim de mundo?
<p>- Disponíveis off-line. – Ele sorriu.
<p>- Está tudo bem?
<p>- Não encontramos gasolina. A noite está sendo um desastre. 
<p>- Um desastre total. – Ela encostou sua cabeça no ombro dele. 
<p>- Eu sou horrível. 
<p>- Eu queria dizer que tudo isso não foi sua culpa, mas eu não posso. – Emily começou a rir.
<p>- Você é a minha namorada. Deveria me apoiar. – Will riu junto com ela.
<p>- Eu te apoio, tanto que estou aqui. Eu até briguei com o Chris depois que você saiu. 
<p>- Ah é? – Will arregalou os olhos de surpresa. 
<p>- Foi o melhor momento da minha noite.
<p>- Essa é a minha garota. – Ele apertou a mão dela. – Sabe, eu devia começar a te ouvir mais.
<p>- Continua. – Ela levantou uma das sobrancelhas.
<p>- Essa ideia foi uma droga, você tinha razão. Eu tenho que parar de fazer essas coisas. 
<p>- É, mas você nunca vai parar. Faz parte de quem você é. 
<p>- E é por isso que você me ama.
<p>- Não exatamente. Você tem umas qualidades melhores do que ser enxerido. 
<p>- Obrigado. – Ele riu.
<p>- Sabe, essa noite não foi toda perdida. Quinn me mandou uma mensagem e parece que ela se deu bem.
<p>- Ela e o Sebastian?
<p>- Sim.
<p>- Até que enfim. Uma coisa boa. 
<p>- Will...
<p>- Eu estava tão focado nessa ideia que eu... eu não parei para pensar na verdadeira relação que eu tenho com os meus irmãos. A verdade é que se eu brigar com a Giovanna, o amor que o Kevin sente por ela vai deixa-lo completamente louco e ele vai parar de falar comigo. Já o Chris... a gente brinca, conversa, cuida um do outro, mas sempre chega a hora que ele precisa mostrar que é melhor do que eu. 
<p>- Esquece isso. A família de ninguém é perfeita.
<p>- E eu tenho você.
<p>- Exatamente. Não precisa de mais ninguém. Seria muito feliz vivendo na bolha da Emily. – Ela sorriu.
<p>- Eu não tenho dúvidas disso.
<p>Os dois ficaram se olhando por alguns segundos e depois ele sorriu. Não precisaram dizer mais nada. Ficaram lá sentados, cada um com um fone no ouvido, olhando para o céu esperando que quando o dia amanhecesse, tudo melhorasse, ou que pelo menos não piorasse.</p>
<br>
<p>“Família. Um conceito simples. Somos ensinados de que a família deve ser o nosso bem mais importante. Mas o que é a família? Alguém do nosso mesmo sangue? Essa é a explicação para o que é família? Não.
<p>Eu acredito na família que eu escolho. 
<p>Você não pode ser obrigado a criar laços com quem só te atrasa. Às vezes tudo o que você precisa é se afastar para que a sua saúde mental possa agradecer. 
<p>Mas deixar uma pessoa ir não é tão fácil quanto deveria. A necessidade de precisar de alguém ao seu lado existe. E então a vida te surpreende e coloca no seu caminho aquela pessoa que de repente você não consegue viver sem e se pergunta como conseguiu viver até a esse ponto sem ela. Aquela pessoa que te entende e te aceita independente de qualquer coisa porque escolheu ser sua família. Essa pessoa pode ser um irmão, um amigo, o amor da sua vida. Não importa quem seja, só sei que essa pessoa vai fazer com que a sua vida valha a pena.”.</p>
</body></html>";
            }

            if (numero == 22)
            {
                lblTitulo.Text = "Capítulo 22 - Então é Natal";
                htmlPage.Html = @"<html><body>
<p><i>“Então é Natal
<br>E o que você fez?
<br>Um ano termina
<br>E começa outra vez”
<br><b>Happy Xmas – John Lennon</b></i></p>
<br>
<p>“O Natal sempre foi o melhor feriado para mim. Eu nunca fui o tipo de criança que acreditava em Papai Noel, mesmo assim, eu sentia aquela magia, aquela sensação diferente na data. Quando eu era criança, contava os dias para o Natal e dia 1 de dezembro já começava a minha festa, conforme eu cresci, isso acabou passando, mas meu amor pelo Natal não. Eu nunca nem fui religioso para dizer que estou comemorando o nascimento de Jesus. É, é uma loucura. 
<p>Outra coisa sobre o Natal: Eu sempre quis fazer parte daqueles festivais de Natal que todo cantor famoso vai.”.</p>
<br>
<p>Na família dos Jones, o Natal sempre era uma questão para comemorar. Os parentes todos se reuniam para realizar aquela grande ceia digna de novelas e desejavam “Feliz Natal” quando dava meia-noite. Karen adorava ver todo mundo junto e adorava também passar a véspera inteira na cozinha preparando todos os pratos tradicionais que ela conseguia encontrar no seu livro de receitas.
<p>Will tinha tudo para não estar animado com o Natal esse ano. Depois do fiasco que foi aquele fim de semana “acampando”, nada mais foi o mesmo. Chris fez questão de contar tudo para os pais e o irmão teve que ouvir sermões de quase três horas por um mês inteiro, os dois não se falavam direito desde então. Já Kevin estava um pouco estranho, ele parou de levar Giovanna para casa e mal almoçavam juntos com todo mundo na escola, mas isso não queria dizer que ela havia parado de persegui-lo ou de fazer comentários inapropriados nas raras vezes que todos estavam reunidos.
<p>Esquecendo os problemas com os seus irmãos, Will acordou bem cedo na véspera de Natal e com muito bom humor. Em Los Angeles não nevava com muita frequência, porém a temperatura estava muito baixa, principalmente por ser de manhã. Ele se vestiu bem depressa e saiu do quarto correndo.
<p>Sua mãe já estava acordada e na ativa, como ele pôde perceber quando desceu as escadas e escutou barulhos de panelas se batendo na cozinha. Ele pegou um dos bolinhos que estavam em cima da mesa para o café da manhã de família e foi correndo para porta antes que alguém o impedisse de sair de casa.
<p>Todas as fachadas das casas do bairro estavam com decorações de Natal, inclusive a dele e isso era uma das coisas que ele mais amava no feriado, aparentemente todos pensavam juntos nessa época, acontecia isso também no Dia das Bruxas e Dia da Independência, mas não era a mesma coisa, pelo menos não para ele.
<p>Na casa de Emily havia alguns pisca-piscas pendurados no portão, mas fora isso, nada mais indicava que aquela família comemorava o Natal. Ele gritou o nome da namorada no portão algumas vezes e esperou. Cinco minutos depois, ela apareceu ainda de pijama, coçando os olhos e com o cabelo, todo bagunçado, preso em um coque mal feito.
<p>- O que você está fazendo aqui a essa hora? Ainda não são nem sete da manhã. – Emily estava com os olhos quase fechados por causa da claridade do sol.
<p>- É véspera de Natal. – Will falou todo animado.
<p>- Que bom, então ainda temos mais um dia antes do Natal. – Ela falou sem muita emoção.
<p>- Não acredito que não gosta de Natal. Você é toda animada e tal, gosta de festas de aniversário, achei que esse feriado seria a melhor coisa para você. – Will ficou intrigado.
<p>- Não é que eu não goste, só não acho grande coisa.
<p>- Retire o que disse agora. – Will arregalou os olhos para fingir espanto, mas já estava quase rindo. 
<p>- Por favor, diga que eu não estou namorando o louco do Natal. 
<p>- Ems, você está namorando o louco do Natal. – Ele abriu um grande sorriso e inevitavelmente, ela fez o mesmo. – Agora vai, se veste, já estamos atrasados.
<p>- Atrasados para que exatamente?
<p>- Vamos dirigir a Van da Alegria de Natal esse ano, a gente se inscreveu para ser voluntário. 
<p>- Van da... o quê? Eu não me inscrevi para nada.
<p>- Na verdade, eu inscrevi a gente. Estávamos brigados e não deu tempo de falar com você sobre isso.
<p>- Inscreveu a gente quando estávamos brigados?
<p>- Culpe a Angie. – Will falou logo. – Além de mais, temos que buscá-la. A mãe dela deixou a gente levá-la conosco. Isso se a gente não se atrasar com a sua demora. 
<p>- Eu não... se você tivesse me contado...
<p>- Me dá a bronca depois. Vai se vestir. 
<p>- Eu odeio você. – Emily deu as costas para o namorado e voltou correndo para dentro de casa.
<p>- Feliz Natal!</p>
<center><h4>--*--</h4></center>
<p>Will e Emily estavam na sala de espera do hospital esperando por Angie. O lugar também estava muito decorado, havia guirlandas e bonecos de neve por todo o lugar e mais tarde, o Papai Noel, um dos médicos, iria fazer uma visita na ala infantil.
<p>- Qual é o seu problema com o Natal?
<p>- Eu já disse, eu não tenho nenhum problema com o Natal. – Emily não convenceu. – É que... todo ano, na ceia, meu pai bebe demais e briga com alguém. Se você passar por lá hoje, talvez esse alguém esse ano seja você.
<p>- Eu passo, muito obrigado. – Will riu. – Na minha casa, tem essa grande festa, meus tios e primos, avós, todos vindo para cá. A casa fica meio cheia, mas é mais fácil de eu fugir.
<p>- Pera aí, você não fica na festa? Que espírito natalino é esse? 
<p>- Eu geralmente fujo para casa do Jason. A mãe dele não gosta de Natal e recusa os convites da minha mãe todo ano. A gente pede uma pizza e vê filmes, claro que comigo com um gorro do Papai Noel. 
<p>- Estou namorando uma criança de sete anos.
<p>- E eu, uma ranzinza, mas isso vai mudar. 
<p>Will se levantou e foi até um boneco de neve que estava perto do balcão da recepção. O boneco segurava um pote e dentro dele havia vários gorros de Natal.
<p>- Eu não vou vestir isso. – Emily falou assim que viu o namorado voltando com um gorro já na cabeça e outro na mão. 
<p>- Se você estiver do meu lado, a magia do Natal vai te contagiar, você querendo ou não. – Ele estendeu a mão para ela pegar o gorro. 
<p>- Já disse que te odeio hoje? – Ela pegou o gorro e o vestiu de má vontade. – Me conta mais sobre essa Van de Natal.
<p>- Van da Alegria de Natal. São todas as doações que o centro comunitário da cidade arrecada. Eles embrulham para presente, colocam na van e saem distribuindo em bairros necessitados, hospitais públicos, alguns orfanatos. 
<p>- Isso é muito legal. – Ela finalmente ficou interessada. 
<p>Angie se anunciou com um grito bem animado de “Vamos logo!”. Ela estava vermelha porque tinha chegado correndo. Usava um suéter de lã cheio de desenhos de Natal e seus olhos brilhavam.
<p>- Eu nem acredito... Faz um tempão que eu não saio daqui! Mal posso esperar para...
<p>E ela foi correndo na frente. Sua mãe, por outro lado, não estava muito animada, seu rosto de preocupação estava bem à mostra. Ela entregou a Will um papel com uma lista de precauções que eles deveriam tomar com a criança e pediu para ele verificar de novo se tinha seu número de telefone gravado em seu celular. 
<p>Depois de tranquilizá-la o máximo que conseguiram, Will e Emily alcançaram Angie que estava esperando por eles na porta central do hospital ainda sorrindo.
<p>- Eu estou muito animada! – Ela não conseguia falar baixo. 
<p>Mas quando eles passaram pela porta giratória do hospital e sentiram o sol no rosto, Angie parou de falar e também de andar. 
<p>- O que foi? – Will franziu a testa confuso.
<p>- Acho... melhor eu não ir. – Não havia alegria na voz da garota e sim muito medo. – Sei lá.
<p>- Você vai adorar. – Will insistiu. – Eu sou um ótimo motorista. 
<p>- Não é isso, é que...
<p>Emily percebeu. Angie olhava para todos na rua um pouco assustada e desviava o olhar quando alguém olhava de volta. Ela havia acabado de sair da sua zona de conforto e achava que não estava pronta para o mundo real. Era diferente, era grande e iluminado e as pessoas não usavam branco e ainda tinham cabelo, de todos os jeitos.
<p>- Sabe, eu tive uma ideia. – Emily se ajoelhou e ficou cara a cara com ela. – Que tal você ser o nosso símbolo de Natal? – Ela sorriu. – Já está com essa blusa muito linda e só falta uma coisa.
<p>Emily tirou o gorro da cabeça e colocou na de Angie. Como um objeto com poderes, a criança sorriu assim que sentiu sua cabeça esquentar com o gorro.
<p>- Eu estou bonita? – Ela olhou de Emily para Will esperando a resposta.
<p>- Está perfeita. – Emily sorriu.
<p>- A garota mais linda que eu já vi. – Will sorriu também e depois olhou para Emily com admiração. – Está pronta agora?
<p>- Vamos lá! – Ela pegou nas mãos dos dois e voltou a andar animada.</p>
<center><h4>--*--</h4></center>
<p>Amanda e Jason estavam na cafeteria. Ela também fugiu do café da manhã de véspera de Natal da família.
<p>- Eu não queria que o nosso primeiro Natal fosse assim. – Amanda resmungava. Jason havia dito a ela que não podia ir à sua casa para ceia já que sua mãe se recusava a sair de casa e ele não podia deixar ela sozinha no feriado.
<p>- Eu sinto muito.
<p>- Eu entendo, mas não gosto. Como ela está?
<p>- Sabe como ela fica em todo Natal. Ela aguenta. 
<p>Amanda sabia que esse assunto era algo delicado e não queria deixar o namorado se sentindo mal bem no Natal então resolveu mudar de assunto. Não se passaram nem dez minutos quando Sebastian ligou para o amigo perguntando onde ele estava, cinco minutos depois, ele apareceu na cafeteria de mãos dadas com Quinn. Os dois estavam juntos desde a noite do acampamento e pareciam bem felizes. 
<p>- Gente, eu convidei a Quinn para passar o Natal lá em casa. – Sebastian sorriu para a namorada enquanto se sentava do lado da irmã. 
<p>- Não vai passar com seus pais? – Amanda estranhou.
<p>- Eu não, o Natal em casa é um porre. Não sou tão boa quanto a Emily, eu fujo toda vez. 
<p>- Coitado do Will então. – Jason brincou.
<p>- Como é o Natal na casa de vocês? – Quinn perguntou.
<p>- Cheio. – Sebastian riu. – Nossa família mora tudo na Califórnia, não são tão unidos, quase não se falam no decorrer do ano, mas quando chega o Natal...
<p>- Todos bancam as boas pessoas e comemoram juntos. – Amanda falou com reprovação.
<p>- Amanda não sabe disfarçar. Sempre trata nossas tias mal. – Sebastian ria.
<p>- Ah, elas são chatas.
<p>- Eu te entendo. Em Nashville, minhas tias viviam querendo se intrometer na minha vida. Eu dava um “chega para lá” sem dó. Não tenho paciência. 
<p>- Eu tento ser o filho perfeito. Sempre tem um que pergunta para um dos nossos pais porque me adotaram. É constrangedor. 
<p>- Age como se tivesse que conquistar o seu lugar. – Amanda olhou feio para o irmão. – O lugar já é seu, os convidados são eles.
<p>- Mesmo assim...</p>
<center><h4>--*--</h4></center>
<p>- <i>Alimente o mundo! Avise a eles que o Natal chegou! Alimente o mundo! Avise a eles que o Natal chegou! Vamos lá!</i>
<p>Will olhou para Emily e ela não estava cantando junto. Pelo retrovisor, Angie também só observava.
<p>- Ah, qual é, garotas? Vamos lá! <i>Alimente o mundo! Avise a eles que o Natal chegou!</i>
<p>- Para com isso.
<p>Will havia feito uma playlist só com músicas de Natal e colocou no rádio da Van no último volume.
<p>- Vocês são as piores ajudantes do Papai Noel do mundo. Sabiam disso?
<p>- E você é louco demais. Vai com calma, Papai Noel. – Emily abaixou um pouco o rádio. 
<p>- Por que eu sou o único animado?
<p>- Eu também estou animada, só não conheço essa música. – Angie começou a tentar inclinar seu corpo para frente, mas o cinto de segurança e a cadeira de viagem estavam atrapalhando. – Aonde vamos primeiro?
<p>- Ah, de acordo com o itinerário, vamos primeiro para um bairro chamado... não sei ler esse nome. – Will olhava fixamente para a tela do GPS preso no painel da van.
<p>- Espero que saiba pelo menos como chegar lá. – Emily sorriu.</p>
<center><h4>--*--</h4></center>
<p>O bairro desconhecido de Will era muito diferente dos quarteirões que ele costumava ver. Ele sabia que LA não era só praias, pessoas felizes e paisagens dignas de filmes, mas também não imaginava visitar um lugar naquele estado. Nas ruas, várias caixas de papelão abrigavam adultos e crianças. Casas feitas de tabuas eram a maioria por ali, ruas sujas de lixo, era como se tudo tivesse sido abandonado. <p>A maioria daquelas pessoas era refugiado, imigrante ou dependente químico. Ele engoliu em seco quando imaginou a possibilidade de Sebastian estar morando naquela situação também se não tivesse sido salvo a tempo.
<p>“Isso deixa a sua vida em perspectiva, não deixa? Seus problemas não parecem mais ser tão importantes”. 
<p>Os três não sabiam que crianças podiam abrir um sorriso tão grande apenas por receber um ursinho de pelúcia. Roupas usadas, porém, mais novas do que as que a maioria estava usando.</p>
<center><h4>--*--</h4></center>
<p>A segunda parada foi em uma igreja que acolhia moradores de rua no inverno não muito longe daquele bairro. Além de brinquedos e roupas, os três deixaram alguns alimentos doados, arroz, feijão, açúcar, macarrão. 
<p>Will não visitava uma igreja há muito tempo, mas sabia o que acontecia na maioria delas, pregadores que tentavam usar a fé das pessoas para benefício próprio com dízimos e vendas de imagens de santos e terços, bíblias caríssimas. Tentavam vender o seu Deus. Ele sorriu ao perceber que a religião ainda reunia pessoas para fazer o bem e que nem tudo aquilo ainda estava perdido e que se existisse mesmo um Deus, ele estaria feliz com a comunhão daquelas pessoas.</p>
<center><h4>--*--</h4></center>
<p>Eles já estavam morrendo de fome quando chegaram em um dos hospitais públicos que estava na lista. Até Angie percebeu a diferença daquele hospital com o que ela morava. Pessoas sendo atendidas no corredor, cadeiras de espera quebradas e a escassez de funcionários. 
<p>As crianças formaram uma grande fila na entrada da ala infantil para receberem os presentes. Para um lugar daquele tamanho, havia muitas crianças. Mesmo se sentindo um pouco mal, Emily colocou um grande sorriso no rosto e começou a distribuir os presentes. 
<p>Alguns brinquedos eram um mistério para as crianças. Era engraçado, um dos primeiros brinquedos que Will teve foi um carrinho de controle remoto, quando tinha quatro anos. Um garoto de quase dez não sabia para que servia aquele controle. Meia hora depois, ele estava no corredor com todas aquelas crianças as ajudando a testar os presentes e brincando como se fosse uma delas.</p>
<center><h4>--*--</h4></center>
<p>O orfanato de Santa Monica foi a última parada. Havia muitas doações destinadas especialmente para aquele orfanato e assim que entrou no lugar, Will percebeu por quê. Aquela casa não tinha nenhum indício de que estavam comemorando o Natal.
<p>As crianças olhavam para ele curiosos. Angie entrou sorrindo para eles e gritando “Vamos enfeitar esse lugar para o Natal!”. Alguém havia doado uma árvore de Natal artificial que ainda estava embrulhada na caixa. Will a carregou para dentro e começou a montá-la. 
<p>Em um momento daquela tarde, todos daquele orfanato estavam suados e cansados de tanto correrem de um lado para o outro buscando enfeites de Natal e pendurando em todos os lugares. Will apostava que aquela sala e aqueles corredores tinham mais pisca-pisca que um shopping. E mesmo assim, ninguém conseguia parar de sorrir.</p>
<center><h4>--*--</h4></center>
<p>A van estava silenciosa enquanto voltava para seu ponto de partida. Tinha sido um dia cheio e de muitas experiências. Os três estavam em silêncio tentando digerir tudo aquilo.
<p>- <i>É Natal. Não é preciso ter medo.</i> – Angie começou a cantar no banco de trás baixinho. – <i>No Natal, deixamos a luz entrar e banimos as sombras.</i> Eu aprendi a cantar. Tem uma garota no orfanato que adora essa música e me ensinou. <i>E no nosso mundo de fartura, podemos espalhar um sorriso de alegria. Abrace o mundo todo nesse Natal.</i>
<p>- <i>Mas faça uma oração. Reze pelos outros.</i> – Emily começou a cantar também. - <i>Oh, no Natal é difícil, porque enquanto você está se divertindo...</i>
<p>- <i>Existe um mundo fora da sua janela e é um mundo de dor e medo.</i> – Will olhava para Emily em intervalos curtos. - <i>Onde a única água fluindo são amargas e dolorosas lágrimas.</i>
<p>- <i>E os sinos do Natal que tocam lá são os chamados de desgraças.</i> – Angie começou a cantar mais alto.
<p>- <i>Bom, hoje à noite, agradeça a Deus por ser eles, ao invés de vocês...</i> – Uma lágrima escorreu no rosto de Emily.
<p>- <i>E não haverá neve na África nesse Natal!</i> – Will ligou o rádio bem alto de novo nessa mesma música. - <i>O maior presente que terão esse ano é a vida! Onde nada jamais cresce! Onde não há chuva nem rios! Afinal, será que eles sabem que é Natal?</i>
<p>Por um minuto, os três ficaram em silêncio só ouvindo as vozes do rádio continuarem com a música e então voltaram a cantar juntos sorrindo.
<p>- <i>Alimente o mundo! Avise a eles que o Natal chegou! Alimente o mundo! Avise a eles que o Natal chegou! Alimente o mundo! Avise a eles que o Natal chegou! Alimente o mundo! Avise a eles que o Natal chegou! Alimente o mundo! Avise a eles que o Natal chegou de novo...</i></p>
<center><h4>--*--</h4></center>
<p>- O que está fazendo aqui? – Karen encontrou a filha escondida na cozinha, mexendo no celular encostada no balcão. 
<p>- Eu estou me escondendo. – Amanda respondeu.
<p>A casa dos Jones já estava lotada. A música no último volume, porém, as vozes dos convidados estavam mais altas. 
<p>- Filha...
<p>- Kevin trouxe a Giovanna. Não consigo ficar lá dentro fingindo que tudo está bem. e ainda tem o Chris e a Ashley...
<p>- Você não devia tomar partido na briga dos seus irmãos. – Karen estava se preparando para um conselho.
<p>- Não é tomar partido. Se eu achasse que o Will estava errado, eu seria a primeira a dizer. Cadê o Sebastian?
<p>- Foi buscar a Quinn. Cadê o Jason?
<p>- Não quis deixar a mãe sozinha no Natal.
<p>- Entendo. Não foi esse ano que ela aceitou meu convite.
<p>- Aparentemente não. – Amanda falou mal-humorada.
<p>- Pode ir ficar com ele se quiser. Qualquer coisa, eu digo que você fugiu assim como eu faço com o Will todo ano.
<p>- O Will foge? Eu não acredito, aquele desgraçado.
<p>- Olha a boca.
<p>- Olha só, falando no diabo... – Amanda olhou para a tela do celular. Seu irmão havia mandado uma mensagem para ela.
<p>- Vai.
<p>- Valeu, mãe. – Amanda beijou o rosto de sua mãe e saiu correndo pela porta dos fundos da cozinha.</p>
<center><h4>--*--</h4></center>
<p>Will estava esperando por Amanda na garagem. 
<p>Ele não queria ter que entrar em casa e cumprimentar todos que estavam lá então preferiu ficar na surdina. Não foi ela que apareceu quando Will ouviu a porta que ligava a casa com a garagem se abrir. 
<p>Kevin, um pouco acuado, apareceu com as chaves da caminhonete de seu pai na sua mão. Ele disse um “oi” bem baixo e entregou as chaves para o irmão.
<p>- Valeu. Milagre o pai confiar um carro dele de novo comigo. – Will riu para tentar deixar a conversa um pouco mais fácil.
<p>- É Natal. Talvez ele esteja mais mole hoje. – Kevin estava inquieto. Não parecia que ele estava lá só para fazer aquele favor de entregar as chaves para o irmão. – Will, eu queria muito falar com você. Um assunto meio sério.
<p>- Pode dizer. – Will não achava que era tão sério assim. Nunca era.
<p>- Giovanna e eu conversamos muito sobre tudo. Sobre a nossa situação, sobre você...
<p>- Sobre mim?
<p>- É.
<p>- Kev, eu não quero me meter entre vocês nem quero ser um assunto entre vocês.
<p>- Acho isso meio impossível. – Kevin continuava falando mais baixo do que o normal, como se estivesse com um pouco de vergonha daquela situação. – Eu acho que... a gente devia...
<p>- O quê? Está terminando comigo? – Will soltou uma gargalhada. – Não quer mais ser meu irmão? Sabe que não é assim que funciona, não é?
<p>- Eu não... Meu namoro nunca vai dar certo se a sua sombra estiver por perto.
<p>- Minha sombra? Como assim? Isso é sério? – Will deixou sua expressão de brincadeira de lado. – Ela pediu para você escolher entre mim e ela? É sério?
<p>- Foi uma decisão em conjunto.
<p>- O caralho que foi. – Will se segurou para não gritar.
<p>- Eu sinto muito.
<p>- Não sente não, mas tudo bem. Agora sai da minha frente antes que eu bata em você.
<p>- Eu amo a Giovanna. – Kevin insistiu. Embora não pudesse mais se relacionar com o irmão, ele também não queria que as coisas acabassem mal. Ele queria que Will entendesse.
<p>- Bom para você.
Kevin o encarou como se quisesse falar algo, mas desistiu no meio do caminho e virou as costas para ele. Amanda estava passando pela porta da garagem quando o irmão passou por ela correndo.
<p>- O que houve? – Amanda percebeu. 
<p>- Eu sou um irmão tão ruim assim? Acho que eu sou. – Will olhava fixamente para o ponteiro de velocidade no painel.
<p>- Do que está falando? – Amanda franziu a testa confusa ao entrar no carro e se sentar ao lado do irmão.
<p>- Quando eu era pequeno, o papai sempre dizia que como irmão mais velho, eu tinha o dever de sempre juntar todos os meus irmãos. Não importa o quanto eu tente, nunca vou conseguir isso.
<p>- O que aconteceu? – Amanda não estava entendendo nada. – Do que está falando? Você é um ótimo irmão.
<p>- Kevin acabou de me trocar pela Giovanna. Aparentemente eu não sou tão bom irmão assim. 
<p>- Ridículo. Ele é um idiota e você é mais ainda por achar que não é bom o suficiente. 
<p>- Olha, esquece isso.
<p>- Não, eu vou lá dar um tapa na cara dele e se eu estiver animada, bato na cara dela também. – Amanda já estava furiosa.
<p>- Não foi por isso que eu te chamei aqui. É Natal e eu quero fazer uma coisa. Deixe o Kevin para depois.
<p>- Achei que íamos na casa do Jason.
<p>- E vamos, mas antes precisamos ir em outro lugar.</p>
<center><h4>--*--</h4></center>
<p>Jason e sua mãe estavam sentados no sofá comendo pipoca vendo um filme aleatório que estava passando na televisão no canal aberto. Esse era o ponto alto do seu Natal. Ele sabia que daqui alguns minutos, Will apareceria lá todo animado com um panetone e alguma torta que ele havia roubado da ceia da sua casa e passaria a noite toda tentando animar ele e sua mãe dizendo que a magia do Natal não podia acabar e criando jogos de todas as maneiras possíveis. 
<p>Era quase onze-horas quando os dois quase pularam do sofá após ouvirem uma buzina bem alta perto da janela da sala que ficou toda iluminada pelas luzes dos faróis do carro.
<p>- O que é isso? – Ele saiu da casa um pouco emburrado. – Will, dessa vez você foi longe demais. 
<p>- É Natal! – Will saiu gritando da caminhonete. – Tem que ter o pacote completo.
<p>Ele apontou para o grande pinheiro que estava amarrado em cima da caminhonete. 
<p>- É Natal, meu amigo, é Natal! – Ele gritou sorrindo. 
<p>Jason se rendeu e sorriu também. 
<p>- A gente comprou alguns enfeites também. Vão ter uma grande noite.
<p>- A gente? – Jason estranhou.
<p>- Não achou que ia passar o Natal aqui sozinho, não é? – Amanda saiu do carro segurando uma grande caixa e o sorriso de Jason ficou maior. 
<p>- Eu vou ajudar você a tirar a árvore daqui e vou seguir meu caminho. Já tem presentes demais esse ano. – Will piscou para o amigo.
<p>- Para onde você vai? – Amanda perguntou depois de correr e abraçar seu namorado que continuava parado em frente a sua porta.
<p>- Esse Papai Noel aqui tem uma última parada antes da meia-noite.</p>
<center><h4>--*--</h4></center>
<p>Não era nem meia noite e Emily já estava se preparando para dormir. 
<p>O telefone dela tocou. 
<p>- <i>Oi!</i> – Will falou animado.
<p>- Ainda não é meia noite para me desejar Feliz Natal. – Ela riu.
<p>- <i>Não consegui esperar. O que você está fazendo?</i>
<p>- Acabei de tomar banho. Ia me deitar e esperar sua ligação.
<p>- <i>Gostei do plano.</i> – Emily ouviu a risada de Will. – <i>Sabe, eu só queria dizer que você foi incrível hoje.</i>
<p>- Você foi mais.
<p>- <i>Está brincando? Você percebeu o real medo da Angie, eu só achei que ela estava com medo de me ver dirigir.</i> – Ele riu de novo. – <i>Se não fosse por você, eu teria levado ela de volta e aí... ela não teria visto tudo aquilo.</i>
<p>- É, eu fui um pouco incrível. Obrigada por hoje. Foi de longe o melhor Natal que eu já tive. 
<p>- <i>E ele só pode melhorar</i>. – Will fez suspense. – <i>Vem passar o Natal comigo.</i>
<p>- Will, eu não posso ir na sua casa. Meu pai ia encher o meu saco e você mesmo disse que seus parentes são chatos.
<p>- <i>Vem passar o Natal comigo, não com meus parentes e eu não estou em casa. Na verdade, agora eu estou parecendo um stalker doido na calçada olhando você pela janela.</i>
<p>- O quê?
<p>Emily olhou pela janela e viu Will do outro lado da rua acenando e com um grande sorriso. 
<p>- O que está fazendo aqui?
<p>- <i>É como diz a música: Tudo o que eu quero de Natal é você.</i>
<p>- Eu... – Emily ficou sem palavras. – Tudo o que eu quero de Natal também é você.
<p>- <i>Então vem passar o Natal comigo!</i> – Ele gritou e ela nem precisou estar com o celular no ouvido para conseguir ouvir.
<p>- Para onde vamos?
<p>- <i>Para onde você quiser.</i>
<p>- Você é doido. – Ela riu.
<p>- <i>Isso é um sim?</i>
<p>- O que você acha?</p>
<br>
<p>“Existem muitas músicas de Natal. As tradicionais que ouvimos em cantigas ou aprendemos quando somos crianças. Têm aquelas que já tantas pessoas cantaram que você nem sabe mais de quem é. Eu nunca gostei muito de músicas de Natal que falavam de solidão ou coração partido embora uma das minhas músicas favoritas de Natal é <i>Last Christmas</i>. 
<p>Para mim, Natal nunca se tratou de presentes ou vestir uma roupa bonita para ir à festa da família, sempre se tratou de magia. O mundo poderia estar uma droga, obscuro e nos seus piores dias, mas eu sempre achei que essa magia iluminava pelo menos um pouco. Não se tratou dos presentes que aquelas crianças pobres ganharam de doação, e sim o sentimento de que elas estavam sendo lembradas, notadas, que elas existiam.
<p>Eu tive um bom ano. Não foi perfeito, mas nenhum nunca será. Eu fiz coisas que achei que não faria por muito tempo e comecei a querer outras. Não é assim que a vida funciona? Não é esse o nosso dever? Sempre buscar. Eu cresci, não totalmente, mas pelo menos um pouco e isso é tudo o que eu poderia pedir. Eu tive momentos incríveis, alguns mais do que incríveis e eu quero buscar muitos momentos como esse, porque é o que tem que ser feito. Os momentos felizes precisam superar os tristes, não necessariamente em quantidade, mas em intensidade. Deveria ser uma regra. Para mim é.”.</p>
</body></html>";
            }

            if (numero == 23)
            {
                lblTitulo.Text = "Capítulo 23 - Mais Um Ano, Você Fez Uma Promessa";
                htmlPage.Html = @"<html><body>
<p><i>“Mais um ano, você fez uma promessa
<br>Mais uma chance de fazer tudo de novo
<br>E não guardar isso para amanhã
<br>Aceite o passado e poderá viver o agora
<br>E eu vou dar o mundo para você.”
<br><b>This Is The New Year – Ian Axel</b></i></p>
<br>
<p>O sol já estava nascendo quando Will e Emily perceberam que precisavam se levantar daquela areia úmida da noite e ir para casa. 
<p>A praia ainda estava lotada, não tanto quanto algumas horas atrás na queima de fogos na comemoração do Ano Novo, mas ainda tinha uma quantidade considerável de pessoas. Alguns estavam bêbados demais para saberem onde estavam, outros estavam acampados, só esperando o dia nascer para seguirem seu caminho. Alguns faziam suas próprias festasà beira do mar, enquanto uns apenas se deitavam na areia esperando a vida voltar ao normal. 
<p>Will e Emily estavam cansados, os olhos quase se fecharam muitas vezes naquela madrugada, mas não se levantaram. A maré subiu um pouco ao ponto de as ondas molharem suas canelas, mesmo assim eles permaneceram lá, sentados. Emily estava com sua cabeça encostada no ombro do namorado e com um dos seus braços enrolado em um braço dele.
<p>- Quando vamos poder falar sobre o Kevin?
<p>- Nunca, lembra? Essa foi a nossa promessa de Ano Novo. – Will sorriu. – Eu estou bem, Ems, só não quero falar sobre isso. 
<p>- Sabe, o Jason me contou uma história e isso vai contra tudo o que você está pensando.
<p>- O que eu estou pensando? – Will olhou para a namorada de rabo de olho.
<p>- Que você é um péssimo irmão ou péssima pessoa ou os dois. 
<p>Era verdade. Na maior parte daquela semana, só nisso que ele conseguia pensar.
<p>- Que história é essa que o Jason te contou?
<p>- Que quando o pai dele foi embora, ele te disse que ia sentir muita falta dele comprando biscoitos todo dia de manhã. Aí você...
<p>- Eu passei meses acordando cedo para ir comprar biscoitos para ele. – Wil riu ao lembrar daquilo.
<p>- Exato. 
<p>- Jason não é meu irmão. 
<p>- Não se trata de sangue, sabia? Se trata de ser ou não ser. Se você o considera irmão, ele é seu irmão. O Kevin, ele... Ele vai cair na real, senão cair, ele que perde. 
<p>- Vamos esquecer isso.
<p>- Vamos. – Ela apertou bem forte a mão dele.</p>
<br>
<p>“Ano novo, vida nova. Eu já ouvi muita gente dizendo essas coisas. Pessoas fazem planos e promessas que pretendem cumprir nesse novo ano, mas poucas cumprem. Algumas se perder no meio do caminho, outras desistem na primeira derrota, umas simplesmente esquecem. 
<p>Eu, particularmente, não acredito em uma vida nova tão rápido. Na maioria das vezes, as coisas só pioram na famosa maré dos erros.”.</p>
<br>
<p>O recesso de fim de ano acabou e a escola voltou a se encher de alunos. 
<p>Emily estava sentada em uma das mesas espalhadas pelo pátio ensolarado lendo um livro, bem concentrada.
<p>- Você poderia me ajudar? – Will interrompeu sua leitura.
<p>- O quê? – Ela não entendeu o comentário.
<p>- Eu não sei onde eu deveria estar. – Ele riu mostrando o papel que continha os horários que ele teria aula.
<p>- Olha, eu até poderia te ajudar, mas não vou.
<p>- Tudo bem, então eu fico aqui com você. – Ele se sentou ao lado dele. 
<p>- Olha, meu namorado está chegando e ele é grande e forte. 
<p>- É, já ouvi falar dele. Parto ele ao meio por você.
<p>Ela começou a rir.
<p>- Eu sou o Will. – Ele estendeu a mão para ela.
<p>- Cala essa boca. 
<p>- Acredita que já faz um ano que a gente se conhece? 
<p>- É, cada um tem a sua cruz. Você é a minha. – Ela falou em um tom debochado.
<p>- A cruz mais linda que você poderia ter arranjado. 
<p>- Dá para o gasto. 
<p>- Acho que vou no aeroporto mais tarde, vou ver se encontro uma caipira melhor. 
<p>- Deveria fazer isso.
<p>- Sabe, eu estava pensando que a gente podia sair no almoço para comemorar. 
<p>- Não dá, vou almoçar com o meu pai.
<p>- Nossa. – Will fez cara de nojo. – Boa sorte. 
<p>- Vou precisar. – Ela brincou.</p>
<center><h4>--*--</h4></center>
<p>Aparentemente, um ano inteiro não bastou para Emily se localizar na escola. Ela chegou no seu armário ainda um pouco perdida e depois de ter dado três voltas por todos os corredores o procurando. 
<p>Ela se distraiu colocando seus livros dentro do armário que se assustou quando alguém segurou o braço dela, mesmo que de leve.
<p>- Eu não vou matar aula. – Ela se virou sorrindo, mas mudou sua expressão bem rápido.
<p>- Olá. – Giovanna deu um sorriso cínico.
<p>- O que você quer? – Ela ficou séria.
<p>- Devia se afastar do Will.
<p>- Esse papo de novo. 
<p>- É para o seu bem. 
<p>- O quê? Vai me ameaçar de novo, é? – Emily riu. – Você já não causou demais, não? O que você fez com o Kevin? Que feitiço foi aquele?
<p>- Cala a boca. 
<p>- Sai daqui. 
<p>- Você quer briga, não é?
<p>- Giovanna, eu não vou brigar com você. – Emily achava aquela ideia muito ridícula. – Eu não sou assim, muito menos por causa de um cara. 
<p>- Você é superior, não é? Pelo menos, acha que é. Coitada.
<p>- Coitada mesmo.
<p>Emily fechou seu armário e foi embora deixando Giovanna falando sozinha.</p>
<center><h4>--*--</h4></center>
<p>- Essa garota está me cansando demais. – Emily bateu o caderno com força na carteira, bem irritada.
<p>- Relaxa. – Amanda tinha a primeira aula de história junto com Emily. As duas estavam muito mais próximas do que no ano letivo anterior quando começaram com o pé esquerdo.
<p>- Ela realmente está conseguindo me tirar do sério. Qual é o problema dela? Por que ela não simplesmente segue em frente? – Emily estava quase gritando.
<p>- Olha, sinto muito te deixar para baixo, mas eu acho que ela nunca vai seguir em frente. Esse namoro com o Kevin é pura fachada, então se prepara.
<p>- Ela é louca.
<p>- Concordo. Ela sempre teve problemas. Era pirada antes mesmo de namorar com o Will. Sabe esse tipo de garota que se define a partir do cara que namora? Que perde o propósito da existência quando termina com alguém? É assim que ela era e continua sendo.
<p>- Tudo bem, agora eu estou começando a sentir dó dela.
<p>- Não sinta. Não acho ela digna de pena. Para mim, é uma nojenta que não gosta de receber um “não” como reposta.
<p>- Acha que se o Will não tivesse me conhecido, ele já teria cedido e voltado para ela?
<p>- Nunca. O Will não é daqueles que cede sob pressão. Ao contrário, o ódio dele só aumenta. Você está preocupada com isso? Com ela? – Amanda ficou intrigada.
<p>- Não, é que... nada, deixa para ela. – Nem Emily sabia muito bem com o que ela estava preocupada. – Ainda não acredito que o Kevin deixou de falar com o irmão só para ficar com essa garota.
<p>- Enquanto ela está atrás do ex. – Amanda completou. – Esse sabe ser feito de otário.
<p>- Desse eu posso ter dó?
<p>- Dó de alguém que não está nem aí para a família que fica do lado dele e que prefere a namorada vadia?
<p>- Assim fica difícil sentir dó de alguém.
<p>- Guarde a sua dó para quem está morrendo.</p>
<center><h4>--*--</h4></center>
<p>O sinal para o almoço tocou. 
<p>Por um minuto, Emily sentiu alívio por estar indo embora, mas foi uma sensação passageira quando lembrou que teria que almoçar com o seu pai. Passou um tempo colocando na balança imaginária o peso de aguentar seu pai ou aguentar a Giovanna, era um equilíbrio perfeito de teste de controle emocional para ela. 
<p>Havia um tumulto no corredor onde ficava seu armário e ela não conseguiu ver o que realmente estava acontecendo até pisar sem querer em um caderno que estava no chão e perceber que era seu. 
<p>Seu armário estava com a porta arreganhada e suas coisas estavam todas espalhadas pelo chão. Livros, canetas, cadernos...
<p>- Ai, meu Deus. – Todos observavam enquanto ela corria para pegar suas coisas jogadas no chão. Algumas folhas foram arrancadas dos cadernos e o ziper dos estojos estavam destruídos.  
<p>Bombardeada com sorrisinhos e piadas, Emily passou pelo corredor pegando suas coisas em silêncio e sem manter contato visual com ninguém. Ela percebeu que o cadeado havia sido arrombado.
<p>- Desgraçados. – Ela falou baixinho enquanto guardava suas coisas na mochila, não podia deixar mais nada no armário sem antes comprar uma tranca nova. 
<p>- O que aconteceu aqui? – Quinn veio correndo quando viu o alvoroço.
<p>- Deve ter sido uma pegadinha. – Emily falou baixinho.
<p>- Quem foi o idiota que fez isso? – Quinn gritou encarando cada um que estava rindo, mas não obteve nenhuma resposta.
<p>- Quinn, deixa. Não importa.
<p>- É claro que importa!
<p>- Não, não importa.
<p>Emily fechou a porta do armário e então percebeu que sua mão estava suja de tinta preta. 
<p>“VaDiA CaIpIrA!”.
<p>A garota olhou para aquelas palavras escritas na porta que havia acabado de fechar. Não conseguiu ter uma reação imediata.</p>
<center><h4>--*--</h4></center>
<p>- Eu queria mesmo falar com você. – Amanda abordou Will enquanto ele guardava seu caderno no armário para ir almoçar.
<p>- Nossa, um irmão que quer falar comigo? Isso é novidade. – Ele riu.
<p>- Sem piadinhas, tá bom? – Ela estava séria.
<p>- O que foi? 
<p>- Precisa conversar com a Emily. Acho que ela está à beira de um colapso. 
<p>- Como assim? Do que você está falando?
<p>- A Giovanna veio falar com ela de novo hoje e pelo jeito, tirou ela do sério. Ela chegou puta da vida na sala na primeira aula.
<p>- Eu vou conversar com ela.
<p>- Mas nada desses papos melosos, tem que ser uma conversa séria. Ela está na pior.
<p>- Não exagera. – Will estava acostumado com Amanda fazendo um drama por pouca coisa.
<p>- Você não faz ideia, não é?
<p>- Do que?
<p>- Não é só a Giovanna. Quer dizer, ela é a única que coloca a boca no trombone, mas a escola toda está sendo um pouco hostil com a Emily. 
<p>- Como assim?
<p>- Existe um grupo de bate-papo online chamado grupo Anti-Emily. Eu fui até convidada a entrar.
<p>- Isso é ridículo.
<p>- Estamos no colegial. Somos todos ridículos. 
<p>- Você não está exagerando? Emily nunca me falou sobre isso. Talvez ela nem saiba.
<p>- Ela sabe. – Amanda o encarou. 
<p>- Com certeza, ela sabe.
<p>Quinn apareceu de surpresa e muito brava. Ela vinha com uma folha de papel que depois empurrou no peito de Will com a palma da sua mão. 
<p>- O que é isso? – Will pegou a folha depois do susto. Estava escrito “VAGABUNDA” em letras vermelhas.
<p>- Estão escrevendo isso sobre a minha irmã. Picharam “Vadia” na porta do armário dela. – Quinn estava gritando e espumando de raiva.
<p>- Quem fez isso?
<p>- Quem você acha, Will? Sua queria ex-namorada que não deixa a Emily em paz. Você precisa dar um jeito nisso antes que eu dê, e eu não vou ser educada. Vou arrancar cada fio de cabelo daquela cabeçona dela!
<p>- Quinn, calma aí. Cadê a Emily?
<p>- Foi embora. Foi almoçar com o meu pai. – Quinn tentou relaxar um pouco, mas sem sucesso. 
<p>- Olha, eu vou resolver isso, tá bom?
<p>- Acho bom mesmo. – Ela o encarou.</p>
<center><h4>--*--</h4></center>
<p>Chris viu Jason e Sebastian sentados em uma das mesas no pátio e foi até eles. Ele estava inquieto quando se sentou ao lado do irmão e começou a falar.
<p>- Vocês ficaram sabendo? Picharam o armário da Emily com umas palavras bem ofensivas. 
<p>- Nossa. – Sebastian arregalou os olhos. – O Will sabe?
<p>- Não sei. Eu estava procurando por ele. 
<p>- Quem fez isso? – Jason perguntou.
<p>- Ninguém sabe, parece. 
<p>- Aposto que foi a Giovanna. – Sebastian concluiu.
<p>- Ou qualquer garota da escola já que a Emily não é uma das favoritas a rainha do Baile por aqui. – Jason não gostava muito de culpar alguém sem ter provas. 
<p>- Eu sei lá. Ashley disse que a Giovanna não sabe de nada.
<p>- Porque a Giovanna com certeza ia confessar. – Sebastian já tinha decidido em quem colocar a culpa. 
<p>- Oi, com licença.
<p>Uma garota tocou levemente sua mão um pouco trêmula no ombro de Sebastian. A timidez estava estampada na cara dela. Obviamente, estava desesperada o suficiente ao ponto de ter que falar com alguém.
<p>- Pois não? – Sebastian se virou para ela.
<p>- Eu passei o dia todo andando em círculos aqui totalmente perdida. – Ela riu sem graça. – Algum de vocês pode me dizer onde fica o bloco 7?
<p>- É do lado da cantina. – Jason respondeu educadamente.
<p>- E onde fica a cantina?
<p>- Você deve ser nova por aqui. – Jason estendeu a mão. – Sou Jason.
<p>- Melissa. – Ela apertou a mão dele.
<p>- Sebastian. – Ele levantou a mão para se identificar.
<p>- Christopher. – Chris fez o mesmo. 
<p>- Prazer. – Ela olhou para os três bastante envergonhada.
<p>- Olha, eu estou indo para o bloco 7 para a minha aula de Química. Se você quiser, podemos ir juntos. – Sebastian se ofereceu.
<p>- Muito obrigada, iria me ajudar bastante. – Ela pareceu aliviada. – A única coisa que eu encontrei aqui sem muito esforço foi o banheiro.
<p>- Primeiro dia é sempre difícil. – Sebastian se levantou e sorriu para ela. – Você se acostuma.
<p>- Eu espero.</p>
<center><h4>--*--</h4></center>
<p>Emily entrou quase sem ar no restaurante. Tinha corrido alguns metros. 
<p>Embora tenha saído da escola mais cedo do que pretendia, não ficou com muita pressa para ir ao encontro com seu pai, logo acabou se atrasando.
<p>- Está tudo bem? – Seu pai perguntou assim que ela se sentou na mesa de frente dele.
<p>- Estou, é que... eu perdi a hora.
<p>- Tudo bem. Eu já pedi nosso almoço, espero que goste.
<p>- Eu vou. – Ela tentou fingir uma animação, mas não conseguiu. – Ah... isso tudo é para algo especial? O que está havendo?
<p>- Nada, por que teria que haver algo?
<p>- É que... eu só achei estranho. A gente quase nunca almoça junto.
<p>- Depois do Natal, na verdade, depois... – Emily podia jurar que ele diria “Will”. – Depois que nos mudamos para cá, eu percebi que nos afastamos. Você é minha filha e eu não quero isso para nós.
<p>- E quanto a Quinn? 
<p>- Bom, eu não sei se vale a pena tentar com ela. Nós dois nos afastamos já faz muito tempo.
<p>Sim, logo depois que todos descobriram da traição. Algo que Quinn nunca perdoou e nunca perdoaria.
<p>- Estava pensando que esse almoço poderia virar uma tradição nossa. Um almoço por semana ou por mês, como você quiser. 
<p>- Ah... tudo bem. – Emily não sabia muito bem o que responder.
<p>O garçom os interrompeu trazendo a comida. Harry havia pedido para ele e sua filha um prato com frutos do mar. Emily nunca gostou muito daquele tipo de comida, mas preferiu não falar nada. 
<p>- Como está sendo seu primeiro dia de aula? Melhor que o ano passado? – Harry tentou puxar um assunto quando viu que a filha não faria.
<p>- Está bom. Normal. – Ela tentou disfarçar. Nunca diria ao pai o que tinha acabado de acontecer na escola.
<p>- E quanto ao Will? Ainda estão se dando bem? 
<p>- O que quer dizer com isso? – Emily ficou na defensiva.
<p>- Nada, eu só... Você o ama?
<p>- Sim. – Emily ficou impressionada. Como ele poderia fazer uma pergunta daquelas? – Fala, pai. – Ela não esperava que aquela conversa apareceria antes da sobremesa. Aparentemente, seu pai não conseguiu esperar. 
<p>- Filha, eu te amo e só quero cuidar de você. Te proteger. 
<p>- Ah é? 
<p>- Ele não é o cara certo para você.
<p>- Você nem o conhece direito, além do mais, não é você quem decide. 
<p>- Eu preciso intervir quando vejo minha filha tomando uma decisão errada. 
<p>- Não é errada. – Emily ficou séria. Se fosse outra pessoa, talvez a Giovanna, ela já estaria gritando.
<p>- Eu conheço esse tipo de garoto. Eles não se importam com as garotas por muito tempo e só querem uma coisa.
<p>- Will não é assim.
<p>- Realmente acha isso?
<p>- Tenho certeza. Pai, você me conhece. Se eu achasse que ele não era o certo, eu não estaria com ele. 
<p>- Talvez ele esteja te manipulando.
<p>- O quê? – Emily ia rir, mas aí percebeu que seu pai estava falando sério.
<p>- Vocês terminaram, não é? Eu não sei por que, mas deve ter tido uma razão. E então ele te convenceu a voltar.
<p>- Ele não me convenceu, eu decidi.
<p>- Você está feliz?
<p>- É claro que eu estou.
<p>- Não é o que está parecendo. Eu sou seu pai. Emily, eu sei quando está mentindo. Percebi assim que entrou aqui. O que está acontecendo?
<p>- Não é nada. É só umas garotas idiotas pegando no meu pé. Não vale a pena falar sobre isso.
<p>- O que elas estão fazendo?
<p>- Não importa.
<p>- Quer que eu fale com o diretor?
<p>- Não! Não é necessário, não foi nada demais. Só me incomodou, só isso.
<p>- O que o Will está fazendo a respeito disso? Ele precisa te proteger. 
<p>- Ele não precisa fazer nada. Ele é meu namorado, não meu guarda-costas, eu me viro. 
<p>- Por que elas estão enchendo você?
<p>- Isso é um interrogatório? – Emily largou os talheres no prato. Já estava irritada.
<p>- Eu só quero saber o que está acontecendo.
<p>- Não. Você quer uma desculpa para dizer que o Will não presta e que eu devia terminar com ele. Foi para isso que você me chamou aqui hoje, não foi? Essa baboseira de estarmos nos afastando... você não está nem aí para isso.
<p>- Filha, isso não é verdade.
<p>- Quem está mentindo agora? 
<p>- Ele vai te machucar, eu sei que vai. Não vai ser hoje, talvez não amanhã, mas um dia vai e eu não quero ver isso acontecendo. Não com você. 
<p>- O quê?
<p>- Eu não quero que ele consiga o que quer de você e depois vá embora. Porque é isso que ele vai fazer.
<p>- Do que você está falando?
<p>- As pessoas comentam. Eu já ouvi. Esse garoto...
<p>- Chega. Eu não quero ouvir mais isso. Desde quando você se importa com as fofocas dos outros? 
<p>- Não é disso que se trata.
<p>- Então é do quê? Você é um hipócrita. Está aqui tentando me dar aulas de bons costumes e julgando pessoas quando... – Emily parou de falar.
<p>- O quê? Diz. Vai, grita que nem a sua irmã. Faz isso.
<p>- Não. Eu não vou fazer isso. Só para de tentar se projetar no Will, ele não é como você e eu não sou como a mamãe. Eu estou com ele porque eu quero e não porque não posso viver sem ele. 
<p>- Você é jovem demais para entender.
<p>- É, essa é a desculpa para a maioria dos adultos. 
<p>Emily se levantou da mesa e foi embora.</p>
<center><h4>--*--</h4></center>
<p>Naquela noite, Will não conseguia parar de pensar em Emily. Ela não havia atendido suas ligações nem respondido suas mensagens a tarde toda e ele precisava falar com ela. Se Emily não atendia os telefonemas, com certeza não atenderia a campainha, por isso ele precisava de um plano B. 
<p>Will foi até a casa dela e esperou todas as luzes se apagarem para ter certeza que todos estariam no mínimo deitados em suas camas prontos para dormir. Pulou o muro da casa, escalou a parede e conseguiu chegar até a janela de Emily para bater no vidro.
<p>- O que está fazendo aqui a essa hora? – Emily respondeu a batida bem rápido abrindo a janela. Ela não parecia que estava se preparando para dormir, mesmo estando de pijama.
<p>- Eu precisava falar com você.
<p>Ela deu espaço e Will pulou para dentro do quarto dela. 
<p>- O que foi?
<p>- Não respondeu as minhas mensagens nem me atendeu quando eu liguei. Você está bem?
<p>- Will, eu estou ótima. – Diferente de quando estava com seu pai, ela nem tentou disfarçar.
<p>- Por que não me contou o que aconteceu hoje com o seu armário? Por que não me contou que tinha gente mexendo com você?
<p>- Você sempre soube que tinha gente mexendo comigo.
<p>- Não, eu sabia no começo, achei que nessa altura isso já tinha acabado.
<p>- Aparentemente, não. 
<p>- Somos namorados, eu conto tudo para você. Não foi legal eu ficar sabendo disso por outra pessoa. 
<p>- Eu não contei, eu me esqueci. Eu sinto muito, mas diferente do que todo mundo pensa, meu mundo não gira ao redor do seu. – Ela estava sendo agressiva.
<p>- Ei, eu não estou bravo com você, eu só quero saber como você está. 
<p>- Não muito bem. 
<p>- Como foi o almoço com o seu pai?
<p>- Eu realmente não quero falar sobre isso. 
<p>- O que quer falar então? 
<p>- Sobre nada. Quando eu não respondo suas mensagens nem atendo suas ligações é porque eu não quero falar com você e quero ficar sozinha, não é porque eu quero que você apareça na minha janela no meio da noite como um bandido. Achei que isso era simples de entender. 
<p>- Você está chateada e está me atacando. Eu consigo entender isso. Eu vi o que escreveram no seu armário. É totalmente normal...
<p>- Eu não estou chateada. Eu estou com raiva, com muita raiva. 
<p>- Tudo bem, então o que quer que eu faça? É só dizer. Quer que eu vá falar com quem quer que tenha feito isso e...
<p>- Não, só vai piorar.
<p>- Então eu... eu fico aqui e a gente assiste alguma coisa que te acalme e...
<p>- Will, não. Só vai embora, por favor. Eu quero ficar sozinha e...
<p>- Não, eu não vou embora. Era nossa promessa, lembra? Nunca ir embora. – Will estava ficando um pouco alterado também. – O ano virou, mas a promessa continua valendo, ela não tem uma data de validade. 
<p>- Por favor, hoje não. – Ela estava cansada. Não queria brigar. 
<p>- Eu estou falando sério. Se você quiser que eu fique, eu fico. 
<p>- Eu não quero que fique, eu quero ficar sozinha.
<p>- Emily!
<p>- Vai embora. – Ela o encarou séria. 
<p>- Que seja então. – Ela havia conseguido deixar ele com raiva também. 
<p>Enquanto Will pulava a janela para ir embora, Emily pensou em pedir para ele ficar, mas não conseguiu. Sua raiva por ele estava vencendo o amor naquela noite.</p>
</body></html>";
            }

            if (numero == 24)
            {
                lblTitulo.Text = "Capítulo 24 - Seja Lá O Que Precisa Dizer, Diga Agora";
                htmlPage.Html = @"<html>
<body>
<p><i>“Então me diga que dói, me diga que queima
<br>Me diga que é amor e que está preparada para cair
<br>Nos meus braços ou no chão
<br>Está perdido ou foi encontrado
<br>Seja lá o que precisa dizer, diga agora.”
<br><b>Say It Now – We The Kings</b></i></p>
<br>
<p>“Palavras machucam. Você aguenta ouvir o que as pessoas têm a dizer sobre você? Se você pudesse, seria sincero o tempo todo? Não aquele tipo de pessoa que dá a desculpa que é sincero só para machucar alguém com as suas palavras, eu estou falando de simplesmente não conseguir esconder a verdade, esconder o que sente. Além de não aguentar ouvir, você também não aguenta falar, principalmente se é para alguém que você ama e não quer machucar. Principalmente se é uma coisa que você não quer dizer, mas que precisa.”.</p>
<br>
<p>Emily passou pelo portão da escola exatamente na hora que o sinal tocou. Ela não gostava de chegar atrasada na sala de aula, mas era algo que devia fazer se não quisesse cruzar com ninguém nos corredores. 
<p>A porta do seu armário havia sofrido uma raspagem para a retirada daquelas palavras. Estava precisando de uma boa mão de tinta, mas isso não era importante naquele momento. Seu cadeado havia sido consertado também. 
<p>Colocou seus livros de volta no armário, sua mochila já estava quase cedendo de tão pesada, esperava que não fossem fazer a mesma pegadinha duas vezes, não seria mais tão engraçado. 
<p>- Olha só se não é a namoradinha. – Uma garota passou pelo corredor e assim que viu Emily fez o comentário. – Vadia.
<p>- Me chamou de que? – Emily fechou a porta do armário imediatamente e seguiu em direção a garota.
<p>- Oi? – A garota se virou para Emily e se fez de desentendida. 
<p>- Do que você me chamou?
<p>- Me desculpa. Eu me confundi.
<p>- Eu duvido. – Emily a encarou.
<p>- A garotinha ficou valente de repente? – Ela sorriu. 
<p>- Eu nem sei quem você é. Qual é o seu problema comigo?
<p>- Eu não tenho nada contra você, na verdade, eu tenho é dó. 
<p>- Eu dispenso a sua dó. 
<p>- Ele diz que te ama e que daria o mundo para você. É tudo mentira.
<p>- Você não é a primeira pessoa a me dizer isso. Essa história já está ficando velha. 
<p>- Eu fui a garota que foi para o banheiro com ele naquele dia depois dele terminar com a Giovanna. – Ela ficou séria. – Passei meses sendo taxada de vadia enquanto ele era o maioral. 
<p>- Ele não te forçou a fazer nada.
<p>- Não, mas me convenceu dizendo coisas bonitas, acho que as mesmas coisas que ele diz para você. Eu não estou nem aí para Giovanna e as suas amiguinhas. 
<p>- Eu sinto muito, mas ele não é mais assim. Ele me ama. 
<p>- Você não é diferente de mim nem da Giovanna nem de nenhuma outra. Talvez ele só tenha mudado o jeito de “caçar”. Ele não ama você, só ama a si mesmo. 
<p>- Não. Eu não aceito isso. 
<p>- Olha, essas garotas não vão desistir e ele não vai poder te proteger o tempo todo. Acho que está na hora de você colocar na balança tudo isso.
<p>- Acabou de me chamar de vadia e agora está me dando um conselho? Eu dispenso.
<p>Emily saiu da frente dela e voltou para o seu armário.</p>
<center><h4>--*--</h4></center>
<p>Giovanna estava esperando Will na frente do armário dele.
<p>- Olá.
<p>- Oi. – Will foi educado.
<p>- Eu queria dizer que eu sinto muito pelo o que aconteceu entre você e o Kevin – Ela puxou conversa. 
<p>- O que você quer? Não está aqui para dizer isso.
<p>- Eu queria que tudo voltasse ao normal com a gente.
<p>- Eu passo. – Will abriu o armário para pegar os livros e afastou um pouco Giovanna. 
<p>- Will, eu estou tentando. Pelo bem do Kev...
<p>- Então pede para as suas fiéis seguidoras, ou sei lá com as chama, comensais da morte, para pararem de perseguir a Emily.
<p>- Eu não sei do que você está falando.
<p>- Foi você que pichou o armário dela? Ou convenceu a Ashley? Ou qualquer outra?
<p>- Não pode me acusar assim.
<p>- Olha só, você pode me irritar o quanto quiser. Tira meu irmão de mim, transforma minha vida num inferno se é o que você acha que eu mereço, mas deixa a Emily em paz. – Will a encarou. 
<p>- Will, esquece essa garota. 
<p>- Você é que devia me esquecer. Você tem o Kevin, ele ama você, aproveita isso.
<p>- Mas eu não o amo. Eu amo você. 
<p>- Que pena do meu irmão então. 
<p>Will fechou seu armário e saiu andando. Não conseguia mais olhar para a cara daquela garota.</p>
<center><h4>--*--</h4></center>
<p>- Pessoal, essa aqui é a Melissa.
Todos na mesa ficaram olhando Melissa se sentar ao lado de Sebastian no almoço exceto Will que nem percebeu o irmão chegando, sua atenção estava toda voltada para a tela do seu celular.
<p>- Prazer. – Ela ficou um pouco tímida olhando para todo mundo. 
<p>- Esses são o Jason, que você já conhece, Amanda... – Sebastian começou a apontar. – Chris que você também já conhece, Will, minha namorada Quinn... Ainda falta algumas pessoas, mas não vai faltar oportunidade para você conhecer. 
<p>- Que legal.
<p>- Então, já está agindo como uma nativa? – Jason brincou. 
<p>- Bom, hoje eu achei a sala da minha primeira aula sozinha, então vamos considerar um avanço. – Melissa tentou falar calmamente e demonstrar o mínimo de timidez possível.
<p>- De onde você veio? – Quinn perguntou, curiosa.
<p>- De Ohio. Meus pais se separaram e minha mãe conseguiu um trabalho aqui em Los Angeles. Queria recomeçar. 
<p>- Eu me mudei para cá ano passado, Nashville. Meus pais usaram a mesma desculpa de querer recomeçar. – Quinn revirou os olhos. Achava que essa história de recomeçar era uma palhaçada.
<p>- Sinto muito pelos seus pais. Sei como é ter pais separados, uma droga. – Jason se solidarizou. 
<p>- Ah, tudo bem. Meu pai não era nenhum “pai do ano”.
<p>Will de repente se levantou. Jason que estava do seu lado se assustou por não ter tido nenhum aviso prévio. 
<p>- Para onde você vai? – Ele perguntou.
<p>- Vou ver se encontro a Emily. Foi um prazer te conhecer, Melinda.
<p>Will pegou sua bandeja, colocou seu celular no bolso e saiu bem apressado. 
<p>- Emily é a namorada dele. – Sebastian situou Melissa. – Estão passando por um lance. Complicado.
<center><h4>--*--</h4></center>
<p>Will havia mandando uma mensagem para Emily enquanto assistia sua primeira aula entediante de Sociologia e não obteve nenhuma resposta até aquela hora, a do almoço. Ele queria lhe dar espaço como ela mesma pediu na noite passada, mas aquilo era mais forte do que ele. Simplesmente não conseguia.
<p>Ele foi até o armário dela. O armário que ele passou quase a tarde toda riscando com uma faca da cozinha para tirar a tinta e se livrar daquelas palavras que haviam escrito, logo depois de ouvir do diretor em sua própria sala que não poderia fazer nada para ajudar, o zelador estava ocupado fazendo coisas mais importantes.
<p>O lugar estava vazio. 
<p>Sua segunda tentativa foi a biblioteca. O refúgio de Emily de todos os dias. O lugar estava vazio, isso era normal. Segundo dia de aula, ninguém estaria atolado de deveres pegando livros para fazer pesquisas. 
<p>Ele podia ir até a sala que seria a próxima aula de Emily, mas sabia que ela não iria aparecer. Amanda havia avisado que ela não tinha aparecido nem na primeira aula.</p>
<center><h4>--*--</h4></center>
<p><i>- Oi, você ligou para mim. Não posso te atender agora, mas deixa uma mensagem que eu te respondo, tudo bem?</i>
<p>Will ouviu a voz de Emily no celular.
<p>- Nossa, agora está indo direto para a caixa-postal. Excelente. – Will respirou fundo. – Ems, eu sei que você não quer falar comigo. Você não aparece na escola faz dois dias, não responde minhas mensagens e de acordo com a nossa última conversa, você não quer que eu apareça aí. Olha, eu realmente não sei o que fazer. Eu não consigo pensar em algo para te dizer e tudo ficar bem, porque eu não sei o que está acontecendo. Você não deixa a Quinn falar para mim, você não quer falar para mim, então eu... Eu estou preso. Eu preciso que converse comigo, eu preciso que diga o que está havendo. – Ele fez uma pausa. – Eu não vou te ligar mais, tá bom? Quando estiver pronta, eu vou estar aqui te esperando. Amo você, tchau. 
<p>Ele desligou. Sua vontade era de jogar o celular no mar e observar ele afundar sentado em cima daquela pedra, mas ele também precisava do aparelho para escutar música no último volume. A música era mais importante que o seu acesso de raiva.</p>
<center><h4>--*--</h4></center>
<p>- Tem falado com a Giovanna ultimamente? 
<p>Chris e Ashley estavam dando uma volta no parque naquela tarde. 
<p>- Todos os dias, por quê?
<p>- O que você sabe sobre essa história da pichação do armário da...
<p>- Não foi ela, Chris. – Ashley já mudou de humor. 
<p>- Você não está mentindo, está?
<p>- Não!
<p>- Mas ela está enganando o Kevin, isso você não pode negar.
<p>- Por que você não fala isso para ela? Eu não tenho nada a ver.
<p>- Mas vocês são melhores amigas. Você devia conversar com ela e...
<p>- Eu não vou fazer nada. Ela é bem grandinha para resolver as suas coisas. Vamos falar de outra coisa?
<p>- Quer dizer que ela fala essas coisas para você sobre enganar o Kevin, sobre estar obcecada pelo Will e você simplesmente ignora? 
<p>- Chris!
<p>- Você sabia sobre o “Anti-Emily”?
<p>- Eu cansei de você.
<p>Ashley foi embora e Chris conseguiu a sua resposta só de olhar para a sua namorada.</p>
<center><h4>--*--</h4></center>
<p>Era sexta-feira. O pátio da escola estava vazio depois do almoço. A consciência de Emily de matar aula nos últimos três dias já estava pesando, então ela resolveu aparecer no segundo tempo. Com sorte, ela entraria na sala de aula antes de encontrar com alguém. Nem em seu armário ela passaria para evitar um encontro inesperado como da última vez. 
<p>O silêncio do lugar foi quebrado com alguém gritando pelo nome dela de uma distância considerável. Emily reconheceu a voz instantaneamente. 
<p>- O que você quer? – Emily se virou e viu Giovanna correndo em sua direção. 
<p>- Andou sumida. Eu tinha esquecido um livro no armário e... que sorte que eu te encontrei. 
<p>- É, que sorte. – Emily estava com a cara fechada. – Agora eu tenho que ir, estou atrasada.
<p>- Devíamos conversar antes.
<p>- Giovanna, não começa, tá bom? Já não fez o bastante para uma semana?
<p>- Do que está falando?
<p>- Acha que eu sou trouxa? Eu sei que foi você que pichou meu armário.
<p>- Está enganada.
<p>- Não tem ninguém aqui. Não precisa mentir. Não é mulher o suficiente para admitir? 
<p>- Você ficaria surpresa com o que eu posso conseguir com um simples choro. – Ela sorriu.
<p>- Então é pior do que eu pensei. Não tem coragem nem de fazer, precisa que outra pessoa faça. 
<p>- Olha quem fala, a garota que foge. Aparentemente a conversa com a Daisy realmente te abalou. 
<p>- Daisy?
<p>- “Eu nem ligo para a Giovanna e blábláblá”. Ela deve ter dito coisas desse tipo. – Emily então se lembrou. – Quando eu descobri que foi com ela que o Will me traiu, eu fiquei puta e parti para cima dela, depois de um tempo, eu percebi que éramos iguais, que tínhamos sido enganadas.
<p>- Você é doente e eu não vou perder o meu tempo com você nem com mais nenhuma dessas suas amiguinhas.
<p>- Eu ainda não terminei. – Giovanna segurou firme o braço de Emily quando ela ameaçou ir embora.
<p>- Me solta. – Emily começou a balançar seu braço, mas a mão de Giovanna parecia estar grudada a ele. 
<p>- Eu odeio você com todas as minhas forças. – Giovanna se aproximou mais e olhou bem fundo nos olhos de Emily. – Eu mando nessa escola e não vou te dar um minuto de descanso, você está me ouvindo? Não é ameaça, é um fato.
<p>- Você quer o Will? Ótimo, vai atrás dele, eu não me importo. Eu só quero que me deixe em paz! – Emily conseguiu se soltar de Giovanna. – Porque eu também estou cansada de você. Eu ainda não te odeio, mas falta bem pouco.
<p>- Eu já saquei você há muito tempo. Não passa de uma mosca morta indefesa que implora pela proteção de um cara porque sabe que é disso que eles gostam, de uma garotinha idiota para colocar na mão.
<p>- Cala a boca. – Emily estava um pouco assustada, mas mesmo assim bateu de frente com Giovanna. – Não vou deixar você me ofender.
<p>- Você não pode fazer nada. 
<p>- Tudo bem, então o quê? Vai, diz tudo o que quer dizer! – Emily começou a gritar. – VADIA CAIPIRA NÃO FOI O SUFICIENTE? 
<p>- Nem perto. Eu vou acabar com você, assim você vai para o buraco em que estava e não volta mais. 
<p>- Você é maluca. – Emily olhava para Giovanna totalmente incrédula de que aquilo estava realmente acontecendo.
<p>- Você não presta, eu devia ter escrito bem mais do que vadia caipira no seu armário. EU DEVIA TER GRITADO PARA TODO MUNDO OUVIR! EU DEVIA TER DITO QUE VOCÊ NÃO PRESTA! QUE VOCÊ É UMA VADIA! UMA VAGABUNDA! UMA INFELIZ IGNORANTE! UMA GRANDE PUTA!
<p>Foi tudo tão rápido e inesperado que Giovanna nem teve tempo nem reflexo o suficiente para se defender. O tapa a pegou em cheio e teve força o suficiente para fazer o rosto dela se virar.
<p>- Me desculpa, eu não... – Emily também ficou em choque.
<p>- Como se atreve a me bater?
<p>- Você... você... 
<p>- Vai se arrepender. VOCÊ VAI SE ARREPENDER POR ISSO!
<p>Giovanna levantou a mão para dar o troco, mas Emily se defendeu. Ela segurou o braço de Giovanna e o empurrou para longe de seu rosto.
<p>- Não encosta em mim! – Emily gritou. – Já chega!
<p>- Só acaba quando eu quiser.
<p>Giovanna deixou para trás os bons modos e a delicadeza que já havia sumido daquela conversa faz tempo e foi para cima de Emily. Por ser maior, ela conseguiu com facilidade derrubar a garota no chão, mas não contava com a força que Emily tinha no braço e em como ela estava se desvencilhando dos ataques de Giovanna. 
<p>- WILL É MEU! SÓ MEU!
<p>- Me solta! Sai de cima de mim! – Emily segurava bem firme os braços de Giovanna para não ser atacada enquanto sentia o peso de outro corpo em cima do seu e via um rosto totalmente descontrolado na sua frente. – Me solta!
<p>- WILL É MEU! ESTÁ ME OUVINDO?! ELE É MEU! EU NÃO VOU DEIXAR QUE VOCÊ TIRE ELE DE MIM!
<p>- Você é louca! Me solta! 
<p>O sinal do fim da aula tocou. Era questão de tempo agora até que alguém saísse de um prédio e fosse para outro, cruzasse o pátio e visse as duas brigando no chão.
<p>- Gente, para! – De repente, Emily ouviu um grito que não era de Giovanna. – Sai de cima dela!
<p>Amanda puxou Giovanna tentando tirar ela de cima de Emily, mas foi inútil. Ela não tinha força o bastante e só conseguiu ser empurrada e cair no chão.
<p>- NÃO IMPORTA! EU VOU MATAR VOCÊ!</p>
<center><h4>--*--</h4></center>
<p>Will empurrou sem querer Melissa enquanto tentava sair da sala de aula com um pouco de pressa.
<p>- Ah, me desculpa. – Ele se apressou a dizer. – Espera um pouco, eu conheço você. É a amiga do Sebastian, Melinda, não é?
<p>- Melissa. – Ela o corrigiu. – E você é o Will.
<p>- Exato.
<p>- O que está acontecendo?
Os dois notaram um tumulto. As pessoas pareciam estar ansiosas para saírem das salas e irem em direção ao pátio mais que o normal, era sexta-feira, mas mesmo assim era estranho. 
<p>- O que está havendo? Ei! – Ele chamou uma garota que passava do seu lado toda empolgada. – O que está acontecendo?
<p>- Estão falando que a sua namorada e a Giovanna estão saindo no tapa no meio do pátio.
<p>- O quê?
<p>Ela falou sorrindo e não esperou ele dizer mais nada, saiu correndo para ver se conseguia pegar pelo menos o final da briga.
<p>- Quem é Giovanna? – Melissa estava perdida.
<p>- Droga!
<p>Will começou a empurrar todo mundo e correu em direção ao pátio com Melissa logo atrás dele.
<p>O pátio estava lotado de gente e muito barulhento. Will não conseguia ver nada além da multidão.
<p>- Saiam da frente! Vai logo! Sai da frente!
<p>Ele começou a empurrar as pessoas para chegar ao meio daquilo e aquilo que viu foi a coisa mais bizarra que já podia ter visto. Giovanna estava totalmente descontrolada em cima de Emily enquanto balançava seus braços de um lado para o outro tentando atacar o rosto da garota, mas estava sendo impedida pela própria Emily que segurava bem forte os dois braços de Giovanna os afastando do seu rosto. 
<p>Amanda também estava lá fazendo de tudo para tentar tirar Giovanna de cima de Emily, o que era inútil, até seu rosto tinha sido afetado. Tinha um arranhão enorme na bochecha.
<p>- Tá legal, já chega! JÁ CHEGA!
<p>Will puxou Giovanna pela cintura e a afastou de Emily. Amanda, assustada, correu para o outro lado, para os braços de Jason que chegou ali segundos depois de Will. Enquanto Will ajudava Emily a se levantar, ele olhou para atrás e viu Giovanna abraçada com Kevin que tinha aparecido do nada naquela multidão que foi se dispersando aos poucos assim que a briga acabou. 
<p>- O que aconteceu aqui?! – Will gritou.
<p>- Ela me atacou.
<p>Para o espanto de Will, e pelo que parecia, de todo mundo, Giovanna começou a chorar nos braços de Kevin.
<p>- Eu estava passando e sem nenhuma razão, ela veio para cima de mim. Eu só estava tentando me defender. – As lágrimas saíam fácil dos olhos de Giovanna.
<p>- O quê? – Amanda falou de longe ainda um pouco assustada.
<p>- Ela me xingou. Me chamou de vadia, disse que eu não prestava e... – O choro só aumentava. – Eu fiquei com tanto medo, eu nunca...
<p>Giovanna estava sendo tão convincente que se Emily não soubesse a verdade, até ela estaria duvidando e acreditando naquela versão da história. 
<p>- Isso não é verdade! – Emily gritou enquanto se apoiava em Will.
<p>- Por que você me odeia? – Giovanna chorou mais alto. Ela estava dando um show para a escola toda. – Eu te disse que não tenho nada a ver com o que fizeram no seu armário. Você é louca! 
<p>- Você...
<p>- Vamos sair daqui. – Will falou baixinho para Emily. – Vamos.
<p>Ele percebeu que a namorada mal conseguia se mexer de tão abalada que estava, então precisou de uma força maior para tirá-la de perto daquele circo.
<p>- Você está bem?
<p>Eles entraram na primeira sala vazia que encontraram. Emily andou até o lado oposto da sala e colocou as mãos no rosto. Seu estado era um pouco deplorável. Sua calça preta estava com manchas de poeira do chão do pátio, sua camisa tinha um corte sutil em uma das mangas, seu cabelo que já era volumoso estava todo embaraçado, seus braços continham alguns arranhões e seu rosto estava muito vermelho. 
<p>- Você está bem? – Will repetiu.
<p>- O que você acha?! – Ela então começou a gritar. – É obvio que não! Você viu o que ela fez! Você viu... Ela é uma mentirosa! Ela é...
<p>- Eu sei disso, Ems. – Will tentou se aproximar da namorada, mas ela se afastou mais ainda.
<p>- Eu não acredito nisso. Aquela garota é louca.
<p>- Olha, tenta ficar calma, tá bom? Eu vou trazer alguma coisa para você comer e aí a gente fica aqui até você se acalmar.
<p>- Eu não vou me acalmar.
<p>- Ems.
<p>- Não. Ela está me deixando louca também.
<p>- Isso vai passar.
<p>- Quando?! Quando isso vai passar?
<p>- Olha, eu sei o que você está passando, tá bom?
<p>- Não sabe, não.
<p>- Emily, ela também está no meu pé, tá? Eu também sinto o que você sente. Ela está usando meu irmão para me atingir e...
<p>- Você não dá a mínima para o seu irmão! Essa é a verdade! – Emily começou a chorar. – Você tenta criar uma relação entre todo mundo porque acha que é isso que deve fazer, mas no final, você não dá a mínima! Se você não tivesse esse código de irmandade tatuado na sua cabeça, você estaria pouco se fodendo para o Kevin!
<p>- Emily. 
<p>- Não foi no seu armário que escreveram “Vadia”, não é de você que caçoam e apontam e olham feio! Você é o maioral que ficou com todo mundo! Eu sou a idiota! 
<p>- O que você quer que eu faça?! Eu não posso apagar isso! Achei que não se importava com o meu passado.
<p>- Eu não me importo! Não se trata disso, se trata de tudo ao redor. Se trata da Giovanna não largando do meu pé e infernizando a minha vida! Se trata do meu pai o tempo todo dizendo que você não presta e que eu preciso me afastar de você! Se trata de todo dia aparecer uma garota do além dizendo que eu preciso tomar cuidado! Se trata de eu sair no tapa com uma garota no meio da escola por causa de cara!
<p>- Eu sinto muito. Eu realmente queria te proteger disso, mas eu não sei como. 
<p>- Você não sabe porque isso não te afeta.
<p>- Está sendo injusta. Eu passei a semana toda preocupado com você! Eu sabia que você estava mal e a única coisa que eu recebi foi NADA! O escuro! Só isso! Eu passei um tempão raspando aquelas palavras idiotas daquela DROGA de armário depois que eu descobri que ninguém ia fazer isso! Você me excluiu! Não pode chegar aqui e dizer que eu não me importo!
<p>- Não foi isso que eu quis dizer.
<p>- Então o que você quer dizer, Emily? Por que está fugindo de mim? Quer terminar e não sabe como dizer? É SÓ DIZER!
<p>- Eu te amo. – Parecia mais que Emily estava tentando convencer a si mesma.
<p>- Aparentemente, não o bastante.
<p>- Não é justo.
<p>- Eu fiquei, tá legal? Eu cumpri a promessa TODAS AS VEZES! Eu fui além das suas inseguranças e das suas dúvidas e do seu pai e de tudo entre a gente! Você não é a única cansada por aqui. A única diferença é que eu fiquei e ainda tô aqui, mas você não está mais. Então diz.
<p>- Eu preciso de um tempo.
<p>- Não. Sem essa de “dar um tempo”, todo mundo sabe o que quer dizer. Eu não quero sair daqui e ficar me preocupando em quando você vai aparecer dizendo que está tudo bem e nós dois sabemos que você não quer dar um tempo. – Os dois se encararam. – Se você acha que vai ser mais fácil, ótimo. Só diz. Eu não vou morrer por isso! Eu vou ficar bem! Não agora, mas vou ficar!
<p>Os dois ficaram em silêncio por alguns segundos e então... 
<p>- Acabou. – As palavras quase não saíram da boca de Emily. 
<p>- Ótimo. 
<p>Will deu as costas e saiu da sala. Emily escondeu seu rosto nas mãos e começou a chorar descontroladamente.</p>
<center><h4>--*--</h4></center>
<p>Amanda chegou em casa bem irritada. 
<p>Jason vinha atrás dela junto com Sebastian e Quinn. 
<p>- Aquela garota é uma infeliz! – Ela foi em direção a sala tentando pentear seus cabelos que estavam um desastre. – Ela é uma doente e maluca...
<p>Amanda parou de falar quando viu Kevin sentado no sofá junto com Giovanna.
<p>- O que ela está fazendo aqui? – Os dois olharam para ela confusos. – Quero que saia da minha casa agora!
<p>- Ela não vai embora, Amanda. Ela está comigo. – Kevin falou e voltou a sua atenção para a televisão assim como a namorada que parecia bem mais feliz do que estava no pátio da escola aos prantos. 
<p>- Não me interessa. Ela pode estar até com o Papa. Tira ela daqui ou eu mesma tiro, mas vai ser pelos cabelos. 
<p>- Amanda. – Jason falou atrás dela.
<p>- Eu quero ela fora daqui agora!
<p>- O que está acontecendo? – Chris apareceu no topo da escada. – Que gritaria é essa? É só nossos pais viajarem que aqui vira uma zona?
<p>- Chris, coloca juízo na cabeça oca do seu irmão e faz ele tirar essa cobra da nossa casa! – Amanda estava histérica. 
<p>- Olha só como fala. – Kevin se irritou e se levantou.
<p>- Realmente acreditou no papinho dela? Naquela encenação digna de Framboesa de Ouro? Eu achava que você era burro, mas não tanto.
<p>- Gente, vamos nos acalmar. – Sebastian falou um pouco distante.
<p>- Não, deixa ela. – Quinn incentivou a amiga. – Essa aí tem sorte. Se eu não estivesse nessa casa, já teria arrancado os dentes dela um por um. 
<p>- Vamos todos ficar calmos. – Chris falou ainda da escada. – Eu acho bem melhor.
<p>- Eu só vou ficar calma quando essa vaca sair daqui!
<p>- Cuidado! – Giovanna também se levantou. – Não estou aqui para ouvir grosseria.
<p>- Não, está aqui para levar tapa nessa sua cara gorda!
<p>Amanda avançou, mas Kevin ficou na sua frente, e se já não bastasse, Jason foi até ela e a afastou do casal. 
<p>- Você não vai conseguir nada com escândalos. – Jason falou só para ela ouvir. – Tenta se acalmar. Você está dando o show que ela quer.
<p>Todos ouviram o barulho da porta abrindo. Ficaram em silêncio e totalmente imóveis quando viram Will passar pela porta e ir até a sala.
<p>- Will. – Chris falou um pouco preocupado.
<p>- Will, como está a Emily? – Quinn perguntou.
<p>Ele não prestou atenção em ninguém a não ser em...
<p>- Sai daqui agora. – Ele falou calmo, porém firme encarando Giovanna. 
<p>- Ela não vai sair. Ela tem o direito de estar aqui tanto quanto qualquer um. – Kevin se posicionou. 
<p>- Tira ela daqui agora. – Will foi então até Kevin. 
<p>- Não. – Kevin o encarou.
<p>- Kev, eu não estou no meu melhor humor. Eu preciso que tire ela daqui.
<p>- Eu já falei que não. Ela é minha namorada e vai ficar aqui e você vai ter que lidar com isso. 
<p>- Inacreditável. – Will bufou. – Qual é o seu problema?
<p>- O meu problema? O único problema daqui é você. Diz a verdade, Will. Você banca o bom irmão e diz que está tudo bem, mas aí no fundo, suas entranhas estão se remoendo de raiva.
<p>- Raiva?
<p>- Você odeia o fato de eu estar namorando a Giovanna e de eu amá-la de um jeito que você nunca conseguiu. 
<p>- Gente, vamos nos acalmar. – Chris estava ficando assustado. – Vamos todos sentar e...
<p>- Não, eu já cansei de fingir. – Kevin falava cada vez mais alto. – Você não ficou satisfeito com toda a merda que você fez ela passar, não é, Will? Você queria mais. Você queria que ela ficasse no seu pé para o resto da vida para você poder pisar nela ainda mais. Não consegue aceitar que ela está seguindo em frente e que está feliz com outra pessoa que não seja você. 
<p>- Você é um idiota.
<p>- Você é uma pessoa ruim, Will. Espero que a Emily perceba isso logo e seja feliz bem longe de você. Assim como a Giovanna está sendo agora. Eu quero você bem longe dela, está me ouvindo?! Eu não quero você falando com ela! Você não vai mais afetá-la, está ouvindo?! Ela é minha! Fica longe dela!
<p>- Eu disse que eu não estava no meu melhor humor. – Will fechou o punho e socou Kevin com um gancho de direita. 
<p>Kevin caiu em cima da mesinha de centro da sala e a quebrou. Will foi para cima e continuou socando o rosto dele. Os telespectadores demoraram um pouco para assimilar a cena e finalmente entender o que estava acontecendo. Segundos depois, Chris estava descendo as escadas correndo, Jason e Sebastian estavam segurando com todas as forças um Will furioso e as garotas só conseguiam cobrir a boca com as mãos após o choque. 
<p>Will se desvencilhou dos amigos, olhou para um Kevin todo ensanguentado caído no chão e então saiu de casa totalmente desnorteado.</p>
<center><h4>--*--</h4></center>
<p>Kevin tremia enquanto Amanda limpava o seu rosto cheio de sangue na pia da cozinha. Seus lábios estavam cortados, seu nariz, um pouco inchado, ainda sangrava e ainda havia um corte acima do olho.
<p>- Eu nunca achei que ele fosse me bater. – Kevin falou.
<p>- É, nem eu. – Amanda respondeu um pouco seca.
<p>- Eu sei que vocês estão contra a Giovanna, mas ela...
<p>- Kev, não diz mais nada, acho que todo mundo já disse o suficiente por hoje. 
<p>- Eu pichei o armário da Emily. 
<p>- Parabéns. – Amanda não demonstrou surpresa, não porque já esperava, mas sim porque nada mais a surpreenderia naquele dia.</p>
<center><h4>--*--</h4></center>
<p>- Will! Will!
Jason e Sebastian haviam corrido atrás do amigo. Ele estava sentado em um lugar isolado da praia. Com olhos vermelhos e inchados de tanto chorar e dorsos da mão machucados por causa dos socos. 
<p>- Will. – Jason parou na sua frente. 
<p>- Como ele está? Ele está bem? – Will falou assustado e ainda chorando. – Ele está bem?
<p>- Está. – Sebastian se sentou ao lado dele. – Se acalma, ele está bem.
<p>- Eu não queria bater nele, eu não... Eu não queria bater nele.
<p>- A gente sabe. – Jason se sentou do outro lado dele. – Está tudo bem.
<p>- Não, não está. Eu não devia... Eu não devia... – Will ainda estava em choque. 
<p>- Vai ficar tudo bem. – Sebastian o abraçou e ele desabou em chorar. 
<p>- Estamos aqui. – Jason o abraçou também. – Estamos aqui.</p>
<br>
<p>“Palavras machucam. Às vezes até mais que um soco. E você não pode voltar atrás, pode até se desculpar, pode tentar compensar, mas elas sempre vão estar lá na lembrança da outra pessoa e da sua também. Não dá para desdizer. Embora você esteja muito arrependido. Então o que você faz? Você lida com isso!”.</p>
</body>
</html>";
            }
        }

        public void clkAbrirComentar(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MyPopupPage("EsseMundoVaiMudar", condicao.ToString()));
        }

        public void clkIrMenu(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MenusView.MenuEsseMundoPage());
        }

        public void clkAbrirProximo(object sender, EventArgs e)
        {
            if (condicao + 1 > 24)
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