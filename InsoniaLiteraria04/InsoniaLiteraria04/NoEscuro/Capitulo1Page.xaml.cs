using InsoniaLiteraria04.Database;
using InsoniaLiteraria04.Global;
using InsoniaLiteraria04.Helper;
using InsoniaLiteraria04.Model;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InsoniaLiteraria04.NoEscuro
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
            mostrarCapituloSalvo("NoEscuro", "Capitulo" + numero.ToString());

            if (numero == 1)
            {
                lblTitulo.Text = "Capítulo 1 - Retorno";
                htmlPage.Html = @"<html><body>
<p>O céu já estava escurecendo quando Joseph finalmente se deu conta que seu carro estava cruzando a Ponta Deja.
<p>Seu filho, Carl, dormia todo torto em cima da cadeira de viagem no banco de trás enquanto Victoria, a esposa, dava os seus últimos retoques na maquiagem. Ela sempre ficava nervosa quando se encontrava com os pais do marido, sempre queria ficar impecável, perfeita. Dessa vez, a pressão era maior. Nunca tinha ido na casa deles, Joseph se recusava a fazer uma visita, geralmente eles iam até o filho, o que deixava Victoria mais à vontade já que estava em sua própria casa, agora seria um território desconhecido e ela não era muito fã dessas situações.
<p>Além de sua pequena família, Joseph também levava no banco de trás Michael. Um atleta que na época da faculdade dividiam um apartamento e que três anos atrás, o acolheu depois de sua carreira no futebol ter acabado após um acidente que causou uma fratura no joelho do jogador o impossibilitando de um dia voltar a entrar em campo. 
<p>O carro estava silencioso. Era evidente que todos estavam ansiosos para chegar ao destino depois de três horas de viagem. Joseph, por outro lado, estava quieto desde que entraram no carro naquela tarde. A coisa que ele menos queria era retornar para Darkey algum dia e sempre pensou que isso nunca seria necessário, mas estava enganado. 
<p>Seus pais fariam uma festa para comemorar os cinquenta anos de casados em sua casa e queriam toda a família reunida. Joseph passou dias no telefone com sua mãe tentando convencê-la a fazer a festa na sua cidade onde ele poderia conseguir salões muitos melhores e maiores com serviços de buffet e todas as frescuras que queria, mas ela insistia que preferia Darkey. Lá estavam todos os seus amigos, parentes restantes e seus outros filhos. Joseph foi o único que saiu de lá depois de tudo. 
<p>- Eu estou muito ansiosa para conhecer o lugar onde você cresceu. – Victoria sorriu ao ver a placa de “Bem-Vindos a Darkey” no final da imensa ponte que ligava o pequeno povoado com o estado. 
<p>- Eu também estou ansioso. Você nunca falou muito dela. – Michael comentou do banco de trás.
<p>- Não há muito o que falar. É uma cidade pequena como outra qualquer. – Joseph respondeu sem muita paciência. 
<p>Na verdade, ele nunca contou a ninguém como era aquela cidade, sempre mudava de assunto quando aquilo era citado em uma conversa e sempre disse que só saiu de lá porque queria conhecer o mundo. Essa era uma das razões, mas não era a única. Os assassinatos que aconteceram naquele lugar há dez anos ainda deixavam Joseph sem dormir à noite às vezes. Ele lembrava de cada notícia, de cada foto divulgada, de cada comentário e de cada vítima.
<p>Darkey continuava exatamente como Joseph lembrava. As pequenas casas todas iguais que rodeava as ruas cobertas de pedregulho. Ele se iludiu achando que nessa altura já haveria pelo menos um projeto de asfalto por lá. As mesmas padarias e mercadinhos. As paredes da igreja só precisavam de uma boa mão de tinta, estavam gastas, mas de resto estava exatamente como ele se lembrava. A delegacia havia sido reconstruída depois do incêndio, ele não chegou a vê-la, mas não estava muito diferente do que era antes. Pessoas despreocupadas andando no meio da rua e conversando com seus vizinhos, rostos familiares dez anos mais envelhecidos. 
<p>Eles avistaram no final da rua principal uma casa que quase poderia ser considerada uma mansão. Havia um muro bem alto cercando a propriedade que só podia ser vista porque era composta de três andares. O portão central de ferro puro e totalmente sem buracos impossibilitava qualquer um de tentar espiar. Nada havia mudado quanto a isso. Havia um motivo para os Rose terem a fama de “os intocáveis”. Esse era o motivo.
<p>- Chegamos. – Joseph finalmente falou quando parou em frente ao portão. 
<p>O espaço do lado de dentro para estacionar um carro era imenso. Cabia uma grande piscina naquele jardim. Quando era mais jovem, Joseph sempre implorou por uma para os pais, mas nunca teve sucesso.
<p>O céu estava estrelado quando saíram do carro, algo que não se via muito na cidade cheia de prédios e nuvens. Joseph tirou o filho, que continuava em um sono pesado, da cadeirinha e o segurou no colo. Seus pais vieram ao seu encontro, sorridentes e com abraços calorosos. Depois de muita falação e barulho, Carl acabou acordando perguntando no ouvido do pai se já haviam chegado na casa dos avós. 
<p>Foi como entrar em uma máquina do tempo quando Joseph entrou no seu antigo quarto e jogou suas malas em um canto. O quarto estava exatamente como ele havia deixado há dez anos. Os mesmos pôsteres de carro pendurados na parede. A mesma mobília, tapetes, cortinas... A cama de casal que ele pegou do seu irmão depois que o outro casou. Ele se sentou na ponta da cama e começou a observar cada detalhe. 
<p>- Eu não acredito que você saiu daqui. Essa casa é muito linda. – Victoria entrou no quarto e se sentou ao lado do marido.
<p>- É, eu costumava me sentir um rei morando aqui. Parece que já faz uma eternidade.
<p>- Você trocou uma mansão por uma caixa de sapatos. Nunca entendi porque nunca me trouxe aqui. Eu até cheguei a pensar que essa casa fosse um trailer velho no meio do mato. – Ela riu ao lembrar de sua teoria. 
<p>- Acho que me acostumei com a cidade. Voltar para o interior é meio tedioso. 
<p>- Eu que nunca estive no interior, estou adorando. 
<p>- Você não está nem a uma hora aqui.
<p>- Mas já acho tudo maravilhoso. Sua mãe está dizendo que está preparando um lindo banquete para gente essa noite no jantar. Ela está muito animada.
<p>- É. – Joseph ainda não estava com aquela animação toda. – Sabe, eu estava pensando em dar uma volta, sentir uma nostalgia. Sabe como é.
<p>- Quer que eu vá com você?
<p>- Não. Além do mais, minha mãe ficaria uma fera se ela fizesse um banquete e ninguém ficasse para comer.</p>
<center><h4>--*--</h4></center>
<p>Quando era mais novo, Joseph sempre se irritava com a cultura de Darkey. Todo mundo conhecia todo mundo, se você não desse “bom dia” para a dona Maria da rua três, você era mal-educado. Era bom andar por aquelas ruas sem ninguém lembrar exatamente do rosto dele. Alguns paravam para ver melhor, mas ninguém se arriscava a perguntar se era ele de verdade. 
<p>Marcenaria do Roe – o lugar que Joseph passava mais tempo quando era criança. Roe tinha um filho, Alexander, que acabou virando melhor amigo do pequeno Joe, era como o chamava quando o via entre as tábuas brincando de esconde-esconde com seu filho ou quando os três comiam juntos marmitas prontas compradas na padaria mais próxima. 
<p>- Será que eu consigo encomendar uma mesa de jantar a essa hora? – Joseph entrou no armazém e foi até o fundo, onde sabia que era o lugar onde Roe fabricava os móveis com as próprias mãos. 
<p>- É só mesa e está um pouco tarde. 
<p>Joseph podia jurar que estava vendo Roe uns trinta anos mais novo, com aquele avental, luvas, mascara, óculos e chapéu de proteção que ele conhecia bem. Não foi uma grande surpresa saber que Alexander havia entrado no ramo e que estava ajudando o pai a tocar a loja. 
<p>- Bem tarde. – Alexander completou sua própria frase. Ele desligou imediatamente a máquina de cortar madeira, retirou os acessórios de proteção e abriu um longo sorriso. – Achei que nunca mais iria ver meu irmão estudado de volta. 
<p>- Eu disse que um dia te surpreenderia. 
<p>Joseph foi até o amigo e lhe deu um forte abraço. Eles não costumavam fazer isso quando eram jovens, mas aquela ocasião exigia isso deles. 
<p>- Olha só, está mais forte, até parece que está mais alto.
<p>- Cala a boca.
<p>Alexander sempre se gabou na juventude por ser o mais alto dos dois, embora a diferença de altura não fosse nem dez centímetros.
<p>- Cara, o que está fazendo aqui? Não me diga que a sua mãe finalmente te convenceu a vir em uma festa dela?
<p>- É, todo ano ela inventa um evento imperdível para ver se eu volto para cá. Dessa vez ela venceu. – Joseph riu da derrota.
<p>- Como está indo a sua volta até agora?
<p>- Bom, na verdade, esse foi o primeiro lugar que eu vim. Estava esperando ver o Roe te dando ordens de como cortar certo uma tábua sem espanar. Eu estou surpreso por ele deixar você mexer nas coisas sozinho. Se aposentou, foi? Está lá em cima tomando chá e vendo a novela? – Era engraçado para Joseph pensar nisso. Ele sempre imaginou que Roe trabalharia até com um andador e totalmente senil.
<p>- Joe, meu pai morreu. Faz sete anos. Infarte. 
<p>- Eu não... Foi por isso que quebrou o nosso pacto e não saiu daqui também? – Ele não sabia se deveria dar os pêsames ou continuar com a conversa normalmente. 
<p>- Eu não podia deixar tudo isso aqui. É o legado dele, tudo o que ele deixou. Tudo o que restou. – Alexander fez uma pausa. – Eu até que aprendi bem, acerto mais do que erro. E as pessoas são legais comigo. 
<p>- E quanto a carreira de medicina?
<p>- Eu sempre corto meus dedos nessa máquina e faço curativos. – Era uma piada muito sem graça, ele sabia. – Os planos mudam. 
<p>- Devia ter me contado.
<p>- Por quê? Você não ia voltar e eu também não queria que voltasse. 
<p>- Ah eu sei lá... Eu fui embora e quis deixar tudo de ruim para trás. Esqueci que acabei deixando a parte boa também. 
<p>- Você não veio até aqui chorar, não é? – Alexander sorriu. – Relaxa, já faz muito tempo. Eu estou bem. 
<p>- É, eu sei. 
<p>- Bom, a gente devia dar uma volta amanhã, andar de bicicleta, como nos velhos tempos. O que você acha?
<p>- Nossa, eu nem sei mais se eu consigo andar de bicicleta. – Joseph brincou.
<p>- Ah é, na cidade grande você só usa carro, não é?
<p>- Eu posso tentar me lembrar. 
<p>- Sabe, talvez você queria ir ao Bar da Tribo depois daqui.
<p>- Ah é? O que mudou lá? As dançarinas?
<p>- Está sob nova direção já faz um tempo. Você vai gostar. Eu acho.</p>
<center><h4>--*--</h4></center>
<p>O Bar da Tribo era conhecido como o lugar proibido para os jovens quando Joseph morava em Darkey. Toda noite um bêbado arrumava uma briga com outro bêbado e a policia intervia. O bar se encontrava na parte mais isolada da cidade. Das suas janelas, os clientes conseguiam ver as grandes árvores que rodeavam a cidade.
<p>O lugar não era muito iluminado e naquela noite também não estava muito frequentado. Quando Joseph cruzou a porta, ele viu a atendente do bar conversando com um homem no balcão, ela parecia estar de bom humor e sorria, o sorriso que ele conhecia muito bem e que não via há muito tempo.
<p>- Olha só, o filho pródigo a casa torna. – A atendente parou de falar com o cliente e gritou assim que o viu. Por um segundo, seu sorriso se transformou em surpresa, depois seu rosto ficou com uma expressão neutra. 
<p>- É, um dia isso tinha que acontecer. – Joseph tentou ser simpático ao se aproximar do balcão. – Tudo bem?
<p>- O que você acha? Hoje só está um pouco fraco. – Ela respondeu ainda neutra.
<p>- Eu não quis dizer...
<p>- Eu sei o que você quis dizer. – Os dois ficaram se olhando por alguns segundos. – O que faz aqui?
<p>- Meus pais vão comemorar anos de casados e... Eu apareci. 
<p>- Nossa, estou chocada. – Ela continuou não demonstrando emoções.
<p>- Eu...
<p>- Quer beber alguma coisa? – Ela logo perguntou. Queria ao máximo evitar qualquer conversa paralela.
<p>- O que você achar melhor. – Ele percebeu a intenção dela. 
<p>A mulher pegou uma garrafa de whisky na estante, colocou um copo no balcão, o encheu com o liquido da garrafa e entregou para Joseph. O olhou por uma última vez e então foi para o outro lado do bar atender outros clientes. 
<p>As horas foram passando. De vem em quando ela passava por ele e enchia novamente o copo com whisky. As poucas pessoas que estavam no bar foram embora pouco a pouco até que os dois ficaram sozinhos. 
<p>- Você acabou com a garrafa. Agora eu preciso fechar o bar. – Ela pegou o copo e jogou na pia. 
<p>- Eu queria conversar e...
<p>- Eu não quero conversar. 
<p>- Trabalha aqui agora? – Joseph tentou puxar assunto com algo obvio. 
<p>- Eu sou a dona. Smith vendeu por preço de banana porque queria se aposentar e porque não estava dando tanto lucro como antigamente. 
<p>- Nossa, que bom para você. 
<p>- Muito bom.
<p>- E quanto aquele cara que você conversou a noite toda? Ele é seu... namorado?
<p>- Você não muda mesmo, não é? – Ela riu. – Eu posso conversar com um cara e não ter interesse por ele. Você sabe disso. 
<p>- Desculpa. 
<p>- Mas que ótimo. O que faz aqui? – A mulher já tinha perdido a paciência.
<p>- Eu te disse, a minha mãe...
<p>- Não aqui na cidade, aqui “aqui”. Por que veio atrás de mim? Por que agora?
<p>- Eu não... – Joseph não sabia o que responder. Nem ele mesmo sabia o que fazia lá. Quando ele entrou no bar e a viu, deveria ter fugido. Deveria ter voltado para casa. Mas ele ficou. – Eu me casei. – Ele mostrou seu anel no dedo. – Tenho um filho.
<p>- Que ótimo. 
<p>- Acho que é melhor eu ir embora. – Ele percebeu que tinha falado algo bem desnecessário.
<p>- Também acho. 
<p>Ele se levantou. Pegou uns trocados que tinha na carteira e colocou em cima do balcão. No meio do caminho até a porta, ele se virou para ela. 
<p>- Eu sinto muito.
<p>- Eu realmente não quero falar sobre isso.
<p>- Mas... 
<p>- Vai embora.
<p>- Lori. – Ele a encarou.
<p>- Você foi embora! – Ela sem querer derrubou no chão o copo que estava enxugando. – Você foi embora sem ao menos se despedir e então aparece depois de dez anos e pergunta se eu estou bem. Qual é o seu problema?
<p>- Eu sei que...
<p>- O que você esperava? – Lori continuou. – Uma recepção calorosa? Beijos e abraços?
<p>- Não, eu só...
<p>- Não tem uma desculpa e tudo bem, não estou esperando por uma. Você veio para uma festa e depois vai embora. O que “isso” vai agregar na nossa vida? Nada. Sai daqui.
<p>- Eu não... Eu deixei uma carta. Não foi bem...
<p>- Eu rasguei se você quer saber. Se você não tem coragem de falar na minha cara, não vale a pena ler as palavras. 
<p>- Isso não é justo, sabia? – Joseph ficou bravo. 
<p>- Não, não é. Agora vai embora. 
<p>- Você nunca concordou. – Ele ficou de saco cheio. – Bem antes de tudo acontecer, eu sempre te disse que queria ir embora, sair dessa droga de cidade, e você nunca, nunca se interessou por isso. 
<p>- Eu não podia deixar meu pai.
<p>- Então por que eu iria pedir para você ir embora comigo quando eu finalmente estava indo?
<p>- Eu não queria que pedisse, só esperava um “adeus”. Uma despedida, só isso.
<p>- Você não entende, não é? Eu não podia me despedir de você. 
<p>- Vai embora. – Lori o olhou nos olhos praticamente suplicando. 
<p>- Não vou voltar mais aqui.
<p>- Ótimo. 
<p>Lori ficou observando Joseph sair do bar. Bufou bem alto e depois foi trancar a porta, apagou as luzes e voltou para o balcão. Naquela noite, ela ia beber todo álcool que aguentasse.</p>
<center><h4>--*--</h4></center>
<p>Victoria já estava em um sono profundo quando Joseph entrou no quarto. Ele abriu o guarda roupa e viu que suas roupas já estavam guardadas lá. Pegou um conjunto de roupas e uma toalha. O clima naquela cidade era muito abafado, ele estava muito suado, precisava de um banho antes de se deitar.
<p>Joseph sentiu um grande peso nas costas enquanto a água do chuveiro caia pelo seu corpo. Ele sabia que aquele retorno não seria um mar de rosas e ele nem havia se encontrado com metade das pessoas que ele tinha convívio, mas com certeza já teve o pior reencontro. Nenhum superaria a Lori. 
<p>A cama não estava tão confortável quanto ele esperava. O problema não era o colchão, era sua cabeça cheia de pensamentos. Não queria se mexer muito para não acordar a esposa, mas estava muito inquieto. 
<p>Ele respirou fundo e se levantou. Tirou o pijama e colocou uma roupa, precisava dar uma volta. Ele não via tantas árvores juntas fazia muito tempo. Conforme ele ia adentrando mais pelas árvores que rodeavam a cidade mais elas cobriam o céu com os seus galhos e folhas. Estava muito escuro e ele chegou a tropeçar algumas vezes em raízes. 
<p>Ele andou até o Comma. Um lago escondido entre a floresta. Ele nadava o tempo todo naquele lago quando era jovem. Parecia outra vida. 
<p>Talvez tivesse sido por causa do escuro ou sua distração, mas demorou algum tempo para Joseph perceber que não estava sozinho ali. Havia alguém boiando bem no meio do rio.
<p>- Ei! – Joseph gritou. – Está tudo bem aí?
<p>Sem resposta.
<p>Seu instinto o forçou a tirar os sapatos, dar um mergulho e ir até o corpo flutuante. Estava inconsciente. Joseph se aproximou por trás do corpo e passou um dos braços pela axila e do queixo dele enquanto seu outro braço ficou livre para nadar. Ele não tinha muita habilidade em “remar” com o braço, teve sorte de ser um lago de água parada. 
<p>Quando chegaram à margem, Joseph empurrou o corpo para fora do lago e logo após saiu também. Ele se aproximou da boca e do nariz da pessoa para checar sua respiração, mas não havia nenhuma. Ele iniciou a ventilação boca-a-boca, tampando o nariz da pessoa e assoprando ar na boca. 
<p>A respiração boca-a-boca não surtiu nenhum efeito. Ele começou então a fazer séries de massagens cardíacas. Ele repetiu o ciclo de respirações e massagens por alguns minutos até perceber que não ia adiantar. A pessoa, que ele logo identificou como uma mulher na casa dos quarenta, estava morta. 
<p>Joseph se levantou cansado e totalmente gelado. Fixou seu olhar no rosto da mulher para ver se conseguia reconhece-la, mas foi inútil, além de estar escuro, ele não tinha uma memória muito boa para rostos vistos há dez anos. Ampliou então a visão e olhou para o corpo da mulher e então percebeu um detalhe. Quatro detalhes, na verdade.
<p>A mulher estava sem seus pés e suas mãos. Cortes relaxados indicavam o final de seus membros. Automaticamente ele se agachou, pegou no pescoço dela e sentiu outro corte na sua nuca. 
<p>Aquela mulher havia sido assassinada.</p>
</body></html>";
            }

            if (numero == 2)
            {
                lblTitulo.Text = "Capítulo 2 - A Mulher No Lago";
                htmlPage.Html = @"<html><body>
<p>Já fazia um bom tempo que o lago Comma não era fotografado pela perícia forense.
<p>O sol estava nascendo quando a equipe terminou de catalogar todas as evidências do local e retirar o corpo da mulher das margens do rio. Naquele exato momento, se algum civil passasse por ali, só veria um saco preto entrando em uma van também preta que seguiria direto para a delegacia de Darkey. 
<p>Joseph tomou distância assim que os policiais chegaram e ficou observando eles trabalharem. Embora ele já tivesse visto várias cenas de crime com corpos em situações piores do que aquele, algo o estava afetando mais que o normal. Horas antes ele havia constatado que a mulher estava realmente morta e que alguns dos seus membros haviam sido arrancados de uma forma brutal. No mesmo momento, ele ligou para a delegacia, ainda se lembrava do número de cor e então, dez minutos depois, uma viatura apareceu na sua frente cantando pneu ao estacionar. A primeira coisa estranha que ele notou foi que não havia barulho de sirene e as lanternas azuis e vermelhas estavam desligadas. Aquela viatura queira passar despercebida o máximo possível. 
<p>- Senhor, eu gostaria de fazer umas perguntas. – Os pensamentos de Joseph foram interrompidos por uma voz um pouco nervosa e ansiosa. Aquele policial não parecia ter mais de vinte anos e definitivamente não tinha muita experiência em campo. Olhou para o corpo mutilado e quase vomitou e agora estava olhando para Joseph com um pouco de cautela como se esperasse que ele fosse arrancar seus pés e mãos também. 
<p>- Manda a ver. – Joseph cruzou os braços e olhou para o policial.
<p>- Seu nome. 
<p>- Joseph Victor Rose. 
<p>- Idade. 
<p>- Vinte e oito anos. 
<p>- O senhor encontrou o... a... – Ele não sabia muito bem como definir o achado.
<p>- O corpo da mulher desconhecida. Sim, encontrei. Estava boiando no lago. 
<p>- Certo. – Ele começou a fazer anotações em um bloco de texto que ele segurava firmemente em uma das mãos, já sua caneta tremia um pouco. – O que o senhor fazia no lago de madrugada?
<p>- Eu estava caminhando. – Joseph respondeu sem muita emoção.
<p>- Sozinho? Você não estava com mais ninguém?
<p>- Está vendo alguém do meu lado, policial?  - Ele encarou o policial com um olhar um pouco neutro. – Gostaria de falar com o xerife. Pode me dar uma carona na sua viatura?
<p>- Ainda não. Tenho mais umas perguntas. – Ele se apressou a dizer. – Você tocou na... no corpo?
<p>- Levando em consideração que eu a encontrei no lago e quando vocês chegaram, ela já estava na margem, eu tenho que responder “sim”. 
<p>- Certo. Por quê?
<p>- Achei que ela estava se afogando. Então eu tirei ela do lago e tentei fazer ressuscitação. 
<p>- Mas não funcionou.
<p>- Obviamente. 
<p>- Certo. – Ele fez outras anotações. – Mais outra pergunta.
<p>- Eu não vi ninguém nem escutei nenhum barulho.
<p>- Certo. 
<p>- Podemos falar com o xerife agora? – Joseph já estava perdendo a paciência.
<p>- Bom...
<p>- Eu não sou suspeito, policial... Carter. – Ele viu o nome do policial em seu crachá pendurado no uniforme. 
<p>- Foi pego na cena do crime.
<p>- Eu liguei para a polícia.
<p>- Talvez para despistar. 
<p>- Olha, você deve ser novo no ramo, então eu vou te dizer uma coisa. Você não pode fazer um interrogatório aqui. É para isso que servem as salas da delegacia. E também não pode me acusar.
<p>- Mas...
<p>- Essa mulher morreu um ou dois dias atrás. Eu estava trabalhando em outra cidade e muitas pessoas podem confirmar isso. 
<p>- Você não sabe quando ela foi morta.
<p>- Um ou dois dias atrás. Devido a coloração da pele, fungos nas feridas, a deterioração do cadáver causado pela água doce do lago e pelos animais aquáticos que podem ter se alimentado do corpo nesses dias entre outros fatores. 
<p>- Como você...
<p>- Eu examinei a vitima e dei essas informações para a sua equipe forense que demorou duas horas para confirmar o que eu já tinha dito. A propósito, esqueceu de perguntar minha profissão.
<p>- Ah, é verdade. – O policial começou a procurar nas suas anotações se havia escrito algo referente aquilo no papel.
<p>- Sou formado em ciência forense, mas acabei indo para o ramo de ação. Sou o Agente Federal Joseph Rose de Grabe City. Eu mostraria o meu crachá, mas está no meu quarto. Te mostro depois.
<p>- Ah. – O jovem policial ficou chocado e estava quase pedindo desculpas para alguém que ele achava ser seu superior. 
<p>- Podemos ir falar com o seu xerife agora? 
<p>O policial só balançou a cabeça positivamente.</p>
<center><h4>--*--</h4></center>
<p>A delegacia de Darkey estava solitária quando Joseph entrou. Ele desceu da viatura primeiro que todo mundo e já foi direto para a porta. 
<p>Andar em um daqueles carros trouxe várias memórias de volta. Muitas vezes, ele era levado de viatura para a sua casa e sua mãe vinha até o portão toda desesperada. 
<p>Ele tocou a campainha em cima de uma mesa que deveria ser da secretária do xerife, já que logo atrás, havia uma porta com uma placa dourada com as letras bem grandes “XERIFE”. Joseph olhou para os lados. Não havia nenhum vestígio sequer que mostrava que um dia aquele mesmo lugar pegou fogo. Era impressionante. 
<p>- Meio cedo para aparecer aqui, não acha? – O xerife abriu a porta e saiu com o seu chapéu, que parecia mais de um caubói, em uma das mãos. A estrela no peito brilhava mais que as lâmpadas no teto. 
<p>- Barry? – Joseph ficou impressionado. – Você é o xerife.
<p>- Saiu da cidade no momento certo, Joe. – Barry abriu um sorriso. Seu bigode e barba grisalha quase escondia seus enormes dentes já amarelos. Seus olhos estavam vermelhos. Com certeza havia passado a noite acordado assim como Joseph, mas não parecia tão cansado. 
<p>- É, senão seu sonho de me colocar em uma cela se realizaria. 
<p>- Vem aqui. 
<p>Barry o abraçou paternalmente, depois o levou para dentro de sua sala e fechou a porta. A sala estava uma bagunça. Havia arquivos por todos os lados de sua enorme mesa. Pilhas de caixas de papelão espalhadas pelo chão. Uma xicara de café já gelado ao lado do telefone. 
<p>- Sente-se. – Barry se sentou em sua cadeira e apontou para outra do outro lado da mesa.
<p>- Obrigado.
<p>- Como você está?
<p>- Eu estou bem. E você? Quando virou xerife?
<p>- Seis anos atrás. O velho William se aposentou. Pegou a esposa e foi para o litoral. Quis morar com os peixes. – Ele gargalhou. – Minha filha sabe que voltou?
<p>- Não falou com ela ontem?
<p>- Não. Sai muito tarde daqui e uma hora depois tive que voltar.
<p>- É, a noite não foi muito boa para mim também. – Joseph olhou para a mesa e viu as fotos. Aparentemente, a equipe já havia mandando para Barry todas as fotos do lago e do cadáver por e-mail e ele havia imprimido para olhar melhor. Aquele homem nunca foi de fazer as coisas diretamente em um aparelho eletrônico. 
<p>- É, uma pena. 
<p>- Quem era ela? Eu não me lembro. 
<p>- Bom... Estão fazendo um reconhecimento facial, mas pelas fotos... É Elena alguma coisa. A cidade é pequena e eu conheço todos esses rostos toda a minha vida. – Ele respirou fundo com um pouco de amargura.
<p>- Mas qual era a situação dela? Estava desaparecida ou...
<p>- Ela era uma moradora de rua. Se estava desaparecida, ninguém deu falta. 
<p>- O que acha que aconteceu?
<p>- Eu não sei, mas vamos investigar. Paul me disse que você é policial. Quem diria? – Barry parecia estar querendo mudar de assunto. 
<p>- É, você sempre foi o meu herói de infância. – Joseph começou a rir e Barry entrou na onda. – Quero fazer parte da investigação.
<p>Os dois voltaram a ficar sérios.
<p>- O quê?
<p>- Gostaria de te ajudar.
<p>- Acho que está um pouco longe da sua jurisdição, Agente. – Barry falou como se Joseph fosse um estranho que poderia atrapalhar o seu trabalho a qualquer momento. 
<p>- A sua equipe é boa, mas eu posso deixar melhor. 
<p>- Dez anos depois e o mesmo egocentrismo. Não, já temos gente demais aqui. 
<p>- Sério? Porque quatro pessoas estavam na viatura e quando eu entrei na delegacia, não tinha mais ninguém. 
<p>- Nem todo policial passa a noite aqui. Principalmente depois do que aconteceu da última vez que passaram. Chegam mais tarde. E eu não te devo explicações. 
<p>- Barry.
<p>- Por que você está aqui, afinal? Na cidade?
<p>- Por causa da festa dos meus pais no final de semana. 
<p>- Ah, o segundo casamento. Eles estão bem animados.
<p>- Estão sim. 
<p>- Então por que se importa com essa mulher morta? Vai embora daqui a alguns dias. 
<p>- Podemos resolver antes.
<p>- Vai para casa, Joe. Aproveita a companhia dos seus pais. – Barry tentou falar do jeito mais casual possível.
<p>- Me diz então que não está pensando nisso.
<p>- Nisso, o quê?
<p>- Dump. Marcus Dump. – Aquele nome fez os pelos dos braços do xerife se arrepiarem. 
<p>- Sai da minha sala.
<p>- Sem mãos, sem pés. Um corte na nuca. Deixada para ser comida de peixe no lago. Qual é a diferença dessa mulher, Elena, para a Susan? Você lembra da Susan?
<p>- Sai da minha sala. – Barry repetiu.
<p>- Barry, qual é?
<p>- A diferença, Joe, é que agora a porra do Dump está morto. 
<p>- Será que está? – Joseph o desafiou.
<p>- O que você...
<p>- Eu fui embora, mas eu li as noticias e você estava aqui. Sabe mais delas do que eu. Encontraram um corpo cem por cento queimado em uma cela e o Dump era o único na cela. Não identificaram o corpo, só fizeram uma associação. – Joseph franziu a testa incrédulo. 
<p>- Qual é a sua explicação, então? Que ele conseguiu fugir antes do incêndio e ainda conseguiu colocar alguém que ninguém deu falta dentro da sua cela e simplesmente saiu andando depois? – Barry estava começando a ficar vermelhor de raiva. Joseph tinha esse poder sobre ele.
<p>- Você mesmo disse que ninguém sentiu falta dessa Elena. Tudo bem, talvez ele morreu mesmo, talvez estejam certos. Talvez seja uma cópia. Alguém que se inspirou nele. Não é a primeira vez que isso acontece em um caso de assassino em série. 
<p>- Deixa de falar besteira. Essa cidade tem andado na paz desde que o infeliz morreu. Elena foi um caso sem importância.
<p>- É assim que você trata as vítimas por aqui?
<p>- Ah, me poupe. Você também é policial, sabe como as coisas funcionam. Ou por acaso você vai para casa toda noite e chora pelos corpos que você encontrou pela cidade? Seu trabalho deve ser bem difícil então. 
<p>- O meu trabalho é analisar todas as hipóteses com muita importância. – Barry revirou os olhos. – E nesse caso aqui, nem precisamos analisar muito. Você viu as fotos, alguém fez isso com ela, alguém a matou. Você não está nem um pouco preocupado dessa pessoa fazer outra vítima?
<p>- Pode ter sido um suicídio.
<p>- Como, na sua cabeça, ela cortou a mão direita sem ter a esquerda ou vice-versa? Está ficando louco?
<p>- Você a encontrou. Quem me garante que você não encontrou um corpo afogado e resolveu fazer uma brincadeirinha de boas-vindas?
<p>- Sério? – Joseph não viu essa chegando, mas mesmo assim não ficou chocado. 
<p>- Sai da minha sala ou eu faço todo mundo aqui acreditar que o problema é você. O grande Joe que voltou depois de mil anos. 
<p>- Sabe, xerife. – Joseph se levantou da cadeira e olhou bem nos olhos de Barry. – Bom saber que a policia da cidade continua a mesma merda de sempre. 
<p>Joseph deu as costas para o xerife e saiu da sala. Como se não bastasse aquela conversa para atingi-lo, a última pessoa que ele queria ver naquele momento entrava na delegacia quando estava indo rumo à porta.
<p>- Joey. – Lori arregalou os olhos quando o viu.
<p>- Lori. – Por outro lado, ele abaixou a cabeça para evitar olhá-la e seguiu seu caminho.</p>
<center><h4>--*--</h4></center>
<p>Alexander acordou assustado. 
<p>Ele pegou seu celular, que estava em cima de seu criado mudo, e verificou a hora. Estava atrasado. Olhou para o outro lado e sorriu. A garota com quem ele havia ido dormir na noite passada ainda estava dormindo do seu lado, isso geralmente não acontecia.
<p>Alex levantou da cama com muito cuidado para não acordar a mulher, pegou suas roupas que estavam jogadas no chão e as vestiu. Ele saiu do quarto tentando fazer o mínimo de barulho e desceu as escadas. Escovou os dentes na pia da cozinha e começou a procurar alguma coisa para comer na geladeira quase vazia, havia esquecido de fazer compras. 
<p>Alguém bateu na porta dos fundos. Ele se assustou. Poucas pessoas faziam isso. Como sua casa ficava em cima de seu armazém, geralmente quem o visitava tocava a campainha no andar de baixo, não dava a volta pela casa, subia as escadas do lado de fora e batia na porta dos fundos. 
<p>- Joe? Nossa, tinha até me esquecido que você sempre fez isso. Oi. – Alexander cumprimentou o amigo e abriu espaço para ele entrar.
<p>- Seu pai odiava quando eu fazia isso, mas você sabe, odeio campainha. Não parece que tem alguém me escutando do outro lado. 
<p>- Você é doido. 
<p>- O que houve? Acabou de acordar? 
<p>- É, eu perdi a hora. – Alexander coçou os olhos enquanto caminhava até sua minúscula cozinha. 
<p>- Eu trouxe café. – Joseph entregou um dos copos para ele. 
<p>- Você acorda cedo agora? – Alex percebeu que o amigo estava bem desperto.
<p>- Policial não dorme, Lex. – Ele brincou.
<p>- É verdade. Havia esquecido da sua profissão chocante.
<p>- Otário. 
<p>Os dois pararam de falar quando ouviram o barulho de alguém descendo as escadas. 
<p>- Alex, você sabe onde está a minha... – A mulher parou de falar quando viu que Alexander não estava sozinho no andar debaixo como ela esperava.
<p>Joseph arregalou os olhos para o que viu. Uma mulher enrolada em uma toalha branca. Os cabelos amarelos e enrolados, que ele se lembrava muito bem, estavam amarrados uns nos outros formando um coque mal feito. Ela também parecia que tinha acabado de acordar e também arregalou os olhos quando viu quem estava com Alexander.
<p>- Joe! – Ela gritou.
<p>- Mackenna.
<p>Joseph sorriu enquanto, para sua surpresa, ela correu e pulou nos seus braços.
<p>- Cuidado, você está... de toalha. – Alexander disse todo preocupado.
<p>- Quando foi que você voltou? – Mackenna ainda gritava, mesmo depois do abraço.
<p>- Ontem à tarde. – Joseph respondeu, alegre, mas não tanto quanto ela. – Vocês dois estão...
<p>- Não. – Alex e Mackenna responderam ao mesmo tempo e exatamente com a mesma expressão, de constrangimento. 
<p>- Você voltou para ficar? – Mackenna ainda não estava acreditando no que estava vendo.
<p>- Não, eu só vou ficar até domingo.
<p>- Ah... – Sua animação diminuiu um pouco. – A gente devia sair então, todos nós como nos velhos tempos. Você viu a...
<p>- Eu vi a Lori. – Ele a completou.
<p>- Claro que viu. Ela atirou em você? Faz anos que ela sonha com isso.
<p>- Não. Ainda não. – Joseph sorriu para tentar disfarçar o incomodo. Mesmo com tudo o que aconteceu na madrugada, a conversa com Lori ainda não havia saído da sua cabeça.</p>
<center><h4>--*--</h4></center>
<p>- O que aconteceu?
<p>Lori esperou um pouco até tocar no assunto. Todos os dias, ela acordava, preparava o café e enchia uma grande garrafa térmica com ele. Ia até a padaria, comprava alguns pães e seguia para a delegacia tomar café da manhã com seu pai, na sala dele, que estava sempre trabalhando. Ela ficou surpresa quando chegou naquela manhã e deu de cara com o seu ex namorado, quem não via desde a noite passada. 
<p>- Como assim? – Barry perguntou de uma maneira inocente enquanto tomava seu copo grande de café.
<p>- O que o Joey estava fazendo aqui?
<p>- Sabia que ele estava na cidade?
<p>- Nos vimos ontem.
<p>- O que ele disse para você?
<p>- Será que... podemos voltar para a minha pergunta? – Lori não tinha nenhuma vontade de compartilhar com seu pai a conversa que teve com Joseph na noite passada.
<p>- Ele encontrou um corpo ontem à noite naquele lago.
<p>- Um corpo? – Lori ficou surpresa. Esperava tudo menos aquilo.
<p>- Tudo bem, filha. Tudo indica que ela se afogou no lago e como ninguém mais vai para lá...
<p>- Já falou com a família dela? Quem é? – Lori sempre se interessava por aqueles casos. 
<p>- Era uma moradora de rua, provavelmente sem família. Nem dada como desaparecida ela foi. 
<p>- Qual era o nome, pai?
<p>- Por que isso importa?
<p>- Porque ela não era um corpo nem uma moradora de rua, era uma pessoa e todo mundo tem um nome. 
<p>- Elena Rocklether. Eu não lembrava do sobrenome dela, ainda bem que estava gravado no nosso banco de dados.
<p>- Ela morreu afogada?
<p>- Ainda estão examinando o corpo, mas aparentemente sim. 
<p>- É uma pena. Aquele lago...
<p>- Vou acabar pedindo para cercarem ele. Agora podemos voltar ao seu caso?
<p>- Que caso? – Lori evitou olhar para os olhos do pai e focou sua atenção na escolha do pão que ela ia pegar para comer.
<p>- Como você está depois de ver o Joe depois de todos esses anos? Ele falou alguma coisa para você?
<p>- Eu estou bem, pai.
<p>- Preciso prendê-lo?
<p>- Pai, não somos mais crianças e ele... Já passou. 
<p>- E por que não se interessou mais por ninguém?
<p>- Ah, não vamos falar sobre isso. Lembra? Temos limites e a minha vida amorosa é um deles. Eu também não pergunto da sua. Esse é o combinado. – Lori riu. 
<p>- Tudo bem. Então me conta, o que vai fazer hoje?
<p>- Mackenna e eu vamos comprar umas coisas para ajudar na construção da feira de amanhã.
<p>- Nossa, a feira. Eu nem me lembrava que já era amanhã.
<p>- Normal, pai. Velhos têm memória fraca. – Ela brincou.
<p>- Cuidado.
<p>O relacionamento de Lori com seu pai sempre foi muito importante para ela. Depois que sua mãe morreu, quando ela tinha seis anos, os dois foram obrigados a ficarem mais próximos. Após Joseph ir embora, os dois ficaram mais próximos ainda. Eles aparentemente não haviam superado seus amores antigos, porque nenhum deles havia tido um relacionamento sério depois dos seus respectivos exs saírem de suas vidas.</p>
<center><h4>--*--</h4></center>
<p>Joseph e Alexander decidiriam largar as bicicletas quando perceberam que a floresta não era mais o melhor cenário para os dois se equilibrarem em cima daquele veículo de duas rodas. 
<p>- Você está mesmo enferrujado. – Alexander começou a rir quando viu o amigo com dificuldade em deixar sua bicicleta encostada em uma das árvores.
<p>- Não fui eu que quase cai ali quando passamos em cima de umas raízes. – Joseph retrucou.
<p>- Bom, eu também estou enferrujado. Minha companhia de bicicleta se mudou faz uns dez anos. 
<p>- Você podia chamar a Mackenna para ser a sua companhia de bicicleta também, já que...
<p>- Cala a boca.
<p>Os dois se sentaram no chão e de repente parecia que eram adolescentes de novo falando sobre as garotas que interessavam na escola. 
<p>- Como isso aconteceu? – Joseph quis perguntar aquilo desde que viu a garota de toalha na casa do amigo de manhã.
<p>- Ah, você conhece a Mack. 
<p>- Conheço. E se me lembro bem, metade da cidade conhece também. – Ele começou a rir. – Relaxa, eu estou brincando com você. 
<p>- Fazemos isso a um ano mais ou menos. 
<p>- Mais ou menos não, eu te conheço. Você sabe a data exata. – Quando eram jovens, Alexander sempre lembrava Joseph de datas importantes sobre tudo. 
<p>- Nove meses e contando. Melhorou?
<p>- O que “isso” quer dizer? Vocês deixaram claro que não são namorados.
<p>- Ah, a gente... a gente se diverte um com o outro. Você sabe, somos amigos há muito tempo. Um dia, a gente estava bêbado e acabou rolando e então...
<p>- Decidiram deixar rolar por mais tempo. É o que? Amizade colorida? Sexo sem compromisso? Não estão meio velhos para isso? Parece coisa de adolescente. 
<p>- Ah, não. Não queremos um relacionamento agora. Nenhum de nós. – Alexander estava começando a ficar nervoso com aquela conversa. 
<p>- Nenhum de vocês? Lex. – Joseph olhou para o amigo com aquela mesma expressão de anos atrás que fazia ele contar tudo o que estava acontecendo.
<p>- Mack não é de se apegar.
<p>- Mas você é. Você não é de sexo sem compromisso, você é uma mocinha. 
<p>- Cala a boca.
<p>- Por que não me contou? Todas as vezes que a gente conversou nesses anos, você nunca... 
<p>- Eu nunca te contei porque não significa nada. É simplesmente... carnal. – Joseph voltou a rir depois de ouvir aquela palavra. – O quê? Nem todo mundo quer ter uma família como você.
<p>- Me desculpa. Então não está apaixonado por ela?
<p>- Não. 
<p>- Você ainda mente muito mal. Não estamos trocando mensagens, Lex. Eu consigo ver seu rosto agora enquanto mente. 
<p>- Tá, tudo bem. – Alex respirou fundo para poder ter coragem de dizer o que ele nunca disse para ninguém em voz alta. – Eu estou apaixonado por ela. 
<p>- Bom.
<p>- Não é bom. Se eu disser isso a ela, ela vai embora. Nós dois sabemos disso. Ela nunca se prendeu a ninguém, nunca se apaixonou de verdade e sempre fugiu de relacionamentos. Eu prefiro continuar assim e pelo menos ter uma parte dela. 
<p>Joseph ficou em silêncio. Não podia dizer que o amigo estava errado.
<p>- E quanto a você? O que sentiu quando viu a Lori ontem?
<p>- Eu... – Joseph hesitou. – Senti várias coisas. Teve uma hora que eu tive que me segurar bem forte para não a abraçar e...
<p>- Você havia me dito que tinha superado ela.
<p>- Eu achei que sim. Até porque eu segui com a minha vida e eu amo a Vicky, mas... quando eu a vi foi como se eu tivesse dezoito de novo e todas aquelas coisas que eu sentia, eu comecei a...
<p>- Sentir de novo. 
<p>- Exato. 
<p>- É o cabelo, não é?
<p>- Eu não me lembrava que ela era tão ruiva assim. – Os dois riram. – Por isso não consegui dormir, por isso fui até o lago. 
<p>- Essa mulher, Elena, esse nome não me é estranho, mas... não consigo me lembrar. Disse que ela morreu a dois dias, certo?
<p>- Mais ou menos. 
<p>- Ninguém reparou que ela sumiu. E se você não tivesse ido ao lago... ninguém mais vai lá depois da...
<p>- Já vi vários casos assim. Pessoas mortas que ninguém sente falta. Eu não sei o que é pior, avisar a família ou não ter uma família para avisar. 
<p>- Joe, eu quero que as pessoas notem se eu sumir. 
<p>Joseph não disse nada para completar. Ele sabia o que o amigo estava pensando. Ele não tinha mais pais e nem tinha irmãos, logo ele era o único da família, mesmo tendo muitos amigos e conhecidos, ele tinha medo de simplesmente sumir. O próprio Joseph sentiu isso nos primeiros anos na cidade grande. Estava sozinho lá e se sumisse, provavelmente só notariam se ele não mandasse um cartão de Natal para os pais, mas e se ele morresse em janeiro? Demoraria onze meses para sentirem a falta dele? Ele já estaria se decompondo até lá.</p>
</body></html>";
            }

            if (numero == 3)
            {
                lblTitulo.Text = "Capítulo 3 - Máscaras";
                htmlPage.Html = @"<html><body>
<p>Joseph agradeceu aos céus por não ter ninguém no hall de entrada da casa dos seus pais quando chegou, assim ele conseguiu subir as escadas e ir até o seu quarto sem ninguém notar. Exceto que...
<p>- Onde você estava?
<p>Victoria estava parada em frente a cama, suas mãos na cintura, um dos seus pés batendo firme no chão, uma veia quase pulando do lado da testa. Se ela estivesse com a boca aberta, Joseph podia jurar que seus dentes estariam cerrados. Aquela era a linguagem corporal que indicava que seu marido estava em apuros. Ela, com certeza, havia visto ele chegando pela janela e já se colocou em posição de guerra.
<p>- Eu... Me desculpa. – Joseph sempre preferia começar a conversa assim, principalmente com a esposa naquele estado.
<p>- “Me desculpa”? Você sumiu desde ontem quando chegamos e o máximo que você tem a dizer é isso? – Victoria só não gritou porque estava na casa de outra pessoa e ela odiava casais que lavavam roupa suja na casa que são hóspedes, não era educado. 
<p>- Eu me esqueci. Eu devia ter ligado.
<p>- Vir para casa também era uma opção. A primeira opção, na verdade. Aonde você dormiu?
<p>- Eu voltei à noite, você já estava dormindo e eu não quis te acordar. – Mentira. O que ele não queria era conversar naquela hora.
<p>- E saiu bem cedo? Porque eu acordei na madrugada e você não estava aqui. 
<p>- Vicky...
<p>- Quer parar de enrolar? O que aconteceu? Seu filho está o dia todo perguntando por você e querendo ir nos lugares que você disse que levaria ele, me deixou completamente louca. 
<p>- Me desculpa.
<p>- Você sabe que eu odeio ficar com os seus pais sem você. Eles me enchem de perguntas sobre você ser policial, sua mãe me repreende dizendo para eu te pedir para desistir disso e ter uma profissão mais segura como se eu fosse...
<p>- Vicky, me...
<p>- Se se desculpar mais uma vez, eu esqueço que não estamos em casa e te dou um tapa. 
<p>Joseph respirou fundo, passou pela esposa e se sentou na ponta da cama. Victoria se virou para olha-lo se explicar. 
<p>- Eu não consegui dormir. Se fiquei uma hora deitado nessa cama, foi muito. Então eu me levantei e...
<p>- E o quê?
<p>- Eu não venho aqui faz muito tempo, um dos motivos é porque me traz lembranças ruins e...
<p>- Lembranças que você nunca me contou. 
<p>- Querida, você precisa entender...
<p>- Como quer que eu te entenda se nem sei do que você está falando? Fica difícil assim. 
<p>- Eu andei pela cidade... – Joseph ignorou o comentário da esposa. Não iria falar sobre o passado. Não interessava para eles. – Tem um lago aqui perto, eu fui até lá e... Eu encontrei um corpo boiando.
<p>- O quê? – Aquelas palavras fizeram Victoria amolecer. Ela sempre odiava aquele tipo de notícia e odiava ter que receber elas sempre pelo marido ou por alguém procurando por ele. Arrepiava sua espinha. 
<p>- Eu achei que ela estava se afogando, então eu fui até lá e...
<p>- Por isso que você está levemente cheirando a peixe?
<p>- Eu tentei salvá-la e demorou um pouco para eu perceber que ela já estava morta há muito tempo. Eu tive que ligar para polícia, depois responder umas perguntas... Fui até a delegacia falar com o xerife. Depois eu... eu havia combinado uma coisa com o Alexander, lembra dele? E eu acabei perdendo a noção do tempo.
<p>- Ela morreu afogada? 
<p>- Eu não sei. – Mas ele sabia, só não queria preocupar a esposa e gerar perguntas que ele não queria responder.
<p>- Amor, eu sinto muito. – Ela se sentou ao lado dele e colocou a mão em seu ombro. Victoria sabia o quão era ruim para Joseph quando ele não conseguia salvar alguém que achava que tinha chance.
<p>- Tudo bem. Ossos do oficio. – Ele se levantou. Sentiu que se continuasse sentado com sua esposa ao seu lado tentando confortá-lo, iria chorar. – Eu vou tomar um banho, aí levo o Carl até o parquinho.
<p>- Seus pais já o levaram. Está lá brincando até agora. – Ela sorriu para tentar animá-lo.
<p>- E o Michael?
<p>- Disse que ia dar uma volta para conhecer mais o vilarejo. 
<p>- Devia ter ido com ele.
<p>- Como queria que eu saísse com você desaparecido?
<p>- Eu não estava desaparecido. – Joseph riu. 
<p>- Se eu te mando mensagem e você não responde, eu te considero desaparecido ou caído na rua com uma bala no peito. 
<p>- Eu estou de folga.
<p>- Mas eu não. Qual foi sempre o nosso combinado?
<p>- “Nunca deixe de dar notícias.”. Eu sei. Sinto muito. 
<p>- Está perdoado. – Ela se levantou e foi até o marido. – Mas só dessa vez. 
<p>Ela lhe deu um beijo habitual e saiu do quarto. 
<p>Joseph estava tão cansado que mal conseguiu ter forças para tirar a roupa suja e ir tomar um banho. Enquanto a água caía no seu corpo, ele chegou a cochilar por alguns minutos embaixo do chuveiro. Ainda com a toalha enrolada em sua cintura, ele se deitou na cama e pegou no sono até ser acordado duas horas depois com a imagem de Elena assassinada na sua cabeça.</p>
<center><h4>--*--</h4></center>
<p>- Por que não me contou ontem que o Joe voltou?
<p>Lori e Mackenna estavam na Rua Sete colocando toalha de mesa em uma barraca de madeira. Outros moradores de Darkey estavam lá também. Muitos homens construíam barracas de vendas enquanto as mulheres tentavam enfeitá-las o máximo possível com papéis decorativos e flores para a Feira Anual que aconteceria na noite do dia seguinte.
<p>A Feira Anual era um evento que tinha o objetivo de unir mais os habitantes da cidade. Foi criada quase junto com a cidade e nunca, por motivo nenhum, foi impedida de se realizar, mesmo nos anos obscuros e muitos tinham orgulho disso.
<p>Para as duas garotas, aquela feira era mais uma desculpa para todo mundo encher a cara e fofocar mais ainda uns dos outros.
<p>- Eu descobri ontem à noite. Ele apareceu no meu bar. – Lori falou um pouco irritada. 
<p>- Devia ter me mandado uma mensagem.
<p>- Você não ia ver mesmo. Estava ocupada demais em cima do Alex para pegar o celular. – Lori nunca gostou daquele relacionamento estranho que a amiga tinha com Alexander e não perdia uma chance de fazer um comentário sobre isso que mais parecia um julgamento só com a sua expressão no rosto.
<p>- Na verdade, essa noite ele que ficou por cima. – Mackenna sorriu para irritar mais ainda a amiga. – Mas me diz como foi, o que vocês falaram. Joe não me disse nada. 
<p>- Não aconteceu nada demais. Ele falou as besteiras dele e foi embora. 
<p>- Se desculpou?
<p>- Não prestei atenção. – Lori fez pouco caso.
<p>- Lori!
<p>- O que quer que eu diga?
<p>- Eu sei lá. Ele está aqui. 
<p>- Isso não quer dizer nada para mim. Eu não sou mais aquela garota boba que chorava por ele todos os dias. 
<p>- Não, agora só é uma mulher amargurada e alcoólatra.
<p>- Eu não sou alcoólatra. – Lori fez bico. E era verdade. Ela mal bebia, preferia servir bêbados do que ser uma, a noite passada tinha sido uma exceção. – Muito menos amargurada.
<p>- Ah é? Quanto tempo faz que você não dorme com alguém? 
<p>- Não te interessa. Além do mais, com quem você quer que eu durma? Todos os caras daqui são nojentos. 
<p>- Eu posso emprestar o Alex para você se quiser um dia desses. Ele não ia fazer objeção. – Mackenna voltou a sorrir para irritá-la. 
<p>- Eu estou bem. 
<p>- Então não sentiu nada em vê-lo? Ele... está bem maior agora e não só de altura e... aquela barba relaxada. Eu estava de toalha quando o vi, só não joguei ela no chão e pulei em cima dele por respeito a você. 
<p>- E porque está apaixonada pelo Alexander.
<p>- Eu não estou nada.
<p>- Quem está mentindo agora?
<p>- Quer dizer que você está mentindo? Você sentiu sim alguma coisa. – Mackenna apontou o dedo para a amiga toda animada. 
<p>- É claro que eu senti. Eu menti, eu ainda sou aquela garota boba que chora por ele todo dia. Todo dia não, talvez um dia por semana. 
<p>- O que vai fazer a respeito?
<p>- Ele está casado, Mack. E vai ficar aqui só por uns dias. 
<p>- Ah, mas seria tão bom vocês dois juntos de novo. Ele era o único cara que não tinha medo de ficar com você por seu pai ser da polícia. Era até sexy quando ele batia de frente com o Barry. – Mackenna mordeu os lábios.
<p>- Ei, abaixa o fogo, o namorado era meu. 
<p>- E daí? – A amiga piscou. – Quer dizer que não viu mais ele desde ontem?
<p>- Na verdade, eu o vi hoje de manhã na delegacia quando eu estava indo levar o café da manhã para o meu pai.
<p>- Nossa, o xerife foi rápido dessa vez. Já enquadrou o coitado?
<p>- Não, é que... você sabia que uma mulher morreu?
<p>- Acho que o Joe comentou isso na casa do Alex de manhã, mas eu não prestei muita atenção. 
<p>- Ela foi encontrada no lago. O nome dela era Elena. Meu pai disse que ela era uma moradora de rua, mas acho que conheço esse nome de outro lugar, mas não tenho certeza de onde. 
<p>- Tinha uma Elena naquele sacolão do lado da igreja, não tinha? Aquele que fechou há umas semanas. 
<p>- Claro e depois que o sacolão fechou, nunca mais vimos ela.
<p>- Bom, seu pai deve ter se confundido então. Acontece.
<p>- É, pode ser. 
<p>- Lori. – Mackenna percebeu que a amiga ficou um pouco pensativa. – Você não está achando que a morte dela tem algo a ver com... Pessoas morrem. Semana passada fez um calor danado, talvez ela foi lá no lago se refrescar e morreu. 
<p>- Ninguém mais vai naquele lago mesmo com uma temperatura de quarenta graus. 
<p>- Ai, vamos voltar a falar de homens? Acho que é mais interessante do que falar de mortos. 
<p>- Ou podemos não falar sobre nada. 
<p>- Vou ver o Alex hoje de novo. 
<p>- Dois dias seguidos? Está virando dependente. Ah é, não é novo, já estão quase fazendo aniversário.
<p>- Cala a boca. Pelo menos, eu tenho alguém para passar a noite. E você que fica naquele bar imundo? 
<p>- Você tem sorte de estarmos em uma cidade pequena e você ser a única suportável daqui. 
<p>- Também te amo, amiga.</p>
<center><h4>--*--</h4></center>
<p>Isabel não tinha um jantar com toda a família reunida já fazia muito tempo. 
<p>Ela estava com um sorriso de orelha a orelha e muito contagiante. Seu maior desejo estava acontecendo. Da ponta da mesa, olhava com muito amor para cada um dos seus três filhos. 
<p>Francine, sua filha mais velha, nunca quis ter filhos e muito menos se casar, achava todos os homens da cidade uns perdedores por não terem ambições, porém ela também não tinha, não trabalhava e com quase quarenta ainda dormia em um dos quartos da casa dos pais e nem pensava em trabalhar tão cedo.
<p>Arthur, seu filho do meio, dizia que queria ser um jogador de futebol americano toda vez que ele e seu pai assistiam os campeonatos pela televisão, mas nunca teve coragem de sair da cidade para tentar realizar o sonho. Na verdade, a falta de coragem não foi seu único empecilho. Aos dezesseis anos, ele engravidou sua namorada. Não se casaram, porém ele precisou começar a trabalhar cedo para pagar a pensão do seu filho que nunca deixaram ele ver crescer. A criança que agora já era um adolescente de quinze anos chamava outro de pai e mal olhava para a cara de Arthur quando se cruzavam pelas ruas de Darkey, mesmo assim preferia continuar vivendo na cidade onde estava o filho. Ele também morava na casa de seus pais e não tinha intenção de sair. Não acreditava mais no amor e vivia uma vida amargurada por um erro do passado.
<p>Joseph, seu caçula, foi o único que deu certo de acordo com o seu marido, Jacob. Desde criança, já dizia que queria ver o mundo além de Darkey. Ele repudiava as atitudes da irmã “acomodada” e mesmo quando começou a namorar com aquela garota, ele tinha consciência dos seus atos, e mesmo com todos aqueles defeitos, ela também tinha. Doeu muito ver seu filho sair debaixo das suas asas e ir embora da cidade. Ele nunca tinha sido aquele filho que mandava mensagens o tempo todo, logo ela ficou muito tempo sem noticias dele. Mas ele conseguiu. Agora tinha uma linda esposa e um lindo filho, e embora aquele emprego de policial tirava seu sono em algumas noites, ele havia tido sucesso em tudo o que queria. 
<p>Seus filhos não eram unidos e às vezes ela duvidava até se eram amigos, mas naquela noite todos estavam fazendo o maior esforço para demonstrarem ser uma família feliz e isso era tudo o que ela podia pedir.</p>
<center><h4>--*--</h4></center>
<p>- Esse bar não é muito cheio, é?
<p>Michael se encostou no balcão e chamou a atenção de Lori com aquele comentário. Aquela não era mesmo uma das melhores noites daquele bar, mas que noite era? 
<p>- Muitas pessoas preferem assim. – Ela respondeu um pouco envergonhada.
<p>- Tem razão. Até porque eu prefiro também. É melhor para conversar. – Ele sorriu. Aquele sorriso que fazia com que ele conseguisse tudo o que queria. 
<p>- Você não é daqui, não é?
<p>- Por quê? Teria me notado se eu fosse?
<p>- A cidade é pequena, se você fosse daqui, provavelmente teríamos estudado juntos e saberíamos os nomes um do outro.
<p>- Seu nome é Lori. – Ela mexeu a sobrancelha surpresa. – Ouvi um dos caras na mesa te chamando. 
<p>- E como te chamam?
<p>- Michael. Para você, Mike. 
<p>- A gente nem se conhece e eu já ganho privilégios? 
<p>- Amanhã de manhã, essa história pode mudar.
<p>- Vai querer beber alguma coisa? – Lori deixou de ser amigável instantaneamente e fechou a cara.
<p>- O que você me recomenda? – Mas o sorriso dele ainda estava lá.
<p>- A porta. 
<p>- Deve ser por isso que você não tem muitos clientes.
<p>- Olha, eu sou a dona e já recebi várias cantadas de bêbados. Só porque você é loirinho de olhos azuis, não quer dizer que não seja igual a eles.
<p>- Eu não estou bêbado. 
<p>- Então é pior do que eles. 
<p>- Tem alguém te esperando em casa? Eu posso entender isso e também não me importaria. 
<p>- Vai querer beber alguma coisa? – Lori repetiu com menos paciência do que estava dez minutos atrás. 
<p>- Eu preciso senão não vou ter uma desculpa para ficar te vendo a noite toda. 
<p>- Olha, aparentemente, você veio de muito longe. Se não quer ficar com um olho roxo, eu sugiro que não force a barra. 
<p>- Tem seguranças aqui? – O sorriso conquistador virou um sorriso pretencioso. 
<p>- Não. Mas acontece que eu sou filha do xerife da cidade, você sabe o que é xerife, não sabe?
<p>- Eu não fiz nada. Calma. – O sorriso sumiu.
<p>- Eu estou bem calma por isso vou te dar duas opções. Uma, eu chamo o meu pai, ele aparece em dez minutos e te arranca daqui em menos. Duas, eu mesma te tiro daqui. Porque como filha de xerife, eu meio que fui obrigada a fazer algumas aulas de defesa pessoal, e quando digo “algumas”, quero dizer, por anos. 
<p>- Eu tenho uma terceira opção?
<p>- Sai daqui enquanto eu escolho entre as duas. Sou bem indecisa, então você tem tempo. 
<p>Michael se levantou do banquinho do lado do balcão e se preparou para ir embora.
<p>- Não quer me dar o seu telefone? Posso te fazer mudar de ideia.
<p>- Você por acaso é retardado? – Lori colocou as mãos na cintura como uma posição de super-heroína. 
<p>- Difícil você, hein. – Ele voltou a sorrir. – Acho que virou um desafio e eu adoro desafios. 
<p>- Não precisa responder, eu já tenho a resposta. 
<p>Lori apontou para a porta impaciente. Ele piscou para ela e então foi embora.</p>
<center><h4>--*--</h4></center>
<p>Os olhos de Barry estavam quase se fechando quando terminou de assinar o último documento para liberar o corpo de Elena para a funerária. Eram quase onze da noite. Para quem havia passado a noite toda em claro, onze horas era muito tarde.
<p>- Xerife? – Paul empurrou a porta que estava encostada. – Eu terminei o meu turno. Precisa de mais alguma coisa?
<p>- Hã... Sim. – Barry se despertou. – Paul, eu preciso que, a partir de amanhã, você e um grupo de quatro ou cinco cadetes façam uma varredura pelas florestas e que me façam relatórios periódicos sobre o que vocês acharem. 
<p>- O que temos que procurar?
<p>- Qualquer coisa que não deva estar lá.
<p>- Acha que vai haver mais corpos?
<p>- Não. Pessoas não se matam o tempo todo.
<p>- Mas senhor... – Paul não entendeu aquele comentário.
<p>- Suicídio. Se alguém perguntar, foi suicídio. Não me interessa o que o Joe diga.
<p>- Mas ele está certo.
<p>- Ele é o seu chefe ou eu sou? – Barry se levantou da cadeira e deu um leve soco na mesa. Estava cansado demais para lidar com suas emoções. 
<p>- Desculpa, Xerife. 
<p>- Está dispensado, policial. 
<p>- Sim, senhor.
<p>Paul saiu rapidamente da sala com a cabeça baixa.</p>
<center><h4>--*--</h4></center>
<p>Já era quase de madrugada quando Michael voltou para casa. 
<p>Ele deu a volta no jardim para chegar na porta da cozinha, que ele descobriu de manhã ser o melhor jeito de entrar na casa sem ser notado. Joseph estava sentado na cadeira de balanço ao lado da porta olhando tão fixamente para o chafariz na sua frente que Michael podia passar por ele sem fazer barulho que nem perceberia.
<p>- Ei, cara, tudo bem? – Michael tocou no ombro do amigo e o fez despertar do transe.
<p>- Oi. Está tarde, achei que já tinha chegado. 
<p>- Bom, eu cheguei. 
<p>- O que faz na rua tão tarde? Aqui não tem muita coisa para se fazer. 
<p>- Ah, estava conhecendo melhor o lugar. – Ele se sentou no degrau de madeira que dividia o jardim da casa.
<p>- Se interessou por alguma coisa? – Joseph ainda não parecia estar naquela conversa cem por cento.
<p>- Por enquanto não, mas até domingo... – Ele sorriu. – O que você faz aqui? O chafariz é interessante à noite?
<p>- Eu estava lembrando de uma vez que eu cheguei em casa bêbado e cai no chafariz. Eu acabei dormindo ali dentro e só acordei no outro dia com a minha mãe me puxando. 
<p>- Bons tempos. Mas não é por isso que está aqui. O jantar foi tão ruim assim?
<p>- Não, na verdade, foi até bom. Ninguém fez comentários desnecessários ou trocou farpas. Todo mundo foi bem-educado.
<p>- Então eu não perdi nada mesmo.
<p>- É, pode-se dizer que não. 
<p>- Sabe, eu sempre te disse que achava você um cara foda do caralho, mas agora eu tenho certeza. 
<p>- Como assim? – Joseph riu daquele comentário. Era verdade, Michael já devia ter falado aquilo para ele umas dez vezes só naquele mês.
<p>- Você deixou tudo isso. Essa casa enorme, todo esse conforto, seus pais... para ir para outro lugar bem longe e desconhecido para morar em uma caixa de sapatos e ainda dividir ela comigo. Seus dois irmãos moram aqui, tenho toda certeza que seus pais não ligariam de você morar também. Essa casa é quase uma fortaleza. Você foi muito corajoso. 
<p>- Engraçado você dizer isso. “Você foi corajoso”. Já perdi as contas de quantas pessoas me disseram isso e por um tempo eu acreditei, mas estando aqui agora... Acho que na verdade, eu fui um medroso que fugiu de tudo. 
<p>- Por que diz isso?
<p>- Eu deixei tudo para trás. Eu deixei minha família, meus amigos...
<p>- A namorada que eu só sei o nome porque te embebedei em um dia que você estava na fossa. Viu ela?
<p>- Vi. 
<p>- Transou com ela?
<p>- Mike, eu sou casado. 
<p>- Eu não conto se você não contar.
<p>- Cala a boca. – Joseph riu. – Além do mais, não é só sobre ela. Eu simplesmente deletei essa parte da minha vida e continuei. Depois voltei como se nada tivesse acontecido.
<p>- Ah, não é verdade. Você ainda tem contato com o... como é mesmo o nome dele? Vilão do Superman?
<p>- O pai do Lex morreu. Eu sou melhor amigo dele e nem estava aqui para ajuda-lo a passar por isso. 
<p>- Olha, isso é ruim e triste, mas por que ao invés de se lamentar, você não simplesmente muda? Esses anos, você não pode voltar, mas pode fazer algo agora. Você está aqui e não é tarde demais. 
<p>- É, isso é verdade. Parece que você não é um atleta cabeça oca, afinal. 
<p>- Eu já te disse isso. – Os dois começaram a rir.</p>
</body></html>";
            }

            if (numero == 4)
            {
                lblTitulo.Text = "Capítulo 4 - A Feira";
                htmlPage.Html = @"<html><body>
<p><i>A noite estava mais quente do que normalmente estaria naquela época do ano e isso era tudo o que os habitantes de Darkey poderiam pedir. Após uma chuva rápida no fim da tarde, o céu se encheu de estrelas e permitiu que todo mundo pudesse sair de casa de novo e curtir a famosa Feira Anual de São Cristóvão. 
<p>Essa feira era uma tradição no povoado, mas quase ninguém sabia de onde aquela tradição tinha vindo ou porque tinha o nome de um santo, mas isso não importava para ninguém. 
<p>- Você fica muito sexy de boné e avental, sabia? – Lori ria enquanto via seu namorado fritando pastéis em uma das barracas mais cheias de clientes. 
<p>- Minha mãe me obrigou a me voluntariar na igreja. Eu frito pastel ou fico na barraca de bordado. – Joseph fez uma careta. Estava um pouco irritado. 
<p>- Ah, eu ia adorar te ver bordando um pano de prato. – Ela continuou com as piadas.
<p>- Ah, cala essa boca.
<p>- Quando você vai terminar? Mack está reunindo todo mundo para ir ao parque. A banda de sempre. – Lori sabia que aquela banda era péssima. 
<p>- Vão cantar reggae de novo? Tenho certeza que daqui duas horas vão estar todos doidões. 
<p>- Ninguém liga muito para as regras hoje. Se bobear, até policiais vão estar lá no meio curtindo.
<p>- Eu só vou poder sair daqui quando acabar. Aparentemente todo mundo gosta de pastel. – Joseph riu enquanto colocava um pastel de frango para fritar no enorme forno cheio de óleo na sua frente após ouvir um grito de um outro cara que estava no caixa atendendo os clientes. 
<p>- Acho que a sua mãe armou isso calculadamente para gente não poder ficar junto hoje. 
<p>- É o tipo de coisa que ela faria.
<p>Lori concordou com a cabeça.
<p>- Sabe, eu tive uma ideia. Não vou poder ir ao parque, mas talvez a gente possa fazer outra coisa depois que tudo acabar.
<p>- O que tem em mente? – Lori sabia que seria algo que ela não toparia, pelo menos, não de cara.
<p>- Está calor. Podemos ir nadar no lago, só nós dois. E fazer outras coisas também. – Ele piscou para ela. 
<p>- Não. – Ela disse logo.
<p>- Por que não? Poderia ser meu presente de aniversário.
<p>- Seu aniversário é daqui quatro meses.
<p>- Presente adiantado. – Ele deu outra desculpa. – Ah, qual é? Você sabe que é minha fantasia fazer coisas naquele lago. 
<p>- Faz sozinho então. – Ela deu um sorriso provocante.
<p>- Não tem tanta graça. 
<p>- Você é ridículo. 
<p>- Vou ficar aqui por mais três horas. Você podia pensar no meu caso e com carinho. – Ele retribuiu o sorriso.
<p>- Eu vou ir lá ver a banda. 
<p>- Nadar pelados depois? – Ele insistiu.
<p>Lori fez que não com seu dedo e se afastou da barraca. Joseph a perdeu de vista enquanto ia para o parque e ele queimava um dos pastéis.</i></p>
<center><h4>--*--</h4></center>
<p>Joseph acordou seu filho bem cedo, e diferente do que imaginou, Carl abriu um grande sorriso quando viu seu pai em frente a sua cama. 
<p>- Para onde estamos indo?
<p>Carl saltitava pela rua segurando em uma das mãos de seu pai e com um pedaço de bolo na outra mão. 
<p>- Sabe, quando eu era pequeno, uma das coisas que eu mais gostava de fazer por aqui era participar de uma coisa que acontece todo ano.
<p>- O quê? – Ele arregalou os olhos. 
<p>- Vai ver quando chegarmos. 
<p>A rua principal de Darkey estava toda enfeitada e esperando pela festa. Havia barbantes com bandeiras coloridas amarrados de um poste de luz para o outro cruzando a rua. Vários caixotes estavam sendo despejados em cima das barracas já montadas. Todos que estavam lá pareciam ocupados com alguma coisa. 
<p>- O que está acontecendo, papai? – Carl olhava para todos os lados um pouco curioso. 
<p>- Estão se preparando para um evento. A Feira Anual de São Cristóvão. 
<p>- Quem é São Cristóvão? 
<p>- Eu não sou a melhor pessoa para te explicar isso. – Joseph franziu a testa. – Sua vó explica depois.
<p>- O que a gente faz aqui?
<p>- Ah... – Ele começou a olhar para todos os lados a procura de alguém conhecido até que... – Vamos ver se podemos ser uteis para alguém. Venha.
<p>Ele conduziu seu filho até uma das barracas que venderia um tipo variado de enfeites. 
<p>- Olha só, você ajudando na organização da feira. – Joseph se dirigiu a Lori que pendurava placas artesanais de madeira em uma grande grade de amostras. – Esses dez anos mudaram mesmo você. – Ele sorriu para ela.
<p>Lori o encarou por alguns segundos, depois virou a cara e foi embora da barraca. 
<p>- Você não esperava que seriam amiguinhos, esperava? – Mackenna estava do outro lado da barraca colocando miniestátuas no balcão de amostra.
<p>- Ah, eu meio que tinha esperanças. 
<p>- Então pode começar a se decepcionar. – Ela sorriu. – Quem é esse mini Joe? – E abriu um sorriso ainda maior.
<p>- Sou Carl. – Ele falou todo orgulhoso.
<p>- É, é claro que você é.
<p>- Ele é meu filho. – Joseph explicou.
<p>- Não precisei dessa informação para perceber isso. – Mackenna estava certa. Carl era a cópia exata do pai. Os mesmos cabelos castanhos e desarrumados, os olhos grandes, castanhos e expressivos e o lindo sorriso que futuramente conquistaria todo mundo. – O que fazem aqui tão cedo?
<p>- Queríamos ajudar na organização. Tem algo para gente fazer? – Joseph perguntou. 
<p>- Aqui eu acho que não, mas deve ter na igreja, devia ir para lá.
<p>- Ah, não, na igreja não. – Joseph teve um leve arrependimento de oferecer ajuda.
<p>- Claro, tem medo de queimar se entrar lá dentro, não é? – Mackenna brincou.
<p>- Queimar, por quê? – Carl arregalou os olhos.
<p>- Não é de verdade, é uma expressão. Ela está só brincando. – Joseph explicou logo. – Você viu o Lex? – Ele voltou a se dirigir a Mackenna.
<p>- Ah, ele está no parque ajudando com o palco. 
<p>- Que banda arrumaram dessa vez?
<p>- A de sempre, só que sem maconha. Barry é um saco. 
<p>- É, ele é mesmo. – Joseph nem riu. Barry era mesmo um saco. – Bom, vamos para lá então, filho.</p>
<center><h4>--*--</h4></center>
<p>O palco já estava todo construído. Naquele momento, os homens estavam subindo os instrumentos musicais e ligando os fios das caixas de som. O trabalho pesado já tinha acabado. 
<p>- Olha só se não é o melhor ser humano do mundo... – Alexander gritou de cima do palco assim que viu Joseph e seu filho entrando no parque. - ... e meu amigo Joseph.
<p>Ele desceu do palco e foi em direção ao amigo.
<p>- Tio Lex!
<p>- Oi, campeão!
<p>Carl pulou no colo de Alexander e o abraçou bem forte.
<p>- Ele estava com saudade de você. – Joseph falou. 
<p>- Nossa, como você cresceu. – Alexander colocou Carl no chão. – Daqui a pouco, não vou conseguir te pegar no colo.
<p>- Eu cresci dois centímetros nesse mês. – Carl falou como se aquilo tivesse sido sua maior vitória da vida, e talvez até aquele momento, fosse. 
<p>- Se puxar seu pai, vai ser mais um gigante da família. 
<p>- E vai dar tchau para o seu tio olhando para baixo, como eu faço. – Joseph riu.
<p>- Otário. – Alexander deu um soco no ombro do amigo. – O que faz aqui tão cedo?
<p>- Queremos ajudar a fazer a feira. – Carl respondeu primeiro. – Eu posso subir no palco para tocar bateria?
<p>- Claro, só não pode quebrar nada.
<p>- Legal! – Carl correu até a escada do lado do palco, subiu e foi em direção a bateria como se fosse o maior doce do mundo.
<p>- Percebeu que acabou de dizer para uma criança de cinco anos que ela não pode quebrar nada? – Joseph sabia, por experiência própria, que aquilo não ia acabar bem.
<p>- Percebi e já estou me arrependendo. 
<p>- Ainda tem algo que eu possa fazer aqui?
<p>- Eu estou indo para o porto buscar alguns caixotes de frutas, você pode ir lá buscar no meu lugar. – Alexander hesitou antes de terminar a fala. – Provavelmente, a Lori vai estar lá. Ela está ajudando a contar as encomendas. 
<p>- Eu a vi uns dez minutos atrás. Certeza que nem vai olhar na minha cara. 
<p>- Acho que é melhor do que levar um tapa. 
<p>- Está querendo dizer que eu estou no lucro?
<p>- Está, meu amigo, está sim.</p> 
<center><h4>--*--</h4></center>
<p><i>- Mackenna me avisou que você estava me esperando aqui. – Joseph segurava seu boné marrom na mão enquanto descia aquela escada toda torta feita de madeira que o levava até o cais. 
<p>Lori estava sentada no chão do outro lado da cerca de corda, com os pés na água. 
<p>- Eu sugeri o lago, mas se você prefere água salgada, eu também topo. – Ele se sentou ao lado dela e tirou a camiseta.
<p>- Cala a boca. Eu não te chamei aqui para isso. 
<p>- Quer dizer que eu tirei a camisa para nada? – Ele sorriu.
<p>- Exatamente.
<p>- Sabe, se eu ganhasse um real todas as vezes que você diz “não” para mim, eu estaria rico. – Ele colocou a camiseta de volta. 
<p>- Nossa, quanto drama. 
<p>- Mocinha, nós dois sabemos quem é o dramático da relação, você pode parar. – Ele apontou o dedo na cara dela enquanto ria. 
<p>- Se você apontar esse dedo de novo para mim, eu quebro. – Ela segurou o dedo dele bem forte e o abaixou. 
<p>- Olha só, está me ameaçando. Tinha que ser filha do seu pai. 
<p>- Ele não é tão ruim assim. – Ela começou a rir.
<p>- Ah, é sim. Eu estou te dizendo, se ele subir para uma posição importante naquela delegacia, eu vou virar um presidiário. E meu único crime foi ter te amado de verdade. – Lori fez uma careta. – É, eu sei. Percebi que foi ruim assim que eu terminei de falar. 
<p>Ela concordou com a cabeça. 
<p>- Ele passou umas cinco vezes hoje em frente a barraca de pastel. Acho que ele queria ver se eu não estava roubando. 
<p>- Eu sinto muito por ele pegar no seu pé. 
<p>- Ah, a culpa meio que é minha. Quem mandou eu me apaixonar pela filha do policial mais chato de Darkey?
<p>- Espero que tenha valido a pena. – Ela colocou a cabeça no ombro dele.
<p>- Ah, valeu sim. Além de ser a garota mais linda do planeta, desde criança eu sempre quis namorar uma ruiva. Vermelho me lembra Natal. 
<p>- Cala a boca, palhaço. – Ela voltou a rir. 
<p>- Depende, estou conseguindo te convencer a ir até o lago? 
<p>- Fala mais um pouco sobre eu ser a garota mais linda do planeta. Talvez no meio disso tudo, eu decida te dar uma chance. 
<p>- Uma chance é tudo o que eu preciso.</i></p>
<center><h4>--*--</h4></center>
<p>- Oi, eu posso pegar essas caixas?
<p>Joseph apontou para várias pilhas de caixotes fechados encostadas na cerca de corda. O barco que havia trazido as frutas já podia ser visto indo embora no horizonte quando ele desceu por aquela escada velha e torta de madeira que o levaria até o cais. 
<p>- O que está fazendo aqui? – Lori estava com uma caderneta na mão e com o seu cabelo preso em um coque mal feito com a ajuda de uma caneta de tampa vermelha, combinava com ela. – Está me perseguindo?
<p>- Não. – Joseph disse logo. – Eu só...
<p>- O quê? – Ela o encarou brava.
<p>- Eu só quero ser útil. 
<p>- Por que não vai ser útil lá na cidade grande, hein?
<p>- Ah, porque lá ninguém faz feira. – Ele sorriu, mas ela continuou séria. – Ah, qual é? Foi engraçado.
<p>- Hilário. 
<p>- Lori, olha, eu estou tentando, tá? Podia me ajudar. Eu não quero um clima estranho. 
<p>- Para ter um clima estranho, teria que ter clima. Nem isso tem. E por que se importa? Vai embora daqui alguns dias. 
<p>- Eu me importo porque talvez eu... eu queira voltar. – Joseph parou de falar assim que se escutou. Aquilo era tolice, uma ideia totalmente impossível. Depois de domingo, ele não pisaria mais os pés naquela cidade esquecida. 
<p>- Pega as caixas e some daqui. 
<p>- Você quer que eu me desculpe? Eu me desculpo. 
<p>- Eu não quero nada. Eu só não quero ter que falar com você, muito menos ver a sua cara. Por que você simplesmente não se tranca no quarto e espera os dias passarem? – Ela realmente estava muito brava. Sua mão estava tentando se fechar contra a caderneta. 
<p>- Eu precisava ir embora. 
<p>- Ótimo, você fez o que você precisava, o que você queria. Agora deixa eu fazer o que eu quero que é não te ver. Só que não está funcionando com você atrás de mim o tempo todo.
<p>- Eu não estou te perseguindo.
<p>- Não é o que parece! – Ela se exaltou. – O que foi fazer no meu bar?
<p>- Eu nem sabia que aquele bar era seu. Eu só... – Mas Joseph não sabia o que dizer. 
<p>Os dois ficaram em silêncio se observando e respirando pesado por alguns segundos até que um grito os fez despertar daquele momento.
<p>- Lori! – Mackenna desceu as escadas correndo, ela trazia um jornal na mão.  
<p>- O que foi? – Ela respondeu mais irritada do que esperava.
<p>- Você tinha razão. Sobre a moça que morreu. Saiu no jornal.
<p>- O quê? – Joseph franziu a testa. Não estava entendendo nada.
<p>- Ela não era moradora de rua. – Mackenna explicou enquanto entregava o jornal para Lori. – James identificou ela. É a do sacolão. Seu pai se enganou.
<p>- O quê? – Joseph repetiu.
<p>A manchete na primeira página do jornal local era bem chamativa. <b>MULHER COMETE SUICÍDIO SEM NENHUM MOTIVO APARENTE.</b> Havia uma foto 3X4 tirada de algum documento ampliada junto a matéria. 
<p>- “...Elena Rocklether, bem conhecida no bairro, teve uma morte trágica três dias atrás.”.  – Joseph começou a ler trechos da matéria por cima do ombro de Lori. – “... as autoridades informaram que o corpo dela foi encontrado boiando no Lago Comma na madrugada do dia 9...”
<p>- Diz aí que os exames toxicológicos indicam que ela estava muito dopada. – Mackenna estava com uma das mãos na boca e demonstrava um pequeno abalo após ler a matéria. 
<p>- Detectaram morfina... heroína... – Joseph começou a ler a lista de drogas. – Codeína... hidrocodona... Isso é impossível.
<p>- Parece que estavam em quantidades pequenas e...
<p>- Quantidades pequenas, o caralho.
<p>Joseph pegou o jornal da mão de Lori com tanto impacto que além de quase rasgar, assustou a garota completamente. 
<p>- Joey, o que foi? Para onde você vai?! – Lori gritava enquanto Joseph subia aquela escada na maior velocidade que ele conseguia.</p>
<center><h4>--*--</h4></center>
<p>Barry tirou a sua atenção da leitura de um relatório comum quando ouviu uma falação do lado de fora da sua sala mais alta que o normal. Ele tentou ver o que estava acontecendo pela janela, mas as persianas o bloqueavam de onde ele estava. Teria que se levantar da cadeira e ir até a janela ou até mesmo abrir a porta para ver sem problemas. 
<p>Antes que ele resolvesse fazer qualquer movimento, sua porta se escancarou e ele logo percebeu o motivo da gritaria. Joseph estava na sua frente, totalmente vermelho de raiva e suado. Dois cadetes estavam atrás dele, tentando impedi-lo que entrar na sala do xerife, mas havia sido inútil. 
<p>- SUICÍDIO?! VOCÊ DISSE AO JORNAL QUE ESSA MULHER SE MATOU?! – Joseph foi até a mesa de Barry e pressionou o jornal contra a madeira, furioso.
<p>- Xerife, tentamos... – Um dos cadetes falou um pouco ansioso. 
<p>- Tudo bem. – Barry falou ainda sentado e calmo. – Saem daqui e fechem a porta. 
<p>Os dois cadetes, ainda um pouco assustados e receosos, saíram da sala como o xerife pediu e fecharam a porta. 
<p>- BARRY! – Joseph chamou sua atenção.
<p>- Primeiro, se acalma, depois a gente conversa. – Barry continuou calmo.
<p>- EU NÃO VOU ME ACALMAR, COISA NENHUMA! QUAL É A SUA? O QUE VOCÊ ESTÁ PENSANDO? 
<p>- Para de gritar. – Barry quase cuspiu. – Somos dois adultos. Se sente, vamos conversar como dois adultos. 
<p>- Você e eu sabemos que não foi um suicídio. – Joseph não gritou, mas continuava vermelho. 
<p>- O que você queria que eu fizesse? Iam começar a fazer perguntas.
<p>- Então você mentiu para aquele repórter? – Ele estava incrédulo.
<p>- Joe, você precisa entender. Eu coloquei policiais pela cidade para investigar. – Barry começou a falar mais baixo que o normal. – Eu estou em alerta vinte e quatro horas por dia. Eu não estou fingindo que isso não aconteceu.
<p>- Mas está enganando as pessoas. 
<p>- Não, não estou.
<p>- Como não está? – Joseph voltou a levantar o tom de voz. – Você declarou um suicídio e ainda por overdose, porque ninguém normal aguenta ficar acordado mais de dois minutos com toda aquela droga no sangue. Está se aproveitando da ignorância das pessoas!
<p>- Quer que eu diga verdade? É isso que você quer? – Barry se levantou.
<p>- É exatamente isso que eu quero. 
<p>- Acontece, garoto... que você NÃO MANDA AQUI! – Barry bateu seus dois punhos na mesa derrubando uma caixa de clips e algumas canetas no chão. – Sabe o que vai acontecer se eu contar a verdade? O caos vai se instaurar nessa cidade. A única coisa que eu vou fazer vai ser assustar essas pessoas. É isso que você quer?
<p>- Eu quero a verdade. Todo mundo tem o direito de saber. 
<p>- Nem sabemos o que aconteceu. Vamos assustar as pessoas por nada?
<p>- Por nada? Uma mulher foi assassinada. Isso não é nada, está longe de ser nada. 
<p>- Marcus Dump está morto. – Barry afirmou. 
<p>- Não se trata dele. Não me interessa quem está morto ou quem está vivo, me interessa é que essa mulher foi morta e o assassino está por aí livre e talvez pronto para matar outro.
<p>- Eu já disse que estou cuidando disso.
<p>- Como? Acobertando tudo? Colocando tudo embaixo do tapete?
<p>- Garoto, você está bem longe de casa. QUEM VOCÊ PENSA QUE É PARA FALAR ASSIM COMIGO?! Essa cidade é minha e eu sei como cuidar dela. Isso não é da sua conta.
<p>- Você vai acabar matando todo mundo.
<p>- ISSO NÃO É DA SUA CONTA!
<p>No mesmo momento, a porta da sala se abriu. Lori estava parada com os olhos arregalados e um pouco assustada. Nunca tinha visto nenhum dos dois tão nervoso na vida. 
<p>- O que está acontecendo aqui? – Ela logo falou.
<p>- Não é nada. – Barry respirou fundo e voltou a se sentar ainda encarando Joseph. 
<p>Joseph ficou em silêncio encarando o xerife, seu coração a mil e seus punhos fechados. Não sabia o que poderia ter acontecido se Lori não tivesse aparecido naquele momento. Só sabia que agora não podia mais brigar, nem socar a cara de Barry como ele tanto desejava desde que entrou naquela sala. 
<p>Seu plano B, nem tanto satisfatório, foi soltar um “Você é um merda”, alto o suficiente para o xerife ouvir com todas as palavras, pegar o jornal da mesa, dar as costas e sair da sala, ainda bufando.</p>
<center><h4>--*--</h4></center>
<p>- Joey! Joey!
<p>Lori corria atrás de Joseph pela rua solitária. Todos estavam naquele momento na rua principal, na rua da Feira.
<p>- O que foi? – Ele se virou para ela, irritado.
<p>- O que está acontecendo?
<p>- Por que não pergunta para o seu querido pai?
<p>- Porque eu estou perguntando para você. – Ela quase o intimou. Joseph odiava quando ela fazia aquilo. – O que aconteceu? Por que você saiu correndo do cais? Por que você e meu pai estavam brigando? Por que você está uma fera?
<p>- Deixa para lá. – Joseph queria muito evitar mais um confronto.
<p>- Eu sei que foi você que encontrou a Elena no lago. Tem a ver com isso?
<p>- Não. – Ele mentiu.
<p>- Então por que saiu correndo depois que leu aquela matéria no jornal? – Lori não sairia de lá até descobrir a verdade. – Estava tudo... 
<p>- Quer saber mesmo o porquê? Porque seu pai é uma fraude. É isso que ele é. – Joseph não conseguiu se segurar e começou a falar e toda a sua fúria voltou. – Porque ele é um velho caduco assustado que não quer encarar a verdade. Porque não importa o que aconteça, ele sempre vai me ver como o seu namorado idiota que ele adorava intimidar. 
<p>- Joey...
<p>- Mas não me importa. Por que eu deveria me importar? Você tem razão, não é?
<p>- O quê? – Lori ficou perdida.
<p>- Eu vou embora daqui em alguns dias e não vou mais voltar. Nada disso me interessa. Se vocês não se importam, por que eu vou me importar?! – Ele começou a gritar no meio da rua. – Eu não sou daqui. Eu só estou te passagem. Quem vai ficar aqui com um assassino vai ser vocês. ENTÃO QUE SE DANE!
<p>- Jo... JOEY!
<p>Lori gritou enquanto via Joseph indo embora pela rua.</p>
<center><h4>--*--</h4></center>
<p>- O que está acontecendo aqui? – Lori entrou furiosa na sala de seu pai. Ele também não estava calmo. Estava de pé olhando para as árvores pela janela quando sua filha trancou a porta da sala e se dirigiu a ele.
<p>- Nada demais.
<p>- Vocês estavam aos berros, pai. Como assim, não foi nada demais?
<p>- Esse garoto gosta de se intrometer, só isso. – Barry não tirou sua atenção das árvores em nenhum momento. 
<p>- Olha para mim e diz isso na minha cara, porque eu te conheço e sei que...
<p>- O seu namorado, dez anos depois, ainda consegue me tirar do sério. – Ele finalmente olhou para a filha e estava vermelho de raiva.
<p>- Ele não é...
<p>- Só porque cresceu, acha que sabe de alguma coisa. Enche a boca para dizer que é um policial, um policial de merda só se for. 
<p>- Por que esse caso da moça do lago está mexendo tanto com vocês?
<p>- Ele é um perturbado, por causa disso. Vê coisas onde não tem.
<p>- Não acredito em você.
<p>- ENTÃO ACREDITA NAQUELE FILHO DE UMA...
<p>- Olha, abaixa o tom. Ninguém está gritando aqui. – Lori não se assustou. – Não tem nada a ver com o Joey. Tem a ver com você. Faz muito tempo que eu não te vejo desse jeito, só quero saber o que está acontecendo.
<p>- É uma investigação. Não posso compartilhar essas coisas com você. 
<p>- É sério que você vai usar essa desculpa? – Ela soltou uma gargalhada. – Você não vai querer que eu descubra isso sozinha.
<p>- Não tem nada para descobrir. Esse cara é um babaca que não aceita que pessoas cometem suicídio. Quer encontrar um assassinato onde não tem e ainda quer os créditos por algo que não fez. 
<p>- Você já lidou com babacas antes e nunca ficou afetado assim.
<p>- EU NÃO ESTOU AFE... Ele sempre me tirou do sério, por que agora seria diferente?
<p>- Porque agora vocês dois são adultos. Porque eu não estou no meio das brigas de vocês e porque você agora é xerife. Sua visão tem que ser diferente. E berrar aos quatro ventos para toda a delegacia ouvir não é uma visão muito boa. 
<p>- Me prometa uma coisa.
<p>- O quê?
<p>- Não importa o que ouvir, você vai acreditar na minha verdade.
<p>- Pai...
<p>- Prometa. 
<p>- Primeiro, eu só acredito na minha verdade, e segundo... Eu não vou participar dessa guerra civil de vocês dois. – Lori, cansada daquela palhaçada que parecia mais duas crianças de dez anos brigando, destrancou a porta e saiu da sala. – Time Lori!</p>
<center><h4>--*--</h4></center>
<p>Carl estava tão contente e animado brincando e conversando com as pessoas em cima do palco que Joseph não quis estragar a festa. Alexander percebeu como o amigo estava e se ofereceu para cuidar do garoto enquanto ele colocava a cabeça no lugar. 
<p>Joseph foi direto para a casa. 
<p>Sua mãe estava na sala, sentada no sofá, ao telefone. Ao que parecia, estava organizando os últimos preparativos para a festa de domingo. Ele conseguiu passar facilmente despercebido por ela e subiu as escadas para chegar até seu quarto. 
<p>Quando entrou no quarto, ele deu de cara com Victoria olhando para três vestidos que estavam colocados em cima da cama. 
<p>- Está escolhendo com qual vestido você vai na festa domingo? – Joseph tentou falar de um jeito bem comum para esconder sua irritação.
<p>- Não, é para hoje à noite. Qual você prefere? O azul ou o vermelho? O preto está fora de cogitação. – Ela falou bem rapidamente.
<p>- Vicky, é uma feira. Essa camiseta e esse shorts jeans que você está usando já está ótimo. – Ele se sentou na cama. 
<p>- Eu quero causar uma boa impressão. Vou conhecer seus antigos amigos e... 
<p>- Por isso mesmo. Eles não vão ligar para a sua roupa. – Ele mal olhou para ela.
<p>- O que você tem? – Ela então percebeu.
<p>- Nada. 
<p>- Mentira. Me conta logo. – Victoria foi até o marido e ficou na frente dele o encarando. 
<p>- Não é nada demais. 
<p>- Cadê o Carl?
<p>- Ficou na feira. Lex disse que vai cuidar dele por um tempo.
<p>- Mais uma prova de que você tem algo. Desde quando deixa seu filho com qualquer um?
<p>- Lex não é qualquer um.
<p>- Você entendeu. 
<p>- É só uma preocupação idiota com aquela mulher do lago. 
<p>- Ah, não. Esquece isso. – Victoria colocou a mão no rosto do marido. – Ela já está morta. Acabou. Não dá para ajudar todo mundo. 
<p>- É, eu sei. – Ele falou sem emoção.
<p>- Sabe, eu tive uma ideia para fazer você relaxar. – Ela mordeu o lábio.
<p>- Ah é?
<p>Victoria foi até a porta do quarto e a fechou. Depois tirou sua camiseta mostrando que não tinha mais nada por baixo. Se sentou no colo do marido e o beijou no pescoço.
<p>- Bom, tecnicamente... – Ele falou sorrindo. – Eu não relaxo com você fazendo isso. Eu fico é em alerta.
<p>- Eu adoro quando você fica em alerta. – Ela sussurrou em seu ouvido. – No que está pensando agora? 
<p>- Agora? Só estou pensando em tirar o seu short.
<p>- Então eu estou fazendo um bom trabalho.
<p>- Um ótimo trabalho. – Joseph suspirou.</p>
<center><h4>--*--</h4></center>
<p>O sol já estava se pondo quando as luzes das bandeiras se acenderam dando início a Feira de São Cristóvão. A música no parque estava alta o suficiente para todo o povoado ouvir independentemente de onde a pessoa estivesse.  
<p>Havia alguns policiais rondando em volta da feira, mas não estavam armados, só queriam garantir que nada saísse do controle. Barry andava pela rua sorridente acenando para as pessoas. Embora Isabel e Jacob Rose não fossem muito populares entre os vizinhos, os dois estavam bem comunicativos e alegres.
<p>- Eu não acredito que você passou dezoito anos da sua vida aqui. – Victoria olhava para todos os lados um pouco impressionada. – Você é tão caipira. 
<p>- E você nem me viu vendendo pastel. – Joseph apontou para a barraca. 
<p>Os dois caminhavam de mãos dadas analisando as barracas. Era engraçado como as barracas e até alguns vendedores ainda eram exatamente como Joseph se lembrava e junto delas, várias lembranças. A barraca dos artefatos e amuletos onde ele foi desafiado a roubar um cordão quando tinha dez anos; a de roupas onde ele acidentalmente derrubou suco de uva em várias camisetas aos oito anos; a barraca do beijo onde ele fez de tudo para ser o vendedor só para conseguir um beijo de Lori aos treze anos.
<p>Carl corria animado atrás de Alexander em todo lugar que ele ia. 
<p>- Eu quero vir para cá em todas as feiras.
<p>- Olha, pede muito para o seu pai, talvez ele te mande por correio para gente. – Alexander riu.
<p>- Tio, você vai nos visitar? Tem uma sorveteria bem grande perto de casa. Eu queria muito te levar lá. O chão é quadriculado.
<p>- Eu ainda não sei.
<p>- Você tem que ir. Seria tão legal você lá. – Carl arregalou os olhos. Ele já convenceu Alexander a lhe mandar um vídeo game por correio uma vez com aquele olhar. 
<p>- E quanto ao seu tio Mike? Certeza que quando está com ele, nem sente a minha falta. 
<p>- Ele é legal, mas não é você. 
<p>- Garoto, você disse as palavras certas. – Alexander levantou Carl e o colocou em seus ombros. – Vamos, vou te levar para conhecer a banda.
<p>- Legal!</p>
<center><h4>--*--</h4></center>
<p>- Ela é bonitinha. Aquele vestidinho até realça as poucas curvas que ela tem, mas aquele cabelo não é bem cuidado. O seu é melhor.
<p>- De quem você está falando?
<p>Mackenna e Lori estavam sentadas em banquinhos ao lado da barraca de bolos. Lori havia prometido que cuidaria daquele lugar até a vendedora oficial chegar, mas ela já estava desistindo de esperar.
<p>- A esposa do seu policial. – Mackenna apontou o dedo indicador para Joseph e Victoria que estavam do outro lado da rua olhando os mostruários da barraca de artesanatos.
<p>- Para de apontar. – Lori bateu na mão da amiga bem depressa.
<p>- O que foi? Devia ir falar com eles.
<p>- Por quê?
<p>- Para ser legal, uma boa anfitriã e... para marcar território. – Ela finalizou com um sorriso maldoso.
<p>- Por que eu iria querer marcar território? Eles são casados. O território é todo dela. – Lori cruzou os braços.
<p>- Mas você precisa dizer que foi a primeira e inesquecível. Melhora a postura, vai mostrar mais seus peitos. Ela mal tem, vai ficar intimidada.
<p>- Cala essa boca. Eu não vou me levantar só para...
<p>- Ah, não precisa se levantar não. Eles estão vindo para cá, disfarça.
<p>- O quê?
<p>Lori não era boa em disfarçar as coisas. No minuto que Mackenna virou o rosto e olhou para a amiga tentando mostrar que não estava prestando atenção no casal que se aproximava, ela fez o oposto. Encarou Joseph e Victoria até eles chegarem na sua frente e cumprimentá-las.
<p>- Olá. – Joseph também estava sem jeito. Com certeza, a ideia de ir até aquela barraca não tinha sido dele. 
<p>- Ai, eu amo bolo. – Victoria estava tão interessada nos bolos em cima da mesa que nem percebeu o clima estranho. – Qual vocês me recomendam?
<p>- Ah, na verdade, não estão a venda. – Lori falou logo. – Quer dizer, estão a venda, mas não somos nós que estamos vendendo.
<p>- Só estamos cuidando até a vendedora chegar. – Mackenna explicou melhor quando viu que sua amiga estava quase tendo um treco. – Nem sabemos os preços.
<p>- Ah, que pena...
<p>- Garotas... – Joseph respirou fundo e finalmente disse. – Essa é a minha esposa, Victoria. Vicky, essa é a minha velha amiga...
<p>- Mackenna. – Ela logo se apresentou. – Estudamos juntos. Eu o ensinei a beijar, então... de nada. 
<p>Victoria riu sem graça.
<p>- Fica quieta. – Joseph também riu. – E essa é... – Ele olhou para Lori e não soube o que dizer.
<p>- A outra velha amiga, Lori, mas não se preocupe, eu não ensinei nada. -  Ela sorriu enquanto estendia a mão para Victoria.
<p>- Muito prazer. Vocês parecem ser legais, quero saber tudo sobre a infância do Joe. Ele não me conta nada.
<p>- Ah, então você vai adorar saber que uma vez ele perdeu uma aposta e teve que andar pela escola durante uma hora só de cueca. – Mackenna adorava se lembrar daquilo.
<p>- O quê? – Victoria ficou chocada. 
<p>- Ele quase foi expulso. 
<p>- Ah. Eu quero detalhes.
<p>- Eu preciso ir, tenho que resolver umas coisas. – Lori se levantou muito incomodada.
<p>- O quê? Vai me deixar aqui sozinha.
<p>- Eu fico com você. – Victoria se sentou bem animada aonde Lori estava sentada segundos atrás. – Vou adorar saber detalhes dessa história do Joe andando de cueca e de outras histórias. 
<p>- Ah, isso não vai ser bom. – Joseph riu.
<p>- Tudo bem, então eu já vou indo.
<p>Lori estava contando os passos enquanto chegava em uma distância segura onde poderia respirar de novo. 
<p>- Lori, espera. – Joseph correu atrás dela e a segurou no braço. – Me desculpa.
<p>- Tudo bem. – Ela tentou não parecer tão incomodada. – Eu conversei com o meu pai e... Eu não entendi a briga de vocês, mas tudo bem.
<p>- Não. É, eu fui um idiota mais cedo, mas não estou pedindo desculpas só por isso, eu...
<p>- Então está pedindo pelo quê? Joey, não precisa se desculpar por estar casado. 
<p>- Eu sei, é que...
<p>Joseph demorou muito para decidir o que iria dizer e acabou não dizendo nada. Dois segundos depois, foram interrompidos por uma garota que vinha na direção deles.
<p>- Olha, só para você, Lori. Paquerando o cara mais gato da feira e... desconhecido. – A garota franziu a testa tentando reconhecer Joseph a todo custo.
<p>- Garota, onde você se meteu? Mack e eu estávamos na barraca esperando por você até agora. – Lori ignorou o comentário da garota e já foi direto para a bronca.
<p>- Desculpa, uns amigos me chamaram para curtir atrás da igreja.
<p>- E por curtir, você quer dizer, ficar chapados e dar amassos. – Joseph completou.
<p>- Exatamente. Quer ir também? – A garota piscou para ele. 
<p>- Ele tem o dobro da sua idade, garota. – Lori ficou brava.
<p>- O quê? Eu não sou tão velho assim. – Joseph brincou. 
<p>- Posso saber o seu nome, cara gato e desconhecido que não é tão velho assim.
<p>- Para de fogo, é o Joey. – Lori quase a beliscou, mas só encostou no braço dela.
<p>- Ai, meu Deus, Joe! – A garota abriu um grande sorriso, arregalou os olhos e pulou nos braços dele. – Eu não acredito.
<p>- Ah, eu também não. – Joseph a abraçou, mas ainda não tinha a reconhecido. – Mas quem...
<p>- Sou eu, a Karine.
<p>- Nossa, Kar, é claro. – Joseph ficou animado também. – Nossa. Você cresceu. 
<p>- Tenho dezoito agora. 
<p>- Nossa. – Ele estava impressionado. – Eu costumava pegar você no colo o tempo todo.
<p>- Pode pegar de novo se quiser. 
<p>- Ei, garota. Vai logo para aquela barraca! – Lori ordenou.
<p>- Tudo bem, mãe. – Karine piscou para Joseph de novo e se perdeu na multidão.
<p>Joseph se lembrava muito bem de Karine. Ele praticamente a viu nascer e crescer. Ele adorava a garota e muitas vezes se metia em apuros só para alegrá-la. Ela era uma das vítimas de Dump, seus pais haviam sido assassinados quando ela só tinha seis anos. 
<p>- Nossa. – Ele ainda estava impressionado. – O tempo passa mesmo.
<p>- É. – Lori concordou. 
<p>- Ainda podemos conversar?
<p>- Tchau, Joey. – Lori se afastou também e ele preferiu não a seguir dessa vez.</p>
<center><h4>--*--</h4></center>
<p>- Ai, meu Deus, me salva. – Mackenna encontrou Alexander no fliperama junto com Carl. Ela puxou a camiseta dele pedindo socorro.
<p>- O que foi? – Ele olhou para ela sorrindo enquanto Carl estava focado em vencer o jogo.
<p>- A mãe dessa criança... – Ela começou a sussurrar. – Quer saber de toda a nossa adolescência. 
<p>- O que contou a ela? – Mesmo falando no tom normal, Alexander sabia que Carl não escutaria. O ambiente estava muito barulhento e a atenção do garoto estava toda no jogo.
<p>- O que ela sabe?
<p>- Não muito.
<p>- Ah, eu contei sobre as apostas, os passeios de viatura... a festa no lago. – Mackenna estava se sentindo um pouco culpada.
<p>- Falou sobre a Lori?
<p>- Claro que não, está maluco? Além de desnecessário, a Lori me mataria. 
<p>- Cadê a Victoria agora?
<p>- Foi atrás do Joe. O que está fazendo? – Ela olhou para o fliperama meio confusa.
<p>- Estou levando uma surra desse garoto aqui. – Ele acariciou os cabelos de Carl e o garoto soltou um sorriso enquanto apertava com força o joystick.
<p>- Você odeia fliperama. – Mackenna ficou sem entender. 
<p>- Aprendi a gostar. Esse garoto tem um poder de persuasão poderoso. 
<p>- Olha, me conta uma coisa. – Ela voltou a falar mais baixo. – Eu sei que a Lori ainda é apaixonada pelo Joe, mas e quanto a ele?
<p>- O quê?
<p>- O que ele sente por ela? Não vai me dizer que não sabe, é o único que ainda fala com ele.
<p>- Ele é casado.
<p>- Não respondeu a minha pergunta. 
<p>- Eu só te digo isso. Não sou fofoqueiro. Além do mais, preciso prestar atenção aqui se eu quiser ganhar do CarlMax123.
<p>- Ai, como você me irrita. Ainda bem que é bom de cama.
<p>Mackenna foi embora irritada.
<p>- Ouviu isso, Carl? – Alexander abriu um largo sorriso presunçoso. – Ela disse que eu sou bom de cama.
<p>- O que isso quer dizer? – Carl levantou uma das sobrancelhas. 
<p>- É algo bom, campeão. É algo muito bom.</p>
<center><h4>--*--</h4></center>
<p>- O que eu posso fazer aqui para poder acordar com você do meu lado na cama amanhã de manhã?
<p>Michael abordou Lori na barraca de sucos naturais. 
<p>- Nascer de novo. – Lori pagou o vendedor e saiu andando.
<p>- Não, espera. – Michael foi atrás dela. – Acho que começamos com o pé esquerdo ontem. 
<p>- Ontem? Achei que a sua cantada ridícula foi de cinco segundos atrás. 
<p>- Essa foi só para quebrar o gelo. 
<p>- Cara, se toca. – Lori revirou os olhos. 
<p>- Olha só, eu tive uma ideia. Eu posso te pagar um sorvete, podemos conversar...
<p>- Eu tive uma ideia melhor. Por que você não some? Olha, aqui tem várias garotas que cairiam nesse seu papinho furado. Vai atrás delas.
<p>- Você é a mais gata. Já comprovei. 
<p>- Então vai atrás da segunda mais gata porque eu não tô a fim. 
<p>- Você é sempre assim? – Michael tentou pegar na mão de Lori, mas ela se afastou.
<p>- Seja mais específico.
<p>- Aquele tipo de mulher que pisa em todos os homens porque quer eles nos seus pés.
<p>- Bom, se mesmo sendo pisado, você vai ficar no meu pé, então o problema é com você, não comigo. Falta um pouquinho de autoestima. 
<p>- Sabe, o Joe me contou tudo sobre você.
<p>Pela primeira vez naquela conversa, Lori não estava mais com cara de nojo, mas também não parecia interessada naquela conversa.
<p>- Olha, dá licença, tá? 
<p>- Ele é meu melhor amigo, me conta tudo. Eu posso até já ter visto umas fotos suas bem quentes. – Ele deu um meio sorriso. 
<p>- Ótimo, então vai para o banheiro se divertir com elas, porque de mim, você não vai ganhar nada.
<p>- Mas...
<p>- Além do mais, Joey é muito ciumento, ele nunca compartilharia uma foto com você. 
<p>- Uma foto eu não sei, mas... – Ele mostrou os dentes nesse sorriso.
<p>Um dos oficiais que estavam na feira cuidando da organização e segurança se aproximou dos dois. Sua mão direita já estava na cintura segurando a arma que estava presa no coldre.
<p>- Lori, ele está te atrapalhando? 
<p>- Não, seu policial. Estamos só conversando. – Michael se sentiu diminuído.
<p>- Uma conversa que eu claramente nunca quis participar, Luke. – Lori também não gostava daquele policial, mas não tinha muita opção.
<p>- Senhor, eu peço que...
<p>- Já estou indo. – Michael aceitou sua derrota e se afastou. – Até mais, Lori. 
<p>- Ele é um daqueles idiotas da cidade grande que acha que tudo o que eles têm são impressionantes. – Luke falou com repulsa.
<p>- É, mas no final, é só gel de cabelo. – Lori comentou.
<p>- Você está bem?
<p>- Por que eu não estaria?
<p>- Não por causa desse idiota, mas eu fiquei sabendo que seu ex voltou para a cidade. O pessoal comenta. 
<p>- Não é grande coisa. 
<p>- Sabe, se você quiser ou precisar de alguém para deixá-lo com ciúmes... eu estou aqui. – Luke estufou o peito para deixar mais ainda seus músculos a mostra. 
<p>- Eu preferiria sair por aí com uma árvore, sem ofensas. Tchau, Luke.
<p>Lori revirou os olhos e foi embora, estava cansada de todas aquelas cantadas vindas de policiais todos aqueles anos. Às vezes, parecia que Barry os incentivava a fazer aquilo porque queria a filha com alguém da sua confiança, mas nenhum deles a interessava, não estavam a sua altura e nunca estariam.</p>
<center><h4>--*--</h4></center>
<p><i>- Deixa eu ver se entendi, vamos andar pela floresta, passar perto do lago, mas não vamos nadar?
<p>- Exatamente isso.
<p>Joseph e Lori tinham acabado de adentrar na floresta que cercava a cidade e caminhavam pelas raízes grudadas no chão de mãos dadas. 
<p>- Você ainda vai me matar, sabia disso? – Joseph sorriu.
<p>- Essa é a intenção. – Lori retribuiu o sorriso. 
<p>- Sabe, mesmo com o seu pai me cercando o tempo todo, ele sorriu para mim hoje. Acho que estou começando a conquistá-lo. 
<p>- Isso porque ele não sabe que você tentou me levar para o lago a noite toda e agora está me levando para floresta.
<p>- É, acho que vou cair no conceito dele. Se é que tem como cair mais do que o subterrâneo.
<p>- Ah, para. Não é tão ruim assim. – Lori soltou uma gargalhada. – Pelo menos, ele te olha. Sua mãe me ignora como se eu fosse um mosquito no canto do para-brisa do carro dela. 
<p>- Nossa, que profundo.
<p>- Calado.
<p>- É por isso que eu digo para irmos embora daqui. Fora dessa cidade, ninguém vai nos julgar ou nos olhar feio. 
<p>- Ganhar a aceitação dos nossos pais seria um plano melhor. 
<p>- Lori, nunca vamos ser aceitos. Para o seu pai, eu sempre vou ser o cara que correu durante uma hora pela escola só de cueca. 
<p>- Não só para o meu pai, como para todo mundo dessa cidade. – Ela voltou a gargalhar.
<p>- Aposta é aposta. 
<p>- Acha que a sua mãe sempre vai me ver como a garota sem futuro e interesseira?
<p>- Provavelmente. O engraçado é que ela tem uma filha que não pretende trabalhar nunca na vida dela e um filho que paga pensão para a cria que nunca vai conhecer. Seria cômico se não fosse trágico. Por isso eu digo...
<p>- Eu não posso ir embora. Eu sou tudo o que o meu pai tem.
<p>- Podemos vir visitá-los nos feriados. 
<p>- Não é tão simples. – Lori sempre ficava resistente quando Joseph jogava essa ideia para ela. 
<p>- Tá, vamos deixar isso para lá. 
<p>- Eu sinto muito.
<p>- Não precisa se desculpar, pelo menos não por isso. Por não estarmos pelados no lago agora? Pode ter certeza.
<p>- Eu te amo, sabia disso? – Ela o beijou. 
<p>- De onde isso veio? – Ele riu. – Mas eu também te amo. Eu sempre vou te amar, na verdade. Não importa o que aconteça. É uma promessa.
<p>- Não pode dizer essas coisas.
<p>- Promessa é promessa, não é? – Ele conduziu a mão dela até o seu peito. – Está sentindo isso? Meu coração trabalha muito quando eu estou perto de você.
<p>- Então quer dizer que se tiver um ataque, a culpa vai ser minha?
<p>- Ah, pode apostar que vai.
<p>- Ridículo. “Sempre” é muito tempo, sabia?
<p>- A ideia é essa. 
<p>Joseph se aproximou mais da namorada para beijá-la, mas um barulho o impediu. Alguém, não muito longe deles, estava muito feliz. Os dois se esconderam atrás de um tronco gigantesco enquanto via, mesmo que no escuro, uma garota toda animada gritando para o garoto que a seguia que iam para o lago fazer amor. Ela não parecia estar completamente bêbada, mas com certeza não estava em seu estado normal. 
<p>- Quer dizer que o lago já está ocupado? – Joseph falou, um pouco decepcionado, depois que o casal desapareceu da vista dos dois. 
<p>- Quem eram? – Lori franziu a testa. Ela não conseguiu enxergar nada naquela escuridão.
<p>- O cara, eu não sei, mas a garota... Era a Santa Susan sem dúvida. 
<p>- Para de chamar ela assim. – Mas mesmo assim, ela riu do apelido. – Como tem certeza?
<p>- Reconheceria aquela voz chata e estridente em qualquer lugar. – Joseph fez uma careta. – Já o cara, não consegui ver quem era, mas acho que é mais velho.
<p>- Como chegou a essa conclusão se você nem viu o rosto dele?
<p>- Estavam indo transar no lago e ele não parecia animado. Se ele tivesse a minha idade...
<p>- Nossa, vai lá pular com a Susan então. 
<p>- Não, eu prefiro pular com você, que tal?
<p>- Pular, eu não sei, mas... – Lori o empurrou até o tronco e começou a beijá-lo. 
<p>Então ele começou a rir descontroladamente.
<p>- O que foi? – Ela ficou sem entender.
<p>- Parece que a Santa Susan não é tão santa assim, afinal. 
<p>- Deixa de ser ridículo. – Ela voltou a beijá-lo, mas dessa vez os dois caíram na gargalhada. – É, transar no lago não é algo que uma santa faria.
<p>- A não ser que ele seja um anjo. Será que ela será a próxima Virgem Maria?
<p>- Para com isso. Ridículo.</i></p>
<center><h4>--*--</h4></center>
<p>Lori estava sentada no cais. As pontas dos seus pés descalços estavam no mar gelado enquanto ela encarava o horizonte. Ela ouviu alguém vindo correndo em sua direção e quando olhou para o lado, parecia que era ele correndo para ela, com vinte anos a menos.
<p>- Carl, não vai para a beirada! – Ela ouviu a voz de Alexander longe. 
<p>Ele estava na escada de madeira observando o garoto que estava maravilhado com aquela paisagem. 
<p>- Olá. – Carl sorriu para Lori e ela não conseguiu não retribuir.
<p>- Oi. O que está fazendo aqui?
<p>- Eu vim olhar o mar. É bem escuro. – Ele chegou nessa conclusão depois de um tempo e se sentou ao lado dela.
<p>- É. É sim. 
<p>- E você? Está olhando o mar? Eu ganhei um brinde no fliperama, você quer ver? – Ele tirou um saquinho vermelho de dentro do bolso da bermuda.
<p>- O que é isso? – Lori demonstrou interesse.
<p>- É uma pulseira. – Carl tirou do saquinho uma pulseira feita com conchas do mar. – Eu queria os óculos de sol. Não gosto de pulseira. Me incomoda tudo que fica preso no meu braço.
<p>- Ah é? – Ela riu e lembrou que Joseph tinha esse mesmo pensamento.
<p>- Você quer? – Ele estendeu a mão aberta com a pulseira para Lori pegar.
<p>- Não. É sua. Você ganhou.
<p>- Mas eu quero dar para você. Combina com você. É tão bonita quanto ela. 
<p>- Olha só, se você fosse mais velho, eu poderia te beijar agora. – Lori estendeu o braço e Carl colocou a pulseira nela. – Nunca ninguém disse isso para mim.
<p>- Eu sou novo, mas aceito o beijo. 
<p>Lori começou a rir.
<p>- Ei. – Joseph estava parado do lado do filho. Parecia que estava lá já fazia um tempo só observando aquela conversa. – O que eu te disse sobre essas conversas?
<p>- Que eu posso beijar quem eu quiser. – Carl sorriu para o pai.
<p>- Espertinho. Pede para o seu tio Lex te levar para comer alguma coisa porque depois vamos embora.
<p>- Tá bom! – Antes de Carl se levantar, ele beijou a bochecha de Lori. 
<p>- Garoto. – Joseph riu enquanto seguia com os olhos seu filho ir até as escadas e se encontrar com Alexander. 
<p>- Deixando as outras pessoas fazerem seu trabalho? Deve ser fácil ter um filho. – Lori riu.
<p>- Mais do que imagina. – Joseph se sentou ao lado dela e ela se afastou um pouco. – Vi que ele te deu a pulseira.
<p>- É. Parece que isso me acontece de geração em geração. – Ela mostrou seu punho com a pulseira. Lori estava com um humor melhor. 
<p>- Sabe, eu estava dando uma volta e essa feira realmente me fez voltar no tempo. 
<p>- Quer realmente voltar no tempo? O garoto que está cuidando da barraca do beijo tem treze anos e quer conseguir um beijo de uma garota específica. 
<p>- Ah é? – Joseph sorriu.
<p>- Parece que ele tem que conseguir o beijo por causa de uma aposta.
<p>- Aposta? Então ele não se apaixonou por ela só pelo olhar? Essa adolescência está perdida.
<p>- Você não se apaixonou pelo olhar.
<p>- Eu me apaixonei sim. Eu chegava na escola todo dia bem cedo só para estar no lugar onde você passaria. Eu adorava aquele olhar furioso e ao mesmo tempo... o mais brilhante do mundo. Você passando pelo corredor era como se... Era como se fosse Natal.
<p>- Ah, cala a boca. – Ela o empurrou de leve com a mão e os dois riram. 
<p>- Eu quero que saiba que eu demorei muito para superar você. Pareceu uma eternidade.
<p>- Eu sei, em nenhum momento eu pensei que você não me amasse. 
<p>- Ótimo, porque promessa... é promessa. – Joseph sentiu vontade de pegar a mão de Lori e levá-la até seu peito para ela sentir seu coração quase pulando.
<p>- Não pode dizer isso. Não agora. 
<p>- Eu sei. 
<p>Os dois ficaram em silêncio olhando para o horizonte escuro.</p>
<center><h4>--*--</h4></center>
<p>- Curtindo bastante o festival caipira?
<p>Michael encostou na grade que corria em volta do carrossel enquanto Victoria olhava bem animada para os cavalinhos coloridos chupando um picolé.
<p>- Nem é tão ruim. Imaginei que seria pior. – Victoria riu. 
<p>- Cadê seus garotos?
<p>- Ah, o Carl está por aí com o Alexander, já o Joe...
<p>- Te deixou sozinha de novo. – Michael se aproximou mais da mulher. 
<p>- Não é bem assim. Não gostamos de ficar grudados o tempo todo. Você sabe disso. 
<p>- É, eu sei sim. Já que você está sozinha...
<p>- Não. Aqui não. – Victoria colocou o dedo no rosto de Michael. – A gente combinou, lembra? É muito arriscado. 
<p>- Mas eu estou na seca aqui. Preciso me molhar um pouco.
<p>- Arranja alguma piranha que se encantaria pelo seu Porsche e fique com ela.
<p>- Você não ficaria com ciúmes se eu ficasse com outra?
<p>- Ah, cala a boca. 
<p>- Olha, eu ouvi dizer que ninguém escutaria se você gritasse no meio da floresta. E como você adora gritar...
<p>- Michael, eu já disse, aqui não. 
<p>- Tudo bem, você quem manda.
<p>Michael deu a volta e parou atrás de Victoria. Se aproximou mais dela e cochichou em seu ouvido.
<p>- Eu vou para o meio do mato agora e em cinco minutos, eu te mando a localização no celular. Já vai com o sutiã desabotoado para não dar muito trabalho. Eu já vou estar com as calças abaixadas. 
<p>- Ridículo.
<p>- Então não me deixa esperando muito. Não quero ter que me divertir sozinho. 
<p>Michael mordeu de leve a ponta da orelha de Victoria e foi embora. Ela tentou resistir, mas sentiu alguns arrepios e sabia que assim que a mensagem dele chegasse no seu celular, ela estaria pronta para encontrá-lo. Era sempre assim.</p>
<center><h4>--*--</h4></center>
<p>George estava bêbado e chapado. Era uma combinação comum para ele.
<p>Em todo o show que performava, ele bebia para lhe dar coragem de subir ao palco e no final dava umas tragadas em qualquer baseado que ele via na boca dos seus colegas ou até mesmo de fãs. 
<p>Ele havia deixado a banda depois da última música e caminhado até a floresta para poder fumar à vontade sem ninguém tomar o cigarro da mão dele, mas estava tão desnorteado que nem percebeu que o cigarro caiu no chão quando ele tropeçou pela quinta vez em uma das raízes no chão.
<p>O silêncio só se quebrava pelos barulhos de insetos noturnos e corujas, até que ele ouviu alguns gemidos.
<p>- Ah, alguém está se dando bem essa noite. Alguém está se dando muito bem!
<p>Ele tentou ir em direção aos gemidos, pensou que poderia até se juntar à festa se ninguém se importasse, mas parecia estar caminhando para mais longe ao invés de mais perto. Depois de um tempo, os gemidos se calaram e ele só ouvia grilos e corujas de novo até que...
<p>Ele não estava sozinho ali. Ouvia passos. Podia ser da sua cabeça perturbada de maconha. Ele ficava muito paranoico quando o cigarro estava chegando ao fim. Continuou andando calmamente pela floresta e os passos atrás dele não cessaram. 
<p>George sentiu um peso enorme nas suas costas e caiu de cara no chão. Suas pernas estavam cambaleando que foi fácil perder o equilíbrio. Ele sentiu o gosto de terra na sua boca e sangue escorrendo do seu nariz. Ainda bem que não havia cheirado, ele pensou. Seria pior.
<p>Ele abriu suas mãos e as apoiou no chão. Foi só quando tentou se levantar, depois de alguns segundos, que ele percebeu que não conseguia. Havia alguém em cima dele. Alguém pesado. Quando tentou levantar a cabeça, uma mão a empurrou de volta e ele sentiu o gosto de terra de novo. 
<p>Em questão de segundos, suas costas começaram a arder. Ele lembrou da dor de quando cortou o dedo cortando carne em um churrasco de domingo há alguns anos, mas aquela dor daquele momento era pior, mil vezes pior e em vários pontos do corpo. Ele tentou gritar, mas só conseguiu engolir mais terra. 
<p>Ele então sentiu uma coisa gelada, molhada e gosmenta passar pelo seu pescoço. Era uma faca com o seu próprio sangue. Ele sentia seu sangue escorrendo pelo corpo. Pelo pescoço. O vento ardendo suas feridas. 
<p>Então parou. Ele desmaiou de dor ou talvez com a perda de sangue. Ou talvez já estivesse morto com a cabeça quase decapitada. Foi difícil saber naquela escuridão. Próximo passo? Ter os pés e as mãos cortadas e talvez ser pendurado em uma das árvores para servir de almoço para algum urubu atrás de carniça.</p> 
</body></html>";
            }

            if (numero == 5)
            {
                lblTitulo.Text = "Capítulo 5 - Nostalgia";
                htmlPage.Html = @"<html><body>
<p><i>Quando Joseph chegou de mãos dadas com Lori na lanchonete, Alexander e Mackenna já estavam sentados na mesa de sempre. 
<p>Os quatro amigos costumavam tomar café da manhã ali toda quarta-feira. Era meio que um ritual que Joseph e Alexander haviam criado três anos antes e que continuava até aquele dia. 
<p>- Já pediram as panquecas? – Joseph perguntou animado enquanto se sentava.
<p>- Já e rosquinhas. – Alexander respondeu.
<p>- Aonde estavam ontem? Tentei ligar. – Mackenna parecia preocupada.
<p>- Eu vi sua mensagem à noite quando cheguei em casa, mas eu estava tão cansada... – Lori colocou uma das mãos na cabeça. Ela parecia mesmo bastante cansada.
<p>- Depois que os nossos planos de sexo no lago foram destruídos no dia da feira, eu levei a Lori para velejar. – Joseph parecia bem satisfeito com a sua ideia. 
<p>- Então conseguiu realizar seus planos no mar? – Alexander riu junto com o amigo.
<p>- Calem essa boca. – Lori deu um tapa no braço do namorado. 
<p>- Seu pai deixou mesmo você usar o barco dele? – Alexander sabia que os pais de Joseph não estavam muito felizes com aquele namoro do filho e que nunca fariam algo para ajudá-los a ter um dia bom.
<p>- Ah, qual é, Lex? Você me conhece. Eu roubei.
<p>- Gente, atenção. – Mackenna bateu palmas para todos olharem para ela. – Eu estava mesmo preocupada. Vocês não souberam?
<p>- Soubemos de quê? – Lori franziu a testa.
<p>- Susan desapareceu ontem à tarde.  – Alexander respondeu. – Está todo mundo procurando por ela. 
<p>- Achei que tinham desaparecido também. – Mackenna olhou feio para a amiga. – Não consegui nem falar com o Barry.
<p>- Espera um pouco, desapareceu? – Joseph não estava acreditando muito naquela história. – Mas como? Essa cidade é um ovo. Deve estar na casa daquela... como é mesmo o nome da amiga dela?
<p>- Lenny. – Mackenna respondeu. – Não, não está. Saiu no Diário Popular. Ela está tão preocupada quanto os pais.
<p>- Quando foi a última vez que ela foi vista? – Lori estava chocada. Seu pai era da polícia e não tinha comentado nada na noite passada. Com certeza, não queria que ela entrasse em pânico.
<p>- Ontem à tarde. – Mackenna respondeu. – Estava na biblioteca com a Lenny e depois foi embora. Não chegou em casa. 
<p>- Gente, é impossível alguém desaparecer aqui, a não ser que ela esteja morta e enterrada em algum lugar. – O comentário de Joseph fez os outros três olharem de cara feia para ele. – Já procuraram no meio do mato? Se ela não está na casa de alguém, só pode...
<p>- A polícia está fazendo rondas na floresta, mas é fácil se esconder por lá. Se alguém a pegou... – Alexander não gostava nem de pensar nessa possibilidade. – É horrível. Nem imagino como os pais dela devem estar. 
<p>- Nós a vimos anteontem, depois da feira. Ela estava na floresta. – Lori lembrou.
<p>- É. – Joseph continuou. – E parecia bem feliz com um cara. 
<p>- A Santa Susan com um cara se escondendo no meio do mato? – Mackenna arregalou os olhos. – Essa é nova. E eu aqui achando que ela nunca nem tinha beijado na vida. 
<p>- Devíamos contar para a polícia sobre isso? – Lori demonstrou mais preocupação do que antes.
<p>- Por quê? Nem vimos a cara do cara. Vai ser outro beco sem saída para eles. – Joseph ainda não parecia estar dando muita importância para aquele caso. – E com certeza, ela vai aparecer em um ou dois dias dizendo que se perdeu quando, na verdade, só queria dar umazinha com o namorado sem ninguém ficar sabendo. 
<p>- Que comentário desnecessário. – Lori pegou o cardápio que estava em cima da mesa e começou a lê-lo para não ter que prestar atenção no que o namorado falava.
<p>- Ah, qual é, gente? Vamos mesmo ficar preocupados por causa dessa garota? A gente mal fala com ela.
<p>- Isso se chama empatia. – Alexander o encarou.
<p>- Isso se chama sensacionalismo. Eu aposto que isso tudo é mentira dela ou algo parecido só para chamar atenção. 
<p>- Diz isso porque odeia ela. – Lori desistiu de focar sua atenção no cardápio sem graça.
<p>- Eu não odeio ela. – Joseph explicou. – Só acho ela uma chata e hipócrita. Disse que a gente ia para o inferno só porque estávamos nos beijando no corredor da escola, enquanto isso se pegava com um desconhecido escondida no meio do mato. 
<p>- Isso parece ódio para mim. – Lori mostrou um sorriso falso. 
<p>- O pessoal está se reunindo para procurá-la pela cidade para cobrir mais terreno, só os policiais não vão dar conta. – Mackenna explicou. – Vão participar?
<p>- Vai ter alguma recompensa? – Joseph sorriu para mostrar sua resposta. Um grande “não”.</i></p>
<center><h4>--*--</h4></center>
<p>Joseph sorriu quando viu Alexander sentado naquela mesa. A mesa que ele não via já fazia dez anos. Ele acenou e foi até o amigo. 
<p>- Eles fazem panquecas como antigamente? – Ele se sentou de frente para o amigo.
<p>- Sim.
<p>- Então devíamos comer em outro lugar com comida melhor. – Os dois começaram a rir. 
<p>- O que os idiotas estão conversando? – Mackenna apareceu e se sentou ao lado de Alexander. Lori veio logo atrás dela e se sentou ao lado de Joseph. 
<p>- Não interessa mais, agora que você chegou... Mack, diga o que todos nós queremos saber. Ele é bom ou não? – Joseph apontou o dedo para Alexander.
<p>- Ah, cala essa boca. – Lori bateu em seu ombro e foi a única da mesa que não riu. 
<p>- O quê? Você realmente diria há dez anos que esses dois estariam se pegando no futuro? Alguma coisa ele tem e tenho certeza que não é bom papo. 
<p>- Ei, ele ainda está aqui. – Alexander levantou a mão. – E eu tenho bom papo. 
<p>- Uma vez, você tentou cantar a Cassie. Ela foi embora achando que você era um louco. – Mackenna riu. – Não, seu papo não é bom, já o...
<p>- Tá legal, já chega. – Joseph fez uma careta. – Já me arrependi de ter perguntado. 
<p>- Olha só, nós três sabemos muito um da vida do outro. – Mackenna falou ainda rindo. – A celebridade aqui é você, conta para gente o que fez nesses dez anos. A boca do Alex é um túmulo. 
<p>- Ah, eu fiz faculdade e... arranjei um emprego... – Joseph ficou um pouco sem graça de contar a sua vida. – Coloquei muito filho da mãe na cadeia. Andei de metrô, vocês sabem o que é metrô?
<p>- Palhaço. – Lori fez pouco caso. – Nos conte como é ser um pai de família. 
<p>- Vocês conheceram meu filho, não é nada fácil. – Ele riu. – Mas... quando ele nasceu, eu me senti o cara mais feliz do mundo e o mais assustado também. Proteger vítimas, moleza, proteger um filho, não tão moleza assim. 
<p>- Eu gostaria de ter um filho. – Alexander ficou pensativo.
<p>- Não diga isso. Minha barriga está fechada. – Mackenna arregalou os olhos.
<p>- Nós todos aqui sabemos que não se faz filhos pela barriga. – Lori brincou.
<p>- É, o lugar por onde faz filhos ultimamente está bem aberto no seu caso. – Joseph também brincou.
<p>Os quatro soltaram gargalhadas. O ritual de quarta-feira não acontecia há muito tempo, dez anos para ser mais preciso. Lori se recusou por um bom tempo a se juntar aos amigos depois que Joseph foi embora e depois, quando ela finalmente superou, eles acabaram deixando esse ritual morrer. Eles sempre se juntavam, mas nunca de manhã, nem na lanchonete e muito menos em uma quarta-feira.</p>
<center><h4>--*--</h4></center>
<p>Victoria estava enchendo sua xicara de café na cozinha. Ela viu pela janela o céu totalmente limpo e por algum motivo, aquela visão a deixou pensativa. 
<p>- Oi!
<p>Ela derramou algumas gotas de café na pia quando se assustou com o grito de Michael atrás dela. Ela não esperava companhia na cozinha naquela hora.
<p>- Quer me matar do coração? – Ela se virou para ele irritada.
<p>- Mas por que está tão assustada? Isso é culpa? – Michael sorriu para ela. O mesmo sorriso cínico que ele usava com quase todo mundo. – Estava te esperando no chuveiro, mas você não apareceu.
<p>- Fala baixo. – Victoria começou a sussurrar. – Eu já te disse que...
<p>- Aqui, não, eu sei. – Michael não abaixou o tom de voz. – Mas na floresta tudo bem, não é? Na verdade, eu só queria dizer que estou à disposição. Você estava tão pensativa olhando para as árvores lá fora. Certeza que estava pensando na gente ontem mandando ver...
<p>- Cala a boca. E eu já disse para falar baixo. Isso foi um erro.
<p>- Eu discordo. – Ele se aproximou mais dela. – Além do mais, eu estou muito a fim. Se você quiser, a gente vai para floresta agora.
<p>- Não. Sai de perto de mim. – Victoria se afastou de Michael e foi para o lado oposto do cômodo. Sabia que se continuasse perto dele daquele jeito, eles fariam ali mesmo em cima da pia em uma cozinha sem portas e para todo mundo ver. 
<p>- Você é engraçada. – Michael não a seguiu. Só riu e foi até a cafeteira em cima da pia para pegar café também. 
<p>- Você ao menos tem ideia do quão errado é isso? – Victoria sempre fazia esse discurso. 
<p>- Não estamos fazendo nada de errado. – Michael observava as árvores do lado de fora enquanto falava. Ele realmente acreditava em suas palavras e não estava nenhum pouco preocupado.
<p>- Ah, é? Sabe o que vai acontecer se o Joe nos pegar? 
<p>- Ele vai fazer um showzinho. Nada que eu não espere. 
<p>- Ele é seu melhor amigo.
<p>- E é seu marido. E mesmo assim você adora gemer no meu ouvido. 
<p>- Cala a boca. – Ela voltou a sussurrar de novo e a olhar para os lados com medo de alguém chegar. – Você é um cretino. 
<p>- Tudo bem, eu aceito a culpa. Aceito com muita satisfação. – Michael se virou para Victoria, olhou para o seu rosto bem assustado e incomodado, tomou um gole de café e sorriu. O mesmo sorriso cínico.</p>
<center><h4>--*--</h4></center>
<p><i>- Isso foi muito errado. Eu não acredito... eu não... 
<p>Victoria estava com as mãos no rosto e sentindo muita vergonha. Não queria ter que encarar nos olhos o homem que estava deitado na cama ao seu lado.
<p>- Isso não podia ter acontecido... Eu não... Isso é errado... Eu me sinto uma... É errado. – Ela murmurava para si mesma. 
<p>- Olha, você quer se acalmar? – Michael ficou de lado para poder olhar para ela. – Falar esse tipo de coisa depois do sexo não é muito bom para o meu ego. Quer olhar para mim? – Ele puxou as mãos dela para longe do rosto.
<p>- Eu não posso me acalmar. Ai, meu Deus. Eu preciso me vestir, eu preciso... Você precisa sair daqui agora.
<p>- Eu moro aqui. 
<p>- Eu estou falando da cama. VOCÊ TEM QUE SAIR DA MINHA CAMA AGORA!
<p>- Você quer se acalmar? – Ele repetiu. – Está tudo bem.
<p>- Não, não está tudo bem. – Ela colocou suas mãos na cabeça. – Eu não podia... a gente não podia.... Por que isso foi acontecer?
<p>- Porque a gente quis. Não tem ninguém culpado aqui.
<p>- É claro que tem culpado. Nós somos culpados. Ai, meu Deus, o Joe vai me matar.
<p>Victoria se levantou da cama completamente nua e começou pegar suas roupas que estavam espalhadas pelo chão do quarto para se vestir.
<p>- Joe não precisa saber. Não foi nada demais.
<p>- Não foi nada demais? NÃO FOI NADA DEMAIS? É CLARO QUE FOI! – Ela parou por um segundo de abotoar seu sutiã para poder gritar. – Eu sou casada com o seu melhor amigo. Ele te deixou morar aqui e... Isso é loucura. Não, isso é mais do que loucura, isso é...
<p>Os olhos de Victoria estavam cheios de lágrimas. Ela andava de um lado para o outro ainda só de roupas debaixo sem nem ao menos saber o que estava procurando.
<p>- Eu nem sei como chamar isso.
<p>- Vamos chamar de... um momento de fraqueza. – Por outro lado, Michael não estava demonstrando nenhuma preocupação. – Tivemos um dia ruim e... simplesmente aconteceu. 
<p>- É essa a desculpa que vamos dar para o Joe? Que simplesmente aconteceu? Acha que ele vai perdoar a gente?! – Victoria estava completamente histérica.
<p>- Como eu disse, ele não precisa saber. Aconteceu, já foi. Não dá para mudar, não há mais nada a se fazer. 
<p>- Eu não vou conseguir esconder isso. Eu não vou...
<p>- Mas você precisa. – Michael se levantou da cama também sem roupa e foi até Victoria. – Vicky, me escuta. Você precisa se acalmar.
<p>- Eu não...
<p>- A gente cometeu um erro, tá bom? Todo mundo comete erros. – Ele colocou suas mãos nas bochechas de Victoria. – Somos humanos. 
<p>- Mas o Joe...
<p>- Ele não vai entender, eu sei. Ele não sabe o que é ter um dia ruim nem precisar de alguém naquela hora. – Ele olhou bem fundo nos olhos da mulher. – Ele não entende o que é se sentir mal e querer fazer de tudo para sentir alguma coisa boa. A gente foi pego pela circunstância. Eu estava aqui e você também, foi errado, mas não tivemos total culpa. E...
<p>- Nunca mais vai acontecer. – Victoria falou com a voz meio fraca.
<p>- Nunca mais. 
<p>Então ele a beijou e grudou o seu corpo junto do dela. E naquele momento, os dois perceberam que ia acontecer de novo e naquele mesmo dia.</i></p> 
<center><h4>--*--</h4></center>
<p>- Sabe, eu não reparei muito na primeira vez que eu vim aqui, mas... você mudou bastante o lugar. 
<p>Lori abria as janelas do bar enquanto Joseph olhava para todos os detalhes. Era mais fácil prestar atenção no lugar quando a dona não o olhava feio ou quando ele não estava nervoso. As paredes estavam com uma cor vinho bem viva quando antigamente tinha cor de concreto. As mesas e cadeiras de madeira não estavam riscadas nem com os pés comidos pelo tempo. O cheiro era bom, não aquele tom de álcool forte que o bar costumava ter. Só faltava uma placa de “Sob Nova Direção”. Mas havia uma coisa que estava igual, aquela velha <i>jukebox</i> ainda estava no mesmo lugar. 
<p>- É, ele é praticamente meu filho agora. É engraçado. – Lori respondeu. 
<p>- O que é engraçado? 
<p>- Todas as vezes que a gente veio para cá e ficou uma ou duas horas antes do meu pai chegar e me levar para casa... Nunca me passou pela cabeça que um dia, eu seria dona daqui. 
<p>- Você ainda pensa? – Joseph não deu muito sentido a frase, mas Lori sabia o que ele estava se referindo.
<p>- Não já faz muito tempo. 
<p>- É uma pena, se quer a minha opinião. – Ele mostrou um pequeno sorriso.
<p>- Quando foi que eu quis? – Já ela mostrou todos os dentes com seu sorriso. 
<p>- Engraçadinha. Então, o que eu preciso fazer para ganhar um drinque aqui? – Joseph se sentou em um dos banquinhos perto do balcão.
<p>- Chegar às seis e meia. Estamos fechados.
<p>- Já para mim, sempre está fechado! Mesmo depois das seis e meia! – Karine entrou no bar já gritando para mostrar sua presença. 
<p>- Sempre não, mas sim pelos próximos quatro anos! – Lori retrucou no mesmo tom.
<p>- Três, eu já tenho dezoito. – Karine se sentou ao lado de Joseph e sorriu para ele.
<p>- Ai, eu odeio olhar para você. – Joseph bufou. – Me sinto um velho. 
<p>- É, já dá mesmo para ver alguns cabelos grisalhos. – Ela o encarou. – Mas não tira, não. Fica um charme. 
<p>- Kar. – Lori olhou feio para a garota.
<p>- O que foi? Se você não dá em cima dele, tudo bem, mas eu não vou perder a minha chance. 
<p>- Olha, você tem atitude, eu gosto disso. – Joseph riu. – Mas pelo menos já usa sutiã?
<p>- Você quer ver? 
<p>- Garota. – Lori voltou a repreendê-la.
<p>- O que foi, mãe? – Ela revirou os olhos.
<p>- Relaxa, Lori. A gente só está brincando. – Joseph piscou para a garota. – Como antigamente.
<p>- Então você se lembra que eu falava que quando eu crescesse, eu ia me casar com você.
<p>- Eu me lembro sim. Foi mal. – Ele riu nas últimas duas palavras.
<p>- Eu não te perdoo. – Ela fingiu um bico. – Como é lá? O mundo fora de Darkey. 
<p>- Ah... – Joseph olhou para Lori com um pouco de receio. – É incrível. É realmente tudo o que a gente vê na TV. É grande, agitado, cheio, tem de tudo um pouco. É barulhento e colorido.
<p>- Parece perfeito. – Karine encostou seu cotovelo no balcão para escorar sua cabeça em sua mão enquanto ouvia, toda admirada, Joseph falar. 
<p>- Ah, não é tão perfeito assim. Às vezes é complicado. Você se sente meio solitário.
<p>- Não se você tiver uma família. Até porque até aqui eu me sinto solitária.
<p>- Do que você está falando? – Lori franziu a testa. – Você tem vários amigos.
<p>- Se você quiser... – Joseph sabia exatamente como Karine se sentia. Ele também tinha vários amigos, mas nenhum deles sabia o que era ver um assassino em série cara a cara com dezoito anos. – Eu tenho um quarto sobrando... Se quiser passar uns dias por lá... Seria bem-vinda.
<p>- Eu adoraria. – Karine abriu um largo sorriso. – Seria incrível. 
<p>- Então fechado. 
<p>- Só porque você tem dezoito não quer dizer que já pode tomar todas as suas decisões, mocinha. – Lori ficou incomodada.
<p>- Ela vai estar com um policial. Relaxa. – Joseph tentou acalmá-la.
<p>- É, Lorie, relaxa.</p>
<center><h4>--*--</h4></center>
<p><i>Joseph foi até o parquinho atrás da igreja. Aquele lugar era mais usado pelas crianças geralmente no sábado à tarde, depois do culto dedicado a elas. Naquele dia, só não estava vazio por causa de uma garota.
<p>Karine estava sentada no balanço segurando bem firme nas cordas. Ela arrastava a ponta de seus pés pelo chão enquanto o balanço ia de lá pra cá bem devagar e com pouca distância.
<p>- Oi. – Joseph se sentou no balanço ao lado. – Tudo bem com você?
<p>- O Pastor Iris não quer dizer aonde meus pais estão. Ninguém quer me dizer. – Uma lágrima escorreu de seus olhos. – O que aconteceu com eles?
<p>- Kar...
<p>- Você nunca mentiu para mim. Me diz. 
<p>- Eles... – Joseph não sabia como dizer para uma garota de seis anos com os olhos cheios de lágrimas que algum maníaco doente havia matado e mutilado seus dois pais de uma vez. – Eles morreram, Kar.
<p>- Por quê?
<p>- Ah... porque todos nós, um dia... eu não tenho uma explicação.
<p>- E eles não vão mais voltar?
<p>- Infelizmente, não, princesa. Eles não podem. 
<p>- O que vai acontecer comigo, então?
<p>- Eu... eu não sei. Eu sinto muito. – Os olhos se Joseph também se encheram de lágrimas. 
<p>- Você pode cuidar de mim, por favor? Eu prometo que eu não vou te dar trabalho. Eu não quero ficar sozinha. 
<p>- Você não vai ficar sozinha. Eu não vou deixar. Eu prometo.</i></p>
<center><h4>--*--</h4></center>
<p>- Isso não é ótimo? Da última vez que nós quatro nos juntamos aqui, não podíamos beber. Olha para gente agora.
<p>Mackenna levantou o copo e puxou o brinde, os outros três a seguiram e brindaram juntos. Ela estava com Lori atrás do balcão enquanto Joseph e Alexander ficaram sentados nos banquinhos do outro lado. 
<p>- Sem falar que todas as vezes, o Lex ficava morrendo de medo de ser pego. Sempre implorava para gente ir embora. – Joseph riu descontroladamente. Os quatro já estavam um pouco alterados. 
<p>- Você devia me entender. É policial agora.
<p>- Você foi um adolescente muito estranho. – Lori riu. Era a única que ainda estava no primeiro copo desde que começaram a beber. Ela ainda tinha um bar inteiro para cuidar, embora ele não fosse muito movimentado durante a semana. 
<p>- Nossa, eu me lembro exatamente de todas as vezes que a gente foi pego. – Joseph puxou na memória.
<p>- Lógico, todas as vezes era você que pagava o pato. Eu adorava isso. Minha mãe nunca soube que eu estive em um bar. – Mackenna se vangloriou.
<p>- Era sempre o Barry que vinha atrás da gente. Ele me via, me prendia com algemas e fazíamos o mesmo caminho de viatura até a delegacia. Chamava meus pais e eu passava a noite toda ouvindo o quanto a Lori era ruim para mim.
<p>- Mal sabia eles que você que nos convencia a vir para cá. – Lori falou fingindo estar brava.
<p>- Meu lema era: “seja sua própria má influência”.
<p>- Ótimo lema. – Os três concordaram rindo.
<p>Joseph olhou para a <i>jukebox</i>. Suas luzes coloridas estavam todas acesas. Ele se surpreendeu. Naquela tarde, achou que não funcionava mais.
<p>- Sabe do que eu me lembrei? – Ele olhou para a Lori. – Do nosso lance. E que eu sempre ando com uma moeda.
<p>- Não!
<p>- Ah, qual é? – Ele fez a sua cara de pidão. – A gente sempre fazia isso.
<p>- É, mas faz muito tempo, eu nem me lembro mais como... – Lori fechou os olhos. Queria desaparecer dali naquele momento. 
<p>- Eu sei que você se lembra.
<p>Joseph se levantou e foi até a máquina.
<p>- Joey, não! – Ela já estava ficando desesperada.
<p>Ele colocou uma moeda na máquina e começou a procurar pela música. Pediu para Deus que ela ainda estivesse lá. Então clicou no botão de play e depois deu um chute no canto perto do pé dela para começar a tocar a música, sempre foi assim. 
<p><i>I’m Still Standing</i> começou a tocar. 
<p>Joseph olhou para Lori, foi até o meio do bar e subiu em uma mesa. Ela o seguiu e subiu em outra de frente dele. Com um minuto de música, já parecia que eles ainda faziam isso toda noite. Impulsionaram as palmas dos dez clientes que o bar atendia naquela noite e cantaram com as vozes um pouco mais afinadas que dez anos atrás.
<p>Eles se lembraram de cada movimento de braço e de perna, estavam em perfeita sintonia. No grande final, a última parte da música, desceram das mesas e foram para outra maior onde os dois conseguiam se movimentar juntos. As palmas continuaram e mais fortes, conseguiram até um coro de fundo. 
<p>Naquele momento, foi como se o tempo tivesse voltado. Eram adolescentes de novo fazendo aquilo em um bar onde não poderiam estar e sabendo que os policiais e Barry estariam ali em alguns minutos e tudo o que eles podiam fazer era aproveitar o momento, o momento deles.</p> 
<center><h4>--*--</h4></center>
<p>- Que horas são? Preciso ir embora antes da Lori chegar. 
<p>Paul olhou assustado para a tela de seu celular. Ele havia pegado no sono. Acordou quando Karine se mexeu na cama. Ele tinha um sono bem leve.
<p>- Ela só chega daqui a uma hora. – Karine subiu em cima dele. – Ainda dá tempo de a gente brincar um pouco. – Ela mordeu a ponta da orelha direita dele.
<p>- Eu geralmente não recuso isso, mas... – Ele a beijou. – Meu turno começa em meia-hora. Eu até que estou meio atrasado.
<p>- Não pode se atrasar mais?
<p>- Por você, eu até posso. 
<p>Karine e Paul estavam ficando juntos fazia alguns meses, sete meses e nove dias, ele diria. Ele era o cadete mais novo da delegacia e ela estava se formando no ensino médio. Tudo aquilo era um segredo, Barry ia gritar sem parar se soubesse e Lori iria surtar. Havia sido um acordo mútuo dos dois de manter aquilo só para eles. 
<p>O relacionamento não era muito comum. Quando se encontravam em público, muitas vezes na igreja aos domingos ou na delegacia ou mesmo quando se cruzavam na rua, fingiam que não se conheciam, pelo menos, não tão intimamente. 
<p>Eles marcavam encontros às escondidas. Como Paul ainda morava com os pais, nunca podia ser em sua casa. Lori estava sempre no bar até tarde, então Karine tinha a casa só para ela toda noite, isso facilitava muito. No começo, eram só encontros de sexo. Isso foi evoluindo, mas não sabiam exatamente em que passo estavam. Conversavam sobre as coisas, mas nunca sobre os sentimentos de um pelo outro.
<p>- Queria te perguntar uma coisa. – Karine passava as pontas dos dedos pelo peito nu de Paul enquanto falava.
<p>- Pode perguntar.
<p>- Você já pensou em sair daqui? Sair de Darkey?
<p>- Não muito. Minha vida toda está aqui e eu até gosto da cidade. Por quê?
<p>- Joe me convidou para passar uns dias lá, disse que tem um quarto sobrando. Eu quero muito ir.
<p>- E deve mesmo. – Paul abriu um sorriso. – É uma grande oportunidade de conhecer coisas novas. Vai ser incrível para você.
<p>- Eu sei, é que... queria que você fosse também. Assim não teria muito pelo que voltar.
<p>- Está dizendo que pensa em voltar por mim? – Seu sorriso ficou maior.
<p>- Claro, seu bobo. 
<p>- Talvez eu vá com você então. Assim não precisaríamos mais nos esconder.
<p>- Ah, mas fazer tudo escondido é a melhor parte. – Karine riu.
<p>- É, eu tenho que concordar com você. – Ele a beijou. – Acho que você vai me fazer chegar atrasado no trabalho. 
<p>- Você não pode dizer para o Barry que estava dando uma lição em alguém por fazer coisa errada? Porque eu posso ser esse alguém.
<p>- É, você consegue ser uma garota bem má quando quer. – Ele desceu os beijos para o pescoço. – Parece até o diabo. 
<p>- É, eu pareço mesmo.</p>
<center><h4>--*--</h4></center>
<p>- Como isso aconteceu? – Joseph estava levantando as cadeiras e colocando elas em cima das mesas com os pés virados para cima. 
<p>- Bom, você disse “quer que eu te ajude a fechar o bar?” e eu disse “sim”. – Lori estava do outro lado passando um pano com álcool em cima do balcão.
<p>- Você entendeu. Esse bar. Eu ainda não entendo.
<p>- Eu era garçonete daqui. Quando o bar faliu, meu pai mexeu os pauzinhos e...
<p>- Comprou para você.
<p>- Acho que foi uma das muitas tentativas dele de me fazer ficar por aqui. – Ela sorriu.
<p>- Mal sabia ele que não precisava de muito. – Joseph foi até ela e se sentou em cima do balcão.
<p>- Eu estava limpando. 
<p>- Calma. Vem aqui. – Ele bateu na madeira do balcão no espaço ao lado dele. 
<p>Lori precisou de ajuda para subir. Os dois ficaram sentados em silêncio por alguns minutos e encararam o bar vazio.
<p>- Sabe, dançar aquela música... eu não fazia aquilo há muito tempo. Geralmente eu só vou em bares para me embebedar.
<p>- Eu também. Eu nem tinha certeza se ainda sabia os passos. – Lori riu.
<p>- Eu sei, mas de repente... assim que a gente começou, simplesmente veio.
<p>- Simplesmente veio. – Ela concordou. 
<p>- Eu me senti como se... como se fosse 2009 de novo. – Joseph a encarou. Ele ainda conseguia ver a mesma garota de 2009 ali. 
<p>- Isso é tão errado. – Lori desceu do balcão e ficou de frente para Joseph.
<p>- Não estamos fazendo nada de errado. – Ele deu de ombros.
<p>- Estamos sim. Não deveria estar aqui. Já é quase duas da manhã. Você deveria estar na casa dos seus pais dormindo com a sua esposa e pensando no seu filho.
<p>- Eu estou aqui ajudando uma amiga.
<p>- Não somos amigos. 
<p>- Nossa.
<p>- Não, eu não estou falando isso para bancar a chata nem para você ficar com raiva, eu estou dizendo porque... não somos mesmo. Você sabe disso. Enquanto a gente dançava, tudo o que eu queria era pular nos seus braços, te beijar e dizer que nunca deixei de te amar. 
<p>- Lori...
<p>- Daqui alguns dias, você vai embora e eu vou poder voltar a fingir que você não existiu, mas até lá... 
<p>- Eu entendi. – Joseph desceu do balcão também. – E você tem razão. Acho melhor eu ir embora.
<p>- Também acho melhor. – Lori respirou fundo.
<p>Joseph foi em direção a porta, pensou em se virar e dizer para aquela mulher que também queria beijá-la, também queria dizer que ainda a amava, mas não podia. Ao invés disso, abriu a porta e saiu.</p>
<center><h4>--*--</h4></center>
<p>- Kar! Karine! Cheguei em casa!
<p>Lori trancou a porta e acendeu as luzes da sala. A casa estava silenciosa. Karine não era de dormir tão cedo. Ela deveria estar descendo as escadas naquele momento fazendo drama por estar em casa ainda sendo duas da manhã. As duas haviam feito um trato. Karine tinha que chegar em casa pelo menos cinco minutos antes de Lori.
<p>- Kar! Não adianta tentar me ignorar. – Lori subiu as escadas. – Ainda tem pipoca. Quero passar a noite toda assistindo filme meloso, o que você acha? Eu estou na pior. Kar!
<p>A porta do quarto de Karine estava só encostada, porém a grande janela estava aberta. A madrugada trazia vento e as cortinas estavam quase todas para fora de casa. O cômodo estava vazio. A cama estava bagunçada. 
<p>- Cadê você, garota? – Lori pegou o celular do seu bolso e discou o número de Karine. O celular em cima do criado mudo começou a vibrar. – Ah, mais que ótimo. Vou passar a noite toda atrás dessa garota. – Ela bufou.
<p>Foi até o criado mudo pegar o celular, porém se distraiu com outra coisa. Havia um pequeno papel ao lado do aparelho. A caligrafia estava um pouco ruim, como se Karine estivesse escrito com pressa. 
<p>- O que é isso?
<p>Lori leu as duas primeiras linhas e depois se assustou quando seu celular começou a vibrar na palma de sua mão.
<p>- Ah, pai? Está tarde. O que foi?
<p>- <i>Filha, eu estou mandando uma viatura até a sua casa.</i> – Barry estava preocupado. – <i>Vão te levar até a delegacia. Eu te encontro lá.</i>
<p>- Pai, o que aconteceu? – Lori continuou lendo as outras palavras daquele bilhete.
<p>- <i>Filha, encontraram a Karine na floresta.</i>
<p>- Ela está bem? Está bêbada?
<p>- <i>Vem até aqui e a gente conversa.</i>
<p>- Pai... – Lori ouviu o barulho da sirene da viatura se aproximando. – O que aconteceu?
<p>- <i>Filha, ela se enforcou.</i> – Barry fez uma pausa. – <i>Lori, ela está morta.</i></p>
</body></html>";
            }
        }

        public void clkAbrirComentar(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new EsseMundoView.MyPopupPage("NoEscuro", condicao.ToString()));
        }

        public void clkIrMenu(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MenusView.MenuNoEscuroPage());
        }

        public void clkAbrirProximo(object sender, EventArgs e)
        {
            if (condicao + 1 > 5)
            {
                DisplayAlert("CAPÍTULOS!", "VOCÊ CHEGOU NO ÚLTIMO CAPÍTULO. CONFIRA OUTRA HISTÓRIA", "OK");
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
                    Historia = "NoEscuro"
                }, UserLocalData.userUID, "NoEscuro", "Capitulo" + capitulo);
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
                await DisplayAlert("AVISO!", "NÃO CONSEGUIMOS CARREGAR INFORMAÇÕES ADICIONAIS! VERIFIQUE SUA CONEXÃO COM A INTERNET", "OK");
            }
        }
    }
}