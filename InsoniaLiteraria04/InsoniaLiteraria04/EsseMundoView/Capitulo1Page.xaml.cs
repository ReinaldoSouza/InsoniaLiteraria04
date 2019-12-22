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
	public partial class Capitulo1Page : ContentPage
	{
        DBFire service;
        public int condicao;

        public Capitulo1Page (int numero)
		{
			InitializeComponent ();
            service = new DBFire();
            condicao = numero;
            mostrarCapituloSalvo("EsseMundoVaiMudar", "Capitulo" + numero.ToString());

            if (numero == 1)
            {
                lblTitulo.Text = "Capítulo 1 - Emily";
                htmlPage.Html = @"<html><body>
<p><i>“Eu espero que tenha valido a pena esperar
<br>Porque essa foi a única vez que senti algo real
<br>Tempestades nunca puderam me parar
<br>Porque não há ninguém no mundo como a Emily”
<br><b>Emily – From First to Last</b></i></p>
<br>
<p>Los Angeles estava tendo o dia mais quente do ano. O que não dizia muita coisa já que fazia sol praticamente todos os dias do ano independente de ser verão, outono, primavera ou inverno.</p>
<p>Naquela manhã, Will estava andando de um lado para o outro em frente ao portão de desembarque no aeroporto, olhando para seu relógio de pulso de dois em dois minutos. Morrendo de raiva porque o voo da sua mãe atrasou devido à turbulência, mal tempo ou qualquer outra coisa que ele não se importava naquela hora. Sua mãe havia viajado para Flórida três semanas atrás para cuidar da sua avó já de idade que havia pegado uma gripe muito séria. Ela era uma bola filha, Will pensou.
<p>Will tinha pegado “a sorte grande”. Ele havia sido o primeiro filho a acordar naquele dia e encontrar seu pai todo apressado na sala de estar, com um copo de café na mão direita e as chaves do carro na outra dizendo que um dos filhos teria que ir buscar a mãe no aeroporto porque ele tinha que ir trabalhar mais cedo por causa de algum problema com alguma cantora infeliz. Ele era um produtor musical em uma gravadora no centro da cidade. Will foi obrigado a se voluntariar.
<p>Pessoas saíam do portão de desembarque o tempo todo, mas nenhum sinal da sua mãe. A maioria era turista, ele percebeu. Começavam a tirar fotos mesmo dentro do aeroporto e pareciam muito felizes tirando férias. Ali era um ótimo lugar para tirar férias, fazia muito sol o tempo todo, havia vários lugares para lazer e a praia era ótima.
<p>Will particularmente gostava de morar ali. Era bom ir para a praia todos os dias, mesmo ele nunca ter presenciado um dia de neve e sempre ter a impressão de que todos ao seu redor olhava cada pedaço da cidade como se fosse a última vez. Ele achava isso estranho às vezes, mas ele não ligava mais, já estava acostumado.
<p>Com o passar do tempo, aquele lugar começou a encher mais de gente. Ele resolveu sair para tomar um ar, estava muito quente. Se sentou em um banco no ponto de ônibus na frente do aeroporto. De onde estava, podia ver seu carro estacionado do outro lado da rua. Ele ficou um tempo olhando para o carro até que uma coisa fez ele mudar a direção da sua visão.
<p>Uma garota, de mais ou menos quinze ou dezesseis anos, estava parada quase no meio-fio, com várias malas no chão ao seu lado e gritando algo que ele não conseguia ouvir. Estavam a uns vinte metros de distância um do outro.
<p>- Tudo bem? Precisa de ajuda? – Ele foi até a garota.
<p>- Ah, eu só preciso pegar um táxi. – Ela sorriu.
<p>- Gritando? – Ele se segurou para não rir. – Você não é daqui, não é? – Apesar daquele jeito estranho de tentar pegar um táxi, seu sotaque dizia que ela era do Sul.
<p>- Não. – Ela ficou com vergonha.
<p>- Eu vou te ajudar.
<p>- Não precisa...
<p>Mas mesmo assim, Will continuou lá ao lado dela por alguns minutos. Os dois ficaram em silêncio até ele avistar um táxi se aproximando. Então foi até quase o meio da rua e fez sinal para o taxista parar.
<p>- Eu nunca ia conseguir fazer isso. – Ela riu.
<p>A garota pegou todas as malas do chão para levar até o porta-malas, mas derrubou uma sem querer no pé de Will.
<p>- Ai, me desculpa.
<p>- Tudo bem.
<p>- Foi mal mesmo, eu sou... muito atrapalhada às vezes. – Ela falou sem graça.
<p> -Tudo bem. – Ele insistiu.
<p>Will se abaixou e pegou a mala do chão. Depois pegou as outras malas da mão da garota e as levou para o porta-malas do carro.
<p>- Muito obrigada. Eu te machuco e você ainda me ajuda.
<p>- Somos assim na Califórnia. – Ele sorriu.
<p>Will abriu a porta do carro.
<p>- Quer um conselho?
<p>- Qual? – Ela ficou curiosa.
<p>- Eu menti, não somos assim na Califórnia. Da próxima vez, não deixa um estranho pegas as suas malas, pode ser perigoso.
<p>- Anotado.
<p>- E não fale com estranhos também.
<p>- Tudo bem. – Ela sorriu.
<p>- Eu sou o Will, a propósito. – Ele estendeu a mão para ela. – Caso a gente se encontre por aí e você queira aceitar o meu conselho de não falar com estranhos. Assim eu não sou mais estranho.
<p>- Muito prazer, Will. – Ela apertou a mão de Will e entrou no carro.
<p>- Você sabe para onde ir? – Ele parecia mesmo preocupado.
<p>- Tenho o endereço anotado.
<p>- Tudo bem.Então se cuida. – Ele fechou a porta do carro para ajudá-la.
<p>Will não teve muito tempo para ficar pensando na garota quando o táxi foi embora. Sua mãe apareceu minutos depois na entrada do aeroporto o gritando. Ele a ajudou com as malas e foram para o carro. Ela não parou de falar da Flórida na viagem de volta, como se quisesse compensar as conversas de três semanas.</p>
<center><h4>--*--</h4></center>
<p>A chegada da mãe em casa foi uma festa. Will percebeu que sentia falta das coisas simples como um abraço e até mesmo a voz dela. Amanda havia feito o almoço de comemoração. Matthew que havia acabado de sarar de uma virose estava todo feliz olhando para a mãe. Chris, que ainda estava segurando um livro de física, esperava pela mãe na porta.
<p>A mãe se sentou no sofá com os filhos e o marido e começou a contar tudo sobre a viagem, tudo que Will já havia ouvido. Ele preferiu então subir para o quarto.
<p>Seu celular tinha algumas mensagens não lidas. A maioria era de Jason, seu melhor amigo, o lembrando sobre a festa que teria na praia à tarde perto do pôr do sol. Era uma tradição escolar. Todos os anos, no último dia de férias, os alunos de todos os anos da escola Baltimore faziam uma festa na praia para comemorar mais um ano letivo. Jason odiava essas festas, mas Will sempre o convencia de ir.
<p>Ele resolveu deitar por mais um tempo e quando fechou os olhos lembrou da garota. Ele a imaginou perdida em Los Angeles sem saber onde estava e sem conseguir pegar um táxi. Foi engraçado no primeiro momento.</p>
<center><h4>--*--</h4></center>
<p>Som alto, copos descartáveis com bebidas alcoólicas, todo mundo dançando, se beijando, entrando no mar de roupa e tudo. Esse era o cenário da festa naquele ano. Will, Jason e Sebastian estavam sentados na areia um pouco distantes de todo mundo só observando.
<p>- Giovanna já falou com você? – Sebastian perguntou sorrindo para o Will.
<p>- Sim, ela me deu uma bebida. – Will mostrou o copo vazio. Ele havia jogado a bebida na areia. – E sorriu.
<p>- Ela quer voltar. – Jason falou.
<p>- Ela sempre quer voltar. – Will reclamou. – Acho que eu vou dar uma volta, essa festa está uma droga.
<p>- Você nos convenceu a vir. – Sebastian falou. – Você está meio estranho hoje. Parece que está longe.
<p>- É, minha cabeça definitivamente não está nessa festa. – Ele se levantou. – Seb, a gente se vê em casa. Jason, a gente se vê amanhã.
<p>- Tudo bem. – Jason achou estranho, mas não contestou.
<p>Will jogou o copo no lixo, caminhou na direção oposta da multidão para evitar olhares e perguntas, segurou seus chinelos e começou a andar pela beira da praia. O sol começou a se por e a praia ficou digna de uma visão de cinema, mas não foi isso que deixou ele surpreso ou o fez dar um sorriso sem perceber.
<p>Ela estava caminhando também vindo em sua direção. O cabelo amarrado em um rabo de cavalo e olhando para os pés, o motivo pelo qual ela não o viu até ele a gritar.
<p>- Ei, garota do táxi!
<p>Ela o encarou por alguns segundos e Will achou que ela não se lembraria dele, e então ela também sorriu.
<p>- Olha só, veio me ajudar aqui também?
<p>- Depende. Eu não sei nadar, então se sua ideia de ajuda é eu impedir você de se afogar, então você vai ficar desapontada.
<p>- Alguém que mora na praia e não sabe nadar? Você é uma fraude.
<p>- Já ouvi muito isso. – Ele brincou. – O que está fazendo aqui?
<p>- Não posso vir à praia?
<p>- Não é isso, é que... – Ele ficou um pouco sem graça. – Horas atrás você mal sabia pegar um táxi. Olha só para você andando sozinha pela praia.
<p>- Um progresso. – Ela debochou. – Eu só estou conhecendo o lugar.
<p>- Nunca veio para Los Angeles?
<p>- Nunca.
<p>- Você é de longe então.
<p>- Nashville, Tennessee.
<p>- Nossa. – Will não conseguiu disfarçar a surpresa.
<p>- O quê? – Ela ficou curiosa.
<p>- Ah, você sabe o que dizem. Pessoas do sul andam com camisa xadrez, chapéu de palha, sarda no rosto, garotas de maria-chiquinha, garotos com jeans remendados, sotaque, banguelas. Pelo menos, o sotaque você tem.
<p>Ela começou a rir com o que ele disse.
<p>- Olha só quem fala, o cara com camisa xadrez.
<p>- Bem observado. – Ele olhou para a sua roupa e ela tinha razão. Ele estava com uma camisa xadrez. – Está aqui de férias?
<p>- É um interrogatório? – Ela sorriu.
<p>- Não, é só um jeito terrível de tentar puxar papo. Eu posso ir embora, mas... Quer caminhar comigo?
<p>- Por que não? – Ela deu de ombros e começou a andar na frente. Ele ficou alguns segundos parado rindo sozinho e então a acompanhou.
<p>O sol já estava quase desaparecendo e a brisa do mar estava mais gelada.
<p>- Deixa eu adivinhar? Seus pais tem uma grande fazenda com celeiros e galinheiros e cavalos e essas coisas. – Ele brincou.
<p>- A fazenda é dos meus avós na verdade. E sim, tem tudo isso aí que você falou e é perto de uma cachoeira.
<p>- Nossa, minha praia não pareceu tão legal agora.
<p>- Tudo bem, é a minha vez de adivinhar. Você é o típico californiano.
<p>- Senti um preconceito nessa frase. Tipo quando eu disse da maria-chiquinha e sardas... saquei. – Ele abaixou a cabeça e riu. – O que é um típico californiano?
<p>- Alto, loiro, se acha um astro de cinema e pelo seu bronzeado, você deve surfar toda tarde ou joga vôlei.
<p>- Você não está de toda errada. É, eu sou alto, loiro, eu poderia sim ser um astro de cinema, esqueceu de mencionar meus olhos claros. – Ele riu. – Mas não, eu não surfo nem jogo vôlei. Eu gosto de sentar na areia às vezes, olhar a praia, clarear um pouco a mente. Você não esperava por isso, não é?
<p>- Para você virar o homem perfeito só falta dizer que chora vendo o pôr do sol.
<p>- Também não precisa forçar.
<p>Os dois começaram a rir.
<p>- Eu não estou de férias. Acabei de me mudar. Meus pais vieram primeiro para se instalarem e eu vim em seguida. Era para eu ter vindo com a minha irmã mais velha, mas a ficha dela ainda não caiu.
<p>- Por que se mudaram ?
<p>- Isso não é o tipo de coisa que eu diria para um estranho.
<p>- Eu não sou um estranho.
<p>- Eu não te conheço.
<p>- Claro que conhece. Eu sou o Will, o cara que poderia ser um astro de cinema. Eu adorei esse elogio, vou usar sempre.
<p>- Cala a boca, não foi um elogio.
<p>- Tudo o que importa é como eu encaro isso.
<p>- Se faz você se sentir melhor...
<p>- Você vai se dar bem aqui.Depois que se acostumar, não vai mais querer ir embora.
<p>- Eu não sei. Minha família toda está lá, meus tios, meus avôs, meus primos, meus poucos amigos que eu consegui fazer. Eu não conheço ninguém aqui.
<p>- Prazer, eu sou Will.
<p>- Além de você. Deixa de ser bobo.
<p>- Você está vendo isso do jeito errado. Você me conhece e na minha humilde opinião, é a melhor companhia que alguém poderia ter.
<p>- Você é muito convencido, sabia?
<p>- Eu costumo ouvir muito isso. – Ele sorriu.
<p>Depois de um tempo, ela percebeu que já havia anoitecido e demostrou um pouco de preocupação no rosto.
<p>- Já está tarde. Eu preciso ir para casa.
<p>- Quer que eu vá com você? Não é muito seguro uma garota sulista andar por aí sozinha à noite.
<p>- Não precisa.
<p>- Encare como uma segunda ajuda. Claro que se um dia eu precisar de um rim, eu vou te cobrar, mas...
<p>Ela voltou a rir.
<p>- Você é muito bobo.
<p>- Eu sou, não é? É uma coisa que vem de dentro. – Ele sorriu.
<p>Os dois se afastaram da praia, calçaram os chinelos e foram para a rua. A garota não morava muito longe dali. Não demorou nem cinco minutos até eles chegarem na casa dela. Uma vila onde todas as caras eram parecidas, quadradas, com um grande jardim, portões de madeira e dois andares. A casa dela era a amarela no final da rua.
<p>- Chegamos. – Ela avisou. – Você quer entrar? – Ela não sabia muito bem se era certo perguntar aquilo.
<p>- Não. Afinal não vai ser legal você me apresentar aos seus pais no nosso primeiro encontro.
<p>- Que encontro?
<p>- Não era um encontro? Eu fui iludido essa tarde toda? – Ele franziu a testa.
<p>- O quê? Mas eu achei... – Então ela percebeu que ele estava fingindo. – Cala a boca.
<p>- Viu? Ator de cinema. – Ele apontou seus dois dedões para seu rosto.
<p>- Eu vou entrar antes que você fale outra bobeira.
<p>- Quer que eu venha aqui amanhã de manhã e vá com você até a escola? Mais uma ajuda na lista, eu posso um dia precisar de medula também.
<p>- Como sabe que vamos estudar na mesma escola? Ou como sabe que eu vou para a escola?
<p>- Porque eu sou um bom stalker, dãhn. – Ele riu. – Eu só deduzi. Moro uns dez minutos daqui e eu só conheço uma escola nessa região. A não ser que você não vá para a escola o que eu acho difícil.
<p>- Tudo bem.
<p>Por algum motivo, a resposta dela deixou Will surpreso.
<p>- Tá bom, então. – Ele sorriu. – Espera um pouco, eu não sei seu nome. Como eu vou te chamar? Se eu aparecer aqui amanhã gritando “garota do táxi” vai ser meio estranho.
<p>- É Emily.
<p>- Muito prazer, Emily. A gente se vê amanhã.
<p>- A gente se vê.
<p>- Ah, e outra coisa. Não mostre para estranhos onde você mora, pode ser perigoso. – Ele brincou.
<p>- Mas você não é um estranho. Você é o Will.
<p>- Isso, garota. Está aprendendo.
<p>- É, eu estou. Tchau.
<p>Will ficou observando Emily entrar em casa e então foi embora. Ele passou pela praia, a festa ainda estava rolando, de longe não conseguiu encontrar Jason ou Sebastian no escuro então resolveu ir para casa, ele havia demorado, não tinha como os dois ainda estarem lá o esperando.
<p>Ele se esquivou da família que estava jantando quando chegou em casa e foi direto para o quarto. Não queria conversar com ninguém naquele momento.
<p>Se deitou na cama, colocou seus fones de ouvido e ligou a música no último volume. Ele sempre fazia isso quando estava com a cabeça cheia, mas naquele dia, não era por um motivo ruim, era por um bom, um muito bom. Ele só queria dormir para poder acordar logo e vê-la de novo, era estranho, diferente, mas bom, muito bom.</p>
</body></html>";
            }

            if (numero == 2)
            {
                lblTitulo.Text = "Capítulo 2 - O Céu é Mais Azul em Malibu";
                htmlPage.Html = @"<html><body>
<p><i>“Eu sempre pensei que me afogaria então nunca nadei
<br>Eu nunca andei de barco, eu não sei como eles flutuam
<br>E às vezes eu fico com medo do que eu não consigo entender
<br>Mas aqui estou eu do seu lado
<br>O céu é mais azul em Malibu”
<br><b>Malibu – Miley Cyrus</b></i></p>
<br>
<p>“Alguém uma vez me disse que todos nós precisamos de um escape e que não existe bem uma regra para o que escape significa. Pode ser alguém, alguma coisa, algum lugar. Algo que te faz fugir da realidade por um tempo, que faz você não ficar olhando para o relógio ansioso para as horas passarem, na verdade você poderia continuar para o resto da vida. Algo que te provoca algum ou vários sorrisos espontâneos, algo que te faz ser você mesmo. Todo mundo precisa de um escape uma hora ou outra.”.</p>
<br>
<p>Will mal conseguiu dormir.
<p>Quando finalmente fechou os olhos, o sol estava começando a bater na sua janela e alguns minutos depois seu despertador já estava tocando, mas diferente do que ele poderia imaginar, não estava cansado.
<p>Na verdade, ele pulou da cama assim que ouviu a primeira campainha do telefone. Algo que não acontecia com tanta frequência. Ele foi direto para o banheiro tomar banho antes que algum dos seus irmãos fosse primeiro, o que geralmente acontecia, ele sempre era o último a levantar e o último a se arrumar, por isso Christopher ficou surpreso quando foi para o banheiro e a porta já estava trancada, ainda por cima ouviu um grito do irmão dizendo que já estava quase saindo.        
<p>Amanda, que tinha um banheiro só para ela, já estava na mesa tomando café da manhã quando Will desceu correndo as escadas com a mochila já nas costas. Sua mãe estava no fogão terminando as panquecas.
<p>- Onde esteve ontem? – Amanda era muito curiosa. Will sabia que ela ia acabar perguntando aquilo em alguma hora do dia.
<p>- Eu estava na festa como todo ano.
<p>- Sebastian falou que você foi embora cedo e mesmo assim ele chegou em casa primeiro.
<p>- Você não é minha mãe. – Will olhou com uma cara feia para ela enquanto colocava café no seu copo.
<p>- Mas eu sou e também quero saber. Não costuma mais ter horário para voltar? O que seu pai fez com você na minha ausência? – Sua mãe, que carregava uma tigela grande de panquecas, se juntou aos dois na mesa.
<p>- Eu só fui dar uma volta pela praia. Eu sempre faço isso. – Will tentou deixar a conversa um pouco casual.
<p>- Sozinho? – Sua mãe forçou.
<p>- Sim.
<p>- Você mente muito mal. – Amanda o encarou.
<p>- Foi com a Giovanna?
<p>- O quê? Não. – Will não gostava nem de imaginar aquilo.
<p>- Então quem? – Amanda insistiu. Ela também se mostrou aliviada pela cara que Will fez quando sua mãe mencionou Giovanna.
<p>-Ninguém. Olha, eu estou atrasado. Eu tenho que ir.
<p>- O quê? Mas você...
<p>Will encheu suas mãos com torradas e bolinhos, tomou seu copo de café em uma golada só e se despediu.
<p>- Para onde você vai tão cedo? Não é para a escola. – Amanda logo falou.
<p>- Eu preciso ir para a biblioteca... pegar um... livro! – Will gritou já da porta com a boca cheia.
<p>- Que mentiroso! – Amanda revirou os olhos não comprando a mentira do seu irmão.
<p>Will sabia que sua mãe não ia mais perguntar sobre aquilo, ela não gostava muito de se meter na vida do filho, mas sua irmã sim. Amanda não ia desistir até ouvir Will falando de Emily e de todos aqueles detalhes, mesmo não sendo nada demais aparentemente.
<p>O dia amanheceu muito bem. O céu ensolarado como sempre, pessoas caminhando ou correndo na beira da praia, crianças andando de bicicleta, skates, patins, e turistas, muitos turistas por toda a parte. Will chegou na casa de Emily após quinze minutos de caminhada. Ele não sabia se devia tocar a campainha ou simplesmente gritar por ela.
<p>“Será que ela achou que eu estava brincando quando disse que a levaria até a escola?”.
<p>Ele ficou parado do outro lado da rua por alguns segundos, até parecia que estava com medo. Tolice. E então ela apareceu abrindo a porta da casa e saindo. Parecia mais bonita do que da última vez que ele a viu. Talvez porque estava toda arrumada. Não, não era isso.
<p>- Bom dia! – Will abriu um grande sorriso e falou bem alto ainda do outro lado da rua quando ela saiu no portão.
<p>- Bom dia. – Ela retribuiu o sorriso.
<p>- Estava pensando se eu deveria bater palmas ou te gritar. Qual era a melhor opção?
<p>- Tocar a campainha.
<p>- Essa era a terceira opção. Esqueci de dizer. Vamos?
<p>- Vamos.
<p>Os dois não pararam de falar no caminho até a escola. De coisas bobas até política, a conversa simplesmente fluía. Will percebeu o olhar de surpresa e susto de Emily assim que ela entrou pelos portões da escola.
<p>Segunda-feira era o pior dia naquele lugar, pelo menos na opinião dele. Estava todo mundo eufórico, falante e piorava nas voltas de aulas. Amigos contando uns aos outros sem parar o que fizeram nas férias como se ninguém soubesse, viagens, passeios, festas ou simplesmente um sábado em casa. Era um pouco estressante.
<p>Os corredores estavam lotados, ainda faltavam uns vinte minutos para começar a aula e ninguém costumava entrar na sala mais cedo.
<p>- Você parece um peixe fora d’agua. – Will tentou brincar com Emily para tentar aliviar a tensão.
<p>- Essa escola... tem mais que o triplo de gente da minha antiga... Eu nunca vi...
<p>- Você se acostuma. – Ele tentou confortá-la. – Qual é o número do seu armário?
<p>- Ah, deixa eu ver... – Ela abriu a mochila e pegou um papel no meio de um caderno. Sua confirmação de matricula. – 398.
<p>- Ah, é no outro corredor. Vem comigo.
<p>Will pegou na mão de Emily e juntos cortaram a multidão e foram até o outro corredor.
<p>- Chegamos. – Ele apontou para o armário.
<p>- Onde fica o seu?
<p>- É no outro corredor. Eu quase não uso, na verdade.
<p>Emily começou a observar as pessoas passando. Muitos cumprimentavam Will e a encaravam por alguns segundos, mas não falavam nada sobre ou com ela.
<p>- Você parece ser bem popular. – Ela disse.
<p>- É, eu conheço bastante gente.
<p>- Futebol?
<p>- Não. – Ele começou a rir. – Eu definitivamente não sou um atleta, mas curto uma líder de torcida.
<p>- Ridículo.
<p>- Cadê o seu horário de aula?
<p>- Aqui. – Ela entregou para ele o papel que ela segurava.
<p>- Hum... História, depois Geografia... Matemática... É, seu dia não vai ser tão bom. Eu vou te levar até a sala.
<p>- Não precisa fazer isso. Eu vou te atrasar.
<p>- Eu gosto de chegar atrasado. Faço uma grande entrada.
<p>Ela riu do que ele disse.
<p>- Já que insiste. </p>
<center><h4>--*--</h4></center>
<p>- Quem é ela? – Jason abordou Will em seu armário.
<p>- Quem? – Ele não entendeu.
<p>- Está todo mundo falando que você chegou hoje com uma garota e que não era a Amanda e muito menos a Giovanna.
<p>- Falam demais. – Will pegou o livro de gramática no armário e fechou a porta.
<p>- Não inventam essas coisas.
<p>- Não é nada demais.
<p>- Então a garota existe. – Jason insistiu.
<p>- Eu conheci essa garota na praia ontem. – Will disse para ele, ia descobrir de qualquer jeito, era mais fácil falar logo. – Ela é nova na cidade, só mostrei a escola para ela.
<p>- Bom samaritano?
<p>- Sim.
<p>- Sem nenhuma segunda intenção?
<p>- Até parece que não me conhece. – Os dois começaram a caminhar rumo a sala de aula.
<p>- Eu te perguntei exatamente porque te conheço. Por que eu não vejo você mostrando a escola para todo mundo? Por que ela é especial?
<p>-Ela não é especial. – Will continuou insistindo na história do desinteresse.
<p>- Me conta. – Jason encarou o amigo. – Nome, como ela é.
<p>- O nome dela é Emily. Como ela é? Ela é... linda, isso que você quer saber? Eu nem conheço a garota direito. Não é nada.
<p>- Se você está dizendo, eu acredito.
<p>- Quando eu fui legal com você antes de sermos amigos, ninguém me perguntou se eu estava interessado por você, então para.
<p>- Já parei. – Jason deu um sorriso de leve.</p>
<center><h4>--*--</h4></center>
<p>Como sempre, Will estava achando aquela aula uma droga. Ficava batendo o pé no pé da mesa e a ponta da caneta na carteira. Olhava para o relógio de cinco em cinco minutos. Claro que também poderia ser pela ansiedade de se encontrar com Emily, mas ele não admitiu isso quando Jason brincou cochichando atrás dele dizendo que a garota não ia fugir.
<p>O sinal do fim da aula tocou.A maioria dos alunos respirou aliviada. O barulho de materiais sendo colocados na mochila aumentou. Will, que já havia guardado tudo fazia tempo, saiu da sala bem depressa e sem falar com ninguém, quis evitar mais perguntas de Jason, e foi direto para a sala onde Emily o esperava.
<p>E foi assim por mais três aulas. Jason odiava falar enquanto o professor dava aula, então não conseguiu fazer perguntas que o amigo não queria responder.
<p>No final da quarta aula, todos foram em direção ao refeitório. A sala de Emily estava vazia.
<p>“Droga, será que ela está bem?”
<p>“Ela pode ter feito amigos e ter ido almoçar com eles. Isso é bom.”.
<p>Will não sabia se deveria esperar então resolveu ir para o refeitório também. Poderia encontrar com ela por lá. Claro que encontrar Emily no meio de um refeitório lotado seria um desafio. Ele foi para a fila da comida, sempre olhando para todos os lados na esperança de encontrá-la em algum lugar com alguém, mas foi em vão. Will então pegou a comida e foi se sentar na mesa de sempre onde estavam seus irmãos e alguns amigos.
<p>Quando ele chegou lá, todos já estavam comendo enquanto Amanda, que parecia um pouco irritada, contava algo que havia acontecido com ela.
<p>- Aí ela quis roubar o meu lugar, acredita? – Amanda não parava de repetir isso e cada vez mais alto.
<p>- Do que você está falando? – Will se sentou ao lado de Jason e resolveu entrar no assunto.
<p>- Uma garota se sentou no meu lugar na aula de Química. A maior sem noção.
<p>- Claro, porque nem tem outras cadeiras na sala. – Will fez pouco caso daquela “noticia trágica”.
<p>- Não enche, Will. – Amanda jogou uma batata frita nele e ele começou a rir.
<p>- Por que demorou tanto? – Sebastian, que estava sentado de frente para Will ao lado de Amanda, estava acostumado com Will sendo o primeiro na fila da comida.
<p>- Will tem outras preocupações agora. – Jason sorriu.
<p>- Cala a boca. – Will olhou para Jason com cara feia. – Agora me conta, Mandy. Como esse monstro que quis roubar a sua cadeira se chamava? – Will começou a brincar para não precisar responder à pergunta de Sebastian.
<p>- Ai, é uma garota nova. Se chama... – Amanda começou a pensar. – E... Emily.
<p>Jason quase engasgou com o suco.
<p>- Está de brincadeira, não é? – Will não escondeu sua surpresa.
<p>- Por quê? – Amanda não entendeu.
<p>- Por nada.</p>
<center><h4>--*--</h4></center>
<p>Will terminou de comer e saiu da mesa praticamente correndo. Ele sabia onde seria a próxima aula de Emily, tinha decorado o horário dela de manhã. Esperava encontrá-la lá na sala de aula sentada no fundo esperando pela aula começar. E foi exatamente onde ele a achou.
<p>Emily estava na última carteira da parede do lado da janela. Com fones no ouvido e lendo um livro parecendo bem concentrada.
<p>- Você correu, hein. – Will quase a assustou quando se aproximou dela em silêncio.
<p>- Me desculpa não ter te esperado.
<p>- O que aconteceu?
<p>- Eu cheguei aqui e, como eu esperava, eu me senti a pessoa mais deslocada do mundo. No meu primeiro dia, a professora me inventa uma prova em dupla e eu fiz sozinha.
<p>- Sua nota foi ruim?
<p>- A questão não é essa. Eu sei que eu não sou boa para fazer amigos e tal, mas as pessoas também não facilitam.
<p>- Não. Quer saber um segredo? Californianos não são educados. – Ele sorriu.
<p>- É horrível. Até quase uma briga eu arranjei hoje. – Ela estava tão irritada quanto Amanda.
<p>- É, eu...
<p>- Uma louca quase pulou em cima de mim porque eu sentei na cadeira dela. – Ela nem ouviu ele falando. – Até parecia que a sala estava cheia e não tinha mais cadeiras para ela sentar. Como se eu fosse adivinhar onde ela senta. É o primeiro dia de aula, ninguém tem um lugar. É ridículo. – Ela falava inconformada.
<p>- Eu já ouvi essa história no refeitório.
<p>- Já estão falando sobre isso?
<p>- Não, foi a minha irmã que contou.
<p>- Quem é a sua irmã?
<p>- A louca que quase pulou em cima de você. – A cara de espanto que ela fez foi impagável. Will não aguentou e começou a rir.
<p>- Ai, eu não acredito, me desculpe, é sério. – Ela colocou as mãos no rosto com vergonha.
<p>- Não, tudo bem. Ela é louca mesmo.
<p>- Seria cômico se não fosse trágico.
<p>- Olha, vai melhorar. Confia em mim.
<p>- É, vai sim. – Ela respirou fundo.
<p>- E já que você não foi almoçar, imaginei que estivesse com fome. – Will tirou do bolso um bolinho embalado em um guardanapo. – Só que está todo amassado.
<p>- O que vale é a intenção. Muito obrigada. – Ela pegou o bolinho e sorriu para ele.
<p>- Disponha.</p>
<center><h4>--*--</h4></center>
<p>Emily conseguiu convencer Will de que não precisava mais ser acompanhada pelas salas de aula quando já era quinta-feira. Ela estava sozinha em seu armário pegando seu livro de Biologia quando duas garotas se aproximaram dela, como dois gaviões que só estavam esperando ela estar sozinha para atacar.
<p>- Oi, tudo bem? – A garota de cabelos bem pretos sorriu para ela.
<p>- Oi. – Emily foi simpática e retribuiu o sorriso.
<p>- Você está saindo com o Will? Está todo mundo comentando.
<p>- O quê? Não. Eu sou nova aqui, ele só está me ajudando. Somos amigos.
<p>Emily percebeu que a outra garota, a loira, que não falou nenhuma palavra, tentava puxar, em vão, o braço da outra.
<p>- É que... como você é nova, eu achei melhor te dar um toque. Ele não é muito confiável.
<p>- Por que diz isso?
<p>- Bom, o povo comenta, você sabe. – Ela fingiu constrangimento.
<p>- É, nada mais confiável do que um boato. – Emily falou.
<p>- É que, na verdade...
<p>- Emily, oi!
<p>Jason interrompeu a garota e grudou em Emily.
<p>- Que bom que eu te encontrei. Eu precisava mesmo falar com você.
<p>- Ah... – Emily não sabia muito bem o que responder.
<p>- Podemos conversar agora?
<p>- Ah, acho que sim. – Ela franziu a testa. – É só que... – Ela apontou para as garotas.
<p>- Já estamos indo. – A morena olhou para Jason e foi embora com a outra nos seus calcanhares.
<p>- Acredite em mim. Eu te salvei de duas cobras. – Ele sorriu enquanto os dois observavam elas andando pelo corredor como donas do mundo.
<p>- Desculpa, eu conheço você? – Emily ficou um pouco confusa. – Eu sou nova e não decorei os nomes, muito menos os rostos de todo mundo da minha sala.
<p>- Ah, não estudamos juntos. Eu sou o Jason. – Ele estendeu a mão para ela.
<p>- Você é amigo do Will. Ele me falou de você. Eu sou a Emily. – Ela apertou a mão dele.
<p>- É, eu já ouvi sobre você também.
<p>- Me desculpa, eu te imaginava mais magro e mais baixo. – Ela riu.
<p>- Ele costuma me descrever assim. O garoto magricela que ele precisa defender de todo mundo.
<p>- Foram exatamente essas palavras.
<p>- Olha, eu não sei o que aquelas garotas falaram para você, mas elas não sabem de nada.
<p>- Eu imaginei. Pela primeira vez nessa semana, eu encontrei algo aqui em comum com a minha outra escola. Aparentemente, tem gente mesquinha em todo lugar.
<p>- Infelizmente. Quer que eu te acompanhe até a sala?
<p>- Eu vou ficar mal-acostumada assim. – Ela sorriu.</p>
<center><h4>--*--</h4></center>
<p>Will estava esperando na frente da porta da sala de Emily no final da última aula da sexta-feira. Quando ela saiu, os dois se abraçaram e algumas pessoas ficaram olhando quando passaram perto deles.
<p>- E então? Está declarado o fim dessa semana. Como foi? – Os dois começaram a andar.
<p>- Foi horrível. – Emily suspirou.
<p>- Não foi nem um “melhor do que eu esperava”?
<p>- Nunca.
<p>- Imaginei que diria isso. Quer ir a um lugar comigo? – Will perguntou.
<p>- Que lugar?
<p>- Não posso te dizer até chegarmos lá.
<p>- Mistério.
<p>- Confia em mim?
<p>- Bom, você não é mais um estranho... – Ela riu. – Eu não deveria, mas confio.
<p>- Então vamos?
<p>- Vamos.
<p>Os dois foram até a praia, mas não pelo caminho que estavam no dia que se conheceram. Will a levou para um lugar mais distante. O volume de pessoas ia diminuindo conforme andavam para mais longe.
<p>- Para onde você está me levando? – Emily estava muito curiosa.
<p>- Já estamos chegando. Calma.
<p>Uns dez minutos depois eles chegaram. A areia estava praticamente coberta de conchas, as ondas estavam mais calmas e a água era um azul puro cristalino. Havia algumas pedras imensas que percorriam pela areia e iam até um pouco para o mar. Will ajudou Emily a subir em uma delas e foram de uma a uma até a última no meio do mar. Os dois se sentaram com cuidado.Em nenhum momento Emily demonstrou medo e isso surpreendeu Will.
<p>A brisa do mar não era forte como deveria ser, era tudo tão calmo, tudo ali transmitia tranquilidade e paz.
<p>- Lembra quando eu disse que sentava na praia para pensar nas coisas? Não era qualquer parte da praia. – Will sorriu.
<p>- Esse lugar é lindo. – Ela não conseguia parar de se sentir maravilhada.
<p>- Califórnia também pode ser seu paraíso se você souber os lugares certos para ir.
<p>- Eu estou vendo.
<p>- Só tem mais uma coisa.
<p>Will pegou seu celular do bolso da calça e seus fones. Colocou um deles na sua orelha e entregou o outro para Emily.
<p>- Nada como cantar a plenos pulmões nesse lugar. É uma experiencia que eu recomendo. – Ele ligou o celular.
<p>- Que música?
<p>- Vamos deixar no aleatório e ver o que aparece. – Ele apertou o play na primeira playlist que encontrou e esperou pelo melhor.
<p>Assim que começou a tocar, ele sorriu. Conhecia a música de cor e era muito apropriada para aquela ocasião. Os dois ficaram em silêncio por alguns segundos. Will percebeu que ela também conhecia a música, seus lábios se mexiam um pouco enquanto olhava fixamente para o horizonte, ela estava com vergonha.
<p>- <i>Mas eu gosto de pensar que eu posso enganar isso tudo...</i> – Então ele começou a cantar. – <i>Para compensar todas as vezes que eu fui enganado...</i>
<p>- Nossa, você canta muito bem. – Emily ficou impressionada.
<p>- Já me disseram isso. – Ele sorriu. – <i>...Eu não perambulo mais nessas ruas, eu não sou o fantasma que você quer de mim. Se você estiver perdido e sozinho ou afundando como uma pedra... Siga em frente! Deixe o passado ser o som dos seus pés batendo no chão e... Siga em frente!</i>
<p>Ele a encarou.
<p>- Vamos! Só funciona se nós dois fizermos.
<p>- Não.
<p>- Vamos! – Ele insistiu. – <i>Porque nós somos... Somos estrelas cadentes! Somos invencíveis! Nós somos quem nós somos!</i>
<p>- <i>No nosso dia mais escuro, quando estamos longes! Então vamos vir, vamos encontrar nosso caminho para casa...</i>
<p>- Não sou o único que canta bem.
<p>- Cala a boca.
<br>
<br><i>Se você estiver pedido e sozinho ou afundando como uma pedra
<br>Siga em frente
<br>Deixe o passado ser o som dos seus pés batendo no chão e
<br>Siga em frente</i></p>
<br>
<p>Os dois ficaram, música após música, cantando cada vez mais alto. Até que anoiteceu e eles se cansaram. Eles ficaram deitados observando o céu que estava muito estrelado naquela noite.
<p>- Como você está se sentindo agora? – Will finalmente perguntou.
<p>- Incrível. Como fez isso?
<p>- Eu tenho um dom. – Ele brincou. – Sabe, esse lugar... eu chamo de gruta.
<p>- Gruta? – Ela não entendeu o nome.
<p>- Assim ninguém nunca sabe onde fica porque não é uma gruta de verdade. – Ele explicou. – Eu nunca trouxe ninguém aqui. O Jason sabe o que é, mas nunca veio. Você foi a primeira pessoa.
<p>- Por quê?
<p>- Achei que precisava. Primeira semana de aula nunca é legal.
<p>- Obrigada.
<p>- Disponha.
<p>- Vai ficar bem tendo que dividir “a gruta” comigo? – Ela riu.
<p>-  Na verdade, vai ficar até melhor.</p>
<br>
<p>“Um lugar, alguma coisa, uma pessoa. Todos os três juntos na hora certa. É um termo interessante. Não tem um significado fixo, mas mesmo assim significa muito.”.</p>
</body></html>";
            }

            if (numero == 3)
            {
                lblTitulo.Text = "Capítulo 3 - Um Dia Vamos Saber... Por Que Eu Não Fui Feito Para Você... Que Eu Era O Único Para Você";
                htmlPage.Html = @"<html><body>
<p><i>“Um dia vamos saber se o amor consegue mover uma montanha
<br>Um dia vamos saber por que o céu é azul
<br>Um dia vamos saber por que eu não fui feito para você
<br>Um dia vamos saber por que Sansão amou Dalila
<br>Um dia eu vou dançar na lua
<br>Um dia você vai saber que eu era o único para você”
<br><b>Someday We’ll Know – The Radicals</b></i></p>
<br>
<p>“Passamos a vida toda tentando adivinhar o que as outras pessoas pensam e às vezes tentamos mudar os pensamentos delas também. Será que ela vai gostar de mim com essa roupa, com esse cabelo... Será que ela não gosta de mim porque eu disse isso? A gente nunca pergunta, parece que é melhor criar uma teoria do porque do que saber a verdade. É mais fácil desse jeito.”.</p>
<br>
<p>Emily tomou um leve susto quando desceu as escadas e encontrou sua irmã mais velha sentada na mesa tomando café da manhã.
<p>Já fazia um pouco menos de um mês que haviam se mudado e Quinn, sua irmã, ainda estava resistente com a ideia. Tinha feito um escândalo na última noite que seus pais estavam na antiga casa se recusando a se mudar. Ela conhecia muita gente lá e tinha um quase namorado, história complicada.
<p>- O que faz aqui? – Emily se serviu de uma torrada com uma expressão de espanto.
<p>- É assim que você me dá boas vindas? – Quinn sorriu.
<p>- É, é exatamente assim. – Emily riu com a torrada na boca.
<p>-Cheguei ontem à noite, você já estava dormindo.
<p>- Mas...
<p>- Resolvi me juntar à família de novo.
<p>- A vovó estava te tirando do sério, não estava? – Quinn estava ficando na casa da avó delas e Emily sabia que a irmã não aguentaria ficar lá por muito tempo.
<p>- Eu estava quase virando uma cozinheira e me casando com um fazendeiro.
<p>- Exagerada. Já levou a bronca?
<p>- Papai gritou muitas e muitas vezes. Não sei como você não acordou.
<p>- Ainda vai bancar a rebelde sem causa? – Emily se serviu de um pouco de leite.
<p>- Rebelde sem causa, sério? Só você que aceitou tudo isso numa boa.
<p>- Ele precisava desse emprego.
<p>- Sabemos que não nos mudamos por causa de um emprego.
<p>- Olha, eu estou atrasada para a aula. – Emily interrompeu o assunto, não gostava muito de falar sobre aquilo. – Você vem também?
<p>- Não, eu ainda preciso fazer a minha matricula.
<p>- Corrigindo, vai ficar vagabundeando.
<p>- Claro, preciso conhecer a cidade.
<p>- Então até mais tarde. – Emily pegou sua bolsa que estava em cima do sofá.
<p>- Antes me responde uma coisa. Tem muito cara gato aqui na Califórnia?
<p>- Não sei.
<p>- Conheceu alguém interessante?
<p>- Eu já estou indo. – Emily gritou da porta.</p>
<center><h4>--*--</h4></center>
<p>Mesmo depois de três semanas, Emily ainda não estava acostumada com aquela multidão de pessoas nos corredores da escola.
<p>- Senti sua falta hoje na caminhada até a escola. – Will encostou perto do armário da garota para conversar.
<p>- Você adorava minha companhia, não é? – Emily riu. – Mas uma hora eu ia ter que aprender a andar na rua sozinha.
<p>- Olha só minha garota crescendo.
<p>- Engraçadinho. Você não acredita o que aconteceu hoje.
<p>- O quê?
<p>- Minha irmã... Desci hoje de manhã e lá estava ela. Chegou ontem à noite.
<p>- Percebeu que não sentia tanta falta dela assim, não é?
<p>- Como percebeu? – Emily riu.
<p>- A sua cara de animação me deu umas dicas. Achei que sua irmã e você se dessem bem.
<p>- A gente se dá bem.
<p>- Então qual é o problema?
<p>- Nenhum, na verdade.
<p>Will percebeu que ela estava mentindo, mas deixou o assunto morrer.
<p>- Olha, eu tive uma ideia. Que tal você participar da noite dos jogos dos irmãos Jones? Pode trazer sua irmã também.
<p>- O que seria isso?
<p>- Quase todo mês a gente se reúne em uma noite e vai a um bar perto daqui jogar charadas.
<p>- Chama isso de integração familiar?
<p>- É. Evita a gente querer se matar a todo instante. Na verdade, não porque fica todo mundo bem competitivo, então só piora.
<p>- Não, eu não quero ser uma intrusa, além do mais eu nem os conheço.
<p>- Não é por falta de oportunidade. Você foge da cantina que nem diabo foge da cruz. Vamos, vai ser legal.
<p>- Não, deixa para próxima.
<p>- Eu levo o Jason, assim você não fica tão de fora e ainda vai ter a sua irmã. Não me faça implorar.
<p>Will sorriu para Emily. Então ela respondeu.
<p>- Tudo bem, mas não me odeie se eu ganhar. Eu sou muito boa em charadas.
<p>- Eu não vou... deixar você ganhar.</p>
<center><h4>--*--</h4></center>
<p>- Então você chamou uma garota para a nossa noite de jogos?
<p>Will sabia que seus irmãos, principalmente Chris, não ia gostar nada da ideia de ter desconhecidos na noite de jogos, e também sabia que estaria provocando uma discussão nada amigável comentando sobre isso no almoço.
<p>- Teria sido mais fácil levá-la de surpresa. – Will resmungou.
<p>- Já que você está levando a sua namorada do mês, a Ashley vai também. – Chris olhou para a namorada que estava sentada do seu lado.
<p>- Ela não é namorada dele. – Giovanna que estava sentada ao lado da amiga, Ashley, falou com um tom de desprezo.
<p>- Ela não é minha namorada. Ela é uma amiga. Eu só queria fazer ela se enturmar, qual é o problema?
<p>- Nenhum. – Chris praticamente fuzilou o irmão com os olhos.
<p>- Bom, vai ser bom para mim. Finalmente uma garota a mais no bar. – Amanda falou.
<p>Will olhou surpreso para a irmã. Amanda não era a maior fã de Emily e Will quase apostou que a irmã ia ficar emburrada também.
<p>- Já que vai todo mundo, eu posso ir também? – Giovanna então falou.
<p>- Ah, seria muito bom. – Ashley respondeu.
<p>- Maravilhoso. – Naquele momento sim, Amanda ficou emburrada.
<p>- Você vai também? – Will olhou para Jason do seu lado.
<p>- Por favor. – Sebastian que estava do outro lado de Jason também falou.
<p>- Claro, tudo o que eu mais quero nessa vida. – Jason falou.</p>
<center><h4>--*--</h4></center>
<p>- Fala a verdade para mim. O que você estava pensando?
<p>Jason e Will estavam na sala esperando o professor chegar para dar aula.
<p>- Seja mais específico. – Will se virou para trás para olhar para o amigo.
<p>- Você nunca chamou uma garota para a noite dos jogos. Nem quando você namorava a Giovanna ela ia e então de repente... Eu não culpo tanto o Chris assim.
<p>- Foi sem querer, na verdade. Ela estava falando da irmã e aí quando eu percebi já tinha convidado.
<p>- Quando você vai dizer que gosta dela?
<p>- O quê? Eu não gosto dela. Pelo menos, não do jeito que você pensa.
<p>- Ah é?
<p>- É. Senão eu falaria, eu não sou como você.
<p>- O que quer dizer com isso?
<p>- Você sabe exatamente o que eu quero dizer com isso.
<p>Jason abriu a boca para dizer alguma coisa, mas naquele exato momento o professor chegou e ele se calou. Para ele, com certeza foi melhor, e para Will... bom, ele já sabia o que o amigo ia dizer, o que ele sempre dizia quando tocavam nesse assunto.</p>
<center><h4>--*--</h4></center>
<p>Mesmo de cara feia, às sete naquela noite, Chris estava lá no bar sentado em uma das mesas com a sua namorada do lado. Kevin chegou uns cinco minutos depois, e diferente do irmão, ele estava bem animado. Giovanna veio em seguida e também parecia bem animada.
<p>Will, Jason, Sebastian e Amanda chegaram juntos. Will se sentou o mais longe que pode de Chris, mesmo estando na mesma mesa, e torceu para não haver uma guerra até o fim da noite.
<p>Quando Emily e Quinn chegaram, Will se levantou e foi até elas ignorando a bufada que Chris deu.
<p>- Emily, oi. – Will sorriu para ela.
<p>- Desculpa o atraso, minha irmã. – Ela apontou para Quinn um pouco irritada.
<p>- E você deve ser a Quinn. Ouvi muito sobre você. Eu sou o Will.
<p>- Engraçado, eu não ouvi nada sobre você. – Quinn piscou para ele.
<p>- Na verdade, eu pedi sigilo.
<p>- Foi o que eu imaginei.
<p>- Querem parar de graça? – Emily ficou envergonhada enquanto os outros dois riram.
<p>Will levou as duas até a mesa e foi um momento bem constrangedor quando todos ficaram se olhando em silêncio. Quinn e Emily se sentaram na mesa ao lado de Will enquanto Chris fingia que só sua namorada estava lá. Amanda então chamou o garçom para fazer o pedido.
<p>Foi a meia-hora mais longa da vida daqueles garotos. De vez em quando alguém comentava algo sobre a escola ou noticias que ouviram ou viram na televisão naquele dia.
<p>- Nossa, vocês são os irmãos mais chatos que eu já vi. Não era isso que eu esperava da Califórnia. – Quinn então falou um pouco impaciente. – São muito bonitos, mas...
<p>- Quinn. – Emily apertou o braço da irmã discretamente.
<p>- Me desculpe, a gente costuma se entrosar mais quando não tem estranhos na mesa. – Chris falou e instantaneamente Will olhou feio para ele.
<p>- Ah, você não sabe lidar com estranhos, então? – Quinn continuou falando. – Na verdade, pela sua cara eu acho que os estranhos que fogem de você.
<p>- Desculpa. – Giovanna levantou a mão como se estivesse em uma sala de aula. – É que o Will nunca convidou outras pessoas e... Eu sou a Giovanna, a propósito, já que ninguém se apresentou.
<p>- Prazer, eu... – Emily falou.
<p>- Nossa. – Quinn a interrompeu. – Como você aguenta ficar com essas pessoas todos os dias? – Ela olhou para a irmã.
<p>- Bom... Acho melhor a gente ir embora.
<p>- Não, por quê? – Amanda falou e Emily se surpreendeu. – Giovanna também nunca foi convidada e não está se sentindo deslocada, não é Giovanna?
<p>- É porque eu já faço parte do grupo.
<p>Amanda revirou os olhos.
<p>- Olha... Emily, não é? – Chris voltou a falar. – Não leve para o pessoal, é que a gente não te conhece e...
<p>- Eu imaginei que isso não seria muito legal.Eu só aceitei o convite porque...
<p>- Você não deve explicações a ele. Em primeiro lugar... – Will já estava farto. – Essa ideia da gente se reunir aqui sempre foi minha e todos nós sabemos, Chris, que você não gosta de estar aqui e só está bancando o bebê chorão porque quer logo ir embora. Em segundo lugar, como sendo a minha ideia, eu posso chamar quem eu quiser chamar. Dito isso, eu estou em um bar e tenho quase dezoito, quem quer ir comigo no balcão beber até cair?
<p>- Eu quero! – Quinn levantou a mão.
<p>- Gente, qual é? – Jason falou. – Era para ser uma noite divertida. Vamos pelo menos tentar?
<p>- Eu cansei.
<p>Will se levantou da mesa irritado e foi para o balcão do bar.
<p>- Eu cuido disso. – Amanda se levantou quando viu que Jason ia se levantar também.</p>
<center><h4>--*--</h4></center>
<p>- Você está bem? – Amanda se encostou no balcão junto com seu irmão.
<p>- Não. Ainda não tenho idade para comprar bebida alcoólica. Eu odeio meu país. – Will bufou.
<p>- Olha, você não pode deixar o Chris te irritar.
<p>- Eu saí antes dele começar a discursar todas as coisas que ele é melhor que eu como em todas as vezes que brigamos. – Will parecia cansado.
<p>- Isso não foi bem uma briga, na verdade, você se estressou rápido demais. Deve estar bem a fim dela.
<p>- O quê?
<p>- Da Emily. Por isso a convidou, não foi? Eu não disse nada, mas também fiquei surpresa.
<p>- Eu não gosto dela, não desse jeito. O que vocês pensam de mim? Eu só tentei ser legal, mas agora eu me arrependo de ter feito isso. Ela é a sortuda por não querer se enturmar.
<p>- Sei lá.
<p>- Olha, eu não estou a fim dela, tá bom? – Amanda não estava comprando aquela afirmação. – Talvez uma queda, só isso. Vai passar.
<p>- Como uma gripe? – Amanda riu. – Devia chamar ela para sair.
<p>- Você odeia ela.
<p>- Eu não odeio ela, só... não gosto.
<p>- Eu não posso chamar ela para sair. – Will começou a olhar para Emily na mesa de onde ele estava. – Assim que descobrir como eu sou, ela sai correndo. Se bem que... se a gente sair, talvez eu nem tenha tempo de falar alguma coisa porque ela vai falar o tempo todo e eu até gosto de ouvir ela falar. Ela faz umas caras engraçadas, é bonitinho.
<p>- Nossa, ainda bem que é só uma queda e que vai passar. – Amanda o policiou.
<p>- Cala a boca.
<p>- Você está com medo de levar um não. É fofo.
<p>- Mas é claro, olha só para ela.
<p>- Estou olhando. – Ela fez pouco caso.
<p>- Ela é perfeita, muito inteligente, vai rir da minha cara quando descobrir o que eu quero fazer no futuro, sem falar que... eu não sou o tipo dela.
<p>- Na verdade, eu acho que vocês combinam. Dois sonsos.
<p>- Até parece.</p>
<center><h4>--*--</h4></center>
<p>Will voltou para a mesa depois de vinte minutos e teve uma surpresa. Chris e Ashley já tinham ido embora com Giovanna e Kevin, e Emily também não estava lá.
<p>- Cadê a Emily?
<p>- Foi embora. – Quinn falou despreocupada.
<p>- Você a deixou ir sozinha a essa hora? – Will arregalou os olhos.
<p>- Sou irmã dela, não guarda-costas.
<p>Will deu meia volta e saiu do bar. Ele estava preparado para sair correndo atrás da garota quando a encontrou sentada em um banco do lado de fora do bar, onde as pessoas geralmente esperavam suas caronas.
<p>- O que está fazendo aqui sozinha? – Will se sentou ao lado dela.
<p>- Eu chamei um táxi, mas até agora ele não chegou.
<p>- Ainda bem que achei. Queria me desculpar pelo fiasco de hoje à noite.
<p>- Tudo bem.
<p>- Não, não está não. Meus irmãos e eu, é que... a gente não se dá muito bem.
<p>- Sério? Eu nem percebi. – Emily brincou.
<p>- Às vezes, eu tento me aproximar, mas tem vez que não dá e eu acabo...
<p>- Levantando da mesa e bebendo todas?
<p>- A parte da bebida foi só para dar um clima melhor. Um drama completo. – Ele riu para tentar aliviar a tensão.
<p>- Eu te entendo.
<p>- Mas você e a sua irmã...
<p>- Somos muito próximas, é verdade, mas às vezes, pelo menos da minha parte, é um pouco difícil conviver com ela.
<p>- Por quê?
<p>- Nada, é bobagem, coisa de garota.
<p>- Eu adoro ouvir coisas de garota.
<p>- É difícil ficar perto dela. – Emily hesitou antes de falar. – Ela é corajosa e determinada, enfrenta as pessoas, e é engraçada e divertida e bonita, todos gostam dela e eu só sou a Emily, a que tira notas boas.
<p>- Tem razão. É bobagem.
<p>- Olha... – Will começou a rir. – Eu não conto mais nada para você.
<p>- Emily, isso é ridículo. Sem falar que ser inteligente é uma das coisas mais importantes na vida, não é? Eu ouvi isso a minha vida toda.
<p>- É, mas você não se interessa pela inteligente, pelo menos não à primeira vista.
<p>- Pode ser, mas... está enganada. Você também é divertida e engraçada e mais essas coisas que você disse que ela é. Na verdade, você é muito mais bonita que ela.
<p>- Ah é? – Emily não acreditou.
<p>- É. Na primeira vez que eu te vi, eu tive que me beliscar para saber que não estava sonhando. E aí quando eu cheguei mais perto, eu pensei “eu teria sorte de olhar para esse rosto para o resto da minha vida”. E olha que você estava toda descabelada e vermelha do sol e toda suada e...
<p>- Eu já entendi. E obrigada.
<p>- Eu não estou falando isso só para te animar. Eu ainda teria sorte de olhar para você pelo resto da minha vida.
<p>Emily então ficou em silêncio. Os dois ficaram encarando um ao outro tentando decifrar o próximo movimento do outro.
<p>- Acho melhor eu... eu ir andando. Está ficando tarde – Ela falou sem graça.
<p>- Claro.Quer que eu te leve?
<p>- Eu ia adorar.</p>
<center><h4>--*--</h4></center>
<p>- Boa noite, irmãzinha.
<p>Quinn entrou no quarto de Emily de muito bom humor. A garota se jogou na cama junto com a irmã.
<p>- Chegou só agora? – Emily se ajeitou na cama para caber as duas confortavelmente.
<p>- Cheguei. Seus amigos são legais.
<p>- Eles não são bem meus amigos. Sério que gostou deles?
<p>- Bom, aquele Chris, ele sim é um porre. Já os outros... eles são bem divertidos, principalmente a Amanda, a gente se deu muito bem.
<p>- O quê? – Emily ficou impressionada. Ela ainda não tinha esquecido da “briga” que as duas tiveram no primeiro dia de aula. – Aquela garota é horrível, mas é típico da Quinn.
<p>- “Típico da Quinn”? Como assim?
<p>- Ah, você sabe, sempre foi bem melhor nisso do que eu.
<p>- É, só que você me surpreendeu. Em três semanas, você já arranjou um namorado?
<p>- O quê? – Emily começou a rir.
<p>- Não queria dizer nada, mas você tem um gosto muito bom. – Quinn começou a rir também. – Já contou a ele que nunca beijou ninguém?
<p>- Cala a boca. Primeiro, isso não é verdade, e segundo, ele não é meu namorado. Só somos amigos.
<p>- Ah tá. Claro. – Quinn duvidou.
<p>- É verdade. Quando a gente se conheceu, eu tinha acabado de me mudar para cá e ele só me ajudou a conhecer o lugar.
<p>- Com toda a boa vontade dele?
<p>- Exatamente.
<p>- Você é muito ingênua. Garotos não têm boa vontade.
<p>- Ele não gosta de mim, tá legal?
<p>- Como você sabe?
<p>- Porque... – Mas ela se calou.
<p>- Viu? Você não sabe. Eu aposto que ele gosta.
<p>- Eu não sei, mesmo que ele goste... eu não sei se depois de um tempo, ele gostaria de mim de verdade.
<p>- Ah, qual é, Emily? Para de pensar no futuro. Eu estou falando para você dar uns amassos nele, não casar. Além do mais, por que acha que ele não gostaria de você?
<p>- Porque a gente é bem diferente um do outro. Você tem que ver ele na escola, todo mundo se vira para falar com ele e todas as garotas olham e... e eu estou lá no meio disso de um jeito bem sem graça.
<p>- Vai ver foi esse seu jeito de sonsa que conquistou ele. Talvez seja o tipo dele.
<p>- Cala a boca.
<p>- Emily, ele é bonito sim, mas não é um Deus inalcançável. É claro que você tem chance.
<p>- E quem disse para você que eu quero uma chance?
<p>- Emily.
<p>- Tudo bem, é claro que eu quero. Hoje quando a gente estava lá fora sentado em um banco, ele ficou olhando para mim de um jeito e disse umas coisas que... eu me acovardei.
<p>- Normal.
<p>- E aí, aqui quando ele foi se despedir, eu jurava que ele ia tentar me beijar, mas não tentou, talvez seja porque eu me afastei dele na primeira vez, talvez ele encarou como um sinal negativo.
<p>- Tudo isso teria sido resolvido se você tivesse beijado ele.
<p>- Ficou maluca?
<p>- O quê? Qual é o problema? Você queria. E ele não é obrigado a ler a sua mente.
<p>- Ele disse que poderia ficar me vendo para o resto da vida dele.
<p>Quinn ficou em choque.
<p>- Olha, é oficial. Se da próxima vez que você o ver, não beijar ele, eu beijo e já me caso também.
<p>- Cala a boca.
<p>As duas voltaram a rir.</p>
<center><h4>--*--</h4></center>
<p>Jason estava deitado na cama no seu quarto lendo um livro quando ouviu batidas no vidro da sua janela.
<p>Quando era pequeno, Will escalava a árvore que ficava do lado da janela de Jason e entrava no quarto dele pela janela ou usavam esse mesmo meio quando queriam sair de casa sem a permissão da mãe do garoto. Agora crescidos, o habito continuou.
<p>- O que faz na rua a essa hora? – Jason abriu a janela para Will entrar.
<p>- Eu fui levar a Emily em casa e depois caminhei um pouco para pensar em algumas coisas antes de vir falar com você.
<p>Os dois se sentaram na cama como sempre faziam.
<p>- Está muito bravo com o Chris?
<p>- Não, eu já imaginava que aquilo fosse acontecer. Amanhã vai ser como se nada tivesse acontecido e tudo ao mesmo tempo. Só um sábado normal. – Will deu um sorriso.
<p>- Então o que você teve que pensar tanto nessa caminhada?
<p>- Eu gosto da Emily. Você tinha razão.
<p>- Olha quem não está surpreso. – Jason brincou.
<p>- Mas tem um porém, eu não acho que ela goste de mim desse jeito.
<p>- Eu duvido.
<p>- Não, é sério. Eu dei alguns sinais, mas ela não reagiu, foi como se não tivesse interessada. No fim da noite, eu até pensei em beijá- la, mas senti que eu ia levar um tapa na cara se fizesse.
<p>- Sinais? Que tipo de sinais?
<p>- Ah, você sabe... Quer dizer, você não sabe, na verdade.
<p>- Você não vai voltar essa conversa para mim. Foco em você, senão te jogo pela janela.
<p>- Tudo isso é muito confuso. Sem falar que se ela me der um fora, não vamos mais poder ser amigos.
<p>- Bem-vindo ao meu mundo.
<p>- A diferença é que eu não vou segurar isso por dez anos.
<p>- Você não sabe calar a boca, não é? – Jason bufou. – Eu preciso te falar uma coisa. A Giovanna conversou com a Emily, eu não sei exatamente o quê.
<p>- Essa noite?
<p>- Não. Acho que foi em um dos primeiros dias dela na escola. Eu nem a conhecia.
<p>- Engraçado, hoje as duas fingiram que não se conheciam.
<p>- Ela sabe que...
<p>- Não, é claro que não.
<p>- E o que você vai fazer?
<p>- Eu acho que vou me arriscar. Quer dizer, ela é tão... vale a pena, não vale? Mesmo se eu levar um belo fora.
<p>- Bom, pelo menos você vai ter certeza, mas é estranho, eu nunca te vi tão inseguro assim.
<p>- É que ela me assusta um pouco. E provavelmente, eu não sou o tipo dela.
<p>- Um dia vamos saber.
<p>- É.
<p>Os dois deitaram na cama.
<p>- Jay. – Will encarava o lustre do quarto do amigo.
<p>- Oi.
<p>- Sabe, você podia tentar também. Se arriscar.
<p>- Eu já disse, não vamos falar sobre isso agora.
<p>- Ela gosta de você.
<p>- Você não sabe.
<p>- Eu sou irmão dela, é claro que eu sei.
<p>Jason ficou em silêncio.
<p>- Eu disse que poderia ficar olhando para ela pelo resto da minha vida. Esse foi o meu sinal. – Will tentou segurar a risada junto com Jason.
<p>- Já vai comprar a aliança amanhã? – Jason provocou.
<p>- Vou fazer alguns orçamentos.
<p>Os dois não aguentaram e começaram a gargalhar.</p>
</body></html>";
            }

            if (numero == 4)
            {
                lblTitulo.Text = "Capítulo 4 - Eu Te Desafio A Se Mexer";
                htmlPage.Html = @"<html>
<body>
<p><i>“Todo mundo está aqui, todo mundo está aqui
<br>Todo mundo está olhando para você agora
<br>Todo mundo está esperando por você
<br>O que vai acontecer? O que vai acontecer?
<br>Eu te desafio a se mexer, eu te desafio a se mexer
<br>Eu te desafio a se levantar do chão”
<br><b>I Dare You To Move – Switchfoot</b></i></p>
<br>
<p>A semana começou e terminou como qualquer uma.
<p>O ocorrido da semana anterior no bar havia ficado para trás, ou tinha sido ignorado, por assim dizer. Ninguém mais tocava naquele assunto.
<p>Will fazia o possível para cruzar o caminho de Emily pelos corredores o tempo todo. Ele não podia mais usar uma desculpa esfarrapada para buscá-la em casa para irem para escola juntos, então ficou determinado em correr com o tempo perdido. Ele se metia em umas experiências engraçadas às vezes, como correr pelos corredores que nem um louco só para poder alcançá-la em seu armário ou na porta de alguma sala de aula que ela estaria.
<p>Emily tinha que lidar com Quinn. Todos os dias, antes de sair de casa para a escola era a mesma história, seu pai ou sua mãe brigando com a sua irmã por não terem conseguido fazer a matricula dela na escola imediatamente e que estavam em alguma fila de espera. Não que isso afetasse Emily de alguma maneira, mas era irritante toda hora a mesma história. Ver Will pelos corredores o tempo todo com certeza melhorava o seu humor. 
<p>Ela não tinha feito muitos amigos ainda. Amanda ainda olhava feio para ela às vezes, mas a relação das duas não passava disso. Will e ela começaram a ter o hábito de almoçar sozinhos em uma daquelas mesas escondidas e afastadas do refeitório, um lugar onde ninguém iria chateá-los. E eles se divertiam com isso e muitas vezes a conversa estava tão interessante que perdiam a hora da próxima aula e Emily tinha que sair correndo para não se atrasar.
<p>A novidade chegou no almoço da sexta-feira. Os dois estavam na mesa de sempre almoçando quando uma garota toda sorridente se aproximou e entregou um panfleto para cada um. Tinha vários desenhos de pessoas bebendo e rindo, era muito bem feito. Tinha letras grandes e bem destacadas que diziam “Quem quer festa? Na casa do Mário, sábado, seu ingresso é uma bebida. Tudo liberado!”. O endereço estava embaixo em letras menores junto com o horário onde dizia que começaria à tarde e rolaria até a manhã do domingo. Mário era famoso por dar festas desse estilo nos fins de semana, seus pais estavam sempre viajando a trabalho deixando a casa só para ele.
<p>- Então... você vai a essa festa? – Emily ainda estava com os olhos no panfleto quando Will perguntou.
<p>- Mas é claro. – Ela brincou. – Esse é bem o meu tipo de festa. 
<p>- O que vai fazer no sábado então?
<p>- Ah, ainda tenho umas caixas que eu ainda não abri da mudança, está uma bagunça enorme, você não tem noção.
<p>- Olha, eu poderia me oferecer para te ajudar a arrumar as coisas, mas nem o meu quarto é arrumado, então eu passo.
<p>- Eu imaginei isso.
<p>- Mas eu posso te tirar dessa enrascada.
<p>- Como assim?
<p>- Quer sair comigo no sábado?
<p>- Sair? – Ela estava um pouco desconfiada.
<p>- É, duas pessoas que vão para um lugar para passar um tempo juntos. Achei que você fosse inteligente.
<p>- Engraçadinho.
<p>Will começou a rir.
<p>- E então, o que me diz?
<p>- Eu não sei. O que vai acontecer nesse encontro?
<p>- Bom, não é bem um encontro. – Will olhou para ela – A não ser que você queira que seja.
<p>- Como assim? – Ela não entendeu.
<p>- Deixa para lá. – Ele falou rápido. – Você topa ou não?
<p>- Se eu não topar, o que acontece?
<p>- Vai passar o final de semana inteiro abrindo caixa e sentindo cheiro de poeira. Se você topar, vai ter um dia incrível comigo. E já concordamos faz tempo que eu sou a melhor pessoa.
<p>- Nunca concordamos com isso. – Ela riu. – Mas tudo bem, eu topo. Para onde vamos?
<p>- É uma surpresa. 
<p>Na verdade, não era bem uma surpresa, já que nem Will sabia exatamente o que iria acontecer nesse encontro. Ele conversou com o Jason, Sebastian e Amanda, mas as ideias deles não pareciam alguma coisa que ele faria. Levar alguém a restaurantes caros e coisas relacionadas a velas não era bem o estilo dele, o ápice do exagero foi a ideia de fazer uma serenata à beira da praia.
<p>No fim do dia, ele já estava exausto de tanto pensar e chegou à conclusão que ele precisava relaxar, era só um encontro, ele já tinha feito aquilo um milhão de vezes, ele era o rei dos encontros, mas por algum motivo o nervosismo agora era real e não podia ser nada fora do comum ou forçado demais ou simplesmente interpretar um papel, tinha que ser algo que mostrasse ele como ele mesmo e isso deveria ser o suficiente.</p>
<center><h4>--*--</h4></center>
<p>O sábado amanheceu perfeitamente perfeito. O sol claro e o céu limpo. Estavam conspirando ao seu favor. A praia estava lotada, era de se esperar. Seria interessante para Will encontrar Emily naquele mundão de gente curtindo um sábado de sol na praia. 
<p>Will ficou parado na areia esperando por Emily. Ele se olhou, bermuda, um tênis normal e regata, não era bem uma vestimenta adequada para um primeiro encontro, era? “Ela precisa me conhecer como eu sou e é assim que eu sou.” Pensou ele e várias coisas parecidas passaram pela cabeça dele nos dez minutos seguintes enquanto ele, parado lá, esperava pela garota.
<p>Quando ela apareceu, ele ficou nervoso por mais cinco segundos e então foi como se de repente ele estivesse com tudo sob controle. Emily também não estava super produzida. Seu cabelo estava amarrado em um rabo de cavalo, estava sem maquiagem como de costume, usava short normal e uma camiseta de renda para afastar o calor.
<p>- Para onde vamos? – Foi a primeira coisa que ela falou quando se encontraram.
<p>- Isso é uma surpresa. – Will continuou com o suspense.
<p>- Surpresa, é? Eu vou precisar fechar os olhos?
<p>- Garota, você é tão desastrada que se você andasse de olhos fechados por dois segundos, eu teria que te segurar para não tropeçar no seu próprio pé.
<p>- Pior que é verdade. – Ela começou a rir.
<p>- Você não precisa fechar os olhos. Na verdade, eu quero seus olhos bem abertos para você apreciar a vista, e quando eu digo vista, eu quero dizer, eu. – Ele abriu um largo sorriso.
<p>- Já vi melhores.
<p>- Eu duvido.</p>
<center><h4>--*--</h4></center>
<p>O píer de Santa Mônica era perfeito para um primeiro encontro. Era um lugar perfeito para andar de roda-gigante, comer churros ou frutos do mar, comprar lembrancinhas, colares e pulseiras feitas de conchas e pescar. Claro que os dois não iam pescar naquele momento. Uma das coisas que Will mais gostava daquele lugar era a vista. Ficar em frente ao Oceano Pacífico enquanto se divertia em um parque de diversão era uma das melhoras coisas da vida dele.
<p>- Esse lugar é muito bonito. – Emily estava encantada olhando tudo.
<p>- É sim. Claro que de onde você veio existem paisagens melhores.
<p>- De onde eu vim? Fez eu me sentir um ET agora. 
<p>- Foi essa a intenção.
<p>Os dois começaram a rir.
<p>- Você já pescou aqui?
<p>- Mas é claro. Eu adoro ficar aqui o dia todo no sol sem fazer nada esperando que um peixe fisgue um anzol. Parece ser tão estimulante. – Will odiava qualquer coisa que tivesse que sentar e esperar. 
<p>- De onde eu vim... – Ela brincou. – Tem um lago cheio de peixes, dá até para você pegar com a mão alguns deles.
<p>- Me deu uma agonia só de imaginar. 
<p>- Você é muito fresco. – Emily levantou a sobrancelha. 
<p>- Já me disseram isso. Você quer comer alguma coisa? Aqui perto vende o melhor cachorro quente do país.
<p>- Eu não sei.
<p>- Olha quem é fresca agora. Se vamos andar o dia todo, você vai ter que comer alguma coisa e eu não tenho dinheiro para comida gourmet. 
<p>- Andar o dia todo? – Ela ficou surpresa.
<p>- Fazia parte da surpresa, então... Surpresa! Não quer sair correndo, quer?
<p>- Eu tenho essa opção?
<p>- Mas é claro. Eu não sou nenhum sequestrador.
<p>- Então eu escolho comer o cachorro-quente.
<p>- É assim que se fala, porque eu quero comer três.
<p>- Três?</p>
<center><h4>--*--</h4></center>
<p>Will sempre se sentia um turista quando ia para a Calçada da Fama. Mesmo não ficando animado nem tirando fotos de cada estrela, a impressão que dava era que mesmo não ligando, ele só estava lá para isso deixando-o parecer um turista animado. Não fazia muito tempo ele teve um sonho que seu nome estava em uma daquelas estrelas, mas não gostava muito de pensar sobre isso.
<p>- Você já foi até o final? – Emily falava com Will, mas andava olhando para o chão.
<p>- Ela tem mais de dois mil estrelas e quase seis quilômetros. Eu não passo tanto tempo assim andando para ver nomes de pessoas.
<p>- Me diz uma coisa. – Emily parecia confusa. – Você me levou ao píer, mas não gosta de pescar. Você me trouxe até aqui na Calçada da Fama, mas não se interessa pelas estrelas, por que estamos aqui então? Por que está me levando a esses lugares?
<p>- Ah, isso é só uma desculpa.
<p>- Desculpa para quê?
<p>- Para passar o dia com você, achei que fosse óbvio.
<p>Emily não conseguiu disfarçar a surpresa, nem a vergonha, e por último a felicidade que aquele comentário produziu nela.
<p>Havia vários artistas de rua cantando e dançando na calçada tentando ganhar alguns trocados. Carrinhos que vendiam lanches estavam cheios de gente. Moças vendendo rosas...
<p>- Você quer uma rosa? – Will apontou para uma garota que estava vendendo perto deles. – Geralmente, eu não faço isso, mas...
<p>- Não precisa.
<p>- Vermelha, branca ou amarela? – Ele ignorou a resposta dela.
<p>- Não, isso é muito cafona. – Então ela olhou para ele. – Você escolhe. – E se rendeu.
<p>Ele voltou com três. Uma de cada cor. 
<p>- Por que só uma se eu posso comprar três? – Ele riu. – Qual é a sua favorita?
<p>- As três. 
<p>Os dois sorriram um para o outro.</p>
<center><h4>--*--</h4></center>
<p>- Dizem que não dá para ver o letreiro de Hollywood bem de perto, só de longe.
<p>Emily lia o mapa da trilha para o letreiro que tinham comprado em uma banquinha de jornal em Beverly Hills.
<p>- Eu conheço uma trilha melhor que essa.
<p>Os dois estavam andando na rua que dava de frente com a montanha onde havia o letreiro. Muitas pessoas paravam no meio da rua e se contentavam em tirar umas fotos de longe mesmo. No fim da rua, havia umas placas indicando o caminho.
<p>- Então por que compramos esse mapa?
<p>- Esquece o mapa. – Ele pegou o mapa da mão dela, dobrou e colocou no seu bolso. – Está preparada? É bem longe.
<p>- Eu nasci preparada. – Ela falou sério.
<p>Os dois agradeceram aos céus por estarem de tênis, a caminhada seria mais fácil daquele jeito, mas não ia deixar de ser um pouco cansativo. Já era de tarde, por isso o sol estava perdendo a força, mas ainda continuava calor e no caminho não havia muitas árvores fazendo sombra. Conforme iam subindo, mais e mais pessoas iam desaparecendo, muitas paravam em algum lugar, tiravam fotos e voltavam, mas eles continuaram. As ruas não tinham mais sinalizações, seria muito fácil se perder naquele lugar.
<p>- A gente não está perdido, está?
<p>- Relaxa, eu sei exatamente onde estamos.
<p>Emily olhava para todos os lados ainda com o rosto maravilhado. Às vezes, eles faziam uma curva e o letreiro se escondia, mas estavam bem alto, dava para ver praticamente toda Los Angeles de lá.
<p>Depois de um tempo, eles chegaram. Se depararam com o letreiro bem na frente deles. Não podiam tocar nas letras, é claro, havia algumas grades para a segurança do monumento, mas mesmo assim, só de estar perto já era o bastante para eles. O céu continuava claro e limpo, praticamente sem nuvens, dava para ver as colinas e boa parte da cidade. Os dois se sentaram no chão para descansar, só porque para voltar era uma descida, não queria dizer que seria fácil.
<p>- Eu nunca... é tudo tão lindo.
<p>- É. – Will olhava para ela. Seus olhos estavam brilhando e ela sorria. O melhor sorriso na opinião dele. – Sabe, a cidade é diferente quando eu estou com você. Acho que até me deu vontade de pescar.
<p>- Ah é?
<p>- Eu não me lembro de curtir tanto um passeio turístico como eu curti o de hoje.
<p>Os dois ficaram lá sentados em silêncio por um bom tempo. Parecia que nenhum dos dois queria sair de lá. O lugar era perfeito e o momento também. Will fingia estar olhando para a paisagem, mas na verdade, só estava olhando para ela o tempo todo. A vista era melhor. 
<p>- Sabe... – Emily quebrou o silêncio depois de um tempo. – Valeu a pena trocar as caixas de poeira. 
<p>- Eu disse que valeria. Essa aqui até pode ser a nossa nova gruta.
<p>- Você está de brincadeira? Eu estou morta, eu nunca mais vou subir aqui na minha vida. – Ela começou a rir. – Como descobriu esse lugar?
<p>- Uma vez, o Seb e eu nos desafiamos, brincadeira de criança. Ganhava quem tirasse uma foto mais perto do letreiro. Eu ganhei.
<p>- Ele nunca achou esse lugar?
<p>- Na verdade, nós dois viemos juntos.
<p>- E como você ganhou?
<p>- Eu também pulei as grades de segurança. Você tinha que ter ouvido o barulho dos alarmes.
<p>- Você é doido. – Emily gargalhou.
<p>- Você não faz ideia. – Ele ria junto.
<p>Depois de um tempo, começou a escurecer sem eles perceberem que já era tão tarde.
<p>- Ai, meu Deus, temos que ir antes que escureça mais. Podemos nos perder. – Emily se levantou bem rápido.
<p>- Relaxa, você está comigo, lembra? – Ele se levantou também.</p>
<center><h4>--*--</h4></center>
<p>A praia ainda estava cheia de gente por todo lugar quando chegaram lá. Já estava noite, mas continuava bem quente. 
<p>- Eu preciso ir para casa. Já está tarde. – Emily olhou o celular.
<p>- É, esqueci que você tem um general em casa. 
<p>- É, bem isso. 
<p>- Eu não quero que acabe. Eu passei um dia muito bom para ser sincero.
<p>- Eu também gostei muito. Muito obrigada. Eu adorei ficar com você hoje.
<p>- E eu adoro você. 
<p>- Que bom, não é? – Ela riu para tentar disfarçar o nervosismo.
<p>- Eu.. na verdade, eu preciso te contar uma coisa. – Ele pegou na mão dela e ficou de frente para ela ver seu rosto com mais facilidade.
<p>- O quê?
<p>- Eu estava muito nervoso hoje e eu nunca fico nervoso. 
<p>- Eu te deixo nervoso? – Emily tentou entender.
<p>- Eu não sei, talvez. Olha, eu vou simplesmente te dizer o que eu quero dizer. E não é tipo aquele lance de “eu estou nervoso demais para dizer agora, vou enrolar o dia todo”, nas é isso, é mais para “o dia acabou e eu preciso dizer senão vai ser uma droga.”.
<p>- Então me diz de uma vez.
<p>- Semana passada no bar e quando eu te levei para casa, eu tive uma vontade enorme de te beijar. – Emily não disse nada. – Eu corro pelos corredores só para poder te ver mais. Eu geralmente falto na aula duas vezes por semana, mas se eu faltar eu não te vejo, então eu prefiro ir. Isso é esquisito. 
<p>- Você está me dizendo que...
<p>- Eu não quero ser seu amigo. Quer dizer, ficar com você é incrível, mas...
<p>- Mas o quê? – Ela sabia o que Will ia dizer.
<p>- Minhas mãos suam quando te vejo e na mesma hora me jogam um pote de coragem e eu sinto que posso fazer qualquer coisa. Quando eu te vi saindo de casa, naquela primeira vez que eu te busquei para irmos juntos para escola, eu... meu coração disparou. 
<p>- Eu...
<p>- Eu gosto de sentir todas essas coisas. Uns dias atrás eu escutei uma música country e eu finalmente entendi a letra e... eu gostei. – Ele riu. – Não é como se eu quisesse tirar isso de mim, eu quero abraçar, na verdade.
<p>- A gente acabou de se conhecer.
<p>- Já vi pessoas ficarem juntas com bem menos tempo de convivência.
<p>- A gente nem se conhece direito.
<p>- Se você quiser eu passo a noite falando para você minha autobiografia, isso não é um problema.
<p>- É que...
<p>- Me diz que não gosta de mim e eu nunca mais toco no assunto.
<p>Ela abriu a boca, mas não saiu nada.
<p>- Viu, você não consegue. Você também gosta de mim. Só diz.
<p>- Você não sabe tudo...
<p>- Eu já sei o que preciso saber. E então?
<p>Emily ficou em silêncio olhando para Will sem nem conseguir piscar direito. Ela queria dizer exatamente o que ele queria ouvir, mas estava com medo mesmo sem saber de que exatamente, mas então...
<p>- Na verdade, eu... naquela noite... eu também queria que você me beijasse. 
<p>Will se aproximou mais dela e percebeu que ela não ia se afastar. Ele não pensou, nem falou, só fez. Tudo de repente parou, o som de tudo, o vento, tudo. O rosto dele foi chegando mais perto do dela enquanto ela se aproximava também, sem forçar, naturalmente. Então os lábios se tocaram.
</br>
<p>“Meus pensamentos sumiram. Minha mente saiu do meu corpo e eu não conseguia sentir mais nada ao meu redor a não ser ela. Nossos lábios se mexiam juntos em uma sintonia que parecia que só nós tínhamos. Eu a puxei mais para perto de mim. Meus lábios não queriam largar os dela e parecia que ela tinha esse mesmo pensamento em relação a mim. Estava ficando mais calor. Aquele calor e aquele sentimento me preenchiam por completo.”.</p>
<center><h4>--*--</h4></center>
<p>Emily percebeu que a luz da sala de estar da sua casa ainda estava acesa pela janela. Já era bem tarde e ela até se surpreendeu que seu pai não tenha ligado antes.
<p>- Eu quase esqueci do general. – Will riu.
<p>Os dois pararam na calçada em frente à casa dela. 
<p>- Ele não é tão ruim. 
<p>- Você quer que eu entre e explique porque a gente demorou?
<p>- O que você diria?
<p>- Senhor, eu beijei a sua filha na praia e não queria mais parar.
<p>- Acho melhor não. 
<p>- A gente se vê amanhã então?
<p>- Eu não sei. – Emily levantou a sobrancelha. 
<p>- Tudo bem. Então para eu não parecer aqueles caras grudentos e estranhos, me liga... quando quiser me ver. 
<p>- Ah, então eu que vou decidir?
<p>- Sim. 
<p>- Espertinho. 
<p>Os dois ficaram se olhando por mais alguns segundos até que ela resolveu se despedir. Eles soltaram a mão um do outro e foi quando perceberam que estavam de mão dadas desde a praia e começaram a rir juntos. Ele a beijou de novo só que com menos intensidade, senão ele não deixaria mais ela ir embora.
<p>Will ficou esperando Emily entrar em casa. Mesmo depois que as luzes da sala se apagaram ele ficou lá esperando por mais alguns segundos, então resolveu seguir o seu caminho.
<p>Quando ele estava cruzando o quarteirão, seu telefone tocou.
<p>- Emily? O que aconteceu? – Ele ficou confuso.
<p>- <i>Você disse que eu tinha que te ligar.</i> – Ela riu.
<p>- Ah, mas... não exatamente agora. Já decidiu se quer me ver de novo?
<p>- <i>Na verdade... Eu não quero parar de te ver. Olha para trás.</i>
<p>- Quê?
<p>Will olhou para trás e viu Emily vindo em sua direção. 
<p>- O que você está fazendo aqui? – Ele sorriu.
<p>- A Quinn me ajudou a fugir. Nosso encontro não precisa acabar, não ainda. 
<p>- Você é doida. 
<p>- É um lado meu que você ainda não conhecia. 
<p>- Eu já te vi xingando a linha telefônica. Eu sei que você é doida.</p>
<center><h4>--*--</h4></center>
<p>Os dois se sentaram na areia úmida da noite. Naquela hora, a praia estava deserta e não estava mais tão quente como estava horas antes, mas estava tudo bem. Conforme a brisa do mar batia em seus corpos mais eles se aproximavam um do outro. 
<p>- O seu pai ficou muito bravo?
<p>- Ele não gritou, mas tentou te ver pela janela.
<p>- Eu até imagino ele falando: “Aquele garoto surfista não presta!”. – Will tentou imitar uma voz irritada com sotaque sulista muito ruim.
<p>- Foi isso mesmo que ele disse. – Emily começou a rir. 
<p>- E mesmo assim você fugiu. 
<p>- Se sinta especial, eu nunca fugi por ninguém. Na verdade, eu nunca tive bem um namorado. Você é o primeiro. 
<p>- Espera um pouco. Eu sou seu namorado agora?
<p>Ela demorou um pouco para perceber que ele estava brincando.
<p>- Você é muito bobo, sabia?
<p>- É que eu gostei disso, a maneira como soou. Seu namorado. 
<p>- Você não é do tipo que namora?
<p>- Eu até sou, mas eu não gosto muito de namorar só por namorar. Gosto de ser para valer. E é sério, eu não estou falando isso só porque...
<p>- Eu acredito. 
<p>- Eu sei que você já deve ter ouvido algo sobre mim e...
<p>- Tudo bem, não me interessa. 
<p>Will sorriu. 
<p>- Me conta uma coisa... sobre você que ninguém mais saiba e eu faço o mesmo para selarmos esse momento. 
<p>- Eu não tenho muito o que dizer. – Emily ficou pensativa.
<p>- Eu aposto que tem.
<p>- Ah, tudo bem. Eu... tenho medo de coelhos. 
<p>- O quê? – Os dois começaram a rir. – São só coelhos. Eles só comem cenoura. Como você tem medo disso?
<p>- Sei lá. Eu acho que é por causa do Pernalonga. Olha, isso é verdade, mas eu posso te contar outra coisa. 
<p>- Pode mandar.
<p>- Eu... não sei muito bem o que eu vou fazer depois que eu terminar o ensino médio.
<p>- É sério? Mas e todos esses estudos e...
<p>- Ah, eu só faço isso porque eu gosto de ser boa em alguma coisa, mas quando eu paro para pensar no futuro, eu travo. É como se eu não pudesse fazer nada. 
<p>- É o oposto. Você pode fazer qualquer coisa.
<p>- Sua vez. – Ela sorriu em agradecimento. 
<p>- Eu queria ter uma relação melhor com os meus irmãos. 
<p>- Nossa. – Ela ficou impressionada.
<p>- É. Se eu pudesse escolher ter um superpoder, seria fazer com que eles pensassem exatamente como eu, evitaria muitos problemas. Pensando bem, seria um desperdício essa escolha, eu iria preferir escolher voar ou teletransporte ou correr bem rápido. Na verdade, eu escolheria ter o poder de parar o tempo, assim eu podia ir andando de boa porque o tempo estaria parado, eu não ia precisar correr nem me teletransportar, e mesmo assim iam achar que eu tenho esses poderes. 3 em 1.
<p>- Você tem as melhores conversas, sabia? – Emily começou a rir.
<p>- Me desculpa. Já quer voltar para casa?
<p>- Não. Eu ainda prefiro ficar aqui ouvindo seu dilema de qual superpoder você escolheria.
<p>Emily encostou sua cabeça no ombro de Will e os dois ficaram lá olhando para a praia, às vezes conversando, às vezes em um silêncio tão profundo que podiam ouvir a respiração um do outro. 
<p>E assim ficaram por horas.</p>
</body>
</html>";
            }

            if (numero == 5)
            {
                lblTitulo.Text = "Capítulo 5 - Dizem Por Aí";
                htmlPage.Html = @"<html>
<body>
<p><i>“Coitadinho, você está com a cabeça nas nuvens
<br>Ela te fez de bobo e, cara, está te deixando para baixo
<br>Ela fez seu coração derreter, mas você ainda está frio até sua alma
<br>Agora dizem por aí que ela não tem mais o seu amor”
<br><b>Rumour Has It – Adele</b></i></p>
<br>
<p>Will se jogou na cama mesmo com a sua roupa toda cheia de areia. Ele não tinha ideia do quanto estava cansado até deitar.
<p>- Onde você estava?
<p>Ele ouviu a voz estridente de sua irmã bem irritada entrando no seu quarto.
<p>- Vai embora. – Sua voz foi abafada pelo seu travesseiro.
<p>- Você não avisou ninguém e eu tive que ligar para o Jason para ele mentir por você. 
<p>- Mandy, eu estou morrendo de sono e morto de cansaço. É domingo. Não enche. – Ele falou sem abrir os olhos e na mesma posição que estava, deitado de bruços com a cara enfiada no travesseiro.
<p>- Me conta onde estava e eu paro de encher.
<p>Amanda se deitou ao lado de Will. 
<p>- Você está fedendo. Devia tomar um banho.
<p>- Você é pior que a mamãe. Ficou a noite toda me esperando? – Will resmungou.
<p>- Não, mas caso não tenha percebido, já são quase nove da manhã. Eu acordo cedo.
<p>- Tudo bem, eu estava com a Emily. Contente? Agora me deixa dormir.
<p>- Passaram a noite juntos? Já? E a Quinn me dizendo que a irmã dela era a santa da família.  
<p>- Não foi do jeito que você acha. Não fizemos nada. Só ficamos juntos de noite, só isso. – Will não falou em um tom de desgosto. Na verdade, ele não tinha uma noite boa daquelas já fazia muito tempo.
<p>- O que houve?
<p>- Você não vai me deixar dormir, não é? – Will virou o rosto e abriu os olhos para a irmã. – A gente saiu ontem e no fim do encontro eu beijei ela. 
<p>- Foi bom?
<p>- Se não tivesse sido bom, eu não teria passado a noite fora. – Ele sorriu.
<p>- Então vocês estão juntos agora?
<p>- Eu não sei, eu acho que sim. Ela me chamou de “namorado”. 
<p>- Então estão namorando? – Amanda por um segundo ficou chocada.
<p>- Por que a surpresa? Você já tinha me sugerido isso.
<p>- Eu tinha, mas... não achei que ia realmente rolar. Gosta dela de verdade?
<p>- Eu gosto. – Diferente da última vez que conversou com a irmã sobre aquilo, Will não enrolou e disse com firmeza.
<p>- Olha, eu... eu estou feliz. Faz um tempinho que eu não te vejo assim. 
<p>- Na verdade, eu acho que eu nunca me senti assim antes. É estranho. 
<p>- E quanto a Giovanna?
<p>- Eu devo nada a ela. Não estamos mais juntos.
<p>- É, mas você sabe, eu sei e o mundo todo sabe que ela achava que vocês voltariam um dia. Vai ser um choque para ela. Eu posso contar? Deixa.
<p>- Cala a boca. – Os dois começaram a rir. 
<p>- Você está um caco, mas parece feliz. 
<p>- Eu estou. 
<p>- Ótimo. Agora posso deixar você dormir. – Amanda se levantou da cama. – Já contou para o Jason?
<p>- Ainda não. 
<p>- Quando contar, pede para ele seguir seu exemplo.
<p>- Você também pode se declarar para ele, sabia? Não é uma regra o cara ter que falar. 
<p>- Vai dormir, vai.
<p>Amanda saiu do quarto.</p>
<center><h4>--*--</h4></center>
<p>Will passou o dia todo dormindo e quando acordou o sol já tinha se posto. Ele evitou ficar à vista, não queria ouvir perguntas que não iria responder. Então resolveu sair do quarto só para tomar banho e comer alguma coisa e depois voltar. 
<p>O domingo passou mais rápido que o esperado. Quando acordou na segunda, ele se deu conta que não tinha falado com Emily depois do encontro e não sabia se aquilo era uma coisa boa ou ruim para os dois. Mas ele sabia o que fazer.
<p>Como de costume, o portão de entrada da escola estava cheio de alunos na frente, a maioria deles pensando em uma maneira de matar a aula. Faltava alguns minutos para o sinal tocar. Will, parado em frente o portão, olhava seu celular de cinco em cinco minutos até que ela chegou.
<p>- Oi.
<p>- Oi.
<p>Emily vinha sorrindo assim que o viu a esperando.
<p>- Tudo bem? Estava te esperando. – Ele sorriu.
<p>- Como sabia que eu não tinha entrado?
<p>- Impossível, eu fui o primeiro a chegar para garantir isso.
<p>- Bom trabalho. Vamos? 
<p>- Espera, eu preciso te perguntar uma coisa antes... bem constrangedora. 
<p>- Pode perguntar. – Pelo olhar, Emily sabia o que ele ia perguntar.
<p>- O lance de... namorados. É sério?
<p>- Esse é o seu jeito de me pedir em namoro?
<p>- Você me pediu primeiro. – Ele apontou. 
<p>- Por que você não me manda um bilhete perguntando se eu quero ser a sua namorada?
<p>- Porque eu não tenho doze anos.
<p>- Mas está parecendo. 
<p>- Eu sou melhor em beijar do que falar. Por isso...
<p>- Não!
<p>Emily se afastou assustada e constrangida.
<p>- Estamos na escola!
<p>- Eu sei, é para isso que a escola serve.
<p>- Will!
<p>- Que é?
<p>Ele não esperava que ela fosse se esquivar de novo, mas ficou um pouco surpreso quando ela não o fez.
<p>- Isso é tão errado. – Emily riu de vergonha depois do beijo, totalmente vermelha. 
<p>- Errado seria eu não te beijar.</p>
<center><h4>--*--</h4></center>
<p>Não demorou muito até que o beijo de Will e Emily no portão começou a ser o comentário principal entre os grupinhos nas salas de aulas. Na verdade, foi na segunda aula que Will percebeu que a história tinha se espalhado. Algumas pessoas olhavam e depois cochichavam para os amigos. Era um pouco estranho.
<p>- Então é verdade o que estão dizendo? – Jason, com Sebastian em seus calcanhares, foi em direção a Will que estava pegando seu livro de geografia no armário para a próxima aula. 
<p>- O quê? Que esse ano vão lançar Silent Hill? É, é verdade sim.
<p>- Não me engana, Will. – Sebastian não tinha muito senso de humor às vezes.
<p>- Viram você beijando a Emily hoje de manhã. – Jason foi logo ao assunto.
<p>- E viram certo.
<p>- Por que não contou para gente? – Sebastian estava indignado. – Ficamos sabendo porque perguntaram para gente. 
<p>- É que...
<p>- E a gente mora na mesma casa. 
<p>- Eu estava muito cansado ontem. Dormi demais e...
<p>- Espera um pouco. – Jason começou a falar. – A Amanda disse que você passou uma noite fora e eu até tive que mentir para os seus pais que você estava na minha casa e... Você passou a noite com ela?
<p>- Sim, mas não fizemos nada. Só ficamos conversando. 
<p>- Quem é você e o que fez com o meu irmão? – Sebastian franziu a testa.
<p>- Calado. 
<p>- Ele está apaixonado por ela. – Jason falou sorrindo. 
<p>- Eu gosto dela, grande coisa. – Will já estava começando a ficar irritado. – Eu cheguei a ouvir alguns comentários. Aparentemente, eu beijar alguém é a pior coisa do mundo. 
<p>- As pessoas falam demais. – Jason revirou os olhos.
<p>- E quanto a Giovanna? Quer dizer, a gente sabe que você não tem mais interesse, mas ela...
<p>- E daí? Só por isso eu tenho que virar padre? Por que todo mundo tem consideração por ela e não por mim?
<p>- Porque todo mundo só sabe o lado dela da história.
<p>- É, porque ela é a rainha das mentiras. Olha, não vamos falar da Giovanna, tá bom? Eu tive o melhor final de semana da minha vida. Não podem ficar felizes por mim?
<p>- Eu estou muito feliz por você. A gente até perdoa você por não ter nos contado.
<p>- Eu também estou feliz, mas a gente não perdoa, não. – Sebastian deu um soco no braço do irmão.
<p>- Qual é, Seb? – Will começou a rir massageando o braço.</p>
<center><h4>--*--</h4></center>
<p>Emily entrou apressada na sala de aula. Estava atrasada por causa de Will. Ela se sentou bem rápido na primeira carteira vazia que encontrou para tentar passar despercebida. Foi só quando se sentou que ela percebeu que o professor ainda não tinha entrado na sala.
<p>- Ainda bem. – Ela suspirou aliviada.
<p>- Olha, só para avisar, tudo bem chegar atrasada. É normal.
<p>Emily se assustou quando percebeu que Amanda, sentada do seu lado, estava falando com ela.
<p>- Somos amigas agora? – Emily perguntou.
<p>- Só estou fazendo um comentário. – Amanda respondeu mal-humorada.
<p>Emily ia continuar a conversa, mas Amanda pegou seu celular e começou a colocar seu foco nele. Após ela tirar seus cadernos e livros da bolsa e colocar na mesa, Emily percebeu algo estranho, algumas garotas olhavam para ela disfarçadamente, mas não tanto e faziam comentários baixinhos com as amigas. 
<p>- Por que estão falando de mim? – Emily cochichou para Amanda. 
<p>- Acho que é porque te viram beijar o Will no portão. A foto de vocês está por toda parte. – Amanda mostrou para Emily a tela do seu celular. A foto de Emily e Will se beijando tinha sido postado em algum chat que Amanda participava e aparentemente, a sala de aula toda. 
<p>- O quê?
<p>- Parabéns. – Amanda sorriu. 
<p>Emily ia dizer algo, mas no mesmo momento, o professor entrou na sala e ela se virou para assistir a aula, mas aquela foto ficou na cabeça dela durante toda a aula.
<p>- Amanda, espera! – Emily correu atrás da garota quando a aula acabou e conseguiu alcança-la no corredor.
<p>- Só porque namora com o meu irmão, não quer dizer que somos amigas. – Amanda continuou andando.
<p>- Mas... Você gostou da minha irmã.
<p>- Ela é legal. 
<p>- Mas eu... Por que estão fazendo isso? O lance da foto? É normal por aqui?
<p>- Você é novata, com certeza é um trote de boas-vindas. – Amanda falou sem emoção. – Além do mais, fazem isso com todo mundo.
<p>- Já fizeram isso com você?
<p>- Eu não namoro. 
<p>- Mas...
<p>- Não é grande coisa, relaxa. Semana que vem já vão estar falando de outra coisa, é assim que o ensino médio funciona. Memórias voláteis.
<p>- Se você está dizendo...
<p>Mas Emily não estava tão segura do quão rápido aqueles boatos iam sumir. 
<center><h4>--*--</h4></center>
<p>Will estava colocando seus livros no armário para ir almoçar quando alguém colocou a tela de um celular na sua cara que ele mal conseguiu ver o que estava sendo mostrado.
<p>- Isso é verdade? – Giovanna parecia um pouco alterada segurando o celular na frente de Will.
<p>- O que é isso? – Ele se afastou um pouco para conseguir distinguir o que era a imagem. – Ah.
<p>- Vocês estão mesmo namorando? – Ela continuava com aquela foto apontada para o rosto de Will.
<p>- Onde viu isso?
<p>- Todo mundo está compartilhando isso para todo mundo. 
<p>- Giovanna, eu...
<p>- Quando você ia me contar? Se é que ia me contar. Eu descobri no refeitório quando uma garota veio fazer graça da minha cara. Foi assim que eu descobri! – Giovanna estava se exaltando.
<p>- Eu não devo nada a você. Não temos mais nada.
<p>- Não é verdade. Você e eu... estávamos melhorando. Essa garota vai roubar você de mim?
<p>- É isso que você vai contar para todo mundo? Que ela me roubou de você? A gente terminou faz um ano e eu não conhecia a Emily quando isso aconteceu.
<p>- Mas nós...
<p>- Não existe mais “nós”, Giovanna. Eu achei que você já tinha entendido. Somos só amigos. – Will não queria perder a calma.
<p>- Eu não posso ser só sua amiga, você sabe.
<p>- Então eu sinto muito. 
<p>- É isso? Você vai jogar tudo o que a gente teve fora por causa de uma garota idiota que você acabou de conhecer? 
<p>- Eu já joguei fora há muito tempo. Giovanna, eu nunca te dei esperanças de que a gente fosse voltar.
<p>- Mas eu...
<p>- Eu não gosto mais de você. Eu sou legal com você porque concordamos em ser amigos, você concordou com isso.
<p><p>- Eu achei que depois de um tempo...
<p>- Não, não é justo.
<p>- Sabe o que não é justo? Você seguir em frente. 
<p>- Queria que eu continuasse tão infeliz quanto você?
<p>- Sim, depois de tudo o que você me fez, sim.
<p>Will percebeu que Giovanna estava com lágrimas no rosto, aquelas lágrimas que ele conhecia muito bem. Lágrimas que não causavam mais impacto nele.
<p>- Tchau, Giovanna.
<p>- Will.
<p>Will fechou o armário e foi embora. Giovanna ficou lá parada no meio do corredor sem reação.</p>
<center><h4>--*--</h4></center>
<p>- Te procurei na biblioteca. É seu esconderijo favorito.
<p>Will encontrou Emily sentada no canto de uma das escadas. A mais afastada do refeitório. 
<p>- Eu estava lá, mas na mesa do meu lado estavam três garotas apontando e cochichando coisas sobre mim.
<p>- O quê? – Will colocou um bolinho que ele tinha pegado no refeitório na boca enquanto Emily falava.
<p>- Você sabia que tem uma foto nossa circulando pelos celulares de todo mundo?
<p>- Não. 
<p>- Mentiroso. – Emily revirou os olhos. 
<p>- Qual é o problema?
<p>- Está todo mundo falando sobre a gente. É esquisito. Você não liga?
<p>- Para falar a verdade, não. – Ele se sentou ao lado da namorada.
<p>- Mas eu não entendo. Todo mundo namora por aqui, por que estão logo no nosso pé?
<p>- Somos o casal da semana. – Will riu, mas Emily não conseguia achar graça naquilo. – Ah, qual é, Emily! Não fica brava com isso.
<p>- Eu não estou brava, eu só estou incomodada. 
<p>- Olha, existe uma razão para isso estar acontecendo. Estão com inveja da gente. 
<p>- Ou acham que somos ridículos. Eu vi até uma garota rindo. – O incomodo de Emily estava virando raiva sim.
<p>- Olha, não interessa. Podem achar que somos ridículos, mas eu sei que não somos. Somos lindos. 
<p>- Para. – Emily ficou sem graça.
<p>- Não, é sério. Somos a melhor coisa dessa escola, talvez desse país, e eu estou falando de um país onde existe Ashton Kutcher e Mila Kunis.
<p>- Cala a boca. – Ele conseguiu tirar um sorriso dela.
<p>- Olha, eu não ligo para fotos nem para comentários e você também não deveria ligar. E se eu quiser te beijar, eu vou te beijar, independentemente de todos os paparazzi da escola. E eu quero muito te beijar agora.
<p>- Bom, já que você quer muito. – Emily sorriu.
<p>Os dois se beijaram.</p>
</body>
</html>";
            }

            if (numero == 6)
            {
                lblTitulo.Text = "Capítulo 6 - Mas Eu Sou Só Um Humano Comum Com Jeitos Comuns";
                htmlPage.Html = @"<html>
<body>
<p><i>“E à luz do dia, eu poderia jurar que somos iguais
<br>Mas eu sou só um ser humano comum com hábitos comuns
<br>Eu sou só um ser humano comum
<br>Mas eu não me sinto tão comum hoje
<br>Sou só um retrato de alguém nada perfeito
<br>Às vezes eu me medico
<br>Eu vou ser um retrato de um ser humano perfeito
<br>Antes que o sol se ponha hoje”
<br><b>Ordinary Human – OneRepublic</b></i></p>
<br>
<p>“Você já conheceu alguém em determinado momento da sua vida que te fez pensar o porquê vocês não se conheceram antes? Tipo, faz parecer que o resto da sua vida com essa pessoa não vai ser o suficiente. Você não quer perder nada, nenhum momento. Como se a sua contagem regressiva estivesse finalmente começando. Parece desesperador, mas não é. É uma sensação muito boa, pelo menos para mim.”.</p>
<br>
<p>Como toda tarde, Will e Emily estavam sentados em um dos bancos do parque conversando depois da escola.
<p>- Eu nunca vou pisar na sua casa. – Emily começou a rir daquele comentário. – Eu vi a cara do seu pai lá do portão hoje. Ele quase me fuzilou com os olhos. 
<p>- A culpa é da minha irmã. Ela fica fazendo piadinhas sobre isso o tempo todo. 
<p>- Podemos matá-la. – Will brincou.
<p>- Você vai ter que aparecer lá uma hora ou outra.
<p>- Prefiro a “outra”. Mas pensando bem, é, isso vai ter que acontecer. Além do mais, desde que a minha irmã abriu a bocona dela em casa, minha mãe vive insistindo para você aparecer lá porque quer te conhecer.
<p>- Eu também gostaria de conhecê-la. – Will ficou chocado com a resposta.
<p>- Era brincadeira. Na verdade, ela não quer ver você. 
<p>- Sem graça. Você nunca fala dos seus pais. Quer dizer, dos seus irmãos eu acredito que sei tudo, mas seus pais...
<p>- Ah, eles são pais, o que quer que eu diga?
<p>- Que sua mãe não é tão brava quanto meu pai. 
<p>- Ah, de boa. Nem de perto. 
<p>- Você não está me escondendo, está? – Emily fez um deboche.
<p>- Ah, mas é claro que eu estou. Ninguém pode saber que eu namoro a garota mais linda do mundo. Podem querer tirar você de mim.
<p>- O mundo é muito grande. 
<p>- Por isso. 
<p>- Olha, que tal a gente combinar o seguinte? Você me leva para conhecer seus pais e eu te levo para conhecer os meus. 
<p>- Por que eu sinto que eu vou me dar mal em todos os jeitos possíveis? 
<p>- Para de drama. – Emily riu.</p>
<center><h4>--*--</h4></center>
<p>- Você vai trazer a Emily aqui em casa? – Amanda ficou impressionada e surpresa quando soube da notícia. Will contou a ela à noite quando estavam sentados na cama dele conversando.
<p>- Por que a surpresa?
<p>- Bom, é que vocês estão juntos há pouco tempo e...
<p>- E eu nunca fiz isso antes, eu sei.
<p>- É, com a Giovanna... nossos pais já conheciam. E as outras... bom, não podem ser consideradas namoradas. 
<p>- É diferente agora. 
<p>- Ela é diferente. 
<p>- Como assim?
<p>- Eu tenho conversado com ela. Ela não é tão ruim. 
<p>- Na verdade, a ruim aqui foi você. 
<p>- Posso continuar? – Ela riu. 
<p>- Claro.
<p>- Bom, ela não é como eu pensei que era. Ela é inteligente, não é o tipo de garota que você costuma namorar. 
<p>- O que quer dizer com isso?
<p>- Você sempre foi o cara que namora aquelas garotas clichês. Frescas, patricinhas e burras, olha só para a Giovanna. 
<p>- Obrigado. 
<p>- Olha, eu acho que pode dar certo. Tudo isso.
<p>- Então você está de acordo? É o seu jeito que dizer que dá a sua benção?
<p>- Contanto que esteja feliz. 
<p>- E eu estou.
<p>- Ótimo. Então eu também estou.</p>
<center><h4>--*--</h4></center>
<p>Will e Emily estavam parados em frente a casa dele. Era uma situação um pouco assustadora. Emily apertou a mão de Will bem forte, ela também estava com medo embora tentasse, sem sucesso, mostrar que estava se sentindo bem confiante.
<p>- Está pronta? Minha mão está dormente, então... – Will tentou brincar para aliviar um pouco a tensão. 
<p>- Nem um pouco. – Ela tentou rir, mas não conseguiu. – Vamos. – Emily tentou arrumar os cabelos com as pontas dos dedos totalmente nervosa.
<p>- Você está linda, relaxa. – Will a beijou para encorajá-la. 
<p>Os dois andaram devagar pela varanda até chegarem à porta de entrada. Will sabia que Emily estava nervosa, a hora de tentar disfarçar tinha acabado. Era real. Ele abriu a porta da frente para ela e então entraram. Sua mãe parecia querer causar uma boa impressão, a casa nunca pareceu tão limpa e perfumada. Chris e Ashley estavam no sofá assistindo algo na televisão que os dois não prestaram atenção. Os dois cumprimentaram quando Will e Emily passaram.
<p>Amanda e Sebastian estavam na cozinha junto dos pais, sentados do lado do balcão. 
<p>- Mãe, pai, essa é a Emily, minha namorada. – Will fez as apresentações. – Emily, esses são os meus pais. Os outros idiotas você já conhece. 
<p>Emily estendeu a mão para cumprimentá-los, mas a mãe foi logo no abraço. Emily ficou surpresa. 
<p>- Seja muito bem-vinda. – Ela sorriu. – E pode me chamar de Karen.
<p>- Muito obrigada, sua casa é muito bonita. – Emily sorriu educada. 
<p>- Obrigada.
<p>- É muito bom conhecer você. – O pai a abraçou também. – Bom saber que alguém está dando um jeito no Will. Me chame de Robert. 
<p>Amanda e Sebastian acenaram.
<p>- O Jason não ligou? Pensei que ele também estaria aqui. – Will perguntou para Sebastian.
<p>- Ele disse que não vai poder vir. A mãe dele não está bem, teve que ficar cuidando dela.
<p>- O que ela tem? – Emily ficou preocupada. 
<p>- Trabalha demais. – Will explicou. 
<p>- Filho, por que não leva a Emily para conhecer o resto da casa enquanto o almoço não fica pronto? – Robert sugeriu. 
<p>- Tudo bem. Vamos.
<p>Will pegou na mão de Emily que continuava nervosa e a conduziu até as escadas. 
<p>- Você não está pensando em me mostrar o seu quarto, está? – Emily falou enquanto os dois caminhavam pelo corredor do segundo andar.
<p>- É exatamente isso que eu vou fazer. – Will abriu a porta para ela entrar. – Só não repara a bagunça. – Ele começou a rir.
<p>O quarto não estava tão bagunçado, mas também não estava organizado. Tinha livros espalhados pela escrivaninha, lençóis mal arrumados e algumas roupas sujas jogadas no chão. Ela começou a olhar para todos os lados, e então parou na minha estante. Estava cheia de CDs e discos de vinil.
<p>- Discos de vinil? – Ela chegou mais perto da estante. 
<p>- Meu pai trabalha em uma gravadora. É fácil de conseguir e os raros eu encontrei na internet. 
<p>- Eu não sabia que você curtia isso. 
<p>- Eu amo música. 
<p>- Você não tem um violão, tem? Porque se você tiver, eu declaro todo o meu amor por você agora. 
<p>Os dois começaram a rir.
<p>- Então pode preparar o discurso. – Will abriu uma das portas do armário e tirou um violão. Ele já estava um pouco surrado. – Eu toco às vezes.
<p>- Toca para mim. – Ela ficou animada.
<p>- Ah, é melhor não.
<p>- Por que não?
<p>- Nunca ninguém me ouviu tocar. Eu toco só para mim mesmo. Eu ainda estou aprendendo e...
<p>- Por favor.  
<p>- É ruim. Você não vai gostar.
<p>- Deixa que eu resolvo isso. 
<p>Ela o olhou bem fundo nos olhos. Ele não podia resistir àquele olhar. Puxou a cadeira da escrivaninha e se sentou, colocou o violão no seu colo e respirou fundo.
<p>- Depois não diga que eu não te avisei. 
<p>- Não vou. 
<p>Assim que ele encostou os dedos nas cordas do violão, ouviram Karen lá embaixo gritar que o almoço já estava pronto. Como um efeito de despertador, ele se levantou em um pulo. 
<p>- Salvo pelo congo. – Emily riu.</p>
<center><h4>--*--</h4></center>
<p>Depois do almoço, todos foram se sentar no sofá na sala de estar e começaram a conversar sobre vários assuntos. Emily fez o máximo possível para participar de todos os assuntos assim como todo mundo fazia o máximo para tentar inclui-la. 
<p>Conforme a tarde chegou, as conversas diminuíram e em determinado momento todo mundo começou a assistir o programa que estava passando na televisão. 
<p>- Quer sair daqui? – Will falou baixinho na orelha de Emily.
<p>Os dois se levantaram e se despediram. Emily ganhou outros abraços e depois saíram da casa. 
<p>- Então, o que você achou? – Will estava ansioso por aquela resposta. Tanto que nem esperou virarem o quarteirão para perguntar.
<p>- É, eu fiquei nervosa, mas eu gostei. 
<p>- É, o Chris foi até educado. 
<p>- É. – Ela riu. – Mas você ainda está me devendo uma música. 
<p>- Você não vai esquecer isso, não é? Eu não consigo. 
<p>- Por que não?
<p>- Porque não é perfeito. É bem ruim, pode acreditar. Você não merece ouvir isso. – Will riu. 
<p>- Olha, tem um motivo para você ser o meu primeiro namorado. 
<p>- Seu pai ser bravo, eu já imaginei. 
<p>- Não, quer dizer isso também, mas não só isso. Eu nunca contei isso para ninguém, mas meus pais não tem o melhor casamento. Na verdade, até uns dez anos eu só os ouvia brigando e dizendo o quanto se odiavam. 
<p>- Nossa. E por que eles não... – Will não sabia se deveria terminar a pergunta. 
<p>- Eles acreditavam que ainda existia amor e também acreditavam nos votos que tinham feito. Também tinha toda aquela história de que não queriam nos criar separados em uma família disfuncional. A questão é que nos criar desse jeito não ajudou muito. Eu coloquei na cabeça que nunca ia passar pelo o que a minha mãe passou ou qualquer desilusão amorosa. 
<p>- Eu sinto muito. 
<p>- Olha, você me diz as coisas mais bonitas e eu adoro ouvi-las, mas às vezes eu acho que você me vê de um jeito que não é quem eu sou de verdade. Eu não sou perfeita. Eu nem sei quem eu sou às vezes. Eu nem... 
<p>- Eu sei que você não é perfeita, mas é como eu te vejo e se depender de mim, eu sempre vou te dizer isso.
<p>Ela sorriu.
<p>- Tudo bem, você me convenceu. 
<p>- Eu não falei isso para...
<p>- Vamos.
<p>Eles fizeram o caminho de volta, mas Emily se surpreendeu quando, ao invés de entrarem na casa, Will a levou até a garagem e entraram no carro.
<p>- Para onde vamos? – Ela perguntou.
<p>- Eu preciso te mostrar uma coisa.
<p>- O quê?
<p>- Aguenta aí, porque é uma viagem de três horas. – Ele ligou o carro.
<p>- Três horas? Mas eu só queria uma música.</p>
<center><h4>--*--</h4></center>
<p>Emily ficou em silêncio durante quase toda a viagem prestando atenção nas placas das avenidas tentando adivinhar para onde estavam indo. Will também ficou calado, concentrado. Mal sabia ela que estava rolando uma grande batalha dentro do cérebro dele que ele não conseguia controlar. 
<p>- O que estamos fazendo em Palm Springs? – Emily finalmente falou quando eles estacionaram em frente a um bar. Já estava à noite e o bar não parecia ser o mais frequentado da cidade. 
<p>- Eu preciso te mostrar uma coisa. 
<p>Os dois saíram do carro. Ele pegou na mão dela e entraram no bar. As aparências não enganaram, o bar estava mesmo pouco movimentado. Não era muito grande e dava para contar as pessoas que estavam sentadas nas mesas sendo servidas. No fundo e não muito iluminado havia um palco e uma banda, na verdade um cara com um violão e um outro com uma bateria minúscula. 
<p>- O que estamos fazendo aqui? – Emily começou a ficar assustada. 
<p>- Isso é o que ganha por ser sincera comigo e contar coisas que não conta para ninguém. Eu preciso fazer o mesmo. 
<p>- Will...
<p>- Fica aqui. 
<p>Ele a deixou parada no meio do bar, soltou a sua mão e foi em direção ao palco. Quando ele subiu, cumprimentou os dois caras que já estavam lá e Emily o viu trocar algumas palavras com eles. Will pegou um violão que estava encostado na parede e envolveu sua alça no seu ombro, pegou o pedestal, colocou o microfone e então se direcionou para a plateia minúscula. 
<p>- Olá, pessoal. Tudo bem com vocês? – Algumas pessoas fizeram alguns sons e bateram algumas palmas. – Hoje eu vou cantar uma música que eu gosto muito e eu espero que gostem também. – Ele olhou para Emily que estava com os olhos arregalados. De tudo o que ela esperava que fosse acontecer naquele dia, aquilo definitivamente não estava na lista.
<p>A banda começou a tocar. Will segurou bem firme no microfone. Ele geralmente não ficava nervoso, mas aquela apresentação era diferente. Ele olhou para Emily uma última vez e então começou a olhar para o outro lado. Ele começou a tocar também e a letra veio no automático. 
<p>- <i>Oi, bom dia, como você vai? O que faz o seu nascer do sol ser tão novo?... Eu poderia ter um novo começo também. Todos os meus arrependimentos não são nada novos... Então esse é um jeito de dizer que preciso de você... Esse é um jeito...</i>
<p>E então ele olhou para ela. Ela estava sorrindo.
<p>- <i>Esse é um jeito de aprender a respirar, aprender a engatinhar... Estou percebendo que você e só você pode acabar com a minha queda... Estou vivendo de novo, acordado e vivo... Estou morrendo para respirar nesses céus enormes...</i>
<p>Ele foi criando mais coragem enquanto olhava para Emily. Sua cara de surpresa mudou para outra expressão que ele não soube decifrar logo de cara, mas em um determinado momento, ela começou a cantar junto. Pelos seus lábios se mexendo, Will percebeu que ela não sabia muito bem a letra da música, mas cantava mesmo assim. 
<p>- <i>Esse é um jeito de dizer que eu preciso de você... Esse é um jeito de dizer que eu te amo... Esse é um jeito de dizer que eu sou seu... Esse é um jeito... Esse é um jeito de aprender a respirar, aprender a engatinhar... Estou percebendo que você e só você pode acabar com a minha queda...</i></p>
<center><h4>--*--</h4></center>
<p>- Eu não acredito nisso. Eu não acredito mesmo nisso. – Emily estava de boca aberta e muito animada quando voltaram para o carro. – Eu realmente não esperava que... Como? Você... – Ela o encarou.
<p>- Eu venho aqui às vezes para cantar. Às vezes, algumas músicas que eu gosto, às vezes algumas que eu escrevo.
<p>- Você também escreve? – Ela arregalou mais os olhos.
<p>- Sim.
<p>- Sobre o quê?
<p>- Qualquer coisa. 
<p>- Will, você é muito bom. É sério, eu estou... Você é incrível!
<p>- Valeu. – Ele mostrou um leve sorriso sem graça.
<p>- Por que você não... Seu pai trabalha em uma gravadora, como que...
<p>- Ele nunca me ouviu cantar, nunca ninguém ouviu.
<p>- Por quê?
<p>- Quando eu era pequeno, meu pai me levava em muitos shows e... Eu passei anos querendo ser igual a um daqueles astros do rock que meu pai me levava para ver. 
<p>- Não pensa mais assim?
<p>- Eu cresci e... sei que não é fácil assim. Isso é só um hobby agora. 
<p>- Está mentindo. Eu vi os seus olhos brilhando lá. Não é só um hobby. Não pode ser.
<p>- Meu pai não quer isso para mim. Ele quer que eu me forme, que eu faça uma boa faculdade, que eu consiga um emprego e que eu tenha uma carreira estável. 
<p>- E o que você quer?
<p>- Eu quero... – Will hesitou um pouco para responder. Nunca ninguém havia feito aquela pergunta para ele. – Eu quero tocar as pessoas com a música. Eu acredito que não só médicos e companhia salvam vidas, eu acredito que a música certa na hora certa pode salvar uma vida. Eu quero lotar um estádio e ouvir todo mundo cantando comigo, sentir que todo mundo está lá sentindo o mesmo que eu. Eu quero alguém me dizendo que a música que eu escrevi foi como se eu estivesse falando com ela. Eu quero que alguém chegue para mim e diga que a minha música o ajudou, diga que a minha música salvou a vida dele de alguma maneira. De algum jeito fazer a diferença.
<p>Emily não disse nada.
<p>- Eu sei, é ridículo. É coisa de criança.
<p>- Não. É a coisa mais linda que eu já ouvi. 
<p>- Obrigado.
<p>Will não sabia se Emily havia percebido o quanto aquelas palavras tinham sido importantes para ele, mas resolveu não estender mais a conversa. Ele a beijou.
<p>- Vamos para casa, Ems. – Ele ligou o carro.
<p>Ela riu.
<p>- O quê?
<p>- Nunca ninguém me deu um apelido. Eu gostei. 
<p>Ele pegou na mão dela e sorriu.</p>
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
            if (condicao + 1 > 6)
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