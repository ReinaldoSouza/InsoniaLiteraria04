using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InsoniaLiteraria04.Database;
using InsoniaLiteraria04.Global;
using InsoniaLiteraria04.Helper;
using InsoniaLiteraria04.Model;
using Rg.Plugins.Popup.Services;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InsoniaLiteraria04.EsseMundoView
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Capitulo3Page : ContentPage
	{
        DBFire service;
        public int condicao;

        public Capitulo3Page(int numero)
		{
			InitializeComponent ();
            service = new DBFire();
            condicao = numero;
            mostrarCapituloSalvo("EsseMundoVaiMudar", "Capitulo" + numero.ToString());

            if (numero == 13)
            {
                lblTitulo.Text = "Capítulo 13 - Contando Estrelas";
                htmlPage.Html = @"<html><body>
<p><i>“Ultimamente, eu tenho, eu tenho perdido o sono
<br>Sonhando com as coisas que poderíamos ser
<br>Mas, amor, eu tenho, tenho rezado muito
<br>Disse, chega de contar dinheiro
<br>Nós vamos contar estrelas”
<br><b>Counting Stars – OneRepublic</b></i></p>
<br>
<p>“Eu não acredito em destino. Não acredito que em alguma hora as coisas vão começar a se encaixar e eu vou perceber que nada daquilo aconteceu por acaso. No que eu acredito? Bom, eu acredito na realidade. Se eu não estivesse saído do aeroporto para tomar um ar, eu não teria visto a Emily e ajudado ela com as malas. Com certeza eu não iria falar com ela na praia, mesmo que ela me chamasse a atenção. A gente se cruzaria na escola e talvez até... São várias possibilidades, não é como se fosse para ser ou algo assim.”.</p>
<br>
<p>A praia estava muito bonita naquela noite. Estava deserta, não era época para muitos turistas e a temperatura havia caído um pouco. Tinha acabado de cair uma chuva, a areia ainda estava molhada. Will e Emily estavam deitados nela mesmo assim. O braço dele estava em volta dela e estavam bem próximos um do outro.
<p>Eles conseguiam ouviu o barulho do mar enquanto olhavam para o céu estrelado e ainda conseguiam sentir o coração batendo um do outro.
<p>- Quer saber um segredo? – Emily cortou o silêncio.
<p>- Claro.
<p>- Eu não tenho medo do mar só de noite. Eu tenho medo de dia também. – Ela riu de vergonha.
<p>- O quê? É por isso que você nunca aceita dar um mergulho quando estamos aqui. Achei que era para não molhar sua roupa. – Will franziu a testa. – Olha, tudo bem não saber nadar, eu também não sei muito bem.
<p>- Não é só isso. É que ele é tão grande.
<p>- Mas é isso que faz ele ser tão interessante.
<p>- Meu avô sempre dizia isso, também dizia que o mar era umas das coisas mais bonitas que Deus criou e que um dia o veríamos juntos. 
<p>- Agora pode mandar uma foto para ele ou talvez trazer ele para cá. Avôs me adoram. – Will brincou.
<p>- Ele morreu há dois anos.
<p>- Que droga. Eu sinto muito. 
<p>- Às vezes, eu acho que eu sou a única que não seguiu em frente. 
<p>- É diferente para cada um. Lidar com a perda nunca é igual.
<p>- Parece que fala por experiência própria. 
<p>- Bom, eu nunca perdi alguém, mas já foi por pouco. Longa história. – Ele já fechou o assunto para evitar perguntas que ele não ia poder responder.
<p>- Entendi.
<p>- Isso afeta a gente e nos muda. 
<p>- É. Tem gente que comete erros e culpa essas coisas.
<p>- Como assim? – Will ficou confuso.
<p>- Tem uma coisa que eu não te contei, eu deveria ter te contado há muito tempo, na verdade...
<p>- Ems, só fala. – Ele sorriu para encorajá-la.
<p>- Lembra no jantar com os meus pais em que ele contou aquelas coisas e a linda história de amor dele com a minha mãe?
<p>- Como esquecer? Ainda tenho pesadelos com aquele discurso.
<p>- Aquela história não é bem verdade.
<p>- Como assim? Eles não se conheceram com dez anos e descobriram que eram o amor um da vida do outro? – Ele foi sarcástico.
<p>- Meu pai teve um caso por alguns meses.
<p>- O quê? Mas como?
<p>- Depois que meu avô morreu, a gente resolveu fazer uma viagem em família, tipo umas férias para a gente se reconectar. Minha mãe sempre quis ir para Nova York, ver um musical na Broadway. – Ela riu ao lembrar. – Meu pai conheceu uma mulher lá e ficaram juntos. Quando voltamos, ele vivia dizendo que tinha viagem de negócios para fazer e voltava para Nova York. Minha mãe ficou desconfiada e em uma dessas viagens, ela o seguiu e descobriu. Ficaram dois meses separados. Depois de tanto ele pedir, ela o perdoou. Se mudar de estado... eles falaram que era por causa de um emprego, mas ficou na cara que era só eles tentando recomeçar.
<p>Will ficou em silêncio procurando palavras para tentar dizer algo, mas não conseguiu.
<p>- A Quinn ficou morrendo de raiva, ela chegou a bater boca com o meu pai e por isso se recusou a vir de imediato. Ninguém fala sobre isso. Minha mãe tenta o máximo fingir que isso nunca aconteceu e meu pai... começou a fazer de tudo para demonstrar o grande amor que ele sente por todos nós.
<p>- E quanto a você? Como lidou com isso?
<p>- Eu não consigo mais enxergar esse amor deles. Acho que estão juntos por conveniência ou comodismo, mas por amor não, eu acho que acabou. Ele se desculpou e disse que estava perdido e triste, confuso e que nunca teve a intenção... É, o pai dele tinha morrido, mas... Ele não beijou sem intenção uma mulher que deu em cima dele em um bar, ele continuou vendo ela por vários meses, manteve uma vida dupla. 
<p>- Eu sinto muito e não se preocupa, isso nunca vai acontecer com a gente.
<p>- Como você sabe? Um relacionamento é muito difícil. Você simplesmente começa a confiar em alguém que você acabou de conhecer. E olha o exemplo dos meus pais, depois de décadas... Eu não quero precisar tanto de você ao ponto de preferir viver com o fantasma da traição ao invés de ficar sozinha. 
<p>- Olha, eu não sei o que vai acontecer com a gente exatamente. Eu só sei que você não precisa de mim para viver nem de ninguém. A sua estrela brilha mais do que todas essas aqui. – Ele apontou para o céu. – Eu não tenho dúvidas. 
<p>Will sentiu seu celular vibrar em seu bolso da bermuda.
<p>- Não vai atender?
<p>- Não, todo mundo sabe que eu estou com você. Só querem me chatear, e além do mais, essa noite sou exclusivo para você.
<p>- Mas só até as onze. Meu pai é um traidor, mas eu ainda tenho que obedece-lo.
<p>- E ele ainda pode me matar. – Will riu.
<p>O telefone vibrou de novo.
<p>- Deveria atender, se estão insistindo deve ser importante.
<p>Will pegou o celular. Era a Amanda que estava ligando.
<p>- Mandy não sabe o que é importante ou emergência. Com certeza, ela deve estar querendo saber que horas eu vou chegar para ela poder me esperar e querer fuxicar da minha vida. Ou falar mal do Jason. – Ele colocou o celular de volta no bolso.
<p>- Bom, a gente podia ir embora, eu estou cansada. Acordei muito cedo para estudar e eu ainda tenho que estudar um pouco mais para uma prova que eu vou ter amanhã. 
<p>- Você disse que ia estudar amanhã de manhã.
<p>- Também. – Ela riu.
<p>- Você já ouviu a trágica história da garota CDF?
<p>- Não.
<p>- Bom, ela tinha uma prova de matemática para fazer, e aí ela deixou todos os amigos de lado para estudar. Todas as horas, minutos, tudo o que ela fazia era estudar. No dia da prova, ela já sabia de tudo e com certeza tiraria um dez, mas enquanto estava indo para a escola, um carro a atropelou e ela morreu. Moral da história: ela morreu e não fez a prova que tanto tinha estudado, perdeu o tempo dela. – Ele riu. – Por isso, meu lema é: nunca estudo para uma prova, não sei se vou estar vivo para fazê-la.
<p>Emily ficou calada.
<p>- Ah qual é? Você é a minha namorada, podia pelo menos fingir que achou engraçado. 
<p>Will olhou para ela. Emily estava dormindo com a cabeça encostada no peito dele. Ele ia rir, mas preferiu ficar quieto, senão se mexeria e ela acabaria acordando. Ficou observando-a por uns instantes enquanto ela dormia, parecia um anjo, parecia que estava tendo um sonho bom, parecia indefesa e que precisava de proteção.
<p>Ele voltou a olhar para as estrelas. Ficou imaginando qual era a função que elas tinham além de iluminar o céu à noite, não prestava muita atenção em Ciências. Sua mente parou no céu e ele então começou a pensar no universo e em vida fora da Terra e o quão pequenos eles eram no universo, não era muito religioso, mas pensou se Deus estaria olhando para eles naquele momento. 
<p>Will ficou um tempo esperando Emily acordar para irem embora. Não sabia que horas eram, mas seus olhos começaram a arder, e literalmente, em um piscar de olhos, ele começou a cochilar também.</p>
<center><h4>--*--</h4></center>
<p>Em questão de segundos, o sol começou a brilhar na cara dele e seus olhos mal conseguiam se abrir. Seu celular vibrava de novo no bolso. Sem querer, ele se mexeu e Emily acordou.
<p>- Que horas são? – Ela levantou a cabeça assustada depois que viu o sol.
<p>Will pegou seu celular. Eram sete da manhã, mas esse não foi o motivo da sua surpresa. Havia vinte e quatro chamadas perdidas. 
<p>- São sete horas. – Ele falou ainda com sono. – E eu tenho várias chamadas perdidas. Acho que alguém ficou preocupado por eu não ter voltado para casa.
<p>- O quê? – Emily se levantou de um salto. – Meu pai vai me matar.
<p>Will, ainda sentado na areia, começou a olhar as chamadas uma a uma. Não era só da Amanda. Sua mãe havia ligado varias vezes e seu pai. Jason havia ligado nove vezes.
<p>- Will, precisamos ir embora. – Emily tentava pentear os cabelos com os dedos, mas o vento que o mar trazia não estava ajudando nenhum pouco no processo.
<p>- Espera só um pouco. Essas chamadas me deixaram um pouco preocupado.
<p>Ele começou a digitar o número do Jason, mas antes dele terminar, seu amigo já estava ligando para ele de novo.
<p>- Jason? – Ele atendeu o telefone.
<p>-<i> Onde você esteve esse tempo todo? Tentei te ligar a noite toda.</i> – Sua voz estava estranha. Preocupada, desesperada.
<p>- É que eu acabei dormindo aqui na praia com a Emily sem querer.
<p>- <i>Isso não importa agora.</i>
<p>- O que aconteceu? Não é a primeira vez que eu passo a noite fora, geralmente eu levo a bronca cara a cara.
<p>- <i>Aconteceu uma coisa horrível, Will. Muito horrível.</i> – Jason estava com voz de choro.
<p>- O que houve, Jay?
<p>- <i>É o Sebastian, ele está internado.</i>
<p>- O quê? – Will então começou a se odiar por não ter atendido o telefone antes.
<p>- <i>Ele teve uma overdose.</i></p>
</body></html>";
            }

            if (numero == 14)
            {
                lblTitulo.Text = "Capítulo 14 - Às Vezes Eu Queria Poder Te Salvar";
                htmlPage.Html = @"<html>
<body>
<p><i>“Às vezes eu queria poder salvar você
<br>E tem tantas coisas que eu quero que você saiba
<br>Eu não vou desistir até acabar
<br>E se isso te levar para sempre
<br>Eu quero que você saiba”
<br><b>Save You – Simple Plan</b></i></p>
<br>
<p><i>Will andava de um lado para o outro por aquele corredor totalmente branco que ele não ia muito com a cara. Os médicos ainda não tinham deixado ele entrar no quarto para ver Sebastian. Ele odiava esperar. Ele não sabia o que estava acontecendo e a preocupação só aumentava. 
<p>Pareceu uma eternidade até o médico de Sebastian sair do quarto e dizer que ele já estava melhor para receber visitas. Will hesitou enquanto Jason entrava quase que imediatamente. 
<p>O que Will viu assim que entrou no quarto foi o que causou a hesitação antes de entrar, o que era só uma imaginação, uma simples suposição do estado do amigo, agora era um fato e parecia muito pior. Sebastian estava com vários tubos em seus braços e mãos conectados por agulhas, ele parecia muito mais magro e mais fraco do que o normal. Seus olhos estavam fundos e mal se abriam.
<p>- Eu não queria que vocês me vissem assim. – Ele começou a chorar com o resto de energia que ele tinha.
<p>Jason foi para mais perto dele e segurou bem forte a sua mão.
<p>- Tudo bem. – Ele o consolou. 
<p>Will ficou parado na porta, não conseguia se mexer. Olhava para Sebastian deitado com uma expressão de assombro no rosto.
<p>- Eu sinto muito. – Ele continuava chorando.
<p>- Por que não contou para gente? – Will finalmente falou, com o tom de voz um pouco agressivo.
<p>- Eu não queria que soubessem.
<p>- Por que não? Somos seus amigos.
<p>- Will, agora não é a melhor hora. – Jason olhou feio para Will o alertando.
<p>- Essa é a melhor hora sim. – Will demonstrava cada vez mais a sua raiva. – Porque eu achei que a gente confiava um no outro.
<p>- É diferente. É complicado.
<p>- Não é complicado. É simples, é muito simples. – Will quase gritou.
<p>- Simples? – Agora quem estava indignado era Sebastian.
<p>- Gente, para. – Jason sabia que a coisa podia ficar feia.
<p>- Acha que tudo isso que eu tenho é fácil? Acha que é “simples”?
<p>- Não foi isso que eu disse. Eu não faço ideia de como é isso, mas me contar era o seu dever. Eu sou seu amigo e tinha o direito de saber. 
<p>- Se vocês soubessem, iam se afastar. Eu não queria isso. Acha mesmo que eu ia jogar tudo o que a gente tem fora?
<p>- Eu nunca me afastaria de você, e se você não sabe disso, então quer dizer que não nos conhece o suficiente, mas tudo bem, a gente também não conhece você. Estamos quites.</i></p>
<center><h4>--*--</h4></center>
<p>- Will, você vai ficar bem? – Emily saiu do carro muito preocupada. Will não havia aberto a boca para nada no caminho de volta para a casa dela. Só havia dito que precisava ir para o hospital urgentemente por causa de Sebastian.
<p>- Eu preciso entrar e explicar para o seu pai que... – Will estava um pouco desnorteado.
<p>- Não, tudo bem. Eu mandei mensagem para Quinn. Ela me acobertou.
<p>- Ótimo. Ótimo. Então eu... eu tenho que ir.
<p>Ele a beijou no rosto rapidamente e voltou para o carro.
<p>- Will! – Emily foi até a janela do carro. – Não quer mesmo que eu vá com você?
<p>- Não. Não precisa.
<p>- Ele vai ficar bem. Como você disse, é só uma intoxicação alimentar. A Quinn já teve isso e ela...
<p>- É, ele vai ficar bem. – Ele confirmou.
<p>- Me avisa se acontecer algo.
<p>- Tá. 
<p>Will mal olhou para Emily, ligou o carro e foi embora.
<p>Emily abriu o portão bem devagar evitando fazer qualquer barulho. Quando entrou, viu Quinn a esperando na porta. As duas entraram em casa com muito cuidado, subiram as escadas correndo e se trancaram no quarto de Emily.
<p>- Eu fiz magica ontem para o pai não descobrir que você estava fora. Eu nunca achei que precisaria fazer isso para você, estou tão orgulhosa!
<p>Quinn se jogou na cama toda animada e sorridente, mas Emily se sentou um pouco nervosa. 
<p>- Relaxa, foi só uma noite fora. Eu quero todos os detalhes, mas... O que foi? – Quinn percebeu que a irmã estava preocupada demais.
<p>- Sebastian está no hospital. O Will foi para lá agora.
<p>- Nossa. – Quinn ficou séria. – Mas o que ele tem? Até ontem ele...
<p>- Will disse que é uma intoxicação alimentar.
<p>- Ah, isso não é grave. Eu já tive uma vez, lembra? Você sente uma azia, mas...
<p>- É esse o ponto. Ele sabe que isso não é grave, não ficaria preocupado do jeito que ele está se fosse só uma intoxicação. 
<p>- Ele está mentindo então? Essa é a sua teoria?
<p>- Sebastian tem problemas com drogas.
<p>- Quem te disse isso? – Quinn arregalou os olhos.
<p>- A Giovanna já chamou ele de doente e viciado. Acho que não é uma coisa que ele conta rindo na mesa do refeitório na hora do intervalo. 
<p>- Acha então que foi uma overdose?
<p>- Espero que não. – Emily olhou para a tela do celular na esperança de ter alguma notificação de uma mensagem de Will, mas nada. Só que agora ela também estava preocupada.</p>
<center><h4>--*--</h4></center>
<p>Will entrou correndo pela porta do pronto-socorro. Amanda foi a primeira pessoa que ele encontrou no caminho da sala de espera.
<p>- Onde você estava a noite toda? Eu tentei te ligar um milhão de vezes! – Amanda começou a gritar antes mesmo dele chegar perto dela.
<p>- Nove vezes. – Ele a corrigiu. – Como ele está?
<p>- Ele estava tendo muitas convulsões, então resolveram sedá-lo. – Amanda parecia cansada, como alguém que não pregou os olhos a noite toda. 
<p>- Quem deu essa ordem? Cadê o médico dele? Em que quarto ele está?
<p>- Will, espera! – Amanda segurou o braço do irmão. – A mamãe já está nervosa lá na sala de espera. Não vai piorar tudo com essa sua atitude. Ele já está aqui, não adianta se desesperar. Você tem que esperar.
<p>- Eu odeio esperar. 
<p>- Eu sei.
<p>- Você ao menos sabe o que aconteceu? – Will estava inquieto – Onde ele arranjou as drogas? E por que ele usou?
<p>- Não é difícil arranjar drogas em Los Angeles. – Amanda falou sem emoção. – Já a segunda pergunta, acho que vamos ter que esperar ele acordar para perguntar. 
<p>- Ele estava bem.
<p>- Eu sei. 
<p>- Como isso é possível? – Will colocou as mãos um pouco tremulas na cabeça. 
<p>- Will, se acalma. Ele vai ficar bem, ele sempre fica. 
<p>- Desculpa eu não ter atendido. 
<p>- Eu sei o que está pensando. 
<p>- Não, não sabe. Eu preciso comer, eu não comi nada. – Ele respirou fundo.</p> 
<center><h4>--*--</h4></center>
<p><i>Will estava nervoso demais para ficar naquela sala de espera do hospital e não podia ficar no quarto com Sebastian, principalmente depois das coisas que ele disse. O garoto já estava péssimo e ele conseguiu piorar ainda mais. Ele se sentou na areia da praia, seu refúgio. Se sentia culpado e com raiva, muita raiva.
<p>- Não precisa ficar com vergonha. Ele vai entender. – Jason foi atrás dele. Não gostava de deixar o amigo sozinho nessas condições. Ele sempre sabia onde Will estava.
<p>- Eu não estou com vergonha. Eu estou puto.
<p>- Will... – Ele se sentou ao lado do amigo.
<p>- Pensando bem, acho que é melhor assim. Espero que a raiva não passe.
<p>- Como assim?
<p>- Lembra quando seu pai foi embora? Você passou a vida o considerando como um herói. Quando ele foi embora, você ficou decepcionado e muito mal.
<p>- O que isso tem a ver com o Sebastian?
<p>- Vai ser mais fácil superar a morte dele estando com raiva.
<p>- Ele está bem. Não vai morrer.
<p>- Não hoje, mas vai acabar acontecendo um dia ou outro. 
<p>- Cala a boca. – Jason revirou os olhos. – Acha mesmo que vai se sentir melhor quando ele morrer se estiver com raiva dele? 
<p>- Eu sei que não. Eu só não sei o que fazer.
<p>- Você não precisa fazer nada. Basta estar lá por ele.
<p>- Eu ficar parado lá não vai ajudar em nada.
<p>- Às vezes ajuda.</i></p>
<center><h4>--*--</h4></center>
<p>- Você disse a ela que o Sebastian está com intoxicação alimentar? – Jason arregalou os olhos.
<p>- Eu estava nervoso. Foi a primeira coisa que me veio na cabeça.
<p>Jason e Will estavam na cantina do hospital comendo um sanduiche. Jason tinha passado a noite toda no hospital junto com a família.
<p>- Tem que contar a ela.
<p>- Queria falar com o Seb primeiro. 
<p>- Olha, você não precisa passar por isso sozinho. Se você não contar, ela não vai ter como te ajudar.
<p>- Eu não estou sozinho. Eu tenho você.
<p>- É, só que ela seria bem melhor nessa situação do que eu. Vamos combinar. 
<p>- Eu não queria jogar essa bomba em cima dela. Ela vai se preocupar e... Talvez quando o Seb acordar.
<p>- Will.
<p>- Não é uma coisa que dá para falar por telefone.
<p>- Então vai lá.
<p>- Eu não posso ir com o Sebastian aqui. – Will negou com a cabeça.
<p>- Ele não vai a lugar nenhum e você não pode fazer nada aqui. E eu sei que odeia esperar. 
<p>- Me liga se tiver alguma mudança. – Will odiava mesmo esperar. Falar com a Emily seria como matar aquele tempo enorme, mesmo que a conversa não fosse muito boa.
<p>- Sabe que eu ligo.</p>
<center><h4>--*--</h4></center>
<p>Will estava esperando no portão quando Emily saiu da escola.
<p>- Sempre a última a sair. – Will sorriu para ela.
<p>- Eu tinha que...
<p>- Estudar, eu sei. – Ele a beijou.
<p>- Está tudo bem? Aconteceu alguma coisa com o Sebastian? Você não me ligou e...
<p>- É que não é uma coisa para se falar por telefone. Ele ainda está na mesma. – Ele acrescentou bem rápido quando percebeu que ela ficou mais nervosa. – Eu só queria conversar com você.
<p>- Não precisa me dizer. 
<p>- Até porque você já sabe, não é? – Will sabia que a namorada não era burra, se ela não sabia pelo menos já suspeitava. 
<p>- Bom...
<p>- É, não foi uma simples intoxicação. Vamos dar uma volta?
<p>- Claro.
<p>Will só voltou a falar quando os dois estavam bem longe da escola.
<p>- Ele sofreu uma overdose ontem à noite. Como dizem, ele é um drogado, um viciado. E em algum momento da noite passada, ele resolveu sair de casa, comprar drogas e se drogar até cair inconsciente em um beco. Não foi a primeira vez e eu duvido muito que seja a última. – Cada palavra destruía ainda mais a cabeça de Will e falar aqui em voz alta era muito pior do que só pensar.
<p>- Eu não queria dizer um simples “sinto muito”. 
<p>- Tudo bem. É melhor do que fazer um escândalo. Foi isso que eu fiz quando descobri. – Will soltou uma gargalhada. 
<p>- Como isso aconteceu?
<p>- Os pais dele são uns malucos. Ele é de Oklahoma. O pai dele é um alcoólatra e a mãe se tornou uma amargurada depois de tanto sofrimento que passou com o marido. Ele chegava em casa bêbado toda noite e batia na esposa e no Sebastian também. Com o passar do tempo, a mãe dele também enlouqueceu e começou a procurar algo para descontar sua raiva. Transformou o garoto em um saco de pancadas.
<p>- Isso é horrível. 
<p>- Depois de tudo, ela começou a dar drogas para ele ficar menos agitado, para fazê-lo dormir.
<p>- Ele era só uma criança. – Emily falou como se aquilo fosse um impedimento para qualquer coisa, mas na realidade, para alguns, não era.
<p>- Por isso aceitava. Não tinha ideia do mal que faria. Uma vez, ele apanhou tanto e ouviu a mãe dizendo que era melhor ele morrer, senão ela o mataria. Ele fugiu de casa com os comprimidos dos pais no bolso, tomou um atrás do outro. Foi assim que ele teve a primeira overdose. Ele só tinha doze anos. 
<p>- O que aconteceu depois? – Emily colocou a mão na boca.
<p>- Eu não sei o que aconteceu com os pais. Só sei que o conselho tutelar tirou a guarda dos pais e deu para uma tia, o familiar mais próximo. Ela morava aqui em Los Angeles, então ele se mudou para cá e a gente acabou se esbarrando.
<p>- Como nós dois.
<p>- Exato. Todo mundo achou que isso seria o melhor, mas ele era uma criança com pais desestruturados, deixado de lado, a tia mal o conhecia. Ele tinha todos aqueles pensamentos que não compartilhava com ninguém e só pesava na vida dele, então o vicio voltou. 
<p>- Como lidou com isso? Você também era uma criança.
<p>- Eu não sabia. Quando nos conhecemos, eu percebi que tinha alguma coisa errada, mas não tinha ideia do que era. Ele parecia normal quando estava comigo e com o Jason, a gente jogava futebol, ia para praia, se divertia. Um dia ele sumiu do nada.
<p>- Como assim, sumiu?
<p>- A gente se via todo dia de manhã e um dia ele não apareceu. Não sabíamos onde ele morava nem o telefone dele. Foi estranho. Ele nunca foi de falar da família, acho que crianças não perguntam sobre isso. 
<p>- Ele sofreu outra overdose.
<p>- A tia dele era mãe solteira e tinha três filhos. É claro que ela cuidaria dos filhos primeiro e depois dele. Não foi culpa dela. Ela o colocou numa clínica para fazer um tratamento, contatou o juizado, abriu mão da guarda alegando que não tinha como cuidar dele e foi embora da cidade com os filhos. Ele ia para o sistema. 
<p>- E todos nós sabemos o que acontece com uma criança de doze a treze anos no sistema.
<p>- Exatamente. – Will falou desanimado. – Meus pais o adotaram. Ele vivia na minha casa antes de tudo, então não foi difícil para eles tomarem essa decisão. 
<p>- Como você ficou depois de descobrir tudo?
<p>- Muito bravo.</p>
<center><h4>--*--</h4></center>
<p><i>Will entrou de novo naquele quarto de hospital. Sebastian ainda estava acordado e parecia melhor do que da última vez, tinha mais cor em seu rosto. 
<p>- Cadê o Jason? – Sebastian ficou esperando o outro amigo passar pela porta logo depois de Will.
<p>- Ele foi para casa. A mãe dele ligou, disse que precisava de ajuda com alguma coisa. – Will olhava para ele sério. Queria tentar esconder a raiva, mas estava difícil.
<p>- Will, eu sei que você está decepcionado, mas eu nunca quis que...
<p>- Eu sei que não. Eu desculpo você.
<p>- Will...
<p>- Eu sei que você quer falar, mas me deixa terminar. – Will respirou fundo. – Eu te desculpo, mas você precisa me desculpar também. 
<p>- Pelo quê? – Sebastian ficou confuso.
<p>- Eu deveria ter te ajudado, te apoiado, não ter gritado com você nem ficado bravo. Eu sei que eu não sou o melhor nisso, é que... eu não suporto ter que ver você desse jeito. Não consigo imaginar você morrendo.
<p>- Seria mais fácil para todo mundo.
<p>- Só se for pra você. – Will se aproximou mais da cama, se curvou e abraçou Sebastian. – Você é o meu irmão e eu não vou te deixar sozinho nessa. Eu prometo.
<p>- Obrigado.
<p>- Eu te amo.
<p>- Eu também te amo.</i></p>
<center><h4>--*--</h4></center>
<p>A sala de espera era com certeza o pior lugar para alguém ficar se estivesse esperando noticias de alguém que teve uma overdose. Ninguém falava nada. Emily segurava bem firme a mão de Will enquanto os dois estavam sentados naquele sofá totalmente desconfortável. Karen e Robert estavam em pé olhando para o corredor de onde normalmente viria o médico para dar notícias. Amanda estava cochilando com a cabeça apoiada no ombro de Jason que também estava exausto, tinham passado a noite toda lá e não foram para casa descansar. Chris havia saído para tomar um ar, já estava inquieto sentado ali. Kevin havia ficado em casa cuidando de Matt, mas mandava mensagens para os irmãos o tempo todo para saber de notícias.
<p>O celular de Emily vibrou no bolso da calça e ela até levou um susto. Era a Quinn.
<p>- Eu vou lá fora ligar para a Quinn. Ela quer notícias. - Emily falou baixinho para Will e se levantou. 
<p>Quando ela cruzou a porta do hospital, viu o céu já todo estrelado, foi quando percebeu que não fazia ideia de que hora era, parecia que havia ficado naquela sala de espera por infinitas horas. 
<p>Emily começou a digitar o número de telefone de casa quando ouviu sons de choro.
<p>- Chris? – Ela o viu sentado em um dos bancos de concreto de frente para o hospital.
<p>- Eu só estava tomando um ar. – Chris enxugou rapidamente as lágrimas do rosto com as mãos quando viu ela se aproximar.
<p>- Tudo bem. – Ela se sentou ao seu lado. – Quer conversar?
<p>- Eu odeio vê-lo desse jeito. – Chris olhava para as suas mãos de cabeça baixa. – Eu não... eu não gosto.
<p>- Ele vai ficar bem. 
<p>- Eu sei, mas... Eu vi.
<p>- O quê?
<p>- Quando estávamos no bar, eu impedi ele de tomar um copo de alguma coisa alcoólica. Ele não estava bem. Eu só fiquei lá, nem conversei nem disse nada, só fiquei lá.
<p>- Você o ajudou.
<p>- Não o bastante. Eu devia ter contado para os nossos pais, eu devia.
<p>- É, devia!
<p>Os dois se assustaram quando ouviram a voz agressiva de Will logo atrás deles. 
<p>- Will... – Chris tentou parar a briga antes dela começar quando se levantou e encarou o irmão.
<p>- Você devia ter me contado isso. Por que não me contou isso?
<p>- Eu achei que ele te contaria. 
<p>- Você devia ter me contado antes! – Will gritou.
<p>- Gente, calma. – Emily se levantou também e ficou entre os dois para evitar uma briga mais séria. 
<p>- Eu achei que tinha ajudado. Ele não é só sua responsabilidade, sabia? Eu também sou irmão dele.
<p>- Eu sei disso, mas eu... – Will respirou fundo. – Agora ele está numa cama de hospital.
<p>- Quer dizer que a culpa foi minha? – Chris ficou indignado. 
<p>- Eu não quis dizer isso.
<p>- Ah é? Porque não foi isso que pareceu. Eu sou tão capaz de ajudá-lo quanto você! – Chris levantou a voz.
<p>- Já chega vocês dois! – Emily se irritou. – O irmão de vocês está desacordado e vocês estão aqui fora tentando marcar território em cima dele? Não é disso que ele precisa. Ele precisa de vocês dois, de todos nós. Ninguém precisa ser o macho dominante aqui. Cresçam!
<p>Os três ficaram em silêncio. Will e Chris ficaram se encarando sem ao menos piscar. O silêncio foi quebrado quando Amanda apareceu correndo e dizendo, quase sem fôlego, que Sebastian havia acordado. Ela voltou a correr de volta para o hospital junto com Chris. 
<p>Will ficou imóvel quando Emily o chamou.
<p>- O que houve? – Emily ficou preocupada.
<p>- Eu estou exausto. 
<p>- Tudo bem. – Emily o abraçou forte.
<p>- Não. Eu estou cansado. Eu cansei disso, eu cansei de sentir... às vezes eu queria que tudo acabasse. Eu não estou dizendo que...
<p>- Eu entendi. 
<p>- Ele com certeza tentou me contar, eu aposto, mas eu estava muito ocupado falando sobre os meus problemas ridículos. Eu não fui o suficiente para ele.
<p>- A culpa não é sua.
<p>- Diga isso mais umas cinquenta mil vezes e talvez depois eu acredite em você.
<p>Will respirou fundo. Precisava se mexer para voltar para o hospital e ver seu irmão, mesmo com aquele peso que ele estava sentindo.</p>
<center><h4>--*--</h4></center>
<p>Quando Will e Emily entraram no quarto onde Sebastian estava, Jason era o único que continuava lá. Ele estava sentado em uma cadeira do lado da cama. Olhava toda hora para o vidro de soro um pouco nervoso. Sebastian continuava pálido, mas abriu um largo sorriso quando viu os dois entrando. 
<p>- Oi, pessoal. – A voz dele estava fraca.
<p>- E aí, gente? – Jason também sorriu.
<p>- Como você está? – Will chegou mais perto.
<p>- Eu estou melhor da... – Sebastian olhou para Emily um pouco desconfiado.
<p>- Da intoxicação? Me disseram que você comeu uma coisa horrorosa. – Emily sorriu gentilmente. Ela achou melhor não falar sobre o “assunto” naquele momento.
<p>- É. – Ele riu sem graça.
<p>- Ela já sabe de tudo. – Will disse logo.
<p>- Sério? – Sebastian olhou para Emily bastante envergonhado.
<p>- Não precisa ficar com vergonha. – Emily se aproximou com cuidado. – Está tudo bem. Eu não ligo para isso.
<p>- Está com pena de mim agora?
<p>- Por que eu teria pena? Você tem dois pais que se preocupam muito com você, tem irmãos que te amam muito e até brigam para ver quem cuida mais de você. – Ela soltou um riso. – Você tem seus dois melhores amigos que fariam tudo por você e tem a mim. – Seus olhos se encheram de lágrimas. – Não sou grande coisa, mas eu tenho meus momentos. – Ela sorriu.
<p>- Obrigado. – Sebastian segurou forte na mão de Emily. – Vai lá, pode começar a gritar. – Ele olhou para Will já esperando pela bomba.
<p>- Eu não vou gritar. Dessa vez não. – Will pegou outra cadeira, colocou ela do lado de Jason e se sentou. Emily se sentou em uma das pernas do namorado. 
<p>- Que milagre.
<p>- Isso nunca ajudou.
<p>- O que você vai fazer então?
<p>- Eu vou ficar sentado aqui e te zoar por você ter perdido na última vez que jogamos futebol. – Will sorriu. 
<p>- Eu posso lidar com isso. – Sebastian sorriu de volta.</p>
<center><h4>--*--</h4></center>
<p><i>- Você se lembra quando a gente se conheceu? – Sebastian, Jason e Will estavam na praia. Sebastian estava há poucos meses em Los Angeles e já amava Malibu.
<p>- Mas é claro. – Jason tinha uma boa memória. – Will e eu estávamos jogando basquete naquela quadra abandonada e de repente você apareceu, assim do nada.
<p>- Era um magricelo que não acreditei que era mais velho do que eu. – Will brincou com o amigo.
<p>- A culpa não é minha se você é gigante. – Sebastian deu um soco de leve no ombro dele. 
<p>- Eu ainda não acredito que você não sabia jogar basquete.
<p>- Eu não conhecia muitas crianças em Oklahoma e meus pais quase não tinham tempo. – Por alguma razão, ele ficava triste quando se lembrava da família.
<p>- Mas isso vai mudar, porque o Jason e eu aqui vamos te ensinar tudo o que você precisa saber. Até a parte das garotas. – Will estava animado. 
<p>- A melhor coisa da minha vida é ser amigo de vocês.
<p>- Diz isso porque ainda não ouviu as piadas sem graças do Will. – Jason falou sem emoção.
<p>- Hei, minhas piadas são muito engraçadas, tá?
<p>- Com certeza.
<p>Os três começaram a rir.</i></p>
</body>
</html>";
            }

            if (numero == 15)
            {
                lblTitulo.Text = "Capítulo 15 - Você Está Feliz?";
                htmlPage.Html = @"<html>
<body>
<p><i>“Mas você não pode dizer o que você quer ou
<br>Pegar o que você quer ou
<br>Dormir e acordar do jeito que quiser
<br>Você disse que sua vida precisava de algo especial
<br>Bom, aqui estou eu
<br>É, você não está feliz?”
<br><b>Glad – Tyler Hilton</b></i></p>
<br>
<p>“Dizem que o tempo cura tudo, que a melhor coisa a se fazer é esperar, ter paciência. Pode até ser verdade em alguns casos. O tempo ajudou Sebastian a melhorar. Ele ainda estava tendo sessões com sua terapeuta, mas já tinha recebido alta do hospital, já estava em casa, indo para a escola, vivendo normalmente na medida do possível. Um ponto positivo para o tempo.
<p>Meu relacionamento com a Emily só melhorou com o tempo. Ficamos mais íntimos e mais à vontade um com o outro, não consigo mais imaginar a minha vida sem aquela garota e quando ela diz que me ama ou quando eu digo, eu sinto de verdade. Outro ponto positivo para o tempo.
<p>E quanto ao Jason? O tempo o ajudou a não sentir mais falta do pai que o abandonou? Eu acho que não. Na verdade, eu acho que a falta só aumentou. Ponto negativo para o tempo.
<p>Uma coisa é fato. O tempo nos deixa com uma nova perspectiva, uma opinião diferente. Nos amadurece para tomar decisões diferentes do que a que poderíamos tomar em outra época, com outra cabeça, mudando nosso futuro, não que isso seja a nossa salvação, às vezes não é. O tempo nos salva, mas pode nos condenar para sempre também, como quando você espera demais para fazer o que você tem que fazer por medo ou por preguiça ou simplesmente por achar que você tem todo o tempo do mundo. Acontece que você não tem. 
<p>O tempo pode fazer você mudar de opinião ou ter mais certeza da decisão que tomou no passado. Pode te fazer esquecer uma lembrança ruim, um rancor ou pode te torturar todos os dias por não poder esquecer. Pode mudar a sua vida ou deixar ela exatamente como sempre foi. Tem gente que tem muito tempo, outras tem pouco. Você nunca sabe qual parte você está. Parece aterrorizante, não é? Mas talvez seja isso que faz o nosso mundo girar. O que você faria se soubesse exatamente o seu prazo de validade? Correria ou desistiria?
<p>Vamos cometer erros e depois consertá-los. Vamos rir mais, chorar também, é importante demonstrar o que você realmente está sentindo. Vamos realizar nossos sonhos e criar sonhos novos, vamos perder batalhas também, afinal não vivemos só de vitórias. Vamos amar, beijar, abraçar, correr, cantar, gritar, brigar, dizer... vamos ser felizes enquanto temos tempo. E você já começou? Você está feliz?”</p>
<br>
<p>- Vai rolar essa festa hoje à noite na casa de um dos caras do time de futebol, a gente podia ir. – Emily e Will estavam no refeitório da escola almoçando.
<p>- Você nem está no time. – Emily riu.
<p>- Não é assim que as coisas funcionam. Precisamos participar desses eventos para ficarmos conhecidos.
<p>- Ah é? – Emily fingiu interesse para Will explicar para ela mais uma das suas paranóias.
<p>- É, se você se mistura, você fica popular, é inevitável. Ultimamente a minha popularidade está caindo por sua causa.
<p>- Ah é? Eu me lembro que na nossa primeira semana de namoro, todo mundo tinha uma foto nossa no celular. Eu te dei mais fama, querido.
<p>- Você tem razão. É como se eu estivesse namorando uma Kardashian. – Will jogou uma de suas batatas fritas no rosto de Emily. 
<p>- Vai acabar muito tarde? – Emily pegou a batata antes que atingisse ela e comeu.
<p>- Hoje é sexta-feira, a festa vai rolar a noite toda. Certeza. E metade vai sair de lá chapado. 
<p>- Eu acho que vou ter que recusar. Amanhã eu tenho que acordar bem cedo. 
<p>- Por que vai acordar cedo em um sábado? Ems, isso é exagero até para você. 
<p>- É para uma coisa. Mas pode ir à festa se quiser, eu não me importo. 
<p>- Boa ideia. Assim eu consigo traçar uma líder de torcida. – Ele começou a rir.
<p>- Ridículo.
<p>- O que você vai fazer amanhã?
<p>- Nada demais.
<p>- Emily. – Will a olhou todo curioso. – Não escondemos nada um do outro, lembra? É algo constrangedor ou sei lá?
<p>- Não. É que... quando meu avô descobriu que tinha câncer, ele começou a visitar hospitais uma vez a cada seis meses para trabalhar como voluntário. Depois que ele morreu, eu comecei a fazer o mesmo. Não importa onde eu esteja ou quando, na data eu vou ao hospital.
<p>- O que você faz lá o dia todo? – Will ficou interessado.
<p>- Nada demais. Ajudo enfermeiras, sirvo o almoço, brinco com crianças, essas coisas...
<p>- Nossa, você não luta contra o crime à noite fantasiada, luta? Porque eu ia adorar te ver de fantasia.
<p>- Cala a boca. – Ela riu envergonhada. – Não é nada demais. 
<p>- É claro que é. É bem legal da sua parte fazer isso. Tem espaço para mais um lá?
<p>- Will, não precisa fazer isso por mim. Eu já te amo o suficiente. 
<p>- Não é isso. Eu gostei dessa ideia. Na verdade, eu devo muito ao hospital também. – Will se lembrou do seu tempo lá semanas atrás. 
<p>- Como ele está hoje? Eu não o vi. – Ela perguntava todo dia.
<p>- Melhor que ontem.</p>
<center><h4>--*--</h4></center>
<p>Jason estava na biblioteca da cidade naquela manhã. Ele perdeu o sono cedo e saiu de casa antes mesmo de sua mãe acordar. Ler aquele livro ali sentado em uma mesa afastada e no silêncio era a ideia dele de um bom sábado de manhã. Aquela época do ano não era a sua favorita e ele sempre se isolava. Sebastian já estava bem melhor, então ele finalmente poderia voltar a pensar nos seus problemas, não que ele quisesse aquilo.
<p>A verdade é que ele não gostava de ficar em casa. Sua mãe sempre mudava de humor repentinamente quando chegava essa data, ele odiava isso, vê-la chorando. Por isso preferia vê-la o mínimo possível, não era um plano ideal, mas funcionava, pelo menos para ele.
<p>- Oi, o que faz aqui?
<p>Jason tirou seus olhos do livro para ver quem estava falando com ele e viu Amanda na sua frente segurando um monte de livros.
<p>- Acho que o mesmo que você, estudando. – Jason deu um meio sorriso um pouco sem graça. Eles nunca ficavam sozinhos no mesmo lugar por muito tempo.
<p>- Como se você precisasse. – Amanda jogou seus livros na mesa de Jason e se sentou ao lado dele. – Will sempre diz que você é um gênio e que não precisa estudar.
<p>- Will é um exagerado e às vezes eu gosto de dar uma revisada.
<p>- Pode ser, mas eu acho que aqui é o seu refúgio quando fica sozinho ou quando não tem escolha.
<p>- Talvez.
<p>- Também não gosto de ficar sozinha. 
<p>- Eu sei que meus amigos ou estão namorando ou estão na terapia. E quanto aos seus? – Jason tentou fazer uma piada. Colocou uma das mãos, a que ele não estava segurando o livro, no bolso para esconder o tremor de nervoso. 
<p>- Namorando. Meu único amigo é o meu irmão. – Ela riu sem emoção. – Minha segunda opção seria a Ashley ou a Giovanna.
<p>- Talvez isso seja um sinal de que você precisa mudar a sua personalidade. 
<p>- Você estava aqui sozinho primeiro e eu estou aqui porque realmente preciso estudar. Qual é a sua desculpa?
<p>- Eu estou aqui porque eu quero. – Jason fechou o livro. A leitura tinha acabado.
<p>- Faz quanto tempo?
<p>- O quê?
<p>- Que seu pai foi embora? Eu sei que mês é esse. Eu presto atenção nas coisas. Não sou tão insensível assim.
<p>- Muito tempo. – Jason não gostava de dizer o tempo exato. Doía mais. 
<p>- Deve ser uma barra.
<p>- Casais se separam, eu entendo isso, não sou idiota, mas filho é para sempre, não é? Isso não faz sentido nenhum. 
<p>- Ele quem perdeu. Não viu você crescendo e se tornando essa pessoa incrível que você é.
<p>- Você me acha incrível? – Jason ficou impressionado.
<p>- Eu estou tentando te ajudar. Não faz pergunta difícil. – Amanda abriu o primeiro livro que viu na mesa e começou a ler para fugir daquela conversa.</p>
<center><h4>--*--</h4></center>
<p>Will estava bem perdido naqueles corredores do hospital. Ele então percebeu que sempre ficava no mesmo lugar todas as vezes que ia para lá e que nunca pensou que aquele hospital era tão grande quanto um labirinto infinito. 
<p>Quando ele e Emily chegaram, às sete em ponto, foram direto para a recepção, preencheram a ficha de voluntariado e receberam algumas ordens do que eles fariam naquele dia. Os dois ficaram em alas separadas. Emily, como já era mais experiente, ficou com as enfermeiras, Will desceu para a ala infantil para cuidar das crianças.
<p>Ele esperava ver aquele lugar o mais deprimido possível, mas ficou surpreso quando percebeu que era totalmente o oposto. Havia cartazes de desenhos por todos os corredores e salas, havia até uma decoração de aniversário de cinco anos de alguém. Faziam isso para as crianças ficarem menos tristes, ele pensou.
<p>Havia crianças correndo e rindo, um espaço onde só tinha brinquedos para todas as idades, até pareceria um parque de diversões se não houvesse todos aqueles tubos e crianças carecas e pálidas. É, não era mesmo um parque.
<p>Afastada desse lugar animado, havia uma sala bem grande com crianças recebendo quimioterapia. Will olhou pela janela. Aquela doença já maltratava a pessoa mais forte, ele não gostava nem de pensar no que fazia a uma criança, era desumano.
<p>Will começou a procurar por alguém do hospital para lhe dar orientações e começar logo o trabalho. Um minuto depois, ele viu uma garotinha correndo em sua direção com um prato de plástico nas mãos cheio de pedaços de bolo. Suas mãos estavam sujas, ela com certeza estava comendo com elas. Devia ter uns sete anos, era bem branca e tinha um cabelo preto bem ralo. Will lembrou de quando era pequeno e via Amanda pentear seus cabelos, ela amava fazer penteados e tranças o tempo todo, algo que aquela garotinha não podia fazer. Ela não parecia se importar com isso já que estava com um sorriso bem grande e seus olhos bem pretos pareciam duas bolas de gude do tanto que brilhavam.
<p>- Oi, você quer um pedaço de bolo? – Ela estendeu o prato para ele pegar.
<p>- Não, muito obrigado. – Ele sorriu para ela.
<p>- Minha mãe sempre diz que a gente sempre tem que comer para ficarmos saudáveis. – Sua voz era fina e doce, parecia um anjo.
<p>- Ela tem razão, mas eu já comi por isso estou sem fome. Comer muito também faz mal.
<p>- Você é novo aqui? Nunca te vi. É médico?
<p>- Ah, não. Eu só vim ajudar e sim, eu sou novo. Eu vim com a minha namorada, deve estar por aí cuidando de doentes.
<p>- Ela deve ser muito bonita. – A garota o observava nos mínimos detalhes como se ele fosse uma atração rara de um circo.
<p>- Por que diz isso?
<p>- Porque você também é muito bonito.
<p>- Obrigado, você também é muito bonita. A gente até podia namorar se eu estivesse sozinho.
<p>- Minha mãe diz que eu sou muito nova para namorar.
<p>- E ela está certa.
<p>Ela se sentou no chão e por reflexo, Will se sentou ao lado dela. 
<p>- Sou o Will. – Ele estendeu a mão para ela.
<p>- Sou a Angela. – Ela beijou seu rosto o sujando de bolo. – Mas todo mundo me chama de Angie. Eu ia apertar sua mão, mas a minha está suja. – Ela riu.
<p>- O que você faz aqui? Qual é a sua história?
<p>- Bom... – Ela o olhou como se quisesse contar desde que o encontrou. – Eu tenho uma coisa na minha cabeça que dói muito às vezes. Dizem que precisam tirar, mas é muito perigoso.
<p>- Você está com medo? Preocupada?
<p>- Não. – Ela parecia bem calma. – Mas a minha mãe sim, ela vive chorando. Acha que eu não percebo, mas eu percebo. Fico triste por ela.
<p>- É, não deve ser fácil. 
<p>- Bom, não faz muito tempo eu ficava naquela sala feia no final do corredor tomando coisas que me faziam mal. – Ela olhou para o final do corredor com medo. – Depois que eu parei, eu me senti bem melhor. Não sei porque minha mãe ainda está triste.
<p>- Pais sempre se preocupam, é a função deles. 
<p>- Deve ser. Você sabe fazer malabarismo? – Ela arregalou os olhos.
<p>- Não, por quê?
<p>- É que você disse que veio ajudar. Achei que ia ficar na sala brincando com a gente enquanto fazia malabarismo ou qualquer outra coisa legal. O que você sabe fazer?
<p>- Ah...
<p>- Sabe dar cambalhota?
<p>- Não. – Will riu. – Eu sei cantar.
<p>- Você podia cantar, tem uma sala onde tem essas coisas de música, violão, piano, essas coisas. Você podia fazer um show. 
<p>- Ah, não. Eu não canto em público.
<p>- Qual é a graça de saber cantar se você não faz show? Não entendi.
<p>- Um dia eu te explico. 
<p>- Quem está fazendo aniversário é o Mark. Ele estava na sala feia ontem. Está em uma cadeira que tem rodas para poder ficar na festa lá no refeitório, ele não aguenta ficar de pé. 
<p>- Ele é seu amigo? Eu sinto muito.
<p>- Ele ia adorar ver um show. – Ela fez bico.
<p>- Tenho certeza que ia. – Will riu da garota tentando fazer chantagem emocional com ele. 
<p>- Sabe, eu tinha uma amiga que também tinha o mesmo que eu na cabeça. – Ela apontou para a cabeça dela. Will percebeu que tinha uma cicatriz bem onde ela apontou. Na certa, ela já tinha feito uma tentativa de retirada do tumor, mas os médicos não conseguiram. – Ela foi para o céu não faz muito tempo. Às vezes acho que eu vou logo também.
<p>- Não pensa nisso. Vai demorar muito para você ir para o céu. 
<p>- Minha mãe também diz isso.
<p>- Porque ela está certa.
<p>- Eu posso ir ao seu casamento? – Ela quase deu um pulo de entusiasmo.
<p>- Isso vai demorar um pouco.
<p>- Mesmo assim... Eu queria ser aquela que joga as rosas antes da noiva entrar. 
<p>- Bom, então está convidada. Você é oficialmente a primeira pessoa que eu convidei para o meu casamento.
<p>- Que legal. – Ela conseguiu abrir um sorriso maior do que já estava e Will retribuiu do mesmo jeito. – Eu estou muito feliz.
<p>- Você está feliz mesmo? – Will tentou disfarçar o tom condescendente. 
<p>- Estaria mais se eu ouvisse você cantar. Por favor.
<p>- Você não vai desistir disso, não é? – Will sabia que estava perdendo a disputa.
<p>- Nunca.</p>
<center><h4>--*--</h4></center>
<p>O vento do mar estava passando pelo rosto de Sebastian. Ele se sentia calmo quando ficava sentado na areia da praia. Era como se Oklahoma e as semanas passadas nunca tivessem existido. Ele se sentia bem.
<p>- Por favor, não me diz que você vai tentar se afogar. – Quinn se sentou de surpresa ao lado de Sebastian. – Eu não sei nadar e não vou poder te salvar. Além do mais, eu não te aguentaria nem se eu soubesse nadar.
<p>- Eu não estava pensando nisso. – Ele ficou sério.
<p>- Relaxa, eu só estava brincando. Seu humor estava melhor no hospital
<p>- O que faz aqui? Te mandaram me espionar?
<p>- Não, estou fazendo por conta própria. – Ela riu. – É brincadeira. – Ela deu um empurrão nele para tentar tirar um sorriso, mas sem sucesso. – Só estava caminhando e te vi. E você? O que faz aqui?
<p>- Minha terapeuta disse que eu preciso parar um pouco para pensar na vida. Eu estava tentando fazer isso.
<p>- Então eu acho melhor te deixar sozinho. – Ela se levantou.
<p>- Não precisa. – Ele segurou na mão de Quinn, mas largou bem rápido. – Eu não gosto muito de ficar sozinho.
<p>- Já que insiste. – Ela voltou a se sentar. – Como está indo a sua recuperação?
<p>- Vinte e sete dias sóbrio e contando.
<p>- Parabéns. 
<p>- Obrigado. – Sebastian a olhou como se nunca ninguém tivesse dito aquilo para ele.
<p>- Eu vou ficar em silêncio agora, para você voltar a pensar na vida. – Ela sorriu e ele finalmente retribuiu o sorriso.
<p>- Tudo bem.</p>
<center><h4>--*--</h4></center>
<p>Angie puxou Will pelo braço até o lugar onde estava tendo a festinha de aniversário. Ela tinha ficado muito feliz quando Will finalmente aceitou cantar e o levou de muito bom grado até a sala de música onde ele pegou um violão velho que logo viu que era de alguma doação. 
<p>Havia mais gente do que ele imaginou que teria. Além das crianças, alguns pais e mães também estavam por lá junto com alguns enfermeiros e médicos. Angie chegou gritando que havia trazido um cantor para a festa só deixando Will ainda mais nervoso.
<p>- Não canta nada que seja sobre pessoas doentes nem músicas tristes. Eles não vão gostar. – Angie avisou antes de ir se juntar com as outras crianças para ver o show. 
<p>Will se sentou em um banquinho e colocou o violão no colo. As crianças se sentaram nos outros bancos espalhados pelo lugar e formaram uma roda. Os adultos ficaram do lado de fora do círculo observando. 
<p>- <i>Remorsos se acumulam como velhos amigos... aqui para reviver seus momentos mais sombrios... </i>– Will resolveu começar a cantar logo ao invés de falar algo antes. – <i>Não vejo saída, não vejo saída. E todos os mortos-vivos saem para brincar.</i>
<p>Ele olhou para Angie e ela parecia encantada prestando atenção em cada palavra, o que era difícil para uma criança daquela idade.
<p>- <i>Todo demônio quer seu pedaço de carne, mas eu gosto de guardar algumas coisas para mim. Eu gosto de deixar meus problemas maiores... É sempre mais escuro antes do amanhecer.</i>
<p>Will respirou fundo e começou a tocar o violão.
<p>- <i>E eu fui bobo e eu fui cego. Nunca consigo deixar o passado para trás. Não vejo saída, não vejo saída... Estou sempre carregando esse peso comigo, nosso amor criou um som terrível. Essa noite, vou acabar com esse assunto. Por isso eu gosto de deixar meus problemas maiores. É sempre mais escuro antes do amanhecer.</i>
<p>Ele começou a ouvir o som de palmas harmonizando com a música do violão. 
<p>- <i>Se livre, se livre! Se livre, se livre, uou... Se livre, se livre! Se livre, se livre, uou.. E é difícil dançar com o diabo nas costas. Então se livre dele, uou!</i>
<p>Will ia cantando mais forte conforme a música ia passando e sua confiança ia aumentando. 
<p>- <i>E eu cansei desse meu coração sem graça, então essa noite vou arrancá-lo e recomeçar. Porque eu gosto de deixar meus problemas maiores. É sempre mais escuro antes do amanhecer...</i>
<p>Então além de bater palmas, as pessoas começaram a cantar o refrão em um único coro. Era uma energia diferente que ele nunca havia sentido antes. Aquelas crianças, a maioria delas nem deveriam saber porque estavam lá, seus pais, preocupados com a vida de seus filhos e aqueles médicos e enfermeiras também com o peso nas costas e carinho por seus pacientes e ele, Will, que era uma das pessoas mais sortudas do mundo e não tinha percebido até aquele momento.
<p>- <i>Se livre, se livre! Se livre, se livre, uou!
<p>- Se livre!
<p>- Se livre, se livre! Se livre, se livre, uou!
<p>- Se livre.... E é difícil dançar...
<p>- E é difícil dançar com o diabo nas costas
<p>- Então se livre dele, uou!
<p>- Então se livre dele...</i></p>
<center><h4>--*--</h4></center>
<p>- Você está bem? – Emily percebeu que Will estava mais pensativo do que o normal quando estavam fazendo o caminho de volta para a casa dela naquela noite. Ela havia passado muito tempo contando a ele o que ela tinha feito naquele dia e ele só respondia com sinais de cabeça e murmúrios, geralmente ele fingia melhor que escutava o que ela dizia. 
<p>- Mais ou menos. Eu estou pensando em uma garotinha que eu conheci no hospital. 
<p>- Na Angie? – Will ficou surpreso por Emily saber o nome dela. – É, eu sei. Ela estava dizendo para todo mundo no hospital que te conheceu. 
<p>- Ela tem um tumor no cérebro e está crescendo rápido. Uma cirurgia arriscada com dez por cento de chance de sucesso. A ficha dela é bem desanimadora. 
<p>- É. Encontramos muita gente assim. Acho que é pior quando é com uma criança. – Emily ficou séria também.
<p>- Ela não tem muito tempo de vida. Na internet, os casos parecidos com o dela, os pacientes não duram nem um ano. E sabe o que ela me disse?
<p>- O quê?
<p>- Que ela estava feliz. Não engraçado e ao mesmo tempo perturbador?
<p>- Eu acho que é a vida. E ela é assim. 
<p>- Sabe, eu... eu cantei lá. Um garotinho estava fazendo aniversário e...
<p>- Eu ouvi falar sobre o seu show. Te adoraram. – Emily sorriu.
<p>- É. – Will sorriu um pouco orgulhoso. – Eu também ouvi pessoas te elogiando. Eu estufei o peito e disse “Ela é a minha namorada!”. 
<p>- Você é um bobão. – Emily começou a rir.
<p>- Fizemos uma coisa incrível hoje.
<p>- É, fizemos sim. 
<p>- Ems, você está feliz? Porque eu quero que você seja.
<p>- Eu estou. – Ela segurou na mão de Will com mais firmeza. 
<p>- Ótimo, porque eu também estou e não tem graça se você não estiver. Vamos ser felizes juntos então.
<p>- Combinado!</p>
<br>
<p>“O que faz você feliz? Cada indivíduo tem o seu conceito de felicidade e não merece ser julgado por isso. Para uma criança, pode ser uma bola como presente, uma boneca, um amigo para brincar, elas não são muito exigentes, os pais que são. Essa exigência cresce conforme crescemos. Procuramos a felicidade em uma profissão que nunca vamos ser bons o bastante, em uma família que nunca vai ser perfeita. 
<p>É, a felicidade é uma coisa muito subjetiva. Não dá para comparar uma felicidade da outra nem alcançar a de outra pessoa. Ela tem que vir de você, não de outro. Isso é muito importante. E ela vai passar. Não dá para ser feliz o tempo inteiro, nem sei se é saudável. Mas é bom ser feliz o máximo de tempo que a gente conseguir. É tudo o que importa.”.</p>
</body>
</html>";
            }

            if (numero == 16)
            {
                lblTitulo.Text = "Capítulo 16 - Estranhos, Farsas Perfeitas";
                htmlPage.Html = @"<html>
<body>
<p><i>“Estranhos
<br>Farsas perfeitas
<br>Estamos nos apaixonando loucamente
<br>Por algo que não é real
<br>Nunca poderia ser nós
<br>Apenas você e eu”
<br><b>Strangers - Sigrid</b></i></p>
<br>
<p>Jason estava um pouco estranho quando se encontrou com Will naquela manhã para correr um pouco na praia. Logo a estranheza se transformou em um rosto envergonhado quando ele começou a contar para o amigo que se encontrou com Amanda no dia anterior na biblioteca da cidade.
<p>- Então vocês conversaram sobre isso? Você não conversa sobre o seu pai nem comigo. – Will ficou surpreso e chocado ao mesmo tempo.
<p>- Eu sei, mas ela perguntou e eu... – Jason ficou ainda mais com vergonha.
<p>- E você não quis ser grosso com o amor da sua vida, não é? – Will riu.
<p>- Cala a boca. Me conta, como foi a sua visita no hospital? Virou mais humano?
<p>- Quase. Foi interessante. Me fez mudar o que eu penso sobre muitas coisas.
<p>- Isso é bom. Você precisa mesmo fazer isso, talvez deixe de ser idiota.
<p>- Valeu. – Will deu um soco no braço do amigo. – Bom, agora que você e a Mandy tiveram a primeira conversa formal e oficial, você bem que podia contar que está perdidamente apaixonado por ela, não é mesmo?
<p>- Acha que é fácil?
<p>- Mas não é tão difícil. 
<p>- Levar um fora é horrível.
<p>- Não tão horrível quanto ver a garota que você gosta com outra pessoa. – Will olhou sério para o amigo. Ele também se preocupava com isso acontecendo. – E vai por mim, vai acontecer isso algum dia e você não vai poder fazer nada. 
<p>- Acha mesmo que eu não penso nisso? Porque eu penso. Todo dia.
<p>- Então o que vai fazer?
<p>- Eu ainda não sei. No minuto que eu disser, tudo vai mudar.
<p>- Isso quer dizer que você gosta de como está agora? Mudar seria bom na minha opinião. 
<p>- Eu não sei. – Jason aparentava ter muito medo.
<p>- Sabe, é legal dar conselho às vezes. Geralmente esse é você. – Will fez uma piada para tentar animar o amigo, mas Jason continuou mexido com aquela situação o resto da corrida.</p>
<center><h4>--*--</h4></center>
<p>Emily ainda não tinha feito amigos na escola nova. Diferente da irmã que sempre andava rodeada de pessoas, quando não estava “na bolha do Will”, ela ficava sozinha com seus livros amigos na biblioteca.
<p>- Você precisa de amigos. – Will sempre começava esse assunto quando almoçavam sozinhos na cantina.
<p>- Eu tenho você.
<p>- Bom, eu sei que eu sou incrível e suficientemente bom, mas não sou onipresente e não gosto que fique sozinha. 
<p>- Eu gosto de ficar sozinha. Eu sou muito autossuficiente. – Emily deu um sorriso.
<p>- Você é muito estranha, isso sim. 
<p>- Por que estamos sozinhos aqui? Cadê todo mundo? – Emily estranhou a mesa estar vazia.
<p>- Jason está com o Seb na biblioteca ajudando ele a estudar para a prova do próximo horário e eu não quero ficar em uma mesa observando Chris e Ashley se lambendo em público.
<p>- Eles estão juntos há muito tempo?
<p>- Tempo demais para falar a verdade. – Amanda respondeu por Will quando se sentou ao lado dele e colocou sua bandeja de almoço na mesa. – Não acredito que iam me deixar lá sozinha. – Ela falou irritada.
<p>- Eu acho eles fofos. – Emily argumentou.
<p>- Ah, eles são fofos sim, quando ela não está por ai traindo ele. – Amanda adorava falar daquelas coisas com o seu tom sarcástico. Seu famoso veneno diário.
<p>- É sério? – Emily arregalou os olhos chocada.
<p>- Foram duas vezes. – Will explicou. – Uma vez com o parceiro dela de matemática e a outra vez com um amigo do Chris. 
<p>- As vezes que a gente sabe. Sem falar da vez que ela deu em cima do Jason. – Amanda sempre ficava brava quando mencionava esse acontecimento.
<p>- Nossa.
<p>- Surpresa, né? – Amanda riu. – Você já sabe que a Giovanna é uma vadia, mas não se engane com a Ashley, ela não é muito diferente.
<p>- Por que anda com elas então? – Emily sempre preferiu ficar sozinha do que ter que conviver com gente que ela não gostava e não entendia muito bem quem não agia como ela.
<p>- Não tenho muita opção. As garotas daqui são todas vadias, e o Will pode confirmar, já dormiu com quase todas elas.
<p>- Amanda! – Will quase se engasgou com o suco.
<p>- É verdade. – Amanda revirou os olhos sem dar muita importância.
<p>- Mas você não gosta dela por causa da traição ou por outra coisa pior? – Emily tentou entender o nível de amizade das duas e se ainda tinha algo que ela precisava saber.
<p>- Ela deu em cima do Jason logo depois que a Amanda contou para ela que gostava dele. – Will voltou a explicar.
<p>- Como sabe disso? – Até Amanda ficou surpresa.
<p>- Eu ouço coisas. – Will deu de ombros. – Eu me lembro do Jason todo assustado me contando que a Ashley deu em cima dele. Foi engraçado. – Mas Will não riu, na verdade ele ficou bem pensativo. – Quer saber, Emily? Você faz bem em só conversar comigo, garotas são doidas.
<p>- Cala a boca. – As duas falaram juntas.
<p>- Sabe, é engraçado. De um lado, eu tenho que ouvir o Jason reclamar dizendo que a Amanda nunca olharia para ele, e de outro, eu escuto a Amanda dizer que o Jason a vê como uma irmã, e mesmo eu dizendo que estão enganados, eles não saem desse chove-não-molha.  – Will bufou. Essa era a pior parte de ter relação com os dois. Ele achava tudo aquilo um saco e bem desnecessário. 
<p>- Nós nunca daríamos certo. Vamos esquecer isso? – Amanda pegou seu celular do bolso e começou a encarar a tela tentando terminar aquele assunto que estava deixando-a bem desconfortável.
<p>- A gente só faz isso. Esquecemos o assunto.
<p>- Por que vocês não dariam certo? – Emily tentou chegar mais a fundo.
<p>- Imagina se a gente terminasse. Ficaria um clima muito ruim e eu não quero isso. – Amanda sempre dava aquela mesma desculpa.
<p>- Vocês mal se falam. Parece até que são melhores amigos e não querem estragar a amizade. – Will balançou a cabeça em negação. – Olha só para você, está na pior. Seguindo ele até a biblioteca só para puxar papo? É deprimente.
<p>- Eu não estava...
<p>- Estudando sábado de manhã? Essa desculpa pode ter colado com ele, comigo não. – Will mexeu a cabeça em negação.
<p>- Você não pode começar um relacionamento pensando que vai acabar. Não é assim que funciona. – Emily opinou.
<p>- Nossa, vocês são muito chatos. Eu vou ter que voltar para a mesa com o Chris e a Ashley. – Amanda fez cara feia.
<p>- Vocês nunca vão conversar sobre isso, não é? – Will já sabia como aquela história iria terminar e isso o deixava triste. Ele amava aqueles dois e mesmo que não desse certo, ele queria que ao menos arriscassem.
<p>- Não. 
<p>Amanda fechou a cara, voltou sua atenção para seu almoço e ficou calada até o sinal do término do intervalo tocar quando ela se levantou, ainda em silêncio, pegou sua bandeja e foi embora.</p>
<center><h4>--*--</h4></center>
<p>- Então, como foi a prova?
<p>Will encontrou Sebastian lendo um livro, sozinho, sentado em uma das mesas espalhadas pelo pátio da escola, quando o horário de aula terminou.
<p>- Você está há bastante tempo aqui? Saiu da aula mais cedo? – Will esperou ele responder, mas foi em vão. – Você vai me responder ou eu vou ter que continuar falando sozinho?
<p>- O livro está muito interessante. – Sebastian olhou de rabo de olho para Will por cima do livro.
<p>- Pode ler em casa.
<p>- Tem muita gente em casa. Não dá para me concentrar. 
<p>- Bastante gente é bom, é ótimo na verdade.
<p>- Will, eu estou bem. Não precisa me checar a cada dez minutos. 
<p>- Não é isso, é só... Como está indo a terapia?
<p>- Eu não quero falar sobre isso. – Sebastian fechou o livro. 
<p>- Quer falar sobre o que, então?
<p>- Cadê a Emily? Por que não está indo levar ela para casa? Você sempre faz isso. 
<p>- Eu não estou sendo um bom irmão ultimamente, por isso eu achei que... Que tal a gente ir para casa junto hoje? A gente não fica junto faz um tempo. – Will fez outra tentativa. Já estava demonstrando sua ansiedade.
<p>- Ficamos juntos o tempo todo. – Sebastian encarou o irmão. – Will, isso não tem a ver com você, tem a ver comigo. É minha culpa, não sua.
<p>- Não pode se culpar por isso.
<p>- Nem você. Eu estou bem, é sério. E na verdade... – Sebastian guardou o livro dentro da mochila. – Eu estou esperando a Quinn, vamos tomar sorvete.
<p>- Vocês estão andando muito juntos ultimamente. Teve o dia lá na praia, vivem trocando mensagens e tudo mais. – Will insinuou algo que não deixou o irmão muito feliz.
<p>- Isso não tem nada a ver. – Sebastian fez cara feia.
<p>- Se essa é a sua história. Mas... depois do sorvete, deveria chamar ela para um encontro de verdade. – Will insistiu. Era melhor o irmão estar com a Quinn do que sozinho.
<p>- Não viaja. – Agora ele estava com vergonha. 
<p>- Ela vai adorar ouvir a sua história dos castores. 
<p>- Cala a boca.</p>
<center><h4>--*--</h4></center>
<p>- Onde você estava?
<p>Quinn, como sempre, entrou no quarto de Emily sem ao menos bater na porta e já se jogou na cama da irmã que estava em frente ao espelho se arrumando para sair com o namorado.
<p>- E para onde você vai? – Quinn respondeu à pergunta com outra pergunta.
<p>- Eu perguntei primeiro.
<p>- Eu estava na sorveteria com o Sebastian. É meu pai agora?
<p>- Pelo horário, acho que vocês tomaram muitos sorvetes, não é? Cuidado para não se resfriar. – Emily olhou com maldade para a irmã.
<p>- Não enche. Estávamos só conversando. Ele é um fofo.
<p>- É, ele é sim. 
<p>- Você tinha que ver. Ele tentou me chamar para sair de verdade, mas não conseguiu. – Ela começou a rir. – Não tem tato nenhum o garoto.
<p>- Você teria aceitado?
<p>- Por que não? Ele é uma ótima companhia e tem uns assuntos bem legais, diferente da maioria dos garotos por aqui que só sabem falar bobagens. 
<p>- Ai, meu Deus. Eu achei que você só estava... Está interessada nele. 
<p>- Talvez. – Quinn não ficou com vergonha de admitir. – Alguém problema?
<p>- Não, nenhum. 
<p>- Vai, fala logo. – Quinn fingiu preguiça. – Fala para eu ter cuidado, ir com calma e essas coisas chatas.
<p>- Eu não vou te dizer isso. Eu não sou seu pai. – Emily começou a rir e foi atingida por uma almofada que a irmã jogou. – Olha, fique aí pensando no seu futuro encontro enquanto eu vou ao meu encontro no presente com o meu namorado do presente. – Ela jogou a almofada de volta na cama.
<p>- Aparece ainda hoje, tá bom? Não quero mentir para os nossos pais de novo. 
<p>- Ah tá.
<p>- Divirta-se e não faça nada que eu não faria.
<p>- Não há nada que você não faria. – Emily deu uma última olhada no espelho, se despediu da irmã e saiu correndo do quarto. Já estava atrasada.</p>
<center><h4>--*--</h4></center>
<p>Will estava terminando de passar gel no cabelo quando alguém bateu na porta do seu quarto. Ele olhou ao redor, estava uma bagunça. Se fosse a sua mãe na porta, ela ia reclamar muito, mas ele não tinha muito tempo, então só pegou as roupas sujas do chão e jogou na cama embora isso não mudasse muita coisa.
<p>- Mãe, eu... – Ele parou de falar e entrou em choque quando viu quem estava do outro lado da porta quando a abriu.
<p>- Não tinha ninguém lá embaixo, então eu fui entrando. – Giovanna sorriu para ele.
<p>- Geralmente, quando não tem ninguém em casa, você vai embora. O que faz aqui? – Will começou a abotoar o resto dos botões da camisa imediatamente.
<p>- São esses seus modos? Não era assim que você me tratava quando entrávamos aqui e...
<p>- Pessoas mudam. – Will a interrompeu embora ela continuasse com um sorriso cínico no rosto.
<p>- Nem sempre.
<p>- Fala logo o que você quer. Eu estou com um pouco de pressa. – Will continuou parado em frente a porta evitando dar brechas para ela entrar.
<p>- Acho que você vai querer ficar depois de ouvir o que eu tenho para dizer. – Ela tentou entrar no quarto, mas Will continuou firme em sua posição.
<p>- Chega de joguinhos. Fala logo ou vai embora. Na verdade, eu já estou dando atenção para você até demais. – Will estava sério.
<p>- Will, querido, eu só vim aqui para te ajudar.
<p>- Me ajudar?
<p>Will ficou tão confuso com aquela frase que nem percebeu Giovanna entrando de fininho no seu quarto sem ser convidada.
<p>- Eu sei que essa Emily não dá para você o que você quer.
<p>- Sai daqui. – Will ficou com a cara ainda mais fechada.
<p>- Ela não precisa saber. Pode confiar, eu não vou contar nada.
<p>- Sai. – Ele respirou fundo e tentou ficar o mais calmo possível, ainda em frente a porta.
<p>- Qual é, Will? Nós dois sabemos o que você quer. – Giovanna se sentou na cama e tirou os sapatos. – Eu também quero. Só vamos ganhar com isso.
<p>- Esse é o seu nível de desespero? Qual é o seu problema, garota?
<p>- Eu é que te pergunto. O que aconteceu com você? – Ela parecia surpresa. – Um ano atrás, bastava uma garota ficar na sua frente que você já levava para a cama e olha que já estamos até no seu quarto.
<p>- Eu realmente achei que você já tinha superado tudo isso. Aquele seu showzinho na escola meses atrás... O que você quer que eu diga?
<p>- Como você quer que eu supere você? – Giovanna de repente se transformou. Aquela garota cínica que apareceu no quarto minutos antes havia desaparecido. Agora Will olhava para uma Giovanna totalmente vulnerável e com lágrimas nos olhos.
<p>- Eu não vou cair no seu jogo. Está perdendo o seu tempo.
<p>- Eu ainda te amo.
<p>- É uma pena. 
<p>- Will, eu...
<p>- Eu estou saindo, está bem? Sinta-se à vontade. Só fecha a porta quando sair, tá bom?
<p>Will pegou o primeiro tênis que ele encontrou no chão, os calçou e saiu do quarto. Desceu as escadas nervoso e foi para a cozinha que ficava o mais longe possível daquelas escadas e da porta principal. Não queria ver Giovanna descendo e ter que conversar com ela de novo ou se despedir. Então preferiu se esconder até ela sair.</p>
<center><h4>--*--</h4></center>
<p>- O que você está fazendo aqui?
<p>Giovanna tinha ouvido aquela pergunta mais cedo, mas dessa vez vinha da boca de Emily que estava parada na frente da porta escancarada do quarto de Will.
<p>- Agora? Nada demais. – Giovanna se levantou da cama enrolada em um lençol. Estava totalmente nua, com os cabelos longos e soltos todos despenteados. 
<p>- Você não...
<p>- Vão sair juntos hoje? – Ela sorriu. – Por isso então que ele estava com tanta pressa e pediu para eu ir embora logo depois que acabou. Acho que ele não queria que você me visse. 
<p>- Eu não acredito em você. – Emily continuou parada em frente a porta.
<p>- Pode esperar aqui e perguntar quando ele sair do chuveiro.
<p>Emily ouviu barulho de água caindo no banheiro. Definitivamente o chuveiro estava ligado.
<p>- Para. – Ela ficou séria. – Ele nunca faria isso comigo.
<p>- Bom, parece que ele fez e muito bem.
<p>- Eu não... – Emily travou.
<p>- Olha, se isso faz você se sentir melhor, a culpa foi minha. Eu que estava enrolando para colocar a roupa e ir embora. Não era para você ver.
<p>- Por que você está fazendo isso?
<p>- Acha mesmo que ia satisfazer o Will só com beijos e abraços? Era só uma questão de tempo até ele procurar alguém que desse o que ele quer.
<p>- Você não sabe de nada.
<p>- Além do mais, é sempre assim. A gente briga, termina, ele ficar com alguma idiota por alguns meses, mas eu não ligo, porque ele sempre volta para mim. – Giovanna falava com um tom de vitória. Não conseguia se conter.
<p>- Você é pior do que eu imaginava. – Emily olhava para Giovanna com desprezo. – Eu podia ficar aqui e dizer por horas o quanto você não tem um pingo de amor próprio e que não passa de uma garota vazia e infeliz, mas eu não vou perder o meu tempo com você. 
<p>- Não vai me bater? Tentar pegar seu namorado de volta? 
<p>- Vai para o inferno.
<p>- Quer deixar um recado para ele? – Giovanna não conseguia segurar sua felicidade enquanto ia até a porta para ver Emily indo embora pelo corredor.</p>
<center><h4>--*--</h4></center>
<p>- Quer dizer que a Giovanna foi para o seu quarto para...
<p>- Para isso mesmo.
<p>Chris ouviu tudo de boca aberta. Ele foi o primeiro que encontrou Will na cozinha esperando a hora passar. Os dois agora estavam encostados no balcão enquanto Will contava tudo o que havia acontecido momentos antes no seu quarto.
<p>- Nunca achei que ela se desesperaria tanto para chegar nesse ponto. – Chris não conseguia acreditar.
<p>- E você acha que eu sim? Estou chocado até agora. O que ela estava pensando?
<p>- Que você deixaria de pensar com a cabeça de cima e deixaria a Emily por ela.
<p>- Ela é louca. – Will bufou.
<p>- É só uma garota que não superou o término. Isso é mais normal do que parece.
<p>- Ah é? Suas ex-namoradas aparecem no seu quarto às vezes querendo fazer sexo com você?
<p>- Eu não tenho ex-namorada nenhuma, mas você não deveria estar tão surpreso. A garota só falta fuzilar você com os olhos quando te vê com a Emily. Era só uma questão de tempo até ela fazer isso. – Chris foi sensato. – Mas mesmo assim... É, você tem razão, ela é louca.
<p>Os dois começaram a rir.
<p>- O que você vai fazer agora? Como vai lidar com isso? Vai contar para Emily o que aconteceu?
<p>- Acho que sim. Afinal não tem para que esconder. Não aconteceu nada, ela vai acreditar. – Will não estava preocupado com aquela hipótese negativa.
<p>- E se a Giovanna contar para alguém essa história só que de um jeito diferente? Tipo, de um jeito que favoreça o lado dela?
<p>- Ela não faria isso. Seria loucura demais até para ela. Além do mais, não faz sentido nenhum.
<p>- Sei lá, hein. Essa coisa ainda está muito estranha.
<p>Mas a desconfiança de Chris perdeu atenção quando Amanda entrou na cozinha batendo a porta com muita força.
<p>- Amanda, você não vai acreditar. – Chris já começou a contar a novidade antes mesmo de Will tentar abrir a boca para falar. – Adivinha quem estava no quarto do Will agora a pouco.
<p>- Giovanna. – Ela respondeu irritada.
<p>- Como você sabe? – Will ficou surpreso. – O que aconteceu? – Ele então sentiu algo próximo de um calafrio.
<p>- A Emily foi embora e estava horrível. Torça para um dia ela olhar para a sua cara de novo.
<p>- O quê? – O calafrio se tornou uma sensação bem pior.
<p>- Ela subiu no seu quarto e a Giovanna estava lá. Você pode me dizer que diabos aquela garota estava fazendo pelada na sua cama?
<p>- Pe-pelada? Mas ela não... – Will nem conseguia dizer.
<p>Chris ficou em silêncio. 
<p>- Ela disse para Emily que você a chamou e que transou com ela.
<p>- O qu... A Emily acreditou nela?
<p>- O que você acha? – Amanda gritou – Quer que eu repita? A vadia estava pelada na sua cama.
<p>- Emily nunca mais vai falar comigo. – Will nem estava mais prestando atenção no que Amanda falava. 
<p>- Precisa ir falar com a Emily e dizer o que quer que você diga para convencê-la.
<p>- O que eu vou dizer? – Ele estava prestes a ter um ataque de pânico.
<p>- A verdade. Pelo menos a que você acha que é a verdade.
<p>- Amanda, eu não fiquei com a Giovanna. – Will se irritou com aquela desconfiança.
<p>- Eu não sou a sua namorada, não sou eu quem você tem que convencer. 
<p>- Mas você acredita em mim, pelo menos?
<p>- Acredito, agora vai.
<p>- Mas... Eu não sei o que fazer.
<p>Will colocou as mãos na cabeça e começou a pensar. Se ele fosse atrás de Emily naquele momento, ela estaria muito brava e nem deixaria ele falar nada, mas se ele esperasse ela se acalmar, seria pior, não teria a menor chance. Hesitou por alguns instantes e então saiu decidido pela porta da cozinha. Ele iria falar com a Emily e não aceitaria um “não” como resposta. Sabia o quanto chato e teimoso ele poderia ser se quisesse.</p>
</body>
</html>";
            }

            if (numero == 17)
            {
                lblTitulo.Text = "Capítulo 17 - O Homem Que Não Podem Mover";
                htmlPage.Html = @"<html>
<body>
<p><i>“E talvez eu fique famoso
<br>Como o homem que não podem mover
<br>E pode ser que você não vá gostar
<br>Mas me verá nos noticiários
<br>E voltará correndo para a esquina
<br>Porque você vai saber que isso é só por você
<br>Eu sou o homem que não podem mover”
<br><b>The Man Who Can’t Be Moved – The Script</b></i></p>
<br>
<p>- Emily! Emily!
<p>Will já estava perdendo o fôlego e ficando rouco. Já fazia mais de quinze minutos que ele gritava sem parar no portão da casa da namorada, sem resposta. Ele sabia que ela estava lá, conseguia ver a luz acesa do seu quarto pela janela, mas ela não parecia estar disposta a atendê-lo.
<p>- Emily! Desce aqui para gente conversar! Você precisa me ouvir!
<p>Nada.
<p>- Emily! Por favor!
<p>Ele olhou fixamente para a janela. Ainda tinha esperanças. Em algum momento ela apareceria lá ou desceria e conversaria com ele no portão. Ele queria vê-la nem que fosse para ser xingado, era melhor do que aquele silêncio horroroso. 
<p>- Emily!
<p>- Vai embora! – Emily abriu a janela. Ela nunca esteve tão brava, pensou Will. Sua expressão era de dar medo. – Você está incomodando a vizinhança com essa gritaria! Eu vou chamar a polícia!
<p>- A gente precisa conversar. – Will havia cansado de gritar.
<p>- A gente não precisa fazer nada! Já você precisa ir embora!
<p>- Por favor.
<p>Emily ficou em silêncio e então fechou a janela. Will respirou fundo já se sentindo um derrotado quando viu a garota saindo pela porta da frente e o encarando do outro lado do portão. 
<p>- Você tem sorte dos meus pais não estarem em casa. Eles sim já teriam chamado a polícia. Você precisa ir embora. – Ela estava muito séria e de braços cruzados.
<p>- A gente precisa conversar.
<p>- Eu não quero conversar.
<p>- Eu não vou embora. – Will estava decidido. – Emily, não aconteceu nada. Precisa acreditar em mim.
<p>- Me deixa em paz.
<p>- Eu te amo. – Ele a encarou e esperou pelo melhor.
<p>- Que bom. – Emily deu as costas para Will e foi em direção a porta.
<p>- EMILY!
<p>- VAI EMBORA! – Ela gritou enquanto fechava a porta. 
<p>- NUNCA FUGIR, LEMBRA?
<p>Will desistiu de continuar gritando. Não ia adiantar e Emily tinha razão, acabariam chamando a polícia e isso não ia ajudar ele em nada. 
<p>Já estava escurecendo, as luzes dos postes da rua já estavam acesas. Ele não sabia que hora era, seu celular havia descarregado. Saiu de casa correndo e nem percebeu que estava sem bateria. Will não podia voltar para casa, tinha que ficar lá, nem que fosse para vencê-la pelo cansaço. 
<p>Ele atravessou a rua, se sentou no meio fio da calçada e ficou observando a janela do quarto de Emily. Qualquer um que passasse pela rua naquele momento acharia que ele era um stalker louco, mas ele não estava nem aí, não sairia dali até ela descer e conversar direito com ele. 
<p>Se passou mais ou menos uma hora quando o portão automático da garagem abriu e Will viu o carro entrar. Ele logo imaginou o pai de Emily descendo todo nervoso do carro e mandando ele ir embora, mas não foi isso que aconteceu, ele foi completamente ignorado pelos pais da garota. Se eles já sabiam da história toda, Will não sabia dizer, só sabia que eles não haviam se incomodado com ele sentado na calçada em frente a casa deles sem nenhum motivo aparente. 
<p>A rua que já não era muito movimentada começou a ficar cada vez mais deserta. O estomago de Will começou a dar sinais de fome e seus olhos começaram a arder, já havia passado da meia-noite. Uma a uma, as luzes que iluminavam as janelas da vizinhança foram se apagando até o quarto de Emily ficar escuro. Ela havia ido dormir. 
<p>Will começou a cantar baixinho músicas aleatórias que vinham em sua cabeça enquanto bocejava de sono sem parar. A cada música cantada, ele calculava as horas. Uma hora... duas horas... três horas... Engraçado quantas músicas você podia lembrar e cantar em tão pouco tempo.
<p>Quatro horas... cinco horas... seis horas... O sol começou a nascer. Suas pernas estavam dormentes, suas costas destruídas e sua cabeça martelando sem parar. Pelas suas contas, daqui uma hora mais ou menos, Emily sairia para ir à escola. Ele a seguiria? Não sabia nem se tinha forças para se levantar daquela calçada, quanto mais correr atrás dela.
<p>A hora de descobrir se ele teria forças para ir atrás da garota ou não chegou mais cedo do que ele imaginava. Não se passaram nem quatro músicas quando Will viu Emily sair pelo portão com a sua bolsa no ombro e a andar pela calçada sem olhar para os lados e com uma expressão no rosto bem séria.
<p>- Emily! – Will se levantou em um salto e correu atrás dela.
<p>- Me deixa em paz! – Emily começou a andar mais rápido.
<p>- Emily, qual é?
<p>- Eu não tenho nada para falar com você. Eu já disse.
<p>- Ei. – Ele correu mais e parou na frente dela. – Eu não posso perder você. Não por isso.
<p>- Devia ter pensado nisso antes.
<p>- Você sabe que eu não fiz nada. – Ele a encarou.
<p>- A única coisa que eu sei é que você está no meu caminho. 
<p>- O que você quer que eu faça? Eu faço.
<p>- Nada, eu não quero que faça nada. 
<p>- Quer dizer que não importa o que eu diga ou faça, você não vai acreditar em mim, não é?
<p>- Exatamente. – Ela continuava séria.
<p>- Então talvez não me ame tanto quanto eu achei que amava.
<p>- Não acredito que está dizendo isso. – Emily balançou a cabeça em negação e incrédula. 
<p>- Não aconteceu nada. Não importa o que ela disse ou te mostrou. Nada foi real.
<p>- Ah não? Então eu imaginei ela no seu quarto e ainda por cima sem roupa?
<p>- Ela apareceu lá, mas eu deixei ela falando sozinha e fui embora. Foi isso que aconteceu.
<p>- Você ia me contar?
<p>- O quê?
<p>- Se eu não tivesse encontrado ela no seu quarto. Mesmo não tendo acontecido nada, você ia me contar?
<p>Will hesitou.
<p>- Vai para o inferno. – Emily o empurrou em direção a rua para liberar a sua passagem e continuou andando.
<p>- Eu já estou no inferno! Eu fiquei a noite toda aqui! – Will gritou enquanto via Emily se afastar.
<p>- Então deveria voltar para casa e tomar um banho! Está fedendo!
<p>Emily continuou andando e nem se virou para falar com ele. Will pensou em segui-la, mas desistiu antes de começar. Nada adiantaria naquele momento. Ele realmente não tinha ideia do que fazer.</p>
<center><h4>--*--</h4></center>
<p>Chris estava matando tempo lendo suas anotações de Inglês sentado em uma das mesas no pátio da escola quando Ashley chegou, beijou seu rosto e se sentou ao seu lado. 
<p>- Você soube? – Ela estava mais animada do que o normal.
<p>- Depende. O que está havendo? – Chris ficou um pouco perdido. Ele não era muito antenado nas conversas das pessoas pela escola.
<p>- Está todo mundo falando que o Will e a Giovanna voltaram. – Ela bateu palmas animada. – Eu mandei uma mensagem para ela muito malcriada. Somos melhores amigas e ela nem me contou isso.
<p>- Isso não é verdade. Estão mentindo para você.
<p>- Não. Disseram que ela mesma contou. 
<p>- Eles não voltaram, Ash. – Chris não tinha muita paciência para esses assuntos. 
<p>- Como você sabe?
<p>- Porque o Will é meu irmão, eu saberia. 
<p>- Ela mandou uma mensagem para mim ontem dizendo que ia até a sua casa, que o Will tinha chamado ela. Ela não me disse mais nada depois, eu nem esperava que... Mas é muito bom, não é? Eles juntos de novo. 
<p>- É, ela foi lá em casa, mas não foi porque o Will chamou. É, ela tentou uma reconciliação, mas ele deu um fora nela.
<p>- Como você...
<p>- Ele me contou. 
<p>- Pode ser mentira, só para você não o julgar por voltar com a Giovanna.
<p>- Não é mentira. A gente não mente um para o outro. Além do mais, ele nem gosta mais dela. – Chris fechou seu caderno e colocou na mochila, depois se levantou. – Como amiga dela, você precisa dizer a ela para superar. O Will ama a Emily, e ele não vai largar ela para ficar com a Giovanna. Quanto mais cedo ela perceber isso, melhor.
<p>Ashley sumiu com toda aquela animação e ficou séria. 
<p>- Eu preciso ir. – Chris deu um beijo de despedida na namorada e foi embora.
<p>Em cinco minutos andando pelos corredores, Chris realmente percebeu que o que a maioria das pessoas estava falando era da suposta volta de Will com a Giovanna. 
<p>- Vocês ficaram sabendo? – Ele encontrou Jason, Sebastian e Amanda em frente ao armário da irmã.
<p>- Não acredito que aquela garota espalhou isso para todo mundo. – Amanda olhava para as pessoas com cara de nojo. – Deve ser uma doente. Só pode.
<p>- Algum de vocês conseguiu falar com o Will? – Chris perguntou.
<p>- Ele não está na escola. – Jason respondeu. – E não atende o celular.
<p>- Ele não dormiu em casa. – Sebastian falou preocupado. – Ele tinha ido atrás da Emily, não foi? Para explicar as coisas.
<p>- Talvez eles conseguiram se ajeitar e estão juntos por aí. – Jason estava esperançoso.
<p>- Ou a Emily matou ele. Aposto na segunda opção. – Ela olhou para os irmãos e para Jason e viu que os três estavam olhando feio para ela. – O quê? Vocês não viram ela ontem. Estava espumando de raiva e não é para menos. Giovanna fez a cabeça dela direitinho. 
<p>- E o que a gente faz? – Chris perguntou.
<p>- Esperamos pelo melhor. – Jason respirou fundo.</p>
<center><h4>--*--</h4></center>
<p>- Ei. – Quinn correu atrás de Emily no corredor trombando com algumas mochilas. – Nem me esperou hoje. Por que saiu tão cedo?
<p>- Queria fugir do meu encosto. – Emily continuava muito brava.
<p>- Ah, tá. – Quinn não comprou a desculpa. – Eu ouvi algumas coisas nos corredores.
<p>- É, eu também. Aparentemente o Will largou a idiota da Emily aqui e voltou para o seu amor verdadeiro. 
<p>- As pessoas falam demais. Ainda mais quando a causadora dos boatos fala demais. O que você vai fazer?
<p>- Como assim? – Emily parou em frente ao seu armário. 
<p>- Aquele garoto ficou do lado de fora da nossa casa a noite toda. Foi romântico e um pouco assustador. Se isso não é uma prova de que ele te ama, eu não sei mais o que ele pode fazer.
<p>- Isso não prova nada a não ser culpa. – Emily estava decidida a pensar no lado negativo de tudo.
<p>- Olha, sem querer ser a advogada do diabo, mas já sendo... Por que você acreditou em uma garota que a gente sabe que é uma vadia manipuladora e doida, mas não acreditou no seu namorado que até agora só te conta a verdade e torce para o melhor? – Quinn estava um pouco preocupada.
<p>- Você não estava lá, tá bom? Não tem como ser mentira. Ela estava sem roupa em cima da cama e...
<p>- Pessoas conseguem tirar as suas roupas sozinhas. Isso não prova nada.
<p>- O chuveiro estava ligado e ela disse que ele estava...
<p>- Você consegue diferenciar a água caindo no chão e no corpo? Até onde eu sei, ela poderia muito bem ter ligado o chuveiro. 
<p>- A Giovanna nem sabia que eu ia para lá. Como ela ia orquestrar tudo aquilo?
<p>- Olha, eu não faço ideia. Se eu começar a achar que tudo foi um plano premeditado, eu vou olhar para ela a partir de agora com o número do hospício na discagem rápida. Então vamos pensar que foi o acaso que a ajudou. – Quinn tentou deixar o assunto um pouco mais leve com o seu sarcasmo, mas Emily continuava borbulhando de raiva. – Ele não é o papai e você não é a mamãe.
<p>- Eu não...
<p>- Eu sei que está pensando nisso. E também sei que ficou a noite toda na janela vendo ele do lado de fora. Eu nunca imaginei que seria possível alguém fazer aquilo que ele fez. Acho que ele merece pelo menos uma chance.
<p>- Eu sei.
<p>Quinn tinha dado algo para Emily pensar.</p> 
<center><h4>--*--</h4></center>
<p>Angie abriu um largo sorriso quando viu Will acenando para ela do outro lado da janela. Ela largou seus desenhos e os lápis de cor no chão da sala e correu até a porta para abraçá-lo. 
<p>- O que faz aqui? – Ela falou ainda no abraço.
<p>- Eu vim te visitar.
<p>- Achei que nunca mais iria te ver. 
<p>- O quê? Eu disse que voltaria, não disse? – Will entrou na sala e se sentou ao lado dos desenhos que ela tinha deixado no chão e ela fez o mesmo. – Cadê todo mundo? 
<p>- Não fica ninguém aqui nessa hora. As enfermeiras passam na porta toda a hora para nos vigiar. – Ela fez uma cara de criança sapeca.
<p>- E cadê a sua mãe?
<p>- Foi pegar um lanche. Mais tarde eu vou fazer outro exame. Ela come sem parar.
<p>- É, eu também como quando estou nervoso. 
<p>- Você não deveria estar na escola? Ou você é velho demais para estar na escola? – Angie ficou confusa.
<p>- É, eu deveria estar lá, mas eu não estava com ânimo para ir hoje. 
<p>- O que aconteceu?
<p>- Nada demais. – Will havia ido para o hospital visitar Angie exatamente para não pensar em Emily e em todo aquele drama envolvido. Angie fazer perguntas sobre não ia ajudar.
<p>- Sabe, eu fiquei muito popular por aqui depois do seu show. 
<p>- É sério? – Will falou impressionado.
<p>- É, eu disse para todo mundo que te conhecia e aí todo mundo começou a perguntar se eu conseguiria fazer você voltar e cantar mais e tirar fotos, dar autógrafos e essas coisas. Você ficou famoso. 
<p>- Sabe, eu acho que a gente pode distribuir autógrafos e fotos por aí. – Will sorriu. – Eu vou curtir bastante. 
<p>- Você está triste? – Angie ficou séria.
<p>- Não, por que está dizendo isso?
<p>- Está fazendo muita força para sorrir. Está preocupado com alguma coisa?
<p>- É, mas eu não quero falar sobre isso.
<p>- É por que eu sou criança e isso é papo de adulto? Eu assisto muitas novelas, sei o que é papo de adulto. Podia me contar. – Angie insistiu. 
<p>- Hum, bom... Emily e eu brigamos.
<p>- Não vai ter mais casamento? – Ela franziu a testa preocupada.
<p>Mesmo triste, Will não conseguiu evitar rir desse comentário.
<p>- Talvez não. – Ele falou.
<p>- O que aconteceu? Por que brigaram?
<p>- Contaram a ela que eu fiz algumas coisas erradas e ela não acreditou em mim quando eu disse que era mentira.
<p>- O que você fez para tentar convencer ela? Alguma serenata? Um bolo bem grande? Gritou na multidão que a amava?
<p>- Ah... não.
<p>- Como não? – Angie ficou decepcionada. – Mas são essas coisas que fazem as pessoas acreditarem nas outras. 
<p>- Eu não sou o tipo de cara que faz essas coisas. – Will sabia que esses eram os jeitos que as coisas eram resolvidas nas novelas que Angie assistia. – Eu tentei conversar com ela e não consegui.
<p>- Você a ama de verdade?
<p>- É claro. 
<p>- Então tenta mais. Demonstrar que você ama alguém nunca é demais. Se você não é esse cara, vire ele. 
<p>- Eu já te disse que você é inteligente demais para a sua idade? – Will sorriu para ela e fez carinho no gorro da garota. – Sabe... – Ele pegou um dos papéis jogados no chão e um lápis e começou a escrever alguns números nele. – Esse é o meu número de telefone. – Dobrou o papel e entregou para ela. – Entrega para sua mãe e sempre que quiser falar comigo, me liga.
<p>- É sério? – Ela pegou o papel dobrado como se fosse o melhor presente que havia ganhado na vida.
<p>- É. Se um dia você estiver na cama sem sono, você me liga e a gente conversa a noite toda ou até você dormir. 
<p>- Promete me atender toda vez que eu ligar? – Ela arregalou os olhos.
<p>- Eu prometo. 
<p>Ele levantou o mindinho, ela fez o mesmo e os dois fizeram a promessa de mindinho. 
<p>- Sabe... – Will voltou a olhar para os papéis jogados no chão. – Esses papéis... eu tive uma ideia bem romântica para reconquistar a Emily.
<p>- Eu posso te ajudar? – Angie ficou empolgada. 
<p>- Pode sim.</p>
<center><h4>--*--</h4></center>
<p>Quando Emily saiu da sua sala no fim da aula evitando olhar para as pessoas que comentavam seu suposto rompimento com Will, ela viu Sebastian parado do outro lado do corredor esperando por ela.
<p>- Sabe, eu adoro quando um irmão Jones aparece me esperando sair da aula. – Ela sorriu.
<p>- Menos mal. – Sebastian sorriu de volta. – Achei que você ia me associar com o Will e ia me dar uns tapas.
<p>- Nem ele levou tapas.
<p>- Então, garota, você está amolecendo. – Ele brincou. 
<p>- É o que dizem. – Ela agarrou o braço de Sebastian e começaram a andar pelo corredor. – Ele pediu para você vir falar comigo?
<p>- Na verdade, não. Eu nem sei onde ele está. Ele nem me falou nada sobre isso. 
<p>- Ele foi até a minha casa ontem, e quando eu sai hoje de manhã, ele ainda estava lá. Disse umas coisas, mas...
<p>- Olha, eu realmente não sei os detalhes do que aconteceu.
<p>- Mas mesmo assim está aqui. 
<p>- Eu conheço o Will como a palma da minha mão. Ele acha que não, mas eu conheço. E quando ele diz que te ama é porque te ama. 
<p>- Eu sei disso. É que... Já sentiu como se você não fosse o suficiente?
<p>- O tempo todo. Mas sempre tem alguém na minha vida que me diz que eu sou mais que o suficiente. E às vezes eu consigo acreditar nele. 
<p>Emily respirou fundo. Não sabia mais o que dizer.
<p>- O Will, mais do que ninguém, merece o benefício da dúvida.
<p>Quando eles viraram em outro corredor, perceberam que havia algo diferente. Havia várias folhas sulfite de cor rosa coladas em várias portas de armários. Todos que passavam, olhavam e apontavam, mas ninguém estava arrancando. Emily olhou para um dos papéis e estava escrito, com uma caligrafia infantil, “SEUS OLHOS”. Havia outros que estavam escritos “SEU SORRISO”, “SEU COQUE MAL FEITO COM CANETA”, “QUANDO FICA BRAVA”, “SEUS PÉS PEQUENOS”, “SEU CABELO QUANDO TEM CHEIRO DE FRAMBOESA OU QUALQUER OUTRA FRUTA, OU ATÉ MESMO QUANDO VOCÊ NÃO LAVA”, “SEUS PEITOS QUE EU OLHO O TEMPO TODO”. Ela riu quando leu aquele último.
<p>- O que é isso? – Sebastian olhava bem curioso para os papéis cor de rosa.
<p>- Bom... – Emily viu um que tinha um desenho de duas pessoas se beijando. Ela só soube dizer o que era aquele desenho porque já tinha visto antes, porque senão nunca conseguiria. 
<p>Na porta do seu armário também havia um sulfite, era azul e estava escrito, com uma caligrafia um pouco melhor: “ISSO É PARA VOCÊ!”. Ela o arrancou e ficou encarando aquelas palavras. Precisava pensar.
<p>- Acho que você não vai assistir a sexta aula. – Sebastian sorriu. 
<p>- Parece que não. Eu tenho que ir. – Ela se despediu de Sebastian com um beijo no rosto e saiu correndo desviando das pessoas pelo corredor.</p>
<center><h4>--*--</h4></center>
<p>- Ela ficou com os olhos arregalados quando começou a ler todos aqueles sulfites pregados. 
<p>Sebastian estava contando para os irmãos e para Jason na mesa do refeitório na hora do almoço a reação de Emily quando viu todos aqueles bilhetes deixados por Will nos armários. 
<p>- Eu não acredito que o Will fez isso. – Amanda estava impressionada também. – Eu nunca imaginei que...
<p>- É, ele a ama de verdade. – Chris falou. 
<p>- Alguém sabe se a Giovanna viu? – Kevin perguntou. Ele parecia um pouco preocupado com a garota. 
<p>- Se ela não viu, eu vou fazer o favor de esfregar a cara dela em cada papel. – Amanda falou brava.
<p>- Eu te ajudo. – Quinn se sentou ao lado de Sebastian e ela parecia tão animada quanto o garoto. 
<p>- Acho que podemos dizer que agora está tudo bem, não é? – Jason finalmente falou.
<p>- Assim eu espero. – Sebastian respondeu. – Não foi dessa vez que a Gi...
<p>- Olá, pessoal. – Giovanna chegou toda sorridente e se juntou a eles na mesa se sentando ao lado de Chris. Ashley ainda estava brava com ele e tinha decidido não almoçar na mesma mesa como uma espécie de castigo para o namorado. – Do que estão falando?
<p>- Do quanto as pessoas são imunes ao seu veneno.  – Amanda respondeu com um sorriso debochado. 
<p>- O quê?
<p>- Tenta melhor da próxima vez quando for enganar a minha irmã. – Quinn encarou Giovanna com uma cara fechada. 
<p>- Sabe, Giovanna. – Amanda largou os talheres no prato. – Você tem sorte de eu ser civilizada senão eu pularia em cima de você até conseguir arrancar o seu último fio de cabelo. Talvez careca, você começaria a ter mais amor próprio.
<p>- Do que você...
<p>- O Will não terminou com você por causa da Emily. – Jason falou. – E mesmo que os dois terminassem agora, ele não voltaria para você. 
<p>- Você precisa seguir em frente. – Kevin tentou consola-la. 
<p>- Você precisa é de vergonha na cara. – Amanda estava muito brava. – E deixar de ser um encosto para as pessoas. 
<p>Giovanna pegou sua bandeja e saiu da mesa irritada. 
<p>- É, acho que essa só foi a garoa. A tempestade está por vir. – Quinn fez todo mundo rir.</p>
<center><h4>--*--</h4></center>
<p>Emily conseguiu ver Will sentado em uma das pedras ainda de longe. Não era um bom lugar para se esconder. Quando ele virou o rosto e viu ela se aproximando, se levantou e esperou ela chegar mais perto. 
<p>- Eu encontrei o seu recado. – Ela mostrou o papel azul que segurava com força na mão.
<p>- Esse papel foi a única dica?
<p>- Na verdade, não. Eu vi aquele desenho... Aquele mesmo desenho que você fez no meu livro de Química enquanto...
<p>- Eu te observava estudando Geografia. – Ele sorriu. 
<p>- Eu estou aqui. 
<p>- É, você está. – Ele desceu da grande pedra e ficou na frente dela. – Eu tinha um grande discurso que estava praticando enquanto você não chegava, mas agora... 
<p>- E se eu não aparecesse?
<p>- Eu voltaria para o portão da sua casa e ficaria plantado lá. Você podia chamar a polícia, eu não ia sair. E aí todo mundo na rua ia parar a sua vida para me olhar e discutir o que estava acontecendo. Chamariam a TV e fariam uma reportagem ao meu respeito. 
<p>- Acha mesmo que isso ia acontecer? – Ela riu. – No máximo, meu pai ia assustar você. 
<p>- Me surpreendi por ele não ter feito isso ontem. 
<p>- Ele não achou que você aguentaria. 
<p>- E você achou?
<p>- Talvez.
<p>- É de você que estamos falando, é claro que eu aguentaria. Eu menti, tá bom? Aparentemente eu sou o cara que faz declarações de amor para impressionar. Eu achei que não, talvez porque eu nunca senti isso ou achei necessário. Eu estava quase indo para casa aprender a fazer um bolo porque a Angie disse que era o que eu tinha que fazer para te reconquistar. 
<p>- Bolo? Quê?
<p>- Se você quiser que eu vá até o centro da cidade e coloque um outdoor enorme dizendo o quanto eu sou apaixonado por você, eu vou. 
<p>- Isso não é necessário, embora seja uma ideia muito boa. 
<p>- Ems...
<p>- Olha, eu fui uma idiota, eu sei. Eu deveria ter deixado você se explicar e deveria ter acredito em você. – Emily respirou fundo. – Você sempre me disse a verdade e nunca me deu motivos para desconfiar. Eu sei que... Talvez eu tivesse ficado insegura. Ela realmente sabia o que eu estava pensando e o que eu questiono e usou isso contra mim e...
<p>- Como assim?
<p>- Eu sei quem você é e você sabe quem eu sou. 
<p>- E... – Will não estava entendendo muito bem. 
<p>- Eu... – Ela não conseguia dizer. – Eu não sei se... Eu ainda não estou pronta para...
<p>- Para quê?
<p>- Você sabe.
<p>Antes de Will dizer que não sabia, ele olhou bem para ela e então entendeu toda aquela conversa. 
<p>- Ems, me escuta, está tudo bem.
<p>- Não, não está não. Eu sou toda...
<p>- Eu também sou. Acho que “coisada” era a sua palavra, não é? – Ele brincou. – Olha só, eu não posso dizer que não penso nisso, senão seria mentira. É claro que eu penso. Toda vez que eu estou com você, eu sinto vontade de arrancar a sua roupa, eu tenho dezessete anos, seria estranho se eu não sentisse isso. 
<p>- Então?
<p>- O que a gente tem vai muito mais além do que isso. E... você acha que não é suficiente para mim, mas é. Eu estarei pronto quando você estiver. 
<p>- Mas e se... 
<p>- Para. Para de pensar nisso. – Ele pegou na mão dela. – Isso que a gente tem, você, é o suficiente para mim. É até mais do que eu poderia pedir.  
<p>- Eu te amo.
<p>- Eu também. Somos os sortudos dessa história. 
<p>Então ela o beijou.
<p>- Você precisou da Angie para fazer tudo aquilo na escola? – Emily sorriu.
<p>- Chegou uma hora que eu percebi que ela escrevia bem melhor que eu.
<p>Os dois começaram a rir.</p>
</body>
</html>";
            }

            if (numero == 18)
            {
                lblTitulo.Text = "Capítulo 18 - Com Você Por Perto";
                htmlPage.Html = @"<html>
<body>
<p><i>“Mas eu estou bem aqui, então não fique triste
<br>Não é só você, eu preciso disso também
<br>Tudo que eu consigo pensar é em você e eu
<br>Dirigindo com o disco do Saves The Day tocando
<br>Nós cantando até nossas vozes sumirem
<br>E eu estava caindo pra valer
<br>Você mal se aguentava
<br>E agora eu quero ir atrás do para sempre
<br>Com você por perto”
<br><b>With You Around – Yellowcard</b></i></p>
<br>
<p>“Existem momentos onde você para e pensa e de repente toda a sua vida passa na sua cabeça. Todas as suas escolhas, todos os seus caminhos. Todas as coisas que você fez e não fez. Como estaria sua vida se tivesse feito outra coisa? Melhor? Pior? Na mesma?
<p>Às vezes tudo o que você quer que aconteça, não acontece e você tem que lidar com isso. Vamos encarar, a vida não é um conto de fadas onde tudo dá certo no final, às vezes temos um final feliz, às vezes não. Mas do que adianta ter um final feliz quando a sua vida toda foi uma droga? É recompensador? Do que adianta ter tudo o que sempre sonhou, mas no final você morrer triste e sozinho? Valeu a pena?
<p>A verdade é que todo mundo precisa das experiências, independente de qual seja. Tristes, alegres, decepcionantes. É a vida. E essas experiências te moldaram. Então a pergunta certa é: você gosta de quem você é?”.</p>
<br>
<p>- Duas garotas estavam falando de mim na cantina e elas nem disfarçaram. – Emily estava contando o dia difícil que teve na escola para Will enquanto os dois caminhavam até a casa dela.
<p>- Isso é normal. Você se acostuma.
<p>- Quando você apareceu na minha sala para me buscar, eu vi gente rindo. 
<p>- Você é a idiota traída. – Will ainda tentava levar tudo na brincadeira. – Não é a única de quem estão comentando. 
<p>- Estão falando que você é incrível porque pegou duas garotas ao mesmo tempo. – Ela falou sem emoção. 
<p>- Pensando bem, teve mesmo uns caras que vieram me dar parabéns. 
<p>- Você entendeu o meu ponto.
<p>- Mas também tem umas pessoas dizendo que depois de tudo o que eu fiz com as garotas, eu mereço morrer sozinho ou em um bordel. Eu prefiro em um bordel. – Ele gargalhou.
<p>- Você não se importa?
<p>- Eu não. Por mim, podem falar o que quiserem. Já estou praticando para quando eu for famoso e tiver haters. 
<p>- Meu objetivo era passar pelo ensino médio despercebida. Agora eu não vou poder realizá-lo.
<p>- Meu objetivo era só passar pelo ensino médio, mas com as minhas notas, vai ser um objetivo impossível. – Ele fez uma piada para descontrair.
<p>- Você não leva nada a sério, não é?
<p>- Claro que eu levo. Você. – Will fez bico para beijá-la.
<p>- Ah, cala essa boca. – Ela começou a rir e o empurrou.
<p>- Olha, eu preciso te perguntar uma coisa. 
<p>- O quê?
<p>- Sobre o baile de inverno de sábado.
<p>- Vai ter um baile sábado? – Emily ficou surpresa.
<p>- Nossa, você é tão atualizada em alguns assuntos, mas para outros... 
<p>- Eu não ouvi nada sobre isso.
<p>- Engraçado porque... – Will pretendia fazer uma outra piada, mas preferiu deixar para lá. – Bom, você não quer ir, quer?
<p>- Você quer?
<p>- Só se você quiser. 
<p>- Ótimo convite, se você quer saber. – Ela levantou as sobrancelhas.
<p>- Eu não sou muito fã de baile. Mas eu topo se você topar.
<p>- Olha, eu também não curto muito baile. 
<p>- É por isso que eu te amo. – Ele a beijou. – Podemos ir ao parque ao invés disso. 
<p>- Eu vou adorar.</p>
<center><h4>--*--</h4></center> 
<p>- E com quem você vai ao baile? – Sebastian perguntou para Jason.
<p>Eles não perceberam como aquele assunto surgiu na roda de conversa. Mas lá estavam os três amigos sentados no chão da quadra naquela tarde depois de terem jogado uma partida de basquete.
<p>- Eu não vou ao baile. – Jason ficou emburrado.
<p>- Por que não? Eu também não vou levar ninguém, mas quero ir. Podíamos ir juntos.
<p>- Sebastian, se a gente for junto, vamos parecer um casal gay. 
<p>- Já falam isso de vocês às vezes. São uma inspiração para quem ainda está no armário. – Will riu.
<p>- O que você está fazendo aqui afinal? – Jason perguntou para Will. – Não deveria estar à procura de um smoking agora?
<p>- Emily e eu não vamos ao baile. Vamos fazer outra coisa.
<p>- O quê? – Sebastian estava curioso.
<p>- Ainda estou pensando. Mas fiquei sabendo que a Amanda vai sozinha e por opção, recusou vários convites. – Will olhou para Jason.
<p>- Talvez ela esteja esperando o cara certo. – Sebastian continuou.
<p>- Não vamos falar sobre isso. – Jason ficou emburrado.
<p>- Além do mais, acho que o Seb aqui não pode falar muito. Emily me falou que a Quinn vai sozinha também. 
<p>- É, ela é muito independente. – Sebastian tentou ignorar o tom de acusação de Will.
<p>- Vocês dois são inacreditáveis. – Will revirou os olhos. – Preferem ir sozinhos ao baile do que levar alguém que vocês gostam.
<p>- E quanto a você? – Jason retrucou. – Tem uma namorada e manipulou ela para não irem ao baile.
<p>- Eu não manipulei ninguém. 
<p>- Então por que ela também disse que não quer ir? Ela é uma garota. – Jason perguntou. – Garotas amam baile.
<p>- Emily é diferente. 
<p>- Se você está dizendo. – Jason usou aquele olhar que Will sempre usava nele quando sabia que o amigo estava enganado sobre alguma coisa.
<p>- Emily não quer ir ao baile. – Will falou para tentar convencê-lo, mas nem ele mesmo estava convencido disso.</p>
<center><h4>--*--</h4></center>
<p>- O que estão fazendo aqui? – Emily se assustou quando chegou em casa e encontrou Quinn e Amanda na sala de estar olhando para alguns vestidos estirados em cima do sofá.
<p>- Estamos decidindo que vestido escolher para o baile. – Quinn parecia bem indecisa. – Já escolheu o seu? Assim a gente evita de ir com vestidos da mesma cor.
<p>- Ah, eu não vou ao baile. – Ela se aproximou das duas um pouco chocada ainda.
<p>- Meu irmão não te convidou? – Amanda ficou brava.
<p>- Não, eu que disse que não queria ir. 
<p>- Por que não quer ir ao baile? A gente ama baile. – Quinn quase gritou.
<p>- Você ama baile. – Emily respondeu.
<p>- Mas... você... você tem um namorado. Nós duas que vamos sozinhas feito duas idiotas. – Agora ela estava brava.
<p>- E quanto ao Jason e o Sebastian? – Emily afastou um vestido do sofá para poder sentar na ponta da almofada. 
<p>- Jason não me convidaria nem se eu andasse com um cartaz na mão dizendo “me convide para ir ao baile”. – Amanda já estava conformada.
<p>- Sebastian é outro. – Quinn revirou os olhos. 
<p>- Vocês também têm bocas e podem convidá-los, sabia? - Emily franziu a testa e evitou um riso. 
<p>- Ela não entende. – Quinn olhou para Amanda.
<p>- E por que entenderia? Ela tem um idiota de um namorado. 
<p>- Espero que escolham um vestido bonito para disfarçarem essa “sei lá como se chama” da cara de vocês.
<p>Emily se levantou e saiu da sala.</p>
<center><h4>--*--</h4></center>
<p>Will entrou no quarto de Sebastian a mando de sua mãe para chamá-lo para jantar e o pegou sentado na cama olhando fixamente para a tela preta de seu celular.
<p>- O que você está fazendo? – Will ficou confuso.
<p>- Estava pensando se era uma boa ideia convidar a Quinn para o baile. 
<p>- E...
<p>- É uma péssima ideia. – Ele largou o celular rapidamente no criado mudo ao lado da cama.
<p>- Por quê?
<p>- Porque ela pode interpretar errado e pensar que... eu não sei se eu quero um relacionamento agora. Talvez o convite para o baile deixe subentendido que eu quero namorar com ela e aí vai dar o maior rolo. – Sebastian parecia ter aquele discurso na cabeça fazia um tempo. 
<p>- Acha que o seu problema vai atrapalhar?
<p>- Se o Harry não gosta de você, imagina de mim?
<p>- Devia se importar menos com as opiniões daquele homem. Ele não é ninguém para julgar as pessoas, na verdade ele é bem... – Will parou de falar. Não ia comentar algo que Emily contou só para ele e que não tinha nada a ver com aquela conversa que estava tendo com o irmão. – Deixa para lá.
<p>- Mas não é só isso. Não quero arrastar mais ninguém para o fundo do poço comigo.
<p>- Sua autoestima me emociona, sabia? – Will foi sarcástico.
<p>- Não é caso de autoestima, eu realmente tenho um problema.
<p>- E faz um grande caso disso e usa ele como desculpa e resposta para tudo na sua vida. “Eu não vou fazer tal coisa porque eu sou doente e posso morrer a qualquer momento. Para que eu vou pensar no futuro já que talvez eu nem tenha um?”. – Ele começou a imitar a voz e jeitos do irmão. – Eu estou cansado disso, sabia?
<p>- Não precisa falar desse jeito.
<p>- Sabe, Seb, eu te amo. – Ele se sentou na cama ao lado do irmão. – E eu sei que não é fácil, mas... Eu não sei se te contei, mas uns dias atrás, eu conheci uma garotinha no hospital, ela não tem nem dez anos e tem um tumor enorme na cabeça. Os médicos não querem operar e talvez ela tenha um ano de vida, mas sabe o que ela me disse quando nos conhecemos? – Sebastian não respondeu. – Que ela queria ir no meu casamento um dia e não parava de sorrir. Era o sorriso mais doce e inocente que eu já vi em uma criança. 
<p>- Por que está me dizendo isso?
<p>- Porque você fica aí falando coisas sem sentido. É, você tem um problema e eu sei que você luta contra ele todos os dias e isso não vai mudar. Mas você está vivo e não tem uma data de validade. Pelo que sabemos, eu posso morrer primeiro que você, qualquer um pode. – Ele fez uma pausa. – E é ridículo você dizer que não quer ficar com a garota que você gosta e que claramente gosta de você também por causa de uma coisa que nem ela parece se importar. 
<p>- Mas eu...
<p>- Você merece ser feliz. Você mais do que qualquer outra pessoa merece isso. E eu estou cansado de ficar vendo você se autodestruir o tempo todo. 
<p>- Não é tão simples.
<p>- De um lado eu tenho um amigo que é apaixonado pela minha irmã desde que nasceu e não consegue dizer para ela por vergonha ou sei lá o que e do outro, eu tenho um irmão que prefere se castigar do que viver a vida. 
<p>- Will...
<p>- Foi por isso que você usou naquele dia? Você realmente queria morrer?
<p>- Sai do meu quarto. – Sebastian abaixou a cabeça. – Sai do meu quarto agora!
<p>- Como quiser.
<p>Will se levantou e saiu do quarto.</p>
<center><h4>--*--</h4></center>
<p>Will se assustou em como foi fácil pular o muro da casa de Emily e escalar a parede para chegar até a janela do quarto dela. 
<p>- O que faz aqui?! – Ela se assustou quando viu o rosto dele na janela.
<p>- Primeiro, dizer que você precisa mandar o seu pai investir mais na segurança da sua casa.
<p>- Piadinhas a essa hora da noite? – Emily abriu a janela para ele conseguir passar. 
<p>- Eu briguei com algumas pessoas e precisava falar com alguém.
<p>- E essas pessoas são Jason e Sebastian?
<p>- Não gosto de brigar com eles, mas não aguentei.
<p>Foi mais difícil de passar pela janela minúscula do que Will imaginou. 
<p>- O que aconteceu? – Os dois deitaram na cama.
<p>- Eu odeio ouvir o Sebastian se diminuindo o tempo todo e o Jason achando que não é bom o suficiente para ninguém. Por que eles não podem ser como eu?
<p>- Como você? – Emily riu. 
<p>- Ah, qual é? A gente se conheceu e no dia seguinte já estávamos namorando. Foi rápido e fácil. E não teve nenhuma enrolação.
<p>- Espera um pouco, está me chamando de fácil? – Ela fingiu estar brava.
<p>- Acho que não tem uma resposta certa para isso. – Ele riu.
<p>- Ridículo. – Ela deu um tapa no ombro dele.
<p>- Agora, falando sério, se você gosta de alguém, por que esperar?
<p>- Nem todo mundo tem certeza absoluta e não pensa nas consequências e para sermos sinceros, até você já teve suas dúvidas.
<p>- É, mas acabou rápido. Eu estou certo e eles errados. Você é minha namorada, tem que concordar comigo. – Will estava chateado. 
<p>- Eu passei a tarde toda com a Quinn e a Amanda reclamando que iam sozinhas ao baile. Vai por mim, eu te entendo completamente. – Ela riu. – Mas você precisa também tentar entender eles. 
<p>- O Seb disse que não quer levar a Quinn para o fundo do poço junto com ele. Como eu faço alguém mudar de ideia pensando assim?
<p>- Eu não sei.
<p>- Sabe, pode parecer o maior clichê do mundo, mas quando eu te conheci eu senti uma coisa e toda vez que a gente se via eu sentia mais forte e eu adorava sentir. Foi por isso que eu me arrisquei, por causa disso. – Emily ficou em silêncio. – Eu amo ficar com você e amo sentir. Por que eles não fazem o mesmo? Eles preferem ficar sozinhos e não sentir isso que a gente sente? Qual é o problema deles?
<p>- Me desculpa, mas na minha cabeça, está repetindo “eu amo ficar com você” o tempo todo e não ouvi mais nada do que você disse depois disso. – Ela sorriu. 
<p>- Sabe, existe uma grande linha na minha cabeça que divide a minha vida “antes da Emily” e “depois da Emily”. – Ele gesticulou. 
<p>- Ah é? Que nem o calendário do Cristianismo?
<p>- Pode ser, a diferença é que eu não me lembro mais da minha vida sem você. Tipo, eu consigo ficar sem você, mas não quero. Isso faz algum sentido?
<p>- Não.
<p>Os dois começaram a rir. 
<p>- <i>Carry on</i>.
<p>- O quê? – Emily não entendeu.
<p>- Quando cantamos <i>Carry on</i>, foi quando eu percebi que estava apaixonado por você. – Ele sorriu. 
<p>- O bolinho. Quando você foi na minha sala e me trouxe o bolinho no almoço. Todo amassado. – Ela voltou a rir. – Eu adorei aquele bolinho.
<p>- Vamos virar um casal brega de velhos? – Will brincou. 
<p>- Pode contar com isso. – Ela o abraçou ainda rindo.</p>
<center><h4>--*--</h4></center>
<p>O sábado amanheceu muito bem. O sol bateu na janela logo cedo acordando o casal. Emily se levantou assustada a procura de um relógio para ver as horas. Will, ainda sonolento, foi empurrado até a janela por uma namorada muito desesperada e assustada. 
<p>Já que estava na rua, Will decidiu resolver logo uma coisa. Se tinha alguém com quem ele odiava brigar, esse alguém era Jason. O dia não era bom se eles não estivessem de bem um com o outro.
<p>- O que está fazendo aqui tão cedo? – Jason atendeu a porta ainda com os olhos quase fechados.
<p>- Precisamos conversar.
<p>- Não podia aparecer aqui só depois das dez?
<p>- Não dá. Emily me acordou de madrugada então eu acordo todo mundo também.
<p>- Will...
<p>- Eu meio que quero me desculpar. 
<p>- Por quê? Você estava certo.
<p>- Eu sei, eu só não gosto de brigar com você. 
<p>- Não foi uma briga. 
<p>- Mesmo assim. 
<p>Jason saiu de casa, ainda de pijama, e os dois se sentaram nos degraus em frente a sua porta.
<p>- O que vamos fazer sobre isso?
<p>- Will, vamos deixar para lá. 
<p>- Olha, deixando um pouco a Amanda de lado. Vamos focar em você. 
<p>- Aí piora. – Jason soltou uma risada sem graça. – Sabe por que eu não vou em nenhum daqueles bailes em que as garotas que têm que chamar os garotos? Porque ninguém nunca me chama. 
<p>- Ah, qual é, Jason? Vai ter pena de si mesmo agora?
<p>- É a história da minha vida, Will. Acha que eu não me sinto mal quando você está com a Emily e eu apareço só para atrapalhar?
<p>- Você não atrapalha.
<p>- Só diz isso porque tem que dizer, mas não é o que você pensa de verdade. Pode não pensar o tempo todo, mas já pensou alguma vez.
<p>- Já acabou?
<p>- É o que eu sinto. 
<p>- Então é isso, não importa o que eu diga, você vai não acreditar em mim? – Jason não respondeu. – Eu já menti para você? – Ele não respondeu. – Jason, se você fosse um pé no saco, eu seria o primeiro a dizer, como já disse várias vezes. – Os dois riram. – Sabe, você não atrapalha e nem é a pessoa que ninguém quer ter por perto. Eu quero ter você por perto, na verdade, eu preciso de ter você por perto. 
<p>- Por quê?
<p>- Porque você é o único que me impede de ser um lixo. Porque, de todas as pessoas, você é o único que eu escuto. Porque você é meu melhor amigo e eu posso ser a pessoa mais terrível desse mundo, mas eu sei que você sempre vai estar lá por mim, pode até me bater, mas vai estar lá.
<p>- Talvez eu não tenha escolha.
<p>- Não. É porque você não desiste das pessoas. Porque a gente se conhece a vida toda. Porque nos piores e melhores momentos, a gente está junto. Porque se não fosse por você, eu nunca seria... Eu. Você é meu parceiro.
<p>- Eu também te amo. – Jason tinha lagrimas nos olhos quando abraçou o amigo.</p>
<center><h4>--*--</h4></center>
<p>Sebastian estava esperando na frente do portão quando Quinn saiu de casa naquela manhã.
<p>- O que faz aqui? – Quinn ficou surpresa.
<p>- Ah... Eu queria conversar com você. – Sebastian estava um pouco envergonhado, mas demonstrava determinação.
<p>- Podia ter me ligado.
<p>- Tem coisas que é melhor dizer pessoalmente.
<p>- Como o quê? – Ela ficou interessada.
<p>- Você já tem par para o baile de sábado?
<p>- Não. Pretendo ir sozinha.
<p>- É, eu também vou sozinho, aí eu pensei que a gente podia... sei lá... se encontrar lá e... – Sebastian começou a olhar para os lados totalmente desconfortável.
<p>- Tá bom. – Quinn sabia que não ia conseguir um convite mais explícito, então não forçou. – Eu te mando uma mensagem quando chegar lá.
<p>- Vou estar esperando. – Ele sorriu sem graça.
<p>- Ótimo. – Ela retribuiu o sorriso.
<p>- Ótimo.</p>
<br>
<p>“Você se desafia quando faz algo que ninguém esperava que fizesse, nem mesmo você. Com é difícil tomar uma decisão, fazer uma escolha que você sabe que pode acabar com a sua vida ou recomeçá-la de um jeito diferente, não é? Soa um pouco dramático, mas viver a vida não é só existir e ir em linha reta, isso não é viver, nem de longe, então sim, antes mesmo de morrer, sua vida pode já ter acabado. É errado ter medo? Receio? Esperar pelo pior? Sim e não. Cada pessoa sabe o que é importante para ela e outros podem não entender nem aceitar, mas é o que é.
<p>Mas a verdade é que quando você não diz ou faz o que precisa dizer ou fazer, algo fica faltando, eu não sei dizer exatamente o que é, mas você não fica completo, e além disso, fica pensando no que poderia ter sido. O que teria acontecido se eu tivesse me desculpado com aquela pessoa? O que teria acontecido se eu tivesse ido atrás de alguém para a impedir de ir embora porque ela era muito importante para mim? O que teria acontecido se eu tivesse dito “eu te amo” para a pessoa que eu amo? Eu não sei, nunca vou saber. E todas essas perguntas na sua cabeça, você também não vai ter uma resposta. Pelo menos não uma concreta.
<p>Você já se olhou no espelho e imaginou como a sua vida vai estar daqui a dez anos? Vinte anos? Trinta anos? Você ainda vai estar sofrendo as consequências dos erros que cometeu? Das coisas que não fez? Do apoio que não recebeu? Da verdade que não contou? Daqui alguns anos, a pessoa que você ama vai continuar a mesma? O sentimento ainda vai ser aquele que te deixa feliz e com esperança e com paz de espirito? Para o seu bem, é melhor que sim.”</p>
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
            if (condicao + 1 > 18)
            {
                Navigation.PushModalAsync(new Capitulo4Page(condicao + 1));
            }
            else
            {
                Navigation.PushModalAsync(new Capitulo3Page(condicao + 1));
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
                    ////DependencyService.Get<IMessage>().ShortTime(message1);
                }
                else
                {
                    LerCapitulo(condicao.ToString(), "false");
                    ////var message = "VOCÊ DESMARCOU UM CAPÍTULO";
                    ////DependencyService.Get<IMessage>().ShortTime(message);
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