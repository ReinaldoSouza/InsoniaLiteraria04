using InsoniaLiteraria04.Database;
using InsoniaLiteraria04.EsseMundoView;
using InsoniaLiteraria04.Helper;
using InsoniaLiteraria04.Model;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InsoniaLiteraria04.AnjoMorteView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Capitulo2Page : ContentPage
    {
        DBFire service;
        public int condicao;

        public Capitulo2Page(int numero)
        {
            InitializeComponent();
            service = new DBFire();
            condicao = numero;
            mostrarCapituloSalvo("AnjoMorte", "Capitulo" + numero.ToString());

            if (numero == 7)
            {
                lblTitulo.Text = "Capítulo 7";
                htmlPage.Html = @"<html><body>
<p><i>“Mais bonitos de preto que as viúvas de nossos inimigos.”
<br><b>Os Instrumentos Mortais – Cidade dos Ossos (Cassandra Clare)</b></i></p>
<br>
<p>As semanas seguintes a formatura passaram tão rápido quanto Choji Akimichi comendo yakiniku, churrasco japonês. O assunto preferido de minha tia tinha mudado da formatura para um, inacreditavelmente, pior: North Carolina State University. Não preciso dizer que esse não era o meu assunto favorito, então eu me trancava no quarto de Adriel e lia mangás para ele, no momento, o seu favorito era Naruto.
<p>-Então, nesta luta, não poderei usar o sharingan... e nem mesmo jutsus comuns, falou Sasuke.
<p>-Aí veio um dinossauro e engoliu Sasuke e todos os seus amigos da Aldeia das Plantas.
<p>Rodrigo interrompeu minha narrativa, entrando de surpresa no quarto e atacando o irmão com cócegas.
<p>-Ah, Digo... ah, não... Digo, para! - Adriel suplicou ao mais velho entre risadas até as cócegas cessarem. - Não tem dinossauro nessa história e o nome é Aldeia da Folha, não da Planta – Falou orgulhoso por saber mais que o irmão mais velho.
<p>-Ihhh... falha minha, carinha. - Rodrigo fez uma cara de profundo arrependimento. - Será que você pode me emprestar a ninja Lisa, da Aldeia de Wilmington, por alguns minutos?
<p>-Hum... tudo bem, mas ela vai ter que compensar cada minuto de leitura antes de eu dormir. - Falou Adriel.
<p>-Acabou de fazer cinco anos e já é um perfeito mercenário - Rodrigo retrucou em reprovação.
<p>-É pegar ou largar! - O mais novo afirmou ao estender a mão - E então?
<p>-Tudo bem! - Rodrigo aceitou o acordo chacoalhando a mão do irmão.</p>
<center><h4>--*--</h4></center>
<p>-Então, o que você tinha para falar de tão urgente comigo que não podia esperar eu terminar de ler o mangá? - Perguntei a Rodrigo quando saímos do quarto de Adriel, que agora tentava fazer de uma de suas camisetas uma bandana.
<p>-O que? Eu te salvei da ganancia do projeto de ninja mercenário, vulgo meu irmão, e é assim que me agradece?
<p>-Ler os mangás me ajuda com o português, são exemplares que trouxe comigo dos Estados Unidos. Eu tenho que lê-los e traduzi-los ao mesmo tempo para seu irmão, ajuda a pensar rápido. - Me expliquei. - Além do que, Sasuke está prestes a lutar no Exame Chunin, mesmo estando com a marca de Orochimaru, é uma situação muito séria.
<p>-Você só pode estar de brincadeira! - Indignou-se.
<p>-Eu nunca brinco quando o assunto é o Uchiha – Falei, negando com a cabeça para dar ênfase a afirmativa.
<p>A essa altura meu quase-primo-melhor-amigo-namorado-secreto me encarava em desconfiança, provavelmente tentando decidir se chamava os bombeiros para me internar numa clínica psiquiátrica ou se ignorava meu discurso sobre o Clã Uchiha. Ao que parece, a segunda opção foi a vencedora, já que ele balançou a cabeça, num gesto de confusão, e mudou de assunto.
<p>-De qualquer forma, eu quero te mostrar uma coisa, vem comigo. - Ele pegou minha mão e me guiou até seu quarto. – Antes usado para guardar tralhas.
<p>O quarto de Rodrigo tinha mais ou menos o mesmo tamanho que o meu, mas era muito mais organizado do que o esperado para um garoto adolescente. A cama ficava encostada a parede ao lado da janela, no lado oposto havia uma mesa com um computador e alguns livros que, devido a insistência em representar sangue em suas capas, deveriam tratar de histórias de terror e assassinatos.
<p>O resto do quarto era composto por um guarda-roupa com uma das portas entreabertas, revelando parte do seu conteúdo, que ameaçava ser ejetado de lá ao mínimo toque, e vários pôsteres de Star Wars e bandas de punk rock, entre elas:  Simple Plan, Yellowcard e Fall Out Boy.
<p>Rodrigo se dirigiu a porta do guarda-roupa que estava meio aberta e eu quase lhe disse para não tocá-la. Com a não tão majestosa postura de quem tinha experiência em situações semelhantes, ele segurou o conteúdo que ameaçava cair com uma das mãos antes de escancarar a porta. O conteúdo do armário, agora totalmente exposto, evidenciava que meu quase-primo-melhor-amigo-namorado-secreto escondia seu espírito rebelde junto a suas roupas.
<p>-Está aqui, em algum lugar – Ele murmurava enquanto remexia na confusão de roupas e objetos indefinidos. - Tenho certeza que guardei aqui.
<p>-Quer ajuda para procurar? - Ofereci - Seja lá o que for que esteja procurando.
<p>-Não. Pode deixar, eu resolvo... - respondeu sem parar o que fazia – isso e... aqui está! - Puxou do fundo do guarda-roupa um embrulho prateado de uns quinze centímetros de altura e me entregou.
<p>-O que é isso?
<p>-Um presente! - Falou sorrindo – Eu fui resolver umas coisas no Centro para papai ontem e o vi numa vitrine e, já que eu não tinha te dado nenhum presente de natal, comprei para você.
<p>Sentei na cama e abri o embrulho com cuidado, dentro de uma caixa de papelão havia uma figura de uma mulher de resina com um dragão ao seu lado. A mulher de cabelos longos parecia vestir um bustiê medieval de prata com um rubi encrustado no centro e uma saia longa com fendas bilaterais que iam do cós prateado até o chão, revelando uma tatuagem sinuosa, que partia da altura da cintura até o joelho, na perna esquerda.
<p>Para uma estátua comprada numa lojinha do centro da cidade, era muito rica em detalhes. O que deveria ser o tecido da saia era negro por fora e púrpura por dentro. Outro rubi estava preso ao cós prateado da saia, alinhado ao que lhe fazia par. A mulher calçava um par de botas negras com detalhes prateados que acabavam logo abaixo do joelho, além de um par de enormes asas de um preto translúcido incrível, outra tatuagem sinuosa, dessa vez na face esquerda, que ia da orelha até sua bochecha e pulseiras de prata que cobriam quase toda a extensão de seus antebraços.
<p>A seu lado, o dragão estava sentado sobre um amontoado de rochas que tinha mais ou menos sua altura, deixando-o a altura do cotovelo esquerdo da mulher-anjo. A criatura mitológica possuía um tom azul turquesa cintilante em suas escamas e espinhas lilases, que se estendiam desde o topo de sua cabeça até um ferrão triangular na ponta da calda que quase alcançava o que deveria ser o chão.
<p>A fera estava vestida em uma armadura, também feita de prata, que protegia seu peito, as patas e os dois longos chifres no topo de sua cabeça. As duas figuras pareciam prontas para a guerra, uma guerra que prometiam vencer.
<p>Levei vários minutos registrando cada detalhe do meu presente, enquanto Rodrigo esperava calado. Meu velho amigo, Anjo da Morte, tinha acabado de ganhar forma.
<p>-Ham... vo-você gostou? - Rodrigo, pela primeira vez, soou inseguro.
<p>-Você está brincando? Eu amei! - Sorri e o abracei, logo senti suas costas relaxarem em meu abraço.
<p>-Eu passei dias, semanas na verdade, pensando em quem vai cuidar de você quando eu partir. Foi então que a vi naquela vitrine, quem melhor para proteger alguém que um anjo guerreiro? - Falou empolgado, mas com a voz um tanto embargada.
<p>Não contei a ele que já havia assimilado minha nova protetora a um anjo da morte, afinal anjos da morte serviam a Lúcifer e, até onde eu sabia, ele tinha sido um anjo guerreiro. Por tanto, estava tudo certo ao que dizia respeito a minha proteção.
<p>Fomos até meu quarto, onde achei um lugar na mesinha para minha guardiã de resina, logo a tempo de ouvirmos tia Tânia nos chamar para o jantar.</p>
</body></html>";
            }

            if (numero == 8)
            {
                lblTitulo.Text = "Capítulo 8";
                htmlPage.Html = @"<html><body>
<p><i>“Toda noite e toda manhã
<br>Alguém para a miséria está a nascer.
<br>Em toda tarde e toda manhã linda
<br>Uns nascem para o grande gozo ainda.
<br>Uns nascem para o grande gozo ainda,
<br>Outros nascem para uma noite infinda.”
<br><b>Augúrios da Inocência (William Blake)</b></i></p>
<br>
<p>Numa tarde de quinta-feira quente e úmida, típica dos dias de verão em Sergipe, me vi sentada no banco de trás do carro de meus tios ao lado de Rodrigo e Adriel, enquanto Jorge guiava o carro em direção ao aeroporto. Tia Tânia estava incrivelmente quieta, provavelmente tentando não cair no choro de novo, como havia feito nos últimos dias, todas as vezes que se tocava no assunto da viagem.
<p>Ao chegarmos ao aeroporto, fomos informados de que o voo para São Paulo, de onde Rodrigo partiria para os Estados Unidos durante a madrugada, havia sido adiado por uma hora. Não sei se vocês já tiveram a chance de visitar o aeroporto de Aracaju, mas não tem muito o que se fazer por lá durante uma hora, enquanto tia Tânia e Jorge se ocupavam em vigiar Adriel para não o perder de vista resolvi ler um dos livros que havia pegado emprestado com minha amiga Bia, foi então que me lembrei de tê-lo deixado no carro.
<p>-Tia, será que eu posso ir até o carro? Esqueci uma coisa lá dentro.
<p>-Claro, querida. – Ela remexeu em sua bolsa. – Aqui está a chave, não esqueça de fechar quando voltar.
<p>-Tudo bem! – Quando já estava próximo a uma das saídas senti um braço rodear meus ombros, não precisava olhar para saber que era Rodrigo.
<p>-Vai ficar sem falar comigo para sempre? – Ele perguntou quando chegamos até o carro.
<p>-Só estou treinando, não vai ser tão difícil daqui alguns minutos. – Respondi sem olhá-lo.
<p>-Ótimo! Resposta nada agressiva. Estamos de bom humor hoje. – Rebateu ele.
<p>-Não tem nada a ver com humor, está bom? – Bati a porta do carro e me encostei de braços cruzados, ainda sem encará-lo.
<p>-Então o que?
<p>-Você está mesmo perguntando isso? – Bufei revirando os olhos.
<p>-Eu sei que isso é uma droga, mas são só alguns meses, eu volto para visitar vocês em julho. – Ele me abraçou e beijou o topo da minha cabeça. – Vai passar bem rápido, você vai ver.
<p>Rodrigo me abraçou com mais força, enquanto eu tentava impedir que as lágrimas, que insistiam em aparecer, rolassem por meu rosto e encharcassem a camisa dele.
<p>-Mas e se você esquecer de mim? – Sabia que estava soando como uma tola, mas não conseguia evitar.
<p>-Shhh... Não pense nisso! Eu nunca poderia esquecer de você! E quando você estiver se sentindo sozinha lembre-se do anjo-guardião, ele vai te fazer companhia quando a noite vier e eu não puder te encontrar sentada nos balanços do parquinho.
<p>A menção ao presente que ele me deu me fez rir de lado, o anjo-guardião, como ele dizia, já estava se mostrando ser realmente meu velho amigo Anjo da Morte, mais uma vez tirando de perto de mim aqueles que amo, ao menos dessa vez ele estava vivo e eu estava tendo a chance de me despedir. Me aconcheguei mais em seu abraço, imaginando se existia alguma chance de congelar aquele momento no tempo, para que ele não pudesse me soltar, nunca mais.
<p>-Ei, vocês dois! – Tia Tania apareceu ao nosso lado. – Sinto muito por atrapalhar a despedida de vocês, mas está na hora de você ir. – Ela falou olhando para Rodrigo. Os olhos dela agora refletiam os meus, cheios de lágrimas.
<p>-Tudo bem, vamos lá despachar o Mala Sem Alça. – Falei, implicando uma última vez com ele, antes que partisse. – Ah, e não esqueça do que eu te pedi.
<p>-Pode deixar! – Falou ele. – Na primeira chance que eu tiver, vou procurar seu amigo, Jesse, e falar que você está muito feliz por se ver livre de mim e que para ficar melhor só falta ele vir ficar com você. – Rodrigo me provocou enquanto caminhávamos em direção ao portão de embarque, onde ele teve que se esforçar para fazer tia Tania soltá-lo de seu abraço.
<p>-Bobo! – Fiz careta para ele que estava de joelhos no chão abraçando o irmão, em seguida, levantou para me abraçar uma última vez antes de partir.
<p>-Prometo que um dia eu vou fazer você esquecer todas essas preocupações, você vai entender que não tem nada a temer e que eu sempre estarei por perto. – Falou ao meu ouvido e saiu em direção ao portão de embarque.
<p>Quando voltamos para casa corri direto para meu quarto, ignorando qualquer coisa que tia Tania tenha falado sobre comer, pelo menos eu acho que era isso que ela falava. Fui até a mesinha, onde havia colocado meu pequeno amigo-anjo-guardião-da-morte, o peguei e me joguei na cama. Eu sabia que Rodrigo tinha razão em dizer que logo eu me acostumaria a falta dele e que quando ele viesse passar as férias em casa, nós poderíamos ficar o tempo todo juntos, mas naquela hora meu único pensamento era rejeitar a ideia de me acostumar a falta dele, assim como não havia me acostumado a falta de meus pais ou de meu irmão.
<p>Tentei tirar aquele pensamento de minha mente, não podia comparar a partida de Rodrigo com a falta de minha família, afinal, ao contrário deles, ele estava vivo e saudável, ainda que longe de mim. Fiquei deitada na cama, agarrada ao presente que ele me deu, até que agarrei no sono desejando acordar apenas quando ele estivesse voltando para mim.</p>
</body></html>";
            }

            if (numero == 9)
            {
                lblTitulo.Text = "Capítulo 9";
                htmlPage.Html = @"<html><body>
<p><i>“A recusa da existência é ainda uma maneira de existir. Ninguém conhece, enquanto vivo, a paz do túmulo.”
<br><b>(Simone de Beauvoir)</b></i></p>
<br>
<p>Seria desnecessário dizer que me tranquei em meu quarto e que fiquei de mal com a vida por ter perdido outra pessoa, exceto pela parte em que não foi isso o que aconteceu. As semanas que se seguiram a partida de Rodrigo foram as mais calmas, se não tediosas, desde o início da minha nova vida no Brasil. 
<p>Aproveitei o resto de minhas férias para ler a maior quantidade de livros, da estante de tia Tânia, que eu pude. Entre um clássico da literatura brasileira e outro, sempre lia e relia os mangás de Naruto com Adriel. Ele estava convicto de que seu sharingan despertaria a qualquer momento e não seria eu a responsável por desiludi-lo.
<p>- Lisa, você pode ler pra mim hoje? - O garoto me perguntou durante um jantar de domingo. 
<p>- Infelizmente, não vai dar, amigão! - Sua expressão entristeceu. - Minhas aulas voltam amanhã e eu preciso dormir cedo, mas eu prometo que leio quando chegar do colégio. Combinado? 
<p>- Combinado! - Ele me respondeu, exibindo um enorme sorriso. 
<p>No dia seguinte, acordei antes do alarme, verifiquei se não estava faltando nada em minha mochila e me arrumei para ir para o primeiro dia do meu último ano no colégio.
<p>- Ande logo com esse café, Lisa. - Tia Tânia me apressou. - Eu ainda tenho que deixar Adriel com a avó antes de te levar para a escola e não posso me atrasar para o trabalho. 
<p>- Já acabei!  - Falei, ainda de boca cheia, o que fez minha tia revirar os olhos enquanto saía da cozinha. 
<p>Quando tia Tânia entrou na rua da escola uma cabeleira lilás me chamou a atenção. 
<p>- Não acredito que ela fez mesmo!
<p>- Falou alguma coisa, querida? 
<p>- Ah, não! Nada, tia! Obrigada por me trazer! 
<p>- Não foi nada! - Tia Tânia respondeu sorrindo. - Quer que eu venha te buscar depois da aula? 
<p>- Não precisa! Eu posso voltar com Bia ou pegar um ônibus, não se preocupe. 
<p>-Tudo bem, então! Boa sorte no seu primeiro dia! - Ela me beijou no rosto antes de me expulsar do carro ao perceber que estava quase atrasada para o trabalho. 
<p>Respirei fundo, me virei e caminhei em direção ao portão do colégio e a cabeleira lilás que eu havia avistado antes. 
<p>- Eu realmente não acredito que você fez isso! - Falei ao chegar perto o bastante de Bia e sua cabeleira lilás. 
<p>- LISA! - Bia gritou meu nome e me abraçou. - Que bom te ver! Como você está? E suas férias? Gostou do meu novo cabelo? Por que você sumiu? Ah, vamos! O pessoal está louco pra te ver. - E saiu me arrastando. 
<p>Foi então que meu pesadelo começou:
<p>- Ei, vejam, se não é a senhorita sumida. - Diego me cumprimentou - Como você está? Soube que andou bancando a babá durante as férias. 
<p>- Eu estou bem! 
<p>- Lisa, bom te ver. Tem tido notícias de Rodrigo? - Um dos garotos que sempre andavam com Diego perguntou. 
<p>- É, como está aquele malandro? - Outro perguntou. 
<p>- Com toda certeza, pegando várias gringas nos intervalos das aulas. - Sheilla, prima de Diego, comentou.
<p>- Pessoal, pessoal, menos. - Diego interferiu. - Assim vai parecer que vocês só sentiram falta de Rodrigo, nem parece que não veem Lisa há mais de um mês. 
<p>- Valeu! - Agradeci baixinho a ele, quando íamos para sala.
<p>Diego e Sheilla eram os únicos da antiga galera, além de mim e Bia, que ainda estavam no colégio. Ela por ter estar no mesmo ano que nós, mas em uma outra turma, ele por ter repetido de ano.
<p>- Ai, que droga! - Bia gritou do nada. 
<p>- O que houve, Bia? Você está bem? - Ela olhava fixamente para a lista de alunos presa ao mural no corredor. 
<p>- Estamos em turmas diferentes. - Ela falou com irritação. 
<p>- O quê? Você tem certeza? - Perguntei. 
<p>- Sim, você e Diego estão no terceiro A e eu no B. Vou ter que aguentar Lily Fetiche e sua gang de depravadas sozinha. - Eu nunca tinha ouvido tanto desespero na voz de Bia. 
<p>- Primeiro, eu não vou nem perguntar porque Lily ganhou esse apelido. Segundo, você ainda pode pedir socorro a prima de Diego. - Tentei acalmá-la. 
<p>- Você diz isso porque tem Diego pra te salvar. Não fique assim tão calma, assim que você passar por aquela porta voltará a ser a prima do Rei do Colégio. - Bia tinha assumido a posição de “o ataque é a melhor defesa”. Eu estava prestes a respondê-la quando o sinal tocou. 
<p>Mas numa coisa ela estava certa: minha manhã foi um inferno. Cada ser vivo daquela escola parecia respirar para me irritar, perguntando sobre meu primo magnífico que estava vivendo o sonho americano enquanto ainda era um adolescente.
<p>- Eu juro que se mais alguém falar de Rodrigo perto de mim hoje vai levar um soco no estômago. - Berrei abafando a voz com minha mochila. Eu estava dentro da sala em pleno intervalo, porque não aguentava mais todo mundo querendo notícias de meu quase primo.
<p>- Relaxa, Li. - Diego estava sentado ao meu lado. - Ao menos você não está sendo obrigada a responder um questionário que tem por intuito eleger o novo Rei do Colégio a partir do nível de gostosura. - Ele falou sorrindo e apontando para a cara de desespero de Bia que estava vindo em nossa direção. 
<p>- Ha-ha-ha. Muito engraçado!  - Ela falou mostrando a língua para ele. - Essas garotas são inacreditáveis. Acredita que uma delas me perguntou quem eu acho que tem mais sexy apeel, Joe Jonas, Zac Efron ou Lucas, o novo garoto do segundo ano.
<p>- E o que você respondeu? 
<p>- Que eu sou melhor que eles, é claro. - Diego falou convencido.
<p>- Que eu prefiro pegar doença da vaca louca a ter que imaginar que essas são minhas únicas opções na vida. 
<p>Nós rimos da cara de nojo dela. Pelo menos até uma menina do primeiro ano entrar na sala procurando por mim. Ela me entregou um bilhete, era um convite para uma festa de volta as aulas na casa de uma garota que eu só conhecia de vista, mas lembrava que era uma das que me olhavam torto quando eu passava abraçada a Rodrigo pelos corredores.
<p>Bia logo me alertou que o objetivo do tal convite era extrair informações, as quais eu não tinha, da vida de Rodrigo. E eu declinei a proposta na mesma hora. Isso não me salvaria dos professores e dos curiosos de plantão que me paravam nos corredores, durante todo o primeiro mês de aulas, em busca de alguma novidade da vida de meu quase primo que pudesse virar notícia e fofoca. 
<p>Flagrei Diego e Bia ameaçando alguns garotos do primeiro ano para que eles espalhassem a notícia de que todo mundo na escola estava proibido de, até mesmo, pensar em Rodrigo. Nem me importei em saber quais seriam as possíveis consequências para quem desobedecesse, apenas agradeci aos dois mais tarde.
<p>Falar, ouvir ou pensar em Rodrigo era a última coisa que eu queria. Meu momento de negação sobre a partida dele havia passado, naquele momento eu estava rejeitando sua lembrança e chegar a aceitação de que ele, provavelmente, não voltaria parecia inconcebível.
<p>Mas não vou prender quem estiver lendo isso, se alguém estiver lendo, a esses momentos. Eles não foram momentos da minha vida dos quais me orgulho. Foram momentos de fraqueza que não precisam ser contados com tantos detalhes. Talvez eu os conte um dia, assim como o baile do qual vocês tanto ouviram falar, mas nunca souberam o que aconteceu.</p>
</body></html>";
            }

            if (numero == 10)
            {
                lblTitulo.Text = "Capítulo 10";
                htmlPage.Html = @"<html><body>
<p><i>“Foram apenas 15 minutos depois de 2 meses sem te ver e eu me senti exatamente igual as outras vezes que passamos juntos, volto pra casa imaginando uma vida ao seu lado e me perguntando porque eu sinto isso porque desse sentimento e penso, será que é só eu que lembro? É só eu que sinto falta?”
<br><b>(Para alguém que talvez nunca irá ler)</b></i></p>
<br>
<p>Nos meses seguintes as perguntas por Rodrigo tornaram-se cada vez menos frequentes, à medida que Lucas, o novo queridinho do colégio, ganhava espaço nos corações do corpo discente e caía nas graças dos integrantes da docência.
<p>No entanto, eu tinha razões para acreditar que o verdadeiro motivo para as perguntas terem sumido foram as ameaças feitas por Bia e Diego. Os dois nunca me contaram como conseguiram se livrar do assunto e eu nunca perguntei. Estava, apenas, agradecida pelos resultados incrivelmente satisfatórios. 
<p>Com Bia estudando em uma sala diferente da minha, eu e Diego ficamos cada vez mais próximos. Corriam boatos na escola de que nós estávamos namorando, não era verdade, mas nenhum dos dois se dava ao trabalho de desmentir a história.  Era uma relação onde as duas partes saíam ganhando: eu me livrava das cantadas baratas dos caras do time de futebol e ele se via livre da história maldosa que haviam inventado a respeito de sua sexualidade no ano anterior. Somente quando já estávamos na faculdade e depois de passar por várias sessões de terapia, Diego descobriu que era assexuado, o caminho para chegar a esse diagnóstico foi dolorido demais e não cabe a mim expor.
<p>Mas como eu disse, as perguntas cessaram, as fofocas diminuíram e em poucas semanas ninguém do colégio parecia lembrar que um dia Rodrigo havia estado entre eles. Sem o assunto 'Rodrigo' em foco eu pude me concentrar nos meus estudos. Além de ter aulas extras de língua portuguesa duas vezes por semana, com uma professora particular que tia Tânia insistiu em contratar.
<p>Ao final do primeiro semestre eu parecia ainda mais cansada que meus colegas, que também prestariam vestibular em alguns meses, graças a todas as aulas extras e as horas sem dormir devorando livros da literatura nacional. Nessa época eu estava um tanto obcecada por Machado de Assis e sua musa com olhar de cigana oblíqua e dissimulada.
<p>- Eu juro, por tudo que há de mais sagrado nessa droga de vida, se você me disser que virou a noite lendo Dom Casmurro pela milionésima vez eu vou socar sua cara - Bia sentou-se ao meu lado no refeitório durante o intervalo - Com tanta olheira, ninguém vai perceber o hematoma.
<p>- Então eu não digo! - Respondi em meio a um bocejo. - Então, quais os planos de vocês para as férias?
<p>- Viajar para a casa dos meus padrinhos no pantanal, fico todo empolado só de pensar no monte de mosquitos. - Disse Diego ao tanger uma nuvem de mosquitos imaginária para longe dele.
<p>- Bem... o plano mesmo era ser abduzida para um planeta onde não haja mais nenhum ser humano além de mim, mas, na falta do cumprimento dele, vou ser arrastada para uma viagem de família feliz com meu pai e minha madrasta. - Bufou Beatriz.
<p>- E você? O que vai fazer nas férias, senhorita Capitolina? - Diego estava esparramado em cima da mesa do refeitório olhando de lado pra mim enquanto falava. - Eu sugiro hibernação. Você está um trapo.
<p>- Dormir é superestimado! - Rebati fazendo careta para ele.
<p>Depois de descobrir que eu estaria oficialmente sem amigos durante as férias, tive de admitir que não dava mais para continuar lendo Dom Casmurro de novo e de novo pelas próximas quatro semanas. Decidi que precisava de livros novos, ou livros que ainda não havia lido, resolvi que atacaria a biblioteca de tia Tânia antes que ela voltasse do trabalho. Eu estava doida para ler Os Miseráveis, mas ela morria de ciúmes do seu exemplar e se negava veementemente a me deixar pegá-lo emprestado.
<p>- Tânia? Jorge? Cheguei! Alguém em casa? - Como eu esperava, ninguém respondeu.
<p>Larguei minha mochila num canto perto do sofá da sala e fui até a biblioteca que tia Tânia deixava, gentilmente, que Jorge usasse como escritório. Fui até a estante e busquei pelo título do livro: Aqui está você, meu novo melhor amigo! 
<p>- Você assustou tanto as pessoas que está precisando recorrer a amigos feitos de papel encadernado?
<p>Por um instante achei que tinha imaginado aquilo, afinal, eu estava sozinha e não tinha como eu ter ouvido nada, principalmente aquela voz. Mas então me virei e senti seus braços me rodearem e me levarem de encontro a seu peito, senti sua respiração e o cheiro doce de seu hálito quando sua voz disse que tinha sentido minha falta.
<p>Trinta segundos. Talvez menos. Esse foi o tempo que meu coração levou para acordar, depois de quatro meses hibernando, e começar a bater de novo, como se nunca tivesse parado, como se nunca tivesse se despedido de Rodrigo naquele aeroporto.  Ele parecia querer fundir nossos corpos dentro daquele abraço, cada vez mais apertado.
<p>- O que... como... quando? O que está fazendo aqui? - Consegui proferir, por fim.
<p>- Isso realmente importa?
<p>Então, Rodrigo me beijou. Aquele beijo era a única resposta que eu queria, que era necessária e que importava. Meu corpo parecia só naquele momento perceber a saudade acumulada durante todas aquelas semanas de silêncio, estava totalmente inebriado pela presença de Rodrigo e, ao mesmo tempo, nunca esteve tão alerta.
<p>Cada beijo, cada toque, cada roçar de pele ganhava proporções extraordinárias. Os Miseráveis jazia a nossos pés, devo tê-lo soltado em algum momento entre a surpresa de ver Rodrigo e a necessidade de estar em seus braços de novo. As terminações nervosas do meu corpo imploravam cada vez mais pelo toque de seus lábios e ele não se opunha em saciá-las, assim como eu não me recusava a saciar as suas. Porque naquele momento, mais do que em qualquer outro, eu tinha absoluta certeza de que ele sentia tanto minha falta quanto eu a dele.
<p>Não sei por quanto tempo ficamos naquele estado hipnótico. Cinco minutos? Vinte? Uma hora? Talvez mais, talvez menos. O fato é que, em algum momento daquela tarde, fomos tirados de nosso transe ao ouvir a porta da frente bater, revelando a chegada de alguém. A voz animada de Adriel chamando pelo irmão chegou até nós.
<p>Sem dizer uma única palavra, Rodrigo desfez o abraço, me deu um beijo rápido e foi em direção a porta, enquanto eu continuei parada no mesmo lugar, meu cérebro tentando processar os últimos acontecimentos.
<p>- Estou aqui, amigão! - Ouvi Rodrigo gritar do corredor em resposta ao irmão, logo depois reaparecendo na porta da biblioteca. - Você não vem?</p>
</body></html>";
            }

            if (numero == 11)
            {
                lblTitulo.Text = "Capítulo 11";
                htmlPage.Html = @"<html><body>
<p><i>“Você sabe aquela noção romântica que todo o lixo e dor é na verdade bom pra se curar? Não é. É apenas lixo e dor. Sabe o que é melhor? Amor! No dia que você começar a achar que o amor está ultrapassado, será o dia que você perderá a razão. A única coisa errada com o amor é não tê-lo.”
<br><b>(Haley James Scott - One Tree Hill)</b></i></p>
<br>
<p>Ser otimista.
<p>Pensar positivo.
<p>Não se deixar abater.
<p>São expressões bonitas, mas que se tornam vazias e sem sentido na mente de alguém que perdeu tanto em tão pouco tempo.
<p>E eu perdi mais uma vez.
<p>Aquela visita foi a última vez que Rodrigo veio nos visitar em anos.
<p>A próxima vez que o vi, eu estava prestes a finalizar meu terceiro ano em medicina e fui aos Estados Unidos para um congresso de oncologia, ele também estava lá. Eu havia pedido que não o avisassem sobre minha viagem, planejava não o ver, mas não somente o vi, como vi sua namorada, Susan, agarrada a seu pescoço.
<p>Não é que eu não tenha tido outros casos durante os anos, é que o ver me fazia lembrar de uma parte do meu passado que eu lutava todos os dias para esquecer. Quando ele me viu, pude reconhecer seu olhar de surpresa e confusão, me perguntando em silêncio o que eu fazia ali sem que ele soubesse. Rodrigo fez menção de vir até mim, mas alguém o puxou em direção a outro auditório, não sei quem o fez, ainda que seja grata a essa pessoa.
<p>Desde então, não trocamos uma palavra sequer a sós, pelo menos, não verbalmente. Mesmo com a distância e o tempo, aquela conexão que havia entre nós parecia apenas crescer e se fortificar, não precisávamos mais que algumas trocas de olhares para saber se o outro estava bem. Isso era o suficiente para me manter o mais distante possível de casa quando ele vinha visitar a família.
<p>Suas visitas tornaram-se cada vez mais raras, à medida que sua vida se solidificava mais e mais no exterior. Em geral, meus tios e Adriel é que iam até ele nas datas comemorativas e eu usava a universidade como desculpa para escapar das viagens, quase sempre uma escapatória eficiente.
<p>E aqui estamos! Eu tenho vinte e seis anos e acabei de me mudar da casa de minha tia Tania. Quando fechei a porta da casa dela hoje cedo, eu finalmente percebi que as pessoas pararam de me deixar quando parei de me agarrar a elas.  
<p>Foi assim com Rodrigo, com Bia, que se mudou para o centro-oeste logo após o primeiro período do curso de Artes. Com Marcos, meu ex-namorado, que me largou para ficar com o melhor amigo de infância, depois de uma bebedeira reveladora durante uma acalorada no quinto período.
<p>Deixar as pessoas irem virou minha especialidade. Sempre que eu conheço alguém, me preparo para o momento em que perderemos contato, seja em cinco minutos ou cinco anos. É uma forma de não criar expectativas em cima das outras pessoas, assim eu não cobro delas ou de mim nada além de respeito e sinceridade. Assim, eu me privo do sentimento de dor e do vazio deixado toda vez que alguém de quem gosto se afasta.</p>
</body></html>";
            }
        }

        public void clkAbrirComentar(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MyPopupPage("AnjoMorte", condicao.ToString()));
        }

        public void clkIrMenu(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MenusView.MenuAnjoMortePage());
        }

        public void clkAbrirProximo(object sender, EventArgs e)
        {
            if (condicao + 1 > 11)
            {
                DisplayAlert("CAPÍTULOS!", "VOCÊ CHEGOU NO ÚLTIMO CAPÍTULO. CONFIRA OUTRA HISTÓRIA", "OK");
            }
            else
            {
                Navigation.PushModalAsync(new Capitulo2Page(condicao + 1));
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
                } else
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
                    Historia = "AnjoMorte"
                }, UserLocalData.userUID, "AnjoMorte", "Capitulo" + capitulo);
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