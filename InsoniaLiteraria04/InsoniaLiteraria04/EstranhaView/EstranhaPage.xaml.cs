using InsoniaLiteraria04.Database;
using InsoniaLiteraria04.Global;
using InsoniaLiteraria04.Helper;
using InsoniaLiteraria04.Model;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InsoniaLiteraria04.EstranhaView
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EstranhaPage : ContentPage
	{
        DBFire service;
        public int condicao;

		public EstranhaPage (int numero)
		{
			InitializeComponent();
            service = new DBFire();
            condicao = numero;
            mostrarCapituloSalvo("Estranha", "Capitulo" + numero.ToString());

            if (numero == 1)
            {
                lblTitulo.Text = "A Estranha";
                htmlPage.Html = @"<html><body>
<p>Eram sete horas de uma manhã nublada de segunda-feira. Eu estava sentada num canto remoto do pequeno café que ficava em frente ao meu prédio. </p>
<p>Lana, a garçonete, vagava por entre as mesas anotando pedidos, enquanto seu pai, Josh, gritava ordens para o cozinheiro.
<p>Havia uma movimentação incomum naquela manhã, fazendo com que as tranças douradas de Lana parecessem borrões flutuantes entre a torrente de pessoas que entravam e saíam do estabelecimento.
<p>Foi enquanto observava o entra e sai dos clientes, à espera do meu pedido, que o vi entrar, alto, de cabelos negros na altura do queixo que se destacavam em sua pele alva. Como sempre, Alec foi até o balcão e cumprimentou Josh, que respondeu de volta apressadamente. Eu o observei olhar esperançoso em busca de uma mesa vazia, provavelmente ao fundo do corredor, onde ele costumava sentar todas as manhãs para tomar café preto e comer panquecas.
<p>Alec nunca conversava com ninguém além de Josh. Na verdade, eu só havia descoberto seu nome por acaso, algumas semanas atrás, quando ouvi Lana pedir para seu pai apressar o pedido do rapaz que sempre sentava-se no mesmo lugar.
<p>Ele falou algo com Lana, que respondeu negativamente com a cabeça e se desculpou. Em seguida ela olhou em minha direção e sinalizou para que ele a seguisse.
<p>- Olá, Tempe!
<p>Eu conhecia a garota desde a época do colégio, quando ela ainda usava papel crepom para colorir os cachos de roxo, e mesmo depois de tantos anos Lana ainda insistia em me chamar por meu apelido de infância e não por meu primeiro nome, Temperance.
<p>- Olá, Lana!
<p>- Tempe – Ela olhava para mim dramaticamente - será que o Alec pode dividir a mesa com você? - Ela falou gesticulando na direção do rapaz que me encarava com um sorriso amarelo no rosto e parecia um tanto assustado. - Nós estamos lotados hoje.
<p>- Oh! Claro! - Respondi sem pensar, me xingando mentalmente depois, No que eu estava pensando ao deixar um estranho dividir a mesa do café da manhã comigo? Eu já havia o visto várias vezes nas últimas semanas, sabia seu gosto por café forte e que sempre encharcava suas panquecas com chocolate, até tinha sonhado com ele me beijando numa praia, mas isso tudo não era atestado de sanidade para ninguém, ele poderia muito bem ser um psicopata. - Eu já estava acabando de qualquer forma.
<p>- Ah...eu não vou atrapalhar? - Alec perguntou desajeitadamente.
<p>- Não, cara, relaxa! A Tempe parece louca, mas é legal.
<p>- Fico abismada com o modo que você trata seus clientes, Lana Banana.
<p>Lana mostrou a língua para mim e saiu apressadamente assim que obteve sua resposta, deixando nós dois num silêncio desconfortável. Depois de um tempo ele quebrou o silêncio:
<p>- Você não se lembra de mim, não é mesmo?
<p>- Ah! Claro que lembro.Você é o cara que fica sentado lá no fundo todas as manhãs observando as pessoas.
<p>- Isso...hãm...observando as pessoas. - Alec parecia decepcionado. - Bom, meu nome é Alec. - Ele estendeu a mão para me cumprimentar e eu retribuí. - Obrigado por me deixar dividir a mesa com você hoje.
<p>- Prazer, Tempe.E não tem problema mesmo, eu já estou de saída para o trabalho.
<p>Apressei-me em terminar o café que Lana havia deixado sobre a mesa e saí dali. Parecia estranho conversar com as pessoas desde que acordei no hospital depois do acidente de carro. Eu nunca sabia se encontraria alguém de quem deveria lembrar. E sonhar com um estranho te beijando na praia não facilitava as coisas, principalmente se você o encontra no dia seguinte e ele te chama pelo nome do meio, que eu não falava para ninguém:
<p>- Tenha um bom dia, Charllote!</p>
</body></html>";

            }

            if (numero == 2)
            {
                lblTitulo.Text = "Aceitação";
                htmlPage.Html = @"<html><body>
<p>Havia um garoto chamado Roy por quem eu estava apaixonada. Ele estava em uma das minhas turmas da faculdade e parecia estar sempre de bem com a vida, eu admirava isso. </p>
<p>Eu nunca fui de ter muitos amigos, mesmo as meninas com quem eu estudo, às vezes, parecem cansadas de me aguentar. 'Quanta carência', você deve estar pensando. Mas, caro leitor, eu realmente estava carente. 
<p>Quando você é criança os adultos pintam a faculdade como um mar cheio de peixinhos palhaços e arraias espertas que vão te divertir e te transformar na melhor pessoa que você pode ser, isso tudo num passe de mágica. Bem, é tudo mentira!
<p>Se você foi uma criança inteligente, que gostava de estudar e amava ler convivendo com crianças que achavam isso tudo tolice, sabe que fazer amigos não foi a coisa mais simples desse mundo. Para falar a verdade, tenho apenas dois verdadeiros amigos da época da escola, Sally e Dom.
<p>Além deles, fiz um ou outro amigo no colegial, mas que não me conhecem tão bem quanto eles. Os motivos para essa falta de traquejo social não são poucos, mas isso é uma outra história.
<p>Depois do colegial eu fiz um ano de curso preparatório, somei então mais um amigo verdadeiro, Luke. Ele deve ter um espaço guardado no céu por me aguentar durante aquele ano. Nossa, eu era um poço fundo de drama, arrependimento e solidão. Fato engraçado sobre Luke, ele era e ainda é namorado de uma das minhas amigas que não me conhecem tão bem. No entanto, isso também não tem nada a ver com essa história.
<p>No ano seguinte ao que conheci Luke eu ganhei uma bolsa de estudos na faculdade particular mais cara da região. Como eu não suportava pensar em ficar presa ao colegial por nem mais um minuto, aceitei a bolsa, mesmo não sendo na área de estudos que me interessava. Para encurtar a conversa, um ano e meio depois eu tranquei o curso para prestar vestibular mais uma vez e a única coisa boa que obtive dessa época foi Lyanna. Sinal de amiga verdadeira ativado com sucesso!
<p>Fui aceita no curso para o qual fiz a prova e agora você que está lendo isso deve estar pensando: UHUUUL!Bom, foi maravilhoso academicamente? Foi!Emocionalmente ? Ainda não tenho certeza. Psicologicamente? Erro de comando, volte duas casas e tente algo mais fácil, como ganhar dinheiro dormindo.
<p>Como dito, eu e traquejo social não somos exatamente chegados. Mas aprendi a lidar com as pessoas e saber, a maioria das vezes, quem valia meu esforço. Luke e Lyanna, vocês me ensinaram isso, valeu mesmo!
<p>Fiz um amigo verdadeiro virtual que dois anos depois conheci pessoalmente, Jason. O que mais me perturba e me dá vontade de bater nele.
<p>Foi necessário metade do curso e uma viagem em grupo para eu somar mais duas pessoas a minha lista, Kala e Jenny. Jenny já estava um pouco antes de Kala, mas ainda era meio provisório. Já disse que eu tinha problemas em confiar nas pessoas? Se não, agora já estão sabendo.
<p>O que é um amigo verdadeiro provisório? É aquela pessoa que você adora e torce para que de alguma forma fique claro que ela também te suporta o suficiente para embarcar no seu clube maluco. Tinha mais uma pessoa nessa situação, Izzy. Ela tornou-se membro permanente do clube em algum momento antes ou depois da tal viagem que garantiu o posto de Kala.
<p>E, finalmente, chegamos a Roy.Ele não passou por nenhum estágio probatório ou coisa do tipo. Foi amizade à primeira idiotice. 'Qual o problema disso?' meu querido leitor se pergunta.Ora, ora, vejamos: EU ME APAIXONEI POR ELE! Logo eu, a pessoa que menos sabe lidar com sentimentos na história do universo, apaixonada.
<p>Entre uma conversa e outra ele arrancou essa informação de mim. Roy tinha esse talento, sabe? Chegava de mansinho, fazendo piada entre uma conversa séria e outra e pá! La estava eu falando coisas que eu nunca falaria para nenhum outro garoto.
<p>Nós tivemos uma conversa, se é que você me entende, mas depois quando ele veio falar comigo pelo celular e perguntar se eu estava bem, eu me embananei toda e ao invés de responder com um 'Nunca estive melhor', que era o que estava sentindo, respondi com um 'Yep'. Quem no mundo, além dessa trouxa que vos fala, responderia isso depois do que tinha acontecido? Pode me chamar de tonta, caro leitor, eu mereço.
<p>As coisas ficaram estranhas entre a gente, pelo menos era o que eu achava. Mencionei meu talento para criar paranoias? Me convenci que ele estava estranho comigo e que os últimos acontecimentos tinham sido um grande erro que acabaria com a nossa amizade.
<p>Não sei até hoje como Kala, Jenny e Izzy não me deram umas bofetadas para que eu parasse de falar no Roy. Eu mesma queria poder fazer isso.
<p>Meu cérebro entrou em pane geral com medo de perder Roy, mesmo depois que criei coragem para perguntar a ele se tinha algum problema e ele me garantiu que estava tudo bem e me mandou relaxar. Aqui vai uma curiosidade sobre alguém que não está acostumada a ter muitos amigos verdadeiros, você se apega aos que consegue durante a vida e prefere sofrer os piores danos possíveis a correr o risco de perdê-los.
<p>Semanas se passaram e minhas amigas estavam realmente inclinadas a ceder ao impulso de me estapear. Enquanto Kala dizia que eu precisava assumir meus sentimentos e contar a ele de uma vez que eu ainda gostava dele. Izzy dizia que eu precisava me desapegar do Roy, porque ele era complicado demais. Caso você esteja se perguntando, ele realmente é complicado, provavelmente parte da razão pela qual eu gosto tanto dele seja essa, afinal, eu sempre tive uma queda por enigmas e quebra-cabeças.
<p>Então, tomei uma decisão, eu contaria a ele tudo, provavelmente Kala tinha razão em dizer que ele levaria numa boa e que, caso ele não gostasse de mim do mesmo jeito que gostava dele, cinco minutos depois ele estaria enviando mensagens com comentários sobre alguma coisa que ele estava assistindo.
<p>Na semana em que eu estava determinada a resolver isso de uma vez por todas, entre outras coisas que deram errado naquele mesmo dia, conversávamos sobre um seriado que ele havia me indicado e que eu estava terminando de ver. Dentro da conversa eu fiz uma piada envolvendo o dia em que ficamos juntos. Ele não fez uma piada de volta e encarei isso como um sinal.
<p>Resolvi deixar para lá. Aceitar de uma vez que eu e Roy não ficaríamos juntos. Afinal, toda aquela carência poderia facilmente estar me cegando e me fazendo achar que os meus sentimentos por ele eram mais que amizade. Provavelmente a pulsação acelerada e o suor escorrendo pelo meu couro cabeludo toda vez que espero ele responder uma mensagem são só sinais de que preciso consultar um cardiologista. Você não acha? Bom, acho que nunca vou saber, não é mesmo?
<p>Enfim, belo leitor, obrigada por sua atenção. Sinto muito pelo final desapontante. Mas a vida nem sempre acontece do jeito que queremos. Não é todo mundo que tem a felicidade de ter um final lendário. Espero, sinceramente, que esse não seja o seu caso.
<p>Por fim, te prometo uma coisa, se eu descobrir o verdadeiro motivo pelo qual meu coração entra em disparada volto aqui para contar-te. </p>
</body></html> ";
            }

            if (numero == 3)
            {
                lblTitulo.Text = "Perdido";
                htmlPage.Html = @"<html><body>
<p><center>'E quando você se perde você tem duas opções: Achar a pessoa que você é dentro de você...Ou perdê - la completamente.' </p>
<p>(Brooke Davis - One Tree Hill)</p>
</center>
<br>
<p>Meu nome é Mark, estou prestes a completar 20 anos de idade e não poderia estar me sentindo mais perdido. </p>
<p>Fui um adolescente daqueles que aproveita bem a vida, se arrisca, diz o que quer e o que pensa doa a quem doer. Também fui alguém que confiava demais nas pessoas, que deixava elas entrarem na minha vida quando bem entendessem. Mas não mais.
<p>Eu passei por algumas coisas que me machucaram e me fizeram construir uma barreira entre o mundo e meus sentimentos. Não é que eu não tenha muitos amigos, às vezes até acho que tenho demais, mas apesar de saberem muito sobre mim, nenhum deles me conhece de verdade.
<p>No entanto, tem esse garoto, Josh, que está na minha turma de Produção de Texto na faculdade. Ele vivia meio isolado por não conhecer ninguém na turma, então a galera achou legal acolhê-lo.
<p>Não dei muita bola no início. Para mim, Josh não passava de mais um colega. Mas a gente acabou se aproximando ao ponto de formarmos dupla em atividades, trabalhos e provas. Além de sempre sentarmos próximos durante a aula.
<p>Por causa disso, a galera começou a fazer piadinhas e brincadeiras, insinuando que estávamos juntos, nos chamando de casal. Eu achava que era tudo bobeira deles, até que em uma de nossas conversas eu percebi que no último mês a gente havia conversado quase que constantemente, salvo quando estávamos dormindo ou estudando.
<p>Josh é um bom amigo, é fácil conversar com ele, não sei como, mas sempre que estou mal me pego enviando mensagens para desabafar. E ele, como sempre, me responde quase que de imediato e tenta me convencer de que não sou uma má pessoa e de que não sou eu que afasto as pessoas, são elas que não tentam de verdade ficar por perto. Quando ele fala eu até sou capaz de acreditar nisso.
<p>Certa vez, entre uma de nossas conversas mais sérias, acabei descobrindo que Josh era totalmente o meu contrário. Fazer amigos e confiar nas pessoas era coisa nova para ele. Algumas horas depois, nessa mesma conversa, descobri que a pilha que a galera colocava, não era só pilha. Josh realmente gostava de mim e ele me disse isso meio sem jeito.
<p>Nós chegamos a ficar juntos uma vez, mas as coisas ficaram meio esquisitas. Sem contar que eu comecei com meu velho habito de repelir as tentativas de aproximação dele. Não era por mal. Nunca é. Mas não ajo bem quando me sinto acuado.
<p>Josh insistiu. Quanto mais eu tentava afastá - lo, mais ele se mostrava presente. Era como se ele estivesse tentando provar alguma coisa. Entre idas e vindas nessa amizade, desisti de afastá-lo, embora nunca mais tenhamos tocado no assunto sentimentos.
<p>Enfim, deixei de tentar afastá-lo. Era um esforço inútil, de qualquer forma. Tentei falar sobre ele com meus pais, pedir conselho, mas papai estava ocupado demais discutindo futebol com meus tios e mamãe...bom, mamãe prefere não saber, quanto menos ela sabe sobre minha vida, mais ela finge que está tudo bem comigo e com o mundo ao redor dela.
<p>Então, só me resta uma opção: conversar com a única pessoa que realmente se importa comigo, o problema é que eu não fazia a mínima ideia de como começar essa conversa, por isso escrevi esse texto. Tudo parece mais simples e tolo quando posto no papel.
<p>Com esse texto eu cumpro o que Josh sempre me disse, assumo quem eu sou e o que eu sinto, volto um pouco a ser aquele adolescente destemido e verdadeiro.
<p>Josh, eu amo escrever, dizer, ler o seu nome. Não é à toa que ao escrever esse texto para você continuei citando-o repetidamente, como a um mantra, mesmo nunca tendo sido adepto a mantras.
<br>
<p>Obrigado por tudo, Josh!
<br>
<p>Com carinho, Mark. </p>
<br>
<br>
<br>
<p>P.S.: Espero que você nunca desista de mim! </p>
         </body></html> ";
            }

            if (numero == 4)
            {
                lblTitulo.Text = "Ansiedade";
                htmlPage.Html = @"<html><body>
<center><p><i>“Você não tem nenhum lugar para se esconder
<br>E eu estou me sentindo como uma vilã,
<br>estou faminta por dentro.
<br>Uma olhada em meus olhos
<br>e você estará correndo,
<br>porque você sabe que eu vou te comer vivo”
<br>- Monsters (Ruelle)</i></p></center>
<br>
<p>Eu estava sufocando, tentava puxar meu corpo para longe, tomar um fôlego, mas meus pulmões não pareciam obedecer aos comandos do meu cérebro. A adrenalina produzida pela tensão se concentrava em apenas um ponto, o coração. Um minuto, três, cinco, dez... vinte e quatro horas. Ainda que eu sufoque, o ar não parece acabar, meu corpo não parece sentir a falta de oxigênio na minha corrente sanguínea, até que, finalmente, apago.
<p>Acordo às quatro da manhã, esperando que aquela sensação tenha sido um sonho ruim, ao ponto de me fazer acordar antes do alarme. Meu sono nunca foi dos mais regulados mesmo, tento me forçar a dormir mais um pouco, desisto depois de uma hora rolando na cama, minha mente não para de pensar na conversa que tive mês passado com minha irmã sobre o novo namorado esquisito que ela arranjou. Logo depois, lembro daquela vez em que discuti com minha colega de apartamento, a forçando a escolher entre manter a bagunça dela restrita a seu quarto, se não eu iria procurar outra pessoa com quem dividir o aluguel. Vamos lá, eu nem sou assim tão organizada, só não deixo que outras pessoas sejam incomodadas com a minha bagunça. Várias outras coisas sobre as quais eu ninguém mais se importa, exceto por mim, continuam a passar por minhas memórias.
<p>Ouço o toque estridente do alarme me tirar do transe autodepreciativo em que me encontrava, são seis e meia. Me arrasto com dificuldade pra fora da cama, vejo de relance meu reflexo bagunçado no espelho do corredor, no banheiro vejo que meu sono interrompido não ajudou em nada na melhora das minhas olheiras, olho nos olhos da figura refletida ali e penso em quão ridícula ela parece.
<p>Meu corpo age em modo automático, enquanto tomo banho e visto o uniforme da BrosCode, a loja ternos que era de meus avós e que meu pai se cansou de cuidar. Como gerente, posso me dar ao luxo de me atrasar alguns minutos, no entanto, já se passou uma hora desde quando eu deveria ter chegado lá. Sinto o celular vibrar em meu bolso quando desço do metrô para o ar fresco do outono.
<p>Sigo em direção a loja, não muito longe da estação, volto a sentir a sensação sufocante de antes, como das outras vezes, ela aparece sem motivo aparente e me deixa em agonia, às vezes por minutos, as vezes durante todo o dia.
<p>Os funcionários da BrosCode desejam bom dia, enquanto passo por cada um sigo para meu escritório. Ligo meu computador e abro a Netflix, não tem muito o que se fazer pelas finanças de uma alfaiataria essa época do ano, o outono acabou de começar e o verão é uma estação complicada nesse ramo, as pessoas evitam ao máximo usar roupas mais sofisticadas, mesmo os grandes CEO's se dão o direito de ir trabalhar vestidos com camisas de algodão e jeans.
<p>Busco por Burlesque no catálogo, queria rever Moulin Rouge, mas o filme foi removido da plataforma. Muito obrigada, Netflix! Uso o filme para tentar ignorar a aceleração desregulada do meu coração, funciona por um tempo.
<p>Meu melhor amigo aprece na porta do escritório no final da manhã trazendo com ele uma pizza enorme, nosso almoço. Com muito esforço, como duas fatias, o que o deixa muito feliz, pois vai ter que dar conta de todo o resto sozinho.
<p>A tarde, vou para o balcão, vou cobrir a funcionária do caixa, ela teve uma emergência familiar e pediu para sair mais cedo. O movimento da loja parece ter melhorado, finalmente, efeito do outono e suas temperaturas amenas. Converso com alguns clientes e com o pessoal que está arrumando os manequins com a nova coleção. Assim que fecho a loja, um nó se forma em minha garganta, embora nada de diferente tenha acontecido hoje.
<p>Volto pra casa, organizo alguns pedidos para os fornecedores, tomo um banho ao som de Coldplay, tenho ler, mas minha mente inquieta impede que me concentre na história, desisto do livro, já passa da meia-noite.
<p>Depois de longos minutos deitada, adormeço, mas logo acordo sufocada, em agonia. Um minuto, três, dez... vinte e quatro horas. Repito tudo de novo no dia seguinte.</p>
</body></html> ";
            }

            if (numero == 5)
            {
                lblTitulo.Text = "O Mundo Vai Mudar Seu Caminho";
                htmlPage.Html = @"<html><body>
<p>Sabe quando a vida parece estar com raiva de você e não perde a mais remota chance de te dar uma rasteira? Já perdi as contas de quantas vezes senti isso nas últimas duas décadas. E, às vezes, até esqueço que sobrevivi a cem por cento dessas quedas.
<p>É bem fácil ceder ao desespero de uma expectativa que não se concretizou, como quando reprovei no vestibular ao final do ensino médio, ou das outras três vezes em que isso aconteceu nos anos seguintes, mesmo eu dando tudo de mim pra ser bem sucedida. Até que um dia eu não reprovei, eu nem tinha me esforçado tanto assim, ainda assim o mundo parece ter girado ao meu favor.
<p>Também teve a vez em que eu percebi que ao longo da vida eu tive de me despedir de todos os amigos em que confiei de verdade, comecei a criar muros, na tentativa de evitar que pessoas se aproximassem mais do que o necessário, assim eu não as perderia. No entanto, entendi que, muitas vezes, é preciso ser afastado daqueles que mais ama, pra saber quem realmente te ama de volta.
<p>Houve a vez em que me perdi em meus próprios pensamentos, na verdade, nem sei se já me encontrei. Minha mente criativa sempre encontra meios de me prender em labirintos, que parecem infinitamente complicados, e meu reflexo é sempre me manter parada, quanto menos me mover no labirinto, menos me perco, mas, também, menores são as chances de sair dele.
<p>Cada sentimento despretensioso vira uma bola que se prende na garganta e me tira dos trilhos. Seja uma perda, uma decepção, um distanciamento, sempre vem a vontade de deixar de sentir, pensar que seria legal ser um bloco de gelo ou quanta sorte o Homem de Lata tinha antes de conhecer a Dorothy, sem sentimentos, apenas ações pré-programadas e livres de riscos.
<p>É preciso se manter alerta, entender que cada sentimento e cada abismo não é o final da estrada. Complicado, não é? Ainda mais complicado é saber disso e, ainda assim, ser incapaz de resistir aos encantos do desespero, de pensar que a balança da justiça do universo puxou a venda um pouquinho e está dando uma espiada pra escolher seus favoritos, mas você é o peso que foi tirado para equilibrá-la.
<p>Eu sei o que parece. E não, esse não é um texto autodepreciativo ou negativo. Só queria lembrar a quem estiver lendo isso que o mundo dá voltas, você não tem que ceder a dor, ela vai passar, nem se acomodar com a perda, você vai chegar lá, é preciso apenas continuar se movendo, continuar sentindo. O mundo vai mudar seu caminho e essa é a melhor e mais assustadora coisa que pode acontecer.
<p>Hoje estou sentindo o que talvez seja o mais assustador de todos os sentimentos, saudade. Provavelmente, o mais devastador também. Porque ele não só aparece quando sentimos falta do que ou de quem está longe, como estou sentindo agora, mas também está lá por coisas e pessoas que ainda nem estiveram na sua vida, como uma falta antecipada do que poderia ser. Tudo que dá pra fazer é repetir pra mim mesmo:
<p>Continue sentindo. O mundo vai mudar o seu caminho.</p>
</body></html> ";
            }

            if (numero == 6)
            {
                lblTitulo.Text = "Se Eu Me Perdesse Essa Noite";
                htmlPage.Html = @"<html><body>
<p>Fico acordado até o amanhecer, vendo cada flash de luz pela janela do meu quarto me impedindo de esquecer aquela noite em que te vi. Você era o sol que fazia tudo girar a seu redor. Dava pra sentir as cores refletidas no seu olhar, enquanto se movia com graça ao conversar com os convidados da festa. Era impossível te perder de vista e eu estava perdido ali.
<p>Era pra ser só uma festinha chata do trabalho de minha irmã, aquelas que ela sempre me forçava a ir junto para lhe servir de motorista.  Como antes, ela sumiu nos primeiros cinco minutos, me deixando sozinho em meio a uma orda de desconhecidos que se amontoavam em grupos para falar mal ou puxar saco de seus chefes.
<p>Horas se passaram, e você continuava a sorrir e conversar com todos que se aproximavam, mas tinha gente demais, decidi ir para varanda, desfrutar do aroma doce e refrescante que emanava das flores do jardim. Me recostei nas grades, ficando de frente para a festa, não queria perder você de vista.
<p>São seis horas da manhã, eu deveria estar me arrumando para o trabalho, ao invés disso, estou largado entre os cobertores admirando o reflexo da luz na parede e pensando que preciso te encontrar mais uma vez. 
<p>Eu sei que não sou nada além de um pequenino vagalume sonhando com a gloriosa lua, querendo sentir de novo a sensação de deslumbre ao te olhar a distância, fazendo me sentir tão pequeno e novo nesse mundo brilhante.
<p>É tão ridículo se sentir assim por causa de outra pessoa, ainda mais alguém que você apenas observou de longe, sem trocar uma única palavra ou olhar. Como não tem nada que eu possa fazer a respeito, continuo a pensar em você em cada minuto do meu dia e ouvindo minha irmã zombar dos meus suspiros e do riso bobo estampado em minha cara.
<p>Se ao menos eu pudesse me perder novamente na sua luz, sentir as pequenas ondas de calor e conforto emanadas por sua presença, observá-la perambulando pelo cômodo agraciando cada pessoa com seu sorriso estonteante, eu me perderia mais uma vez e talvez tomasse coragem para dizer um 'oi'.
<p>São quase seis da tarde, minha irmã logo deve chegar do trabalho, resolvo levantar e tomar um banho, ela não vai gostar nada de saber que faltei o trabalho por nada, por isso, ela nunca vai ficar sabendo disso. Ouço a porta da frente bater quando estou saindo do banho, vozes chegam até mim, sugerindo que ela veio acompanhada.
<p>A segunda voz pergunta onde fica o banheiro e eu me apresso a juntar minhas coisas, deixando o banheiro minimamente organizado. Quando piso fora do banheiro trombo com alguém e me perco de novo na luz dos seus olhos, ao menos dessa vez, talvez, você possa se perder comigo essa noite.</p>
</body></html> ";
            }

        }

        public void clkAbrirComentar(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new EsseMundoView.MyPopupPage("Estranha", condicao.ToString()));
        }

        public void clkIrMenu(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MenusView.MenuEstranhaPage());
        }

        public void clkAbrirProximo(object sender, EventArgs e)
        {
            if (condicao + 1 > 6)
            {
                DisplayAlert("CAPÍTULOS!", "VOCÊ CHEGOU NO ÚLTIMO CAPÍTULO. CONFIRA OUTRA HISTÓRIA", "OK");
            }
            else
            {
                Navigation.PushModalAsync(new EstranhaPage(condicao + 1));
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
                    Historia = "Estranha"
                }, UserLocalData.userUID, "Estranha", "Capitulo" + capitulo);

                if (condicao == 1 && status == "true")
                {
                    var listAsync = await service.mostrarQuantidadeLeituras("Estranha");

                    if (listAsync != null)
                    {
                        var contagem = Convert.ToInt32(listAsync.Quantidade);

                        await service.SomarLeituras(new QuantidadeLeituras()
                        {
                            Quantidade = contagem + 1
                        }, "Estranha");
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