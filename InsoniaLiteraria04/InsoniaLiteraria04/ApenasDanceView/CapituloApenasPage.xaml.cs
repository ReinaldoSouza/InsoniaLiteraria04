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

namespace InsoniaLiteraria04.ApenasDanceView
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CapituloApenasPage : ContentPage
	{
        DBFire service;
        public int condicao;

        public CapituloApenasPage (int numero)
		{
			InitializeComponent ();
            service = new DBFire();
            condicao = numero;
            mostrarCapituloSalvo("ApenasDance", "Capitulo" + numero.ToString());

            if (numero == 1)
            {
                lblTitulo.Text = "O Baile";
                
                htmlPage.Html = @"<html><body>
<p>Eram dez horas da manhã na cidade de Lima, no Condado de Allen, estado de Ohio. Faltava uma semana para as férias de inverno e o corpo estudantil do Stoneheart High School mal podia esperar para a chegada do final de semana, quando eles dariam adeus aos estudos durante dez dias.
<p>- Ei, Brianna! – A garota de cabelos castanhos e corpo esguio ouviu alguém a chamando pelo corredor. A menina trancou seu armário e virou-se para ver quem a chamava.
<p>- Ah, é você, Joe! – Ela falou com desinteresse. – O que quer? Você não deveria estar encerando o chão por onde minha irmã passa ou algo do tipo?
<p>- Eu não a vi na aula hoje. - o garoto loiro respondeu se encolhendo em reação ao tom de voz da menina. – Queria saber se você a viu? – Ele perguntou encolhendo-se ainda mais fazendo uma careta. Brianna poderia jurar que se ele encolhesse mais ficaria menor que sua irmã que era a garota mais baixinha que ela conhecia.
<p>- E eu lá tenho cara de babá de rebelde sem causa? – Brianna fala e sai para o refeitório onde seus amigos a esperavam para tratar dos últimos detalhes do Baile de Inverno que aconteceria no próximo final de semana.
<p>Considerando que a amiga não havia aparecido para as aulas da manhã e que sua irmã, Brianna, não sabia dela, Joe só pode concluir que Týr, mais uma vez, havia enrolado os pais para matar aula. Ela começou a fazer isso sempre que um baile do colégio se aproximava quando ainda era uma novata no colegial e isso não mudou quando chegou ao seu último ano no colégio.
<p>Týr odiava a ideia de se vestir e se arrumar toda para agradar a algum moleque do colegial do qual ela nem lembraria o nome daqui a dois ou três anos. Há dois anos, quando era uma novata, uns engraçadinhos fizeram uma aposta para ver quem conseguiria ser o par dela no baile da primavera, após rejeitá-los várias vezes e expulsá-los repetidamente da sua presença, ela acabou batendo em um dos pretendentes mais insistentes que foi parar na enfermaria do colégio com um braço torcido e cinco dedos marcados em uma das faces. Isso lhe rendeu uma suspensão de três dias, por isso, desde então, ela evitava ao máximo os corredores de Stoneheart sempre que uma dessas ocasiões se aproximava.
<p>Joe resolveu faltar a última aula do dia e ir procurar por sua amiga. Estava acabando de atravessar o jardim da escola quando sentiu uma mão tocar em seu ombro, ao se virar ele deu de cara com Zack, o cara mais popular do colégio, era tão alto quanto Joe, mas seu porte atlético de jogador de futebol americano o fazia parecer intimidador, isso somado ao seu rosto de traços marcantes e o cabelo negro rebelde fazia com que todas as meninas do Stoneheart se arrastassem a seus pés. Todas, menos Týr. Eles eram grandes amigos quando crianças, chegavam a ser inseparáveis, até que depois da morte do pai, seis anos atrás, ela se afastou de todo mundo, inclusive dele. O único com quem ela ainda conversava era o nerd esquisito que a seguia para todos os lados quando começaram o colegial.
<p>- Cadê a Valentina? – Zack foi direto ao assunto.
<p>- Desculpa, cadê quem? – Joe perguntou confuso.
<p>- Týr, - Zack falou a contragosto, ele achava o nome dela lindo, não via necessidade em criar um apelido – onde ela está? Era para a gente se encontrar para finalizar o trabalho de literatura juntos, mas ela me deu bolo.
<p>- Ah, ela, as vezes esqueço que ela se chama Valentina. – Joe sorriu de canto um pouco envergonhado por não lembrar do nome de verdade da amiga. – Ela não apareceu nas aulas também. Estou indo procurá-la em casa, se quiser, pode vir comigo. – O moreno hesitou um pouco, mas resolveu seguir com o outro, ele precisava mesmo falar com Valentina fora dos corredores da escola.
<p>- Ela tá fazendo aquilo de novo, não é?
<p>- Aquilo o quê? – Por que a conversa daquele cara era sempre tão estranha? Joe pensou.
<p>- Aquilo de matar aula por causa do baile. – O outro explicou.
<p>- Ah, isso, é, ela está fazendo de novo. Eu queria entender o que há de tão ruim em ir a um baile, se ela não quer ir com um parceiro, poderia ir sozinha, não é como se ela se importasse com o que falariam dela por estar sozinha no baile.
<p>- Mas ela se importa em não poder bater ‘naqueles animais que insistem em me atormentar’. – Zack fez uma imitação do tom irritado da amiga de infância fazendo com que seu companheiro de caminhada gargalhasse, mas ele não sorria, lembrar do jeito briguento e mal-humorado dela o deixava triste.
<p>- Você gosta dela, não é? Eu vejo você a observando pelos corredores. – Joe perguntou, sério e recebeu um aceno de cabeça como resposta. – Então, por que não fala isso pra ela?
<p>- Eu não quero que ela se afaste de novo. – Zack parou, eles estavam há algumas quadras da casa de Týr e da dele. – Eu era o melhor amigo dela, mas quando a gente tinha onze anos, o pai dela morreu num acidente de carro quando estava indo assistir a uma apresentação dela no musical da escola e a Valentina começou a se culpar por isso, no início eu falava pra ela que não era sua culpa, mas não adiantava até que um dia, no aniversário de morte do Sr. Forbes nós discutimos por causa das aulas de dança do grupo de teatro que ela tinha abandonado e ela deixou de falar comigo. – O rapaz encarava a janela da casa de andar há alguns metros dali, onde ele sabia que Týr estaria deitada ouvindo música no último volume. – Demorou três anos para ela voltar a falar comigo, isso porque um professor a obrigou a ser minha dupla na turma de química, eu não posso arriscar isso, seja lá o que isso for, por egoísmo.</p>
<center><h4>--*--</h4></center>
<p>No final da rua, em uma bela casa de dois andares, uma garota de pele clara e olhos negros fitava, confusa, duas figuras que se encaminhavam na direção de sua casa pela janela. O que aqueles dois estão fazendo aqui juntos? Týr se perguntava e ao mesmo tempo torcia que fosse só uma coincidência, afinal Zack morava do outro lado da rua, ele deveria estar voltando da escola mais cedo, só isso.
<p>Pensar em Zack deu a Týr a impressão de que ela tinha algo de importante para fazer, mas ela não sabia o que. A menina levantou-se da cama que ficava sob o parapeito da janela para trocar o CD do aparelho de som, havia cansado de ouvir Bryan Adams, precisava de algo mais impactante e um pouco menos sentimental para ocupar sua mente, aproveitando que sua mãe e seu padrasto não estavam em casa para reclamar do barulho, ela colocou BACK IN BLACK do AC/DC no último volume e desceu as escadas em busca de algo para comer na cozinha.
<p>Depois de convencer um relutante Zack a atravessar a rua e ir falar com Týr, Joe parou em frente a porta da casa da amiga e tocou a campainha. Ao aproximar-se da casa ele teve sua suspeita de que ela estava em casa confirmada, da calçada dava para ouvir o som ensurdecedor de What Do You Do For Money Honey vindo do interior da residência.
<p>Alguns minutos depois, Týr atendeu à porta descalça, vestida num short preto meio rasgado e uma blusa com estampa do Fall Out Boy que era o dobro do seu tamanho. Sua cara de poucos amigos fazia o título da banda estampado na blusa parecer bem autoexplicativo se lido em seu sentido literal.
<p>- O que vocês querem?
<p>- Precisamos conversar. – Joe informou. A moça revirou os olhos e se afastou da porta, dando espaço para os dois rapazes entrarem. Ela indicou que eles a seguissem escada acima até o quarto, onde ela logo diminuiu o volume da música.
<p>-Tudo bem, agora desembuchem. – Ela falou com impaciência, colocando uma das mãos no quadril ao assumir a pose mandona que os dois garotos tanto conheciam.
<p>- Seu amigo esquisito me arrastou até aqui. – Zack provocou e recebeu uma careta por parte do loiro como resposta.
<p>- Por que você faltou à aula? – Joe foi direto ao assunto, mesmo já sabendo qual seria o motivo.
<p>- Não interessa. – Respondeu emburrada.
<p>- Você só pode estar de brincadeira. É nosso último ano, não podemos ficar perdendo aula por capricho, universidade nenhuma vai te dar uma bolsa desse jeito. – Joe rebateu.
<p>- Não foi por capricho e você sabe disso. – falou cruzando os braços na frente do corpo na tentativa de ocultar o incômodo que sentia com aquele assunto. – Eu não vou discutir sobre isso. – cortou o assunto antes que Joe insistisse naquilo. – E você o que faz aqui?
<p>- Hãm, eu? – Zack perguntou. Estava absorto em pensamentos paralelos a respeito do motivo do sumiço de Týr dos corredores da Stoneheart.
<p>- Não, o Han Solo. – Týr respondeu com sarcasmo.
<p>- Você não apareceu para terminarmos o trabalho de literatura e eu estranhei. – O quarterback explicou.
<p>- Que droga, eu esqueci! – A menina exclamou batendo com uma das mãos na própria testa – Faremos hoje à tarde.
<p>- E quanto ao não pisar nos corredores do colégio? – Joe interferiu, tinha esperanças que a amiga acabasse com aquela bobagem e voltasse a assistir as aulas.
<p>- Podemos fazer aqui em casa, tenho os livros e podemos usar meu computador para pesquisas.
<p>- E a apresentação do trabalho, é em dois dias, não é? – O rapaz insistia.
<p>- Não haverá apresentação, apenas a entrega do trabalho escrito. O Zack pode fazer isso sozinho.
<p>- Valentina! – Zack a chamou, mas arrependeu-se imediatamente de chamá-la assim ao ver o olhar de fúria que ela lhe transmitiu. Por isso, apressou-se em completar o pensamento. – Eu tenho treino de futebol à tarde, será que podemos deixar para à noite?
<p>- Você quem sabe. – Ela limitou-se a dizer. Não gostava quando a chamavam por seu nome de verdade. Apenas duas pessoas a chamavam assim, Zack era uma delas, quando eles eram melhores amigos, a outra estava há muito morta e ela não gostava de lembrar disso. – Se isso é tudo, façam-me o favor de dar o fora da minha casa. Quero curtir minha “dor de garganta”. – Falou fazendo um gesto de aspas com a mão para indicar a desculpa que tinha dado à mãe para não ir ao colégio.</p>
<center><h4>--*--</h4></center>
<p>Brianna voltava para casa acompanhada de Lýs e Tess, suas melhores amigas. As duas tagarelavam incansavelmente sobre como seus vestidos para o baile eram deslumbrantes e quão caro eles haviam custado. Mas ela caminhava absorta, pensando em sua irmã. A observação do fiel escudeiro de Týr, Joe, havia chamado a atenção da garota para o comportamento da irmã mais velha. Ela sabia o que ele estava pensando e ele estava certo em se preocupar, a chegada do baile sempre deixava sua irmã estranha, quando criança as duas amavam dançar e sair com os amigos, eram muito ligadas, mas quando o pai das duas morreu Týr se afastou de todos, inclusive dela, deixou o grupo de dança, as aulas de teatro e até parou de falar com Zack, coisa que Brianna achava impossível de acontecer, já que os dois viviam enganchados.
<p>Zack e Brianna secretamente fizeram um acordo de deixar que Valentina tivesse seu tempo sozinha, para se recuperar do trauma e voltar a ser como era antes. No entanto, os anos passaram-se e a menina ficou cada vez mais fechada para o mundo, só conversava abertamente com Joe e Brianna era agradecida a ele por cuidar dela por todo esse tempo. Entretanto, estava na hora dela tomar as rédeas dessa situação, sua irmã não podia ficar mais afastada do mundo e ela não podia mais deixar que os outros se preocupassem com isso enquanto observava tudo de fora.
<p>- Brianna, você está escutando a gente? – Tess parou de frente para a amiga. – Você tá passando mal? – Preocupou-se ao olhar a expressão estranha no rosto da outra.
<p>- Hãm, sim... claro, desculpa, do que vocês estavam falando mesmo? – Brianna respondeu, só então ela percebeu que já estavam em frente a sua casa.
<p>- Sobre os garotos do time, eles começaram de novo com a brincadeira idiota de perseguir sua irmã, não vejo graça em perturbar uma pessoa que não interfere na vida de ninguém. – Lýs respondeu indignada.
<p>- Eu confesso, que as vezes, eu queria que ela desse outra surra em um deles pra ver se aperta os parafusos soltos. – Tess afirmou sorrindo.
<p>- Não seria de todo mal! – Brianna concordou rindo. E teve uma ideia. – Garotas, eu tive uma ideia e vou precisar da ajuda de vocês, mas antes eu preciso falar com uma pessoa, me esperem aqui. – Dito isso, ela atravessou a rua sem demora e tocou a campainha da casa em frente a dela.
<p>Uns minutos depois a porta se abriu revelando uma mulher bonita de feições suaves e pele morena, seus cabelos, assim como os do filho, eram negros e estavam sempre majestosamente bagunçados, o que lhe dava um ar despojado e jovial.
<p>- Olá, senhora Black! – Cumprimentou educadamente. – O Zack tá em casa?
<p>- Claro querida, entre. – A mulher respondeu revelando um sorriso brilhante. – Ele está na sala, acabou de chegar do treino. – Imediatamente, Brianna atravessou a entrada da casa e foi de encontro a Zack que estava largado no sofá.
<p>Ela agarrou uma das almofadas que estava numa poltrona na sala e jogou na cara do rapaz:
<p>- Sua mãe vai te matar se te ver largado no sofá dela todo suado e grudento desse jeito. – Zack olhou na direção da menina confuso com a presença dela. – Nós precisamos conversar!
<p>- “Oi, Zack, como vai?” Estou bem, Bri e você? “Estou ótima, podemos conversar?” – O garoto a respondeu com sarcasmo. – O que há no DNA dos Forbes que são sempre tão delicados?
<p>- Nosso pai era militar. E não me chama de Bri. – Brianna rebateu fazendo uma careta. – Mas isso não vem ao caso. Preciso da sua ajuda para ajudar Týr. – Notou a careta de Zack ao ouvir o apelido. – E pra começo de história: você vai ter que superar seu problema com o apelido.
<p>- Eu nem aceitei ainda e você já tá dando ordens. Ótimo! – O garoto bufou.
<p>- Não se faça de rogado, você está doido para tê-la de volta só pra você e monopolizar a atenção dela como era antes. Agora, me dá seu celular. – Ele a olhou com desconfiança. – Anda logo! – Ela esticou o braço esperando ele lhe entregar o aparelho.
<p>Zack não sabia se confiar em um plano maluco de Brianna era a melhor ideia de reaproximação, mas ele não sabia mais o que fazer pra ter a confiança de Valentina de novo. Então, relutantemente, entregou o aparelho celular à garota e observou ela mexer nele com impaciência. Assim que terminou o que queria, a menina devolveu o aparelho ao dono e mandou que ele lesse a mensagem que havia enviado para todos os integrantes do grupo.
<p>- Do que se trata isso?– Ele perguntou ao terminar de ler a mensagem.
<p>- Lýs e Tess acabaram de me contar que seus amiguinhos do time, mais uma vez, planejaram mexer com minha irmã por causa do baile.
<p>- Mas eu não fiquei sabendo de nada!
<p>- Como se eles fossem contar a você, todo mundo sabe que você é doidinho por ela e, por mais burros que seus queridos colegas de time sejam, não iriam querer o capitão deles zangado com o time. – Explicou.
<p>- E você acha que ameaçá-los vai funcionar? – Zack duvidava da eficácia do plano.
<p>- Não custa tentar. Agora é minha vez de agir, vê se não faz nenhuma burrice e lembre-se do que falei sobre o nome dela. – Sem esperar resposta, ela saiu como um raio em direção a porta deixando Zack pensativo no sofá.
<p>Depois da partida de Brianna o rapaz se levantou e subiu as escadas, precisava de um banho para relaxar. Logo ele saberia, de qualquer forma, o que ela aprontaria, afinal tinha que ir encontrar com Týr para fazerem o trabalho. Ao entrar no quarto foi até a janela e viu Týr em seu quarto, do lado oposto da rua, sentada no parapeito da janela com fones no ouvido. Diferente de quando eram crianças, quando ela tinha um cabelo enorme, agora ela assumiu um corte channel curto com pontos longas na frente e pintado todas as pontas do cabelo de azul escuro o que destacava ainda mais seus enormes olhos negros, olhos com os quais ele sonhava todas as noites desde a discussão que tiveram cinco anos atrás.
<p>- É, o dia está movimentado e pelo visto só está começando! – Ele concluiu com ar de cansaço.</p>
<center><h4>--*--</h4></center>
<p>-Vocês entenderam o que devem fazer? – Brianna perguntou a Lýs e Tess que assentiram. – Ótimo! Agora andem que eu tenho que conversar com a fera.
<p>- Boa sorte! – As duas disseram em uníssono e se levantaram para partir.
<p>Após a saída das amigas Brianna trancou a porta e subiu as escadas, estava na hora de conversar seriamente com a irmã. Bateu na porta do quarto de Týr, mas não recebeu resposta, então resolveu entrar assim mesmo, a irmã estava sentada no parapeito da janela com fones no ouvido e de olhos fechados. Ao menos com mamãe e Josh em casa ela desliga aquele som infernal Brianna pensou. Se aproximou da irmã mais velha e tocou de leve em seu braço, tinha medo que a outra se assustasse e acabasse caindo da janela.
<p>- Ei! – Týr cumprimentou a irmã com olhar calmo e tirou os fones. A outra estranhou a calmaria da irmã e não resistiu e acabou perguntando:
<p>- Não era pra você estar subindo pelas paredes de raiva por causa das gracinhas da galera do colégio?
<p>- Descontei minha raiva no saco de areia lá na garagem, não há mau humor que resista depois disso. – Ela falou satisfeita.
<p>- Sorte a minha, porque a gente precisa levar um papo muito sério. – A irmã falou a puxando da janela e sentando-a junto a ela na cama. – O baile!
<p>Ao ouvir a palavra dissílaba Týr assumiu uma postura desconfiada e afastou-se da irmã que a encarava segurando em sua mão com firmeza. Brianna era forte, seu corpo naturalmente atlético e esguio era bonito, mas não era só fisicamente que ela tinha força. Týr invejava a irmã mais nova pelo autocontrole, senso de justiça e sensatez, mas sabia que fugir daquela conversa não era uma opção, Brianna sabia ser dura e fria e até mesmo inconveniente quando queria.
<p>- Você não vai me soltar, não é?
<p>- De jeito nenhum! – Brianna falou balançando a cabeça em negação e apertando mais a mão em volta do pulso da irmã.
<p>- Que droga! – Týr falou bufando. Sentou na cama em redenção.
<p>- Você não pode continuar com isso, não pode continuar afastada de todos que te amam. – Brianna começou. – Eu sei que você sente falta do papai, eu também sinto. Sei que dançar te faz lembrar dele e que você não quer isso, mas em duas semanas acaba o prazo de matrícula para as bolsas das universidades e se você não se inscrever logo vai perder a única chance que tem de realizar o seu sonho de infância, entrar para Julliard School.
<p>- E quem disse que eu quero isso? – Týr falou emburrada.
<p>- Sério? Você só falava nisso quando o papai era vivo. Vivia dando piruetas e falando que seria uma grande bailarina igual a vovó e que iria estudar na mesma universidade que ela. E quer saber? – Ela puxou o rosto da irmã para que a encarasse. – Você seria uma tola e estaria manchando a memória do papai, porque, sinceramente, não acho que ele iria gostar de saber que você desistiu de seus sonhos por causa dele e muito menos que você usa ele como desculpa para seu medo. – Levantou-se e antes de sair do quarto se virou e concluiu. – Ele amava o Zack como se fosse filho dele e odiaria saber que você também o afastou por causa de uma discussão idiota a respeito de uma coisa que ele tinha razão. – E saiu batendo a porta.</p>
<center><h4>--*--</h4></center>
<p>Brianna estava sentada à mesa esperando que sua mãe servisse o jantar. Týr não havia saído do quarto desde a conversa delas.
<p>- Elisa, Týr não vai descer para jantar? – Josh, o padrasto das garotas, pergunta à mãe delas.
<p>- Eu a chamei, mas ela nem mesmo abriu a porta, simplesmente gritou que estava sem fome. Mais tarde eu levo algo pra ela comer. – Elisa respondeu.
<p>- Tem certeza? Moro nessa casa há três anos e acho que nunca a vi perder a fome. Será que está doente? – Josh preocupou-se.
<p>- Relaxa, Josh. Ela não está doente, só está ocupada resolvendo umas coisas. – Brianna explicou brevemente.
<p>Eles comiam e conversavam alegremente durante o jantar, Elisa estava curiosa para ver o vestido que a filha comprou para o baile e a enchia de perguntas de como estava a organização para a festa. Quando estava no colégio, Elisa fazia parte da comissão de organização dos bailes da Stoneheart High School e sonhava que suas filhas seguissem o mesmo caminho, no entanto sua filha mais velha teve problemas quanto a isso e ela sempre depositava suas expectativas sobre a caçula.
<p>Quando todos terminaram de comer, Brianna ajudou sua mãe a lavar a louça, enquanto Josh enxugava e guardava. Eles ouviram a campainha tocar e a menina foi abrir a porta.
<p>- Zack? O que faz aqui? – Ela perguntou surpresa.
<p>- Eu combinei com sua irmã de fazermos o trabalho para a aula de literatura, já que ela me deu bolo hoje cedo. Ela tá aí?
<p>- Claro, tá lá em cima. Mas eu não me surpreenderia se ela não abrisse a porta.
<p>- Por que não? – Ele estranhou, Týr não parecia muito enraivada quando ele a viu mais cedo pela janela.
<p>- Tivemos uma conversinha e digamos que ela não aceitou muito bem o tema. - Explicou fazendo careta. – Vai se arriscar?
<p>- E eu tenho outra opção? – O jovem falou já subindo as escadas.
<p>Subiu as escadas pulando dois degraus por vez e atravessou o corredor até a última porta, parou em frente e respirou fundo antes de bater. Deu três batidas rápidas, sem receber resposta insistiu, repetindo o gesto, depois de três tentativas Zack começou a falar alto para garantir que a menina lá dentro ouvisse o que ele tinha a dizer.
<p>- Týr, abre essa porta, sou eu, o Zack. – Nada de resposta. – Olha, se você não abrir essa maldita porta em dez segundos eu vou arrombá-la, me ouviu? – E começou a contar. – Dez... nove... oito... sete... seis... cinco... quatro... tr... – Antes que ele finalizasse a contagem a amiga escancarou a porta o olhando torto, assim que ele entrou no quarto ela trancou novamente a porta e jogou um livro na direção dele quase acertando na cara.
<p>- Marquei alguns trechos que podemos usar no corpo do trabalho, veja o que acha, eu vou terminar as pesquisas. – Anunciou se virando para o computador. Mas Zack não estava preocupado com nenhum trabalho estúpido do colégio no momento, ele largou o livro em cima da cama e a puxou pelo braço a segurando com firmeza pelos ombros para impedir que ela se desvencilhasse dele. – O que foi agora? – Ela perguntou encarando o peito definido do amigo, que ficava exposto devido a camisa de algodão grudada que ele estava vestido, não queria encarar os olhos dele.
<p>- “O que foi?” pergunto eu. Quando estive aqui mais cedo você parecia bem, até me tratou sem ironias e xingamentos, quase como antigamente e agora tá assim, fria, agindo mecanicamente. O que sua irmã te falou pra te deixar assim?
<p>- Um monte de besteiras sobre eu estar com medo de não ser aceita na Julliard, por isso não me inscrevo e sobre eu usar a morte do papai como pretexto. – A voz de Týr saía um pouco esganiçada devido ao choro que ela tentava segurar. - Mas eu não quero falar sobre isso agora. – Falou encostando a testa no abdômen de Zack de modo a esconder as lágrimas que não conseguiu segurar.
<p>- Esse é o problema, você nunca quer falar sobre isso, não quis falar há cinco anos atrás quando brigamos, nem depois quando eu tentei falar com você dia após dia, nem quando eu deixei de te importunar com isso e fiquei te observando de longe e não quer falar agora, então quando, Valentina? Quando você vai voltar a viver e parar de se lamentar por uma coisa que você não tem culpa? – Zack estava cansado de não falar nada por medo de machucá-la, ela já era bem grandinha e estava na hora de agir como tal.
<p>- Eu não sei! - Ela falou, agora com a voz embargada por causa do choro silencioso. - Mas, com certeza, seu rebanho ficar fazendo apostinhas e brincadeiras de mau gosto sobre o baile não ajuda.
<p>- Rebanho? Quer dizer que agora virei pastor e não sabia?
<p>- Não, Animal! – Ela falou limpando as lágrimas do rosto e voltando ao seu tom normal de irritação. - Eles são um monte de animais reunidos, um rebanho, e você é o chefe deles.
<p>- Se você diz! – Ele a soltou de vez e deu de ombros, estava aliviado em pensar que ela falando era um sinal de que talvez ele conseguisse sair dali vivo. – Mas você pode ao menos voltar a frequentar as aulas? Eu, quer dizer a Bri tomou o meu celular e enviou uma mensagem ameaçando o rebanho caso eles continuassem com as implicâncias com você. – Ela olhou surpresa para ele. – Pois é, eu me senti um idiota por não ter percebido o que eles tramavam e não ter tomado providências antes.
<p>O celular dele tocou e ele viu o nome da mãe no visor, atendeu para ver o que ela queria e acabou tendo que ir para casa.
<p>- Eu preciso ir, minha mãe não consegue pegar alguma coisa no alto do armário e meu pai não está em casa ainda. O que seria de vocês baixinhas sem o animal aqui, hein? – Ele sorriu piscando o olho pra Týr que olhava para ele emburrada, mas na verdade estava segurando o riso. Antes de sair ele disse – A gente se vê amanhã na aula ou não, você que sabe.
<p>No dia seguinte, Týr apareceu no final da aula de literatura com o trabalho em mãos, para o alívio de Zack que se lamentava por ter ido embora da casa dela na noite anterior sem nem mesmo começa-lo. Ele tentou falar com ela, mas ela saiu apressada pelos corredores se misturando entre as hordas de estudantes que saiam apressados de suas salas fazendo muito barulho. Realmente são todos uns animais, Zack pensou divertidamente.
<p>Zack não conseguiu achar Týr em meio a multidão e não a viu durante o resto da semana. Por algum motivo que ele desconhecia, mas suspeitava que tivesse a ver com o planejamento da morte dele graças a última conversa que tiveram, a menina havia fechado as persianas da janela de seu quarto impedindo que ele a observasse, por fim o rapaz resolveu relaxar e esperar pelo momento de sua morte iminente.</p>
<center><h4>--*--</h4></center>
<p>O dia do baile de inverno chegou e Brianna estava descontroladamente preocupada, achando que tudo ia sair errado, ela sempre ficava assim antes dos bailes que organizava e eles sempre saiam exatamente como ela planejava, Lýs e Tess passaram o dia com a amiga arrumando os últimos detalhes antes do grande evento. Faltando poucas horas para o baile as duas foram embora e Týr finalmente criou coragem para falar com a irmã.
<p>Brianna se surpreendeu com o pedido que a irmã lhe fez, mas ficou genuinamente feliz ao saber que a surpresa, que ela havia preparado antes que seu plano de juntar Týr e Zack fosse por água abaixo, não seria desperdiçada. Algumas horas depois as duas ouviram Elisa chamar pela filha caçula.
<p>- Filha, você está tão linda! – Elisa falou emocionada ao ver Brianna descer as escadas em um belo vestido preto de seda bordada de um ombro e que se estendia até seu calcanhar.
<p>- Realmente, está muito bonita! – Josh elogiou.
<p>- Obrigada! – Brianna sorriu satisfeita. – Mãe, Josh, eu tenho uma surpresa pra vocês. – Ao dizer isso ela apontou para o topo da escada onde Týr estava parada.
<p>Elisa agora chorava de alegria ao ver seu sonho realizado, as duas filhas prontas para ir ao baile. Týr desceu as escadas para que sua mãe pudesse dar uma olhada melhor nela, seu vestido tomara que caia era azul escuro, combinando com as pontas coloridas de seu cabelo, a parte de cima ficava justa ao corpo se abrindo numa bela saia de seda com babados que iam da cintura até a altura dos joelhos, por baixo da saia Brianna obrigou a irmã a vestir um saiote de tule para dar volume no vestido. A menina não acreditou quando Brianna lhe mostrou o vestido que Lýs e Tess haviam feito, a pedido dela, para Týr, os sapatos pretos de salto eram da irmã, que também a havia ajudado com a maquiagem.
<p>Depois de as duas conseguirem se desvencilhar do abraço emocionado que a mãe havia lhes dado, ouviram a campainha tocar indicando que o par e carona de Brianna para o baile havia chegado.
<p>- Bri, você não me disse quem é o seu... – Týr se surpreendeu ao ver Joe parado à porta de sua casa vestido num belo terno risca de giz e sem os óculos – par. Joe?
<p>- Que bom que resolveu vir, Týr. Não aguentava mais ouvir Brianna resmungar o desperdício que era o seu vestido ficar guardado numa caixa sem nunca ser mostrado ao mundo. – O garoto passou a mão pelos cabelos loiros um pouco nervoso com a situação.
<p>- Eu não resmungo! – Brianna brigou. – E era realmente um desperdício. Agora vamos, já estamos atrasados. – Ela puxou Joe pelo braço enquanto Týr os seguia de perto até o carro do amigo.
<p>A música já tocava quando eles chegaram ao ginásio do colégio, Brianna foi até suas amigas ver se tudo corria bem, deixando Joe e Týr sozinhos. Týr, por sua vez, vasculhava a multidão em busca de Zack.
<p>- Ele está do outro lado, perto da mesa de bebidas. – Joe falou lhe chamando a atenção.
<p>- Quem? – Týr se fez de desentendida.
<p>- O lobo mau, quem mais seria? – Joe respondeu sarcasticamente.
<p>Ela mostrou a língua a ele e foi até onde ele havia apontado, ao chegar perto da mesa de bebidas avistou Zack sozinho recostado em uma coluna de concreto. Respirou fundo tomando coragem e foi até ele, tocou em seu ombro por trás, o assustando.
<p>Zack não podia acreditar no que estava vendo, achava que sua imaginação estava lhe pregando uma peça.
<p>- Como? – Ele tentou entender a situação e Týr balançou a cabeça negativamente revirando os olhos.
<p>- Apenas dance comigo! – Ela respondeu e o puxou para a pista de dança.</p>
</body></html>";
            }

            if (numero == 2)
            {
                lblTitulo.Text = "A Carta";
                htmlPage.Html = @"<html><body>
<p>Existe um momento na vida de todos em que o mundo parece estar suspenso. Você não respira, mas não sente falta de ar. Anda, ainda que não consiga sentir suas pernas. Chora, sorri, grita, sem perceber nenhuma dessas coisas. Esse era um desses momentos na vida de Týr.
<p>Ela estava parada em frente a porta da casa de Zack esperando ele vir atendê-la, depois de ficar imóvel durante vários minutos encarando a correspondência que havia acabado de chegar, endereçada a ela.  
<p>-TÝR! - Zack estalou os dedos em frente a seus olhos
<p>-Ah, oi! - Ela respondeu um pouco confusa.
<p>-Você está bem? Estou falando com você a eras.
<p>-Na verdade... huum... não! - A garota respondeu exibindo a carta que trazia nas mãos.
<p>-Uou! Agora eu entendi! Vai, entra! - Ele deu espaço para ela entrar em sua casa.
<p>Os dois não ficavam cara a cara sozinhos desde o baile, sempre estavam sob os olhares atentos de Brianna e Joe ou de algum companheiro de time de Zack, quando não era isso, era a distância segura da rua que separava suas janelas enquanto eles se falavam por mensagens no celular.
<p>Para ser sincero consigo mesmo, Zack estava de saco cheio das pessoas perguntando se eles estavam namorando e de saco cheio de não ter uma resposta para isso. Quer dizer, eles estavam sempre juntos, ela ia a todos os treinos do time, ele a acompanhava as idas a loja de quadrinhos junto com Joe e uma Brianna muito emburrada. Sem contar as centenas de mensagens que trocavam quando estavam separados.
<p>No entanto, eles não tinham se beijado, ainda que passassem muito tempo abraçados ou de mãos dadas. Havia apenas duas semanas que ela havia lhe deixado voltar para sua vida, Zack não queria estragar as coisas sendo precipitado, principalmente quando a carta da Universidade Julliard, dizendo se Týr havia ou não sido selecionada para as audições da nova turma, estava para chegar a qualquer momento.
<p>E ela havia chegado. Finalmente ele descobriria se os esforços para convencê-la a superar seus medos e voltar a dançar haviam valido à pena.
<p>-Você já abriu? - Ela negou com a cabeça, mordendo o lábio inferior, como sempre faz quando está nervosa, Zack observou. - Vem comigo!
<p>Eles foram até a cozinha, onde Zack preparou alguns sanduíches e pegou a jarra de suco que estava na geladeira. Os dois subiram até o quarto dele, Týr notou que o lugar continuava igual ao das lembranças dela de quando eram crianças e fingiam estar em uma guerra espacial, entre as estrelas e planetas pintadas com tinta fluorescente no teto do quarto dele, que agora descascavam por causa do tempo.
<p>-Acho que elas não brilham mais. - Ela falou olhando para cima.
<p>-O quê? - Ele perguntou virando-se para ela e compreendendo a pergunta ao notar para onde seu olhar estava direcionado. - Não muito!
<p>-É uma pena! Você deveria retocá-las.
<p>-Posso considerar isso depois. Mas agora - o rapaz chamou a atenção dela tocando na carta - nós precisamos abrir essa belezinha aqui e comemorar.
<p>-E se eu não for selecionada?
<p>-Primeiro, não existe chance nesse mundo de você não ser aceita, sua vó puxaria a perna dos diretores à noite pelo resto da eternidade . - Týr deu um sorriso de lado. - Segundo, duvido que alguém consiga dar mais voltas que você sem vomitar o almoço do dia anterior ou ter uma crise de labirintite.
<p>-Fala sério! As garotas que se escrevem parecem robôs, elas praticam vinte e cinco horas por dia.
<p>-Exatamente, elas são como robôs, podem ter a técnica e a prática, mas elas não têm o mais importante, isso aqui. - Zack puxou uma mão dela até o coração e segurou ali, sentindo as batidas descompassadas, pela ansiedade que ela sentia. - Nem toda a prática do mundo vai superar o que você transborda quando está dançando, você faz todo mundo parar para te ver dançar e é isso que me faz ter certeza de que quando você abrir essa carta você vai rir desse medo bobo que está sentindo agora.
<p>-Você acha?
<p>-Eu tenho certeza! Agora abre logo essa carta!
<p>-Tudo bem!
<p>Týr desamassou o envelope que estava em sua mão e começou a abri-lo, suas mãos tremiam de nervoso. Puxou  a folha com o emblema de Julliard de dentro do envelope e começou a ler. Zack observou em silêncio, deixando que ela levasse o tempo necessário, embora estivesse morrendo de curiosidade para saber de uma vez o resultado. Por fim, desistiu de esperar.
<p>-Então? - O garoto perguntou.
<p>-Eu não acredito! - A menina falou, finalmente, com os olhos marejados. - Eu passei! Oh meu Deus, Zack! - Ela começou a rir e chorar ao mesmo tempo. - Eu não acredito, eu passei, e estou entre as concorrentes finais da Julliard.
<p>-É sério? - Zack falou, mais aliviado que ela por ter sido um bom resultado. Ele a abraçou e girou, tirando-a do chão. - Isso é maravilhoso!
<p>Antes que eles pudessem pensar, estavam se beijando e, mais uma vez, um daqueles momentos em que você respira, ri e chora sem saber como, acontecia. O tempo tinha parado para fazer aquele momento durar por horas ou, ao menos, era assim que os dois sentiam.
<p>Quando o beijo acabou eles continuaram abraçados, talvez tentando absorver o que tinha acabado de acontecer, talvez sem se dar conta de que ainda estavam um nos braços do outro, mas o fato é que eles estavam ali, juntos.
<p>Zack foi o responsável por quebrar o silêncio:
<p>-Você precisa contar para sua mãe e sua irmã.
<p>-Ai meu Deus, elas vão fazer um escândalo.
<p>-Ah, com certeza, vão. - Os dois começaram a rir. - Eu me surpreenderia se toda a rua não ficasse sabendo disso nas próximas vinte e quatro horas.
<p>-Não seja ridículo! - Ela deu um tapa no braço dele. - Isso vai acontecer em no máximo quinze horas, não as subestime.
<p>-Ah não! Já estou vendo a Diretora Jones me substituindo no topo da sua pirâmide das celebridades por você.
<p>-Não se preocupe, eu renuncio o posto de escolhida, não tenho vocação para Harry Potter, prefiro ser a Hermione. Ei, por que você está fazendo essa cara?
<p>-Tentando imaginar a Emma Watson vestida só numa camisa masculina do Fall Out Boy e polainas, dançando Gisélle. - Zack respondeu, ainda imaginando a cena.
<p>-Ridículo! - Týr balançou a cabeça fingindo desprezo. - Vamos, preciso contar a minha mãe as novidades e, já que você me fez o favor de lembrar desse detalhe, vai junto.</p>
</body></html>";
            }
        }

        public void clkAbrirComentar(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new EsseMundoView.MyPopupPage("ApenasDance", condicao.ToString()));      
        }

        public void clkIrMenu(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MenusView.MenuApenasDancePage());
        }

        public void clkAbrirProximo(object sender, EventArgs e)
        {
            if (condicao + 1 > 2)
            {
                DisplayAlert("CAPÍTULOS!", "VOCÊ CHEGOU NO ÚLTIMO CAPÍTULO. CONFIRA OUTRA HISTÓRIA", "OK");
            }
            else
            {
                Navigation.PushModalAsync(new CapituloApenasPage(condicao + 1));
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
                    Historia = "ApenasDance"
                }, UserLocalData.userUID, "ApenasDance", "Capitulo" + capitulo);

                if (condicao == 1 && status == "true")
                {
                    var listAsync = await service.mostrarQuantidadeLeituras("ApenasDance");

                    if (listAsync != null)
                    {
                        var contagem = Convert.ToInt32(listAsync.Quantidade);

                        await service.SomarLeituras(new QuantidadeLeituras()
                        {
                            Quantidade = contagem + 1
                        }, "ApenasDance");
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