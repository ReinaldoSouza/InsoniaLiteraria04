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
    public partial class Capitulo6Page : ContentPage
    {
        DBFire service;
        public int condicao;
        public Capitulo6Page(int numero)
        {
            InitializeComponent();
            service = new DBFire();
            condicao = numero;
            mostrarCapituloSalvo("EsseMundoVaiMudar", "Capitulo" + numero.ToString());

            if (numero == 31)
            {
                lblTitulo.Text = "Capítulo 31 - Mais Duas Pessoas Sozinhas No Mundo Hoje à Noite";
                htmlPage.Html = @"<html>
<body>
<p><i>“E haverá mais duas pessoas sozinhas
<br>No mundo hoje à noite, amor, você e eu
<br>Somos só mais duas pessoas sozinhas
<br>Que desistiram da luta do certo ou do errado
<br>Bem, você sabe que meu coração está doendo
<br>Não precisa destruí-lo 
<br>Se o amor não faz você mudar de ideia”
<br><b>Two More Lonely People - Miley Cyrus</b></i></p>
<br>
<p>Jason não tomou café da manhã em casa e foi para a praia correr um pouco, estava tudo deserto e ele tinha tempo para pensar. 
<p>Ele não gostava mais de ficar em casa, não era como antes. Depois que seu pai apareceu, estava tudo estranho. Sua mãe mal falava e quando falava eram palavras de apoio ou coisa parecida. Ele não queria apoio. Na verdade, ele não sabia bem o que queria. 
<p>Will já estava sem ar quando cruzaram o primeiro quilômetro.
<p>- Você está mesmo levando a sério esse negócio de corrida. – Jason brincou quando voltou com uma garrafa de água que comprou no quiosque mais próximo.
<p>- Eu só tenho três meses. – Will mal conseguia falar. 
<p>- Não posso perder isso de jeito nenhum. Acho que vou me inscrever também. Preciso de algo para...
<p>Então ele parou de falar. Seu rosto ficou tão branco que ele parecia que ia ter um treco. Will começou a procurar o que o amigo olhava com tanta intensidade até que achou. 
<p>- Ele não nos viu. Podemos dar a volta. – Will sugeriu, mas Jason não se mexeu. Ele queria sim fugir, a última pessoa que queria encontrar naquela praia era o seu pai, mas seu corpo estava imóvel. Era uma sensação muito ruim. 
<p>Richard os viu e caminhou lentamente em direção a eles.
<p>- Esse lugar é lindo, não é? Senti saudade da praia. – Ele sorriu assim que ficou próximo dos dois. Will fechou a cara e sorriu sem mostrar os dentes nem vontade de sorrir. – Que bom que vocês ainda... estão juntos. 
<p>- É, eu não sou de abandonar pessoas. – Will se segurou, mas não conseguiu evitar de dizer aquilo.
<p>- Filho, podemos conversar? – Richard tentou ignorar Will.
<p>- Não dá. – Jason também estava com a cara fechada.
<p>- Sua mãe me passou o seu número, mas você não...
<p>- Não atendo chamadas desconhecidas. Fica longe da minha mãe e fica longe de mim. Você entende isso?
<p>Richard então olhou para Will. Ele mesmo sabia que Will não era a sua melhor escolha, sua irmã seria de mais ajuda, mas não tinha outra opção naquele momento.
<p>- Não olhe para mim. Eu só não dou um murro na sua cara por respeito ao Jason e à sua idade. – Will respondeu o olhar. 
<p>- Vocês já tomaram café? Nós podemos... 
<p>- Não estou com fome. – Jason continuava na defensiva.
<p>- Eu até estou com fome, mas de novo, respeito ao meu amigo. A não ser que a oferta seja muito boa e... – Will parou de falar. Pela cara de Jason, nem piadas ele estava aceitando. 
<p>- Que tal um almoço? Ou eu posso te pegar depois da escola e...
<p>- Eu não tenho dez anos, pai. Ninguém precisa me pegar na escola e eu sei almoçar sozinho, muito obrigado.
<p>Jason pegou animo e começou a correr para longe dali. Will sabia que não ia alcança-lo tão cedo, então nem se atreveu a ir na mesma velocidade que ele.
<p>- Will! – Richard o gritou antes que ele começasse a correr. – Não pode conversar com ele?
<p>- O quê?
<p>- Você é amigo dele. Se você disser, talvez ele... Ele te ouça. 
<p>- Olha, sem querer ser mal-educado, eu não vou fazer isso. 
<p>- Prefere que ele continue me odiando?
<p>- Jason só está ressentido. Eu estava aqui quando você foi embora e vi tudo o que ele passou e como ele ficou, mas ele não te odeia, você é o pai dele. Já eu, nem consideração eu tenho por você. E eu falei sério, só não te dou um soco na cara por causa dele. Então não vem pedir ajuda para mim. 
<p>Will deu as costas para ele e voltou a correr. Tinha esperanças que Jason parasse no meio do caminho, porque nunca o alcançaria se ele ainda estivesse correndo.</p>
<center><h4>--*--</h4></center>
<p>- Boas notícias. – Melissa estava sentada sozinha em uma das mesas espalhadas no pátio da escola lendo um livro quando Sebastian chegou todo animado e se sentou ao lado dela. – Eu descobri por uma fonte confiável que os gibis mais raros das editoras vão ser leiloados na feira por preço de banana. Já vou pedir meu presente de aniversário adiantado para o meu pai.
<p>- Nossa, que legal. – Melissa tentava não mostrar muita animação.
<p>- É, eu sei que a gente não tem dinheiro o suficiente para comprar muitos, mas quem sabe um ou dois e...
<p>- Tudo bem. – Melissa deu uma risadinha sem graça.
<p>- Está tudo bem? Eu sei que você ficou um pouco mexida com a morte da amiga do Will, eu também fiquei, mas... Não achei que... – Sebastian percebeu que Melissa estava um pouco estranha.
<p>- Não é nada, eu estou ótima. É que eu não vou poder ir à feira. 
<p>- Por que não?
<p>- Ah, é que... – Melissa tinha adiado tanto aquela conversa, mas ainda não tinha pensado em uma desculpa muito convincente. – Uma prima minha vai vir para a cidade nesse mesmo dia. Ela vai vir de muito longe para me ver e não seria legal eu sair bem no dia que ela quer ficar comigo.
<p>- Leva ela junto, problema resolvido.
<p>- Ah, sem chance. Ela odeia essas coisas. – Melissa se esquivou.
<p>- A Quinn também, mas ela vai mesmo assim. As duas podem ficar reclamando juntas enquanto a gente se diverte.
<p>- Ah, eu acho melhor não.
<p>- Tem certeza? A gente fala sobre isso há dias. 
<p>- Eu tenho sim. Espero que se divirta.
<p>- Está tudo bem mesmo? Estou com a impressão que está me escondendo alguma coisa.
<p>- Então para de ser paranoico. Eu não estou escondendo nada. Os planos mudaram, só isso.
<p>- Tudo bem então. – Sebastian ainda estava desconfiado. – Eu vou tirar muitas fotos lá e quando você ver, vai ser como se estivesse lá. Se tiver sorte, eu ainda consigo alguns gibis para gente. 
<p>- Tá bom. – Ela sorriu. Não conseguiu evitar.</p>
<center><h4>--*--</h4></center>
<p>- Quinn, espera.
<p>Chris correu atrás da garota quando a viu passando pelo corredor da escola. Agora que ele estava sem a Ashley do seu lado, precisava de alguém para conversar. Ficar sozinho o tempo todo não era muito legal.
<p>- Oi. – Ela sorriu para ele. – Espero que não me convide para outra festa. 
<p>- Vai ser difícil recusar depois da última, não é?
<p>- E você me disse que era caseiro. Eu sou uma inocente. – Ela levantou uma das sobrancelhas.
<p>- Eu te juro. Foi a minha primeira festa. Pelo menos, daquele jeito. 
<p>- Acredito.
<p>- Sabe, ontem eu tomei um sorvete em uma barraca na praça. – Chris deu aquela informação como se tivesse sido uma grande vitória, mas Quinn não entendeu muito bem o motivo. – Eu adoro tomar sorvete e eu sempre tomava com você-sabe-quem. Não vou deixar de tomar agora que estou solteiro. 
<p>- Você-sabe-quem? Não fala mais o nome da Ashley ou se referiu a Voldemort? – Quinn brincou.
<p>- É mais fácil seguir em frente desse jeito. 
<p>- Se está dizendo. 
<p>- É sério. Eu percebi que não compensa ficar triste por algo que nunca mais vai acontecer.
<p>- Você nunca teve tanta razão na sua vida como agora. E quer saber? Não precisa tomar sorvete sozinho. Da próxima vez, me chama e se for pagar, melhor ainda. 
<p>- Farei isso. Que tal hoje à tarde?
<p>- Está marcado.</p>
<center><h4>--*--</h4></center>
<p>- Podemos conversar?
<p>Jason ficou paralisado quando viu seu pai no portão da escola o esperando. Amanda até levou um susto quando seu namorado parou de repente. Ela apertou a mão dele bem forte quando viu o motivo. 
<p>- Eu estou com pressa. – Jason já havia fugido de Richard de manhã. Seu plano continuava o mesmo. 
<p>- Filho, por favor. 
<p>- Será que não entende que eu não quero falar com você? – Jason estava muito bravo, mas evitou gritar. Não queria ter pessoas perguntando o que estava acontecendo, ele não tinha na cabeça nenhuma boa desculpa para aquilo.
<p>- Jason, se acalma. – Amanda falou baixinho para ele. – Por que não vamos para outro lugar?
<p>- Eu não vou para lugar nenhum com ele. 
<p>- Jason, eu... – Richard estava nervoso. Suas mãos estavam no bolso. Queria esconde-las. Quando ficava nervoso, começava a mexer muito as mãos. – Eu sei que você está bravo e tem todo o direito de estar.
<p>- Tenho mesmo. 
<p>- Mas eu estou aqui para acertar as coisas.
<p>- Você está morrendo? É isso? Não quer ir para o inferno sem o meu perdão? – Jason estava inquieto. Amanda olhava de um para o outro muito preocupada.
<p>- Não tem nada a ver com isso. Eu sei que é tarde, mas não precisa ser tarde demais. Só me dá uma chance. 
<p>- Se eu aceitar, você me deixa em paz depois? 
<p>- Se for o que você quer.
<p>- Ótimo. Você tem meu telefone, me manda uma mensagem dizendo o lugar. 
<p>- Tudo bem. Quer que eu te leve em casa? – Richard estava ainda um pouco receoso.
<p>- Não. Não tenho dez anos, posso ir sozinho para casa. Ah, quase ia me esquecendo. Você já não se importava quando eu tinha dez anos.
<p>Jason puxou a mão de Amanda e os dois foram embora. Richard preferiu não tentar segui-los. Já tinha conseguido o que queria.
<p>- Você está bem? – Amanda finalmente falou depois que já estavam bem longe da escola.
<p>- A pergunta certa é se eu vou ficar bem. – Jason respondeu um pouco pensativa.</p> 
<center><h4>--*--</h4></center>
<p>- Então ele conseguiu te convencer? Vai sair mesmo com o seu pai?
<p>Will e Jason estavam na quadra velha perto da casa dos dois arremessando bola um para o outro. Will olhava para o amigo como se quisesse sondá-lo ou descobrir as coisas só com as suas expressões faciais. 
<p>- É. – Jason não sabia muito bem o que dizer. – Ele não ia me deixar em paz se eu não aceitasse. 
<p>- Esse é mesmo o motivo?
<p>- Sabe que não. Mesmo eu ainda não confiando nele, eu...
<p>- Você quer sair com ele, conversar. É seu pai, não tem nada de errado nisso. – Will falou calmamente, mas ainda o fitava profundamente.
<p>- O que você acha?
<p>- Quer a verdade ou quer que eu minta?
<p>- Will...
<p>- Você me conhece. Eu compro as brigas dos outros, sinto a dor alheia e sou mais rancoroso que você. 
<p>- Eu sei, mas o que quer dizer?
<p>- Quero dizer que eu acho que você está cometendo um erro. Eu quero muito estar errado, mas não consigo parar de pensar nisso. 
<p>- Por favor, você precisa me apoiar, não vou conseguir fazer isso se você for contra.
<p>- Eu não estou sendo contra, eu estou feliz por você. Se ele estiver realmente arrependido, vai ser incrível, vai ter o que sempre quis, mas... Eu me preocupo com você, não dá para evitar.
<p>- Eu sei. E não vamos criar muita expectativa, de repente esse jantar acaba sendo uma droga.
<p>- Não. Vai ser muito bom. Vai dar tudo certo. – Will tentou ao máximo mostrar positividade mesmo que dentro da sua cabeça, ele achasse que aquele jantar seria um desastre e seu amigo acabaria machucado de novo. – Conversou com a sua mãe sobre isso?
<p>- Ela disse que não vai se meter, que, além de tudo, ele é meu pai e eu que tenho que decidir. 
<p>- E como ela está lidando com tudo isso? Afinal, desde... ela nunca mais ficou com ninguém, nem por diversão. Acabei de perguntar por que sua mãe não faz sexo casual, isso é nojento. – Will fez uma careta e os dois começaram a rir. 
<p>- Ela não vai perdoá-lo. Não vou ser uma criança inocente achando que a minha família vai ficar reunida de novo um dia, isso não vai acontecer. 
<p>- Mas e quanto a outra mulher? Eu achei que seu pai...
<p>- Você sabe tanto quanto eu. Vamos conversar sobre tudo isso no jantar. Eu tenho várias perguntas.
<p>- Eu também. Posso escrever elas para você?
<p>- Óbvio que não, mas vai ser o primeiro a saber as respostas.
<p>- Não mereço menos que isso. – Will riu. – E não importa o que aconteça nesse jantar, eu estou aqui.
<p>- Eu sei.
<p>- Não, é sério. Eu sou o cara para fazer uma festa de boas-vindas para o seu pai com um sorriso no rosto ou arrancar os dentes dele na porrada com toda a força que eu tenho. Você só precisa escolher. 
<p>- Valeu. – Jason riu.</p>
<center><h4>--*--</h4></center>
<p>Sebastian e Quinn estavam passeando pela praia. Por algum motivo, Quinn escondeu do namorado que saiu para tomar sorvete com Chris depois da escola e isso estava deixando ela um pouco estranha. Sebastian não percebeu, tinha suas próprias preocupações. 
<p>- Ah, eu tenho que dizer uma coisa para você. – Sebastian finalmente decidiu dividir seus pensamentos com a namorada.
<p> Coisa boa ou ruim?
<p>- Para você pode ser boa. – Ele riu.
<p>- Como assim?
<p>- Acho que eu não vou mais para a feira.
<p>- O quê? – Mesmo Quinn suspeitando do motivo, não deixou de ficar surpresa. – Mas eu já estava até pesquisando camisas de Guerra Nas Estrelas para comprar. 
<p>- Eu duvido muito. – Sebastian sabia que Quinn nunca faria aquilo. – Mas a Melissa não vai poder ir, então...
<p>- Podemos ir só nós dois então. – Suas suspeitas se confirmaram. 
<p>- Eu sei que você não quer ir, só está sendo uma boa namorada. Além do mais, era uma coisa que ela e eu estávamos combinando de ir juntos. Mesmo eu dizendo para ela que iria mesmo assim, acho que não é legal e não vai ser a mesma coisa sem ela. 
<p>- Ah, eu posso ser a substituta, ué? – Quinn sabia que aquela feira era muito importante para Sebastian, ele não falava sobre outra coisa há dias, e agora saber que ele não queria ir por algo que ela causou não a fazia se sentir bem. 
<p>- Não se trata disso. 
<p>- E por que ela cancelou de repente?
<p>- Disse que uma prima vem visita-la. 
<p>- Que dureza. – Quinn mal conseguiu disfarçar. – Bom, eu posso começar a estudar essa área de nerds e podemos ir no ano que vem, sem que eu fique totalmente perdida. 
<p>- Combinado então. – Sebastian soltou um sorriso. – Mas mesmo assim, ainda acho que ela estava estranha. – Ele falava mais para ele mesmo do que para Quinn. – Você podia conversar com ela para descobrir o que está havendo.
<p>- Por que eu?
<p>- Talvez seja coisa de garota, ela não vai me dizer.
<p>- A gente mal conversa. 
<p>- Tem razão. Acho que vou pedir para a Emily. 
<p>- Ou devia deixar para lá. Talvez seja algo pessoal que ela não queira compartilhar, como as suas coisas. 
<p>- Ela sabe que eu sou viciado.
<p>- É sério? – Quinn não ficou feliz com aquela informação. – Eu achei que você não contava isso para ninguém. 
<p>- Meio que escapou quando estávamos em São Francisco. 
<p>- Es... – Quinn pensou em reclamar, mas resolveu não seguir aquele caminho. – Vamos para casa? Queria ver um filme.
<p>- Na sua casa, com o seu pai por perto?
<p>- Pode ser na sua então. – Ela riu.
<p>- Bem melhor.</p> 
<center><h4>--*--</h4></center>
<p>Will estava na casa de Melissa. Aquele era o sofá mais confortável que ele já havia se sentado. Embora na televisão estivesse passando um programa de fofoca que não curtia, ele estava esperando por um certo bolo que ela falou que a mãe colocou no forno fazia algum tempo. 
<p>- Então você cancelou o passeio nerd com o Sebastian com uma desculpa esfarrapada. O que acontece agora? A escola não é tão grande, você não vai conseguir fugir para sempre.
<p>- Eu não quero fugir. – Melissa explicou. – Eu só vou ficar mais na minha.
<p>- Não está mais respondendo as mensagens dele. Ele até me perguntou se eu sei de algo. 
<p>- O que você disse?
<p>- Eu disse que não sei, mas odeio mentir para ele. 
<p>- Você precisa continuar mentindo. – Melissa estava praticamente o ameaçando com um olhar bravo. 
<p>- Olha, eu não pretendo dizer nada a ela sobre isso se é o que quer, mas eu tenho que dizer que isso é um erro. Um grande erro.
<p>- Por que você acha que é um erro?
<p>- Porque, primeiro, se gosta dele, deve dizer.
<p>- Emily me disse isso. – Melissa bufou.
<p>- E ela está certa. Regra número um: nunca esconda seus sentimentos, nunca.
<p>- Ele está com a Quinn.
<p>- Isso, e se ele gostar de verdade da Quinn, vai te dizer e você vai poder seguir em frente. E eu acho que isso é melhor do que ficar fugindo. 
<p>- Não é tão simples. Para você, pode ser, mas...
<p>- Deu certo para mim. 
<p>- Olha, quando eu cheguei aqui, o Sebastian já estava com a Quinn, eu sou a intrusa.
<p>- Pessoas se apaixonam o tempo todo. Isso não é nenhum pecado. 
<p>- Eu não quero ser a garota que se mete no meio de um casal. Eu não sou esse tipo. 
<p>- Não acho que se trata disso. 
<p>- Olha, a Quinn é a certa dessa história. Ela só está defendendo o que é dela. 
<p>- Eu não estou falando que ela está certa ou errada. Só estou dizendo que eu conheço o Sebastian, e se ele descobrir de algum jeito que a Quinn agiu pelas costas dele e mandou você ficar longe, vai ficar uma fera. Ele vai achar que a namorada não confia nele e isso vai destruí-lo.
<p>- E eu falar isso para ele vai ajudar como? – Melissa não entendia como aquilo poderia ter um final diferente de desastroso.
<p>- Talvez não ajude, mas pelo menos os segredos acabam. Sabe que em alguma hora isso vai acontecer.
<p>- Sua vida amorosa está tão chata que você precisa ir bagunçar as dos outros?
<p>- Na verdade, minha vida está ótima porque eu fui sincero com os meus sentimentos. Devia tentar.</p>
<center><h4>--*--</h4></center>
<p>- Onde estava? – Emily estava esperando por Quinn no seu quarto quando ela chegou. 
<p>- Por quê? Nunca ficou preocupada antes. – Quinn jogou sua jaqueta na cama despreocupada e foi para a sua penteadeira.
<p>- Estava com o Sebastian? – Emily estava parada perto da janela com os braços cruzados. – Ou com o Chris?
<p>- Com o Sebastian. O que está insinuando?
<p>- Contou para ele que foi tomar sorvete com o Chris?
<p>- Não foi necessário. Foi só uma coisa entre amigos. 
<p>- Ah, eu entendi. Você pode sair com os seus amigos, mas ele não pode sair com os dele. – Emily estava com os seus olhos julgadores.
<p>- É diferente. – Quinn encarou a irmã. – Eu só estou ajudando ele a superar um término.
<p>- Papo furado. Vocês estão saindo juntos quase todos os dias e indo a festas...
<p>- Foi só uma vez. 
<p>- Quinn, o que você está fazendo?
<p>- Eu não gosto do Chris.
<p>- Eu sei, e não me importa. – Emily se aproximou mais da irmã. – Mas o que você fez com a Melissa, e pior, o que você fez com o seu namorado...
<p>- Mas aquela garota...
<p>- O Sebastian não vai te trair, Quinn. Eu sei disso e você sabe disso. 
<p>- Não pode ter certeza. Ele é um garoto. 
<p>- Então o que vai fazer? Vai ameaçar toda garota que se aproximar dele? Quinny, isso não é saudável. 
<p>- Eu não consigo evitar. Me desculpa. 
<p>- Precisa conversar com ele. Dizer o que sente. Você está insegura, isso é normal. 
<p>- Talvez eu diga.
<p>- Quinn!
<p>- Eu vou pensar, tá bom? Agora pode sair do meu quarto, por favor? – Quinn já estava irritada e sem paciência.</p>
<center><h4>--*--</h4></center>
<p>- Will, para de se mexer, parece que eu estou dormindo com algum bicho.
<p>Já passava das duas da manhã. Will se virava na cama o tempo todo e não conseguia pegar no sono. 
<p>- Eu não consigo dormir. 
<p>- O que está havendo? Eu achei que você já estava...
<p>- Não é a Angie, é o Jason. 
<p>- É o lance do pai? – Emily se virou para olhar o namorado nos olhos.
<p>- Eles vão se encontrar amanhã à noite. 
<p>- E você não concorda com isso.
<p>- Nem um pouco. Eu tentei dar apoio, mas... Estou quase indo lá e proibindo ele de fazer isso. Estou com um mal pressentimento.
<p>- Will, eu sei que está preocupado e também sei que é bem provável que você odeie mais aquele homem do que o próprio Jason.
<p>- Muito provável. 
<p>- Mas você precisa deixar para lá. Jason precisa decidir isso sozinho.
<p>- Eu sei, mas não dá para evitar.
<p>- Cadê a sua positividade? – Emily sorriu. 
<p>- Não está disponível ultimamente. 
<p>- Olha, essas últimas semanas foram difíceis, mas... 
<p>- Acho que a gente anda muito intenso.
<p>- Exatamente. 
<p>- Sabe, eu tive uma ideia. A gente pode gastar nossa energia em outra coisa e já que estamos acordados... – Will sorriu.
<p>- Eu gostei dessa ideia.
<p>Emily ficou por cima dele e o beijou.</p>
<center><h4>--*--</h4></center>
<p>- Você está lindo.
<p>Amanda penteava o cabelo de Jason com os dedos para irritá-lo.
<p>- Acha que meu pai vai gostar? – Jason estava nervoso. Ele já havia trocado de roupa quatro vezes e naquele momento estava alisando sua camisa pensando se deveria trocá-la de novo. 
<p>- Não precisa colocar um terno. É um encontro com o seu pai, não uma entrevista de emprego. – Amanda riu.
<p>Jason precisava se encontrar com o pai no Bob’s às oito horas da noite, mas estava tão ansioso que começou a se arrumar às quatro da tarde. Naquele momento faltava apenas uma hora para o tão esperado encontro e seu coração parecia que ia sair pela boca.
<p>- Olha, relaxa um pouco. Esse encontro vai ser um pouco estranho, mas vai ser só o primeiro. Vai melhorar depois. – Amanda segurou nas mãos geladas de Jason. – Qualquer coisa me liga, eu vou lá te socorrer. – Ela riu. 
<p>- E você? O que vai fazer hoje?
<p>- Bom, aparentemente, meus dois homens têm compromisso hoje. Will vai para o cinema ver algum filme ridículo de garota. Então, eu vou para casa fazer pipoca e assistir um filme ridículo de garota também. 
<p>- A Proposta de novo? – Jason sabia que esse era a única comédia romântica que Amanda assistia.
<p>- A Proposta de novo. – Ela sorriu. 
<p>- Vai dar certo, não vai? Eu estou fazendo a coisa certa? Você acha que... talvez eu deva ligar para ele e dizer que...
<p>- Olha, uma hora você ia ter que falar com o seu pai querendo ou não. Não dá para fugir para sempre.
<p>- Mas...
<p>- Faça todas essas perguntas que estão na sua cabeça há anos. Escute, não grite e se no final, der algo errado, eu vou estar aqui te esperando. 
<p>- Então talvez, seja melhor que dê tudo errado. – Jason beijou a namorada sorrindo.</p>
<center><h4>--*--</h4></center>
<p>- Você ainda acha que eu fiz a coisa errada, não é? – Quinn observava, sentada na cama, Emily se arrumando para ir se encontrar com Will. 
<p>- Não importa mais o que eu acho. Obviamente, você não vai lá desfazer.
<p>- Eu simplesmente não posso. – Quinn ficou brava.
<p>- Acha mesmo que o Sebastian te trairia com a Melissa, não é?
<p>- Se ela der trela, sim. 
<p>- Nossa. – Quinn conseguiu ver a cara de reprovação de Emily pelo reflexo do espelho. 
<p>- Ah, qual é, Emily? Nem todo romance é um conto de fadas como o seu onde o Will só tem olhos para você. 
<p>- Eu não estou falando disso. Se você acha que o Sebastian te trairia com a Melissa, quer dizer que acha que ele pode sentir algo por ela. Quer mesmo ficar com alguém que sente atração por outra pessoa?
<p>- Vamos mudar de assunto, por favor?
<p>- É o que a gente faz sempre, não é?
<p>- O que vai fazer hoje? – Quinn mudou logo de assunto.
<p>- Will e eu vamos ao cinema. 
<p>- Que interessante. 
<p>Quinn não podia dissertar sobre aquilo então ficou em silêncio. Depois de uns minutos, o silêncio foi quebrado com alguém batendo na porta do quarto.
<p>- Quem é? – Emily gritou achando aquela atitude estranha, seus pais não tinham costume de bater na porta. 
<p>- Sou eu, Emily. Sebastian.
<p>- Sebastian? – Emily olhou para Quinn. – Pode entrar.
<p>- Sua mãe me disse que você e a Quinn estavam aqui. Me deixou subir. – Ele entrou no quarto sorridente. 
<p>- Querido, o que faz aqui? – Quinn se levantou, foi até o namorado e o beijou. 
<p>- Na verdade, eu queria falar com a Emily.
<p>- Comigo? – Emily não disfarçou a surpresa.
<p>- Queria que conversasse com a Melissa e perguntasse a ela se está acontecendo alguma coisa. Ela anda um pouco estranha e...
<p>- Ah. – Emily não soube esconder o desconforto.
<p>- Ela te contou algo? Acho que ela contou para o Will também, mas ele desconversou quando eu perguntei. 
<p>- Ah, eu não sei de nada. – Ela respondeu rápido. 
<p>- Tudo bem. Mas você poderia...
<p>- Claro, eu posso perguntar. – Emily concordou. 
<p>- Tudo bem. – Sebastian sorriu. – Quinn, eu queria dizer que não vamos poder sair semana que vem porque vou passar o dia todo com o Will e o Jason, coisas de garoto.
<p>- Tudo bem. – Quinn agiu como se aquilo não fosse nada demais.
<p>- Tudo bem mesmo para você? Você deixa eu fazer isso?
<p>- Como assim? 
<p>- Eu preferi vir aqui perguntar. Não quero que amanhã ou depois você vá até eles e ordene que eles fiquem longe de mim, ou você só faz isso com garotas?
<p>- Ah, eu acho melhor deixar vocês sozinhos... – Emily deu um passo em direção a porta.
<p>- Não, fica. – Sebastian ficou sério. – Como pôde fazer isso? – Ele encarou a namorada.
<p>- Você não está entendendo. Foi isso que ela te disse? – Quinn se desesperou. Ela não tinha ideia de como ia sair daquela situação.
<p>- Não, ela não me disse. Na verdade, ninguém me disse nada. – Sebastian olhou de Quinn para Emily e depois voltou para a namorada. – Por isso eu estou aqui, porque eu quero que você olhe nos meus olhos e diga que você não fez nada disso. Me diga que você não foi até a Melissa e disse a ela para se afastar de mim. 
<p>- Eu não...
<p>- Quinn.
<p>- Eu não sabia o que fazer. Vocês não se desgrudavam mais.
<p>- Somos amigos, Quinn. Qual é o problema disso?
<p>- Ah, por favor, Sebastian. Eu sei que você é inocente e não vê a maldade, mas acha mesmo que essa Melissa não sente nada por você?
<p>- O que ela sente ou deixa de sentir não é da sua conta e muito menos da minha. Você é a minha namorada.
<p>- Não parece. Porque é com ela que você conversa o tempo todo, marca encontros, fala dos seus problemas...
<p>- Um encontro. – Sebastian a interrompeu. – Para uma feira, que eu já tentei marcar com o Will, com o Jason e com todos os meus irmãos. A única diferença é que ela também curte e aceitou.
<p>- E quanto a passarem a noite juntos?
<p>- Isso é ridículo. Eu não tive escolha, você sabe muito bem. Além do mais, na mesma noite, você estava aqui com o Chris. Exatamente nesse quarto. – Sebastian estava bravo, mas evitou gritar, não queria causar um alvoroço. 
<p>- É diferente, ele tinha acabado de terminar o namoro, eu estava tentando dar apoio.
<p>- E nós estávamos presos no trânsito por causa da chuva e nada demais aconteceu.
<p>- Você só não enxerga, mas não quer dizer que não seja verdade. Emily... – Mas a irmã olhou para Quinn e demostrou que não estava ali para ajudá-la.
<p>- Você mentiu para mim e agiu pelas minhas costas. Fingiu surpresa quando eu disse que ela havia cancelado o encontro quando na verdade, você foi a causadora disso. Quer dizer que eu só posso ter os amigos que você aprovar? Só posso conversar com a Emily porque ela é sua irmã e namora meu irmão?
<p>- Sabe que não é isso.
<p>- É exatamente isso. Agora é a Melissa, mas depois vai ser qualquer outra garota que eu conversar no corredor da escola. Você está agindo feito louca. 
<p>- Eu não sou paranoica, nem sou a louca ciumenta, mas me desculpa, eu não consegui suportar que...
<p>- Então viesse falar comigo. Dissesse o que estava sentindo. Eu sei que eu também sou péssimo nisso e demorei uma década para deixar você entrar na minha vida, mas... depois que eu abri a minha guarda, eu fui totalmente sincero com você e o mínimo que eu queria era o mesmo da sua parte. – Sebastian estava totalmente desapontado.
<p>- Vamos tentar esquecer isso por favor.
<p>- Não. Eu preciso de um tempo.
<p>- Um tempo?
<p>- Um tempo de você.
<p>- Sebastian, não faz assim.
<p>- Devia ter pensado nisso antes. 
<p>Sebastian saiu do quarto antes que Quinn falasse qualquer outra coisa. Emily a olhava com aquele olhar de “Eu te avisei”, mas ela não reclamou. Na verdade, ela nem sabia mais o que dizer.</p>
<center><h4>--*--</h4></center>
<p>- Como você acha que ele descobriu?
<p>- Não foi a Mel. Ela quase ameaçou cortar a minha cabeça se eu falasse algo para ele. 
<p>Will e Emily estavam caminhando até o cinema. Ela havia contado o que aconteceu em sua casa, a briga de Sebastian com Quinn e Will ficou bem surpreso. 
<p>- Eu sabia que isso ia dar um grande problema. 
<p>- Olha, vamos parar de falar sobre esse triangulo amoroso e vamos falar de outra coisa.
<p>- Acha que o Sebastian gosta da Melissa?
<p>- Emily! – Will arregalou os olhos. – Outra coisa.
<p>- Ainda está preocupado com o Jason?
<p>- Outra coisa que não seja essa. – Will estava tentando esquecer que o amigo ia se encontrar com o pai naquela mesma noite.
<p>- Ah, tudo bem então... O que vamos assistir hoje?
<p>- Qualquer filme que você não chore no final.
<p>- Impossível.
<p>- Verdade, você chora até com comédia. 
<p>- Cala a boca. – Emily deu um leve tapa no ombro de Will e começou a rir.
<p>A noite estava perfeita para um passeio. O clima estava bom, as ruas movimentadas, eles já estavam quase desistindo de ir ao cinema para ficarem passeando por aí quando Emily segurou o braço de Will com tanta força que ele até se assustou e parou de andar abruptamente. 
<p>- Ai, o que foi? – Will fez uma careta.
<p>- Que horas mesmo era o jantar do Jason com o pai?
<p>- Acho que às oito, por quê?
<p>- Que horas são agora?
<p>- Ah... quase nove. – Will pegou seu celular do bolso e olhou as horas na tela.
<p>- Olha, eu não tenho certeza absoluta porque tudo o que eu vi foram fotos, mas... Acho que o pai do Jason está ali no ponto de ônibus.
<p>Emily apontou e assim que fez, Will olhou e confirmou. 
<p>- É, é ele mesmo.
<p>Richard estava sentado em um dos bancos do ponto de ônibus. Ele estava com uma mochila bem grande nas costas. Seu pé batia bem apressado no chão como se estivesse inquieto.
<p>Embora Emily não achasse uma boa ideia, Will foi até ele. 
<p>- O jantar foi rápido, não é? Você pagou por hora?
<p>- Will, oi. – Richard ficou nervoso assim que viu os dois se aproximando. – É que eu não consegui...
<p>- Ele está lá te esperando, não está?
<p>- Na verdade, eu preciso voltar para Chicago. Eu recebi um telefonema, uma proposta de emprego e se eu não sair daqui agora, eu posso perder e... você sabe como as coisas estão difíceis... – Richard começou a se explicar.
<p>- Besteira.
<p>- Will, vamos embora. – Emily puxou o braço de Will, mas ele não se moveu. 
<p>- O que está acontecendo?
<p>- Eu tenho uma família, sabia? – Richard tirou a carteira do bolso e abriu. Tirou de lá uma foto bem pequena e mostrou para Will. Duas garotinhas sorrindo o encarava. – Minhas filhas. São tudo na minha vida. 
<p>- Por que voltou?
<p>- Eu achei que daria certo, mas...
<p>- Papo furado. Eu quero a verdade. 
<p>- Eu... minha mulher e eu íamos nos separar e disse que tiraria minhas filhas de mim. Como nunca fomos casados, ela disse que ia conseguir provar que eu nunca fui um pai presente e que qualquer juiz ficaria do lado dela e eu acabaria sem nada. – Richard falava bem rápido. – Eu entrei em pânico e... 
<p>- E se lembrou que tem outro filho, assim as suas chances de ficar sozinho seriam quase nulas porque sabe que ele estaria aqui te esperando de braços abertos por ele ser um trouxa. 
<p>- O que mudou? – Emily também o encarava, mas não com raiva e sim, com desprezo.
<p>- Ela me ligou e a gente conversou e... acontece que ela quer tentar de novo e eu também quero, pelas nossas filhas.
<p>- Mas nossa! – Will começou a bater palmas e a gritar. – Meus parabéns! Se importa com as suas filhas! É o pai do ano!
<p>- Will... – Emily tentou fazer ele parar, mas foi inútil.
<p>- Acontece que você também tem um filho aqui e ficou muito confortável em abandoná-lo por quase dez anos. 
<p>- Eu sei e eu sinto muito...
<p>- Não sente nada até porque está fazendo o mesmo de novo, fugindo como um bandido. 
<p>- Assim que eu resolver as coisas, eu vou voltar e...
<p>- Guarde suas mentiras para quem acredita. Seja um homem de verdade e vá falar com ele.
<p>- Eu não<p> posso. 
<p>- Você é o pai dele! – Will não conseguia acreditar no que estava ouvindo. – Você infernizou ele até conseguir uma chance e agora que ele abaixou a guarda, você vai fazer isso? Que tipo de pessoa é você?
<p>- Você é um garoto. Não entende. – Por algum motivo que Will não entendia, Richard ficou bravo com aquelas palavras. – Ser um pai não é o mar de rosas que você imagina.
<p>- O que você sabe sobre isso? Você nunca foi um pai. Você nunca se importou com o Jason e levando em consideração o fato de que a sua esposa te ameaçou e você já correu para cá para refazer a vida, você não se importa nem com as suas filhas. Você é um lixo.
<p>- Escuta aqui, garoto...
<p>- Não, escuta você. É, eu não sei como é ser um pai, mas uma coisa eu sei. É melhor mesmo que você suma e nunca mais volte. Jason vai ficar bem melhor sem você, ele é muito melhor sem você. Ele não precisa de você. Ele é um cara incrível, totalmente diferente do pai de merda que ele tem.
<p>- Não vou discutir sobre isso com você. – Richard olhava desesperado para a estrada na esperança de um ônibus aparecer.
<p>- Seu filho está te esperando.
<p>- Eu não conseguiria me despedir. É muito duro.
<p>- Papo furado! Você não conseguiria era encará-lo e admitir a droga de pai que você é. Você é um covarde. 
<p>- O que você sabe?
<p>- EU ESTAVA LÁ! Fui eu que fiquei, dia após dia, vendo ele sofrer pelo abandono do pai, sentindo saudade, esperando você aparecer, se perguntando se ele tinha algum problema para não merecer ser amado pela única pessoa que ele queria que o amasse. Ele nunca teve nenhuma explicação e isso acabou com ele. 
<p>- Eu também sofri. 
<p>- Hipócrita desgraçado. – Will se desvencilhou de Emily e foi para cima de Richard. – Eu poderia acabar com a sua raça agora, arrancar todos os seus dentes e fazer você ir para Chicago todo fodido. – Ele apontou o dedo na cara de Richard. – Você é um merda e não importa quantas desculpas queira inventar, você nunca vai deixar de ser um merda. 
<p>Will estava com uma vontade enorme de dar um soco na cara daquele homem, mas se controlou. Emily foi até ele e o afastou de Richard. Os dois ficaram lá parados vendo Richard pegar o primeiro ônibus que passou sem nem ao menos olhar para trás. 
<p>- Jason ainda deve estar lá esperando por ele. – Emily ainda estava chocada.
<p>- Acho que vamos ter que deixar o cinema para outro dia.
<p>- Vai. – Emily o beijou.
<p>- Posso te levar para casa.
<p>- Vai logo.
<p>- Tá. A gente se vê no seu quarto mais tarde.</p>
<center><h4>--*--</h4></center>
<p>- O que faz aqui a essa hora da noite?
<p>Melissa ficou surpresa quando deu de cara com Sebastian, inquieto e todo nervoso, parado na sua frente quando abriu a porta de casa. 
<p>- A gente precisa conversar. Eu posso entrar?
<p>- Já está muito tarde. É melhor não. – Ela hesitou. – O que foi?
<p>- Quer me contar?
<p>- Sebastian...
<p>- Eu sei de tudo. Eu sei que a Quinn mandou... – Ele mal conseguia falar. – Ela mandou você ficar longe de mim. 
<p>- Como descobriu? 
<p>- Eu estava preocupado com você. Vim aqui ontem à tarde para conversar. A porta estava aberta, eu entrei e ouvi você e o Will conversando na sala. 
<p>- Que droga.
<p>- Devia ter me contado.
<p>- Por quê? O que faria se eu tivesse te contado?
<p>- Acabei de terminar com a Quinn. 
<p>- Eu sinto muito. – Melissa não sabia o que dizer. Segurava a maçaneta com toda a força. – Devia ir para casa se acalmar e pensar a respeito.
<p>- Eu queria muito falar com você agora. Eu...
<p>- Sebastian, é melhor você ir. – Melissa ficou séria. 
<p>- Eu ouvi tudo. – Sebastian não se referia mais só a Quinn e sim os sentimentos que Melissa poderia sentir por ele.
<p>- Vai embora, eu não quero falar sobre isso.
<p>- Melissa...
<p>- Vai. A Quinn está certa. Isso tudo é uma loucura.
<p>- Não.
<p>- No sábado passado, ficamos três horas conversando por telefone, e depois que desligamos, você apareceu na minha porta me convidando para irmos à lanchonete comer aquele hamburguer que você tanto falava.
<p>- E o que tem de mal nisso?
<p>- Ficamos mais três horas lá conversando. 
<p>- Isso não quer dizer...
<p>- Eu te contei coisas. Coisas que eu nunca contei para ninguém. 
<p>- Eu também te contei. A gente confia um no outro, que mal há nisso?
<p>- Você acabou de terminar com a Quinn, a sua namorada, ou brigar, sei lá, e está aqui conversando comigo. Isso não está certo. 
<p>- Tudo bem, eu confesso, eu... gosto de ficar com você e eu não quero que isso mude. Você é engraçada, divertida, me faz bem. Eu esqueço as merdas da minha vida quando eu estou com você e eu gosto disso. 
<p>- Sebastian, vai embora, por favor. 
<p>- Eu nunca quis que... – Sebastian percebeu que não deveria estar falando aquelas coisas para ela.
<p>- Eu sei, agora vai. 
<p>Melissa fechou a porta na cara do garoto. Ele ficou parado na frente da porta por alguns instantes antes de seguir o seu caminho de volta para casa. Nunca esteve tão confuso em toda a sua vida.</p>
<center><h4>--*--</h4></center>
<p>Jason estava parado na frente da lanchonete olhando fixamente para o relógio no seu pulso quando Will o viu ainda do outro lado da rua. Ele passou o caminho todo tentando pensar em uma desculpa, uma mentira, para contar ao amigo e evitar que ele soubesse que seu pai havia o abandonado de novo, mas não conseguiu achar absolutamente nada. Jason não acreditaria em nada.
<p>- Will, oi. O que faz aqui? – Jason franziu a testa. Will era a última pessoa que ele esperava ver ali.
<p>- Oi, cara. – Will respirou fundo.
<p>- Achei que estaria no cinema.
<p>- Eu ia, mas... Olha, Jay, eu queria mesmo apoiar você, mas não consigo tirar isso da cabeça.
<p>- Como assim?
<p>- Isso é uma má ideia. 
<p>- O quê?
<p>- Por que a gente não vai embora? Amanhã você telefona para o seu pai e diz que não está pronto ou sei lá, não fala nada. 
<p>- Will, eu não estou entendendo. – Jason ficou inquieto.
<p>- Eu não acho que você se encontrar com o seu pai já tão rápido seja a coisa certa. Você precisa ainda pensar e...
<p>- Você não veio até aqui para me dizer isso.
<p>- Eu vim sim, porque eu sou seu melhor amigo e não quero que... Vamos embora, vamos. Ele não merece que você... – Will mal conseguia terminar a frase. 
<p>- Ele não vem, não é?
<p>Por um segundo, Will pensou de novo em mentir. Ele poderia ter sofrido um acidente, ter sido sequestrado. Tinha acabado de morrer. Mas ao invés disso, ele disse...
<p>- Não. 
<p>Jason demorou menos de um segundo para digerir aquilo e então foi como se ele estivesse fazendo muita força para não desabar ali mesmo. 
<p>- Jason, eu... eu realmente queria que isso desse certo. Eu realmente queria que você conhecesse o seu pai e ficasse bem. Eu realmente... Eu sinto muito.
<p>- Não, tudo bem. Eu deveria ter esperado por isso.
<p>- Não é culpa sua.
<p>- Eu sei. Eu sou crescido agora, não vou me culpar por algo que eu não... Eu não preciso dele. Achei que o conhecer melhor seria uma boa, mas aparentemente nunca vou saber.
<p>- Eu nem... Eu não sei o que dizer.
<p>- Achei que ele demoraria mais tempo para ir embora dessa vez. – Ele soltou uma gargalhada e uma lágrima escorreu dos seus olhos. – Eu só queria que ele me amasse. Só isso. 
<p>- Eu sei disso. – Will o abraçou. Achou que Jason cairia no choro quando fizesse aquilo, mas não foi isso que aconteceu. O amigo continuou segurando. 
<p>- Acho melhor eu voltar para casa.
<p>- Não. Vamos entrar.
<p>- O quê? Dois minutos atrás, você estava querendo que a gente fosse embora. E você tem o cinema e...
<p>- O cinema vai estar lá amanhã.
<p>- Will, é sério. Você não precisa.
<p>- Eu preciso sim. Além do mais, você está vestido como se fosse a um casamento, não podemos desperdiçar isso. – Will riu. Jason não riu de volta, mas apreciou a tentativa. – Agora vamos, estou morrendo de fome.
<p>- Tudo bem.</p> 
<br>
<p>“Às vezes você sente que o seu mundo está prestes a desabar. Alguém te abandona, você descobre mentiras de alguém que você ama, você briga com alguém e não pode voltar atrás e às vezes nem quer, embora esse alguém faça falta, você sente algo por alguém que não sente o mesmo. 
<p>Às vezes nesses momentos, você vai estar sozinho e terá que lidar com tudo isso por conta própria. É difícil, eu sei, mas não é impossível. Afinal, no fim do dia, tudo o que sobra são você e seus pensamentos, mas isso não quer dizer que não seja bom ter um amigo para te ajudar a superar, para te aconselhar, te acalmar ou para simplesmente estar lá do seu lado quando ninguém mais está.
<p>Algumas pessoas tem sorte. Elas têm com quem contar, já outras, bom, tem algumas pessoas que não tem essa sorte e é uma pena. A vida é complicada demais para se viver sozinho. 
<p>Às vezes, tudo o que você precisa é de uma mão estendida para você segurar. Uma ajudinha. Um “estou aqui por você”.”.</p>
</body>
</html>";
            }

            if (numero == 32)
            {
                lblTitulo.Text = "Capítulo 32 - Ninguém Vai Fazer O Que Eu Faço Por Você";
                htmlPage.Html = @"<html>
<body>
<p><i>“Mas, ninguém vai tentar por você
<br>Ninguém vai fazer o que eu faço por você
<br>Ninguém vai chorar por você
<br>E ninguém vai amar você
<br>E ninguém vai fazer o que eu faço por você”
<br><b>I For You - The All-American Rejects</b></i></p>
<br>
<p>Will desceu as escadas correndo. Ele geralmente não atendia a porta quando estava sozinho em casa, mas aquela pessoa era bem insistente. A campainha estava tocando já fazia uns dez minutos. 
<p>- Pois não? – Will encarou o desconhecido que estava do lado de fora.
<p>- Ah, oi. Eu gostaria de falar com o Kevin. Ele está em casa? – O homem, de mais ou menos vinte e poucos anos, sorriu como em um gesto de gentileza.
<p>- Você é amigo dele? – Will não conhecia bem os amigos de Kevin, principalmente naquele momento que mal se falavam, mas aquele homem devia ter dez anos a mais que o irmão. Era uma amizade um pouco estranha.
<p>- Sou o Leo. Ele está bem? Não tem me atendido.
<p>- Ah, aparentemente está. – Will o olhou mais detalhadamente. – Vocês se conheceram aonde? Estudam juntos? Nunca te vi no colégio. 
<p>- Ah, não. Eu já me formei. Nos conhecemos em uma festa faz alguns meses. Carlos estava lá. 
<p>- Ah, eu não conheço nenhum Carlos. – Will sorriu para não parecer mal-educado, mas não estava gostando nada daquela situação. – Bom, ele não está. Se quiser esperar...
<p>- Na verdade, eu estou com um pouco de pressa. Podia dizer a ele que estive aqui?
<p>- Claro. Mas existe celular hoje em dia, pode ligar para ele.
<p>- Ah, ele não costuma me atender. É complicado. 
<p>- Vou fingir que entendi. 
<p>- Bom, só diz que eu estive aqui. 
<p>- Tudo bem. – Will deu de ombros. 
<p>- Até mais.
<p>Leo se despediu e foi embora. Aquela conversa foi a mais estranha que Will já teve na vida.</p>
<center><h4>--*--</h4></center>
<p>- Tudo bem, se depender de mim, você não vai ficar nessa depressão, não.
<p>Amanda entrou no quarto de Jason, arreganhou a porta, começou a abrir as cortinas e janelas para entrar ventilação. O garoto ainda estava deitado com as luzes apagadas e já fazia um bom tempo que o sol havia nascido.
<p>- O que você está fazendo? – Jason resmungou enquanto cobria o rosto com o cobertor.
<p>- Jason, levanta agora! – Amanda estava brava. – Sua mãe já está ficando louca.
<p>- Eu não posso mais dormir?
<p>- Já são quase uma da tarde. Você é o tipo de garoto que madruga na porta da padaria para comprar pães quentes ou porque tem alma de velho.
<p>- Eu estou cansado. Não estou a fim de acordar agora.
<p>- Não me interessa nenhum pouco. – Amanda puxou o cobertor da cama de Jason e o jogou no chão. – Will acha que você precisa de um tempo, eu digo que esse tempo acabou.
<p>- Meu pai foi embora. Eu tenho o direito de ficar triste pelo menos por um tempo.
<p>- Não no meu turno. – Amanda batia o pé no chão e continuava firme.
<p>- Amanda, por favor... – Jason estava praticamente suplicando. – Eu quero ficar sozinho.
<p>- Você tem quinze minutos para se levantar, trocar de roupa, escovar os dentes e sair dessa casa.
<p>- Amanda...
<p>- Estou te esperando lá fora.
<p>Amanda bateu a porta do quarto quando saiu.
<p>- Mas que saco. – Jason murmurou.</p>
<center><h4>--*--</h4></center>
<p>Quinn e Emily estavam almoçando sozinhas na mesa pequena da cozinha. Seus pais haviam saído e as duas não queriam arrumar a mesa da sala só para dois pratos. As duas estavam bem quietas. Emily não conseguia se acostumar com sua irmã não tendo nada a dizer.
<p>- Já falou com o Sebastian hoje?
<p>- Não. Ele pediu um tempo e só se passou um dia. – Além de quieta, ainda estava mal-humorada.
<p>- Olha, eu acho que seria bom vocês conversarem agora. A cabeça está mais fria, talvez entendam que...
<p>- Eu não quero falar com ele agora, Emily, e também não quero falar sobre isso.  
<p>- Então do que quer falar?
<p>- De nada, por isso estou quieta. 
<p>- Quinny...
<p>- Ele passou a noite com a Melissa, não foi?
<p>- O quê? De onde você tirou isso?
<p>- Quando a Rachel e o Ross deram um tempo, ele foi transar com uma qualquer.
<p>- Bom saber que você baseia a sua vida em séries de TV. – Emily fez cara feia. 
<p>- Ele pediu um tempo. Não posso bancar a sonsa e ir atrás dele. Preciso esperar.
<p>- Você precisa é se desculpar.
<p>- Mas eu me desculpei. – Quinn se alterou.
<p>- Mas não de verdade. A real é que você não se sente arrependida nem acha que fez algo errado. 
<p>- Mas eu não fiz.
<p>- Você é impossível, sabia?</p>
<center><h4>--*--</h4></center>
<p>Will abriu o seu armário e pegou lá no fundo uma pilha de anuários que só aumentava a cada ano. Ele jogou os livros todos em cima da cama e começou a folheá-los um por um. Uma coisa que ele sempre gostou sobre os anuários da escola, além de poder curtir com a cara dos outros com suas fotos horríveis, era que se esquecesse do rosto de algum estudante, sempre poderia encontrar a foto dele no livro e sua memória clarearia. 
<p>A foto de Leo estava lá, mas não tinha nenhuma informação importante sobre ele. 
<p>- Will?
<p>Sebastian entrou no quarto de repente e quase assustou Will que estava sentado na cama olhando o anuário. 
<p>- Nossa, bom saber que você gosta de bater na porta. – Will olhou de cara feia para o irmão.
<p>- Eu queria falar com você. – Sebastian também estava com uma cara de poucos amigos.
<p>- Você conhece um tal de Leo? – Will levantou o anuário e apontou para a foto de Leo para Sebastian ver melhor. – Eu sei que é um nome comum, mas...
<p>- Ele não estudava Biologia com você no primeiro ano? Lembro que ele já era repetente uns cinco anos. – Sebastian se aproximou para ver melhor. – Acho que até largou a escola depois daquele ano. 
<p>- Ele apareceu aqui hoje.
<p>- Atrás de você? O que ele queria?
<p>- Não estava atrás de mim, queria falar com o Kevin.
<p>- Então você está bisbilhotando a vida do Kevin? – Sebastian desaprovava a situação. 
<p>- Só estou curioso, só isso. Não é como se eu fosse ir atrás desse Leo e obrigasse ele a parar de falar com o Kevin. – Will piscou para o irmão.
<p>- Eu peguei a referência e é exatamente o que eu quero falar com você.
<p>- Pode falar. – Will fechou o livro e afastou os outros para dar espaço para o irmão se sentar também. 
<p>- Eu sei de tudo. – Sebastian não se sentou.
<p>- Eu sei. Emily me disse que estava lá quando você brigou com a Quinn. 
<p>- Você pretendia me contar algum dia? Sei lá, talvez um dia não tão distante?
<p>- Eu não podia te contar, a Melissa...
<p>- E quanto ao “garotos antes de garotas”?
<p>- Não é bem esse o ditado. Na verdade, assim fica estranho. – Will franziu a testa.
<p>- Você entendeu. 
<p>- Seb, me desculpa, eu não ia te contar, mas que bom que você descobriu. Melissa sabe...
<p>- Eu fui até lá ontem. Fui falar com ela, fui me desculpar e...
<p>- Se desculpar pelo quê?
<p>- Pelo modo como a Quinn agiu e...
<p>- Isso não faz o menor sentido. 
<p>- Como assim?
<p>- Você terminou com a Quinn e foi atrás da Melissa? Geralmente... 
<p>- Eu não terminei com a Quinn, a gente deu um tempo.
<p>- E o que vai fazer com esse tempo? – Will estava muito confuso. – Eu sugiro que descubra o que sente pela Melissa.
<p>- Do que está falando?
<p>- Gosta dela?
<p>- Ela é minha amiga e eu estou namorando a Quinn. 
<p>- Isso não quer dizer nada.
<p>- Will, você sabe o quanto é difícil para mim me relacionar com alguém, ainda mais se esse alguém sabe o que já aconteceu comigo.
<p>- Seb...
<p>- Quinn esteve lá por mim várias e várias vezes e ficou lá esperando até eu finalmente abaixar a guarda. Ela...
<p>- Então você vai continuar namorando ela por isso? Por gratidão? Seb, tem noção do quão ridículo isso é? É, a Quinn fez tudo isso, ela é incrível... Mas tudo bem se apaixonar por outra pessoa, isso acontece. 
<p>- Eu não posso. 
<p>- Então o que você vai fazer?
<p>- Me afogar na praia, talvez?
<p>- Tente de noite. Não tem quase ninguém lá e não corre o risco de alguém tentar te salvar.
<p>- Não é engraçado.
<p>- Não, não é. 
<p>Os dois ficaram em silêncio e se encarando por um bom tempo. Sebastian, então, respirou fundo e finalmente disse.
<p>- Acho que gosto da Melissa. 
<p>- Já é alguma coisa. – Will sorriu.</p>
<center><h4>--*--</h4></center>
<p>- Eu disse quinze minutos, não uma hora. 
<p>Amanda estava na varanda totalmente sem paciência quando Jason abriu a porta e saiu de casa. 
<p>- Achei que se eu demorasse um pouco, você iria embora.
<p>- Já namoramos há muitos meses e você nem me conhece? Estou decepcionada.
<p>- Me diz qual é a sua ideia. O que vamos fazer agora? – Jason não estava nada animado. 
<p>- Vou te levar para um lugar.
<p>- Que não seja um orfanato.
<p>- O quê?
<p>- Eu entendi. Meu pai me abandonou, mas muitas crianças não têm pai nem mãe e não estão fazendo tanto drama quanto eu.
<p>- Eu não vou te levar para um orfanato, embora fosse uma boa ideia.
<p>- Então para onde?
<p>- Você vai ver. – Amanda sorriu e pegou na mão do namorado.</p> 
<center><h4>--*--</h4></center>
<p>Will estava na cozinha preparando um lanche para comer. Quando sua mãe não estava em casa, ele nunca comia comida “de verdade”. A porta da cozinha estava entreaberta então de lá conseguiu ouvir o movimento da sala de estar. 
<p>Alguém tocou a campainha e antes dele pensar em largar a mão do pão, ouviu alguém descendo as escadas e atendendo a porta. Após alguns minutos de sussurros, ele ouviu a voz de Kevin mais alto, ele parecia um pouco nervoso.
<p>- Eu ainda não tenho o seu dinheiro.
<p>- Eu te dei um prazo. – Aquela outra voz era de Leo, Will tinha certeza.
<p>- Eu vou conseguir, só preciso de mais um tempo.
<p>- Vou voltar amanhã, se não me entregar, alguém vai ter que me entregar. Seus irmãos, seus pais...
<p>- Você prometeu segredo. – Kevin respondeu bravo. 
<p>- E você prometeu me pagar. Que tal nós dois cumprirmos nossas promessas?
<p>- Eu só preciso de mais um tempo. 
<p>- Olha, você estava bem loucão quando resolveu fazer negócios comigo. Acho que a culpa foi minha, não deveria ter te levado a sério. – Leo parecia estar calmo, mas o seu tom era um pouco intimidador. – Mas não importa, como eu disse, se você não pagar, alguém vai e não me interessa quem. Eu só quero o meu dinheiro. 
<p>- A gente pode se encontrar amanhã à noite, no CarBar. A gente conversa e acerta tudo.
<p>- Tudo bem. – Leo bufou. – Vou te dar mais uma chance. 
<p>- Muito obrigado.
<p>- Mas se você não levar meu dinheiro, você está morto, entendeu?
<p>Kevin não respondeu. 
<p>Leo saiu e Will ouviu Kevin fechar a porta. Sua vontade era de ir até a sala e confrontar o irmão para saber o que estava acontecendo, mas decidiu ficar onde estava. Não era o momento.</p>
<center><h4>--*--</h4></center>
<p>- Por que estamos fazendo trilha? Eu odeio fazer trilha. 
<p>Jason amava correr na praia e praticar esportes, até mesmo os radicais, mas trilha não era mesmo o seu negócio. Ele odiava estar cercado de mato e mosquitos e sem sinal de celular. Amanda estava castigando-o.
<p>- Eu tinha dez anos quando meu pai me levou para a minha primeira trilha.
<p>- E isso prova o quê?
<p>- Não prova nada. Eu só quero compartilhar o meu sentimento com você.
<p>- Eu não entendi.
<p>Quando Amanda apareceu naquela tarde na casa dele o chamando para sair, Jason logo imaginou um encontro romântico, algo inesquecível que faria ele esquecer a sua amargura, mas estava sendo o oposto. Sentia mais ódio do que antes.
<p>- Eu odeio trilha. – Jason resmungou.
<p>- Eu também. – Amanda riu enquanto andava um pouco na frente. O sol já estava perdendo a sua força, logo eles teriam que voltar. 
<p>- Então o que estamos fazendo aqui?
<p>- Seu pai não te obrigou a fazer trilha como o meu me obrigou, então agora estou te obrigando.
<p>- Eu ainda não entendi nada. 
<p>- Eu estou tentando dizer que eu odiei meu pai por me trazer para cá. Você não precisou odiar o seu por isso.
<p>- Não por isso, mas por me abandonar e por ter outra família. Só por isso. 
<p>- Que saco. – Amanda estava esgotada.
<p>- Amanda, aonde você quer chegar?
<p>- Eu estava tentando te mostrar que ser abandonado pelo pai tem seu lado bom. Deveria se concentrar nele.
<p>- Lado bom? – Jason fez uma careta. – Você ficou louca? Que lado bom isso tem?
<p>- Você não aguentou sermão, nem precisou se preocupar com o dia dos pais, não teve “a conversa” embaraçosa. Pais não são tão legais assim. Quantas vezes eu desejei que o meu fosse embora? Várias.
<p>- Você tem um ponto. Mas eu senti falta de todas essas coisas. 
<p>- Tudo bem então, plano B.
<p>- Plano B?
<p>- Para de sentir falta dele e de se sentir um miserável. Ele foi embora e talvez nem volte mais. Você cresceu, evoluiu, mas ele continua o mesmo. Você não quer ter alguém como ele na sua vida. Só te traria dor de cabeça.
<p>- Eu sei, mas não consigo evitar.
<p>- Olha, eu entendo, mas eu sou a sua namorada. Isso já é um motivo para a sua vida ser maravilhosa. 
<p>- Você até que tem razão, sabia? – Jason sorriu. Ele percebeu o grande esforço que Amanda estava fazendo. Embora aquele lugar estivesse uma droga e ele estivesse se sentindo uma droga, aquela garota estava lá e isso já era o suficiente para ele conseguir sorrir espontaneamente. 
<p>- É, eu tenho. – Ela também sorriu.
<p>- Eu te amo por estar aqui. – Jason, todo suado, beijou sua namorada.
<p>- Eu também te amo.</p> 
<center><h4>--*--</h4></center>
<p>Seria bem difícil ter que encarar Quinn depois do que aconteceu entre eles, mas Sebastian precisava falar com ela. Ele mal tinha conseguido dormir, as palavras de Will ficaram martelando a cabeça dele a noite toda e isso era péssimo para a sua situação. O sol havia acabado de nascer e ele já estava tocando a campainha, parado em frente ao portão da casa de Quinn, esperando pelo pior, mas torcendo pelo melhor. Ficar calado ou a evitando não ia ajudar.
<p>- O que está fazendo aqui? – Quinn o atendeu ainda de pijama. Ela estava com uma grande cara de sono e seus cabelos, soltos, estavam despenteados. – Achei que não ia aparecer aqui tão cedo. E isso não foi eufemismo. 
<p>- Eu sei, é que...
<p>- Você pediu um tempo. Esse tempo já acabou? – Quinn estava um pouco brava. – Posso saber o que você fez durante esse tempo?
<p>- Eu pensei. Pensei muito durante esse tempo. 
<p>- Que bom. – Quinn preferiu dizer poucas palavras e esperar que Sebastian dissesse o resto.
<p>- Embora eu ainda não consiga entender muito bem nem aceitar o que você fez, eu... Eu não quero brigar, quero resolver as coisas.
<p>- Como? Fingindo que nada aconteceu?
<p>- Não, isso não funciona para mim. 
<p>- Então o que você quer, Sebastian? Eu tentei, tá? Eu fiz de tudo para isso dar certo e eu exagero às vezes, mas... – Quinn começou a achar que aquela conversa toda era um erro. Ela queria voltar para cama, dormir e esquecer que aquilo estava acontecendo. 
<p>- Quinn, você é muito importante para mim.
<p>- E mesmo assim, gosta da Melissa.
<p>- Não. Para com isso, eu não gosto... – Então ele ficou em silêncio, respirou fundo e resolveu simplesmente dizer. Quinn merecia a verdade. – Na verdade, eu não sei se gosto. Eu não sei. Eu gosto de ficar com ela, mas você é a minha namorada e gosto de ficar com você. Eu nunca te trairia.
<p>- Eu sei disso, mas eu não quero que fique comigo pela metade. Ou você gosta completamente de mim ou... 
<p>- Eu gosto muito de você. Quinn, você é maravilhosa.
<p>- Mas não pode dizer que não sente nada por ela. Não posso ficar com alguém assim.
<p>- Eu sei. Você não merece alguém com dúvidas. Você merece alguém completo, mas eu não posso ser esse alguém agora.
<p>- Acho que focamos tanto em conseguirmos ficar juntos que não pensamos no que aconteceria quando finalmente ficássemos. – Quinn deu um sorriso sem graça.
<p>- Você é a garota mais incrível que eu já conheci. 
<p>- Não precisa dizer essas coisas só para tentar me fazer ficar bem.
<p>- Não, eu não estou inventando. E mesmo que me odeie...
<p>- Eu não odeio você. – Quinn riu de verdade. – Acho até que te amo, você é meu melhor amigo, na verdade. 
<p>- Você também é minha melhor amiga. E me salvou mais vezes do que eu posso contar.
<p>- Vem cá, idiota.
<p>Quinn abraçou Sebastian bem forte.
<p>- Se você realmente perceber que está apaixonado pela Melissa, vai atrás dela. – Quinn falou no ouvido de Sebastian. – Não afaste ela como me afastou tantas e tantas vezes. 
<p>- Prometo não fazer isso.</p>
<center><h4>--*--</h4></center>
<p>- O que a gente está fazendo aqui exatamente? – Emily segurava o braço de Will bem forte um pouco assustada.
<p>Aquele bar era estranho demais. Alguns motoqueiros gigantes bebiam cerveja no balcão. Era tudo bem escuro, até as cores das paredes. As luzes eram fracas e as pessoas aproveitavam esse detalhe para fazer coisas ilícitas nos lugares mais escuros.
<p>- E se o Kevin estiver aqui? – Emily não conseguia disfarçar seu nervosismo.
<p>- Eu ouvi a voz dele toda trêmula. Ele só marcou aqui para ganhar tempo. É claro que não vai aparecer. Agora me ajuda a achar o cara. – Will estava bravo. Estava arrependido de ter falado para Emily seu plano de ir abordar Leo. Mesmo nervosa, ela não o deixou ir sozinho. Ele não sabia o que poderia acontecer nem o tipo de índole que aquelas pessoas que estavam no bar tinham. Os dois poderiam estar em um grande perigo. 
<p>- Eu só vi uma foto e...
<p>- Achei. – Will andou mais rápido em direção a uma mesa em um canto escuro do bar. Leo estava sentado com algumas notas de dinheiro na mão. Parecia estar contando elas sem se preocupar em ser visto com todo aquele dinheiro. – Quanto você quer? – Will se sentou de frente para Leo e ficou sério. Emily ficou ao lado dele, mas em pé.
<p>- Veio salvar o irmãozinho? – Leo deu uma risada enquanto guardava seu bolo de dinheiro no bolso da blusa de moletom.
<p>- Quanto? – Will repetiu.
<p>- O seu querido Kevin me deve vinte mil dólares.
<p>- Vinte mil? – Emily arregalou os olhos e quase gritou. – Will, você não tem esse dinheiro.
<p>- Então não se envolvam. Se não é para ajudar, não atrapalhe. 
<p>- Ele só tem dezesseis anos. – Will o fuzilou com os olhos.
<p>- Não me interessa. Ele parecia ter bastante certeza quando me procurou para pedir dinheiro.
<p>- Na verdade, isso é algo bem imaturo, você devia ter percebido. – Emily tentou esconder seu nervoso com a cara fechada.  
<p>- Eu só faço o meu trabalho. Eu empresto, mas quero de volta, simples assim. – Leo piscou para Emily. – Até que fui legal dando um prazo maior do que deveria.
<p>- Que legal da sua parte. Com certeza vai para o céu por isso. – Will foi irônico.
<p>- Will, acho melhor a gente ir embora. – Emily puxou o braço dele.
<p>- Eu não tenho medo de um agiota. – Will ignorou a namorada.
<p>- Eu não sou um simples agiota.
<p>- É, eu sei. Aposto que além de dinheiro, seus bolsos devem estar cheios de drogas. Eu conheço o seu tipo. 
<p>- Olha só, Will, eu não sou o vilão aqui. Ele veio até mim.
<p>- Ele é menor de idade. Você devia ter avisado os pais dele.
<p>- Claro, até porque nesse ramo, a gente segue as regras. 
<p>- Me dá mais um prazo que eu mesmo te pago. – Will não sabia mais o que dizer.
<p>- Eu gosto de você, Will, mas isso não é problema seu. 
<p>- Ele é meu irmão, isso é problema meu. 
<p>- Ele te mandou no lugar dele, não é? Aquele idiota. Infelizmente o prazo acaba hoje.
<p>- É impossível eu conseguir esse dinheiro hoje. – Will quase bateu na mesa, mas não era tão valente assim. 
<p>- Você ainda tem o final dessa noite. Tenta vender as drogas do seu irmão por aí, talvez consiga. 
<p>- Drogas? Do que você está falando? – Leo estava se referindo a Sebastian?
<p>- Eu dei algumas coisas para o Kevin vender para tentar pagar a dívida, mas o retorno também foi zero, certeza que ele deve ter usado tudinho com aquela namorada louca dele. Os vinte mil cobrem tudo.
<p>Will ficou mais chocado depois de saber que tinha drogas envolvidas do que saber que seu irmão devia vinte mil dólares.
<p>- O que vai fazer se ele não pagar hoje?
<p>- Vou na casa dele com alguns amigos. – Leo olhou para dois homens no balcão que pareciam mais dois guarda-roupas do que humanos. – Talvez alguém saia com um joelho quebrado, talvez dois. 
<p>- Está blefando. – Will o encarou.
<p>- Seu irmão já presenciou meu trabalho. Pergunta para ele se eu estou blefando.</p> 
<center><h4>--*--</h4></center>
<p>- EU VOU MATAR VOCÊ!
<p>Will entrou no quarto de Kevin como uma bomba. Seus pais estavam jantando fora e seus irmãos não estavam em casa. Foi bem melhor fazer barulho sem se importar se alguém estaria ouvindo além dos interessados. Emily vinha logo atrás dele um pouco preocupada.
<p>Kevin estava sem camisa deitado na cama com Giovanna. Os dois deram um pulo e se sentaram quando Will entrou gritando. 
<p>- O que é isso? Sai do meu quarto agora! – Kevin colocou a camisa bem rápido e se levantou para enfrentar seu irmão.
<p>- Olha só, seu idiota. – Will avançou e apontou o dedo na cara dele. – A minha vontade agora é de te encher de porrada e a boa noticia é que não tem ninguém aqui forte o bastante para me tirar de cima de você, então escolha muito bem as suas próximas palavras. 
<p>- Will, se acalma. – Emily falou bem firme. 
<p>- O que está acontecendo? – Giovanna parecia estar em choque. 
<p>- O que está acontecendo é que o seu namorado, mais conhecido como o idiota do meu irmão, está devendo vinte mil dólares para um TRAFICANTE! QUAL É O SEU PROBLEMA? Ser um idiota não é o suficiente para você? – Will quase cuspiu de raiva.
<p>- Eu não... – Kevin ficou mais manso. – As coisas saíram do controle. 
<p>- Onde estão?
<p>- Onde estão o quê?
<p>- Não se faça de sonso. – Wil estava vermelho. – Onde estão as drogas?
<p>- Não tem droga nenhuma aqui. – Kevin estava um pouco assustado.
<p>- Falar isso não melhora a sua fita, porque eu sei que ele te deu e se não estão aqui, quer dizer que você usou e se você usou, aí sim que eu vou acabar com a tua cara.
<p>- Eu não us...
<p>- ENTÃO AONDE ESTÃO?
<p>- Will, se acalma! – Emily gritou. 
<p>- O que você fez com o dinheiro? – Will falou baixo, porém não estava calmo. 
<p>- Eu comprei algumas coisas.
<p>- Seja mais especifico. 
<p>- Eu gastei em algumas festas, roupas... 
<p>- E o que fez com as drogas? – Kevin não respondeu. – E O QUE VOCÊ FEZ COM AS DROGAS? 
<p>- A gente usou algumas. – Giovanna falou bem acanhada. 
<p>- Mas eu joguei fora a maioria. 
<p>- Mas que ótimo. – Will começou a andar pelo quarto com as mãos na cabeça.
<p>- Eu tentei vender e... – Kevin percebeu tarde demais que não deveria ter dito aquilo. 
<p>- Ele disse que vai vir aqui quebrar seu joelho e talvez eu ajude ele. QUAL É O SEU PROBLEMA?
<p>- W<p>ill, por favor. Eu não sei o que fazer. – Kevin estava muito assustado. – Se eu não pagar, ele vai me pegar e... Eu sei o que ele faz com as pessoas que devem para ele. Eu estou com medo. 
<p>- Deu nosso endereço para ele?
<p>- Não, eu nem sei como ele descobriu. 
<p>- Eu... – Will olhou bem nos olhos de Kevin e conseguiu perceber o seu medo. – Eu vou tentar resolver isso.
<p>- Como? – Emily ficou surpresa.
<p>- Eu não sei. Não saiam daqui, vou ver se arranjo alguma coisa. 
<p>Will saiu do quarto de Kevin e desceu as escadas correndo e rumou para a porta.
<p>- Will, espera.
<p>Emily correu atrás dele.
<p>- Ems, fica aqui. Eu preciso...
<p>- Will, o que você vai fazer?
<p>- Sei lá, vou atrás do Leo e implorar por mais uma chance. Barganhar. Sei lá. Você viu como o Kevin está. Não posso deixá-lo passar por isso. 
<p>- Eu vou com você.
<p>- Não.
<p>- Quando o seu “não” me impediu de alguma coisa?</p>
<center><h4>--*--</h4></center>
<p>Will e Emily voltaram para aquele bar estranho, mas não encontraram Leo por lá. Foram em mais cinco bares com reputações duvidosas, mas não tiveram sucesso. Will pensou em ir até a polícia, mas pegar dinheiro emprestado de agiota não era bem visto pela polícia e ainda tinha drogas envolvidas. Kevin não estaria a salvo se fosse pego. 
<p>Já estava tarde e os dois não tinham mais nenhuma ideia do que fazer ou aonde ir. Eles resolveram voltar para casa, talvez conversar com mais alguém, pensar em mais alguma ideia, rezar... Quando chegaram em casa, lá perto da meia noite, Will se surpreendeu em ver todos acordados na sala de estar como se estivessem esperando por ele. Seu pai estava perto da porta bem furioso, os dois faziam a mesma cara e ficavam da mesma cor quando o sangue esquentava. Sua mãe estava sentada no sofá um pouco nervosa ao lado de Chris e Sebastian. Kevin estava perto da escada, chorando. 
<p>- O que aconteceu? – Will começou a imaginar o pior.
<p>- Filho, o que você fez? – Robert cerrou os dentes. Parecia estar fazendo uma força enorme para não gritar.
<p>- Como assim, o que eu fiz? – Will começou a olhar para todos tentando encontrar alguma pista. 
<p>- Recebemos uma linda visita hoje. – Robert se aproximou mais de Will e o encarou. – Inesperada, pode-se dizer assim. Ninguém aqui estava entendendo nada, mas seu irmão nos explicou.
<p>- Eu sinto muito, Will. – Kevin mal conseguiu falar enquanto chorava.
<p>- Explicou, é? – Will olhou para Emily que estava muito mais preocupada que ele. 
<p>- Um agiota. – Robert tentou manter ao máximo a sua calma. – Um agiota bateu na minha porta e ameaçou um dos meus filhos e depois a minha esposa. UM AGIOTA! – Will deu um passo para trás ao seu assustar com o grito. – EU NÃO ACREDITO NISSO!
<p>- Pai, eu...
<p>- O QUE VOCÊ TINHA NA CABEÇA?
<p>Will arregalou os olhos surpreso. 
<p>- Filho, quanto você deve? – Karen não gritou. Na verdade, ela parecia bem abalada. Segurava as mãos de Chris e Sebastian bastante trêmula.
<p>- Eu não... – Will olhou para Kevin. – Vinte mil. Eu devo vinte mil.
<p>- Will. – Emily abriu a boca incrédula, mas Will segurou a sua mão como um sinal para ela ficar calada.
<p>- Vinte mil. – Robert parou de gritar. – O que você fez com esse dinheiro?
<p>- Eu... – Will não sabia o que responder.
<p>- Olha, não me importa. AONDE VAMOS ACHAR VINTE MIL PARA PAGAR ESSE CARA?! Ele tem nosso endereço. Eu tive que ficar falando e falando até convencer ele a dar mais um tempo de prazo. – Robert nunca esteve tão bravo, Will nunca o viu daquele jeito. – Você tem ideia do perigo que você colocou a sua família? Ele veio aqui com dois caras enormes. Poderiam muito bem ter feito mal para os seus irmãos e para sua mãe.
<p>- Eu sei, eu...
<p>- E ISSO SERIA CULPA SUA!
<p>- Me desculpa. – Will se sentiu travado. Emily estava do seu lado tão travada quanto ele. 
<p>- Vou tentar fazer um empréstimo amanhã no banco para pagar a sua dívida.
<p>- Muito obrigado.
<p>- Não precisa. Eu sou seu pai, é o que eu faço. – Robert olhava para Will com um grande olhar de desapontamento. 
<p>- Eu prometo que não vai acontecer de novo.
<p>- Não vai mesmo. Eu vou pagar essa sua dívida pelo bem da nossa família, mas o empréstimo no banco, você que vai pagar.
<p>- Pai, de onde eu vou tirar vinte mil?
<p>- Isso é problema seu. Venda suas coisas, arrume um emprego. Não vai para faculdade mesmo, talvez se identifique sendo um garçom. – Ele não queria dizer aquelas coisas, mas estava com tanta raiva e desapontado que queria fazer de tudo para ferir seu filho. 
<p>- Tá. 
<p>- Espero que saiba o quão decepcionado eu estou com você. Agiota, drogas... depois de tudo o que a gente já passou, você se mete nessas coisas? Você é o irmão mais velho, droga. Devia dar o exemplo. É isso que você quer ensinar? É esse o namorado que você quer ser para a Emily? Ela também estava em perigo.
<p>- Pai, eu acho que já chega. – Sebastian falou. 
<p>- Não, Seb. Papai tem razão. A culpa é minha e eu vou consertar isso. 
<p>Sebastian olhou disfarçadamente para Chris e depois os dois olharam para Kevin. Eles sabiam que Will não era o verdadeiro culpado, mas não tiveram coragem de dizer, principalmente depois do irmão ter aceitado a culpa.</p>
<center><h4>--*--</h4></center>
<p>- Will! Will!
<p>Kevin foi até o quintal falar com o irmão. Will tinha saído da casa para tomar um ar. A última pessoa que ele queria ver era Kevin. 
<p>- O que você quer? – Will se virou para ele com os punhos já fechados.
<p>- Eu sinto muito. Eu precisava do dinheiro, e eu não... ele apareceu aqui e eu entrei em pânico e... eu não sabia o que dizer...
<p>- Então preferiu colocar a culpa em mim, não é? E ele é um agiota, falaria e concordaria com qualquer coisa só para ter o dinheiro de volta. Plano perfeito. 
<p>- Me desculpa, não foi por querer.
<p>- Vai para o inferno, Kevin. Eu ainda não acredito que eu me ferrei para te ajudar. Sai da minha frente antes que eu acabe com a sua cara. 
<p>- Eu não sabia o que fazer... – Ele insistiu.
<p>- Mas você pareceu saber o que fazia enquanto pedia dinheiro e aceitava drogas, não é, Kev? Você sabia que era errado. 
<p>- Eu precisava do dinheiro.
<p>- Para festas e roupas? – Will achava aquela ideia ridícula.
<p>- Eu precisava me destacar. Eu precisava de algo para...
<p>- Para quê? – Will sabia o que ia ouvir, mas mesmo assim não conseguia acreditar.
<p>- Se eu não a levasse para restaurantes chiques e comprasse coisas para ela, ela ia me deixar, eu tenho certeza disso. Olha só para mim. 
<p>- Você é patético. Cadê ela para te apoiar agora? Está usando as suas drogas enquanto está aqui? Porque eu duvido que você as jogou fora.
<p>- Will. – Kevin o encarou. – Você não entende, eu sei, mas mesmo assim... Obrigado por me ajudar.
<p>- “Obrigado”? Eu não acredito nisso. Você não é o idiota, EU SOU O IDIOTA! De nada, Kevin. De nada.
<p>Will simplesmente colocou toda a sua raiva e frustração no punho e socou a cara do seu irmão com um de direita. Ele não ficou mais calmo vendo Kevin cair no chão com o nariz sangrando, mas ficou satisfeito, pelo menos por um segundo.
<p>- Se lembra quando você me disse todas aquelas coisas ridículas e disse que não queria mais ser o meu irmão? Agora sou eu que prefiro não ter mais um irmão como você e se tentar se dar bem de novo em cima de mim, vai ficar sem os dentes.</p>
<center><h4>--*--</h4></center>
<p>Emily abriu a janela do quarto para Will entrar. Ela já estava enrascada por ter chegado em casa muito tarde, mas não ia deixar o namorado sozinho naquele momento. 
<p>- Não acredito no que aconteceu. – Emily ainda estava incrédula e muito pilhada para dormir. – Eu devia ter dito algo.
<p>- Não. Não devia. 
<p>- Will. – Emily olhou para a mão machucada dele, e mesmo sendo contra a briga, ela desejou ter batido em Kevin também. 
<p>- Esquece isso.
<p>- O que vai fazer agora?
<p>- Você ouviu meu pai. Preciso arranjar dinheiro. Preciso de um emprego. 
<p>- Você precisa contar a verdade e deixar o Kevin arcar com as consequências. 
<p>- Arrumar um emprego não é tão ruim. – Will riu.
<p>- Sabe que não é isso que eu quis dizer. 
<p>- Acho que já tivemos muitas emoções por uma noite, não é? – Will mudou de assunto. – Vamos só dormir.
<p>- Vai ficar bem? – Will sentiu a angustia na voz da namorada. 
<p>- Que opção eu tenho? 
<p>Os dois se deitaram na cama. Will ainda estava com o coração acelerado e aquelas cenas ainda estava passando pela sua cabeça. Os olhares, os gritos, o soco. Seu próprio grito. Mesmo com Emily segurando sua mão, era impossível ficar calmo naquele momento.</p>
</body>
</html>";
            }

            if (numero == 33)
            {
                lblTitulo.Text = "Capítulo 33 - Podemos Começar De Novo Antes Que Acabe?";
                htmlPage.Html = @"<html>
<body>
<p><i>“Eu nunca te fiz bem, eu sei disso
<br>Muitas noites sem dormir, minha culpa
<br>Eu digo isso toda hora, eu sei disso
<br>Eu quero tentar de novo
<br>Podemos começar de novo antes que acabe?”
<br><b>Start Over - Imagine Dragons</b></i></p>
<br>
<p>Amanda chegou em casa naquela manhã com um pressentimento ruim. Ela havia passado a noite na casa de Jason e estranhou quando encontrou a família toda reunida na mesa tomando café em silêncio. Ela não se surpreendeu em não ver Will na mesa, ele nunca estava mesmo, mas estranhou todos quietos. Geralmente gritavam, brigavam ou até riam, mas em silêncio, nunca.
<p>- O que aconteceu aqui? – Ela se sentou ao lado de Sebastian e pegou um pão da cesta que sua mãe colocou na mesa.
<p>- Nada. – Sebastian falou baixinho.
<p>- Eu duvido. Alguém pode me dizer o que está acontecendo? Quem morreu? – Amanda ficou brava.
<p>- Não aconteceu nada. – Robert falou emburrado.
<p>- Na verdade... – Kevin começou a falar, mas se calou. Amanda então percebeu que o irmão estava com o nariz roxo. Ela olhou instantaneamente para Sebastian e ele concordou. Will havia socado Kevin novamente.
<p>- Seu irmão fez uma dívida com um agiota. – Robert socou de leve a mesa. Karen levou um leve susto, ela ainda não havia superado o trauma da noite passada.
<p>- Eu duvido muito. – Amanda quase riu. Por um segundo, achou que aquilo era uma brincadeira.
<p>- Não vamos falar sobre isso na hora do café. – Karen olhou para o marido com reprovação. 
<p>- O que você sabe sobre isso? – Amanda perguntou para Sebastian.
<p>- Eu não sei de nada. – Sebastian também estava irritado.
<p>- Will conta tudo para você. – Amanda insistiu.
<p>- Exatamente! – Robert interrompeu a conversa. – Você já devia saber disso há muito tempo. 
<p>- Will não me contou nada porque todos nós aqui sabemos que ele nunca faria isso. – Sebastian se levantou e encarou o pai. – Me desculpa falar, mas você deveria conhecer melhor os seus filhos. 
<p>Sebastian saiu da mesa e subiu para o quarto. Ele sabia que Will o mataria se contasse a verdade, mas ouvir seus pais falando do seu irmão daquele jeito era no mínimo revoltante. Kevin ainda havia saído como coitadinho por voltar para casa com o nariz sangrando. A situação era totalmente ridícula. 
<p>- Tem uma coisa bem errada aqui. – Amanda olhou para a sua família. Jason seria a outra pessoa que Will contaria esse tipo de coisa e ele nunca ficaria em paz sabendo do problema do amigo, então ele não sabia. Logo, Will não era culpado.</p>
<center><h4>--*--</h4></center>
<p>Quinn acordou bem determinada naquela manhã. Todo aquele término com Sebastian a deixou bem pensativa e chegou à conclusão de que tinha feito algo errado e que agora tinha que consertar.
<p>- O que você quer? – Melissa atendeu a porta meio mal-humorada. 
<p>- Eu sei que você não quer falar comigo e tal, mas eu queria me desculpar. O que eu fiz foi ridículo.
<p>- Tudo bem. 
<p>- É sério. Eu sinto muito mesmo. – Quinn insistiu.
<p>- Está tudo bem, Quinn. Não se preocupe.
<p>- Eu estava meio louca, talvez um pouco mais do que “meio”. – Quinn continuou se explicando. 
<p>- Olha, eu entendo. Você achou que seu namoro estava em perigo, só quis salvá-lo. 
<p>- Sebastian e eu terminamos. – Quinn abriu o jogo. – Então se você quiser tentar...
<p>- Primeiro, eu não preciso da sua permissão, não somos amigas, e segundo, não. Eu não vou tentar nada. 
<p>- Tem razão. Você não deve nada a mim. 
<p>- Não devo.
<p>- Mas eu só quero te dizer que eu não vou ficar atrás do Sebastian. A gente já conversou e nos entendemos. 
<p>- Quinn, eu agradeço mesmo você ter vindo até aqui. 
<p>- Tá. – Quinn se virou para ir embora. 
<p>Melissa segurou a maçaneta e estava prestes a fechar a porta quando Quinn voltou ainda mais determinada.
<p>- Olha, o Sebastian é um cara legal.
<p>- Por favor, eu não quero ter essa conversa.
<p>- Mas vai ter. Olha só, ele é muito mais do que legal. Ele é um em um milhão. Ele não se abre com todo mundo, mas se abriu com você.
<p>- Porque somos amigos.
<p>- Você sabe que é mais do que isso. Eu realmente queria chegar aqui e gritar dizendo que mesmo que não tenha, você roubou meu namorado, mas não posso. 
<p>- O que você quer de mim?
<p>- Gosta dele?
<p>Melissa hesitou.
<p>- Gosto. – Ela finalmente se deu por vencida. Foi estranho dizer aquilo em voz alta, mesmo assim. 
<p>- Ótimo. – Quinn sorriu.
<p>- Por que está sendo legal comigo?
<p>- Eu sou doida assim mesmo. Eu cansei de ficar aqui fora, eu posso entrar?
<p>- Ah... claro.
<p>Melissa abriu a porta por completo para dar espaço para Quinn entrar.</p>
<center><h4>--*--</h4></center>
<p>Jason havia mandado uma mensagem de texto para Will perguntando onde ele estava, e dez minutos depois estava correndo em sua direção, ofegante. Will achou difícil acreditar que ele estava por perto, levando em conta que Beverly Hills era um pouco longe de onde moravam.
<p>- O que foi que você fez? Estava maluco? – Jason quase socou ele de tanta raiva que estava sentindo. 
<p>- É, eu sei. Fiz besteira. – Will já devia ter adivinhado. Amanda com certeza já tinha ficado a par da situação e atualizou o namorado em seguida.
<p>- Ah, corta essa. – Jason gritou. – Quem você está protegendo? O Kevin?
<p>- O quê?
<p>- Pelo histórico, eu poderia chutar “Sebastian”, mas nós dois sabemos que nem drogado ele deixaria você levar a culpa por algo que ele fez. O Chris é certinho demais para se meter com um agiota e a Amanda nem se fala. É o Kevin, não é?
<p>- Você está viajando. – Will ainda pretendia negar até o fim. 
<p>- Me diz o que está acontecendo. Me explica essa história direito. 
<p>- Ele foi até a nossa casa, o agiota. Kevin está devendo vinte mil para ele.
<p>- Vinte mil? – Jason arregalou os olhos. 
<p>- Queria bancar o bonzão para a namorada. Que legal, não é?
<p>- Amanda disse que seu pai está uma fera. 
<p>- É, está. Ele quase me bateu ontem. Gritou tanto que até os vizinhos ouviram. Ele vai pagar, mas quer que eu o pague de volta.
<p>- E... – Jason mal conseguia falar de tão chocado que estava. – E de onde você vai tirar esse dinheiro?
<p>- Trabalhando. – Will levantou o jornal que estava segurando. – Passei a manhã toda procurando emprego. 
<p>- Fala sério, Will. Tem ideia da confusão que você arrumou?
<p>- É claro que eu tenho, mas não consegui evitar. 
<p>- Posso te ajudar em alguma coisa? 
<p>- Claro, você tem vinte mil para me emprestar ou um emprego para me dar?
<p>- Você vai trabalhar em quê? Não tem experiência e muito menos educação.
<p>- Eu não sou um analfabeto.
<p>- Você entendeu. Você precisa de cursos para arranjar um emprego bom, senão você só vai ser mais um...
<p>- Proletariado. – Will falou desanimado. – Eu sei disso e mesmo arranjando um emprego, eu não vou ganhar bem e vou passar o resto da minha vida pagando meu pai.
<p>- A outra opção é contar a verdade para ele e deixar o Kevin se virar.
<p>- Isso está fora de cogitação. Ele é só uma criança. 
<p>- Ele foi maduro o bastante para ir atrás de um agiota e fazer uma divida enorme. 
<p>- Jason...
<p>- Se ele se safar, vai continuar fazendo isso, porque sabe que tem um idiota que vai levar a culpa por ele sempre.
<p>- Ah, qual é? É claro que não. Ele aprendeu a lição. Estava bem mal ontem.
<p>- Nossa, como você pode ser tão otário? Pessoas não mudam. Se fazem besteira uma vez, vão continuar fazendo. 
<p>- Eu sei porque está dizendo isso. – Will se referia ao pai de Jason, mas preferiu deixar implícito. 
<p>- O assunto aqui é você, não eu. 
<p>- Eu não posso contar, tá bom? Ele ainda é meu irmão. 
<p>- Que seja. – Jason bufou. – Vamos te achar um emprego então.
<p>- Você tem aula agora. 
<p>- Um dia não vai me matar. Aparentemente não mata você. 
<p>- Mas machuca.</p>
<center><h4>--*--</h4></center>
<p>- Kevin? Ele está defendendo o Kevin? – Amanda não ficou surpresa quando Emily terminou de contar tudo o que havia acontecido na noite passada, mas mesmo assim arregalou os olhos e falou moderadamente alto. As duas estavam sentadas uma do lado da outra em suas carteiras esperando a aula começar.
<p>- Exatamente. Você só tem irmãos burros? – Emily ainda estava brava. 
<p>- É, parece que eu sou a única inteligente da família. – Amanda revirou os olhos enquanto se gabava. – Mas agora tudo faz sentido. Por isso o Kevin está com o nariz machucado. Deve ter levado um socão do Will.
<p>- É, levou. Amanda, você tem que fazer alguma coisa. Eu passei a noite toda tentando convencer o Will que ele está ficando louco e o quanto ele é idiota, mas não adiantou.
<p>- Se você não mudou a opinião dele, que chance eu tenho sendo uma mera mortal?
<p>- Ele saiu bem cedo de casa. Disse que ia procurar emprego. Nem apareceu hoje na escola. Ele está se ferrando enquanto o Kevin anda de mãos dadas com a Giovanna pelos corredores como se estivessem no céu.
<p>- Que eles aproveitem. A chama do inferno chega para todo mundo. – Amanda riu.
<p>- Isso não tem graça. 
<p>- Emily, essa não é a primeira vez nem vai ser a última que o Will faz uma coisa dessas. – Amanda já estava acostumada com aquele comportamento do irmão.
<p>- Como assim?
<p>- Uns quatro anos atrás, Will entrou um uma briga no meio do pátio por causa do Chris. Ele foi suspenso, ficou meses de castigo e levando broncas, mas fez todo mundo ficar calado. Se ele pudesse, com certeza teria a overdose no lugar do Sebastian só para ele ficar se drogando sem ninguém saber.
<p>- Isso não é saudável e não é bom para ninguém. Se o Kevin não for castigado, ele nunca vai aprender a lição. 
<p>- Eu sei disso, tá bom? Não estou defendendo o Will. Na verdade, eu acho uma burrice, sempre achei, mas não adianta. 
<p>- Vou terminar de quebrar o nariz do Kevin quando eu o ver.</p>
<center><h4>--*--</h4></center>
<p>Will passou na garagem primeiro para garantir que o carro de seu pai não estava mais lá para poder entrar em casa. Não era muito maduro da parte dele, ele sabia. 
<p>A sala de estar estava vazia. Pela hora que era, todos já deveriam estar na rua, pensou ele. 
<p>- Até que enfim. 
<p>- Mãe, o que faz aqui? – Will ficou imóvel em frente a escada quando viu sua mãe vindo da cozinha.
<p>- Falei para o seu pai que eu não estava bem para ir trabalhar. Além do mais, essa aqui ainda é minha casa. – Ela sorriu. – Achei que fosse a sua também. 
<p>- É, por enquanto. Se o papai não me expulsar... – Will sorriu também. 
<p>- Não deveria estar na escola?
<p>- Ah... – Ele não queria destruir aquele clima leve com mais uma bronca. – Eu fui fazer umas coisas, estou indo para lá agora. Só vim buscar minha mochila.
<p>- Você não deveria ter dormido aqui? 
<p>- Mãe...
<p>- Bom, espero que a Emily tenha paciência com você. 
<p>- Mãe, eu sinto muito. – Will se desculpou. Mal tinham se falado na noite passada, ela estava muito abalada. E aquelas palavras de seu pai dizendo que aquele louco poderia ter feito algo de ruim a ela ficaram na sua cabeça até aquele momento.
<p>- Sente muito, é?
<p>- É. Mesmo eu achando que não adianta de nada.
<p>- Filho, eu sei que não foi você.
<p>- O quê? Como? – Will franziu a testa.
<p>- Eu sou a sua mãe, eu sei.
<p>- Essa não é uma resposta muito elaborada. 
<p>- Quem está protegendo?
<p>- Bom, se é para ser lógico, é seu filho, você também deveria saber. 
<p>- É o Kevin, não é? – Karen então caiu no choro. – Eu não acredito.
<p>- Não, mãe. Por favor, não chora. – Will foi até a sua mãe e a abraçou para tentar consolá-la. 
<p>- Não devíamos ter ficado tanto tempo fora. Eu percebi que ele estava tão... diferente.
<p>- Deve ter sido o soco que eu dei nele uns meses atrás.
<p>- O quê? – Ela arregalou os olhos.
<p>- Mãe, você precisa se acalmar. Precisa conversar com ele. Você e o pai...
<p>- Você precisa contar a verdade para o seu pai.
<p>- Mãe, eu não posso. 
<p>- Seu pai vai achar que estou tentando te proteger se eu contar. Vai achar que eu estou louca.  
<p>- É, porque ele sempre pensa o pior de mim.
<p>- Não é verdade. – Karen colocou a mão no rosto do filho. – Filho, você é um bom irmão e uma boa pessoa. Pode até achar que está fazendo isso para ajudar o Kevin, mas não está. 
<p>- Eu sei, mas só de pensar nele... Eu não consigo evitar.
<p>- Will...
<p>- Sabe, acho que não sabe, mas quando você estava indo para o hospital em trabalho de parto do Matt, o papai estava apavorado. Na verdade, ele sempre fica apavorado nos partos. – Will riu ao lembrar disso. – Ele não conseguia encontrar ninguém para ficar com a gente de última hora e não podia levar todos nós. 
<p>- Onde essa história vai chegar?
<p>- Ele olhou para mim e disse “Seus irmãos estão nas suas mãos agora. Cuide bem deles até eu voltar com mais um.” Eu tinha dez anos e ele confiou em mim para cuidar de três crianças, ele não tinha escolha mesmo se não confiasse, mas eu prometi que cuidaria e cuidei. 
<p>- É, mas agora eles estão crescidos. Está na hora de você deixar eles cuidarem de si mesmos. 
<p>- Sabe como isso é hipócrita? Você é nossa mãe e trata a gente como bebê. – Will riu.
<p>- Mas eu posso. Vem aqui. – Os dois se abraçaram. – Eu ainda tenho orgulho de você.
<p>- Obrigado.</p>
<center><h4>--*--</h4></center>
<p>- Emily!
<p>Kevin foi até a garota gritando enquanto ela tirava seus livros do armário para a próxima aula que teria em alguns minutos. 
<p>- O que você quer? – Emily não fez questão de ser gentil nem de olhar para ele.
<p>- Você viu o Will hoje? Queria falar com ele, mas parece que ele não veio à escola.
<p>- Will deve estar resolvendo os seus problemas. 
<p>- Se o encontrar, pode dizer que eu sinto muito? Eu estou tentando ligar, mas ele não me responde também.
<p>- Eu não sou a sua pombo-correio. Além do mais, relaxa, provavelmente você não vai levar outro soco se cruzar com ele. Provavelmente. 
<p>- Ele vai me evitar o máximo que conseguir.
<p>- E por que será, Kevin? – Emily então o encarou, ela estava a um passo de ficar furiosa. – Você já não disse que ele não era mais seu irmão e que não se importava com ele ou algo assim? Por que está atrás dele agora? Ele já te tirou da confusão. Não precisa fingir que se importa.
<p>- Mas eu me importo.
<p>- Ótimo jeito de demonstrar isso. 
<p>- Eu não pedi para ele levar a culpa, eu só...
<p>- Disse que a culpa era dele para o seu pai e para todo mundo. 
<p>- Ele só precisava desmentir.
<p>- É sério? – Emily estava inconformada. – Eu não sou idiota. Você sabia muito bem que ele nunca ia fazer isso. Porque não importa o quão imbecil você for, o Will sempre vai te defender. Pena que esse relacionamento é unilateral. 
<p>Kevin abaixou a cabeça envergonhado.
<p>- Agora ele está com problemas, cadê o irmão dele para ajudá-lo?
<p>- O que eu poderia fazer?
<p>- Primeiro contar a verdade. 
<p>- Eu não posso fazer isso. Todo mundo acha que eu sou o que faz a coisa certa. Eu estaria desapontando todo mundo. – Kevin tentava convencer Emily com um discurso que nem ele mesmo acreditava.
<p>- Kevin, você namora a Giovanna. Ninguém mais acha que você faz só coisas certas.
<p>- Não fale assim dela.
<p>- Olha, eu não me importo com ela, muito menos com você. Eu me importo com o Will e em como ele está se virando do avesso para limpar a sua bagunça. O mínimo que você devia fazer era consertar isso.
<p>- Já disse que não posso. 
<p>- Você é um bebê chorão, sabia disso? – Emily tentou falar o mais baixo possível para ninguém que estivesse passando pelo corredor ouvir. – Você precisa crescer e parar de achar que vão te defender para o resto da vida. Will acha que você é uma criança, mas na verdade, você é só um inconsequente rebelde sem causa. 
<p>- Não sabe o que está dizendo.
<p>- Ah, meu Deus. Tadinho do Kevin. Ele é novo demais para trabalhar e pagar as suas próprias dividas, mas é velho o suficiente para gastar vinte mil dólares e ainda se drogar.
<p>- Eu não me...
<p>- Ah, qual é? – Emily não escondeu sua falta de confiança. – Will acha na cabeça dele que você é um garoto inocente, manipulável. Não duvido nada ele achar que a Giovanna faz a sua cabeça. Mas não é verdade, não é?
<p>Emily esperou Kevin responder, mas ele continuou em silêncio.
<p>- Giovanna acha que te obrigou a pichar o meu armário, mas você queria. Você queria o dinheiro para gastar com ela, mas também para se sentir poderoso. Mas as drogas, eu não... 
<p>- Quantas vezes a gente passou noites no hospital porque o Sebastian teve uma overdose? Eu nunca vi nenhum de vocês julgando ele por isso. 
<p>- Eu só não te dou outro soco porque você já recebeu o suficiente ontem. – Emily reparou no nariz roxo de Kevin. – E eu espero mesmo que você caia na real antes que vá para um caminho sem volta. Mas pelo Will, não por você. 
<p>Emily fechou a porta do armário e foi embora.</p>
<center><h4>--*--</h4></center>
<p>Will estava em uma missão que, naquela tarde, já acha que era impossível. Seus pais sempre falavam que seus filhos iriam para a faculdade e só começariam a trabalhar depois de formados, ele não fazia ideia que precisaria procurar emprego ainda no ensino médio mesmo demorando mais do que seus irmãos para se formar.
<p>Procurar emprego era a coisa mais difícil que ele já tinha feito na vida, principalmente quando se não fazia ideia do que procurar. 
<p>Havia uma vaga para auxiliar de ajudante em uma clínica veterinária na cidade, mas cuidar de animais não era bem a praia de Will. Ele sempre quis ter um cachorro quando criança, mas nunca fez questão de aprender a cuidar de um. 
<p>A vaga de auxiliar de florista estava quase ganha, mas aí a dona percebeu que ele não fazia ideia do motivo de estar lá nem o que era uma margarida.
<p>O emprego de garçom era bom, até o salário era aceitável, mas entraria em conflito com o horário da escola. Ele resolveria um problema criando um outro ainda maior. Isso não ia dar muito certo. 
<p>O sol já havia baixado quando desistiu, pelo menos naquele dia, e entrou no primeiro bar que encontrou aberto. Ele havia andado a cidade toda em um sol infernal o dia inteiro, só recebeu “não” na cara, estava morrendo de fome e queria muito matar alguém. Seu dia tinha sido ótimo. 
<p>O Bar Woody-Club era muito bem frequentado. Estava localizado em um lugar muito bom da cidade e o espaço era enorme. Talvez porque estava vulnerável, mas Will se impressionou muito quando entrou no estabelecimento. As luzes eram de neon, havia várias mesas e uma pista de dança. Ele conseguia ver um palco enorme no fundo ainda escuro. 
<p>- Já veio beber tão cedo? – O barman veio por de trás das estantes de garrafas de bebidas e foi para atrás do balcão. 
<p>- Ah, era tudo o que eu queria fazer agora. – Will riu enquanto se sentava em um banco perto do balcão. – Mas eu não sou muito de beber.
<p>- Parece cansado. O que houve? – O barman tirou um copo de baixo do balcão e começou a servi-lo água tônica. – Sou Fred, alias. 
<p>- Will. Bom, eu fui rejeitado umas dez vezes hoje. Acho que mais.
<p>- É, as mulheres não estão nada fáceis hoje em dia. Mesmo para você aí todo galã. 
<p>- Primeiro, muito obrigado pelo elogio. – Os dois começaram a rir. – Mas não foi mulher. Estou procurando emprego.
<p>- Qual a sua história? Foi expulso de casa e paga um aluguel que faz um buraco na carteira?
<p>- Quase isso.
<p>- O que está procurando?
<p>- Eu estou tão desesperado que topo até limpar banheiro. 
<p>- Olha, pode ser seu dia de sorte. Eles precisam de um barman aqui.
<p>- É sério? – Will quase se engasgou com a água. 
<p>- Eu estou indo para Miami semana que vem. Estão procurando alguém para me substituir.
<p>- Miami? As praias de Malibu não são suficientes para você? – Will brincou. 
<p>- Na verdade, minha namorada mora lá. Ela está na faculdade e a gente topou esse negócio de namoro à distância, mas eu já estou ficando louco. Decidi me mudar. 
<p>- Nossa, que legal. Acho que está fazendo a coisa certa. 
<p>- É, eu a amo.
<p>- Eu sei como é. Eu namoro a garota mais incrível do mundo e não consigo ficar longe dela nem por um dia. 
<p>- O amor deixa a gente imbecil. – Os dois voltaram a rir.  – E então, topa ser barman?
<p>- Ah, o quê? Fácil assim? Eu não preciso mostrar a experiência que eu não tenho nem as habilidades que eu ainda vou aprender?
<p>- Fácil assim. Só não fala isso para o chefe. – Fred piscou para ele.
<p>- Eu não posso ser barman. Eu nem tenho vinte e um. 
<p>- Eu também não. Contanto que não beba, tudo bem. 
<p>- É sério mesmo? Isso meio que salvaria a minha vida.
<p>- O meu chefe, mais conhecido como o dono de tudo, está lá nos fundos. Podemos falar com ele agora mesmo. 
<p>- Parece que você está mais desesperado do que eu.
<p>- Só tem aparecido louco por aqui e você não parece ser louco. 
<p>- Não, só idiota. 
<p>- O que aconteceu? Por que precisa tanto do emprego? Pode dizer, eu sou barman, além de te dar conselhos, esse papo nunca vai sair daqui. 
<p>- Meu irmão mais novo fez besteira e agora deve vinte mil dólares. Eu preciso desse emprego para pagar por ele e falando isso em voz alta eu percebo o quanto é idiota o que eu estou fazendo.
<p>- É um pouco.
<p>- Meses atrás, ele me disse que eu era uma péssima pessoa e preferiu ficar com a namorada dele do que ser meu irmão. Talvez eu só queira que ele...
<p>- Te considere.
<p>- Exato. É idiotice. 
<p>- Eu tenho dois irmãos que se casaram e não me mandaram convite. Eu meio que sou a ovelha negra da família. Às vezes tudo o que eu queria era uma ligação, mas eu sei que se algo acontecer, eu largo tudo para ajuda-los. E talvez eles façam o mesmo, eu não sei. 
<p>- Família é uma droga.
<p>- Família é uma droga.</p>
<center><h4>--*--</h4></center>
<p>- Por que você me mandou a sua localização por mensagem e escreveu “CORRE”? 
<p>Emily encontrou no bar toda confusa e com o celular na mão.
<p>- Achou que eu tinha sido sequestrado? – Will estava sentado em um banquinho perto do balcão.
<p>- Não, seria bom demais para ser verdade. – Ela sorriu. – O que estamos fazendo aqui?
<p>- Eu vou estar aqui agora todo dia depois da escola. 
<p>- O quê? Por quê? Resolveu virar alcoólatra?
<p>- Ah, qual é? Você é mais inteligente que isso.
<p>- Conseguiu um emprego?
<p>- O dono do bar disse que posso começar amanhã mesmo. 
<p>- Ai, minha nossa! – Emily o abraçou. – Eu sabia que iria conseguir.
<p>- Você sabia mais do que eu então. – Will finalmente conseguia respirar aliviado. 
<p>- Você vai... – Emily olhou surpresa para o palco no fundo do bar.
<p>- Não. Eu vou ser o barman. – Will cortou o barato dela. 
<p>- Mesmo assim, é um emprego. – Ela sorriu. – Devíamos comemorar.
<p>- E nós vamos. Seu namorado agora é um adulto oficialmente. 
<p>- Só precisa agora começar a fazer coisas de adulto. 
<p>- Mas quem não quer fazer sexo é você. – Will riu.
<p>- Cala a boca, seu ridículo. – Ela também riu. – Eu estou falando do Kevin. Eu acho muito bom você ter arrumado o emprego, mas não quero ver você trabalhando feito doido só para pagar uma dívida que não é sua. 
<p>- Foi o que eu disse a ele. – Fred vinha do porão com uma caixa de papelão nos braços.
<p>- E ele ouve a gente? Não. – Emily olhou feio para Will e depois se voltou para Fred. – Sou Emily.
<p>- Fred. Então você é a garota mais incrível do mundo que o Will falou. 
<p>- Pode ser que eu sou. – Ela sorriu. 
<p>- Foi ele que me arranjou o emprego. Devia ter visto o que ele falou para o chefe dele me contratar. Até eu me convenci de que eu era um barman.
<p>- E esse lugar, como ele é?
<p>- Daqui algumas horas esse lugar vai lotar de gente. Deviam ficar para já irem se acostumando. – Fred falou enquanto colocava a caixa atrás do balcão. – A bebida é por conta da casa, já que vocês não podem beber. – Ele riu. 
<p>- Isso parece ótimo. – Will fingiu comemorar. – Mas eu preciso contar a boa notícia para algumas pessoas.</p>
<center><h4>--*--</h4></center>
<p>Jason já estava há alguns minutos parado do lado de fora da casa de Will esperando. Quando o carro de Robert cruzou a rua e veio em sua direção, ele foi para a frente do carro e acenou para o homem estacionar. 
<p>- Jason, oi. O que houve? – Robert estacionou na calçada mesmo e saiu do carro um tanto apressado. Jason não costumava fazer isso, então esperou o pior. 
<p>- Bom, o Will vai me matar quando descobrir, mas eu precisava muito falar com o senhor. 
<p>- No que mais ele se meteu? – Robert já bufou e ficou inquieto.
<p>- Ele não se meteu em nada. 
<p>- Olha, Jason, eu gosto muito de você, eu até te considero da família e eu sempre digo o quanto estou feliz por você estar namorando a minha filha, certo?
<p>- Senhor...
<p>- Eu sei que você é o melhor amigo dele. Eu sei que veio aqui defendê-lo, mas até um amigo precisa reconhecer o erro do outro amigo. O que ele fez foi horrível. 
<p>- Olha, sendo bem sincero... Se alguém dissesse para o meu pai que estou usando drogas ou algo do tipo, ele acreditaria, e eu não poderia culpá-lo, além do mais ele não me conhece. – Falar sobre o pai ainda deixava um gosto amargo na boca de Jason. – Mas se esse mesmo alguém falasse o mesmo para o senhor, nunca acreditaria.
<p>- É claro. Eu te conheço muito e sei que você nunca se meteria com isso.
<p>- Exato. Me conhece bem, mas conhece o Will melhor, eu sei que conhece. Acredita mesmo que ele se meteria com um agiota ou com qualquer outra coisa ilegal desse jeito?
<p>- Jason, eu não sei de mais nada. Você não estava lá, você não...
<p>- É, eu não estava. Eu imagino como deve ter sido para o senhor e para sua família ver um bandido na porta da sua casa. E você pode até ter comprado essa história na hora por causa da raiva e do nervoso, mas... Você não pensou melhor e percebeu o quão ridículo isso é?
<p>- Jason...
<p>- Quando a Amanda me contou essa história de manhã, eu não acreditei. Eu nem precisei pensar muito, só sabia que era algo impossível de acontecer. Eu não acredito que eu conheço mais o Will do que o pai dele.
<p>- O que você quer dizer, Jason? Que o Will não é o culpado? Ele...
<p>- Assumiu a culpa, eu sei disso. E sei que ele levaria de novo, mesmo sendo algo estupido. 
<p>- Ele está protegendo alguém, não está? – Robert colocou as mãos na cabeça, pensativo e um pouco envergonhado. – Mas que droga. Sebastian?
<p>- Tenta de novo. 
<p>Robert pensou por alguns segundos antes de dar outra tentativa. Seus filhos todos passaram pela sua cabeça até que...
<p>- Kevin. 
<p>- Will nunca deixaria o irmão mais novo na mão. 
<p>- Eu não acredito nisso. Eu disse tantas...
<p>- Acho que precisam conversar.
<p>- Acho que eu preciso me desculpar.</p>
<center><h4>--*--</h4></center>
<p>- Vocês estão olhando para o novo barman do Woody-Club. – Todas as pessoas que Will queria ver naquele momento estavam reunidas na lanchonete tomando sorvete naquela noite. Ele chegou junto com Emily e mostrou para todo mundo a camiseta preta com o logo bem discreto do bar no canto. 
<p>- Você não sabe ser um barman. – Chris franziu a testa. – Nem tem idade para ser um. Vai acabar sendo preso. 
<p>- Ele só precisa não ficar bêbado. – Emily sorriu enquanto se sentava ao lado da irmã. 
<p>- Aquele lugar vive cheio. Você tem certeza que vai dar conta? – Amanda parecia preocupada.
<p>- Nossa. “Parabéns, Will. Sabia que ia conseguir”. Eu só quero ouvir isso. – Will se sentou um pouco desanimado do lado de Jason. 
<p>- Parabéns, Will. – Quinn falou. 
<p>- Muito obrigado. – Ele sorriu. – A partir de amanhã, eu vou ter o meu próprio dinheiro.
<p>- E com o seu próprio dinheiro, vai poder pagar ao papai pela divida do Kevin. Vai ser bem produtivo. – Sebastian ainda estava bravo. Não havia aceitado nenhum pouco aquela ideia.
<p>- Vamos esquecer isso, tá bom? O que foi feito já está feito. 
<p>- Espero que já tenha pelo menos uns dez mil dólares quando chegar em casa. – Amanda avisou. 
<p>- Eu estou com zero vontade de ir para casa hoje. 
<p>- Você precisa ir. Aproveita e já conta a verdade. – Chris falou. 
<p>- Eu vou pedir alguma coisa para comer. – Will ignorou o irmão.</p>
<center><h4>--*--</h4></center>
<p>Sebastian saiu da lanchonete e foi caminhar. Sua cabeça estava um pouco cheia. Já estava irritado por causa do seu namoro fracassado e a história de Will só piorou a sua situação. 
<p>Ele viu de longe Melissa olhando para uma vitrine de roupas e quando pensou em dar meia volta para não cruzar com ela pelo caminho, ela se virou e o viu.
<p>- Não sabia que estava por aqui, eu sinto muito. – Ele foi até ela, não queria parecer mal-educado.
<p>- Por que diz isso como se estivesse fazendo algo errado?
<p>- Bom, eu não... eu não sei. – Ele riu sem graça.
<p>- Eu conversei com a Quinn hoje. Ela foi até a minha casa se desculpar. 
<p>- Você aceitou as desculpas?
<p>- Você não? 
<p>- Estamos bem, não estamos mais... Estamos bem.
<p>- Ótimo. 
<p>- E quanto a nós?
<p>- Sebastian...
<p>- Eu não quero ficar com você. – Sebastian atropelou as palavras. – Quer dizer, eu quero, mas não do jeito que você está pensando e querendo evitar. Quero voltar a ser seu amigo. 
<p>- Eu também quero. – Melissa respirou fundo. – Eu acho que eu pirei com essa história da Quinn. Eu já fui traída e odiaria ser essa pessoa. E só de pensar que ela achava que eu poderia ser... isso foi demais para mim. 
<p>- Está tudo bem agora. Será que podemos esquecer tudo isso e voltar ao normal? Recomeçar? 
<p>- Tudo bem, eu topo. 
<p>- Quer... dar uma volta na praia? Eu preciso te contar uma coisa ridícula que o Will fez e que está me deixando louco. 
<p>-Tá, mas preciso estar em casa às onze. 
<p>- Onze e meia? – Sebastian sorriu. 
<p>- Só... vamos logo. – Melissa também sorriu. 
<p>- Senti sua falta. – Ele a abraçou involuntariamente. 
<p>- Amigos não se abraçam. – Ela pensou em afastá-lo, mas gostou do abraço.
<p>- Se abraçam sim.</p>
<center><h4>--*--</h4></center>
<p>Will entrou no quarto bem apressado para pegar seu carregador de celular. Só precisava disso e então iria para a casa de Emily. Seu pai estava sentado na cama o esperando. 
<p>- Will, podemos conversar? 
<p>- O que foi? Eu estou com um pouco de pressa. – Will respondeu sem nem ao menos olhar para o rosto de seu pai. Ele pegou o carregador que estava em cima da estante e colocou no bolso.
<p>- Eu sei que... não foi você que fez a dívida com o agiota. 
<p>- O quê? A mamãe te convenceu a acreditar nisso?
<p>- Ela sabe?
<p>- Quem te contou? – Will sabia que Robert não havia descoberto sozinho e se não tinha sido sua mãe... – Jason. Aquele linguarudo filho de uma figa. 
<p>- Ele só estava te ajudando.
<p>- O que você quer, pai? – Will o encarou.
<p>- Dizer que sinto muito. 
<p>- Ótimo.
<p>- Filho...
<p>- Eu arranjei um emprego. Prometi que ia te pagar e eu vou, então não se preocupe.
<p>- Eu não quero o seu dinheiro.
<p>- Então o que você quer? 
<p>- Você está bravo. Por que está bravo? – Robert não estava entendendo a reação do filho. 
<p>- Você me disse coisas ontem. Você gritou e berrou e eu fiquei calado só te ouvindo. E você achava que tinha razão e tudo bem, porque eu disse que você tinha razão. Ninguém acreditou que eu seria capaz de fazer uma coisa dessas, ninguém, a não ser você.
<p>- Mas, Will...
<p>- Em algum momento entre ontem à noite e a hora que falou com o Jason, você chegou a duvidar do que eu supostamente tinha feito? Não, não é? – Robert ficou em silêncio. – Você sempre espera o pior de mim.
<p>- Não é verdade.
<p>- É sim. Eu posso não ser o melhor aluno nem ligar para as coisas que você liga, e é, eu faço algumas besteiras. Mas eu ainda sou o mesmo garoto que ajuda cada um de vocês dentro dessa casa da maneira que eu posso e tudo o que eu ganho é desconfiança. 
<p>- Eu sinto muito.
<p>- Eu sei, pai, eu já ouvi. E tudo bem. Eu não me importo agora. Se você descobriu, que ótimo, se não quer mais meu dinheiro, melhor ainda. Se vai lá agora castigar o Kevin ou ao menos conversar com ele para saber o que está acontecendo, faça isso. 
<p>- Will...
<p>- Mas não pode dizer “sinto muito” e apagar tudo. Eu não sou de esquecer as coisas. Você sabe disse porque me conhece ou ao menos deveria me conhecer. 
<p>- O que você quer eu faça? O que você esperava que eu fizesse ontem à noite? Você não estava aqui quando aquele bandido apareceu. Você não... você poderia ter dito a verdade. 
<p>- Mas eu não disse e não me arrependo mesmo todo mundo me dizendo que eu fui idiota. Eu bati no meu irmão há alguns meses porque ele me disse que eu era uma pessoa ruim, agora estou levando a culpa de uma coisa que ele fez só para protegê-lo. Esse é o tipo de pessoa que eu sou. Enquanto isso, ele está indo à festas, se drogando e negociando com agiotas com apenas quinze anos e sem você saber. Esse é o tipo de pai que você está sendo. Tenta dormir com esse barulho. 
<p>Will saiu do quarto.</p>
<br>
<p>“Muitas pessoas são orgulhosas e rancorosas demais para perdoar alguém. Eu, particularmente, não sou de esquecer esse tipo de coisa. Não sou de perdoar e muito menos fingir que nada aconteceu. 
<p>Recomeçar, um termo interessante e muito usado que pode ter seu lado bom e seu lado ruim, mas o que é que não tem dois lados nessa vida, não é verdade? Às vezes algumas coisas têm até mais de dois.
<p>Você seria capaz de esquecer tudo o que aconteceu só para viver em paz com alguém? Ao menos tentaria? Se sim, como o encararia todos os dias? Você realmente passaria uma borracha na história toda e só esperaria que isso não acontecesse de novo? Não teria dúvidas? Isso é fácil de fazer? Difícil? Às vezes só é complicado. 
<p>Como se apaga algo que não sai da sua cabeça? A pessoa que te decepcionou, o grau de consideração, isso tudo é alguma variável nessa equação de começar de novo? É fácil deixar para lá e fingir que alguém nunca existiu, mas e se esse alguém é seu melhor amigo, um familiar, alguém que você ama de verdade? Você acaba descobrindo que nesses casos, não é tão fácil assim. 
<p>Vale a pena correr o risco de reviver tudo de novo? As pessoas mudam assim? Mas e as segundas chances? Elas existem? Alguém realmente merece uma segunda chance? Você merece? Às vezes sim, às vezes não. Às vezes só é complicado.”.</p>
</body>
</html>";
            }

            if (numero == 34)
            {
                lblTitulo.Text = "Capítulo 34 - A Vida Em Cores é Assim, Hoje Não Parece Com Nenhum Outro Dia";
                htmlPage.Html = @"<html>
<body>
<p><i>“A vida em cores é assim
<br>Hoje não parece com nenhum outro dia
<br>E nos cinzas mais escuros
<br>O sol explode, as nuvens quebram
<br>A vida em movimento é assim
<br>E bem quando eu não conseguia mais correr essa corrida
<br>O sol explode, as nuvens quebram
<br>A vida em cores é assim”
<br><b>Life In Color - OneRepublic</b></i></p>
<br>
<p>“Quando eu tinha seis anos, meu pai me levou a uma casa de shows pela primeira vez. A banda ainda não era muito conhecida na época, mas mesmo assim a casa estava lotada. Parecia um milhão de pessoas para mim naquela idade ou talvez até tivesse mesmo. Nós dois ficamos nos bastidores antes do show começar e eu me lembro do vocalista da banda autografando o meu violão de brinquedo. Eu não sabia o que aquilo significava na época. Eu só fiquei pensando, por que aquele cara tinha riscado o meu brinquedo? Era algum caderno, por acaso?
<p>Ficamos no canto do palco o show todo que durou umas três horas. Ao invés de olhar a banda, era a plateia que me interessava e eu não consegui tirar os olhos dela. Alguns seguravam cartazes de cartolina que eu só conseguia enxergar os corações e fotos dos membros da banda. A maioria das pessoas empurrava um ao outro para tentar chegar na grade ou o mais próximo possível do palco. Alguns choravam, talvez de emoção, eu pensei. Mas o que mais me impressionou foi que aquela plateia sabia todas as músicas de cor e cantava junto sem ninguém pedir. Conforme o show se encerrava, até dava a impressão que estavam cantando mais alto e com mais energia. Aquela letra que eu não entendia muito bem significava algo para aquelas pessoas. Ninguém cantaria daquele jeito se a letra fosse uma merda sem significado nenhum.
<p>No final do show, todos os integrantes pegaram o microfone e agradeceram. Eles haviam ensaiado um discurso e cada um dos cinco disse uma parte. Eles agradeceram pelo amor e carinho que os fãs tinham por eles, disseram que estavam trabalhando em mais um CD e que amavam o que faziam. É, cantar em um palco parecia divertido. Mas qual era o objetivo a não ser fazer barulho? Eu não entendia até aquele dia. 
<p>Quando o show acabou, o cara que autografou o meu violão veio se despedir de mim e perguntou se eu tocava alguma coisa. Eu apontei para o brinquedo. Era o mais próximo de um instrumento que eu tinha. Ele disse que esperava que eu me tornasse bem famoso um dia e eu não entendi porque ele desejava isso para mim. Ele falou mais algumas coisas que não fizeram muito sentido, mas no final, algo fez e aquela parte ficou na minha cabeça por muito tempo.
<p>- Você viu aquelas pessoas cantando junto comigo essa noite? Não tem sensação melhor do que essa. Saber que alguém está lá se importando e gostando da mensagem que você passa e que isso pode fazer com que a vida dessa pessoa mude pelo menos por algumas horas, não tem preço. Eu faço a diferença com a minha música. Eu não ia querer isso se fosse de outro jeito. 
<p>Fazer a diferença. Isso parecia ser bem importante. Passar a sua vida fazendo a diferença na vida das outras pessoas. O que mais eu poderia pedir?
<p>Eu quebrei o meu violão de brinquedo dois meses depois e no Natal daquele ano, minha mãe me comprou um de verdade e com oitos anos eu já conseguia tocar qualquer coisa. Foram dias e noites praticando sozinho e com machucados nos dedos. Minha primeira música foi sobre um pássaro que eu vi voando pela janela do meu quarto, era engraçada e muito horrível, mas eu ainda a tenho e às vezes, quando estou sem inspiração, eu leio ela e algo me desperta.”.</p>
<br>
<p>Will chegou quase sem fôlego no bar. Ele jogou sua mochila atrás do balcão e foi direto para o armazém que ficava no porão. Fred estava lá empilhando umas caixas em um carrinho.
<p>- Você quase se atrasou. – Fred avisou.
<p>- Eu tenho que cruzar a cidade em quinze minutos. Sorte eu não ter sido atropelado no caminho para cá. – Will reclamou enquanto tirava sua camisa de flanela e deixava à mostra sua camiseta com o logo de Woody-Club no peito. 
<p>- Bem-vindo à vida adulta. – Fred riu. 
<p>- O que eu faço agora? – Ele pendurou a camisa em um dos pregos que estavam na parede. 
<p>- Vamos levar essas caixas lá para cima e abastecer as estantes de bebidas. Você tem que fazer isso todos os dias quando chegar aqui. 
<p>- Certo.
<p>- E contar quantas estão levando e no final do dia, no caso, noite, contar quantas garrafas estão vazias e dar baixa no estoque.
<p>- Entendi. – Will guardava toda a informação sem escrever nada. Ele se lembraria. 
<p>- Temos...
<p>- Trinta minutos até abrirmos o bar. – Ele completou. – Abastecemos o bar, passamos pano no chão e no balcão e arrumamos as mesas. Hoje é quarta-feira, dia do karaokê. 
<p>- Isso mesmo. – Fred ficou impressionado. – Quinta é dia de...
<p>- DJ.
<p>- Sexta, sábado e domingo?
<p>- Show ao vivo.
<p>- Segunda e terça?
<p>- Cinema antigo hollywoodiano. Cara, está achando que está falando com um amador?
<p>- Engraçadinho.</p>
<center><h4>--*--</h4></center>
<p>Will estava se divertindo mais do que pensou que se divertiria, embora fosse um pouco cansativo trabalhar e estudar ao mesmo tempo. Antes de ir embora, Fred havia ensinado como fazer todos os drinques do cardápio. Quanto a aquilo, Will havia anotado um por um. Ele se enrolou com os nomes no começo, mas se acostumou rápido.
<p>Nos primeiros dias, Joshua, o dono do bar, chegava bem cedo para instruir Will dos trabalhos e para ajudá-lo em algumas coisas especificas. Um mês depois, ele já recebia mercadorias sozinho, instruía os garçons e garçonetes, fazia o inventário e Josh não aparecia no bar com tanta frequência. Emily aparecia lá toda noite e ficava para ajudá-lo a fechar o caixa e as portas. Ela deixava tudo muito mais rápido, era melhor em matemática do que ele. 
<p>A primeira noite sozinho naquele bar, o lugar lotou. Era uma sexta-feira, e uma banda cover do U2 que era bem famosa naquelas redondezas se apresentaria. Ele tentou ficar o mais calmo possível. Josh havia dito que aquela noite seria o seu teste final. Emily precisou passar pelo balcão e ajudá-lo com os drinques. No final, deu tudo certo.</p>
<center><h4>--*--</h4></center>
<p>- E como estão as coisas com o seu pai?
<p>Jason fazia a mesma pergunta toda vez que se encontrava com Will na escola. 
<p>- Ainda a mesma coisa. E eu ainda estou com raiva de você por me dedurar. 
<p>- Falar a verdade não é te dedurar. 
<p>- Que seja. – Will revirou os olhos.
<p>- Seb me disse que seus pais estão pensando em colocar o Kevin em um colégio militar ano que vem. É verídico?
<p>- Eu não faço ideia. Mal estou ficando em casa ultimamente. Amém. 
<p>- É verdade, agora você é um trabalhador. Meu Deus, que orgulho.
<p>- Não enche. – Will fez cara feia para a piada do amigo.
<p>- Will, agora é sério. Você precisa perdoar o seu pai. Não foi culpa dele.
<p>- Olha, eu perdoei, tá bom? Eu só não estou com saco para falar com ele agora. 
<p>- Eu queria ter essa opção, sabia?
<p>- Ah não, você não vai me jogar essa história de “aproveita porque você ao menos tem um pai”. 
<p>- Por que não? 
<p>- Porque é irritante. Você não tem pai e quer ter um pai. Eu tenho um pai e me irrito com esse pai. Às vezes queria dar ele para você. 
<p>- Sem graça. 
<p>- Aliás, como você está? Estamos há tanto tempo falando dos meus problemas que... 
<p>- Eu estou igual. Sinto vontade de ir até o seu bar e me embriagar? Com certeza, sinto, mas... Vou ficar bem. 
<p>- Se aparecer lá com uma identidade falsa, finjo que é verdadeira. – Will sorriu.
<p>- Se ainda não falou com o seu pai, é claro que ainda não falou com o Kevin. 
<p>- Esse aí eu não quero ver nem pintado. 
<p>- Por que tanto ódio nesse coração? – Jason riu. 
<p>- Porque se não tiver ódio, vai ter amor e isso é uma droga. – Will respondeu também rindo.</p>
<center><h4>--*--</h4></center>
<p>Toda noite, Will já ia direto do bar para a casa de Emily e isso facilitava sua missão de ignorar o pai, mas nos fins de semana era inevitável. Ele precisava aparecer em sua casa para ver sua mãe.
<p>As coisas com seu pai ainda não estavam boas. Eles mal se falavam e às vezes Robert até tentava evitar contato visual com o filho. Kevin estava de castigo, proibido de sair de casa e de mexer no celular por tempo indeterminado, quanto à escola, seus pais o levavam e buscavam de carro todos os dias. Amanda havia falado para Will que Giovanna aparecia lá com bastante frequência para visitar o namorado, mas que ele não era a primeira pessoa que ela perguntava sobre.
<p>AWill não estava se importando com isso, na verdade. Era como se viver diariamente naquela casa tivesse sido em uma outra época. Uma época bem distante. 
<p>Naquele sábado de manhã, quando ele chegou em casa, cruzou com seu pai que estava na sala de estar vendo televisão. Parecia que ele estava ali estrategicamente esperando seu filho chegar.
<p>- Oi, tudo bem? – Robert falou em um tom bem casual. 
<p>- Tudo ótimo, pai.
<p>- Podemos conversar?
<p>- Agora não dá. Eu tenho que colocar minha roupa na máquina de lavar. – Will tinha uma mochila nas costas com as roupas sujas da semana toda.
<p>- Como está indo no trabalho?
<p>- Muito bem. 
<p>- Filho, sabe que não precisa mais...
<p>- Eu sei, mas não estou trabalhando por você e sim por mim. 
<p>- E quando podemos conversar?
<p>- Não sei. Talvez amanhã, talvez outro dia. 
<p>- E quanto aos seus estudos?
<p>- Pai, está tudo bem, tá bom?
<p>Will não queria continuar ali para ter uma conversa que ele não estava a fim de ter então tentou cruzar a sala o mais rápido possível, mas quando estava quase chegando na porta da cozinha, seu pai gritou.
<p>- Espero que não pense em ser um barman para o resto da vida!
<p>- E se eu for? Qual é o problema? – Will se virou para o pai.
<p>- Isso não é trabalho para você.
<p>- E qual exatamente é o trabalho para mim? Porque aparentemente nada do que eu quero fazer é bom para você. 
<p>- Não vamos começar com essa história de novo. – Robert bufou. 
<p>- Que história, pai?
<p>- Essa história de querer cantar.
<p>- Essa história de querer cantar. – Will soltou uma risada. – Sabe o que é mais engraçado? Eu passei a vida toda ouvindo você me dizer que “essa história de querer cantar” não ia me levar a lugar nenhum.
<p>- E é verdade. 
<p>- É e talvez por isso, eu não consiga subir em um palco e enfrentar uma plateia de verdade. O que é uma pena, pai, porque eu sou bom. Eu sou muito bom, na verdade. 
<p>- Não interessa. – Robert se levantou do sofá. Ele talvez achou que ficar de pé daria mais força ao seu discurso. – O que você quer fazer não vai te dar um futuro.
<p>- Talvez não dê mesmo, mas você é meu pai. O mínimo que devia fazer era me apoiar. Você gerencia uma gravadora. Passa todos os dias dizendo para aspirantes que a vida deles vai dar certo, mas não consegue fazer isso comigo. 
<p>- Essas pessoas não são meus filhos. Eu quero que você faça...
<p>- Você não entende, não é? Não interessa o que você quer. Eu não vou fazer algo que eu não gosto só para te agradar e ser infeliz para o resto da vida. Não é assim que funciona! Pelo menos, não para mim!
<p>- Você não entende. Tudo bem.
<p>- Você que não entende e nem faz questão de entender, mas não me interessa. Ultimamente, a sua opinião é a última coisa que me interessa!
<p>- Olha como você fala!
<p>- Que gritaria é essa aqui? – Karen saiu da cozinha irritada. Ela estava ouvindo a conversa desde o começo em silêncio na cozinha e havia prometido a si mesma que não ia interferir, mas não conseguiu. 
<p>- Deixa para lá, mãe. Eu só vim aqui lavar a minha roupa. 
<p>Will passou pela mãe, cruzou a cozinha e foi até a lavanderia. Agora só precisava ficar ali até que todas as suas roupas fossem lavadas. A hora mais longa de sua vida.</p>
<center><h4>--*--</h4></center>
<p>- Isso não está certo. 
<p>Emily ajudava Will a arrumar as mesas e cadeiras do bar. Naquela noite haveria show ao vivo e sempre era preciso abrir mais espaço para a pista de dança em noites como aquela. 
<p>- Emily...
<p>- Will. Pais e filhos não devem ter raiva um do outro. 
<p>- Eu não tenho raiva do meu pai, eu só... estou cansado de ouvir bobagens. 
<p>- E o que vai fazer então? – Emily estava irritada. – Não pode ficar brigando com ele como cão e gato o resto da vida e também não pode ignorá-lo.
<p>- Eu só preciso de um espaço. Só isso. E sabe...
<p>- O quê? Vai viver no meu quarto para sempre?
<p>- Não, sua boba. Eu estava pensando... Agora que eu não tenho dívida nenhuma para pagar, eu posso pensar em alugar um lugar para eu morar. 
<p>- Olha... – Emily se aproximou de Will. – Eu acho ótimo você pensar nisso, mas eu acho bom também você avaliar a situação primeiro. Morar sozinho não é fácil.
<p>- Eu sei disso e não é uma coisa que eu queira fazer imediatamente. Eu só estou pensando. 
<p>- Então você não está mesmo pensando em uma reconciliação. 
<p>- Eu não sei. – Will respirou fundo. – Acho melhor pensarmos em outras coisas agora. 
<p>- Tipo o quê?
<p>- Eu preciso testar o som. Os caras da banda vão chegar daqui uma hora. Quer escolher a música?
<p>- Me surpreenda. – Emily sorriu.
<p>Will subiu no palco. Os instrumentos já estavam ligados nas caixas de som, só precisavam ser testados. Ele pegou a guitarra, sentiu a afinação e começou a tocar. 
<p>- Testando. Um-Dois-Três. – O microfone estava ótimo. - <i>Eu acredito na areia entre meus dedos. A praia dá uma sensação, uma sensação terrestre. Eu acredito na fé que cresce e nas quatro notas certas que podem me fazer chorar.</i>
<p>- Eu adoro essa música! – Emily gritou enquanto observava Will cantando. 
<p>- <i>Quando eu estou com você, parece que eu posso morrer e mesmo assim ficaria tudo bem, tudo bem! E eu quero algo a mais para me colocar completamente nesse tipo de vida semi-encantada.<i>
<p>- <i>Amor! Amor!</i>
<p>- <i>Eu quero algo a mais. Eu não estou ouvindo quando você diz adeus...</i>
<p>Ele parou.
<p>- Eu poderia ficar aqui ouvindo você cantar o dia todo.
<p>- E eu poderia cantar para a minha fã número um o dia todo.
<p>- Não poderia não. Tem que abrir o bar em cinco minutos.
<p>- Droga!</p>
<center><h4>--*--</h4></center>
<p>Sebastian saía da escola depois de ficar uma hora a mais na biblioteca estudando para uma prova de Geografia quando viu Melissa passando pelo portão. Ele correu até ela.
<p>- Oi.
<p>- Oi. O que ainda está fazendo aqui? – Melissa sorriu.
<p>- Estudando. As provas bimestrais estão chegando, então...
<p>- Entendi.
<p>- Olha, que bom que eu te encontrei, eu ia mesmo te ligar e... O que vai fazer essa noite?
<p>- Eu vou ficar em casa e assistir a primeira temporada de Um Diário de Um Vampiro.
<p>- Isso parece horrível. – Sebastian fez cara de nojo.
<p>- Não se eu imaginar que estou do lado de dois vampiros gatos.
<p>- Olha, eu tenho outra ideia. Podemos ir ao bar onde o Will trabalha. Vai ter música ao vivo hoje.
<p>- Eu sei, ele me falou. Eu não estou muito a fim. 
<p>- Ah, qual é? É sexta à noite. Todo mundo vai. Faz parte da galera agora.
<p>- Galera?
<p>- Olha, se você não for, eu vou ser obrigado a te fazer companhia e assistir esse negócio de vampiros. Tem alguma vampira também?
<p>- Cala a boca. Tudo bem, eu vou. A gente se encontra lá?
<p>- Ou eu posso ir te pegar.
<p>- Eu sei o caminho, Seb.
<p>- Só por via das dúvidas. Caso se perca. Você não tem muito senso de direção. 
<p>- Pensando bem, eu me perco às vezes.
<p>- Na sua casa às sete?
<p>- Combinado.</p>
<center><h4>--*--</h4></center>
<p>- Eu estou muito atrasada!
<p>Emily entrou no quarto correndo já tirando os sapatos. 
<p>- Onde esteve? – Quinn estava deitada em sua cama.
<p>- Que susto! O que faz aqui?
<p>- Estava te esperando. Você sumiu a tarde toda. 
<p>- Eu estava no bar ajudando o Will a abrir. – Emily entrou no banheiro para trocar de roupa.
<p>- Então você está trabalhando no bar também só que sem receber? – Quinn levantou a sobrancelha. 
<p>- Não enche! – Ela gritou do banheiro. – Você vai ao bar hoje à noite?
<p>- Acho que não. Sebastian e Melissa vão estar lá, certeza. Prefiro evitar.
<p>- Achei que fossem amigos. Você não foi até a casa dela e tudo?
<p>- Sim, mas o que falamos na teoria não é exatamente o que acontece na pratica. 
<p>- Vocês são ridículos.
<p>- Olha, eu estive pensando... Tem falado para o papai sobre você estar em um bar toda noite?
<p>- Isso é problema meu.
<p>- Já sei minha resposta.
<p>- Não enche. – Emily saiu do banheiro já com outra roupa e penteando os cabelos. 
<p>No momento em que Emily ia responder, Harry entrou no quarto sem nenhum aviso. 
<p>- Pai! Podia ter batido na porta. – Emily arregalou os olhos brava.
<p>- Estão se arrumando para irem em algum lugar?
<p>- Eu não vou para lugar nenhum. – Quinn tirou logo o dela da reta e deixou Emily ainda mais brava.
<p>- Eu vou ao bar onde o Will trabalha. Vai ter música ao vivo e...
<p>- Você não vai.
<p>- Eu estou indo toda noite. Por que hoje seria diferente? – Emily resolveu falar a verdade.
<p>- Porque eu descobri e estou dizendo que você não vai.
<p>- Pai, não começa. Eu não estou fazendo nada de errado.
<p>- Eu ainda nem comecei mesmo. 
<p>- Olha, eu não bebo nem uso drogas nem saio com estranhos, eu vou estar lá com o meu namorado. – Emily então tentou alcançar o lado humano do pai. – Will está passando por uma barra, só estou indo lá para apoiá-lo.
<p>- Não me interessa pelo que ele está passando. Você não vai ficar toda noite em um bar. 
<p>- Eu já disse. Não estou fazendo nada de errado. Você precisa confiar em mim. 
<p>- Eu...
<p>- Eu já cansei de você falando mal do Will e tentar proibir a gente de ficar junto. Estamos juntos já faz tanto tempo e você não consegue aceitar. – Emily encarou o pai. – Se insiste com essa coisa ridícula, tudo bem, mas não pode me impedir de sair.
<p>- Claro que eu posso. Eu sou seu pai! – Harry gritou.
<p>- É meu pai e deveria saber o que é melhor para mim. É uma pena que não saiba. – Emily calçou novamente os sapatos e pegou sua bolsa que estava em cima da cama. – Eu estou tão feliz, queria que ao menos ficasse feliz por mim. – E saiu do quarto.
<p>- Emily!
<p>- Eu vou atrás dela. – Quinn se levantou da cama e se dirigiu ao pai. – Só parem de brigar.</p>
<center><h4>--*--</h4></center>
<p>Will estava lidando com a noite mais agitada da sua vida. A casa estava cheia. Ele já estava acostumado com isso, além de ser uma sexta feira, todo mundo gostava do show que o bar proporcionava todo fim de semana. Ele fazia drinques como em uma linha de produção e os garçons corriam de um lado para o outro. 
<p>O show começaria em meia hora. A banda já estava tocando alguns acordes para aquecer enquanto esperava o vocalista chegar. 
<p>- Você brigou com o seu pai enquanto reclamava por eu brigar com o meu? – Will serviu outra soda para Emily que estava sentada encostada no balcão. 
<p>- Ele me tirou do sério. 
<p>- Você é uma hipócrita. – Ele riu enquanto preparava outro drinque para a mesa sete.
<p>- Cala a boca. Cadê esse cantor que não chega? Qual é o nome dele mesmo?
<p>- Acho que Brad. Josh disse que ele esteve no The Voice, ou alguma coisa assim. Só que ele está um pouco atrasado. – Will olhou para o seu relógio de pulso. – Já deveria estar aqui.
<p>Dez minutos depois, Josh saiu do armazém, ainda com o celular na mão e totalmente agitado.
<p>- Más notícias. Brad não vem.
<p>- O quê? – Will deu um grito.
<p>- Disse que teve um problema familiar. Mentira! É só um profissional de merda. – Josh estava quase vermelho de raiva. 
<p>- E o que a gente vai fazer? – Will estava nervoso também. Josh colocou as mãos na cabeça e ficou calado como se esperasse uma resposta do além. – Tive uma ideia. Podemos deixar a banda tocar alguns instrumentais. Isso vai deixar a galera...
<p>- Entediada. Eles não estão aqui para ouvir acordes, querem ver um show de verdade!
<p>- Tudo bem. Me dê dez minutos. Eu vou lá fora e encontro um cantor para você. Estamos em Hollywood, todo mundo quer ser uma estrela.
<p>- Não seja ridículo. – Josh balançava a cabeça negativamente olhando para seus clientes.
<p>- Então me ajuda, porque eu não tenho mais nenhuma ideia. 
<p>- Você precisa subir no palco e cantar.
<p>- O quê? – Will pensou ter ouvido mal. O quão louco e desesperado Josh estava para propor algo como aquilo?
<p>- Você precisar ir para o palco e cantar! – Josh gritou.
<p>- Olha, isso não vai acontecer. Eu nem sei...
<p>- Ah, corta essa. É claro que você sabe cantar. – Josh o interrompeu. – Eu já te ouvi. 
<p>- Onde? Quando? Como...
<p>- Você simplesmente não faz “um-dois-três” quando testa o microfone. Agora suba naquele palco e faça um show. 
<p>- Inacreditável. Emily... – Will olhou para a namorada à procura de ajuda, mas ela continuou em silêncio. – Josh, olha, eu não posso fazer isso. Eu nunca fiz isso antes.
<p>- Na verdade... – Emily começou a falar.
<p>- Tá bom, eu já cantei em um hospital para crianças doentes e em um bar falido para dez pessoas, mas não em um lugar como esse para centenas de pessoas. – Will estava começando a entrar em pânico. – Além do mais, eu preciso fazer drinques.
<p>- Eu faço os drinques. – Josh passou por cima do balcão.
<p>- Josh... Eu não posso. Eu vou pagar o maior mico.
<p>- Will, acha mesmo que se eu soubesse que você ia pagar mico, eu mandaria você fazer isso? Esse bar é tudo que eu tenho e não trato ele como piada. Agora sobe lá. 
<p>- Ótimo. – Will sentiu uma grande vontade de vomitar naquele momento.</p>
<center><h4>--*--</h4></center>
<p>Emily puxou Will até o armazém. Lá estava silencioso e poderiam conversar. Eles só tinham dez minutos até a hora do show.
<p>- Will, me escuta. – Emily segurou nas mãos dele, geladas e trêmulas.
<p>- Ems, eu não posso. 
<p>- Você pode sim. 
<p>- Eu vou subir lá e vou travar. Eu não vou conseguir. Eu nunca...
<p>- Você já fez isso antes, é só imaginar...
<p>- Eu não consigo. – Will repetia várias vezes enquanto balançava a cabeça negativamente. 
<p>- Will, esse é o seu grande sonho.
<p>- Não, meu grande sonho é ganhar na loteria. Cantar em público é meu pesadelo. 
<p>- Will...
<p>- Eu quero fugir daqui. Vamos fugir? – Will apertou as mãos de Emily. Estava tremendo. – Eu não preciso mais trabalhar mesmo, não tenho mais dívida nenhuma... Quem liga para esse bar?
<p>- Will.
<p>- Eles vão me vaiar. Vão tacar coisas em mim. Eu vou ser a maior piada de Los Angeles.
<p>- Isso não vai acontecer. – Emily, pelo contrário, estava muito calma e fazia de tudo para tentar passar aquela sensação para Will.
<p>- Vão rir das minhas músicas.
<p>- Não.
<p>- Vou fazer papel de palhaço.
<p>- Não vai, não. – Emily olhou bem no fundo dos olhos de Will. – Will, você é bom. Na verdade, é mais que bom. 
<p>- Só diz isso porque é a minha namorada. 
<p>- Não, eu digo isso porque eu já te ouvi cantar e sei o quão talentoso você é. 
<p>- E se eu abrir a boca e não sair nada?
<p>- Você pensa demais. 
<p>- Eu sei. – Will riu sem graça. – Eu estou com medo. 
<p>- Isso é uma coisa boa. É normal ter medo de algo novo, mas eu vou estar do seu lado o tempo todo. 
<p>- Você tem certeza? – Ele respirou fundo. – Eu sou bom mesmo, não sou? – E então mostrou um meio sorriso.
<p>- É sim. 
<p>- Will, vem! – Josh apareceu na porta do armazém. – Já vou te anunciar. Cinco minutos.
<p>- Droga! Que música eu canto? – Will voltou a olhar apavorado para Emily.
<p>- Qualquer uma.
<p>- Eu esqueci a letra. Eu esqueci a letra de todas.
<p>- Vai lá e relaxa.</p>
<br>
<p>“Dizem que quando você está com medo ou nervoso, o seu coração acelera muito. O meu coração estava quase saindo pela boca, então isso, com certeza, não era mais medo. Era outra coisa, uma coisa que eu não sabia mais decifrar. Algo entre ansiedade, ataque de pânico, pavor e animação. É, não dava para perceber, mas tinha animação em mim. Na verdade, eu não queria admitir, mas estava em êxtase.
<p>Eu subi no palco. A banda já estava em seu posto. Eu havia conversado com aqueles homens umas três vezes desde que comecei a trabalhar ali e naquele momento, íamos dividir o palco. 
<p>Emily estava no canto, mal era vista pela plateia, mas eu conseguia vê-la muito bem, na verdade, ela era tudo que eu conseguia ver naquele momento e me concentrei nela. 
<p>Eu não me lembro o que eu disse, como disse meu nome nem como disse o que cantaria, eu só me lembro de estar na frente de todo mundo, com o microfone na minha boca. Todos em silêncio esperando para ouvir algo. 
<p>Fechei os olhos. A banda começou a tocar a música que eu passei. Eu sempre carregava os acordes e letras salvos no meu celular. Era como se eu esperasse que algo desse tipo fosse acontecer em algum dia. Respirei fundo e comecei...
<p>- <i>Eu faço o meu melhor para achar algum tipo de brilho...</i>
<p>Meu corpo ficou quente, eu abri os olhos. Segurei o microfone com força mesmo ele estando no pedestal. Cantei. Cantei mais alto. E mais alto. Era como se... Sabe quando você está escutando rádio e de repente começa a tocar a sua música favorita? Você sente vontade de cantar junto não importa o lugar onde esteja. E você canta e não tem nada melhor do que poder cantar a sua música favorita.
<p>Olhei para a plateia, vi alguns rostos, aquelas expressões... Eu já tinha visto aquelas expressões algumas vezes, mas só agora eu entendia. Era liberdade. Eu consegui ver as cores das luzes que me iluminavam, o holofote, eu acho. As paredes do bar, nunca tinha reparado que eram tão vermelhas, pareciam sangue naquele momento. O palco estava verde e depois ia para o amarelo, depois voltava para o verde. Olhei para Emily, tinha aquele sorriso bem brilhante e aqueles olhos. Eles nunca foram tão azuis como naquele momento. Nada era tão colorido como naquele momento.”</p>
<br>
<p>A música acabou. A ovação tomou o seu lugar logo em seguida. Will não agradeceu nem ficou lá em silêncio enquanto as palmas não terminavam. Ele simplesmente correu até Emily. 
<p>- Isso foi incrível! – Will gritou totalmente trêmulo. 
<p>- Você conseguiu. – Emily segurou suas mãos geladas. – Eu disse que conseguiria.
<p>- Foi incrível! Eu nunca senti isso na minha vida! – Will estava quase pulando e seus olhos estavam esbugalhados. – É inacreditável!
<p>- Eu nunca te amei tanto quanto agora! – Emily o abraçou. – Eu estou tão orgulhosa de você!
<p>- Obrigado. Obrigado por tudo!
<p>- Não chora agora! Você tem outra música para cantar e outras depois dessa! Vai!
<p>- Tá! Eu vou. EU TE AMO! – Will deu um beijo bem caloroso em Emily e os dois precisaram de alguns segundos para recuperar o folego. 
<p>Will voltou para o palco enquanto ainda batiam palmas. 
<center><h4>--*--</h4></center>
<p>- Você foi incrível! – Jason foi o último que abraçou Will em frente ao balcão do bar depois que o show acabou. Ele também estava em êxtase. – Eu estou muito orgulhoso.
<p>- Valeu. – Will respondeu.
<p>Amanda o olhava sorrindo. Sebastian e Melissa não paravam de falar, animados, sobre os melhores momentos do show e das músicas. Chris o encarava com muito orgulho. 
<p>- Will, você salvou a minha vida. Foi maravilhoso. – Josh apareceu no meio deles abraçando Will meio alvoroçado. – Não tem ideia do que causou.
<p>- Como assim? – Will se assustou.
<p>- Pessoas gravaram o seu show e compartilharam nas redes sociais. Teve gente que chegou aqui perguntando onde era o seu show. Esse lugar nunca esteve tão cheio e nunca foi tão comentado! Foi incrível!
<p>- É sério? – Will ficou em choque.
<p>- Olha, precisamos contratar outro barman porque a partir de hoje, você é o meu cantor e eu não quero ouvir um não como resposta.
<p>- Eu não vou dizer “não”. – Will sorriu.
<p>- É bom mesmo. Eu vou fazer de você uma estrela!
<p>Josh saiu correndo pelo bar dando pulos de alegria. Will começou a gargalhar com a sua galera. Um a um, eles foram se despedindo e indo embora até que só ficou Emily.
<p>- Acho que eu ainda sou barman, então tenho que fechar o bar. – Will riu. 
<p>- O que me diz, astro do rock? Você ainda vai ter olhos para mim quando estiver cercado de fãs? – Emily sorriu.
<p>- Eu vou ter olhos só para você não importa quanta fãs eu tiver. Até porque você é a minha fã número um.
<p>- Achei esse título um pouco sexista. – Emily riu. 
<p>- Ems, hoje foi o melhor dia da minha vida.
<p>- Eu sei. E também foi o meu. – Ela o beijou. – Eu estou muito feliz por você.
<p>- É tudo o que importa, não é?
<p>- É.</p> 
</body>
</html>";
            }

            if (numero == 35)
            {
                lblTitulo.Text = "Capítulo 35 - Só Diga Que Não Vai Embora";
                htmlPage.Html = @"<html>
<body>
<p><i>“Eu sou tão apaixonado por você
<br>E eu espero que saiba
<br>Amor, seu amor vale mais que todo ouro do mundo
<br>Nós chegamos tão longe
<br>Veja como crescemos
<br>E eu quero ficar com você
<br>Até que fiquemos bem velhinhos
<br>Só diga que não vai embora”
<br><b>Say You Won't Let Go - James Arthur</b></i></p>
<br>
<p>Will chegou morrendo de sono em casa de manhã. 
<p>Ele não havia conseguido dormir. Estava eufórico demais para fechar os olhos. Preferiu ficar a noite toda conversando com Emily e descrevendo cada sensação que ele sentiu em cima do palco. Quando perceberam, já passava das oito da manhã e estavam falando de como a plateia reagiu. 
<p>- Filho!
<p>Will queria subir bem rápido as escadas para fugir daquela conversa, mas não conseguiu.
<p>- O que foi? – Ele respirou fundo enquanto ia até a sala de estar onde seu pai estava. 
<p>- Eu queria dizer que...
<p>- MEU FILHO É UM ROCKSTAR! – Karen não conseguiu esperar e saiu da cozinha gritando de animação. Correu até o filho e o abraçou bem forte. 
<p>- Entendi. Amanda contou para vocês. – Will retribuiu o abraço da mãe, mas não com tanto entusiasmo. 
<p>- Na verdade...
<p>- Nós vimos. – Os olhos de Karen brilhavam.
<p>- O quê?
<p>- Sua mãe me convenceu a ir. – Robert começou a explicar.
<p>- Eu queria que ele fosse até onde você trabalhava para conversarem. Ele veria você sendo adulto e responsável e fariam as pazes. – Karen parecia bem orgulhosa daquele plano que nunca teria funcionado. – Imagina a nossa surpresa quando entramos no bar e ouvimos você cantando no palco. 
<p>- Por que não ficaram? – Will ficou curioso.
<p>- Bom, parecia que você tinha muitos fãs para atender. – Robert respondeu com um pequeno sorriso. Era verdade. Depois do show, uma fila se formou perto do palco e Will tirou fotos com todo mundo. Até parecia um cantor famoso de verdade. 
<p>- Filho, estou tão feliz. Você foi maravilhoso. – Karen passou sua mão no rosto do filho com delicadeza.
<p>- Obrigado, mãe. – Will ficou sem jeito, mas não tirou os olhos de seu pai.
<p>- Will, você tinha razão. – Robert finalmente falou. – Você é muito bom. Eu quero que largue esse emprego e venha comigo até a gravadora. Vamos começar a gravar um disco agora mesmo.
<p>- Isso não é magnifico? – Karen comentou.
<p>- Ah, eu não quero. – Will nem precisou pensar para responder.
<p>- Filho... – Robert não entendeu.
<p>- Eu estou bem aonde estou. Não preciso da sua ajuda.
<p>- Filho, você ouviu o que eu disse? Vamos gravar um disco. Eu vou te colocar em todas as rádios do país e...
<p>- Eu já disse que não quero. Agora se não se importam, vou subir e tomar um banho. – Will se afastou de sua mãe que estava incrédula. 
<p>- William, você ficou louco da cabeça? Quem recusa gravar um disco?
<p>- Ontem você disse que eu não tinha futuro e hoje você quer que eu grave um disco? Que a minha música vai estar em todas as rádios? Ah, me poupe. 
<p>- Will... – Karen tentou segurar a mão do filho. 
<p>- Will, o que você quer de mim?
<p>- Olha, você está focando no filho errado. Vai cuidar do seu filho que está usando drogas e me deixa em paz. Eu sei me virar muito bem sem você.
<p>Will subiu as escadas correndo e se trancou no quarto. Ele só precisava de uma hora.</p> 
<center><h4>--*--</h4></center>
<p>- Você recusou uma gravação de um disco? Você perdeu o juízo?
<p>Jason e Will estavam correndo pela praia. A maratona estava chegando e com todos os últimos acontecimentos, eles tinham diminuído os treinos. 
<p>- Eu recebi essa mesma resposta do meu querido pai. – Will parou para beber um gole de água. Sua garrafa já estava quase vazia. 
<p>- Talvez ele tenha razão. 
<p>- Jason, eu não quero trabalhar com o meu pai. Eu já estive no estúdio, eu sei como ele trata aquelas pessoas. Se ele não gostar do meu estilo de música, o que com certeza vai acontecer, vai querer mudar tudo e fazer do jeito dele.
<p>- E só tem uma pessoa mais teimosa que você nesse mundo e essa pessoa é seu pai.
<p>- Exato. – Will respondeu. 
<p>- E o que vai fazer? – Jason parecia triste.
<p>- Ei, isso não é uma coisa ruim. Eu tenho o emprego que eu sempre quis. Subo no palco por três dias da semana e ainda recebo por isso. Eu não me sinto triste. 
<p>- Mas você só quer fazer isso? Quer dizer, acha que não pode ir além?
<p>- Jason, relaxa. Eu subi no palco pela primeira vez ontem. Eu não estou pensando no meu Grammy ainda. Preciso ir com calma. 
<p>- Bom, muitos pensariam o contrário.
<p>- Nesse momento, eu só quero correr para ganhar a minha maratona daqui um mês. 
<p>- Você não vai ganhar. Eu já disse que vou também. Eu posso ganhar, você não.
<p>- Quer apostar?
<p>- Eu não preciso. – Jason sorriu.
<p>- Palhaçada. </p>
<center><h4>--*--</h4></center>
<p>O bar ficava mais cheio a cada dia. 
<p>Josh contratou outro barman. O homem tinha o dobro da idade dele, mas era muito bom nos drinques e com os clientes. Will agitava a plateia em todos os shows e até na escola a sua fama chegou. 
<p>Várias vezes, ele ouviu sua voz saindo de um celular alheio no corredor da escola. Apontavam, comentavam e alguns calouros até pediam fotos discretamente. Era engraçado. 
<p>Agosto chegou e Will fazia cara de cansado toda vez que Emily falava sobre a maratona que aconteceria no próximo fim de semana. Ele já havia conseguido um substituto para cantar no bar enquanto estivesse fora. Era um garoto adolescente que ainda estava aprendendo a cantar e a lidar com o palco, ainda estava um pouco cru. Ele não podia contratar alguém melhor que ele. Queria a sua plateia fiel. 
<p>O sol bateu na janela às sete da manhã naquele sábado. Will se despediu de Emily dizendo que a veria em algumas horas e depois pulou a janela do quarto. Na sua casa, ele entrou pelos fundos para não ser visto. Tinha sido um habito que ele havia adotado. Evitava conversas indesejadas. 
<p>A viagem até San Diego duraria umas três horas. Jason havia mandando mensagem dizendo que já estava pronto. Emily também já estava se arrumando. Amanda odiava corrida e nem pensou duas vezes quando se negou a ir para essa viagem. Ela estava dormindo, Will imaginou. 
<p>Will tomou um banho, se vestiu, colocou algumas mudas de roupa em uma mochila para o banho depois da corrida, pegou a chave do carro que havia alugado no dia anterior. Não estava mais pedindo o carro emprestado de seu pai. Colocou seus tênis nos pés, a mochila nas costas e saiu do quarto. 
<p>Sebastian estava com a porta do seu quarto aberta quando Will passou pelo corredor. 
<p>- Will! – Sebastian se assustou quando viu o irmão. 
<p>- O que aconteceu? – Will olhou para Sebastian. Ele estava com a cara amassada, havia acabado de acordar e estava enrolado com lençol na cintura e de peito nu. 
<p>- Ah, nada. – Ele falou nervoso.
<p>- Tudo bem você dormir pelado, mas não precisa sair do quarto assim. Quer conversar? – Will franziu a testa.
<p>- Não, agora não dá, eu preciso voltar a... dormir.
<p>- O quê? – Will percebeu que ele estava mentindo. 
<p>- Ah, eu preciso voltar.
<p>- Tem uma garota no seu quarto. 
<p>- Não tem, não. – Sebastian fechou a porta atrás dele antes que Will tentasse espionar. 
<p>- Sebastian!
<p>- Não tem ninguém aqui dentro. Você está viajando.
<p>- É a Melissa?
<p>- Não.
<p>- É a Quinn então?
<p>- Também não.
<p>- Você tem sorte de eu estar muito atrasado. Eu posso ser um grande empata-foda quando eu quero. – Will sorriu. 
<p>- Não está acontecendo nada aqui. Não tem nenhuma foda para você empatar.
<p>- Agora, porque à noite deve ter acontecido muita coisa.
<p>- Will, sai daqui.
<p>- Já estou saindo.
<p>Will desceu as escadas de casa rindo enquanto Sebastian voltava para seu quarto.</p>
<center><h4>--*--</h4></center>
<p>Emily escolheu a trilha sonora ao ligar o rádio do carro e Will riu quando percebeu que a música não era tão ruim e que tinha sido uma boa escolha. 
<p>A viagem foi tranquila. 
<p>Jason repetiu várias vezes que havia treinado muito e que venceria a corrida. Ele arregalou os olhos quando chegaram no ponto de partida e havia mais umas dez mil pessoas ali mais ou menos junto com eles.
<p>Will olhava para as pessoas bem interessado. Havia gente ali de tudo quanto é tipo, novo, velho, magro, gordo, mas o que mais despertou seu interesse foi ver pessoas que não deveriam estar ali também prontos para “correr”, alguns estavam com muletas e pernas enfaixadas, alguns nem tinham uma das pernas ou as duas. Uns usavam toucas e chapéus para esconder a careca causada pela quimioterapia e Will se lembrou automaticamente de Angie. Embora estivesse ali por ela, fazia tempo que não parava para sentir falta dela como naquele momento. 
<p>- A gente se encontra na linha de chegada! – Jason gritou lá na frente já se posicionando.
<p>- Seu amigo é louco. – Emily riu enquanto falava com Will.
<p>- E olha que eu sou o competitivo da relação. – Will respondeu.
<p>- Você quer que eu corra devagar para te esperar? – Ela provocou.
<p>- Você não vai nem ver o que te atingiu. – Will brincou, pois sabia que seria o último a cruzar a linha de chegada.</p>
<center><h4>--*--</h4></center>
<p>Jason correu os primeiros vinte minutos sem ao menos respirar com dificuldade. Ele sempre foi muito bom em corrida. Não participava muito, ou melhor, nada, das atividades extracurriculares envolvendo esportes na escola por vários motivos. Todos aqueles atletas o olhavam como se ele fosse o mais demente possível e ele não gostava de se misturar com esse tipo de gente. Seu pai era capitão do time de basquete na sua época da escola e a última coisa que ele queria era fazer algo que seu pai também já fez. Ele preferia gastar seu tempo extra em coisas mais importantes como os seus estudos. 
<p>Ele parou em uma bancada de apoio onde serviam garrafas de água para os corredores. Pegou uma garrafa, bebeu alguns goles e jogou o resto no rosto. Depois voltou a correr. 
<p>Correr naquela maratona tinha sido meio que seu refúgio. Sempre que estava sozinho ou com a mente vazia, ele ia para a praia correr para treinar, mesmo que sem Will. Isso o mantinha ocupado e cansado. Chegava em casa e só dormia depois. 
<p>Embora dissesse que já estava tudo bem, seu pai ainda aparecia em seus pensamentos quando ele estava em silêncio e sozinho. Precisava fugir daquela sensação. Mas não sabia o que ia acontecer depois, depois da maratona, depois que voltar para a casa e não tiver mais o que pensar. Por um segundo, desejou correr para sempre. E ele sabia muito bem do que estava correndo.</p>
<center><h4>--*--</h4></center>
<p>Emily sempre correu desde criança. Seus pais moravam em uma fazenda bem no interior do estado e ela tinha muito espaço. Eram vários campos para cruzar e muito tempo de sobra para fazer isso. 
<p>Quando era mais nova, ela até pensou em seguir carreira, mas logo desistiu. Ela foi a viagem toda em silêncio. Sempre que Will parava de falar com Jason e perguntava para ela o que estava acontecendo, Emily fazia uma cara de sono e dava a desculpa que estava cansada, mas não era verdade. 
<p>Ela não chegou a treinar para aquela maratona, logo só pensou nela duas vezes durante aqueles meses. Quando se inscreveu e naquela manhã, quando Will a lembrou. 
<p>Ela passou a viagem toda pensando e lembrando de como estava no dia em que fez a inscrição. Estava se sentindo péssima e inútil e por um momento, fazer aquelas inscrições a ajudou, imaginou que estava fazendo algo de bom, algo de importante, mas aquele momento passou rápido. E enquanto corria, ela ainda se sentia uma inútil. Talvez não totalmente, mas o sentimento ainda estava lá.</p>
<center><h4>--*--</h4></center>
<p>Will desistiu nos primeiros cinco minutos como ele mesmo já havia previsto. Enquanto caminhava pela rua, ele pensava. Muitas coisas haviam mudado desde a morte de Angie. Algumas coisas para melhor, outras para pior. O que ela diria se soubesse que ele havia se apresentado em um lugar lotado de gente e que havia gostado? O que ela diria se soubesse que ele não falava direito com seu pai a mais de um mês?
<p>De algum modo, ele já sabia a resposta. Na verdade, até conseguia ouvir a voz dela na sua cabeça. Ele sorriu ao perceber que ainda se lembrava da voz dela e que meses atrás estava com medo de isso não acontecer.
<p>Will continuou caminhando sozinho em silêncio preso em seus pensamentos até perceber que o sol já estava se pondo e que logo o tempo máximo para o término da maratona acabaria.
<p>- O que aconteceu com você? – Jason e Emily vinham em sua direção. Eles, ao contrário de Will, estavam suados e cansados. 
<p>- Ficamos um tempão te esperando. – Emily parecia um pouco preocupada. – Achávamos que tinha caído no meio do caminho.
<p>- Para cair, eu precisaria correr. – Will brincou. – Eu definitivamente não sirvo para essas coisas.
<p>- Já eu terminei em vigésimo segundo lugar. – Jason falou como se tivesse conseguido o primeiro lugar e uma medalha de ouro.
<p>- Vamos para casa? – Emily sugeriu. 
<p>- Bora. – Will respondeu. – Eu ainda preciso cruzar a linha de chegada. 
<p>- Falta quatro quilômetros. – Jason riu.
<p>- Então deixa para lá.</p>
<center><h4>--*--</h4></center>
<p>- Pelo menos, dessa vez não foi a gasolina.
<p>Will, Emily e Jason estavam na recepção de um hotel de beira de estrada em algum lugar em Oceanside. O motor estava superaquecido e o carro havia parado. Já era tarde e nenhum serviço de guincho estava funcionando naquele horário. 
<p>- Mas tem um lado bom nessa história. – Emily assinava sua ficha de estadia. – Você não deve nada a ninguém agora e não precisa prestar contas a ninguém. 
<p>- E os custos do conserto vai tudo para a locadora do carro. – Jason completou.
<p>- Mas ainda vamos precisar passar a noite aqui e não é nenhum hotel cinco estrelas. – Will olhou em volta. Esse havia sido o primeiro que acharam enquanto caminhavam pela estrada. Não parecia ser muito grande, porém era limpo e iluminado e de acordo com a ficha de estadia, eles ofereciam o café da manhã incluso no valor da diária.</p>
<center><h4>--*--</h4></center>
<p>Will bateu na porta do quarto de Emily já passando da meia-noite. 
<p>- Nem em um hotel, você me dá uma folga? – Emily sorriu ao abrir a porta. Ela já estava de pijama e rosto lavado, pronta para dormir.
<p>- Na verdade, eu quase pedi um quarto só nosso.
<p>Ele caiu na cama. Mesmo não sendo de casal, aquela cama era maior que a da casa de Emily. 
<p>- Você não me contou como foi vencer a corrida.
<p>- E você não me contou porque desistiu dela. – Emily deitou ao lado dele.
<p>- Eu não desisti. 
<p>- Conheço você. Passaria pela linha de chegada morrendo, mas passaria. 
<p>- Ah, eu não estava muito a fim. Além do mais, isso não foi para ganhar, não é? Foi pela Angie. 
<p>- Eu pensei nela o dia todo.
<p>- Eu também. Foi bom. – Will suspirou. 
<p>- É, foi sim. – Ela concordou. – Eu liguei para o meu pai, você ligou para o seu? – Emily vivia jogando esse tipo de coisa para ver a reação de Will. Aquela briga dele com o pai a deixava bastante chateada.
<p>- Eu liguei para a Amanda. 
<p>- Will. Eu amo ter você toda noite dormindo comigo, mas... você precisa fazer as pazes com o seu pai.
<p>- Ou... eu já vi alguns anúncios de aluguéis, não são tão caros quanto eu pensei. Eu finalmente vou me formar no colegial, já vou fazer dezenove anos. Acho mesmo que já está na hora de sair de casa. – Will voltou com a ideia de ir morar sozinho.
<p>- Tem certeza?
<p>- Tenho, sim.
<p>- Sabe que eu vou te apoiar, não importa o que faça, não sabe?
<p>- Mas...
<p>- Ele é seu pai. E mesmo que você vá morar em outro lugar, você precisa falar com ele.
<p>- Eu vou falar com ele. Eu prometo. – Will sorriu para a namorada. – Vamos mudar de assunto agora?
<p>- Tudo bem. Já pensou o que vai fazer quando ficar famoso? Não vai mais precisar se preocupar com aluguel caro. 
<p>- É. Na verdade, vou tentar conseguir uma entrevista com a Oprah ou com o Jimmy Fallon ou com os dois. 
<p>- Eu estou falando sério. – Ela riu.
<p>- Eu também. – Ele riu junto. – Mas, na verdade, eu não sei. O plano sempre foi ser famoso, nunca pensei no que fazer depois. Até mês passado, eu achava que nunca cantaria em um palco, então... estou curtindo o momento por enquanto. E quanto a você? Nunca me contou sobre seus sonhos para o futuro. 
<p>- Teve uma época que eu quis ser professora. 
<p>- Professora, sério?
<p>- Por quê? Não me imagina ensinando?
<p>- Não é isso. Até porque minhas notas subiram por sua causa. E você é a pessoa mais estudiosa que eu já conheci. Mas eu estava pensando que você poderia ser, tipo, minha empresária.
<p>- Ah, eu adoraria também. – Ela riu fazendo uma careta negativa. 
<p>- Não que ser professora não seja algo incrível, quer dizer, deve ser o máximo saber que você é o responsável por educar um médico ou advogado ou o cientista que descobriu alguma lei de Newton, sei lá.
<p>- Mas...
<p>- Mas você pode ser essa cientista e criar uma lei com o seu nome. Primeira Lei de Emily. Eu gosto como isso soa. – Mesmo parecendo uma piada para Emily, Will não estava rindo. – Você pode não achar agora, mas eu conheço você e eu não te acho incrível só porque é minha namorada. Eu sei que você pode fazer qualquer coisa que quiser. 
<p>- Para.
<p>- Não, é sério. E eu vou estar lá para te aplaudir quando você ganhar o prêmio Nobel ou qualquer outro prêmio por descobrir a cura do câncer ou de qualquer outra doença e vou te dizer o quanto você é especial
<p>- Isso pode demorar um pouco.
<p>- Não importa, você me tem para sempre. Na verdade, eu estava até pensando em te chamar para... ir morar comigo. 
<p>- Estava pensando, é?
<p>- Estou, na verdade. – Will percebeu que Emily ficou surpresa. – Eu sei que vai dizer não e que vai dar a desculpa do seu pai e vai gaguejar e ficar pensativa, mas mesmo assim... Eu quero que saiba que você é a melhor coisa na minha vida já faz um tempinho e eu não vou parar de fazer planos para gente, mesmo que eles demorem. Afinal como eu já te disse...
<p>- Eu te tenho para sempre. – Ela sorriu. – O que vai acontecer se eu ganhar o prêmio Nobel na mesma noite que você ganhar seu Grammy? Como vamos nos aplaudir?
<p>- No meu discurso, eu vou dizer que devo tudo a uma mulher que está recebendo um prêmio Nobel em outro lugar e vou fazer todo mundo aplaudir essa mulher. 
<p>- E no meu discurso, talvez eu cite alguma música sua e comente sobre o Grammy e faça a plateia cantar em coro por alguns segundos. Eu vou estar recebendo um prêmio Nobel, vão fazer o que eu pedir. – Emily começou a fantasiar junto com Will.
<p>- E no final da noite, vamos nos encontrar e comemorar. Não só pelos prêmios, mas por estarmos juntos depois de tudo. 
<p>- Eu te amo. – Emily o beijou. – E você também me tem para sempre.
<p>- Isso é uma promessa, não é? – Ele pegou o dedinho mindinho dela e cruzou com o seu. – Um tempo atrás fizemos uma promessa de nunca ir embora. Mesmo a gente se perdendo às vezes, nunca fomos embora completamente. 
<p>- E não vamos. 
<p>- Não. Vamos estar aqui amanhã e depois de amanhã e todos os dias da nossa vida. – Ele retribuiu o beijo.
<p>- Sabe, eu... eu quero fazer uma coisa.
<p>- Agora? – Will arregalou os olhos. - Não pode ser amanhã? Já está tão tarde e eu não estou muito a fim de sair desse quarto agora e...
<p>- Cala a boca. – Emily tapou a boca de Will com a mão. – Não precisamos sair do quarto.
<p>- Como assim? 
<p>- É sério que eu vou ter que te explicar o que eu quero? - Emily ficou por cima de Will.
<p>- Você... você tem certeza? – Will ficou ainda mais surpreso. – Não estamos em um lugar especial nem em uma hora especial, não têm velas nem...
<p>- Não interessa. 
<p>- Mas precisa ser como você imaginou.
<p>- Está sendo como eu imaginei. Você está aqui e eu nunca estive tão apaixonada.
<p>- Mas por que agora? – Will ainda não entendia. 
<p>- Porque eu te amo, Will.
<p>- Eu também te amo, Ems.</p>
<br>
<p>“O melhor momento da minha vida. Isso é tudo o que eu consigo dizer. O para sempre nunca fez tanto sentido como naquela hora. Nada fez tanto sentido como naquela hora. 
<p>É engraçado como o momento simplesmente se torna o melhor depois de uma escolha. Você nunca sabe quando vai acontecer até estar acontecendo. 
<p>O melhor momento da sua vida...”.</p>
</body>
</html>";
            }

            if (numero == 36)
            {
                lblTitulo.Text = "Capítulo 36 - Tudo Está Nas Cicatrizes";
                htmlPage.Html = @"<html>
<body>
<p><i>“Se eu pudesse ter só uma noite
<br>Para ficar com você, consertar as coisas
<br>O que fomos, o que somos
<br>Está escondido nas cicatrizes
<br>Se eu pudesse te levar lá
<br>Não vou deixar passar, isso eu juro
<br>Você não terá que se perguntar o que somos
<br>Porque não terá sempre que olhar para muito longe
<br>Tudo está nas cicatrizes”
<br><b>Scars - Miley Cyrus</b></i></p>
<br>
<p>Will olhou seu celular ainda na tela de bloqueio. Já passavam das dez da manhã. Ele havia pegado no sono de novo e dormiu mais do que o planejado. 
<p>Emily se mexeu ao seu lado. Ele se levantou da cama com muito cuidado para não a acordar e foi em busca de sua camiseta que deveria estar em algum lugar no chão. Ele não queria ter que sair do quarto sem camisa de novo. 
<p>- Para onde você vai? – Emily falou baixinho ainda de olhos fechados.
<p>- Buscar alguma coisa para gente comer. Acho que aqui não tem serviço de quarto. – Will sorriu. 
<p>- Que horas são? – Emily procurou pelo celular, mas não o encontrou perto da cama. 
<p>- São quase onze.
<p>- O quê? – Ela levou um susto. – A gente tem que ir. – Ela se levantou com o lençol cobrindo seus peitos. 
<p>- Relaxa, hoje é domingo.
<p>- Mas o Jason...
<p>- Ele passou aqui mais cedo. Pedi para ele ir até a oficina onde o guincho deixou o carro e voltar para Los Angeles com ele.
<p>- Mas...
<p>- Eu já disse. Hoje é domingo. A gente arranja outro carro até à noite.
<p>- Bom... Então por que não volta para cama? – Emily se deitou novamente.
<p>- Porque eu estou com fome, você não?
<p>- Um pouco, mas posso aguentar. – Ela deu um meio sorriso um pouco provocante.
<p>- Se você está dizendo. – Will desistiu da sua busca pela camiseta e voltou para a cama. – Você está bem?
<p>- Eu estou ótima. – Agora ela deu um sorriso completo.
<p>- Só me diz uma coisa, o que exatamente eu disse ontem para você querer... eu poderia ter dito isso antes, tipo, um ano atrás. – Will começou a rir.
<p>- Cala a boca. 
<p>- Tudo bem, se eu disser, obrigado?
<p>- Mas o prazer foi meu.
<p>- De nós dois, na verdade. – Will a abraçou.
<p>- Espera um pouco, estamos no meio do nada, como vamos achar outro carro para alugar?
<p>- Quer mesmo se preocupar com isso agora? – Ele começou a beijar o pescoço dela.
<p>- Achei que você estava com fome. – Emily começou a rir.
<p>- Mudei de ideia.
<p>O celular de Will começou a vibrar no criado-mudo.
<p>- Seu celular está tocando. 
<p>- Eu estou muito ocupado para atender.
<p>Os beijos não estavam mais no pescoço de Emily quando o celular parou de tocar.</p>
<center><h4>--*--</h4></center>
<p>- Temos que conversar.
<p>Robert entrou no quarto de Kevin sem ao menos bater na porta. Seu filho estava deitado na cama com fones de ouvido e com sua atenção voltada para a tela do celular.
<p>- A porta estava fechada. Gostaria de alguma privacidade aqui. – Kevin nem olhou para o pai. 
<p>- Onde esteve noite passada? – Robert cruzou os braços e ficou parado em frente a porta com uma expressão de fúria no rosto.
<p>- Aqui no meu quarto. Estou de castigo, esqueceu?
<p>- Não, eu não esqueci. Por isso mesmo estou perguntando onde você estava. Porque em casa que não era. 
<p>- Eu precisava resolver umas coisas. Foi rápido, eu achei que...
<p>- Que parte do castigo você não entendeu? – Robert pegou o celular da mão de Kevin à força.
<p>- Não foi nada demais. – Kevin finalmente olhou para o pai e sua cara era de repulsa. – Larga do meu pé.
<p>- Da última vez que eu “larguei do seu pé”, você se meteu em problemas, e grandes.
<p>- Eu já disse que isso não vai mais acontecer. Quantas vezes eu preciso me desculpar?
<p>- Até você perceber que o que fez foi errado. 
<p>- Eu já percebi. 
<p>- Parece que não. Onde esteve ontem? Eu não vou repetir a pergunta.
<p>- Estava em uma festa. Está satisfeito?
<p>- Festa de quem?
<p>- Eu não sei. Eu recebi o convite e fui. Não pergunto quem deu a festa, eu só curto. 
<p>- Eu vou precisar colocar grade na sua janela e trancar sua porta depois do jantar? – Robert fazia de tudo para não gritar. Não queria que sua esposa ouvisse. 
<p>- Você nunca fez isso com o Sebastian, por que vai fazer comigo? Eu não sou o filho viciado aqui.
<p>- Mas é o filho que negocia com agiotas e desaparece sem dar notícias.
<p>- Will também sumiu. Cadê você chamando a polícia para ir atrás dele? – Kevin começou a desafiar o pai. – Não enche.
<p>- Garoto, olha como você fala comigo. Eu ainda sou o seu pai. 
<p>- Você não tem uma reunião para ir ou uma viagem para fazer? Vai cuidar de quem se importa. Eu não preciso de você.
<p>- Kevin...
<p>- Eu estou de castigo. Não posso sair do meu quarto nem falar com ninguém que não seja a respeito da escola. O que você quer falar comigo não tem nada a ver com a escola. Pode sair então? Não quero quebrar o castigo. 
<p>- Kevin, você é só uma criança, por isso eu vou relevar o que está dizendo. Tudo o que eu quero é você longe de problemas. 
<p>- Que problemas eu teria no meu quarto?
<p>- Você acabou de confessar que foi a uma festa. O que fez lá? – Robert sabia que o filho estava metido em mais problemas do que ele havia contado. 
<p>- Eu me diverti. Dancei, beijei a minha namorada, conversei com pessoas... O que mais quer que eu diga?
<p>- Eu cometi um erro não sendo rígido com você e pretendo repará-lo. 
<p>- Vai cuidar do filho com problemas com drogas ou com o que não aparece mais em casa quando você está e me deixa em paz. – Kevin o encarou. – Poderia devolver meu celular agora?
<p>Robert observou seu filho por mais alguns segundos. Sua vontade era de pegá-lo pelo braço e chacoalha-lo até ele criar juízo, mas ao invés disso, só saiu do quarto com o celular firme em sua mão.</p>
<center><h4>--*--</h4></center>
<p>- Que horas são?
Melissa acordou assustada. 
<p>- Quase meio-dia. – Sebastian olhou o despertador no criado-mudo ao lado da cama, ainda com os olhos embaçados.
<p>- Nossa, a gente dormiu demais. – Melissa se levantou da cama correndo. Ela pegou sua calça jeans que estava jogada no chão e a vestiu.
<p>- Que pressa é essa? – Sebastian franziu a testa.
<p>- Eu estou pensando em como sair dessa casa sem ser notada a uma hora dessas.
<p>- Quase impossível. – Sebastian nem se deu ao trabalho de se levantar da cama. 
<p>- Mas que droga! Você devia ter me acordado mais cedo. – Melissa estava brava. 
<p>- Podemos descer e tomar café. Ou talvez almoçar. – Sebastian sorriu. Toda vez que Melissa ficava para dormir, ele tentava convencê-la a sair do quarto na manhã seguinte para que todos a vissem 
<p>- Sem chance. Isso nem deveria ter acontecido. – Ela começou a procurar por sua blusa por toda parte.
<p>- Está dizendo isso há muitos dias. E continua acontecendo. 
<p>- Isso é tão errado. – Melissa continuava andando de um lado para o outro. 
<p>- É por isso que você não quer contar para ninguém? Olha, eu não sei mentir muito bem. Will quase me pegou ontem. 
<p>- Isso é um pesadelo.
<p>- Qual é o problema?
<p>- Eu não faço essas coisas, tá bom? Eu não sou de... – Ela nem sabia qual era realmente o problema. Ela estava reclamando desde que acordou, mas tinha certeza que aconteceria tudo de novo em outra noite. Uma noite bem próxima. 
<p>- Você tinha que relaxar. Eu também não sou de fazer isso, mas... aconteceu. 
<p>- Você me seduziu.
<p>- Isso não é verdade. – Sebastian começou a rir.
<p>- É sim. – Ela jogou a camiseta de Sebastian, que estava no chão, na cara dele. – Se veste, a gente precisa bolar algo para eu poder sair daqui.
<p>- Então diz que não foi um erro. – Ele a desafiou.
<p>- Sebastian, não começa. 
<p>- Tudo o que eu sei é que eu te chamei para estudar e você não trouxe livros. 
<p>- Será que eu consigo pular essa janela? – Ela abriu a janela do quarto, porém a queda era grande e a abertura era estreita demais. 
<p>- Você pode ficar aqui e esperar todo mundo sair. Talvez não demore.
<p>- É domingo. Ninguém sai de casa no domingo.
<p>- Então... – Sebastian se levantou, ele ainda estava de cueca. – Pode ficar aqui até saírem na segunda de manhã.
<p>- Eu não posso... – Ele se aproximou mais dela e a pegou pela cintura. – Viu? Eu disse que a culpa era sua por tentar me seduzir. 
<p>- Eu aceito a culpa e com prazer. – Ele sorriu.
<p>- Ai, eu odeio você. – Melissa voltou a tirar a calça. – Já que vamos ficar presos aqui por um tempo, acho melhor fazermos algo de útil.
<p>- Eu concordo. 
<p>Os dois voltaram para a cama.
<p>- Só me diz uma coisa antes, como exatamente eu te seduzi? – Sebastian riu.
<p>- Você simplesmente fez. Agora cala a boca e vamos aproveitar o tempo que temos. 
<p>- Nem precisa dizer duas vezes.
<p>Eles começaram a se beijar tentando fazer o mínimo de barulho possível. Não queriam ser pegos.</p>
<center><h4>--*--</h4></center>
<p>- O que você está pensando?
<p>Will e Emily estavam deitados na cama em silêncio já fazia um bom tempo. Eles haviam pedido dois lanches enormes em uma lanchonete delivery, comeram e depois voltaram para a cama. A janela estava aberta ao máximo e a luz do sol estava iluminando o quarto todo.
<p>- No que mudou. – Emily estava mesmo bem pensativa. 
<p>- Como assim?
<p>- Acho bom que você seja o homem da minha vida, senão um dia eu vou me arrepender. 
<p>- Ah, é. Eu me esqueci que você é quase a Virgem Maria. – Will riu. 
<p>- Quase.
<p>- Está arrependida agora?
<p>- Você sabe que não. Na verdade, eu não quero sair dessa cama nunca mais. 
<p>- Eu posso fazer com que isso aconteça. – Os dois começaram a rir. 
<p>Os dois voltaram a ficar em silêncio e Emily começou a observar o namorado como se nunca tivesse o visto antes. 
<p>- O que é isso aqui? – Ela colocou a ponta de seu dedo indicador em uma cicatriz no ombro direito de Will.
<p>- Ah, eu ganhei essa cicatriz quando eu era pequeno. Acho que onze, doze anos. 
<p>- O que aconteceu? Caiu do parquinho?
<p>- Antes fosse. Eu briguei na escola. Estavam roubando o lanche do Jason. Na época, eu achava que quando as pessoas sabiam que você não tinha pai, também achavam que ninguém ia te proteger, só que...
<p>- Estavam enganados. 
<p>- É. Resumindo, quando eu me virei para dar um soco em um, o outro meteu uma pedra no meu ombro. Precisei de sete pontos. 
<p>- Que horror.
<p>- É, crianças podem ser malvadas. – Will riu. 
<p>- Como consegue se divertir com isso? Eu ainda tenho pesadelos quando lembro da briga que eu tive com a Giovanna. 
<p>- Ah, a situação é completamente diferente. Eu também tenho pesadelos quando me lembro que bati no Kevin.
<p>- Duas vezes.
<p>- Duas vezes. 
<p>- Acha que...
<p>- Eu não quero falar do Kevin, pelo menos não hoje. 
<p>- Do que quer falar então?
<p>- Sabia que eu tenho uma cicatriz no joelho também? 
<p>- Levou uma pedrada de quem dessa vez? – Emily riu. 
<p>- Não, eu caí tentando aprender a andar de skate. Tinha uma garota, ela era muito gata, mas só andava com skatistas, então eu... foi um desastre.
<p>- Eu imagino. 
<p>- Mas no final, o que valeu foi a intenção.
<p>- Nossa. Garotos são tão idiotas.
<p>- Ah, qual é? Você nunca fez nada de diferente para tentar conquistar um garoto? 
<p>- Ah, eu... – Emily ficou vermelha de vergonha. – Eu já pintei meu cabelo de azul. 
<p>- Você virou emo? – Will fingiu ficar boquiaberto.
<p>- Não foi bem isso. Ele gostava de garotas com cabelo colorido e com maquiagem preta. Foi ridículo e infelizmente, não teve um fim tão bom quanto o seu.
<p>- O que aconteceu?
<p>- Meu cabelo ficou horrível. 
<p>Will começou a gargalhar. 
<p>- Para de rir, não é engraçado. 
<p>- É um pouco sim. 
<p>- Eu não conto mais nada para você. – Ela fingiu ficar emburrada. – Sabe, eu sempre me perguntei se era verdade a história de que não precisamos mudar nada na gente, porque sempre vai ter alguém que vai nos aceitar como somos. 
<p>- É, mas na adolescência, essa é a coisa mais difícil de acreditar. 
<p>- É.
<p>- Só para você saber, eu me apaixonaria por você de cabelo azul também. 
<p>- E olha só, eu te amo e você nem sabe andar de skate.</p>
<center><h4>--*--</h4></center>
<p>- Eu já estou ficando cansada de esperar. Minha mãe já me ligou umas quatro vezes. – Melissa riu olhando para o celular. 
<p>- Bom, eu não estou escutando barulhos. Quer arriscar? – Sebastian sorriu.
<p>- Você devia sair e ver se a barra está limpa.
<p>- Eu nem estou vestido. Da última vez que eu fiz isso, o Will me pegou. 
<p>- Antes você do que eu.
<p>- Olha, já está ficando tarde. – Sebastian tinha razão. Já havia passado das seis da tarde. – Você pode ir ou pode ficar.
<p>- Como assim ficar? – Melissa levantou uma de suas sobrancelhas. 
<p>- Ah, sei lá. Concordamos com uma noite só, que não iria significar nada, que continuaríamos amigos, mas aí... foi mais do que uma noite. Continua sendo, na verdade. Por quanto tempo vamos fazer isso? 
<p>- Sebastian...
<p>- Eu prefiro quando me chama de “Seb”, você parece mais...
<p>- Para. – Ela sorriu um pouco sem graça. 
<p>- Eu não sei o que está acontecendo com a gente e eu não posso pedir ajuda para alguém para tentar entender porque você quer segredo. É só sexo? Porque se for...
<p>- Não é só sexo.
<p>- Então...
<p>- Eu não sei.
<p>- Parece até que estamos fazendo algo de errado.
<p>- Talvez estejamos.
<p>- Somos duas pessoas solteiras que não devem nada a ninguém. Se você quer só diversão, ótimo, eu topo, mas se você quer outra coisa, algo sério, me avisa, porque eu topo também. 
<p>- Que tal não falarmos sobre isso agora?
<p>- Uma hora a gente vai ter que falar. 
<p>- Olha, não é nada com você. É que... eu não tenho muitas experiências boas com namoros. Na verdade, eu só tenho experiências ruins.
<p>- Eu realmente queria dizer que essa vai ser uma experiência boa, mas a minha baixa autoestima não deixa. 
<p>Melissa sorriu e depois disso o beijou.
<p>- Achei que a terapia estava ajudando.
<p>- E está, mas não cem por cento. Às vezes eu acho que nunca vou ficar cem por cento. Uma vez viciado, sempre viciado.
<p>- Não é verdade. 
<p>- Sabe, eu tenho um corte aqui na barriga. – Sebastian apontou para uma pequena cicatriz perto da costela. – Os médicos fizeram uma vez para colocar um tubo. Meu coração estava quase parando de bater. 
<p>- Deve ter sido horrível. 
<p>- Eu só me lembro de usar e depois acordar no hospital. Horrível foi para as pessoas que ficaram esperando eu acordar. 
<p>- Eu sinto muito. Se eu pudesse tirar isso de você, eu tiraria. 
<p>- Não precisa dizer isso. 
<p>- Preciso sim, senão daqui a pouco eu vou ouvir a sua história de “ficar comigo não é bom para você”, “eu estou tentando te proteger” e blábláblá.
<p>- É, eu ia chegar lá mesmo. 
<p>- Sabe, essa sua cicatriz e essa história servem para mostrar que você já passou pelo pior e mesmo assim não desistiu.
<p>- Eu não posso desistir. Will sempre me fala que me mataria se eu morresse. – Sebastian soltou um riso. – Eu tenho uma família, amigos e...
<p>- A mim. 
<p>- Eu tenho você?
<p>- Por completo.</p> 
<br>
<p>“Quantas vezes você já fez algo que deixou alguma marca? Aquele momento onde algo que você fez mudou o caminho das coisas. Algo que fez a diferença na vida de alguém. 
<p>Você já cometeu erros, tentou apagá-los e não conseguiu? Você já jogou tudo para o alto, deixou para lá e foi viver a sua vida? Já deixou para lidar com as consequências depois? 
<p>Toda ação causa uma reação, uma consequência, uma marca, talvez uma cicatriz. Você pode tentar se esquecer dela, pode aceitá-la, pode sentir orgulho ou vergonha, mas ela sempre vai estar lá, não some, talvez fique pouco perceptível com o tempo, mas sumir completamente? Nunca. Cada cicatriz guarda uma história, talvez de luta, de vitória, de derrota, de empate. Cada cicatriz te ensina o que fazer na próxima vez, repetir ou não o erro.
<p>Você gostaria de apagar as suas cicatrizes? E eu não estou falando de cirurgias plásticas, porque nesse caso, mesmo apagadas, você saberia que ela já esteve lá. Eu estou falando de apagá-la por completo, até da sua memória. Você esqueceria os momentos, o que a causou e estaria propenso a fazer tudo de novo várias vezes. Onde isso poderia te ajudar?”.</p>
<br>
<p>O telefone de Will começou a tocar. 
<p>- É um sinal de que precisamos ir embora. – Emily falou no ouvido do namorado. 
<p>- Mas essa cama está tão confortável. – Will se espreguiçou. – Deve ser o Jason querendo saber se vamos voltar logo. 
<p>- Precisamos comprar uma passagem de ônibus. 
<p>- Ele bem que podia voltar e nos buscar. – Will riu. 
<p>- Para de choramingar e atenda. – Ela mandou.
<p>- Eu vi que o seu pai te ligou umas mil vezes hoje, por que eu tenho que atender as minhas ligações e você não precisa atender as suas?
<p>- Porque o mundo é das mulheres, atende agora. 
<p>- Eu vi que aqui tem uma banheira. Poderíamos ir para lá. 
<p>- Will, pode ser importante.
<p>- Se for importante, a gente vai ter que ir embora e eu não quero ir embora. Quero continuar com a nossa Lua de Mel.
<p>- Lua de Mel? – Emily riu.
<p>- Antecipada, ué?
<p>- Atende logo isso, eu também não quero ir embora, mas...
<p>- Tudo bem. – Will olhou para a tela do celular. – É a Amanda. Mandy?
<p>- <i>Will, cadê você?</i> – Amanda estava nervosa.
<p>- Calma, o que houve? Eu te avisei que...
<p>- <i>Não interessa. Vem para o hospital agora.</i>
<p>- Hospital? – Emily também se assustou com essa palavra. – O que aconteceu com você?
<p>- <i>Eu estou bem. É o Sebastian.</i>
<p>- De novo? – Will sentiu um frio na espinha.
<p>- <i>Vem logo. É ruim, Will. É muito ruim.</i></p>
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
            if (condicao+1 > 36)
            {
                Navigation.PushModalAsync(new Capitulo7Page(condicao + 1));
            }
            else
            {
                Navigation.PushModalAsync(new Capitulo6Page(condicao + 1));
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