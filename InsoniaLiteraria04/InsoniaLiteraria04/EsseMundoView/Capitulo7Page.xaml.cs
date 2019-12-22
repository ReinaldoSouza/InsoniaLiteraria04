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
    public partial class Capitulo7Page : ContentPage
    {
        DBFire service;
        public int condicao;
        public Capitulo7Page(int numero)
        {
            InitializeComponent();
            service = new DBFire();
            condicao = numero;
            mostrarCapituloSalvo("EsseMundoVaiMudar", "Capitulo" + numero.ToString());

            if (numero == 37)
            {
                lblTitulo.Text = "Capítulo 37 - Até Mesmo Os Melhores Caem Às Vezes";
                htmlPage.Html = @"<html>
<body>
<p><i>“Até mesmo o melhor cai às vezes
<br>Até mesmo as estrelas se recusam brilhar
<br>Fora o passado, você caiu a tempo
<br>De alguma maneira eu acho que você e eu colidimos”
<br><b>Collide - Howie Day</b></i></p>
<br>
<p>Will correu até a sala de espera B, com Emily em seus calcanhares, depois da recepcionista o informar que sua família provavelmente estaria lá. Fazia quatro horas que ele havia recebido a ligação de Amanda. Nesse meio tempo, eles foram de táxi até a rodoviária mais próxima e pegaram um ônibus até a rodoviária de Los Angeles. Will falou só o necessário durante a viagem e segurava bem firme o celular na mão. Achava que se Sebastian morresse, ele receberia a ligação. 
<p>- Will! Will! – Karen gritou assim que viu o filho entrando na sala de espera e foi em direção a ele para abraçá-lo.
<p>- Como ele está? – Will percebeu que sua mãe estava mais nervosa do que normalmente estaria e seus olhos estavam bem vermelhos.
<p>- Eu não...
<p>- Onde encontraram ele? O que ele usou? – Como sua mãe não respondeu, ele foi em direção ao restante da família. – Onde ele estava?
<p>- Will, se acalma. – Robert falou, mas suas mãos estavam tremendo. – Não sabemos muito.
<p>- Mas... 
<p>Emily foi até a irmã, que estava tentando passar despercebida, escondida em um banco no lado mais isolado da sala. Ela estava calada e com as mãos geladas que Emily sentiu quando se sentou ao lado dela e segurou bem forte suas mãos.
<p>- Will, Will. – Amanda falou. – Ele não... – Seu nariz estava tão vermelho quanto seus olhos. – Ele estava no East. 
<p>- Esse é... o bairro mais perigoso de... – Emily falou assustada.
<p>- Traficantes. – Will bateu o pé. 
<p>- Will, ele não se drogou. – Jason chegou perto do amigo e o olhou nos olhos. Tentou falar o mais calmo possível e ao mesmo tempo, tentou dar apoio mesmo também precisando. – Ele foi baleado. Quatro tiros à queima-roupa. 
<p>- O quê? – Will arregalou os olhos enquanto Emily colocava a mão no rosto.
<p>- Ele está em cirurgia. Já faz seis horas.
<p>- Não quis dizer isso por telefone. – Amanda explicou.
<p>- Mas por quê? Como isso aconteceu? Por que ele estava lá? – Will quase gritou. Sorte a sala de espera estar vazia além deles. 
<p>- Karen, Robert?
<p>O médico interrompeu o que seria um show de gritos de Will, quando saiu de uma porta restrita a médicos e funcionários do hospital.
<p>- Kurt, como ele está? – Robert foi em direção ao médico bem agitado.
<p>- Bem, eu sinto muito, mas as notícias não são muito boas. – Kurt era um dos médicos que sempre cuidava de Sebastian em cada overdose que ele tinha. Mesmo sabendo de seu histórico, ele estava bastante preocupado. 
<p>- O que isso quer dizer? – Will ficou ao lado do pai.
<p>- Ele teve sorte. As balas não atingiram em cheio nenhum órgão vital.
<p>- Mas isso é bom, não é? – Karen falou esperançosa. 
<p>- Não é ruim. – Kurt continuou. – Porém ele perdeu muito sangue, o pulmão direito dele foi atingido e a remoção de uma das balas quase provocou uma fratura na medula.
<p>- Ele não vai conseguir mais andar? – Chris fez a pergunta que todos estavam assustados para fazer.
<p>- Não, a medula ainda está intacta. Foi por pouco, mas conseguimos. 
<p>- Kurt, vá direto ao ponto, por favor. – Robert segurou a mão de Will bem forte. 
<p>- Os rins e o fígado de Sebastian são fracos por causa das... vocês sabem. Eles quase não aguentaram a cirurgia. Tivemos que induzi-lo ao coma para que os órgãos dele se curem e voltem a trabalhar normalmente. 
<p>- Mas ele vai acordar, não vai? – Karen continuou esperançosa.
<p>- Bom, agora não depende mais da gente, e sim dele. Não podemos fazer mais nada a não ser esperar. Faremos exames diários e vamos torcer para ele reagir bem aos medicamentos. 
<p>- Mas ele é um viciado. Remédios não são drogas? – Amanda perguntou.
<p>- É diferente nesses casos. – O médico explicou. – Contanto que nós, médicos e enfermeiras, dosem as quantidades certas, não haverá problema de uma intoxicação e não conta como “usar drogas”. Bom, vamos conversando caso algo mude. 
<p>- Podemos vê-lo? – Karen perguntou. 
<p>- Só vocês dois e bem rápido. 
<p>Kurt guiou Karen e Robert para fora da sala e saíram juntos pelo mesmo lugar que ele entrou. O silêncio tomou conta daquele lugar. 
<p>- Eu não entendo. – Jason quebrou o silêncio. – Ele... O que ele foi fazer lá?
<p>- Enquanto ele não acordar, não vamos saber. – Amanda se sentou junto com Jason.
<p>- Quem o encontrou? – Will perguntou.
<p>- Parece que um desconhecido estava caminhando pela rua e o encontrou sangrando em um beco. – Melissa falou pela primeira vez desde que Will havia chegado. Ela estava sentada em um extremo da sala. 
<p>- Isso não está certo. – Will andava de um lado para o outro, totalmente em negação.
<p>- Olha, eu não sei vocês, mas eu não vi o Sebastian o dia todo. – Chris comentou. – É domingo e ele não tomou café, nem almoçou, simplesmente sumiu. Nem sei se dormiu em casa. Estava com você?
<p>- Não. – Will respondeu. – Eu estava em San Diego. 
<p>- Eu mandei mensagem para ele. – Amanda falou bem preocupa. – Perguntei onde ele estava hoje à tarde. Ele disse que estava bem, que eu não precisava me preocupar. Ele não é de sumir, por isso não dei muita importância.
<p>- Tinha uma garota. – Will se lembrou. – Ontem, eu... eu estava no corredor e ele saiu do quarto quase sem roupa para ver se o caminho estava livre para a garota sair. Ele disse que estava sozinho, mas não estava, ele mente muito bem. 
<p>- Vocês acham que essa garota pode... – Emily olhou para todos para tentar entender o que estavam pensando. – Acham que ele foi atrás de drogas para eles e se meteu com um traficante armado?
<p>- Pode ser. – Will estava pensando exatamente aquilo. – Precisamos encontrar essa garota.
<p>- Não foi isso que aconteceu. – Melissa falou.
<p>- Como sabe? – Jason se virou para Melissa.
<p>- Eu estava com o Sebastian, na manhã de ontem, na noite de ontem, e hoje o dia todo. 
<p>- Você estava com o Sebastian quando ele foi baleado? – Will demonstrou uma leve surpresa em seu rosto, estava tão desnorteado e confuso que nem assimilou muito bem o que Melissa estava falando.
<p>- Não. Ele saiu do quarto, disse que ia descer para beber algo e não voltou mais. 
<p>- Só isso? – Will a encarou. – O que foi que você fez?
<p>- Como assim?
<p>- Will. – Emily se levantou e foi até o namorado. Ela já estava prevendo o que ia acontecer.
<p>- Você foi a última a vê-lo. Nos diz então o que aconteceu.
<p>- Eu já disse o que aconteceu. Ele saiu do quarto e não voltou. Me ligou, disse que precisava resolver uma coisa rápida. Eu achei estranho, mas disse para eu não me preocupar porque estava tudo bem. Depois disse que a barra estava limpa e que eu podia ir embora, que me veria à noite. 
<p>- Isso parece furada. Está escondendo alguma coisa.
<p>- O que quer dizer com isso?
<p>- Você sabe alguma coisa!
<p>- Will, para de gritar, estamos em um hospital. – Jason o alertou de longe. 
<p>- E por que estamos em um hospital, Melissa? – Will não tirou os olhos da garota.
<p>- O que está insinuando?
<p>- Sabe mais do que quer contar.
<p>- O que quer dizer, que eu atirei nele? 
<p>- Mel, se acalma. Ninguém aqui acredita que você tenha alguma culpa nisso. – Emily falou olhando feio para Will.
<p>- Eu não acredito nem desacredito. – Amanda falou ainda sentada.
<p>- Amanda! – Jason olhou para a namorada um pouco bravo.
<p>- O que sabemos sobre essa garota? – Amanda apontou. 
<p>- Então é isso? – Melissa olhou para Will.
<p>- Parece que é. – Will não queria acreditar que Melissa fosse alguém ruim a esse ponto, ela era sua amiga, mas agora seu irmão estava em uma espécie de coma e ela era a única que parecia culpada. – Meu irmão está no hospital e aparentemente por sua causa.
<p>- Eu não fiz nada. – Seus olhos se encheram de lágrimas.
<p>- Vai embora.
<p>- Ótimo. 
<p>Melissa pegou seu celular que estava em cima de uma cadeira e saiu da sala de espera pisando firme.
<p>- Will, o que pensa que está fazendo? – Emily confrontou o garoto assim que Melissa saiu.
<p>- O que você acha?
<p>- Eu acho que você está ficando louco. Não acredito que falou isso para a Melissa. Não tem cabimento nem sentido algum.
<p>- O que queria que eu dissesse? Ela é a única...
<p>- Ela é sua amiga. Ela estava aqui e se importa com o Sebastian.
<p>- Só que ele agora está em coma e ainda pode morrer.
<p>- E por isso, vai sair e acusar todo mundo?
<p>- Não quero falar sobre isso agora. – Will se afastou. Ele não queria um conflito com ela naquele momento. 
<p>- Que tal não falarmos sobre mais nada agora?
<p>Emily o encarou por alguns segundos e depois saiu da sala do mesmo jeito que Melissa. Brava.</p>
<center><h4>--*--</h4></center>
<p>A pequena capela do hospital estava iluminada por velas. Quinn odiava aquele cheiro, mas sabia que sua irmã estaria ali e precisava estar ao lado dela naquele momento. 
<p>- Achei um exagero. – Ela se sentou ao lado da irmã em um banco. 
<p>- Exagero é pouco. Você não concorda com ele, não é? – Emily falou alto demais para o ambiente silencioso.
<p>- Não. Melissa nunca se meteria nessas coisas. Talvez eu concordasse se eu estivesse na minha época de loucura doentia, mas...
<p>- Eu não queria brigar com ele justo agora, mas... Eu não consegui ficar de boa com isso. Ele a expulsou. 
<p>- É, com o Sebastian desse jeito...
<p>- Por causa disso também. – Emily suspirou.
<p>- O que quer dizer? – Quinn percebeu que a irmã estava escondendo alguma coisa dela. 
<p>- Nada.
<p>- O que aconteceu? Com toda a coisa do Sebastian, eu nem perguntei, mas... O que aconteceu nesses dois dias que você ficou desaparecida?
<p>- Eu não fiquei desaparecida. Eu fui para a maratona em San Diego.
<p>- E correram até a Lua? Isso foi ontem. O que fez hoje? Jason voltou logo cedo, mas você e seu namorado só voltaram por causa do Sebastian.
<p>- Não sei do que está falando. 
<p>- Emily. – Quinn insistiu. 
<p>- Eu não quero falar sobre isso agora. – Emily queria continuar quieta, mas pelo olhar da irmã, ela não iria ter essa sorte. – Bom, ontem Will e eu, a gente, bom, nós...
<p>- Ai, meu Deus, finalmente aconteceu! – Quinn ficou surpresa, depois animada, seus olhos até brilharam enquanto implorava por detalhes. – Eu não acredito!
<p>- Xiu. Estamos em uma igreja. – Emily falou mais baixo.
<p>- Deus gosta de procriação. 
<p>- Cala a boca.
<p>- Como se sente?
<p>- Eu não vou falar sobre isso agora. Não é hora nem lugar.
<p>- Como se sente? – Quinn ignorou completamente o desejo da irmã. Estava ansiosa demais para esperar.
<p>- Eu me sinto ótima. – Emily então se rendeu e sorriu. Tentou ao máximo esconder sua animação. Se fosse em outra ocasião... – Eu... foi maravilhoso e especial. Eu o amo e de repente, percebi que estava pronta. Não fiz por ele, fiz por mim.
<p>- Eu estou tão orgulhosa de você. – As duas se abraçaram. 
<p>- Obrigada.
<p>- Agora, me diz uma coisa. – Quinn ficou ainda mais animada. – Ele é bom mesmo como todo mundo diz?
<p>- Quinn, a igreja. – Emily ficou sem graça.
<p>- Ah, Deus está feliz por você ter conhecido os prazeres da carne, tenho certeza. 
<p>- Quinn!
<p>- Só me dê um detalhe, um simples detalhe. É grande?
<p>- Cala a boca. – Emily colocou as mãos no rosto para esconder o riso.</p> 
<center><h4>--*--</h4></center>
<p>Kevin estava sentado no sofá da sala quando Chris chegou em casa. Já passava da meia-noite. 
<p>Chris resolveu voltar para casa para dormir um pouco, além de ter uma prova muito importante no dia seguinte, ficar naquele hospital não era nada animador.
<p>- Onde você estava? – Kevin levou um susto quando viu o irmão entrando em casa.
<p>- No hospital, ué. – Chris franziu a testa.
<p>- Ah. Eu tinha até me esquecido. Como ele está?
<p>- Mal. – Chris se aproximou do irmão, mas antes de se sentar ao lado dele, parou. – Que cheiro é esse?
<p>- Ah, não enche.
<p>- Você está bêbado? Cadê o Matt?
<p>- Está dormindo, eu acho. – Kevin olhava meio vago para o irmão. 
<p>- Que horror. Seu irmão mais velho no hospital, o mais novo está em seus cuidados e você aqui bebendo.
<p>- Eu não sou médico. Mesmo sóbrio, eu não ia poder ajudar. – Kevin soltou uma gargalhada.
<p>- É, mas poderia ter um pouco de consideração. Ele é seu irmão.
<p>- Ele não é meu irmão. – Kevin se levantou, cambaleando. 
<p>- Cala essa boca.
<p>- É a verdade. – Ele deu de ombros.
<p>- Onde arranjou a bebida? – Chris estava muito bravo. A maior parte da raiva estava preenchida com decepção. Ele e Kevin sempre foram muito próximos, agora ele mal conseguia reconhecer o garoto que estava na sua frente.
<p>- Não interessa.
<p>- Interessa sim. Você é novo demais para ficar bebendo desse jeito. Se o papai descobrir...
<p>- Ele só vai descobrir se você contar. Eu vou lá dormir e... – Kevin tentou dar um passo, mas caiu de volta no sofá e voltou a rir.
<p>- Eu vou te fazer um café bem forte. 
<p>- Eu não quero café e estou pouco me lixando para o papai.
<p>- Onde arranjou a bebida?
<p>- Um amigo meu me deu. – Kevin fechou os olhos. 
<p>- Que amigo, Kevin? – Chris o chacoalhou para ele acordar.
<p>- Olha, não... enche. – Kevin colocou a mão no bolso da sua blusa de moletom e tirou um embrulho.
<p>- O que é isso?
<p>- Não é nada. 
<p>- Me dá isso. – Chris pegou o embrulho das mãos de Kevin. Não teve dificuldade, o irmão mal estava aguentando segurar o embrulho. Ele o abriu e arregalou os olhos quando viu o que tinha dentro. – Kev, o que é isso? Meta?
<p>- Me dá isso. – Kevin pegou o pacote da mão de Chris, mas pela falta de força, derrubou todos os comprimidos no chão. 
<p>Chris se ajoelhou e pegou apressadamente todos os comprimidos jogados no tapete e os guardou em seu bolso da calça. Olhou para seu irmão jogado no sofá com os olhos entreabertos e boca torta. 
<p>- O que você está fazendo? – Ele respirou fundo. – Isso é coisa séria. 
<p>- Eu não estou... usando... relaxa.
<p>- Então por que estava no seu bolso? Isso é muito forte! – Chris começou a gritar e Kevin respondeu com caretas. –  Não aprendeu nada com o que aconteceu com o Sebastian? Ele está nessa enrascada por causa desses comprimidos!
<p>- Não... – Kevin não conseguiu terminar a frase.
<p>Chris levantou Kevin, o pegou pelo braço e o levou para o quarto. Subir as escadas foi um pouco complicado, mas conseguiu, mesmo tendo que parar no meio umas três vezes para descansar. 
<p>- Eu não sei o que eu vou fazer com você. – Chris o colocou na cama e jogou um cobertor por cima dele. – Ai, meu Deus.
<p>- Ela prefere ele, sabia? – Kevin murmurou ainda de olhos fechados. – Ela me largou porque disse que prefere ele. Will.
<p>- Quem?
<p>- Giovanna. Ela me largou.
<p>- Por isso você bebeu? Kev, eu sinto muito, mas... você tem que esquecer ela e parar de colocar a culpa no Will por uma coisa...
<p>- Ele tem culpa, sim. Ele adora... ser o maioral... o herói... Quem vai prestar atenção em mim quando o Grande Will está por perto?
<p>- Está delirando. Mas esse seu ódio não vai te ajudar em nada.
<p>- Vai sim... Eu prefiro... ficar com ódio... do que ficar arrasado. Eu prefiro odiar o Will do que... ficar decepcionado com a Giovanna.
<p>- Giovanna não liga para você. Você sempre soube que ela amava o Will e não você.
<p>- Não. Ela disse que tinha começado a me amar. Ele voltou a... dar esperanças a ela...
<p>- Sabe que isso não é verdade. 
<p>- Para... de defender... ele. Ele não está nem aí para você. Ele está lá feliz com a namoradinha... e com o amiguinho... e com o irmãozinho falso dele. Ele não liga... para gente.
<p>- Vai dormir, Kev. Não dá para falar com você desse jeito.</p>
<center><h4>--*--</h4></center>
<p>- O que está fazendo aqui?
Jason sabia que bater na porta de alguém quase duas horas da manhã era uma grande falta de educação, mas mesmo assim, esperava que Melissa entendesse.
<p>- Eu sei que você não me esperava aqui a essa hora.
<p>- Eu sei que concorda com o Will, mas se veio aqui me xingar e gritar, eu já te aviso, aqui você que vai ser expulso. – Melissa estava muito brava. 
<p>- Eu não vim brigar e eu não concordo com o Will, até porque eu não sei o que aconteceu.
<p>- Eu também não sei. Ele simplesmente... – Mas além de brava, ela estava muito preocupada. Era bem visível. – Acha mesmo que ele levou tiros por causa de drogas?
<p>- O celular estava no bolso dele e a carteira. Não foi um assalto. – Jason estava preocupado. – Mas eu não sei...
<p>- Eu passei o dia todo com ele. Agora eu estou me sentindo um pouco culpada, porque se ele foi atrás de drogas, pode ter sido algo que eu disse ou fiz...
<p>- Não faça isso com você. 
<p>- Talvez o Will tenha razão. Talvez eu tenha um pouco de culpa.
<p>- Olha, o Will não falou por mal. Ele sempre fica muito mexido com tudo isso e você sabe que ele não pensa antes de falar.
<p>- Eu sei.
<p>- Quando ele se acalmar, vai te pedir desculpas.
<p>- Pode ser.
<p>- Você o ama?
<p>- Will? – Melissa franziu a testa. Não entendeu a pergunta.
<p>- Não, o Sebastian. – Jason riu.
<p>- Eu não sei. Estávamos naquele lance ridículo de amizade com bônus, dizendo que não era sério e que não significava nada, mas no minuto que eu chegava, não queria mais ir embora. Talvez eu o ame. 
<p>- E agora está pensando se vai ter a chance de dizer isso a ele.
<p>- É. Também estou pensando que ele pode ter ido atrás de drogas porque achou que eu o rejeitei.
<p>- Isso não foi culpa sua. Foi uma tragédia e ninguém teve culpa de nada.
<p>- Quero realmente acreditar nisso. Por que se não foi minha culpa, o que foi que aconteceu então?
<p>- Boa pergunta.</p> 
<center><h4>--*--</h4></center>
<p>- <i>Oi, você ligou para mim, mas agora eu não posso atender, então...</i>
<p>- Ems, sou eu. Olha, eu não queria ter brigado com você daquele jeito, é que minha cabeça está uma droga, eu estou uma droga. Sinto como se o Seb estivesse morrendo e eu não pudesse fazer nada para impedir e isso me deixa com muita raiva. Me desculpa, eu te amo e preciso de você aqui comigo. 
<p>Will desligou o telefone.
<p>O sol já estava nascendo. Karen e Robert ainda estavam na sala de espera. Jason e Amanda foram embora junto com Chris um pouco depois da meia noite. Will estava sentado em um dos bancos de concreto na entrada do hospital do lado de fora. Estava batendo uma brisa e ele agradeceu por aquele ar fresco, estava conseguindo tirar o cheiro de hospital de seu nariz.
<p>- Will, oi. Bom dia. – Giovanna apareceu de surpresa. – Eu soube do Sebastian. Como ele está?
<p>- Nada bem. – Will não deu atenção para a garota.
<p>- Olha, qualquer coisa que você precisar, eu...
<p>- Giovanna, o que você quer? Eu estou uma pilha agora e você é um problema que eu não quero e nem preciso lidar agora. 
<p>- Eu só queria conversar.
<p>- Sobre o quê?
<p>- Eu estou preocupada com o Kevin.
<p>- Kevin não é problema meu 
<p>- Tecnicamente, nem meu. Terminei com ele ontem.
<p>- Chocante. – Will não recebeu a notícia como Giovanna esperava. Na verdade, ele não demonstrou emoção nenhuma.
<p>- Eu não posso continuar com isso, já estou ficando muito preocupada. 
<p>- Não vai me dizer que ele está te batendo. 
<p>- Tudo começou com o dinheiro que ele pegou do agiota. – Giovanna ignorou o comentário.
<p>- Ah, me poupe. Não era um problema quando você estava gastando junto com ele.
<p>- Mas ele não gastou só comigo. Ele comprou drogas e...
<p>- Vocês dois usaram. – Will não ia deixar Giovanna sair como a injustiçada da história. – Não vem bancar a santa, tá bom, Giovanna? O quê? Você o levou ao máximo e agora não consegue aguentar? Veio pedir a minha ajuda?
<p>- Não quero que ele acabe como o Sebastian.
<p>- Cuidado.
<p>- Eu me importo com ele. Posso não amá-lo, mas eu o conheço há anos. É quase da família. Você precisa falar com ele. – Ela parecia mesmo muito nervosa.
<p>- Se ele não te ouviu, que chances eu tenho? Caso não tenha notado, eu não sou a pessoa favorita dele nesse momento. Você é.
<p>- Fale com o seu pai, com qualquer um. Ele precisa de ajuda, eu não consigo sozinha.
<p>- Por que não me disse isso antes? Por que só agora?
<p>- Não achei que fosse sério. Todo mundo usa drogas, eu não achei que ele ficaria louco.
<p>- Ele tem quinze anos. Você drogou uma criança.
<p>- Eu não fiz nada. Eu estou com medo. 
<p>- Isso me parece culpa. – Will a olhou de canto com muito julgamento nos olhos.
<p>- Eu não me sinto culpada. Eu só estou preocupada. Minha meta de vida não é estragar as pessoas. 
<p>- Se você está dizendo.
<p>- Vai fazer algo? – Ela bufou. Cansou de ser insultada.
<p>- Vou tentar. 
<p>- Se precisar de ajuda, eu estou aqui.
<p>- Ótimo. 
<p>Giovanna se sentou ao lado de Will, mas não falou mais nada.</p>
<br>
<p>“Já aconteceu algo na sua vida que mudou totalmente a sua perspectiva das coisas? Alguém bom que você conhece já fez algo muito ruim? E aquela pessoa que só erra já se redimiu alguma vez? E você? Já se decepcionou? Tipo, quando você queria fazer algo, mas não fez por alguma razão? Você já deixou coisas sem serem ditas? Já agrediu a pessoa errada? Já esteve em um caminho sem volta?
<p>Você se considera o melhor? O pior? Alguém em aprendizado? 
<p>O que você faz quando cai? Espera alguém te ajudar a se levantar? Se levanta sozinho? Fica lá no chão? Por que você cai? E por que você se levanta depois? Ficar no chão é muito mais fácil. Mas o melhor faz o mais fácil? O pior vai pelo mais fácil? Alguém em aprendizado escolhe o mais fácil? Em algum momento da vida, você vai ter que escolher entre se levantar sozinho e ficar no chão até alguém te ajudar a se levantar. Está preparado para essa escolha?”.</p>
<br>
<p>- Não achei que sairia do hospital tão cedo. Alguma coisa mudou? – Jason olhou assustado.
<p>- Não.
<p>Will encontrou o amigo na mesma velha quadra abandonada que os garotos costumavam jogar futebol, ou melhor, jogar a bola de um lado para o outro. 
<p>- Está tudo igual. – Will respirou fundo.
<p>- Vai melhorar.
<p>- Sei. – Will não estava muito convencido daquilo. – Giovanna me disse que o Kevin está usando drogas. Eu sabia que ele havia usado uma vez, mas... ela disse que ele está se viciando. 
<p>- E acredita nela?
<p>- Eu não sei, acho que sim. Não vejo porque ela mentiria sobre isso. – Will tinha um olhar vago e estava cansado demais até para ter raiva.
<p>- Nossa.
<p>- O quê? – Will percebeu que Jason queria falar mais do que já havia falado.
<p>- É estranho, só isso.
<p>- Estranho por quê?
<p>- Você acreditar cegamente na Giovanna e duvidar da Melissa.
<p>- Não vamos começar com isso agora. – Will desviou o olhar.
<p>- Eu fui vê-la ontem à noite depois do circo que você armou.
<p>- E?
<p>- Ela está muito mal. – Jason aumentou o tom de voz. – Você falou tanto que a culpa era dela que ela está começando a acreditar. Você precisa consertar isso.
<p>- O que quer que eu faça?
<p>- Will!
<p>- Eu não vou lá pedir desculpas para a Melissa até saber a verdade. Se eu aparecer lá agora, eu posso falar coisas bem piores que eu ainda não disse e que estou pensando. 
<p>- Não. Você tem que ir lá pedir desculpas a ela exatamente porque não sabe a verdade. Por que ela tentaria matar o Sebastian? A sua cabeça doentia tem alguma história que explique isso?
<p>- Eu não sei, mas se ela fez, algum motivo tem.
<p>- Você está se ouvindo?! – Jason estava totalmente incrédulo. – O que é isso? Algum estado de negação?
<p>- Eu não estou negando nada. Meu irmão está no hospital com quatro buracos e eu não nego isso.
<p>- Eu o amo também, Will. Mas você acusou alguém de uma coisa horrível. Ela se importa com o Seb e agora está se sentindo culpada por algo que você disse. Eu sei que você não é do tipo que pensa, mas dessa vez foi longe demais.
<p>- Então, você, como melhor amigo do Sebastian, acha que existe outra explicação?
<p>- Eu sei que existe.
<p>- Por que acredita tanto assim na Melissa? A gente mal conhece ela.
<p>- Não se trata da Melissa. Se trata de você e de mim e do Seb.
<p>- O quê?
<p>- Will, a gente precisa aceitar que talvez isso não tenha sido culpa de ninguém. Não foi minha culpa, nem sua, nem da Melissa. A culpa foi do Sebastian.
<p>- O que está querendo dizer? Que o Sebastian foi atrás dos tiros? Que ele queria mesmo morrer? Eu não acredito nisso.
<p>- Ele tem problemas, todos nós sabemos disso. 
<p>- Cala a boca!
<p>- Seb é doente, um viciado. Não é culpa de ninguém ele estar naquela cama. Ele não pode evitar, eu sei, e é uma pena, mas a culpa é só dele. 
<p>- Para!
<p>Will não hesitou, mas parou depois que sentiu o impacto do seu punho. Jason foi para trás segurando o nariz com uma mão já cheia de sangue. 
<p>- Jason, eu...
<p>- Tudo bem, Will. – Jason se afastou. 
<p>- Eu não queria...
<p>- Não, você queria sim. Mas espero que perceba que eu estou dizendo a verdade. Você sabe que o Sebastian pode ter feito isso por conta própria, mas não quer se decepcionar como todas as vezes. Você pode me bater a vontade, mas a dúvida não vai sair de você e nem de mim. Só não quero que você saia julgando as pessoas enquanto não sabe de nada. 
<p>- Não sabe o que está dizendo. 
<p>- Ele não é perfeito e quanto mais rápido perceber isso, vai começar a sofrer só por ele e vai parar de culpar os outros e até a si mesmo. 
<p>- Eu... – Will encarou Jason um pouco em choque. – Sinto muito pelo soco.
<p>- Não sente não e só não vai me bater de novo porque a sua culpa não deixa.
<p>Jason deu as costas para Will e saiu da quadra.</p>
<br>
<p>“O que acontece quando você se levanta? 
<p>Saiba que você pode cair de novo, pode até ser pior. Mas você se arrisca, você se levanta, você luta mesmo que seja difícil. Um dia, você vai olhar para trás e vai perceber que levantar é difícil, mas se prender às quedas é muito pior.”.</p>
</body>
</html>";
            }

            if (numero == 38)
            {
                lblTitulo.Text = "Capítulo 38 - Estou Desaparecendo";
                htmlPage.Html = @"<html>
<body>
<p><i>“Onde você está agora?
<br>Em Atlântida
<br>Embaixo no mar, embaixo no mar
<br>Onde você está agora?
<br>Em outro sonho
<br>Os monstros correndo selvagens dentro de mim
<br>Estou desaparecendo
<br>Tão perdido”
<br><b>Faded - Alan Walker</b></i></p>
<br>
<p>Emily já havia acordado, mas se assustou mesmo assim quando Will bateu no vidro da janela dela naquela manhã. 
<p>- O que faz aqui a essa hora? Achei que ainda estava no hospital. – Emily abriu a janela para ele poder entrar no quarto. – Está tudo bem por lá?
<p>- Tudo na mesma. – Will respondeu um pouco derrotado.
<p>- Vai à escola?
<p>- Eu não sei. – Ele respirou fundo e se sentou na cama. – Eu tentei te ligar ontem.
<p>- Eu ouvi a sua mensagem. – Emily se sentou ao lado dele. – Eu só...
<p>- Você está com raiva de mim?
<p>- Não. Eu só estou tentando entender você. Eu sei como você fica quando acontece algo com o Seb e... eu estou tentando.
<p>- Me desculpa.
<p>- Não precisa. – Emily tentou pegar na mão de Will, mas ele se desvencilhou. Ela então percebeu que uma das mãos estava com os nós machucados. – O que houve com a sua mão?
<p>- Nada. – Ele colocou suas mãos no bolso da blusa rapidamente.
<p>- Will, com quem você brigou? Will! – Emily chamou sua atenção quando percebeu que ele não ia falar sem insistência.
<p>- Com o Jason. – Ele sentiu vergonha em dizer.
<p>- O quê? – Emily se levantou da cama. – Você bateu no Jason? Por quê?
<p>- A gente... Ele começou a falar umas coisas que eu não gostei e... Você sabe como eu fico.
<p>- Will, vocês são amigos. Vocês não batem um no outro. 
<p>- Eu sei e eu me sinto péssimo. 
<p>- Espero que tenha se desculpado depois. 
<p>- Eu deixei o nariz dele sangrando. Nenhuma desculpa apaga isso. – Will voltou a ficar irritado.
<p>- Will...
<p>- Minha cabeça já está estourando por causa do Sebastian e agora o Kevin...
<p>- O que aconteceu com o Kevin?
<p>- Giovanna disse que ele está usando drogas com frequência, não só aquela vez como ele disse para gente. 
<p>- Giovanna? – Emily ficou desconfiada.
<p>- Ela terminou com ele quando descobriu. Agora está com medo que ele faça alguma besteira. 
<p>- Nossa, ela deve estar péssima. – Emily revirou os olhos.
<p>- Emily, ela estava mal mesmo quando falou comigo.
<p>- Deixa eu ver se entendi, você agora acredita cegamente na Giovanna e duvida da Melissa quando ela diz que não sabe de nada?
<p>- Jason falou a mesma coisa, mas...
<p>- E o quê? Vai me bater também?
<p>- Isso não tem graça.
<p>- Não é para ter graça. Percebe a doideira que é isso tudo? Como a gente sabe que não foi a Giovanna que deu drogas para ele?
<p>- Porque... – Mas ele não terminou.
<p>- Viu? A gente não sabe. Mas eu estou vendo aqui você defende-la enquanto expulsou a sua amiga do hospital. 
<p>- Vamos voltar a esse assunto de novo?
<p>- Então podemos pular para outro. Se o Jason falar outra coisa que você não concordar, vai bater nele de novo? – Emily só não gritou porque não queria acordar seus pais.
<p>- Você disse que estava tentando me entender.
<p>- É, mas está difícil.
<p>- Ems, eu preciso do seu apoio nessa coisa toda. 
<p>- Desculpa, Will, mas eu não vou passar a mão na sua cabeça e dizer que tudo bem fazer o que você está fazendo agora. Não é assim que eu funciono. Se veio aqui para isso, pode ir embora. 
<p>- Maravilha. 
<p>Will se levantou da cama e voltou para a janela. Olhou para sua namorada mais uma vez e saiu do quarto pelo mesmo jeito que entrou.</p> 
<center><h4>--*--</h4></center>
<p>Giovanna estava inquieta. 
<p>Ela andava de um lado para o outro pelos corredores da escola como se estivesse procurando por alguém. Quando viu Emily pegando seus livros no armário, correu em direção a ela.
<p>- Oi, Emily, tudo bem? – Ela tentou ser gentil.
<p>- Fala. – Emily fechou a porta do armário bem forte quando ouviu a voz de Giovanna e amarrou a cara instantaneamente.
<p>- Olha, o Will deve ter falado para você que...
<p>- É, ele me falou.
<p>- Bom, eu sei que passamos por uns maus bocados, mas aconteceram algumas coisas que me fizeram pensar e...
<p>- Corta esse papo furado. – Emily não estava com nenhuma paciência para aquela conversa. – Não somos e nem vamos nos tornar amigas. Eu pulo na frente de um caminhão antes que isso aconteça.
<p>- Nossa. 
<p>- Nossa? – Emily soltou uma gargalhada. – O que você quer?
<p>- Queria saber o que pretendem fazer a respeito do Kevin.
<p>- Você falou com o Will sobre isso. Pergunta para ele, não para mim.
<p>- Mas... eu achei que você poderia... – Ela iria mencionar a palavra “ciúmes”, Emily sabia disso.
<p>- De loucas como você, eu não tenho ciúme, eu tenho pena. 
<p>- Olha, você tem todo o direito de estar brava comigo e...
<p>- Eu tenho mesmo. 
<p>- Eu não sou mais a mesma pessoa que...
<p>- Que me atacou? Era isso que você ia dizer? – Emily a confrontou. – Você não é mais uma vaca manipuladora? Que passa por tudo e por todos para ter o que quer? Que não passa de uma mimada ridícula que não se importa com ninguém a não ser você mesma?
<p>- Não precisa me ofender. Eu estou tentando ser civilizada.
<p>- É, mas eu não vou fazer nem questão de tentar com você. Sabe por quê? Porque você pode até fazer todo mundo acreditar nessa sua mentira, pode manipular todos, mas a mim não. Você não vai mais me pegar desprevenida. – Emily ficou mais firme. – Da próxima vez que você tentar encostar em mim, eu não vou mais só me defender, eu vou quebrar a tua cara. Agora sai da minha frente, cansa olhar para essa sua cara por mais de um segundo.
<p>Emily empurrou Giovanna contra os armários quando passou do seu lado para ir embora.</p>
<center><h4>--*--</h4></center>
<p>Emily estava tão concentrada em sua raiva por Giovanna que quase não percebeu que Melissa estava sentada, isolada, nos degraus de uma das escadas quando passou pelo corredor. 
<p>- Melissa! – Ela gritou quando já estava no meio do caminho e voltou para a escada. – Eu queria mesmo falar com você.
<p>- O que houve? – Melissa tentou não demonstrar emoção, ela até mesmo enxugou rapidamente as lágrimas do rosto com a manga de sua blusa. 
<p>- Eu... – Emily se sentou ao lado dela. – Eu fui atrás de você ontem depois do show do Will, mas já tinha ido embora.
<p>- Eu achei melhor. 
<p>- E eu sinto muito. – Ela pegou no braço da amiga. – Eu sei que você nunca faria mal algum ao Sebastian. Eu até briguei com o Will por isso.
<p>- Não precisava fazer isso. 
<p>- Precisava sim. Ele estava sendo imbecil. 
<p>- Sabe como ele está? O Sebastian? 
<p>- Do mesmo jeito. – Emily tentou consolá-la com o olhar. 
<p>As duas ficaram em silêncio por um tempo. Emily não sabia se era a hora certa para fazer perguntas mesmo querendo muito as respostas.
<p>- Já faz quanto tempo que...
<p>- Desde a noite do primeiro show do Will. Não era a nossa intenção, mas acabou rolando e depois...
<p>- Não parou mais. – Emily riu. 
<p>- O que eu faço se ele não acordar? 
<p>- Você só tem que pensar no que vai fazer quando ele acordar, não o contrário, senão vai enlouquecer. 
<p>- Você acha que... o Will, ele... 
<p>- Mesmo dizendo aquelas coisas, o Will não acredita que você seja culpada. Ele só precisava culpar alguém para não se culpar. É meio que a válvula de escape dele.
<p>- Eu sei.
<p>- E eu estou aqui para o que precisar. 
<p>- Pode dar um soco no Will por mim?
<p>- Eu quase dei um hoje de manhã antes de você pedir.
<p>As duas começaram rir.</p>
<center><h4>--*--</h4></center>
<p>- Olha só quem apareceu! – Josh começou a bater palmas quando Will entrou no bar, ainda fechado para os clientes. As luzes ainda estavam quase todas apagadas e as cadeiras em cima das mesas. – O que houve com você ontem à noite? Meu astro não pode furar comigo.
<p>- É o meu irmão, Sebastian. Ele está no hospital. Eu me esqueci completamente de avisar. Foi mal. – Will foi até o balcão onde Josh estava. 
<p>- Ele vai ficar bem? – Josh tirou a expressão de deboche rapidamente do rosto e demonstrou preocupação. 
<p>- Na verdade, eu nem sei. – Will suspirou. 
<p>- Bom, como é algo sério, eu te perdoo. – Josh mostrou um sorriso para tentar consolá-lo. – Precisa de alguma coisa?
<p>- Não, eu só...Eu vim te avisar que não vou mais poder...
<p>- Não complete essa frase. – Josh arregalou os olhos. – Você não pode ir embora.
<p>- Josh...
<p>- Você é a nova sensação daqui. Todo mundo perguntou por você nesse fim de semana. Queriam ver o show do Will. Você é famoso, está por toda a parte.
<p>- Não exagera. – Will não ficou animado com aquela informação, muito menos se iludiu.
<p>- Não, eu estou falando sério. Suas apresentações estão pelo Facebook, Instagram e tudo mais. Não é o mais famoso do mundo, mas também não é mais anônimo. 
<p>- Olha, eu... – Will realmente pensou no caso e se imaginou assinando vários autógrafos por aí, mas logo em seguido, viu a imagem de Sebastian baleado no hospital. – Josh, eu realmente não quero te desapontar nem te deixar na mão, mas eu não estou com cabeça para...
<p>- E se a gente combinar que você ganha uma parte dos lucros nas suas noites de show além do seu salário fixo?
<p>- Josh, isso não tem a ver com dinheiro e...
<p>- Cara. – Josh tirou um talão de cheques de uma das gavetas da estante de bebidas, preencheu um cheque, assinou e entregou para Will. – Toma. E só estamos começando.
<p>- O quê? – Will arregalou os olhos e abriu a boca. – Isso é muito dinheiro.
<p>- E isso foi só uma parte do lucro. Agora você entende meu desespero? Você não pode parar.
<p>- Eu nunca ganhei tudo isso de uma vez só. Acho que se juntar todo o dinheiro que eu ganhei na vida, não chega a esse valor.
<p>- Te convenci a ficar?
<p>- Josh...
<p>- Você disse que gostaria de morar sozinho. Com esse dinheiro, você pode dar uma entrada em uma casa. Além do mais, de onde veio esse, pode vir mais. – Josh se empenhou. Estava olhando para a sua galinha de ovos de ouro, não ia desistir dela tão fácil. 
<p>- Eu não sei.
<p>- Você me disse que seu pai te chamou para trabalhar com ele. Vai sair por isso?
<p>- O quê? Não, é claro que não. 
<p>- Então o que é?
<p>- Eu não estou mesmo com cabeça para subir no palco agora. – Ele sabia que não era uma explicação muito plausível, na verdade, era bem idiota. Talvez até estivesse tentando se auto sabotar, era uma opção.
<p>- Cara, você finalmente está tendo uma chance, a chance que você achou que nunca teria. Vai me dizer que não quer se apresentar de novo?
<p>- É claro que eu quero.
<p>- Então?
<p>- É que... – Mas nem Will sabia explicar o porquê de querer desistir daquilo. – Eu posso pensar por um tempo?
<p>- É claro que pode. Só que... eu só quero uma resposta, se for outra, nem venha me dizer.
<p>- Pode deixar. – Will riu.</p>
<center><h4>--*--</h4></center>
<p>- Eu não acredito que o Will fez isso.
<p>Amanda e Jason estavam almoçando juntos em uma mesa isolada no refeitório. Jason tentou cobrir seu nariz roxo com a mão o máximo que conseguiu para evitar perguntas e não falar naquele assunto, mas desde de manhã, Amanda só sabia falar naquilo.
<p>- Deixa para lá. – Ele falou mal-humorado.
<p>- Jason, o Will socou você. Quem ele pensa que é?
<p>- Ele só está triste por causa do Sebastian.
<p>- Todos nós estamos. Isso não dá o direito a ele de te bater. – Ela estava muito brava.
<p>- Eu já disse para deixar para lá.
<p>- Você pode deixar, mas quando eu o encontrar, quem vai dar um soco nele vai ser eu. 
<p>- Sebastian foi baleado, Amanda. Isso nunca aconteceu antes.
<p>- Eu sei, tá? – Amanda respirou fundo e sua raiva saiu como o ar dos seus pulmões. – Eu estou morrendo de medo. E eu só estou falando do Will porque quero me distrair e tentar tirar da minha cabeça a imagem do Sebastian desse jeito. 
<p>- Eu só queria saber o que aconteceu.
<p>- Se ao menos a Melissa...
<p>- Amanda. – Jason não gostava nenhum pouco da ideia de Amanda concordar com o irmão de que Melissa era culpada de algum jeito.
<p>- Tá, não falo mais da sua amiguinha. – Ela revirou os olhos.</p>
<center><h4>--*--</h4></center>
<p>- Ainda está brava comigo? – Will estava esperando por Emily no portão enquanto ela saía da escola. Ela o olhou um pouco desconfiada, mas depois fez que não com a cabeça. – Que bom porque eu realmente preciso da minha namorada agora. 
<p>- Vamos caminhar.
<p>Enquanto caminhavam, Will contou para a namorada sobre a conversa que teve com Josh mais cedo.
<p>- Você não precisa pensar. Não pode largar. – Ela disse quase que instantaneamente.
<p>- Ems, eu sei lá. Cantar é a última coisa que eu estou pensando agora.
<p>- Não interessa. Essa é uma grande oportunidade. Não pode desistir agora. Você não é um simples barman, você é o cantor principal daquele lugar.  
<p>- Mas tem tanta coisa acontecendo.
<p>- O Sebastian está no hospital e você não pode fazer nada para ajudar. Mas cantar vai te ajudar.
<p>- Talvez tenha razão.
<p>- Eu sempre tenho razão.
<p>- E olha que você ainda nem viu o valor do cheque.
<p>- Sabe que não se trata disso. Eu te vi no palco, eu te vejo todas as vezes e... 
<p>- Eu nunca me senti tão feliz. – Will ficou pensativo.
<p>- Exato.
<p>- Mas eu não posso me sentir assim agora. Não é certo.
<p>- Mas às vezes tudo bem. – Emily segurou na mão dele. 
<p>- Teve uma boa aula? – Will mudou de assunto.
<p>- Tive sim, e por que você não teve? – Ela o olhou com uma cara de reprovação.
<p>- Eu não...
<p>- Está tentando evitar o Jason?
<p>- Não. Um pouco. Estou. – Ele se acovardou com o olhar de Emily.
<p>- Uma hora vai precisar falar com ele. 
<p>- Não quero pensar nisso agora. Vamos comer alguma coisa? Quero me entupir de bolinho.
<p>- Antes... Giovanna veio falar comigo hoje. – Emily fechou a cara. – Cheia de conversa fiada.
<p>- Emily, o que você fez? – Will se preocupou. 
<p>- Nada, mas queria ter metido a mão na cara dela.
<p>- O esquentadinho da relação sou eu. Só assim a gente funciona.
<p>- Eu não a suporto.
<p>- Ela pode mudar, sabia? Eu quero mesmo acreditar nesse momento que pessoas podem mudar. 
<p>- Will, o Sebastian não é a Giovanna.
<p>- Mas está na pior tanto quanto ela.</p>
<center><h4>--*--</h4></center>
<p>Will foi até o hospital. 
<p>Já estava quase anoitecendo, e aquele era o horário perfeito. Seus pais estariam em casa fazendo o jantar para Matt e não ali, assim ele não precisaria encará-los. 
<p>Aquela sala de espera estava vazia. Will se sentou em uma das cadeiras e começou a pensar. Entraria no quarto de Sebastian, ele estaria inconsciente, mas precisavam conversar. Will precisava desabafar, sem se importar se o outro lado iria ouvir ou não. 
<p>A porta para a UTI se abriu e Melissa saiu por ela.
<p>- O que faz aqui? – Will se levantou quase que imediatamente.
<p>- Eu... só... – Melissa entrou em choque. – Will, eu...
<p>- O quê?
<p>- Só vim ver como ele está. Não pode me proibir de fazer isso. 
<p>- Não, eu não posso. 
<p>- Ótimo. – Ela ficou séria.
<p>- Quer dizer que... vocês estão juntos? – Ele a olhava como um detetive desconfiado atrás de mentiras.
<p>- Eu não sei bem. Ainda não... decidimos. 
<p>- Ele é frágil. Não pode fazer esse tipo de coisa. Ele precisa ter uma relação estável e...
<p>- Ele parecia muito bem tendo uma relação não estável comigo.
<p>- Se ele estivesse tão bem, não estaria aqui. – Will se aproximou mais de Melissa. 
<p>- Quando vai parar de me culpar? Sabe que a culpa não é minha. 
<p>- Tudo o que eu sei é que ele foi baleado no lado barra pesada da cidade. E você passou o dia todo com ele.
<p>- E você não passou. Não estava lá para cuidar dele. 
<p>- Isso é injusto.
<p>- E me acusar não é? 
<p>- Vai embora, Melissa. – Will respirou fundo.
<p>- Achei que tinha dito que não podia me proibir de estar aqui.
<p>- É, só que eu menti. Eu posso, sim. 
<p>- Tudo bem. Eu já fiz o que eu tinha para fazer aqui. Se você quer continuar com essa teimosia, eu não estou a fim. 
<p>- Eu não quero brigar. 
<p>- Não é o que parece. – Melissa o encarou. – Somos amigos, pelo menos, eu achei que éramos. E agora, você me trata como se não me conhecesse. 
<p>- Aquele cara que está em coma é tudo para mim. 
<p>- E isso te dá o direito de tratar mal as pessoas?
<p>- Me dá o direito de saber o que aconteceu. E você não quer me dizer. E pela minha experiência, quando alguém esconde algo, é porque se sente culpado.
<p>- Eu não sei de nada. Não tenho nada para esconder.
<p>- Mentira. E espero que quando o Sebastian acordar, ele não tente te proteger e conte a verdade. 
<p>- Eu também espero, Will. Eu também espero.
<p>Melissa deu as costas para Will e saiu da sala de espera. Ele ficou alguns segundos parado olhando para aquela porta que separava a sala da UTI. Sebastian estava do outro lado, todo remendado, respirando por um tubo e inconsciente. Ele não queria ver aquilo. Deu meia volta e foi embora.</p>
<center><h4>--*--</h4></center>
<p>Quinn foi à praia. Se sentou na areia e ficou por algumas horas observando o mar, em silêncio. A brisa no seu rosto. 
<p>- Oi, eu posso me sentar aqui com você? – Chris cobriu o sol que ela estava tomando.
<p>- Claro, a praia é pública. – Ela sorriu enquanto ele se sentava.
<p>- O que faz aqui sozinha? Você está bem?
<p>- Eu queria ficar um pouco sozinha, organizar os meus pensamentos... 
<p>- Quer ficar sozinha agora?
<p>- Não. Na verdade, eu gosto de você estar aqui.
<p>- Não precisa fingir que está tudo bem, sabia?
<p>- Eu não estou fazendo isso. Só acho que não preciso de consolo tanto quanto os outros. Preferi eu mesma me consolar. – Quinn soltou uma gargalhada.
<p>- Acho que todo mundo que se importa com o Sebastian precisa de consolo.
<p>- Eu amo o Sebastian. Não somos mais namorados, mas eu ainda o amo. 
<p>- Sei como é, não somos os melhores irmãos, mas... 
<p>- Ele vai melhorar, eu sei. Ele já passou por isso.
<p>- Vai, sim. – Chris concordou.
<p>- Eu sei o que eu estou fazendo aqui, mas o que você está fazendo aqui? – Quinn olhou para Chris com um pouco de carinho. – Você está bem?
<p>- Eu só estou me sentindo um pouco sozinho. 
<p>- Sozinho?
<p>- Eu sempre foquei nos estudos. Não tenho mais namorada, o Kevin virou outra pessoa com quem eu não consigo mais conversar. Will tem seus problemas, eu não tenho amigos.
<p>- Eu sou sua amiga. Não está sozinho.
<p>- É por isso que eu estou aqui. – Chris soltou um sorriso. – Dois sozinhos juntos não ficam mais sozinhos. 
<p>- É matemática básica. – Quinn riu.</p>
<center><h4>--*--</h4></center>
<p>Jason estava treinando arremessos na cesta quase quebrada naquela quadra pública abandonada. Praticar esportes era o seu jeito de esquecer as coisas.
<p>- Jason!
<p>Will pegou a bola enquanto ela caía da cesta e fez outro arremesso. 
<p>- Vamos jogar? – Will jogou a bola de volta para Jason. 
<p>- Ah, eu prefiro jogar sozinho agora, senão se importa.
<p>- Olha, eu vim aqui me desculpar. – Will tentou não fixar seu olhar no nariz machucado do amigo. – Amanda, depois de gritar por meia hora, me disse que estaria aqui. 
<p>- Você já pediu desculpas. 
<p>- Eu sei, mas... Estamos bem?
<p>- Sim. Estamos. – Jason estava sério. 
<p>- Então podemos jogar?
<p>- Eu já disse que prefiro jogar sozinho agora. Talvez amanhã. 
<p>- Jason, eu estou aqui tentando pedir desculpas. Podia facilitar.
<p>- Por que exatamente, eu deveria facilitar? – Jason jogou a bola de basquete no chão. – Você fez isso comigo. – Ele apontou para o seu nariz inchado.
<p>- E eu já pedi desculpas. – Will subiu o tom de voz. – Mas você disse que está tudo bem, quando obviamente não está.
<p>- É, não está mesmo. Porque você me bateu e eu achei que isso nunca fosse acontecer. – Jason começou a falar um pouco mais alto também. 
<p>- E eu sinto muito.
<p>- Sente mesmo? 
<p>- É claro que eu sinto. Você é meu melhor amigo. 
<p>- Está arrependido?
<p>- É claro. 
<p>- Então quer dizer que se eu começasse a falar as mesmas coisas que eu falei ontem, não ia me bater de novo?
<p>- Jason... – Will hesitou.
<p>- Exatamente. Eu estava lá quando você bateu no Kevin e vi como você ficou e me disse várias vezes que não faria isso de novo.
<p>- E fiz.
<p>- É, mas pelo menos dizia que não ia fazer. Quanto a mim, nem isso você conseguiu dizer. 
<p>- Jason...
<p>- Você tem razão. Não estamos bem, estamos bem longe disso. Porque eu me importo com o Sebastian tanto quanto você, mas eu nunca... nunca bateria em você para me sentir melhor comigo mesmo.
<p>- Não foi isso que aconteceu.
<p>- Foi exatamente isso que aconteceu. E com certeza, eu vou te perdoar, mas não consigo agora porque eu estou com muita raiva. 
<p>- Eu também estou com raiva. 
<p>- É, mas diferente de você, eu vou embora, não saio batendo nas pessoas. 
<p>Jason deu as costas para Will e saiu da quadra. 
<p>- Esqueceu sua bola! – Will gritou.
<p>- Pode ficar com ela! – Jason gritou sem nem olhar para trás.</p>
<center><h4>--*--</h4></center>
<p>- O que está fazendo aqui? – Kevin estava saindo do quarto quando viu Will passar pelo corredor para chegar até a porta do seu quarto.
<p>- Eu ainda moro aqui. – Will falou irritado quando parou em frente à sua porta. 
<p>- É, infelizmente. – Kevin bufou. 
<p>- Cadê todo mundo? – Ele se virou e olhou para o irmão que estava em estado deplorável. Kevin parecia que não dormia há dias e muito menos via a luz do sol. Estava branco feito papel. 
<p>- Voltaram para o hospital, mas o Chris está no outro quarto tentando fazer o Matt dormir. Nosso bebê. – Kevin riu.
<p>- Posso falar com você?
<p>- Estou sem tempo. – Kevin ignorou Will e desceu as escadas correndo.
<p>- Arranja um tempo. – Will o seguiu e os dois pararam na sala de estar um de frente para o outro. 
<p>- Olha, você não tem nada mais importante para fazer? Por que não vai para o hospital também? Devem precisar de você lá para chorar. 
<p>- Você está drogado. Então tudo o que disser...
<p>- Não vai ter credibilidade? Não, eu não estou drogado. Pelo menos, não hoje.
<p>- E você ainda fala isso com orgulho? 
<p>- Cala a boca.
<p>- Não, agora você vai me ouvir. Vai parar de ser um idiota agora mesmo. 
<p>- Não se mete.
<p>- Você é só uma criança. Não pode entrar nessa. 
<p>- Obrigado, Will, por tentar me salvar. – Kevin usava seu tom de sarcasmo muito bem. – O que seria de mim sem meu irmão perfeito. 
<p>- Para.
<p>- Para você. Não vem fingir que está preocupado. Você nem se importa comigo. Não fala comigo por semanas e de repente aparece...
<p>- Não é verdade. Você é meu irmão e...
<p>- Tem pena de mim. Certeza que já soube que a Giovanna me chutou. 
<p>- E por isso acha que a sua vida acabou. – Will tentou manter a calma. Se ele começasse a gritar, Kevin gritaria mais alto e em dois minutos os dois estariam se socando. 
<p>- Pode não ter acabado, mas eu não vejo mais razão...
<p>- Ah, não começa com isso. Você só tem quinze anos.
<p>- E acabei de perder o amor da minha vida!
<p>- Ela pode ser o amor da sua vida. Agora. Mas isso vai passar, e quando passar, vai perceber que o que está fazendo é a coisa mais errada do mundo.
<p>- Mentira.
<p>- Ela é só uma garota. Você precisa deixar para lá. Está acabando com a sua vida por causa dela.
<p>- Não, eu estou acabando com a minha vida por causa de você! – Kevin gritou descontrolado. – Você me tirou a única coisa que era importante para mim!
<p>- Eu nunca...
<p>- Ela nunca se apaixonaria por mim, já que ama você.
<p>- Kevin...
<p>- Calado.
<p>- O Sebastian está no hospital por causa dessas benditas drogas e você está afundando nelas igualzinho a ele. Você não aprendeu nada? É tão lesado desse jeito? – Will percebeu que falava daquele jeito, mas na realidade, queria suplicar.
<p>- Já acabou?
<p>- Não, eu não acabei. 
<p>- Conta para o papai, eu não ligo. Logo eu vou estar bem longe daqui.
<p>- Porque vai comprar uma casa com dinheiro de agiota? Porque vai para debaixo do viaduto cheirar junto com os seus amigos?
<p>- Você é engraçado. Esse é o mesmo discurso que você faz para o Sebastian toda vez que ele tem uma overdose? – Kevin riu. – Pelo menos, eu sei usar direito e isso nunca aconteceu.
<p>- Kevin... – Will ficou desconcertado. – Cala essa boca e volta para o seu quarto.
<p>- Ah, quer parar de conversar? – Kevin começou a rir. – Está acostumado com o Sebastian concordando com tudo o que você fala, não é? Na verdade, essa sua conversinha não é muito funcional. Ele está no hospital, não está?
<p>- Cuidado. – Will estava sério. 
<p>- É a verdade, não é? Agora só falta você me bater de novo. Nossas conversas não acabam sempre assim? 
<p>- Eu não estou entendendo. Por que exatamente está com raiva de mim? Você está estragando a sua vida, eu estou tentando ajudar e você está com raiva de mim. O que está acontecendo?
<p>- Você não está tentando me ajudar. Só não quer ficar com a consciência pesada. Você engana todo mundo, menos a mim. Você é o culpado por eu estar assim. Tudo o que acontecer comigo...
<p>- Pode ir parando por aí. Eu não vou ser responsabilizado pelas idiotices que você faz. Eu tentei te ajudar, na verdade, eu estou tentando agora mesmo, mas você... você não se importa. Nosso irmão...
<p>- Ele não é meu irmão!
<p>- Nosso irmão está no hospital e pode morrer por causa dessas coisas que você gosta tanto. É isso que você quer que aconteça com você também? Essa noite foi uma das piores noites da minha vida porque eu fiquei naquela droga de hospital a noite toda esperando os médicos me dizerem se meu irmão estava morto ou vivo. É isso que você quer da sua vida? É tão idiota para querer isso?
<p>- E se fosse eu? Se eu estivesse no hospital?
<p>- Eu estaria do mesmo jeito!
<p>- Eu duvido. E se tivesse que escolher entre nós dois? Hein? O que escolheria? Me fala.
<p>- Kevin...
<p>- Anda! Me fala!
<p>Will respirou fundo e abaixou a cabeça. Fechou os punhos e imaginou esmurrando a cara do irmão naquele momento sem ninguém para impedi-lo. Queria machucá-lo tanto que a raiva que sentia não seria o suficiente.
<p>- Eu preferiria que você estivesse naquele hospital morrendo agora. – Will o encarou. – Era isso que queria ouvir? Está feliz?!
<p>- Nunca estive tão feliz em toda a minha vida.
<p>Kevin deu as costas para Will e saiu de casa.</p>
<br>
<p>“Você já se olhou no espelho e seu reflexo não mostrou quem você achava que era? Você está mudado completamente. Isso que acontece. Diz coisas que não deveria dizer, faz coisas que não deveria fazer. 
<p>E torce para alguém no meio do caminho te enxergar e te ajudar a voltar a ser quem era antes de tudo. Você só pode torcer por isso.”.</p>
<br>
<p>Emily atendeu um pedido bem estranho no meio da noite. Will havia mandado uma mensagem de texto para ela quase meia-noite e a deixou preocupada. Não perguntou porque nem o que estava acontecendo. Simplesmente se levantou da cama, trocou de roupa, saiu de casa em silêncio para não acordar ninguém e andou cinco quilômetros até a praia onde Will estava.
<p>- O que aconteceu? Sebastian está bem?
<p>Will estava de pé olhando para o horizonte negro com os braços cruzados. 
<p>- Eu não sei o que está acontecendo. – Will se virou para Emily. Seus olhos estavam vermelhos e inchados. 
<p>- Will, o que houve? – Emily se aproximou preocupada. 
<p>- Eu não sei o que está acontecendo. – Ele repetiu.
<p>- Will...
<p>- Não fica com raiva de mim. – Ele voltou a chorar.
<p>- Will, mas eu não estou...
<p>- Por favor, não fica com raiva de mim. 
<p>Will a abraçou e desmoronou em lágrimas. Emily ficou em silêncio e esperou até que passasse.</p>
</body>
</html>";
            }

            if (numero == 39)
            {
                lblTitulo.Text = "Capítulo 39 - Como Se Fosse O Aniversário Dela";
                htmlPage.Html = @"<html>
<body>
<p><i>“Ela está tão bêbada, agindo feito louca
<br>Fazendo uma cena
<br>Como se fosse o aniversário dela
<br>Bebendo champanhe, enlouquecendo
<br>Caindo em mim
<br>Como se fosse o aniversário dela”
<br><b>Like It’s Her Birthday - Good Charlotte</b></i></p>
<br>
<p>Cinco minutos em cima do palco fez Will esquecer tudo o que estava acontecendo na vida dele e aquelas três horas foram as melhores horas em semanas. Por um momento, ele havia se esquecido de como a vida dele se transformou em uma droga do dia para a noite.
<p>- Você foi incrível! – Emily, que ficava todas as noites o assistindo atrás do palco, o abraçou assim que ele terminou o show. – Mas está suado demais.
<p>- Valeu. É, eu preciso mesmo de um banho.
<p>- Como você está?
<p>- Ems, o que aconteceu naquela noite nunca mais vai acontecer. – Ele se referia ao dia em que ele fez Emily ir até a praia no meio da noite para poder desabafar e chorar nos braços dela por horas.
<p>- Não me interessa se vai acontecer ou não. Só quero saber se você está realmente bem. 
<p>- Estou melhor. 
<p>- Sério? Porque a situação ainda está igual com todo mundo. Jason, Melissa, Kev...
<p>- Will!
<p>Emily foi interrompida por um grito. Giovanna vinha na direção dos dois correndo, toda sorridente.
<p>- Giovanna? – Will olhou para Emily desconfiado depois olhou para Giovanna. – O que faz aqui?
<p>- Bom, eu fiquei sabendo que você virou um astro do rock. Eu tinha que ver isso. – Ela estava muito animada. – Você foi maravilhoso.
<p>- Valeu.
<p>- Incrível. – Giovanna o abraçou tão de repente que ele ficou sem reação. Não retribuiu o abraço, mas também não se afastou. – Ah, oi, Emily.
<p>Emily não respondeu. Só levantou as sobrancelhas e continuou de cara fechada.
<p>- Bom, eu já vou. Só queria te parabenizar. O show foi perfeito. – Giovanna deu um “tchau” com a mão e foi embora saltitando.
<p>- Somos amigos dela desde quando mesmo? – Emily cruzou os braços brava enquanto observava Giovanna indo embora.
<p>- Relaxa, tá bom? Ela só faz isso para irritar. E eu não quero me irritar hoje. Na verdade, eu queria te agradecer.
<p>- Pelo quê?
<p>- Por não me deixar desistir. Você tinha razão, cantar é o que me move. Não posso mais ficar sem isso.
<p>- E você ainda fica surpreso quando eu te digo que sei o que é certo para você. – Emily sorriu. 
<p>- É, eu nem sei porque eu ainda tento te contrariar. – Ele também sorriu. – E para te agradecer de verdade, eu estava pensando em transformar amanhã em um grande dia.
<p>- Como assim? 
<p>- Eu ainda estou com raiva de você ir para Nashville no seu aniversário. Então a gente pode comemorar amanhã.
<p>- Amanhã não é meu aniversário. E não precisa fazer isso, eu sei que você odeia comemorar aniversário.
<p>- Eu odeio comemorar o meu aniversário, o seu eu até gosto. 
<p>- Ridículo.
<p>- Não, é sério. Você vai para Nashville despois de amanhã então... que tal a gente sair para jantar? Assim dá tempo de eu ir comprar um presente.
<p>- Você ainda não comprou? – Emily fingiu estar em choque.
<p>- Amor, você já sabe a resposta.</p>
<center><h4>--*--</h4></center>
<p>- Nossa, tudo o que eu queria nesse momento era viajar para bem longe daqui. Me leva também, por favor. Prometo ir dentro da sua mala. – Melissa brincou.
<p>Melissa e Emily estavam tomando café juntas em uma cafeteria perto da escola antes da aula começar.
<p>- Na verdade, você bem que podia ir no meu lugar. Eu detesto ter que viajar logo agora. Está todo mundo um caos.
<p>- Relaxa, vai ser só por uma semana. O que de pior poderia acontecer?
<p>- Sebastian foi baleado em algumas horas. Pode acontecer várias coisas em sete dias. 
<p>- Will e Jason ainda estão brigados?
<p>- Sim e ainda tem o Kevin. Eu queria mesmo desistir dessa viagem. – Emily bufou.
<p>- Sua vó te mataria se você não fosse.
<p>- É, eu tenho certeza que amanhã vou chegar lá e a casa toda vai estar cheia de bexigas coloridas e cartazes por toda a parte. É que...Você vai ficar bem?
<p>- É, eu sei. Você é a única pessoa que está falando comigo e talvez sem você aqui eu enlouqueça, mas... – Melissa riu. – Eu vou ficar bem. Qualquer coisa, eu pego um voo para lá também e vou curtir a sua festa de aniversário na roça. 
<p>- Engraçadinha. 
<p>- Quem não deve estar nada feliz é o Will. Você me disse que ele armou um circo no ano passado.
<p>- Bem isso. E quase pirou quando eu fiz o mesmo no aniversário dele. – Emily riu da lembrança daquele aniversário horrível. 
<p>- Imagino a cara dele. – Melissa riu junto. 
<p>- Ele me disse que vai fazer algo especial hoje à noite. Já que não vamos passar meu aniversário juntos, ele quer comemorar antes. 
<p>- Não quer perder os seus doces dezessete. – Melissa brincou.
<p>- É, ele está atrasado.</p> 
<center><h4>--*--</h4></center>
<p>- Você já fez as pazes com o Jason? E se não, por que está demorando tanto?
<p>Amanda confrontou Will em seu quarto enquanto ele penteava o cabelo para ir à escola. 
<p>- Bom dia para você também, Amanda. – Will ignorou a irmã e continuou olhando para o espelho.
<p>- Ah, não enche. Já falou com o Jason?
<p>- Ele não quer falar comigo.
<p>- Como sabe disso?
<p>- Porque ele já me disse. Eu não vou insistir. Quando ele quiser, ele aparece.
<p>- Deixa eu ver se entendi. Você bate nele e espera que ele venha atrás de você? 
<p>- Você entendeu errado. Eu fui pedir desculpas e ele disse que ainda não está pronto para me perdoar. Quando estiver, ele vai me dizer. Simples assim. 
<p>- E você não está nenhum um pouco com remorso? 
<p>- Eu pedi desculpas, Amanda. – Will olhou sério para a irmã. – O que mais você quer que eu faça?
<p>- Vá até a casa dele e fique na porta até ele te perdoar. 
<p>- Isso não vai acontecer.
<p>- Você está se ouvindo? Jason perdeu o pai poucos meses atrás e agora aconteceu isso com o Sebastian. Por que você acha que é o único que tem o direito de estar bravo e sofrendo? 
<p>- Não enche.
<p>- Se você fosse um bom amigo, engoliria esse orgulho estupido e ficaria do lado dele.
<p>- Você não sabe de nada.
<p>- E você sabe? – Amanda não estava para brincadeira e nem iria abaixar a cabeça para o irmão. 
<p>- Eu sei que o Jason tem problemas, mas eu também tenho e não estou falando só do Sebastian. Também tem o Kev...
<p>- Kevin não é problema seu. 
<p>- Ele precisa ser problema de alguém. A mamãe não consegue cuidar disso. Quando ela descobrir, provavelmente vai ter um ataque cardíaco. Enquanto isso, nosso querido pai só sabe falar alto e nada mais. 
<p>- Não dá para salvar quem não quer ser salvo. Já dizia o Batman.
<p>- Batman não falava isso.
<p>- Como sabe? Ele não é de verdade, posso inventar o que eu quiser dele. 
<p>- Embora eu queira muito continuar a ter essa conversa estimulante com você, eu...
<p>- Will. – Amanda pegou no braço do irmão quando ele tentou sair do quarto. – Jason precisa de você tanto quanto você precisa dele e sabe disso. Essa briga é idiota. 
<p>- Eu sei, mas eu bati nele e para falar a verdade, eu estou com vergonha. Então eu não posso ir até a casa dele e ficar na porta até ele me perdoar, porque nem eu sei se mereço perdão. 
<p>- Mas vocês são...
<p>- Amigos, eu sei. Mas agora eu não posso fazer nada.</p> 
<center><h4>--*--</h4></center>
<p>Quinn foi visitar Sebastian para se despedir. Estava indo para Nashville no dia seguinte e mesmo que pensar naquilo doesse, ela tinha medo de voltar já com as más notícias então preferiu prevenir. Era como um <i>déjà vu</i>. Ela se lembrava como tida sido da última vez. Na verdade, naquela vez, eles mal se conheciam e agora ele já era uma parte dela. 
<p>Na hora de sair, estava tão distraída e aluada que demorou para perceber que havia uma garota parada em frente à porta central do hospital. Dessa vez, Melissa nem se atreveu a entrar.
<p>- Por que não entra logo? – Quinn falou com a Melissa. 
<p>- Da última vez que eu estive aqui, fui expulsa.
<p>- Relaxa, o Will não está aqui. 
<p>- Menos mal.
<p>- Você sabe que ninguém acredita que é sua culpa, não sabe?
<p>- Você não vai vir com o discurso de “se ele estivesse comigo, isso nunca teria acontecido”? – Melissa fingiu estar surpresa com a atitude de Quinn. 
<p>- Mesmo tendo agido feito uma louca com você, eu não sou esse tipo de pessoa. E eu sei que não foi sua culpa. Logo meu discurso seria inválido. 
<p>- Obrigada.
<p>- Agora entre e vai lá falar com ele. 
<p>- Obrigada de novo. 
<p>- Disponha.</p> 
<center><h4>--*--</h4></center>
<p>Will olhou no relógio em seu pulso. Estava meia-hora adiantado. Deu uma última olhada no espelho, passou as pontas dos dedos no cabelo e se declarou pronto para sair. Seu telefone, que estava jogado em cima da cama, começou a tocar.
<p>- Alô?
<p>- <i>Will, você precisa me ajudar.</i> – Will reconheceu a voz logo de cara.
<p>- Giovanna, eu estou meio ocupado agora. Eu preciso...
<p>- <i>É muito urgente.</i>
<p>- Então liga para outra pessoa e pede ajuda para ela porque eu não posso agora.
<p>- <i>Will, é o Kevin.</i>
<p>- Olha, Giovanna, isso não me interessa mais. 
<p>- <i>Por favor, Will.</i> – Giovanna estava quase chorando de desespero. – <i>Eu estou muito preocupada.</i>
<p>- Então liga para os meus pais ou então para a polícia. Talvez se ficar preso uma noite, ele aprenda. 
<p>- <i>Eu não posso fazer isso.</i> – Giovanna respirou fundo. – <i>Ele estava com algumas pessoas e... Você precisa me ajudar.</i>
<p>- Que parte do “não me interessa” você não entendeu? Eu tenho planos essa noite e ser babá do Kevin não está neles. 
<p>- <i>Ele é seu irmão e eu não vou conseguir sozinha. Eu preciso de você!</i>
<p>- Onde vocês estão? O que aconteceu?
<p>- <i>A gente brigou, ele estava atrás de mim e... eu disse umas coisas, ele também. Ele ficou muito mal e eu fiquei preocupada então resolvi segui-lo. Ele veio para um bar meio estranho, tenho certeza que veio atrás de drogas.<i/>
<p>- Olha, Giovanna... eu tenho que... – Will não conseguia terminar a frase. – Não dá para aguentar a barra?
<p>- <i>Ele não vai me ouvir. Na verdade, eu sou a última pessoa que ele gostaria de ver agora.</i>
<p>- Só que eu também não sou o melhor amigo dele nesse momento. 
<p>- <i>Mas eu estou desesperada. Não sei o que fazer!</i>
<p>- Tá legal. – Will desistiu de lutar. – Me manda o endereço por mensagem. Estou indo para aí. Fica de olho nele até eu chegar.
<p>Will desligou o telefone. Até pensou em mandar uma mensagem para Emily dizendo que chegaria um pouco atrasado, mas se tudo desse certo, ele não precisaria nem contar para ela o que havia acontecido e ainda chegaria na hora.</p>
<center><h4>--*--</h4></center>
<p>Will não tinha muito costume de ir para aqueles lados da cidade e não se sentia muito seguro andando por ali também. O bar era muito escuro, muito parecido com o outro onde ele, junto com Emily, se encontrou com o agiota meses atrás. 
<p>Havia umas luzes vermelhas piscando e às vezes causavam até ardência nos olhos. Contradizendo com o estado do bar, o lugar estava cheio de gente e Will estava até com dificuldade de andar entre as mesas. Alguém até tropeçou nele e derrubou vodca em sua camisa. O cheiro era tão forte que ele quase conseguiu sentir o gosto da bebida só de respirar. 
<p>- Giovanna! – Will gritou quando a viu perto do balcão. – Cadê o Kevin?
<p>- Ele entrou no banheiro faz uns dez minutos. – Ela foi em direção a ele. Estava com os olhos inchados e tremia segurando um copo de água tônica. 
<p>- Eu disse para você ficar de olho nele até eu chegar. 
<p>- Eu não podia entrar no banheiro! – Ela gritou.
<p>- Não seria a primeira vez.
<p>Will, já muito irritado, foi até o banheiro. Ele com certeza ficou drogado por tabela. A fumaça de maconha deixou o banheiro todo branco e ele mal conseguia respirar lá dentro. Porém conseguiu averiguar. Kevin não estava lá. 
<p>- Tem certeza que ele entrou aqui?
<p>- Absoluta. – Giovanna o esperava perto da porta do banheiro.
<p>- Perdemos ele.
<p>- O que vamos fazer? – Ela ficou mais desesperada. 
<p>- Ele estava com alguém? Conversou com alguém?
<p>- Ele conversou um garoto ruivo. Não sei quem é, mas se eu ver o rosto... – Giovanna começou a olhar para os lados. – Aquele ali! – Ela apontou para um garoto isolado em um canto do bar no escuro.
<p>Will foi até o garoto bem depressa empurrando as outras pessoas que ficavam em seu caminho. 
<p>- Oi, eu estou procurando uma pessoa! – Will gritou. A música estava alta e o garoto um pouco alienado. Talvez nem soubesse onde estava. 
<p>- Eu não vendo nada, está falando com a pessoa errada, otário. – Ele começou a rir.
<p>- Eu não quero comprar nada, idiota. – Will pegou na camiseta do garoto bastante irritado. – O garoto que você conversou. Onde ele está?
<p>- Eu conversei com muita gente, seja mais especifico. 
<p>- Ele usava uma camiseta laranja e um boné verde. – Giovanna gritou por cima do ombro de Will. 
<p>- Ah, o Kevin. – Ele voltou a rir. – Foi buscar uma coisa nova para gente. Quer experimentar um pouco também?
<p>- Se você falar sobre drogas para mim de novo, eu vou arrancar os seus dentes, está me ouvindo?
<p>- Will. – Giovanna estava assustada.
<p>- Sabe para onde ele foi, idiota?
<p>- Para o Studio.
<p>- Studio? – Will não fazia ideia de o quê ou onde era aquilo.
<p>- É um bar aqui perto. A gente já... – Giovanna ficou um pouco envergonhada.
<p>- Que maravilha. – Will fechou os punhos e se segurou ao máximo para não socar a cara daquele garoto, que parecia ter a mesma idade do irmão, ou até mesmo a parede. 
<p>- Vamos até o Studio agora? – Giovanna segurou o choro.
<p>- Eu não... Eu não posso! Eu já estou atrasado. Na verdade, nem deveria estar aqui. – Will pegou o celular do bolso da calça. – Ah, que ótimo, sem bateria.  Está com o seu celular aí?
<p>- Está sem bateria também. – Giovanna respondeu. – Usei o resto para te ligar. Will, por favor, não pode me deixar sozinha agora.
<p>- Tudo bem. – Will, mesmo bravo, ainda conseguiu ter pena do desespero de Giovanna. – Vamos lá. 
<p>Ele seguiu até o Studio em silêncio. Nem ouvia direito os murmúrios de Giovanna, só conseguia pensar em Emily e em como seus planos haviam ido por água à baixo.</p>
<center><h4>--*--</h4></center>
<p>Kevin também não estava no Studio.
<p>- Eu não acredito que vamos ficar brincando de esconde-esconde com o Kevin a noite toda. – Will se sentou no balcão com o sangue fervendo. 
<p>- Será que ele voltou para o...
<p>- Eu não sei!
<p>- Não precisa gritar.
<p>- Eu não estou bravo com você, Giovanna. Estou irritado é comigo mesmo por estar aqui me importando com aquele idiota.
<p>- Podemos dar uma volta pelo bairro. Talvez tenhamos sorte. 
<p>- Eu duvido, mas o que temos a perder, não é?
<p>Os dois perderam umas três horas andando de bar em bar, de beco em beco, atrás de um mínimo sinal de Kevin. Quando chegaram no último bar já não tinham esperança nenhuma. Giovanna passou o caminho todo tentando puxar uma conversa com a desculpa que precisavam relaxar um pouco, descontrair, mas Will não lhe dava atenção nenhuma, mal a escutava para ser sincero. Estava com tanta raiva que ele poderia socar a parede de concreto mais próxima e não sentiria dor. Pelo menos, não naquele momento. 
<p>- Olha, eu acho que sei de quem você está falando. – Will arregalou os olhos quando ouviu aquela resposta do décimo barman com quem ele havia conversado naquela noite. – Ele estava bem mal, e mesmo assim queria continuar bebendo.
<p>- Ele tem quinze anos. – Will o acusou.
<p>- Calma, cara, ele já chegou aqui assim e não estava só bêbado. Ele tinha usado e era algo pesado. Eu pedi um taxi, se o endereço que me deu foi o certo, ele já deve estar em casa ou pelo menos no portão.
<p>- Eu não acredito nisso. – Will finalmente respirou aliviado.
<p>- Ele é uma criança, eu tenho noção disso.
<p>- Aparentemente é o único. Afinal nem ele tem essa noção. 
<p>Já muito cansado, Will aceitou que agora deveria voltar para casa para se certificar de que seu irmão estava mesmo lá.</p> 
<center><h4>--*--</h4></center>
<p>Kevin estava dormindo de bruços jogado na cama quando Will entrou no quarto dele. Ele ainda estava de tênis e jeans. Fedia a álcool, mas Will também. Umas dez pessoas haviam esbarrado e derrubado bebida nele naquela noite. Já se passava da meia-noite. 
<p>- Como ele está? – Giovanna estava do lado de fora da casa esperando Will chegar para dar notícias.
<p>- Ele está bem. Dormindo. Ficamos a noite toda atrás desse idiota e ele aqui dormindo. – Will bufou.
<p>- Will, eu sinto muito. – Giovanna estava aliviada, porém ainda havia tristeza em sua voz.
<p>- Tudo bem, você só estava preocupada. 
<p>- Que bom que ele tem você.
<p>- Isso não é muito bom, na verdade.
<p>- Para. Você é um bom irmão para ele. 
<p>- Valeu. – Will soltou um sorriso.
<p>- Eu estou morrendo de fome. Eu conheço uma lanchonete que fica aberta a noite toda, está a fim de...
<p>- Não, na verdade, eu preciso correr. Vou tentar salvar a minha noite. 
<p>- Tenho certeza que a Emily vai entender. 
<p>- Como... – Antes de perguntar, ele desistiu. Não tinha tempo para isso. – Tchau, Giovanna.</p>
<center><h4>--*--</h4></center>
<p>- Emily, Emily. – Will bateu devagarzinho no vidro da janela do quarto da namorada. 
<p>- Will? – Emily se levantou da cama, acendeu a luz do quarto e abriu a janela. – O que faz aqui a essa hora?
<p>- Eu vim me desculpar. – Will entrou no quarto.
<p>- Tudo bem.
<p>- Não, eu pisei na bola. 
<p>- Para falar a verdade, eu te liguei algumas vezes. – Ela estava um pouco séria, mas poderia ser porque havia acabado de acordar, pensou Will. 
<p>- Meu celular ficou sem bateria e eu não consegui te ligar.
<p>- Vir para cá como havia falado era uma opção também. 
<p>- Eu sinto muito, é que aconteceu umas coisas e...
<p>- Está tudo bem? – Ela ainda estava desconfiada.
<p>- Agora está.
<p>- Que bom.
<p>- Olha, a gente pode ir comemorar agora. – Will ainda tinha uma chance.
<p>- Já está muito tarde.
<p>- A noite é uma criança, Ems. – Ele tentou puxar um sorriso, mas não conseguiu.
<p>- Hoje não.
<p>- Então amanhã? Prometo deixar as coisas duas vezes melhores.
<p>- Eu vou viajar amanhã e você sabe.
<p>- Mas... – Will não sabia mais o que propor. – Então não vamos poder comemorar seu aniversário juntos.
<p>- Exatamente. – Ela respirou fundo. – Olha, eu vou dormir, a gente se vê amanhã.
<p>- Eu não posso ficar? 
<p>- Hoje não. Meus pais vão acordar cedo amanhã e eu não quero encrenca.
<p>- Você está brava. 
<p>- Não estou brava, só fiquei preocupada porque você não apareceu, mas agora eu sei que está tudo bem. Eu estou com sono, só isso.
<p>- Me desculpa mesmo, eu tinha planejado tudo para hoje. Estou tão triste quanto você. Eu sinto muito, de verdade.
<p>- Tá bom. Eu sei que sente. – Ela deu um sorriso forçado para disfarçar.
<p>- Quando você voltar, eu vou te recompensar, eu prometo.
<p>- Eu já disse que está tudo bem. Agora eu preciso mesmo dormir. Amanhã vai ser uma correria.
<p>- Tudo bem. A gente se vê amanhã na escola e depois eu vou até o aeroporto me despedir direito. Só me manda o horário certo por mensagem porque eu sou péssimo com datas.
<p>- A gente percebe. – Ela riu.
<p>- Engraçadinha. 
<p>Will a beijou e depois passou pela janela novamente. Emily ficou olhando-o passar por seu quintal e virar a rua, depois se deitou na cama, mas não conseguiu dormir.</p>
<center><h4>--*--</h4></center>
<p>- Então como foi ontem? Sei que não somos amiguinhas, mas eu ia perguntar para o Will, mas não vi ele chegando.
<p>Amanda e Emily entraram na sala de aula que ainda estava vazia e se sentaram uma do lado da outra. 
<p>- O Will não apareceu. Quer dizer, apareceu depois de seis horas. 
<p>- O quê? – Amanda ficou surpresa – Por quê? 
<p>- Eu não sei direito. Ele foi bem vago. Disse que aconteceu umas coisas, mas que agora estava tudo bem.
<p>- E vocês vão sair hoje?
<p>- Eu nem vou conseguiu ver todas as aulas hoje. Passei a noite fazendo as malas. 
<p>- Está brava?
<p>- Eu não estou brava. – Mas Emily ficava mais brava toda vez que ouvia essa pergunta.
<p>- Está de brincadeira, não é? Ele te deu um bolo. Se o Jason fizesse isso comigo, eu faria ele sofrer por, no mínimo, um mês. – Amanda levava essas coisas muito à sério.
<p>- Acho melhor eu focar na viagem.
<p>- E como você está se sentindo? Deve estar com muita saudade de lá.
<p>- Muita. Eu não queria ir no começo, mas agora... até ansiedade eu estou sentindo. – Emily riu. 
<p>- Vai ser bom tirar uma folga dessa loucura que é aqui. 
<p>- Olá, garotas. – Giovanna chegou toda sorridente na sala de aula e se sentou ao lado de Emily.
<p>- Chegou o cão em forma de demônio. – Amanda revirou os olhos.
<p>- O que faz aqui, Giovanna? Você nem faz essa matéria mais. – Emily fez cara de nojo.
<p>- Eu vim falar com vocês, na verdade. 
<p>- Eu dispenso. – Amanda falou logo. 
<p>- Eu estou muito sem tempo, principalmente para você.
<p>- Eu vim dizer que eu não guardo mágoas e que se quiserem, podemos ser todas amigas. – Giovanna sorria de orelha a orelha.
<p>- Não queremos. – Emily respondeu sem rodeios. 
<p>- Olha, eu cansei dessas intrigas, tá bom? – Giovanna encarou Emily. – Eu finalmente me reconectei com o Will ontem e eu me senti ótima.
<p>- Você o quê? – Emily preferiu achar que não tinha ouvido direito.
<p>- Giovanna, sai daqui. – Amanda sentiu o cheiro de intriga chegando. 
<p>- Ele não te contou? A gente saiu ontem para beber e conversar.
<p>- Eu duvido. – Emily não cedeu. Amanda ficou calada.
<p>- Relaxa, não fizemos nada demais. Ele não traiu você. – Giovanna riu como se estivesse contando uma piada.
<p>- Ele não saiu com você. E muito menos bebeu ontem à noite. Eu falei com ele e...
<p>- E ele estava cheirando a álcool, não estava? Ele é forte para bebida, sempre foi. Já eu... – Giovanna começou a rir. – Quase caí um monte de vezes no caminho de volta para casa. Eu disse a ele que poderia ir embora sozinha, mas como ele é um cavalheiro e muito fofo insistiu em me levar.
<p>- Que bom. Seria péssimo você acordar no meio da rua hoje. – Emily respondeu.
<p>- Como eu disse, não aconteceu nada demais. Pode ficar despreocupada. – Giovanna encostou no braço de Emily. 
<p>- Eu estou despreocupada, querida. – Emily sorriu. – Só não encosta em mim. Não quero pegar pulgas. 
<p>- É, não dá mesmo para ser amiga de vocês. 
<p>Giovanna fingiu estar chateada, se levantou da mesa e saiu da sala.
<p>- Essa garota é inacreditável. – Amanda balançava a cabeça em negação. 
<p>- Ele estava cheirando a bebida ontem. – Emily pensou alto.
<p>- O quê?
<p>- Eu realmente achei que ele havia ido para o bar beber por causa do que aconteceu com o Sebastian, o Kevin e o Jason e que havia perdido a hora. Eu poderia aceitar isso uma vez. 
<p>- Emily, não. Eu me recuso a acreditar que ele saiu com ela. 
<p>- Então por que ele não me disse por que se atrasou? Ele sempre me diz. 
<p>- Eu não sei, mas o Will, ele nunca...
<p>Antes de Amanda terminar a frase, o professor entrou na sala seguido de outros alunos. A aula começou e as duas ficaram em silêncio durante o tempo todo. Emily decidiu sair mais cedo para arrumar suas malas, que já estavam prontas em cima de sua cama, mas parecia que ela estava fugindo.</p>
<br>
<p>“Sozinho. Você já ficou sozinho? Todos continuaram e você ficou lá parado, de fora, abandonado. O que acontece quando você fica sozinho? Fica com medo? Questiona sua capacidade de conseguir se virar? Você se sente mais fraco? Eu fico exatamente assim quando estou sozinho.”.</p>
<br>
<p>Will tentou ligar para Emily várias vezes naquele dia, mas sem sucesso.
<p>Quando Amanda, mais séria do que o normal, lhe disse que sua namorada havia saído mais cedo para arrumar as malas, ele achou muito estranho. Emily nunca deixaria esse tipo de coisa para última hora. Não era como sua irmã, Quinn, que nem havia ido à escola para preparar suas coisas correndo.
<p>A casa já estava vazia quando ele chegou lá. Seu telefone no ouvido, a voz de Emily dizendo para deixar um recado na caixa postal. 
<p>No aeroporto, um avião havia levantado voo para o Tennessee quarenta e cinco minutos atrás, às duas da tarde. Duas da tarde, ele se lembrou, era esse horário que Emily havia dito uma semana atrás enquanto contava tudo o que pretendia fazer, toda animada, quando chegasse em sua cidade natal. 
<p>- Will!
<p>Jason gritou para o garoto que encarava o telão de embarque já fazia dez minutos.
<p>- Ela já foi. 
<p>- Mas... – Will olhou para Jason sem entender. – Por quê? Ela nem... Ela nem se despediu.
<p>- Eu sinto muito. 
<p>Havia uma mensagem no celular de Will. Ele nem percebeu devido sua vontade insana de ouvir a voz de Emily. 
<p>“Eu tive que ir. Me desculpa.” – Ela digitou.</p>
</body>
</html>";
            }

            if (numero == 40)
            {
                lblTitulo.Text = "Capítulo 40 - E Você Estará Quebrado De Um Jeito Melhor";
                htmlPage.Html = @"<html>
<body>
<p><i>“Amor, se você quer a verdade
<br>Tudo é possível
<br>Você pode andar na lua ou pode vê-la rolar
<br>Nunca está nas estrelas, está no seu coração
<br>É, você vai ser chutado, mas se levante mesmo assim
<br>E você estará quebrado de um jeito melhor”
<br><b>Broken Into Better Shape - Good Old War</b></i></p>
<br>
<p>“Casa. Na teoria, esse é o lugar onde você se sente bem apesar de qualquer coisa. Às vezes, nem é a casa em si, e sim o ambiente, as pessoas que moram lá que fazem você se sentir bem. Na teoria, é claro.
<p>Você já fez algo tão ruim que ficou com vergonha de voltar para casa? Você já se afastou tanto que não sabia mais o caminho de volta? E para qual casa você voltaria? A que você deixou ou a que você quer de verdade?”</p>
<br>
<p>- <i>Última chamada: Voo 143, com destino final para Nashville.</i>
<p>- É a nossa vez.
<p>Harry se levantou da cadeira e pegou suas malas que estavam no chão ao seu lado. Patrícia fez o mesmo assim como Quinn. Emily continuou sentada olhando para o outro lado do aeroporto.
<p>- Ele não vai aparecer se você não avisar, sabe disso. Ele não é muito inteligente. – Quinn foi até a irmã.
<p>- Eu sei. – Emily se levantou e pegou suas malas do chão. 
<p>- Por que não avisou para ele? Ele deveria estar aqui.
<p>- Porque eu não quero falar com ele agora. – Emily estava brava.
<p>- O que foi que aconteceu e por que você está fugindo?
<p>- Eu não estou fugindo. – Emily já tinha repetido aquilo umas trinta vezes em sua cabeça para tentar se convencer. 
<p>- Não é o que parece.
<p>- Vamos, meninas! – Harry gritou para as duas garotas já no portão de embarque.
<p>As duas se entreolharam. Emily olhou uma última vez para trás como se esperasse que Will descobrisse tudo e aparecesse ali.
<p>- Jason?! – Ela se assustou quando viu ele vindo em sua direção. – O que faz aqui?
<p>- Quinn me avisou. – Jason falou.
<p>- Ela avisou, é? – Emily fez cara de reprovação para Quinn, enquanto ela sorria. 
<p>- Que história é essa de ir embora sem se despedir?
<p>- Eu não vou embora. É só por uma semana. – Ela falou.
<p>- Não pode ir embora brigada com ele.
<p>- Eu não estou brigada com ele. – Emily olhou feio para Quinn pela segunda vez.
<p>- Então por que ele não está aqui para se despedir também?
<p>- Jason...
<p>- Isso vai acabar com ele e você sabe. – Jason estava quase suplicando. 
<p>- Eu não quero brigar com ele, não agora. Eu sei como ele está e o que está acontecendo. – Emily respirou fundo. – Mas se eu falar com ele agora, eu vou... Amanda deve ter te contado.
<p>- É mentira.
<p>- Eu tenho certeza que é. Pelo menos, a história dela.
<p>- Então qual é o problema? 
<p>- Eu estou irritada. Ele furou ontem comigo e eu não consegui nem brigar com ele. Ele bateu em você e eu não consegui brigar com ele. Ele abriu um barraco no hospital por causa da Melissa e eu não fiz nada. Eu não quero ficar aqui passando a mão na cabeça dele. 
<p>- Olha, ele precisa de você agora. 
<p>- Não, ele precisa de alguém que diga a verdade para ele. Eu só estou atrapalhando.
<p>- Da última vez que eu disse a verdade... – Jason riu.
<p>- Garotas! – Harry chamou de novo um pouco irritado. – Vamos!
<p>- Temos que ir. – Emily se agitou.  
<p>- Olha, talvez você tenha razão e ele precise organizar as coisas na cabeça sozinho. – Jason pegou na mão dela. – Mas ele não vai ficar bem com isso.
<p>- Eu sei.
<p>- Mas eu te entendo. 
<p>- E eu sei que ele não está sozinho. – Emily sorriu e depois abraçou Jason. – Cuida dele, tá? Eu volto logo. 
<p>- É, ele não está sozinho. – Jason também sorriu. 
<p>- Tchau, Jason. – Quinn também se despediu de Jason com um abraço e sussurrou em seu ouvido. – Vou te mandar nosso endereço por mensagem quando chegarmos lá. Vai que de repente...
<p>- Pode deixar. – Jason piscou para ela. 
<p>Jason ficou observando a família toda entrar no portão de embarque e ao mesmo tempo se perguntava se deixar Emily ir embora daquele jeito era a coisa certa a se fazer pelo amigo.</p> 
<center><h4>--*--</h4></center>
<p>- Olá, pessoal! – Will subiu no palco. – Hoje eu quase fiz a coisa mais rock’n roll do mundo que é bater um violão no chão até quebrá-lo e depois botar fogo nele. – Todos começaram a rir. – Por isso, agora, vamos dar uma desacelerada. Espero que gostem!
<p>A música começou a tocar.
<p>- <i>Ei, você! Então nunca encontrou o seu caminho de verdade? Fique de verdade, se você conseguir passar pelo dia de hoje... Eu sei que quando penso sobre ficar um dia sem isso, todo dia fica igual. Eu gostaria que você pudesse encontrar alguém, mas eu sou o único culpado nisso.</i>
<p>Will respirou fundo. Ele havia mesmo quase quebrado seu violão no chão do seu quarto. Amanda estava em casa quando ele chegou do aeroporto e dividiu com ele sua opinião do que havia acontecido e o que Giovanna havia falado para ela e Emily de manhã.
<p>Naquele momento, ele estava se sentindo um idiota. Giovanna o manipulou e ele caiu direitinho. Emily podia até não ter acreditado nela, mas era verdade. Ele passou a noite toda com outra em uma caçada mentirosa enquanto poderia estar com a sua namorada.
<p>- <i>Você consegue ver? Estou implorando e suplicando. Porque quando os seus olhos iluminarem o céu à noite... Eu sei que você tem que encontrar o caminho de volta para mim...</i></p>
<center><h4>--*--</h4></center>
<p>- Will?
<p>Jason ficou quieto sentado em uma mesa com um copo de soda esperando o bar se esvaziar, para só assim se manifestar enquanto Will ainda estava em cima do palco arrumando os instrumentos, sozinho. 
<p>- Vai embora. – Will nem olhou no rosto dele para falar. 
<p>- Não pode me expulsar do bar.
<p>- Ah, eu posso sim. 
<p>- É verdade que você quase quebrou seu violão?
<p>- Agora não, Jason. – Will fechou os olhos. Estava cansado.
<p>- Olha, Will... – Jason subiu no palco. – As coisas não estão boas e nós dois falamos coisas que não queríamos. Coisas que não foram legais. Eu vim me desculpar.
<p>- Eu não vou te desculpar.
<p>- Por que não? – Jason quase riu.
<p>- Porque eu não estou a fim, tá legal? – Will se virou para o amigo. 
<p>- Will...
<p>Um, depois o outro, se sentou na beirada do palco. Os dois ficaram olhando para a pista que estava lotada de gente horas antes, mas agora estava como abandonada. 
<p>- Você é uma piada, sabia? – Jason riu.
<p>- E você é o pior amigo do mundo. 
<p>- Por que exatamente?
<p>- Eu estou passando por uma barra e preciso do meu amigo, enquanto isso você fica aí choramingando por causa de um soco. Eu estou levando um milhão de socos no estomago o tempo todo e não estou choramingando.
<p>- Ah não? O que você está fazendo agora então?
<p>- Não enche. – Will respirou fundo. – Eu consegui afastar todo mundo, até mesmo quem eu achei que nunca afastaria. 
<p>- Você não me afastou. Eu só estava com raiva assim como você. E quanto a Emily...
<p>- Eu passei a noite toda com a Giovanna porque eu achei que estávamos procurando pelo Kevin, mas no final, foi só uma brincadeira de mal gosto. Giovanna não está nem aí para o Kevin, só quer me punir. 
<p>- Emily não acha que você a traiu. Ela só quis te dar um tempo para você resolver esse complexo de Superman que é até legalzinho às vezes, mas irrita na maior parte do tempo. 
<p>- Eu disse para o Kevin que preferia que ele estivesse no hospital, não o Sebastian. Eu fiz isso com ele. Não é uma coisa que o Superman faria. 
<p>- Você não deu drogas para ele usar, Will. – Jason fez cara feia.
<p>- Ele me odeia, Jason.
<p>- Então segue em frente!
<p>- Ele é meu irmão. Se eu não fazer nada, ele vai ficar pior.
<p>- E como exatamente você está ajudando? Gritando com ele? Seu único dever é contar para os seus pais.
<p>- Se meu pai descobrir sobre as drogas, vai acabar com o Kevin. 
<p>- Ele já sabe, só está ignorando porque não sabe como lidar com isso. Você gritando e brigando com ele o tempo todo não vai ajudar. 
<p>- Está tudo uma droga. E eu vou ficar aqui sozinho para sempre porque ninguém vai suportar ficar do meu lado. 
<p>- Eu estou aqui.
<p>- Cara, você foi o primeiro a ir embora.
<p>- Como eu disse, eu também estava com raiva pelo que aconteceu com o Sebastian, eu tenho esse direito também, não tenho? Você acha que eu sou algum tipo de anjo celestial muito racional que só faz a coisa certa, mas eu também sou uma pessoa e surto às vezes. 
<p>- Mas...
<p>- Somos as piores pessoas do mundo, mas vamos ficar juntos. Foi a nossa promessa, lembra?
<p>- Como não lembrar? Eu até fiz pulseiras da amizade. – Will riu.
<p>- Cala a boca. – Jason riu também. – Eu vou te mandar uma coisa por mensagem de texto.
<p>- O que é?
<p>- O endereço da Emily.
<p>- Jason, ela não quer falar comigo agora.
<p>- É a Emily. Mesmo brava, ela sempre quer falar com você.</p>
<center><h4>--*--</h4></center>
<p>- <i>Não, não! Nunca me deixe para baixo. Porque o tempo não vai voltar quando eu não estiver por perto... Nós vivemos entre tantas paredes que eu mal consigo respirar. Você diz que só quer alguém, mas eu sou o único que você precisa...</i>
<p>Will sentiu seu celular vibrar.
<p>- <i>Você consegue ver? Estou implorando e suplicando. Porque quando os seus olhos iluminarem o céu à noite... Eu sei que você tem que encontrar o caminho... Se sou eu que você não precisa, então quando as luzes se apagarem... Eu sei que você jamais encontrará seu caminho de volta para mim...</i>
<p>Ele nunca ficou tão ansioso para sair do palco antes. Assim que a música acabou, Will foi para trás do palco e pegou o celular. Uma chamada perdida de Emily. 
<p>- Achei que não queria falar comigo. – Ele não conseguiu esperar ela ligar de volta.
<p>- <i>É, eu também achei.</i> – Emily fez uma pausa. – <i>Mas...</i>
<p>- Me desculpa.
<p>- <i>Não, na verdade, eu que tenho que me desculpar.</i>
<p>- Eu sei, mas é que a regra universal é que a culpa é sempre dos homens, então... – Will riu.
<p>- <i>E essa regra está muito certa.</i>
<p>- Amanda me contou o que a Giovanna falou para você e... 
<p>- <i>Eu sei que você não me trocou por ela.</i>
<p>- Mas eu estava com ela. – Will hesitou. – Não porque eu queria. Achei que o Kevin estava em apuros. No final, acabou que não estava e eu meio que fiquei com vergonha de te contar. 
<p>- <i>Will, eu estou preocupada com você.</i>
<p>- Eu sei. Eu também estou preocupado comigo. Mas eu vou ficar bem.
<p>- <i>Eu sei que vai. Na verdade, eu nem liguei para dizer isso.</i>
<p>- Por que me ligou então?
<p>- <i>Queria ouvir sua voz.</i> – Will conseguiu ver nitidamente em sua cabeça Emily sorrindo.
<p>- É, eu também queria ouvir a sua.</p>
<center><h4>--*--</h4></center>
<p>- Olha, eu estou cansada de chegar aqui e você sempre estar com a mesma roupa. – Melissa brincou ao se sentar ao lado de Sebastian. Ela sempre fazia isso quando chegava, era uma maneira de quebrar o clima ruim que aquele quarto trazia. – Sabe, ontem eu estava pensando na vez que ficamos presos no trânsito e fomos até o gramado para ver as estrelas. Se lembra disso? – Ela pegou em uma das mãos geladas de Sebastian. – Talvez tenha sido aí que eu me apaixonei por você. É, foi bem rápido. – Ela riu. – Olha, eu... você me disse algumas coisas naquele dia no seu quarto e uma delas foi sobre relacionamento e... Eu meio que dei para trás. Achei que teria mais tempo para dizer, mas... Isso não é o tipo de coisa que a gente espera para dizer. Temos que simplesmente ir fundo. Eu estou mesmo apaixonada por você. 
<p>O silêncio absoluto só era quebrado pelos barulhos das máquinas do hospital. Ela admirava o rosto de Sebastian, parecia que ele só estava dormindo e sonhando com algo bom, ela conseguiu até ver seus lábios formarem um pequeno sorriso. Por um segundo, achou que fosse alucinação. 
<p>- Eu... sa... sabia... – Melissa então sentiu a mão de Sebastian se mexer.
<p>- Ai, meu Deus. – Ela quase deu um pulo da cadeira. – Ai, meu Deus.
<p>- Ca-calma. – Sebastian ainda estava com a voz fraca e com os olhos entreabertos. – Eu só apaguei por umas horas. 
<p>- Seb... não. Eu preciso chamar o médico. – Mas Melissa continuou parada.
<p>- Espera. – Sebastian apertou a mão de Melissa com toda a força que conseguiu. – Só quero aproveitar mais esse momento.
<p>- Que momento?
<p>- É claro que não era só curtição. – Ele conseguiu dar um meio sorriso. – Eu também estou apaixonado por você.</p> 
<center><h4>--*--</h4></center>
<p>Karen foi a primeira a abraçar e apertar Sebastian quando a família chegou no hospital. Ela não esperou o filho explicar o que tinha acontecido e nem queria saber também. Tudo o que importava era que ele havia acordado e estava bem, e ela repetia isso o tempo todo. 
<p>Não demorou muito até Karen e Robert saírem do quarto para falarem com o médico em particular em busca de mais informações da situação de Sebastian depois dos exames que foram feitos logo depois de ele acordar. 
<p>Chris e Amanda estavam sentados em umas cadeiras perto da janela. Will estava em pé perto da porta um pouco em choque enquanto Jason sentava em uma poltrona ao lado da cama.
<p>- Cadê o Kevin e o Matt? – Sebastian perguntou.
<p>- Mamãe não quis buscar o Matt na escola, mas vai vir aqui à noite. – Chris explicou. – Já o Kevin...
<p>- Não conseguimos encontrar ele. – Amanda falou logo. 
<p>- O que aconteceu, Sebastian? – Will estava querendo perguntar aquilo desde que tinha chegado, mas não sabia qual era o momento.
<p>- Eu não... – Sebastian franziu a testa. – Eu não me lembro. 
<p>- Seb, você não levou um tiro na cabeça para perder a memória.
<p>- Will. – Jason olhou feio para o amigo. 
<p>- Eu tenho certeza que todo mundo quer saber o que aconteceu.
<p>- Melhor não falarmos disso agora. – Amanda voltou a falar. – Conforme você for melhorando, as coisas vão ficar mais claras. 
<p>- Acho melhor a gente sair para ele descansar um pouco. – Chris se levantou.
<p>- Cadê as garotas? Emily, Quinn... Melissa. – Sebastian perguntou. 
<p>- Elas foram para Nashville. Vão ficar um tempinho lá. – Will respondeu em seco. – Já a Melissa, eu...
<p>- Ela estava aqui quando eu acordei. – Sebastian sorriu. 
<p>- Está apaixonado por ela, não está? – Amanda perguntou e até sorriu também.
<p>- Estou e ela também está por mim. E foi bom acordar com ela do meu lado.
<p>- É sempre bom acordar com alguém que você ama do lado. – Will também sorriu.</p> 
<center><h4>--*--</h4></center>
<p>Foi um dia longo para Will. Quando ele chegou em casa, já à noite, tudo o que ele queria era cair na cama e dormir.
<p>- O que está fazendo? – Seus planos foram interrompidos por Chris. Quando entrou no quarto, seu irmão estava colocando um monte de roupas dele em uma mala.
<p>- Vamos para o Tennessee. 
<p>- Como é que é? – Will arregalou os olhos. 
<p>- Olha, você está ganhando uma nota fazendo shows, eu sei que tem dinheiro para comprar pelo menos duas passagens na classe econômica. Minhas malas já estão prontas no meu quarto. 
<p>- Olha, eu sei que você está interessado na Quinn e já deve estar com saudades dela. – Chris demonstrou surpresa. – Mas a Emily precisa de um tempo e talvez eu também precise.
<p>- Ela quer que você coloque a cabeça no lugar e seja o Will de novo.
<p>- Exatamente e para isso, eu preciso...
<p>- Você tem razão, precisa mesmo de um tempo, mas não da Emily, precisa de um tempo longe de tudo isso. Você precisa ir. 
<p>- Nossos pais...
<p>- Eles vão deixar. Eu sou o responsável, lembra? E antes que diga outra coisa, você vai, mesmo que eu tenha que te arrastar. – Chris estava sério.
<p>- Por que está fazendo isso?
<p>- Porque você é meu irmão e já chega de você cuidando de todo mundo. Alguém precisa cuidar de você. 
<p>- Você é louco. – Will começou a rir.
<p>- Você também deveria ser. Agora arruma sua mala.
<p>- Parece que você já arrumou para mim. 
<p>- Tudo bem, agora me dá seu cartão. Vou comprar as passagens. – Chris estendeu a mão aberta.</p>
<center><h4>--*--</h4></center>
<p>Chris havia convencido Will a comprar as passagens e os dois iriam subir em um avião em duas horas.
<p>Will saiu de casa bem apressando após prometer para Chris que não iria fugir e que chegaria a tempo. Ele precisava fazer algo que não podia esperar até depois da viagem.
<p>- O que está fazendo aqui? – Melissa ficou sem reação quando viu Will parado na frente de sua porta.
<p>- Eu vim...
<p>- Eu estava lá quando o Sebastian acordou, então eu sei que...
<p>- Não vim falar sobre isso. Vim me desculpar.
<p>- Ele te contou, não foi?
<p>- Ele não me contou nada. – Will falou. – Na verdade, não precisou que ele me contasse. Eu conheço você, sei que...
<p>- Will... 
<p>- Eu nunca deveria ter falado aquelas coisas. 
<p>- Não deveria. – Melissa continuava séria. 
<p>- Eu sinto muito mesmo. Eu tenho essa coisa na minha cabeça que... Eu não penso direito quando acontece essas coisas. 
<p>- É, deu para notar. 
<p>- Eu estraguei tudo, eu sei. Não só com você, mas...
<p>- É, eu soube do soco que você deu no Jason.
<p>- Não foi o meu melhor momento. – A vergonha estava estampada no rosto de Will.
<p>- Will... – Melissa respirou fundo e cruzou os braços.
<p>- Você ainda está com raiva e eu entendo isso, e não espero que você me perdoe de uma hora para outra. O que eu fiz...
<p>- Eu não quero ficar com raiva de você.
<p>- Eu também não quero isso. Somos amigos e... eu me importo muito com os meus amigos. 
<p>Will ficou esperando Melissa dizer algo, talvez algo enfurecido ou um simples “tudo bem”, mas ao invés disso, ela o abraçou e bem forte. 
<p>- Eu também fiquei assustada. Muito assustada. 
<p>- Eu realmente sinto muito. – Will respirou aliviado. – Eu sinto muito mesmo.</p> 
<center><h4>--*--</h4></center>
<p>Eram dez da manhã e o sol já estava muito quente quando Will e Chris desembarcaram em Nashville. Chris colocou no GPS o endereço que Jason havia mandado e ainda teriam uns vinte minutos de viagem se conseguissem um táxi.
<p>Will tinha outros planos. 
<p>Ele colocou todas as malas no porta-malas do táxi e então pediu para o irmão ir sozinho para a fazenda. Chris achou que era uma loucura no começo, mas Will o convenceu. 
<p>Emily falava daquela viagem fazia dias e toda hora. Mesmo não estando ao lado dela, ele sabia exatamente onde ela estaria naquele momento e não era na sua casa. 
<p>O único taxi disponível levou Chris, então Will resolveu pegar um ônibus que deu mais voltas pela cidade do que ele gostaria. Antes de chegar no seu destino, o ônibus passou por várias estradas de terra e plantações. Por um lado, aquele tempo extra foi bom para Will, ele tentou ajeitar seus pensamentos e fez várias simulações imaginárias do que aconteceria quando ele se encontrasse com Emily, mas nenhuma daquelas simulações aconteceu de verdade.
<p><i>The Fairgrounds Nashville</i> era uma área muito grande e se tornou o lar da Feira Estadual do Tennessee que acontecia todo ano no começo do mês de outubro. Aquele lugar, com certeza, abrigava mais de cem mil pessoas naquele momento. Havia brinquedos como carrossel, roda-gigante, barraquinhas de prêmios e as pessoas pareciam bem contentes. 
<p>Havia música, talvez até ao vivo, Will não conseguiu identificar, era muita gente por metro quadrado para ele conseguir achar uma banda ou simplesmente ouvir direito o que eles cantavam. Ele teve um pouco de dificuldade para achar a área certa, mas encontrou, Emily foi a primeira pessoa que ele conseguiu ver.
<p>- Will! – Quinn o gritou do outro lado, e quando ele se virou, viu ela correndo ao seu encontro. – Demorou, hein.
<p>- Até demais. 
<p>- Toma. – Ela tirou seu avental amarelo com estampas de frutas e seu boné também amarelo e entregou para Will. – Vê se não estraga tudo de novo. Estou cansada de ouvir vocês choramingarem. 
<p>- Obrigado. – Will sorriu enquanto colocava os acessórios rapidamente e se despedia de Quinn.
<p>Emily estava tão concentrada colocando frutas em uma sacola para uma mulher de idade do outro lado do balcão que nem percebeu Will entrando na barraca.
<p>- Quinn, você trouxe o... – Emily se virou para olhar a irmã, mas...
<p>- Não, eu acho que ela não trouxe. – Will sorriu.
<p>- O que você está fazendo aqui? – Ela não sabia se sorria, se franzia a testa ou se abria a boca de surpresa.
<p>- O que acha que eu estou fazendo aqui? É uma feira. E eu sou ótimo para vender laranjas. – Will apontou para as frutas que estavam em cima do balcão. – Ah, vim atrás da garota que eu amo também. Agora vamos lá! – Ele bateu uma mão na outra para pegar o ritmo. – Quem quer laranjas? Laranjas bem doces! Eu não sei o valor da dúzia, mas a gente pode negociar!
<p>- O que você está fazendo? – Emily observava Will andando pela barraca de um lado para o outro gritando.
<p>- O que acha que eu estou fazendo? – Ele sorriu enquanto descascava uma laranja e colocava um pedaço dela inteiro na boca.
<p>- Você é louco. – Ela retribuiu o sorriso.
<p>- É, eu sou sim. – Ele havia viajado dezoito horas por aquele sorriso.</p>
</body>
</html>";
            }

            if (numero == 41)
            {
                lblTitulo.Text = "Capítulo 41 - Meu Lugar é Com Você";
                htmlPage.Html = @"<html>
<body>
<p><i>“Desde o momento em que eu acordo
<br>Durante os dias que eu enfrento
<br>Até o sono que eu finjo
<br>Meu lugar é com você
<br>Até que as estrelas comecem a cair
<br>Até que o vento pare de chamar
<br>Até que isso não importe mais
<br>Meu lugar é com você”
<br><b>I Belong - Tyler Hilton</b></i></p>
<br>
<p>- Eu não acredito que você realmente está aqui. – Quinn estava esperando Chris em frente à entrada da fazenda. Ela mesma não acreditou quando viu ele parado no meio da estrada de terra com as malas todas no chão olhando para os lados um pouco perdido. – Quando eu dei o endereço para o Jason, eu pensei que...
<p>- Pensou que ele que viria com o Will, não é? Bom, surpresa. – Chris riu.
<p>- Eu encontrei o Will na feira, então... imaginei que o fiel escudeiro dele estaria vindo para cá. 
<p>- Feira? Então foi para lá que ele foi. 
<p>- É, a gente estava lá. Vendíamos frutas todo ano com os nossos tios, era... – Quinn fez careta. – Eu nunca gostei. 
<p>- Queria ter visto você vendendo maçãs.
<p>- Não queria, não. Por que veio com ele?
<p>- Bom, agora que está tudo melhor em casa, por que não umas férias? Eu estudei muito para ter o privilégio de poder faltar uns dias. – Chris sorriu. 
<p>- Férias? Interessante. Como está o Sebastian?
<p>- Ele acordou. – Quinn arregalou os olhos. – Agora vai passar pelas terapias de novo como sempre. Ele vai ficar bem. 
<p>- Isso é bom, isso é muito bom. 
<p>- É, agora você pode parar de se sentir culpada
<p>- Culpada? Por que eu me sentiria culpada?
<p>- Por gostar de mim. 
<p>- Eu não gosto de você.
<p>- Se é o que acha. Eu posso entrar ou vou ficar o dia todo na rua com essas malas? – Chris encarou Quinn.
<p>- Claro que pode entrar. Vou pedir para alguém vir te ajudar com as malas.
<p>- Obrigado.</p> 
<center><h4>--*--</h4></center>
<p>A feira não era o melhor lugar para se ter uma conversa. 
<p>Will e Emily foram interrompidos tantas vezes por clientes e pelos tios da garota e precisavam falar tão alto por causa do barulho que desistiram e resolveram conversar uma outra hora. 
<p>Na volta para fazenda, dentro do caminhão, a tia de Emily, Nancy, não parava de fazer perguntas para Will sobre a Califórnia e ele respondia com entusiasmo. A última coisa que ele queria era passar uma má primeira impressão para aquelas pessoas. 
<p>Conhecer os familiares de Emily não foi tão estranho quanto Will pensou que seria. Quando ele chegou na casa, Chris já estava sentado na grande mesa na sala de jantar sendo tratado como se fosse da família. Era estranho, ele realmente achava que veria milhares de Harrys em uma sala cheia e que ele ficaria o tempo todo pisando em ovos para não dizer nem fazer algo que pareceria errado nos olhares deles, mas era diferente. Eram todos sorridentes e bons anfitriões.  Era o ar diferente do Sul, ele pensou.
<p>Quando Will entrou pela porta da cozinha junto com Emily, era como se todos já estivessem o esperando por horas. A vó dela, Helena, os abordou com uma tigela cheia de pedaços de bolo de laranja, o cheiro bom estava por todo o cômodo. A casa era enorme, mas tinha mesmo que ser para abrigar toda aquela gente. Havia pelo menos uns cinco casais espalhados pela casa, sentados na mesa ou no sofá ou até mesmo em pé encostados em alguma parede. Havia também algumas crianças correndo de um lado pelo outro e pelas escadas e alguns adolescentes também em frente à televisão, com certeza eram primos. 
<p>Will se sentou em silêncio em sua cama no quarto de hóspedes. Olhou para a janela em frente e ficou observando o sol se pôr. Tinha sido um longo dia, suas malas ainda estavam no chão intocadas. 
<p>- O pessoal daqui é legal, não é? – Chris estava do outro lado do quarto colocando suas roupas em uma parte do guarda-roupa. – Não acredito que até conseguimos um quarto de hóspedes.
<p>- É, eles são sim. Será que foi daqui mesmo que o Harry veio? – Will riu em pensar na situação. Harry foi o único que não deu boas-vindas todo sorridente para Will, na verdade, nem expressão no rosto ele tinha.
<p>- Se ajeitou com a Emily?
<p>- Acho que sim. Não estávamos brigados, mas... Não conseguimos conversar direito. Muita gente. 
<p>- Então é por isso que ainda está tão preocupado? – Chris se aproximou do irmão.
<p>- Na verdade, eu só estou pensando em como as coisas estão em casa. – Will respirou fundo.
<p>- Will, você veio aqui para se desligar de casa, se lembra?
<p>- Eu vim aqui para arrumar as coisas com a Emily. 
<p>- E tirar umas férias.
<p>- Eu não concordei com férias. 
<p>- Quer dizer que já quer ir embora?
<p>- Não, é que... O ar daqui é tão puro. Olha só esse céu. – Will apontou para a janela. 
<p>- A gente mora na praia. O ar também é puro. 
<p>- Não está tão puro ultimamente, pelo menos não em casa. Eu estou muito preocupado, mas eu não quero voltar. Quero ficar leve de novo primeiro. 
<p>- Você tem dezoito anos. Nós dois somos jovens, deveríamos ser leves. Me dá seu celular. – Chris estendeu a mão aberta para Will.
<p>- Para quê? Você tem o seu. 
<p>- Me dá logo. – Chris insistiu. 
<p>- Toma. – Will tirou o celular do bolso da calça e deu para ele.
<p>- Agora vamos desligar... – Chris desligou o celular de Will e depois fez o mesmo com o dele e os guardou na mala. – Agora só vamos ligá-los quando estivermos indo embora.
<p>- O quê? Por quê? – A ideia de não ter um celular por perto era considerada loucura para Will. – Olha, vai lá pegar a Quinn ou sei lá quem, mas me devolva o celular.
<p>- Will!
<p>- Isso é ridículo. 
<p>- Não, é a coisa certa a se fazer. O Sebastian está bem, o Jason e a Amanda também, a Giovanna não vai te atingir aqui e quanto ao Kevin, acho que está na hora dos nossos pais cuidarem dele. 
<p>- Mas... – Will tentou reclamar porque era de sua natureza, mas não queria mesmo lutar. – Tudo bem. Você venceu.
<p>- Eu amo vencer. – Chris sorriu.</p> 
<center><h4>--*--</h4></center>
<p>O único problema naquele lugar era que todo mundo dormia muito cedo. Não eram nem nove e meia da noite quando a última pessoa se levantou do sofá para se preparar para dormir. Will foi até a cozinha e tomou um copo de água da torneira. 
<p>- Eu ainda não estou acreditando nisso, sabia? – Emily estava parada em frente a porta da cozinha. 
<p>- É por isso que eu ainda não ganhei nem um beijo? – Will sorriu encostado na pia. – Ainda está digerindo?
<p>- Por isso e outras coisas. Você não deveria estar aqui.
<p>- É claro que eu deveria. Você até sorriu quando me viu lá na feira.
<p>- Foi um sorriso falso.
<p>- Emily...
<p>- Tínhamos concordado que precisávamos de um tempo. 
<p>- É, e que sentíamos saudade um do outro.
<p>- Nem tanto assim. – Emily mostrou um leve sorriso.
<p>- É seu aniversário. Eu quero estar aqui com você.
<p>- Você ainda é um imbecil ridículo? 
<p>- Acho que eu sempre vou ser, sinto muito te decepcionar. – Will brincou. – Eu me desculpei com a Melissa. Depois que o Sebastian acordou, eu percebi...
<p>- Espera um pouco, o Sebastian acordou? – Emily ficou chocada. – E como você só me fala isso agora?!
<p>- Me desculpa. É, ele acordou, não disse o que eu queria, mas...
<p>- Ele está bem?
<p>- Vai ficar, mas eu percebi que... ele está apaixonado pela Melissa de verdade e ela também está apaixonada por ele e aí eu me dei conta.
<p>- Se deu conta de quê?
<p>- De que não tinha como um fazer mal para o outro. Não é isso que o amor significa e é por isso que eu estou aqui. Eu estou melhor, não soquei ninguém no avião, eu juro.
<p>- Will, eu adoro você se importar com as pessoas e querer salvar todo mundo, mas não dá para salvar todo mundo, não importa o quanto queira.
<p>- Eu sei disso.
<p>- Mas vai continuar tentando mesmo assim, não é?
<p>- Me desculpa, mas não dá para dizer para o Clark Kent não ser o Superman. 
<p>- É, não dá. Mas nessa lógica, isso faz de mim...
<p>- A Lois Lane. A minha Lois. A melhor parceira que um herói poderia pedir. – Will se aproximou de Emily. – E a Lois Lane também tem problemas.
<p>- O quê?
<p>- Primeiro você vem de um lugar que não tem asfalto.
<p>- Cala a boca. – Os dois começaram a rir. 
<p>- Você não pediu para eu vir, mas... eu vim mesmo assim. E eu não quero ir embora.
<p>- Eu também não quero que vá embora. 
<p>- Ótimo, porque eu não vesti a minha capa e vim voando até aqui para não ficar com você nos meus braços. 
<p>Will passou suas mãos pela cintura de Emily e a puxou para mais perto dele. 
<p>- Bom, já que você vestiu a capa... – Emily o beijou.
<p>- Eu deveria ter mencionado a capa antes. – Will sorriu. – Aqui não tem nenhum celeiro por perto ou muito longe, não importa, para gente... poder... fazer as pazes direito?
<p>- Bom, eu conheço um lugar.</p>
<center><h4>--*--</h4></center>
<p>Quinn já estava de pijama quando Chris bateu na porta de seu quarto. Ela se levantou da cama assustada.
<p>- O que você quer? – Ela tentou pentear o cabelo quando o viu.
<p>- Estou sem sono e o Will não está no quarto. A gente pode conversar?
<p>- Está tarde.
<p>- Não tanto assim. – Chris insistiu.
<p>- Tudo bem.
<p>Chris se sentou na beirada da cama ao lado da garota. Ele parecia um pouco nervoso e trêmulo.
<p>- Está tudo bem? – Quinn perguntou.
<p>- Ah, eu vim mesmo aqui porque queria te ver. Eu até falei para Jason para eu vir no lugar dele... eu queria ajudar o Will, sim, mas ver você também... eu queria muito.
<p>- Chris...
<p>- Sei lá, eu... eu estou imaginando coisas? Não estou, não é? Está acontecendo de verdade, não está? Quer dizer, você é muito linda e com certeza, areia demais para o meu caminhãozinho, mas... sempre que a gente está junto, acontece uma coisa que... sei lá...
<p>- Eu realmente... – Quinn demostrou um pouco de desconforto com aquele papo. – Esse é o seu discurso para me conquistar?
<p>- Não, eu só... – Chris não sabia o que dizer. O discurso que ele ensaiou no quarto por vinte minutos tinha sumido da sua cabeça. – Acho melhor eu ir embora.
<p>- Chris, você é muito ingênuo. – Quinn começou a rir. – Eu estou esperando que você me beije desde a hora que chegou. Eu até mandei uma mensagem para o Jason agradecendo por ele não vir. 
<p>- O quê? – Chris não sabia como reagir. – Mas não é estranho? Você era a namorada do meu irmão, não me parece certo.
<p>- A gente terminou e ele já está com outra.
<p>- Mas...
<p>- Mas nada, me beija. 
<p>- É errado. Eu comecei a ficar atraído por você enquanto ainda namoravam. Eu tentei ao máximo esconder isso e...
<p>- Me beija logo. 
<p>- E se ele não gostar? Não quero outro clima tenso que nem Will-Giovanna-Kevin. 
<p>- Chris, cala essa boca e me beija.
<p>- Mas...
<p>- Mas que droga! Você pensa demais. – Quinn empurrou Chris e ele se deitou na cama. – Eu disse para você me beijar. – E depois subiu em cima dele. – Será que o Will é o único atirado dos irmãos Jones?
<p>- Parece que sim. – Chris ficou mais nervoso do que estava antes.
<p>- É, quem diria que a minha irmã que é a sortuda? Será que eu vou ter que pedir de novo para você calar a boca?
<p>- Não.
<p>- Ótimo.
<p>Quinn beijou Chris.</p> 
<center><h4>--*--</h4></center>
<p>Will e Emily dormiram mais do que deviam e acordaram com o sol já nascendo e com os passarinhos cantando do lado de fora do celeiro. Mesmo atrasados, eles demoraram para se levantar do feno. Resolveram aproveitar aqueles últimos minutos sozinhos.
<p>Quando chegaram na casa, o lugar tinha gente andando para lá e para cá com xicaras de café em uma mão e uma fatia de pão no outro. Passaram despercebidos por todos, até mesmo por Harry e Patrícia. 
<p>Quinn estava diferente quando desceu para tomar café naquela manhã. Chris desceu as escadas logo depois dela e sorria de orelha a orelha.
<p>- Os dois transaram. – Will cochichou na orelha de Emily enquanto se serviam de café.
<p>- O quê? – Emily perguntou.
<p>- Olha só para o Chris. Ele não para de sorrir e... está mordendo os beiços olhando para a Quinn. Isso é típico dele depois de ter uma noite na ativa.
<p>- Está imaginando coisas.
<p>- A gente teve sorte de não ter dormido aqui dentro, porque ou eles fizeram no seu quarto ou no meu. 
<p>- Para. – Emily quase riu.
<p>- Parece que a noite deles foi quase tão boa quanto a nossa.
<p>- Por que “quase”?
<p>- Porque eu sou melhor... do que qualquer um na verdade. – Will estufou o peito. 
<p>- Engole esse café. – Emily beliscou seu braço. 
<p>Antes que Will falasse qualquer outra coisa sobre a noite do irmão, um garoto se aproximou dos dois. De primeira, Will achou que ele era um dos primos de Emily, eles eram muitos e ele ainda não havia gravado o rosto de todo mundo.
<p>- Emily, oi. – O garoto colocou a mão no ombro de Emily para chamar a sua atenção. 
<p>- Derek, oi. – Emily levou um susto, mas se tranquilizou depois que viu de quem se tratava. – Eu não sabia que estava por aqui. A vovó falou que tinha viajado.
<p>- É, eu estou tentando a sorte no Texas agora, mas quando eu fiquei sabendo que você estava por aqui, eu... eu tive que vim te ver. Quanto tempo, hein. – Ele abriu os braços e abraçou Emily.
<p>- É, faz um tempo mesmo. Como você está? – Ela ficou animada. 
<p>- Eu estou bem. Nem vou perguntar como você está porque já estou vendo. Está ótima.
<p>- Obrigada. – Emily sorriu. 
<p>- E eu sou o Will. – Will colocou sua mão na frente de Derek. Endireitou a coluna e estufou o peito novamente. – Sou o namorado dela. 
<p>- Ah... – Derek ficou sem graça. – Prazer. Sou Derek, e eu não sou namorado dela. 
<p>- Sorte a minha. – Will mostrou um meio sorriso bem falso. 
<p>- Você não é daqui, não é?
<p>- Não, eu sou da Califórnia. – Will falou como se essa informação o deixava mais superior a Derek do que já era. Ele era alto, forte, bonito, tinha um ótimo cabelo e olhos claros. Como Derek, o oposto daquilo tudo, poderia competir com ele? Foi seu primeiro pensamento, porém não desfez a pose. 
<p>- Imaginei. Então, Emily, vai ficar aqui até quando?
<p>- Até o final da semana. E você? – Emily ignorou o comportamento do namorado e tentou agir normalmente. 
<p>- Também. 
<p>- Você pode aparecer aqui amanhã na minha festa então.
<p>- Nada me deixaria mais feliz. – Derek sorriu. 
<p>- Achei que a festa era só para família. – Will fingiu estar em dúvida enquanto Emily olhava feio para ele.
<p>- Eu sou quase da família. 
<p>- É. – Will voltou a dar um sorriso falso.
<p>- Bom, eu vou deixar vocês tomarem café em paz. A gente se vê amanhã, Emily.
<p>- Tá legal. – Emily se despediu.
<p>- Foi muito bom te ver.
<p>- Igualmente.
<p>- Tchau, Will.
<p>Mas Will nem se deu o trabalho de responder. 
<p>- Você só me faz passar vergonha. – Emily colocou a mão no rosto assim que Derek se afastou. – Precisava agir daquele jeito?
<p>- Ele estava dando em cima de você na minha frente. – Will fez uma careta.
<p>- Ele é um amigo de infância. Os pais dele são muito amigos do meu pai, é só isso. 
<p>- Ele estava te despindo com os olhos.
<p>- Que exagero. – Emily começou a rir.
<p>- Você está adorando isso, não é?
<p>- Você está com ciúmes. E se eu parar para pensar, eu nunca te vi desse jeito.
<p>- É porque eu nunca precisei. Quando você chegou em Los Angeles, eu fiz questão de marcar meu território ao redor de você. 
<p>- Ah, então foi isso que você fez?
<p>- Exatamente isso. E se eu precisar fazer isso aqui, eu vou fazer, porque nenhum caipira de um metro e meio vai vir aqui e cantar a minha namorada na minha frente. 
<p>- Você é ridículo. – Ela gargalhou alto. – Primeiro, você não precisa disso e, segundo, ninguém vai marcar território em mim. 
<p>- Tudo bem. Não está mais aqui quem disse. Além do mais, já foi satisfatório ver a cara de decepção dele quando descobriu que eu sou seu namorado. Ele vai precisar nascer de novo se quiser tentar competir comigo. – Will riu.
<p>- Por que você ainda não engoliu esse café?</p>
<center><h4>--*--</h4></center>
<p>- Onde você passou a noite? 
<p>- Como sabe que eu não passei a noite no quarto já que você também não passou? – Will olhou para o irmão demostrando que já sabia o que havia acontecido na noite passada.
<p>Os dois estavam caminhando pelos arredores da fazenda para conhecer melhor a área. Estava um calor de quase quarenta graus.
<p>- Você não sabe de nada.
<p>- Ah, eu sei sim. – Will insistiu. 
<p>- Vamos dizer que, hipoteticamente, você saiba de algo. Acha que eu fiz algo errado? – Chris tentou ao máximo não demostrar vergonha.
<p>- Depende, durou mais que cinco minutos? – Will começou a gargalhar.
<p>- Cala essa boca. Eu estou falando sério. 
<p>- Tudo bem. Na verdade, eu ia dizer que você mandou muito bem. 
<p>- Acha que o Sebastian...
<p>- Não, ele não vai se importar. É o Sebastian. Mas mesmo assim você parece preocupado.
<p>- Eu queria conversar com você sobre isso.
<p>- Sobre namorar a Quinn?
<p>- Não, sobre... – Chris não conseguiu falar a palavra.
<p>- Não acha melhor ter essa conversa com o nosso pai? Quer dizer, ele não chegou a falar comigo, mas o segundo filho sempre é melhor. – Will brincou.
<p>- Não, ele... – Chris ficou um pouco vermelho. – Eu não tenho muita experiência. Eu só fiz com a Ashley e... com a Quinn foi diferente.
<p>- Eu sei que fisicamente toda mulher tem as mesmas coisas, mas... sempre vai ser diferente. 
<p>- Foi diferente para você? Todas as vezes?
<p>- Foi e não. Na maioria das vezes, eu só quis... preencher um espaço que nunca foi preenchido. A minha primeira vez foi complicada, acho que de todo mundo é. Somos jovens, ainda temos muito o que aprender. 
<p>- Eu sei e não é que era ruim, mas eu tinha muitas inseguranças com a Ashley. Como fazer, onde fazer, quanto tempo duraria. Às vezes eu ficava mais preocupado em fazer direito e nem aproveitava o momento, mas com a Quinn foi...
<p>- Na real, a gente, quando digo “a gente”, eu quero dizer, nós homens, gostamos de dizer que sexo é só sexo, mas... também nos importamos, também significa algo para gente. Quando aconteceu com a Emily, eu... até aquele momento, eu nunca tinha feito com alguém que eu amasse de verdade. E com ela foi... eu só queria ficar lá com ela o resto da vida.
<p>- Acho que foi isso que eu senti também.</p>
<center><h4>--*--</h4></center>
<p>Na varanda da casa, havia uma rede amarrada em duas vigas de concreto ao lado de um balanço muito parecido com o que havia na varanda da casa de Emily em Los Angeles. Quando Will passou por lá pela primeira vez, já se imaginou deitado lá o dia todo, mas a oportunidade não chegou até aquela noite quente.
<p>- O que está fazendo aqui sozinho? – Emily saiu da casa e se deparou com Will deitado na rede com seus pensamentos longe.
<p>- Eu poderia ter trazido meu violão. Poderia escrever várias músicas aqui. Ou só dormir com o violão na mão. – Will riu. – Eu sempre quis uma rede em casa. Estou realizando meu sonho de criança.
<p>- Bobo. Posso me juntar a você?
<p>- Achei que nunca fosse pedir. – Will abriu espaço e Emily se deitou ao lado ele. – Dei uma volta pelas redondezas hoje com o Chris. Esse lugar é muito bonito.
<p>- É sim. As montanhas, os lagos...
<p>- A gente podia ficar aqui, sabia? Envelhecer juntos. Deitar na rede enquanto nossos netos quebram a casa toda. – Will colocou seu braço ao redor de Emily. 
<p>- Will, eu te conheço. Você não aguenta ficar aqui. 
<p>- É, esse silêncio irrita para cassete. – Os dois começaram a rir. – Mas é bom, me acalma. É o silêncio ou é você.
<p>- Provavelmente sou eu. 
<p>Os dois ficaram em silêncio por alguns minutos ouvindo o barulho de grilos e corujas, até que aquilo foi quebrado por uma melodia de violão vindo do outro lado da casa.
<p>- O que estão fazendo? – Will franziu a testa.
<p>- Meus tios insistiram em cantar música ao vivo amanhã na minha festa. Devem estar ensaiando. 
<p>- Sua família é legal. Ninguém se parece com o Harry. Se bem que até ele está legal aqui. Não me xingou nenhuma vez.
<p>- Isso é uma vitória. – Emily riu.
<p>- Ou ele já desistiu e percebeu que eu não vou a lugar nenhum.
<p>- Não vai?
<p>- Não vou. Enquanto eu estava lá em LA e você aqui, eu percebi uma coisa. Não existe Will sem Emily. A gente que equilibra o Universo.
<p>- Nossa, temos uma grande responsabilidade, hein?
<p>- É, temos. 
<p>Will se levantou e saiu da rede sem aviso nenhum.
<p>- Para onde você vai? – Emily ficou surpresa.
<p>- Vem. Essa música que estão tocando... merece uma dança.
<p>- Eu não vou dançar na minha varanda e você não conhece essa música.
<p>- Emily, você vai dançar na sua varanda e eu conheço essa música. – Ele estendeu a mão para ela sorrindo. 
<p>- Você é louco. 
<p>Emily se rendeu. Se levantou e se deixou ser conduzida pela varanda enquanto ouviam aquela melodia. 
<p>- <i>As pessoas dizem que é bom me conhecer, muitas vezes me pergunto o porquê. Eu estudei minhas reflexões... Eu me olhei nos olhos...</i>
<p>- Não é essa a música que eles estão tocando. – Emily levantou a sobrancelha. 
<p>- Essa letra fica boa com qualquer melodia. – Ele continuou. - <i>Mas ainda não consigo tirar conclusões. Eu ainda estou falando fora de hora... Agora, eu faço muitas perguntas a respeito das lições que não aprenderei...</i>
<p>Will olhou nos olhos de Emily.
<p>- <i>Acontece que todos os meus erros eram perdoáveis e o tempo que passei perdido foi o sinal... Que toda a tinta fica invisível...</i>
<p>- <i>Se você der... Der tempo suficiente.</i> – Ela completou.
<p>- Eu te amo.
<p>- Eu também te amo.</p>
<br>
<p>“Amor. Como isso funciona? Você de repente acorda um dia e está apaixonado por alguém? Bom, em quase todas as vezes, não é tão fácil assim. É difícil dizer exatamente o momento que o amor aparece. 
<p>Quantas vezes você acordou no meio da noite e sentiu aquela vontade de pegar o telefone e ligar para ouvir aquela voz? Aquela voz que te acalma, que te conforta, que te deixa feliz.
<p>Você acorda de bom humor só de pensar nela. Não é porque você sonhou nem nada disso, é só porque você a ama e sabe que daqui a alguns minutos vocês vão se encontrar e vão se sentir completos. Então vocês se encontram. Aí escutam aqueles sinos dentro de suas cabeças, veem aquelas luzes que iluminam só vocês, como se estivessem sob holofotes. Aquela vontade de nunca mais se largarem. O coração batendo forte, a sensação de adrenalina, aquele nervosismo, aquele olhar que deixa tudo perfeito. Aquele momento que você vai guardar para sempre.
<p>O amor de verdade não acaba, nem se enfraquece. Ele fica lá com você desde a hora que você acorda até o momento que você vai dormir. E às vezes, você tem sorte de ser correspondido e também ser amado pela pessoa que é a mais perfeita para você.
<p>Eu me sinto assim com a Emily. Toda manhã, é nela que eu penso, e eu sei que ela também pensa em mim. A cada mensagem de bom dia, a cada beijo, a cada “eu te amo”, o amor só aumenta, se é que isso é possível. Quando ela está por perto, eu me sinto bem, completo, como se eu pudesse fazer de tudo. É engraçado pensar que existe uma pessoa que pode te deixar desse jeito, sem um pingo de noção, totalmente perdido e nervoso, vulnerável, mas completamente feliz. Saber que existe alguém assim para todos deixa um pouco de esperança para aqueles que pensam em desistir. Não é fácil nem simples, mas vale a pena depois. 
<p>Eu me considero sortudo por saber que o meu amor por essa garota vai continuar comigo pelo resto da vida e que ela vai estar aqui para sempre, mesmo com todas as sensações que eu não consigo controlar, mesmo com aqueles momentos que acho que vão me desmoronar, mesmo com todo esse nervosismo e não saber como agir.”.</p>
</body>
</html>";
            }

            if (numero == 42)
            {
                lblTitulo.Text = "Capítulo 42 - Se Você Topar, Eu Topo";
                htmlPage.Html = @"<html>
<body>
<p><i>“Se você topar, eu topo
<br>Se não topar, eu também não
<br>Você quer isso também? Porque eu preciso agora
<br>Se você dizer a palavra
<br>Vou acabar com as suas dúvidas
<br>Posso te mostrar, posso te mostrar
<br>Que nós não temos que ser tão cuidadosos
<br>Que minhas cartas estão na mesa
<br>Se você topar, eu topo
<br>Se não topar, eu também não
<br>Vamos fazer isso, vamos fazer isso agora”</b></i></p>
<br><b>In - Simple Plan
<br>
<p>Will ouviu o barulho do galo cantando. Droga de galo, eu ainda estou morrendo de sono, ele pensou.
<p>Ele abriu um dos olhos e tentou ver as horas em seu relógio no pulso. Eram quase sete. Emily estava deitada do seu lado, ainda dormindo. Os raios de sol entravam pela janela aberta do celeiro e iluminava o chão onde os dois estavam deitados.
<p>- Bom dia. – Ele falou assim que Emily começou a se mexer em seus braços e a abrir seus olhos. – Feliz aniversário.
<p>- Nossa. – Ela sorriu. – Que horas são? Acho que a gente dormiu demais. 
<p>- É. Estamos atrasados, não é?
<p>- Precisamos ir. – Emily deu um aviso de que iria se levantar.
<p>- Não, espera. – Will a impediu. – Eu tenho uma coisa para você.
<p>- Pode me dar na festa. 
<p>- Eu passei a noite toda esperando você acordar para te entregar. Não vai me fazer esperar mais. – Will riu.
<p>- Você dormiu a noite toda.
<p>- Mas esperei nos meus sonhos. 
<p>- Tudo bem, o que é?
<p>- Fecha os olhos. 
<p>- Ah, eu adoro surpresas. – Emily fechou os olhos e abriu a mão. 
<p>- Antes de eu te entregar, eu quero que você leve em conta que eu não tenho tanto dinheiro assim e... – Will respirou fundo. – Eu também não sou muito bom em escolher presentes e... 
<p>- Will, anda logo. 
<p>Will tirou do bolso da calça jogada ao seu lado uma pequena caixinha de veludo azul. 
<p>- Toma. – Ele a colocou na palma da mão de Emily. – Feliz aniversário... de novo. – Depois beijou a namorada no rosto. – Pode abrir os olhos. 
<p>Emily abriu os olhos e os arregalou quando viu a caixinha. 
<p>- Ai, meu Deus. – Ela a abriu. – Esse...
<p>- Naquele dia que fomos fingir que fazíamos compras em Beverly Hills, a gente parou em uma joalheria e você ficou cinco minutos olhando para esse anel.
<p>- Eu não acredito que você percebeu. É lindo. – Ela sorriu.
<p>- Não, isso não é nada comparado a você. – Ele tirou o anel da caixa e colocou no dedo de Emily. – Mas é um enfeite bonito. 
<p>- Palhaço. Eu amei.
<p>- E eu amo você. Eu ia te entregar no jantar de despedida, mas...
<p>- Eu também te amo. – Emily o beijou. – Agora precisamos nos levantar, nos vestir e... torcer para ninguém nos ver entrando de fininho em casa.
<p>- Vamos precisar de sorte.</p> 
<center><h4>--*--</h4></center>
<p>Will entrou na casa que ainda estava silenciosa. Ele abriu e depois fechou a porta com muito cuidado. Emily daria a volta e entraria na casa pelos fundos. Eles estavam com sorte, todos aparentemente estavam dormindo. 
<p>- Bom dia! – Dona Helena surpreendeu Will quando ele estava entrando na cozinha para pegar um copo de água.
<p>- Ah, bom dia! – Ele falou um pouco sem jeito passando a palma da mão pela camisa para tentar tirar o amarrotado. 
<p>Helena estava cortando o pão no balcão que ela havia acabado de tirar no forno. O cheiro estava maravilhoso e harmonizando com café sendo feito na cafeteira e ele nem gostava muito de café. 
<p>- Dormiu bem?
<p>- Dormi muito bem, sim. – Will deu um sorriso. – A senhora sempre acorda tão cedo assim?
<p>- Não sempre, mas já faz algum tempo. Meu marido adorava falar que eu era contra o sono. – Ela sorriu. Era um sorriso tão gentil e bondoso que Will sentiu vontade de abraçá-la. 
<p>- Eu sou completamente o oposto. Se eu pudesse, ficava o dia todo dormindo. 
<p>- Deve ser a idade.
<p>Will ficou observando Helena tirar outra forma do forno. Era um bolo, pelo cheiro, de laranja. 
<p>- A senhora deve ter muito trabalho cozinhando para todo mundo. Aqui é sempre assim? Lotado de gente?
<p>- Ah, eu gosto de casa cheia. Desde que meu marido morreu, eu... eu não gosto de ficar sozinha aqui.
<p>- Entendi. A senhora o amava muito, não é?
<p>- Ele foi o meu primeiro e único. Quarenta anos de muito amor. 
<p>- Nossa, então isso existe mesmo. – Will ficou impressionado. – Deve ter várias histórias.
<p>- Só algumas. – Helena soltou uma risadinha. – Quando ele morreu, eu passei dias sonhando com essas memórias. Uma delas, uma das mais importantes... Tínhamos quinze anos e ele me deu um anel, daqueles que vinham em chicletes, sabe? Ele me disse que um dia aquilo viraria um anel de noivado. Dois anos depois, virou.
<p>- Nossa, vocês se casaram tão cedo assim?
<p>- Antigamente era diferente, a gente era criado acreditando que o casamento resolveria todos os nossos problemas do futuro, que era nosso destino. Muitos, nessa correria, se casaram só por casar e... não tiveram um final muito feliz. Nós tivemos sorte. 
<p>- É, a ideia de casamento é diferente agora. É mais complicado. 
<p>- Isso é relativo. Meu casamento não foi um mar de rosas, mas foi a melhor coisa que eu pude pedir.
<p>- Quando se casou, não ficou com medo de se arrepender?
<p>- Eu sei o que está pensando. Éramos jovens, não sabíamos o que estávamos fazendo, mas tínhamos uma conexão e era bem forte. Eu nunca tive tanta certeza na minha vida como tive naquele momento.
<p>- Isso é incrível. Anos atrás, eu pensava que ficaria sozinho para o resto da vida, na verdade, todos achavam isso de mim também. Eu nunca tinha sentido, sabe? Eu só me importava com... – Will hesitou e parou antes de dizer “sexo”. Era uma senhora. – Além disso, era estranho pensar que um dia eu teria essa vontade de ficar com alguém.
<p>- Isso mudou.
<p>- Quando eu me apaixonei pela Emily, eu pensei... “É ela. Eu poderia planejar o resto da minha vida com ela”. 
<p>- Isso é bom. 
<p>- É muito bom, na verdade. – Will sorriu.
<p>Os dois foram interrompidos por um dos tios de Emily que chegou na cozinha já pedindo por uma xicara de café. Dois minutos depois, mais duas pessoas entraram na cozinha. Dez minutos depois, aquele lugar estava lotado e barulhento.</p>
<center><h4>--*--</h4></center>
<p>Emily estava sentada na cadeira do balanço com um copo de café na mão. 
<p>O sol ainda estava tentando fugir da neblina e a brisa diária ainda estava fria. Ela sempre gostou de tomar café ali quando a casa estava cheia, ajudava com seus pensamentos. 
<p>- Vamos! – Will a assustou. 
<p>- O quê?
<p>- Sua festa é só de noite. Vamos sair.
<p>- Para onde?
<p>- Lembra quando você era nova em Los Angeles e eu te levei para vários lugares? Agora é a sua vez. – Will parecia animado.
<p>- A cidade é bem longe daqui.
<p>- Eu sei. Eu vim da feira, lembra? Mas Nashville é a Cidade da Música. Eu preciso conhecê-la. 
<p>- É, você precisa. – Emily tomou o resto do café em um gole só. – Vamos lá.
<p>- Ótimo. Depois se você quiser, podemos ir visitar os bairros onde só tem mato.
<p>- Fica quietinho, tá bom.
<p>- Sim, senhora. – Will riu.</p>
<center><h4>--*--</h4></center>
<p>A temperatura havia caído um pouco embora o céu estivesse totalmente limpo e o sol brilhasse como nunca. Embora fosse um dia comum, diferente de Los Angeles, ninguém naquela cidade parecia estar com pressa e havia muito mais espaço para que as pessoas não esbarrassem umas nas outras.
<p>- Você é a única do Sul que é estressadinha? – Will brincou enquanto observava as pessoas ao seu redor. 
<p>- Não sei, mas sou a única do Sul que tem que te aguentar vinte e quatro horas por dia. – Ela o provocou. 
<p>Will não escondia sua surpresa de ver uma cidade evoluída de um estado considerado “interior”. Os hotéis pareciam incríveis, as pessoas não andavam só de roupa de cowboy, pelo contrário, muitos estavam de terno e gravata. Will pensou que nunca veria aquilo por ali. Em algumas calçadas, pessoas com seus violões cantavam e tocavam esperando uma gorjeta, muitos davam de bom grado e ainda ficavam em volta para ouvir a cantoria. 
<p>- Eu preciso comprar um violão aqui.
<p>Will olhou admirado para uma loja de instrumentos musicais em que eles passaram em frente. Os cheiros das comidas nos restaurantes eram sentidos de longe e em várias lojas o som do country estava bem alto. 
<p>- Aqui é incrível. – Will e Emily se sentaram em um banco de uma praça para tomar sorvete. – Não é mesmo o tipo de lugar que eu moraria, mas... 
<p>- Não tem tanta carroça quanto você imaginava, não é?
<p>- Exatamente. – Os dois começaram a rir. 
<p>- Bom, aqui não tem tanta gente famosa quanto LA.
<p>- Mas tem as gravações da série Nashville.
<p>- Tenho quase certeza que não gravam aqui. – Emily riu. 
<p>- Ah, aonde você estudava? Queria ver. 
<p>- É do outro lado da cidade. Eu demorava duas horas para chegar lá todos os dias e é bem menor do que a nossa escola, tipo, bem menor mesmo. 
<p>- Não sente falta de ninguém de lá? Tirando o seu amigo, Derek... – Will fez uma careta. – Eu não vi você falando com mais nenhum velho amigo. 
<p>- Eu já te disse, eu não tinha muitos amigos por aqui. Na verdade, eu mal conversava com as pessoas. A maioria dos meus colegas só colava de mim em matemática. 
<p>- Eu queria estar na sua sala para colar de você em matemática. – Will provocou a namorada. 
<p>- Cala a boca. – Ela riu.</p> 
<center><h4>--*--</h4></center>
<p>- Sabe, aqui é muito calmo. Eu quero muito ficar aqui para o resto da minha vida.
<p>Chris e Quinn estavam deitados naquele campo enorme cheio de flores olhando para o céu limpo. Eles haviam saído de casa para fugir da família e das perguntas inadequadas.
<p>- Ah, eu duvido que você quer. Afinal, eu vou estar em Los Angeles daqui a alguns dias. – Quinn sorriu. 
<p>- É, eu não conseguiria mesmo ficar aqui sem você. – Chris a beijou.
<p>- Isso vai ser sério mesmo? Quando voltarmos para casa, você não vai fingir que isso não aconteceu?
<p>- Eu não sou esse tipo de cara. Na verdade, eu não vejo a hora de chegar em casa e contar para todo mundo que eu estou com a garota mais linda do mundo.
<p>- Está quase me convencendo. – Quinn sorriu. – Tenho mais um motivo para querer voltar para casa o quanto antes. 
<p>- Você não me disse porque não gosta de ficar aqui. – Chris olhou desconfiado para a garota.
<p>- Não é que eu não goste, eu só não... eu prefiro ficar lá. É melhor para fugir. 
<p>- Aqui todos te aconselham a perdoar seu pai, não é?
<p>- Eu já perdoei meu pai. Eu só... a gente nunca foi legal um com o outro. Dizem que eu tenho a personalidade forte.
<p>- Isso é desculpa de gente chata. – Chris brincou. 
<p>- Quando eu fui traída, eu quis matar o cara. Não imagino ficando com ele o resto da vida depois disso. 
<p>- Eu perdoei a Ashley.
<p>- E depois se cansou da enganação. Todos temos um limite. 
<p>- Mas... – Chris pensou em argumentar, mas não queria estragar aquela tarde. – Olha, eu não quero ficar aqui falando do seu pai ou da Ashley ou de traição. Eu quero falar de nós, na verdade, eu nem quero falar.
<p>- Esse é o meu tipo de conversa. – Quinn subiu em cima de Chris e começou a beijá-lo. 
<p>- Estamos ao ar livre. Podemos ser pegos.
<p>- Eu gosto do perigo. – Quinn mordeu o lábio de Chris. – E eu vou fazer você gostar também.
<p>- Acho que já estou gostando.</p>  
<center><h4>--*--</h4></center>
<p>- Sabe, eu nunca nadei em um lago antes! Há! – Will mergulhava de um lado para o outro naquele lago feito uma criança. Ele conseguia ver os seus pés pisando nas pedras de tão limpa e cristalina que a água era. Alguns peixes nadavam ao seu lado, os menores ficavam na palma de sua mão quando ele pegava um punhado de água.
<p>- Eu sabia que ia gostar! – Emily gritou sentada na grama ao lado do lago.
<p>- Você tem que vir.
<p>- De jeito nenhum, deve estar muito gelada. 
<p>- Eu te esquento, vem.
<p>- Eu duvido que isso seja possível. – Ela riu. – Na verdade, a gente está atrasado. Já está quase na hora da minha festa e eu preciso me arrumar.
<p>- Mas você já está linda.
<p>- É, você é meu namorado. É seu dever dizer isso. 
<p>- Sabe, acho que eu vou comprar uma casa com um lago do lado. Assim ao invés de usar uma banheira, eu tomo banho no lago.
<p>- Boa sorte achando uma casa assim em Los Angeles. 
<p>- É, vou precisar. – Will deu outro mergulho. – É, EU ESTOU APRENDENDO A RESPIRAR! ESTOU APRENDENDO A ENGATINHAR!
<p>- O que está fazendo?
<p>- Cantando! EU ESTOU PERCEBENDO QUE VOCÊ E SÓ VOCÊ PODE ACABAR COM A MINHA QUEDA!
<p>- Você está berrando.
<p>- EU ESTOU VIVENDO DE NOVO, ACORDADO E VIVO! – Ele ignorou o comentário de Emily.
<p>- <i>Estou morrendo pra respirar nesses céus enormes...</i> – Ela o completou.
<p>- Você se lembra. – Ele sorriu para ela.
<p>- Como não me lembrar? Agora vamos, eu odeio me atrasar.
<p>- Tá legal. Antes... um último mergulho. – Will voltou para debaixo d’agua.
<p>- Eu vou te deixar aqui, viu?! – Ela gritou.</p>
<center><h4>--*--</h4></center>
<p>O lugar estava todo iluminado. 
<p>Foram colocados alguns postes pelo campo com luminárias incandescentes, não havia um espaço escuro. Bexigas coloridas penduradas por toda parte. Mesas de plástico com algumas cadeiras em lugares estratégicos. Uma mesa isolada com um bolo branco de três andares, até parecia de casamento, só faltava os bonequinhos no topo do bolo. Uma espécie de palco na outra extremidade. Harry havia contratado uma banda local, um cantor, um tocador de banjo e um tecladista. Os tios de Emily também tocariam.
<p>- Nossa. – Will arregalou os olhos quando chegou em casa todo molhado.
<p>- Eu sei. Eles são exagerados. – Emily ficou envergonhada.
<p>- Tudo bem. Se eu aceitasse, minha mãe faria uma festa bem maior que essa. – Will riu. 
<p>Os dois entraram em casa para se arrumarem. Depois de um banho bem quente, Emily já estava pronta para a festa. Antes de sair do quarto, ela olhou para seu anel no dedo. Era maravilhoso. 
<p>- Você está incrível. – Will estava esperando pela namorada na ponta da escada.
<p>- Você também está incrível. – Emily respondeu. 
<p>Além dos familiares, alguns vizinhos também estavam na festa. Algumas pessoas dançavam ao som daquela música que Will não conhecia. Quinn e Chris estavam tentando se esquivar dos convidados para ficarem sozinhos. 
<p>Will encheu um prato descartável de salgadinhos na mesa de comidas e se sentou em uma das mesinhas de plástico. Emily cumprimentava todo mundo ao lado de seu pai que parecia muito feliz.
<p>- Você deve estar se divertindo. – Patrícia se sentou ao lado de Will. 
<p>- Comer é a minha melhor diversão. – Will falou de boca cheia. 
<p>- Sabe, eu fiquei feliz por ter vindo para cá. Emily virou outra pessoa quando você chegou.
<p>- É, eu... também estou feliz por ter vindo. Harry até está sendo gentil.
<p>- Isso porque ele não sabe que vocês fogem para o celeiro todas as noites.
<p>- O quê? – Will quase engasgou. 
<p>- É, eu sei. – Patrícia sorriu. – Também sei que você está com problemas em casa e tem dormido no quarto dela. 
<p>- Como...
<p>- Eu sou a mãe.
<p>- Todas as mães têm o mesmo discurso? – Will se lembrou da conversa com a sua própria mãe meses atrás. – E por que não contou para o Harry?
<p>- Porque eu sei como ele reagiria. E porque eu sei que você é um rapaz bom. 
<p>- Muito obrigado. 
<p>- Como estão seus irmãos?
<p>- Sebastian acordou. Isso é bom.
<p>- Muito bom. Graças a Deus.
<p>- É. – Will não acreditava muito em Deus, mas não era sobre isso que ele queria falar naquele momento. – Ainda estou com problemas com o Kevin, mas... resolvi minhas diferenças com o Christopher e isso também é bom. – Ele riu.
<p>- Sabe, Will, eu não digo isso muitas vezes, mas eu gosto que você esteja com a Emily. Você faz bem a ela.
<p>- É, ela faz bem mais por mim. O sortudo sou eu.
<p>- Ah, é sim. – Patrícia sorriu e pegou na mão de Will. – Obrigada.
<p>- Eu que agradeço.</p> 
<center><h4>--*--</h4></center>
<p>- Gente, eu... eu vi o microfone desocupado então... não me aguentei, desculpa. – Will subiu no palco. Todos olharam para ele surpresos. Emily se aproximou mais do palco um tanto incrédula. – Na verdade, eu dei dois dólares para o John me deixar cantar essa. – Ele riu. – Ah, eu tenho essa música... Antes de cantar, eu queria dizer algumas palavras...
<p>Will olhou para Emily. Ele não se considerava muito bom com discursos, mas a ocasião pedia. 
<p>- Eu vim de LA até aqui atrás de uma garota. Essa garota me tira do sério, mas também me tira o ar só de olhar para ela. Dá um pouquinho de trabalho ser o namorado dela, muita dor de cabeça, mas também... vale todo o esforço. Eu a amo, amo muito. Eu sou uma pessoa melhor por causa dela. E enquanto eu estava lá, do outro lado do país, sozinho, eu tive mais certeza... Não existe Will sem Emily. Feliz Aniversário. 
<p>Will pegou o banjo um pouco desajeitado. Não estava muito acostumado com aquele instrumento, mas isso não o impediu de tocá-lo perfeitamente.
<p>- <i>Bom, ela vai chorar... Antes do filme acabar. Ela vai te dar o coração dela... Oh, oh, e vai parecer que você o roubou. Ah, ela vai estar com o cabelo amarrado e usando sua camiseta. Não vai precisar tirar uma foto porque mesmo depois que ela for embora... É, você ainda vai se lembrar, vai pensar nela em cada minuto da sua noite...</i>
<p>Emily nem ao menos piscava e sorria como nunca. 
<p>- <i>É exatamente assim que ela ama... É exatamente assim que ela mexe com você. Ela vai te deixar nas nuvens. Cara, você pode tentar, só saiba que nunca vai ser o suficiente... Ela vai te deixar em chamas. Ela vai iluminar a sua meia-noite.... Oh, e se você conseguir ficar com ela, nunca a deixe ir embora. Ela é como um pôr do sol deixando tudo como ouro... É exatamente assim que ela ama</i>.</p>
<br>
<p>“Existem oportunidades na vida que você não pode perder. O único problema é que você, na maioria das vezes, só as reconhece depois que as perde. Passamos a vida vivendo no limite. O que dizer? O que fazer? Nos preocupando com várias coisas ao mesmo tempo, pensando demais, pensando de menos. 
<p>Você gostaria de voltar no tempo e pegar de volta a oportunidade que você perdeu? O que isso mudaria na sua vida? O que não mudaria? Você consegue conviver com esse pensamento?”.</p>
<br>
<p>- A festa foi incrível. – Will e Emily estavam deitados no chão do celeiro. Já passava das duas da manhã e os dois não estavam com um pingo de sono. 
<p>- É, foi sim. Não precisava ter feito aquilo. Embora tenha sido lindo. – Emily o beliscou de leve na costela.
<p>- Esse foi o jeito que eu encontrei de marcar meu território aqui no Tennessee. Agora ninguém vai querer se aproximar de você e me enfrentar. 
<p>- Nossa, achei que tinha feito isso porque me amava.
<p>- Não seja boba. – Will começou a rir. – Ah, eu já ia me esquecendo. Sua mãe conversou comigo e disse que sabia das noites que passei no seu quarto.
<p>- O quê? Como? – Emily arregalou os olhos e começou a ficar preocupada.
<p>- Relaxa, ela não se importou. Até disse que eu sou incrível. Não com essas palavras, mas disse.
<p>- Eu aposto que disse. – Ela ficou mais calma. 
<p>- É. Sabe, ficar perto da sua família me fez perceber que eu quero ficar longe da minha. Isso faz algum sentido?
<p>- Não.
<p>- Parece que me desligar era a coisa certa a se fazer. O Chris tinha razão. 
<p>- É, mas uma hora vamos ter que voltar. Como se sente a respeito disso?
<p>Will hesitou.
<p>- Vamos fugir? Podemos colocar toda a comida da sua vó em uma mochila e irmos para algum país da Ásia.
<p>- Por que Ásia?
<p>- Todos são japoneses, vamos nos destacar.
<p>- Palhaço. – Emily começou a rir.
<p>- Mas falando sério, eu acho que... eu vou mesmo procurar um lugar para morar. Talvez um lugar mais perto da praia, talvez uma mansão nas montanhas...
<p>- Terra chamando Will. – Emily levantou uma de suas sobrancelhas. 
<p>- É, eu sei. O máximo que eu vou conseguir é um “apê” no centro do tamanho de uma caixa de sapatos, mas já está valendo. 
<p>- É claro que está. 
<p>- Não vou mais precisar pular a sua janela. Vamos ter um lugar só nosso, não vamos precisar ficar no seu quarto. 
<p>- Mas... Meio que pareceu que estava me chamando para morar com você. 
<p>- Mas eu já chamei. Você não se lembra? – Will fitou Emily tentando decifrar o que ela estava pensando. – Só que eu nunca ouvi uma resposta, pelo menos, não muito concreta. 
<p>- Não se trata de eu querer. Você conhece meu pai, nunca aceitaria isso. Ele é muito careta, imagina a filha dele que acabou de completar dezessete anos indo morar sozinha com o namorado. Ele ia infartar.
<p>- É. Mas se isso não fosse um problema, você aceitaria se eu te pedisse para ir morar comigo?
<p>- Se você pedisse com jeitinho.
<p>Os dois começaram a rir. Depois de uns segundos, Will parou de rir e ficou sério. Naquele momento, foi como se um filme estivesse passando na sua cabeça. Todos aqueles momentos, todos aqueles lugares, todas aquelas noites, todas as brigas e beijos, palavras ditas e não ditas. Era como se ele tivesse só uma oportunidade de dizer naquela hora o que ele queria dizer.
<p>- Casa comigo. 
<p>- O quê? – Emily parou de rir instantaneamente e preferiu fingir que não entendeu o comentário dele ao invés de responder algo.
<p>- Casa comigo. – Ele repetiu. Não foi como se ele tivesse se arrependido, na verdade, na segunda vez, ele ficou mais decidido. 
<p>- Will...
<p>- Eu não vou mentir para você e dizer que eu planejei isso, porque eu não planejei. Na verdade, isso veio na minha cabeça cinco minutos atrás e eu sei que não é o melhor discurso para um pedido de um casamento.
<p>- Will...
<p>- Na verdade, eu sempre pensei que faria o pedido daqui dez anos na frente de uma multidão, talvez com um <i>flash mob</i>, cartazes e balões, talvez até com pétalas de rosas. Eu ainda não me decidi, mas... Eu amo você. E eu quero fazer direito então casa comigo.
<p>- Will, você não... – Emily mal conseguia falar de tão surpresa que estava. – Estamos falando de casamento, isso é coisa séria, não é... estamos falando do resto das nossas vidas. 
<p>- Que eu quero que passemos juntos. Você não quer?
<p>- É claro que eu quero, mas...
<p>- Mas...
<p>- Você não está pensando direito. Se a gente se casasse, mesmo que escondido porque ninguém ia aceitar, todo mundo ia comentar, primeiro iam dizer que eu estou grávida, iam dizer que somos loucos, começariam apostar a duração do casamento e...
<p>- Primeiro, você iria se casar comigo, não com todo mundo.
<p>- Mas... O que a gente sabe sobre casamento? Eu não sei ser uma esposa, eu nem sei o que ser esposa significa.
<p>- A gente também não sabia o que era namorar e, particularmente, eu acho que nos saímos muito bem. – Will sorriu.
<p>- Olha, isso não é uma coisa que... você não pode jogar essa bomba em cima de mim desse jeito. – Ela começou a gesticular. – Não pode chegar aqui e falar de casamento como se fosse a coisa mais normal do mundo. Você nem se ajoelhou e nem tem um... – Então ela olhou para a sua mão. – Um anel. 
<p>Ela havia olhado para aquele anel mais cedo e sabia o que tinha pensado. Não era loucura da cabeça de Will, ou ela também estava louca. 
<p>- O Will de dois anos atrás nunca imaginou que estaria tendo essa conversa com alguém agora. – Will riu olhando também para o anel. – Mas o Will de agora, ele... eu tenho certeza que não existe um amor tão forte quanto o nosso. Você sempre volta para mim e eu sempre volto para você porque não conseguimos fazer outra coisa. Eu também não sei ser um marido e eu não sei exatamente o que um casamento realmente significa. Se você não quiser, tudo bem. A gente finge que nunca tivemos essa conversa e fazemos amor. Eu sei que é loucura. Mas...
<p>- Eu quero. Eu quero muito. – Emily respirou fundo.
<p>- Eu sei que você pensa mil vezes antes de tomar uma decisão e eu sou maluco impulsivo. Eu sei que você está com medo, eu também estou. Mas eu também sei que a gente consegue fazer isso.
<p>- Como você sabe?
<p>- Porque não existe Will sem Emily. – Will voltou a sorrir. 
<p>- Will...
<p>- Emily. – Will olhou bem nos olhos dela e tentou passar toda a credibilidade e segurança possível só com aquele olhar. – Casa comigo.</p> 
<br>
<p>“Sabe aquela oportunidade? Aquela que você não pode perder? Eu quase a perdi. Quase deixei passar por vários motivos, primeiro por quase não ter reconhecido a tempo, depois que reconheci, fiquei com medo. Depois fiquei na dúvida... Até cheguei a pensar que outra oportunidade como aquela chegaria mais cedo ou mais tarde... Mas eu iria aguentar esperar? Você aguentaria?
<p>Exatamente. Por isso que... independentemente do resultado, mesmo com medo e com dúvidas, se arrisque. Aproveite, lide com as consequências depois. Eu aproveitei. Eu peguei a oportunidade e segurei com todas as minhas forças. E... eu nunca me senti tão orgulhoso de mim como naquele momento.”.</p>
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
            if (condicao+1 > 42)
            {
                Navigation.PushModalAsync(new Capitulo8Page(condicao + 1));
            }
            else
            {
                Navigation.PushModalAsync(new Capitulo7Page(condicao + 1));
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