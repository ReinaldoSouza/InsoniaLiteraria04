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

namespace InsoniaLiteraria04.SegredosDistantesView
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
            mostrarCapituloSalvo("SegDistantes", "Capitulo" + numero.ToString());

            if (numero == 1)
            {
                lblTitulo.Text = "Capítulo 1 - Decepção";
                htmlPage.Html = @"<html><body>
<p>Jason já estava com dor de cabeça de tanto andar pela rua naquele sol quente que só a Califórnia tinha. Até já se sentia mais bronzeado. Ele conhecia aquelas ruas como a palma de sua mão, o desanimo tomava conta, a raiva também. Cansado, essa era a palavra que o definia.
<p>- Como foram as coisas hoje?
<p>Lisa estava sentada no minúsculo sofá que ficava na sala-cozinha daquele apartamento alugado quando Jason abriu a porta respirando bem pesado e com a camisa molhada de suor.
<p>- Péssimas. Eu recebi tanto “não” hoje que já não sei mais se a palavra “sim” existe. – Jason sentou no chão ao lado de Lisa.
<p>- Relaxa, eu ainda tenho dinheiro do meu último estágio. – Lisa tentou acalmá-lo passando a mão na cabeça molhada dele.
<p>- Eu também tenho, o restaurante pagou tudo direito, mas uma hora vai acabar. 
<p>- Sobrevivemos por bastante tempo, vamos sobreviver por mais.
<p>- Principalmente com uma publicitária formada na família. – Jason deu um empurrão em Lisa para comemorar. 
<p>- Ou como uma futura garçonete no restaurante do Centro. – Lisa falou desanimada.
<p>Jason havia dado para Lisa a ideia de morarem juntos dois anos antes dela se formar. Estava cansado de encarar o pai todo santo dia e ouvir o quanto era um fracassado, não bastava ele só pensar nisso. De qualquer maneira, ele passava mais tempo dormindo no sofá do dormitório dela na faculdade, então achou que seria melhor se formalizassem aquilo. Os dois estavam em São Francisco, longe da família e recém desempregados. 
<p>- Você não vai ser uma garçonete. Eles pagam pouco e você tem um diploma. 
<p>- Obrigada pelo apoio, mas já estou quase desistindo e rasgando meu diploma.
<p>- Nossa, que revolta. Esse papel é meu, esqueceu? Esse apartamento não aguentaria dois. – Jason começou a rir. 
<p>- Tem razão. Vamos sair para comer com o dinheiro que nos resta? Podemos gastar tudo hoje.
<p>- Claro, para que economizar se você não tem dinheiro?
<p>- Exatamente.
<p>- Eu só vou tomar um banho e a gente vai. Eu estou todo grudento e fedendo. Andei no sol o dia todo. – Jason cheirou a camisa suada e enrugou o nariz.
<p>- Eu não ia falar nada, mas já que você disse... Não vou discordar. – Lisa fez uma careta e começou a rir.
<p>- Engraçadinha. – Jason se levantou do chão e foi para o banheiro.</p> 
<center><h4>--*--</h4></center>
<p>Jason e Lisa tinham uma cozinha, mas quase nunca era usada. Eles não gastavam dinheiro com roupas nem com aparelhos tecnologicamente novos, gastavam comendo. Perto do apartamento, que ficava no centro, havia um restaurante que eles conheciam o cardápio de cor. 
<p>Naquela noite, como na maioria das noites, os dois sentaram na mesa perto da janela que sempre sentavam, e começaram a observar as pessoas que passavam na rua do lado de fora. Jason comia um hambúrguer, sim, esse era o seu jantar de cada dia, enquanto Lisa comia seu frango à parmegiana que ela adorava. 
<p>- Sabe, uma amiga minha da faculdade conseguiu um emprego em Miami. Ela está fazendo anúncios sobre moda e essas coisas. – Lisa sempre falava das amigas, mas Jason nunca via ela se comunicando com nenhuma delas por telefone ou por qualquer outra coisa. Às vezes ele pensava em perguntar como ela sabia, mas preferia ir pelo outro caminho. Lisa sempre mencionava elas com um tom de amargura. 
<p>- Você vai conseguir algo, só tenha paciência. 
<p>- Talvez eu devesse tentar em outro lugar. Talvez voltar para Los Angeles.
<p>- Se você quiser, a gente volta. – Jason limpava o molho que ficava ao redor da boca com as costas da mão livre. 
<p>- Mas você gosta daqui. E em Los Angeles tem seu pai ridículo. 
<p>- É, mas... podemos dar um jeito. Eu nem gosto tanto daqui.
<p>- Deixa para lá. 
<p>Lisa ficou em silêncio e voltou a focar no seu frango até Jason assustá-la balançando o seu braço que segurava a faca.
<p>- O que foi? – Ela franziu a testa.
<p>- Lisa, aquele cara sentado a duas mesas na nossa frente não é aquele publicitário que fez uma palestra na sua faculdade que você voltou toda animada e cheia de panfletos? Lembro que vi o rosto dele espalhado pelos cômodos durante umas três semanas.
<p>- Quem? – Ela se virou disfarçadamente e assim que o viu, arregalou os olhos. – É ele mesmo, Scott Goder. O cara é um gênio. Um grande empreendedor de publicidade. Tudo o que ele toca vende. 
<p>- Nossa, ele podia tocar naquelas porcarias que eu coloquei no Ebay já faz tempo, quem sabe assim venderia. – Jason falava de boca cheia.
<p>- Palhaço. É sério. Eu li em um site que ele vai abrir outra empresa na Flórida. 
<p>- Sério? Deve estar contratando então. Por que você não vai falar com ele?
<p>- O quê? – Lisa se assustou com a ideia e até engasgou. – Claro que não.
<p>- Por que não?
<p>- Eu não posso abordar um cara multimilionário para pedir emprego no meio do jantar. É loucura.
<p>- Não. Isso se chama entusiasmo e... determinação.
<p>- Você acabou de inventar isso.
<p>- Vamos. O que você tem a perder?
<p>- Sei lá, ele pode acabar com a minha carreira.
<p>- Qual? Você ainda precisa de uma carreira para ele acabar. 
<p>- Grosso.
<p>- Eu estou falando. Você só tem a ganhar. Vamos.
<p>Jason limpou sua boca com o guardanapo e se levantou da mesa.
<p>- Jason, não. – Lisa sussurrou.
<p>- Medrosa. – Enquanto ele estufava o peito todo animado.
<p>Lisa ficou esperando apreensiva enquanto Jason ia até Scott e, para a sua surpresa, se sentava na mesa dele. Os dois ficaram alguns minutos conversando, até riram. Ela observou o homem tirar uma caneta do bolso e escrever algo em um guardanapo que depois foi entregue a Jason. Ele, por sua vez, apertou a mão de Scott sorrindo, voltou para a mesa e se sentou na frente de Lisa.
<p>- Me diz quem é o seu melhor amigo que te conseguiu uma entrevista com Scott Goder? – Jason sorriu e apontou os dois dedões para ele mesmo.
<p>- O que? Como você fez isso? – Lisa arregalou os olhos novamente.
<p>- Eu sou uma pessoa esforçada e muito carismática. – Ele entregou o guardanapo para Lisa. – Palavras dele, não minhas.
<p>- Você conseguiu uma entrevista para mim e não consegue nenhuma para você? – Lisa viu que no guardanapo tinha um endereço e um horário.
<p>- Eu me esforço mais quando é para outras pessoas.
<p>- Sei.
<p>- Na verdade, eu não consigo disfarçar a minha cara de insatisfação quando dizem que vou precisar cuidar de plantas ou cachorros para conseguir uma grana. 
<p>- Você é ridículo. 
<p>- Não deveria me agradecer assim, só estou falando.</p>
<center><h4>--*--</h4></center>
<p>Lisa passou a manhã toda nervosa. 
<p>Ela iria fazer uma entrevista com um dos maiores empreendedores do país em algumas horas. Jason a levaria até o edifício onde seria o encontro, ela não conhecia muitos lugares por ali. Lisa trocou de roupa umas dez vezes e Jason revirava os olhos sempre que ela pedia a opinião dele sobre o seu visual. 
<p>O prédio era bem chique. O nível de elegância era bem alto. Lisa até se estremeceu quando a porta de entrada automática se abriu.
<p>- Quer relaxar? Vai dar tudo certo. – Jason pegou na mão da amiga para tentar dar um apoio.
<p>Ele se adiantou e foi até um balcão que ficava logo no hall do prédio. Várias moças bem arrumadas estavam do outro lado mexendo no computador, falando ao telefone e coisas desse tipo. 
<p>- Por favor, eu queria uma informação. – Jason olhou para uma garota loira que parecia ter a sua idade.
<p>- Pois não?
<p>- Bom, é que minha amiga marcou uma entrevista com Scott Goder às duas da tarde, eu queria saber se... – Por um segundo, Jason sentiu que havia sido enganado e que não teria entrevista nenhuma.
<p>- Ah, sim, a secretaria dele me avisou das entrevistas. – A moça fez uma pausa e voltou sua atenção para o monitor do computador. – Vocês podem subir até o décimo quinto andar. Ele está esperando por vocês. – A voz dela era calma, delicada. 
<p>- Ah, não. Só minha amiga vai fazer a entrevista. O nome dela é Lisa.
<p>- Bom, aqui está dizendo que ele está esperando por duas pessoas. – A moça franziu a testa. – Lisa e Jason. Você é o Jason?
<p>- Sou, mas... Eu não posso fazer uma entrevista agora. Eu não estou pronto, eu não...
<p>Jason se olhou. Ele estava com uma calça jeans surrada, um tênis encardido que não tinha nem mais cadarço e usava uma de suas famosas camisas listradas.
<p>- Eu não sirvo para publicidade, eu só... – Ele respirou fundo. – Eu nem... tenho diploma.</p> 
<center><h4>--*--</h4></center>
<p>Jason e Lisa ficaram em silêncio no elevador. 
<p>- Boa sorte. – Lisa mal conseguiu falar de tanto nervoso, suas mãos tremiam.
<p>- Eu não tenho a menor chance. Vai por mim. Ele deve ter gostado do meu sorriso. Essa é a única explicação.
<p>- Bom saber. – Lisa tentou sorrir. – Penteia o cabelo. 
<p>- Ele está penteado.
<p>- Não, não está. Você deveria ter feito a barba também.
<p>- Eu deveria se soubesse que ia fazer uma entrevista em um lugar onde uma caneta vale mais que o meu guarda-roupa inteiro.
<p>Jason passou a mão pelos cabelos, mas não adiantou muita coisa. A porta do elevador se abriu, e se o hall do prédio era chique, aquele andar era dez mil vezes mais. 
<p>Eles ficaram alguns minutos em silêncio sentados em um sofá de frente com a mesa da secretária, uma mulher ruiva de trinta e poucos anos. O sofá era muito confortável, não chegava nem perto do sofá que eles tinham no apartamento, na verdade, aquilo nem poderia mais ser chamado de sofá depois daquele dia. 
<p>Jason foi chamado primeiro. Ele respirou fundo, ficou alguns segundos grudado no sofá e depois se levantou um pouco nervoso. Ele não estava mesmo preparado para aquilo. 
<p>Lisa apertava suas mãos uma na outra esperando Jason sair daquela sala que a assustava. Aquela espera parecia uma eternidade. O que eles estavam conversando? Teria algum teste? Alguma coisa que ela não havia se preparado? Droga, eu não vou conseguir, pensou ela.
<p>Jason saiu da sala quarenta minutos depois respirando bem mais leve e bastante aliviado.
<p>- O que ele falou para você? – Lisa cochichou quando ele sentou ao seu lado no sofá.
<p>- Ele me deu um teste, bem difícil por sinal, e perguntou coisas pessoais. Onde eu me vejo daqui cinco anos, meus planos, sonhos e essas coisas, você vai se dar bem.
<p>- Mas...
<p>- A senhorita Lisa já pode entrar. – A secretária falou.
<p>Lisa arregalou os olhos de nervoso, se levantou do sofá e entrou na sala.</p> 
<center><h4>--*--</h4></center>
<p>Quando Jason saiu do banho naquela noite, Lisa estava com o telefone grudado na orelha e com uma expressão no rosto bem apreensiva andando de um lado para o outro pela sala.
<p>Demorou um pouco para ele perceber que a garota falava com alguém do escritório de Scott. Ele se surpreendeu, não esperava que a ligação fosse chegar tão rápido daquele jeito.
<p>- Então? – Jason parou na frente de Lisa e a encarou assim que ela desligou o telefone.
<p>Suspense. 
<p>- EU PASSEI! – Ela deu um grito e começou a pular. – Eu só preciso ir lá amanhã entregar uns documentos. EU NEM ACREDITO! AI, MEU DEUS!
<p>- Incrível. Eu disse que você ia passar. – Jason começou a bater palmas.
<p>- É, você disse. – Ela o abraçou bem forte. – Eu sinto muito, disseram que você não conseguiu.
<p>- Ah, tudo bem, eu já esperava. Acho que ele só me chamou por consideração, eu fui péssimo. – Jason não ficou menos triste com aquela notícia. – Não importa, vamos focar na sua boa notícia. 
<p>- Você vai conseguir arrumar outro. Eu sei disso. – Lisa não conseguia esconder o seu tom de voz piedoso. 
<p>- É, na Flórida vai ter novas oportunidades. – Jason concordou.
<p>- Na Flórida?
<p>- É, o seu emprego não vai ser lá?
<p>- É, mas eu não achei que você iria querer ir para lá também.
<p>- Por que eu não iria? É a Flórida, eu sempre quis ir para Disney a pé.
<p>- Você é muito idiota. – Ela começou a rir.</p>
<center><h4>--*--</h4></center>
<p>Lisa havia acordado bem cedo para organizar os seus documentos e saiu de casa antes mesmo de Jason acordar. 
<p>Ele resolveu tomar café sozinho então, não sabia que horas ela voltaria nem se iria querer comer alguma coisa. Lisa perdia a fome quando ficava ansiosa por alguma coisa. O restaurante não estava com muito movimento naquela manhã. Jason pegou seu hambúrguer como de costume, seu jantar também era seu café da manhã, e se sentou na sua mesa, dessa vez, sozinho. 
<p>- Jason?
<p>Ele quase se engasgou com a carne quando viu Scott Goder na sua frente.
<p>- Ah... senhor Scott? – Jason limpou a boca rapidamente com o guardanapo. – Senta aí.
<p>- Tomando seu café da manhã, é? – Ele se sentou rindo.
<p>- Bem saudável, não é? Esse é o meu jeito de cuidar da minha vida. – Jason riu também, um pouco envergonhado. – Quer comer alguma coisa? Eu pago.
<p>- Bom...
<p>- Eu acabei de dizer que pagaria algo para um multimilionário. Pensando bem, você que deveria pagar o meu café e o meu aluguel.
<p>- Bom saber que você acorda de bom humor. 
<p>- Bom, nem sempre é assim, então quando o bom humor aparece, eu preciso usar ele até não conseguir mais, já que não sei quando vai aparecer de novo. – Ele deu de ombros. – Você vem sempre nesse restaurante aqui? Achei que ricos comiam em lugares mais chiques. 
<p>- Bom, para ser sincero, vim ver se te encontrava. Me disse outro dia que você praticamente vivia aqui.
<p>- Então quer falar comigo? – Jason ficou ainda mais confuso. 
<p>- Quero. – Scott fez uma pausa. – Então você arranjou um emprego.
<p>- O quê? Ah, ainda não, mas eu vou continuar procurando. E se você quer saber, Lisa ficou muito feliz por ter sido escolhida, está indo para a empresa agora mesmo preencher a papelada. Aposto que nem dormiu à noite. 
<p>- E por que você não quis ir?
<p>- Como assim? Ela saiu bem cedo, eu nem tinha acordado ainda e para que eu vou acompanhá-la nessas coisas? Ela já é bem grandinha. 
<p>- Não, não isso. Por que não aceitou o emprego? – Scott parecia bem curioso. Talvez ele não tivesse dormido à noite.
<p>- Mas... – Jason não estava entendendo nada. – Eu não...
<p>- Houve algum engano? Porque a minha secretária disse que você recusou a proposta, o que é uma pena porque eu gostei muito de você.
<p>- Gostou, é?
<p>- É claro. Você tem visão, pode não ser para publicidade, mas... adoraria te ter na minha empresa. Quando você começou a falar de robôs e códigos e tudo mais...
<p>- Ah, é que... – Jason não sabia muito bem o que dizer. Na verdade, ele nem sabia o que estava acontecendo. – Bom, ficar sentado em um escritório não é bem a minha praia, terno e gravata, não, mas eu fiquei feliz pela consideração e por pensar em mim desse jeito. Eu nem ia fazer a entrevista na verdade, eu fiz só por... 
<p>- Tem certeza disso? Eu só vim falar com você pessoalmente porque não quero cometa um erro. Você disse que ainda não tem emprego, disse na entrevista que precisava encontrar seu rumo. Eu posso te dar o emprego e o rumo. Tem certeza que não quer?
<p>- Ah, eu... – Jason engoliu em seco. – Eu tenho sim, mas você vai ficar muito satisfeito com a Lisa na Flórida, ela é incrível. Tudo que ela sabe fui eu que ensinei. – Ele riu logo em seguida para disfarçar o desconforto.
<p>- Espero que sim. Eu não costumo errar. – Scott se levantou. – Ainda tem meu telefone. Qualquer coisa, é só ligar.
<p>- Porque você não costuma errar.
<p>- Exatamente.</p>
<center><h4>--*--</h4></center>
<p>Jason não foi para casa depois do café da manhã e muito menos depois do almoço. Não estava procurando emprego, mas também não queria voltar para casa. Ele odiava aquela sensação, era como estar em Los Angeles de novo. Ficar na rua para não ter que estar na mesma presença que seus pais, ele odiava pensar na amiga daquele jeito.
<p>Lisa já estava guardando suas roupas em malas quando Jason chegou bem depois do horário do jantar. Ela ficou tão ocupada e agitada o dia todo que nem sentiu a falta do amigo. Embora não dissesse, ela também precisava de um tempo.
<p>- Já está arrumando as coisas?
<p>- É. – Ela falou ofegante. – Eu começo a trabalhar em alguns dias, mas querem que eu vá logo para já ir me adequando ao lugar. Disse que poderia ir amanhã mesmo. 
<p>- Que bom. – Jason estava sem expressão.
<p>- É loucura, eu sei. Deveríamos ir primeiro sem nada para arrumar um lugar para ficar e tal, mas... eu não quero voltar aqui depois, por isso... Já fizemos coisas piores. – Jason não se manifestou. – Vai, arruma suas coisas também, vamos sair bem cedo ou já desistiu de ir? Ainda preciso comprar as passagens, pode fazer isso para mim? Fiquei tão atolada o dia todo, que eu acabei esquecendo... ah, eu preciso ligar para o senhorio também e...
<p>Lisa andava de um lado para o outro, entrava e saia do quarto. Jason se encostou na pia da cozinha e observou aquele cenário por alguns minutos em silêncio até que...
<p>- Você quer que eu desista?
<p>- Como assim? – Lisa não deu muita importância para o comentário.
<p>- Você quer que eu desista?
<p>- Eu não entendi. Desista de que? Jason, você está estranho. Onde esteve o dia todo? – Ela parou de dobrar as roupas e se virou para o amigo.
<p>- Você mentiu para mim. Mentiu para eles também. – Jason permanecia calmo.
<p>- Do que você...
<p>- Eu encontrei o Goder hoje lá no restaurante. Ele ficou chocado por eu ter recusado a vaga. Eu recusei a vaga.
<p>- O que você disse a ele? – Lisa o encarou com a boca um pouco trêmula.
<p>- Relaxa, eu não falei que você mentiu. Não disse que você recusou a vaga por mim. Eu simplesmente apoiei a mentira.
<p>- Jason...
<p>- Por que você fez isso?
<p>- Eu...
<p>- Por quê, Lisa? – Até Jason se surpreendeu com a sua calma. No caminho de volta, ele se imaginou gritando com a garota e arremessando coisas na parede por pura raiva.
<p>- Jason, olha, eu sinto muito, tá bom? É que...
<p>- É que o que? Qual é a sua desculpa? Não acha que eu seja bom para o emprego?
<p>- Não é isso.
<p>- Eu quero a verdade, Lisa. Desembucha. Eu vi a cara que você fez quando descobriu que eu também faria a entrevista. Eu vi a sua cara quando eu sai da sala do cara. Eu também vi a sua cara quando eu mencionei que haveria empregos na Flórida e você me perguntou se eu iria também. Eu não disse nada, mas... Eu vi. Então por favor, só me fala a verdade.
<p>Lisa ficou em silêncio. Precisou reunir toda a coragem que ela precisava. Já fazia um tempo que ela se sentia daquele jeito. Precisava falar. Finalmente.
<p>- Eu quero um espaço, Jason. Essa é a verdade.
<p>- O quê?
<p>- Você ficou do meu lado o tempo todo durante todos esses anos. Pela primeira vez na vida, eu queria fazer algo sozinha. Por favor, você precisa entender.
<p>- Eu não entendo. 
<p>- Jason...
<p>- Você mentiu para mim. Quer dizer que todo esse tempo que eu estive aqui, você só queria que eu fosse embora, é isso?
<p>- Não. Jason, eu te amo, mas...
<p>- Mas nada. Você me chamou para ir morar com você naquele cubículo de quarto na faculdade. Eu só... – Jason não conseguia mesmo entender o que estava acontecendo. 
<p>- Você reclamava dos seus pais o tempo todo. Eu tinha que fazer alguma coisa, você é meu melhor amigo, mas eu não achei que você ficaria por muito tempo.
<p>- Inacreditável. – Jason começou a andar pela cozinha impaciente e com a cabeça explodindo.
<p>- Jason, me desculpa. – Lisa tentou se aproximar, mas ele se afastou. – Olha, eu vou ligar para eles. Eu vou ligar e dizer que houve um engano e...
<p>- E o quê? Que eu sou bipolar e agora eu quero o emprego? E por que faria isso se só quer se livrar de mim?
<p>- Eu não quero me livrar de você. Jason, não exagera.
<p>- Está com pena de mim? Está se sentindo culpada?
<p>- Jason!
<p>- Bastava você falar comigo. Era só isso que eu queria. – Jason a encarar. – Acha que está sendo fácil para mim também? Acha que eu não me sinto um peso morto? Porém... eu pago a minha parte do aluguel e a minha comida e as minhas roupas. Você só se cansou de ficar perto de mim.
<p>- Não é verdade, eu só preciso...
<p>- De espaço, eu já ouvi. Você vai ter o seu espaço, Lisa. Na verdade, agora você vai ter a Flórida só para você. Já é o suficiente? Está satisfeita?
<p>Jason deu a meia volta, saiu do apartamento e bateu a porta bem forte. Ele tinha esse costume quando estava nervoso. Porém aquilo era uma evolução, ele nem socou uma das paredes nem jogou nada para o alto e muito menos gritou.</p>
<center><h4>--*--</h4></center>
<p>- <i>Alô?</i>
<p>- Tempe, sou eu.
<p>- <i>Jason, que horas são aí porque aqui é muito tarde e o fuso-horário nem é tão...</i>
<p>- São duas da manhã aqui. – Jason riu no telefone.
<p>- <i>Você ficou louco? Por que está me ligando a essa hora?</i>
<p>- Eu briguei com a Lisa. Queria falar com alguém, mas eu não posso ligar para Emily, seria estranho.
<p>- <i>Então eu sou a sua segunda opção?</i>
<p>- Sempre. 
<p>- <i>Idiota.</i> – Temperance riu. – <i>O que houve? Você está na cozinha enquanto ela está no quarto?</i>
<p>- Eu saí de casa. Eu estou sentado em um banco de uma praça agora, passando um frio do inferno, o que é contraditório já que no inferno deve ser calor. 
<p>- <i>Está em uma praça de madrugada? Você ficou louco? Vão te matar aí.</i>
<p>- Ninguém vai me assaltar. Eu tenho quase dois metros de altura e estou fazendo a minha cara de mal. Eles só não podem saber que eu morro de medo de armas, facas e que corro pouco. 
<p>- <i>Por que vocês brigaram? Espero que tenha me ligado para dizer.</i>
<p>- Ela mentiu para mim. Me enganou. 
<p>- <i>Não esperava menos. Olha, eu não vou conseguir ser imparcial.</i>
<p>- Ela pode até ter razão, sabia? Mas eu me senti como um encosto, como se ela estivesse estagnada por minha causa. 
<p>- <i>Cala a boca.</i>
<p>- Só que agora ela vai ter um emprego incrível e quer mudar. Não é errado. Mas a maneira como ela fez isso...
<p>- <i>Se acha que ela tem razão e aparentemente está se sentindo culpado, você pode ir para casa e pedir desculpas.</i>
<p>- Eu não vou pedir desculpas, eu não fiz nada de errado.
<p>- <i>Então pode ir para um hotel.</i>
<p>- Eu tenho pouco dinheiro. Tenho que guardar para emergências. Hotel é caro.
<p>- <i>Então vai fazer o quê? Morar na praça?</i>
<p>- Muita gente faz isso.
<p>- <i>Jason...</i> – Jason até conseguiu imaginar a cara de Temperance falando. 
<p>- O que eu faço, Tempe?
<p>- <i>Ela é sua amiga. Conversa com ela.</i> 
<p>- Ela mentiu para mim.
<p>- <i>Sei onde quer chegar. Mas eu briguei com o Brandon por isso e ele se matou.</i>
<p>- Eu sei que a Lisa não vai se matar. Talvez eu a mate se voltar lá. 
<p>- <i>Você está com raiva, é normal. Mas ela é a sua melhor amiga. Essa briga vale a pena?</i>
<p>- Ela era a única pessoa que eu achei que nunca mentiria para mim, que nunca me decepcionaria, mas parece que eu me enganei. E eu não sei se quero esquecer isso, nem se eu consigo.
<p>- <i>E o que vai fazer?</i>
<p>- Você deveria dizer isso para mim. Foi para isso que eu liguei.
<p>- <i>Teve mentiras, então a melhor coisa que você tem que fazer é chegar nela e dizer a verdade, o que está realmente sentindo e esperar que ela faça o mesmo.</i>
<p>- Eu devo acreditar nela?
<p>- <i>Nem imagino. A amiga é sua.</i>
<p>- Valeu, Tempe. Sempre muito útil.
<p>- <i>Disponha. E Jason, você não é um encosto, pelo menos não o tempo todo.</i>
<p>- Eu sei que não.</p> 
<center><h4>--*--</h4></center>
<p>- Jason.
<p>Lisa estava sentada no sofá esperando quando Jason chegou de manhã com os olhos vermelhos de sono e com uma cara ainda não muito boa.
<p>- Eu só vim aqui pegar minhas coisas. – Jason respondeu rudemente assim que Lisa se levantou para falar com ele.
<p>- Jason, não faz assim. Vamos conversar.
<p>Ele parou em frente a porta de seu quarto e ficou quieto encarando Lisa por alguns minutos.
<p>- Fala. Fale antes que eu comece a te xingar e gritar.
<p>- Jason, eu não fiz por mal. 
<p>- Tudo bem. Você quer um espaço, eu entendo isso. Eu só queria que tivesse me dito e não mentido para mim. 
<p>- O que você queria que eu dissesse?
<p>- “Sai daqui, Jason”, simples e rápido. – Jason não conseguia mais reconhecer a sua amiga ali.
<p>- Eu não podia. 
<p>- Quando começamos a morar juntos, eu percebi que você estava diferente. Eu achei que a morte do Cabelo Cabeludo ainda te afetava.
<p>- Aonde quer chegar? – Lisa até mudou de expressão. A morte de Brandon ainda a afetava, sim.
<p>- Eu me preocupei com você. Você mal saía de casa, eu achei que tinha me chamado para eu poder ficar do seu lado, para eu ser seu apoio e foi isso que eu sempre tentei ser para você, me desculpa se isso te incomodou em alguma hora ou pareceu que eu fiquei muito em cima, mas, droga, Lisa, você só precisa ter me falado. – Os olhos de Jason não estavam mais vermelhos só por causa do sono.
<p>- Jason...
<p>- Você é a minha melhor amiga. Nos conhecemos desde sempre, falamos sobre qualquer coisa. Como você quer que eu me sinta? 
<p>- Olha, eu quero mesmo resolver isso, mas você é impossível. – Lisa estava sem paciência. – É por isso que às vezes eu não te falo as coisas, porque sei como você reage.
<p>- Agora eu sou o culpado?
<p>- Não tem nenhum culpado aqui. 
<p>- Tem sim. Eu não fui seu amigo, eu fui um peso para você e tenho certeza que você se arrependeu de vir morar comigo no segundo que disse “sim”.
<p>- Tudo bem, agora você está fazendo drama demais, quer parar de agir feito criança pelo menos uma vez na vida? Que saco. 
<p>- Tudo bem.
<p>- Jay, eu preciso viver a minha vida e você precisa viver a sua. Isso é a coisa mais normal do mundo. Eu não sei por que você está fazendo tanto exagero por causa disso.
<p>- Não sabe? Amizade é confiança. Como eu vou acreditar agora em qualquer coisa que você disser? Como, Lisa? Me diz. Você diz que sente muito, mas sente mesmo? 
<p>- Jason, eu não mais brigar.
<p>- Relaxa, não vamos mais brigar. Como eu disse antes, eu só vim aqui pegar as minhas coisas. Eu vou voltar para Los Angeles hoje. Boa viagem até a Florida. 
<p>- E como ficamos?
<p>- Garanto que você não quer um amigo infantil. Então não ficamos.
<p>Jason virou as costas e entrou no quarto. Ele saiu logo, não tinha muita roupa para guardar. Ele não bateu a porta quando saiu. Simplesmente foi embora sem nem olhar para a cara de Lisa.</p>
</body></html>";
            }

            if (numero == 2)
            {
                lblTitulo.Text = "Capítulo 2 - Vida Nova";
                htmlPage.Html = @"<html><body>
<p>Emily estava comemorando naquele dia.
<p>Depois de quatro anos, estudando para caramba, passando noites em claro, trabalhando que nem uma condenada naquele escritório sendo estagiária da assistente da assistente, naquele dia ela acabara de ser promovida. Agora ela era assistente. Mas não uma simples assistente, uma executiva. 
<p>Quando ela entrou no escritório de manhã, recebeu uma salva de palmas e um cartão de “parabéns” estava em cima de sua mesa. Elton, um dos seus colegas de trabalho mais próximos desde o começo do estágio, havia convidado ela para um almoço de comemoração pela promoção, ela recusou esse convite assim como todos os convites que ele fez durante aqueles anos. 
<p>- O que você vai fazer essa tarde? – A mesa de Elton ficava em frente à mesa que Emily estava desocupando. Ela colocava as suas coisas em uma caixa de papelão decorada. Ia se mudar para dois andares a cima.
<p>- Eu vou sair para procurar um apartamento. Algum lugar para realmente chamar de lar. – Emily não parava de sorrir. – Agora eu vou ganhar mais então acho que posso alugar um apartamento melhor aqui em Manhathan e sair daquele buraco onde sinto que vão me assaltar a qualquer momento.
<p>- Se quiser, eu vou com você, posso te ajudar.
<p>- Ah, não precisa. Eu estou bem. 
<p>- Bom, quando finalmente arranjar a casa nova, me manda o endereço que eu levo uma pizza. Essa comemoração você não pode recusar. – Ele tentou de novo.
<p>- Pode ser. Eu vou pensar no seu caso.
<p>- Relaxa, eu não vou abusar de você.
<p>- Não vai mesmo. Eu não sou muito alta, mas bato bem forte. – Os dois riram.
<p>- Sabe, eu estou feliz por você, agora vai ser da elite. 
<p>- Logo, logo, eles te promovem também, não vai se formar esse ano?
<p>- Vou, mas não vou ser o primeiro da classe que nem você. 
<p>- Você chega lá. – Emily piscou para ele.  
<p>- Já contou para todo mundo da sua promoção? – Elton admirava Emily. Achava que não teria mais tantas oportunidades de conversar com ela no trabalho, então aproveitou cada segundo. Esqueceu sua caixa de e-mails e focou só nela. A garota dos seus sonhos.
<p>- Todo mundo já sabe. Quando eu cheguei de manhã, fui recebida com palmas pelo setor inteiro, você viu, estava aqui.
<p>- Eu estou falando dos outros que não estão em Nova York.
<p>- Eu vou ligar para a minha mãe à noite. Eu quase não tive tempo nem de respirar.
<p>- E quanto a outra pessoa?
<p>- Que outra pessoa?
<p>- Aquela que você está pensando agora e que está louca para ligar.
<p>Emily pensou em Jason e o quão eufórico ele ficaria quando soubesse da grande notícia. Ela realmente quis ligar para ele assim que ficou sabendo da promoção, mas havia um “porém”.
<p>- A gente não se fala há mais de um ano. 
<p>- Não quer dizer que não pense nele. Esse é o único motivo para não ficar comigo.
<p>- Não, existe vários outros motivos. O primeiro é: eu não estou interessada. – Emily sorriu.  
<p>- Adoro quando você me dá um fora.
<p>- Isso é ser masoquista. Deveria procurar um terapeuta.</p>
<center><h4>--*--</h4></center>
<p>O dia de Emily foi bem cheio.
<p>Sua nova mesa ficava ao lado da sala do diretor, isso já dizia alguma coisa. Trabalhou até as duas da tarde, depois saiu em busca de uma nova casa. Mesmo com um futuro salário maior, os alugueis dos apartamentos em Manhathan eram bem caros.
<p>- Bom, esse é o aluguel mais barato que você vai achar.
<p>Esse era o sétimo apartamento que Emily tinha visto naquela tarde. Ela, assim como a corretora, estava cansada. Sua animação já tinha se esvanecido fazia um tempo e estava quase desistindo e voltando para o seu apartamento pequeno e perigoso.
<p>- Bom, o lugar é ótimo, mas... mesmo assim ainda é muito caro para eu pagar. Talvez eu deva continuar no subúrbio. – Emily sorriu sem graça para a corretora.
<p>O apartamento era perfeito. Não era grande, mas também não era minúsculo. Décimo andar, bem iluminado e ventilado. Quarto, sala, cozinha, dois banheiros e ainda uma varanda com a vista para o Central Park. O que mais ela podia pedir?
<p>- Bom, a maioria das pessoas que moram por aqui procura um colega de quarto.
<p>- Vocês vendem isso também? – Emily se assustou.
<p>- Bom, eu posso segurar a oferta até amanhã, você pode pensar e...
<p>- Emprego novo, vida nova. – Ela falou baixinho. – Eu posso ir até a varanda?
<p>- Á vontade.
<p>Emily viu o céu e depois o parque. Se imaginou passando suas tardes de domingo sentada ali tomando uma xícara de café e olhando as pessoas passeando pelo parque. Se imaginou olhando as estrelas à noite. Quatro anos e nem ao menos conseguia viver daquele jeito. Tudo o que ela passou havia valido a pena? Às vezes ela parava para pensar se tudo aquilo era uma loucura. Deixar sua cidade, morar sozinha. 
<p>Ela ainda não tinha ganhado um grande feito. Havia sido promovida, ótimo, mas não foi sorte nem uma benção. Ela merecia aquilo depois de tudo, não era como se ela estivesse agradecida. Era o que ela esperava. Mas foram quatro anos. Demoraria mais quatro para ela ser promovida de novo? 
<p>- Tudo bem, eu pego. – Ela falou ainda da varanda. 
<p>- Tem certeza? – A corretora ficou um pouco surpresa.
<p>- Tenho. Alguma coisa me diz que vai dar tudo certo. 
<p>- Tudo bem, vou preparar o contrato. 
<p>- Ótimo. – Disse ela decidida.</p>
<center><h4>--*--</h4></center>
<p>Emily não tinha muito no outro apartamento. Só alguns móveis velhos deixados pelos outros donos. Ela passou a noite arrumando suas roupas em malas e algumas outras coisas pequenas em caixas, o resto ela ia deixar. No sábado de manhã, já estava no prédio subindo as suas coisas para o décimo andar com uma chave nova e brilhante no bolso.
<p>Vida nova, ela pensou. 
<p>A primeira coisa que fez quando chegou no escritório na segunda-feira de manhã foi anunciar por meio de um papel que ela pregou no quadro de avisos no hall do prédio que estava procurando por uma colega de quarto. 
<p>- E como foram as coisas? – Elton chegou perto da mesa de Emily com um bolinho. Ainda estava quente. 
<p>- Consegui um apartamento. – Emily estava ligando o computador e se preparando para finalmente trabalhar de verdade na sua nova posição. – Só preciso de um colega de quarto. Alguém para dividir o aluguel.
<p>- Bom, eu estou mesmo precisando me mudar. Meu apartamento é um lixo. – Elton sorriu.
<p>- Esse alguém não pode ser você. Não podemos morar juntos, eu sou péssima. Nossa amizade acabaria. 
<p>- Talvez não devesse dizer isso para os candidatos a colega de quarto.
<p>- Não, eu preciso de uma garota, e de preferência que saiba cozinhar. Eu estou cansada de comer comida congelada toda noite. – Emily ignorou o comentário “porque você quer” de Elton e continuou falando. – Talvez eu até me case com ela. 
<p>- Bom, já que você me deixou no escuro o final de semana todo... Deveríamos comemorar hoje a sua nova casa. Pizza à noite?
<p>- Não dá, eu mal dormi esse final de semana todo. Eu pintei o lugar todo e tive que comprar móveis novos e montá-los sozinha, não consegui pagar um montador nem um pintor.
<p>- De novo, devia ter me pedido ajuda. Eu sou ótimo em... ler o manual de instruções.
<p>- Obrigada, mas eu até gostei de fazer isso sozinha. Me senti mais independente, sei lá. Mas por outro lado, eu só estou pensando na minha cama agora. Chegar em casa, só quero um banho quente e uma longa noite de sono.
<p>- Você é uma garota difícil.
<p>- Muitos dizem isso. – Emily sorriu.
<p>- Bom, vou esperar então você me convidar. 
<p>- Pode demorar.
<p>- Eu não ligo. – Elton deixou o bolinho em cima da mesa e foi em direção ao elevador.</p>
<center><h4>--*--</h4></center>
<p>Emily abriu a porta, entrou no apartamento que ainda cheirava a tinta e respirou fundo. Vai dar certo, ela pensou, vai dar tudo certo. Ela se sentou no chão da sala vazia e ficou olhando para as paredes recém pintadas de azul. Havia comprado uma cama, um pequeno guarda-roupa, um armário minúsculo para a cozinha e uma mesa de dois lugares, ainda faltava um sofá.
<p>Pegou o celular do seu bolso. Ainda tinha o número. Será que ainda era o mesmo? Ela não falava com ele fazia tanto tempo, mas não podia ligar, não era certo. Não depois de tudo. Respira, Emily.
<p>Alguém bateu na porta.
<p>- Mas o quê...
<p>Emily se levantou um pouco surpresa e atendeu a porta.
<p>- Oi.
<p>Ela não esperava por aquele oi. Na verdade, ela não esperava por nenhuma palavra vindo daquela boca.
<p>- Jason? O que faz aqui? – Ela arregalou os olhos.
<p>- Ouvi dizer que precisa de um colega de quarto. – Ele sorriu e assim como se fosse automático, ela sorriu também.
<p>- Como sabe disso?
<p>- Fui até onde você trabalha e vi o panfleto. Eu preciso de uma entrevista?
<p>- Jason...
<p>- Olha, eu sou uma pessoa quase boa, não uso drogas embora as pessoas digam que eu pareço um drogado às vezes, não faço barulho, mentira, faço sim, não sou o mais organizado, pode ser que encontre roupa suja jogada no banheiro, mas você se acostuma. Eu sei cozinhar contanto que você só coma...
<p>- Macarrão?
<p>- Macarrão. Isso mesmo. 
<p>- Jason...
<p>- Pode tirar essa cara de assustada. Eu... só vou ficar por um dia.
<p>- Um dia? O que você... Jason, está tudo bem?
<p>- Eu estaria melhor se você me deixasse entrar.
<p>- Ah, claro. Entra. 
<p>Ela abriu espaço para ele entrar e se assustou quando viu todas aquelas malas que estavam atrás dele.
<p>- Olha só, adorei os móveis... – Jason fez uma piada. – ...Cor de parede. Ou são invisíveis? 
<p>- Engraçadinho. Por que trouxe tanta coisa? Disse que só ia ficar um dia. Isso é exagerado até para você.
<p>- Na verdade, eu trouxe todas as minhas coisas porque eu sou um sem teto agora. Deixei metade da minha grana no aeroporto. Não havia pensado nesse detalhe. Talvez eu doe todas as minhas roupas em algum lugar por aqui para não deixar a outra metade do meu dinheiro no aeroporto de novo.
<p>- O quê?
<p>- É uma longa história. – Ele ficou sério. 
<p>- Eu não tenho TV então me anime.
<p>- Posso te animar de outro jeito. – Jason sorriu.
<p>- Prefiro sua longa história. – Ela voltou a sorrir também.</p>
<center><h4>--*--</h4></center>
<p>- Bom, eu tenho dois iogurtes, dois cupcakes e uma maçã. 
<p>Emily colocou tudo no chão da sala onde Jason estava sentado e se sentou junto dele.
<p>- Tudo bem, e o que você vai comer? – Jason pegou os dois bolinhos.
<p>- A maçã aparentemente. 
<p>- Muito saudável da sua parte. – Jason mordeu um pedaço de um dos bolinhos e depois entregou ele a Emily. – Eu não estou com fome. 
<p>- Então a coisa é séria mesmo. – Ela pegou o bolinho da mão dele. 
<p>- Eu briguei com a Lisa. Acho que foi mais do que brigar. Eu não sei.
<p>- O quê? Por quê? – Emily franziu a testa.
<p>- Ela mentiu para mim. Então eu saí de casa.
<p>- No que ela mentiu? Foi grave? Eu sei que você sabe ser dramático. Quando vão fazer as pazes?
<p>- Eu acho que não quero mais. 
<p>- Então foi sério mesmo. – Emily olhou para Jason e ele não conseguiu encará-la.
<p>- Estávamos morando juntos, mas parece que não era o que ela queria e não sabia como me mandar embora. Preferiu colocar a culpa em mim e me chamar de infantil. Não sabia como se livrar do peso.
<p>- Teve xingamento?
<p>- Quase, mas eu me segurei. Você deveria ficar orgulhosa.
<p>- Jason, ela é a sua melhor amiga. 
<p>- É desculpa para alguma coisa?
<p>- Eu queria que fosse, mas não. – Emily também estava séria. – Eu sinto muito. Sei o quanto ela é importante para você.
<p>- É um saco.
<p>- É um saco. – Ela repetiu.
<p>- E quanto a você? O que eu perdi?
<p>- Bom... nada.
<p>- Como nada? Dá última vez que eu te vi, você estava no Bronx. Agora está em Manhathan. 
<p>- Fui promovida.
<p>- É sério? – Jason abriu um sorriso e começou a bater palmas. – E eu aqui falando de mim? Devíamos estar comemorando. 
<p>E foi exatamente assim que ela imaginou que seria quando ele soubesse.
<p>- Você merece, sabia? É a pessoa mais inteligente e talentosa que eu já conheci.
<p>- Só diz isso porque tem que dizer.
<p>- Por que eu teria que dizer? Não somos namorados nem nada. Tudo o que eu digo é verdade, não é só para te agradar como nos velhos tempos.
<p>- Nos velhos tempos.
<p>- Você não está...
<p>- Não! – Ela quase gritou. 
<p>Emily sabia que uma hora ou outra Jason ia perguntar. Eles sempre faziam isso. Esperavam a melhor hora para perguntar um para o outro toda vez que se encontravam, mas nunca era a melhor hora.
<p>- Nem com aquele cara do escritório?
<p>- Como conhece...
<p>- Eu disse que fui até onde você trabalha. Encontrei com ele e foi ele que me disse que você já tinha ido embora. Os olhos dele brilharam quando falou de você e eu senti um pouco de ciúme quando ele me viu. 
<p>- Ele é só um colega. E quanto a você? California está cheia de garotas.
<p>- Nenhuma delas é você.
<p>- Jason... – Emily desviou o olhar.
<p>- Eu não ia vir, tá legal? A gente não se fala há tanto tempo e...
<p>- Por que veio?
<p>- Bom...
<p>Jason encarou Emily e se aproximou um pouco mais.
<p>- Eu... eu preciso ir dormir. – Emily se levantou. 
<p>- O quê? – Ele se assustou com a reação da garota.
<p>- Amanhã eu acordo cedo. – Ela rodeou a casa com o olhar. – Eu vou procurar algo para você dormir e...
<p>- Não precisa. Eu durmo aqui no chão mesmo. Não me importo. 
<p>- Tá bom. Boa noite. – Ela se despediu e correu para o quarto antes mesmo dele responder.
<p>- Boa noite.</p>
<center><h4>--*--</h4></center>
<p>Jason estava deitado no chão. Eram quase cinco da manhã e ele ainda estava olhando para o teto. Conseguia ouvir os pássaros já cantando do lado de fora e a luz do sol queria entrar pela janela. 
<p>Ele se levantou. Suas costas doíam de deitar no chão duro. Se espreguiçou do sono que não teve e foi até a varanda. O vento frio bateu em seu rosto e ele tentou relaxar. Tentou se imaginar em um lugar feliz. Deveria ser aquele lugar. 
<p>- Já levantou? – Emily estava parada ao lado da porta de vidro que separava a sala da varanda, ainda de pijama.
<p>- Eu nem dormi, na verdade. – Ele respondeu sem olhar para ela.
<p>- Nem eu. O que você faz aqui, Jason? – Emily foi até ele. – Eu não quero ser mal-educada nem nada, mas eu preciso saber.
<p>- Eu queria... eu sinto sua falta. De pelo menos conversar com você.
<p>- Eu...
<p>- Eu me sinto sozinho. Até mesmo quando eu estava com a Lisa. Eu me sinto sozinho. – Ele respirou fundo.
<p>- Você realmente acha que a Lisa está certa, não acha?
<p>- Eu sou um peso para qualquer um. 
<p>- Não é.
<p>- Agora é você que está dizendo coisas como se eu fosse seu namorado. – Ele sorriu para ela. – Emily, eu estou completamente perdido. Todo mundo seguiu com a vida e eu continuo o mesmo, parado no tempo.
<p>- Você não está parado no tempo. Jason, não consegue ver o problema aqui?
<p>- Claro que eu consigo, acabei de dizer.
<p>- Não. – Emily segurou na mão de Jason e o olhou nos olhos. – Você é uma pessoa incrível, e mesmo sendo o ridículo, você está lá para todo mundo que se aproxima de você. Você queria vir para Nova York por minha causa. Ficou e cuidou da Temperance. Depois que ela ficou boa, você foi cuidar da Lisa porque ela ainda não tinha superado a morte do Brandon e você precisava dar apoio a ela. Agora a Lisa foi embora e você está aqui.
<p>- Onde quer chegar?
<p>- Você pensou em si mesmo nesses últimos quatro anos? No que queria fazer, para onde queria ir.
<p>- Eu...
<p>- Talvez a Lisa ir embora não seja algo ruim. 
<p>- Eu não quero ficar sozinho. 
<p>- Eu sei, mas eu acho que ficar sozinho é o que você precisa agora. Parar e pensar em você. 
<p>- Pensar nas outras pessoas é mais fácil. É menos deprimente porque o problema não é comigo. 
<p>- Se você não pensar em você, quem vai pensar? Está na hora de você ser seu próprio herói. 
<p>- Eu te odeio por ter razão. – Jason sorriu. – E se eu não conseguir? E se eu pensar e pensar e ver que eu não sirvo para nada?
<p>- Isso não vai acontecer. 
<p>- Só diz isso porque tem que dizer.
<p>- Verdade. – Ela o beliscou. – Mas pode ficar aqui se quiser.
<p>- Acho melhor não. Mas ainda quero ficar um pouco com você até o sol nascer.
<p>Ele se aproximou de novo e a beijou. Dessa vez, ela não se afastou nem recusou. Retribuiu. 
<p>- Eu ainda te amo, sabia? E isso nunca vai mudar. – Ele segurou em ela em seus braços. 
<p>- Eu sei, eu também sinto o mesmo. – Ela ficou na ponta dos pés e o beijou na bochecha. – Agora eu preciso dormir. Tenho duas horas para fazer essa noite valer a pena. 
<p>- Posso fazer em uma.
<p>- Vai dormir. – Ela gritou enquanto passava pela porta de vidro e entrava na sala de estar.</p>
<center><h4>--*--</h4></center>
<p>- O que está fazendo? 
<p>Emily acordou com o barulho que Jason estava fazendo na cozinha.
<p>- Preparando o café da manhã. – Jason gritou. – Eu comprei algumas coisas para encher a sua geladeira. Você sabia que tem supermercado em Nova York, não sabia?
<p>- Cala a boca. Eu me mudei faz três dias.
<p>Emily se sentou em sua mesa e ficou observando Jason, sem camisa, e bem desastrado, fazendo seu café da manhã. Pelo menos, o cheiro estava bom.
<p>- Você vai fazer macarrão para o café da manhã, é? – Emily riu.
<p>- Eu faço um ótimo café da manhã, ou por acaso você esqueceu?
<p>- Não esqueci. Por que colocou o pão em cima da boca do fogão? – Ela franziu a testa. Além daquela anormalidade, ela reparou que ele passava manteiga nos pães com o dedo, o suco estava em uma pequena vasilha de plástico e o bolo parecia espatifado. Ele com certeza, havia tentado cortar ele com as mãos. 
<p>- Eu procurei por uma frigideira, talheres, copos, mas você não tem nada disso. Precisa fazer umas compras, sabia?
<p>- Eu vou fazer isso mais tarde.
<p>- Ótimo. Também precisa de algumas tigelas. Uma televisão... ao invés do sofá, podia comprar uma poltrona, é mais barato. 
<p>- Podia vir comigo fazer essas compras, o que você acha? Serviria para carregar as coisas pesadas.
<p>- Não dá. Eu vou embora assim que você sair. Preciso voltar para a vida real. – Ele respirou fundo. 
<p>- Ou você podia ficar aqui por uns dias. Já que não arranjou emprego lá, talvez arranje aqui, sei lá.
<p>- Você acha?
<p>- Eu não sei, foi só uma ideia. – Ela tentou desconversar. – Vamos comer? – Depois deu um sorriso para disfarçar o nervoso.
<p>- Ainda bem que eu comprei café pronto porque eu procurei por uma cafeteira aqui e também não tem.
<p>- Cala a boca.
<p>- Pelo menos tem uma mesa. Mas cadê a toalha de mesa, Emily?
<p>- Fica quieto, eu já disse que eu acabei de me mudar para essa droga. – Ela deu um tapa no ombro dele. Ela sempre fazia isso quando ele começava a implicar, quer dizer, o tempo todo. 
<p>- Está perdoada.
<p>Os dois tomaram um ótimo café da manhã. O bolo estava delicioso e o café também. E havia os pães. Fazia tempo que Emily não comia pães daquele jeito. Os dois conversaram, riram, estavam bem mais leves do que a noite passada. Incrível o que um “eu te amo” e duas horas bem dormidas faziam.
<p>Assim que terminaram o café, Jason juntou as coisas na pia. Procurou por um detergente e uma esponja, mas sem sucesso, começou então a lavar a louça só com água mesmo. Alguém bateu na porta minutos depois.
<p>- Tá aberta! – Jason gritou.
<p>- Você deixou a minha porta aberta? – Emily jogou um jato de água que vinha da torneira da pia, na cara dele.
<p>- O que é que tem?
<p>Elton entrou no apartamento segurando dois copos de café comprados, uma cesta de bolinhos e uma rosa.
<p>- Olha quem está aqui para comemorar... – Elton parou de falar assim que viu Jason na pia, ao lado de Emily.
<p>- Elton? – Emily não sabia muito bem o que dizer.
<p>- Olha só, bolinhos. – Jason olhou para Emily. – Parecem deliciosos.
<p>- Você. Conseguiu achá-la. – Elton estava com vergonha.
<p>- É. Eu consegui.
<p>- Elton, o que faz aqui? – Emily ficou muito constrangida. Foi até o colega agradecer pela visita e pelos presentes, mas não estava nada confortável com a situação.
<p>- Eu vim te fazer uma surpresa. Estamos combinando isso faz um tempo. 
<p>- Ah, não...
<p>- Na verdade, eu estava até pensando que poderíamos fazer umas compras depois do expediente. Comprar algumas coisas para casa, talheres, pratos, copos, essas coisas.
<p>- Ah...
<p>- Sabe, Elton John, você tem razão. Foi o que eu falei para ela. – Jason falou enquanto enxugava suas mãos na bermuda. – Acho que você arranjou o seu cara para carregar as caixas.
<p>- O quê? – Emily não entendeu.
<p>- Eu preciso mesmo ir. – Jason sorriu. Vestiu sua camisa que estava jogada no chão, ele provavelmente havia usado ela como travesseiro. Pegou suas mochilas que estavam encostadas em um canto da parede. – Bom dia para vocês. 
<p>E saiu do apartamento.
<p>- Ele parece ser legal. – Elton deu de ombros. – Gostou da flor? – Elton mostrou a rosa para Emily. Único presente que ela ainda não havia pegado.
<p>- É maravilhosa.
<p>Emily nem olhou para a rosa e saiu correndo atrás de Jason.
<p>- Jason, espera!
<p>Ele estava em frente ao elevador. O botão para descer estava aceso. Porém o painel mostrava que o elevador ainda estava no terceiro andar. 
<p>- Emily, volta para lá. – Jason se arrependeu profundamente de não ter ido pelas escadas.
<p>- O que houve? – Emily não estava entendendo nada. – Você sabe que eu não...
<p>- Mas ele quer.
<p>- Não me interessa. Isso não quer dizer nada.
<p>- Eu não devia ter vindo.
<p>- Ah é?
<p>- A gente estava se enganando lá dentro. O que a gente faz agora? Resolve morar junto? Isso é tão quatro anos atrás e você mesma disse ontem que...
<p>- Então o que veio fazer aqui, Jason? – Emily quase gritou. – Não foi para conversar nem para ficar na minha varanda.
<p>- Eu só achei que...
<p>- Você só veio aqui para matar a saudade? Para me fazer de trouxa? Que droga, Jason.
<p>- Isso não é verdade.
<p>- Então o que foi? 
<p>- Eu não posso ficar aqui, você sabe disso. E tem esse cara...
<p>- Esse cara não significa nada para mim. Para de usar ele como a sua desculpa.
<p>- Ele gosta de você e parece ser legal.
<p>- Eu não pedi a sua opinião e também não preciso da sua aprovação. Não é isso que eu quero que fale.
<p>- Olha...
<p>- Não, quer saber? Vai embora agora! E não volte nem se... por nada. Não volte por nada. Eu não quero mais ver a sua cara. 
<p>- Eu sinto muito.
<p>- Vai embora. Eu não sei porque eu ainda deixo você fazer isso.
<p>- E eu não sei porque ainda faço.
<p>A porta do elevador abriu. 
<p>- Eu sinto muito.
<p>- É bom mesmo que sinta. 
<p>Jason desapareceu de vista.</p>
<center><h4>--*--</h4></center>
<p>Elton percebeu que estava sobrando e saiu do apartamento assim que Emily voltou. Ele deixou a rosa em cima da pia que logo depois foi jogada no ralo por Emily.
<p>Sua cabeça estava explodindo. Dois minutos atrás estava tudo perfeito, como as coisas mudaram de repente? Ela nem percebeu nada. 
<p>- Com licença?
<p>Emily entrou no apartamento com tanta raiva que esqueceu a porta aberta. Arreganhada, na verdade.
<p>- O que é? – Ela respondeu da maneira mais grossa possível.
<p>- Eu fiquei sabendo que você está à procura de uma colega de quarto e...
<p>Uma mulher de mais ou menos vinte e oito anos estava parada em frente a porta de Emily. Ela tinha cabelos bem pretos e uma pele bronzeada, e usava um grande sorriso no rosto. Seu sotaque era diferente, não era de Nova York.
<p>- Olha, não é uma boa hora. – Emily bufou. 
<p>- Eu sou professora particular. Um aluno meu sabia que eu estava precisando de um lugar para morar e me disse que no prédio onde ele trabalhava uma garota procurava uma colega de quarto. Ele viu no mural de avisos.
<p>- É, eu preciso, mas... – Emily nem conseguia pensar direito. 
<p>- Bom, eu preciso muito. Eu acabei de sair de um relacionamento e...
<p>- Ah, nem me fale. 
<p>- Você também? – Ela já sentiu a afinidade com Emily.
<p>- É, há quatro anos, mas ele vive me assombrando feito um fantasma. 
<p>- Que mal hein.
<p>- A pior parte é que eu finalmente achei que agora talvez, talvez desse certo, mas aquele infeliz, ele... AI QUE RAIVA! Me desculpa. Eu nem sei porque eu estou falando isso com você. Eu nem te conheço. 
<p>- Relaxa, eu sou uma boa ouvinte caso queira.
<p>- É melhor esquecer isso e irmos direto ao que interessa.  Olha, eu não sei o que falar para você agora. Eu nunca tive uma colega de quarto antes, então...
<p>- Não, tudo bem. Eu entendo. Quer que eu volte mais tarde?
<p>- Ah, não, é que... Você tem ficha na polícia? É psicopata? Algo parecido? Cleptomaníaca? 
<p>- Não. – Ela ficou até com vergonha de responder.
<p>- Tem um blog onde fala mal dos outros?
<p>- Também não. – Ela não entendeu bem aquela pergunta.
<p>- Sabe cozinhar? 
<p>- Eu adoro cozinhar. 
<p>- Pode pedir a minha mão agora. – As duas riram. – Entra aí.
<p>- Quer dizer que eu passei? Não vai perguntar mais nada?
<p>- Você gosta de jiló? Porque eu odeio jiló e não quero ninguém comendo jiló perto de mim. 
<p>- Não, não gosto. 
<p>- Ótimo. Eu sou Emily.
<p>- Allison. 
<p>As duas deram a mão uma para outra.
<p>- Bom, você pode trazer as suas coisas quando quiser. – Emily não sabia mais o que dizer. – Como você pode ver, eu não tenho muito, então... Podemos resolver isso depois. Eu vou sair para trabalhar agora, depois eu preciso comprar umas coisas...
<p>- Podemos comprar juntas, o que você acha?
<p>- Perfeito. Você carrega caixas?
<p>- Quê?
<p>- Deixa para lá. Bom, podemos ir juntas, aí a gente já faz uma cópia da chave, já fala do aluguel e essas coisas.
<p>- Combinado. – Allison sorriu.
<p>- Ótimo. 
<p>- Certeza que não quer falar sobre o seu relacionamento? Ele é bonito?
<p>Emily hesitou em responder. 
<p>- O mais bonito, mas é mais confuso do que um quebra-cabeça de um milhão de peças. 
<p>- Você o ama?
<p>- Sim.
<p>- É uma droga.
<p>- É sim.</p> 
</body></html>";
            }

            if (numero == 3)
            {
                lblTitulo.Text = "Capítulo 3 - Segredos";
                htmlPage.Html = @"<html><body>
<p>Rotina.
<p>Temperance precisava disso se quisesse se dar bem na faculdade. Só mais um ano, só mais um ano, pensava ela, mas nunca acabava. Medicina não era uma coisa fácil de se estudar. 
<p>Seu despertador tocava todos os dias às cinco da manhã. Ela calculava vinte minutos no banho, dez minutos para o café e mais vinte minutos para se arrumar e ir para a sala de aula. Uma vantagem de morar em um dormitório da faculdade. Estudava todos os dias da semana até as cinco da tarde, depois voltava para o quarto e usava seu tempo livre para ler livros aleatórios ou assistir algo pelo notebook, quando não tinha que fazer trabalhos imensos para alguma aula ou estudar que nem louca para uma prova ou seminário.
<p>Temperance gostava dali. Sua família não estava por perto para encher seu saco e ninguém olhava estranho para ela por ter ficado louca. Seus poucos colegas de classe bastavam. Não se metiam na sua vida e quando tentavam, ela já dava um corte para que pensassem duas vezes antes de tentar de novo.
<p>Ela não podia falar firmemente que não se arrependia de ter deixado Nathan, seria mentira, mas ainda afirmava que era o melhor para ela, não seria saudável se preocupar com ele naquela etapa da sua vida.
<p>Jason, desse sim ela sentia falta. Era estranho falar com ele por telefone ou e-mail. Mesmo tentando imaginar, era diferente falar com ele sem ver aquelas caras de desesperado que ele fazia falando de coisas inúteis como sua ex ou atual namorada, ela nunca sabia o que a Emily era exatamente.
<p>Aquela noite Jason tinha feito Temperance quebrar sua rotina. Ficaram quase a noite toda conversando por telefone.
<p>- Deixa eu ver se entendi. Você foi embora da casa da Emily porque tem um cara que está a fim dela, mas ela não está a fim dele. Faz todo o sentido. – Ela revirou os olhos.
<p>- <i>É mais complexo que isso.</i>
<p>- Então me explique direito o que se passa pela sua cabeça louca porque eu não entendi. Acho que você precisa de terapia. 
<p>- <i>Para quê? Não te ajudaram em nada.</i> – Jason riu.
<p>- Ridículo.
<p>- <i>Ela foi promovida e alugou um apartamento incrível.</i>
<p>- E... Você tem fetiche por garotas pobres e sem teto? Não é meio machista?
<p>- <i>Não, ela que não deve ficar com um sem teto.</i>
<p>- E lá vamos nós.
<p>- <i>O quê?</i>
<p>- Você só reclama, mas eu não estou vendo você tentando mudar isso. 
<p>- <i>O que você quer que eu faça? Prante dinheiro?</i>
<p>- Eu não sei, sei lá, arrumar um emprego?
<p>- <i>Eu já tenho um, acabei de arrumar, mas...</i>
<p>- Mas o quê?
<p>- <i>Eu não quero ser garçom para o resto da vida.</i>
<p>- Você não precisa. Tem que começar a pensar grande. 
<p>- <i>De onde tirou isso? De um livro de auto ajuda? Ou do blog do finado Brandon? Porque ele poderia muito bem estar falando do cabelo dele.</i>
<p>- Ridículo de novo. 
<p>- <i>Pensar grande...</i> – Jason fez silêncio. - <i>Eu poderia virar um super-herói, como o Batman, ele não tem poderes. Droga, mas eu queria ser o Superman.</i>
<p>- Batman tem dinheiro para ser super-herói. E o Superman é um alien.
<p>- <i>Você gosta de destruir meus sonhos, não é?</i>
<p>- Com toda certeza. – Temperance fez uma pausa. – Jason, o que você gosta de fazer?
<p>- <i>Eu gosto de mandar.</i>
<p>- O quê?
<p>- <i>Quando eu era pequeno, eu curtia mandar nos meus primos. E todo o emprego que eu perco é porque eu quero mandar em gente que não posso. Cara, eu nasci para ser chefe.</i>
<p>- Não vai conseguir ser chefe do dia para noite.
<p>- <i>Só se eu tiver um plano.</i>
<p>- Jason, não.
<p>- <i>Pensar grande, Tempe. Esse é o segredo.</i> 
<p>- Mas Jason...
<p>Então ele desligou o telefone justo quando ela estava prestes a dizer que o que ele falava era loucura.</p>
<center><h4>--*--</h4></center>
<p>- É sexta à noite. 
<p>Anna sempre entrava no dormitório gritando, Temperance odiava isso. Naquela noite, ela estava de pijama, com o cabelo amarrado em um rabo de cavalo, deitada em uma cama cheia de livros e cadernos, tinha um relatório de anatomia para fazer. Já Anna estava com um vestido preto colado e curto, toda maquiada, pronta para uma festa. Seus longos cabelos cacheados estavam até brilhando.
<p>- Eu tenho coisas para fazer. – Temperance falou com a cara fechada. 
<p>- Esse relatório só é para ser entregue no final do mês. Vai dar tempo.
<p>- Não se ele for perfeito.
<p>- Qual é, Temperance? Você precisa sair um pouco. Daqui alguns anos, não vamos sair do hospital, temos que aproveitar agora. – Anna estava toda animada. – Olha só, a festa vai ser na fraternidade daquele garoto que te chamou para sair semana passada na lanchonete. Talvez hoje seja...
<p>- Não. Nem hoje, nem nunca.
<p>- Temperance, ele é um gato.
<p>- Não estou interessada. – Temperance estava perdendo a paciência.
<p>- Você nunca está. Nesses quatro anos, você não sai do quarto. Você tem amigos aqui, eu sou sua amiga, mas fica difícil lidar com você desse jeito. 
<p>- Olha, Anna, eu não estou com paciência para isso agora, tá bom? Vai para festa, você vai ter amigas lá também. Vai lá e se divirta. Eu não estou no clima, só ia te atrapalhar.
<p>- Então conversa comigo. – Anna se sentou na cama ao lado de Temperance. – Eu posso pegar um café, tirar esse vestido e conversar com você a noite toda. 
<p>- Eu converso com você o tempo todo, do que você está falando?
<p>- Eu não estou falando de coisas da faculdade. Por que você não vai para casa nas férias nem nos feriados? Por que veio estudar tão longe quando existem várias faculdades boas no seu país? Por que não sai do quarto nem namora nem curte a vida?
<p>- Anna, eu te adoro, mas nada disso te interessa. Vai para festa, vai.
<p>- É muito difícil ser sua amiga. – Anna bufou.
<p>- Eu sei. Pode criar um blog e falar sobre isso. 
<p>- O quê?
<p>- Deixa para lá.
<p>Temperance voltou sua atenção para o livro no seu colo enquanto Anna saía do dormitório batendo o pé.</p>
<center><h4>--*--</h4></center>
<p>Temperance acabou dormindo em cima dos livros. Ela sempre fazia isso, fazia parte da sua rotina. 
<p>Duas horas depois ela acordou toda assustada.
<p>- <i>Alô?</i>
<p>- Jason... – Sua respiração estava ofegante.
<p>- <i>Aconteceu de novo?</i> – Jason já sabia só pela voz da amiga.
<p>- Aconteceu. Eu estou ficando louca de novo, não estou?
<p>- <i>Colega, você nunca deixou de ser louca.</i> – Jason riu.
<p>Sonhar com Brandon era comum para Temperance, ela sempre via ele chorando ou brigando ou pior, como naquela noite, se matando. Ela nunca conseguia evitar aquilo e acordava sempre no seu último suspiro. Quando aquilo acontecia, ela ligava para o Jason, não importava a hora, esse era o acordo. 
<p>- <i>Bom, as festas da faculdade são tão boas como nos filmes?</i> – Jason sempre perguntava isso.
<p>- Eu não sei, eu não vou. – E era isso que ela sempre respondia.
<p>- <i>A Temperance de sempre.</i>
<p>- Me diz algo. Algo sobre você para esquecer um pouco essa imagem. 
<p>- <i>Ah, então minhas desgraças vão te deixar feliz?</i>
<p>- Esse é o plano.
<p>- <i>Eu voltei para casa. O emprego de garçom é aqui em LA.</i>
<p>- O quê? Mas você odeia viver lá.
<p>- <i>É, mas não posso continuar morando em um hotel gastando um dinheiro que eu não tenho.</i>
<p>- Mas...
<p>- <i>Pode ser por pouco tempo. Tem um quarto sendo alugado aqui perto, é bem barato porque fica em cima de um bar. Eu vou dar uma olhada lá amanhã. Posso dormir e me embebedar no mesmo lugar.</i>
<p>- Que sonho. – Temperance resmungou.
<p>- <i>Sabe, eu andei pensando no meu futuro emprego como chefe.</i>
<p>- Eu já falei que isso é loucura?
<p>- <i>Não é não. É a melhor ideia.</i>
<p>- Como você vai conseguir um emprego de chefe se você não tem nem um diploma?
<p>- <i>Eu dou um jeito.</i>
<p>- Engraçado. Como vai sua namorada? Ex ou sei lá, como se denominam essa semana?
<p>- <i>Olha quem é a engraçada agora? Não nos falamos desde aquele dia.</i>
<p>- Não deve estar perdendo nada.
<p>- <i>Por que você não gosta dela?</i> – Jason riu.
<p>- Eu nunca disse que não gostava dela. Só não vou com a cara.
<p>- <i>Com quem você vai com a cara, não é verdade?</i>
<p>- Com muita gente. 
<p>- <i>Vamos parar de falar de mim. E o Nathan como está?</i>
<p>- Você jogou baixo.
<p>- <i>Só sei jogar assim.</i> – Ele riu de novo.
<p>- Um cara me chamou para sair semana passada.
<p>- <i>Você disse que não podia e deu as costas.</i>
<p>- Como sabe?
<p>- <i>Eu achei a notícia em um blog.</i>
<p>- Será que dá para parar de fazer piada sobre isso?
<p>- <i>Desculpa. É que nunca fica velha.</i>
<p>- Idiota.
<p>- <i>Olha, eu sei que você se virou e foi embora porque é o que você faz. Você não se aproxima de ninguém aí. Eu não sei qual é o seu problema.</i>
<p>- Estou aqui para focar nos meus estudos. 
<p>- <i>Essa desculpa cola aí? Porque aqui não colou.</i>
<p>- Jason...
<p>- <i>Eu sei que é difícil para você, principalmente para você. Eu entendo, mas precisa seguir em frente. Garanto que tem várias pessoas legais aí. Quer dizer, eu sou insubstituível, óbvio, mas o Nathan não é. Vários caras adoram loucas. O Cabelo de... O Brandon morreu, você não precisa de um substituto dele.</i>
<p>- Sempre foi nós dois, Jason. Agora sou só eu.
<p>- <i>Ei, eu estou aqui. Não é só você.</i> 
<p>Temperance não respondeu.
<p>- <i>Agora vai dormir. Se o Brandon aparecer no sonho de novo, mate ele, será mais fácil e mais rápido.</i> 
<p>- Sem graça de novo.</p>
<center><h4>--*--</h4></center>
<p>- Temperance, não é?
<p>Um garoto abordou Temperance na cantina. Ela estava comprando seu café da manhã na loja de sempre, um simples bolinho.
<p>- Sou eu.
<p>- Eu sou o Norman. Estudamos Genética Humana juntos.
<p>- Tudo bem. – Temperance continuava sem interesse.
<p>- Eu estou tendo problema em elaborar um relatório sobre o assunto e queria saber se você poderia me dar uma ajuda.
<p>- Ah, eu não...
<p>- Eu não sou burro, eu prometo, eu só preciso de ajuda e você é a melhor da classe, então...
<p>- Eu vou pensar.
<p>- Ótimo. Eu vou te dar o meu telefone. Eu moro aqui no campus, então vai ser fácil me achar.
<p>Ele tirou seu caderno da mochila e arrancou uma folha. Pegou uma caneta e escreveu seu número nela apoiado no balcão da loja.
<p>- Pensa com carinho.
<p>- Pode deixar.</p>
<center><h4>--*--</h4></center>
<p>- Eu preciso te contar uma coisa, e pedir um conselho.
<p>Temperance ligou para Jason no intervalo de uma aula para outra.
<p>- <i>Que coisa louca, eu ia te ligar agora. Também tenho uma coisa para falar.</i>
<p>- Acha que ajudar alguém a estudar é a mesma coisa que fazer amizade?
<p>- <i>É, pode ser, que seja. Eu acabei de comprar um bar.</i>
<p>- O quê?
<p>E por um segundo, Temperance achou que Jason estava delirando.</p>
</body></html>";
            }

            if (numero == 4)
            {
                lblTitulo.Text = "Capítulo 4 - Fracasso";
                htmlPage.Html = @"<html><body>
<p>- <i>Como assim, você comprou um bar?</i> – Temperance estava gritando. – <i>Ficou maluco?</i>
<p>- Por quê? É uma ótima ideia. Para eu ser o meu próprio chefe, eu tenho que ter uma empresa. O bar é a minha empresa. – Jason explicou a lógica.
<p>- <i>Mas... Mas... Como comprou um bar? Você não tem dinheiro. Roubou algum banco ou sei lá?</i>
<p>- Primeiro, para de gritar, eu não sou surdo. Segundo, relaxa, a dívida é minha, não sua.
<p>- <i>Jason!</i>
<p>- Olha, eu vou te contar. É uma história bem curta.
<p>Na verdade, a história só era curta porque Jason fez assim. Dois dias atrás, ele estava que nem louco à procura de um apartamento pelas ruas de Los Angeles, mas havia um problema, nenhum daqueles lugares estava no seu orçamento.
<p>Viver na casa dos pais estava tão insuportável que ele já estava desesperado. Ele nunca foi muito religioso, mas quando leu a placa “QUARTO PARA ALUGAR” pendurada na porta de um bar fechado já com um preço que não era nada mal, encarou como um sinal de Deus.
<p>Não havia ninguém no bar e não conseguiu entrar em contato também com o número que deixaram no canto da placa. Mas no outro dia, ele estava lá de novo bem cedo.
<p>Acontece que quando ele entrou no bar para perguntar sobre o quarto, descobriu que o lugar todo estava à venda e que aquela placa de aluguel era só para chamar a atenção. A boa notícia era que o dono estava vendendo tudo a preço de banana, o ponto era péssimo, segundo ele, ninguém queria comprar e estava com pressa para ir embora. Jason sabia que ele toparia qualquer coisa, então agarrou aquela chance. Entregou suas economias como garantia e assinou um contrato de compra.
<p>- <i>Você vai pagar em quantas vezes?</i> – Temperance ainda estava digerindo tudo aquilo.
<p>- Em várias prestações. Ele disse que contanto que eu pague, está tudo certo. Eu até assinei um contrato. O bar já é meu. – Jason estava muito animado.
<p>- <i>E como você vai pagar?</i>
<p>- Com os lucros do bar.
<p>- <i>Se ele está vendendo porque o lugar é ruim por que você acha que vai lucrar?</i>
<p>- Porque eu sou foda.
<p>- <i>Jason!</i>
<p>- Tempe, quer relaxar? Vai dar tudo certo. 
<p>- <i>Você sabe cuidar de um bar? Sabe administrar essas coisas? Como vai comprar as bebidas? Você sabe preparar drinques?</i>
<p>- Bom...
<p>- <i>Você tem um alvará?</i>
<p>- Na verdade...
<p>- <i>Vai contratar mais pessoas?</i>
<p>- Tempe, eu não fiz nenhum curso de empreendedorismo, então vai com calma.
<p>- <i>Você vai falir o lugar e não vai ter dinheiro para pagar o bar e...</i>
<p>- Obrigado pela confiança.
<p>Jason desligou o telefone na cara de Temperance.</p> 
<center><h4>--*--</h4></center>
<p>Jason sabia que a amiga acreditava nele, mas se preocupava demais o que deixava ela muito cautelosa e chata às vezes. Ele só precisava mostrar que conseguiria. 
<p>Na manhã seguinte, ele já se mudou para o quarto em cima do bar. Era um espaço grande sem divisórias e um banheiro. Havia uma geladeira, um fogão e uma cômoda, era o suficiente, não tinha muita roupa para guardar, só precisava comprar uma cama ou simplesmente um colchão. Era aconchegante, não era cinco estrelas, mas para ele era no mínimo quatro. O mais engraçado era que seus pais nem perguntaram para onde ele ia se mudar, achou interessante esse fato. 
<p>Jason tinha só alguns dias para fazer aquele lugar funcionar, não sabia como, Temperance tinha razão, mas podia aprender. Naquela tarde, foi em todas as bibliotecas que conhecia e comprou livros sobre negócios, empresas, administração. Passou a noite toda alternando entre leitura e vídeo de dicas no Youtube, sua cabeça doeu, ficou com sono, com raiva, até jogou um dos livros contra a parede, mas não parou até assimilar tudo. Aquilo era melhor que quatro anos para um diploma.
<p>Regra número um, o bar precisaria de uma boa propaganda. Mais uma noite em claro, ele não queria criar uma simples página no Facebook ou em outra rede social, podia fazer melhor. Em oito horas de trabalho, um site incrível estava no ar. Até ele ficou impressionado com o resultado. Nem se lembrava onde tinha aprendido fazer aquele tipo de coisa. 
<p>Os dias se passaram. O bar estava ganhando uma imagem melhor, já estava limpo, mais iluminado, prestes a ser abastecido, mas ainda fechado. Jason ficou o dia todo na prefeitura só para conseguir um papel que permitisse que ele vendesse bebidas alcoólicas sem levar uma multa.
<p>Era quinta-feira e ele queria o bar aberto no sábado, o tempo estava acabando. Na porta havia uma placa de “PROCURA-SE UM BARTENDER” já fazia um tempo, mas ninguém apareceu. O lugar era tão ruim assim?</p>
<center><h4>--*--</h4></center>
<p>- Com licença?
<p>Jason estava varrendo o chão quando uma garota entrou no bar toda assustada e tímida. Sua voz era baixa e calma. 
<p>- O que foi? – Jason encarou a garota. 
<p>- Você está contratando?
<p>- É o que diz o cartaz. – Jason não deu muita atenção. Antes mesmo de começar tudo, já estava de saco cheio. 
<p>- Eu queria fazer um teste.
<p>- Aqui não é audição para filme não, filhinha. 
<p>Jason ainda olhava para a garota. Bem baixinha, parecia perdida, com certeza, não era da Califórnia, estava um pouco acuada e assustada. Seu sotaque era um pouco diferente do que Jason estava acostumado a ouvir. 
<p>- Na verdade, eu quero ser bartender.
<p>- Você? – Jason fez uma cara de descrente.
<p>- Eu preciso do emprego. 
<p>- Olha, aqui não é <i>Rock of Ages</i> não. Nem toda garota do bar vira artista como mostra nos filmes. Não sei o que te disseram lá no buraco que você veio, mas as coisas não são tão fáceis assim.
<p>- Como assim? Eu sou daqui.
<p>- Não é não, você se entregou quando abriu a boca. – Ele voltou a varrer o chão.
<p>- Mas...
<p>- Olha, eu até te contrataria, mas seria preciso colocar um degrau no balcão para você alcançar.
<p>- Eu posso usar salto. – Ela insistiu.
<p>- Olha...
<p>- Por favor. 
<p>- Qual é o seu nome? – Jason resolveu dar uma chance. Largou a vassoura encostada no balcão e se virou para a garota.
<p>- Amber. Amber Stewart.
<p>- Tudo bem. Eu vou esquecer do seu nome assim que você sair, mas tudo bem.
<p>- Por isso eu vou escrever.
<p>Amber pegou um pedaço de papel do bolso junto com uma caneta, escreveu algo e entregou para Jason.
<p>- Meu nome e meu telefone. Pode me ligar depois.
<p>Jason pegou o papel. Leu uma, duas vezes... Estava pensando... 
<p>- Olha só, caipirinha, eu não vou ligar para você.
<p>- Eu não estou falando só do emprego. A gente pode sair. – Amber levantou uma de suas sobrancelhas. 
<p>- Ai meu Deus. – Jason começou a rir descontroladamente. – Você está me chamando para sair? Desse jeito?
<p>- Bom...
<p>- Eu dispenso. Eu não tenho um tipo exatamente, mas também não sou tipo Branco de Neve que curte anã. Na verdade, acho que vou te chamar de Dunga, mais fácil de lembrar.
<p>- O quê? – Ela arregalou os olhos. 
<p>- Olha, você sabe fazer drinques?
<p>- Sei. Eu fazia muitos drinques em casa.
<p>- No sertão tem drinques? Achei que só bebessem cachaça por lá.
<p>- Não, eu...
<p>- Olha, esquece. Eu não vou te contratar mesmo.
<p>- Mas...
<p>- Nem vou te chamar para sair, Tampa. É, Tampa é melhor que Dunga.
<p>- Tampa?
<p>- É, tampinha é sem graça. Agora vai saindo do meu bar, por favor. Pode voltar no sábado na inauguração. Vamos servir ótimas bebidas. – Jason sorriu.
<p>- Eu queria... Já veio muitos candidatos melhores?
<p>Jason hesitou. Não havia aparecido ninguém além dela.
<p>Alguém bateu na porta.
<p>- Pode entrar, está aberta! – Jason gritou.
<p>Era Peter, o entregador da distribuidora que Jason havia encomendado as bebidas dois dias atrás. Ele usava um boné que mal dava para ver seu rosto suado e cansado. Ele não era muito mais velho que Jason. 
<p>- Pete, e aí?
<p>Peter havia entregado umas caixas de bebidas no dia anterior também. O estoque já estava quase completo.
<p>- E aí, cara? Eu trouxe as últimas caixas para você.
<p>- Ah, pode deixa-las aqui no chão que eu dou uma arrumada. – Jason apontou para um canto. - São muitas?
<p>- Quatorze.
<p>- Jesus do Céu! – Jason não queria carregar caixa nenhuma. Ainda estava com dor nas costas do último carregamento.  – Bom... – Mas ele pensou rápido. – Pode ir trazendo.
<p>- Tudo bem. – Peter saiu do bar e se dirigiu até o caminhão estacionado em frente para buscar as caixas.
<p>- Você.... – Jason apontou para Amber. - ...Está contratada.
<p>- É sério? – Ela quase deu pulos de alegria.
<p>- Seríssimo.
<p>- Muito obrigada. – Ela se aproximou para abraçá-lo, mas Jason se afastou.
<p>- Ah, não precisa disso não.
<p>- Tudo bem, chefe. Qual vai ser meu primeiro trabalho?
<p>- Ainda bem que perguntou. – Disse Jason satisfeito. – Pete vai trazer umas caixas e você vai levá-las até o porão. É só descer essas escadas... – Jason apontou para as escadas que ficavam no fundo do bar. – A primeira porta que você encontrar.
<p>- Quer que eu carregue caixas? Mas são pesadas e... – Amber desanimou.
<p>- Você é uma mulher forte e independente. Me prove isso.
<p>- Você vai me ajudar?
<p>- Ah, eu não posso. Preciso fazer umas coisas lá em cima.
<p>- O quê?
<p>- Não te interessa. Olha, eu não sou um carrasco. Você pode parar para descansar, tomar uma água, sei lá. Não precisa ter pressa.
<p>- Mas...
<p>- Depois que você terminar, a gente conversa sobre horários e salários.
<p>- Ah... – Amber era tímida demais para contestar alguma coisa.
<p>- Agora vamos lá, ao trabalho, Tampa.
<p>Jason subiu as escadas para o seu quarto enquanto Amber se preparava para começar a carregar as caixas que viriam em alguns instantes.</p>
<center><h4>--*--</h4></center>
<p>Sábado estava chegando mais rápido do que Jason queria. Conforme as horas daquela sexta-feira iam passando, ele ficava mais nervoso para a tão esperada inauguração.
<p>- Calma, vai dar tudo certo. – Amber sempre falava isso quando ele chegava no balcão com cara de nervoso. – Seu site ficou incrível e tem bastante visualização. O lugar está maneiro também. 
<p>Ela passava o tempo todo no balcão treinando drinques. A verdade é que Amber havia mentido, ela nunca tinha preparado drinque nenhum na vida. 
<p>- Eu estou com medo. E se ninguém aparecer?
<p>- Você chamou todos os seus amigos e família?
<p>- Bom, minha família não liga e meus amigos... é complicado.
<p>- Pode desabafar comigo. – Amber sorriu para tentar consolá-lo.
<p>- Não. 
<p>Jason pegou o celular do bolso. A vontade de ligar para Emily estava maior. Pela primeira vez, em quatro anos, ele passou cinco dias tão ocupado que se esqueceu de pensar nela, mas naquele momento, sem nada para fazer, além de esperar, o deixou muito vulnerável. Ele odiava se sentir daquele jeito.
<p>- Sabe, a inauguração do seu bar é um momento muito importante. Vai querer alguém que você goste por perto. – Amber insistiu.
<p>- Na verdade...
<p>- Problemas não resolvidos com garotas?
<p>- Com uma só. A gente brigou e... – Jason não sabia exatamente o que falar. – Ela provavelmente não deve querer me ver nem pintado de ouro.
<p>- Ou só está esperando você ligar.
<p>- Olha, Tampa, acho melhor você ir embora para descansar. Esteja aqui amanhã cedo. Vamos ter um dia bem cheio. 
<p>- Tudo bem. Quando mesmo que eu recebo?
<p>- O quê? – Jason fez uma cara de confuso.
<p>- Mas...
<p>- É brincadeira. – Ele soltou uma gargalhada. – Eu te pago logo depois que fecharmos amanhã.
<p>- Tá legal.</p> 
<center><h4>--*--</h4></center>
<p>Já estava anoitecendo quando Jason finalmente pegou o telefone e ligou para Emily. Ele não sabia se aquilo o fazia ser mais forte ou mais fraco.
<p>- <i>Alô?</i> – Aquela voz não era de Emily. Será que ela tinha trocado de número?
<p>- Oi, esse é o celular da Emily?
<p>- <i>Ah, sim, é dela. É que ela está tomando banho.</i> 
<p>- Ah.
<p>- <i>Eu sou Allison, colega de quarto dela.</i>
<p>- Claro, colega de quarto. Ela precisava mesmo de uma... – Jason sabia que Emily precisava de uma colega. Claro que já tinha encontrado uma. Ele agradeceu por não ter sido aquele cara que atendeu o telefone.
<p>- <i>Quer que eu peça que ela ligue de volta?</i>
<p>- Não, olha, vai ser melhor assim. Só fala para ela que é o Jason e que... Eu vou inaugurar um bar amanhã aqui em Los Angeles e seria muito importante para mim se ela viesse. 
<p>- <i>Jason? Sei.</i>
<p>- Pode anotar o endereço e o horário?
<p>- <i>Claro, pode falar</i>.</p>
<center><h4>--*--</h4></center>
<p>Jason acordou bem cedo no sábado. Saiu para correr pela praça para tentar aliviar a ansiedade. Quando chegou no bar depois da corrida, Amber já estava na porta esperando por ele.
<p>Ele fez ela lavar todos os copos de novo, depois lavar a calçada do bar, e logo depois as janelas. Jason não parava quieto. Andava de um lado por outro. Olhava no site de dois em dois minutos. Dava broncas desnecessárias em sua funcionária. Estava uma pilha de nervos. 
<p>Amber parecia calma e confiante. Seus drinques estavam perfeitos para uma iniciante, pensou ela. Embora estivesse ouvindo gritos o dia todo, não se sentiu abalada.
<p>Jason abriu as portas exatamente às dezenove horas. Ele parou ao lado da porta para receber os clientes enquanto Amber ficou de prontidão no balcão de bebidas. A cada minuto que ninguém aparecia, ele ficava mais nervoso.
<p>- Calma, eles vão aparecer logo. – Amber ainda estava animada.
<p>Mas ela estava enganada. Passou uma hora, duas horas, três horas.... Jason não saiu de perto da porta até quase dar meia-noite.
<p>Ninguém apareceu. Então ele fechou as portas.</p>
<center><h4>--*--</h4></center>
<p>- Ninguém apareceu, Tempe.
<p>- <i>Eu sinto muito, Jason. Mesmo preocupada, eu queria muito que desse certo.</i> – Temperance falava com muita cautela.
<p>- Eu sou um fracassado. Eu achei mesmo que isso daria certo. O que eu tinha na cabeça.
<p>- <i>Não. Olha, as coisas não acontecem de uma hora para a outra. Você precisa ter paciência, fazer mais propaganda e tal. Talvez o povo ainda precise de panfletos e essas coisas.</i>
<p>- Eu perdi, Tempe. Eu não tenho dinheiro para pagar marketing e muito menos o bar, estou com uma dívida enorme com a distribuidoras de bebidas. Eu estou ferrado.
<p>- <i>Eu queria muito estar aí agora.</i> – Temperance respirou fundo.
<p>- Eu sei. 
<p>- <i>Você ligou para ela?</i> – Temperance falava de Emily. Ela nem precisava dizer o nome.
<p>- Eu deixei um recado. Ela também não apareceu.
<p>- <i>Talvez ela não conseguiu uma passagem, está trabalhando demais, talvez nem pegou o recado. Você não sabe.</i>
<p>- Pode dizer. Ela não quis vir. Eu não a culpo. Agi feito um canalha com ela. Pelo menos agora eu sei que acabou mesmo. 
<p>- <i>Talvez foi o melhor.</i>
<p>- É. Agora eu vou desligar e beber tudo o que eu comprei. Já que não posso devolver nem pagar, vou entrar em um coma alcoólico.
<p>- <i>Nossa, quanto drama. A gente vai arranjar um jeito.</i>
<p>- Se você está dizendo.
<p>- <i>Eu estou.</i></p>
<center><h4>--*--</h4></center>
<p>Amber ainda estava encostada no balcão quando Jason desceu as escadas para apagar as luzes do bar.
<p>- Eu disse que você já podia ir. Eu sei que está esperando o seu salário, mas pode me dar uns dias? Me passa o número da sua conta que eu deposito. Imagino que esse foi o seu emprego mais rápido.
<p>- Tudo bem, só tivemos um dia difícil. Eu entendo, amanhã vai ser melhor. Eu não vou me demitir.
<p>- Acho que não vou abrir amanhã.
<p>- Já vai desistir? – Amber ficou triste.
<p>- Eu dei um passo maior que a perna. Eu não posso abrir um bar. Eu mal consegui terminar o colegial. Eu só estava me enganando. Você devia mesmo procurar outro emprego com alguém que tenha dinheiro para te pagar.
<p>- Está falando isso porque está triste. Foi só um dia ruim.
<p>- Olha só, Tampa da Garrafa “Pense Positivo”, eu não quero falar sobre isso agora. Eu quero beber. Já são quase duas da manhã. Pode ir embora.
<p>- Eu posso fazer uns drinques para você. – Amber sorriu. – Eu treinei tanto. Preciso de um cliente para provar. 
<p>- Ótimo, me deixe bêbado. É disso que eu preciso.
<p>Amber se virou para a estante de bebidas e começou a misturar algumas coisas como havia aprendido na internet. Jason observava ela tentando fazer os malabarismos falhos enquanto pensava na morte do seu sonho que nasceu no começo da semana.</p>
</body></html>";
            }

            if (numero == 5)
            {
                lblTitulo.Text = "Capítulo 5 - Coração";
                htmlPage.Html = @"<html><body>
<p>- Quem era?
<p>Emily saiu do banheiro toda molhada com a toalha enrolada pelo corpo.
<p>- O quê? – Allison não entendeu.
<p>- Eu ouvi o toque do meu celular lá do banheiro. Era o Elton de novo? – Emily bufou. – Eu já falei para ele que vamos jantar no sábado.
<p>- Não, não era ele. Era “O” Jason. – Allison deu uma ênfase. 
<p>- Jason? O que ele queria? – Emily tentou esconder sua curiosidade ao máximo. – Eu não achei que ele fosse ligar tão cedo. Aquele idiota.
<p>- Bom, ele disse que vai abrir um bar no sábado e queria que você fosse. Ele deu até o endereço, eu escrevi aqui e...
<p>Allison entregou um post-it para Emily.
<p>- Espera aí, ele vai abrir um bar? Como assim? Como ele arranjou dinheiro para...
<p>- Olha, por que não liga para ele? – Allison pegou o celular de Emily e entregou para ela. – Ele pode responder todas as suas perguntas. Eu só tenho um papel com um endereço. 
<p>- Eu não vou ligar para ele. – Emily fechou a cara.
<p>- Por que não? Ele ligou, foi uma iniciativa, não foi?
<p>- Porque ele foi um idiota e imbecil. Deve ter ligado porque se sentiu culpado ou coisa parecida. Além do mais, eu não quero falar com ele. 
<p>- Você quer sim.
<p>- Eu não quero, não. 
<p>- Olha, Emily, eu...
<p>- Eu não quero ouvir, tá bom? Eu vou me trocar.
<p>- Mas...
<p>Emily deu as costas para Allison e voltou para o banheiro.</p>
<center><h4>--*--</h4></center>
<p>Mas naquela noite Emily não conseguiu dormir. Ela ficou com aquele papel na mão a noite toda. 
<p>Uma parte dela queria muito ligar para o Jason e pedir uma explicação, ou só para conversar, aquela ideia de bar era loucura, mas queria entender. Outra parte queria simplesmente levantar, arrumar as malas e pegar um voo para Los Angeles. A outra parte estava querendo rasgar aquele papel e voltar a dormir, mas era a que estava perdendo e ela não conseguiu nem rasgar o papel e muito menos dormir.
<p>- EU ESTOU PÉSSIMA. – Emily tacou a bolsa dela na mesa da cozinha naquela manhã.
<p>- O que houve? – Allison estava fazendo café. As duas haviam feito compras. Agora tinham uma cafeteira.
<p>- Eu não dormi a noite toda! Eu vou aparecer na reunião dos fornecedores com uma cara de zumbi! – Emily gritava irritada.
<p>- E de mal humor. – Allison sorriu.
<p>- Você é muito feliz. Devia ter dito que era feliz o tempo todo quando chegou aqui. Eu odeio gente que é feliz o tempo todo. 
<p>- Eu não sou feliz o tempo todo. 
<p>- Não é o que parece. 
<p>- Na verdade, você que é rabugenta o tempo todo. – Allison a fitou – Já decidiu? Vai para LA ver o Jason?
<p>- Eu já disse que não quero falar sobre isso.
<p>- A inauguração é hoje. Se quiser eu reservo a passagem para você e...
<p>- Você conhece o Jason? – Emily já estava perdendo a paciência.
<p>- Ah, não, mas...
<p>- Então você não sabe. Eu posso ir nessa inauguração, mas e depois? 
<p>- Como assim, depois?
<p>- Ele mora lá e eu aqui. E a gente já tentou tantas vezes por todos esses anos e todas as vezes foram falhas. Não... Eu cansei de falhar. Eu quero seguir em frente. 
<p>- Com o Elton?
<p>- Eu não gosto do Elton. Você até parece ele falando. – Emily bufou.
<p>- Não, você ama o Jason. 
<p>- Alli...
<p>- Você sabe, assim, tipo, que existem empresas em Los Angeles para você trabalhar? Não precisa morar aqui e ele lá.
<p>- Você quer que eu mude a minha vida toda por um cara?
<p>- Não, eu só quero o apartamento todo só para mim. – Allison riu de novo. 
<p>- Há-há-há, que engraçado. – Emily pegou um dos pães, cortou com uma faca e comeu uma das metades. – Me conta uma coisa. E você?
<p>- Eu o quê?
<p>- Vamos parar de falar de mim. Vamos falar de você. Sou só eu que falo sempre, vamos mudar isso.
<p>- Primeiro, você não fala, você resmunga. E segundo, eu não tenho muito o que dizer.
<p>- Não gosta de ninguém?
<p>- Eu acabei de sair de um relacionamento. Eu já disse isso.
<p>- E eu não prestei atenção. Eu devia estar com muita raiva na hora.
<p>- Você acha?
<p>- Por que terminaram? – Emily ignorou a pergunta.
<p>- O amor acabou. Isso acontece às vezes. Na verdade, acontece mais do que a gente imagina.
<p>- Por que isso também não acontece comigo? – Emily fez bico.
<p>- É isso mesmo que você quer? Deixar de amar o Jason?
<p>- Às vezes eu quero, às vezes não. Só sei que seria mais fácil.
<p>- Bem confusa você, hein.
<p>- Só um pouco.</p>
<center><h4>--*--</h4></center>
<p>- <i>Oi, você ligou pro Jason, eu mesmo, fala aí depois eu ligo se eu lembrar.</i>
<p>Emily desligou o celular.
<p>Ainda eram três da tarde e ela já havia quase deixado mensagem para Jason três vezes e quase desmarcado o jantar com o Elton umas dez vezes. Sempre que o encontrava sentia vontade de dizer, mas não conseguia. Ela precisava de um conselho, mas o celular de Allison ficou ocupado o dia todo. 
<p>E aquele problema não era o único...
<p>- O que houve? Ainda está pensando no Jason? – Allison estava na mesa da cozinha corrigindo algumas provas.
<p>- Não. Olha, quando eu comecei o meu dia, eu achei que pensar no Jason seria a pior coisa, mas aí...
<p>- Apareceu o Elton. – Allison tentou adivinhar.
<p>- Minha vida não se resume a homens. – Emily fez uma careta.
<p>- Não é o que parece.
<p>- Eu estou falando daquela vadia irritante. 
<p>- Ah, a Jessica. – Allison sempre ouvia o nome Jessica seguido de xingos.
<p>- Exato. Essa mulher é uma vaca manipuladora. – E pensar em Jessica deixou Emily mais nervosa do que pensar no Jason.
<p>- Você não está exagerando? – Allison franziu a testa.
<p>- Não, eu não estou exagerando. Ela é o cão. Essa garota vem competindo comigo desde que eu entrei na empresa. Ela ficou uma fera quando eu fui promovida. Agora está determinada a fazer da minha vida um inferno.
<p>- Nossa.
<p>- É, hoje mesmo, eu estava calmamente preparando a apresentação do meu chefe para uma reunião, aí quando eu estava quase terminando, ela apareceu e do nada, já tinha feito, e passou na minha frente. Sem falar que na hora do almoço, ela entrou no meu computador e apagou uns e-mails importantes e eu fiz cara de palhaça para algumas pessoas. 
<p>- O que você fez com ela?
<p>- Num mundo perfeito, eu teria arrancado os olhos dela e comido. Na vida real, eu fuzilei ela com os meus olhos, chorei de raiva no banheiro e pedi desculpas para o meu chefe.
<p>- Você sabe que ela pode fazer você perder o emprego, não sabe?
<p>- Eu sei, mas... 
<p>- Mas o quê?
<p>- Eu não vou ficar fazendo intrigas que nem uma garota do colegial. Eu já passei dessa fase. Eu vou continuar fazendo o meu trabalho, mostrar a outra face, e que o karma ferre com ela em um futuro próximo.
<p>- Se eu fosse você, trancaria ela no banheiro e descia a porrada.
<p>- É. – Emily deu uma risada forçada.
<p>- O quê?
<p>- Fizeram isso comigo quando eu estava no colégio. Por que você acha que eu sou furiosa com o mundo?
<p>- Sério, Emily? Me desculpa, eu não sabia que...
<p>- Tudo bem. Eu geralmente não falo sobre isso, mas já faz tanto tempo, eu nem penso mais. A questão é que o colegial não foi uma boa época para mim, por isso eu sempre tento me distanciar disso.
<p>- Mas você conheceu o Jason no colegial, isso foi bom, não foi?
<p>- Foi. Quer dizer, a gente brigava o tempo todo e tinha toda aquela história de um blogueiro nos cercando e tal, mas...
<p>- Blogueiro?
<p>- Longa história. O ponto é que me mudar para Nova York foi um jeito de me livrar de tudo, de tirar todos os agouros do passado, de virar a página, de...
<p>- Recomeçar. – Allison completou. – Eu sei como se sente. Eu também busco por isso. Sabe, eu também cometi erros, alguns eu me arrependo, outros nem por um segundo, mas essa é a vida, não é? Erros e aprendizados. Você sobreviveu ao colégio, pode sobreviver agora também. 
<p>- Como assim?
<p>- Não pode deixar aquela garota pisar em você. Ninguém pode pisar em você.
<p>- É tão mais fácil brigar com o Jason, nele eu consigo bater. Eu digo para todos que eu sou durona e forte, mas na verdade, às vezes eu sou a mesma medrosa que apanhava no banheiro da escola. Só que aqui eu esqueço. 
<p>- Ficar com o Jason te faz lembrar do seu passado assombroso? É por isso que você nega tanto?
<p>- Não. Me faz pensar no que poderia ter sido. O plano era nós dois nos mudarmos para Nova York, mas as coisas aconteceram, e eu vim sozinha. O que teria acontecido se tivéssemos vindo juntos? Estaríamos praticamente casados ou finalmente teríamos uma conclusão?
<p>- Você nunca vai saber. O passado já era. Você só pode pensar no presente e no futuro. Daqui a cinco anos, você quer estar praticamente casada com o Jason ou com uma conclusão?
<p>- Eu não sei, eu não penso muito no futuro. 
<p>- Eu também não pensava. Quando eu tinha dezoito anos, eu só queria curtir. Eu saía com os amigos, viajava, era festas e festas...
<p>- Aí pegou aids? Essa é a sua grande história de vida?
<p>- Aí eu conheci um cara, me apaixonei e nos casamos.
<p>- O quê? – Emily não conseguiu disfarçar a surpresa. – Quantos anos você tem?
<p>- Vinte e sete.
<p>- Eu tenho vinte e dois e mal consigo namorar um cara por mais de seis meses. É o mesmo cara de sempre, mas tanto faz.
<p>- Esse foi o meu relacionamento que acabou. Fui casada por seis anos.
<p>- SEIS ANOS?! – Emily deu um grito. – Desculpa, agora que eu percebi que eu coloquei uma estranha para dividir o apartamento comigo. Me diz que você não come carne humana.
<p>- Não, só de lebre. – Allison riu.
<p>- Eu posso aceitar isso, não gosto mesmo de coelho.
<p>- Todos nós temos uma bagagem, sabia? Essa garota que está tentando te ferrar no serviço também tem uma bagagem.
<p>- E você quer que eu a entenda? Achei que tinha dito para bater nela. 
<p>- Não, eu só estou dizendo que para tudo tem uma razão. Você não é medrosa, sobreviveu quatro anos em Nova York sozinha, e tudo isso veio da força que criou no colégio, a sua sobrevivência. Eu nunca teria amadurecido daquela vida de festas se eu não tivesse me apaixonado e me casado, talvez eu tivesse mudado, mas não tão rápido, talvez eu tivesse cometido muitos outros erros antes de mudar.
<p>- Você pode ter razão. Eu sobrevivi, eu deixei a minha vida ruim para trás. Eu acho que com o Jason, eu vou só me iludir, quer dizer, a gente se ama, mas não vai dar certo. Não deu até agora. Eu tenho que seguir em frente, assim como você seguiu.
<p>- Não se engane. Eu ainda tenho meus momentos de fraqueza.
<p>- Ah, então era com ele que estava falando no telefone o dia todo? Porque eu te liguei e só dava ocupado. Foi bom o sexo por telefone?
<p>- Cala a boca. Eu só... – Allison gaguejou. – Eu só estava falando com a minha mãe. Eu sou bem família e sinto muita saudade dela. 
<p>- Eu não falo com a minha mãe faz dias.
<p>- O telefone está logo ali.</p>
<center><h4>--*--</h4></center>
<p>- Olha, eu estou muito nervoso, e eu estou feliz que você não tenha cancelado. Achei que cancelaria.
<p>- Por que eu cancelaria? A gente come junto o tempo todo na empresa.
<p>- É.
<p>Mas para Elton jantar era diferente. Ele reservou a melhor mesa do seu restaurante favorito para aquela noite. Ele estava nervoso e ainda estava usando...
<p>- Eu só não entendi porque você está usando terno. – Emily sorriu.
<p>- Ah, eu gosto de me vestir bem principalmente para você. – Ele sorriu.
<p>- Bom, vamos comer que eu estou morrendo de fome. – Ela sempre mudava de assunto quando percebia que uma cantada estava chegando. 
<p>Emily estava um pouco desconfortável. Não estava tão bem vestida assim. Fazia frio então estava com uma calça jeans e uma blusa de moletom. Seu cabelo estava amarrado com um coque. Para ela era algo casual, mas aquele restaurante, aquele terno...
<p>- Como você está?
<p>- Estou bem e você? – Emily olhava para o cardápio. – Você escolheu um restaurante muito caro hoje. Eu mal posso pagar por metade dessas coisas.
<p>- Ah, relaxa, hoje eu pago.
<p>- Não, deixa disso. Eu nunca vou ter dinheiro o suficiente para pagar o que você come. – Ela riu.
<p>- Não, hoje é diferente. Eu pago, relaxa.
<p>- Como assim?
<p>Emily sabia o que estava acontecendo, só não queria acreditar. Aquilo era um encontro, ela percebeu assim que chegou no restaurante. Mas mesmo assim, estava com medo de ouvir o que estava acontecendo em voz alta.
<p>- Emily, eu estou querendo te dizer isso há muito tempo e...
<p>- Elton...
<p>- Eu sei o que vai dizer, por isso deixa eu falar tudo e depois você pode dizer seu “não”. Talvez eu te convença. 
<p>- Eu não sei, não.
<p>- Emily, a gente se conhece já faz uns quatro anos, certo? Você sabe mais da minha vida do que qualquer pessoa que eu conheço. Isso é importante para mim.
<p>- Também é importante para mim. Você é meu... amigo. – Seria deselegante falar “colega”.
<p>- Eu não quero ser só seu amigo.
<p>- Mas...
<p>- Olha, eu também conheço você. Sei o tipo de garota que você é. 
<p>- Como assim?
<p>- Você merece tudo, Emily. Você merece um cara que faça você se sentir a garota mais especial do mundo. Que te faça sorrir e que te faça feliz. 
<p>- Elton...
<p>- Eu quero fazer você sentir aquela coisa de alma gêmea, sabe? Aquela música que finalmente faz sentido, fazer tudo ficar bem, te apoiar sempre. Ser seu melhor amigo, ouvinte, conselheiro, te abraçar, te dar força. Eu quero ser tudo isso para você, porque você já é tudo para mim. Estamos nós dois juntos nessa cidade enorme, tem que ser um sinal.
<p>- Elton... – Emily estava bastante assustada e sabia que estava transparecendo. Elton só não queria ver.
<p>- Eu me apaixonei por você assim que eu te vi. Eu sabia que tinha que ir falar com você. Estar com você me deixa feliz e calmo e com o pensamento de que tudo vai dar certo. Eu não quero sentir essas coisas com outra pessoa. Eu quero sentir com você, eu já sinto com você. 
<p>- Eu sinto muito...
<p>- Calma.
<p>- Mas eu não posso.
<p>Emily se levantou da cadeira e isso deixou Elton surpreso.
<p>- Você é meu amigo e você me conhece bem. Mas essas coisas... eu não sinto por você. Eu sinto muito. 
<p>- Mas você pode sentir.
<p>- Não. Ou você sente ou não sente. Não dá para forçar.
<p>- E o que vai fazer agora? Vai atrás dele, não vai?
<p>- Eu acho que sim.
<p>- Emily, isso é uma loucura. Ele não está aqui, eu estou.
<p>- Mas eu o amo. E mesmo eu dizendo que quero seguir em frente, eu sei que isso nunca vai acontecer e eu não quero que aconteça, porque...
<p>- Você o ama.
<p>- Você também merece ser correspondido. Você é incrível, mas não perde seu tempo comigo. Vai atrás da sua garota.
<p>- Vai atrás do seu garoto. – Elton falou um pouco desanimado.
<p>- Muito obrigada.
<p>Emily deu um beijo no rosto de Elton e saiu correndo do restaurante.</p> 
<center><h4>--*--</h4></center>
<p>- Eu preciso que você me faça um favor!
<p>Emily chegou no apartamento toda ofegante e foi direto para o quarto. Allison, que estava na sala sentada no sofá assistindo televisão, se assustou.
<p>- O que houve no encontro com o Elton? Foi tão ruim assim? Não durou nem meia hora.
<p>- Compra uma passagem de avião para mim agora! – Emily gritou do quarto.
<p>- Para onde? – Allison sorriu.
<p>- Você sabe para onde!
<p>- O que te fez mudar de ideia? – Allison pegou o notebook para comprar a passagem no site da companhia aérea. – O encontro com o Elton foi mesmo ruim, hein.
<p>- Você tem razão. – Emily apareceu na sala já com uma mala pronta. Ela estava com tanta pressa que nem percebeu que seu coque tinha se desfeito e agora seu cabelo estava solto e todo despenteado.
<p>- Tenho?
<p>- Eu posso trabalhar em qualquer lugar, mas não vou sentir por qualquer um o que eu sinto pelo Jason. Eu posso ter os dois.
<p>- Claro que pode. 
<p>- Quer dizer, eu nunca vou ser completamente feliz se tiver uma ótima carreira, mas se não tiver ninguém para compartilhar, nem vai valer a pena.
<p>- Jason é o seu cara?
<p>- É.
<p>- Então vai lá dividir seu sucesso com ele. Tenho certeza que com o seu currículo, qualquer empresa contrataria você. E eu vou ter o apartamento só para mim. Sem bagunça, só meu. – Allison brincou.
<p>- Eu o amo. – Emily sorriu. – Eu o amo. EU O AMO!
<p>- Vai logo. Seu voo é... – Allison olhou para o computador. – ... às oito.
<p>- Então eu tenho que correr.
<p>- Me liga depois. Quero todos os detalhes.
<p>- Pode deixar.</p>
<center><h4>--*--</h4></center>
<p>Emily não esperava chegar a tempo da inauguração do bar de Jason, já era muito tarde, mas também não esperava que o voo se atrasaria e que pegaria mal tempo no caminho. A viagem quase levou o dobro do tempo planejado. 
<p>O sol já estava nascendo quando Emily pisou no aeroporto de Los Angeles. Ela pensou em ligar para Jason avisando, mas queria mesmo era a surpresa, queria ver a cara dele quando a visse ali. 
<p>Ela apertava bem firme o papel do endereço do bar enquanto estava no taxi. Sua ansiedade estava grande e seu coração batia a mil.
<p>- Com licença.
<p>Emily entrou no bar. O lugar estava bem arrumado e organizado, mas vazio, normal, ainda era muito cedo, pensou ela.
<p>- Pois não? – A garota atrás do bar abriu um sorriso. – A primeira cliente. O que você vai querer?
<p>- Eu queria falar com o Jason, ele está por aqui?
<p>- Bom, ele mora em cima do bar. – Ela apontou a escada no fundo do bar. – Mas deve estar dormindo ainda.
<p>- Ah, não tem problema, ele não vai se importar de ser acordado.
<p>- Mas ele...
<p>Emily ignorou a garota, deixou a mala jogada no chão e subiu as escadas correndo.
<p>- O QUE VOCÊ QUER, TAMPA? EU JÁ VOU! – Jason ouviu as batidas na porta.
<p>Jason se assustou quando a abriu. Ele tinha acabado de acordar, seu cabelo e seu rosto estavam amassados, estava usando seu short de dormir que Emily conhecia bem e estava sem camisa.
<p>- Emily? – Ele arregalou os olhos vermelhos de sono.
<p>- Eu sou uma idiota. Você é idiota, nós dois somos idiotas, na verdade.
<p>- Emily...
<p>- Eu te amo. – Ela entrou no quarto. -  Eu te amo e você me ama, a gente pode dar certo. Eu sei que parece loucura, mas eu te amo mais que tudo nessa vida e isso não vai passar e eu nem quero que passe. – Esse era o discurso que ela havia praticado no avião.
<p>Emily parecia uma desesperada.
<p>- Eu sei que podemos dar certo. A gente só precisa tentar mais, eu não quero desistir, porque eu só penso em você o tempo todo e... Fala alguma coisa.
<p>- Ah, você me deixou surpreso, eu... achei que não apareceria. – Jason passou a mão pelo rosto.
<p>- Eu sou uma mulher cheia de surpresas. – Ela sorriu.
<p>- Verdade. – Jason riu ainda chocado.
<p>- O que você acha?
<p>- Eu te amo. E te ver aqui é...
<p>- Eu sei. Olha, eu tenho um plano e... – Então ela parou de falar após ouvir um barulho. – Tem alguém no seu banheiro?
<p>- Não. Olha, vamos descer... – Jason pegou a camiseta que estava jogada no chão e a vestiu. – A gente toma alguma coisa, café da manhã, sei lá e conversa e... – Ele parecia muito nervoso.
<p>- Jason, o que está havendo?
<p>- Eu... Eu não achei que você fosse aparecer.
<p>- Como assim?
<p>- Jason, eu não achei uma toalha, tem como você me mostrar onde tem uma?
<p>Uma garota totalmente nua e molhada saiu do banheiro de Jason.
<p>- Ah... – Jason encarou Emily. Ela que estava chocada agora.
<p>- Eu não sou uma idiota, você é.
<p>- Ai, me desculpa. Que vergonha. – A garota voltou para o banheiro correndo.
<p>- Emily...
<p>- Você é um idiota, um babaca, um canalha, e...
<p>- Emily...
<p>- Você é um filho da mãe!
<p>Emily deu um tapa bem forte na cara de Jason.
<p>- Seu desgraçado.</p>
</body></html>";
            }

            if (numero == 6)
            {
                lblTitulo.Text = "Capítulo 6 - Time de Dois";
                htmlPage.Html = @"<html><body>
<p>- EU ODEIO VOCÊ!
<p>- EMILY, ME DEIXA EXPLICAR, CARAMBA!	
<p>Amber se assustou quando viu Emily e Jason descendo as escadas correndo.
<p>- Querem beber alguma coisa? – Amber falou.
<p>- Você é um otário. Parece que é movido a mulher, vai te matar não enrolar com uma por uma noite? – Emily continuava falando alto.
<p>Os dois pararam no meio do bar ignorando Amber completamente.
<p>- A gente terminou. – Jason falou.
<p>- Corrigindo, você ficou maluco e foi embora. E se já tinha superado, por que me ligou?
<p>- Bom...
<p>- Se você não me queria, por que pegou a droga do celular e ligou para mim? – Emily pegou seu celular do bolso e tacou na barriga de Jason.
<p>- Por que não chegou mais cedo?
<p>- Desculpa, eu não sabia que eu tinha hora marcada.
<p>- Não, você... Que ódio! Eu estava me sentindo um fracasso, eu estava bêbado. Era a... a garota que eu não faço ideia de quem seja ou a Tampa. – Jason apontou para Amber.
<p>- Tampa? – Emily franziu a testa. – Seu nome é Tampa? – Ela encarou Amber descrente. – Por que seu nome é Tampa?
<p>- Era Tampa ou Playmobil. – Jason respondeu. – Já viu o tamanho dela?
<p>- Eu também não sou alta.
<p>- Mas você é a Emily. 
<p>- Você é muito idiota. – Emily começou a rir. – De onde tira essas coisas? E eu não quero rir porque ainda estou com raiva de você.
<p>- E eu estou feliz que esteja aqui. Quer dizer, o celular na barriga doeu, mas... 
<p>Emily continuou em silêncio esperando pelo resto do discurso.
<p>- Me desculpa. Eu não deveria... Eu nem sei porque eu fiz. – Jason olhos nos olhos dela. – Que bom que está aqui. Preciso de você mais do que nunca.
<p>- E dizem por aí que você ainda é o amor da minha vida. – Emily revirou os olhos. – Eu não... – Ela queria dizer que não o perdoava, mas não terminou a frase. 
<p>- Ah, que lindos. – Amber estava encostada no balcão ouvindo a briga toda.
<p>- Cala a boca. – Jason olhou para Tampa de cara feia.
<p>- Jason! – Emily gritou.
<p>- O quê? Ela não é paga para falar. Na verdade, ela nem está sendo paga. O que você ainda está fazendo aqui?
<p>- O segundo dia é o dia da sorte. – Amber sorriu. – Hoje é o dia. 
<p>- Eu não gosto de você. É sério, não gosto. – Jason bufou.
<p>Dez minutos depois, o bar estava aberto, a garota no quarto do Jason desceu já vestida, se despediu dos três de longe e foi embora, Jason mencionou algo sobre a caminhada da vergonha, depois ficou com vergonha também de encarar Emily nos olhos.
<p>Ele, Emily e Amber se sentaram perto do balcão e nenhuma viva alma entrou no bar o dia todo.</p>
<center><h4>--*--</h4></center>
<p>- Diga que eu sou um fracasso, um perdedor do inferno.
<p>- Você não é nada disso.
<p>Já eram quase dez da noite. Amber havia ido embora às oito depois que Jason a convenceu que ninguém apareceria. Naquele momento, ele e Emily fingiam que estavam tomando a vodca que abriram fazia uma hora, mas ainda estava cheia.
<p>- Eu sou sim. Me diz o que eu fiz direito nesses quatro anos. Nada.
<p>- Eu não sabia que você era um bêbado depressivo. – Emily riu.
<p>- Na verdade, isso tudo é um jogo. Eu finjo que estou triste, você fica com dó e dorme comigo.
<p>- Então você quer sexo por pena?
<p>- Sexo é sexo. – Ele riu.
<p>- Claro, até com desconhecidas serve.
<p>- Eu... – Mas ele não tinha nenhuma explicação para aquilo. – É verdade o que você me disse? Quer mesmo voltar comigo? 
<p>- Eu não sei mais.
<p>- É sério?
<p>- Eu não devia ter ficado brava hoje de manhã. Não temos mais nada, você podia ter ficado com quantas quisesse. Eu fiz um ataque por nenhum motivo.
<p>- Devia sim. Mesmo não estando juntos, sempre estamos juntos. – Jason sorriu e bebeu um gole de vodca. – Eu sempre faço essas coisas. Na verdade, eu precisava ficar com aquela garota para sentir alguma coisa... Me sentir satisfeito, sei lá.
<p>- Satisfeito? Vai usar mesmo essa palavra?
<p>- Meu vocabulário é curto. – Jason riu.
<p>- Me conta.
<p>- O quê?
<p>- Tudo. 
<p>- Num dia desses, eu estava quase surtando. Eu não acreditava em crise existencial até finalmente ter uma. Eu tenho vinte dois anos e se eu morrer amanhã, eu não vou deixar uma marca, senti como se esses vinte anos tivessem sido perdidos. 
<p>- Você já tem uma marca. Acha que alguém vai ser tão idiota quanto você nesse mundo? Um dia vão te estudar, escuta o que eu estou te dizendo. – Os dois sorriram.
<p>- Quando me veio a ideia louca de comprar um bar foi... Foi como uma luz no fim do túnel, foi como se finalmente eu tivesse um objetivo, e aí eu não pensei mais em outra coisa. Eu tinha algo para construir e dediquei todas as vinte quatro horas que eu tinha para realizar isso. E foi um fracasso. Eu vou ter que devolver tudo isso em alguns dias e...
<p>- Você tem mais alguns dias então. Tenta de novo.
<p>- Emily...
<p>- A vida é feita de tentativas. 
<p>- Por isso que você veio até aqui? Para tentar de novo?
<p>- Eu vim até aqui por vários motivos e mesmo assim eu ainda estava com dúvida, aí eu escutei uma música idiota no rádio do Uber, <i>Shut Up and Dance</i> e só consegui pensar em você.
<p>- <i>Shut Up and Dance</i>? Que parte?
<p>- A parte que ele fala que nascemos para ficar juntos.
<p>- E nascemos.
<p>- E por que sempre me dá um medo quando chego perto de você? 
<p>- Queria saber também porque sinto o mesmo. 
<p>- Eu odeio a gente. – Emily bateu no balcão e começou a rir.
<p>- Calma, garota.
<p>- Na verdade, eu tenho que ir embora.
<p>- Mas já? – Jason até se levantou da cadeira.
<p>- Vou dormir no avião e chegar amanhã para trabalhar que nem uma louca, mas a vida é assim.
<p>- Mas eu nem tive tempo de dormir com você.
<p>- E nem vai ter.
<p>- Ganho um beijo pelo menos?
<p>- Não. – Emily também se levantou.
<p>- Emily?
<p>- Se eu te beijar, eu vou querer dormir com você, então não. 
<p>- Então você vai sair correndo?
<p>- É exatamente isso que eu vou fazer. 
<p>Emily pegou suas malas que estavam em um canto do bar, se virou para Jason, o olhou por alguns segundos e saiu do bar.
<p>- Essa garota é louca. 
<p>Jason se virou para o balcão e virou o copo de vodca de uma vez só. Ele então ouviu a porta do bar se abrir de novo.
<p>- Olha, quer saber?! – Emily gritou.
<p>- O quê? – Jason olhou para ela um pouco assustado.
<p>- Eu posso ligar para o meu chefe e dizer que eu peguei uma gripe ou algo mais sério.
<p>- Febre amarela.
<p>- Isso, febre amarela. 
<p>Emily largou suas malas na porta e correu para beijar Jason. 
<p>- Eu amo você. – Jason a beijou sorrindo.
<p>- Eu sei.</p> 
<center><h4>--*--</h4></center>
<p>Jason odiava quando estava dormindo e o sol batia no seu rosto. Ele precisava urgentemente comprar uma cortina para colocar naquela janela.
<p>- Bom dia. – Ele logo se virou para abraçar Emily, mas ela já estava acordada e sentada na cama mexendo no seu notebook. – Você não dormiu?
<p>- Só um pouco. – Ela não parecia mesmo com sono, parecia uma louca olhando para a tela do computador.
<p>- O que você está fazendo? 
<p>- Eu liguei para o meu chefe e disse que estava com conjuntivite. Ele disse que eu não preciso me preocupar em ir trabalhar essa semana.
<p>- Que ótimo. Você pode então desligar esse computador para gente aproveitar esses dias. Podemos ficar nessa cama que nem coelhos.
<p>- Nada disso. – Emily olhou feio para ele.
<p>- Por que não?
<p>- Você sabia que cinco bares faliram nesse bairro só nesse ano?
<p>- Não.
<p>- E sabia que você tem que inovar sempre se quiser manter o seu bar no ranking dos 100 melhores bares de Los Angeles?
<p>- Também não. O que você andou fazendo essa noite?
<p>- O que você pesquisou para comprar um bar?
<p>- Quanto custava uma latinha de cerveja.
<p>- Jason!
<p>- O quê? Eu sou novo no negócio. – Jason deu de ombros enquanto se sentava para olhar para a tela do computador também. 
<p>- Vamos tentar uma coisa nova então.
<p>- Como assim?
<p>- Aqui é Los Angeles, você não pode simplesmente abrir um bar comum, tem que abrir O Bar. 
<p>- O Bar, gostei do nome. Mas o que eu posso fazer? Colocar um fliperama?
<p>- Sei lá, talvez contratar uma banda.
<p>- Emily, eu mal tenho dinheiro para pagar a Tampa.
<p>- Você só precisa atrair clientes, depois pagar fica mais fácil.
<p>- Falou como se eu não soubesse disso. – Jason fez sua cara de obvio. – Eu até fiz um site e ele ficou incrível.
<p>- É, ficou mesmo. Eu não fazia ideia que você fazia essas coisas. – Ela arregalou os olhos. – Mas não adianta ter um site perfeito se não tem ninguém para ver.
<p>- Disse outra coisa óbvia.
<p>- Você quer ser positivo? Não vamos conseguir nada com essa atitude. Eu andei pesquisando, podemos colocar noites de karaokê, noite de cinema antigo, noites temáticas, muitas coisas. Uma caixa de som e um projetor não custa tanto dinheiro assim.
<p>- Você pesquisou tudo isso, é? – Jason meio que se sentia orgulhoso.
<p>- Pesquisei, por quê? Não olha para mim com essa cara.
<p>- Com que cara?
<p>- Essa cara de “olha para ela, está me ajudando, com certeza me ama”. 
<p>- Eu não tenho outra cara além dessa. Bom, se temos trabalho a fazer, é melhor levantar logo. 
<p>- Tem razão. – Emily fechou o notebook. – Eu vou tomar banho, a não ser que tenha alguma vadia no banheiro.
<p>- Ah, então foi sexo à três? Por isso eu estou tão cansado.
<p>- Cala a boca. – Ela beliscou o braço de Jason.
<p>- Ai.<p>
<center><h4>--*--</h4></center>
<p>- Bom, eu estava procurando aqui e bandas são muito caras de contratar. 
<p>Jason tomava um copo de café enquanto mexia no notebook de Emily sentado em uma das mesas do bar.
<p>- Lógico, olha as bandas que você está procurando. – Emily apontou para a tela do computador.
<p>- O que tem de errado?
<p>- O Green Day nunca vai vir cantar em um bar desconhecido e ainda cobrar barato. 
<p>- Por que não?
<p>- Jason!
<p>- O quê? Tudo bem. – Ele se deu por vencido. – Mas até as aspirantes são caras. Como vão ficar famosos se cobram tudo isso para se apresentarem? Espero que fiquem no anonimato para sempre.
<p>- Olha, eu tenho uma amiga no trabalho, ela tem contato com muita gente e me deu alguns números de blogueiros e youtubers.
<p>- Para que precisamos de blogueiros? – Jason fez uma cara de espanto.
<p>- Para propaganda. – Emily falou como se fosse óbvio. – Achei que tinha morado com uma publicitária por quatro anos, ela não te ensinou nada? Se esse pessoal vier para cá, vão escrever e falar sobre O Bar e seus seguidores vão se interessar.
<p>- Faz sentido.
<p>- É claro que faz.
<p>- Bom, não tenho orçamento para contratar o Green Day, então quem eu contrato?
<p>- Uma banda cover, sei lá. 
<p>- Será que alguém faz cover dos Rogue? – Jason começou a digitar.
<p>- Eu nem sabia que essa banda existia, quanto mais um cover.
<p>- Esqueci, você escuta coisas ruins. Tem o telefone da Taylor Swift aí?
<p>- Cala a boca. – Ela deu um tapa no ombro dele.
<p>- Na questão de publicidade, eu tenho outra ideia além do pessoal da internet. Eu consigo fazer um algoritmo que roda na internet para liberar avisos, anúncios e notificações por aí falando sobre O Bar, como eu não pensei nisso antes?
<p>- Eu ia te perguntar o que é algoritmo, mas deixa para lá. Só faz. 
<p>- Sabe, ficar pesquisando essas coisas me deu vontade de ir em algum show. O que você acha? Topa sair hoje à noite?
<p>- Como um encontro? 
<p>- Não, já passamos dessa fase. 
<p>- Que fase estamos?
<p>- Eu não sei, mas ainda quero muito ir em um show. O que você acha?
<p>- Só compra os ingressos. – Ela piscou para ele.</p>
<center><h4>--*--</h4></center>
<p>- Eu não sabia que você curtia The 1975. – Emily olhou surpresa para Jason.
<p>Os dois estavam sentados em uma das primeiras filas do show, a quarta talvez. Aquele lugar estava cheio e barulhento.
<p>- Eu não curto, devo ter ouvido uma ou duas músicas deles.
<p>- E por que me trouxe aqui?
<p>- Porque eu sei que você curte e porque era o show mais barato de hoje. Eu estou em crise, lembra?
<p>- É verdade. – Ela riu.
<p>O show começou. Era incrível como aquela <i>vibe</i> fazia Jason ficar bem, claro que a música sendo boa ajudava bastante, mas tinha algo a mais.
<p>- Eles poderiam ir cantar no bar, não poderiam?! – Ele gritou no ouvido de Emily.
<p>- Eu duvido você conseguir falar com eles! – Ela gritou em resposta.
<p>- Quer apostar?!
<p>- Quero! – Emily o desafiou.
<p>- Sabe que eu nunca perco uma aposta, não sabe?! Você me conhece!
<p>- Tem uma primeira vez para tudo!
<p>- Obrigado por acreditar em mim! – Jason não sabia terminar uma conversa sem ironia.
<p>Jason passou o resto do show pensando no que faria para conseguir falar com os caras da banda. Quando o show acabou, ele já tinha todo um plano na cabeça, tinhas muitas falhas, muitos pontos para o fracasso, mas foi tudo o que ele conseguiu pensar em uma hora e meia.
<p>Emily e Jason saíram da casa de show e ficaram do outro lado da rua esperando todo mundo ir embora. Logo em seguida, deram a volta por fora até chegarem perto de uma das portas dos fundos.
<p>- O que estamos procurando? – Emily não entendiam nada. – Vamos ficar rodeando até um sair?
<p>- Não, olha só aquele segurança ali naquela porta. Eles estão ali. – Jason apontou.
<p>- Como você vai passar por ele? Você é alto, mas ele também e é grande.
<p>- Eu não preciso brigar com ele, eu tenho outro plano. Agora solta o cabelo e abaixa um pouco a sua blusa.
<p>- O quê? – Emily ficou horrorizada.
<p>- Para os seus peitos ficarem mais amostra.
<p>- Eu sei o que acontece se eu abaixar mais a blusa. Eu não vou fazer isso.
<p>- Você quer entrar ou não? Relaxa, não vai acontecer nada. Só temos que entrar no personagem.
<p>- Que personagem? Você é maluco.
<p>- Vamos logo. 
<p>Jason desabotoou sua camisa e ficou com o peito de fora, bagunçou mais o cabelo que já estava bagunçado e amassou um pouco a barba. Depois de relutar um pouco, Emily acabou seguindo e fazendo o que ele queria.
<p>- O que eu não faço por você? – Ela reclamou.
<p>- Essa é a minha garota.
<p>Ele pegou o celular do bolso e começou a falar como se estivesse conversando com alguém. Pegou a mão de Emily e os dois começaram a andar rápido em direção a porta.
<p>- ... Olha, eu não aceito essa quantia, é ridícula... Você pode abrir a porta logo, eu estou com pressa. – Jason encarou o segurança. – Será que eu vou ter que demitir alguém?
<p>O segurança o encarou por alguns segundos e depois abriu a porta.
<p>- ... É, eu tive um problema com um otário aqui, olha, vamos falar do contrato depois. – Jason continuou fingindo que falava no telefone até os dois estarem dentro do lugar.
<p>- Eu não acredito, como você fez isso? – Emily começou a rir enquanto arrumava a blusa e prendia o cabelo.
<p>- Eu vi isso em uma série uma vez. Eu não acredito que deu certo. – Jason abotoou a camisa enquanto comemorava. 
<p>- O que a gente faz agora?
<p>- Bom, agora, a gente só... – Jason então viu o vocalista da banda parado uns poucos metros de distância. – Como é o nome dele? – Ele cochichou para Emily. – Qual é o nome dele? 
<p>- Matthew.
<p>- Matt, oi, dá licença? – Ele foi em direção do cantor.
<p>- Matt? – Emily fez uma careta.
<p>O cara olhou para Jason e ficou nítido que ele estava tentando reconhece-lo.
<p>- Ah, você não me conhece. Eu sou o Jason e ela é a Emily e...
<p>- Por que estão aqui? Eu preciso chamar o segurança?
<p>- Não, é que... Eu estou abrindo um bar, e eu gostaria muito, seria muito importante se você e sua banda cantasse na inauguração.
<p>- Ligue para o nosso agente, ele resolve essas coisas, ele vai passar os preços e tudo...
<p>- Não, espera. É que... – Will pensou rápido. Precisava de um discurso. – Eu estava lá no primeiro show de vocês anos atrás e foi incrível, desde aquele dia eu faço de tudo para ir em qualquer lugar que vocês estejam cantando, a energia que eu senti naquela noite foi fora do comum, é incrível, isso sempre muda, é como se eu ouvisse vocês pela primeira vez sempre.
<p>- Onde está querendo chegar?
<p>- Seria uma honra para mim ter vocês no bar só por uma noite. Quer dizer, eu não posso pagar muito, não tudo que vocês merecem, e na verdade, vão precisar me ajudar mais do que serão ajudados, mas eu quero que os meus clientes sintam o que eu senti e sinto até hoje quando vejo vocês cantarem. Eu quero que a música de vocês toque eles, assim como me tocou. Isso é muito importante para mim.
<p>- Olha, cara, eu não sei... – Matthew ainda estava na dúvida.
<p>- O lugar é pequeno, não vai ter alvoroço, eu prometo, e se vocês quiserem, eu nem conto para ninguém que vocês vão chegar lá, vai ser tipo algo de surpresa, sei lá. Eu estou desesperado porque eu quero muito vocês lá. Seria a realização do meu sonho.
<p>O cara ficou em silêncio por alguns segundos. A mão de Jason tremia.
<p>- Sem alvoroço. – Aquelas palavras congelaram o corpo de Jason.
<p>- Com toda certeza.
<p>- Me passem o endereço e o horário.
<p>- Ai, meu Deus. – Jason até respirou aliviado. Ele tinha conseguido.</p>
<center><h4>--*--</h4></center>
<p>- Você mentiu para mim.
<p>Emily e Jason estavam deitados na cama no quarto em cima do bar que reabriria em alguns dias.
<p>- Menti nada. 
<p>- Disse que não gostava dos The 1975.
<p>- E eu não disse isso, só disse que conhecia poucas músicas.
<p>- Mas...
<p>- Eu menti, Emily. Eu nunca fui a um show deles. Eu só falei aquelas coisas para mexer com o ego dele. Falei o que ele queria ouvir.
<p>- Não entendi.
<p>- Sabe quando você não gosta de uma pessoa sem nenhum motivo, você simplesmente olha para ela e diz “odeio você”? Mas você tem que conviver com ela e não tem como se darem bem porque você simplesmente não gosta dela, não tem como explicar. O que você faz?
<p>- Não sei.
<p>- Você finge. Você coloca a sua melhor cara, xinga a pessoa mentalmente, mas por fora vocês são colegas, porque você diz as coisas que ela quer ouvir. Você não pode discordar de nada, porque você já odeia ela, se discordar, vai formar uma briga e aí a coisa fica feia. Por isso, você fala uma coisa legal e dá risada do nada.
<p>- Você é horrível, sabia? – Emily estava de boca aberta. 
<p>- Eu sei. 
<p>- Não, eu estou falando sério. Quase chorei de emoção na hora e agora você está me dizendo que era mentira. Como eu vou acreditar em você agora?
<p>- Eu não consigo mentir para quem eu conheço, não sou tão cara de pau assim, você perceberia, além do mais, não consigo fingir que gosto de alguém que eu odeio se tiver alguma razão para eu odiar essa pessoa. Acha que é fácil ser eu? Não é nada fácil ser eu.
<p>- Na verdade, eu estou precisando é de umas aulas. Queria lidar com as pessoas assim como você lida.
<p>- Na base do xingo e violência?
<p>- Não. Só ter uma solução. 
<p>- Está acontecendo algo que eu não sei? Sua colega de quarto é uma psicopata?
<p>- Tem uma garota na empresa. Ela é falsa, dissimulada e está doida para puxar o meu tapete. Agora que está sozinha lá, deve estar fazendo de tudo para roubar o meu lugar.
<p>- Sabe que o mundo é dos mais fortes, não sabe? Se ela faz tudo isso, você tem que fazer também só que melhor.
<p>- Esse é o seu conselho? Eu não vou ferrar uma pessoa só porque ela está me ferrando.
<p>- Por que não?
<p>- Eu não vou combater fogo com fogo. Isso acaba saindo do controle.
<p>- Tudo bem, então... Você é incrível, não precisa se sentir ameaçada por ela. Você vai arranjar um jeito para se livrar dela nos seus termos. Mesmo que os meus sejam melhores. 
<p>- É tão estranho.
<p>- O quê?
<p>- Lembra quando eu disse que te ver me dava medo? 
<p>- Lembro.
<p>- Deitada aqui eu me sinto a pessoa mais protegida do mundo. E forte.
<p>- Como se pudesse fazer qualquer coisa. 
<p>- Exato.
<p>- Isso porque somos um ótimo time. Um sempre protege o outro. 
<p>- Mesmo um em cada ponta do país?
<p>- Eu também não sei o que estamos fazendo, tá bom? Eu só sei que eu nunca teria feito aquilo que eu fiz hoje se eu não estivesse com você. E tem o lance do algoritmo que eu não pensei até conversar com você. Você me deixa melhor.
<p>- Eu sei o que quer dizer.
<p>Emily pegou na mão de Jason.</p> 
<center><h4>--*--</h4></center>
<p>Nos dias que se seguiram, Emily e Jason fizeram vários panfletos anunciando a reabertura do bar e começaram a espalhar pela cidade toda. O algoritmo também rodava e sempre que eles pesquisam bar no Google, O Bar e sua reinauguração era o primeiro anúncio que aparecia.
<p>Jason acordou no dia da inauguração um pouco tenso. Na verdade, muito tenso. Emily riu com o seu nervosismo muitas vezes naquele dia, e mandou ele relaxar um milhão de vezes, mas ele só conseguiu realmente relaxar quando viu seu bar cheio pela primeira vez.
<p>- Eu não acredito, Tampa, está dando tudo certo. – Jason foi até o balcão para ver se Amber estava se virando bem.
<p>- Eu nunca vi tanta gente em um lugar só. E meus drinques estão sendo elogiados por todo mundo. – Ela dava pulinhos de felicidade.
<p>- Mais que sua obrigação, não é, filhinha?
<p>A banda The 1975 chegou no horário marcado e aquele lugar explodiu de palmas e gritos. Jason se desculpou com os olhos por ter prometido um lugar sem alvoroço. Ele realmente se sentiu tocado com aquelas músicas e seu discurso “falso” acabou se tornando verdadeiro. Emily estava do outro lado do bar toda animada com todas as músicas na ponta da língua.
<p>- Bem, eu sei quando você está por perto porque eu conheço o som do seu coração – Jason foi até ela. Seus olhos brilhavam.
<p>- Como está? – Ela ignorou a citação da música.
<p>- Está linda.
<p>- Eu não estou falando de mim, bobo. Como está tudo? – Ela riu sem graça.
<p>- Foi mal, mas agora eu só estou vendo você.
<p>- Cala a boca e vem dançar comigo.
<p>- Música errada. – Jason riu.</p>
<center><h4>--*--</h4></center>
<p>- Então, como nos saímos hoje? – Emily tinha acabado de fechar a porta do bar. Era quase duas da manhã.
<p>- Bom... – Jason estava com o dinheiro todo espalhado em uma mesa. – Boas notícias, eu vou conseguir pagar a banda e a Tampa.
<p>Amber comemorou batendo palmas lá do fundo do bar. Ela estava no computador vendo se alguém havia postado algo sobre O Bar.
<p>- Também vou poder pagar uma parte do bar e... dá para liquidar toda a dívida com a distribuidora de bebidas esse mês e só em uma noite. – Jason bateu forte na mesa de animação.
<p>- Eu disse que ia dar certo. – Emily beijou a boca de Jason também bem animada. – E o dinheiro dos créditos?
<p>- A máquina está carregando, eu ainda não peguei o valor, mas já é uma vitória. Somos mesmo um grande time.
<p>- Ainda tinha dúvidas?
<p>- Superhomem e Supermulher ativar. – Jason fechou a mão e deu para Emily tocar.
<p>- Ativar. – Emily fez o toque e começou a rir assim que Jason abriu a mão e fez um barulho estranho com a boca.
<p>- Gente, vem aqui! – Amber gritou. – Um blogueiro postou sobre o bar.
<p>- Só espero que seja um que tenha vários seguidores. – Emily correu até Amber.
<p>Jason juntou todo o dinheiro e colocou de volta na caixa registradora, depois foi até Amber e Emily.
<p>- Pode ler. O que ele está falando do bar?
<p>- Bom... – Amber começou a ler. – “Voltamos depois de tanto tempo e Los Angeles não para de me surpreender. Qual é o motivo? O Bar. Exatamente, um bar que se chama O Bar, seria ridículo se não fosse genial e é genial. Um lugar confortável com gente legal e uma boa música, ótimas bebidas e clima perfeito. Essa foi a minha primeira vez n’O Bar e não vai ser de jeito nenhum a última. Eu recomendo a todos que me seguem e até quem não me segue. Esse bar não pode ficar escondido. É, Jason, eu acho que você finalmente venceu.”. Isso é incrível. – Amber bateu palmas depois que leu.
<p>- Nossa, ele sabe até meu nome. Não me lembro de ter dito o meu nome para ninguém. – Jason riu.
<p>- Ele deve ter ouvido a gente conversar. Esse povo é bem abelhudo. – Emily tentou explicar. – Amber, que blog é esse? Algum famoso?
<p>- Ah... Eu nunca ouvi falar dele na verdade, mas tem bastante visualizações. Se chama Tesouro de Segredos Distantes.
<p>- O quê?
<p>E de repente, parecia que Jason tinha visto um fantasma.</p>
</body></html>";
            }

            if (numero == 7)
            {
                lblTitulo.Text = "Capítulo 7 - Aprendizado";
                htmlPage.Html = @"<html><body>
<p>Anna olhava para Temperance sem ao menos piscar. A amiga estava em sua cama lendo um livro aparentemente bem concentrada.
<p>- O que foi? – Temperance olhou de rabo de olho para a colega de quarto.
<p>- Hoje vai ser o primeiro dia. – Anna sorriu.
<p>- Primeiro dia de quê?
<p>- Você vai começar a dar aulas para aquele gatinho do terceiro período.
<p>- Eu não vou dar aulas. Só vou ajudar ele a fazer um relatório. E ele nem é tão bonito assim.
<p>- Você não sai com um cara já faz... quatro anos.
<p>- E você não cuida da sua vida já faz quatro anos. Que tal mudarmos isso?
<p>- Não está nem um pouco ansiosa? E se ele quiser te dar um beijo?
<p>- Eu não estou pensando nisso. Eu nem sei porque aceitei ajudá-lo. – Temperance estava pensando em reconsiderar desde que aceitou.
<p>- Qual é o problema com você?
<p>- Anna...
<p>- Você não vai à festas, não bebe, não namora. Está perdendo a melhor fase. Depois vai entrar em um hospital e não vai sair mais. 
<p>- Olha, eu não sou como você. Eu passei por uns problemas, tá bom? E meu último namorado...
<p>- O quê?
<p>- Eu não consegui lidar. Eu terminei com ele por nenhuma razão. Ele ficou comigo no pior momento da minha vida e depois eu terminei, por quê? Nem eu sei. – Temperance cuspiu as palavras. – Talvez eu não seja para isso, então não fique tão animada. Eu só vou ajudá-lo, não é nada demais.</p>
<center><h4>--*--</h4></center>
<p>- Por que você resolveu fazer medicina?
<p>Norman e Temperance estavam na biblioteca naquela tarde escrevendo o tão esperado relatório. 
<p>- Estamos aqui para estudar, não para bater papo. – Temperance falou sério tirando o sorriso do garoto.
<p>- Mas não podemos ser amigos?
<p>- Olha, eu não tenho tempo para perder. Eu tenho mil matérias para estudar, minha semana de provas está chegando. Eu não quero tirar nota baixa por sua causa.
<p>- Calma. Eu posso te ajudar a estudar.
<p>- Você mal consegue fazer um relatório.
<p>Os dois ficaram em silêncio por alguns minutos. Norman estava tentando pensar no que dizer depois do corte.
<p>- Posso te confessar uma coisa? Eu inventei isso só para me aproximar de você. – Norman deu um sorriso.
<p>- Você é uma besta. – Temperance começou a guardar rapidamente seus livros na mochila bem irritada.
<p>- Não, espera. Vamos conversar.
<p>- Cara, se toca. – Ela se levantou da mesa e colocou a mochila nas costas.
<p>- Eu estou fazendo medicina por causa do meu irmão. Ele tinha uma doença rara e morreu quando eu tinha quinze anos. Eu meio que jurei achar a cura. – Ele falou bem rápido esperando que aquilo fizesse ela ficar.
<p>- Se isso for uma cantada, você é doente.
<p>- Não, é sério. Eu li uma vez que se você conta algo bem intimo para uma pessoa, ela se sente à vontade e acaba retribuindo uma hora ou outra.
<p>- Eu me sinto muito feliz e emocionada só de pensar em poder ajudar alguém de verdade. A sensação de salvar uma vida deve ser a coisa mais magnifica que alguém é capaz de sentir. É por isso que eu estou aqui. Eu preciso sentir. Preciso salvar alguém. – Temperance tirou a mochila das costas e a colocou no chão ao lado da cadeira. Logo em seguida, voltou a se sentar.
<p>- Talvez devesse ser super-heroína. 
<p>- É meu plano B. – Ela sorriu.
<p>- Olha só você fazendo piadas. Estamos progredindo.
<p>- Não fique tão animado. Não vou te ajudar a estudar já que não precisa.
<p>- Mas eu preciso sair, então pode me chamar para um encontro.
<p>- Você está paquerando a garota errada, eu não estou a fim.
<p>- Por que não?
<p>- Não precisa de uma razão. Não é não.
<p>- “Não” pode virar “sim”.
<p>- Não no meu caso.</p>
<center><h4>--*--</h4></center>
<p>- Jason, eu preciso falar com você. – Temperance estava tão ansiosa que nem fez as contas do fuso horário para ligar para seu melhor amigo de outro país.
<p>- <i>Sabe que horas são?</i> – Jason bocejou.
<p>- Muito tarde?
<p>- <i>Tenta de novo.</i>
<p>- Muito cedo. 
<p>- <i>QUATRO HORAS DA MANHÃ!</i> – Jason gritou.
<p>- Olha, é que...
<p>- <i>Oi, Temperance!</i>
<p>Temperance ouviu uma voz de mulher que reconheceu instantaneamente.
<p>- Emily? Jason, você está em Nova York?
<p>- <i>Não, eu que estou em Los Angeles.</i> – Emily falou animada.
<p>- Por que você está falando como se fossemos melhores amigas?
<p>- <i>Porque eu sei fingir. Há!</i>
<p>- Que engraçado. Jason, como foi a reinauguração?
<p>- <i>Foi perfeita.</i> – Jason voltou a falar. – <i>The 1975 cantaram aqui e disseram que vão vir mais vezes e que vão indicar o lugar para outros cantores. Eu vou bombar com esse bar.</i>
<p>- Não esperava menos. Parabéns.
<p>- <i>Obrigado, mas tenho certeza que você não me ligou a essa hora para me perguntar do bar. O que foi?</i>
<p>- Um cara deu em cima de mim hoje. Ele me pediu ajuda para estudar, mas era tudo pretexto. Eu ia te contar sobre isso na noite que me contou que comprou um bar.
<p>- <i>Olha só. Parece que alguém está namorando.</i> – Jason começou a rir.
<p>- Eu não vou ficar com ele. 
<p>- <i>Ele é vesgo, não é?</i>
<p>- Não, ele é bem bonitinho.
<p>- <i>É retardado, débil mental?</i>
<p>- Não. 
<p>- <i>Você ainda é apaixonada por mim?</i>
<p>- Eu nunca fui apaixonada por você.
<p>- <i>Foi sim.</i> – Emily falou e Jason concordou.
<p>- Calem a boca. – Temperance ouviu os dois rindo do outro lado da linha.
<p>- <i>Mas o que você vai fazer?</i> – Jason perguntou. – <i>Você não namora desde o Nathan, e isso faz quatro anos. Ainda sabe beijar pelo menos?</i>
<p>- <i>Jason!</i> – Temperance ouviu a voz de Emily e depois o barulho de um tapa.
<p>- Olha, eu não sei o que eu vou fazer. Eu nem sei se eu quero... Eu não quero, eu sei que eu não quero.
<p>- <i>Se você está dizendo.</i> – Jason falou com aquele tom que Temperance odiava. – <i>Olha, Tempe, já que eu estou acordado, bom.. o Brandon tinha algum irmão?</i>
<p>- O quê? Por que isso agora? – Temperance não entendeu nada.
<p>- <i>Só responde.</i>
<p>- Mas... Não, ele era filho único. 
<p>- <i>Algum amigo além de você, sei lá, alguém que idolatrava ele por usar o cabelo natural?</i>
<p>- Não, ele só tinha a mim.
<p>- <i>Algum primo, prima, sei lá.</i>
<p>- Por que está me perguntando essas coisas? Isso é estranho.
<p>- <i>Não, é que... às vezes eu vejo pessoas usando black power e penso: “será que não é a família do Brandon me perseguindo?”.</i>
<p>- Que piada sem graça, ainda mais agora.
<p>- <i>Emily riu.</i> – Verdade, Temperance tinha ouvido a risada.
<p>- Ela namora você. Não tem moral nenhuma.
<p>- <i>Pelo menos eu não sou zarolho...</i>
<p>- O Norman não é zarolho.
<p>- <i>Na verdade, eu sou uma beleza. São quatro horas da manhã, você me acordou, mas estou olhando no espelho agora e percebi que estou lindo o suficiente para tirar uma foto para ser publicada numa capa de revista. Nossa, eu sou muito lindo.</i>
<p>- <i>Nossa, quanto amor.</i> – Temperance ouviu Emily falar. – <i>Por que eu estou aqui? Você pode se amar o suficiente por nós dois.</i>
<p>- <i>Você adora isso.</i> – Jason respondeu.
<p>- <i>Adoro, não. Acho bizarro.</i> – Emily continuou.
<p>- Olha, gente, eu vou desligar. Não quero ouvir a briga de vocês, muito menos a reconciliação. Tchauzinho.
<p>Temperance desligou o telefone.</p>
<center><h4>--*--</h4></center>
<p>- Você precisa ligar para ele.
<p>Anna não falava de outra coisa desde que Temperance falara para ela sobre o que aconteceu naquela tarde na biblioteca com o Norman.
<p>- Não, eu não vou ligar. Eu nem quero sair com ele.
<p>- Você tem que sair com ele. – Anna parecia desesperada.
<p>- É minha obrigação?
<p>- Óbvio. Ele é um gato. Se você não pegar, eu pego.
<p>- Aí você coloca mais um na sua lista.
<p>- Acabou de me chamar de vagabunda? Porque se chamou, você está bem certa. – Anna gargalhou.
<p>- Eu não sei se eu estou pronta para isso, para namorar, me importar e essas coisas de relacionamento. – Temperance respirou fundo. Estava assustada só de pensar em ligar para Norman. 
<p>- Amiga, não precisa namorar, é só dar uns beijos, já está o suficiente. Não se preocupe tanto, é só um encontro, não seu noivado. 
<p>- O que quer dizer?
<p>- É permitido ficar com uma pessoa uma vez e nunca mais falar nisso. Você tem muito o que aprender. Agora liga para ele.
<p>- Não. Eu vou parecer desesperada.
<p>- Querida, você está desesperada.
<p>Então como uma ninja, Anna pegou o celular da mão de Temperance.
<p>- Anna!
<p>- Se você não vai fazer nada, eu vou fazer.
<p>- Não!
<p>Temperance tentou pegar o celular, mas Anna foi mais rápida e começou a correr pelo quarto enquanto digitava.
<p>- Pronto! – Anna deu uma risada de triunfo. – Ele disse que está ansioso para amanhã à noite.
<p>- Eu vou matar você! – Temperance pegou o celular da mão da amiga e quase deu um tapa na cara dela.
<p>- Vou te emprestar um vestido bem curto e apertado.
<p>- Aproveita e me empresta sua bolsinha.
<p>- Sei que esse é o seu jeito de me agradecer.
<p>- Você é uma ridícula. Não acredito que me forçou a fazer isso.</p>
<center><h4>--*--</h4></center>
<p>Mas na verdade, Temperance não estava se sentindo forçada. Na verdade, ela não pensou em mais nada no dia seguinte. Mal prestou atenção nas aulas e ficou duas horas olhando para o seu guarda roupa procurando uma roupa perfeita para o encontro. 
<p>Ela olhou o celular várias vezes para não perder a hora. Estava nervosa, mil coisas passando pela sua cabeça, coisas boas e coisas ruins. Ela estava enferrujada, não tinha ideia do que ia acontecer. Quando chegou a hora, se sentou na cama para esperar Norman chegar.
<p>Mas ele não apareceu...
<p>Depois de horas, mandou uma mensagem dizendo que teve um imprevisto. Se desculpou centenas de vezes. 
<p>Anna voltou para o quarto bem tarde, Temperance já estava deitada, até fingiu estar dormindo, porque não queria falar sobre aquilo naquele momento. 
<p>De madrugada, ela ouviu seu celular, que estava no criado mudo ao seu lado, vibrar. Era uma mensagem. Ela já reclamou em pensamento achando que era de Norman, mas não era dele.
<p>“Temperance, está tudo bem?”
<p>Era um número desconhecido. 
<p>“Quem é?” Temperance respondeu a mensagem.
<p>“Saiba que eu estou do seu lado, Tempe. Sempre.”.
<p>“Jason? Você está me zoando? Não tem graça.”
<p>“Errou. Seu outro melhor amigo.”.
<p>“Que?”
<p>“Eu ainda te amo, Tempe, mesmo depois de tudo.”.
<p>Temperance desligou o telefone. Era só imaginação. Ela estava sonhando. 
<p>- Não é real, não é real. 
<p>Isso Ás vezes ainda acontecia com ela.
<p>- Não é real. Ele está morto. Ele morreu faz muito tempo. Não é real.
<p>Temperance se deitou de novo, fechou os olhos, mesmo não estando com sono. 
<p>- Não é real. 
<p>Ela queria ligar para o Jason para tentar não pensar no assunto, mas acabaria dizendo isso para ele e passariam a noite tendo uma conversa depressiva e triste sobre Brandon. Tudo o que ela não queria.
<p>- Não é real. Não é real.
<p>Mas era real, sim.</p>
</body></html>";
            }

            if (numero == 8)
            {
                lblTitulo.Text = "Capítulo 8 - Qualquer Lugar, Menos Aqui";
                htmlPage.Html = @"<html><body>
<p>Já eram quase cinco da manhã. Emily e Jason estavam deitados na cama. O braço dele estava em volta dela. Os dois olhavam para o teto. Aquele teto que precisava de uma boa pintura.
<p>- Você não vai dormir mais?
<p>- Como sabe que eu não estou dormindo? – Jason resmungou. – Você nem está olhando para mim.
<p>- Eu não preciso olhar para você para saber que está acordado. Você não para de se mexer, seu coração está batendo muito rápido e às vezes eu escuto murmúrios.
<p>- Eu não...
<p>- Sim. – Emily calou a boca de Jason. – Quer falar sobre isso?
<p>- O que eu tenho para falar?
<p>- Por que não contou para a Temperance sobre o blogueiro quando ela ligou agora pouco?
<p>- Porque pode não ser nada e eu estaria preocupando ela à toa. 
<p>- Você acha que não é nada? – Emily conhecia o Jason. Naquele momento, ele estava com mil teorias na cabeça, uma pior que a outra.
<p>- Eu não acho nada. Só estou esperando.
<p>- Esperando o que, exatamente?
<p>- Outra postagem, sei lá. 
<p>- E se foi só uma coincidência? – Embora Emily tentasse ao máximo deixar Jason desencanado, ela também estava um pouco preocupada. Não era coincidência, impossível ser.
<p>- Eu não... sei lá.
<p>- Jason, o Brandon morreu. 
<p>- Eu sei, Ems. Eu vi a lápide e xinguei ela também. Sem falar que eu fui uma das causas para isso acontecer. 
<p>- Não fala isso.
<p>- Você não pensa nisso? Porque eu penso. – Ele respirou fundo. – O tempo todo.
<p>- Não deveria. A culpa não foi nossa, ele cavou a própria cova. Ele tinha opções.
<p>- Eu sei, mas ainda assim é horrível.
<p>- Você quer mesmo falar sobre isso agora? – Emily abraçou Jason forte.
<p>- Não, mas também não consigo dormir. 
<p>- Amanhã, eu... Hoje, na verdade... Eu vou ter que ir. Meu chefe deve achar que eu já morri. – Emily deu uma risada fraca.
<p>- Que hora é o seu voo?
<p>- Daqui quatro horas para ser bem exata. – Ela olhou o celular que estava no criado mudo. – Eu deveria estar dormindo.
<p>- Deveria. Deveria sim.
<p>- Mas poderia cancelar meu voo e ficar aqui. Na verdade, era o meu plano inicial antes de te pegar dormindo com uma prostituta.
<p>- Ela não era uma prostituta.
<p>- Vai defendê-la? – Emily o encarou.
<p>- De jeito nenhum.
<p>- Ótima escolha. 
<p>- Você só quer ficar aqui por causa daquela garota que está te irritando.
<p>- Na verdade, eu nem pensei nela.
<p>- Então escolheria ficar aqui mesmo tendo uma vida perfeita lá em Nova York?
<p>- Escolheria.
<p>- Para.
<p>- O quê?
<p>- É tão difícil imaginar isso. Quer dizer, eu tenho uma ótima autoestima, eu sei disso, o meu ego é enorme, mas com você...
<p>- Comigo...
<p>- Eu não sou o bastante para você, às vezes eu sinto que você merece mais. Eu sou uma bagunça. Você não precisa lidar com isso. Eu não recomendaria.
<p>- Você me vê como alguém perfeita e isso não é verdade. 
<p>- Perfeita, você? Eu já vi você surtar, na verdade esse discurso todo é para eu tentar me livrar de você. Você é doida e eu tenho medo. – Jason começou a rir.
<p>- Cala a boca. – Emily o beliscou. – A verdade é que eu te amo. Eu nunca teria uma vida perfeita sem você.
<p>- Eu vi o quanto você trabalhou nesses quatro anos para chegar onde chegou.
<p>- Eu sou só uma secretária.
<p>- Você é mais do que isso. Você sabe. E...
<p>- O quê?
<p>- Eu te amo demais para fazer você desistir de tudo isso assim. Eu sei que você ficaria por mim, mas eu não quero que faça isso. 
<p>- Jason... – Emily queria rebater aquilo. – Vai ficar bem sem sim?
<p>- Diferente do que você pensa, eu posso respirar sem você.
<p>- É sério? – Emily riu.
<p>- Sério. 
<p>- O que a gente faz então? 
<p>- Bom, ainda temos três horas. Podemos fazer muitas coisas em três horas. – Ele colocou a mão na perna dela. 
<p>- E depois?
<p>- E depois eu dormi, porque eu vou ficar bem cansado.
<p>- Idiota. 
<p>- Não vamos nos despedir. Não precisamos. Vamos só dormir e... um dia de cada vez.
<p>- Um dia de cada vez.</p>
<center><h4>--*--</h4></center>
<p>Quando amanheceu, Jason sentiu Emily se levantando da cama. Ele poderia ter aberto os olhos, observado ela arrumar as malas e depois se despedido, mas não fez isso. Esperou o barulho da porta sendo fechada, para então assim abrir os olhos.
<p>- Bom dia, chefe!
<p>Amber estava varrendo o bar quando Jason desceu as escadas naquela manhã. Em cima do balcão havia uma bandeja com dois copos de café expresso e alguns bolinhos.
<p>- Você comprou o nosso café? – Jason franziu a testa.
<p>- É, não podemos beber álcool logo de manhã. – Ela sorriu.
<p>- Fale por você. – Jason pegou um litro de vodca da prateleira e virou na boca.
<p>- O que houve? É algum tipo de comemoração?
<p>- Não, Tampa. Não é comemoração. – Ele falou sem paciência. 
<p>- O que está acontecendo?
<p>- Não te interessa, tá bom?
<p>- Nossa, que mal humor. 
<p>- E ainda assim você continua falando comigo. O que eu preciso fazer? Jogar vodca na sua cara?
<p>- Grosso.
<p>- Olha, eu vou dar uma saída. Abre o bar para mim, está bem?
<p>- Claro. Quer seu café?
<p>- Não, obrigado. Pode tomar. 
<p>- Posso levar para Emily lá em cima?
<p>- Ela já foi embora.
<p>- Sério? – Amber fez uma cara triste.
<p>- Não, é só brincadeira. – Jason fechou a cara.
<p>- Ela vai voltar?
<p>- Fica na sua. Tá bom?
<p>Jason deixou a porta aberta quando saiu.</p>
<center><h4>--*--</h4></center>
<p>Se tinha uma coisa que Jason odiava era ficar sozinho naquelas circunstâncias. Não estava muito sol naquele dia. Ele se sentou na areia e ficou um tempo olhando para o mar. Começou a se lembrar de quando estava na escola e matava aula para ir para a praia, aquilo era quase uma rotina. Jason podia ter impedido Emily de ir embora, ele sabia disso. Poderia ter dito o que ela queria ouvir e naquela hora os dois poderiam estar na praia, mas não foi isso que aconteceu e agora ele estava...
<p>- MAS QUE MERDA!
<p>... com dor de cabeça.
<p>- O que foi isso?
<p>Jason olhou para trás. Uma bola de futebol o atingiu na parte de trás da cabeça.
<p>- Cara, foi mal. 
<p>Um homem, de mais ou menos vinte anos com a regata grudada no corpo de tanto suor, se aproximou dele e pegou a bola do chão.
<p>- Qual é o seu problema? – Jason se levantou pronto para armar um escândalo.
<p>- Foi mal, eu estava jogando e... como não tinha quase ninguém na praia, eu chutei um pouco mais forte e...
<p>- E acertou na minha cara!
<p>- Na verdade, foi...
<p>- Na verdade, eu posso acertar a sua cara agora. – Jason fechou os punhos. Ele não tinha medo de uma briga. Os dois tinham quase mesmo tamanho, o mesmo porte físico, ele ia bater mais do que apanhar. 
<p>- Cara, relaxa. – O homem riu.
<p>- Não me chama de “cara”! Eu nem te conheço.
<p>- Tudo bem. Eu sou Daniel, Dan, tanto faz. Qual é o seu nome?
<p>- Olha, meu, pega a sua bola e sai daqui. 
<p>- Por que o mal humor? 
<p>- Eu não... – Jason respirou fundo. – Só cai fora.
<p>Jason voltou a se sentar na areia.
<p>- Por que você está de mal humor? – Daniel se sentou ao lado dele.
<p>- Ah, qual é? Você só pode estar de brincadeira.
<p>- Por quê? É algo óbvio?
<p>- Não, eu só não quero falar sobre isso com você. Como eu já disse, eu nem te conheço.
<p>- Sou Daniel, eu já disse também.
<p>- Não me interessa! – Jason falou mais alto do que gostaria. – Meu Deus, será que eu atraio pessoas chatas? 
<p>- Ou você que é chato. 
<p>- Eu estou sendo obrigado a aturar essa conversa. Por outro lado, você pode simplesmente... evaporar daqui. – Mas Daniel não se moveu. – Você puxa papo com todo mundo na praia? O que você é? Um ajudante de Deus daquelas igrejas estranhas, sei lá?
<p>- Não, é que... Eu não conheço muita gente e nem converso também, então se a pessoa dá uma brecha, eu puxo papo. 
<p>- Eu não dei brecha, você jogou uma bola em mim, depois se sentou do meu lado. 
<p>- Verdade, mas até agora não me bateu, e me bateria se fosse outra pessoa.
<p>- Cara, eu estou com dó de você. Eu não vou te bater.
<p>- Dó de mim? Você que é o rabugento sozinho na praia. 
<p>Jason deu uma risada.
<p>- Ótimo argumento, mas você também está sozinho e está jogando futebol com absolutamente ninguém, é triste. Jason, meu nome é Jason. – Jason estendeu a mão.
<p>- Dan. – Daniel apertou a mão de Jason. 
<p>- Você já disse isso. 
<p>- Prazer.
<p>- Prazer. Olha, Danny, pode se levantar e voltar a jogar seu futebol. Só não confunde a minha cabeça com o gol de novo, eu agradeceria. 
<p>- Não quer jogar?
<p>- Não, eu não jogo. Não curto muito esportes.
<p>- Quer me contar por que está com raiva? – Daniel insistiu. 
<p>- Eu não quero mesmo falar sobre isso. 
<p>- Eu passei a semana retrasada toda procurando emprego. Meu pai foi demitido da siderúrgica em que ele trabalhava, e era a nossa única renda, então eu tive que desistir da faculdade para procurar um emprego. 
<p>- Que barra. – Jason tentou ao máximo não mostrar um olhar de pena.
<p>- E eu tenho uma irmã mais nova, ela tem dez anos. Minha mãe é legal, ela... eu sentia falta da comida dela quando eu estava na faculdade então foi bom voltar. Na verdade, eu queria largar o curso já fazia um tempo. Eu não me sentia bem lá, estava me sentindo sozinho, além do mais, eu só estava no curso porque... não tinha muita escolha.
<p>- Por que está me contando essas coisas?
<p>- Você se sente mais confortável em se abrir depois que a outra pessoa se abre. Na teoria. 
<p>- Você é muito estranho. Sério. 
<p>- Eu sei. – Daniel sorriu. – Sua vez.
<p>- Eu estou com raiva porque queria estar em qualquer lugar, menos aqui.
<p>- Ainda está com raiva de mim?
<p>- Não, não é sobre você. Você tem razão, eu estou sozinho. Eu tenho uma amiga, mas ela mora no Canadá e meus pais, eles... eu não falo com eles faz um tempo. Eu tinha outra amiga que morava comigo, mas a gente brigou e não nos falamos desde então. Já faz umas semanas.
<p>- Brigaram por quê?
<p>- Ela mentiu para mim. Traiu minha confiança e eu sou do tipo que guarda rancor. E tem essa garota que eu amo, mas não consigo ficar com ela. 
<p>- Ela não te ama?
<p>- Ama. 
<p>- Então qual é o problema? – Daniel não entendeu.
<p>- Uma hora ou outra, eu vou estragar tudo. Eu sempre estrago, não importa o quão bem a gente esteja. 
<p>- É nessa hora que eu tenho que te dizer que você precisa dar uma chance? Que você não vai estragar tudo dessa vez e todas essas coisas que você quer ouvir?
<p>- Não, você não pode dizer isso.
<p>- Por que não?
<p>- Porque você não me conhece e não sabe nada sobre mim. Então tudo o que disser será mentira, porque você não sabe.
<p>- Talvez eu saiba.
<p>- Como? Está me perseguindo?
<p>Daniel ignorou a pergunta.
<p>- Eu tenho vinte anos, moro com meus pais e minha irmã aqui mesmo em Malibu. Eu fazia engenharia mecânica, mas sempre quis ser um cantor desde pequeno. Eu até escrevo algumas músicas.  
<p>- O que você está fazendo?
<p>- Eu gosto muito de jogar futebol, então jogo sozinho mesmo, não me importo com isso. Na verdade, eu faço muitas coisas sozinho tipo ir ao cinema, comer em lanchonetes, até ir ao boliche.
<p>- Como você joga boliche sozinho?
<p>- Jogando. 
<p>- Me diz que já namorou, por favor. Não dá para fazer isso sozinho.
<p>- Uma vez só. – Daniel falou envergonhado.
<p>- Você definitivamente é maluco. 
<p>- Tem razão, olha só, você já me conhece, agora é a sua vez.
<p>- Não dá para conhecer uma pessoa em alguns minutos.
<p>- Podemos tentar. 
<p>- Cara, você é muito desesperado. – Jason estava quase rindo.
<p>- Eu preciso de um melhor amigo, aparentemente você também. 
<p>- Você não está com câncer, não é? Nenhuma doença terminal? Você não é do tipo “vou fazer tudo isso antes de eu morrer daqui três meses”? Porque eu não quero amizade com esse tipo de pessoa. Pode não parecer, mas eu tenho coração e vou sofrer quando você morrer.
<p>- Não, eu não estou doente.
<p>- Então...
<p>- Não tem nada de errado em querer fazer amigos. 
<p>- Eu não sou muito de me abrir, principalmente com desconhecidos.
<p>- Cara, eu não sou mais um desconhecido. Eu vou te dar a minha senha do banco e do <i>Facebook</i>.
<p>- Contanto que tenha dinheiro, pode passar a senha sim. Olha, você corre? – Jason se levantou de surpresa. – Se joga futebol, deve correr.
<p>- Eu corro, por quê? – Daniel se levantou logo depois. 
<p>- Vamos correr então. Eu preciso tirar o estresse. E talvez quando eu estiver cansado e de saco cheio de te ouvir falando da sua vida, eu te conte algumas coisas sobre a minha.
<p>- Então vou continuar contando coisas sobre mim enquanto estivermos correndo. Meu aniversário é dia 12 de janeiro, mas odeio ganhar presentes, fico sem graça. Eu sei fazer contas mais rápido do que pessoas normais, mas não me considero um nerd.
<p>- Na verdade, nem começamos a correr e eu já estou de saco cheio. – Jason pegou impulso e começou a correr.
<p>- Por quê?! – Daniel gritou correndo atrás do outro.
<p>- Odeio tagarelas!
<p>- Eu não sou tagarela. – Ele conseguiu acompanhar Jason.
<p>- Você não parou de falar desde que apareceu.
<p>- É porque você é muito quieto.
<p>- Eu não sou quieto.
<p>- É sim. Você não fala nada.
<p>- Tudo bem, eu fui expulso da escola no meu último ano porque eu bati em um cara. Fui um repetente. É legal.
<p>- Estou feliz por você ter falado algo, mas estou chocado pelo ocorrido.
<p>- É uma longa história. 
<p>- Eu não tenho nada para fazer o dia todo.
<p>- Eu sim, eu tenho um bar para cuidar.
<p>- Você tem um bar? – Daniel arregalou os olhos e demonstrou entusiasmo.
<p>- É, eu abri ontem. Você pode trabalhar lá até arranjar um emprego melhor se quiser.
<p>- É sério? – Daniel parou de correr por causa da surpresa.
<p>- É. – Jason parou também. – Não posso te pagar muito, mas...
<p>- Eu aceito. – Daniel falou como se estivesse em um altar.
<p>- Beleza, vamos voltar a correr e depois eu te levo até o bar.
<p>- Tudo bem. Valeu. E eu vou ganhar a corrida.
<p>- Não vai, nada. Eu sou muito competitivo. 
<p>- Droga.</p>
<center><h4>--*--</h4></center>
<p>Jason ficou impressionado quando entrou em seu bar e viu quase todas as mesas ocupadas. Por um momento, naquela manhã, deitado, ele pensou que todo aquele lucro na noite passada havia sido um sonho.
<p>- Esse bar é seu? – Daniel entrou surpreso. – Eu estive aqui ontem na inauguração. Foi incrível o show.
<p>- Esteve aqui, é? Vou começar a achar que você é um <i>stalker</i>. – Jason riu. – Vem.
<p>Os dois foram até o balcão.
<p>- Tampa, está conseguindo dar conta? – Amber estava bem concentrada colocando uma dose de tequila em um copo com uma rodela de limão dentro.
<p>- Só está um pouco corrido. – Amber respondeu.
<p>- Isso é bom, quer dizer que quem veio ontem...
<p>- Gostou tanto que voltou hoje. – Amber, embora estando com uma aparência cansada, parecia animada com aquela informação, até mais que o próprio Jason.
<p>- Eu contratei um ajudante para você. Esse é o Daniel. Vai trabalhar com a gente.
<p>- Muito prazer, Tampa. – Daniel estendeu a mão. – Seu nome é um pouco estranho. 
<p>- O nome dela não é Tampa. – Jason riu. – É... Droga, eu esqueci o nome dela.
<p>- É Amber. – Amber sorriu ao apertar a mão de Daniel. – Muito prazer.
<p>- O prazer é meu. 
<p>- Eu não daria muita corda, logo ela vai estar pulando em cima de você. – Jason alertou.
<p>- Que ridículo. 
<p>Amber juntou os copos que estavam em cima do balcão em uma bandeja de alumínio e os levou para uma mesa.
<p>- Tudo bem, o que eu tenho que fazer? – Daniel esfregou uma mão na outra pronto para trabalhar.
<p>- Bom, pode começar anotando os pedidos e passando para Tampa preparar as bebidas. Mas à noite, eu vou te dar um outro trabalho.
<p>- Tudo bem, eu sou multitarefas. À noite eu faço o que?
<p>- Está vendo aquele palco? – Jason apontou para o palco no fundo do bar onde The 1975 havia se apresentado na noite passada.
<p>- Estou.
<p>- Essa noite, você que vai fazer o show.
<p>- O quê? – Daniel ficou pasmo. – Não. Eu não tenho... Eu não...
<p>- Qual é? Você disse que queria ser cantor. Você deve saber cantar. É o mínimo. 
<p>- Eu sei, mas...
<p>- Eu pensei nisso no caminho para cá. Todo mundo gosta de um bar com música ao vivo. Eu recebi umas mensagens no caminho para cá. Eu e a minha... – Ele ia dizer namorada? – Eu entrei em contato ontem com algumas bandas de garagem. Consegui uma para o próximo final de semana e você pode abrir o show dela também.
<p>- Calma, eu... – Daniel já estava começando a ficar nervoso.
<p>- Você já cantou com plateia antes?
<p>- Sim, mas só de brincadeira, não como trabalho.
<p>- Olha é simples. Você vai se apresentar e vão gostar de você e aí vai conseguir fãs, e com fãs consegue contatos. Quando perceber, já vai estar fazendo turnê pelo mundo e ganhando Grammys. 
<p>- Não é tão simples.
<p>- Você só precisa tentar.
<p>- Mas...
<p>- Vai dar certo. Relaxa. É o seu grande sonho, não é? Deve ter falado sobre isso umas cinco vezes enquanto a gente corria. 
<p>- É, mas... Eu não sabia que você ia querer realiza-lo. Por que está fazendo isso? – Daniel sorriu sem graça.
<p>- Porque você tem razão. Eu preciso mesmo de um novo melhor amigo. E é isso que eu faço pelos amigos. – Jason também sorriu. – Agora vai trabalhar.
<p>- Valeu. 
<p>- Disponha.</p>
<center><h4>--*--</h4></center>
<p>Daniel não ficou nervoso na hora que subiu ao palco. Jason até ficou orgulhoso por vê-lo ali cantando, parecia que tinha experiência. Ele então percebeu que em nenhum momento daquele dia pensou que o garoto poderia não cantar tão bem quanto ele pensava. Ele se arriscou e valeu a pena. Daniel foi aplaudido muitas vezes. 
<p>- Você foi incrível, sabia? – Jason demorou para dizer.
<p>Ele e Daniel estavam colocando as cadeiras em cima das mesas. Jason havia mandado Amber embora mais cedo para ela poder descansar, e claro, para ele poder se descansar dela. Daniel pediu para ficar e ajudá-lo a fechar o bar.
<p>- Você achou mesmo? Faz muito tempo que eu não faço isso, até mesmo sem plateia.
<p>- Você nem pareceu assustado. Pareceu que fazia isso toda noite. E eu gostei das músicas. Tem talento. 
<p>- Valeu. Quer dizer que meu futuro é promissor?
<p>- Contanto que não morra amanhã...– Jason riu.
<p>Os dois ficaram em silêncio. 
<p>- Posso te perguntar uma coisa?
<p>- Você me irritou e falou mais do que devia o dia todo, agora quer ser educado? Não sabia que pedir permissão era a sua praia.
<p>- Vou ignorar seu comentário e... – Os dois caíram na risada. – Vou perguntar mesmo assim. Qual é realmente a história entre você e essa garota que você ama? Por que acha que vai estragar tudo?
<p>- Somos complicados demais. A gente se conhece desde o colegial, mas... aconteceu algumas coisas e nos separamos. Desde então tentamos ficar juntos, mas brigamos o tempo todo. No fundo, eu sei que se a gente passar um tempo mais junto, vamos brigar definitivamente.
<p>- Por quê?
<p>- Como eu disse, eu sou uma pessoa complicada e ela também.
<p>- Mas você ainda quer tentar, não quer? – Daniel estava muito interessado.
<p>- Quero. Ela é a única garota por quem eu me apaixonei na vida. Eu nunca senti, entende? E aí quando estamos juntos, tudo o que a gente passou faz valer a pena. Eu a amo e acho que isso não vai mudar, pelo menos não tão cedo. 
<p>- Isso é bom. Eu queria ter isso. Acho que eu nunca me apaixonei desse jeito que você está dizendo. 
<p>- Sorte a sua.
<p>- Não. Eu quero. Acho que todo mundo merece encontrar esse sentimento uma hora ou outra. Você já encontrou, não desiste.
<p>- Você parece um biscoito da sorte.
<p>- Me diz como ela é. – Daniel voltou a colocar uma cadeira no chão e se sentou.
<p>- Pensa na garota mais linda que você já viu... Agora triplica essa beleza. Ela é brava, determinada, inteligente, sarcástica, eu já disse brava?
<p>- Já. Ela tem olhos e cabelos castanhos?
<p>- Tem. Como você sabe? – Jason já estava começando a ficar assustado.
<p>- Acho que ela está lá fora parada em frente a porta.
<p>- O quê?
<p>Jason olhou para a porta de vidro do bar e era verdade, Emily estava lá fora. Ele não pensou duas vezes, largou o pano que estava em sua mão, no chão, correu até a porta e foi para fora.
<p>- O que você faz aqui?
<p>- Meu voo atrasou e eu fiquei o dia todo no aeroporto. – Ela estava ofegante ou nervosa. Jason não soube diferenciar.
<p>- Você ficou o dia todo em Los Angeles e só apareceu aqui agora? Por que não me ligou? Por que...
<p>- Eu não queria me despedir de novo. Mas eu queria muito ver você. 
<p>- Eu... eu te amo tanto agora.
<p>E então ela sorriu.
<p>- Jason, eu... 
<p>- Não diz nada.
<p>- Eu preciso. 
<p>- Eu sei que você também me ama. 
<p>Emily se aproximou de Jason e o beijou com muita força.
<p>- Nossa, você quase arrancou minha alma agora. – Jason riu depois de respirar fundo.
<p>- É porque eu quero levar ela comigo para Nova York.
<p>- Meu coração já vai. Deixa a alma comigo.
<p>- Idiota. – Emily riu e voltou a beijá-lo.</p> 
</body></html>";
            }
        }

        public void clkAbrirComentar(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new EsseMundoView.MyPopupPage("SegDistantes", condicao.ToString()));
        }

        public void clkAbrirProximo(object sender, EventArgs e)
        {
            if (condicao + 1 > 8)
            {
                DisplayAlert("CAPÍTULOS!", "VOCÊ CHEGOU AO ÚLTIMO CAPÍTULO. CONFIRA OUTRA HISTÓRIA", "OK");
            }
            else
            {
                Navigation.PushModalAsync(new Capitulo1Page(condicao + 1));
            }
        }

        public void clkIrMenu(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MenusView.MenuSegredosDistantesPage());
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
                    Historia = "SegDistantes"
                }, UserLocalData.userUID, "SegDistantes", "Capitulo" + capitulo);
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
                await DisplayAlert("AVISO!", "NÃO CONSEGUIMOS CARREGAR INFORMAÇÕES ADICIONAIS! VERIFIQUE SUA CONEXÃO COM A INTERNET", "OK");
            }
        }
    }
}