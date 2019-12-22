
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
	public partial class Capitulo1Page : ContentPage
	{
        DBFire service;
        public int condicao;

        public Capitulo1Page(int numero)
        {
            InitializeComponent();
            service = new DBFire();
            condicao = numero;
            mostrarCapituloSalvo("SegObscuros", "Capitulo" + numero.ToString());

            if (numero == 1)
            {
                lblTitulo.Text = "Capítulo 1 - Recomeços";
                htmlPage.Html = @"<html><body>
<p>Era o primeiro dia de aula.
<p>Os alunos do colégio Carmel em Dallas estavam muito animados. Estava todo mundo conversando e falando sobre as férias. É claro que todos sabiam como tinham sido as férias de todo mundo já que a cidade era pequena, mas ficava sempre melhor quando a pessoa contava.O dia estava lindo e tinha tudo para dar certo, mas havia dois adolescentes naquela escola que não estavam tão felizes assim e nem tão entrosados como deveriam.
<p>Lisa e Jason eram de Los Angeles, mas tinham se mudado para Dallas para morar com os tios da Lisa logo após um incidente na outra escola que causou a expulsão de Jason. Depois do ocorrido, todo mundo se afastou de Jason e então ele resolveu sair da cidade, mas não ia conseguir recomeçar sozinho, por isso Lisa foi com ele, mesmo seus pais não concordando, já que ela se sentia um pouco culpada pelo o que aconteceu com o Jason e além do mais, ele era o seu melhor amigo, ela não conseguiria viver em Los Angeles sem ele.
<p>- Olhe pelo lado positivo, vida nova, escola nova, pessoas novas, cidade nova. – Lisa estava tentando parecer animada para Jason.
<p>Os dois andavam pelos corredores observando tudo. Lisa estava um pouco curiosa, queria saber como tudo funcionava e mal podia esperar para fazer novos amigos, enquanto Jason estava com a cara fechada e olhava tudo com desdém.
<p>- Dallas é uma droga, nem tem praia. – Jason sabia ser pessimista. – Não tem praia, né? - Ele ficou na dúvida, não era muito bom em geografia.
<p>- Não. Mas pelo menos estamos juntos.
<p>- Não sei porque você fez isso. Por que veio comigo? – Jason ainda não conseguia entender a escolha de Lisa.
<p>- Porque mesmo você sendo irritante, cafajeste e a pior pessoa do mundo, você ainda é meu melhor amigo.
<p>- Precisa escolher melhor suas companhias. – Jason fez Lisa rir.
<p>- Esse ano vai ser o melhor. Nem todo mundo tem uma chance de recomeçar. Nós tivemos, vamos aproveitar.
<p>- É uma escola, todas são iguais. Mas algumas garotas são melhores. – Jason olhava para as garotas que passavam por eles no corredor do colégio. – Mas não são bronzeadas.
<p>- Como se isso te impedisse de alguma coisa.
<p>- Tem razão. São garotas. Brancas ou morenas são maravilhosas. Tão perfeitamente perfeitas. – Jason suspirou.
<p>- Cala essa boca e vamos para a sala de aula.</p>
<center><h4>--*--</h4></center>
<p>Havia uma biblioteca muito grande na escola e alguns alunos costumavam ficar lá antes de começar a aula, para terminar trabalhos, adiantar algumas coisas e tal, mas como era o primeiro dia, estava um pouco vazia, a maioria do pessoal estava no pátio. Mas tinha uma garota que gostava de ficar na biblioteca, sentada lendo livros. A mesa onde ela estava havia vários livros e ela parecia muito interessada no que estava lendo.
<p>- O que você está fazendo aqui? A aula já vai começar. – Um garoto se sentou ao lado dela.
<p>- Eu tenho relógio, eu sei que hora começa a aula. – Ela nem olhou para o garoto.
<p>- Só tentei ser legal. – Ele ficou envergonhado.
<p>- Não, você está tentando puxar conversa mesmo depois de levar foras de todas as maneiras, Toddy. – Agora ela já havia fechado o livro.
<p>- Você não me diz porque nunca quis ficar comigo. – Ele parecia ter essa dúvida há muito tempo.
<p>- Se olhe no espelho e se escute. Já tenho a minha razão para não ficar com você.
<p>- Temperance! – Outro garoto gritou vindo em direção dos dois. – Vamos para a aula.
<p>- Bran, não se pode gritar na biblioteca. – Tempe começou a pegar os livros e a guardar nas prateleiras.
<p>- Me desculpa, mas não tem ninguém aqui para brigar comigo. – Bran soltou uma risadinha.
<p>- Não importa, eu brigo por eles. – Tempe olhou de cara feia pra Bran.
<p>- Já pedi desculpas, agora vamos?
<p>- Vamos, não posso chegar atrasada. – Ela sorriu para o Bran.
<p>Tempe deixou Toddy falando sozinho e saiu da biblioteca com Bran.</p>
<center><h4>--*--</h4></center>
<p>A aula literatura estava bem monótona. Jason revirava os olhos, se mexia de um lado para o outro na cadeira e sua falta de paciência já estava ficando bem clara para todos.
<p>- Ai, que sono. – Jason resmungou baixinho para Lisa que estava do lado dele. – Você não está com sono?
<p>- Cala a boca, eu estou tentando escutar. – Lisa cochichou.
<p>- Eu queria não poder escutar.
<p>- Está tudo bem, senhor...? – O professor ouviu o falatório de Jason.
<p>- Jason, meu nome é Jason. – Ele sorriu. – E não me chama de senhor, por favor, vai parecer que eu tenho cem anos de idade.
<p>- Anotado.
<p>- Muito obrigado. Muito gentil da sua parte atender meu pedido.
<p>- Cala a boca, Jay. – Lisa sussurrou irritada para o amigo.
<p>- Disponha. – O professor entrou na brincadeira e dava para ouvir uns risinhos disfarçados pela sala toda. – Bom, depois da apresentação do Jason, o novo aluno, vamos começar os trabalhos.
<p>- Na primeira aula? – Jason não conseguiu disfarçar o espanto.
<p>- Ai, meu Deus. – Lisa escondeu o rosto com as mãos.
<p>- Sim, assim você perde o sono. – O professor riu para ele.
<p>- Ótima ideia. – Na verdade, não era uma ótima ideia para o Jason. – Mas eu tenho outras ideias que seriam melhores e...
<p>- Até o fim da semana, vocês vão formar duplas e escolher uma obra literária inglesa para apresentar aqui na frente de todos
<p>- Que maravilha! Não acredito nisso! Logo agora?! – Os alunos começaram a reclamar.
<p>- Parem, pessoal. Assim vocês se conhecem melhor. Eu vou até escolher as duplas.
<p>- Do jeito que ele está me odiando agora, vai me colocar com a pior pessoa da sala. – Jason cochichou para Lisa.
<p>- O nosso querido Jason vai fazer o trabalho com a Temperance.
<p>- Tempero? Como é que é? – Jason não tinha prestado muita atenção.
<p>- Sou eu. – Temperance disse do fundo da sala e Jason olhou para trás.
<p>- Pelo menos é bonitinha. – Jason comentou para Lisa.
<p>Lisa olhou feio para Jason.</p>
<center><h4>--*--</h4></center>
<p>- Aquele professor está pegando no meu pé. – Jason não parava de reclamar para a Lisa sobre o professor de literatura no almoço.
<p>- Você falou mal da aula dele. O que você queria? – Lisa como sempre tinha que ouvir os dramas de Jason.
<p>- Que ele risse. Estão falando que me colocaram para fazer dupla com a maior nerd da sala.
<p>- Qual é o problema?
<p>- O problema é que ela é nerd. Ela vai ficar toda controladora fazendo o trabalho e depois vai me dar um fora porque nerds são frescurentas.
<p>- É o nosso primeiro dia de aula e você já está pensando em namorar? – Lisa estava indignada.
<p>- Sempre.
<p>- Oi, me desculpem. – Um garoto se aproximou da mesa dos dois no refeitório interrompendo a conversa.
<p>- Pois não? – Jason olhou desconfiado.
<p>- Eu sou o Brandon. – Ele olhou pra Lisa. – Vamos ser parceiros no trabalho de literatura.
<p>- Ah, claro, eu sei. Eu sou Lisa. – Lisa foi simpática.
<p>- Eu só queria saber como vamos fazer isso? – Brandon parecia nervoso.
<p>- Ah, a gente pode se encontrar depois da aula na biblioteca.
<p>- Você vai se encontrar sozinha com um estranho? – Jason era muito sutil.
<p>- Jason! – Lisa olhou de cara feia para ele. – Não liga, não, Brandon. Ele não pensa no que fala. Na verdade, ele nunca pensa.
<p>- Tudo bem. A gente se vê então. – Brandon ignorou Jason.
<p>- Claro. – Lisa sorriu.
<p>- E... pode me chamar de Bran.
<p>- Até mais, Bran.
<p>- Bran? – Jason esperou Brandon ir embora para comentar. – E eu que achei que a nerd era a pior escolha. Você ficou com o cabeludo. – Jason começou a gargalhar.
<p>- Cala a boca, imbecil, ele parece ser legal.
<p>- Você nem conhece ele. – Jason a repreendeu.
<p>- E nem você. Não o julgue.
<p>- Tudo bem. – Jason se conformou.
<p>- Vamos para aula.
<p>- Ah, eu acho que vou matar essa. Quem liga pra História? – Jason sabia que Lisa ia ficar brava.
<p>- Matar aula? Mas já? – Lisa ficou surpresa.
<p>- É o primeiro dia. – Jason falou como se isso fosse alguma desculpa.
<p>- O que você vai fazer para ter que matar aula?
<p>- Eu conheci uma garota e a gente vai dar uma volta. – Jason estava animado.
<p>- O quê? Mas que horas você conheceu ela? Ficamos juntos o tempo todo. – Lisa ficou sem entender.
<p>- Então, eu estava saindo do banheiro, e de repente ela estava me encarando com aquele olhar de “eu te quero”, até olhei para baixo pensando que meu zíper estava aberto.
<p>- Merece palmas. – Lisa foi irônica.
<p>- Muito obrigado. – Jason não entendeu a ironia.
<p>- Quer dizer que você vai embora e eu vou ter que ficar sozinha?
<p>- A culpa é sua, você sempre é toda certinha e não gosta de matar aula.
<p>- Tudo bem, mas dessa vez eu vou matar também. – Lisa estava decidida.
<p>- Não, dessa vez você não vai. – Jason cortou o barato da amiga.
<p>- Por quê?
<p>- Porque eu vou sair com a Jessica, esse é o nome da garota que eu conheci, eu acho, e se você ir junto, vai meio que ficar de fora.
<p>- Você está me dando um fora?
<p>- Você me deu um fora primeiro, gata. – Jason beijou o rosto de Lisa, pegou sua bandeja do almoço e saiu do refeitório.
<p>- Idiota!</p>
<center><h4>--*--</h4></center>
<p>Lisa estava sentada em uma das mesas na biblioteca esperando por Brandon.
<p>- Oi, eu demorei? – Brandon chegou parecendo que estava sem fôlego. Ele tinha corrido.
<p>- Não, que nada. Eu que gosto de chegar cedo.
<p>- Uma garota chegando cedo? Isso é novidade. – Brandon estava encantado.
<p>- Bom, vamos começar. – Lisa tentou disfarçar que ficou sem graça. – Eu tenho algumas ideias.
<p>- Que legal, você gosta de ler?
<p>- Eu adoro. Quando o Jason não está me irritando que é quase sempre, eu leio.
<p>- Vocês são namorados? – Brandon precisava saber.
<p>- Não, somos só amigos. A gente já se conhece há muito tempo.
<p>- Eu também tenho uma amiga, crescemos juntos.
<p>- É legal crescer aqui?
<p>- É normal. Você veio de onde? Nunca te vi por aqui.
<p>- Los Angeles.
<p>- E por que foi embora de lá? Ouvi dizer que Los Angeles é praticamente um paraíso. – Brandon não falava com uma garota a não ser Temperance fazia muito tempo. Ele estava muito ansioso para saber tudo sobre a Lisa.
<p>- É uma longa história, deixa para outro dia, além do mais, Jason e eu nos mudamos para refazer a vida e começar do zero.
<p>- Isso é bom.
<p>- Eu espero que seja. Bom, vamos estudar.
<p>- Se você insiste. Mas eu preferia ficar aqui jogando conversa fora com você. Muito mais agradável.
<p>- Para, está me deixando sem graça. – Lisa sorriu. – Mas foi fofo.</p>
<center><h4>--*--</h4></center>
<p>- Tudo bem, vamos jogar a real, vamos fazer o trabalho juntos, mas não se apaixone por mim. – Temperance foi bem direta com Jason. Os dois estavam em uma das mesas que ficavam no meio do pátio para os alunos estudarem.
<p>- Entendi, afinal não estamos em um romance do Nicholas Sparks. Eu já sabia que nerds não curtem a vida. – Jason não fez um grande caso, mas não podia perder a oportunidade de brincar com a garota.
<p>- Cala essa boca. Só quero tirar uma nota boa, então não jogue a sua ignorância no trabalho.
<p>- Entendido, chefe. – Jason se largou na cadeira logo depois de fazer um sinal de soldado na testa.
<p>- Olha, vamos fazer uma obra bem impactante, tipo...
<p>- Eu tenho uma ideia.
<p>- Não vamos fazer <i>Romeu e Julieta</i>. - Temperance já revirou os olhos.
<p>- Eu não ia dizer isso.
<p>- Ia sim. Garotos como você só conhecem essa história. – Temperance foi arrogante.
<p>- Eu ia dizer <i>Sonhos de Uma Noite de Verão</i>.
<p>- Você já leu essa peça? – Ela até ficou impressionada.
<p>- Não. – O encanto dela acabou. – Mas a Lisa já, e ela sempre me conta os resumos. Tem uns que são tão chatos que eu finjo que escuto.
<p>- Típico. Vamos começar logo. Quanto mais rápido começarmos...
<p>- Mais rápido terminamos e eu vou embora. – Jason não queria ficar ali tanto quanto Temperance, então não se importou com a ignorância da garota.
<p>Jason começou a dar opiniões sobre o projeto porque não queria parecer um inútil, mas com o passar do tempo ele percebeu que enquanto falava, Temperance ficava no celular digitando.
<p>- Podemos voltar ao trabalho ou você está muito ocupada? – Jason ficou inconformado.
<p>- Me desculpa, eu estava comentando algumas coisas.
<p>- No trailer de <i>Guerra nas Estrelas</i>?
<p>- Claro que não. Estava conversando com o meu amigo Brandon, ele me mandou um link de uma notícia que saiu no blog da escola.
<p>- Blog?
<p>- São páginas da internet onde regularmente são publicados diversos conteúdos, como textos, imagens, músicas ou vídeos, tanto podendo ser dedicados a um assunto específico como ser algo geral. – Temperance começou a dar uma aula.
<p>- Eu sei o que é um blog.
<p>- Então...
<p>- Eu estou perguntando qual blog.
<p>- Tem um blog que todo mundo da escola visita, alguém escreve anonimamente sobre todo mundo.
<p>Temperance entregou seu celular para Jason e ele começou a ver as fofocas do blog falando sobre os mais populares da escola.
<p>- Já falaram de você aqui? – Jason estava lendo tudo.
<p>- Sou invisível demais para aparecer em um blog assim. – Temperance não tinha vergonha disso.
<p>- Por que alguém faria isso?
<p>- Por diversão, eu acho.
<p>- Quem escreve essas coisas?
<p>- Não sabe o que anônimo significa? Ninguém sabe quem escreve.
<p>- E ninguém tenta descobrir? – Ele não conseguia acreditar naquilo.
<p>- Não, porque todo mundo quer saber as sujeiras dos outros.
<p>- Faz sentido. – Jason continuou olhando as notícias do blog.
<p>- Podemos continuar com o trabalho agora?
<p>- Claro, só... – Então ele parou de falar e começou a ler. – Eu não acredito nisso.
<p>- O que foi?
<p>- Estão falando de mim aqui. – E de repente o rosto de Jason transparecia a raiva que ele estava sentindo. – Mas que droga.
<p>- O que estão falando de você?
<p>Jason estava chocado demais para responder.</p>
<center><h4>--*--</h4></center>
<p>- Você acredita nisso? – Naquela noite Jason estava muito estressado. Ele e Lisa ficaram trancados no quarto e nem desceram para jantar.
<p>- Existe um blog na escola? – Nem Lisa acreditava.
<p>- Exato. E falam de tudo. Da líder de torcida que traiu o namorado para tirar dez na prova de Geografia, do garoto popular que estava no armário, mas foi obrigado a sair depois dessa notícia. Falam de tudo. Esse blog serve para destruir a vida das pessoas naquela escola.
<p>Jason colocou a página do blog no celular dele e deu pra Lisa ver.
<p>- “Tesouro de Segredos Obscuros”? – Lisa começou a ler o blog.
<p>- Bem cafona, né?
<p>- É inacreditável como todo mundo aceita isso.
<p>- Parece que a fofoca é mais importante que o fofoqueiro.
<p>- Mas por que você está tão bravo? – Lisa ainda tinha a dúvida.
<p>- Porque o infeliz escreveu sobre mim. A última postagem dele foi sobre mim.
<p>- Ai meu Deus. – Lisa começou a ler a notícia sobre Jason e ficou espantada. – Tem câmeras na escola? Como essa pessoa sabe de tudo isso?
<p>- Eu ainda não sei, mas eu vou descobrir.
<p>- Jason, não se mete em encrenca.
<p>- Não vai ser encrenca, eu só vou desmascarar o imbecil e depois disso vou bater muito na cara dele.
<p>- Isso é encrenca.
<p>- Então vamos ter encrenca.</p>
<br>
<p><i>“<b>CUIDADO GAROTAS DO COLÉGIO CARMEL, O GARANHÃO ESTÁ NO PEDAÇO:</b> Depois de destruir todos os corações de Los Angeles, Jason Porter está em Dallas para fazer o mesmo estrago. Parece que o sucesso dele vai ser a maldição dos outros já que ele não vai deixar uma garota viva depois do seu arrastão de corações. Fujam se não quiserem entrar nessa viagem sem volta, e garotos, vocês também precisam ter cuidado, não deixem suas garotas sozinhas, senão elas podem acabar se rendendo a doença Jason e se infectar. <b>VAMOS TOMAR VACINA CONTRA ISSO, PESSOAL, PORQUE PODE SER MORTAL.</b>”.</i> – Tesouro de Segredos Obscuros.</p>
</body></html>";
            }

            if (numero == 2)
            {
                lblTitulo.Text = "Capítulo 2 - Raiva";
                htmlPage.Html = @"<html><body>
<p>Raiva, aquele sentimento de... Bom, todo mundo sabe o que é raiva, e era isso que o Jason estava sentindo naquele momento.
<p>Pessoas apontando, falando pelas costas, cochichando e lendo o blog, foi assim que Jason passou seu segundo dia de aula.
<p>- Será que dava para você largar esse celular pelo menos para comer? – Lisa encontrou Jason na hora do almoço. Em uma mão o garfo, na outra, o celular.
<p>- Eu não posso. Preciso ser o primeiro a saber o que o blogueiro vai falar de mim.
<p>- No que isso vai ajudar? – Lisa pegou o celular da mão de Jason à força.
<p>- Preciso estar preparado.
<p>- Você é paranoico.
<p>- Eu não sou paranoico.
<p>- Olá! – Uma garota sorrindo se aproximou deles.
<p>- O que falaram de mim no blog? – Jason virou para a menina assustado. – Talvez eu seja um pouco paranoico. – Jason olhou para Lisa concordando com ela.
<p>- Eu não sei, eu não leio essa porcaria. – Ela continuava sorrindo.
<p>- Podia espalhar essa moda pela escola?
<p>- Mas é claro.
<p>- Não. – Jason olhou bem para ela. – Você não me parece muito popular.
<p>- Jason! – Lisa sempre repreendia Jason quando ele não sabia esconder seus comentários. – Oi, eu sou Lisa. – Lisa estendeu a mão para a garota. – E esse é o Jason.
<p>- Eu sou a Maddie, vim dar as boas-vindas para vocês. E espero que adorem nossa escola. – Ela parecia ser animada.
<p>- Como vamos adorar se está todo mundo falando mal de mim?
<p>- Para. – Lisa olhou feio para Jason.
<p>- Faça como eu, não ligue. Depois passa.
<p>- Você tem cara de que não precisam de um blog para falarem mal de você. – Jason olhou para Lisa que estava brava. – Mas isso é só um julgamento à primeira vista, afinal o que eu sei, não é?
<p>- Eu não me importo com o que os outros falam. – Maddie não parecia atingida pelos comentários de Jason.
<p>- Bom para você. – Jason não estava animado.
<p>- Maddie, onde você mora? – Lisa tentou puxar conversa.
<p>- Em uma fazenda aqui perto.
<p>- Fazenda? Tipo com vacas? – Jason estranhou.
<p>- Sim, qual é o problema?
<p>- Nenhum. – Jason tentou disfarçar, mas não conseguiu.
<p>- Um dia, eu vou me casar e meu marido e eu vamos amar morar lá.
<p>- Querida, isso aqui não é novela nem série de TV. Quem vai querer morar perto de vacas?
<p>- Jason! – Lisa já estava perdendo a paciência. – Não liga para ele, Maddie, ele não está pensando direito.
<p>- Tudo bem, não me importo. Parece que ele merece ser chamado de tudo o que o blog chamou ele, no final das contas. – Maddie sorriu e Lisa começou a rir sem parar.
<p>- Você não deveria rir, Lisa. – Jason olhou feio para a amiga.
<p>- Mas eu estou rindo.</p>
<center><h4>--*--</h4></center>
<p>Temperance estava falando das ideias do trabalho para Jason quando se encontraram nos corredores naquele dia, mas ele não estava prestando muita atenção.
<p>- ... E aí vai ficar perfeito. – Ela estava animada.
<p>- É, vai mesmo. – Ele respondeu depois que ela terminou.
<p>- Você nem prestou atenção. – Ela o repreendeu.
<p>- Me desculpa, mas olha só para as pessoas.
<p>Temperance deu uma olhada ao redor. Estava todo mundo olhando, apontando e rindo, não era paranoia do garoto.
<p>- Relaxa, isso vai passar. – Pela primeira vez, Temperance foi gentil.
<p>- Está falando isso porque não falaram de você.
<p>- Não devia se importar com o que os outros falam, principalmente alguém que não tem coragem de falar na sua cara.
<p>- É, eu sei, mas eu me importo. Eu finjo que não estou nem aí, mas eu faço de tudo para agradar todo mundo. Não acredito que falei isso para você.
<p>- Isso nunca vai dar certo. – Temperance achou estranho.
<p>- Estava dando até agora.
<p>- Eu duvido, aliás você teve que mudar de estado, não é?
<p>- Isso não tem nada a ver.
<p>- Olha, relaxa, tá bom? Foque nos estudos e tudo vai dar certo.
<p>- Para você, tudo é estudar? Ter uma vida às vezes é bom.
<p>- É impossível ajudar você.
<p>- Olha, foi mal. – Jason realmente se sentiu mal.
<p>Mas Temperance saiu andando deixando Jason falando sozinho.</p>
<center><h4>--*--</h4></center>
<p>- Você parece meio distraída hoje. – Brandon percebeu que Lisa não estava normal quando se encontraram para terminar o trabalho de literatura na biblioteca naquela tarde.
<p>- Eu estou bem, eu só estou um pouco preocupada com o Jason.
<p>- Por quê? – Brandon não lia o blog?
<p>- Ele está muito irritado com o que as pessoas estão dizendo e ele é bem esquentadinho. Tenho medo que ele faça alguma besteira.
<p>- Tipo bater em alguém?
<p>- Não seria a primeira nem a última pessoa que ele bateria, e além do mais ele está decidido a descobrir quem é essa pessoa, não sei o que pode acontecer se ele descobrir. – Lisa parecia mesmo bem preocupada.
<p>- Se você quiser, eu posso ir falar com ele, tentar colocar um pouco de juízo na cabeça dele.
<p>- Não precisa, até porque vocês mal se conhecem.
<p>- Mas eu posso ajudar e dá para ver que isso está mexendo com você. Se eu conseguir fazer ele mudar de ideia, você vai ficar bem. – Brandon insistiu.
<p>- Faria isso por mim?
<p>- Mas é claro. – Ele sorriu.
<p>- Bran, você é um fofo. Muito obrigada.
<p>- Bom, agora vamos parar de falar no Jason.
<p>- E falar no trabalho?
<p>- Eu preferiria outro assunto.
<p>- Qual? – Lisa ficou curiosa.
<p>- Você. Esse é o melhor assunto.
<p>- Para. – Lisa ficou envergonhada.
<p>- É sério. Eu quero te conhecer melhor e você também pode perguntar qualquer coisa sobre mim.
<p>- Tudo bem, vamos para a primeira pergunta: Você é fofo assim com todo mundo? – Lisa brincou fingindo que sua mão fechada era um microfone.
<p>- Não. Só com quem vale a pena.</p>
<center><h4>--*--</h4></center>
<p>- “Só com quem vale a pena”? – Lisa estava contando a conversa que teve com o Brandon para o Jason no quarto dele depois do jantar. – Essa foi a cantada mais barata que eu já ouvi.
<p>- Não foi uma cantada, ele estava sendo legal. – Lisa defendeu Brandon.
<p>- Sim, para poder te conquistar. Geralmente é assim que as cantadas funcionam.
<p>- Deixa de ser chato, tá bom? – Lisa já estava começando a se arrepender de ter contado aquilo para Jason.
<p>- Eu só estou falando para você tomar cuidado. – Jason às vezes era protetor.
<p>- Olha quem fala. Quem foi que um dia chegou em mim todo bonzinho?
<p>- Certo e eu fiz isso para te conquistar, por isso eu sei que ele está fazendo o mesmo. O meu ponto acabou de ser provado.
<p>- Nem todo mundo é como você.
<p>- Por isso que você me deu um fora e vai dar uma chance para ele? – Jason brincou. – O seu tipo de cara é os estranhos de cabelo enrolado? – Jason riu.
<p>- Cala essa boca. – Lisa riu junto. – A gente só está se conhecendo.
<p>- Olha, eu conheço esse tipo, tá bom? Que se faz de santo e romântico. No terceiro encontro, já vai querer que você tire a blusa.
<p>- Lógico, porque é isso que eu vou fazer. – Lisa foi irônica.
<p>- Vai por mim, eu sei o que eu digo. Os sonsos e coitadinhos são os piores. – Jason falou rindo.
<p>- Você está muito mais legal do que hoje de manhã. – Lisa tentou mudar de assunto.
<p>- É que eu estou tentando esquecer o meu problema, por isso estou mais focado no seu relacionamento com o Cabeça de Vassoura.
<p>- Eu não tenho um relacionamento com ele, e se você chamar ele de Cabeça de Vassoura de novo, eu vou te bater.
<p>- Cabeça de Vassoura. – Lisa deu um tapa de leve na cara de Jason. – Ai, doeu!
<p>- Eu avisei. – Lisa começou a rir. – Não sei medir minha força.
<p>- Muito engraçadinha você.
<p>- Quando vai começar a sua tarefa “Descobrindo o blogueiro da escola”?
<p>- Logo, já montei até a lista dos suspeitos.
<p>- E quem está na lista? – Lisa estava achando Jason louco demais.
<p>- Todos os garotos da escola.
<p>- Garotos? Eu acho que garotas escrevem mais em blogs do que garotos.
<p>- É, mas nenhuma garota falaria mal de mim, eu sou o tal. – Jason tinha um ego enorme, e Lisa sabia disso, por isso nem se importou quando ele disse isso.
<p>- Mas é claro que é. E quanto as garotas que você dispensou?
<p>- Eu nunca dispensei ninguém, e além do mais, nem deu tempo de namorar muito aqui.
<p>- E quanto aquela garota de ontem?
<p>- A Julia?
<p>- Achei que fosse Jessica.
<p>- Isso, Jessica. Está certo. Olha, a gente mal conversou, as nossas bocas ficaram muito ocupadas, se é que você me entende. – Jason deu “aquele” sorriso.
<p>- Eu não precisava saber disso. – Lisa fez sua cara de nojo. – Por que me conta essas coisas? Eu sou uma garota.
<p>- Para ver você ficar com ciúmes e correr atrás de mim.
<p>- Claro, porque isso me passa pela cabeça toda a hora.
<p>- Também te amo. – Jason fez bico para receber um beijo.
<p>- Sai daqui. - Ela o empurrou para longe.</p>
<center><h4>--*--</h4></center>
<p>- E como está indo o trabalho? – Brandon e Temperance estavam almoçando juntos.
<p>- Ah, está indo bem, eu vou me encontrar com o Jason daqui a pouco para terminar, mesmo eu sabendo que ele não vai fazer nada e só vai ficar falando coisas estranhas. – Temperance riu.
<p>- Acha bom ficar passando muito tempo com ele?
<p>- Não entendi. O que tem ele?
<p>- As pessoas estão comentando. Você viu o que saiu no blog. – Brandon parecia preocupado com a amiga.
<p>- Eu não me importo com essas coisas e as pessoas não vão falar sobre mim.
<p>- A Lisa e eu estávamos conversando e eu me ofereci para conversar com ele e deixar ele mais calmo.
<p>- E por que você faria isso? O cara é um chato.
<p>- Mas é amigo da Lisa.
<p>- E você está tentando conquistar ela que eu sei.
<p>- Não tem nada a ver, só estou tentando ser legal.
<p>- Sem nenhuma segunda intenção?
<p>- Exato.
<p>- Você é um garoto, todo garoto tem segunda intenção. – Temperance olhou feio para Brandon.
<p>- Não generalize. Não é como se eu desse em cima de toda garota da escola.
<p>- Você está a fim dela, não tem como negar.
<p>- Tudo bem, eu admito. – Brandon não iria conseguir fugir de Temperance. – Se eu falar com o Jason, vou conseguir pontos com ela.
<p>- Ela te pegou de jeito, não foi? – Temperance riu.
<p>- Ela me chamou atenção. Eu não sei explicar.
<p>- Essa tal Lisa é muito bonita. – Ela reconheceu.
<p>- Ela é sim, e quando sorri... – Brandon ficou com cara de bobo.
<p>- Ai, sai. Tudo o que eu não preciso agora é de um amigo apaixonado. – Temperance se irritou.
<p>- Você também deveria ficar apaixonada se não desse um fora em todo mundo que chega perto de você.
<p>- Prefiro ficar sozinha do que mal acompanhada. Estou feliz assim.
<p>- Não acredito, mas tudo bem. – Brandon sempre voltava nesse assunto.
<p>- Acredite no que quiser, mas eu não vou ficar com alguém só por desespero. Tenho amor próprio.
<p>- Não vai demorar muito até começarem a comentar sobre você e o Jason.
<p>- Seria ridículo. A gente só está fazendo um trabalho. Ele é bonitinho, mas não. – Temperance não estava interessada.
<p>- Só toma cuidado.
<p>- Isso serve para você também. Não quero você chorando quando a Lisa te der um fora.
<p>- Espero que isso não aconteça.
<p>- Vocês se conhecem há dois dias, por que essa babação toda?
<p>- Se você fosse um garoto e conhecesse a Lisa, também iria babar.</p>
<center><h4>--*--</h4></center>
<p>- Por que garotos babam por garotas? – Jason se surpreendeu quando Temperance fez essa pergunta para ele enquanto estavam terminando o trabalho na biblioteca.
<p>- Porque somos héteros. Senão babaríamos por outros garotos. Alguns babam.
<p>- Nossa, que profundo. – Temperance se decepcionou.
<p>- O que quer que eu responda? Por causa do cheiro, dos peitos, da...
<p>- Para, eu já entendi. Depois eu procuro alguém mais profundo e sensível que você, talvez um garoto de dez anos.
<p>- Faça isso. – Jason fingiu que ligava enquanto mexia no celular.
<p>- Que tanto mexe nessa droga? Devíamos terminar logo o trabalho para eu nunca mais poder olhar para sua cara.
<p>- Eu estou vendo se o blogueiro imbecil falou mal de mim de novo.
<p>- Ai, ainda está nessa? Supera isso. Você é pior que um ex-namorado grudento.
<p>- Como se você soubesse o que é ter um ex-namorado.
<p>- Eu prefiro não responder.
<p>- Já sei a resposta. – Jason continuou implicando.
<p>- Você tem algum suspeito? – Temperance tentou mudar de assunto. – Para o “blogueiro”?
<p>- É um cara, eu tenho certeza.
<p>- Por que acha isso?
<p>- E com certeza, deve ser um cara estranho que se tranca no quarto e joga vídeo game o dia todo.
<p>- Ele parece ser interessante, preciso conhece-lo.
<p>- Ou essa pessoa pode ser alguém que não goste de mim.
<p>- Tudo bem, a gente conversou, foi legal, podemos voltar de novo para o trabalho?
<p>- O blogueiro é você. – Jason parecia chocado.
<p>- O quê? – Temperance começou a rir. – Você está maluco? Eu não sou garoto.
<p>- Você me mostrou o blog e disse que nunca tinham falando de você lá. É claro, você não ia falar de você mesma. Estava na minha cara e eu não tinha sacado. Por que fez isso?
<p>- Eu não fiz nada. Você está delirando.
<p>- Então é alguém que você conhece, porque está te poupando.
<p>- Ninguém nunca escreveu de mim porque... – Temperance ia explicar.
<p>- Até agora. – Jason estava olhando para o celular bem surpreso.
<p>- O quê?
<p>- Ninguém nunca escreveu de você até agora. Porque acabaram de fazer isso agora.</p>
<br>
<p><i>“<b>SÓ PARA COMPROVAR OS FATOS:</b> e eu que achava que o tipo do Jason era aquelas garotas vadias que davam em cima de todos, mas na verdade, para o meu espanto e para espanto de todos, ele gosta mesmo é das reservadas, e já temos o nome da vítima: <b>TEMPERANCE GRANGER.</b> É isso mesmo pessoal, já sabemos que ele vai tirar nota dez o ano todo. Enquanto isso, todos os garotos que já tentaram pelo menos roubar um beijo da nossa querida Tempe devem estar chorando nesse momento. Sinto muito, garotos, vocês ainda têm muito o que aprender com o nosso herói, Jason.”.</i> – Tesouro de Segredos Obscuros.</p>
</body></html>";
            }

            if (numero == 3)
            {
                lblTitulo.Text = "Capítulo 3 - Distração";
                htmlPage.Html = @"<html><body>
<p>Aquela semana não estava sendo fácil para Jason, e agora graças ao blogueiro, nem para Temperance.
<p>- Será que eu tenho que dizer “eu te avisei”? – Brandon e Temperance estavam discutindo sobre o novo post do blogueiro no meio de um dos corredores da escola.
<p>- Não, eu não previ isso. – Temperance estava chateada.
<p>- Mas eu sim. Talvez devesse se afastar desse cara um pouco.
<p>- Brandon, eu não posso deixar de falar com uma pessoa só porque resolveram falar mal de mim por causa dessa pessoa.
<p>- O Jason é tão importante assim que não dá para se afastar?
<p>- Não é isso, ele pode ser um pé no saco, mas nunca me fez mal nenhum e tirando os comentários ruins, ele nunca me tratou mal.
<p>- É, mas agora está todo mundo associando você a ele. – Brandon parecia preocupado.
<p>- Pessoas idiotas que leem blogs idiotas.
<p>- Quer dizer que você não liga?
<p>- Não.
<p>- Eu duvido, você nunca gostou de ser o centro das atenções, e agora você é.
<p>- Não é para tanto.
<p>- É sim, sabe como falavam do Jason, agora vão falar de você.
<p>- Olha... – Tempe queria retrucar, mas sabia que Brandon tinha razão.</p>
<center><h4>--*--</h4></center>
<p>- Quer dizer que agora todo mundo acha que você e a Temperance estão ficando? – Lisa estava quase rindo.
<p>Ela e Jason estavam caminhando de volta para casa depois da aula, foi a única oportunidade que tiveram de ficar juntos naquele dia.
<p>- Seria engraçado se não fosse trágico. – Jason não estava nada contente com aquele post. Pior do que falar dele, é falar mal de alguém por causa dele.
<p>- As pessoas têm noção de como ela trata você?
<p>- Não, elas só sabem o que o blogueiro fala. Odeio ele.
<p>- Bom, você fez com que falassem da Temperance pela primeira vez. Deveria se orgulhar.
<p>- É, agora ela deve me odiar.
<p>- E você se importa? Achei que também não gostasse dela. – Lisa ficou confusa.
<p>- É, mas já está sendo difícil arranjar amigos, e assim que o seu lance com o Cabelo Encaracolado ficar sério, eu meio que vou ficar sozinho por aqui.
<p>- Não é assim, além do mais, deve existir pessoas que não ligam para o blog.
<p>- É, tipo a garota das vacas. Prefiro ficar sozinho.
<p>- Mas eu não entendo, na outra escola você adorava ser o centro das atenções.
<p>- Lá era diferente, eu me vangloriava, ninguém falava mal de mim.
<p>- Você que pensa, só não falavam alto.
<p>- O que meus ouvidos não ouviam, eu não sabia.
<p>- Olha, eu queria te ajudar, mas não sei como.
<p>- Fica longe de mim.
<p>- O quê? Por quê? – Lisa ficou surpresa.
<p>- Senão vão começar a falar de você também.
<p>- Querido, não vai se livrar de mim tão fácil.
<p>- Que fofo, agora me dá um beijo. – Jason fez bico.
<p>- Ainda não. – Lisa começou a rir.</p>
<center><h4>--*--</h4></center>
<p>Em todo lugar da escola que Temperance passava, ela sentia como se todo mundo apontasse para ela. Brandon tinha razão, o pior pesadelo dela estava acontecendo.
<p>- Temperance, oi. – Maddie se aproximou dela.
<p>- Oi, Maddie.
<p>- Olha, eu só quero dizer que eu estou do seu lado. – Maddie sorriu.
<p>- Valeu.
<p>- É, até porque vai ser super mágico quando você conseguir mudar a personalidade do Jason e vocês viverem felizes para sempre.
<p>- Olha só, querida. – Temperance tentou ser educada, mas estava difícil. – Jason e eu não estamos juntos. Desculpa, mas eu ainda não estou completamente louca.
<p>- Sério? – Maddie parecia decepcionada. – Vocês formam um lindo casal.
<p>- Garota, você está bêbada? Eu nunca ficaria com o Jason. – Temperance quase gritou.
<p>- Ah, isso é muito bom. – Um garoto entrou no meio da conversa das duas.
<p>- Quem é você? – Temperance olhou para o garoto sem entender nada.
<p>- Seu novo namorado.
<p>- Nem daqui um milhão de anos. – Temperance já estava tão acostumada a dar foras que já saia naturalmente.
<p>- Já entendi, você prefere os galinhas. - O cara ficou bravo.
<p>- Não, eu prefiro alguém que tenha cérebro. Algo que nenhum de vocês têm.
<p>- Espero que morra solitária. – O garoto se magoou.
<p>- E espero que engravide alguém na adolescência. – Temperance não se atingiu.
<p>- Não precisava ter falado com o garoto daquele jeito. – Maddie olhou assustada para Temperance assim que o garoto foi embora.
<p>- Precisava, sim.
<p>- Você me assusta às vezes.
<p>- Me desculpa se o mundo não é um conto de fadas.
<p>- Tempe! Oi! – Antes de Maddie responder, Jason chegou gritando o nome de Temperance.
<p>- Não me chame mais de Tempe. – Ela olhou feio para Jason.
<p>- Te chamo como então? Tem? Amiga do encaracolado? Vassoura 2?
<p>- Não fala assim dela. – Maddie entrou na conversa.
<p>- Você não tem leite para tirar de alguma vaca, não? Sai daqui.
<p>- Jason! – Temperance até parecia a Lisa repreendendo o Jason.
<p>- Eu já vou. – Maddie ficou brava.
<p>- Tchau, tchau. – Jason se despediu enquanto Maddie ia embora.
<p>- O que você quer? – Temperance estava séria.
<p>- Você está com raiva de mim?
<p>- Não.
<p>- Ótimo. – Jason sorriu.
<p>- Mas não somos amigos. Terminamos o trabalho, pode seguir a sua vida.
<p>- Ah, mas... você até que é uma nerd legal. Não quero parar de falar com você.
<p>- Obrigada?
<p>- De nada. Olha, eu estava pensando...
<p>- Que novidade.
<p>- Todo mundo acha que a gente está namorando porque você não tem um namorado. – Jason ignorou o comentário de Temperance. – Por isso, eu vou te ajudar a encontrar um.
<p>- Não.
<p>- Por que não?
<p>- Querido, o seu gosto deve ser péssimo.
<p>- Garota, você está a perigo, não pode escolher muito.
<p>- Eu estou feliz sozinha.
<p>- É claro que está. – Jason estava aprendendo a ser sarcástico.
<p>- Eu vou deixar por isso mesmo.
<p>- Nossa, você é muito chata. Mais chata do que uma aula de história. – Ele perdeu a paciência.
<p>- Eu amo história, então isso é um elogio para mim. – Temperance sorriu.
<p>- E ainda acham que eu namoraria você.
<p>- O quê? Meu bem, você teria sorte de namorar comigo.
<p>- Então quer ser minha namorada? – Jason não perdia uma.
<p>- Não.
<p>Jason riu.
<p>- Não custava tentar, né? Olha, eu vou ignorar o seu fora e continuar tentando te ajudar.
<p>- Eu não quero ficar com nenhum garoto dessa escola.
<p>- Então você é lésbica? – Temperance não respondeu. – Por mim tudo bem, podemos então encontrar uma namorada para você, podemos até sair nós três juntos. E agora minha cabeça ficou cheia de fantasias.
<p>- Para com isso. Você deve ser um péssimo cupido.
<p>- Por que acha isso?
<p>- Porque você está solteiro.
<p>- Por opção.
<p>- Duvido. – Temperance sempre retrucava.
<p>- Eu fiquei com uma garota ontem, e você? Quanto tempo faz que não fica com um cara?
<p>- Não te interessa.
<p>- Olha, isso vai ser bom para todo mundo. A não ser que você também goste do Cabelo de Medusa.
<p>- Eu não gosto do Brandon.
<p>- Aquele cabelo te assusta também, não assusta?
<p>- Olha, eu cansei de conversar com você, está bom? – Temperance estava farta. – Eu não quero ficar com nenhum cara dessa escola.
<p>- Nem aquele ali? – Jason apontou para um cara que estava passando pelo corredor, ele parecia bem sério.
<p>- Não me lembro de tê-lo visto alguma vez por aqui. – Temperance ficou curiosa.
<p>- Então ele é novo. Vamos falar com ele, pode rolar uma química.
<p>- Não.
<p>- Eu vou sozinho então. – Jason foi atrás do garoto.
<p>- Jason, não!
<p>Jason ignorou os gritos de Temperance e foi abordar o garoto sério no meio do corredor.
<p>- Oi. – Jason chegou perto do garoto.
<p>- Oi. – Ele ficou surpreso por alguém falar com ele.
<p>- Eu sou Jason, você é novo aqui? Eu sou. – Ele tentou ser simpático.
<p>- Sou, eu vim de Londres. - O garoto continuava sério.
<p>- É verdade que lá todo mundo toma chá?
<p>- Eu não tenho tempo para isso.
<p>- Não, espera. Olha, qual é mesmo o seu nome?
<p>- Kol.
<p>- Kol? É o diminutivo de Cepacol?
<p>- O quê?
<p>- Porque se for, tudo bem. – Jason tentou disfarçar. - Mas indo direto ao assunto, eu preciso te dizer, eu tenho uma amiga, ela está muito a fim de você, você podia ir ali conversar com ela e...
<p>- Você acha que eu preciso da sua ajuda? – Kol foi ignorante.
<p>- Talvez um pouco. – Kol fechou mais a cara. – Quase nada.
<p>- Você não me conhece.
<p>- Graças a Deus. – Jason não sabia guardar seus pensamentos para si. Simplesmente saiam da boca dele.
<p>- Então não venha falar comigo como se fôssemos amigos, porque não somos.
<p>- Nem colegas?
<p>- Não.
<p>- Sabe, você ia adorar a Temperance. – Jason insistiu. – Ela é tudo o que... eu não gosto em uma garota. Talvez seja o seu tipo. – Kol não respondeu. – Não?
<p>- Por que você ainda está conversando comigo?
<p>- Não faço ideia.
<p>- Tchau. – Kol foi embora.
<p>- Espero que você seja a próxima vítima do blogueiro! – Jason gritou achando que seria um insulto, mas Kol nem voltou para revidar. - Que babaca.</p>
<center><h4>--*--</h4></center>
<p>- Não precisava ter tratado o garoto assim. – Lisa estava dando mais uma lição de moral no Jason na hora do almoço.
<p>- Você deve ser ótimo para conseguir amigos. – Brandon estava lá também.
<p>- Ele foi mal-educado primeiro. – Jason tentou se explicar. – E por que o Cabeça de Cachos está aqui? – Jason ignorou o Brandon.
<p>- Se vocês quiserem privacidade, eu vou para outra mesa. – Brandon não gostava de Jason.
<p>- Não, Bran, não precisa. – Lisa insistiu. – O Jason sabe irritar.
<p>- É, a Tempe fala isso o tempo todo. – Brandon concordou.
<p>- Quer dizer que a Temperance fala sobre mim? Tipo uma paixão secreta assustadora? – Jason ficou curioso.
<p>- Não, tipo, como você é irritante. Esqueceram de falar isso no blog.
<p>- Vai lembrar ele então. – Jason fechou a cara.
<p>- Quando vocês dois pararem de brigar por algo que eu nem sei o que é, a gente pode voltar a comer? – Lisa tentou botar ordem.
<p>- Só mais uma coisa. – Jason não sabia quando parar. – Brandon, ninguém te avisou que estamos em 2015 e que a moda Black Power já acabou? Eu acho que não.
<p>- Jason! – Lisa ficou brava.
<p>- Tudo bem, Lisa, eu não me importo. – Brandon até soltou uma risada. – Agora eu já sei porque uma garota não consegue ficar com ele por mais de duas horas. Quando ele abre a boca, a beleza acaba.
<p>- Nossa, eu fiquei comovido. – Jason fingiu chorar. – Você tem algum lenço escondido nesse seu cabelo para eu usar? – Jason começou a rir.
<p>- Já chega de vocês dois por hoje. – Lisa ficou com raiva e se levantou.
<p>- Lisa, espera. – Brandon não queria que ela fosse embora.
<p>Lisa ignorou o pedido de Brandon e foi embora emburrada.
<p>- Olha só o que você fez. – Ele fechou a cara na hora.
<p>- O que foi que eu fiz? – Jason se fez de desentendido.
<p>- Você não deixa ninguém ficar em paz. Fica longe da Temperance. – Brandon estava sério.
<p>- O quê? Por quê?
<p>- Porque eu não quero você perto dela. Ela é a minha melhor amiga e eu tenho o dever de protege-la.
<p>- Meigo.
<p>- Olha, talvez eu nem precise me preocupar com isso. Quando ela te conhecer melhor, ela mesma vai se afastar.
<p>- Então continue falando mal de mim no seu blog. – Jason jogou verde.
<p>- O quê? Quer dizer que eu sou seu suspeito agora? – Brandon não estava acreditando.
<p>- Todo mundo é suspeito.
<p>- Garoto, o colégio não está fazendo uma conspiração contra você.
<p>- O quê?
<p>- Abaixa a bola, você não vale tudo isso. – Brandon se levantou e deixou Jason sozinho na mesa.
<p>- Você que pensa!</p>
<center><h4>--*--</h4></center>
<p>- Não precisava ter falado assim com ele. – Temperance estava brigando com o Brandon em um corredor da escola de novo.
<p>- Está defendendo ele, depois de tudo o que ele falou?
<p>- Ele é muito bobo, não tem noção. Ele não faz por mal.
<p>- Inacreditável. – Brandon estava muito estressado.
<p>- Eu não estou defendendo ele, só acho que você está fazendo uma tempestade.
<p>- Eu estou te protegendo.
<p>- Não preciso de proteção. O que você faria se eu te pedisse para parar de falar com essa Lisa?
<p>- É diferente, eu acho que estou gostando dela.
<p>- Você mal a conhece. – Temperance não entendia.
<p>- E quanto ao Jason? Você o conhece o suficiente?
<p>- Não é a mesma coisa, eu não gosto dele, só somos amigos.
<p>- Ele é o seu tipo de amigo agora? – Brandon ficou chocado.
<p>- Brandon, não começa. Eu sei que você se preocupa, mas não é para tanto.
<p>- Você espera muito das pessoas e ele vai acabar te decepcionando.
<p>- Deixa que eu cuido disso. Não sou eu que estou cego por alguém que nem conheço. O que você sabe sobre essa Lisa?
<p>- Não muito, mas ela é legal. O Jason não.
<p>- Ele pode não ser a pessoa mais perfeita do mundo, mas ele não é mal, e esse blog está mexendo com a cabeça dele.
<p>- Claro, vamos colocar a culpa no blog. – Brandon foi embora emburrado. Temperance nem percebeu que estava todo mundo olhando para os dois brigando.</p>
<center><h4>--*--</h4></center>
<p>- Oi. – Jason encontrou Kol na sala de aula. Eles teriam aula de Geografia na mesma sala.
<p>- Você de novo? - Kol reclamou.
<p>- Eu de novo. – Jason sorriu.
<p>- O que você quer? Outra amiga que quer me conhecer?
<p>- Não, e eu devo pedir desculpas por isso. Você é estranho e ela também, achei que seriam perfeitos um para o outro. – Kol não gostou do comentário. – Me desculpa por te chamar de estranho.
<p>- Por que você está se importando comigo?
<p>- Bom, tem um blog imbecil e uma pessoa bem imbecil anda escrevendo coisas ruins sobre mim nele.
<p>- E você não está conseguindo fazer amigos?
<p>- Exatamente.
<p>- Então está me usando?
<p>- Não. É claro que não. Eu estou te ajudando a fazer amigos também.
<p>- Eu não quero ser seu amigo. – Kol foi grosso.
<p>- Por que não? Eu sou o melhor amigo que alguém poderia ter.
<p>- Eu não ligo.
<p>- Por que você é tão... você?
<p>- Você acha trágico ter um blog falando de você? Garoto, você não sabe o que é tragédia. Talvez se você crescesse um pouco, não teria gente falando mal de você.
<p>- Não aja como se me conhecesse.
<p>- Por quê? Não é isso que você está fazendo comigo?
<p>- Eu só estava tentando ser legal.
<p>- Eu não preciso disso.
<p>- Cara, qual é o seu problema? – Jason não entendia porque Kol era tão chato e arrogante.
<p>- Aparentemente, você.
<p>- Não está mais aqui quem falou então.
<p>- Ótimo.
<p>Jason se sentou do outro lado da sala. Talvez ele devesse se acostumar a ficar sozinho.</p>
<center><h4>--*--</h4></center>
<p>Brandon estava na biblioteca.
<p>- Oi, tudo bem? – Maddie se sentou do lado dele. – Por que está aqui sozinho?
<p>- Só estou pensando na vida.
<p>- Está todo mundo falando da sua briga com a Temperance.
<p>- A gente não costuma brigar e odeio quando isso acontece. Ela é muito importante para mim.
<p>- Que lindo. Acho legal a maneira como você cuida dela. – Maddie ficou impressionada.
<p>- É, mas parece que ela se cansou disso e quer se cuidar sozinha.
<p>- Ela só está um pouco brava, vai passar.
<p>- Valeu, Maddie. Obrigado por aparecer e conversar comigo.
<p>- Você parecia que precisava de companhia.
<p>- É, acho que ficar sozinho nunca é bom.
<p>- Brandon! – Temperance chegou correndo e gritando.
<p>- Que lindo, vão fazer as pazes. – Maddie abriu um sorriso de orelha a orelha.
<p>- O que aconteceu? – Brandon se assustou. Temperance não costumava gritar na biblioteca, era sempre ele que fazia isso.
<p>- Estão falando da gente. – Temperance estava com raiva, mas ao mesmo tempo parecia um pouco triste.
<p>- Quem?
<p>- O blog.</p>
<br>
<p><i>“<b>CRISE NO PARAÍSO?</b> Parece que a amizade colorida de Brandon e Tempe está por um fio, e sabem por que, meu povo? Por causa do Jason é claro. Hoje os dois amigos foram vistos brigando por metade da escola. É, Bran, ninguém nunca achou que você tinha tanto ciúme assim da sua ‘amiga’, será que tem algo mais nessa relação de vocês? Eu preciso que me contem, porque eu já estava começando a gostar de VOCÊ com a Lisa. Agora quem precisa se cuidar é o Jason, já que ele parece que está sendo deixado por todos. É sério, pessoal, eu estou começando a sentir pena dele... Será que eu devo parar de desmascará-lo? É claro que não.”.</i> – Tesouro de Segredos Obscuros.</p>
</body></html>";
            }

            if (numero == 4)
            {
                lblTitulo.Text = "Capítulo 4 - Escolhas";
                htmlPage.Html = @"<html><body>
<p>Jason estava lendo a postagem do blogueiro. Como sempre, suas mãos tremiam de raiva.
<p>- Crise no paraíso. Mesmo falando de outras pessoas, esse infeliz tem que falar de mim também. – Ele bufou.
<p>Lisa lia também do seu lado por cima do seu ombro. O professor ainda não tinha entrado na sala.
<p>- Preciso falar com o Brandon, ele deve estar péssimo. – Lisa parecia chateada.
<p>- É, se o cabelo dele mudar de acordo com o humor, ele deve estar murchando agora.
<p>- Para de piada. A coisa é séria.
<p>- É séria porque estão falando sobre ele, mas quando era comigo, era paranoia.
<p>- Isso não tem nada a ver. – Lisa não estava entendendo a raiva de Jason. – Você está acostumado com fofocas. Ele não.
<p>- Se essa é a sua história. Vai lá correndo para ele.
<p>- Está impossível conversar com você nesses últimos dias. Eu já vou.
<p>- Ótimo.
<p>- Ótimo.
<p>Jason ficou no seu lugar sentado de braços cruzados e bravo enquanto Lisa saia da sala à procura de Brandon.</p>
<center><h4>--*--</h4></center>
<p>- Eu disse que isso ia acontecer. Eu não acredito que estão falando isso de mim. – Brandon, Maddie e Temperance ainda estavam na biblioteca. – Isso é o fim do mundo. – Brandon lia e relia o post.
<p>- Nossa, isso é horrível. – Maddie parecia assustada.
<p>- Você se acostuma. – Temperance já estava conformada. – Não precisamos ligar para isso.
<p>- Estão insinuando coisas sobre a gente. – Brandon estava chocado.
<p>- Isso não teria acontecido se você não tivesse feito um escândalo na frente de todo mundo.
<p>- Olha...
<p>- Para de falar assim do Brandon, ele não está bem. – Maddie interrompeu Brandon.
<p>- Você cala a boca, Maddie, não sabe da história toda. Devia parar de se intrometer na vida dos outros.
<p>- Eu só queria ajudar. – Maddie ficou triste.
<p>- Não liga para ela, Maddie. Parece que a Temperance já foi infectada com a doença Jason. – Brandon ficou com raiva.
<p>- Brandon! – Lisa chegou. – Você está bem? – Ela estava preocupada.
<p>- Lisa, oi. – Brandon esqueceu que estava bravo e abriu um sorriso. Lisa tinha esse poder sobre ele.
<p>- Eu li o post. Eu sinto muito. – Lisa disse para Brandon e Temperance.
<p>- Não precisa. Ninguém morreu. – Temperance fechou a cara.
<p>- Me desculpa, eu só...
<p>- Está tudo bem, Lisa. A Temperance não está muito bem. - Brandon olhou feio para a amiga.
<p>- Na verdade, eu estou ótima. Preciso ir, tenho muita lição para fazer. – Temperance foi embora brava.
<p>- Eu fiz alguma coisa errada? – Lisa ficou sem entender a ignorância de Temperance.
<p>- Não, eu gostei de você ter vindo.
<p>- A Temperance é assim mesmo. – Maddie sorriu.
<p>- O Jason me avisou sobre isso, mas fiquei chocada mesmo assim. – Lisa riu sem graça.
<p>- Não vamos falar sobre a Temperance. – Brandon quase esqueceu que Maddie ainda estava lá.
<p>- Bom, eu já vou indo. – Maddie percebeu o clima e saiu da biblioteca para deixá-los sozinhos.
<p>- Você está bem mesmo? – Lisa esperou Maddie sair para voltar a falar com Brandon.
<p>- Quer mesmo a verdade? – Brandon não parecia bem. – Eu não lido muito bem com essas fofocas.
<p>- Na minha outra escola, só não tinha um blog, mas as fofocas eram as mesmas com todo mundo.
<p>- Teve uma época em que as pessoas cochichavam sobre mim. – Brandon não parecia estar gostando de lembrar disso. – Era horrível.
<p>- O que aconteceu? Eles pararam?
<p>- Bom, o garoto que começou tudo saiu da escola e aí as fofocas foram diminuindo. Mas foi uma época difícil.
<p>- Eu imagino.
<p>- Não me leve a mal, mas eu não acho que você imagine. Quer dizer, olha só para você. -  Brandon fez aquela cara de bobo de novo.
<p>- Eu não sou a mais querida por todos, se é isso que você acha. Eu tinha vários colegas, mas meu único amigo de verdade era e ainda é o Jason.
<p>- Sinto muito por isso. – Brandon tentou imaginar alguém ter só o Jason como amigo.
<p>- Ele é implicante a maior parte do tempo, mas eu me sinto muito bem com ele, ele é incrível.
<p>- Talvez um dia eu conheça esse lado incrível dele.
<p>- Eu acho que vai demorar porque também demorou comigo.
<p>- Eu quero parar de pensar nisso. Vamos sair?
<p>- Para onde?
<p>- Você escolhe. Só quero passar o dia com você
<p>- Dizem que eu sou uma ótima companhia. – Lisa sorriu.
<p>- Então eu acho que vou adorar.</p>
<center><h4>--*--</h4></center>
<p>- Você está sendo deixado por todos? – Maddie se sentou na mesa onde Jason estava almoçando na cantina.
<p>- Garota, o que você quer? Eu não sei ordenhar vacas.
<p>- Só queria te fazer companhia. Não gosto de ver as pessoas tristes.
<p>- Por que você se importa? Viva a sua vida. – Jason não estava de bom humor, principalmente para Maddie.
<p>- Se você não fosse tão chato, não estaria excluído. A vida não é só ficar com uma garota aqui e outra ali e achar que tudo está bem.
<p>- E a vida também não é só sol e rosas, não é possível ser feliz assim o tempo todo. – Jason não engolia essa história da Maddie, dona da felicidade.
<p>- Eu já sofri muito, agora eu resolvi parar de sofrer e sorrir, é muito melhor.
<p>- Ótima filosofia, mas você sofreu com o que? Com a morte de um bezerro? – Jason simplesmente não conseguia levar Maddie a sério.
<p>- Cala essa boca.
<p>- Maddie, você deveria ter me esperado, quase me perdi aqui. – Jason ficou surpreso quando Kol se sentou na mesa junto com eles.
<p>- Ei, cara com nome de remédio, o que você está pensando que está fazendo? Por que está sentando aqui?
<p>- Ele é meu irmão. – Maddie respondeu antes de Kol.
<p>- O quê? Irmão? – Jason nunca ficou tão chocado em toda a vida dele. – Não pode ser verdade.
<p>- Por que não? – Kol perguntou.
<p>- Não tem como a Miss Felicidade ser irmã do cara mais chato do mundo. Se bem que ela também é muito chata, mas mesmo assim...
<p>- Achei que a pessoa mais chata do mundo fosse você. – Kol comentou.
<p>- Não faça disso uma competição. – Jason já estava farto. – Eu vou sair daqui. – Jason largou a comida e foi embora.
<p>- Não acredito que você conheceu o Jason. – Maddie ficou surpresa.
<p>- Tive o desprazer de conhecer. – Kol estava nervoso.
<p>- Você está bem? Não se arrependeu de ter voltado?
<p>- Eu estava sentindo a sua falta. – Kol tentou sorrir, mas não conseguiu.
<p>- Eu também estava morrendo de saudade, mas eu só quero que você seja feliz.
<p>- Irmã, eu não sei mais o que é ser feliz e nem quero mais saber já que tudo é uma mentira.
<p>Maddie ficou sem saber o que falar. Ela não gostava de ver o irmão assim.</p>
<center><h4>--*--</h4></center>
<p>- Oi. – Temperance encontrou Jason no seu armário.
<p>- Oi. – Jason estava sério. Temperance nunca viu ele assim.
<p>- Está tudo bem?
<p>- Tudo ótimo. Agora além de garanhão, eu sou o mais solitário da escola. Está tudo perfeito. – Jason fingiu animação.
<p>- Cadê o garoto que lida tudo com brincadeira?
<p>- Ele não veio para escola hoje. E quanto ao Brandon? Ele já começou a vender o cabelo para tentar subornar o blogueiro para parar de falar mal dele?
<p>- Esse é o Jason que eu conheço. – Temperance fez Jason rir.
<p>- Por que você está aqui, hein? Não deveria estar com ele?
<p>- O Brandon escolheu a Lisa. Eles estão juntos.
<p>- Então é por isso que eu não a vi o dia todo.
<p>- Você está com raiva por isso?
<p>- Eu não. – Jason fez pouco caso.
<p>- Jason, pode falar sério.
<p>- Sabe, pela primeira vez o blogueiro tem razão. Eu estou mesmo solitário de novo.
<p>- Você tem a mim. – Temperance estava começando a gostar de Jason.
<p>- Você fala como se isso fosse uma coisa boa. – Jason riu.
<p>- Sem graça. – Temperance deu um tapa nas costas dele, ela queria acertar a cabeça, mas ele era muito grande para ela.
<p>- Mas olha só quem eu encontro. – Um valentão se aproximou dos dois, vinha outros dois na cola dele.
<p>- E você é... – Jason não ficou intimidado.
<p>- Barry. Meu nome é Barry.
<p>- Eu estou pensando em uma piada para o seu nome, pode me deixar pensar por dois dias? Ou então eu te chamo de Flash, mas seria sem graça e sem criatividade.
<p>- Eu só vim dizer que eu gosto de vocês dois juntos.
<p>- Não estamos juntos. – Temperance corrigiu logo.
<p>- O que isso tem a ver com você? – Jason não estava entendendo nada. De onde aquele garoto tinha surgido?
<p>- Bom, eu trouxe um recado. Está todo mundo feliz que você se aquietou, assim não precisamos nos preocupar.
<p>- Se preocupar com o que? – Jason estava perdido.
<p>- De você querer galinhar com as nossas namoradas. – Os outros dois atrás riram.
<p>- Vocês não se garantem? É isso? – Jason fechou a cara.
<p>- A gente não queria que você ficasse com cara de otário quando fosse rejeitado. – Barry fez cara de dó.
<p>- Olha, quer saber... – Jason avançou para cima de Barry.
<p>- Tudo bem, gente, já chega. – Temperance entrou no meio dos dois.
<p>- Eu não sabia que você precisava de uma garota para te proteger. – Barry fez os outros dois garotos rirem de novo.
<p>- Não preciso que ninguém me proteja. – Jason tirou Temperance do caminho a força.
<p>- Não, espera aí. – Temperance tentou impedir, mas não conseguiu. Jason deu um soco na cara de Barry.
<p>- Vamos embora, Tempe. Agora eu preciso encontrar e ficar com a namorada desse imbecil. – Jason foi embora com raiva e Temperance ficou em choque, ela nunca tinha visto uma briga.</p>
<center><h4>--*--</h4></center>
<p>- Você brigou com alguém? – Jason só se encontrou com Lisa à noite em casa.
<p>- Briguei, e daí? – Jason estava quase explodindo.
<p>- Não deveria ter feito isso.
<p>- Olha, Lisa, não começa.
<p>- Você quer ser expulso como na outra escola?
<p>- Você não sabe o que ele disse. – Jason não estava acreditando que a Lisa não estava do lado dele.
<p>- Não interessa. Não é essa a questão. Você tem que se acalmar. – Lisa também estava brava.
<p>- É fácil para você falar quando ficou o dia todo namorando por aí.
<p>- Então é sobre isso que se trata? O Brandon e eu só saímos para conversar, ele estava mal com o lance do blog e eu estava tentando ajudar.
<p>- É, eu sei. – Mas Jason não sabia.
<p>- Não é justo.
<p>- Sabe o que não é justo? Não é justo todo mundo poder ficar com raiva, MENOS EU! – Jason começou a gritar.
<p>- Do que você está falando?
<p>- Todo mundo pode fazer o que quer, mas quando eu faço algo errado, é um desastre.
<p>- Você bateu em uma pessoa.
<p>- E qual é o problema? Ele não foi o primeiro nem vai ser o último.
<p>- As coisas não se resolvem assim! – Lisa gritou também.
<p>- E como se resolvem? Porque eu tentei, eu tentei deixar para lá, e esqueci, mas esse blogueiro dos infernos está me deixando louco, e eu juro que se eu descobrir quem ele é, eu vou matar ele de porrada.
<p>- Para, você precisa se acalmar.
<p>- Por quê? Por que eu estou fazendo uma tempestade sem motivo?! – Jason continuava a gritar.
<p>- Não é isso.
<p>- Por que eu sou um exagerado e deveria deixar para lá?!
<p>- Jason!
<p>- Cansei de todos dizerem para eu relaxar. Eu não quero e nem posso relaxar. Eu não vou deixar que um ninguém fale assim de mim. Se você não se importa, ótimo.
<p>- É claro que eu me importo, você é meu melhor amigo.
<p>- Mas não parece.
<p>- Isso tem a ver com o Brandon?
<p>- Isso não tem nada a ver com o Cabelo de Minhoca, isso tem a ver comigo. É pessoal, por algum motivo, esse cara que escreve não gosta de mim e quer acabar comigo e eu nem sei por que.
<p>- Calma...
<p>- Eu estou cheio. Se ele me odeia tanto, por que ele não vem aqui e diz na minha cara?
<p>- Seria melhor?
<p>- Não. Mas pelo menos eu poderia bater em alguém.
<p>- Jason, eu sinto muito.
<p>- Eu também. – Jason saiu de casa furioso.</p>
<center><h4>--*--</h4></center>
<p>- Como foi o dia com a Lisa? – Temperance estava jantando na casa de Brandon. Ela continuava séria.
<p>- Foi bom. Me fez esquecer. E como foi o seu dia?
<p>- Ótimo, até presenciei uma briga.
<p>- O quê? – Brandon ficou curioso.
<p>- Jason bateu em um cara.
<p>- Por quê?
<p>- Porque estão falando mal dele, só por isso. Até eu estou com raiva desse blogueiro.
<p>- Se o Jason não fosse tão ruim, o blogueiro não teria o que falar dele.
<p>- Eu não acredito que você está defendendo esse infeliz. Ele também falou de você.
<p>- E por quê? Porque eu fui associado a esse idiota. Preciso fazer a Lisa se afastar dele.
<p>- Isso é uma missão impossível. Os dois são muito amigos.
<p>- Ele é uma péssima pessoa para ela estar junto.
<p>- Bran, eu te amo, mas você julga muito as pessoas. E às vezes, você chega a ser injusto.
<p>- Defendendo o Jason? Daqui a pouco, vai me dizer que está se apaixonando por ele.
<p>- Isso não vai acontecer. Não sou alucinada como você.
<p>- Como começamos a brigar tanto?
<p>- Quando você começou a achar que está certo em tudo. Eu já vou, perdi a fome.
<p>Temperance se levantou da mesa e saiu.</p>
<center><h4>--*--</h4></center>
<p>Quando Jason estava bravo, ele costumava sair e ir para a praia para ficar mais calmo, sentir a brisa do mar, mas isso era em Los Angeles. Agora, o máximo que tinha era uma praça ali perto que dava para ver umas árvores. Isso deixava ele ainda mais nervoso.
<p>Ele se sentou em um banco na praça, respirou fundo, tentou se acalmar, mas não conseguiu.
<p>- Mas que droga! – Ele bufou para si mesmo. – Que inferno!
<p>Ele estava tão distraído com os seus problemas que nem percebeu que não estava sozinho na praça.
<p>- Nossa! Que raiva é essa? – Uma garota estava sentada em um outro banco não muito longe dele falou um pouco assustada e irritada ao mesmo tempo.
<p>- Se você estivesse vivendo a minha vida também estaria com raiva. – Jason foi ignorante, nem olhou para a garota.
<p>- Ou você só é dramático. – Ela o enfrentou.
<p>- Olha, você não sabe o que está acontecendo, tá bom? Não tem direito de dar opinião sobre isso.
<p>- Tem razão. Mas eu não sou obrigada a ouvir suas reclamações.
<p>- Vai para outra praça. – Jason finalmente a encarou.
<p>- Eu cheguei aqui primeiro.
<p>- Mas você quem está incomodada, então tem aquele ditado que diz...
<p>- Olha, fica quieto na sua que eu fico quieta na minha, tudo bem?
<p>A garota nem esperou ele responder e virou a cara.
<p>- Também não precisa ser grossa. – Jason falou.
<p>- Estou me adaptando a você.
<p>Os dois ficaram em silêncio por alguns minutos, mas não paravam de se olhar uma vez ou outra.
<p>- Você perdeu alguma coisa aqui? – A garota ficou brava com os olhares de Jason. – Você não para de me olhar.
<p>- Você olhou para mim primeiro. – Jason retrucou.
<p>- Não olhei, nada.
<p>- Olhou, sim.
<p>Ele estava irritado, mesmo assim olhava diferente para a garota.
<p>- Tudo bem, eu confesso. Eu estava te olhando, mas é porque eu estou um pouco curioso.
<p>- Curioso com o quê?
<p>- Por que está aqui a essa hora da noite? Você é uma garota e...
<p>- O quê? Uma garota não pode passear pela cidade à noite?
<p>- Claro que pode. Estamos em um país livre. Mas é estranho.
<p>- Você não sabe de nada.
<p>- Tem razão. Eu não sei mesmo, mas pode me contar sua história se quiser.
<p>- O quê? – Ela começou a rir de deboche. – Por que eu faria isso? Você é psicólogo ou algo assim?
<p>- Eu pareço um psicólogo?
<p>- Você parece alguém perdido.
<p>- Está enganada. Mas tudo bem, além do mais, você nem me conhece.
<p>- Olha, ainda bem.
<p>- É aí que eu discordo. Acho que você está perdendo em não me conhecer.
<p>- Olha, eu não sou de julgar as pessoas assim sem conhece-las, mas... Você não pareceu ser alguém legal nesses cinco minutos que se passaram. Você parece ser dramático, arrogante e ignorante.
<p>- Nossa, percebeu tudo isso só com alguns minutos de conversa? Você é muito boa. – Jason fingiu estar impressionado.
<p>- Olha só o sarcasmo.
<p>- Ainda bem que você não gosta de julgar, não é verdade? – Jason não sabia porque, mas sabia que podia falar com ela desse jeito.
<p>- Quem eu quero enganar? Eu amo julgar as pessoas pela primeira impressão.
<p>- Então você é dessas que diz que a primeira impressão é a que vale?
<p>- Lógico.
<p>- Talvez eu só não esteja em um bom dia.
<p>- Você é um exemplo de ser humano em um bom dia?
<p>- Nem tanto assim. – Jason sorriu.
<p>- Imaginei que não.
<p>- Você é muito espertinha, sabia?
<p>- É o que dizem.
<p>- Olha, eu nem sei porque eu estou falando com você agora. Você falou de mim, mas também foi grossa e antipática, e além do mais, eu não converso com estranhas. – Essa última parte não soou tão convincente.
<p>- Sério?
<p>- A não ser que sejam gatas.
<p>- Ah é? – A garota revirou os olhos.
<p>- É. Quer dizer que eu posso falar com você. – Jason sorriu para ela, se levantou e se sentou ao lado dela no banco.
<p>- Você não precisava ter vindo até aqui, eu estava te ouvindo quando estava sentado do outro lado.
<p>- Foi mal, é mais forte do que eu. – Jason confessou. – E olhando assim mais de perto, até que você é bonitinha.
<p>- Bonitinha? – Ela franziu a testa.
<p>- Quem eu quero enganar? Você é linda. Esses olhos castanhos... – Ele suspirou.
<p>- Eu vou embora. – Ela ficou sem graça. Jason não imaginou que isso seria possível com toda a pose que ela tinha feito até aquele momento.
<p>- Não, tudo bem. Eu vou parar. Vamos começar de novo. Sou Jason. – Ele estendeu a mão.
<p>- Por que eu diria meu nome?
<p>- Porque se você não disser e depois sumir, amanhã eu vou acordar achando que você foi uma alucinação.
<p>- Nossa. – Ela começou a rir. E Jason achando que ela não poderia ficar mais linda. – Bom, eu não sou uma alucinação, eu sou a Emily.
<p>- Muito prazer.
<p>- O prazer é todo meu. – Ela apertou a mão dele.
<p>- Bom, agora que somos íntimos...
<p>- Não somos íntimos.
<p>- Me diga. – Ele a ignorou. – Você aborda todos os caras que aparecem aqui no parque?
<p>- Mas é lógico, vai que um deles é o amor da minha vida. – Emily brincou.
<p>- Vai que eu sou o amor da sua vida.
<p>- Eu duvido. – Emily fez cara de desdém.
<p>- Por quê? Eu não sou o seu tipo? – Jason até esqueceu que estava com raiva.
<p>- Digamos que eu não sou o seu tipo.
<p>- Olhando você agora... – Jason a olhou dos pés a cabeça. – Você é muito meu tipo.
<p>- Para! Eu não sou um pedaço de carne. Isso era para ser um elogio?
<p>- Não. Além do mais, qualquer elogio seria pouco para você.
<p>- Cala essa boca. – Emily ficou sem graça.
<p>- O quê? É verdade. Para você ver que eu estou falando sério, você até me fez esquecer da minha raiva.
<p>- Por que está com raiva?
<p>- Bom, você meio que tem razão, eu não sou uma boa pessoa. Só que agora estão jogando isso na minha cara.
<p>- Se isso te irrita tanto, mude.
<p>- Eu gosto de quem e como eu sou, não vou mudar.
<p>- Então encontre pessoas que te aceitam como você é.
<p>- Você me aceita como eu sou? – Jason sorriu.
<p>- Eu nem te conheço.
<p>- Podemos mudar isso quando quiser.
<p>- Como você faz isso? – Emily estava sorrindo.
<p>- Faço o quê?
<p>- Isso. Você não consegue parar de dar em cima de mim?
<p>- Não consigo. Está funcionando? – Jason se animou.
<p>- Não, mas quem sabe um dia, quando você fizer chover.
<p>- É um desafio?
<p>- Olha, já está ficando tarde, eu vou embora.
<p>- Onde eu te vejo de novo?
<p>- Na sua memória. – Emily riu.
<p>- Tenho memória fraca. – Jason pegou o celular. – Sorria.
<p>- Por quê? – Emily ficou confusa.
<p>- Só sorria.
<p>Demorou um pouco, mas Emily finalmente sorriu, então Jason tirou uma foto dela.
<p>- Você é louco? – Ela se assustou.
<p>- Talvez eu seja. Para ficar louco por você agora é dois “p”. – Jason não conseguia parar. – Na verdade, eu meio que já estou louco por você.
<p>- Eu vou embora. – Emily estava quase ficando vermelha.
<p>- Tudo bem. – Ele não conseguia parar de sorrir.
<p>Jason ficou admirando Emily enquanto ela se levantava do banco e se afastava.
<p>- É, parece que sair para pensar foi uma ótima escolha! – Jason gritou enquanto Emily ia embora.
<p>- Saia mais vezes! – Emily também gritou.
<p>- Pode deixar!
<p>Jason então se pegou sorrindo. Minutos antes, ele se sentou naquele banco com a maior raiva que já havia sentido na vida, mas tudo tinha sumido. O que aquela garota tinha feito?</p>
</body></html>";
            }

            if (numero == 5)
            {
                lblTitulo.Text = "Capítulo 5 - Verdade";
                htmlPage.Html = @"<html><body>
<p>Jason não falava mais com Lisa a não ser se fosse algo muito necessário. Ele já estava ignorando ela por uma semana e sempre que a garota chegava para conversar, ele fazia algum comentário maldoso e ia embora.
<p>- Oi. – Lisa se sentou ao lado de Jason na aula de Geografia e puxou papo. Era a sua milésima tentativa só naquele dia. – Não te vi saindo hoje de casa.
<p>- Saí mais cedo. – Jason estava sério e nem olhava para Lisa.
<p>- Olha, eu sinto muito.
<p>- Você não tem um namorado para conversar? Um cabelo enrolado para alisar?
<p>- Sinto sua falta. A gente mal conversa.
<p>- É uma pena. – Jason não parecia afetado.
<p>- Se você quiser que eu me afaste do Brandon, eu me afasto. – Lisa falava sério.
<p>- Eu não quero que faça isso. – Jason finalmente olhou para ela.
<p>- Então fala comigo.
<p>- Não dá.
<p>- Por quê?
<p>- Porque de repente, me deu uma vontade de matar aula. – Jason pegou seu caderno, se levantou e saiu da sala.</p>
<center><h4>--*--</h4></center>
<p>- Eu estou muito mal. – Lisa reclamava enquanto almoçava com Brandon e Temperance no refeitório da escola.
<p>- O Jason ainda não está falando com você? – Brandon estava sentado ao lado dela.
<p>- Não como antes. O máximo que eu estou ganhando dele nesses últimos dias é um resmungo, uma revirada de olho, um xingamento aqui ou ali, já estou farta. Eu não acredito que isso está acontecendo.
<p>- Olha, vai passar.
<p>- Ele é meu melhor amigo desde sempre. Não acho que vá passar. Sinto que ele está me abandonando e eu vou ficar sozinha.
<p>- Você tem a mim. – Brandon colocou sua mão no ombro dela.
<p>- Grande coisa. – Temperance disse bem baixinho para ela mesma.
<p>- É diferente. – Lisa ignorou o comentário ruim de Temperance. – O Jason é... o Jason.
<p>- Quer que eu faça piadas com o meu cabelo? Eu posso fazer isso. – Brandon fez Lisa rir.
<p>- Não precisa.
<p>- Se quiserem que eu saia para vocês começarem a se pegar, é só falar. – Dessa vez Temperance falou alto.
<p>- Fica quieta, Tempe. – Brandon ficou sem jeito.
<p>- Não, eu já estou indo, eu tenho que passar na biblioteca. Tchau, pessoal. – Lisa pegou sua bandeja do almoço, se levantou e foi embora.
<p>Brandon ficou olhando em direção a Lisa até ela sumir de vista, então voltou a comer.
<p>- Esse é o namoro mais seco que eu já vi. – Temperance percebeu que não houve nem beijo de despedida.
<p>- Não estamos namorando. – Brandon fechou a cara.
<p>- Então o que estão fazendo? Vocês ficaram juntos a semana toda e agora que o Jason não fala mais com a Lisa, você parece que está grudado nela.
<p>- Ela precisa de companhia, não tem muitos amigos por aqui.
<p>- E você é o garoto gentil que atravessa a rua com ela de mãos dadas?
<p>- Não enche.
<p>- Não está mais aqui quem falou. – Temperance parou de comer, pegou sua bandeja e se levantou da mesa.</p>
<center><h4>--*--</h4></center>
<p>- Maddie, oi. – Jason encontrou com a Maddie no corredor na troca de aula. Ele sorriu para ela.
<p>- Oi. – Ela olhou para ele estranho. – O que você quer?
<p>- Nada, só saber como você está. – Jason não podia ser mais falso do que aquilo.
<p>- Eu estou bem, obrigada.
<p>- Que bom, não é? Ninguém quer ver você mal.
<p>- O que você quer? – Maddie não estava convencida.
<p>- Nada, só bater um papo.
<p>- Sobre?
<p>- Sobre você. – Jason parecia muito interessado naquela conversa. – Quero te conhecer melhor, mas por favor, sem papo de vaca, tá bom?
<p>- Tudo bem. -  Maddie de repente ficou animada. – Olha, eu sou de Dallas mesmo, mas quando eu era mais nova, eu...
<p>- Tudo bem, eu não quero saber disso. – Jason não aguentou. – Qual é o problema com a sua família? – Ele foi direto ao assunto.
<p>- Como assim?
<p>- Você parece que vê o passarinho verde todo dia, já o seu irmão, ele parece que chupa limão ao invés de outra coisa. O que se passa? Um é mais amado que o outro?
<p>- Olha, J...
<p>- Não me chame de J, não temos intimidade para isso. – Jason cortou logo.
<p>- Tudo bem, então não temos intimidade para falar sobre o meu irmão. – Maddie fez uma cara de quem tinha ganhado um prêmio.
<p>- Não, espera aí, eu estava brincando. – Jason voltou a sorrir. – Você pode me chamar de J, de K, de L, do alfabeto inteiro se quiser. Temos muita intimidade, só falta eu te ver sem roupa para completar.
<p>- Isso nunca vai acontecer.
<p>- Vou fingir que estou triste. Olha, será que não dá para gente conversar, de amigo para garota assustadora, mas que é minha amiga? – Jason não sabia convencer.
<p>- Se quer saber algo sobre o Kol, pergunte a ele.
<p>- O Caracol nunca vai me contar. Me dá pelo menos uma dica. Ele tentou mudar de nome e não conseguiu, então ele é azedo por ter traumas com o nome?
<p>- Não.
<p>- Então ele mudou de sexo? – Jason fingiu choque. – Na verdade, ele se chamava Kola, e agora é Kol, mas desistiu e quer voltar a ser Kola, ou Joaquina, o nome não importa mais.
<p>- Não. – Maddie estava abismada.
<p>- Então o quê?
<p>- Ele perdeu alguém muito importante. É muito recente e ele me mata se souber que eu te contei.
<p>- Relaxa, ele nunca vai saber.
<p>- Eu duvido.
<p>- É verdade, eu já vou sair correndo para falar com ele sobre isso. – Jason foi sincero.
<p>- Eu imaginei. Você não vai sossegar enquanto não descobrir tudo.
<p>- Você é inteligente. – Jason piscou para ela. – Olha, me desculpa. Eu sinto muito, essa pessoa devia ser próxima sua também.
<p>- Sim. Todos nós sofremos.
<p>- Esse alguém não é um cachorro, né? – Jason quis ter certeza da gravidade do problema antes de realmente sentir muito. – Porque  tem gente que considera bicho igual gente e tudo mais...
<p>- Tchau, J. – Maddie perdeu a paciência e foi embora.
<p>- Não me chame de J, vaqueira.</p>
<center><h4>--*--</h4></center>
<p>- A gente pode conversar? – Brandon correu até Jason na saída do colégio. Ele não podia perder essa oportunidade de conversar.
<p>- Ah, deixa eu ver na minha agenda... não. – Jason começou a andar mais rápido.
<p>- É sobre a Lisa.
<p>- O que tem ela? – Jason continuou andando mesmo estando interessado no assunto.
<p>- Ela está muito mal porque você não está falando com ela. – Brandon tentava acompanhar o seu passo.
<p>- Você virou o mediador dela agora? – Jason resmungou. – Me desculpa, eu não consigo te levar a sério com esse capacete que você chama de cabelo.
<p>- Olha, para, tá bom? Eu quero falar sério com você, pela primeira vez.
<p>- Que medo de você.
<p>- Você está com medo de mim? – Brandon ficou surpreso.
<p>- Você entende o conceito de “ironia”, “sarcasmo”? Parece que não, não é? – Jason riu.
<p>- Você pode falar sério comigo? – Brandon já estava perdendo a paciência com ele.
<p>- Lógico, vai que você está escondendo um revólver dentro desse seu cabelo. – Jason brincou.
<p>- Que parte de “conversar sério” você não entendeu?
<p>- Que parte de “não quero conversar” você não entendeu? Parece que estamos quites.
<p>- Eu estou tentando ser legal, mas com o seu tipo, é impossível.
<p>- Meu tipo? – Jason finalmente parou de andar. – Qual seria o meu tipo? Os que não usam capacete natural na cabeça?
<p>- Os que não valem nem o que comem.
<p>- Como é? – Jason pensou não ter ouvido direito.
<p>- Sabe, eu costumava pensar que caras como você mudavam com o tempo, mas eu acho que só pioram. Você se acha o tal, mas não passa de um ninguém, e daqui há alguns anos, você vai estar trabalhando em um posto de gasolina vendo todos serem bem-sucedidos menos você.
<p>- Ai, meu Deus, você viu o meu futuro sem precisar ler a minha mão? – Jason fingiu estar impressionado. – Eu não sabia que estava cara a cara com o Pai Diná, essa sessão vai ser de graça, não é? Diz ai, qual é a minha linha da fortuna? Será que dá para ler com os meus punhos fechados e na sua cara?
<p>- Você finge que a verdade não te afeta.
<p>- Não afeta.
<p>- Então por que ficou tão grilado com o blog? – Brandon usou o ponto fraco de Jason para atingi-lo.
<p>- Porque eu odeio pessoas que acham que podem fazer qualquer coisa atrás de um computador só porque é anônimo.
<p>- Eles podem.
<p>- Não podem não, e sabe por quê? Porque uma hora, a verdade aparece. E se depender de mim, vai ser bem rápido.
<p>- Olha, eu não quero falar sobre o blog. Eu quero falar sobre a Lisa.
<p>- Tudo bem, fale. Eu sou todo ouvidos. – Jason fingiu interesse.
<p>- Você está fazendo muito mal a ela.
<p>- Você veio até aqui tentar uma reconciliação? Não é bem assim que se faz.
<p>- Não, eu vim até aqui para mandar você ficar longe dela. – Brandon estava com raiva.
<p>- Mandar? Quem você pensa que é? Algum cara fortão com uma esponja na cabeça?
<p>- Eu quero o bem dela e ela não vai ficar bem com você por perto.
<p>- Olha só, poodle de pelo preto, você não tem moral para me mandar fazer nada, entendido?
<p>- O que vai acontecer quando o blogueiro falar dela por sua causa? Tipo como ele fez com a Tempe e comigo?
<p>- Isso não tem nada a ver.
<p>- Tem sim. Você está acabando com todo mundo e a melhor coisa que você pode fazer é ficar longe. Você é o tipo de pessoa que merece ficar sozinha.
<p>- Você não me conhece.
<p>- Mas você já foi expulso de uma escola antes, não foi?
<p>- Cala a boca. – Jason estava se segurando.
<p>- O que você fez lá? Só agiu como você mesmo? Acho que isso espantou todo mundo.
<p>- Sai daqui.
<p>- Me diz, vai, somos próximos o suficiente para conversarmos um com outro. – Brandon estava provocando.
<p>- Sabe por que eu fui expulso? – Jason o encarou. – Porque eu achava e ainda acho que pessoas como você merecem apanhar.
<p>- Como assim?
<p>- Foi mal, Tempe.
<p>Jason pensou um pouco antes de bater em Brandon.
<p>- O quê? Vai me bater? Não tem mais o que dizer?
<p>- Foi mal, sou de poucas palavras. – Jason deu um soco na cara de Brandon.
<p>- Qual é o seu problema? – Brandon gritou segurando o queixo.
<p>- Você é o meu problema, seu otário. E quer um conselho? Arruma essa peruca, está caindo.
<p>Jason deu as costas para Brandon e continuou andando com passos firmes.</p>
<center><h4>--*--</h4></center>
<p>- O que aconteceu? – Lisa estava sentada no sofá da sala quando Jason chegou em casa, e ela percebeu que ele estava com a mão machucada.
<p>- Nada. – Ele tentou evitar uma conversa e subiu as escadas correndo.
<p>- Entrou em outra briga? – Lisa correu atrás dele.
<p>- O que eu posso fazer? Bater faz parte de mim.
<p>- Sabe que isso é errado.
<p>- Olha, Lisa, menos, está bem? – Jason entrou no quarto e encostou a porta.
<p>- Com quem você brigou? – Lisa o seguiu. Ela não ia deixar ele em paz.
<p>- Com o seu namorado projeto de espanador.
<p>- Por que brigou com o Brandon? – Lisa se alterou.
<p>- Porque eu estava a fim.
<p>- Não estou acreditando nisso.
<p>- Então acredite. Porque é a verdade. – Jason não fez questão de fazer cerimônia. Deitou na cama e esperou que Lisa desistisse e saísse do quarto.
<p>- Jason, você precisa parar com isso. Precisa se controlar. Você não liga para o que pode acontecer por isso? Não se importa comigo?
<p>- Não faz drama, tá bom? Por que você não usa essa desculpa e se afasta logo de mim? Vai ser o melhor para você.
<p>- Você é o meu melhor amigo. Eu nunca me afastaria de você. Não importa quantas burrices você faça.
<p>- Eu sinto muito.
<p>- Deixa de ser idiota. – Lisa perdeu a paciência.
<p>- Não consigo. Por que você acha que o blogueiro caiu matando em cima de mim? Porque eu sou um idiota.
<p>- Já entendi porque você está fazendo tudo isso. Você tem medo que ele fale de mim? Eu não ligo. Posso lidar com isso.
<p>- Eu não quero que precise lidar com isso. Eu sempre digo que vou te proteger. Esse sou eu te protegendo.
<p>- Mas Jason...
<p>- Se quiser que eu saia da sua casa...
<p>- Eu não quero que saia da minha casa. – Lisa quase gritou. – Só que do mesmo jeito que você quer me proteger, eu também vou ficar do seu lado, não importa o que aconteça.
<p>- Por quê? Eu não valho tudo isso.
<p>- Vale sim. Pelo menos para mim. – Lisa deitou na cama com Jason. – Você é a pessoa mais importante para mim. Não importa o que aconteça, eu nunca vou sair do seu lado.
<p>- Eu te amo, Lisa. – Jason finalmente cedeu.
<p>- Eu também te amo.</p>
<center><h4>--*--</h4></center>
<p>E no dia seguinte, todo mundo já estava sabendo que Jason tinha batido em Brandon e isso nem tinha saído no blog. Algumas pessoas viram a briga e espalharam a novidade. E Brandon apareceu com a boca machucado na aula o que confirmou os boatos.
<p>- Por que bateu no Bran? – Temperance foi a primeira que abordou Jason naquela manhã no corredor da escola.
<p>- Porque ele pediu, não com todas as letras, mas deu a entender que queria.
<p>- Só eu posso bater nele. – Temperance estava brava.
<p>- Quer exclusividade? Não é justo. – Jason brincou.
<p>- Brigou com ele por causa da Lisa?
<p>- Não. Você faz parecer que eu estou com ciúme e que meu mundo gira ao redor da Lisa.
<p>- E não está? – Temperance estava tentando sondar Jason.
<p>- Eu não ligo para quem a Lisa namora, mesmo que o namorado dela não tenha um cabelo muito bonito.
<p>- Eles não formam um casal bonito.
<p>- Nenhum que dá certo forma um casal bonito.
<p>- Então você está de acordo? – Ela ficou surpresa.
<p>- Eu detesto o Brandon, mas não vou pedir pra Lisa escolher entre mim e o Brandon cabeludo. Não sou tão imaturo assim.
<p>- Seria errado.
<p>- Muito errado. Mas e quanto a você?
<p>- O que tem eu?
<p>- Você também não parece estar gostando desse ‘namoro”. Eu até tenho motivos porque o Brandon me irrita, mas a Lisa não está no seu pé. Acho que é você que está com ciúmes do cabeludinho. Pode confessar. – Jason riu.
<p>- Para de falar besteira.
<p>Temperance parou no seu armário para pegar seus livros.
<p>- Que chaveiro legal. – Jason olhou para o chaveiro de Temperance.
<p>- Obrigada, eu ganhei de presente. Só uso por obrigação.
<p>- Do que você está falando? – Jason pegou o chaveiro. Era do filme Sexta-Feira 13. – Minha mãe colocou meu nome de Jason só por causa do Jason. – Ele riu.
<p>- Quer dizer que você é imortal e assassino? – Temperance riu.
<p>- Essa é a ideia.
<p>- Então pode ficar para você, eu não gosto muito. – Temperance tirou o chaveiro do seu molho de chaves e o entregou para Jason.
<p>- Você me dando um presente? Assim eu vou ter que te beijar para retribuir.
<p>- Eu dispenso. – Ela fez cara de nojo.
<p>- Claro, não é essa boca que você quer beijar. – Jason comentou enquanto colocava seu novo chaveiro em um dos zíperes de sua mochila.
<p>- Do que você está falando?
<p>- Você tentou fugir da minha pergunta, eu percebi. Você está falando tanto do Brandon e da Lisa e ciúme e tal, mas não sou eu que estou com ciúme, é você. Ou você é uma amiga possesiva e não quer dividir o cabelo de mola ou você está completamente apaixonada pelo Cachinhos de Chumbo.
<p>- Eu não gosto do Brandon.
<p>- Qual é? Pode me contar. Além do mais, aí eu teria uma explicação de você rejeitar todos os caras daqui.
<p>- O Brandon é meu amigo.
<p>- E vai me dizer que nunca sentiu vontade de puxar aqueles cabelos, mesmo que provavelmente suas mãos ficariam presas, e beijar ele com todas as suas forças apaixonadas? – Jason fez os gestos com as mãos.
<p>- Não.
<p>- Tempe! – Jason conhecia as pessoas.
<p>- Talvez.
<p>- Tempe!
<p>- Tá, tudo bem. Eu podia ter uma pequena queda pelo Brandon uns anos atrás.
<p>- Tudo bem, se você tiver alguma queda por ele, é só se segurar no cabelo. – Jason começou a rir. – Desculpa, eu não podia perder essa. Achei que não ia confessar. Eu sabia! – Jason quase deu um pulo para comemorar.
<p>- Mas isso já passou. Foi há muito tempo e agora eu nem vejo ele desse jeito.
<p>- Posso te chamar de Rainha da Friendzone?
<p>- Não.
<p>- Nem A Garota Quedinha?
<p>- Não.
<p>- Não tem graça falar com você. – Jason fechou a cara.
<p>- Eu não vivo te colocando apelidos.
<p>- Mas é logico, não temos tanta intimidade assim para você me chamar de Gatinho.
<p>- Como se um dia eu fosse chamar você assim.
<p>- Pão doce também serve, você pode escolher. – Jason riu enquanto Temperance ficava mais brava.</p>
<center><h4>--*--</h4></center>
<p>- Acho que eu devo desculpas a ele. – Brandon estava conversando com Lisa no pátio depois da aula. – Eu meio que provoquei.
<p>- O Jason é meio esquentado, mas eu acho que vocês dois cometeram erros.
<p>- Sabe, depois de tudo o que fizeram comigo, eu tenho esse problema de julgar todo mundo por quem eu acho que elas são.
<p>- Só porque um é imbecil, não quer dizer que todos são. O Jason é muito legal e quando o conhecer melhor, você vai perceber isso.
<p>- Espero que ele me dê uma chance. Se é importante para você, também é importante para mim.
<p>- Você e suas frases impactantes. – Lisa ficou sem graça.
<p>- Se quiser, eu paro.
<p>- Não, tudo bem. É que as vezes eu fico confusa.
<p>- Como assim?
<p>- O que estamos fazendo? Estamos passando tanto tempo juntos e eu gosto disso, mas vai ser só isso, bons amigos?
<p>- Me desculpa, mas eu não sou muito... – Brandon ficou nervoso de repente. – Eu não... eu não sei dar uma iniciativa. Timidez é um grande problema meu.
<p>- Você gosta de mim?
<p>- D-demais. – Brandon gaguejou. – Gosto muito.
<p>- Eu também. Não vejo porque esperar.
<p>- Esperar para quê? – Brandon estava meio assustado.
<p>- Para nos beijar. – Lisa se aproximou mais e roubou um beijo de Brandon.
<p>Era para ser perfeito, se alguém não viesse interromper.
<p>- Pessoal, Bran, Lisa, vocês não vão acreditar. – Maddie estava sem folego, ela com certeza tinha vindo correndo.
<p>- Maddie, o que aconteceu? – Brandon ficou assustado.
<p>- Eu estava na aula e uma amiga minha me convenceu a ler o blog da escola e acabou de sair uma coisa.
<p>- É sobre o Jason? Ele vai pirar mais ainda. – Lisa ficou preocupada.
<p>- Bom, ele não é foco agora.
<p>- De quem estão falando? – Brandon ficou curioso e ao mesmo tempo continuava assustado.
<p>- Brandon, você vai se surpreender. – Maddie deu seu celular para Brandon e Lisa lerem a notícia.</p>
<br>
<p><i>“<b>UMA QUEDINHA BÁSICA?</b> Sério, gente? Agora sabemos porque Temperance e Lisa não são melhores amigas para sempre. Bom, para quem não sabe, elas estão disputando o mesmo homem, e não, gente, não é o nosso garanhão Jason, é alguém ainda melhor, nosso Cachinhos de Chumbo, Brandon (ouvi esse apelido em algum lugar e adorei, vou adotar). É isso mesmo, fontes dizem que nossa Tempe já superou o grande amor que sentia por Brandon, mas eu duvido já que ela nunca ficou com ninguém e sempre fica na cola do garoto. Bom, eu aguardo mais notícias desse triangulo que eu mal conheço e já amo. E você, Jason? Vai confessar que ama a Lisa para o lance todo virar um quadrado amoroso? Esperamos que sim, assim você tem um papel na história.”.</i> – Tesouro de Segredos Obscuros.</p>
<br>
<p>- Nunca! – Jason estava se sentando na carteira para assistir a aula quando pegou o celular para ler o post do blogueiro. – Como aquele filho de uma mãe descobriu?
<p>- Para quem você disse? – Temperance entrou na sala de aula alterada. Estava todo mundo olhando para ela e quase rindo.
<p>- Para ninguém. – Jason tentou acalmar ela. – Tempe, eu juro.
<p>- Então como ele descobriu?
<p>- Eu não sei. Eu nunca contaria nada.
<p>- Você é um imbecil e eu não acredito que cheguei a pensar que você era confiável. – Temperance saiu da sala chorando.
<p>- Tempe! – Jason gritou, mas não conseguiu impedir ela de ir embora.</p>
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
            if (condicao + 1 > 5)
            {
                Navigation.PushModalAsync(new Capitulo2Page(condicao + 1));
            }
            else
            {
                Navigation.PushModalAsync(new Capitulo1Page(condicao + 1));
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

                if (condicao == 1 && status == "true")
                {
                    var listAsync = await service.mostrarQuantidadeLeituras("SegObscuros");

                    if (listAsync != null)
                    {
                        var contagem = Convert.ToInt32(listAsync.Quantidade);

                        await service.SomarLeituras(new QuantidadeLeituras()
                        {
                            Quantidade = contagem + 1
                        }, "SegObscuros");
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