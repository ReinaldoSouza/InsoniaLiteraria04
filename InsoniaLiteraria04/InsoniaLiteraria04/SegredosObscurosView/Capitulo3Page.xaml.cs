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
	public partial class Capitulo3Page : ContentPage
	{
        DBFire service;
        public int condicao;

        public Capitulo3Page (int numero)
		{
			InitializeComponent();
            service = new DBFire();
            condicao = numero;
            mostrarCapituloSalvo("SegObscuros", "Capitulo" + numero.ToString());

            if (numero == 11)
            {
                lblTitulo.Text = "Capítulo 11 - Ajuda";
                htmlPage.Html = @"<html><body>
<p>Temperance e Brandon estavam caminhando até a escola.
<p>- Se alguém me dissesse que você e o Jason morariam juntos um dia, eu não acreditaria.
<p>- O mundo dá voltas. – Brandon ficou pensativo.
<p>- Falando do demônio, cadê ele? Por que não veio junto?
<p>- Ele disse que gosta de chegar atrasado para ter uma entrada triunfante. Eu acho que ele é muito preguiçoso e quer dormir mais.
<p>- Bem a cara dele. Ele já começou a se meter nas suas coisas? – Temperance tinha um irmão mais novo, ela sabia como Jason podia ser.
<p>- Não, ele não é louco. Eu já falei os limites.
<p>- Só não coloque fotos comprometedoras no seu computador. Ele pode ver. – Temperance fez piada.
<p>- Eu não tenho fotos comprometedoras. – Brandon riu. - E ele não é nem louco de mexer no meu computador.
<p>- Isso é uma ameaça? – Temperance riu.
<p>- Sim, eu já ameacei ele.
<p>- Ele levou a sério?
<p>- Ele é o Jason, é claro que não levou a sério.
<p>- Sabe, isso que você está fazendo é muito legal.
<p>- Eu sei.
<p>- E surpreendente também.
<p>- Bom, você e a Lisa vivem dizendo que ele é a melhor pessoa, preciso conhecer ele então, não é? Porque até agora, ele ainda não me surpreendeu.
<p>- Amo como você julga as pessoas sem conhecer. – Temperance revirou os olhos.
<p>- Ah, para, Temperance, eu me lembro do primeiro dia de aula quando você veio reclamar para mim por ter sido escolhida para fazer trabalho com o palhaço da turma. Você julgou o Jason tanto quanto eu.
<p>- Eu mudei. Você pode também.
<p>- Vamos ver, não é? – Brandon não estava muito confiante.</p>
<center><h4>--*--</h4></center>
<p>Lisa chegou na escola sozinha. Ela não era muito boa em ficar sozinha. Depois de um tempo parada na frente do portão da escola, ela resolveu andar pelos corredores à procura de Brandon, mas parecia que ele ainda não tinha chegado.
<p>- Lisa, oi. – Maddie correu para alcançar Lisa.
<p>- Oi, Maddie. – Lisa a cumprimentou.
<p>- Vem ficar aqui com a gente até a aula começar. – Maddie sorriu.
<p>- Com a gente?
<p>- Meu irmão e eu. – Maddie apontou para o cara todo de preto e mal-humorado encostado em uma parede, Kol.
<p>- Parece ótimo. – Lisa ficou sem graça de recusar o convite.
<p>Lisa não tinha muita intimidade com Maddie e Kol, então não sabia muito o que falar. Enquanto Kol ficava quieto na dele, Maddie não parava de falar em como tinha sido seu final de semana.
<p>- Nossa, deve ter sido bem legal. – Lisa se sentia perdida, mas resolveu soltar um comentário assim que Maddie parou de falar, para não parecer tão desinteressada.
<p>- Foi maravilhoso. – Maddie estava lembrando que foi para casa dos avós no fim de semana.
<p>- E você, Kol? Fez algo interessante? – Lisa tentou puxar conversa.
<p>- Eu fiquei em casa. – Ele falou.
<p>- Não gosta de sair?
<p>- Não muito.
<p>- Sabe, em Los Angeles, Jason e eu saíamos o tempo todo, já aqui não conhecemos muito os lugares.
<p>- Bom, a gente pode sair depois da escola, eu posso te mostrar tudo. O Kol vai adorar ir também, não vai, Kol? – Maddie beliscou o irmão.
<p>- É, vai ser legal. – Kol não estava animado.
<p>- Também acho. – Lisa também não estava animada.</p>
<center><h4>--*--</h4></center>
<p>Jason chegou na escola olhando para todos os lados, parecia um paranoico estranho.
<p>- Emily! – Ele gritou quando a viu no meio do povo no pátio da escola. Por algum motivo, ela se destacou.
<p>- O que foi? – Ela se assustou.
<p>- Você tem alguma aula importante hoje? – Ele tinha algum plano.
<p>- Ah, não, eu tenho aula de artes e depois vão fazer uma palestra sobre saúde.
<p>- Quer sair daqui? – Jason estava animado.
<p>- E ir para onde?
<p>- Ah, sei lá. Você está aqui a mais tempo.
<p>- Você está querendo que eu mate aula? Eu não vou fazer isso.
<p>- Tudo bem então. Meu plano não foi muito bom. – Jason fez um bico. – Mas a gente pode ir depois da aula, não tem problema nenhum.
<p>- Acho melhor não. – Emily tentou disfarçar.
<p>- Por que não? – Jason ficou surpreso.
<p>- Eu vou fazer umas coisas e...
<p>Jason sorriu.
<p>- Se não quer sair comigo, é só dizer. Não precisa inventar uma desculpa.
<p>- Eu não faço esse tipo de coisa, então eu acho que isso não vai dar certo.
<p>- Que tipo de coisa?
<p>- O que você espera? Porque eu não sou esse tipo de garota.
<p>- Eu nunca disse que você era. Cara, a gente conversou a noite toda, você não entendeu nada do que eu disse?
<p>- Eu estava pensando e...
<p>- Tem a ver com o lance do blog? – Jason perguntou logo.
<p>- O quê? Não, não, claro que não. – Ela explicou. – É comigo.
<p>- Sério? Porque está parecendo que é comigo. O que foi que eu fiz?
<p>- Você não fez nada, eu só não quero isso agora. – Emily explicou.
<p>- Eu posso mudar, ou pelo menos, tentar, sei lá.
<p>- Eu não quero que mude, não por mim. – Emily estava estranha. – Além do mais, eu me lembro de você dizer que está contente com quem é.
<p>- Foi algo que eu disse? Eu não estou entendendo. Estava tudo bem um dia atrás.
<p>- Jason, eu gosto de você, você é bem legal.
<p>- Odeio esse papo. – Ele reclamou.
<p>- Eu só pensei melhor e achei que seria melhor acabar logo com isso.
<p>- Acabar com o quê? Ainda não temos nada.
<p>- Eu tenho que ir agora. – Emily não queria mais falar sobre o assunto, então foi embora.
<p>- Tudo bem.
<p>Jason não foi atrás de Emily. É claro que ela queria dar um fora nele, mas sem ser mal-educada, mas por quê? O que ele tinha feito além de ser ele mesmo?
<p><i>Garotas eram bipolares</i>, pensou Jason.</p>
<center><h4>--*--</h4></center>
<p>- Ela me deu um fora. ACREDITA? – Jason ainda estava inconformado quando contou tudo pra Temperance na sala antes da aula de biologia começar.
<p>- Acredito e acho tudo isso muito possível.
<p>- Achei que os foras que ela me dava era uma estratégia para me fazer se interessar mais.
<p>- Parece que você estava enganado. – Temperance não parecia comovida com a situação.
<p>- Por que você não está triste?
<p>- Qual é, Jason? Olha a sua volta, está cheia de garotas, daqui a cinco minutos, você encontra outra como sempre. Para que fazer um grande caso disso?
<p>- A Emily não é uma garota qualquer.
<p>- Como é que é? – Temperance ficou impressionada.
<p>- Não, espera um pouco. – Jason estava confuso. – Ela é sim só uma garota. – Ele se contradisse. – Do que eu estou falando?
<p>- Eu estou confusa. Pela Emily não era só o gosto pela conquista? Achei que tinha dito isso para o Brandon.
<p>- E eu achei que ele não ia contar nada para você. Que cabeludo fofoqueiro! – Jason ficou com raiva.
<p>- Calma. Não é grande coisa, somos todos amigos aqui.
<p>- Eu vou arrancar aquela peruca natural fio por fio daquele infeliz.
<p>- Relaxa, eu ia saber de qualquer jeito.
<p>- Você tem uma câmera no quarto do Brandon? – Jason ficou com medo da ideia de uma câmera naquele quarto.
<p>- O quê?
<p>- Não ando mais de cueca quando não tiver mais ninguém lá.
<p>- Fica quieto, é claro que não. Eu estou falando que eu ia acabar descobrindo que você começou a gostar da Emily.
<p>- Eu não gosto dela tanto assim.
<p>- Jason! – Temperance fez aquela cara.
<p>- Tudo bem, mas como?
<p>- Eu percebo coisas. – Ela tinha orgulho desse dom.
<p>- Olha, esquece esse assunto. Vamos sair hoje à tarde já que a Emily me deu um fora.
<p>- Quer dizer que eu sou a segunda opção? – Temperance não gostou da ideia.
<p>- Na verdade, é a terceira. Eu ia chamar a Lisa, mas estamos brigados.
<p>- Me sinto melhor agora.
<p>- Disponha. – Jason não entendeu o sarcasmo.
<p>- Saia sozinho.
<p>- Tudo bem então. Perdeu um copo de sorvete. – Jason tentou convencer Temperance.
<p>- Não tem problema, o Brandon paga um para mim. – Ela riu.
<p>- Espero que caia cabelo nele.</p>
<center><h4>--*--</h4></center>
<p>Maddie chegou na biblioteca puxando Lisa pelo braço e chamando por Kol.
<p>- Kol, vamos logo. – Ele estava sentando lendo um livro.
<p>- Eu não posso ir, foi mal. Estou estudando para uma prova de matemática.
<p>- Deixa para depois. – Maddie fechou o livro.
<p>- Maddie, você sabe como eu sou com matemática. – Kol e a Matemática tinham um caso sério de guerra já fazia tempo
<p>- Se você quiser, eu posso te ensinar. – Lisa se sentou perto de Kol.
<p>- Acho que não é tão boa professora assim. Eu sou muito ruim.
<p>- Vai por mim, eu ensinei o Jason. – Lisa sorriu.
<p>- Bom, então eu não estou perdido. – Kol tentou retribuir o sorriso, mas não conseguiu.</p>
<center><h4>--*--</h4></center>
<p>- E ao invés de vocês saírem pela cidade, você ficou a tarde toda ensinando o Kol matemática? – Brandon começou a rir da namorada. Os dois estavam sozinhos no quarto dele.
<p>- Não foi tão ruim. – Lisa riu sem graça.
<p>- Deve ter sido péssimo.
<p>- Eu já tive um aluno pior.
<p>- Ele aprendeu pelo menos?
<p>- Digamos que eu sou uma ótima professora. – Lisa se vangloriou.
<p>- Digamos que você é ótima em tudo. – Brandon adorava elogiar Lisa.
<p>- Para. – Ela ficou envergonhada. – Mudando de assunto, como está sendo dividir o quarto com o Jason? – Lisa se sentou na cama.
<p>- Bom, pelo menos ele não é desorganizado. – Brandon olhou para o seu quarto. Ainda estava arrumado.
<p>- Onde ele está?
<p>- Eu não sei. Não quer dar de cara com ele?
<p>- Bom, eu não quero muito.
<p>- Bom, a gente pode então jantar fora. Ou você pode me ensinar matemática.
<p>- Um aluno por dia, por favor. – Lisa brincou.
<p>- Mas eu não tenho preferência?
<p>- Mas é claro que tem. Tem muita preferência. – Lisa sentou no colo de Brandon e os dois começaram a se beijar.
<p>- Gostei dessa preferência. – Os dois riram.
<p>- Então cala a boca e continua me beijando.
<p>Eles voltaram a se beijar.
<p>- Eca, arranjem um quarto. – Jason entrou no quarto.
<p>- Eu já estou no quarto. – Brandon falou enquanto Lisa saia do colo dele bem rápido.
<p>- Bom, arranjem um quarto no qual eu não esteja nele. – Jason sorriu.
<p>- Vou pensar nisso na próxima vez. – Brandon fechou a cara.
<p>- Vai ter uma próxima vez? A Temperance disse que você beija mal. – Jason brincou.
<p>- Sério? – Brandon pensou no que iria falar depois. – Eu não sei como revidar com você.
<p>- Aceite perder, é melhor. – Jason riu.
<p>- Tudo bem, Jason? – Lisa finalmente falou. Jason tinha ignorado ela até aquele momento.
<p>- Eu estou ótimo. E você?
<p>- Também. – Lisa respondeu.
<p>- Bom, a gente vai sair para jantar. – Brandon tentou quebrar a tensão. – Está a fim de ir com a gente, Jason?
<p>- Eu passo.
<p>- Se quiser ir, tudo bem. – Lisa falou.
<p>- Não, eu estou sem fome.
<p>- Tudo bem, então. Tchau. – Brandon e Lisa iam saindo do quarto. – E não mexe.,.
<p>- “Não mexe no meu computador”. – Jason imitou a voz de Brandon. – Eu já sei, peruquinha de Carnaval.
<p>- Ótimo.</p>
<center><h4>--*--</h4></center>
<p>- Quando você me chamou para jantar, eu não sabia que você ia trazer a Lisa. – Temperance estava se sentindo uma vela no meio de Lisa e Brandon na lanchonete. – Sem ofensas, Lisa.
<p>- Eu pedi para ele te convidar. – Lisa sorriu.
<p>- E por que você faria isso? Você é maluca? – Temperance não entendeu.
<p>- Eu quero te conhecer melhor.
<p>- O quê? – Temperance olhou para o Brandon.
<p>- A ideia não foi minha. – Brandon disse logo.
<p>- Olha, vamos andar juntas a maior parte do tempo. Não vejo o porquê de a gente ficar se ignorando. – Lisa explicou.
<p>- Eu não costumo ser amiga das namoradas do Bran. Na verdade, o Bran não costuma nem ter namoradas.
<p>- É, mas isso pode mudar. – Lisa estava animada.
<p>- Por que quer ser minha amiga? Somos tão diferentes.
<p>- Não é verdade. Nós duas somos inteligentes.
<p>- Ah é? – Temperance não estava acreditando muito.
<p>- É verdade. – Brandon ajudou. – Ela ensinou matemática para o Kol hoje.
<p>- E já ensinei para o Jason uma vez. E agora ele é muito bom.
<p>- Por isso que matemática é a única matéria que o Jason vai bem.
<p>- Eu sei. – As duas riram.
<p>- Viu? Vocês têm muita coisa em comum. – Brandon parecia feliz. – Podem falar do Jason.
<p>- Pode ser. – Temperance ainda não tinha muitas esperanças.
<p>O celular de Temperance começou a tocar.
<p>- O que é isso? – Brandon se assustou com o toque.
<p>- Ah, é uma mensagem do Jason. – Ela leu com raiva. – Ele está aqui reclamando que a Emily deu um fora nele e não admite que gosta dela. Ele ficou o dia todo assim.
<p>- O quê? – Brandon riu.
<p>- Espera um pouco, a Emily é a garota da praça?
<p>- Sim. – Temperance respondeu.
<p>- E ela terminou com ele? – Lisa ficou interessada.
<p>- Bom, não terminou exatamente porque eles nem começaram nada ainda, mas parece que ela deu um chega para lá nele. E ele não está aceitando muito bem.
<p>- Isso é normal. – Brandon comentou. – Todo mundo leva um fora na vida.
<p>- Ele deve estar mal. – Lisa começou a ficar preocupada com Jason.
<p>- Ele vai superar. – Temperance não estava muito preocupada. – Que horas vamos pedir a comida?</p>
<center><h4>--*--</h4></center>
<p>Lisa ficou pensando no que aconteceu com o Jason a noite toda. Ela sabia que ele não lidava muito bem com rejeição e se ele gostava mesmo dessa Emily, com certeza estaria mal. Mas por que ela estava se importando? Eles estavam brigados, isso não era do interesse dela. Mas ele ainda era o seu melhor amigo e ela não ia deixar ele assim.
<p>Lisa chegou na escola no dia seguinte com um objetivo: encontrar a tal Emily, mas ela mal se lembrava do rosto da garota. Não seria uma tarefa fácil.
<p>- Lisa, oi. – Kol se aproximou de Lisa assim que ela cruzou o portão da escola.
<p>- Kol, tudo bem? – Lisa não estava prestando muita atenção.
<p>- Eu queria agradecer por me ajudar ontem.
<p>- Ah, sem problema, não foi nada.
<p>- Eu posso retribuir em alguma coisa? – Kol perguntou.
<p>- Não precisa, é sério. – Ela sorriu.
<p>- Eu insisto.
<p>- Bom, já que insiste, você conhece uma garota chamada Emily?
<p>- A que o blogueiro disse que está ficando com o Jason?
<p>- Essa mesma.
<p>- Ah, ela é aquela ali. – Kol apontou para a garota que estava pegando uns livros no armário.
<p>- Ai, muito obrigada. – Lisa abraçou Kol. – Valeu mesmo, salvou a minha vida.
<p>- Disponha.
<p>Lisa saiu correndo atrás de Emily.
<p>- Você é a Emily? – Lisa chegou perto da garota.
<p>- Sou. – Emily achou estranho Lisa ir falar com ela.
<p>- Eu sou a Lisa.
<p>- É, eu sei. O Jason já falou de você uma ou trezentas vezes. – Emily riu.
<p>- Eu fiquei sabendo que está rolando alguma coisa entre vocês. – Lisa tentou sondá-la.
<p>- Ah, não está rolando nada.
<p>- Sério? Por quê? Vocês parecem perfeitos juntos.
<p>- Perfeitos não é bem a palavra. – Emily parecia insegura.
<p>- Olha, Jason e eu não temos nos falado ultimamente...
<p> Eu sei. – Emily respondeu.
<p>- Mas eu fiquei sabendo que ele ficou mal porque você meio que deu um fora nele, é verdade?
<p>- Bom, não foi bem um fora.
<p>- Eu sei que a gente não se conhece nem nada, mas por quê?
<p>- Por que a gente não se conhece? – Emily não entendeu a pergunta.
<p>- Não. Por que você deu um fora nele?
<p>- Bom, quando uma garota não gosta de um cara, ela dá um fora nele. Geralmente.
<p>- Então você não gosta do Jason? – Lisa estava tentando entender.
<p>- Não. – Ela mentiu.
<p>- Sério? – Lisa não ia se convencer tão fácil.
<p>- Tudo bem, eu confesso. Eu posso meio que ter uma atração bem pequena por ele. – Emily parecia envergonhada. – Ele não é feio de se olhar e...
<p>- É a cara que ele faz, não é?
<p>- É a cara. – Emily suspirou e as duas começaram a rir. – Ele faz aquela cara de convencido e bobão que me deixa morrendo de raiva, mas depois ele me diz umas coisas fofas que eu sei que são da boca para fora e volta a fazer aquela cara. – Emily estava confusa. – E tem aqueles olhos que parecem que estão lendo a sua mente mesmo que ele não faça ideia do que está fazendo e falando.
<p>- Falta uma coisa.
<p>- Quando ele começa a falar. Nove das dez palavras que ele fala é idiotice, mas eu não consigo parar de ouvir. Poderia ouvir o dia todo.
<p>- Então por que deu um fora nele?
<p>- Porque ele é o Jason. Está comigo, mas dois minutos atrás, estava azarando outra garota.
<p>- É, isso é um problema. Mas sei lá, será que não dá para se arriscar? De repente, ele perceba que é um idiota.
<p>- Acho improvável.
<p>- Eu também. – Lisa riu. – Mas se fosse comigo, eu arriscaria. O que você tem a perder?
<p>- Eu não sei.
<p>- E o que você tem a ganhar?
<p>- Ele? Mas não me parece grande coisa. – Emily ainda estava dividida.
<p>- Vai por mim, é sim. Aquela pose de “não ligo para nada, eu sou o bom” é só fachada.
<p>- Quer dizer que ele não é um bobão convencido e sem graça? – Emily percebeu que não conhecia o Jason então.
<p>- Não, isso ele é. Não tenha dúvidas. Mas se ele se importa, ele vai fazer de tudo para te deixar bem. Esse é o Jason, imperfeito, mas não dá para viver sem.
<p>- Então por que ainda está brigada com ele?
<p>- Bom...
<p>Emily tocou no ponto fraco de Lisa que a deixou sem resposta. Nem ela mesma sabia que ainda continuava aquela briga com Jason.</p>
<center><h4>--*--</h4></center>
<p>- Eu fiquei a noite toda assistindo uma série sobre dois irmãos que jogavam basquete. – Jason estava com a Temperance sentados em uma mesa na biblioteca.
<p>- Então sua noite foi boa. – Temperance riu enquanto tentava ler um livro.
<p>- Como foi o jantar? – Jason ficou curioso.
<p>- A gente jantou, aí depois o Bran ficou todo meloso com a Lisa e eu quase vomitei.
<p>- Típico.
<p>- Depois eles me deixaram em casa e eu posso apostar que de lá foram para um motel.
<p>- Você esqueceu que estamos falando do Bran? Ele não saberia o que fazer em um motel. – Jason riu.
<p>- Disso eu não sei, graças a Deus.
<p>- A Lisa está bem?
<p>- Você a viu, sabe como ela está.
<p>- A gente mal conversou.
<p>- Por que não pergunta para ela? – Temperance não tinha paciência.
<p>- Bom...
<p>- Ela sente a sua falta. Dá para ver. Ela também perguntou de você.
<p>- Perguntou? Ela sente a minha falta?
<p>- Eu sinto. – Lisa chegou de surpresa.
<p>- Ai, meu Deus. – Jason ficou constrangido.
<p>- Eu vou deixar vocês a sós. – Temperance pegou o seu livro e se levantou da mesa. – Ser vela uma vez só por mês já está ótimo para mim.
<p>Jason começou a balançar a cabeça negativamente para Temperance não sair do local.
<p>Temperance saiu da biblioteca mesmo assim.
<p>- Quer conversar agora? – Jason não entendeu e estava preparado para brigar.
<p>- Eu fui uma idiota. Fui longe demais. Você estava certo, eu não devia te culpar nem te afastar pelo o que o blogueiro disse. Ele que se dane.
<p>- E?
<p>Jason se levantou para poder olhar Lisa nos olhos.
<p>- E você é meu melhor amigo e é muito importante para mim.
<p>- E? – Jason cutucou mais.
<p>- E eu senti muito a sua falta, até das coisas mais idiotas que você faz.
<p>- E? – Jason riu, ele não estava mais com raiva.
<p>- E eu te amo, mas se não calar a boca agora e me abraçar, eu vou te bater.
<p>- Eu também te amo. – Jason abraçou Lisa. – Nunca se esqueça disso.
<p>- Não vou. – Ela o abraçou mais forte e os dois ficaram assim por alguns segundos, como se estivessem se reconectando. – Agora eu preciso te dizer uma coisa.
<p>- Que coisa? – Jason ficou curioso.
<p>- Você pode ficar bravo.
<p>- Mas já? É sobre o quê?
<p>- A Emily.
<p>- O que você tem a ver com a Emily?
<p>- Bom...
<p>Lisa foi interrompida e não conseguiu falar mais nada.
<p>- Lisa, deixa comigo. – Emily apareceu.
<p>- Emily? O que faz aqui? – Jason, confuso, olhava de uma para outra. – Lisa, o que você fez?
<p>- De nada. – Lisa sorriu, deu um beijo na bochecha dele e foi embora da biblioteca.
<p>- O que foi que ela disse? – Jason ficou com medo. – Eu não estou carente se é isso que ela disse.
<p>- Ela não disse isso. – Emily riu.
<p>- Ainda bem. O que ela disse? – O medo ainda não tinha passado.
<p>- Não importa.
<p>- Não? – Jason ficou na dúvida.
<p>- Olha, eu sei que talvez não dê certo e que você com certeza vai me magoar, mas ainda está de pé aquele encontro depois da aula?
<p>- Depende. – Jason se animou.
<p>- Depende de quê?
<p>- De nada, eu não vou me fazer de difícil. – Jason falou logo.
<p>- Entendi. – Emily riu.
<p>- E se eu te prometer que vai dar certo e que eu não vou te magoar? Você vai acreditar?
<p>- Vamos ver.
<p>- Eu geralmente cumpro minhas promessas.
<p>- Então eu vou cobrar.
<p>- Acho que é agora que a gente deve se beijar de verdade. – Jason se aproximou mais de Emily.
<p>- Eu já acho que é mais tarde.
<p>- Você me deixa louco. – E de novo, Emily deixou Jason na vontade.</p>
</body></html>";
            }

            if (numero == 12)
            {
                lblTitulo.Text = "Capítulo 12 - Encontros";
                htmlPage.Html = @"<html><body>
<p>Jason chegou correndo na cantina para conversar com a Temperance.
<p>- Se prepara.
<p>Ele se sentou ao lado dela todo eufórico que até deu um empurro nela de leve.
<p>- O que foi? – Ela se assustou.
<p>- A Emily aceitou sair comigo. – Jason estava muito animado.
<p>- É sério? – Temperance duvidou.
<p>- Muito sério.
<p>- Que bom, né? – Ela não demonstrava a felicidade que deveria.
<p>- Muito bom. A GAROTA MAIS INCRÍVEL DA ESCOLA VAI SAIR COMIGO! – Jason gritou.
<p>- E agora todo mundo sabe disso. – Temperance colocou as mãos no rosto para disfarçar.
<p>- E daí? Quero compartilhar a minha felicidade. Eu passei um inferno nessa escola nessas últimas semanas e finalmente estou feliz. Quero que todos saibam que eu venci. – Jason levantou os punhos pra cima.
<p>- Que exagero.
<p>- Olha, quando finalmente o garoto nerd e estranho dos seus sonhos te chamar para sair, você vai gritar assim também.
<p>- Eu duvido.
<p>- Nossa, você ainda tem vontade de viver com essa animação toda?
<p>- Cala a boca.
<p>- Se você quer ser chata e ranzinza para sempre, tudo bem. Só não corta meu barato, tá bom?
<p>- Tudo bem.
<p>- Porque eu vou sair com a GAROTA MAIS...
<p>- Sr. Porter? – Um professor se aproximou da mesa onde os dois estavam e interrompeu os gritos de Jason.
<p>- Professor, oi.
<p>- Olá, eu posso saber por que não foi a minha aula de História hoje?
<p>- Ah... Eu estava muito mal hoje de manhã. – Jason colocou a mão na barriga para fingir uma dor. – Eu tive que entrar na segunda aula.
<p>- A minha aula era a terceira. – O professor estava sério.
<p>- Ah, sério? Eu não tenho outra desculpa. – Jason ficou sem graça. Ele era péssimo para isso.
<p>- Olha, você perdeu uma atividade importante hoje, metade da nota.
<p>- Sério? Era um trabalho surpresa? – Ele já estava pronto para reclamar.
<p>- Eu avisei semana passada, mas você não estava lá também.
<p>- Eu tive que sair mais cedo nesse dia. Motivos pessoais. – Jason mentia muito mal.
<p>- Olha, eu vou tentar te ajudar.
<p>- É sério? – Jason franziu a testa. – Ah... valeu mesmo, professor.
<p>- Então me entregue o trabalho amanhã de manhã. – O professor deu uma segunda chance.
<p>- Ah, claro. Mas o trabalho é sobre o que mesmo?
<p>- Você precisa ler três livros sobre A Guerra Fria e tirar algumas conclusões. – O professor explicou calmamente.
<p>- Espera aí, não tem como eu ler três livros em um dia.
<p>- Que pena. – A bondade dele tinha acabado.
<p>- Olha só professor, você não está entendendo. – Jason tentou aliviar a pressão rindo. – Eu meio que tenho um encontro hoje com uma garota incrível, não sei se você ouviu os gritos, mas será que não dá para arrastar um pouco a data de entrega? – Jason pediu demais.
<p>- Olha só, Sr. Porter...
<p>- Pode me chamar de Jason.
<p>- Eu já arrastei a data. – Ele ignorou o comentário de Jason. – Eu não ligo para a sua vida amorosa, eu ligo para a sua educação.
<p>- Não pode ligar para a minha educação depois de amanhã?
<p>- Quero o trabalho na minha mesa amanhã de manhã ou vai ter um F. – Isso era um não.
<p>- Não, espera aí... – O professor deixou Jason falando sozinho.
<p>- Você matou a aula de História? – Temperance, que ouviu toda aquela conversa com o professor, estava inconformada.
<p>- Eu tenho que fazer um trabalho monstruoso e é só com isso que você está se importando agora?
<p>- Jason, o que você faz na escola se não assiste as aulas?
<p>- Eu fico no corredor... vendo as garotas... passarem de minissaia... principalmente se estiver calor. – Jason ficou envergonhado.
<p>- Devia compartilhar essa informação com a Emily no primeiro encontro.
<p>- Parece que não vai ter um primeiro encontro. – Jason ficou bravo.
<p>- É uma pena. – Temperance não estava dando a mínima.
<p>- A menos que... – Jason teve uma ideia.
<p>- A menos que o quê?
<p>- Você faça o trabalho para mim.
<p>- Ah, isso não vai rolar. – Temperance fez cara feia e ficou balançando a cabeça negativamente.
<p>- Ah, qual é, Tempe? Você passa o dia todo na biblioteca mesmo, pelo menos fazendo o meu trabalho o seu dia vai ser mais produtivo.
<p>- O que você vai aprender se eu fizer o trabalho para você?
<p>- Como se a Guerra Fria fosse importante para alguma coisa. Ultimamente está fazendo muito calor.
<p>- A Guerra Fria não é sobre temperatura. Saberia se fosse às aulas e fizesse o trabalho.
<p>- Olha, se você fizer, eu prometo que à noite eu dou uma lida nele.
<p>- Eu não vou fazer.
<p>- Eu não ia ler mesmo. Tudo bem, eu te pago sorvete por um mês. – E o suborno começou.
<p>- Não.
<p>- Faço sua lição de casa por uma semana.
<p>- E me arriscar a tirar D? Eu acho que não.
<p>- Eu faço suas unhas. – Jason não sabia fazer unhas.
<p>- Continue. – Temperance se interessou.
<p>- Tempe, eu não sei fazer unhas.
<p>- Que surpresa.
<p>- Por favor, vai, por favor. Implorar é o meu último recurso. – Jason começou a implorar.
<p>- Não.
<p>- Posso implorar e ainda fazer uma cara de dó. Sei fazer isso.
<p>- Tudo bem. – Jason respirou aliviado. – Mas só vou fazer a metade. O resto você faz.
<p>- Ah não, eu fico com a metade mesmo. Tirando um C- está ótimo.
<p>- Amo a sua ambição, sabia? – Temperance revirou os olhos. – Só você mesmo. É a última vez, viu? Na próxima.
<p>- Tempe, eu te amo, é sério, eu poderia te beijar agora.
<p>- Mas não vai. – Ela se afastou.
<p>- Eu ia, mas depois desse fora, vou deixar para lá. – Jason sorriu.
<p>- Ótimo.
<p>- Olha, eu estou te devendo essa. Quando você estiver precisando de ajuda, se sentir sozinha e triste, eu vou com certeza chamar alguém para te fazer companhia, tá bom?
<p>- Que esse alguém não seja como você. Só peço isso.
<p>- Pode deixar.
<p>Jason estava sorrindo de orelha a orelha.</p>
<center><h4>--*--</h4></center>
<p>- Você fez as pazes com o Jason? – Brandon ficou surpreso.
<p>Ele e Lisa estavam sentados em uma das mesas que ficam no pátio tomando um pouco de sol.
<p>- Fiz. – Lisa estava feliz.
<p>- Que legal. Quer dizer, agora você vai ficar mais feliz.
<p>- É, eu tenho meu melhor amigo de volta e o namorado mais perfeito do mundo. – Lisa o beijou.
<p>- Temos que comemorar isso, mas sem o Jason, por favor.
<p>- Claro. – Lisa riu.
<p>- Vamos sair depois da aula?
<p>- Combinado.
<p>- Oi, gente. – Maddie chegou cumprimentando os dois.
<p>- Oi, Maddie. – Brandon e Lisa falaram juntos.
<p>- Lisa, você vai fazer alguma coisa importante depois da aula?
<p>- Vou sim. – Lisa olhou para Brandon pedindo ajuda. – Bran e eu vamos sair. Por quê?
<p>- Por nada. Achei que a gente podia sair para fazer compras, essas coisas de garotas.
<p>- Ah, a gente pode fazer isso amanhã. Hoje não vai dar mesmo.
<p>- Ah, tudo bem. A gente vê isso amanhã. – Maddie se despediu e foi embora. – Tchau.
<p>- Tchau.
<p>- Agora ela não desgruda de você? – Brandon achou estranho Maddie chamar Lisa para sair.
<p>- Acho que ela quer me agradecer por ajudar o irmão dela.
<p>- Ou ela está apaixonada por você. – Brandon brincou.
<p>- O quê? Obvio que não.
<p>- Vai saber.
<p>Os dois começaram a rir.
<p>Kol estava de longe observando a conversa dos três. Maddie foi até ele assim que se afastou de Lisa e Brandon.
<p>- Ela não vai poder sair hoje. – Maddie comentou.
<p>- O quê? Por quê? – Kol parecia decepcionado com a irmã.
<p>- Ela vai sair com o Bran hoje. – Maddie explicou.
<p>- Que pena.
<p>- Mas por que você quer tanto que eu saia com ela?
<p>- Ela me ajudou, eu pensei que você podia retribuir ou sei lá.
<p>- Ela ajudou você, você que retribua então. Sem falar que se eu for amiga da Lisa, eu vou ter que aturar o Jason e ninguém merece isso.
<p>- Eles voltaram a ser amigos? – Kol ficou surpreso com a notícia.
<p>- Parece que sim, ouvi o pessoal comentando na aula. Por que a surpresa? Estava na cara que era só questão de tempo.
<p>- Não, por nada. – Kol voltou a ficar pensativo.</p>
<center><h4>--*--</h4></center>
<p>- Então você vai sair com a Emily? – Jason e Brandon estavam conversando na sala antes da aula de física começar.
<p>- Quem te disse?
<p>- Parece que te ouviram gritar na cantina. – Brandon riu.
<p>- Isso pode ter acontecido. – Jason nem ficou com vergonha.
<p>- Para onde você vai leva-la?
<p>- Eu não sei ainda. Não conheço essa cidade direito. – Jason estava um pouco perdido. – Mas eu vou dar uma pesquisada depois na aula de filosofia, não presto atenção nela mesmo.
<p>- Olha, quer um conselho? Tem um parque aqui perto que tem um campo bem bonito. É grande e é cheio de flores, é bem romântico.
<p>- Sério?
<p>- É, você pode fazer um piquenique ou sei lá.
<p>- Ah, eu não sou o tipo de cara que faz piquenique. – Jason achava tudo isso brega.
<p>- Quer dizer que para Emily não vale a pena fazer um piquenique? – Brandon estava tentando sondá-lo.
<p>- Ela também não parece que curte esse tipo de coisa.
<p>- Você acha?
<p>- Bom, tem uma primeira vez para tudo. – Jason riu.
<p>- Foi o que eu pensei que diria.
<p>- Olha, valeu, você não é todo cabelo como eu achei que era. Às vezes você pensa nas coisas importantes da vida.
<p>- Valeu, eu acho.
<p>- Olha só, Bran...
<p>- Você me chamou de Bran? – Brandon quase caiu da cadeira.
<p>- Chamei sim. Olha, eu estou ansioso pelo encontro, e não estou pensando direito e não consegui pensar em um apelido legal e eu não gosto de repetir nenhum. Vai parecer que eu não tenho criatividade.
<p>- Entendi.
<p>- O que eu quero dizer é que você até que é legal. No começo, você era um saco.
<p>- Você também não ajudava. – Brandon completou.
<p>- E eu pensei em sabotar seu namoro com a Lisa, dizendo para ela que você traficava lã na cabeça, mas agora eu estou legal.
<p>- Que bom. É mais fácil para nós dois.
<p>- Só não espere abraços. Jubas enroladas me dão alergia.
<p>- Tudo bem. Você é um cretino.</p>
<center><h4>--*--</h4></center>
<p>Temperance pegou os livros sobre Guerra Fria nas prateleiras, jogou eles todos em uma mesa vazia na biblioteca, se sentou e começou a ler para fazer o trabalho de Jason. Ela sabia que não ia conseguir fazer o trabalho pela metade.
<p>Pouca gente ficava na biblioteca depois da aula e exatamente naquele dia não tinha ninguém por lá. Temperance decidiu colocar os fones de ouvido para ficar mais concentrada. É claro que Temperance e fones de ouvido não combinavam muito bem. Achando que estava sozinha na biblioteca, ela resolveu cantarolar.
<p>- <i>If you wanna be my lover, you gotta get with my friends...</i>i> – Temperance começou a cantar. - <i>Make it last forever, friendship never ends...</i>i>
<p>Um garoto estava observando Temperance cantar bem de perto, mas ela estava tão concentrada no livro e na música que nem percebeu e continuou a cantar.
<p>- Oi, com licença. – Ele falou.
<p>- Ai, meu Deus, oi. – Temperance se assustou e tirou os fones bem rápido.
<p>- Você está usando todos os livros? – Ele tentou não rir da reação de Temperance.
<p>- Ah, não. – Ela estava sem jeito. – Pode levar esses. – E apontou dois livros.
<p>- Muito obrigado. – Ele pegou os livros.
<p>- Eu nunca vi você por aqui. – Temperance sempre sabia quem ficava muito na biblioteca.
<p>- Eu sou novo. Fui transferido há dois dias.
<p>- Ah.
<p>- Sou Nathan, mas todo mundo me chama de Nate. Na verdade, aqui não, porque você é a primeira a saber meu nome. – Ele riu sem graça.
<p>- Isso é normal, logo você se entrosa melhor. Eu sou Temperance. – Temperance continuava com vergonha.
<p>- Lindo nome.
<p>- Obrigada, Nate. – Ela riu e quase ficou toda vermelha. – Você está fazendo algum trabalho?
<p>- Não, eu só gosto de ler.
<p>- Que legal, eu também adoro ler. Essa biblioteca me salva muito.
<p>- Podemos ler juntos um dia desses. – Temperance não sabia se aquilo era um convite ou algo sem compromisso.
<p>- Eu... ia adorar.
<p>- Ótimo, eu já vou. Não quero te atrapalhar.
<p>- Não me atrapalha. – Temperance não conseguia parar de sorrir.
<p>- Uma última coisa, você canta muito bem. – Ele riu.
<p>- Isso é mentira e me desculpe por você ouvir. – Temperance começou a rir.
<p>- Eu amei, na verdade.
<p>- Então tá bom. – Os olhos dela brilharam.</p>
<center><h4>--*--</h4></center>
<p>- Esse bolinho está muito bom. – Lisa falou de boca cheia.
<p>Brandon estava levando Lisa para conhecer a cidade e pararam em uma lanchonete.
<p>- Esse é o meu lugar favorito. Vou te trazer muito aqui.
<p>- Bom saber, porque eu me viciei nesse bolinho. – Lisa tentava limpar a boca com o guardanapo.
<p>- São bons mesmo.
<p>- Posso te perguntar uma coisa?
<p>- Até duas.
<p>- Já aviso que pode parecer idiota.
<p>- Fala.
<p>- Por que você gosta de mim?
<p>- É sério que você não sabe? – Brandon se assustou.
<p>- Me diz.
<p>- Olha, desde a primeira vez que eu te vi... Eu vi uma coisa em você. Eu não sei, me chamou a atenção. Aí quando eu te conheci e a gente conversou, eu pensei comigo mesmo: “Se eu tivesse coragem, ela seria minha namorada.”.
<p>- Mas agora eu sou a sua namorada.
<p>- Mas não foi dependendo da minha coragem. – Brandon riu.
<p>- Acho que você foi a melhor coisa que me aconteceu quando eu mudei de cidade. Eu estava com tanto medo e ansiosa. Eu não converso com mais ninguém que eu conhecia e isso é horrível. Mas aí tem você, parece que essas coisas nem importam mais.
<p>- Eu não sou tão bom assim. – Brandon ficou sem jeito.
<p>- Você acha? Você faz eu me sentir tão bem, tão leve. Tão apaixonada. – Ela falou a última palavra olhando nos olhos de Brandon para ver a sua reação.
<p>- Você está apaixonada por mim?
<p>- Só se estiver por mim.
<p>- Olha para minha cara e olha para você.
<p>- Como assim? – Lisa ficou confusa.
<p>- Não tem como alguém não se apaixonar por você. – Brandon beijou Lisa.</p>
<p></p>
<p><i>“<b>PELO QUE PARECE, O SAPO VAI VIRAR PRÍNCIPE HOJE:</b> Os boatos correm rápido e dizem que Jason vai finalmente levar a Emily para sair e eu aqui já achando que eles estavam até fazendo coisas que não deviam, sempre penso mal do meu amigo. Mas convenhamos, vocês acham mesmo que esse romance perfeito vai durar? Vamos fazer uma aposta? Quem acha que vai durar um dia? Uma semana? Quinze dias? Bom, eu aposto que a Emily vai dar um chute nele logo nos dez primeiros minutos do encontro, então vamos lá, façam suas apostas, e Emily, não me desaponte. Eu estou precisando do dinheiro.”.</i> – Tesouro de Segredos Obscuros.</p>
<p></p>
<p>- Eu posso abrir os olhos?
<p>- Ainda não.
<p>Jason estava guiando Emily, mas estava tampando os olhos dela com suas mãos.
<p>- Primeira coisa que você deve saber sobre mim, eu odeio surpresas.
<p>- Eu também odeio. – Jason riu.
<p>- E por que está fazendo isso?
<p>- Fica quieta, já estamos chegando.
<p>Emily quase caiu quando tropeçou em uma pedra. Sorte que Jason estava segurando ela.
<p>- Cuidado.
<p>- Deixa eu abrir os olhos. – Ela já estava ficando irritada.
<p>- Pode abrir. Minha mão vai ficar tampando sua visão do mesmo jeito.
<p>- Se eu cair, eu vou te bater.
<p>- Não confia em mim?
<p>- Acho que não. – Ela riu.
<p>Os dois andaram por mais alguns minutos. Mesmo Emily insistindo, Jason não deixou ela olhar antes de chegarem no lugar planejado.
<p>- Pode abrir os olhos agora.
<p>Jason tirou a mão dos olhos de Emily, mas ela hesitou em abrir os olhos.
<p>- Onde estamos? – Ela ficou impressionada com a paisagem.
<p>- É um parque. O Cabelo de Arame me deu essa dica.
<p>- Esse lugar é lindo. Agora só falta uma cesta de piquenique. – Emily brincou.
<p>- Não falta mais. – Jason mostrou a cesta animado enquanto a colocava no chão e se sentava na grama.
<p>- Meu Deus, nunca achei que você fosse o cara que fazia piqueniques. – Ela não estava zombando, estava surpresa.
<p>- Para ser sincero, eu nunca achei que faria um piquenique. – Jason riu.
<p>- E por que fez? – Emily se sentou ao lado de Jason.
<p>- Para tentar te impressionar. Não é óbvio?
<p>- Eu te conheço há algumas semanas e só o que você fez foi me impressionar.
<p>- Isso é ótimo, maravilhoso na verdade.
<p>- Só não exagera, tá bom? – Emily ainda demonstrava um pouco de medo.
<p>- Tudo bem. Bom, eu trouxe bolo de chocolate, de laranja e de cenoura. – Jason começou a tirar as coisas da cesta e colocava em uma toalha que ele tinha estendido no chão. – Eu trouxe suco de laranja e de maracujá, mas também refrigerante se você quiser.
<p>- Nossa.
<p>- Eu trouxe alguns bolinhos, morangos, uma torta doce, outra salgada.
<p>- Quem mais vai chegar para comer? – Emily ficou impressionada.
<p>- Eu não sabia direito do que você gostava então eu trouxe tudo.
<p>- Eu gosto de qualquer coisa. Eu estou aqui com você, não é? – Emily riu.
<p>- Essa doeu. – Jason colocou a mão no peito e fingiu chorar.
<p>- Não precisava fazer isso.
<p>- Tinha que ser perfeito. Eu me esforço muito quando quero algo perfeito.
<p>- Eu estou vendo. – Emily sorriu. – Ainda tem mais?
<p>- Só mais uma coisa. Uma flor.
<p>- Flor?
<p>- Eu não gosto de flores, mas disseram que era romântico. – Jason entregou uma rosa amarela para Emily.
<p>- Você só trouxe essa?
<p>- Por quê? Você gosta de outras? Eu posso...
<p>- Não, não. Essas são as minhas favoritas na verdade. – Emily cheirou a rosa. – Obrigada.
<p>- Acertei uma. – Jason sorriu.
<p>- É, você é todo atrapalhado, mas às vezes você acerta.
<p>- Se isso te faz se sentir melhor, eu nunca fiz isso para nenhuma garota. Tem umas que até o nome é difícil para mim decorar, então...
<p>- E por que está fazendo comigo? – Emily ficou curiosa.
<p>- Eu realmente não sei. – Ele riu. – Você me deixa muito confuso. Tipo, meio perdido, sabe?
<p>- Isso é bom?
<p>- É bom. – Ele respondeu logo. – Muito bom.
<p>- É? – Emily estava em dúvida.
<p>- Você não acha?
<p>- Não, é que, não me leve a mal, você tem toda a fama e tal, e eu vim hoje achando que ia sair correndo nos primeiros cinco minutos, logo depois de te bater, é claro.
<p>- Mas...
<p>- Mas já se passaram cinco minutos e eu não quero ir embora. Na verdade, eu queria ficar aqui por um bom tempo.
<p>- Bom, tem comida suficiente para cinco dias. – Jason brincou.
<p>- Verdade. – Ela riu.
<p>- Eu acho que gosto de você. Eu não sei por que, mas eu gosto. É estranho porque eu não costumo gostar de ninguém. Quer dizer, você é linda e eu me interessei na hora por você, mas parece ser mais que isso.
<p>- E por que eu sou diferente?
<p>- Você só é. Você me irrita e muito, principalmente quando não sabe o que quer.
<p>- Eu sou a indecisa?
<p>- Você não queria que eu assumisse no primeiro dia, não é?
<p>Os dois começaram a rir.
<p>- Garotos são idiotas.
<p>- E garotas são difíceis. – Jason suspirou.
<p>- Você parece se dar muito bem com elas.
<p>- Até pode ser, mas nenhuma delas tem os seus olhos e o seu sorriso, e você é difícil.
<p>- Para. – Ela ficou sem graça. – Mas quer saber uma coisa engraçada? Eu acho que posso gostar de você. – Ela ainda estava bancando a difícil.
<p>- Acha que pode?
<p>- Acho.
<p>- E se eu te beijar agora?
<p>- Eu não beijo no primeiro encontro. – Emily sorriu.
<p>- O quê? Eu passei tudo isso para ter um encontro com você e mesmo assim não ganho um beijo? AHHHHHHHHHHH!
<p>- Para! – Emily se assustou com o grito de Jason e começou a rir.
<p>- Sabe, eu gosto de falar com você e estar com você. Eu nem vou ligar se você não me beijar.
<p>- É sério?
<p>- Não. Eu estou olhando para você e tudo o que eu consigo pensar é “beijo, beijo, beijo, beijo...”.
<p>- Você é louco.
<p>- Bom, a gente pode falar de qualquer coisa então para esse pensamento na minha cabeça passar.
<p>- Podemos.
<p>- Ou... podemos nos beijar logo, talvez todo esse clima passe e a gente não esteja interessado um no outro.
<p>- Beija tão mal assim? – Emily brincou.
<p>- Você pode decidir.
<p>- Para falar a verdade, quando eu te conheci eu pensei, “se ele não fosse tão chato nem irritante, nem metido a bravinho, eu até poderia me interessar por ele”.
<p>- Quando eu te conheci eu pensei “eu quero muito ficar com essa garota”.
<p>- Sabia que quando você quer muito uma coisa, ela pode acontecer? Um dia, eu ainda vou ganhar na loteria.
<p>- Eu acredito que se você quer algo, precisa tomar uma posição. Nada vai vir do céu para você, a não ser que queira um meteoro, aí pode até vir.
<p>- O que você faria agora se quisesse muito mesmo me beijar?
<p>- Bom, eu aproximaria mais o meu rosto do seu a ponto de sentir sua respiração. – Ele fez. – Depois olharia bem nos seus lindos olhos, sorriria... – Ele sorriu. – E então...
<p>Jason a beijou. Aquele beijo que fez seu coração bater mais forte perder o fôlego. Diferente do que ele achou que aconteceria, ela não se afastou, ela correspondeu o beijo. Ele passou sua mão por detrás do pescoço dela e sentiu as mãos quentes dela no seu rosto.
<p>- Eu estou ferrado. – Jason falou quase sem ar e ainda com o rosto quase colado ao dela.
<p>- Por quê? – Ela não entendeu.
<p>- Eu gosto mesmo de você.
<p>- Eu também. – Emily parecia mais assustada que Jason.
<p>- Que se dane. – Jason voltou a beijar Emily.</p>
</body></html>";
            }

            if (numero == 13)
            {
                lblTitulo.Text = "Capítulo 13 - Confusão";
                htmlPage.Html = @"<html><body>
<p>Brandon estava sentado na cama encarando Jason desde que ele tinha chegado do encontro com a Emily. E já fazia muito tempo.
<p>- Por que está me olhando desse jeito? – Jason fez cara feia.
<p>- Não vai mesmo me contar como foi seu encontro? – Brandon estava curioso.
<p>- Por que você quer saber?
<p>- Porque a ideia foi minha, lembra?
<p>- E você quer um obrigado? Ou um beijo da Emily? – Jason se vangloriou.
<p>- Ai, meu Deus, ela te deu um beijo? – Brandon pulou na cama de entusiasmo.
<p>- Na verdade, eu a beijei. Eu sou o cara. – Jason sorriu.
<p>- Menos, bem menos.
<p>- Ah, desculpa, eu esqueci que estou falando com o cara cabeludo que a garota que teve que beijar senão nunca perderia o BV.
<p>- Meu primeiro beijo não foi com a Lisa.
<p>- Se essa é a sua história. – Jason não ia se dar por vencido tão fácil.
<p>- Vai jogar isso na minha cara para sempre?
<p>- Não, só até seu cabelo ficar liso. Droga, então vai ser para sempre.
<p>- Cala essa boca.
<p>De repente, a porta do quarto se abriu tão rápido que Jason e Brandon até levaram um susto. Os pais de Brandon sempre batiam na porta antes de entrarem. Temperance entrou no quarto dos garotos bem apressada.
<p>- Bran, eu preciso falar com você. – Ela parecia ter corrido.
<p>- Não sabe bater? – Jason se assustou. – E se eu estivesse sem roupa?
<p>- Eu não estaria aqui. – Brandon respondeu com cara de nojo.
<p>- Não é esse o caso. A questão é que...
<p>- Eu posso falar agora? – Temperance ficou irritada.
<p>- Claro. – Jason se levantou.
<p>- Jason, não precisa sair. Você pode ouvir. – Temperance explicou.
<p>- Eu não vou sair, eu só vou fechar a porta.
<p>Jason fechou a porta e voltou a sentar na sua cama.
<p>- Tempe, o que houve? – Brandon estava até preocupado.
<p>- Bom, eu conheci um cara hoje. – Então Temperance finalmente sorriu.
<p>- E você deu o fora nele? – Brandon perguntou. Sabia que era o que geralmente acontecia.
<p>- Bom...
<p>- Ele era nerd? – Jason perguntou.
<p>- Na verdade...
<p>- Você odiou ele, né? – Brandon sabia que Temperance recusava todos.
<p>- Olha...
<p>- Ele deu em cima de você? – Jason tentou adivinhar.
<p>- Gente, a história é minha, deixa eu contar? – Temperance ficou impaciente.
<p>- Conte. – Jason e Brandon falaram juntos.
<p>- Bom, eu estava fazendo o trabalho do Jason e...
<p>- Eu tenho que te agradecer por isso. – Jason piscou pra Temperance.
<p>- Como assim? Está obrigando ela a fazer seus trabalhos? – Brandon olhou pra Jason com cara de reprovação.
<p>- Isso não vem ao caso agora. – Temperance falou logo. – Havia um garoto na biblioteca depois da aula lendo.
<p>- Nossa, o que mais se faz na biblioteca além de ler? – Jason não entendeu o espanto.
<p>- Ela quis dizer que ele é inteligente. – Brandon explicou.
<p>- Não precisa ser inteligente para ler. Basta ser alfabetizado. Ele pode ser um idiota que não tem nada para fazer em casa. Eu apostaria nisso. – Jason riu.
<p>- Você sabe estragar minhas fantasias. – Temperance olhou feio para Jason.
<p>- E qual é a sua fantasia? – Jason ficou confuso.
<p>- Encontrar um cara bonito, inteligente, que goste de ler, sincero, gentil e essas coisas. – Temperance sonhava.
<p>- E quantos caras você quer encontrar para juntar todas essas qualidades? – Jason brincou.
<p>- Se você existe, com certeza deve existir o oposto. – Temperance rebateu.
<p>- Eu não diria o oposto, afinal eu já sou lindo, gentil, sincero, o melhor namorado do mundo, entre outras coisas.
<p>- De quem você é namorado? – Temperance não acreditava no que ouvia.
<p>- Da Emily. – Brandon riu.
<p>- Aquela garota está namorando você? – Temperance achou estranho.
<p>- Eu não diria um namoro. – Jason foi modesto. – Na verdade, é um namoro sim.
<p>- Como isso aconteceu? – Temperance se sentiu perdida.
<p>- Digamos que eu arraso em encontros.
<p>- Ai, cara, chega. – Brandon cansou. – Só a Lisa para te aguentar.
<p>- Não, chega nada. Eu quero saber de tudo. – Temperance se sentou ao lado de Jason na cama.
<p>- Eu também quero saber. – Brandon se deu por vencido.</p>
<center><h4>--*--</h4></center>
<p>- E aí, como foi ontem? – Lisa se encontrou com Emily de manhã na escola. As duas estavam indo para a mesma sala de aula.
<p>- Foi muito bom. – Emily estava contente.
<p>- Muito bom? – Lisa não se contentou.
<p>- Foi incrível, está bom assim? Ele foi incrível.
<p>- Eu te disse. – Lisa comemorou.
<p>- Disse mesmo.
<p>- Então vocês agora estão juntos? – Lisa queria saber de tudo.
<p>- Bom, eu acho que sim. Eu não sei, não conversamos direito sobre isso. – Emily ficou com vergonha.
<p>- Eu não acredito. – Lisa riu.
<p>- É sério. Somos péssimos.
<p>- Achei que éramos ótimos. – Jason chegou beijando Emily. – Bom dia.
<p>- Bom dia. – Emily sorriu depois do beijo.
<p>- Pessoal, eu estou aqui. – Lisa ficou impressionada.
<p>- Você quer um beijo também? – Jason brincou.
<p>- Não. – Lisa riu. - Que bom que finalmente estão juntos ou sei lá. Agora eu preciso procurar o meu namorado para não me sentir uma vela.
<p>- Eu ouvi dizer que ele estava no cabelereiro. – Jason brincou apontando o caminho.
<p>- Quando você vai voltar para casa? – Lisa mudou de assunto.
<p>- Ah, eu estou gostando de morar com o Cabelo de Fios Entrelaçados.
<p>- Bom para você. – Lisa fez cara feia para Jason.
<p>- Bom, vamos para a aula? – Jason pegou na mão de Emily.
<p>- Vamos. – Ela concordou.
<p>- Andar de mãos dadas é estranho, não é? – Jason riu depois de um tempo andando desse jeito.
<p>- Pode soltar se quiser. – Emily também riu.
<p>- De jeito nenhum. – Ele segurou até mais firme.</p>
<center><h4>--*--</h4></center>
<p>- Por que estão andando de mãos dadas? – Maddie viu Jason, Emily e Lisa nos corredores da escola e já correu atrás deles para falar.
<p>- Porque não dá para andar de pés dados. – Jason fez sua piadinha diária.
<p>- Jason! – Lisa e Emily olharam feio para Jason.
<p>- Agora são duas de uma vez? – Jason lamentou.
<p>- Me respondam por favor. – Maddie não mudou de assunto.
<p>- Bom, Emily e eu estamos... – Jason olhou para Emily.
<p>- Estamos? – Emily também queria saber.
<p>- Eles estão juntos. – Lisa falou logo. – Graças a mim.
<p>- Também não é assim. Logo, logo, a Emily não ia resistir a mim, você só apressou as coisas. – Jason brincou com Lisa.
<p>- Se isso é um obrigado, de nada.
<p>- Ai, que legal. Vocês fazem um lindo casal. – Maddie sorriu.
<p>- Obrigada, Maddie. – Emily agradeceu. – Mas ainda não somos um casal exatamente.
<p>- Isso, nós somos... Eu não sei o que nós somos. – Jason disse logo. – Mas está tudo ótimo.
<p>- Vamos parar de conversa fiada. É claro que estão namorando. – Maddie rotulou.
<p>- Vai lá para o seu rodeio, vai. – Jason comentou.
<p>- Boa sorte, Emily, vai precisar. – Maddie foi embora brava depois do comentário.
<p>- Vou mesmo. – Emily concordou.
<p>- Muito engraçado. – Jason fechou a cara.</p>
<center><h4>--*--</h4></center>
<p>- Eu tentei falar com você ontem, mas não consegui. – Kol e Lisa dividiam aula de Biologia.
<p>- Ah, eu fiquei o dia todo com o Bran ontem. Deve ser por isso. – Lisa explicou. – Mas o que aconteceu?
<p>- Eu queria te pagar um sorvete por ter me salvado em matemática.
<p>- Ah, não precisa. – Lisa ficou sem jeito.
<p>- Como não? É o mínimo que eu posso fazer.
<p>- Isso é gentil, mas é sério, não precisa mesmo. Eu te ajudei porque somos amigos.
<p>- Somos amigos? – Kol ficou surpreso.
<p>- Claro que somos. – Lisa riu.
<p>- Que legal. – Kol também riu. – Será que você pode me dar uma ajuda em biologia também? Eu estou meio atrasado nas matérias.
<p>- Claro.
<p>Lisa pegou seu caderno.
<p>- O que você perdeu?
<center><h4>--*--</h4></center>
<p>- Espera um pouco, o Kol cara de Caracol riu? É isso mesmo que você falou? – Jason e Lisa estavam almoçando juntos.
<p>- Foi. Qual é o problema? – Lisa não entendeu o espanto.
<p>- Eu nunca vi aquele cara rir. Só na maldade quando eu estava na pior, mas com espontaneidade? Nunca. Eu até achei que ele nem sabia fazer isso.
<p>- Que exagero.
<p>- Ele deve estar a fim de você. Você reparou se na conversa que estavam tendo ele não tirou os olhos dos seus peitos? – Jason falou logo.
<p>- Cala a boca, isso não tem nada a ver.
<p>- Você disse que ele te chamou para tomar sorvete. Ele queria um encontro. Ele estava te cantando.
<p>- Não estava nada. Ele só foi gentil. – Lisa não via maldade naquilo.
<p>- Por que um cara é gentil com uma garota? Porque ele quer ela. – Jason parecia estar ensinando o bê-á-bá para Lisa.
<p>- Não tem nada a ver. Quer dizer que você nunca foi gentil com uma garota sem segundas intenções?
<p>- Não que eu me lembre. Ainda mais com sorrisinhos e educação. Ele está a fim de você sim.
<p>- Ele não gosta de mim. – Lisa já estava perdendo a paciência.
<p>- Quem não gosta de você? – Brandon chegou bem na hora.
<p>- Ninguém. – Lisa falou logo.
<p>- O tal do Kol chamou a Lisa para tomar um sorvete. – Jason avisou.
<p>- O quê? – Brandon não acreditou.
<p>- Ele só quer me agradecer pelas lições de matemática. E eu já disse que não quero. – Lisa olhou feio para Jason.
<p>- Qual é o problema? O Kol é legal. Deveria aceitar. – Brandon não parecia se importar.
<p>- O quê? – Jason arregalou os olhos de surpresa. – Você tem algum problema, babaca de Cachinhos Escorridos? Ele está chamando a sua namorada para tomar um sorvete e para você tudo bem? – Ele ficou inconformado.
<p>- Você e eu tomamos sorvete o tempo todo. – Lisa não via problema.
<p>- É diferente. Eu não estou a fim de você. – Jason explicou.
<p>- Nem o Kol. – Lisa falou.
<p>- Ele perdeu a namorada recentemente. – Brandon explicou. – Ele nem deve estar pensando nisso agora.
<p>- Nossa, como vocês são ingênuos, até parece que nasceram ontem. Daqui a pouco vão acreditar no Coelho da Páscoa. – Jason não suportava isso.
<p>- Se ele me trazer ovos, qual é o problema? – Brandon riu junto com Lisa.</p>
<center><h4>--*--</h4></center>
<p>- Eu ainda não entendi.
<p>Temperance ouviu tudo o que Jason falou enquanto estavam a caminho da última aula do dia e ainda não entendia como ele tinha ficado inconformado conversando com Brandon e Lisa.
<p>- O cara deu em cima dela e o Miojinho não ligou.
<p>- O Kol não é disso e o Bran sabe. – Temperance explicou.
<p>- Em Dallas ninguém trai? Acho que devem avisar isso para o roteirista daquela série de TV.
<p>- Não é isso, é que o Kol sabe que o Brandon é o namorado da Lisa, ele nunca...
<p>- Em Los Angeles ninguém liga quem namora quem, a regra lá é que vença o melhor.
<p>- Que coisa ridícula. Eu não conheço o Kol muito bem, mas eu acho que...
<p>- Olha, tá bom, vamos falar de outra coisa. – Jason já tinha perdido a paciência.
<p>- De quê?
<p>- Você acha que daria certo se a Emily e eu namorássemos?
<p>- Achei que já estavam namorando. – Temperance ficou confusa.
<p>- Saímos ontem e foi legal. Mas namorar? Sei lá. É muito compromisso e eu nem...
<p>- O que ela quer?
<p>- Eu deveria saber? – Jason não sabia mesmo o que fazer em uma situação dessas.
<p>- É claro. Vocês precisam saber se estão no mesmo ritmo. Se você não quer namorar, diz para ela.
<p>- Mas eu quero namorar com ela.
<p>- Cara, você está me confundindo.
<p>- O problema é que eu não sei se eu me dou bem com namoro.
<p>- Você nunca namorou? – Temperance se surpreendeu.
<p>- Mais de dois dias com a mesma garota? Que eu me lembre não.
<p>- Garoto, você precisa melhorar. Se você gosta da Emily, vai fundo.
<p>- Eu não acho que ela vá deixar eu ir fundo no segundo encontro, ela não é assim. – Jason pensou besteira.
<p>- Eu não quis dizer isso. – Temperance ficou com vergonha.
<p>- Eu sei. – Jason riu.
<p>- Ai, meu Deus. – Temperance falou alto de repente.
<p>- O quê? Tem algum bicho em mim? – Jason começou a se olhar e a balançar a camisa.
<p>- Não, o Nate está vindo para cá. – Temperance sussurrou enquanto tentava se esconder atrás dele.
<p>- Quem?
<p>- O Nate.
<p>- Quem é Nate? – Jason tinha memória fraca.
<p>- O garoto que eu conheci quando eu fazia seu trabalho. – Temperance sussurrou brava.
<p>- Nossa, parece que ele está te perseguindo. – Jason brincou.
<p>- É uma escola e estamos no corredor, óbvio que vamos nos encontrar. Não me envergonhe. – Temperance deu uma ordem.
<p>- Pode deixar, mãe.
<p>- Não diz isso...
<p>- Oi, Temperance. – Nathan se aproximou de Jason e Temperance.
<p>- Oi, Nate. – Temperance parecia uma boba rindo. Jason tentou disfarçar o riso daquela cena bizarra.
<p>- Você aqui de novo?
<p>- É. – Ela só ria. – Esse aqui é o... o... – Temperance olhava para Jason.
<p>- Jason. Eu sou o Jason. – Jason estava segurando a risada.
<p>- Muito prazer.
<p>- Uh, que educado. – Jason brincou.
<p>- Cala essa boca. – Temperance falou baixinho pra Jason. – O que você está fazendo aqui, Nate?
<p>- Ah, eu estou indo no meu armário para pegar um livro para eu ler na minha aula vaga.
<p>- Quem lê livro em aula vaga? – Jason comentou.
<p>Nate e Temperance olharam para Jason como se ele tivesse falado um palavrão.
<p>- Parece que gente chata lê. – Jason se sentiu intimidado. – Bom, eu já vou. Isso pode ser contagioso.
<p>- Onde você vai? – Temperance estava com medo de ficar sozinha com Nate.
<p>- Eu vou namorar, mas acho que vocês não sabem o que é isso, senão não estariam lendo nas aulas vagas.
<p>Jason piscou para os dois e foi embora.</p>
<center><h4>--*--</h4></center>
<p>- Que bom que mudou de ideia e aceitou meu convite para tomar o sorvete. – Kol e Lisa estavam na sorveteria.
<p>- Ah, eu percebi que não tinha nada demais. Dois amigos podem tomar sorvete juntos.
<p>- Mas é claro. – Kol sorriu. – Você contou para o Bran? Ele não se importou?
<p>- É claro que não. Ele até incentivou na verdade. O Jason que ficou me enchendo.
<p>- O que ele falou? – Kol não gostou do comentário sobre o Jason.
<p>- Ah, ele ficou falando que você estava dando em cima de mim. – Lisa riu. – Só ele mesmo para achar isso.
<p>- Ele tem o costume de achar que todo mundo é igual a ele.
<p>- Bom, não vamos falar do Jason, já que você não é muito fã dele.
<p>- Claro, vamos falar de coisas boas, tipo você.
<p>- Assim me deixa sem graça. – Lisa não gostou do papo.
<p>- Você veio de onde? – Kol tentou mudar de assunto rápido.
<p>- De Los Angeles. – Lisa fingiu que o último comentário de Kol não existiu para evitar um clima chato.
<p>- Sente falta de lá?
<p>- Um pouco. Dos meus pais principalmente. Mas está sendo legal ficar aqui.
<p>- É legal ir para longe de vez em quando.
<p>- Você veio de Londres recentemente, não é? É legal lá? – Lisa sempre quis sair do país e ir para Europa.
<p>- É bem legal sim. Um dia eu te levo lá.
<p>- Ah, claro. – Lisa tentou não levar o comentário a sério. – A Maddie disse que você ainda não está muito bem.
<p>- Bom, eu percebi que eu tenho que seguir em frente. E é o que eu estou tentando fazer.
<p>- Eu sei que é difícil, mas eu estou aqui se precisar de ajuda.
<p>- Bom saber. – Kol sorriu esperançoso.
<p>- Amigos são para isso. – Lisa deixou bem claro.</p>
<center><h4>--*--</h4></center>
<p>Jason e Emily foram para a casa de Brandon depois da aula.
<p>- Então é aqui que você está morando agora? – Jason levou Emily para o quarto.
<p>A casa estava vazia. Brandon ainda não tinha voltado da aula e os pais dele estavam trabalhando.
<p>- Por enquanto sim. Mas daqui a pouco eu volto a morar com a Lisa.
<p>- Você é meio que um sem-teto, não é? Ou cigano que vive pulando de um lado para o outro. – Emily brincou.
<p>- Vivo de caridade, é diferente. – Jason entrou na brincadeira.
<p>- O que estamos fazendo aqui? Achei que íamos comer bolinhos na padaria aqui perto.
<p>- Não me leve a mal. Eu não te trouxe para o quarto para apressar as coisas. A não ser que...
<p>- Não. – Emily falou logo.
<p>- Não, foi o que eu pensei.
<p>- O que foi? O que está acontecendo?
<p>- Eu preciso conversar antes. Uma coisa séria. – Jason fez uma cara séria, mas não combinava muito com ele.
<p>- Sim, eu quero ser sua namorada. – Emily disse logo.
<p>- A respeito disso...
<p>- Você não quer?
<p>- Não é isso. – Jason explicou. – Quer dizer, eu quero muito ser seu namorado, eu quero mesmo. Eu até ia mesmo te dizer isso.
<p>- Então...
<p>- Eu não sei como fazer isso. Como ser um namorado. Eu geralmente sou o garoto que fica com a garota e deixa ela no dia seguinte. E já se passaram dois dias e ainda não tentei fingir que não te conheço.
<p>- Eu sei disso. Mas se te deixa melhor, eu também acho que não sei ser uma namorada. Eu também sou nova nisso. Estou mais para solitária. – Emily ficou envergonhada.
<p>- Somos uma droga então. – Jason riu.
<p>- Eu acho que sim.
<p>- Olha, eu tenho uma ideia.
<p>- Ir devagar?
<p>- Sim e não, a gente aprende a ser namorados um com o outro. Quer dizer, podemos fazer isso juntos.
<p>- Bom, é meio óbvio né, já que não dá para namorar sozinho.
<p>- Você ficaria surpresa. – Jason fez Emily rir. – Bom, a partir de agora, se alguém perguntar, você é a minha namorada.
<p>- E você é meu namorado.
<p>- Feito
<p>- Feito. – Emily riu.
<p>- Agora chega de conversar. – Jason começou a beijar Emily.
<p>- E a parte de não querer avançar no segundo encontro? – Emily falou entre os beijos.
<p>- Ah, era só conversa fiada. – Jason riu e voltou a beijá-la.
<p>O computador de Brandon começou a apitar.
<p>- O que é isso? – Emily se assustou.
<p>- Ah, é só o computador do Cabelinho. Ignora. – Jason não ligou muito para isso, se importava mais com os beijos.
<p>O computador não parava de apitar.
<p>- Isso está quebrando o clima. – Emily riu.
<p>- E eu vou quebrar essa droga. – Jason foi para o computador com raiva.
<p>- O que está acontecendo? – Emily foi ver o que o computador estava fazendo.
<p>Na tela do computador estava escrito “POSTAGEM FEITA”.
<p>- O que é isso? – Jason começou a mexer no computador e mais embaixo estava escrito o post.
<p>- O que está escrito? – Emily tentou ler por cima do ombro de Jason.
<p>- Algo sobre mim e você e a Lisa, o Kol também é mencionado.
<p>- Não entendi. – Emily lia junto com Jason.
<p>- É um post do blog da escola.
<p>- E o que ele está fazendo no computador do Bran? – Emily ficou confusa.
<p>- Só tem uma explicação. – Jason ficou chocado. – O Bran é o blogueiro.
<p>- O quê? – Emily ficou surpresa.</p>
<br>
<p><i>“<b>NOVIDADES, PESSOAL:</b> Parece que Jason finalmente encontrou sua alma gêmea, ele e Emily foram vistos até andando de mãos dadas no corredor da escola, que fofo. E o prêmio de Amiga do Ano vai para Lisa que juntou os dois pombinhos com o seu poder do amor, estou emocionado aqui. Será que ela se sentiu tão culpada assim por brigar com o Jason que precisou fazer algo para se desculpar? Talvez. O ponto é que ela sabia que Jason e Emily estavam perdidamente apaixonados um pelo outro, mas ela ainda não percebeu que o estranho Kol está babando por ela, e quem também não percebeu é o ingênuo namorado dela. E aí, vamos ter um novo triangulo amoroso? Acorda para a vida, Lisa!!! Ah, e boa sorte no seu novo relacionamento, Temperance.”.</i> – Tesouro de Segredos Obscuros.</p>
</body></html>";
            }

            if (numero == 14)
            {
                lblTitulo.Text = "Capítulo 14 - Suspeitas";
                htmlPage.Html = @"<html><body>
<p>Emily continuava lendo o post com os olhos bem abertos.
<p>- Isso não pode ser. Deve ter alguma explicação.
<p>- Ah é? E qual? – Depois do choque, Jason começou a ter raiva. – Que o cabelo dele tem vida própria e eles que digitam as coisas?
<p>- Você precisa falar com ele. – Emily ignorou o comentário sem graça.
<p>- Por isso que ele não queria que eu olhasse essa droga de computador. Eu iria descobrir. – Jason não estava se aguentando de raiva.
<p>- Conversa com ele. – Ela insistiu.
<p>- Eu não vou conversar com ele. – Jason parecia uma criança birrenta.
<p>- E vai fazer o quê?
<p>- Eu vou dar um soco naquela cara redonda cheia de cabelo de ele tem. – Jason estava quase gritando.
<p>- Se acalma, está bem? Não vai chegar a lugar nenhum assim.
<p>- Você viu todas as coisas que ele escreveu sobre mim? Sobre a gente? Sobre a... Nossa, a Lisa vai pirar quando...
<p>- Jason, para. Temos que ter calma e pensar...
<p>- Eu não vou ter calma coisa nenhuma. Ele bancando o amigo coitado e por trás estava descendo a lenha em mim.
<p>- Olha, eu entendo, tá bom? Você está com raiva, em choque e essa é a sua primeira reação, mas você precisa se acalmar. Você precisa pensar melhor e...
<p>- Emily, não tem o que pensar.
<p>- Tem sim. Você não tem certeza de nada, e mesmo se o Brandon for o blogueiro, você não sabe porquê.
<p>- Deve ser porque ele cansou da vida dele e resolveu falar das dos outros.
<p>- Conversa com ele. É o único jeito.
<p>- Eu não acredito que ele fez isso. – De repente a raiva do Jason se transformou em decepção.</p>
<center><h4>--*--</h4></center>
<p>- Como aquele blogueiro miserável descobriu sobre o Nate? – Temperance estava lendo o post.
<p>- Isso não é a pior parte. – Brandon e Lisa estavam do seu lado lendo também.
<p>Os três estavam voltando da escola juntos. Tinha sido ideia do Brandon pra tentar aproximar mais as garotas.
<p>- Ele acha que o Kol está afim de você. – Brandon comentou.
<p>- É ridículo. – Lisa ficou sem graça.
<p>- Quando essa coisa vai parar? – Brandon desligou seu celular.
<p>- Quando o Jason descobrir quem ele é. – Lisa falou. – Ele vai conseguir.
<p>- Por que acha isso? – Temperance achou estranho a confiança cega de Lisa no Jason.
<p>- Eu conheço o Jason e quando ele decide fazer algo, ele faz.
<p>- Ele devia ter esse espirito nas provas. – Temperance comentou.
<p>- Também acho. – Lisa riu.
<p>- Bom, garotas, eu vou virar aqui. – Os três chegaram na rua da casa de Brandon. – Preciso arrumar a bagunça que o Jason deixa no meu quarto. – Brandon beijou Lisa e se despediu de Temperance. – A gente se vê depois.
<p>- Tchau. – As duas falaram juntas.
<p>Lisa esperou Brandon sumir na curva da rua para voltar a falar.
<p>- Temperance, eu posso falar com você?
<p>- Por que comigo? – Temperance não estava interessada. Achava até que seria um caminho silencioso até a sua casa.
<p>- Porque só Deus sabe onde o Jason está e eu preciso falar sobre isso.
<p>- Se não tem outro jeito, fale.
<p>- Eu acho que o Kol está mesmo a fim de mim.
<p>- O quê? O Kol? Sério? Não acha que é só o seu ego falando? – Temperance não deu muita importância.
<p>- Ele me falou umas coisas estranhas e me via de um jeito bem diferente.
<p>- Ele perdeu a namorada recentemente. Não deve estar pensando em namorar tão cedo.
<p>- Você acha?
<p>- Sim, e ele sabe que você tem namorado.
<p>- Quer saber? Você tem razão. Deve ser só da minha cabeça.
<p>- Isso.
<p>- Eu ia comentar isso com o Brandon, mas para que colocar isso na cabeça dele também? Vou deixar para lá. – Lisa decidiu.
<p>- É, ele já tem muita coisa na cabeça. Tipo cabelo. – Temperance riu.
<p>- Você está passando muito tempo com o Jason. – Lisa também riu.
<p>- É, e isso não é saudável.</p>
<center><h4>--*--</h4></center>
<p>Jason se encontrou com Lisa na manhã seguinte quando estavam no portão da escola.
<p>- Oi, Lisa. – Jason sorriu quando a viu.
<p>- Oi, Jay, tudo bem?
<p>- Tudo ótimo. Eu estava te esperando. Eu queria te perguntar uma coisa.
<p>- Pergunta. – Lisa percebeu que Jason estava nervoso.
<p>- Eu posso voltar para casa?
<p>- Mas é lógico, eu já te disse isso. Só que eu pensei que queria ficar com o Bran. Não foi isso que você me disse?
<p>- Você me conhece. Mudo de ideia fácil. – Jason tentou disfarçar.
<p>- O que aconteceu? Vocês se bateram de novo? – Lisa já olhou com cara feia.
<p>- Não. É que o xampu da casa dele está enrolando o meu cabelo. O ar está ajudando também. – Jason não sabia o que dizer.
<p>- Bom, o quarto está lá te esperando. – Lisa sabia que Jason não estava falando a verdade. – E quando quiser contar o que está acontecendo, eu vou estar esperando também.
<p>- Não está acontecendo nada. Só sinto a sua falta.
<p>- Também sinto a sua. Mas não me comprou com isso. – Lisa não estava convencida.
<p>- Oi, gente. – Emily chegou perto dos dois e Jason a beijou.
<p>- Olha só. – Lisa ficou feliz. – Quer dizer que estão dando certo. Não tenho costume de ver o Jason com a mesma garota por dois dias.
<p>- Muita engraçada. – Jason fingiu rir. – As garotas podem me mudar.
<p>- As garotas? – Emily perguntou.
<p>- A Emily pode me mudar. – Jason corrigiu logo.
<p>- Melhor assim.
<p>- Bom, gente, fiquem aí namorando que eu vou procurar o meu namorado. – Lisa se despediu.
<p>- Ele deve estar em algum computador por aí. – Emily olhou feio para Jason depois desse comentário. – Ele me falou que precisava terminar um trabalho. – Jason mudou a frase.
<p>- Bom, eu vou encontra-lo. Tchau.
<p>- Você contou para ela? – Emily perguntou para Jason assim que Lisa foi embora.
<p>- É claro que não. A conversa ia ser interessante: Ei, Lisa, sabe o blogueiro que praticamente te chamou de vadia oferecida, então ele é o seu namorado.
<p>- Você não tem certeza disso.
<p>- Os fatos caíram na nossa cara, só você não quer ver isso e eu nem sei porque.
<p>- Me desculpe, mas eu não costumo pensar de cabeça quente e tirar conclusões precipitadas.
<p>- Me desculpa, mas eu não sou tão calmo como você.
<p>- Aprenda a ser senão você vai se dar mal.
<p>- Que saco. E desde quando você defende tanto o Brandon? Conhece ele tão bem assim para confiar tanto nele?
<p>- Eu não estou defendendo o Brandon. Eu mal conheço ele.
<p>- Então... – Jason não entendia, esperava que Emily ficasse do seu lado.
<p>- A questão é que eu só acredito em fato. A gente só tem uma desconfiança. Só isso. Não vale a pena armar um circo por isso.
<p>- Ah, vale sim.
<p>- Jason, por favor. Tenta se controlar.
<p>- Não prometo nada.
<p>Jason pegou na mão de Emily e os dois começaram a andar. Ele ficou quieto e com a cara fechada por um tempo, mas pelo menos não estava elétrico e querendo matar o Brandon, isso Emily já considerava um avanço.</p>
<center><h4>--*--</h4></center>
<p>- Foi legal seu encontro com a Lisa? – Maddie e Kol estavam indo para a escola.
<p>- Não foi um encontro. Você disse que era para eu agradecer e foi o que eu fiz. Levei ela para tomar um sorvete. – Kol explicou.
<p>- Você odeia sorvete. – Maddie não entendeu.
<p>- Eu só fui ser legal.
<p>- Por favor, me diz que não está começando a gostar dela. Isso é errado. – Maddie já fez sua cara de reprovação.
<p>- É claro que não. – Kol fechou a cara. – Eu não estou pronto para namorar ainda.
<p>- Eu quero muito que você siga em frente, mano, mas não com a Lisa. Ela está com o Bran.
<p>- Eu sei.
<p>- Não quero que se machuque de novo. – Maddie estava preocupada.
<p>- Eu não vou, pode relaxar.
<p>- Mas...
<p>- Eu já disse que não estou a fim da Lisa. Mas que droga!
<p>Kol ficou bravo e começou a andar mais rápido.</p>
<center><h4>--*--</h4></center>
<p>- Eu tentei te ligar ontem, mas só dava ocupado. – Jason encontrou Temperance na biblioteca. Ele estava um pouco ansioso para conversar com ela.
<p>- Me desculpa. – Temperance sorriu. – Mas eu fiquei conversando com o Nate a noite toda. – Ela sussurrou a última parte.
<p>- Sobre o quê? – Jason já imaginava.
<p>- Sobre documentários da TV, livros com histórias legais, notícias... – Ela continuava sussurrando.
<p>- E como não dormiu no meio da conversa?
<p>- Sem graça. Foi perfeita. Até sonhei com ele.
<p>- Por que você está sussurrando?
<p>- Porque...
<p>- Bom, eu encontrei o livro que eu te disse ontem. – Nathan chegou segurando um livro bem grosso e todo contente.
<p>- Entendi. – Jason percebeu. Temperance não queria que Nate escutasse por isso estava sussurrando.
<p>- Que legal, estou ansiosa para ler. – Temperance sorriu.
<p>- Olha, vocês podem continuar a conversa entediante mais tarde? – Jason falou logo.
<p>- Jason!
<p>- Como assim? – Nathan não estava acostumado com os comentários do Jason.
<p>- Desculpa, eu esqueci o seu nome então vou te chamar de José...
<p>- É Nathan.
<p>- Olha, José, será que você não pode ler em outro lugar? Eu preciso falar com a Tempe agora.
<p>- Ah, claro.
<p>- Claro que não. – Temperance falou logo. – Nate, você não precisa ir.
<p>- Precisa sim. – Jason falou. – É importante.
<p>- Ah, sem problema, a gente se fala depois, Temperance.
<p>- Mas...
<p>- Tenho certeza que ela vai adorar falar com você depois. – Jason respondeu por Temperance.
<p>Tudo bem então. – Temperance fechou a cara para Jason. – Será que tem como eu te odiar mais? – Ela não sussurrou mais para Jason.
<p>- Também te amo, agora precisamos falar sério.
<p>- Eu não fico expulsando a Emily quando estão juntos. – Temperance estava com raiva.
<p>- Ai, já faz um minuto, supera isso.
<p>- Não.
<p>- Olha, eu descobri uma coisa que pode te deixar chocada. – Jason ficou sério.
<p>- O quê? A Emily é mais chata do que achou que era? Não estou chocada. Falha na missão. – Temperance provocou.
<p>- Há quanto tempo conhece o Cabeça de Cachos?
<p>- Eu conheço o Cabe... Conheço o Bran a minha vida toda.
<p>- Ele sempre foi muito cibernético?
<p>- O quê? – Temperance não entendeu.
<p>- O Bran é o blogueiro. – Jason falou logo.
<p>- Ele é o seu suspeito da semana? Ainda bem que não acha mais que sou eu. – Temperance não levou a sério.
<p>- Eu encontrei todos os posts do blogueiro no computador do Brandon.
<p>- No computador que ele não deixa ninguém mexer? Você mexeu nele?
<p>- Nesse mesmo. O computador avisou quando um post do blog foi postado e todos os outros estavam salvos lá.
<p>- Você falou com ele? – Temperance não queria acreditar. – O blogueiro já falou dele também.
<p>- Eu também não quero acreditar, mas não consigo parar de pensar nisso.
<p>- Não, na verdade, você já condenou o Brandon e só quer que eu te ajude a escolher a sentença.
<p>- Na verdade, eu já sei a sentença, só vim aqui te avisar. – Jason mostrou um sorriso sarcástico.
<p>- Eu não consigo imaginar o Bran fazendo isso, mas você parece tão convencido.
<p>- Não sei o que fazer. – Jason queria uma luz. – Eu quebro o nariz dele ou o deixo de olho roxo?
<p>- Você não vai brigar com ele.
<p>- Por que não? Ele acabou comigo.
<p>- Você precisa confirmar.
<p>- Ele nunca vai confessar. Emily acha que tem alguma explicação.
<p>- Também quero que tenha.
<p>- É tão óbvio. Por que vocês são tão bobas?
<p>Mas Temperance não respondeu.</p>
<center><h4>--*--</h4></center>
<p>- Jason, oi. – Kol se sentou junto com Jason no almoço.
<p>- O Semancol falando comigo? – Jason ficou desconfiado. – O Apocalipse é daqui a uma hora?
<p>- Sem piadas, por favor.
<p>- O que você quer? – Jason sabia que Kol não estava lá por acaso.
<p>- A Lisa fala de mim para você?
<p>- Não, por que deveria falar?
<p>- Ah, por nada. – Kol ficou com vergonha.
<p>- Fala logo. – Jason conhecia as pessoas.
<p>- É que ela me ensinou matemática e...
<p>- E ela contando até dez te deixou excitado? – Jason sabia que Kol estava a fim de Lisa. Outra coisa que era óbvia e que ninguém queria acreditar.
<p>- Isso não tem nada a ver.
<p>- Não me convenceu. Mas se não quer falar, sai daqui. Não foi eu que te chamei.
<p>- Você acha errado eu gostar de alguém mesmo eu estando de luto? – Kol foi logo ao assunto.
<p>- Você quer um conselho meu?
<p>- Bom...
<p>- Nossa, como os tempos mudaram, hein. Olha, eu não sou bem a pessoa que julga o certo e o errado. Eu sou o cara que terminou com uma garota e duas horas depois estava no banheiro conhecendo melhor outra garota.
<p>- Eu estou falando sério. – Kol ficou bravo.
<p>- Eu também.
<p>- Ela era o amor da minha vida.
<p>- Mas ela morreu. Vai ficar na seca para o resto da vida? Somos homens, precisamos das mulheres por perto, é a nossa natureza.
<p>- Eu não sei.
<p>- Você está gostando da Lisa?
<p>- Eu não sei, ela foi a única garota que foi legal comigo há muito tempo.
<p>- É que não é tão fácil ser legal com você. Mas não se engane, a Lisa é legal com todo mundo. Faz parte de quem ela é, além do mais, ela gosta do Bran. Acho que você devia se afastar.
<p>- Você tem razão.
<p>- Sério? É difícil alguém dizer isso para mim. Estou curtindo nossa amizade. – Jason sorriu.
<p>- Não somos amigos.
<p>- Então sai daqui, porque olhar para você está me embrulhando o estômago. – Jason continuou sorrindo.
<p>- Ridículo.
<p>- Tô nem aí.</p>
<center><h4>--*--</h4></center>
<p>- Você estava com o Jason quando ele descobriu que o Bran era o blogueiro? – Temperance viu Emily na aula de Geografia e a abordou.
<p>- Estava, mas ainda não me convenci que o Brandon seja o blogueiro.
<p>- O Jason tem certeza disso. – Temperance ficou na dúvida.
<p>- Bom, eu não conheço o Brandon direito, então eu não sei. Só que me pareceu tudo meio estranho.
<p>- O Bran é meu amigo desde sempre, não quero acreditar que seja ele. Ele não seria capaz de fazer uma coisa dessas.
<p>- Se você está dizendo... E por que estamos conversando? Ontem você me odiava.
<p>- Tem razão, hoje eu só não gosto de você. – Temperance deu um sorriso falso.
<p>- Não me ame amanhã.
<p>- Pode deixar.</p>
<br>
<p><i>“<b>MUITO AMOR ESTÁ ROLANDO:</b> Parece que a Lisa está roubando corações por aí. Abra o olho, Bran, porque seu cabelo não vai esconder os chifres. Parece que o Kol nem deixou o corpo da ex esfriar e já está soltando as asinhas. Ele confessou para o nosso pessoal que está de quatro pela Lisa. Ele pode ser estranho, mas tem um bom gosto, não podemos negar.”.</i> – Tesouro de Segredos Obscuros.</p>
<br>
<p>- Por que fez isso? – Kol parou Jason no corredor muito bravo.
<p>- Da última vez que me abordaram assim, me jogaram de contra com o armário, vai fazer igual? – Jason não estava entendendo nada.
<p>- Você é um idiota.
<p>- O que eu fiz dessa vez? – Jason ainda não tinha visto o blog.
<p>- Não acredito que confiei em você.
<p>- O que foi que eu fiz?
<p>- Você contou para o blogueiro que eu estou gostando da Lisa. – Kol empurrou Jason.
<p>- O quê? Eu não fiz nada disso. – Jason deu de ombros.
<p>- Jason! – Emily veio correndo para apartar a briga.
<p>- O que está acontecendo aqui? – Jason não estava entendendo mais nada.
<p>- O blogueiro postou que o Kol está gostando da Lisa. – Emily explicou.
<p>- E eu só contei isso para você. – Kol estava bravo.
<p>- Olha, eu não falei nada, tá bom?
<p>- Eu não acredito em você.
<p>- Que se dane. – Jason ficou bravo. – Você não foi o primeiro e nem vai ser o último a desconfiar de mim, então entra na fila.
<p>- Você se diverte com isso, não é? Não tem consideração por ninguém.
<p>- Menos, Kol, bem menos.
<p>- Você é um otário. – Kol gritou e todo mundo no corredor ficou olhando.
<p>- Aquele infeliz me paga. – Jason saiu correndo nervoso e deixou Kol falando sozinho.
<p>- Jason, não! – Emily saiu correndo atrás de Jason.</p>
<center><h4>--*--</h4></center>
<p>- Seu desgraçado. – Jason empurrou Brandon contra o armário.
<p>Ele já estava quase sem fôlego, tinha corrido por toda a parte procurando por Brandon.
<p>- Jason! – Lisa que estava do lado de Brandon se assustou.
<p>- O que você está fazendo? – Brandon não entendeu.
<p>- Por que você está fazendo isso? – Jason estava vermelho de raiva. – Qual é o seu problema, cara?
<p>- Fazendo o que? – Brandon estava confuso. – Eu não estou te entendendo.
<p>- Eu sei, tá bom? Para de fingir.
<p>- Sabe o quê?
<p>- Jason, o que está acontecendo? – Lisa não estava entendendo nada.
<p>- Eu sei que você é o blogueiro. – Jason quase gritou.
<p>- O quê? – Brandon ficou em choque.
<p>- Eu vi no seu computador. Eu vou acabar com a sua cara. – Jason partiu para cima de Brandon.
<p>- Não, Jason, espera. – Lisa entrou no meio dos dois. – Calma.
<p>- Vai defender ele agora? – Jason ficou com mais raiva. – Depois de tudo o que ele falou da gente?
<p>- Eu não sei do que você está falando. – Brandon se defendeu.
<p>- Precisamos ficar calmos. – Lisa não estava calma.
<p>- Você precisa sair da frente. – Jason encarou a amiga.
<p>- Eu não vou sair.
<p>- Vai sim. – Jason tirou Lisa a força do meio dos dois. – Isso é entre o Cabeludo e eu.
<p>- Jason, eu não sei do que você está falando. – Brandon parecia desesperado.
<p>- Para de mentir. – Jason socou um armário perto de Brandon. – O próximo soco vai ser na sua cara.
<p>- Jason, tenha calma. Você está enganado. – Brandon não sabia mais o que dizer.
<p>- Eu nunca estive tão certo. – Jason empurrou Brandon de novo.
<p>- Já chega! – O diretor ouviu o tumulto.
<p>- Diretor? – Lisa ficou com medo.
<p>- Jason Porter, para a diretoria agora. – O diretor separou Jason de Bran. – E quanto a você, Brandon, tome cuidado na próxima.
<p>- Ah, quer dizer que eu vou para a diretoria e ele só deve tomar cuidado? – Jason não se conformou.
<p>- Vamos agora. – O diretor ordenou.
<p>- Mas...
<p>- Quem começou a briga? – O diretor encarou Jason.
<p>- Minha mãe.
<p>Jason sabia que não tinha porque discutir com o diretor. Ele estava com problemas de qualquer jeito.</p>
<center><h4>--*--</h4></center>
<p>- E aí, qual é o meu castigo? – Jason se sentou na cadeira de frente para o diretor que continuava de pé.
<p>- Eu tenho o seu histórico, Jason. Eu sei que foi expulso da outra escola porque se meteu em uma briga.
<p>- O quê? Vai me expulsar daqui também? – Jason parecia que não estava ligando.
<p>- Eu vou começar com um aviso e uma detenção.
<p>- Ótimo, posso ir agora?
<p>- Não. Eu quero te dizer que esse colégio é sério.
<p>- Eu sei, está bem? É um novo colégio, com novas pessoas e...
<p>- E você continua com o mesmo hábito. – O diretor completou.
<p>- Você não me conhece. – Jason o enfrentou.
<p>- Tem razão. Mas espero poder conhecer.
<p>- Olha, chega de papo furado, está bom? Eu não estou a fim de ouvir.
<p>- Acha que tudo se resolve no soco? Pessoas com educação conversam para acabar com as diferenças.
<p>- Como eu disse, você não me conhece.
<p>- Mas eu sei como é ser um adolescente e...
<p>- Olha, eu não quero ouvir uma história de vida. – Jason o interrompeu. – Ou um sermão. Eu não preciso disso. Se não vai me expulsar, então deixa eu sair daqui, se vai me expulsar, me expulse logo.
<p>- Você realmente não se importa?
<p>- Eu não me arrependo de nada do que eu faço. E se eu sair daqui e dar de cara com o Bran, eu vou brigar com ele de novo.
<p>- Ótimo, então vai ficar aqui até a aula acabar.
<p>- Que bom, eu odeio Física mesmo. – Jason cruzou os braços.
<p>- Olha, Jason...
<p>- Não, olha você, você enche a boca para falar que esse é um colégio sério, mas não mexeu um dedo para acabar com esse tal blog que está falando de todo mundo já faz tempo.
<p>- Eu não posso fazer nada. Não posso controlar o que as pessoas vêm na internet dos seus computadores e celulares.
<p>- E se o blogueiro falasse de você? Mesmo assim não poderia fazer nada?
<p>- Isso é diferente.
<p>- Não, isso é hipocrisia. Eu posso ser infantil e não medir meus atos, mas eu faço o que eu acho certo para mim e para as pessoas que eu gosto.
<p>- Mas acha que brigar vai resolver alguma coisa?
<p>- Para mim, vai. Com toda a certeza.
<p>- Eu preciso falar com os seus pais.
<p>- Boa sorte. Eu que sou filho não consigo. – Jason riu.
<p>- Sinto muito. – O diretor então achou que entendia o problema de Jason.
<p>- Não sinta. É uma coisa boa.
<p>- Você quer conversar?
<p>- Parece que eu quero conversar? Sabe o que eu quero? Eu quero que isso acabe. Eu estou cansado de andar pelos corredores e as pessoas apontando os dedos para mim e ouvindo conversinhas do quanto eu sou horrível. – Jason se levantou. – Até onde isso tem que ir para você parar de fingir que não está vendo nada e começar a agir? Eu tenho certeza que você tem o poder para fazer isso acabar, mas por algum motivo, você não se importa.
<p>- Jason...
<p>- Mas eu me importo. E se para parar com isso, eu precisar brigar mais algumas vezes, eu vou brigar, não tenha dúvidas.
<p>- Você sabe quem é esse blogueiro anônimo? Tem provas para isso? Ou vai bater primeiro e perguntar depois?
<p>- Não é da sua conta, afinal, você não pode fazer nada. Do que adianta você saber de alguma coisa?
<p>Jason virou o rosto. A conversa tinha acabado para ele.</p>
<center><h4>--*--</h4></center>
<p>Jason estava arrumando suas roupas dentro das suas malas. Ele estava saindo da casa de Brandon.
<p>- Jason, a gente pode conversar? – Brandon entrou no quarto enquanto Jason arrumava as suas coisas.
<p>- Bran, vai ser rápido, tá bom? Não quero te bater na sua casa então fica longe de mim.
<p>- Eu te dei um teto e é assim que você me retribui?
<p>- O quê? Vai me chamar de mal-agradecido agora? Posta lá no blog o otário que eu sou e que só te maltrato. Eu até gravo um áudio se você quiser.
<p>- Jason, eu não quero brigar.
<p>- O que você quer então, Brandon?
<p>- Eu quero te explicar.
<p>- Você não tem nada para explicar. Eu já sei o suficiente. – Jason estava socando as roupas nas mochilas com força.
<p>- Eu não sou o blogueiro. Você precisa acreditar em mim. – Brandon quase suplicou.
<p>- Ah não?
<p>- Não.
<p>- Seu computador diz o contrário.
<p>- Eu coloquei um alerta no blog. – Brandon explicou.
<p>- O quê? – Jason parou de mexer nas roupas e encarou Brandon. – Como assim?
<p>- O meu computador avisa logo depois que o blog é atualizado.
<p>- Por quê? – Jason não estava caindo na história.
<p>- Para eu poder ler tudo o que sai, sem perder nada.
<p>- Então você é um aspirante a fofoqueiro?
<p>- Eu já fui como você. – Brandon não sabia mais o que fazer.
<p>- Eu duvido.
<p>- Não como você, mas o blogueiro já pegou no meu pé no segundo ano.
<p>- Por quê? – Jason queria saber de tudo. Ainda não tinha decidido se acreditava no Brandon.
<p>- Eu não sei. Ele resolveu que eu era o assunto de entrada dele e ficou no meu pé por semanas, foi horrível. Eu passei pelo que você passou.
<p>- Eu sei o quão horrível ele pode ser. – Jason se lembrou dos seus primeiros dias no colégio.
<p>- Então eu resolvi não perder nada e sempre saber o que ele dizia, sem falar que eu tenho essa vontade de descobrir quem ele é também. Eu já passei noites lendo e relendo os posts na esperança de encontrar alguma pista que me levasse ao blogueiro.
<p>- Mas foi um fracasso. – Jason imaginou certo.
<p>- Eu sei que não somos muito amigos, mas...
<p>- Eu quero ler esses posts. – Jason continuava sério e parecia que iria bater no Brandon a qualquer momento.
<p>- Claro. – Brandon ligou o computador. – Agora não dá mais para esconder minha obsessão.
<p>Jason se sentou perto do computador e começou a ler todos os posts desde o primeiro. O blogueiro tinha pegado pesado mesmo com o Brandon no começo falando coisas horríveis dele, coisas que alguém tímido não saberia lidar muito bem. Mas ele não tinha sido a única vítima, logo que ele se cansou de Brandon, o blogueiro foi atrás de outros.
<p>- Quem é Jefferson? – Jason viu que o blogueiro acabou com a reputação de bom moço do garoto.
<p>- Ele roubava dinheiro de todo mundo para comprar drogas. – Brandon respondeu. – Ele foi expulso e depois preso.
<p>- Samuel? – Jason continuou olhando.
<p>- Pelo que eu sei, ele batia nos calouros, acho que era por esporte.
<p>- O blogueiro foi em pró dos fracos e oprimidos? Que lindo. – Jason só sabia ter mais raiva.
<p>- Parece que em boa parte do tempo sim. Mas eu não sei porque ele ficou em cima de mim. Eu nunca fiz nada de mal.
<p>- Ele me crucificou no meu primeiro dia. Você não foi o único a ser injustiçado. – Jason continuou a ler os posts. – Samantha?
<p>- É a garota que depois que foi expulsa eu descobri que mexia com a Tempe.
<p>- É, eu sei. A Tempe já me contou essa história. – Jason começou a ler os posts sobre a Samantha.
<p>- Eu me lembro que a Emily ficou aliviada quando a Samantha foi expulsa. – Brandon comentou. – Também, depois de tudo o que essa garota fez para a Emily, ela tinha o direito de dar uma festa.
<p>- Emily? A minha Emily? – Jason não entendeu. – Ela me disse que era amiga da Samantha. Melhor amiga.
<p>- Amiga? Todo mundo falava que essa tal de Samantha era a maior valentona da escola e obrigava umas garotas a serem meio que seguidoras dela, a Emily foi uma dessas garotas.
<p>- Seguidora?
<p>- Empregada. Ela maltratava todo mundo.
<p>- Então elas não eram amigas. A tal da Samantha ameaçava a Emily. Por que ela mentiu para mim então?
<p>- Eu não sei.
<p>Jason tinha outra coisa na cabeça agora. Outra novidade. Era tanta informação que ele sentia que sua cabeça ia explodir a qualquer momento.</p>
<center><h4>--*--</h4></center>
<p>- Eu conversei com o Macarrão de Parafuso e eu percebi que ele não era o blogueiro.
<p>- Viu? Você quase foi expulso por nada. – Emily e Jason estavam tomando café da Cafeteria.
<p>- Esse é o meu problema, sempre penso com a cabeça quente. – Jason finalmente tinha concordado.
<p>- Eu não sabia que o blogueiro tinha falado mal do Bran. Bom, na verdade, eu só comecei a acompanhar o blog quando começaram a falar da Samantha.
<p>- Aquela sua amiga? – Jason estava tentando sacar a namorada.
<p>- Isso.
<p>- Sabe, o Cabelo de Rodinha salvou todos os posts do blogueiro.
<p>- Isso é o que chamamos de obsessão.
<p>- É, ele é bem mais obcecado que eu. Quem diria?
<p>- É. – Emily riu.
<p>- Só que o mais interessante é que os posts da Samantha dizem que ela não tinha amiga nenhuma.
<p>- Eu sempre fui uma ninguém, você sabe disse. Ninguém me notava, eu já te disse que eu era meia solitária. – Emily percebeu que Jason estava desconfiado. – Por que estamos falando disso?
<p>- Porque desde que eu te conheci, eu conto tudo para você, você sabe praticamente a minha vida toda e agora eu estou percebendo que não sei tanto assim de você.
<p>- Jason...
<p>- Quando vimos os posts do blog no computador do Brandon, qualquer um que visse diria que ele era culpado, até a Tempe ficou na dúvida, mas você não, você queria me convencer que não era ele.
<p>- E acabou que não era. Eu sou culpada por isso? Onde você quer chegar?
<p>- Como você sabia exatamente que não era ele?
<p>- Jason, não começa, eu sei o que está pensando.
<p>- De algum jeito, o blogueiro sabe o que as pessoas falam para mim. E eu já passei noites me perguntando como ele sabia, mas agora eu vejo como é simples. O blogueiro sabia todas as minhas conversas porque eu contei todas para ele.
<p>- E lá vamos nós começar outra semana onde o Jason achava que a sua namorada é o blogueiro. – Emily ficou brava. – Isso é ridículo.
<p>- A Samantha te manipulava e então o blog começou a falar mal dela e ela foi expulsa e olha só quem ganhou com isso?
<p>- Eu já saquei. Tudo bem, eu não te disse a verdade sobre a Samantha. O que isso importa? A gente acabou de se conhecer. É uma coisa minha que é difícil de falar com as pessoas.
<p>- Mas...
<p>- Eu nunca falei disso nem para minha mãe, quanto mais para um garoto que eu mal conheço e que talvez eu possa gostar.
<p>- Talvez?
<p>- Você está fazendo eu perder a minha paciência. – Emily estava quase levantando da cadeira para ir embora.
<p>- O blog disse que eu falei coisas sobre você, mas você não acreditou, você não brigou comigo como a Temperance ou como a Lisa ou até como o Kol. Você só acreditou em mim. Eu fiquei maravilhado no dia, mas agora eu vejo... Ninguém é tão perfeita assim.
<p>- Então é isso que você acha? – Emily cruzou os braços e encarou Jason. - Que eu sou a blogueira?
<p>- Me diz que não é.
<p>- Para quê? Você não vai acreditar. Parece que você já tem a sua opinião formada. Você já tem um caso todo montado contra mim.
<p>- Então é isso?
<p>- Parece que é. – Emily estava decepcionada.
<p>- Então não vai tentar se explicar? – Jason insistiu.
<p>- Você é meu namorado. Deveria acreditar em mim. Não é isso que você sempre pede? Que as pessoas acreditem em você?
<p>- Eu mal te conheço. Você acabou de mentir para mim. Acha mesmo que está na posição de exigir confiança?
<p>- Parece que não.
<p>- Jason, ainda bem que eu te achei. – Temperance entrou correndo na Cafeteria e quase tropeçou quando chegou até a mesa onde os dois estavam.
<p>- Tempe, agora não. – Jason queria terminar a conversa com Emily.
<p>- É importante. O blogueiro acabou de postar sobre a sua quase expulsão, e muito obrigada por me avisar que isso aconteceu. – Temperance jogou seu celular no colo de Jason.
<p>- O blogueiro acabou de postar? – Jason não acreditou.
<p>- Que legal, não é? – Emily ficou com raiva. – Parece que eu estou usando um celular invisível ou digitando no ar para conseguir postar sem você nem perceber. Ou eu sou um robô, eu apostaria nessa última.
<p>- Emily, olha... – Jason tinha feito uma idiotice.
<p>- Que bom que você acha que eu sou a blogueira, Jason.
<p>- Me escuta...
<p>- Alias, agora eu quero muito que ele acabe com você.
<p>Emily se levantou e foi embora.
<p>- Emily!
<p>- O que aconteceu? – Temperance não entendeu nada.
<p>- Eu fiz bobagem como sempre. – Jason estava se sentindo um idiota naquele momento.</p>
<br>
<p><i>“<b>CALMA, JASON, NÃO VALE A PENA SER EXPULSO POR MINHA CAUSA:</b> Gente, eu estou feliz porque finalmente querem me conhecer melhor, mas tem gente passando dos limites para fazer isso acontecer. Ah, e cara, é com você mesmo Jason, não tente me encontrar, porque sempre que você achar que está me pegando, eu vou dar a volta e pegar você, mas relaxa. A gente se vê por aí.”.</i> – Tesouro de Segredos Obscuros.</p>
</body></html>";
            }

            if (numero == 15)
            {
                lblTitulo.Text = "Capítulo 15 - Passado";
                htmlPage.Html = @"<html><body>
<p>Jason tinha acabado de dizer para Lisa que ele desconfiou de Emily quando ela deu um grito que quase o assustou.
<p>- Você é um idiota!
<p>Os dois estavam no quarto de Jason e ele contou toda a história enquanto arrumava suas roupas de novo nas gavetas da cômoda.
<p>- Eu errei, tudo bem? Mas eu tinha o direito de ficar suspeitando. – Jason estava bravo também. Ele demonstrava isso enquanto jogava suas roupas com força de volta ao seu guarda-roupa.
<p>- Ela é sua namorada, devia confiar nela. Se um dia o Bran chegasse em mim e me acusasse desse jeito, eu nunca mais olharia na cara dele.
<p>- O Eu-Nunca-Ouvi-Falar-De-Cabeleireiro nunca te acusaria. É bobo demais para isso.
<p>- Por que você fez isso?
<p>- Porque esse blogueiro está me deixando louco. Está mexendo com a minha cabeça e fazia sentido na hora. Fazia muito sentido. Ele é um ridículo.
<p>- E vale a pena ser expulso ou perder a garota que você gosta por causa dele?
<p>- Eu não dou a mínima para a expulsão.
<p>- Mas se importa com a Emily. – Lisa era a única que conhecia Jason até melhor do que ele mesmo.
<p>- É lógico.
<p>- Então o que ainda está fazendo aqui? Vai falar com ela.
<p>- Ela não vai querer me ouvir.
<p>- Você sabe ser um pé no saco quando quer e quando não quer também, então faça ela te ouvir.
<p>- Diz como se fosse fácil. </p>
<center><h4>--*--</h4></center>
<p>- Seu amigo é meio louco. – Nathan ria das coisas que a Temperance falava. Nathan tinha ido com ela até a cafeteria atrás de Jason e depois que ele e a namorada foram embora, os dois resolveram ficar para comer alguma coisa.
<p>- Não, o Jason é inconsequente, só isso.
<p>- Vocês são tão diferentes e mesmo assim tão amigos.
<p>- É, acho que a gente se completa. – Temperance ficou pensativa.
<p>- E quanto ao Brandon?
<p>- Ele é diferente, somos mais parecidos do que todo mundo pensa e ele sempre esteve comigo.
<p>- São amigos há muito tempo?
<p>- Tempo o suficiente, nos conhecemos desde criança.
<p>- Nossa, Brandon e Jason, como vou competir com eles?
<p>- Competir? – Temperance não entendeu o comentário de Nathan.
<p>- Você já tem dois grandes amigos. Será que ainda precisa de um terceiro?
<p>- Um terceiro amigo? Tudo o que eu mais quero é isso. – Ela não queria isso.</p>
<center><h4>--*--</h4></center>
<p>- Um terceiro amigo? – Jason estava tirando sarro de Temperance. – Você precisa mesmo de mais amigos.
<p>Jason foi a primeira pessoa que Temperance encontrou de manhã na escola e precisava muito contar aquilo para alguém.
<p>- É, ele disse exatamente isso. – Temperance continuava séria.
<p>- Garota, você está mesmo na zona da amizade. Acho que esse lugar é o seu destino. Brandon, agora esse cara... Muitos dizem que até comigo... – E as piadas continuavam.
<p>- Isso não tem graça. Ele é o cara perfeito para mim.
<p>- Mas só quer a sua amizade ou pelo menos um terço dela.
<p>- Olha só, você sabe fração. – Temperance resmungou.
<p>- Olha só, deve ser por isso que ele só quer sua amizade. – Jason retrucou.
<p>- Ai, sai daqui. – Temperance o empurrou de leve no meio do corredor.
<p>- Não posso.
<p>- Por que não? Não nascemos grudados.
<p>- Eu preciso relaxar a mente e pensar em outra coisa. Nos problemas dos outros. A Lisa já me encheu o dia todo ontem querendo que eu falasse com a Emily, você é a única que me restou.
<p>- E eu volto a ser a segunda opção de novo.
<p>- Sem drama, tá bom? Eu que deveria estar fazendo drama.
<p>- Você já faz drama noventa por cento do seu dia, uma hora tem que dar uma folga e deixar um pouco para os amigos.
<p>- Espero que morra sozinha, sabia? Você às vezes merece. – Jason arregalou os olhos para Temperance.
<p>- Desculpa, eu não estou vendo a sua namorada aí do seu lado.
<p>- Ela é imaginária.
<p>- Isso é triste. – Temperance queria que Jason pagasse em um dia tudo o que ele já falou para ela.
<p>- Espera um pouco, o seu cara perfeito te dá um fora e você resolve me atacar? Eu não tenho culpa que você não é direta.
<p>- Mas eu... – Temperance começou a gaguejar. – Eu... Eu dei sinais.
<p>- Ficar olhando para ele não é um sinal. Nem perguntar como ele penteia o cabelo.
<p>- Ele deveria saber que eu estou a fim dele.
<p>- Caras não entendem indiretas, se gosta dele, vai lá e fala.
<p>- O Bran sempre me disse que garotas atiradas assustam os garotos.
<p>- Eu gosto das garotas atiradas. Eu não preciso pedir, elas já vão e tiram a roupa antes de mim.
<p>- O quê? – Temperance deu um olhar de reprovação.
<p>- Eu não deveria ter dito isso. Vou falar algo melhor, tá bom? Se levarmos a experiência da vida triste do Bren-enrolado, se a garota que ele gosta, aquela que eu costumo chamar de Lisa, não tivesse se atirado para ele, eles estariam até hoje falando sobre xampu e condicionador para cabelos crespos e sedosos.
<p>- Qual é o seu problema com o cabelo do Bran?
<p>- Eu não sei, só gosto de falar coisas engraçadas sobre ele. É mais forte do que eu, não consigo parar de rir quando vejo.
<p>- Você está aqui me fazendo companhia por que quer evitar a Emily?
<p>- É lógico que não. – Jason mentiu e muito mal por sinal.
<p>- Uma hora vão ter que conversar.
<p>- Para de ficar do lado dela. Você a odeia, lembra?
<p>- Eu não estou do lado dela, mas você foi o errado. Ela acreditou em você uma vez, e você duvidou dela na primeira chance que teve.
<p>- É diferente. Eu contei tudo da minha vida para ela e ela escondeu tudo de mim.
<p>- Não se trata disso.
<p>- Tudo bem, eu posso ter alguns problemas de confiança.
<p>- Ai, meu Deus, você está com medo. – Temperance ficou chocada. Até colocou a mão na boca.
<p>- Eu não estou com medo. Um pouco apavorado, temeroso, assustado, mas com medo não.
<p>- Ridículo.
<p>- A mão dela é muito pesada e ela tem cara de ser nervosinha.
<p>- Vocês enrolaram uma vida para começarem a namorar. Vai lá e conserta, seja homem pelo menos uma vez na vida.
<p>- Eu sempre sou homem.
<p>- Prova.
<p>Jason fuzilou Temperance com os olhos.</p>
<center><h4>--*--</h4></center>
<p>- Kol, oi, que bom que você veio. A gente precisa conversar. – Lisa havia ligado para Kol e pedido para ele encontra-la perto de casa para poderem ir juntos para escola e ela poder bater um papo com ele sozinha.
<p>- Precisamos mesmo. O blogueiro, ele...
<p>- Eu não quero falar sobre o que saiu no blog. – Lisa foi direta.
<p>- Que bom.
<p>- Kol, eu quero muito ser sua amiga, mas se você quer algo a mais, eu sinto muito, vamos ter que nos afastar então.
<p>- Não, Lisa, por favor. Não se afasta.
<p>- Eu gosto muito do Bran. Não vai acontecer nada entre a gente.
<p>- Eu sei. – Kol se sentou na guia da calçada.
<p>- Olha, eu sei que você perdeu sua namorada recentemente e...
<p>- A Andressa era o amor da minha vida. – Kol começou a falar.
<p>- Eu entendo. – Lisa se sentou ao lado dele.
<p>- Eu sou novo, nós dois éramos novos, mas a gente já pensava no futuro. Era como se eu não conseguisse me imaginar no futuro sem ela, entende?
<p>- Desculpa, mas não. Eu nunca senti algo tão forte assim.
<p>- A gente falava sobre sonhos, metas, até casamento e filhos. – Lisa podia jurar que viu uma lágrima escorrendo do olho de Kol. – Quando ela morreu, eu achei que não poderia viver mais. Tudo me lembrava ela, tudo me lembrava o que eu tinha perdido.
<p>- Eu sinto muito. Como isso aconteceu?
<p>- O acidente? O Jason não te contou?
<p>- Não muito, acho que ele preferiu não se intrometer. Mas se não quiser falar, não precisa. – Lisa disse logo para tentar evitar causar mais dor em Kol.
<p>- Não, tudo bem. A gente ia completar dois anos de namoro, tinha uma festa na casa dela, foi legal, a gente se divertiu muito.
<p>- Sei.
<p>- A mangueira de gás da casa dela estava com problemas. Tinham chamado já a manutenção, mas eles estavam enrolando.
<p>- A culpa não foi sua.
<p>- Ela estava indo dormir e pediu para eu desligar o gás, eles sempre desligavam. Eu estava indo para a cozinha, quando recebi uma ligação do meu pai, atendi o telefone, conversei com ele e acabei saindo da cozinha sem desligar nada. – Kol falou expressando o quão idiota ele sabia que tinha sido isso. – Eu podia ter prestado mais atenção, talvez o gás já estava até vazando, mas eu não senti, eu deveria ter sentido, mas não, eu nem prestei atenção em nada. Então eu fui embora. A explosão ocorreu duas horas depois. Eu acordei no meio da noite com o barulho, a casa dela era perto da minha. Eu vi o fogo, a fumaça preta, saí correndo pela rua e conforme eu ia seguindo em direção ao fogo, mas eu percebia de onde ele vinha. Até eu confirmar, ver a casa pegando fogo e nenhum sobrevivente.
<p>- Que horror. – Lisa estava emocionada.
<p>- Me disseram que ela morreu na hora. Quer dizer, eles não sabem, mas é o que geralmente acontece em explosões assim, ninguém sente nada. Eles não tiveram enterro porque não sobrou nada do corpo para enterrar. Eu não pude me despedir e pior, eu não pude salvá-la.
<p>- Você não tinha esse controle.
<p>- Tinha sim, e eu nunca vou me perdoar.
<p>- Você precisa. Isso não vai fazer bem para você. Não vai fazer bem para ninguém.
<p>- Você foi a primeira garota que se aproximou de mim depois do acidente, talvez seja só carência.
<p>- Quero que saiba que você ainda pode encontrar uma garota para te fazer feliz, e isso não vai manchar a memória da Andressa, na verdade ela gostaria muito disso.
<p>- Eu sei. Valeu, Lisa.
<p>- Estou aqui para isso.</p>
<center><h4>--*--</h4></center>
<p>- Quer dizer que o Kol se abriu para você? – Lisa contou para Brandon a conversa que teve com o Kol assim que o encontrou pelos corredores na escola.
<p>- Sim. Eu não sabia que tinha sido tão trágico.
<p>- Você devia ter conhecido ele antes. Era a pessoa mais feliz que eu já conheci. A morte da namorada acabou com ele. Afastou todo mundo.
<p>- É uma pena. O luto é uma droga.
<p>- É sim.
<p>- O Jason me contou sobre o blogueiro que também pegou no seu pé. Por que nunca me disse isso?
<p>- Não é uma coisa que a gente conta no primeiro encontro. E além do mais, já faz muito tempo. Não tem importância. – Brandon não parecia se importar mais com o bullying que tinha sofrido anos atrás.
<p>- É claro que tem. Esse blogueiro acabou com a vida de muita gente. Quase acabou com a sua e está querendo acabar com a do Jason. Eu odeio ele.
<p>- Eu penso que ele tem um motivo, também penso que ele é um doente.
<p>- Deve ser um solitário.
<p>- Acho que isso me fez ficar mais fechado para os outros. – Brandon pensava nas consequências.
<p>- Como assim?
<p>- Quando eu entrei para o ginásio, eu era um tagarela, eu era amigo de quase todo mundo. Eu não era popular nem nada do tipo, mas eu tinha muitos amigos. Logo depois, eu descobri que muitos deles falavam mal de mim por aí, e eu nem sabia porquê.
<p>- As pessoas são maldosas.
<p>- Quando o blogueiro surgiu e começou a falar de mim, todo mundo se afastou.
<p>- O que ele falava de você?
<p>- Digamos que as piadas que o Jason faz com o meu cabelo não são nada comparadas as coisas que o blogueiro dizia. De repente eu tinha virado o garoto popular que todo mundo amava odiar. Eu não tive mais coragem de me abrir com mais ninguém além da Tempe. Aí você apareceu.
<p>- E o que aconteceu? – Lisa sorriu.
<p>- Aí tudo ficou mais fácil estando com você.
<p>- Eu tenho um dom.
<p>- E eu te amo por isso. – Brandon percebeu o que disse tarde demais.
<p>- Eu vou ignorar a sua cara de arrependimento pelo que disse e dizer que eu também te amo.
<p>- Achei que não diria. – Brandon riu sem graça.
<p>- Por que não? Você foi a melhor coisa que me aconteceu nessa escola.
<p>- Eu sou a única coisa que te aconteceu nessa escola. – Brandon riu antes de beijar a namorada.
<p>- Lisa, oi. – E mais uma vez Maddie estava lá interrompendo o beijo dos dois.
<p>- Maddie, tudo bem? – Lisa se recompôs.
<p>- Tudo. Eu só queria te agradecer. – Maddie abraçou a Lisa.
<p>- Pelo quê?
<p>- Por ter conversado com o Kol. Ele me contou o que vocês falaram.
<p>- Ah, não foi nada.
<p>- Foi mais do que imagina. O Kol nunca falou do acidente para ninguém. Ele não tinha se aberto com ninguém e você o ajudou. Acho que agora ele está até mais leve.
<p>- Que bom que eu pude ajudar.
<p>- Obrigada mesmo.
<p>- De nada. Eu fiquei feliz.
<p>Maddie abraçou Lisa mais uma vez antes de ir embora.
<p>- Será que haverá uma vez que vamos estar nos beijando e a Maddie não vai aparecer? – Brandon comentou.
<p>- Cala a boca. – Lisa riu.</p>
<center><h4>--*--</h4></center>
<p>- É verdade o que estão dizendo por aí?
<p>Maddie encontrou Jason nos corredores.
<p>- Depende, o que estão dizendo por aí? – Jason fechou a cara para Maddie.
<p>- Que você e a Emily terminaram.
<p>- Não terminamos oficialmente.
<p>- Eu sabia. – Maddie ignorou o comentário de Jason.
<p>- Sabia do que, garota?
<p>- Que a Emily não ia te aguentar por mais de duas horas. – Maddie riu satisfeita.
<p>- Está vendo isso? – Jason apontou para o ar.
<p>- Vendo o quê?
<p>- Alguém pedindo a sua opinião. Não está vendo? Eu também não.
<p>- Grosso.
<p>- Nossa, eu estou tocado pela tristeza por você achar isso de mim. – Jason fingiu limpar as lágrimas. - Vai achar quem te aguenta, garota, tipo suas vacas, bois e companhia.
<p>- São muito melhores que você.
<p>- Você puxou a conversa. Quem necessita dessa amizade é você e não eu.
<p>- Acredito em segundas chances, mas você é impossível.
<p>- Maddie, eu já te dei um fora daqui. Está aqui ainda por quê?
<p>- Ai, que horror. – Maddie saiu gritando.
<p>- Sai, coisa ruim.</p>
<center><h4>--*--</h4></center>
<p>Jason estava procurando Temperance e é claro que ele não tinha dúvidas de onde ela estava. Não era muito difícil saber qualquer era o seu lugar favorito da escola.
<p>- Você viu a Emily? – Jason encontrou Temperance lendo na biblioteca antes da aula.
<p>- Não, e espero não a ver para não estragar o meu dia.
<p>- O “não” já bastava, não preciso ficar ouvindo você se abrir.
<p>- Tomou coragem e vai falar com ela?
<p>- Pode ser.
<p>- Pode ser? – Temperance ficou desconfiada.
<p>- A gente não se fala desde...
<p>- E... – Temperance não deixou Jason terminar.
<p>- E eu estou sentindo falta dela, tá bom? Era isso que queria ouvir? – Jason falou bem rápido na esperança de Temperance não entender.
<p>- Mais ou menos isso. Quem diria? Você apaixonado até que é fofo.
<p>- Fica quieta. – Jason ficou bravo.
<p>- Ela deve estar fazendo algo desinteressante, tipo olhando o sol.
<p>- Mas é claro. Eu sei onde ela está. – Jason então percebeu. – Se ela não está aqui na escola, ela...
<p>- Ela está olhando o sol? – Temperance não percebeu.
<p>- Depois a gente se fala. Seu quase namorado e terceiro amigo está vindo. – Jason comentou antes de sair correndo da biblioteca.
<p>- O quê?
<p>E era verdade, depois que Temperance desviou seu olhar de Jason, ela viu Nathan se aproximando dela.
<p>- Oi. – Ele sorriu e se sentou ao lado dela.
<p>- Oi. – Ela sorriu de volta sem jeito.
<p>- Jason estava com pressa.
<p>- Ele tem um namoro para consertar.
<p>- Namoros, coisa que destrói todo mundo. – Nathan às vezes falava coisas estranhas.
<p>- Você não gosta de namorar? – Temperance não acreditou que disse isso.
<p>- Bom, minha última namorada me traiu. Namorar é um saco. Você gosta?
<p>- Ah, bom... – Temperance respirou fundo. – Eu nunca namorei sério. – E sentiu vontade de dizer “e nem não sério”.
<p>- Não está perdendo nada.
<p>Mas não era isso que ela achava.
<p>- Ah sei lá, você pode encontrar alguém e se surpreender, mas o que eu sei, não é? Namorar não é a minha prioridade agora. – Temperance mentiu.
<p>- Qual é a sua prioridade agora?
<p>- Não faço ideia. – Temperance ficou nervosa.
<p>- Mas me conta uma coisa, por que nunca namorou? Você é linda.
<p>- Você me acha linda? – Temperance não soube disfarçar a surpresa e a felicidade. – Quer dizer, obrigada.
<p>- Acho sim.
<p>- Para ser sincera, eu nunca encontrei alguém que valesse a pena. Não quero namorar só por namorar. Além do mais, eu sempre fui a garota dos livros e exercícios de matemática, nunca tive tempo.
<p>- Mesmo que namorar seja uma droga, você solteira é um desperdício.
<p>Como Temperance responderia ou falaria qualquer coisa depois disso?</p>
<center><h4>--*--</h4></center>
<p>- Achei que te encontraria aqui. É meio que nosso ponto de encontro.
<p>Jason foi até o parque, sabia que Emily estaria lá por alguma razão. Ela estava sentada naquele mesmo banco toda pensativa. Sua mochila do seu lado e olhando para lugar nenhum.
<p>- Preciso parar de ser previsível. – Emily mal olhava para Jason.
<p>- A não ser que você queria que eu te encontrasse. – Jason riu.
<p>- Vai por mim, você é a última pessoa que eu quero ver nesse momento.
<p>- Eu estraguei tudo, tá bom? Eu sei disso. Eu admito. Eu sinto muito. – Jason se sentou ao lado dela, mas um pouco distante por causa da mochila.
<p>- Eu já sei de tudo isso. Me conta alguma novidade. – Emily estava séria.
<p>- O que você quer que eu faça para você me perdoar?
<p>- Nada. Porque eu não vou te perdoar. Então ficar falando besteiras só vai fazer você perder seu tempo.
<p>Emily então ameaçou ir embora.
<p>- Espera. – Jason segurou o braço dela.
<p>- O quê?
<p>- Eu não quero te perder. Você é importante para mim.
<p>- Então por que não confiou em mim?
<p>- Porque você mentiu. – Jason ainda mantinha essa ideia. – Quem mente uma vez, mente outra vez.
<p>- O que queria que eu dissesse?
<p>- A verdade.
<p>- A verdade? – Emily respirou fundo. – Tudo bem, você quer a verdade? Eu vou te dar a verdade. Eu era uma garota boba e medrosa que era obrigada a seguir uma idiota que sentia prazer em machucar as pessoas. O tempo todo eu era ameaçada, ela pegava no meu pé porque eu era fraca e tinha medo demais de denunciar.
<p>- Emily...
<p>- Sabe quantos amigos eu perdi? Ninguém mais fala comigo, é por isso que eu sou uma ninguém, me tratam como se eu fosse ela. – Emily não estava triste nem chorava, só tinha rancor na sua voz. – Eu fui uma idiota, eu podia ter feito algo, mas não fiz, eu fiquei com medo de eu ser alguma próxima vítima, então eu preferi ficar atrás, mais seguro, mais fácil, só que o pior é que não me adiantou de nada porque mesmo atrás eu também era perseguida, eu também tinha medo.
<p>- Eu... – Jason tentou falar.
<p>- Acha que eu tenho orgulho disso e que eu gosto de falar para todo mundo que eu conheço sobre isso?
<p>- Mas você mentiu na minha cara.
<p>- Você me olhava e falava comigo como se eu fosse alguma coisa vindo do céu. Sabe como é difícil suprir essas expectativas? Eu não queria que achasse que a Emily que você tanto admirava era na verdade a pior pessoa do mundo.
<p>- Você não é a pior pessoa do mundo. Eu não posso te julgar por isso. Você só teve medo. É normal.
<p>- Você não tem. O blogueiro acaba com você, mesmo assim você o ameaça e briga com ele.
<p>- Não me use como exemplo, eu sou louco assim mesmo. – Jason riu para tentar aliviar o clima, mas não deu certo.
<p>- Sabe porque eu acreditei em você quando o blogueiro postou aquelas coisas?
<p>- Por que você também é louca?
<p>- Porque eu já gostava de você e eu me recusava a acreditar que alguém que eu gostasse faria aquilo comigo.
<p>- Tudo bem, você conseguiu me deixar pior. Eu também não tenho orgulho do meu passado, tá bom? Eu já fui expulso de uma escola.
<p>- Eu sei.
<p>- E sabe por quê? Eu bati em um cara até ele quase ficar inconsciente e eu quase não consegui parar.
<p>- O quê? – Emily ficou surpresa.
<p>- Ele meio que perseguia a Lisa. Quando ela saía da escola, ele a seguia e ficou assim por um tempo. Às vezes ele ficava o dia todo parado em frente à casa dela. É claro que ele disfarçava para ninguém perceber e os pais da Lisa achavam que era paranoia dela.
<p>- O que aconteceu?
<p>- Uma hora eu me cansei e fui falar com ele. Ele me disse que se uma hora ele resolvesse pegar ela, ninguém o impediria. O sangue foi para a cabeça, o resto é história. Eu nunca tinha visto tanto sangue na minha vida.
<p>- O que fizeram?
<p>- Meu pai é advogado e me salvou. Ele tentou também esconder tudo, ter um filho marginal estragaria a carreira dele. Minha mãe ficou assustada e horrorizada e começou a me tratar como se eu fosse explodir a qualquer momento. Me pediram para escolher uma escola em outra cidade até as coisas sossegarem. Eu escolhi uma do outro lado do país. A Lisa meio que se sentiu culpada e veio junto comigo. Falo sempre com a minha mãe mesmo que breve, mas não falo com o meu pai desde então. – Jason não gostava muito de contar essa história.
<p>- Eu sinto muito.
<p>- Não sinta. Eu me recupero bem.
<p>- Eu duvido. – Emily o encarou. – Jason, eu preciso ir.
<p>- Emily, me perdoa.
<p>- Eu preciso pensar.
<p>- Tudo bem, mas eu sinto a sua falta.
<p>- Também sinto a sua.
<p>Emily deu um beijo no rosto de Jason e foi embora.</p>
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
            if (condicao + 1 > 15)
            {
                Navigation.PushModalAsync(new Capitulo4Page(condicao + 1));
            }
            else
            {
                Navigation.PushModalAsync(new Capitulo3Page(condicao + 1));
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