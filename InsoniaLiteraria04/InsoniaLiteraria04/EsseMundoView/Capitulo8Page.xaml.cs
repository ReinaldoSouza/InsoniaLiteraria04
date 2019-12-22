using System;
using InsoniaLiteraria04.Database;
using InsoniaLiteraria04.Global;
using InsoniaLiteraria04.Helper;
using InsoniaLiteraria04.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InsoniaLiteraria04.EsseMundoView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Capitulo8Page : ContentPage
    {
        DBFire service;
        public int condicao;
        public Capitulo8Page(int numero)
        {
            InitializeComponent();
            service = new DBFire();
            condicao = numero;
            mostrarCapituloSalvo("EsseMundoVaiMudar", "Capitulo" + numero.ToString());

            if (numero == 43)
            {
                lblTitulo.Text = "Capítulo 43 - Fuja Como Um Criminoso";
                htmlPage.Html = @"<html>
<body>
<p><i>“Fuja, fuja 
<br>Como um criminoso
<br>Não espere por mim
<br>Não espere por mim
<br>Com vergonha, com vergonha
<br>Mas preciso tanto de você
<br>E você espera por mim
<br>E você espera por mim”
<br><b>Prodigal - OneRepublic</b></i></p>
<br>
<p>Will tinha acabado de dizer suas últimas palavras. Não iria mais insistir nem tentar convencê-la, o que ela dissesse naquele momento, ele aceitaria. Na verdade, ele estava tentando dizer a si mesmo que ela o amava e que mesmo que dissesse “não”, e ela iria dizer, não significaria que não o amasse, nada iria mudar entre os dois, só não se casariam, certo? 
<p>- Falar alguma coisa agora seria bom.
<p>- Wil, eu... – Emily respirou fundo. 
<p>- Olha, vamos deixar isso para lá agora. Vamos esquecer por enquanto. – Will já estava jogando a toalha. – Eu meio que falei por impulso. Vamos pensar nisso, eu penso, você pensa e aí quando tivermos mais certeza da resposta... Tudo isso agora é uma grande loucura.
<p>- Sim.
<p>- É. É uma loucura. – Ele concordou.
<p>- Não, seu idiota. Eu disse “sim”. 
<p>- Sim?
<p>- Sim, eu quero me casar com você.
<p>- O quê? É sério? Mas... – Will quase se beliscou achando que era um sonho. Em nenhuma maneira que ele imaginou aquela conversa acabando, acabaria assim. – Você aceitou. 
<p>- Eu aceitei.
<p>- Você é maluca? – Will riu um pouco assustado.
<p>- Tanto quanto você. – Ela estava um pouco sem ar de tanto nervoso. – Eu agora pediria para você colocar o anel no meu dedo, mas...
<p>- Ele já está aí... Eu te amo.
<p>- Eu também te amo.
<p>- Vamos nos casar. – Will começou a rir da loucura que era ouvir aquelas palavras.
<p>- Vamos nos casar. – Emily se juntou aos risos, depois pulou em seus braços de entusiasmo e o beijou.</p>
<center><h4>--*--</h4></center>
<p>Will e Chris estavam na saída do aeroporto esperando pelo <i>Uber.</i>
<p>Tinha sido uma semana bem interessante. Chris havia finalmente entregado o celular para Will e ele percebeu que nem havia sentido falta. Os dois estavam diferentes. 
<p>Chris estava feliz como nunca esteve e mal conseguia esperar para contar para todo mundo. Sebastian ficaria feliz por ele, sabia disso. Quinn era maravilhosa. Nada poderia dar errado.
<p>Will também estava feliz, mas acima disso, estava muito nervoso. Quatro dias atrás, ele havia pedido a mão de Emily em casamento e para o seu terror, ela havia aceitado. Os dois não tiveram oportunidade de falar sobre o assunto com os pais de Emily naquela casa cheia, embora tivessem agradecido por isso. Pretendiam fazer algo para juntar os pais dela com os dele e contar tudo de uma vez só. 
<p>- Você tem certeza que o Sebastian não vai se importar, não é? – O entusiasmo e a coragem de Chris iam e voltavam a todo instante.
<p>- Ele está com a Melissa, Chris. Relaxa. – Will já estava cansado de repetir.
<p>- Eu sei, mas...
<p>- Mas nada. Para de graça.
<p>- Eu tenho um discurso. Eu o criei todo enquanto estávamos no avião. Posso treinar com você?
<p>- Obvio que não. Eu não vou perder dez minutos da minha vida ouvindo você pedindo perdão por finalmente ter se dado bem com uma garota.
<p>- Mas... 
<p>- Na verdade, eu que preciso te dizer uma coisa. – Will ficou sério.
<p>- O que foi? – Chris se assustou com a expressão do irmão.
<p>- Olha, para deixar claro, você vai ser o primeiro a saber e precisa prometer que não vai contar para ninguém até eu contar.
<p>- Tudo bem. Eu prometo.
<p>- Ótimo. – Will começou a bater o pé direito no chão várias vezes para tentar disfarçar o nervosismo, mas isso só demostrava mais. – Eu pedi a Emily que... se casasse comigo. Foi depois da festa de aniversário dela.
<p>- O quê?
<p>- E ela disse “sim”.
<p>- O QUÊ?! – Chris deu um grito tão alto que as pessoas que estavam passando perto deles se assustaram. – Você por acaso ficou louco? Não podem se casar.
<p>- Por que não?
<p>- Porque são jovens e desestruturados e... é loucura.
<p>- Chris, eu sei de tudo isso, tá bom? Mas não há nada que você possa falar que vai me fazer mudar de ideia.
<p>- Mas, Will...
<p>- Eu a amo e quero passar o resto da minha vida com ela.
<p>- Como acha que nossos pais vão reagir?
<p>- Eu não dou a mínima para isso.
<p>- Você nem terminou o colegial.
<p>- Eu tenho um emprego e ganho bem. Eu consigo fazer isso. Eu quero fazer isso. – Contar para o irmão não havia diminuído o nervoso como Will imaginava, mas transformava tudo aquilo que ele não parou de pensar nesses quatro dias em uma coisa mais real e concreta. 
<p>- Olha... – Chris hesitou. Se eles tivessem tido aquela conversa um ano atrás, Chris com certeza ia rir da cara do irmão e soltaria comentários sarcásticos e irônicos de como Will mal conseguia cuidar de uma tartaruga se tivesse. – Eu não vou dizer que é a sua melhor escolha, mas...
<p>- Não vou receber um sermão e gritaria do quanto eu sou louco?
<p>- Eu vou te apoiar. Se é o que quer fazer e se acha que vai conseguir fazer, eu vou te apoiar.
<p>- Valeu. 
<p>- Ela disse sim mesmo? – Chris abriu um sorriso.
<p>- Disse. – Will sorriu também e os dois se abraçaram.</p>
<center><h4>--*--</h4></center>
<p>Chris jogou as malas no pé da escada. Estava morrendo de sede. Iria para a cozinha beber alguma coisa primeiro para depois subir para o quarto e desfazer as malas.
<p>- Mãe! Pai! – Will gritou no pé da escada e depois foi até a sala. – Amanda! Kevin! Chegamos. – Ninguém respondeu. A casa parecia estar vazia.
<p>- Será que estão preparando uma festa de boas-vindas para gente? – Chris voltou da cozinha com um copo de água na mão. 
<p>- Eu duvido. – Will pegou o celular no seu bolso e o ligou pela primeira vez desde a viagem. – Trinta e duas chamadas perdidas? Achei que tínhamos avisado que íamos viajar. – Will arregalou os olhos para a tela do seu celular. – Ligaram para você também?
<p>- Eu não sei, eu... – Chris havia ligado o celular bem rápido no aeroporto e pedido o Uber, logo após isso colocou seu celular no bolso e nem prestou atenção nas notificações. – É, tem muita chamada perdida aqui também. – Ele começou a olhar suas notificações. – E mensagens de texto. 
<p>- Que estranho. – De repente, Will sentiu um frio no estomago. Isso não parecia nada bom. 
<p>Os dois subiram as malas para seus respectivos quartos. Estava tudo normal lá em cima. Os quartos estavam exatamente como eles deixaram uma semana atrás. O quarto de Kevin estava trancado, o de Amanda e de Sebastian estavam entreabertos e dos pais, a porta estava só encostada. 
<p>Will pegou o telefone novamente para discar o número de Amanda quando ele ouviu do primeiro andar a porta do hall de entrada se abrir. Ele desceu correndo as escadas com Chris em seus calcanhares e deram de cara com Amanda e Jason. Os dois pareciam cansados e muito preocupados. Ficaram bem surpresos quando viram que a casa não estava vazia.
<p>- Vocês chegaram. – Amanda respirou fundo. – Tentei ligar para vocês feito louca.
<p>- O que houve? A gente acabou de chegar. Cadê todo mundo? – Will perguntou já com medo da resposta. Pelo estado físico que aquele casal se encontrava, eles não traziam boas notícias. 
<p>- O Sebastian está bem? – Chris também estava assustado. 
<p>- Estamos vindo do hospital. Ele está bem. – Jason tentou nos acalmar. – Só viemos para...
<p>- Eu vou trocar de roupa. Só vim para isso. – Amanda falou.
<p>- Gente, o que está acontecendo? – Will perguntou de novo. 
<p>- Acho melhor vocês se sentarem. – Jason começou a enrolar.
<p>- Eu não quero sentar. Eu quero saber o que está acontecendo. – Will odiava aquela enrolação. Ainda mais quando parecia que o assunto era sério. – O que houve?
<p>- É o Kevin. – Amanda finalmente falou. – Ele apareceu aqui em casa totalmente drogado dois dias atrás. Papai quase bateu nele, se a mamãe não tivesse intervindo...
<p>- Só isso? – Chris ficou mais aliviado. – Isso já aconteceu. Quer dizer, no dia que o Sebastian foi baleado, ele estava aqui bêbado. Eu que tive que levar ele para o quarto. 
<p>- É, mas... – Amanda não parecia tão aliviada quanto o irmão. – Ele fugiu ontem à noite, pulou a janela. A polícia acabou de encontrar ele no East. Ele quase foi fichado. A sorte é que o policial é conhecido do nosso pai e concordou em não o levar para delegacia contanto que ele fosse para algum centro de reabilitação. É isso que nossos pais estão fazendo agora. Estão internando ele no centro comunitário. 
<p>- O quê? – Will aceitou o conselho de Jason e se sentou no primeiro degrau da escada.
<p>- Mas isso é bom, não é? Pelo menos, vamos acabar com isso antes que saia do controle. Nossos pais deveriam ter tomado uma providencia bem antes. Talvez na época do agiota. O transtorno seria menor. – Chris continuou calmo. Ele sabia que aquilo era a melhor escolha naquele momento. 
<p>- Tem mais, não tem? – Will olhou para Jason. – O que não estão nos contando?
<p>- Na tarde que o Sebastian foi baleado... – Jason começou a falar com lágrimas nos olhos. – Ele estava seguindo o Kevin e o viu com o traficante. Seb abordou os dois, o cara achou que ele era da polícia e atirou. 
<p>- Impossível. – Chris fez que não com a cabeça.
<p>- Não foi o Kevin que chamou a emergência, não é? – Will colocou o rosto nas mãos e abaixou a cabeça.
<p>- Esperem um pouco. Estão me dizendo que o Kevin viu o Sebastian sendo baleado e não fez nada? Nem chamou a emergência? E nem contou para ninguém? – Chris finalmente havia ficado nervoso. – Isso não é verdade. 
<p>- Você mesmo disse que naquele dia ele estava bêbado. – Amanda segurou a mão do irmão que parecia estar bem abalado. 
<p>- Kevin é nosso irmão. Ele nunca... ele nunca veria o Sebastian morrendo e iria embora. Não. – Chris não conseguia acreditar naquela história. – Não. 
<p>- Por isso que o Sebastian não quis falar para gente o que aconteceu. – Will falou baixinho ainda com a cabeça baixa.
<p>- Ele só nos contou ontem. – Jason falou. – Depois que soube que o Kevin fugiu de casa. Achou que seria mais fácil a gente procurar se soubéssemos onde ele andava indo. 
<p>- Eu avisei tanto. – Will começou a chorar. – Eu gritei, eu... eu só piorei as coisas.
<p>- Isso não é verdade. – Amanda estava abalada por ter contado a história. Era como se estivesse vivenciando tudo de novo. – Você fez muito, mas não era o seu dever ajudar.
<p>- Somos irmãos, Mandy. Se a gente não se ajudar, quem vai? Ele só uma criança. 
<p>- É, que cresceu rápido demais. – Amanda completou com amargura na voz.</p> 
<center><h4>--*--</h4></center>
<p>- Eu posso entrar?
<p>Chris bateu na porta do quarto de hospital onde Sebastian estava internado e mostrou seu rosto.
<p>- Chris? – Sebastian se animou. – Claro, entra aí. – E se arrumou na cama para tentar ver o irmão no mesmo nível. 
<p>- Como você está? – Chris se aproximou do irmão e passou a mão no cabelo dele como um cumprimento.
<p>- Melhor. Não posso me mexer muito, mas... o médico disse que se minha recuperação continuar nesse ritmo, posso sair daqui em uma semana. 
<p>- Isso é ótimo. 
<p>- É. – Mas Sebastian não parecia tão feliz. – Que bom que voltaram. Soube do Kevin? 
<p>- Sim. – Chris respirou fundo.
<p>- E quanto ao Will?
<p>- É, ele também. – Chris tentou falar calmamente. – Está em casa tentando digerir tudo isso.
<p>- E como você está?
<p>- Pelo menos não fui baleado. Se ele não tivesse fugido, você ia contar a verdade?
<p>- Para falar a verdade, eu não sei. Acho que os irmãos Jones têm problemas com guardar segredos para proteger uns aos outros. 
<p>- É, nós temos. E já que estamos falando de segredos e “contar”... Não sei se é a melhor hora, mas... eu não queria esconder isso de você.
<p>- O que foi? – Sebastian franziu a testa. 
<p>- Aconteceu uma coisa em Nashville. Quer dizer, aconteceu várias coisas e logo vai saber da maioria, mas tem essa coisa que... Quinn e eu acabamos que... ficando juntos.
<p>- Sério?
<p>- É, eu sei, é totalmente errado. Eu sinto...
<p>- Chris, está tudo bem. – Sebastian sorriu. – Tudo bem, a gente terminou.
<p>- Mas é sua ex. Eu não quero o mesmo clima que foi quando o Kevin começou a namorar a Giovanna e...
<p>- Não tem nada a ver. Quinn e eu terminamos bem e decidimos ser só amigos. Eu amo a Melissa e estou com ela agora e aparentemente você e a Quinn gostam muito um do outro. 
<p>- Gostamos.
<p>- Ótimo. Eu sei que podemos ser todos amigos agora. E ninguém precisa se bater. – Sebastian riu. 
<p>- Obrigado. 
<p>- Estou feliz que está feliz.</p> 
<center><h4>--*--</h4></center>
<p>- Tudo bem. Me conta de novo essa história porque eu ainda não consegui entender e muito menos acreditar. – Emily estava chocada com tudo que havia ouvido.
<p>Will havia entrado no quarto dela pela janela e naquele momento os dois estavam deitados na cama. Já estava bem tarde. 
<p>- Eu não vou repetir tudo isso de novo, mas resumindo... Kevin quase matou o Sebastian e agora vai ser internado em uma clínica. – Até para Will aquilo estava sendo difícil de compreender. 
<p>- E você não foi vê-lo?
<p>- A Amanda me contou e eu fiquei em choque por três horas e então vim para cá. Nem o Sebastian eu fui visitar ainda. 
<p>- Você parece calmo. Me contou tudo sem gritar e xingar. Se isso tivesse acontecido há algumas semanas, você estaria andando de um lado para o outro super irritado e no final subiria pelas paredes. 
<p>- Acho que o mato me mudou. – Will sorriu.
<p>- Sem graça. 
<p>- Talvez eu ainda esteja em choque, em negação ou sei lá. Além do mais, Kevin sabe o que é certo e errado. Por que eu estaria com raiva dele estar pagando pelo que ele fez? E é uma clínica e não cadeia, e o Sebastian está bem. 
<p>- Agora eu estou na dúvida. Eu não gostava muito quando você se importava demais, mas agora acho estranho você não se importar.
<p>- Vamos falar de outra coisa então. Tipo o nosso casamento.
<p>- Você contou para alguém?
<p>- Contei para o Chris. Ele acha que eu estou doido. – Will riu. – E você?
<p>- Ainda não. Eu ia contar para Quinn, mas... 
<p>- Se já está assim, imagina quando formos contar para os seus pais. – Will parecia se divertir.
<p>- Que tal pensarmos nisso depois? Se quiser, eu vou junto com você amanhã na clínica.
<p>- Talvez eu só piore as coisas. 
<p>- Mas ele é seu irmão e você tem que ir vê-lo.
<p>- É, eu sei. 
<p>- Então combinado. Só me prometa uma coisa.
<p>- Sem socos? – Will já sabia o que a namorada ia dizer.
<p>- Sem socos. – Ela confirmou.
<p>- Chutes pode? 
<p>- Will!
<p>- E empurrões? Você não falou nada sobre empurrões. 
<p>- Eu é que vou te empurrar da cama daqui a pouco.
<p>- Não vai, não. – Will a abraçou e ela retribuiu.
<p>- Ridículo.</p> 
<center><h4>--*--</h4></center>
<p>A clínica estava quase solitária de manhã quando Emily e Will chegaram na recepção. Karen e Robert estavam no balcão assinando os últimos papéis, estavam lá desde a noite passada.  Os dois abraçaram o filho e Will sabia que eles estavam quase desabando. 
<p>- Filho, vamos voltar para casa, tomar um banho... – Karen parecia bem desnorteada. 
<p>- Se cuidem. – Will se despediu dos pais e foi até uma das recepcionistas. 
<p>Dez minutos depois, Will e Emily estavam sentados em um sofá de uma sala de espera aguardando a enfermeira trazer crachás de visitante.
<p>- Acho que eu preciso fazer isso sozinho.
<p>- Tudo bem. – Emily segurou bem forte a mão de Will, o beijou e depois desejou boa sorte. – Sem socos, viu? – Ela repetiu.
<p>- Eu prometi, não foi? – Will tentou rir, mas o clima estava bem tenso naquele lugar.
<p>Antes de entrar no quarto onde Kevin estava, a enfermeira pediu para Will colocar todos os objetos metálicos que ele possuía em uma caixa que ela carregava. Procedimento de segurança da clínica. 
<p>- Só vai poder ficar por alguns minutos. – A enfermeira falou quando estavam na porta do quarto. – A terapia dele vai começar daqui a pouco e vai precisar se ausentar dos familiares e dos amigos por um mês.
<p>- Tudo bem. 
<p>Kevin estava muito abatido quando Will entrou no quarto. Ele estava sentado no meio da cama olhando para os próprios dedos vestido com a roupa branca da clínica. Uma calça de moletom e uma camiseta lisa. 
<p>- Tudo bem?
<p>Ele olhou para Will um pouco surpreso, mas depois voltou a olhar para as mãos.
<p>- O que você quer aqui?
<p>- Vim te ver.
<p>- Já viu. Agora pode ir embora. – Kevin também estava com a voz fraca. 
<p>- Kev...
<p>- Você concorda com eles? Também acha que mereço estar aqui?
<p>- Kev, você quase causou a morte do Sebastian...
<p>- E como você mesmo disse, prefere ele do que eu. – Kevin encarou o irmão.
<p>- Sabe que eu só falei isso pela raiva. 
<p>- Se é isso que você acredita... Mas eu sei a verdade. Veio aqui para falar o quê? Para dizer que me avisou?
<p>- Eu vim aqui para ver como você está e para saber se você ainda é o meu irmão, mas aparentemente meu irmão não está mais aqui. Ele foi embora já faz um tempo.
<p>- Eu odiava ele. 
<p>- Então você prefere ser quem é agora? 
<p>- Quem eu sou, Will? Me fala. – Kevin o enfrentou.
<p>- Agora eu só consigo ver um mimadinho que merece tudo o que está acontecendo com ele. 
<p>- Eu não mereço ser preso.
<p>- Você não está preso. Está em um tratamento para melhorar. 
<p>- E se eu não quiser melhorar? E se eu achar que como eu estou agora é como eu gosto de estar?
<p>- Então você é um otário. E quer saber mais? – Will não esperou Kevin responder. – Eu quero mesmo que você saia daqui e que lá fora, faça uma burrada tão grande que não haja volta e te joguem na cadeia. E espero que apodreça lá.
<p>- Seria mesmo capaz de deixar isso acontecer comigo? – Will sabia que não. 
<p>- Provavelmente não, mas eu vou tentar melhorar. Além do mais, você não é mais uma criança e parece que só vai aprender a lição quando cometer um erro muito grande ou nem isso. Quase matou seu irmão e não estou vendo nenhum remorso.
<p>- Talvez sem o Sebastian, eu finalmente teria um espaço. 
<p>- Isso não é justo. Você me tirou da sua vida, Kevin. Se lembra disso? – Will apontou o dedo na direção do irmão. – Porque eu me lembro como se fosse hoje. E eu, mesmo assim, passei o tempo todo desde então tentando te ajudar, tentando estar lá, mesmo você “não querendo”. AGORA EU CANSEI! Na verdade, se você ficar aqui para sempre, eu não vou me importar, eu vou até ficar aliviado por não precisar mais carregar um peso nas minhas costas. 
<p>- Vai embora e não se incomode mais em vir aqui. 
<p>- Ótimo. 
<p>Will saiu do quarto com uma vontade imensa de voltar e dar um soco nele, mas tinha feito uma promessa e seu irmão já estava na pior, não queria piorar.</p> 
<center><h4>--*--</h4></center>
<p>- Você é o que? A policial boazinha? É a minha segunda chance? – Kevin se levantou da cama quando viu Emily na porta do quarto. 
<p>- Will foi buscar o carro. E pelo jeito que ele saiu daqui, a conversa não foi boa. 
<p>- Não estou de olho roxo. 
<p>- Kevin, eu sei que você não é mau. 
<p>- Aparentemente, só você sabe disso. 
<p>- É porque eu sou a única inteligente por aqui. – Emily riu e Kevin riu junto. 
<p>- Não precisa ser legal comigo. Você já me disse uma vez que...
<p>- Seu irmão te ama. – Emily o interrompeu. Não se tratava do que ela achava naquele momento. – Ele pode não querer admitir agora porque é um imbecil, mas ele te ama. 
<p>- Não depois de tudo o que a gente disse. 
<p>- Ele me contou o que vocês disseram. E sabe que é mentira. Ele nunca conseguiria escolher entre vocês. Seria mais fácil ele morrer e deixar os dois viverem. Não importa o quanto ele tente, nunca vai deixar de se importar com você.
<p>- Será? Quando ele chegou aqui, eu achei que... – Kevin balançou a cabeça.
<p>- Olha, você precisa melhorar. 
<p>- Não sei se consigo.
<p>- Tem que conseguir. Will não vai querer se casar sem um dos irmãos dele no altar. – Emily sorriu.
<p>- Casar? Como assim?
<p>- Ele me pediu em casamento. – Emily mostrou a mão com o anel. – E eu disse “sim”.
<p>- Isso deve ser bom. – Kevin não tinha muita energia para comemorar, mas mesmo assim demonstrou felicidade. 
<p>- É muito bom. Por isso eu preciso que você fique bem.
<p>- Emily...
<p>- Por favor.
<p>- Não posso te prometer isso.
<p>- Só me prometa que vai tentar. Eu já me contento com isso. 
<p>- Mas eu sempre tento. – Kevin começou a chorar. – Mas eu não consigo. 
<p>- Mas agora é diferente. Não está mais sozinho. E isso já é um começo. 
<p>Emily se aproximou dele e o abraçou.
<p>- Vai ficar tudo bem. Vai ficar tudo bem.</p> 
<center><h4>--*--</h4></center>
<p>- Você não devia ter ido falar com ele. – Will estava quase quebrando o volante de tanto apertar.
<p>- Eu devia sim.
<p>- E quanto a mim? De que lado você está?
<p>- Eu fiz isso por você. – Emily olhou feio para o namorado.
<p>- Ele é um idiota. E eu achando que a clínica poderia mudar ele.
<p>- Ele não precisa mudar, ele precisa melhorar. É diferente.
<p>- Para melhorar é preciso mudar.
<p>- Discordo. 
<p>- De novo, de que lado você está? – Will deu um tapa no volante.
<p>- Olha, você está com raiva dele, eu entendo, mas ele é seu irmão. – Emily também estava brava. Odiava ter que dar um sermão.
<p>- Eu não estou com raiva dele, estou é com raiva de mim por não ter impedido isso. 
<p>Emily começou a olhar para a estrada confusa quando percebeu que Will havia perdido a saída. 
<p>- Para onde vamos?
<p>- Vamos fugir.
<p>- O quê? – Emily riu achando que aquilo era uma brincadeira. 
<p>- É, vamos para algum lugar bem longe. Vamos nos casar e esquecer de todo mundo. Vamos criar uma nova família e...
<p>- Will.
<p>- Só por esse fim de semana então. – Ele estava divagando. 
<p>- Não dá para criar uma nova família em um fim de semana. 
<p>- Dá em três minutos. – Will riu. 
<p>- Acabamos de chegar.
<p>- E eu já quero ir embora de novo. Se eu soubesse que era isso que estava me esperando em casa, eu teria ficado em Nashville, até mesmo sem você. 
<p>- Dá a meia-volta, Will. 
<p>- Relaxa, a gente não vai fugir, eu só estava brincando. Eu pego o próximo retorno.
<p>- Eu não estou falando sobre isso. Eu quero que você volte para aquela clínica e se resolva com o seu irmão.
<p>- Eu não quero. – Will falou como uma criança malcriada.
<p>- Sabe que se tudo ficar bem, ele pode melhorar mais rápido. 
<p>- Eu já vi esse filme, Ems. Eu vou dar mais uma chance e ele vai estragar de novo. Eu não quero me decepcionar. 
<p>- Mas ele é seu irmão e isso não se trata de você. 
<p>- Agora você usa essa desculpa? Você odeia quando eu uso essa desculpa. 
<p>- Eu sei.
<p>Will bufou várias vezes e parecia muito concentrado na estrada, até que...
<p>- Eu vou ter que voltar, não é?
<p>- Vai e é por isso que eu te amo.
<p>- Eu acho que não quero mais me casar com você. – Will riu. 
<p>- Cala essa boca. – Emily deu um tapa no ombro do namorado. 
<p>Will entrou no primeiro retorno que encontrou, mesmo achando uma péssima ideia. Ele respirou fundo algumas vezes na esperança de que quando chegasse novamente na clínica estivesse mais calmo.
<p>- O que é isso? – Emily forçou a vista para ver melhor o que a fumaça que vinha na direção dos dois escondia. 
<p>Não demorou muito até os dois avistarem um carro fora da estrada. Ele parecia ter capotado devido ao estado que o carro se encontrava e a distância que ele estava. 
<p>- O acidente foi bem feio, hein? – Will parou o carro no acostamento.
<p>- O que você vai fazer? – Emily ficou assustada.
<p>- Liga para a emergência. Vou ver se eu posso ajudar.
<p>- Will, você não é bombeiro nem o Superman. 
<p>- Eu só vou ver se estão bem e tentar acalmá-los até a emergência chegar. Agora liga. 
<p>- Meu herói. – Emily fez cara feia para o namorado e começou a discar o número em seu celular. 
<p>Will saiu do carro e viu pela janela que Emily já estava falando com alguém pelo telefone. O carro estava todo detonado. O vidro do para-brisas estava com um grande buraco e com um pouco de sangue. Havia alguém lá dentro ainda preso com o cinto de segurança.
<p>- Oi, cara. – Will se aproximou dele. O homem conseguiu abrir os olhos por alguns instantes e depois os fechou.
<p>- A-ajuda e-ele. – Ele gemeu.
<p>- Olha, minha namorada já ligou para a emergência, eles já devem estar vindo. Vão estar aqui em poucos minutos. – Will tentou falar o mais calmo que ele conseguiu, mas o homem nem tinha muita energia para ficar nervoso, mal conseguia ficar acordado.
<p>- M-me ajuda. – Ele continuou gemendo. Tinha um ferimento bem grave na testa e não parava de sangrar. Sua roupa também tinha marcas de sangue, provavelmente mais partes do corpo dele estavam sangrando. 
<p>- Vai ficar tudo bem, está me ouvindo?
<p>- E-eu não...
<p>- Espera um pouco, eu conheço você. – Will parou de prestar atenção nos ferimentos do homem e reparou mais em seu rosto. O rosto que ele ficou procurando em livros de anuário por horas. – Você... você é o Leo. O agiota.
<p>- A-ajuda e-ele. – Leo repetiu. 
<p>- Ajuda quem? Não tem mais ninguém no carro.
<p>- F-fora.
<p>- Fora? Como assim “fora”?
<p>Will se afastou um pouco do carro. Leo estava falando que alguém durante o acidente saiu do carro. Só podia ser isso. 
<p>- Não tem ninguém aqui. – Will começou a olhar para todos os lados. Lá atrás Emily estava do lado de fora do carro olhando para Will, com o celular na mão.
<p>- A-ajuda... – Leo continuava gemendo cada vez mais baixo.
<p>- Mas não... não tem ninguém... – Então Will o viu.
<p>Um corpo jogado a uns cem metros de distância do carro. 
<p>- Não pode ser. – Will reconheceu aquela roupa branca. 
<p>- Will! – Emily gritou do acostamento. 
<p>- Liga para a emergência, Emily! LIGA PARA A EMERGÊNCIA AGORA! KEVIN!</p>
</body>
</html>";
            }

            if (numero == 44)
            {
                lblTitulo.Text = "Capítulo 44 - O Eco é A Única Voz Que Está Voltando";
                htmlPage.Html = @"<html>
<body>
<p><i>“Estou no limite e gritando meu nome
<br>Como um bobo, a plenos pulmões
<br>Algumas vezes, quando fecho meus olhos
<br>Eu finjo estar bem, mas nunca é suficiente
<br>Porque meu eco é a única voz que está voltando
<br>Minha sombra é a única amiga que tenho”
<br><b>Echo - Jason Walker</b></i></p>
<br>
<p>Era como se ele estivesse correndo sem sair do lugar, era assim que Will se sentia. Não importava o quão rápido ele corresse, nunca chegaria a tempo. 
<p>Kevin estava estirado no chão quando Will o alcançou. Sua roupa branca estava toda manchada de sangue. Seus dedos das mãos se mexiam sutilmente como se toda a sua energia estivesse lá. Seus olhos estavam entreabertos, mas bem vagos. Sua boca se abriu assim que viu Will se aproximar.
<p>- Kevin. – Will se ajoelhou ao lado do irmão. 
<p>- Will... – Ele mal conseguia falar. – Está doendo, Will.
<p>Kevin tentou levantar seu braço, mas tudo o que conseguiu foi deixar a mão em outra posição. 
<p>- Não, não. Fica parado. A ambulância vai chegar logo, logo.
<p>- Eu não consigo me mexer. Está doendo muito. – Seus olhos se encheram de lágrimas.
<p>- Você precisa se acalmar. – Will engoliu o choro. Queria pegar Kevin no colo e sair correndo, mas sabia que naquela situação, fazer aquilo seria pior.
<p>- Não me deixa aqui, por favor. – Kevin começou a delirar. 
<p>- O quê?
<p>- Por favor, não me deixa aqui.
<p>- Eu não vou te deixar aqui, me ouviu? – Will foi firme. 
<p>- Por favor, me ajuda. Eu não quero morrer. 
<p>Will não conseguia ficar parado vendo seu irmão chorar de dor. Ele olhou para todos os lados, mas ainda não havia nenhum sinal de alguma ambulância chegando. Emily ainda estava parada em frente ao carro estacionado no acostamento. Será que ela sabia que era o Kevin que estava caído todo ensanguentado?
<p>- Olha, fica calmo. Eles já estão chegando. Fica calmo.
<p>- Will, eu...
<p>- Não fala nada. Só respira fundo e espere. Eu estou aqui com você. 
<p>Will ficou com medo de que um simples toque causasse mais dor em Kevin, então manteve uma certa distância, porém seus olhos estavam fixos nos olhos do irmão.
<p>- Kev, vai ficar tudo bem, tá bom? Eu estou aqui e vou cuidar de você.
<p>- Do jeito que você sempre cuida. – Kevin mostrou um quase sorriso. – Me perdoa.
<p>- Para. Não vamos ter essa conversa agora, me ouviu? 
<p>- Will...
<p>- Você vai ficar bem e ainda vamos brigar muito por você ser um idiota. 
<p>- Will... – Lágrimas escorriam dos olhos de Kevin. – Eu vou morrer.
<p>- Não, você não vai morrer. Eu não vou deixar você morrer, está me ouvindo? – Quase que por instinto, Will pegou em uma das mãos de Kevin. Ela estava fria e totalmente suja de sangue. 
<p>De longe, ele ouviu o barulho de uma sirene.
<p>- Estão chegando, Kev. Eu disse que iam chegar. Vai ficar tudo bem. – Will sorriu. – Aguenta mais um pouco. Vai ficar tudo bem. Vai ficar tudo bem.
<p>Will percebeu que pessoas estavam se aproximando pelo barulho de passos na grama. Ele soltou a mão de Kevin, se levantou e se afastou para não atrapalhar. Atrás, alguns socorristas pararam no carro para atender Leo que já estava desacordado e outros foram correndo com uma maca até Will e Kevin.
<p>- Você está bem? – Um dos paramédicos se aproximou de Will.
<p>- Estou sim, não fui eu quem... sofreu o acidente.
<p>- Esse sangue é seu?
<p>- Sangue... – Will se olhou e viu que seus braços e mãos estavam cheios de sangue e sua camiseta tinha algumas marcas vermelhas também. Kevin havia sangrado mais do que ele percebeu. – Só ajuda ele, é meu irmão. 
<p>Dois paramédicos se aproximaram de Kevin e com muito cuidado o prepararam para a maca. 
<p>- Tomem cuidado com ele. – Will ficou de longe olhando Kevin sendo levantado e colocado na maca. – Tomem cuidado, por favor. – Levantaram a maca. 
<p>- Cuidado! – Um dos paramédicos gritou quando percebeu que Kevin estava tossindo e cuspindo sangue.
<p>- O que está acontecendo? – Will tentou entender o que estava vendo. 
<p>Os dois paramédicos voltaram a colocar a maca no chão. Kevin tossia sem parar até não tossir mais.
<p>- O que está... – Will tentou se aproximar mais e conseguiu ver um dos paramédicos em cima de Kevin com suas mãos em seu peito e fazendo um <p>movimento que ele sabia muito bem que era feito quando o coração parava de bater, massagem cardíaca para ressuscitação. 
<p>O coração de Kevin havia parado, mas Will também não conseguia respirar. Suas pernas cederam e Will se ajoelhou na poça de sangue que o irmão havia deixado e encarou aquela cena. Paramédicos suando e gritando tentando salvar uma criança que não tinha mais vida. 
<p>- Droga! – O paramédico falou logo depois que parou de forçar suas mãos contra o peito de Kevin. 
<p>- O que aconteceu? Por que vocês pararam? Ele ainda não está acordado. – Will se levantou. – Por que vocês...
<p>- Sentimos muito. – O paramédico que estava mais próximo de Will falou. O outro em cima de Kevin ainda estava em choque. Perder alguém nunca virava rotina.
<p>- Sente muito por quê? Ele não...
<p>- Ele não está mais respirando. 
<p>- Então faça ele respirar! – Will ordenou.
<p>- Garoto...
<p>- FAÇA ELE RESPIRAR AGORA! Ele estava falando comigo, como assim não está mais respirando? ISSO NÃO EXISTE! – Will colocou as mãos sujas de sangue na cabeça. 
<p>- Você precisa se acalmar. – O paramédico se aproximou mais de Will. – Meu nome é Nicholas, pode me chamar de Nick, se quiser.
<p>- Eu quero que você faça seu trabalho. Meu irmão não pode morrer. Resolva isso. – O coração de Will batia muito forte e ele bufava pelo nariz. 
<p>- Não há mais nada a se fazer. – Nicholas falou. 
<p>- Mentiroso.
<p>Will empurrou os paramédicos e foi até Kevin.
<p>- Kevin, acorda. – Ele se ajoelhou e encostou sua mão no peito do irmão. – Kevin, fala alguma coisa. 
<p>- Você precisa se afastar. – Nicholas pegou no braço de Will para tentar levantá-lo. – Precisamos levá-lo.
<p>- Se vocês não vão ajudar, por que precisam levá-lo? – Will puxou seu braço de volta. – Eu vou ligar para outro hospital. 
<p>- Você não entende.
<p>- Não, é você que não entende. Ele é meu irmão e eu não vou deixá-lo morrer. Eu prometi que não ia. – Will voltou para Kevin. – Kev, fala comigo. Abre os olhos. Vamos, abre os olhos. – Ele começou a chacoalhá-lo. – Abra esses malditos olhos, Kevin. Por favor. – Por fim, ele implorou chorando. – Por favor, não morre.
<p>- Não há nada que se possa fazer. Eu sinto muito, mas seu irmão morreu...</p>
<center><h4>--*--</h4></center>
<p><i>Não há nada que se possa fazer. Eu sinto muito, mas seu irmão morreu...</i>
<p>Will entrou em um dos banheiros do hospital. Se olhou no espelho. Seu rosto estava sujo com sangue seco e seus olhos estavam vermelhos e inchados. Ele demorou alguns minutos se encarando até ligar a torneira da pia.
<p>Começou a esfregar suas mãos uma na outra, a água que saía das suas mãos era vermelho vivo, mas elas continuavam sujas. Ele começou a esfregá-las com mais força e foi para os braços, também, sujos. O sangue não queria sair. 
<p>Tirou sua camisa, ela também estava suja de sangue. A colocou dentro da pia e começou a esfregar. Queria se livrar daquela sujeira o mais rápido possível, mas estava sendo impossível. 
<p>- Isso tem que sair. Por que não está saindo?
<p>Jogou um pouco de água no rosto. Se olhou no espelho novamente. Estava parecendo um zumbi, ele pensou. 
<p>Voltou a esfregar a camisa na água para tentar se livrar das manchas. Ele só tinha aquela camisa naquele momento. Como sairia do banheiro com a camisa molhada ou talvez sem ela? 
<p>- Seu idiota. – Ele ouviu a si mesmo. – Você é um idiota, sabia disso?
<p>Ele respirou fundo.
<p>- Cala a boca. – Não sabia para quem estava falando. – CALA A BOCA!
<p>O espelho se quebrou. Pedaços de vidro caíram no chão. A pia se encheu de sangue. Will estava tremendo. Seus olhos ardiam e suas mãos estavam dormentes.</p> 
<center><h4>--*--</h4></center>
<p><i>Não há nada que se possa fazer. Eu sinto muito, mas seu irmão morreu...</i>
<p>Karen ficou observando o caixão descer e ficou parada em frente o túmulo até anoitecer. Robert ficou do seu lado a segurando pelos ombros, pelo estado que ela estava, ficou com medo dela acabar desmaiando. Não comia fazia mais de um dia. 
<p>Amanda segurou o choro até o último minuto. Ela estava brava. 
<p>- Aquele idiota, filho de uma figa. Eu não acredito que ele fez isso. – Foi a primeira coisa que ela disse quando Will contou a ela o que havia acontecido. 
<p>Ela gritou, teve uma crise de histeria, mas não conseguiu chorar. Diferente de Jason, que caiu no choro no mesmo momento que viu Will todo cheio de sangue sentado no chão da sala de espera do hospital. 
<p>Chris estava destruído. Olhava para todos bem desnorteado, muitos até duvidavam se ele realmente sabia onde estava. Não falou uma palavra o enterro todo e olhava o vago na maior parte do tempo. 
<p>Quinn o guiava e falava baixinho em seu ouvido coisas que ninguém conseguia ouvir. Ela ainda estava em choque. Segurava a mão de seu namorado um pouco trêmula. 
<p>Matt havia ficado em casa com alguns primos mais novos e uma babá. Achavam que ele era muito novo para presenciar uma cena daquelas. Besteira, Will disse. O irmão dele havia morrido, ele tinha noção do que aquilo significava. 
<p>Sebastian quase levantou da cama e saiu correndo quando soube da notícia por Emily. Ela havia ido até lá com toda a calma que ela conseguiu juntar naquele momento, se sentou ao seu lado e contou tudo o que havia acontecido segurando suas mãos. No final, os dois estavam chorando. O médico não permitiu que ele saísse do hospital nem para o enterro, seria muito perigoso no estado que ele ainda estava. 
<p>Will o considerou sortudo. Enquanto Sebastian estava em uma cama de hospital com Melissa assistindo algum programa na TV, ele estava parado em pé em um lugar que cheirava mal, usando preto e com todos em sua volta com cara de morte. Não era a segunda-feira que ele estava esperando. 
<p>Emily estava ao seu lado segurando sua mão machucada com todo o cuidado. Ela havia trocado seu curativo duas horas antes. Quando ele saiu do banheiro do hospital naquele dia com as mãos cortadas, ela pensou em lhe dar uma bronca, mas se calou e só o levou até uma enfermeira. 
<p>Harry e Patrícia estavam em um lugar afastado. Não se achavam dignos de estarem na frente, mal conheciam o garoto, mas sabiam como era perder alguém da família, por isso estavam lá. Caso alguém precisasse de apoio. 
<p>Quando voltaram para casa, todos continuaram em silêncio. Karen e Robert subiram para o quarto quase que imediatamente. Amanda pegou Matt no colo e subiu também, provavelmente os dois dormiriam juntos naquela noite, o garoto começou a chorar assim que viu todo mundo com “cara de enterro”. Chris ficou um bom tempo na cozinha, Quinn se despediu dele mesmo querendo ficar e foi embora. 
<p>Will se sentou no sofá junto com Emily. Jason se sentou ao lado de Emily. Ela pegou nas mãos dos dois e ali ficaram, a noite toda em silêncio. Não se levantaram nem se olharam. Só ficaram lá até o sol nascer de novo.</p> 
<center><h4>--*--</h4></center>
<p><i>Não há nada que se possa fazer. Eu sinto muito, mas seu irmão morreu...</i>
<p>Will só percebeu que não ia para escola fazia um tempo quando começou a assistir a aula de Química. Estava completamente perdido na matéria, não que isso não acontecia antes, mas estava pior. 
<p>Estar de luto por Kevin estava sendo pior do que quando estava por Angie. Não porque dessa vez era com alguém de seu sangue, seu irmão, mas sim porque ninguém o deixava esquecer. 
<p>Ninguém sabia da existência de Angie, então quando ela morreu, Will pôde voltar para a escola como se nada tivesse acontecido, ninguém sabia pelo que ele estava passando e era bom. Mas dessa vez, não era assim. Todos paravam para perguntar como ele estava e para dar os pêsames, até pessoas que ele nunca conversou na vida. Havia um grande memorial na frente do armário de Kevin. Bilhetes pendurados, flores, velas. Ele achava aquilo tudo bem ridículo. 
<p>Não se passaram nem três aulas e Will já estava cansado. Saiu da sala antes mesmo da aula terminar. Precisava de silêncio, mas aquele corredor estaria lotado e barulhento em questão de minutos. O almoço seria em uma hora, mas ele não estava com fome. Também não queria ficar vinte minutos em uma mesa no meio do refeitório falando sobre coisas que não queria falar. 
<p>Pegou seu celular. Mandou uma mensagem para Emily. Também não queria ninguém preocupado procurando por ele.</p> 
<center><h4>--*--</h4></center>
<p><i>Não há nada que se possa fazer. Eu sinto muito, mas seu irmão morreu...</i>
<p>Will viu a praia se encher de pessoas e também viu essas mesmas pessoas indo embora. Viu o sol do meio-dia e também viu ele se pondo às seis da tarde. A temperatura caiu e ele suava. Provavelmente estava todo vermelho do sol, não havia passado protetor solar para o dia todo. 
<p>A brisa do mar batia levemente em seu rosto e as ondas se aproximavam sutilmente de onde ele estava sentado. Seus pés já estavam se molhando, mas ele não pretendia se levantar tão cedo. 
<p>Ele olhou para as suas mãos enfaixadas. Ardia quando ele fechava os punhos e ardia mais ainda quando ele socava a areia úmida com os punhos fechados. 
<p>- Droga. – Ele respirou fundo.
<p>Will não sabia porque estava fazendo aquilo, só queria ver suas faixas encharcadas de sangue e se tivesse sorte, isso aconteceria. Já estava sentindo. 
<p>Ele fechou os olhos e socou mais forte. Fez uma careta para segurar o grito de dor.
<p>A voz de Kevin gritou por ele. Aquela voz que estava com ele desde que o irmão parou de falar. Ele realmente achava que teria uma outra chance com o irmão depois de ver o estado que ele estava? Ele tinha que ter adivinhado que o garoto ia morrer. Ele tinha que ter dito tudo o que estava sentindo. Não ia dar certo, provavelmente começaria a gritar o quanto o irmão era um imbecil por ter se metido naquela encrenca.
<p>Ele socou a areia de novo.</p>
<center><h4>--*--</h4></center>
<p><i>Não há nada que se possa fazer. Eu sinto muito, mas seu irmão morreu...</i>
<p>Olhar para uma pedra com o nome de seu irmão definitivamente não era a mesma coisa. Will se sentou naquela grama, provavelmente sete palmos a cima de um caixão e encarou aquela lápide. Do lado havia um buquê de margaridas. 
<p>Margaridas eram as flores favoritas de sua mãe, ela com certeza havia passado por lá bem cedo como todos os dias.
<p>- Kevin... – Will respirou fundo. – Já faz uma semana, hein? Infelizmente sua missa de sétimo dia não foi tão glamurosa quanto seu enterro. Eu vi até pessoas rindo, pelo menos do lado de fora da igreja, que era onde eu estava. Foi mal, mas você sabe que igreja nunca foi muito a minha praia. Se você foi para o céu, acho que o que eu vou te contar vai ser inútil, porque ou você está vendo tudo ou não se importa, além do mais, se você está no céu, por que perderia tempo com a gente?
<p>Will fez uma pausa.
<p>- Mas se na pior das hipóteses, você está em seu sono eterno esperando para ser comido por milhões de minhocas então... O que eu vou te contar vai continuar sendo inútil, não é? Bom, tirando as vezes que ela vem aqui te visitar ou quando foi para a missa, mamãe não sai mais do quarto, a gente mal consegue vê-la, estamos um pouco preocupados, mas nosso pai disse que vai passar, que só precisamos dar um tempo. Ele é bom nisso, afinal mal aparece em casa, ele está usando a metodologia de que trabalhar é melhor do que ficar parado se lamentando, me parece ser uma boa metodologia. 
<p>“Seu quarto está trancado. Ninguém ainda teve coragem de entrar e começar a empacotar. Então se a sua alma, espirito, fantasma ou sei lá o que, estiver lá dentro esperando fazer contato com alguém, perdeu seu tempo que deve ser muito, por ser a eternidade, então eu recomendo que você vá conhecer outros lugares e vá assustar outras pessoas. Ouvi dizer que ingleses acreditam em fantasma. Farão um ritual para você.”.
<p>Will fez uma careta que quase pareceu um sorriso.
<p>- Amanda é outra que já pode ser dada como desaparecida. Ela fica mais na casa do Jason. Sinceramente, pelo que eu vi no enterro, não sei se ele está consolando ela ou o contrário. Eu me lembrei de uma coisa nesses últimos dias, ele que te ensinou a andar de bicicleta, se lembra disso? É, isso é algo que um irmão faria. 
<p>“Sebastian saiu do hospital ontem. Queria ter ido na sua missa, mas o médico disse que ele tinha que ficar de repouso absoluto por mais dez dias. A mamãe não quis arriscar. Um filho no mês já está bom, não é? Ele está bem fisicamente, mas... tenho certeza que deve estar lutando muito para continuar sóbrio. Eu nem sou viciado e estou lutando, então imagina ele. Ele acha que poderia ter feito mais por você. Na verdade, todos nós achamos que poderíamos. Mas agora não adianta mais pensar nisso, não é? Você está morto, é tarde demais para qualquer um de nós.”
<p>Ele respirou fundo. Precisava continuar.
<p>- Chris é o único que parece que está segurando bem as coisas. Ele virou um dono de casa, é sério. Ele está cuidando da mamãe e do Matt. Papai até pensou em mandá-lo para a casa da vovó em Nova Jersey, mas preferiu manter a família unida. Eu sei que ele é forte demais e não se permite, mas... também deve estar se culpando. É uma coisa de família. Além do mais, somos todos crianças fazendo coisas erradas, não é? E sempre tendo culpa de alguma coisa.
<p>“Emily fica comigo toda noite. A gente conversa sobre coisas aleatórias e então ela cai no sono. Eu não durmo, nem sei se vou conseguiu dormir um dia. Ontem, a gente falou do casamento. É, eu sei, é ridículo. É, eu ia me casar e ia contar para todo mundo, mas... agora não importa mais. Você não vai estar lá. Mas será que estaria se estivesse vivo? Você estava me odiando muito para querer ir no meu casamento.”
<p>“Seu amigo Leo sobreviveu. Fiquei sabendo que ele saiu do hospital e foi direto para cadeia por homicídio culposo. Ele estava bêbado no dia do acidente, você sabia disso? É claro que sabia. Será que eu preciso dizer o quão idiota você foi naquele dia? Custava ficar naquela droga de clínica só por mais um tempo? Seu imbecil. Estão dizendo que ele vai pegar uns dois anos de pena e pode sair antes se tiver um bom comportamento. Você perdeu a sua vida enquanto ele vai ter dois anos de descanso.”.
<p>“Giovanna sumiu. Ela apareceu no seu enterro. Ela parecia bem triste se quer saber a minha opinião. Não parecia estar fingindo. Provavelmente acha que causou tudo isso. Talvez tenha causado, talvez não. Preferi não... Estão falando que ela se mudou, foi para outro estado, eu não tenho certeza. Talvez só esteja escondida em casa com medo da luz do sol. Todo mundo tem seus fantasmas, não é verdade?”
<p>Will começou a puxar as folhas presas no chão de nervoso. 
<p>- Eu não estou mesmo sabendo lidar com isso. É como se eu tivesse me desligado do mundo, mas ele continua funcionando sem mim, sem nós dois. Como eu disse, tinha até pessoas sorrindo na sua missa. Como alguém consegue estar sorrindo? Eu fodi com as minhas mãos. – Ele mostrou as mãos enfaixadas para a lápide. – Mas não se preocupe, eu não estou sentindo dor, eu queria muito sentir, mas não consigo. Eu não durmo já faz um tempo e nem como. Na verdade, eu estou começando a pensar que morri com você naquele dia, só não me enterraram ainda. Talvez ainda estejam tentando me reanimar. Pode ser, eu até estou sentindo um aperto no peito bem grande. – Will começou a chorar. – Eu nunca te deixaria lá, você sabe disso, não é? Eu não sei porque disse aquilo, talvez tenha sido o choque, talvez nem conseguiu me reconhecer, mas... eu nunca teria te deixado lá, não importa a raiva que eu estava sentindo. Eu teria morrido para te salvar, você sabe disso, não sabe?
<p>Aquele silêncio ensurdecedor era horrível.
<p>- E quanto a você? – Ele engoliu o choro. – Como está? Já encontrou Deus? Está feliz? Claro que não. Você está morto.</p>
<center><h4>--*--</h4></center>
<p><i>Não há nada que se possa fazer. Eu sinto muito, mas seu irmão morreu...</i>
<p>- Você vai tomar alguma coisa?
<p>O barman passava de dez em dez minutos perto de Will que estava encostado em uma das extremidades do balcão do bar já fazia uma hora.
<p>- Não, eu estou esperando alguém. – Will estava com a cara fechada.
<p>- Não pode ficar no balcão se não vai tomar nada.
<p>- Toma. – Will jogou uma nota de cem no balcão. – Agora me deixa em paz.
<p>Queria estar bem sóbrio quando acontecesse. Na noite passada, tudo ficou claro. Ele mesmo se respondeu quando perguntou o que faria da vida para superar tudo aquilo. O que ele podia fazer de bom naquele ponto em que estava? 
<p>- Você é o Paul? – Ele perguntou assim que um homem se encostou no balcão ao lado dele.
<p>- Sou eu, está querendo algo? – Paul usava um boné que mal dava para ver seu rosto. O lugar já era escuro e ele ainda usava uma roupa preta para tentar passar despercebido. Suas mãos estavam em seus bolsos o tempo todo.
<p>- Não, eu só queria te perguntar uma coisa. 
<p>- É policial? – Paul se afastou um pouco.
<p>- Não, só curioso.
<p>- Sabe o que acontece com curiosos?
<p>- Me diz. – Will o encarou. Estava esperando que seus “capangas” aparecessem. Caras assim nunca andavam sozinhos. 
<p>- Não têm um final muito bom.
<p>- Você ao menos se importa com esses garotos que compram de você? Tem noção das famílias que você destrói?
<p>- Eu não destruo nada. Cada um faz o que quer.
<p>- Todos vocês têm o mesmo discurso. É pensando assim que você consegue dormir à noite?
<p>- Eu durmo à noite porque eu consigo muita grana. Mais alguma coisa? É jornalista?
<p>- Também não. É que meu irmão provavelmente comprava de você. Ou de alguém que trabalha para você. Você é o grande <i>Heisenberg</i> do bairro, não é?
<p>- Gostei. – Paul sorriu. – O que aconteceu com o seu irmão? Está em uma clínica? Tomou jeito na vida?
<p>- Ele está morto. 
<p>- Nossa. – Paul não demostrou nenhuma emoção. – É sempre uma pena quando perdemos um cliente. 
<p>- São notas a menos entrando no seu bolso, não é?
<p>- Exatamente. 
<p>- Ele só tinha quinze anos, seu filho da mãe. 
<p>Will socou Paul com um de direita. Seu punho formigou por causa da ferida. O rosto do traficante se virou e quando voltou a olhar para Will, havia um pequeno corte em cima de seu olho esquerdo. 
<p>- Se eu fosse você, pediria desculpas. – Paul sorriu limpando o sangue com um dedo molhado de cuspe. 
<p>- Acho melhor eu ir embora antes que eu te soque de novo.
<p>Will deu um soco com a outra mão na madeira do balcão e saiu do bar. Já estava bem tarde e aquele bairro não era muito movimentado naquela hora. Não era um lugar muito bem iluminado também, muitos postes estavam com suas luzes queimadas. Não demorou muito até ele perceber que estava sendo seguido.
<p>- Aí vem o show. – Ele disse baixinho até se virar e encarar os dois caras que o seguia. – Nossa, eu não sabia que paredes andavam hoje em dia. 
<p>Aqueles homens eram como paredes mesmo. Dois metros de altura e totalmente quadrados. Mal se via os pescoços deles de tanto músculo. 
<p>- Senhores... – Will abriu os braços.
<p>Os dois continuaram em silêncio. 
<p>- Sabe, eu acho que é meio que uma desvantagem, vocês contra mim. Eu sou bom, mas não tanto assim. – Will sorriu. 
<p>Um dos homens se aproximou de Will e sem aviso prévio o socou tão forte que o fez cair. Will sentiu o cheiro do asfalto quando seu rosto bateu no chão. 
<p>- Belo soco. – Will cuspiu o sangue e se levantou. – Foi sua mãe que te ensinou? – Ele sorriu. – Por que agora não vem para valer? Está ficando feio. 
<p>Dois segundos depois, ele estava no chão de novo. Seu nariz sangrava assim como sua boca. Seu rosto estava cheio de arranhões causados pelo asfalto. 
<p>- Ah, qual é? – Ele apoiou suas mãos machucadas no chão para tentar se levantar, mas levou um chute no estomago antes mesmo de se levantar. – Vocês são bons, hein? – Ele riu enquanto cuspia o sangue para fora da boca. – Eu preciso dizer.
<p>Outro chute na costela fez ele rolar pelo chão e arranhar mais o rosto. 
<p>- Paul mandou te dar um recado. – Will viu uma sombra se aproximar de seu ouvido. – Da próxima vez, você não vai ter tanta sorte. 
<p>- Isso é sorte? – Will riu com os dentes todos vermelhos de sangue. 
<p>Ele levou outro chute no estomago antes de ser deixado caído no chão por aqueles “monstros bombados”, como ele pensou. Ele sentiu umas pontadas quando tentou respirar, não era a dor cruciante que ele queria sentir, mas estava no caminho. Ficou olhando para a lua cheia enquanto juntava forças para se levantar. 
<p>Sentiu seu celular vibrando em seu bolso. Com certeza, era Emily. Ele estava atrasado para deitar em uma cama e ficar ouvindo coisas que ele não queria ouvir. Ele estava onde queria estar. Deitado no meio da rua sangrando. Se ele tivesse sorte, um carro passaria por cima dele antes do amanhecer.</p>
<center><h4>--*--</h4></center>
<p><i>Não há nada que se possa fazer. Eu sinto muito, mas seu irmão morreu...</i>
<p>- Will!
<p>Emily ficou horrorizada quando viu o estado do namorado quando ele chegou em casa. Ela estava sentada no sofá com o celular na mão quando ouviu o barulho da porta se abrindo.
<p>- Não... surta. – Will falou bem devagar. Doía um pouco quando ele falava, andava e respirava.
<p>- Como eu não vou surtar?! O que aconteceu com você?! – Ela foi até ele imediatamente.
<p>- Eu... fui... assaltado. 
<p>- E não levaram nada? Porque eu estou vendo o celular no seu bolso. Will, o que aconteceu? – Ela o olhou dos pés à cabeça para avaliar a situação em que o namorado se encontrava. 
<p>- Eu entrei em uma briga, não foi nada demais.
<p>- Briga com quem e por quê?
<p>- A gente fala sobre isso amanhã, eu preciso...
<p>- Vamos falar sobre isso agora. 
<p>- Eu mal estou... me aguentando em pé. 
<p>- Will... – Emily suplicou. 
<p>- Eu comecei a briga. E eu não quero ouvir sermão nem nada disso. Eu só quero... – Mas Will não sabia o que queria. 
<p>- Vamos para cozinha, eu vou limpar seu rosto. 
<p>Os dois foram até a cozinha. Will se sentou em uma das cadeiras com um pouco de dificuldade e ficou observando, em silêncio, Emily encher uma vasilha com água e pegando um pano de prato em uma das gavetas do armário. 
<p>- Conversa comigo. Por favor. – Ela começou a passar o pano molhado nos ferimentos do rosto dele enquanto ele fazia uma careta causada pela ardência dos arranhões e feridas abertas. 
<p>- Eu não estou melhorando. Não importa o quão limpo fique essas feridas. Eu não vou melhorar. – Os olhos de Will começaram a se encher de lágrimas. – Eu estou me sentindo vazio e não tem nada que possa preencher isso.
<p>- Eu sei.
<p>- E o que eu vou fazer? Meu irmão está morto. O que eu faço agora? 
<p>- Eu sinceramente não sei, mas não pode fazer isso. – Emily começou a ficar com olhos cheios de lágrimas também. 
<p>- Eu dei um soco em um traficante e os capangas dele fizeram isso comigo.
<p>- Will!
<p>- Eu só não voltei para o bar para continuar brigando porque eu não conseguia levantar. Eu não sei o que está acontecendo comigo.
<p>- Está se punindo. Mas você precisa entender que nada disso foi sua culpa.
<p>- Então por que tem uma voz na minha cabeça dizendo que eu disse para ele que ele podia morrer? Que eu não quis salvá-lo? Que eu fiz tudo errado? 
<p>- Porque essa voz só quer uma coisa. Sua destruição. Não podemos viver pelos mortos, Will. Eu aprendi isso do jeito mais difícil. Estamos vivos, devíamos focar nisso. 
<p>- Eu queria não ter voltado para casa.
<p>Will começou a chorar descontroladamente. Emily encostou sua testa na dele e segurou bem forte suas mãos e caiu no choro também. 
<p>- Eu também.</p>
<center><h4>--*--</h4></center>
<p><i>Não há nada que se possa fazer. Eu sinto muito, mas seu irmão morreu...</i>
<p>- Me disseram que seria bom eu estar aqui hoje e eu estou começando a acreditar nisso. – Will havia colocado um banquinho em cima do palco. Josh havia colocado mais mesas e cadeiras escondendo a pista de dança. Naquela noite, o show não seria para dançar. – Eu não sei se vocês sabem, mas... meu irmão morreu faz duas semanas. É... – Ele respondeu os murmúrios de pena da plateia. – Eu não vou e nem quero ficar aqui cantando músicas animadas e positivas ou falando sobre coração partido, não é isso que eu quero passar essa noite. O que eu quero... Todos nós enfrentamos alguma coisa, estamos enfrentando agora. E nessas horas ninguém aqui liga o rádio no último volume com uma música feliz. Então... Eu quero que pensem em uma música... aquela música que mesmo triste, te consola em um dia difícil, aquela música que mesmo tendo uma letra fodida, te ajuda a superar. Eu vou cantar essas músicas para vocês hoje. Escrevam em um guardanapo, que seja, e me mande. Se eu não souber a letra, eu aprendo. Estamos todos juntos nessa hoje à noite. 
<p>Will colocou o microfone no pedestal e apoiou suas mãos no canto do banco. Suas mãos estavam quase curadas. Seu rosto ainda tinha alguns vestígios da briga, mas estavam se curando também. Agora com aquilo, com aquela noite, ele esperava se curar também.
<p>- Eu vou começar com a minha. – Ele respirou fundo enquanto a banda entrava no ritmo. - <i>Me abrace agora... Porque eu não poderia mesmo se tentasse. Agora acabou... eu acho que minha hora finalmente chegou. Eu não quero ir... Mas chegou a hora de dizer adeus. Então me abrace agora... porque vai ser nossa última vez...</i>
<p>É, era muito mórbida. 
<p>- <i>Eu estou desacelerando... E eu não acho que eu possa lutar contra isso. Eu sei que de alguma forma... você vai encontrar uma maneira de viver sua vida. Se lembre só de viver cada dia como se fosse o último. E me abrace agora... Porque eu acho que minha hora chegou.</i>
<p>Will limpou as lágrimas do rosto. 
<p>- <i>Eu não quero morrer. Eu não sei porque esse tipo de destino foi feito para mim. Você tem que ser forte, tem que seguir em frente. Não é como deveria ser. E o que eu posso dizer? Não era para acabar desta forma. O que eu tenho que fazer? Era para eu envelhecer com você. Mas isso não vai acontecer.</i>
<p>Ele engoliu o choro.
<p>- <i>Não, isso não vai acontecer</i>.</p>
</body>
</html>";
            }

            if (numero == 45)
            {
                lblTitulo.Text = "Capítulo 45 - Eu Não Quero Mais Ficar Triste";
                htmlPage.Html = @"<html>
<body>
<p><i>“Não, eu não quero ficar triste
<br>Eu não quero mais ficar triste
<br>E eu sei, alguns dias vão ser ruins
<br>Mas eu não quero mais ficar triste”
<br><b>I Don’t Wanna Be Sad - Simple Plan</b></i></p>
<br>
<p>Will abriu os olhos. 
<p>Dormir ainda estava sendo difícil para ele, mas às vezes o cansaço o vencia e ele conseguia relaxar. 
<p>Naquela manhã, Emily dormia profundamente ao seu lado. Ele conseguiu ver os raios de sol iluminando o quarto pela janela, mas ainda era muito cedo. Não queria se mexer ao levantar da cama e acordá-la, então continuou deitado abraçado com ela. Aquilo ainda o acalmava. 
<p>Emily se mexeu.
<p>- Você pensa demais. – Ela murmurou ainda sem abrir os olhos.
<p>- Mas você...
<p>- Eu não preciso ler seus pensamentos nem ver a sua cara para saber que você pensa demais. 
<p>- É justo. Obrigado por passar a noite.
<p>- Você me pediu e eu fiquei. – Emily abriu os olhos e o beijou.
<p>- Eu sei que faz um tempo que eu não digo, mas eu te amo.
<p>- Eu sei. 
<p>- Ah é? – Will riu.
<p>- Olha só, um sorriso. Não vemos isso com muita frequência ultimamente.
<p>- É, eu sei. – Will se espreguiçou ainda deitado. – Ai, eu quero ficar aqui o dia todo. 
<p>- Não podemos. – Emily se levantou. – Suas provas finais começam hoje, se lembra?
<p>- O quê? – Will tentou se lembrar de qual aula ele teria naquele dia. 
<p>- São importantes.
<p>- Ems... – Ele começou a resmungar. – Eu não estou com cabeça para...
<p>- Will, a gente já falou sobre isso.
<p>- É, eu sei. Temos que continuar, ninguém vai parar por nossa causa. 
<p>- Exato. Eu sei que é horrível, mas...
<p>- Tudo bem. 
<p>- Só, por favor, não tente se machucar de novo. – Ela pegou na mão de Will. – Eu estou aqui, conversa comigo.
<p>- Eu não sei o que eu tinha na cabeça quando fiz isso. – Will olhou para as mãos. As cicatrizes ainda estavam bem visíveis.
<p>- Tudo bem. 
<p>- Sabe, eu estava pensando... podemos marcar aquele jantar com os nossos pais para contar a novidade. – Will passou os dedos pelo anel de Emily.
<p>- Acho melhor esperarmos um pouco.
<p>- Já está desistindo? – Will riu. 
<p>- Não é isso.
<p>- Eu sei. E tem razão, é melhor mesmo a gente esperar um pouco. E enquanto esperamos...
<p>Will se levantou, puxou Emily pela cintura e os dois caíram na cama.
<p>- Não, Will, para. A gente vai se atrasar. – Ela começou a rir.
<p>- Vai valer a pena. 
<p>- Vamos perder a hora. – Emily tentou se esquivar, mas não estava tão convencida de que fazer aquilo era o que ela queria.
<p>- Como eu disse, vai valer a pena.
<p>Will começou a beijá-la.</p> 
<center><h4>--*--</h4></center>
<p>- Como acha que vai se sair na prova? – Emily encontrou Amanda sentada em uma das mesinhas no meio do pátio da escola. Ela estava bem concentrada lendo um livro que Emily não conseguiu ver a capa.
<p>- Acho que vou bem. 
<p>- É, eu também. – Emily se sentou ao lado dela. – Eu não te vejo sozinha faz um tempo.
<p>- Eu mandei o Jason me deixar em paz um pouco. O garoto sabe como sufocar alguém. – Ela soltou um riso. 
<p>- Estava sendo tão ruim assim?
<p>- Pior. – Amanda fechou o livro. – Olha, sua função é cuidar do meu irmão, não de mim. 
<p>- Eu não quero cuidar de ninguém, eu só estava puxando papo com a minha amiga.
<p>- Não, está bancando a prestativa. E eu odeio isso.  
<p>- Tudo bem. 
<p>Emily pegou seu celular no bolso da calça e focou sua atenção na tela. Amanda voltou para seu livro e as duas ficaram em silêncio por alguns minutos.
<p>- Vocês viram o Chris? – Quinn se aproximou das duas. – Ele sumiu faz algumas horas e não me responde. Já estou ficando preocupada. – Ela se sentou ao lado das duas. 
<p>- Ele não vai se quebrar se ficar um pouco sozinho. Na verdade, é o que muitos estão precisando. É horrível não se tocar.  – Amanda fechou a cara e Quinn se assustou.
<p>- Qual é o seu problema? – Quinn a enfrentou. 
<p>- É sério? – Amanda a encarou. 
<p>- Olha, eu sei que você está mal, todos estamos, mas...
<p>- Não, não todos. Você mal conhecia o Kevin. Ele não era seu irmão e não foi você que... – Então ela parou de falar. 
<p>- Eu sei que está sofrendo, mas podia ser um pouco mais gentil. – Quinn não tinha papas na língua.  
<p>- Sai daqui.
<p>- Gente, vamos parar... – Emily tentou apaziguar as coisas.
<p>- Eu já disse para saírem daqui! – Amanda jogou o livro no chão. – Sabe, quando eu descobri o que o Kevin tinha feito com o Sebastian, eu o julguei, e julguei muito. Eu torci para que mandassem ele para a cadeia. Eu não tive dó, nem pena, só queria que ele se ferrasse. Ele só fez burrada, eu estou triste agora, mas sei que quando a tristeza passar, vou me sentir aliviada por ele estar morto, agora esse clima tenso na minha família vai acabar. Era isso que queriam ouvir? Estão felizes? – Os olhos de Amanda se encheram de lágrimas. 
<p>- É, você tem razão. Eu não conhecia o Kevin muito bem. Na verdade, só vi os piores momentos dele. – Quinn respirou fundo. – Mas eu tenho uma irmã e eu morreria se acontecesse alguma coisa com ela. Você está com raiva, eu sei, e tudo bem descontar nas pessoas, se isso te ajudar, mas não tente afastar ninguém. Ficar sozinha não é a melhor escolha. – Quinn pegou na mão de Amanda e ela não se afastou. 
<p>- Eu fui a última a falar com ele. – Emily começou a falar. – E de algum jeito, o que eu falei, fez ele ir embora, fez ele fugir. Eu achei que estava ajudando. Eu pedi para o Will fazer o retorno, eu realmente achei que estava ajudando, mas tudo o que eu fiz foi fazê-lo encontrar o irmão morrendo fora da estrada. 
<p>- Vamos parar com essa “deprê”? – Quinn levantou a sobrancelha. – Vamos sair, fazer compras, falar de garotos, ver um filme. 
<p>- Parece interessante. – Amanda estava quase se rendendo. 
<p>- Eu quero uma pizza. – Emily falou.</p>  
<center><h4>--*--</h4></center>
<p>Will estava sentado no sofá quando seu pai entrou em casa bem apressado.
<p>- Filho, eu não... – Robert parou no meio da escada. – Achei que estava na escola.
<p>- Eu fiz a prova e vim embora. 
<p>- Sabe, eu estava... – Ele foi em direção ao sofá. – Sabe que minha proposta com a gravadora ainda está de pé, não é?
<p>- Pai, eu...
<p>- Eu sei. Eu só queria dizer que sinto muito.
<p>- Pai, para.
<p>- Não, é sério. Eu sinto muito não ter percebido antes. 
<p>- Percebido o quê? – Will se levantou do sofá.
<p>- Seu sonho. Se ele é importante para você, também é importante para mim. E eu vou te apoiar em cada decisão que você tomar sobre isso.
<p>- Pai, não precisa falar essas coisas. 
<p>- Preciso sim. 
<p>Robert abraçou Will bem forte. O primeiro pensamento de Will foi se afastar, mas mesmo parecendo bem estranho, ele ficou e retribuiu o abraço.
<p>- Eu te amo.
<p>- Eu tenho a sensação que você vai ficar dizendo “eu te amo” a cada cinco minutos. – Will riu.
<p>- E você está certo.
<p>- Eu também te amo. E o Kevin também te amava.
<p>- Eu sei. – Os olhos de Robert ficaram vermelhos só de ouvir o nome. – Só queria ter feito melhor o meu trabalho.
<p>- Você fez o que podia.</p> 
<center><h4>--*--</h4></center>
<p>- Mãe? Estou entrando.
<p>Sebastian entrou no quarto de sua mãe com uma bandeja. Karen não comia fazia um tempo e ele se preocupou. Isso também era uma desculpa para entrar no quarto e conversar com ela, sentia falta dela.
<p>- Querido, eu não estou com fome. – Karen estava deitada ainda de pijama.
<p>- A senhora precisa comer.
<p>Ele colocou a bandeja no criado mudo ao lado da cama. Doía nele ver a mãe naquele estado. O rosto dela estava inchado de tanto chorar e seus olhos tinham muitas olheiras e era bem nítido, já que estava muito pálida. 
<p>- Chris disse que a senhora não come. – Sebastian se sentou na cama perto dela.
<p>- Eu ando sem fome, mas isso vai passar. Eu vou ficar bem. – Sua voz também estava fraca. 
<p>- Estou preocupado.
<p>- Não precisa, querido. 
<p>- Eu sinto muito também. 
<p>- Não foi sua culpa.
<p>- Não por isso, mas todas as vezes que você ficou no hospital esperando para saber se eu ia sobreviver ou não. Eu sinto muito mesmo e eu prometo que isso nunca mais vai acontecer. – Ele pegou na mão dela. 
<p>- Eu sei, Sebastian. Isso também não é sua culpa e eu te amo mesmo assim. 
<p>- Eu sei que não é a melhor hora de perguntar sobre isso, mas... Nunca se arrependeu? Nenhum pouco?
<p>- Nunca. – Ela fez que não com a cabeça para completar. – Porque dizem que filhos a gente não escolhe, mas eu escolhi você... e escolher você para ser mais um dos meus filhos foi a melhor coisa que eu fiz. 
<p>- A senhora me salvou. Sabe disso, não sabe?
<p>- Você fez tudo praticamente sozinho. 
<p>- Não, eu não conseguiria sem a minha mãe.
<p>- Só está dizendo isso para fazer eu me sentir melhor. – Ela tentou rir, mas não conseguiu.
<p>- Não, estou dizendo porque é a verdade. Eu te amo.
<p>- Eu também te amo, querido.
<p>Sebastian se aproximou mais da mãe e a abraçou. Ela começou a chorar em seu ombro. Ele não disse nada, sabia que nada que falasse ajudaria, não naquele momento, então ficou lá abraçado com a sua mãe aos prantos, na esperança que aquilo amenizasse pelo menos um pouco a dor dela depois.</p> 
<center><h4>--*--</h4></center>
<p>- Eu atendo!
<p>Emily desceu as escadas correndo para atender a porta. Ela nem precisava ter gritado, já que parecia que ninguém estava ouvindo a campainha tocar.
<p>- Giovanna! – Emily não conseguiu disfarçar a surpresa no rosto de ver Giovanna parada em sua porta.
<p>- Oi. – Ela estava um pouco pálida e havia perdido bastante peso. Seu olhar conhecido de cinismo não estava lá também. 
<p>- O que está fazendo aqui?
<p>- Eu estou indo embora amanhã para Seattle passar as férias com uns tios meus, mas eu queria falar com você antes. – Sua voz estava fraca também.
<p>- Mas ainda tem algumas provas e... – Emily não sabia porque estava preocupada.
<p>- Meus pais conversaram com o diretor, eu vou poder fazer algumas atividades e enviar por e-mail. Ele entendeu que eu não posso mais ficar aqui. 
<p>- Giovanna, eu...
<p>- Me desculpa. – Seus olhos se encheram de lágrimas. – Me desculpa por tudo o que eu fiz para você. Agora é sério, eu juro.
<p>- Não precisa...
<p>- Me desculpa pelas mentiras, pelas coisas horríveis que eu disse, por ter te atacado feito uma louca, eu nem sei porque eu fiz isso. Eu amava o Will, mas ele não tinha culpa de não me amar de volta, muito menos você. Me desculpa por não perceber o quanto vocês se amavam e o quanto eu estava fazendo mal a vocês. – Ela engoliu o choro. – Me desculpa por essa perseguição sem sentido. Eu nunca quis ser uma pessoa ruim, eu juro, eu nunca achei que... Eu sinto muito.
<p>- Giovanna... – Emily não sabia o que dizer. Só sentiu uma coisa horrorosa no estômago. 
<p>- Por favor, me perdoa. Eu sei que eu fui uma pessoa horrorosa com você. Eu sei que eu fiz o impossível para te deixar mal. Eu sei que eu me aproximei do Kevin por vingança e despeito e usei ele e isso... Me desculpa, por favor.
<p>- Giovanna, está tudo bem. Você não precisa se desculpar e também não precisa ir embora.
<p>- Eu não posso ficar aqui. – Ela soluçou. – Eu não posso olhar para a cara de todo mundo enquanto todos sabem que fui eu que destruí a vida dele.
<p>- As escolhas foram dele. 
<p>- Eu vi ele se drogando e eu... eu não fiquei preocupada, eu só fingi para tentar me aproximar do Will. Se eu realmente tivesse me preocupado... Ele me ouviria, eu sei que me ouviria, mas eu não...
<p>- Olha, todos nós cometemos erros e... isso não nos faz pessoas ruins, só nos faz pessoas. Olha, você precisa conversar com alguém, e tirar isso do seu peito. Não é bom viver assim. 
<p>- Para, não precisa ser legal comigo. Eu fiz da sua vida um inferno.
<p>- É verdade, mas, sabe, eu percebi uma coisa. Rancor e raiva são sentimentos desperdiçados. No final, nada disso importa. Não vai ser da raiva e do rancor que vamos nos lembrar quando estivermos... – Ela não conseguiu terminar.
<p>Emily deu um passo à frente, abraçou Giovanna e sentiu uma paz que não sentia fazia um tempo.</p> 
<center><h4>--*--</h4></center>
<p>Jason estava sentado bem no meio da quadra quando Will chegou. Os dois não iam lá fazia dias e não conversavam um com o outro fazia um tempo também. 
<p>- Oi. – Will se sentou de frente dele.
<p>- Como você está? – Jason o analisava.
<p>- Estou bem. 
<p>- Então já posso me desculpar por não aparecer. 
<p>- Você estava com a Amanda. Nem você consegue ser duas pessoas ao mesmo tempo. – Will soltou um riso. 
<p>- É, mas... amigos antes de garotas, não é? – Jason riu.
<p>- Acho que não nessa situação. 
<p>- Para falar a verdade, eu usei a Amanda como desculpa. Me preocupar com ela fez com que eu me preocupasse menos comigo e com você. Um em dois não é tão ruim.
<p>- Jay.
<p>- Era o Kevin, cara. Quando éramos pequenos, fazíamos sopa de terra para ele comer. 
<p>- Eu me lembro disso. – Will riu em lembrar. 
<p>- Eu praticamente cresci na sua casa e sempre considerei todos meus irmãos. Eu não ia conseguir te ajudar, ia piorar tudo.
<p>- Está tudo bem agora, Jason. 
<p>- Está mesmo? – Ele olhou para as mãos de Will.
<p>- Ainda dói. Não as mãos, mas ainda dói. O engraçado é que agora eu não penso nas vezes que ele me tirou do sério ou quando eu o soquei porque ele tinha me tirado do sério, nem no momento...
<p>- O que pensa então?
<p>- Quando o Sebastian teve a primeira overdose morando em casa, e no hospital, o Kevin bem pequeno, disse que queria ser médico para ajudar pessoas como o irmão dele. É nisso que eu penso. É triste ele ter morrido, mas mais triste ainda é que em seus últimos dias, ele não foi ele mesmo. Ele morreu perdido, totalmente irreconhecível. Todos deveríamos ter uma chance, mas ele não teve. 
<p>- É, eu não quero perder a minha chance. 
<p>- Nem eu. Mas eu estou me cansando de pensar nessas coisas, estou cansado de ficar estagnado no passado.  
<p>- O que quer dizer?
<p>- Eu sempre vou sofrer pelo Kevin, eu nunca vou superar o que aconteceu com ele, eu nem superei o que aconteceu com a Angie, mas eu não quero mais viver assim. Eu não quero mais ficar triste o tempo todo. Eu quero ser feliz!
<p>- É, eu também.
<p>- E a gente merece, Jason. A gente foi até o inferno e voltou. Temos que pegar esse rumo para felicidade.
<p>- Eu gostei disso. – Sebastian se aproximou dos dois andando bem devagar. Ele ainda deveria estar de repouso na cama de seu quarto, mas estava sendo impossível para ele ficar deitado o dia todo. 
<p>- Devia estar na cama. – Will o alertou.
<p>- Ah, eu odeio a cama. – Sebastian se sentou ao lado dos amigos.
<p>- A não ser que a Melissa esteja nela, não é? – Jason brincou.
<p>- Aí a coisa muda de figura. – Sebastian riu. 
<p>- Eu amo vocês. – Will falou.
<p>- Para com isso. – Jason começou a rir.
<p>- Eu também amo vocês. – Sebastian gostava de dizer. 
<p>- Tá, eu também amo. – Jason fingiu desanimo e fez os outros dois rirem.</p> 
<center><h4>--*--</h4></center>
<p>- Ai meu Deus, você tinha um cabeção quando era criança. – Quinn começou a rir de Chris.
<p>Os dois estavam deitados na cama vendo algumas fotos de infância que Chris havia achado em uma caixa e levado para a casa de Quinn. Ultimamente, ele estava se sentindo muito nostálgico. Preferia pensar no passado do que no presente que era triste ou no futuro que era assustador. 
<p>- Todas as crianças são cabeçudas. – Chris retrucou.
<p>- Não são, não. – Ela continuava a rir.
<p>- Olha, esquece isso. Essa aqui foi no meu aniversário de seis anos. – Chris mostrou uma outra foto para Quinn.
<p>- Esse é o Kevin quase em cima do bolo?
<p>- É sim. Ele não podia ver um bolo que já queria comer. Nunca soube esperar.
<p>- É bem a cara dele.
<p>- Eu preciso encontrar uma foto. Tenho certeza que está por aqui. – Chris começou a mexer na caixa. – Aqui.
<p>- Qual é a história dessa foto? – Quinn viu a imagem de duas crianças sentadas em uma casinha de madeira ao lado de uma árvore bem robusta. 
<p>- Quando éramos pequenos, nosso pai construiu uma casa na árvore para gente, só que o Kevin tinha medo de altura, então nosso pai construiu uma no chão também. Só que ninguém queria ficar com ele no chão.
<p>- Aí você ficou com ele.
<p>- Houve uma época em que eu fazia tudo por ele, éramos melhores amigos. É horrível perder o seu melhor amigo.
<p>- Olha, eu não sou muito boa nessas coisas, mas pode contar comigo. Posso ser sua nova melhor amiga, e ainda com bônus.
<p>- Parece ser uma coisa boa.
<p>- Só parece? – Quinn o beijou.
<p>- É uma coisa muito boa. – Ele riu.
<p>- Com um beijo, a sua perna já vibra? – Quinn brincou.
<p>- É o meu celular, boboca. – Chris começou a rir. – É uma mensagem do Will, eu preciso ir.
<p>- Algum problema? 
<p>- Não, só... disse que é importante. 
<p>- Posso ficar com as fotos?
<p>- Claro, o que é meu é seu.
<p>- Mas já? – Quinn ficou impressionada.
<p>- Relaxa, não foi um “eu te amo”.
<p>- Não foi?
<p>- Ainda não. – Chris beijou Quinn e se despediu.</p>
<center><h4>--*--</h4></center>
<p>- Cheguei a pensar que eu não precisaria vir aqui pedir para você se levantar, mas aqui estou eu. 
<p>Will entrou no quarto de sua mãe sem ao menos bater na porta. Karen estava deitada na cama segurando bem forte um travesseiro. 
<p>- Filho, eu estou bem.
<p>- Mãe, ninguém nessa casa está bem.
<p>- Bom...
<p>- Vamos descer. Esticar as pernas, comer alguma coisa. – Will se aproximou mais dela. 
<p>- Eu estou sem fome.
<p>- Vamos para a praia então. O sol está lindo. Eu até tento te ensinar a surfar se você quiser.
<p>- Que oferta tentadora. – Karen mostrou um sorriso só para tentar agradar seu filho. – Mas eu estou bem aqui e você não sabe como surfar. 
<p>- Podemos aprender juntos então. – Ela sorriu para encorajar a mãe, mas não adiantou. – Mãe, eu te amo e não consigo te ver desse jeito.
<p>- Eu só preciso de um tempo. Só isso.
<p>- O tempo não vai ajudar, mãe. Isso sempre vai estar com a gente. – Will se sentou na cama. 
<p>- Olha, eu sei que eu não estou sendo uma boa mãe ultimamente e eu deveria ser a pessoa que dá força para vocês, eu sei...
<p>- Não, mãe. O problema não é você. Você é a melhor mãe do mundo. – Will pegou na mão de sua mãe. – Você fez tudo por nós, está na hora da gente fazer tudo por você. Vamos descer.
<p>- Filho, eu não quero.
<p>- Não me faça implorar. Você sabe que eu sou um saco e só vou sair daqui quando você vier junto.
<p>- Nisso você puxou o seu pai.
<p>- Acho que não. Vem. – Peguei na outra mão dela para guiá-la. – Vamos juntar nossas dores.
<p>Mesmo hesitando, Karen se levantou da cama e Will a guiou para fora do quarto. Ela estava fraca por não ter comido nem dormido o suficiente, então desceram as escadas bem devagarzinho. Robert, Chris, Amanda, Sebastian e Matt os esperavam lá embaixo na sala. 
<p>- O que está acontecendo aqui? – Karen olhou cada um por bastante tempo.
<p>- É a família unida, mamãe. – Matt falou sorrindo. 
<p>- Eu chamo isso de intervenção. – Will sorriu para a sua mãe que segurava bem forte seu braço. 
<p>- Mãe... – Amanda começou a falar. – Perdemos o Kevin, mas ainda estamos aqui e nos amamos. Eu amo você.
<p>- Querida... – Ela não conseguiu terminar a frase.
<p>- Vamos fazer de tudo para te deixar bem. – Chris sorriu. – Vamos te dar força por todas às vezes que a senhora nos deu força. Eu te amo, mãe.
<p>- Eu também, querido. – Karen limpou suas lágrimas do rosto.
<p>- Não importa quantas vezes eu disser que te amo, nunca vai ser o suficiente. Eu nunca tinha conhecido o amor até que a senhora entrou na minha vida. – Sebastian já estava chorando.
<p>- Querido...
<p>- Eu amo você, mamãe. Eu estava com muita saudade. – Matt correu e abraçou as pernas da mãe. 
<p>- Filho... – Karen colocou uma de suas mãos nas costas de seu filho caçula e sorriu.
<p>- Amor, você sempre foi o meu porto seguro. Casamento é assim, na alegria e na tristeza. Eu também não estou bem, mas juntos vamos superar, eu sei que vamos. – Robert também estava com o rosto cheio de lágrimas. 
<p>- Eu te amo, mãe. E todos nós estamos aqui por você. – Will apertou a mão da mãe que estava em seu braço.
<p>- Vocês são a minha vida. Eu também amo muito vocês.
<p>Amanda correu até a mãe para abraçá-la, já em prantos. Logo depois veio Sebastian e Chris. Robert veio por último e ficou em volta de todo mundo.
<p>Eles não costumavam fazer um abraço coletivo, mas o momento pedia e estava fazendo muito bem.</p> 
<center><h4>--*--</h4></center>
<p>- Nossa, eu pagaria para ver a Giovanna nesse estado. – Quinn abriu a boca em estado de choque enquanto ouvia Emily contar sua história.
<p>- Não tem graça. – Emily ainda estava abalada com aquela conversa. 
<p>- Eu não disse que tinha.
<p>As duas estavam deitadas na cama de Quinn. 
<p>- Isso mexeu muito comigo, sabe. – Emily olhava fixamente para o teto. 
<p>- Por quê?
<p>- Isso não deveria ter acontecido. Eu não consigo aceitar. Acontecem tantas coisas erradas no mundo, mas...
<p>- Emily...
<p>- Tem tanta gente que faz tanto mal, e aí um garoto faz uma escolha errada e morre. Não faz sentido.
<p>- Não é assim que funciona. – Quinn odiava esse tipo de conversa.
<p>- Então como funciona?
<p>- Acho que nunca vai encontrar a sua resposta. É só a morte.
<p>- É uma droga.
<p>- Você não pode fazer isso. – Quinn observou a irmã.
<p>- Do que você está falando?
<p>- Se segurar. Você sempre faz isso. 
<p>- Eu não estou me segurando. Eu fiquei chorando por três dias seguidos. Mal conseguia respirar. 
<p>- Parece que não foi o suficiente.
<p>- Eu não quero mais chorar. Chorar não adianta nada. – Emily sentiu as lagrimas escorrendo no seu rosto. – Ele não teve culpa. Ele não sabia o que estava fazendo.
<p>- Eu acho que ele sabia, só não sabia que podia morrer. 
<p>- É horrível. 
<p>- Talvez nos sirva como alguma lição.
<p>- Não tem lição nenhuma aqui, Quinn. Não tem nada. E... eu não falei naquela hora, mas... eu também morreria se acontecesse algo com você.
<p>- Eu sei. 
<p>As duas deram as mãos uma para a outra.</p>
<center><h4>--*--</h4></center>
<p>- Esse lugar é muito bonito e eu adorei essa caminhonete. 
<p>Will havia alugado aquela caminhonete por mais duas semanas. Sempre que ele ia na loja de aluguel, prometia a si mesmo que compraria seu carro futuramente, mas nunca cumpria. Naquele momento, a caminhonete estava estacionada na colina mais alta que Will encontrou, e Emily e ele estavam deitados na caçamba olhando para o céu. 
<p>- É, acho que eu vou comprar uma. Poderíamos conceber nossos filhos aqui. 
<p>- A gente nem casou ainda e você já está falando sobre filhos? – Emily começou a rir.
<p>- Rápido demais, não é? – Ele riu junto. – Sabe, depois da conversa que eu tive com o Jason e o Sebastian e depois com a minha mãe... Eu andei pensando...
<p>- O quê?
<p>- Você se lembra quando a Angie morreu e você inscreveu a gente na corrida? – Emily confirmou com a cabeça. – E depois mencionou um show de amadores em Nova York...
<p>- Lembro.
<p>- Ele começa em seis dias. É, eu pesquisei. E o Coldplay vai fechar o show. 
<p>- É, você pesquisou.
<p>- Acha que seria tarde para eu fazer a inscrição? 
<p>- Eu acho que sim, mas...
<p>- Podemos ir só para assistir. Podemos ir todos nós. Chris pode pegar a van do papai e... Todos nós curtimos.
<p>- Podemos ir de avião, sabia? Dividimos em dez vezes.
<p>- Ah, mas pela estrada é mais divertido. 
<p>- É loucura.
<p>- É divertido. – Will a corrigiu. 
<p>- Ninguém vai aceitar. Todo mundo está preocupado com o resto das provas. Essa semana seria para gente estudar e... 
<p>- Podemos estudar na estrada. Só um vai precisar dirigir. – Will explicou. 
<p>- Will...
<p>- Eu posso cantar <i>Fix You</i> para te convencer. 
<p>- Não precisa me convencer. Todas as loucuras que você inventa, eu topo, não é? Só quero ver se os outros vão topar. 
<p>- Eu vou convencer eles e você vai me ajudar. – Will pegou o celular do bolso e começou a digitar.
<p>- O que está fazendo?
<p>- Mandando mensagens. Estou chamando todo mundo para vir aqui.
<p>- Agora?! – Emily se assustou.
<p>- É, se todos toparem, vamos ter que sair amanhã de manhã. Não se preocupa, vamos ter a noite toda para nos divertir. – Will passou seu braço em torno de Emily e a beijou. – Você me inscreveu no show, não me inscreveu?
<p>- O que foi que me entregou? – Emily sorriu.
<p>- Nada. É que... é o que você faz. Quando ia me contar?
<p>- Quinta à noite, eu já estava até me preparando para comprar as passagens. 
<p>- Eu te amo. 
<p>- Deveria mesmo.</p>
<center><h4>--*--</h4></center>
<p>- O que estamos fazendo aqui? – Amanda saiu do carro olhando para todo o lado esperando encontrar algo estranho. – A gente não podia ter se encontrado em um bar?
<p>- Queria que vocês se locomovessem, não a gente. – Will e Emily estavam sentados na caçamba enrolados em uma manta. 
<p>Chris saiu do banco do motorista e também estava um pouco desconfiado. Jason, Quinn, Melissa e Sebastian saíram depois dos bancos de trás.
<p>- Que bom que vieram de van, porque... vamos precisar dela. – Will falou.
<p>- Will, o que está acontecendo? – Jason se aproximou da caminhonete. 
<p>- Precisamos estar em Nova York até sexta à noite. Se sairmos amanhã cedo, chegamos na sexta de manhã. Emily e eu vamos na caminhonete e vocês vão na van. – Wil explicou como se fosse a coisa mais simples do mundo.
<p>- Por que precisamos ir para Nova York? – Melissa levantou uma das sobrancelhas. 
<p>- Ah, eu tenho um show lá. E depois tem Coldplay.
<p>- É sério? – Chris arregalou os olhos.
<p>- É. 
<p>- Gente, não podemos ir. Semana que vem tem o resto das provas e... Se sairmos de lá no sábado, nunca chegaremos aqui na segunda. – Quinn fez os cálculos.
<p>- Will já pensou em tudo. – Emily falou. – Podemos trocar de motorista e quem estiver no banco de passageiro, estuda.
<p>- E podem voltar de avião. E eu volto sozinho. Trago a van no gancho. – Will terminou. – Minhas provas acabaram. 
<p>- Você pensou em tudo mesmo. – Amanda riu. 
<p>- Olha, essas últimas semanas foram horríveis para todos nós. Não sei vocês, mas já cansei disso. Isso meio que pode ser um remédio e faz um tempo que a gente não faz uma coisa dessas juntos.
<p>- Da última vez que viajamos juntos, não deu muito certo. – Sebastian fez uma careta. 
<p>- Estamos diferentes agora. – Chris explicou. 
<p>- É, estamos. – Will sorriu. – E não é todo dia que eu canto na Madison Square Garden. 
<p>- Espera aí, o show é na... – Amanda mal conseguiu falar.
<p>- Isso é incrível. – Jason parecia orgulhoso. 
<p>- Eu topo. – Quinn falou. – Eu quero mesmo fazer uma loucura.
<p>- Isso aí, Quinn. – Will a apoiou. – Somos jovens, essa é a hora para fazermos loucuras. Metade de nós vamos nos formar agora e com a faculdade e trabalho... não vamos ter tanto tempo assim de ficarmos juntos. Temos que comemorar, mesmo a gente achando que... não temos motivo. 
<p>- Além do mais... – Emily olhou para Will. Os dois, minutos antes de todo mundo chegar, decidiram que havia chegado a hora de contar. – Vamos ter muita coisa para planejar ano que vem e não vamos ter tempo para viagens. 
<p>- Que coisas exatamente? – Jason ficou um pouco perdido.
<p>- Vamos nos casar. – Emily mostrou o anel que dessa vez estava no dedo certo. 
<p>Todos ficaram em silêncio por alguns segundos, provavelmente chocados demais para dizer alguma coisa. 
<p>- Casar? É sério? – Amanda foi a primeira a dizer algo.
<p>- Fiz o pedido enquanto estávamos no Tennessee. 
<p>- Mesmo estando com raiva por não ter me falado primeiro, parabéns! – Jason tomou a frente e abraçou os dois.
<p>- É, eu também estou com raiva. – Sebastian foi logo depois dele. 
<p>Um por um, eles abraçaram Will e Emily e mesmo Amanda resmungando um “isso é loucura”, ela não deixou de sorrir e parabenizar. 
<p>- Valeu, gente! – Will sorriu. 
<p>- É, eu acho que temos mesmo uma coisa para comemorar. – Melissa falou. – Eu também topo.
<p>- Eu deveria estar em repouso e fazer uma viagem tão longa não deve ser muito boa para minha saúde agora, mas... Eu também topo. – Sebastian sorriu. – E vou brigar com o Jason para ser o padrinho.
<p>- Eu não preciso nem brigar. – Jason provocou. – Eu topo.
<p>- Eu também topo e pretendo fazer a Emily desistir desse casório. – Amanda brincou.
<p>- Eu também topo. – Chris pegou na cintura de Quinn. – Não fico longe dela nem por um minuto. 
<p>- Que grude. – Quinn o beijou. 
<p>- Então, combinado. – Will falou. – Amanhã antes do sol nascer, vamos cruzar o país.
<p>- É! – Todos falaram em sintonia.</p> 
<br>
<p>“Tristeza. Quantas vezes ela te atingiu? Quantas vezes ela impediu você de fazer algo? Quantas vezes você não continuou por causa dela?
<p>Felicidade. Você procura sempre por ela, não é mesmo? Ela é fácil de alcançar? Existe alguém que é sempre feliz?
<p>A verdade é que a felicidade e a tristeza meio que andam juntas. A felicidade vem e vai, assim como a sua amiga. Só você escolhe se quer ser mais feliz ou mais triste. Ser feliz não quer dizer que você está fazendo a coisa certa, quer dizer, ela pode ser certa para você, mas não precisa ser certa para os outros. 
<p>O que os outros têm a ver com a sua felicidade? Nada. Você não precisa de ninguém para ser feliz. Seja feliz por você mesmo. A felicidade vale a pena. Às vezes ela some, mas quando aparece, não há nada melhor. 
<p>Por isso, nunca desista dela.”.</p>
</body>
</html>";
            }

            if (numero == 46)
            {
                lblTitulo.Text = "Capítulo 46 - E Eu Vou Tentar Te Consertar";
                htmlPage.Html = @"<html>
<body>
<p><i>“As luzes vão te guiar para casa
<br>E aquecer seus ossos
<br>E eu vou tentar
<br>Te consertar”
<br><b>Fix You - Coldplay</b></i></p>
<br>
<p>Como planejado, todos já estavam dentro dos carros antes mesmo do sol nascer. O dia prometia ser ensolarado embora a neblina cobrisse uma boa parte do horizonte.
<p>- Está pronta? – Will olhou sorrindo para a sua copiloto enquanto ligava o carro. 
<p>- Nem um pouco. – Emily riu.
<p>- Relaxa, eu planejei tudo.
<p>- Achei que tinha dito para eu relaxar. Como eu saber que você planejou tudo me deixa relaxada? Acho que é o oposto.
<p>- Há-há-há. Que engraçadinha.
<p>- Eu estou brincando. – Ela deu um tapa no ombro de Will. – Eu estou muito pronta e bem animada. 
<p>- Ah é? 
<p>- Você vai cantar na Madison Square Garden. – Ela não conseguia parar de sorrir. 
<p>- Olha, eu ainda não tenho certeza...
<p>- Ah, é claro que você tem. – Emily pegou seu celular e, com um cabo USB, o conectou no rádio do carro. – E eu vou te mostrar o porquê.
<p>Não demorou nem dez segundos para a música começar a tocar. 
<p>- Essa música... – A música era muito boa, na verdade. Ele a conhecia, aquela música era dele. – Emily! – Ele desligou o rádio imediatamente. – Onde conseguiu isso?
<p>- Está por toda a internet. Alguém juntou todas as suas apresentações no bar e criou até um álbum, postou o áudio no Youtube. 
<p>- É sério? – Will ficou impressionado.
<p>- É. E eu achando que eu era a sua fã número um. Não pensei nisso.
<p>- Você ainda é. Esse aí é só mais louco. – Will riu para disfarçar o quanto ficou admirado por alguém gastar tempo para fazer isso com a música dele. 
<p>- Agora liga esse rádio. 
<p>- Não. Podemos fazer nossa própria trilha sonora. 
<p>- Ah, não, Will, não. – Emily colocou a mão no rosto.
<p>E quando a caminhonete entrou na interestadual, Will abriu os vidros e começou a cantar bem alto a 120 quilômetros por hora. 
<p>- <i>O PÉ NA ESTRADA EU VOU BOTAR QUE JÁ TÁ NA HORA DE IR!</i>
<p>- Ai, meu Deus, quantos anos você tem? Dez? – Emily começou a rir.
<p>- Ah, qual é? Você adora esse desenho. Chora toda a vez que assiste. Vamos lá. <i>UM LINDO HORIZONTE E UM CÉU AZUL. O QUE MAIS EU PODERIA PEDIR?</i>
<p>- <i>Que todos saibam que lá vou eu e o que eu mais quero é chegar...</i>
<p>- <i>O QUE EU MAIS QUERO É CHEGAR!</i>
<p>- <i>Com um lindo horizonte e um céu azul, histórias eu quero contar...</i>
<p>- <i>EU QUERO CONTAR!</i>
<p>Will fez menção de tirar uma das mãos do volante para colocar para fora da janela.
<p>- Duas mãos no volante, mocinho. – Emily apontou o dedo na cara dela.
<p>- Tá bom, mãe. – Will riu. - <i>Mas que todos saibam que lá vou eu, caminhando, eu vou pro meu lar...</i>
<p>- <i>CAMINHANDO, EU VOU PARA O MEU LAR!</i> – Emily não conseguia cantar sem rir.
<p>- <i>Sob os raios do sol, sigo um sonho meu. Histórias eu quero contar... Sim, lá vou eu...</i>
<p>- <i>Olha, lá vou eu...</i></p>
<center><h4>--*--</h4></center>
<p>A primeira parada foi em uma lanchonete no meio da estrada ainda na California por volta das dez da manhã. Ninguém tinha tomado café da manhã e todos estavam famintos. 
<p>Will não se lembrava da última vez que tinha tomado café com os irmãos. Mesmo que nada que falaram pela meia hora que ficaram lá foi aproveitável, ele se sentiu tendo o melhor café da manhã da vida.
<p>Melissa era a que estava mais animada. Ela adorava aquele tipo de viagem, mesmo não tendo feito nenhuma daquele tipo em toda a sua vida. 
<p>Sebastian estava bem mais saudável do que nos últimos dias. Se alguém o visse sem saber da sua situação, diria que ele poderia correr uma maratona.
<p>Chris e Quinn pareciam em lua de mel, um dava comida na boca do outro e ninguém estava estranho com isso, até riam daquela situação. Emily foi uma que tirou várias fotos para tirar sarro da irmã mais tarde. 
<p>Eles pegaram a estrada por mais algumas horas e pararam para almoçar em um restaurante já no Arizona. Naquele momento, a temperatura já havia subido muito.</p> 
<center><h4>--*--</h4></center>
<p>- Eu não acredito que eu estou fazendo isso. – Will se sentou no banco de passageiro enquanto observava Emily colocando o cinto de segurança e engatando a primeira marcha.
<p>- Todos combinamos que iriamos nos revezar no volante. Esse foi o trato. – Emily sorriu. – Você precisa descansar.
<p>- Eu posso chamar o Chris ou Jason para dirigir no meu lugar por algumas horas.
<p>- Para com isso. Eu sou uma ótima motorista. 
<p>- Não é, não. Mas quero esquecer isso. – Will fechou os olhos quando Emily começou a sair do acostamento.
<p>- Ah, para com isso. Você não pode ser esse tipo de cara.
<p>- Eu estou brincando com você. Eu nunca deixaria você na frente do volante se não confiasse. Não importa o que digam, eu não sou suicida. – Will riu.
<p>- Ridículo. 
<p>- Só nos deixe em Oklahoma com vida, só te peço isso.
<p>- Para. – Ela começou a rir também.</p>
<center><h4>--*--</h4></center>
<p>- <i>Como estão as coisas aí?</i>
<p>- Todos estão dormindo. – Jason riu.
<p>Todos na van dormiram dez minutos depois que Jason pegou no volante. A estrada estava solitária, escura e silenciosa. Ele tinha que fazer algo para não acabar cochilando no volante, então colocou seus fones de ouvido, o conectou no celular e ligou para Will que estava no carro da frente.
<p>- <i>Eu estou com uma louca no volante, então acho que você está no lucro.</i> – Will brincou.
<p>- Não acredito que deixou a Emily dirigir. – Os dois caíram na gargalhada.
<p>- <i>Eu ouvi isso!</i> – Emily gritou. O telefone de Will com certeza estava no viva-voz.
<p>- Eu bem que percebi que estão andando devagar demais para ser você o motorista.
<p>- <i>É. Se depender da minha namorada, vamos chegar em Nova York daqui um mês.</i>
<p>- Noiva. – Jason o corrigiu. 
<p>- <i>É, acho que eu ainda não me acostumei com a ideia.</i>
<p>- Você é louco, sabia? – Jason estava incrédulo. – Como aconteceu?
<p>- <i>Eu não vou falar sobre isso com ela do meu lado, é constrangedor.</i> – Mas Will não estava se sentindo constrangido. – <i>Foi engraçado. Estávamos deitados em um celeiro. Acho que até as galinhas riram da gente.</i>
<p>- Galinhas? 
<p>- <i>É.</i> – Will fez uma pausa. – <i>De repente, eu olhei para ela e percebi.</i>
<p>- Simples assim?
<p>- <i>Simples assim.</i>
<p>Jason não estava vendo o amigo, mas sabia que naquele momento ele olhava com o olhar mais apaixonado possível para Emily. 
<p>- Eu estou muito feliz por vocês, é sério. 
<p>- <i>Eu sei, é por isso que é o meu padrinho.</i>
<p>- Isso! – Jason comemorou e os três voltaram a rir.</p> 
<center><h4>--*--</h4></center>
<p>A fogueira estava assando os últimos marshmallows em algum lugar no meio do Missouri. Depois de três dias sem parar na estrada, todos entraram em um acordo, estavam cansados demais até para sentar e assistir a estrada passando. 
<p>Havia um campo enorme que a rodovia cercava. Um bom lugar para estacionar e armar uma barraca de acampamento. Naquela hora, quase uma da manhã, o lugar parecia estar abandonado. A luz das chamas da fogueira era a única coisa que iluminava aquele campo. 
<p>Will e Emily estavam deitados na caçamba da caminhonete. O céu estava muito estrelado, sem nenhuma nuvem, porém a temperatura estava bem baixa. Eles agradeceram muito pelo cobertor que haviam trazido. Os outros estavam deitados no chão em seus sacos de dormir e bem agasalhados.
<p>- Da última vez que fomos acampar, as coisas não saíram muito bem. – Amanda lembrou rindo.
<p>- É, a briga foi feia. – Chris confirmou.
<p>- A culpa toda foi sua. – Quinn apertou a perna dele. 
<p>- Eu aprendi a abastecer. – Will entrou na brincadeira. 
<p>- Vocês se lembram da vez que a gente foi acampar e o papai fez a gente se perder? – Chris se lembrou. – Ficamos andando em círculos por horas até achar a nossa van.
<p>- Eu me lembro. Ele nos levou para conhecer a floresta, depois não sabia o caminho de volta. – Amanda caiu na gargalhada. 
<p>- É, aparentemente vocês têm umas experiências bem ruins em acampamento. – Quinn fez uma careta. 
<p>- Vocês acham que ele está lá em cima? – Sebastian olhava para o céu já fazia um tempo. Ele nem estava prestando atenção na conversa dos outros. – O Kevin. Eu sei que essa viagem é para gente esquecer um pouco de tudo, mas... eu não consigo parar de pensar... Acham que ele está lá em cima nos vendo? 
<p>- Eu acho. – Melissa apertou o braço do namorado. – E finalmente está em paz.
<p>Will se lembrou da conversa que teve com a lápide dias atrás onde ele falava que Kevin não poderia estar bem porque estava morto. Preferiu não se pronunciar quando todos começaram a falar sobre suas crenças em Deus. Emily percebeu e segurou bem firme na sua mão.
<p>- Eu acho que ele deve estar em algum lugar. – Amanda falou. – Não sei dizer se é céu ou inferno o nome, mas definitivamente ele está em algum lugar. 
<p>- Eu passei muito tempo da minha vida tentando entender o que acontecia depois da morte. – Emily falou. – Depois que meu avô morreu, eu vivia rezando e pedindo para ele aparecer ou simplesmente falar comigo. Eu me lembro de ficar com raiva por ele me ignorar depois de morto, coisas de criança. Depois de um tempo, eu só aceitei que ele havia ido embora e nunca mais voltaria. Deve ser a fase final do luto, sei lá.
<p>- A gente pode falar de outra coisa? – Os olhos de Amanda começaram a se encher de lágrimas e Jason a abraçou. 
<p>- <i>Eu escalei as montanhas mais altas, eu corri pelos campos...</i> – Will começou a cantar. Se fazer aquilo era o remédio para várias coisas na sua vida, ultimamente aquelas coisas só haviam aumentado. – <i>Só para estar com você... Só para estar com você...</i>
<p>- <i>Eu corri, eu rastejei, eu subi os muros da cidade...</i> – Jason e Amanda o acompanhou.  – <i>Esses muros da cidade... Só para estar com você...</i>
<p>- <i>Eu beijei lábios doces, senti os dedos que curam...</i> – Chris e Quinn vieram logo em seguida. – <i>Queimava como fogo... Esse desejo ardente...</i>
<p>- <i>Eu acredito na vinda do Reino para que todas as cores se filtrem como uma só...</i> – Sebastian e Melissa cantaram bem baixinho. – <i>Mas sim, eu ainda estou correndo! Sim, eu ainda estou correndo.</i>
<p>Emily olhou para Will antes de começar a cantar, ele sorriu mesmo com os olhos cheios de lágrimas.
<p>- <i>Você quebrou as algemas e soltou as correntes. Você carregou minha cruz e toda minha vergonha... Toda minha vergonha... Você sabe que eu acredito nisso...</i>
<p>Mesmo com os rostos cheios de lágrimas, nenhum deles conseguiu esconder o sorriso quando todos cantaram na mesma sintonia a última frase. Aquela noite seria mais uma lembrança de acampamentos que comentariam anos mais tarde, mas não seria uma lembrança qualquer. Foi naquela noite que todos eles sentiram aquela mesma sensação da qual nunca conseguiriam descrever. 
<p>- <i>Mas eu ainda... Não encontrei... O que eu estou procurando...</i></p>
<center><h4>--*--</h4></center>
<p>Nova York era mesmo um caos, não importava onde estavam. Will estacionou em frente ao único hotel duas estrelas que ele conseguiu reservar quartos de última hora e para tantas pessoas, e mesmo naquele bairro, quarenta minutos de distância da Madison Square Garden, que deveria ser aparentemente isolado do grande centro, as pessoas não paravam. 
<p>Não demorou muito até todos levarem suas malas, que eram poucas, para os quartos, tomarem um banho e descerem todos juntos para almoçar. 
<p>Emily percebeu que Will estava quieto e praticamente engolindo a comida sem mastigar, mas preferiu não se manifestar. Ele estava aéreo, com certeza não ouvia nada do que os outros diziam. Era o nervosismo. Subiria em um palco em poucas horas e não seria uma plateia qualquer nem em um lugar qualquer. Seria um sonho ou um pesadelo, ele ainda não tinha decidido qual dos dois. 
<p>Quando todos, animados, saíram do restaurante fazendo planos de onde iriam para gastar tempo até a hora do show, à noite, Will beijou o rosto de sua namorada e ainda em silêncio, voltou sozinho para o hotel e se trancou no quarto pelas cinco horas que restavam.</p> 
<center><h4>--*--</h4></center>
<p>- Eu acho que eu não vou conseguir ir ao show. – Sebastian estava deitado na cama observando Melissa pentear os cabelos no espelho na sua frente.
<p>- O quê? Por quê? – Ela se virou para ele assustada.
<p>- A viagem foi cansativa e... eu estou um pouco enjoado.
<p>- Deve ser o fuso-horário. 
<p>- Ou o fato de eu ter levado 4 tiros no mês passado. – Ele sorriu para deixar a namorada menos preocupada. – Tudo bem. Grava tudo para mim, eu assisto quando você voltar.
<p>- Eu não vou te deixar sozinho aqui.
<p>- Não, não quero que perca o show por minha causa.
<p>- Eu nem ligo para o Coldplay.
<p>- Está mentindo.
<p>- Não, eu não ligo mesmo. Prefiro ficar aqui... – Ela se deitou do lado dele. – Acho que pode ser bem melhor. 
<p>- Você acha, é?
<p>- Eu não quero mais perder nenhum momento disso. – Ela respirou fundo. 
<p>- O “Eu te amo” ainda é sério? Porque você não falou mais sobre isso desde o hospital. 
<p>- É muito sério. Eu te amo muito. 
<p>- É, eu também te amo. – Sebastian a beijou.
<p>- Viu só? Ficar aqui não vai ser tão ruim.</p>
<center><h4>--*--</h4></center>
<p>- Você está bem?
<p>- Te conto quando eu descobrir se estou. 
<p>Will ligou o carro e por um instante, desejou pegar a estrada e voltar para casa. Ele se apresentaria às oito e meia da noite e só faltavam duas horas.
<p>Emily resolveu ficar em silêncio o caminho todo, mas estudava Will com muita atenção. Ele estava nervoso, ela também estava. Conseguia ver as gotas de suor escorrer pela sua testa e suas mãos no volante não estavam tão firmes como deveriam estar. 
<p>Eles se despediram de Amanda, Jason, Quinn e Chris antes que tomassem rumos separados. Will segurou bem forte na mão de Emily quando seguiram o caminho para os bastidores. 
<p>O lugar estava uma loucura. Pessoas passando de um lado para o outro, gritos por toda a parte, vários celulares tocando ao mesmo tempo, pessoas com figurinos pela metade desfilando pelos corredores, seguranças circulando. Uma loucura.
<p>O show começou. De onde Will e Emily estavam, conseguiam ver as costas do primeiro cantor se apresentando e um pouco do som abafado. Para alivio de Will, sua visão não alcançava a plateia. O lugar podia estar vazio, seria bem legal. 
<p>Todos eram confiantes, tinham uma presença de palco razoável e estavam cantando covers do Coldplay. Will não havia pensado nisso. Coldplay ia fechar a noite com um show de duas horas, aquele pessoal não estava lá para ver aspirantes cantarem, queriam o prato principal, então nada que os outros cantassem seria importante a não ser que fosse um “esquenta” para o prato principal, era tão óbvio que ele se sentiu um idiota e olhou para Emily pedindo socorro. Pelo menos, a plateia cantaria junto por ser uma música conhecida. Ficariam em completo silêncio quando chegasse a vez dez.</p> 
<center><h4>--*--</h4></center>
<p>- Eu não acredito que a gente está aqui. Nova York. – Amanda e Jason haviam se afastado. Quinn fez questão de estar o mais próximo possível do palco e puxou Chris com ela enquanto que Amanda odiava aquele aperto da grade. 
<p>- É divertido, não é? – Jason sorriu enquanto assistia uma moça cantando um cover de <i>Paradise</i>. – A gente não mora em uma cidade pequena para ter um sonho de vir para Nova York, mas mesmo assim... 
<p>- É Nova York. – Amanda sorriu.
<p>- Exatamente. – Ele também sorriu. 
<p>- Sabe, eu tive uma ideia. Como a gente só vai pegar o avião amanhã à noite, poderíamos...
<p>- Por favor, não fale que vamos fazer compras. Eu odeio te acompanhar enquanto faz compras. – Jason implorou.
<p>- Eu não quero fazer compras. 
<p>- Ufa. – Ele respirou aliviado. 
<p>- Eu estava pensando que a gente podia dar uma fugidinha e cair na cidade. Podemos fazer da nossa vida uma comédia romântica, já que estamos na cidade do amor.
<p>- Achei que a cidade do amor fosse Paris. – Jason franziu a testa.
<p>- Que seja. Você topa?
<p>- Eu claro que eu topo. Só fiquei curioso para saber por que de repente você ficou tão romântica.
<p>- Não custa nada tentar algo novo.
<p>- Como isso nem sempre acontece, vou aproveitar. Você já tem algo em mente?
<p>- Não, mas eu vou pensar. 
<p>- Podemos ir para o Grand Central Terminal para eu gritar que te amo no meio de todo mundo, como naquele filme...
<p>- Ah, não. Isso é muito brega. Eu me contento com uma caminhada no Central Park e um buquê de flores. 
<p>- Mas isso não é como nos filmes.
<p>- Nos filmes mais pés no chão. Eu quero romantismo, mas também não exagera. 
<p>Jason a admirava.
<p>- O que foi?
<p>- Eu te amo, sabia? Às vezes, quando estamos juntos, eu ainda não acredito que isso tudo é real. Eu passei tanto... tanto tempo querendo isso... E foi tudo como eu esperava. 
<p>- Não destruí as suas expectativas? – Amanda brincou.
<p>- Nem uma delas. 
<p>- Obrigada. Mesmo te afastando duas vezes por dia, eu não teria conseguido passar por... tudo isso sem você. Eu também te amo.
<p>Os dois se beijaram ao som de <i>Yellow</i>.</p> 
<center><h4>--*--</h4></center>
<p>- Jones, é com você.
<p>Will sentiu o microfone encostar no seu peito quando um dos “caras” do som o entregou para ele. Havia chegado a hora. Havia fones em seu ouvido, como daqueles cantores profissionais que ele sempre via. Suas partituras estavam nas estantes junto com a banda. 
<p>Ele olhou para Emily. Não estava escutando nada, mas conseguiu ler em seus lábios um “você vai conseguir” e um “eu te amo”. Ela parecia bem confiante mesmo. Se estava nervosa, ele não conseguia perceber. Assim que ele começou a andar em direção ao palco, Emily entrelaçou suas mãos e as levou até a boca. Sim, ela também estava muito nervosa.
<p>Mesmo abafado ao máximo, Will conseguiu ouvir a gritaria da multidão. As luzes eram dez mil vezes mais iluminadas do que aqueles simples holofotes do bar. O palco era mais alto do que ele pensava e assim que percebeu, já se imaginou caindo dali e virando motivo de chacota. 
<p>Vinte mil pessoas olhavam para ele naquele momento. 
<p>O som começou a sair pelos seus fones de ouvido. Ele ficou lá parado, não sabia se devia dizer alguma coisa antes de começar a cantar ou se devia correr. Suas mãos geladas seguravam o microfone com toda a força do mundo. Ele respirou fundo. Olhou para o amor da sua vida mais uma vez e então encarou a multidão. 
<p>Vinte mil pessoas. Ou simplesmente vinte. No final, era tudo a mesma coisa. Em menos de um minuto, ele já havia dominado aquele palco e não sentia mais vontade de sair. 
<p>Em um determinado momento, um dos seus fones de ouvido caiu e ele não estava mais surdo. Ele não era o único cantando como ele imaginou tantas vezes nos minutos que estava atrás do palco. Infinitas vozes formavam um coro e cantavam junto com ele cada palavra da sua própria música. Foi ali que ele se curou. Todas as vezes que ele desejou que a sua música um dia fizesse a diferença para alguém e a curasse. Naquele momento, fez.</p> 
<center><h4>--*--</h4></center>
<p>- Você está feliz? Você parece feliz. – Chris olhou para Quinn toda descabelada e com o rosto bem vermelho. Esse era o seu estado no final da noite.
<p>- Eu... esse foi o melhor show do mundo. – Ela estava rouca de tanto cantar e gritar. 
<p>- É, eu percebi. – Ele sorriu para ela.
<p>Os dois estavam em frente ao portão esperando pelos outros. 
<p>- Sabe, eu notei que você não cantou muito. – Quinn levantou uma das sobrancelhas.
<p>- Ah, eu não curto muito Coldplay. Eu só vim mesmo por vocês e pela viagem.
<p>- É sério? Quanto mais tempo ficamos juntos mais eu vejo o seu mal gosto.
<p>- Bom, meu gosto para mulheres é bom.
<p>- Pelo menos, alguma coisa você tem que ter de bom, não é? – Ela riu. 
<p>- Só isso já me basta. 
<p>- O que foi? – Quinn estranhou Chris olhar para ela daquele jeito. Ela imaginou o que estava por vir.
<p>- Eu já posso dizer que te amo? Porque eu não aguento mais esperar.
<p>- Depende...
<p>- Eu te amo. E eu não vou retirar isso. 
<p>- Eu... não sou muito boa nisso.
<p>- Não era isso que eu queria ouvir. – Chris riu.
<p>- Não, seu idiota. É claro que eu te amo também, mas... não é o tipo de coisa que você vai ouvir com frequência, então...
<p>- É só me olhar desse jeito sempre, aí eu vou saber. Porque tem coisas que a gente não precisa dizer. 
<p>- Amém. – Ela o beijou. 
<p>- Então você me ama mesmo? De verdade?
<p>- Cala a boca.</p>
<center><h4>--*--</h4></center>
<p>- Você parece feliz. 
<p>Sebastian desistiu de esperar pelo irmão dentro do hotel e saiu. Will estava sentado na escadaria que levava à porta principal. 
<p>- Meu coração ainda está disparado. E eu não consigo parar de sorrir. – Os olhos de Will brilhavam.
<p>- É, eu ouvi dizer que foi incrível. Queria ter estado lá. – Sebastian se sentou ao lado dele.
<p>- Tudo bem. Não vai te faltar oportunidade.
<p>- É isso que eu gosto de ouvir. 
<p>- E como você está? 
<p>- Eu estou bem e pela primeira vez, nessa viagem, é verdade. – Sebastian também sorriu. 
<p>- Que bom.
<p>- Acho que eu passei tempo demais pensando que eu fui baleado por nada, quando, na verdade, mesmo se eu soubesse o que aconteceria depois, eu levaria os tiros também, porque alguém me ensinou a ser um ótimo irmão. – Ele bateu seu cotovelo no de Will. 
<p>- Esse ano foi uma droga, não é?
<p>- Você acabou de cantar na MSG e pediu o amor da sua vida em casamento. Não diminua essas coisas porque coisas ruins aconteceram. 
<p>- Tem razão. Você está mesmo na onda de ser um bom irmão, não é? – Os dois começaram a rir.
<p>- Ai, eu não quero voltar para casa.
<p>- Olha, e se eu disser que você não precisa ir embora de avião amanhã e pode ainda ganhar uns três dias na estrada?
<p>- Como assim? 
<p>- Vou precisar de um favor.</p> 
<center><h4>--*--</h4></center>
<p>Quando Emily acordou naquela manhã, ouviu o barulho do chuveiro no banheiro. Ela ligou a televisão e ficou mudando de canais até Will sair do banho. 
<p>- Eu estava tão cansada que eu capotei ontem à noite. Nem vi você entrando no quarto. – Emily se espreguiçou. 
<p>- É, você já estava babando quando eu entrei.
<p>- Cala a boca. – Ela jogou um travesseiro na cara dele. – Você ao menos dormiu?
<p>- Não. E pela primeira vez em muito tempo, foi por uma coisa boa. – Will deitou na cama ainda com a toalha enrolada na cintura. – Eu preciso te mostrar uma coisa.
<p>- O quê?
<p>Will pegou seu celular que estava no criado-mudo e mostrou para a namorada a página que estava em sua tela.
<p>- Criaram uma página no Instagram para você? – Emily arregalou os olhos.
<p>- E já tem vinte e cinto mil seguidores. – Will estava surpreso também. – Tem várias apresentações minhas do bar aí e... fotos nossas da viagem.
<p>- Suas fãs malucas estavam nos seguindo?
<p>- É, estavam. Não é à toa que muitas pessoas cantaram junto comigo no show. As pessoas sabiam quem eu era. Isso não é incrível?
<p>- É, sim. – Emily sorriu.
<p>- Dito isso, preciso te dizer outra coisa.
<p>- O quê? – Emily percebeu que ele ficou mais sério.
<p>- Antes da gente ir embora, quando eu estava esperando você sair do banheiro, um cara... um tal de Carlos sei lá das quantas, parou para falar comigo. Resumindo, ele quer que eu abra os shows do Coldplay na pequena turnê que eles vão fazer pela Europa. 
<p>- Ai, meu Deus! AI MEU DEUS! – Emily levantou da cama e começou a comemorar. – Isso é incrível.
<p>- É, sim. 
<p>- E por que você não está pulando que nem eu?
<p>- Eu não vou voltar para casa. Eles farão o primeiro show em Londres daqui quatro dias. Só volto para casa no Natal, provavelmente. 
<p>- Nossa, eu não esperava por isso. – Emily demonstrou um desapontamento por poucos segundos, mas depois voltou a comemorar. – Mas é uma turnê e é o Coldplay. Depois disso, você vai ser conhecido mundialmente.
<p>- Eu sei. 
<p>- Você tem que fazer isso.
<p>- Mas esse é o momento certo? Não estamos todos bem cem por cento e meus pais ainda...
<p>- Nunca vamos estar bem cem por cento, nunca vai haver um momento certo para isso, mas, Will, essas oportunidades são raras. Você não pode deixar para lá.
<p>- Mas e você? Eu não quero te deixar.
<p>- Eu vou estar aqui e vai ser só por algumas semanas.
<p>- Mas...
<p>- É o seu grande sonho. – Emily voltou para cama e ficou cara a cara com o namorado. – Nada mais importa. 
<p>- Meu sonho não se resume só a isso.
<p>- Will. – Emily colocou sua mão no rosto de Will. – Você vai, mesmo que eu tenha que te colocar em uma mala e te jogar em um avião. E quanto a gente... – Então ela olhou para o seu anel. 
<p>- O quê?
<p>- Casa comigo.
<p>- Ems, eu já disse que caso. Eu mesmo fiz o pedido e...
<p>- Não, seu idiota. Casa comigo agora. 
<p>- Mas agora eu quero tomar café.
<p>- Não agora, agora, mas... agora. – Ela sorriu.
<p>- Você não pode ir comigo. – Will percebeu os planos de Emily. – Ainda tem uma semana de provas. Vai ser reprovada por minha causa.
<p>- Minhas notas são ótimas. Bombar nessas provas só vai me fazer perder um ponto e eu estou adiantada. 
<p>- Ems... A gente não falou com ninguém... nossos pais vão pirar.
<p>- Desde quando você é o racional? Só diz “sim”, caramba. 
<p>Will não respondeu.
<p>- Pensando bem, a gente não precisa casar para eu ir com você.
<p>- Não. – Will concordou. – Mas... eu quero fazer direito. Eu te amo.
<p>- Eu também te amo. – Ela sorriu. – E isso, de longe, vai ser a coisa mais doida que eu vou fazer, mas... eu quero mesmo me casar com você agora.
<p>- Tem certeza?
<p>- Eu tenho.
<p>- Vamos nos casar? – Will ainda não estava acreditando.
<p>- Vamos nos casar.
<p>Ela abriu um sorriso maior ainda e o beijou.</p> 
</body>
</html>";
            }

            if (numero == 47)
            {
                lblTitulo.Text = "Epílogo - Você e Só Você";
                htmlPage.Html = @"<html>
<body>
<p><i>“Você e só você
<br>Faz meu coração achar que está puxando todas as cordas
<br>Você e só você
<br>Me faz ficar de joelhos e dar este anel
<br>Meu tudo”
<br><b>You and Only You - We The Kings</b></i></p>
<br>
<p><i>Para falar a verdade, eu nem sei como fazer votos de casamento. Eu preciso dizer aquelas coisas do tipo, eu aceito você, Emily, na alegria e na tristeza, na riqueza e na pobreza, na saúde e na doença e em todos os dias da minha vida? Eu preciso mesmo dizer isso? É tudo tão óbvio, tão comum, e se tem uma coisa que nós dois não somos é comum. Dizem que os votos precisam vir do coração, eu concordo, mas até o meu coração fica perdido quando estou perto de você...</i></p>
<br>
<p>- Quinn, você precisa se sentar!
<p>Emily chegou gritando no quarto onde Quinn estava experimentando roupas que ela havia comprado e Chris estava na cama terminando de ler seu resumo de História. 
<p>- O que houve? – Ela não se sentou e nem demonstrou interesse no que sua irmã ia dizer, perguntou só por perguntar.
<p>- Eu vou me casar. – Emily estava ofegante.
<p>- Emily, minha querida. Essa notícia é velha, você já contou, lembra?
<p>- Não, eu vou me casar. Agora!
<p>- Agora? – Quinn arregalou os olhos e Chris parou de ler imediatamente. – Tipo, agora?
<p>- Como...
<p>- Não, não agora, mas mais tarde.
<p>- O quê? – Chris falou. – Por quanto tempo eu dormi? 
<p>- Mas por que vocês vão... Will é louco?
<p>- Na verdade... – Emily mordeu os lábios. – A ideia foi minha. 
<p>- Emily... – Quinn não sabia nem o que dizer. – Você tem certeza disso? Achei que eu teria tempo para tentar te convencer.
<p>- Eu tenho certeza absoluta. 
<p>- Tudo bem, e quanto aos nossos pais? Ligou para eles?
<p>- Não. – Emily sentiu um pouco de vergonha. Ela não costumava ser tão irresponsável. 
<p>- E quando vai ligar? Quando já estiverem casados? Isso é loucura. E olha que sou eu que estou dizendo isso. – Quinn parecia mesmo muito preocupada.
<p>- Não é loucura. É o que eu quero fazer. 
<p>- Emily!
<p>- Achei que você tinha aceitado a ideia e que ia me apoiar.
<p>- Como eu disse, achei que eu teria mais tempo para te convencer que era loucura. 
<p>- A gente também achou que quando contassem para os nossos pais, eles iriam... basicamente ficar doidos e proibiriam. – Chris enfim falou. 
<p>- Que ótimo. Adorei. – Emily diminuiu o passo. Aquela conversa tinha acabado com a sua energia. 
<p>- E se você se arrepender daqui a duas semanas? – Quinn encarou a irmã.
<p>- Eu não vou me arrepender.
<p>- E como pode ter certeza disso?
<p>- Eu só tenho.
<p>- Emily, onde vocês vão morar? – Quinn odiava bancar a responsável irmã mais velha. – Você só tem dezessete anos e o Will é um louco que canta em um bar. Nem terminaram o colégio ainda.
<p>- Você não precisa me dizer essas coisas. Eu não vim aqui pedir a sua opinião nem a sua benção. Eu vim dizer que vou me casar e eu nunca tive tanta certeza de uma coisa na minha vida como estou tendo agora. 
<p>- Mas é loucura. – Quinn mal abriu a boca para falar de tanto nervoso.
<p>- Eu sei, mas eu não me importo. 
<p>- Deveríamos dar parabéns e não convencer ela do contrário. – Chris falou se aproximando das duas. 
<p>- Você é louca.
<p>Quinn a abraçou bem forte.</p> 
<br>
<p><i>... Sabe, eu nunca acreditei nisso. Borboletas no estômago, aquele negócio que te deixa travado, amor. Eu achava tudo uma grande idiotice, quem sente essas coisas? Mas aí eu te conheci e de repente eu não sabia mais o que dizer. Tudo no que eu acreditava caiu por terra. Foi a melhor coisa que me aconteceu. Sou uma pessoa melhor depois que te conheci. Sou uma pessoa melhor depois que comecei a amar você...</i><p>
<br>
<p>- Eu ainda não acredito que eu vou ser o melhor amigo de um cantor famoso. – Jason estava praticamente pulando de alegria no quarto. 
<p>Will estava em silêncio sentado na cama olhando para um par de alianças em sua mão que ele havia comprado em uma joalheria barata do hotel. Sua cabeça estava tão longe dali que nem prestava atenção nas coisas que Jason dizia. 
<p>- Eu vou comprar uns CDs do Coldplay para você conseguir uns autógrafos. Vai ser tão... Europa! Você já se imaginou indo para a Europa? Isso é incrível! Seus pais vão pirar, mas é incrível. O que houve? – Então ele olhou para o amigo e percebeu que Will não estava demonstrando tanto entusiasmo e ainda olhava para duas alianças 
<p>- Eu vou me casar.
<p>- Vocês ainda nem contaram para seus pais e já comprou a aliança? – Jason se sentou ao lado de Will e pegou as duas alianças da mão dele para ver. – E se depois que você voltar da Europa, não quiser mais casar? Ou a Emily não quiser?
<p>- Vamos nos casar essa noite.
<p>- O quê? – Jason quase deu um pulo. – Já contou para os seus pais?
<p>- Não, você é a primeira pessoa para quem eu contei.
<p>- Então eu sou o único que pode te impedir?
<p>- Você não vai me impedir. – Will revirou os olhos.
<p>- Will, casamento é coisa séria. Vocês precisam de um tempo para pensar melhor e planejar... Não podem decidir um casamento de um dia para o outro. 
<p>- Olha, eu sei todos os discursos, tá bom? Eu não quero ouvir de novo. Eu sei os riscos, eu sei as consequências e tenho uma ideia do que vai acontecer depois. Não é isso que eu quero que diga.
<p>- Então o que é?
<p>- Quero que diga que está feliz por mim. Você é meu melhor amigo, droga.
<p>- Me apoiaria se eu chegasse e dissesse que iria me casar com a Amanda hoje?
<p>- Sim. 
<p>- Mesmo sabendo que a gente não pensou em tudo?
<p>- Mas pensamos em tudo. – Will fez uma careta. – Vamos juntos para a Europa. Quando a turnê acabar, voltamos para LA e com o dinheiro que eu vou conseguir somado com o que eu já tenho, vamos comprar uma casa ou alugar um “apê”, não importa. Não vamos ser sem-teto. 
<p>- Está preparado para encarar as crises? Casamento é mais desafio do que dias felizes. Está mesmo pronto para isso?
<p>- Estou.
<p>- Will, isso é loucura. Além de estragar a sua vida, vai estragar a da Emily também e ainda vai estragar o relacionamento que vocês têm.
<p>- É muita coisa para se estragar. – Will pegou as alianças de volta. – Valeu pelo apoio. Era tudo o que eu precisava. Achei que me apoiasse e que estava feliz,
<p>- Desculpa, mas eu não vejo como isso pode dar certo.
<p>- Jason, casamentos dão certo. Eu sei que é difícil, eu sei que não é só brincar de casinha, eu sei de tudo isso. Eu não sou um garoto ingênuo que vive dentro de uma bolha. 
<p>- Então?
<p>- Eu vou ter o melhor momento da minha vida, meu sonho que eu achei que seria impossível, vai se realizar e é com ela que eu quero estar. Eu sei que não vai ser fácil, nunca foi e nunca vai ser, mas eu aceito o risco, porque eu a amo. 
<p>- Eu estou feliz por você. – Jason se rendeu. – Eu estou mesmo, mas...
<p>- Não é da sua natureza cometer loucuras. – Will riu. – Eu sei disso.
<p>- Palhaço.</p>
<br>
<p><i>... Muitos hoje podem ter dúvidas a respeito da gente, podem achar que o que estamos fazendo é loucura, podem estar apostando o quanto o nosso casamento vai durar, mas sinceramente, eu não me importo. Se eles soubessem o que eu sei, se eles sentissem o que eu sinto, nunca duvidariam. Emily, hoje, aqui, eu prometo a você que nunca vou desistir de nós. Eu sempre vou cuidar de você. Eu sempre vou ter fé e sempre vou encontrar esperança quando acharmos que acabou. Eu prometo fazer isso dar certo. Não prometo que vai ser fácil, mas prometo estar sempre lá por você. Prometo te ouvir, mesmo quando você começar a falar coisas sem sentido, e vai por mim, isso vai acontecer muitas vezes. Eu prometo amar você pelo resto da minha vida...</i></p>
<br>
<p>Emily pegou o celular e discou o número de casa. 
<p>Eles não conseguiriam impedir. Estavam bem longe de Nova York. Nem de avião chegariam a tempo, então estava tudo bem, eles podiam saber. 
<p>Ela não conseguiu apertar o botão verde. Se sentou no chão do corredor e começou a chorar.
<p>- Emily? – Melissa estava passando pelo corredor quando encontrou a amiga sentada chorando. – Tudo bem? 
<p>- Não, não está nada bem.
<p>- O que aconteceu? – Ela se sentou ao lado de Emily. 
<p>- Acho que eu estou cometendo uma loucura. 
<p>- O que está querendo dizer? 
<p>- Eu vou me casar. – Emily esperou um pouco para dizer a última palavra para reparar bem na expressão de surpresa de Melissa. – Hoje.
<p>- O quê? – E a cara de surpresa apareceu rápido. 
<p>- Eu sei, é loucura, não é? E eu não consigo nem ligar para os meus pais para dizer, porque talvez eu saiba que isso é errado e doido, mas... 
<p>- Calma. Você precisa se acalmar. – Melissa tirou o espanto do rosto e focou em Emily. – Primeiro, todas as noivas surtam antes do casamento, mesmo com meses de planejamento, você não teve nem um dia, então o que você está sentindo é mais do que o normal. 
<p>- É.
<p>- E você vai se casar na adolescência. Não precisa ficar na dúvida, é mesmo loucura, eu te garanto.
<p>- Então acha que eu devo desistir também? Porque eu sei que todo mundo nos apoiou quando contamos, mas ninguém achava que isso fosse realmente acontecer tão cedo. 
<p>- Você quer isso? Você quer se casar?
<p>- Eu quero muito. – Emily limpou as lágrimas do rosto. – Mas...
<p>- Então nada mais importa. Você não precisa de apoio e nem de pessoas te encorajando. Precisa é de um vestido e um buquê. 
<p>- Mel... 
<p>- Casamentos começam e acabam todos os dias e eu te garanto, a idade é o menor dos problemas. Você pode se arrepender um dia, mas... não estamos falando de um dia, estamos falando de agora e agora... 
<p>- Você precisa me convencer a não fazer. Dizendo essas coisas, só prova que é tão louca quanto eu. – As duas começaram a rir. 
<p>- Eu nunca tentaria te convencer. Eu não sei se o Will e você vão ficar juntos para sempre, eu só sei que... vocês não fazem o tipo do casal que quer se casar por capricho. Você diz que está sendo precipitada, mas eu sei que você pensou muito nisso e já sabe das chances e probabilidades e...
<p>- É...
<p>- Só cabe a mim torcer e te ajudar a arranjar um vestido. 
<p>- Eu poderia te beijar agora, sabia? Seria como minha despedida de solteira.
<p>- Eu aceito um abraço. – Melissa a abraçou e soltou um parabéns bem firme. Era tudo o que Emily precisava ouvir.</p> 
<br>
<p><i>... Hoje, mais do que nunca, eu tenho certeza que você é a mulher certa para mim. Você me entende, me suporta acima de tudo, me aceita, fica do meu lado mesmo quando ninguém está, mesmo quando eu me torno a pior pessoa. Amo o modo como você acredita em mim, como você ri das minhas piores piadas. Me faz querer crescer e comemora comigo as minhas vitórias, às vezes até mais do que eu. Era você que eu esperava, era você que eu procurava, agora eu te achei e eu não pretendo te perder nunca. Eu te amo, Emily.</i><p>
<br>
<p>- Eu vou sair com a Melissa. Precisamos correr se eu quiser achar um vestido a tempo. – Emily entrou no quarto bem apressada. Ela realmente estava com pressa, mas também queria evitar que Will visse seus olhos pós-choro.
<p>- Tudo bem. – Will estava sentado na cama com uma cara bem pensativa.
<p>- Tudo bem?
<p>- O quê? – Ele despertou.
<p>- O que foi? – Ela então parou.
<p>- Você acha mesmo que estamos fazendo a coisa certa? Você quer mesmo... – Will parou de falar quando percebeu que não era isso que ela queria ouvir.
<p>- Bom... – Emily se sentou ao lado dele.
<p>- Ninguém acha que a gente vai conseguir. Acham que estamos nos precipitando, que não pensamos direito. Jason praticamente me chamou de louco.
<p>- É, a Quinn também não adorou a notícia.
<p>- Precisamos ligar para os nossos pais? Eles vão pirar e vão querer correr para chegar aqui. Eu sei que teve a morte do Kevin e tudo mais, mas por que não falamos antes com eles? Por que sabemos que o que estamos fazendo é errado e que eles vão conseguir nos impedir quando souberem?
<p>- Está pensando em desistir? – Emily o encarou.
<p>- Não. Eu não quero desistir.
<p>- Não é o que está parecendo. 
<p>- Não fica brava comigo. – Will pegou na mão da namorada.
<p>- Eu não estou brava com você, eu só estou cansada de levarmos em consideração tudo o que falam. Dez minutos atrás, eu estava chorando no corredor. Mas o que estamos fazendo não é da conta de ninguém. Se não gostaram, o problema é deles.
<p>- É casamento, Emily, é coisa séria. – Will repetiu o que Jason disse a ele e se odiou por isso.
<p>- Eu sei que casamento é coisa séria, não precisa me dizer.
<p>- Você tem dúvidas?
<p>- É claro que eu tenho dúvidas. Um milhão, na verdade.
<p>- Mas...
<p>- Eu também não sei ser uma esposa, mas eu também não sabia ser uma namorada. E, modéstia à parte, eu me sai muito bem. – Ela sorriu orgulhosa.
<p>- Eu te amo. – Will atropelou as palavras.
<p>- Isso está totalmente fora do contexto.
<p>- Não me importo.
<p>- Eu também te amo. E eu ainda quero me casar se você quiser. 
<p>- É claro que eu quero. Não tem nada que eu queira mais. 
<p>- Ótimo, agora eu preciso ir.
<p>Ela se levantou e Will a puxou pelo braço.
<p>- Espera.
<p>E a beijou com a maior intensidade que conseguiu.</p> 
<br>
<p><i>Bom, até hoje, eu nunca havia me preocupado em como fazer meus votos de casamento. Na verdade, eu nunca pensei muito nisso, mas... Droga, eu sou péssima com discursos, mas... Nunca vai me faltar palavras para descrever como eu me sinto quando estou com você. Will, eu sempre planejei tudo na minha vida, cada coisa que aconteceria, cada plano, cada qualquer coisa, aí você chegou, e bagunçou os meus planos, me deixou louca, mas ao mesmo tempo, é o único que conseguiu me acalmar, que me deixou menos louca, se é que isso faz sentido. É, eu sei... Nada disso faz sentido, mas as melhores coisas na vida são assim, não dá para explicar...</i><p>
<br>
<p>- Então você vai mesmo se casar. – Sebastian nem precisou perguntar quando entrou no quarto de Will.
<p>- Eu vou. – Ele respondeu da maneira mais fácil possível. 
<p>- Ah... então seu plano deu certo. 
<p>- Na verdade, eu... criei todo um discurso na cabeça para dizer a ela e convencê-la e no final, ela que pediu. Eu fiquei quieto e disse sim. – Will sorriu.
<p>- Isso é... – Sebastian não sabia o que falar. – Parabéns.
<p>- Valeu.
<p>Will foi em direção do irmão e o abraçou. Aquela simples palavra era a única coisa que ele precisava ouvir.
<p>- Bom, você é completamente louco, mas sei que tem certeza disso. Não está fazendo sem pensar. 
<p>- Eu a amo e me casar em um futuro distante não seria o suficiente para mim.
<p>- Use isso nos seus votos. – Sebastian brincou. – Você já arranjou o lugar?
<p>- Eu passei o dia todo na internet procurando por capelas. Se der errado, vamos ter que ir no cartório e simplesmente...
<p>- Deixa que eu cuido disso para você. 
<p>- Sério? – Will ficou surpreso.
<p>- É, eu vou sair perguntando por aí. 
<p>- Cara, meu casamento depende disso, mas sem pressão.
<p>- Idiota.</p> 
<br>
<p><i>... Eu te amo por tudo o que você é e por tudo o que nós somos. Eu amo o modo como você me faz ver a vida, amo você por ter compartilhado seus sonhos comigo e por me deixar fazer parte deles. Com você é tudo ou nada e eu amo isso também. Amo a maneira como você me desafia todos os dias, com você nada cai na rotina. Amo quando você mente para mim mesmo sabendo que é muito transparente e péssimo mentiroso. Amo quando sabe o que eu estou pensando, eu não preciso dizer, você só sabe...</i><p>
<br>
<p>- Nossa, eu nunca achei que... – Quinn observava Emily usando um vestido branco em frente ao espelho arrumando o cabelo.
<p>- O quê? – Emily se virou para a irmã que estava sentada na cama.
<p>- Você está linda.
<p>- Encontrei esse vestido em uma loja no Brooklyn, Melissa me ajudou a escolher. Eu adorei.
<p>- Sempre achei que eu seria a primeira a casar.
<p>- É sério?
<p>- Claro que não, casar nunca esteve nos meus planos.
<p>- Nem nos meus, na verdade. 
<p>- Sei. – Quinn se aproximou da irmã para ajudá-la com o penteado.
<p>- Ainda acha que é uma loucura?
<p>- Acho, mas é a sua loucura. – Quinn riu.
<p>- Obrigada?
<p>- Eu sei que eu exagerei. Além do mais, conheço você e sei que não faz nada sem pensar, é até chato às vezes, quase sempre, na verdade. Então eu acho que...
<p>- Eu pensei.
<p>- Eu sei e mesmo assim você quer.
<p>- Quero. – Emily concordou.
<p>- Mas sabe que nosso pai vai pirar, não sabe? Nem nossa mãe vai conseguir conter ele.
<p>- Eu lido com ele quando voltar. Não quero pensar nisso agora. 
<p>- Bom, quero que saiba que eu vou estar lá com vocês. Nunca perderia o começo da Terceira Guerra Mundial. – Ela começou a gargalhar.
<p>- Cala a boca. 
<p>- Bom, vamos logo. Vamos terminar esse cabelo e depois partir para a maquiagem.
<p>- Obrigada. – Emily pegou na mão de Quinn. – Eu nunca conseguiria sem você.
<p>- Não vai precisar pensar nisso. É o casamento da minha irmã, não posso faltar. – Quinn sentiu uma lágrima saindo do seu olho. 
<p>- Ah, para. – Já Emily estava com o rosto todo molhado. – Eu não posso chorar depois da maquiagem, ouviu?
<p>- Tudo bem.</p>
<br>
<p><i>... Eu tenho que confessar que eu estou assustada, afinal quem não estaria? Mas mesmo assustada, eu desejo isso. Eu consigo ver nos seus olhos tudo o que queremos e isso me dá a certeza de que é o que devemos fazer. Isso. Não importa o quanto eu resista, eu já me joguei, não posso fingir que eu estou de fora quando estou completamente dentro. Eu sei que nem sempre vai ser um mar de rosas, eu sei que haverá brigas e desentendimentos e gritos e mais gritos, mas eu estou pronta para isso. Eu estou pronta para você...</i><p>
<br>
<p>- Então esse é o lugar.
<p>Will observava todos os detalhes da pequena capela à beira do rio Hudson. Era pequena, simples, mas tudo o que ele precisava. 
<p>- O padre disse que pode fazer o casamento às oito. – Sebastian comentou animado.
<p>- Perfeito. Valeu, Seb. – Will bateu nas costas do irmão.
<p>- Na verdade, não fui exatamente eu que achei esse lugar.
<p>- Melissa?
<p>- Passou perto. – Jason falou atrás dos dois. 
<p>Will se assustou e se virou rapidamente. Encontrou o amigo sorrindo atrás dele e não conseguiu evitar sorrir também.
<p>- Você?
<p>- Acho que, como padrinho, eu tinha que fazer alguma coisa. – Jason falou.
<p>- A culpa é sua. – Sebastian olhou para Will. – Escolheu o padrinho errado.
<p>- Mas eu achei que...
<p>- Eu não quero que desista. Na verdade, eu quero dizer que sinto muito. Eu não falei aquelas coisas por mal, eu só... – Jason fez uma pausa. 
<p>- Você só... – Will queria ouvir o resto. 
<p>- Eu só tentei cuidar de você. Casamento é sério e complicado, mas vocês não são como meus pais ou como...
<p>- Eu sei. – Will não precisou ouvir o resto. – E também sei que você tem as melhores intenções, mas...
<p>- Mas eu sou seu melhor amigo e eu vou te apoiar e ficar feliz por você. Então encare essa capela como um pedido de desculpas e um presente de casamento.
<p>- Que está mais que aceito. – Will soltou uma gargalhada. – E... eu decidi que quero vocês dois no altar comigo. Vocês estão no meu top cinco de pessoas mais importantes para mim e ainda não decidi que ordem. Querem ser meus padrinhos?
<p>- Achei que nunca fosse pedir. – Sebastian sorriu.
<p>- Será uma honra. – Jason abraçou Will. – Eu te amo, cara. 
<p>- Eu também.</p> 
<br>
<p><i>... Sabe, eu sei que muita gente achava que nunca daríamos certo, afinal somos tão diferentes, mas eu... Fomos além. Hoje, somos mais do que achávamos que seríamos. Eu te amo mais hoje do que te amava um ano atrás e sei que sempre vai ser assim. Nosso amor sempre vai crescer, ele sempre vai nos dar força para continuar e para sermos felizes juntos. Eu acredito que se é para se apaixonar, você tem que fazer isso para valer, ir com tudo, sabe? Sem olhar para trás e sem hesitar. Eu estou completamente apaixonada por você e essa é uma sensação maravilhosa. Eu queria que todos pudessem sentir o que eu sinto hoje...</i></p>
<br>
<p>- Olha só, meu irmão de terno e gravata. Quem diria?
<p>Amanda encontrou Will andando em círculos pelo corredor tentando dar um nó na gravata pelo reflexo de um vaso de flores.
<p>- Deixa que eu faço isso. – Ela era muito melhor naquilo do que ele. 
<p>- Desde quando se tornou tão prestativa?
<p>- Desde que eu precisei sair de manhã e comprar um vestido porque meu irmão vai se casar hoje. Coloquei na sua conta. – Ela sorriu enquanto terminava o nó.
<p>- Você está bem com isso? Falei com o Chris e...
<p>- Só estou chocada. Eu passei a minha vida achando que... você seria o tio solteirão. 
<p>- Engraçadinha.
<p>- Eu estou mais preocupada é com a turnê. Não te ter por perto todos os dias vai ser estranho, embora me doa admitir. 
<p>- Vão ser só algumas semanas e existe o celular. Eu vou estar sempre do outro lado da linha.
<p>- Não vai ser a mesma coisa. 
<p>- Eu volto logo, prometo.
<p>- Tem certeza?
<p>- De que eu vou voltar? – Will franziu a testa.
<p>- Não, sobre se casar. Não quero julgar nem dizer o óbvio e ser repetitiva, mas vocês são tão... novos.
<p>- A gente se ama.
<p>- Eu também amo o Jason, mas não quer dizer que vamos nos casar amanhã.
<p>- Eu topo dividir o altar com vocês se quiser. – Will brincou. – Eu sei lá, só não sei explicar, mas a Emily é a mulher da minha vida, disso eu sei, então... para que esperar?
<p>- Não está com medo?
<p>- Só apavorado. – Ele riu. – Sei que vou fazer algo estupido mais cedo ou mais tarde, mas também sei que vamos superar, assim como a gente sempre supera. Não existe Will sem Emily, não é?
<p>- É o que dizem. – Amanda sorriu. – Eu quero muito que sejam felizes. Quero que você seja feliz.
<p>- Eu vou ser.
<p>- Ótimo. Então só se lembre do nome dela e não diga errado... A última Emily que eu vi casando... – Os dois riram da referência de <i>Friends</i>. 
<p>- Eu te amo. E mesmo casado, você ainda vai ser a minha irmãzinha e pode me chamar sempre que estiver com medo da chuva. 
<p>- Eu também te amo.
<p>Amanda o abraçou com bastante força.</p>  
<br>
<p><i>... Você é tudo de que eu preciso. Você me dá força, me dá proteção, me completa. Você me entende como ninguém. Você é o meu melhor amigo. É para você que eu conto tudo de bom e de ruim. Você tirou os meus medos e me fez ser mais confiante. Muito obrigada por querer compartilhar a sua vida comigo, por me deixar entrar. Muito obrigada por me apoiar, por lutar por mim, por me amar, por estar comigo, por sempre tirar o melhor de mim. Você me deixa completa. Não tem como eu conseguir sem você, Will.</i></p>
<br>
<p>Will já estava preparado.
<p>Aquele corredor do hotel estava tão vazio e assustador. Emily estava no quarto de Quinn e aquele quarto estava tão silencioso. O que teria acontecido? Ela estava dois minutos atrasada. Noivas sempre se atrasam, ele pensou olhando para seu relógio no pulso pela trigésima vez. Pensou em bater na porta, tinha que bater. 
<p>- O que está fazendo? – Chris saiu de um quarto atrás de Will bem na hora de impedir o irmão de bater na outra porta.
<p>- Vou perguntar porque ela está demorando muito. Já faz...
<p>- Não exagera. Eu disse que a levaria. Você deveria estar na capela. O noivo não pode ver...
<p>- Blábláblá. Ninguém pode dirigir bêbado também, mas todos fazem isso.
<p>- É sério?
<p>- Eu não posso ficar na capela esperando, eu ia enlouquecer. Vou ficar aqui.
<p>- Mas o noivo...
<p>- O noivo pode bater no irmão antes do casamento? Ou isso também estraga alguma superstição ridícula? – Will quase gritou, estava uma pilha de nervos.  
<p>- Sem graça. Vai dar tudo certo. – Ele colocou sua mão no ombro largo do irmão. – Eu já vou descendo, a Quinn está lá embaixo. Já que você está aqui, eu não... A gente se vê na capela. 
<p>- Tá.
<p>- Vai dar tudo certo! – Ele gritou antes de entrar no elevador e desaparecer de vista. 
<p>- Vai dar certo uma ova. – Ele sussurrou.
<p>- Ah, eu acabei me esquecendo... – Chris saiu do elevador. – Emily não está aqui. Está no quarto da Melissa no andar de cima.
<p>- Ela tentou me despistar?
<p>- Sim. – Chris sorriu. – Agora que eu já te disse...
<p>- O quê? – Will percebeu que Chris começou a olhá-lo de um jeito estranho.
<p>- Eu nem sempre digo isso, mas você é um ótimo irmão e eu estou feliz por finalmente nos darmos bem. 
<p>- Ah, não, sem sentimentalismo agora, por favor. Eu não preciso disso. – Will riu para disfarçar.
<p>- Eu estou feliz por vocês e eu sei que o Kevin também estaria.
<p>- É, ele sempre adorou casamentos.
<p>- Ele adorava o bolo e...
<p>- Posar para as fotos. – Will completou.
<p>- Isso. 
<p>Chris foi até Will e o abraçou. Disse um “eu te amo” seguido de uma “boa sorte”. Voltou para o elevador e desapareceu novamente. Will correu para o outro elevador e subiu até o andar de cima. Ele passou mais dez minutos andando em círculos por aquele outro corredor que parecia igual com o anterior.
<p>- Vamos, vamos... – Ele fechava e abria suas mãos para tentar diminuir a tensão. – Daqui a pouco, eu vou começar a gritar aqui. – Resmungou um pouco alto.
<p>- Gritar por quê? – Ele ouviu a voz de Emily atrás dele. 
<p>Will sabia que todas as mulheres ficavam lindas vestidas de noiva. Mas Emily sempre foi a garota mais linda que ele havia conhecido, agora ela estava vestida de noiva. Ele simplesmente não conseguia lidar com aquilo.
<p>- Você está... Uau!
<p>- Uau? – Ela riu.
<p>Seus olhos brilhavam mais que o vestido e seu sorriso era a coisa mais linda que Will já havia visto na vida. Ele nem conseguiu reparar em como era o vestido. Só sabia que era branco. 
<p>- Não tem outra palavra. 
<p>- Ei, você já me convenceu a casar, não precisa dizer essas coisas.
<p>- Eu... – Will abriu a boca, mas não conseguiu emitir som algum. – Você... – Só sorriu e admirou. 
<p>- Temos que ir. Já estamos um pouco atrasados e...
<p>- Não, espera. Eu quero olhar bem pra você e guardar essa imagem na minha cabeça, esse momento. Agradeço a Deus nesse momento pela minha memória fotográfica. Amém! – Ele levantou as mãos para o alto.
<p>- Você também está perfeito com esse terno.
<p>- Nós dois sabemos que eu não precisava do terno. – Ele brincou.
<p>- Vamos logo.
<p>- Eu sei que tem os votos e vamos dizer isso para todo mundo, mas... agora... só nós dois aqui... Eu prometo te amar para sempre.
<p>- E eu prometo cobrar essa promessa. 
<p>- Agora sim. Vamos nos casar?
<p>- Vamos nos casar. 
<p>Quando Will pegou na mão de Emily, sua segurança voltou imediatamente. Era como se houvesse alguma ligação, como se tudo tivesse que ser daquele jeito. Eles não sabiam o que aconteceria depois, não tinham ideia, mas não estavam preocupados. Sabiam que iriam conseguir.</p> 
<br>
<p>“Muita gente reclama o tempo todo da vida, do que está acontecendo, como se reclamar fosse ajudar em alguma coisa, fosse resolver tudo. Mas estamos reclamando direito? E se estamos só reclamando de algo muito natural? Reclamando por nada? Somos incompletos, não somos perfeitos e vivemos uma vida longa, mas nunca conseguimos o bastante. Mas o que seria o bastante para nós? Eu acho que nunca vamos saber.
<p>Nem sempre se tem o que se quer, não é verdade? Mas saber disso não muda nada, só nos deixa mais fortes na busca por alguma coisa que não temos. Muitos vencem nessa luta de encontrar algo, outros desistem, me arrisco a dizer que a maioria desiste. Vivem infelizes por isso? Nem sempre, mas para que desistir se você pode tentar mais uma vez? Você está vivo. Tentar de novo não vai te matar, pode até te salvar.
<p>Nunca nos contentamos com nada. Passamos a vida toda querendo alguma coisa, buscando, procurando, ansiando por algo maior e isso é uma coisa boa. É muito bom na verdade, ter um objetivo, saber que em algum lugar nesse mundo tem algo para você, pode ser algo simples ou complexo, mas está lá esperando que você o encontre.
<p>Não nascemos perfeitos, mas muita gente busca a vida toda por perfeição, mas a perfeição é tão difícil. Ninguém é perfeito, na verdade. Todos temos defeitos e mais defeitos, mas por que isso seria ruim? Se fôssemos perfeitos, o que aconteceria? Você se acomodaria e aí a sua perfeição iria para o ralo. É a melhor coisa do mundo saber que alguém não liga para as suas falhas, que te ama porque elas existem ou o amor é tão forte que as supera. Você já se mostrou? Já contou para alguém seu pior defeito? Esse alguém te aceitou? Você aceitou ele? Os defeitos e imperfeições estão aí como uma mala para você carregar, você escolhe se vão te ajudar ou te atrapalhar.
<p>Não nascemos apaixonados, mas todos nós buscamos a vida toda por amor, e se a perfeição é difícil, amar é mais ainda. Como amar alguém que você não conhece completamente? Mas o amor vem de qualquer lugar. Seu cachorro pode te amar e você pode amar ele. Você ama seus irmãos? Já disse eu te amo para seus amigos? Isso parece estranho para você? Já parou para pensar se já dispensou o amor de alguém nessa vida? Já teve o coração arrancado? O amor é bom, mas sempre vem com a possibilidade de uma decepção depois. Devemos desistir por isso? Jamais. 
<p>É, o amor é mesmo difícil, não é para todo mundo. É complicado. Mas quando estamos com a pessoa certa, amar não parece ser tão complicado, na verdade, parece a coisa mais fácil do mundo.”.</p>
<br>
<p><i>“Amor não é amor que se altera quando encontra alteração, nem se curva diante de força contrária. Amor é um marco eterno, dominante, que encara a tempestade com bravura. Amor não se altera com o passar de horas e semanas, mas resiste a tudo. Quando a vida fica dura, quando as coisas mudam, o amor verdadeiro fica o mesmo.”.</i> – <b>William Shakespeare</b>.</p>
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
            if (condicao+1 > 47)
            {
                DisplayAlert("CAPÍTULOS!", "VOCÊ CHEGOU NO ÚLTIMO CAPÍTULO. CONFIRA OUTRA HISTÓRIA", "OK");
            }
            else
            {
                Navigation.PushModalAsync(new Capitulo8Page(condicao + 1));
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
                    //var message1 = "CAPÍTULO LIDO";
                    //DependencyService.Get<IMessage>().ShortTime(message1);
                } else
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