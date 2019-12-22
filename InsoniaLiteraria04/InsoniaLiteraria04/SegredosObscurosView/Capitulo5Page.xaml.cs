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
	public partial class Capitulo5Page : ContentPage
	{
        DBFire service;
        public int condicao;

        public Capitulo5Page (int numero)
		{
			InitializeComponent ();
            service = new DBFire();
            condicao = numero;
            mostrarCapituloSalvo("SegObscuros", "Capitulo" + numero.ToString());

            if (numero == 21)
            {
                lblTitulo.Text = "Capítulo 21 - Ódio";
                htmlPage.Html = @"<html><body>
<p>Lisa estava em choque. Ela mal piscava e sua boca estava aberta de espanto. Jason a encarava e falava rápido demais até para ele. Ele tinha entrado no banheiro feminino procurando por ela, até porque não podia entrar no masculino daquele jeito, morrendo de raiva e quase chorando.
<p>- Não, espera, eu não estou entendendo nada.
<p>- Temperance é a blogueira. – Jason tentou falar com calma dessa vez.
<p>- Não importa quantas vezes você diga isso, eu não consigo acreditar nem entender.
<p>- Então pode começar a acreditar.
<p>- Não, não. – Lisa estava em negação. – Ela pode não gostar muito de mim e nem de ninguém, mas... Não. Olha, você tem certeza? Pode ser um engano.
<p>- Não é.
<p>- Não é possível. Ela é sua amiga.
<p>- Parece que não é, né? – Jason estava muito frio em relação a isso.
<p>- O que você vai fazer?
<p>- Eu tenho que fazer alguma coisa? – Ele não esperava por isso.
<p>- Eu... eu não sei. Mas você sempre quis descobrir a identidade dele.
<p>- É, mas... Eu não sabia que... Que seria ela. Acho que eu vou vomitar.
<p>- Vocês precisam conversar.
<p>- Já conversamos.
<p>- Não, eu conheço você. Deve ter gritado e nem ter deixado ela falar.
<p>- Eu deixei ela falar. Podia falar enquanto eu gritava, não ia impedir.
<p>- Você precisa pedir uma explicação. – Lisa falou sério.
<p>- Existe uma explicação para isso, Lisa? – Jason não iria aceitar uma explicação.
<p>- Pelo menos ela acha que tem. E vocês são amigos.
<p>- Não somos amigos.
<p>- Mas... – Lisa não sabia mais o que falar. – Você vai revelar para todo mundo?
<p>- Não. – Jason não podia fazer uma coisa dessas. – Além do mais, agora que ela sabe que a gente sabe, ela não vai escrever nada. Eu quero agora esquecer que esse blog existiu.
<p>- Eu sinto muito.
<p>- Não precisa. Minha melhor amiga ainda está aqui.
<p>- E sempre vai estar.
<p>Os dois se abraçaram.</p>
<center><h4>--*--</h4></center>
<p>- Você está estranha? Está tudo bem?
<p>- Eu estou ótima.
<p>Temperance deu um sorriso forçado para Nathan quando se encontraram nos corredores da escola naquela manhã.
<p>- Você foi embora mais cedo ontem. Eu te procurei e o seu amigo...
<p>- Ele não é mais meu amigo. – Temperance fez questão de dizer.
<p>- O que houve? Você brigou com o Brandon? É por isso que está estranha?
<p>- Eu não estou estranha. Eu só tenho uma prova agora e eu estou nervosa. – Temperance mentiu. – Eu sempre fico assim antes de provas.
<p>- Você vai se sair bem. É muito inteligente.
<p>- Obrigada.
<p>Temperance não ficou vermelha nem fez cara de boba como sempre fazia quando Nathan a elogiava. Na verdade, ela continuou séria a conversa toda. Sua cabeça estava muito longe dali.</p>
<center><h4>--*--</h4></center>
<p>- A minha ficha ainda não caiu. É sério.
<p>Lisa e Emily estavam no pátio conversando. Jason ainda não tinha chegado, estava atrasado como sempre.
<p>- Quando o Jason me contou sobre o chaveiro... sei lá, isso não é a cara da Temperance. – Emily ainda estava desconfiada.
<p>- É por isso que surpreendeu. – Lisa estava pensativa. – Será que o Bran sabe?
<p>- São melhores amigos. Ele pelo menos, deve ter suspeitado. Por que não pergunta?
<p>- A gente meio que terminou. Não posso chegar lá e acusar a amiga dele.
<p>- Eu sinto muito pelo término.
<p>- Não, está tudo bem. O assunto agora é outro. – Lisa pareceu não estar mais abalada com o rompimento.
<p>- Ele está mal, não está? – Emily se referiu ao Jason. – Ele praticamente saiu correndo ontem e não me atendeu depois.
<p>- Com certeza não quer que você o veja chorando.
<p>- Homens. – Emily balançou a cabeça.
<p>- Ele odiava aquele blogueiro e de repente descobriu que era uma amiga dele.
<p>- Para mim, essa história está muito mal contada.
<p>- E para mim, a Temperance é uma falsa. Não acredito que ela fez isso.
<p>- Eu também não.
<p>Emily ainda estava com dúvidas. Ela conhecia Temperance há muito tempo, era meio que impossível pensar naquela garota como uma blogueira maldosa que vivia para acabar com a vida das pessoas. Isso com certeza não estava certo.</p>
<center><h4>--*--</h4></center>
<p>Jason não sabia muito bem o que ia fazer, nem sabia porque estava indo para lá. Ele só queria tirar uma dúvida, ou melhor, aliviar a raiva em alguém.
<p>- Jason, o que faz aqui? – Brandon abriu a porta de casa assustado.
<p>- Ainda bem que não foi para a escola. Seria interessante não te achar aqui.
<p>- Eu vou mais tarde. – Brandon estava meio desanimado. – Veio falar da Lisa e...
<p>- Você sabia? – Jason encarou Brandon.
<p>- Sabia o quê?
<p>- Não se faça de bobo, cabeleira. Me diz.
<p>- Jason...
<p>- Você sabia esse tempo todo que a Temperance era a blogueira?! – Jason gritou de raiva.
<p>- N-não.
<p>- Mentira.
<p>Jason deu um soco na cara de Brandon.
<p>- Qual é o seu problema? – Brandon apertou o nariz que estava sangrando.
<p>- Aposto até que ajudou.
<p>- Eu não sabia de nada. – Brandon escondeu o rosto com as mãos. – Ela me contou ontem.
<p>- Você é um mentiroso. Você é o melhor amigo dela e vem me dizer que não sabia?
<p>- Eu também estou triste, está bem? Você conhece ela há uns meses, eu conheço ela a vida toda.
<p>- Idiota.
<p>Jason deu outro soco na cara de Brandon.
<p>- Por que está me batendo? – Brandon se afastou de Jason para evitar um terceiro soco.
<p>- Porque eu preciso bater em alguém. Porque eu não posso bater nela. E porque você é um idiota por não ter percebido.
<p>- Eu também estou me odiando. Estou bem pior que você.
<p>- Não foi com você que ela foi duas caras. Ela nunca detonou você.
<p>- Ela já...
<p>- Deixa eu ir embora, nem sei por que eu vim para cá.
<p>- Para me bater, pelo que parece.
<p>- Pena que meu ódio não passou.
<p>Jason foi embora bufando.</p>
<center><h4>--*--</h4></center>
<p>- Lisa, oi.
<p>Temperance era louca. Ela tinha uma pequena esperança de que Jason não tinha contado nada para Lisa. Mal sabia ela...
<p>- O que você quer? – Lisa bateu forte a porta do seu armário sem nem mesmo pegar seus livros e fechou a cara.
<p>- Você viu o Jason? Eu preciso falar com ele. – Ela ainda tinha aquela ilusão que o Jason ia aceitar as desculpas dela.
<p>- Acho que ele não vai vir hoje.
<p>- Podia dizer a ele que eu estou querendo...
<p>- Não. – Lisa estava séria. – Não sou garota de recados, nem uma vagabunda.
<p>- Lisa...
<p>- Ele me contou. Diferente de você, entre a gente não tem segredos.
<p>- Lisa, me desculpa.
<p>- Me poupe.
<p>- Eu não queria...
<p>Lisa respirou fundo e até deu um passo para trás, mas não aguentou. Ela prometeu para si mesma que não faria, que ficaria calma, mas foi mais forte que ela. O tapa de Lisa deixou Temperance assustada, seus olhos começaram a ficar vermelhos. Lisa segurou o choro também.
<p>- Você queria sim. Ou agora vai me dizer que estavam te obrigando? – Lisa não gritou, sabia que todos ao redor estavam olhando e queria evitar mais falatório.
<p>- Não, eu...
<p>- Você disse coisas horríveis.
<p>- Eu sinto muito por ter te chamado de...
<p>- Não me interessa nenhum pouco do que você me chamou. Eu não me importo.
<p>- Então...
<p>- Ele gostava de você... E se importava.
<p>- Eu...
<p>- Ele defendia você. Sempre. Ele sempre foi fechado e nunca demonstrou tanto, mas ele gostava de ficar com você, de ser seu amigo. Ele amava você.
<p>- Eu sei. – Temperance estava quase chorando.
<p>- Então por que fez isso com ele? Por quê? O que ele fez para você?! – Ela não aguentou ficar sem gritar também.
<p>- Você não entende.
<p>- Não mesmo. E para falar a verdade, eu nem quero entender. Você nunca gostou de mim, isso não é novidade, então eu não me surpreendi. Eu realmente não me importei. Agora que eu não namoro mais o Bran, eu nem ia mais fazer questão da sua amizade se é que a gente tinha alguma, então por mim, você podia me xingar de qualquer coisa. Mas ele não. Você fez ele de bobo.
<p>- Eu não o conhecia quando eu comecei e...
<p>- Mas depois o conheceu! – Lisa gritou de novo. Ela não estava mais ligando para quem fosse ouvir. – Mesmo depois de conhecer ele, você continuou e disse coisas piores e viu como ele se sentia e não se importava.
<p>- Não é verdade.
<p>- Então por que não parou? O egoísmo falou mais alto?
<p>- Eu...
<p>- Não sabe o que dizer? Ou prefere escrever e postar tudo? Eu iria adorar ler. Talvez devesse falar mal de você. O quanto você é covarde, o quanto você é uma egoísta e que não se importa com ninguém a não ser você mesma, o quanto você não é importante para ninguém.
<p>- Talvez eu faça isso. – Temperance engoliu o choro.
<p>- Eu vou adorar ler. Cretina.</p>
<center><h4>--*--</h4></center>
<p>Temperance estava escondida atrás da escola. Seus olhos estavam vermelhos. O tapa de Lisa ainda estava um pouco marcado no seu rosto. Ela não conseguia acreditar no que estava acontecendo.
<p>Ela sabia que no minuto que admitisse para o Jason que era o blogueiro, tudo ia mudar. É claro que ele ia contar para Lisa e agora só estava faltando a Emily ir brigar com ela, uma coisa que ela sabia que não ia demorar a acontecer. Mas Temperance não podia voltar atrás e nem queria fazer isso. Mesmo odiando ele agora, a garota tinha que defender o Brandon. Temperance sabia que se Jason descobrisse a verdade, que se Jason descobrisse que o blogueiro na verdade era o Bran, as coisas não iriam acabar bem.
<p>Mas agora ela era odiada pelos seus únicos amigos e não ia demorar muito até a escola toda descobrir. Mas o ódio também estava com ela. Temperance não acreditava em como pôde ser tão burra por tanto tempo e como o seu ex-melhor amigo tinha a enganado da pior maneira.
<p>- Até que enfim te achei. – Nathan apareceu de surpresa
<p>- Ah, oi. – Temperance limpou o rosto e parou de pensar nas coisas.
<p>- Te procurei por todo lugar. Está todo mundo falando que você brigou com a Lisa.
<p>- Eu estou bem.
<p>- Por que brigaram? – Nathan estava preocupado.
<p>- Ela está com raiva.
<p>- Por causa do Bran? Ela acha que...
<p>- Não, não tem nada a ver. – Temperance não estava confortável.
<p>- Pode me contar se quiser.
<p>- Eu não quero, é uma coisa minha, está bem? – Agora estava impaciente.
<p>- O que está acontecendo? Você não é assim.
<p>- Você não me conhece de verdade. Sinto muito.
<p>- Temperance, é claro que eu te conheço.
<p>- Eu sou a dona do blog da escola. – Ela queria acabar com aquela conversa e escolheu a pior maneira possível.
<p>- O quê?
<p>- Você não lê o blog? Aquele que fala mal de todo mundo anonimamente?
<p>- Bom...
<p>- Sou eu que escrevo. – Nem ela sabia porque estava dizendo aquelas coisas.
<p>- Não pode ser. – Nathan estava chocado.
<p>- Mas é. Viu? Você não me conhece.
<p>- Por que fez isso?
<p>- Por diversão. – Temperance tentou ficar séria. Ela não podia dar nenhum sinal.
<p>- Por que está me dizendo isso?
<p>- Porque está todo mundo descobrindo e era só uma questão de tempo até você descobrir, então resolvi acabar logo com o mistério.
<p>- Ainda bem que não saímos para valer. Eu me odiaria se estivesse namorando sério alguém como você.
<p>Como ela responderia um comentário desses? Ela não sabia. O que ela fez já estava feito. O ponto é, se sabotar não era bem a escolha certa.
<p>- Então vai embora.
<p>Nathan deu a meia volta e desapareceu, Temperance voltou a chorar descontroladamente.</p>
<center><h4>--*--</h4></center>
<p>- Não devia ter brigado com ela. – Jason estava bravo.
<p>- Por que não? Ela mereceu.
<p>- Não, ela não mereceu. Ela não merece nada.
<p>Jason e Lisa estavam na sala de estar. Não tinha ninguém em casa então podiam gritar à vontade. Ninguém ia se importar.
<p>- Se fosse outra pessoa, você estaria batendo nele até agora.
<p>- Verdade e me irrita muito não poder bater nela. Mas o que iria adiantar?
<p>- Iria trazer alivio. Na verdade, agora eu estou muito aliviada e calma. – Mentira, Lisa não estava calma.
<p>- A verdade é que eu não consigo olhar mais para a cara dela sem começar a chorar que nem um bebê imbecil.
<p>- Aquele tapa foi mais por você do que por mim. Ela...
<p>- Olha só para gente. Viemos para cá porque em casa estava ruim. Agora acabaram com a gente.
<p>- Jason...
<p>- Eu quero fingir que nada aconteceu e terminar esse ano. Eu só quero isso e depois sumir daqui.
<p>- Eu não entendo. Por que você está tão calmo? – Lisa conhecia o amigo. Era para ele estar subindo pelas paredes. – Quer dizer, você está bravo, mas não está nem um quarto bravo do quanto eu achei que estaria.
<p>Jason ficou um momento em silêncio.
<p>- Todas as minhas desconfianças de todo mundo. Não era sério, na verdade. Eu acusava porque sabia que não era verdade e eu só fazia para, sei lá... era o meu jeito, eu via que era besteira no minuto seguinte. Mas a verdade é que eu nunca pensei que o blogueiro seria alguém que convivesse comigo, eu não queria acreditar nisso. Eu não queria acreditar que alguém que eu conheço fosse capaz de fazer algo assim. É demais para mim. Isso não é normal, não deveria ser.
<p>- Você está em negação?
<p>- Não, eu estou estranho. Se até alguém que eu achava que era a minha amiga fez algo assim, imagina os outros. Eu sei que eu não sou a pessoa mais fácil de lidar do mundo, mas eu sou tão ruim assim para merecer coisas desse tipo?
<p>- É claro que não. O problema não é com você, é com ela.
<p>- Eu sei lá, talvez isso seja um sinal. Talvez eu precise ser uma pessoa melhor. Talvez eu precise crescer um pouco.
<p>- Não posso discordar disso.
<p>- Cala a boca. – Lisa fez Jason rir, e isso já bastava para ela.</p>
<center><h4>--*--</h4></center>
<p>- Oi.
<p>- O que você quer?
<p>Temperance ficou desconfiada quando Emily se sentou ao lado dela na lanchonete.
<p>- Falar com você.
<p>- Se for me bater, tenta não bater no rosto, a sua amiga já bateu. – Ela sorriu com cara de derrota. – Mas deixo você puxar meu cabelo.
<p>- Eu não vim bater em você.
<p>- Por que não? Não está com raiva? – E Temperance achando que não podia mais se surpreender naquela semana. – Então veio agradecer? Essa é nova.
<p>- Por que fez isso? – Emily encarou Temperance.
<p>- Vai me deixar responder? Porque todo mundo já me perguntou isso, mas ninguém me deixou responder. Acho que vou gravar a resposta, vai ser mais fácil. Eu fiz isso porque eu queria...
<p>- Chega de papo furado. – Emily estava séria. – Sabe o que eu quero dizer.
<p>- Desculpa, eu não sei.
<p>- Por que você está mentindo? Por que você diz ser a blogueira quando, na verdade, não é?
<p>- Você está maluca. – Temperance ficou com medo. Emily sabia?
<p>- Olha, Temperance, nunca fomos amigas, na verdade, mal nos falamos, aconteceu que agora eu namoro o seu amigo e a gente começou a trocar pelo menos cumprimentos, mas é só.
<p>- Onde quer chegar?
<p>- Eu quero dizer que mesmo não gostando muito de você e nem falando muito com você, eu te conheço. Eu estudo com você desde sempre e a gente acaba conhecendo as pessoas.
<p>- Emily, você não me conhece. Eu... – Temperance já ia começar a fazer o mesmo discurso que fez para Nathan.
<p>- Você é como um cão de guarda. Você é fiel e de confiança, mas não é má.
<p>- É por isso que existe o termo duas caras.
<p>- Não, com você nunca teve isso, se você não gostava de uma pessoa, você falava na cara dela, eu já vi você dispensando todos os garotos da escola. E você nunca foi de fofoca. Você pode estar enganando todo mundo aqui, mas eu não.
<p>- E você agora quer saber por que eu estou “mentindo”? Olha, você está viajando.
<p>- Prefere ser odiada do que contar a verdade? Mesmo assim, eu não sei por que está defendendo o blogueiro. Ele só pode ser alguém que... – De repente, Emily parou de falar. Parecia que ela estava montando as peças.
<p>- Emily. – Temperance logo percebeu que Emily tinha sacado tudo.
<p>- É o Brandon, não é?
<p>- Não, nada a ver. – Ela fez uma última tentativa.
<p>- Ele nunca foi um grande fã do Jason. Ele vivia falando para você ficar longe dele e odiava ver a Lisa e o Jason juntos.
<p>- Você não entende.
<p>- Por que está escondendo ele?
<p>- Se o Jason descobrir, ele acaba com o Bran.
<p>- Então prefere que todos acabem com você?
<p>- Ele é o meu melhor amigo. Eu tenho que protegê-lo.
<p>- Olha, eu nunca tive grandes amigos, e eu posso estar louca, mas a amizade tem que vir dos dois lados.
<p>- Como assim?
<p>- Você está aqui, sozinha, odiada, sendo a vilã da história, e ele? Deve estar em casa esperando alguém chegar para ele se fazer de coitado. Cadê a amizade, Temperance? Eu não estou vendo.
<p>- Mas é mais complicado do que parece.
<p>- O Jason acha que a única pessoa que o conheceu e não o julgou por aqui é uma traidora de duas caras e que brincou com ele esse tempo todo. Você o conhece, sabe como isso está afetando ele.
<p>- Você sabe o que ele fez com o cara que perseguia a Lisa. Ele vai fazer a mesma coisa com o Brandon.
<p>- E?
<p>- Emily!
<p>- Temperance, vai olhar na minha cara agora e vai dizer que ele não merece?
<p>Temperance não respondeu.</p>
<br>
<p><i>“<b>ISSO É UM ADEUS:</b> Eu quero avisar a todos que a partir de hoje o blog será desativado. Não me arrependo de tudo o que eu falei e expus, mas eu sabia que um dia teria que parar, e esse dia é hoje. Não vou pedir desculpas e nem quero ser perdoado, só cansei de ser aquele que mostra a todos o problema de vocês.”.</i> – Tesouro de Segredos Obscuros.</p>
</body></html>";
            }

            if (numero == 22)
            {
                lblTitulo.Text = "Capítulo 22 - Dúvida";
                htmlPage.Html = @"<html><body>
<p>Emily abordou Temperance no meio do corredor da escola naquela manhã e quando a garota tentou desviar e ir embora, Emily pegou no braço dela e não o largou.
<p>- Quando vai contar para ele? – Ela estava brava.
<p>- Contar o que e para quem? – Temperance se fez de desentendida.
<p>- Não se faça de boba. Você sabe do que eu estou falando.
<p>- Quantas vezes eu preciso dizer que eu não vou contar? Você é surda?
<p>- E você é idiota? Larga a mão do Brandon.
<p>- Quem você acha que é para me dizer o que fazer?
<p>- Alguém que quer te ajudar.
<p>- Olha só, eu não preciso de ajuda. – Temperance fechou a cara.
<p>- Então é isso que você quer? As pessoas já estão comentando. Logo, logo, todo mundo vai “descobrir” que você é a blogueira.
<p>- Eu não ligo.
<p>- Cadê o Brandon do seu lado?
<p>- Ele não está do meu lado porque eu não o quero aqui.
<p>- Mesmo brigados, vocês...
<p>- Emily, você já teve um amigo de verdade?
<p>- Isso não tem a ver comigo. – Emily estava séria.
<p>- Tem a ver com todos nós. Você sempre foi solitária então é muito fácil para você tomar uma decisão egoísta.
<p>- Você está me chamando de egoísta? – Emily riu. – Eu estou aqui tentando ajudar você e...
<p>- Você não quer me ajudar. Só quer que a verdade apareça. Você não dá a mínima para o Brandon.
<p>- Tem razão. Eu não dou a mínima para ele. Ele fez coisas erradas e tem que pagar, se pensar assim, faz de mim uma egoísta, ótimo.
<p>- Então pensa no Jason. Se ele bater no Brandon até mata-lo, o que você acha que vai acontecer?
<p>- Você nunca vai dizer.
<p>- Não. Olha só, cuida da sua vida.
<p>- Então vai para o inferno.
<p>Emily saiu andando com raiva.</p>
<center><h4>--*--</h4></center>
<p>- Você acha que se eu for mal nessa prova, eu vou reprovar nessa matéria? – Jason estava olhando para as suas notas anotadas nos boletins dos outros bimestres para saber se precisava se preocupar em estudar para a prova ou não. Ele e Emily estavam sentados em uma mesa no pátio. O sol da manhã já estava bem quente.
<p>- Eu não sei. – Emily falou nervosa.
<p>- Está tudo bem? – Jason percebeu o humor na namorada. – Por que está nervosa?
<p>- Por nada. – Ela continuava séria.
<p>- Está “naqueles dias”?
<p>- Não se diz isso para uma garota.
<p>- São hormônios então?
<p>- Nem isso. – Ela deu um tapa no braço de Jason. – Eu só briguei por aí.
<p>- Brigou por aí? Com quem?
<p>- Com ninguém. – Ela tentou esconder, mas era péssima mentirosa.
<p>- Você briga sozinha agora?
<p>- É um caso raro de dupla personalidade, pode pesquisar.
<p>- Emily. – Jason encarou a garota, ela não tinha mais para onde correr.
<p>- Olha só, comecei a namorar com você e agora estou falando idiotice, não sabia que isso pegava, mas aparentemente pega.
<p>- Pega mesmo. – Jason riu. – Agora para de enrolar e me conta o que está acontecendo.
<p>- Eu não quero falar sobre isso.
<p>- Mas eu quero.
<p>- Não vai me forçar. – Emily continuou resistente.
<p>- Me conta o que está havendo. Me conta o que está havendo. Me conta o que está havendo. Me conta o que está havendo. Me conta o que está havendo... Posso ficar aqui o dia todo... Me conta o que está havendo. Me conta o que está havendo. Me conta o que está havendo. – Mas ele já estava quase sem ar.
<p>- Tudo bem, só cala a boca.
<p>- Venci. – Ele sorriu.
<p>- Você é um insuportável, isso sim.
<p>- Eu aceito isso.
<p>- É o seguinte, eu estava tendo uma conversa nada amigável com a Temperance.
<p>- Por quê?
<p>- Porque ela é uma mentirosa.
<p>- Já conversamos sobre isso. Eu não quero que você saia no tapa com ele como a Lisa. O ano está acabando, vamos esquecer tudo e nos concentrar em nós e nos estudos. Eu disse “nos concentrar nos estudos”? Nerdice também pega?
<p>- Graças a Deus, sim.
<p>- Pela primeira vez, eu estou pensando na formatura, então vamos aproveitar.
<p>- É a Temperance, eu sei o quanto ela é importante para você.
<p>- Eu vou superar.
<p>- Vai mesmo?
<p>- Eu te amo por se preocupar comigo.
<p>- Eu sei. – Ela então sorriu. – Tudo bem, vamos parar de falar sobre a Temperance.
<p>- Vamos. – Jason concordou</p>
<center><h4>--*--</h4></center>
<p>- Como você fez isso?
<p>Maddie se sentou para almoçar com a Lisa. Sem ser convidada, como sempre.
<p>- Fiz o quê?
<p>- O blogueiro finalmente estava me ajudando a acabar com você, e de repente ele desliga o blog. Como você fez isso?
<p>- Eu não tenho nada a ver com isso. Talvez a culpa finalmente caiu sobre ele.
<p>- Que droga.
<p>- Olha, por que estamos conversando? Dias atrás você estava querendo me bater.
<p>- Ainda quero.
<p>- Sai daqui antes que eu jogue suco na sua cara.
<p>- Me diz o que você fez. – Maddie insistiu.
<p>- Eu já disse, cai fora. – Lisa quase gritou. Já estava de saco cheio.
<p>- Ai, meu Deus, você descobriu a identidade do blogueiro e chantageou ele. – Maddie estava chocada.
<p>- É, e um meteoro está caindo na Terra.
<p>- É a única explicação.
<p>- Olha, você é a última pessoa com quem eu quero conversar agora.
<p>- Só me deixa te perguntar uma coisa, agora que você terminou com o Bran, o meu irmão tem alguma chance com você?
<p>- Ai minha Nossa Senhora, não tem como você ser mais sem noção que isso.
<p>- Nossa, é por isso que está aqui sozinha. Tão antipática. Parece o Jason.
<p>- Sai daqui. – Lisa deu um grito que assustou a Maddie.
<p>- Tudo bem, eu saio. – Maddie se levantou e foi embora.
<p>- Que droga. – Lisa continuou reclamando.</p>
<center><h4>--*--</h4></center>
<p>- Tempe, a gente pode conversar?
<p>- O que você quer, Brandon? – Temperance olhou feio para Brandon quando ele se sentou ao lado dela na aula de Química.
<p>- Eu queria te dizer uma coisa.
<p>- O quê? – Temperance não estava dando tanta importância ao assunto.
<p>- Acabou. Eu desfiz o blog.
<p>- Bom para você. Agora só precisa ir para a igreja pedir perdão a Deus para ver se vai para o céu.
<p>- Temperance, eu quero o seu perdão.
<p>- O de Deus é mais importante. – Temperance continuou com uma cara feia.
<p>- Olha, hoje de manhã, eu liguei o rádio e o locutor estava falando daquela promoção que você participou há alguns dias e...
<p>- Eu também ouvi. – Temperance continuou seca.
<p>- Ah, que bom.
<p>- Olha, não vai rolar. Não vai sentar do meu lado e puxar papo, eu não quero.
<p>- Tempe...
<p>- Pode sentar do meu lado se quiser, mas se começar a falar mais do que deve, eu vou te ignorar.
<p>- O que eu preciso fazer para provar que eu sinto muito?
<p>- Nada. O que era para você fazer, ou melhor, não fazer...
<p>- Eu cometi um erro.
<p>- Olha só quem está sendo julgado agora. Não é tão legal, não é? – Temperance deu um sorriso falso, recolheu suas coisas da mesa, se levantou da sua cadeira e foi sentar em outro lugar.</p>
<center><h4>--*--</h4></center>
<p>- Emily, eu te procurei pela escola toda. – Jason aparecer quase sem fôlego.
<p>- Sério?
<p>- Não, eu só te procurei pelo refeitório e por algumas salas. – Jason riu.
<p>Emily estava concentrada em frente ao computador.
<p>O horário de aula já tinha acabado. Era comum ter bastante gente na biblioteca depois da aula, mas naquele dia não. Era de se esperar já que era quase o fim do ano letivo e as provas e trabalhos finais estavam quase acabando.
<p>- O que você está fazendo? – Jason se sentou ao lado da namorada.
<p>- É que minha mãe me ligou dizendo para eu dar uma olhada nos meus e-mails.
<p>- Por quê?
<p>- Parece que ela recebeu uma ligação. Eu não entendi direito, ela estava muito animada.
<p>- Será que você não ganhou um milhão de dólares? – Jason arregalou os olhos para ler a caixa de entrada dos e-mails de Emily. – Sua mãe não é de se animar por pouca coisa.
<p>- Eu duvido. – Emily lia os títulos das mensagens um por um, até que... – “Pedido de estágio aceito.”. Ai, meus Deus.
<p>- Que estágio?
<p>- Ai, meu Deus. – Emily começou a rir sozinha. – Ai, meu Deus.
<p>- O que está acontecendo? – Jason ficou animado antes mesmo de saber do que se tratava aquele negócio todo.
<p>- No começo do ano, eu me escrevi para um programa de estágio em Nova York para BrooklyRide. – Emily clicou no link do e-mail e esperou carregar.
<p>- BrooklyRide? Eu já ouvi esse nome. – Jason não entendeu muito bem.
<p>- É só uma das maiores empresas de Nova York.
<p>- Interessante. – Jason ainda não tinha entendido.
<p>- Você não entendeu. Essa empresa tem a fama de criar grandes empreendedores pelo País todo.
<p>- Nossa, que legal, agora eu entendi a sua alegria.
<p>- Eu me inscrevi de bobeira. Não achei que eu seria escolhida.
<p>- Qual é? Ninguém tem a menor chance perto de você.
<p>- Para. – Emily ficou sem graça.
<p>- Quer dizer que você vai para esse estágio para ficar rica e criar a sua própria empresa?
<p>- Esse é o plano A.
<p>- Não precisa de um plano B, esse vai dar certo.
<p>- Cala a boca. Você me iludir tanto assim não é muito bom.
<p>- Você está animada, mas não tão animada como deveria. Tem algo que eu não sei?
<p>- É que... Quando eu era “torturada” por aquela ridícula, a única coisa que me fazia levantar de manhã era saber que em alguns anos eu estaria em um escritório de frente com o Empire State.
<p>- E...
<p>- Mesmo assim parecia impossível. Sabe quantas pessoas dessa cidade, desse estado, saem daqui para uma cidade grande e consegue ser bem-sucedida? Quase nenhuma.
<p>- Mas você não é uma pessoa comum. Não devia te surpreender. – Jason sorriu para a namorada. – Mas quando começa?
<p>- Ah, eu não sei. – Emily começou a ler as informações da mensagem. – Bom, eu vou ter que ir para Nova York logo depois da formatura. – Emily ficou encarando a tela do computador.
<p>- Sério? Mas já? – Jason não conseguiu disfarçar o desapontamento. – Nova York é bem longe.
<p>- É. – E de repente, a animação de Emily também tinha acabado.</p>
<center><h4>--*--</h4></center>
<p>- Às vezes eu fico me perguntando o que você anda fazendo.
<p>Brandon encontrou Lisa sentada em um banco no parque naquela tarde.
<p>- Da última vez que falou comigo, disse que minha presença te atrapalhava, que queria ficar longe de mim.
<p>- Sinto muito por isso. Eu estava bravo e...
<p>- Brandon, o que você quer? Não veio até aqui para jogar conversa fora. – Lisa foi direto ao ponto.
<p>- Fui até a sua casa e sua tia me disse que estaria por aqui.
<p>- O que foi fazer lá?
<p>- Sinto sua falta.
<p>- Essa é a hora que você diz que me perdoa e eu volto correndo para você?
<p>Brandon ficou surpreso, porque achou que Lisa ficaria feliz em saber que ele queria voltar.
<p>- Não é bem assim. – Ele resolveu tentar outra coisa.
<p>- Ah, não?
<p>- Eu pedi um tempo. Eu estava confuso, não estou mais.
<p>- Também não estou confusa. Parece que eu não te amo o tanto que eu pensava.
<p>- Lisa, não faz assim.
<p>- Eu nunca fiz nada de errado, mas você mesmo assim, não me entendeu. Me desculpa, mas aquilo me magoou muito e eu não consigo esquecer.
<p>- Eu sei que eu fiz tudo errado e...
<p>- Eu entendo, de verdade. Mas eu passei dias sofrendo por você, não pode aparecer aqui dizendo que sente a minha falta como se nada tivesse acontecido.
<p>- Você está diferente, até no jeito de falar. – Brandon não esperava encontrar Lisa assim.
<p>- Acho que está caindo a ficha, o ano está acabando e eu percebi que foi uma droga e que eu não vejo a hora de voltar para casa.
<p>- Ainda temos tempo de arrumar.
<p>- Temos? Porque eu não sei mais.
<p>- Não quero desistir de você ainda.
<p>- Engraçado, achei que já tinha desistido.
<p>Lisa se levantou do banco e foi embora.</p>
<center><h4>--*--</h4></center>
<p>Temperance estava na sala de estar lendo um livro que ela não lia há muito tempo. Nos últimos dias, ela tinha passado muito tempo lendo em sua casa. Ela não frequentava mais a biblioteca da escola, não queria encontrar com Jason, ou Emily, ou até mesmo com a Lisa. Ela preferia ficar na sua casa, na sua própria bolha.
<p>A campainha tocou, Temperance hesitou, mas depois foi atender a porta.
<p>- O que faz aqui? – Temperance ficou surpresa quando deu de cara com Nathan parado na sua porta.
<p>- Você não é a blogueira. – Ele entrou na casa dela sem mesmo ser convidado.
<p>- O quê?
<p>- Você não pode ser.
<p>- Não entendi. – Temperance ficou confusa e observava Nathan que parecia prestes a ter um treco.
<p>- A garota que eu conheci nunca poderia ser o blogueiro. Eu passei a noite toda lendo aquele blog e pensando nisso e...
<p>- Ficou acordado a noite toda?
<p>- Fiquei. – Ele estava sem graça.
<p>- Por quê?
<p>- Porque eu não podia aceitar.
<p>- Ninguém nunca ficou acordado a noite toda por minha causa. – Temperance sorriu.
<p>- Então eu sou o primeiro, eu acho.
<p>- É.
<p>Temperance nunca tinha sentido aquilo, um garoto estava na frente dela, se preocupando com ela e dizendo que pensava nela. Quando ela percebeu, já estava beijando ele. Foi diferente do primeiro beijo, aquele tinha algo a mais, ela não sabia o que, mas tinha.
<p>- Você me beijou. – Nathan encarou Temperance.
<p>- Beijei. – Agora ela queria se matar de vergonha.
<p>- Você não é o blogueiro, não é? – Nathan sabia que não.
<p>- Não, eu menti para acobertar uma pessoa. – Ela não podia esconder a verdade por muito mais tempo.
<p>- Quem?
<p>- Desculpa, eu não posso dizer.
<p>- É o Brandon?
<p>- Não, não... É. – Era como se Nathan lesse a mente dela.
<p>- E vai continuar mentindo?
<p>- Ainda não decidi.
<p>- Você já o perdoou?
<p>- Ainda não. E nem sei quando eu vou perdoá-lo.
<p>- Quero que saiba que eu te apoio e vou fazer o que você achar melhor. Não vou contar para ninguém enquanto não quiser.
<p>- Que bom. – Ela sorriu.
<p>- E quero que saiba de outra coisa também.
<p>- O quê?
<p>- Você beija muito bem. – Nathan chegou a ficar vermelho de vergonha.</p>
<center><h4>--*--</h4></center>
<p>- Você não vai acreditar no que aconteceu?
<p>Jason nem prestou atenção quando Lisa entrou no seu quarto toda exaltada. Seus pensamentos estavam bem longe de lá.
<p>- O Bran veio pedir para voltar. Acredita nisso? – Jason não respondeu. – É como se eu fosse o cachorrinho dele. Que ridículo. – Lisa nem percebeu que Jason estava no mundo da lua. – É claro que eu não vou aceitar assim de mão beijada. Ele precisa provar que realmente sente muito. Eu sofri muito por ele. O que acha que eu devo fazer?
<p>- O quê? – Jason percebeu que Lisa estava falando com ele.
<p>- Você nem ouviu o que eu disse.
<p>- É claro que eu ouvi. Você... vai comprar um cachorro. Já pediu permissão para a sua tia?
<p>- Eu não quero um cachorro. Eu estou falando do Bran.
<p>- É, o cabelo dele parece pelo de cachorro mesmo.
<p>- Jay, foco. – Lisa bateu palmas para Jason sair do transe. – Ele quer que a gente volte.
<p>- Que bom, não é? – Jason não sabia mais o que era bom ou ruim.
<p>- Talvez, sei lá, mas ele me magoou muito e agora...
<p>- Pelo menos, ainda estão no mesmo estado.
<p>- O quê? – Lisa não entendeu o comentário.
<p>- O que faria se o Enroladinho se mudasse para outro estado?
<p>- Agora? Eu faria uma festa. Não me preocuparia em dar de cara com ele em qualquer lugar dessa droga de cidade pequena.
<p>- Foi um péssimo exemplo.
<p>- Eu não estou entendendo, quem vai se mudar?
<p>- A Emily. – De repente falar em voz alta fazia ser mais real.
<p>- Mas por quê? Para onde?
<p>- Ela foi aceita em um estágio muito importante em Nova York, ela vai embora depois da formatura.
<p>- Nossa, que legal... para ela. – Lisa completou depois que viu a depressão do amigo. – Você tem que ficar feliz por ela, você entende isso, não é? Vai ser muito importante para o futuro dela.
<p>- Eu sei, mas graças a isso, não vamos ter um futuro.
<p>- Isso é bem egoísta.
<p>- Alô, você está falando com o Jason. Quem está no mundo da lua agora?
<p>- Jason...
<p>- Pela primeira vez eu me apaixono por uma garota e ela se muda. Deus está querendo brincar comigo? Não tem graça.
<p>- Muitos relacionamentos dão certo a distância.
<p>- Olha, eu não sirvo para namorar a distância, isso não funciona para mim.
<p>- Por quê?
<p>- Eu quero uma namorada que esteja do meu lado, não do outro lado do país. Ainda não inventaram intimidade virtual.
<p>- Não é o fim do mundo.
<p>- Eu sei que não é. Não é como se fossemos ficar juntos para sempre, eu já sabia que não ia durar muito depois da formatura... É que me pegou de surpresa.
<p>- Vocês ainda têm dois meses até a formatura. Aproveitem esse tempo.
<p>- Namoro com data de validade, que legal! – Jason fingiu animação.
<p>- Ela também não deve estar bem.
<p>- Está sim, está realizando um sonho.
<p>- Mas está perdendo você.
<p>- Que, modéstia parte falando, é bem melhor que um sonho.</p>
<center><h4>--*--</h4></center>
<p>Maddie e Kol estavam sentados na praça tomando sorvete.
<p>Kol ainda estava com raiva de Maddie por ela ter brigado com a Lisa, por isso mal estavam se falando, aquele sorvete era uma oferta de paz vindo da irmã.
<p>- A noite está linda, não é? – Maddie estava tentando puxar conversa.
<p>- Está. – Mas Kol continuava um pouco mais sério.
<p>- Kol, estou tentando, tá bom? Eu fui até pedir desculpas para a Lisa hoje, ela que não aceitou.
<p>- Não vamos falar da Lisa, tá bom? Eu não quero. Só vai piorar.
<p>- Eu sei que fui longe demais.
<p>- Vamos só tomar esse sorvete e ir para casa.
<p>- Claro.
<p>- Oi, gente. – Brandon chegou devagar, não sabia como estava o humor dos dois.
<p>- O que você quer? – Kol olhou feio para ele.
<p>- Eu só queria...
<p>- Eu não quero ver vocês dois brigando pela Lisa em público. Seria muito vexame. – Maddie falou logo.
<p>- Não é isso, eu não quero brigar. – Brandon se sentou ao lado deles.
<p>- Então o que você quer? – Kol ainda estava desconfiado.
<p>- Eu quero me desculpar e perguntar se vocês querem voltar a ser meus amigos.
<p>- Que carência é essa? – Maddie achou a atitude de Brandon estranha.
<p>- Maddie. – Kol chamou a atenção da irmã bem baixinho.
<p>- Eu estou me sentindo sozinho ultimamente e a gente sempre foi amigo, eu não queria perder isso, todos nós fizemos bobagens.
<p>- Quer tomar sorvete com a gente? – Maddie então falou.
<p>- Eu adoraria. – Brandon sorriu.</p>
<center><h4>--*--</h4></center>
<p>A última pessoa que Emily esperava que estaria na sua porta naquela noite seria Jason. Ele geralmente jogava pedras na janela dela antes de tocar a campainha.
<p>- O que está fazendo aqui tão tarde?
<p>- Eu queria falar com você.
<p>- Não podia ser amanhã?
<p>- Sabe que eu sou ansioso e odeio esperar.
<p>- Logico que eu sei, mas ainda te amo. – Ela sorriu.
<p>- Não devia dizer isso. – Jason falou baixinho.
<p>- Dizer o quê?
<p>- Que me ama, já que tem suas passagens compradas para ir para Nova York.
<p>- Na verdade, eu ainda não comprei e...
<p>- Olha, a gente mal conversou sobre isso e eu não quero ser o namorado chato, mas isso está me incomodando.
<p>- Eu sei.
<p>- Sabe?
<p>- Jason, você não é muito sutil, eu vi como você ficou depois da notícia. Só estava esperando você tocar no assunto.
<p>Os dois se sentaram no sofá da sala.
<p>- Também não quero te deixar. – Ela olhou nos olhos de Jason.
<p>- Mas é o seu sonho. E eu não posso ficar na frente disso.
<p>- Quando eu me inscrevi, eu não tinha ninguém, na verdade, eu estava arranjando qualquer pretexto para sair dessa cidade. Mas agora, eu tenho você e...
<p>- Eu quero que saiba que eu estou orgulhoso de você. Eu não estou com raiva nem decepcionado, eu estou orgulhoso e feliz por você. Mas mal por mim, ninguém gosta de ser deixado para trás.
<p>- Vem comigo. – Jason não esperava por esse comentário, e pela expressão de Emily, ela também não esperava falar aqui em voz alta. – Ah, qual é? Vai me dizer que não pensou nisso?
<p>- Pensei, por um milésimo de segundo. Onde iriamos morar? Você iria me sustentar? Um estágio não paga tão bem e ainda tem a faculdade... O que eu faria em Nova York? Venderia Sushi em Chinatown?
<p>- Ou cachorro-quente no Central Park.
<p>- Emily.
<p>- Você não tem sonhos também?
<p>- Ah... não. – Jason percebeu que não tinha mesmo. – Na verdade, eu sempre achei que ficaria no colegial para sempre, e com as minhas notas, isso podia ser possível, mas aí você apareceu.
<p>- Eu apareci.
<p>- E agora vai embora.
<p>- Não precisa ser assim, podemos dar um jeito.
<p>- Quer mesmo que a gente se torne um casal infeliz pela distância? Você vai estar em Nova York, a cidade do amor.
<p>- Achei que fosse Paris.
<p>- Bom, as comédias românticas são todas em Nova York.
<p>- Não é justo, não depois de tudo o que aconteceu com a gente. Eu até fui acusada de blogueiro.
<p>- Você nunca vai esquecer isso, não é?
<p>- Não.
<p>- Olha, eu não quero que fique presa a mim, e para ser sincero eu também não quero ficar preso a você.
<p>- Jason...
<p>- Eu sou um cara, tenho necessidades e a cidade está cheia de tentações. – Jason brincou. – E eu sou paranoico, você sabe, eu ia ficar toda a hora pensando no que você estaria fazendo. Confiança não é bem o meu forte.
<p>- É Nova York, você pode fazer o que quiser.
<p>- Mas eu nem sei o que eu quero. Eu não tenho sonhos.
<p>- Então vamos arranjar um para você. – Emily beijou Jason.
<p>- E se eu só atrapalhar você? Eu li uma vez que se você ama, você tem que deixar ir. Talvez eu tenha que te deixar ir.
<p>- Não quero que me deixe ir. Quero que lute por mim.
<p>- Não devia dizer isso.
<p>- Por quê?
<p>- Porque eu sou muito bom de briga, você sabe. – Jason beijou Emily. – Cadê seus pais?
<p>- Estão dormindo, por quê?
<p>- Porque eu vou começar a lutar agora.
<p>Jason deitou no sofá junto com Emily e os dois começaram a se beijar.</p>
</body></html>";
            }

            if (numero == 23)
            {
                lblTitulo.Text = "Capítulo 23 - Dance";
                htmlPage.Html = @"<html><body>
<p>O alarme tocou.
<p>- Que horas são? – Jason acordou assustado.
<p>- Quase sete. – Emily resmungou ao lado dele.
<p>- Que droga, eu estou atrasado.
<p>Jason pulou da cama.
<p>- Você sempre se atrasa. – Emily riu.
<p>- Se você acordou antes, por que não me acordou?
<p>- Porque eu gosto de te ver dormindo. – Emily estava zoando com a cara dele.
<p>- Muito engraçada. Quero ver você ficar fazendo piadinhas quando os seus pais me pegarem pulando a janela.
<p>- Jason Porter com medo? – Emily se levantou da cama também.
<p>- Fica quieta. Além do mais, para passar a noite com você, eu pulo até do precipício.
<p>- Nossa, que desespero. Nem parece que pegava garotas no banheiro.
<p>- Cala a boca. – Jason ficou observando Emily gargalhar. – Eu vou embora agora.
<p>- Eu te amo, sabia? – Emily ria com o nervosismo de Jason.
<p>- Eu também te amo. Você é linda até com remela no olho.
<p>- O quê? – Emily começou a limpar o canto dos olhos.
<p>- Eu disse que você continua linda.
<p>- É por isso que toda vez eu acordo primeiro que você, para me arrumar.
<p>- Você não pode evitar. Noite passada, eu acordei e você estava babando. – Jason começou a rir.
<p>- Cala essa boca.
<p>- Quem está fazendo piada agora?
<p>- Vai, pula logo dessa janela, antes que eu te jogue. – Emily abriu a janela.
<p>- Tudo bem. Ah, eu ia me esquecendo, hoje à tarde, você precisa me ajudar a escolher um smoking para o baile de formatura. Eu não sou muito bom nisso.
<p>- Por quê?
<p>- Porque o baile é nesse sábado e está em cima da hora e...
<p>- Isso foi um convite para ir ao baile? Você me chamou desse jeito?
<p>- Você é a minha namorada, não preciso te convidar.
<p>- É aí que você se engana.
<p>- Emily...
<p>- Convida logo. – Emily mandou.
<p>- Tá bom. Emily, quer ir ao baile de formatura comigo? – Jason ficou emburrado.
<p>- Eu adoraria. – Emily sorriu.
<p>- Que ótimo. – Jason foi irônico. – Vai ajudar com o smoking ou não?
<p>- Não entendo de smoking. Devia pedir para algum garoto.
<p>- Eu não tenho amigos.
<p>- Que triste. – Emily riu.
<p>- Você é uma chata. Eu odeio você.
<p>- Pula logo dessa janela. – Emily continuou brincando.</p>
<center><h4>--*--</h4></center>
<p>- Eu nem sei se eu vou ao baile.
<p>- Lisa, você passou a sua vida toda falando de baile. Como assim você não vai?
<p>Jason e Lisa se encontraram no meio do corredor da escola. Ele até pediu para ela ajuda-lo com o smoking.
<p>- Esse é o ponto. Eu sonhava com o baile perfeito, onde eu iria com o cara que eu estaria apaixonada e teríamos uma linda noite, dançaríamos até cansar e ele diria que eu estava parecendo uma princesa. Eu provavelmente seria a rainha do baile e...
<p>- Cara, você é muito mulherzinha. – Jason olhou com cara de nojo.
<p>- Sou sim, não é errado. É o meu único baile de formatura, devia ser como eu quero.
<p>- Nada é como a gente quer.
<p>- Do que está falando? Seu baile vai ser perfeito, vai estar com a sua namorada que te ama.
<p>- É, só que no meu baile perfeito, eu iria com uma garota, ficaria com outra no baile, e no fim da noite, eu iria para casa com outra, ou talvez iriamos nós quatro. – Jason começou a imaginar
<p>- Deixa de ser idiota. – Lisa bateu na cabeça de Jason para ele acordar.
<p>- Eu estou brincando. Tá, o meu baile vai ser bom, mas caras não ligam para isso. Só vamos ao baile para beber o ponche batizado, ficar de porre, e conseguir “algo a mais” com a garota depois. Ser o rei do baile para aumentar seu ego é um bônus.
<p>- É, e garotas vão ao baile para terem uma noite especial.
<p>- Você ainda pode ter uma noite especial, não precisa de um cara para isso. Vamos ao baile para comemorar o fim da escola e passar a última noite com os amigos, pelo menos é o que dizem.
<p>- É aí que tá, Jason. Eu não tenho amigos aqui. Eu conheço cinco pessoas nesse lugar: uma vai estar beijando e agarrando o meu melhor amigo, outra tentou me bater, um me beijou sabendo que eu tinha namorado, o outro me fez sofrer e tem mais, tem outra que fingiu ser minha conhecida só para espalhar fofocas de mim.
<p>- Lisa...
<p>- Esse ano foi o pior. Não tenho o que celebrar.
<p>- Desculpa eu ter te arrastado para cá.
<p>- Eu quis vir, e não é a sua culpa essa escola ser uma droga.
<p>- Está acabando, está acabando. – Jason abraçou Lisa.</p>
<center><h4>--*--</h4></center>
<p>- Com quem você vai ao baile?
<p>Maddie e Kol estavam almoçando juntos.
<p>- Com ninguém, por quê? – Kol não sabia porque a irmã estava perguntando isso para ele.
<p>- Por nada. Você vai sozinho?
<p>- Eu nem sei se eu vou. E você?
<p>- Acho que eu vou convidar o Bran, claro que vai ser só como amigo. Ele está sendo legal ultimamente agora que largou a Lisa, e parece que a Temperance vai com a namoradinho dela, então com certeza ele vai sozinho.
<p>- Boa sorte.
<p>- Pode chamar a Lisa se quiser. Não vou ficar com raiva.
<p>- Será que podemos não falar sobre a Lisa?
<p>- Claro, se é o que quer.
<p>- E o Bran não vai querer ir com você.
<p>- Por que diz isso?
<p>- Porque ele ainda gosta da Lisa. Não duvido nada deles se acertarem até sábado.
<p>- Então eu vou sozinha e me divirto com todo mundo.
<p>- Perdedora. – Kol sussurrou.</p>
<center><h4>--*--</h4></center>
<p>- Ei, Peruquinha, a gente pode conversar? – Jason correu atrás de Brandon assim que a aula acabou. Ele precisava falar com o garoto.
<p>- O que você quer? Me bater de novo?
<p>- Tentador, mas não. Vai chamar a Lisa para o baile? – Jason foi direto ao ponto.
<p>- Nós terminamos e ela não me quer de volta.
<p>- Vai chamar ou não? É uma pergunta simples de “sim” ou “não”, não precisa contar a história da sua vida.
<p>- Eu não posso.
<p>- Tanto cabelo e nenhuma coragem?
<p>- O que quer que eu faça?
<p>- Vire homem. Olha, a gente não se atura a metade do tempo, mas eu admito que a Lisa era feliz enquanto estava com você, agora ela está triste, amargurada, eu não tenho costume de ver ela assim e eu não gosto de ver ela assim.
<p>- Ela não me quer.
<p>- Arrisque, tá bom? Não custa nada. Eu sei que você ainda a ama.
<p>- É claro que amo.
<p>- Então. Para de frescura e vai. Ela só quer que você insista.
<p>- Obrigado pelo conselho, achei que não éramos mais amigos.
<p>- Olha só, Fios de Mola, eu peguei pesado com você por causa da Temperance, mas a verdade é que nós dois fomos enganados, não é? Bater em você não vai mais me fazer bem.
<p>- É. – A voz de Brandon quase não saiu. – Vai perdoá-la?
<p>- Eu não sei. Você perdoou?
<p>- Perdoei, mas ela não está mais falando comigo. Estamos dando um tempo na amizade.
<p>- Que saco. Bom, qualquer coisa estamos aqui, não é? A escola está para acabar, vamos aproveitar enquanto temos tempo. – Jason sorriu.
<p>- Isso quer dizer que somos amigos mesmo?
<p>- Isso quer dizer que eu preciso de ajuda para alugar um smoking, por isso estou puxando o seu saco.</p>
<center><h4>--*--</h4></center>
<p>- Oi. – Kol se aproximou de Lisa meio acuado enquanto ela estava no seu armário pegando os livros de gramática para a próxima aula.
<p>- O que você quer? – Lisa estava séria.
<p>- Eu estava aqui pensando... Quer ir ao baile comigo?
<p>- Não. – Lisa bateu forte a porta do armário.
<p>- Ah, qual é Lisa? Como amigos, eu não vou...
<p>- Me beijar enquanto eu namoro outra pessoa? Se fingir de vítima só para eu ser legal com você? Por que não vai fazer isso? Ficou chato?
<p>- Eu não estava pensando direito. Mas todo mundo comete erros e...
<p>- Sim, aparentemente, é o lema de todo mundo por aqui.
<p>- Lisa...
<p>- Você nem pediu desculpas, e ainda transformou a sua irmã em uma louca.
<p>- Eu não tenho culpa disso.
<p>- Alguma coisa você falou, ou não falou, porque não a impediu, só que agora não me interessa mais, só tenho que aguentar o baile, as provas finais e a formatura, depois não quero ver a cara de vocês nunca mais.
<p>- Eu sei que você está chateada e...
<p>- Eu não estou chateada, Kol. Eu estou possessa e farta de tudo isso. Então não, não quero ir ao baile com você, muito menos ser sua amiga. Eu quero é sumir daqui o quanto antes.
<p>Lisa deu as costas para Kol e foi embora.</p>
<center><h4>--*--</h4></center>
<p>- Eu nunca fui a um baile. – Temperance e Nathan estavam almoçando juntos.
<p>- Nem nos de primavera, inverno, nos Sadie Hawkins? – Nathan ficou surpreso.
<p>- Nunca.
<p>- Difícil imaginar que uma garota tão linda nunca foi convidada ao baile.
<p>- Na verdade, eu recusei todos sem querer parecer uma garota metida. – Temperance riu.
<p>- Por quê?
<p>- Nunca achei que valesse a pena.
<p>- E por que o meu convite vale? – Nathan ficou curioso.
<p>- Porque você é diferente de todo mundo.
<p>- Diferente? Isso é bom?
<p>- Isso é ótimo. Já viu os garotos dessa escola? São ridículos. E você... Mesmo a gente se conhecendo pouco, parece que você me conhece a vida toda.
<p>- Não é verdade. – Nathan ficou sem graça.
<p>- Você acreditou em mim. Ninguém fez isso.
<p>- Não foi nada.
<p>- Posso te contar um segredo?
<p>- Claro.
<p>- Isso foi muito importante para mim.
<p>- Posso te contar um segredo também?
<p>- Pode.
<p>- Acreditei em você porque estou apaixonado por você. – Nathan beijou Temperance.
<p>- Na verdade, eu também estou...
<p>- Eu sei. – Nathan pegou na mão de Temperance. – Eu te conheço, lembra? – Ele percebeu que era bem mais fácil fazer gestos de carinho e amor agora que ela já sabia o que ele sentia e que era reciproco.</p>
<center><h4>--*--</h4></center>
<p>Baile – aquela noite onde todos os alunos se vestem bem, se arrumam e vão ao ginásio do seu colégio para dançar, comemorar, uma comemoração por uma conquista, a formatura. Todo adolescente fica ansioso por isso, mesmo a maioria não admitindo.
<p>Lisa sempre teve aquela fantasia de baile. Seu sonho podia parecer bobo, mas sempre quis ser a Rainha do Baile, ela sabia que se ainda estivesse na sua antiga escola, sua campanha para Rainha do Baile já teria começado há muito tempo, mas agora ela não tinha eleitores, não tinha amigos, não tinha para que fazer campanha, nem para o Baile ela queria ir.
<p>Era engraçado como a vida dela e a sua própria personalidade mudou de um ano para cá. Ela nunca era muito de se apaixonar perdidamente por um cara e se jogar de cabeça principalmente depois do seu último relacionamento. Ela não se decepcionava com um cara, não deixava eles terem esse luxo, ela era quem geralmente terminava os namoros por “não estar dando certo”. Agora lá estava ela, linda em um vestido vermelho pronta para ir a um baile onde ela não iria se divertir, nem um par ela tinha.
<p>- Não quer mesmo que eu vá com você?
<p>- Jason, você vai com a Emily.  – Lisa estava cansada de Jason ficar em hora em hora oferecendo sua companhia para ir ao baile com ela.
<p>- Ela vai entender.
<p>- Mas eu não quero estragar a noite de vocês. Eu estou bem, muito bem.
<p>- Prometo que vou dançar com você uma música.
<p>- Vai logo se vestir ou vai se atrasar. – Lisa bufou.
<center><h4>--*--</h4></center>
<p>A vida de Brandon mudou drasticamente em pouco tempo. Há alguns anos, ele era só um garoto que passava horas no seu quarto e tinha uma única amiga, Temperance. Agora, ele estava no meio de uma desilusão amorosa e apaixonado pela garota mais linda que ele já tinha conhecido e ainda estava pronto para ir ao baile.
<p>Brandon pensou muito no que Jason havia falado para ele sobre se arriscar. Uma parte dele sabia que só estava indo ao baile para tentar se desculpar e conseguir ter a Lisa de volta. Mas e se ela descobrisse tudo o que ele escondia? Não teria perdão, sabia disso. Mas ele não tinha mais nada a perder. Quando estavam no primeiro ano do colegial, Brandon e Temperance combinaram que iriam ao baile juntos se não tivessem parceiros, agora nem a Temperance o Brandon tinha mais.
<br>
<p>Kol nunca teve planos de ir ao baile. Na verdade, nem a Andressa gostava de dançar. Eles sempre falavam que como comemoração, no dia do baile eles fugiriam e casariam em qualquer capela por aí e viveriam felizes para sempre.
<p>Mas a vida não foi justa com ele. Ninguém foi. Logo depois da morte do amor da sua vida, Kol desistiu, achou que nunca mais seria feliz e agora ele sabia que estava certo. Sua sorte no amor morreu junto com a Andressa. Mas ele tinha cometido uma mancada com a Lisa e agora estava lá sentado no sofá vendo Maddie se arrumar para o baile.
<p>Maddie nunca se importou em ir sozinha para o baile. Ela sempre pensou no baile como uma noite de diversão com os amigos. Ela sempre foi alegre e extrovertida e tinha muitos amigos, ela dançaria em grupo, tiraria muitas fotos e conversaria a noite toda, era para isso que estava indo para o baile, para se divertir.
<br>
<p>Temperance sempre achou que o baile era para perdedores, mas agora ela tinha um par, tudo tinha mudado. Ela passou a vida julgando os garotos do colégio, uns eram desesperados, outros muito travados, outros eram cara-de-pau, outros eram charmosos demais e alguns mentirosos, para resumir, nenhum era o Nathan.
<p>Agora ela estava fazendo algo que nunca achou que faria, um penteado e maquiagem. Seu vestido roxo estava preparado em cima da cama, ela tinha uma hora para se aprontar. Mal podia esperar para Nathan poder vê-la.
<br>
<p>Emily estava nervosa. Ultimamente aquele baile era tudo o que ela pensava, na verdade, o baile ajudava ela não pensar nas outras coisas. Daqui a algumas semanas ela estaria indo embora e, se tivesse sorte, nunca mais voltaria para aquela cidade, mas também tinha o Jason. Depois que descobriu que iria embora, toda vez que Emily via o namorado era como se fosse a última vez, aquele clima de despedida estava entre eles o tempo todo, e aquele baile seria a única noite onde eles não teriam que se despedir, esperava ela.
<p>A campainha tocou, Jason já tinha chegado.
<p><i>“Meu Deus, ele conseguiu ficar mais lindo de smoking.”.</i> Pensou ela.
<p>- Olha só, e eu achando que eu seria a pessoa mais linda do baile. – Jason sorriu.
<p>- Eu me esforcei um pouco. – Emily tentou ganhar vantagem.
<p>- Não minta, você nem precisa se esforçar.
<p>Jason não conseguia parar de olhar para Emily descendo as escadas. Os olhos dela estavam brilhando e o seu sorriso estava mais lindo do que nunca. Se ela estivesse com um vestido branco, ele casaria com ela naquele momento mesmo. Mas aquele vestido azul claro a deixava parecendo um anjo.
<p>- Bom, você pode não conseguir os votos, mas você já é a Rainha.
<p>- A Rainha do baile?
<p>- Do baile, do mundo, do meu coração, de tudo.
<p>- Idiota.
<p>Jason nunca ligou muito para o baile, mas agora o mínimo que ele queria era a noite perfeita, e olhando para a garota linda na frente dele, ele sabia que seria mais que perfeita. Então isso era amor.</p>
<center><h4>--*--</h4></center>
<p>O ginásio estava todo decorado. Havia balões azul e verde, as cores da escola, e havia luzes coloridas em toda parte. Todo mundo estava muito bem vestido e tinha até uma banda local.
<p>- Essa decoração está uma droga, já vi decorações melhores em filmes. – Temperance e Nathan estavam dançando.
<p>- Nem prestei atenção na decoração. Meus olhos estão em outro lugar.
<p>- Bom mesmo. – Temperance sorriu.</p>
<center><h4>--*--</h4></center>
<p>- Eu tenho uma novidade para você. – Jason estava ansioso. Estava dançando com Emily sua música favorita.
<p>- O que foi?
<p>- Eu ia te contar hoje de manhã, mas...
<p>- O quê? – Agora ela estava ansiosa.
<p>- Eu me inscrevi em umas faculdades que ainda tinham prazos essa semana.
<p>- Ah é?
<p>- É. Me inscrevi em uma na Pensilvânia, em Connecticut, Nova Jersey e uma em Nova York. Se tudo der certo, podemos estar nos amando ano que vem em Manhatthan.
<p>- Se candidatou para quê?
<p>- Sabe, finalmente estudando, eu percebi que eu até gosto de matemática e de arte, eu busquei na memória e lembrei que adorava aqueles brinquedos LEGO quando eu era criança.
<p>- Vai ser arquiteto?
<p>- Não custa tentar. Minhas notas em matemáticas são as mais altas.
<p>- Estou orgulhosa de você.
<p>- Devia se orgulhar mesmo. Você fez isso comigo. Agora eu tenho um sonho, não é bem um sonho, mas... – Jason estava animado.
<p>- Eu entendi. – Emily riu. - Mas agora realizou o meu sonho.
<p>- Vai além do estágio?
<p>- Muito além.</p>
<center><h4>--*--</h4></center>
<p>Lisa estava tomando um ponche sentada em uma das cadeiras encostadas nas paredes do ginásio.
<p>- Quer dançar? – Brandon apareceu.
<p>- Bran, eu...
<p>- Uma dança, só isso.
<p>Lisa hesitou, olhou para os lados pedindo ajuda, mas acabou se rendendo e se levantou. Brandon a conduziu para a pista de dança e começaram a dançar lentamente. Os dois estavam desconfortáveis, mas continuaram mesmo assim.
<p>- Olha, eu sei que você está magoada e tem dúvidas quanto a nós.
<p>- Bran...
<p>- Eu sei que eu sou culpado, mas eu só queria...
<p>- Bran, eu vou embora depois da formatura. – Lisa o encarou.
<p>- O quê?
<p>- Não precisa se desculpar nem tentar consertar as coisas, é inútil.
<p>- Não pode ir embora.
<p>- Eu já decidi.
<p>- Mas...
<p>- Bran, vamos só dançar.
<p>Brandon não sabia mais o que dizer. Ele tinha perdido. Ele tinha a perdido.</p>
<center><h4>--*--</h4></center>
<p>Temperance estava se servindo de ponche na mesa de bebidas. Estava rindo à toa.
<p>- Está curtindo o baile? – Emily apareceu do lado de Temperance, pegou um copo para fingir que estava se servindo também.
<p>- Estou sim, obrigada. – Temperance foi educada.
<p>- E o seu melhor amigo traidor? Está tendo tudo o que não merece?
<p>- Vai perguntar a ele. – Temperance não estava dando muita atenção a Emily.
<p>- Bom, se eu não consigo fazer você contar a verdade, talvez eu o convença a dizer.
<p>- Claro, porque você é muito persuasiva. – Temperance foi irônica.
<p>- Você sabe que é cumplice, não sabe? E pior, cumplice que se culpa.
<p>- Você não vai parar até conseguir o que quer, não é? O que você ganha com isso?
<p>- Nada, só não gosto de ver as pessoas sendo enganadas. Pelo jeito você contou a verdade para o seu namoradinho.
<p>- Deixa o Nathan fora disso.
<p>- Eu não vou falar com ele.
<p>- Você quer me ferrar, é isso? Não gosta de mim e por isso...
<p>- Não. Se eu quisesse te ferrar, já teria dito para todo mundo quem é o verdadeiro blogueiro. Eu quero te ajudar.
<p>- Eu não quero a sua ajuda. Vá para o inferno. – Temperance perdeu a paciência.
<p>- Eu vou, mas antes preciso fazer uma coisa. – Emily deixou o copo vazio na mesa e foi embora.
<p>- Que garota chata.</p>
<center><h4>--*--</h4></center>
<p>- Você viu a Emily?
<p>- Não conversamos a semanas e a primeira coisa que você me diz é “você viu a Emily”? Não, eu não vi. – Temperance estava emburrada.
<p>Jason se sentou ao lado de Temperance no ginásio. Ela tinha se sentado em uma das cadeiras para descansar as pernas enquanto Nathan ia ao banheiro.
<p>- O que quer que eu diga? Ei, Tempe, tem escrito muitas coisas no blog ultimamente?
<p>- Já disse que eu não sei onde está a Emily, vá procura-la.
<p>- Você e o Nathan se ajeitaram?
<p>- Por que quer saber? Vai estragar isso para mim?
<p>- Por que eu virei o vilão dessa história? Eu estou aqui conversando de boa com você. Deveria se considerar sortuda.
<p>- Que honra você conversando comigo.
<p>- Sorte sua que não sou vingativo, pelo menos não com você.
<p>- Sorte. – Temperance ficou triste de repente.
<p>- Olha, eu sinto a sua falta, tá bom? Pronto, eu disse. Mesmo você sendo você, foi a única amiga de verdade que eu fiz aqui. E eu fico pensando, alguma coisa daquilo tem que ser real.
<p>- Que bom. – Temperance estava tentando ser ignorante para não começar a chorar.
<p>- E isso foi meio que um pretexto para vir falar com você.
<p>- Quer dizer que vai me perdoar? – Ela nem se animou.
<p>- Quer dizer que eu quero, eu quero muito, mas sou orgulhoso demais para isso.
<p>- Jason...
<p>- Vou procurar a Emily. – Jason se levantou.</p>
<center><h4>--*--</h4></center>
<p>Brandon não conseguia mais ficar naquele ginásio. A dança com a Lisa tinha sido o pior momento daquela noite, nunca tinha visto a garota que ele amava tão fria. Para que ele estava lá mesmo? Ele estava se iludindo, ninguém mais se importava com ele. Lisa não o queria. Temperance o ignorava e se divertia com Nathan. Ele estava sobrando.
<p>- Brandon!
<p>Emily saiu correndo atrás de Brandon quando o viu sair do ginásio. Os corredores do colégio estavam vazios, dava até para ouvir o eco dos gritos de Emily.
<p>- Emily, o que você quer? – Brandon ficou surpreso. Emily nunca havia falado com ele direito.
<p>- Eu sei a verdade.
<p>- Era de se esperar que o Jason tenha te contado. – Brandon logo percebeu. – Olha, eu não sabia que a Tempe...
<p>- Eu sei que o blogueiro é você então me poupe o seu discurso de “eu não sabia de nada”.
<p>Brandon ficou em silêncio. Por essa, ele não esperava.
<p>- Você está louca.
<p>- Me poupe. Me poupe do seu papo “não sou eu, você está enganada” e blábláblá. Eu já sei de tudo.
<p>- A Tempe te contou?
<p>- Eu suspeitei, a cara dela me confirmou, simples assim.
<p>- O que você quer? Me chantagear?
<p>- Eu quero que você crie vergonha nessa sua cara e conte a todos a verdade.
<p>- Eu não posso.
<p>- Por que não? É corajoso o suficiente para postar segredos dos outros na internet, mas não é para confessar?
<p>- Isso é muito complicado.
<p>- Na verdade, é simples, muito simples.
<p>- Sabe, você deveria me agradecer.
<p>- Como é que é? – Emily não esperava que Brandon tivesse esse comportamento.
<p>- Você foi uma que eu ajudei. – Ele explicou.
<p>- Obrigada. – Emily foi sarcástica. – Olha, você não é o dono da verdade, não tinha o direito de decidir quem é certo ou errado, e pior, falando mal pela internet. Se queria defender alguém, por que não deu a cara para bater?
<p>- Você não entende. Eu já fui como você, eu...
<p>- Nada vai servir como desculpa, tá bom? – Emily começou a gritar. – Você é um covarde. Grita aos quatro ventos que a Temperance é sua melhor amiga, mas deixa ela levar a culpa por você e garanto que ainda consegue dormir à noite.
<p>- Não consigo.
<p>- E ainda tem a cara de pau de tentar salvar seu relacionamento com a Lisa? O que ela vai pensar quando descobrir que foi você que andou xingando ela quando estavam namorando?
<p>- Não era para atingi-la. Eu estava tentando protege-la.
<p>- Ah, claro. Você é uma ótima pessoa. – Emily estava furiosa, tinha adiado essa conversa tempo demais. – Um santo.
<p>- Eu queria que a Lisa e a Tempe ficassem seguras, eu queria...
<p>- Queria o quê? – Emily o enfrentou.
<p>- Queria que as duas ficassem longe de mim.
<p>Emily ouviu a voz de Jason vindo atrás dela. Brandon estava tão concentrado na discussão com Emily que nem viu que Jason havia aparecido e tinha ouvido quase toda a conversa.
<p>- Todo esse tempo, foi você. – Jason estava digerindo as coisas.
<p>- Jason... – Brandon olhou para Jason.
<p>- Você passou o ano todo me mandando ficar longe da Lisa e da Tempe enquanto o blogueiro acabava comigo e postava que eu falava mal das duas pelas costas delas e isso fazia com que as duas ficassem com raiva e se afastavam de mim. Foi tão óbvio.
<p>- Jason, vamos sair daqui. – Emily pegou no braço de Jason.
<p>- Espera. Eu não vou brigar... Eu só quero entender.
<p>- Jason, eu sinto muito. – Brandon estava apavorado.
<p>- Quando eu “descobri” que era a Temperance, eu mal deixei ela falar e disse um milhão de coisas, mas agora... Por quê?
<p>- Olha...
<p>- Me odiou tanto assim logo de cara? Todo aquele papo de amizade foi fingimento? Você me convidou para morar na sua casa para conseguir mais conteúdo para postar online?
<p>- Não é bem assim. – Brandon tentou explicar.
<p>- Eu não acredito. Nós descobrimos tudo naquela droga de computador, você inventou uma mentira e eu, um ótario, acreditei porque você não faria isso comigo... PORQUE EU ACHEI QUE ÉRAMOS AMIGOS! – Jason começou a gritar e seu grito ecoou pelo corredor todo.
<p>- E somos.
<p>- Amigos não falam mal de amigos.
<p>- Eu não te conhecia no começo.
<p>- Exatamente, você não tem o direito de achar que sabe como é a pessoa só porque viu ela andando no corredor. – Jason foi andando em direção ao Brandon.
<p>- Jason... – Emily já tinha se arrependido de ter largado o braço do namorado.
<p>- Eu sinto muito.
<p>- Não me importa nenhum pouco.
<p>Jason deu um soco na boca de Brandon.
<p>- JASON! – Emily gritou.
<p>- Se eu soubesse que seríamos amigos, eu nunca teria escrito sobre você. – Brandon cuspiu sangue no chão.
<p>- Mentiroso! Você nunca parou, mesmo depois... Você nunca parou.
<p>- Eu não podia. – Brandon estava desesperado. – Eu não...
<p>- Você deixou sua amiga levar a culpa por você.
<p>Jason voltou a socar Brandon, só que dessa vez com mais força e no nariz. Jason estava ficando vermelho de raiva e o nariz de Brandon estava agora sangrando também.
<p>- A Tempe decidiu isso sozinha, eu não queria...
<p>- E você, como um amigo agradecido, simplesmente deixou ela fazer.
<p>- Eu não tinha como...
<p>- O lance do chaveiro, você sabia que ela ia me dar, não sabia? Foi tudo um plano doentio. – Jason continuava andando em direção a Brandon enquanto ele se afastava bem devagar.
<p>- Na verdade, eu...
<p>- Você xingou a garota que dizia amar, você é um doente idiota e covarde.
<p>Jason empurrou Brandon contra os armários.
<p>- Eu te odeio, Brandon, EU TE ODEIO! – Jason gritou. – Você quis acabar com a minha vida!
<p>- Me perdoa! – Brandon começou a suplicar.
<p>- Você é o pior tipo de pessoa. – Jason deu um soco na barriga de Brandon e isso fez o garoto tossir sangue sem parar.
<p>- Jason, para! – Emily gritou assustada. Ela não conseguia se mexer.
<p>- Você vai me pagar por tudo o que você fez para todo mundo. – Jason apertou o pescoço de Brandon com uma das mãos enquanto a outra ainda o empurrava contra os armários.
<p>- Jason... por... favor. – Brandon fazia força para falar.
<p>- Jason, para. – Emily foi até os dois e segurou o braço de Jason e tentou tirar ele de perto de Brandon, mas foi em vão. – Vai matar ele.
<p>- É isso que ele merece. – Os olhos de Jason estavam segurando as lágrimas.
<p>- Não, para. – Emily apertou o braço de Jason.
<p>Brandon estava assustado e quase sem ar.
<p>- Por que você fez isso? – Jason soltou Brandon e ele caiu sentado no chão. – Você me enganou, eu posso não ter sido a melhor pessoa do mundo, mas você... – Jason travou. Não sabia mais o que falar.
<p>- Vamos sair daqui. – Emily também estava assustada, nunca tinha visto Jason com tanta raiva daquele jeito.
<p>De repente, os três ouviram o barulho da porta do ginásio abrir.
<p>- Jason, Emily, o que estão fazendo aqui? Estava procurando vocês.
<p>Lisa deu de cara com Brandon sentado no chão chorando e com o nariz e a boca sangrando, ela olhou direto para as mãos de Jason que também estavam machucadas. Lisa encarou Emily que estava prestes a chorar.
<p>- O que está acontecendo aqui? – Lisa estava espantada.
<p>- Fala você ou quer que eu fale? – Jason olhou para Brandon.
<p>- Lisa, eu sinto muito. – Brandon não parava de chorar.
<p>- Por quê? – Lisa não estava entendendo nada.
<p>- Eu sinto muito.
<p>- Gente, o que está acontecendo? – Lisa estava indo em direção de Brandon para consolá-lo.
<p>- Ele é o verdadeiro blogueiro.
<p>As palavras de Jason causaram um impacto em Lisa. Ela parou no meio do caminho e começou a encarar o nada.
<p>- Mas a Temperance... Ela...
<p>- A Temperance assumiu a culpa, porque o Brandon é covarde demais para se responsabilizar. – Jason fechou suas mãos com força, se Brandon levantasse, ele com certeza levaria outro soco.
<p>- Mas você... – Lisa olhou para Brandon. – Você não pode... Não!
<p><i>“Eu te amo”</i>
<p><i>“Parece que a nossa linda Lisa além de ser perfeita, ainda é atirada.” </i>
<p><i>“Lisa não é o que chamamos de a melhor pessoa do mundo, como amiga ela é nota zero, mas para outras coisas, ela até que sabe fazer bem quando você está entediado.”.</i>
<p><i>“Acorda para a vida, Lisa!”</i>
<p><i>“Parece que a Lisa está roubando corações por aí.”.</i>
<p><i>“Boatos estão rolando por aí dizendo que a nossa Lisa está brincando com dois garotos ao mesmo tempo.”.</i>
<p><i>“Agora me diga uma coisa, Lisa, é legal ser a nova vadia da escola?”.</i>
<p><i>“Eu te amo também”.</i>
<p>- Não pode ser. – Lisa começou a chorar. – Não! – Ela gritou.
<p>- Me perdoa. – Brandon se levantou e tentou chegar perto de Lisa.
<p>- FICA LONGE DE MIM! – Lisa gritou. – Fica longe.
<p>Lisa saiu correndo.
<p>- Lisa! – Brandon gritou.
<p>- Ainda vai ter coragem de ir atrás dela?
<p>Jason encarou Brandon pela última vez e então correu atrás de Lisa.
<p>- Emily... – Brandon não tinha mais a quem recorrer.
<p>- Eu devia ter deixado ele te matar.
<p>Emily limpou as lágrimas do rosto e voltou para o ginásio. Ela sabia que Lisa estava mal e Jason precisava acalmá-la, ela não queria atrapalhar, além do mais, ela precisava falar com Temperance.</p>
<center><h4>--*--</h4></center>
<p>Jason conseguiu falar com Lisa quando ela já tinha chegado em casa e estava no seu quarto. Ele havia corrido atrás, mas depois parou, não sabia o que diria, sabia que ela precisava de um tempo para processar tudo aquilo e ele também precisava, tinha achado melhor esperar um pouco antes de ir conversar com ela. Agora ela estava sentada no chão ao lado de sua cama. Seu rosto estava todo manchado por causa da maquiagem que as lágrimas estavam estragando.
<p>- Jason, eu quero ficar sozinha.
<p>- Eu te prometi uma dança, lembra? – Jason tirou a gravata e jogou na cama, ele odiava aquilo no pescoço.
<p>- Jason, eu não estou com cabeça para isso.
<p>Jason pegou o celular e deu play na primeira música que achou.
<p>- Mas eu sempre cumpro minhas promessas.
<p>Jason pegou a mão de Lisa, a levantou e a conduziu até o meio do quarto e começaram a dançar.
<p>- Ele mentiu para mim. Acho que nem me amava de verdade. – Ela falou entre os soluços.
<p>- Esquece isso.
<p>- Como eu posso esquecer? Eu não sei se o odeio ou se odeio a mim por não ter percebido nada.
<p>- Olha, a culpa não é sua, tá bom? Você não tinha o dever de descobrir nada.
<p>- Eu quero ir embora daqui.
<p>- Nós vamos superar isso, eu prometo. – Jason limpou as lágrimas do rosto de Lisa. – Juntos, sempre superamos.
<p>- Eu não acredito no que está acontecendo. – Lisa voltou a chorar.
<p>- Está tudo bem. – Jason a abraçou forte. – Vai ficar tudo bem. Vai ficar tudo bem.</p>
</body></html>";
            }

            if (numero == 24)
            {
                lblTitulo.Text = "Capítulo 24 - Despedida";
                htmlPage.Html = @"<html><body>
<p><i>“Meu nome é Brandon Schmutz e eu fiz coisas ruins...</i></p>
<br>
<p>Lisa estava se preparando para a última prova final, mais uma prova concluída e ela estaria livre. Livre da escola, livre daquele povo, livre de Brandon.
<p>Era estranho, Lisa esperava que ele fosse falar com ela depois do baile, para se desculpar, para se explicar ou qualquer outra coisa, mas não. Lisa não tinha mais visto Brandon por perto, parecia até que ele tinha trocado de horário das aulas, mas era melhor para ela. Ela não queria vê-lo, queria esquecê-lo, mas se dissesse que não sentia a sua falta seria mentira. Ela até se perguntava às vezes o que ele estaria fazendo. Mesmo querendo esquecê-lo, ele não saia de sua cabeça.
<p>- Eu acho que fui bem na prova de História. – Jason e Emily estavam almoçando com Lisa. Eles conversavam entre si enquanto Lisa comia quieta. – Só teve algumas perguntas que eu não fazia ideia do que era, aí eu chutei.
<p>- Quantas perguntas? – Emily ficou curiosa.
<p>- Mais da metade, na verdade. – Jason fez as contas.
<p>- Mas você disse que tinha ido bem. – Emily deu um olhar de reprovação para o namorado.
<p>- Ah, relaxa, eu sempre me dou bem quando chuto tudo. E para que vamos usar História na vida? Eu não estou indo descobrir um país.
<p>- Claro, porque História é só para isso. – Emily ficou séria. – Diz para ele, Lisa.
<p>Mas Lisa não estava prestando atenção.
<p>- Terra chamando Lisa... – Jason bateu palmas para “acordar” Lisa.
<p>- Ah, o quê?
<p>- Estamos falando de História. – Jason a situou.
<p>- Odeio História, temos que deixar o passado para trás, não é? – Lisa logo respondeu.
<p>- O quê? – Jason sabia que não estavam mais falando das provas.
<p>- Passado é uma droga.</p>
<center><h4>--*--</h4></center>
<p>Ela estava se odiando.
<p>Lisa não prestou atenção na última prova de Inglês, ela com certeza tinha passado, mas não tinha dado o seu melhor. A cabeça dela estava quase rodando e toda vez que ela passava pelo corredor, aquele corredor, ela lembrava.
<p>“Ele é o verdadeiro blogueiro”. A voz de Jason ainda ficava na cabeça dela o tempo todo. Era horrível.
<p>- Bran?
<p>Lisa finalmente encontrou Brandon. Ele estava colocando suas coisas do armário na sua mochila.
<p>- Lisa, oi. – Os dois ficaram parados um olhando para o outro por um bom tempo até ele voltar a falar como se quisesse puxar assunto. – Você foi bem na prova?
<p>- Eu vou me formar, é o que importa. – Lisa o observava tirar as coisas do armário com muita rapidez. – O que está fazendo?
<p>- Bom, como as provas acabaram, eu estou limpando o meu armário.
<p>- Não vai mais para as aulas? – Lisa estava séria.
<p>- Não vejo razão.
<p>- Então adeus. – Lisa falou com a voz um pouco fraca, mas mesmo assim não deu as costas para ele. Não conseguia.
<p>- Lisa, espera.
<p>- Bran, o que você quer?
<p>- Talvez depois de hoje a gente não se fale mais, mas eu quero dizer que eu sinto muito mesmo. Não queria ter feito nada do que eu fiz.
<p>- Mas você fez mesmo assim. Não acha meio tarde vir me pedir desculpas.
<p>- Você não entende.
<p>- E nem quero entender. – Lisa tentou colocar um pouco de distância entre eles. – Sabe, Brandon, é melhor mesmo você não voltar para as aulas. No minuto que descobrirem que você é o blogueiro, ninguém mais vai querer você aqui.
<p>- Você vai contar? Me odeia tanto assim?
<p>- Eu não vou contar. Eu não sou fofoqueira como você. Se você quer manter em segredo, eu não ligo. Não mais.
<p>- Sabe, quando a gente se conheceu, eu achei que... Eu senti que a gente ficaria junto para sempre. Eu queria isso.
<p>- Você não pode me dizer isso. Não depois de tudo.
<p>- Mas Lisa...
<p>- Não é engraçada a vida? Você me crucificou por ter feito uma coisa errada, quando na verdade você fez pior. Se você não me perdoou, por que eu tenho que te perdoar?
<p>- Eu te perdoei.
<p>- Quando percebeu que estava ficando sozinho. – Lisa estava prometendo a si mesma que não choraria.
<p>- Me diz o que eu tenho que fazer para você parar de me odiar.
<p>- Eu não odeio você. – Lisa se rendeu ao choro. – Eu te amo.
<p>- Eu também te amo.
<p>- Não quero que me ame desse jeito, porque desde que eu descobri, eu fico com essa coisa na cabeça, todos os posts, tudo o que você falava que eu já nem sei mais se é verdade, todas as mentiras.
<p>- Nunca menti sobre o que eu sinto por você. Eu juro.
<p>- E como você quer que eu acredite em você? Você tem uma dupla personalidade? Você não era você quando me xingava pela internet? Quando infernizava a vida do Jason?
<p>- Não começou sim. No começo... eu não conhecia...
<p>- Não me interessa o começo, e sim como é agora. E ao meu ver, agora é péssimo.
<p>- Lisa...
<p>- Já chega.
<p>- Por favor. – Ele pegou na mão dela. – Você precisa me perdoar. Eu preciso de você.
<p>- Não me faça ser a vilã da história. Eu não posso te perdoar, não agora. Eu preciso de um tempo e...
<p>- Não temos esse tempo. – Brandon tentava esconder seu desespero.
<p>- Eu não posso, não agora. Tem tanta coisa... Eu não posso.
<p>Lisa se soltou de Brandon e foi embora correndo.</p>
<br>
<p><i>... Eu menti para a garota que eu mais amava. Lisa, a garota que eu estava, ou melhor, estou perdidamente apaixonado me odeia agora porque eu a enganei e ela tem toda a razão, eu não posso dizer que ela está exagerando ou algo parecido, o que eu fiz foi muito ruim. Será que eu não tinha noção do quanto isso afetava as pessoas? Eu deveria saber, já passei por isso. Lisa, me perdoa por te amar do jeito errado, eu nunca quis que você... você merecia mais...</i></p>
<center><h4>--*--</h4></center>
<p>- Temperance, espera!
<p>Jason estava procurando Temperance pela escola toda até que a achou no meio do povo em um dos corredores. Ela parecia andar mais rápido conforme ele gritava mais alto. Estava tentando evita-lo, ele sabia disso.
<p>- Jason, o que foi? – Ela não estava muito feliz nem com muita paciência quando ele a alcançou.
<p>- Eu descobri que...
<p>- O Brandon é o blogueiro. – Temperance completou. – A Emily me contou sobre a briga, todos os detalhes.
<p>- Olha, eu queria falar com você.
<p>- Sobre isso? Sobre como bateu nele?
<p>- Não. Sobre nós. Eu não sei porque você aceitou levar a culpa, também não me interessa, mas falei aquelas coisas e... Bom, dizem que quando a gente faz uma burrada, devemos nos desculpar.
<p>- E você quer se desculpar comigo?
<p>- Eu disse muitas coisas que eu não queria dizer. Na verdade, na hora eu queria dizer isso, mas agora eu sei...
<p>- Eu sei, está arrependido.
<p>- Estou, sim. Bom, na verdade, não. – Jason estava ainda muito confuso com aquela história toda. – Você é a culpada por me fazer acreditar que era você. Como queria que eu reagisse?
<p>- Eu sou culpada?
<p>- Devia ter me contado a verdade. Devia ter me contato que era o Cabeleira o tempo todo.
<p>- Eu queria evitar exatamente a briga que vocês dois tiveram.
<p>- Tinha medo de eu mata-lo?
<p>- Na verdade, eu tinha sim. Seu histórico não é muito bom. – Temperance o enfrentou.
<p>- Olha, uma hora a verdade chegaria, você só a atrasou. E eu não acredito que você ajudou alguém que só falou mal de você. Você o perdoou?
<p>- Ele nunca havia falado mal de mim, só começou quando você chegou.
<p>- Vai me culpar por estragar a amizade de vocês agora?
<p>- Não. O Bran estragou tudo sozinho. Eu não culpo ninguém.
<p>- Temperance, isso é muito doentio. Como você conseguiu ainda pensar nele depois de tudo.
<p>- Isso não vem ao caso agora. Não te interessa, na verdade.
<p>- Tudo bem, eu não quero falar sobre isso. Eu só... como estou indo com o meu pedido de desculpas?
<p>- Eu não ouvi as palavras “me desculpe”?
<p>- Ainda tem isso também?
<p>- Jason!
<p>- Tá, me perdoa?
<p>- Tudo bem. – Temperance deu um sorriso forçado. – Por um minuto você duvidou?
<p>- O quê? – Jason não entendeu.
<p>- Você me teve como amiga por quase um ano. Você não duvidou que eu estaria mentindo e que eu não era a blogueira de verdade?
<p>- Está dizendo que eu deveria ter sacado que você estava mentindo? Não acha que está pedindo demais?
<p>- Olha, eu te perdoo e estou disposta a esquecer tudo e seguir frente, além do mais, não quero ficar sem amigo nenhum, mas saiba de uma coisa, você também me decepcionou.
<p>- Que ótimo.
<p>- Você tem um problema em confiar nas pessoas. Devia tratar isso.
<p>- É o contrário. Eu confiava tanto em você que descobrir aquilo quase me matou. Agora me vem com essa brincadeira?
<p>- Olha, eu preciso ir embora.
<p>Temperance se despediu e foi embora.
<p>- Inacreditável. – Jason ficou inconformado.</p>
<center><h4>--*--</h4></center>
<p>Temperance passou a tarde toda sentada em um balanço que ficava na varanda da sua casa. Ela se lembrava de que quando era pequena adorava aquilo. Passava horas e horas ali.
<p>- Você se lembra quando éramos pequenos e brigávamos para ver quem ia ficar mais tempo no balanço? – Brandon se aproximou de Temperance aos poucos. Estava fazendo sua última tentativa para salvar sua amizade com Temperance.
<p>- Naquela época você já pensava em ser um blogueiro? – Temperance estava fria.
<p>- Tempe, eu estou tentando...
<p>- Se quer me emocionar com nostalgia não vai funcionar.
<p>- Você e o Jason já se entenderam?
<p>- Por que se importa?
<p>- Não quero que fique sozinha.
<p>- Melhor sozinha do que mal acompanhada, não é isso?
<p>- Tempe...
<p>- Nos entendemos sim, mais ou menos. – Temperance estava se sentindo muito desconfortável ali.
<p>- Que bom para vocês. – Brandon sorriu.
<p>- Já faz uma semana desde o baile. Você sumiu e agora me vem com esse papo? Por quê?
<p>- Bom, eu não me sinto bem e eu preciso de você e...
<p>- Olha só, Brandon, eu não consigo, tá bom? Eu sei que você quer que a gente volte a ser amigo, mas eu não consigo.
<p>- A gente podia ao menos...
<p>- Toda vez que eu olho para você, eu me lembro das coisas ruins que eu pensei sobre o blogueiro. E de todas as coisas que eu... – Ela não conseguia terminar a frase.
<p>- Mas eu...
<p>- E eu não consigo esquecer, porque o que você fez não tem nome.
<p>- Sabe que eu não vou conseguir, não sabe? Ficar sozinho, eu odeio isso. Eu sempre tive você do meu lado e...
<p>- Você decidiu fazer uma coisa, agora precisa lidar com as consequências.
<p>- Sabe que eu não tive escolha, você mais do que ninguém sabe o sufoco que eu passei naquele colégio, aquelas pessoas não tinham limites, elas acabavam comigo e acabavam com você e...
<p>- E quanto ao Jason? E quanto a Lisa? E quanto a mim? – Temperance não deixou Brandon responder. – Eu não dou a mínima para as pessoas que você fez serem expulsas, eu me importo comigo.
<p>- O Jason era o tipo de cara que a gente costumava odiar, eu pensei que...
<p>- Pensou errado. Você o julgou sem conhece-lo e não fez só isso, o atacou e quase destruiu tudo o que ele tinha. Jason pode ser muitas coisas, menos mentiroso, é por isso que ele é melhor que você.
<p>- Tempe...
<p>Aquelas palavras cortaram Brandon bem fundo. Ele tinha perdido. Evitou chorar, não queria demonstrar aquilo naquele momento.
<p>- Eu não estou falando para você me perdoar agora, mas...
<p>- Eu não quero mais ficar perto de você. Eu não te conheço mais.
<p>- Eu estou arrependido. Com o tempo, você vai ver e...
<p>- Como eu vou saber que todo esse arrependimento é verdadeiro?
<p>- Sou o seu melhor amigo.
<p>- Uma amizade cheia de mentiras. Eu prefiro ficar sozinha a ter um amigo como você.
<p>- Não diz isso.
<p>- Mas é a verdade. – Temperance foi dura.
<p>- Não vai mudar de ideia, não é? – Brandon começou a limpar os olhos, não queria mesmo chorar na frente de Temperance.
<p>- Não, eu não vou.</p>
<br>
<p><i>... Tempe, eu fui um amigo horrível com você, e por isso, eu nunca vou me perdoar. Você é a pessoa mais importante para mim. Eu vou passar o resto da minha vida me destruindo por ter feito você passar por isso, nunca foi a minha intenção, e acredite em mim quando eu digo que te amo e que você foi a melhor coisa que aconteceu na minha vida. Espero que fique bem, espero que encontre alguém bem melhor do que eu...</i></p>
<center><h4>--*--</h4></center>
<p>Kol e Maddie estavam limpando seus armários que eram um do lado do outro.
<p>- O que você vai guardar? – Maddie perguntou ao irmão.
<p>- Aqui no meu armário só tem livros. Eu vou jogar tudo fora. – Kol estava colocando seus livros todos em um caixa.
<p>- Ah, eu vou guardar as fotos. – O armário de Maddie era todo enfeitado e cheio de fotos pregadas por todos os cantos. – Vou sentir falta dessas pessoas. – Maddie estava guardando suas fotos na mochila.
<p>- A cidade é pequena, vão se esbarrar por aí o tempo todo.
<p>- Mas não vai ser o mesmo. Não vamos mais ter um motivo para estar todos juntos e muitos desaparecem.
<p>- Você aí triste e eu aqui não vendo a hora de sair dessa escola e nunca mais ver ninguém daqui.
<p>- Isso não é saudável.
<p>- Não disse que era.
<p>- No final, só vai sobrar nós dois, não é?
<p>- É. – Kol abraçou a irmã. – E é o que importa.
<p>- Me perdoa por tudo o que eu fiz, foi só para te proteger, porque eu te amo. – Maddie começou a chorar nos braços do irmão.
<p>- Eu também te amo. Agora para de chorar, é estranho.
<p>Ela sorriu enquanto desfazia o abraço com o irmão para limpar as lagrimas do rosto com as mãos.
<p>- Pessoal, eu posso falar com vocês? – Brandon se aproximou dos dois irmãos um pouco sorrateiro.
<p>Maddie limpou o rosto e sorriu para Brandon.
<p>- O que foi? – Kol ficou preocupado pela cara que Brandon estava fazendo, ele parecia triste.
<p>- Eu sinto muito.
<p>- Pelo quê? – Maddie ficou confusa.
<p>- Por tudo o que eu fiz.
<p>- Mas você não fez nada para a gente. – Maddie estava começando a achar que Brandon estava ficando louco.
<p>- Eu sou o blogueiro.
<p>- O quê? – Kol não conseguia acreditar.
<p>- Não pode ser. – Maddie olhou para Brandon com cara de nojo. – Não pode ser.
<p>- Me desculpem.
<p>- Depois de tudo o que fez para todo mundo, você vem até aqui e só diz “me desculpem”? – Kol começou a rir.
<p>- Não espera que a gente te perdoe, não é? – Maddie encarou Brandon.
<p>- Não, só queria que soubessem.
<p>Brandon deu uma última olhada para Maddie e Kol, se virou e foi embora. Ele ainda conseguiu ouvir comentários dos dois do tipo “ele sacaneou a própria namorada”, “será que ele é louco?”, “deve ser um desocupado, que horror”.</p>
<br>
<p><i>... Eu machuquei muita gente e eu acho que não percebi, não sei qual é o problema comigo. Para todas as pessoas que eu magoei direta ou indiretamente, eu espero do fundo do meu coração que me perdoem, porque eu sei que não vou conseguir conviver com essa culpa sozinho, eu sei que é difícil até porque eu mesmo não consigo me perdoar...</i></p>
<center><h4>--*--</h4></center>
<p>- Você parece nervoso, o que está rolando?
<p>Emily e Jason estavam indo embora da escola. Estavam andando bem devagar, não estavam a fim de chegar logo em casa e Emily percebeu que o namorado estava um pouco inquieto.
<p>- Eu acho que não entrei para a faculdade. – Jason estava pensativo.
<p>- Por que diz isso?
<p>- Bom, eu estava passando pelos corredores hoje de manhã e já tinha um montão de gente falando que já tinha recebido a carta de Aceitação e Rejeição das faculdades.
<p>- Você não recebeu nada?
<p>- Ainda não. Nem um me chamando de burro.
<p>- Então não se preocupe ainda. Só se considere rejeitado se a sua carta chegar e disser isso.
<p>- Mas e se eu sou tão ruim que nem mandaram uma carta avisando? Tipo, olharam para a minha inscrição e falaram “ele já sabe o resultado, para que vou perder meu tempo?” – Quando se tratava de inteligência, a autoestima de Jason ficava lá embaixo.
<p>- Do que você está falando? Claro que não. – Emily começou a rir. – A verdade é que qualquer faculdade que te rejeitar vai estar perdendo um ótimo aluno.
<p>- Você mente muito mal. – Jason beijou Emily. – Mas assim eu já me sinto melhor.
<p>- Não é mentira, é sério.
<p>- Que bom que pelo menos você acredita em mim.
<p>- E eu vou acreditar sempre. – Emily sorriu.
<p>- É por isso que eu te amo.
<p>- Eu sei.
<p>Mesmo com todo o apoio da namorada, Jason sabia que a qualquer hora as cartas de cada faculdade que ele se inscreveu chegariam na sua casa e ele teria que se decepcionar com todas elas quando lesse “você foi rejeitado, eu lamento”.
<p>- Mas como você está sobre...
<p>- Não vamos falar sobre isso. – Jason já sabia o que a namorada queria.
<p>- Por que não?
<p>- Porque aí vamos brigar. Você sabia o tempo todo.
<p>- Eu não podia fazer nada. A Temperance não ia...
<p>- Olha, esse pessoal é muito estranho. Como conseguiu viver aqui todo esse tempo e continuar tão normal?
<p>- Amor, seu amor te cega. – Emily riu.
<p>- Tem razão. Vai ver você é a mais louca de todos.
<p>Os dois começaram a rir, mas foram interrompidos.
<p>- Jason!
<p>Jason e Emily viraram para trás. Brandon estava tentando alcança-los.
<p>- O que você quer, Brandon? – Jason fechou a cara para falar com ele.
<p>Emily segurou o braço de Jason bem forte, como se ela fosse capaz evitar se Jason resolvesse voltar a bater no Brandon.
<p>- Eu queria falar com você.
<p>- Olha, eu não estou no clima...
<p>- Por favor, vai ser rápido. Por favor. – Brandon estava quase suplicando.
<p>- Tudo bem.
<p>- Eu vou deixar vocês sozinhos. Acho melhor.
<p>Emily olhou desconfiada para os dois, largou o braço de Jason e foi para o outro lado da rua para observar de longe.
<p>- Fala.
<p>- Jason, eu quero dizer que... Eu sei que você está me odiando agora e que você...
<p>- Sem enrolação, vai direto ao ponto. – Jason estava se segurando para não bater nele de novo.
<p>- De todas as pessoas que eu me importo, eu sei que você foi a mais afetada.
<p>- Pessoas que você se importa? Você se importa comigo? – Jason quase riu.
<p>- É claro que sim.
<p>- Imagina se não se importasse. – Jason cruzou os braços, assim ele conseguia se controlar mais fácil.
<p>- Eu sinto muito por tudo o que eu fiz para você. – Brandon tentou ignorar o comentário. – Eu não devia ter te julgado sem te conhecer, eu não devia ter dito todas aquelas coisas sobre você e mentir na sua cara. Eu fui um péssimo amigo e uma pessoa horrível. Me perdoa. – Os olhos dele estavam vermelhos e inchados.
<p>- Tudo bem. Eu perdoo. – Jason continuava sério e de braços cruzados, ele ficou encarando Brandon enquanto ele falava.
<p>- Você me perdoa? – Brandon nem acreditou.
<p>- Perdoo.
<p>- Muito obrigado. – Brandon sorriu.
<p>Por um segundo, ele se aproximou de Jason para abraça-lo, mas Jason se afastou. O sorriso saiu do rosto de Brandon.
<p>- Eu te perdoo, mas não somos amigos, então não fique muito animado. Você não é nada para mim, tão insignificante que nem vale a pena guardar rancor. Tão insignificante que nem vale a pena pensar sobre você.
<p>- Não diz isso. – Brandon segurou as lágrimas nos olhos.
<p>- Sabe o que você é, Bran? Um covarde, se escondeu atrás do computador com medo de encarar as pessoas e brigar.
<p>- Você não sabe de nada.
<p>- Ainda bem, porque eu não quero.
<p>- Você não entende.
<p>- Tem razão, eu não entendo. Eu não entendo o que leva alguém a trair a confiança dos seus amigos só para...
<p>- Se salvar, eu fiz isso para me salvar. Você não entende porque nunca sofreu isso. – Brandon começou a gritar, sua tristeza se misturou com raiva e ele não teria outra chance para gritar aos quatro ventos o que sentia. – Você nunca precisou andar pelos corredores de cabeça baixa e com medo, nunca foi ameaçado o tempo todo...
<p>- Nossa, seguindo a sua teoria, deve existir uns quinhentos blogueiros pelo estado, não é? Nada do que você passou justifica.
<p>- Justifica para mim!
<p>- Se você fez o certo, se você acha que está certo, por que está pedindo perdão?
<p>- Isso precisa parar. Eu só me defendi. Só isso. – Ele parou de gritar.
<p>- Você nunca gostou de mim e eu nunca gostei de você. Vamos viver assim.
<p>- Mas não é...
<p>- Não adianta prolongar isso. Não faz sentido.
<p>- Você não...
<p>- Olha, Brandon, relaxa, tá bom? Você tem o meu perdão, não é isso que você quer?
<p>- Sim.
<p>- E a partir de hoje, você pode se acalmar, eu vou ignorar você, eu não vou brigar nem xingar nem provocar, vou fingir que você não existe, você vai poder viver a sua vidinha como quiser, porque eu não me importo. – Jason descruzou os braços, ele não estava mais querendo brigar. – Eu tenho mais o que fazer do que ficar pensando em como você sofre e em como a sua vida é miserável. Eu não odeio você, não vale a pena odiar você, você é um nada, se quiser até pode continuar escrevendo sobre mim, porque eu percebi que a sua opinião ou de qualquer um não me importa, então se te faz se sentir bem, pode postar, até porque eu sempre achei que o blogueiro era mais inteligente e talvez eu até respeitasse ele e por isso a opinião me afetava tanto, mas agora eu sei que é você e... Olha só para você, eu estou pouco me lixando para o que você pensa de mim. Por mim, você pode até morrer.
<p>Jason deixou Brandon falando sozinho e atravessou a rua para se juntar com Emily e ir embora.
<p>- Você está bem? – Emily falou baixinho enquanto ainda olhava para Brandon do outro lado da rua.
<p>- Não, mas vamos embora.
<p>Jason pegou na mão de Emily e começou a andar sem olhar para os lados.</p>
<br>
<p><i>... Jason, eu admito que você não merecia nada do que eu fiz para você, mesmo nunca tendo uma grande amizade, você foi muito bom para mim, foi muito bom ter um amigo de verdade para conversar sobre qualquer coisa, a Tempe é ótima, mas não era a mesma coisa, você era diferente, divertido, eu gostava de ficar com você, eu sinto muito ter estragado isso. Mas foi bom, eu não merecia a sua amizade. Cara, eu sinto muito...</i></p>
<center><h4>--*--</h4></center>
<p>- Mãe! Mãe!
<p>Brandon chegou em casa gritando. Ele estava desesperado. As palavras do Jason ainda estavam gritando na sua cabeça e ele não conseguia fazer nada a não ser chorar.
<p>- Mãe! Mãe! Mãe, cadê você? Eu preciso de você!
<p>Não tinha ninguém em casa.
<p>Brandon começou a correr pela casa, a procurar por alguém, mas se ninguém tinha o escutado era porque a casa estava vazia mesmo. Sua mãe com certeza estava na casa de alguma amiga e seu pai estava trabalhando, ele sempre estava trabalhando.
<p>Ele entrou no seu quarto e começou a bater as portas do seu guarda-roupa, ele estava com tanta raiva que ele não sabia como tirar aquilo, ele nunca havia se sentido assim antes. Era horrível. Sentia um aperto no peito, não sabia como fazer parar.
<p>- Tempe? – Brandon ligou para Temperance em um ato de desespero.
<p><i>- Brandon? O que você quer?</i> – Temperance estava irritada.
<p>- Tempe, por favor, eu preciso de você. – Brandon estava chorando.
<p><i>- Olha, eu vou trocar de número.</i>
<p>- Eu não quero ficar sozinho, por favor.
<p><i>- Não me liga mais! </i>– Temperance desligou o telefone.
<p>- Tempe, por favor... – Ele não sabia mais o que fazer.
<p>Brandon jogou o celular na parede.
<p>- Para com isso, por favor.
<p>Suas mãos estavam no seu rosto. Ele estava envergonhado demais para encarar o espelho.
<p>- Me ajuda. Por favor, alguém me ajuda. – Ele chorava.</p>
<br>
<p><i>... Vocês acham que me odeiam muito, não é? Mas não. Ninguém me odeia mais do que eu mesmo. Eu destruí tudo que era bom na minha vida, e agora não tenho nada. Não sobrou nada para mim.”.</i></p>
<br>
<p>Brandon foi até o quarto da sua mãe, ele sabia onde ela guardava aquilo que ele queria, aquilo que ele precisava. Ele não teria coragem de se machucar, só iria piorar. Brandon estava muito nervoso, ele só queria se acalmar.
<p>Brandon pegou a maleta em cima do guarda roupa da sua mãe. Suas mãos estavam tremendo. Havia muitos lá, ele não sabia qual daquelas embalagens guardava aquilo que deixaria ele calmo. Sua cabeça parecia que ia explodir. Ele abriu a primeira embalagem. Brandon não estava aguentando mais, seu corpo todo estava tremendo agora.
<p>Mas aquele comprimido não adiantou. Sua cabeça ainda estava explodindo, ele ainda estava chorando de nervoso e seu corpo ainda estava tremendo. Brandon tomou outro. Ele fechou os olhos na esperança que tudo passasse, que fosse apenas um sonho. Mas não era. Brandon sentiu outro comprimido entrando pela sua garganta. Ele não conseguia mais chorar. Sua cabeça estava tão pesada que o fez sentar no chão. A temperatura do seu corpo aumentou. Tomou mais dois comprimidos. Seus olhos estavam quase fechando. Suas pernas estavam dormentes, ele não conseguiria mais se levantar sozinho. As vozes de Temperance, Lisa e Jason começaram a ecoar pelo quarto. As lágrimas nos olhos de Brandon voltaram. Mais três comprimidos. Suas mãos tremiam mais do que nunca. Estava tudo girando. Ele estava com frio. Mais um comprimido. Suas mãos pararam de tremer, sua cabeça agora estava leve. O sono estava quase o dominando, ele queria dormir, mas algo ainda não estava bem.
<p>Aquela sensação não sarava. Aquele ódio não sumia. Ele não estava mais chorando, mas a tristeza continuava ali. Sua cabeça não estava doendo, mas o nervoso ainda tomava conta dele. Seu corpo estava dormente, mas a vontade de sair gritando ainda era grande. Mais dois comprimidos. Isso não adiantava. Mais dois comprimidos. Aquilo não parava. Mais quatro comprimidos. O corpo dele ainda lutava para ficar acordado. Mais três comprimidos. Ele queria dormir, queria esquecer de tudo. Mais cinco comprimidos. Seus olhos fecharam. Suas costas se renderam, ele caiu para trás. Suas mãos ficaram pesadas demais para levantar. O único som que ele ouvia era seu coração batendo lentamente, até não ouvir mais nada.</p>
</body></html>";
            }

            if (numero == 25)
            {
                lblTitulo.Text = "Capítulo 25 - Origem";
                htmlPage.Html = @"<html><body>
<p><i>“<b>BOAS NOVAS, PESSOAS, EU CHEGUEI.</b> Bom, eu acho que vocês não me conhecem, então eu vou começar me apresentando: Eu sou aquele que vai expor todos os segredos de todo mundo para todo mundo. Vocês devem estar assustados e curiosos perguntando: Por quê? Porque eu cansei de gente hipócrita, eu cansei das pessoas julgando e não querendo ser julgadas. Eu cansei de rir e aturar tudo. Bom, quem vai ser o primeiro a não ter mais segredos a esconder?“.</i> – Tesouro dos Segredos Obscuros.<p>
<br>
<p>Naquela manhã, os alunos do colégio Carmel estavam mais agitados do que o normal. Com os celulares na mão, estavam todos falando sobre o tal blog Tesouro dos Segredos Obscuros que do nada apareceu na internet na noite anterior. Todos tinham recebido mensagens de texto com o link do site, tudo anonimamente.
<p>- Por favor, me diz que você ficou sabendo o tal blog. – Brandon chegou animado para falar com Temperance naquela manhã no colégio. Ela estava em seu armário pegando seus livros para a aula.
<p>- E como não saber? O dono do blog mandou o link para o celular e o e-mail de todos os alunos da escola.
<p>- É sério? – Brandon ficou espantado. – Ele queria mesmo divulgação.
<p>- O infeliz parece revoltado. Parece que vai expor os segredos de todo mundo. Mal posso esperar para ler os podres do povo. – Temperance riu.
<p>- Não tem medo dele te atacar?
<p>- Não tenho nada a esconder. A não ser que ele comece a falar que eu canto no chuveiro.
<p>- Muito mal por sinal. – Brandon riu da amiga.
<p>- Cala essa boca. E quanto a você? Está com medo?
<p>- Não pode ficar pior do que já está sendo, então não estou me importando não.
<p>- Ainda está pensando nessas coisas? – Temperance revirou os olhos. – Adolescentes são idiotas, não deve levar a sério nada do que dizem.
<p>- Isso porque não estão falando de você.
<p>- Acha que nunca falaram mal de mim? Eu nem ligo.
<p>- Que bom para você, porque eu ligo. Eram meus amigos.
<p>- Parece que não eram. </p>
<center><h4>--*--</h4></center>
<p>Todo mundo esperava que o blogueiro postasse de hora em hora um segredo diferente para entreter todo mundo, mas isso não aconteceu. Ele ficou em silêncio o dia todo e a frustração tomou conta de todo mundo por terem se animado à toa.
<p>- Estou esperando ele falar mal dos atletas. É o que eu mais quero. – Brandon e Temperance estavam almoçando na cantina.
<p>- Eu quero que ele fale mal do Alan. – Temperance pensou bem e depois riu.
<p>- Alan?
<p>- Um garoto que está no meu pé desde ontem. Ele acha que um dia eu vou ficar com ele. – Temperance fez cara de nojo. – É um idiota que nem sabe escrever direito.
<p>- Você está solteira, por que não dá uma chance?
<p>- Porque ele é nojento. Ele estava limpando o nariz ontem no meio da aula. Não estou tão desesperada.
<p>- Não foi o que você me disse sábado à noite. – Brandon riu provocando a amiga.
<p>- Cala a boca. – Ela jogou uma batata frita na cara dele. – É diferente. É claro que eu quero um namorado, mas ele tem que ser o melhor.
<p>- Você é muito exigente.
<p>- Eu mereço o melhor.
<p>- Bom, os melhores têm que ficar com os melhores. – Brandon sorriu.
<p>- Hum, primeiro elogio do dia.
<p>- E último, porque eu tenho que ir. – Brandon se levantou da mesa bem rápido.
<p>- Mas já?
<p>- É, eu tenho um dever de casa para fazer antes da próxima aula, eu vou para a biblioteca.
<p>- Vou terminar de comer e te encontro lá.
<p>- Tudo bem. Até depois.
<p>Brandon se despediu de Temperance, pegou sua bandeja de comida e foi embora quase que correndo.
<p>Temperance não tinha muitos amigos além de Brandon e quando ele sumia ela era obrigada a ficar sozinha e não gostava muito de ficar comendo por ali sozinha. Principalmente naqueles dias.
<p>- Temperance, pode se levantar?
<p>Emily se aproximou da mesa. Temperance levou um susto, porque Emily não costumava falar com ela. Na verdade, as duas mal se olhavam. Era estranho Emily saber o nome dela.
<p>- Por que eu tenho que me levantar?
<p>- A Samantha quer sentar nessa mesa. – Emily estava séria, mas suas mãos estavam meio tremulas.
<p>- Tem outras mesas vazias. – Temperance não estava entendendo.
<p>- Mas ela quer se sentar nessa.
<p>- É alguma implicância comigo? Só porque eu não a ajudei com...
<p>- Olha, eu não quero saber de nada, eu não sei de nada. Você tem que se levantar, ela vai se sentar aqui.
<p>- Se ela quer que eu saia, ela que me tire. – Temperance encarou Emily.
<p>- Vai logo. – Emily sussurrou.
<p>- Não.
<p>Emily olhou para trás. Um grupo de garotas estava a observado. Temperance podia jurar que Samantha era uma das garotas que estavam nesse grupo.
<p>- Temperance, me desculpe.
<p>Dito isso, Emily empurrou a bandeja da garota no chão. O barulho do prato caindo contra o chão foi tão alto que o refeitório todo ficou em silêncio e olhou para Temperance e Emily para saber o que estava acontecendo entre elas.
<p>- Vai sair agora? – Emily estava nervosa.
<p>- Tudo bem. – Temperance se levantou. – Parabéns, Emily, se livrou de levar uma surra hoje. Fico muito feliz por você.
<p>Temperance pegou a bandeja do chão e foi embora sem olhar para trás.</p>
<br>
<p><i>“<b>E VOCÊS ACHANDO QUE EU SÓ ESTAVA FAZENDO BAGUNÇA.</b> Sabe como é difícil pesquisar coisas ruins por aqui? Bom, mas nada é impossível. Vamos ao que interessa. Vocês sabiam que tudo o que falam sobre Brandon Schmutz é verdade? Isso mesmo, amigo nota zero, ele merece mesmo ter tanta gente falando mal dele pelas costas, mas coitado, é direito dele também ter alguém para falar tudo na cara dele, para ver se ele acorda. Garoto, daqui a uns dias, todos vão começar a se drogar para ter que te aguentar. Por que você não morre?”.</i> – Tesouro dos Segredos Obscuros.</p>
<br>
<p>Brandon nunca gostou muito de ser o centro das atenções, por isso aquilo era o seu pior pesadelo. Ao sair da biblioteca, andar por aqueles corredores foi a pior coisa que ele poderia fazer, todos apontavam, cochichavam, e pior, riam dele.
<p>- Acredita que o blog postou sobre mim? – Brandon e Temperance estavam na aula de história.
<p>- Eu li, sinto muito.
<p>- Hei, Temperance! – Um garoto gritou do fundo da sala. – Bebeu quantas hoje para aguentar o Brandon no seu pé? – Todos começaram a rir.
<p>- Ignora eles. – Temperance olhou para Brandon. – Sabe que nada disso é verdade.
<p>Mas Brandon sabia que uma parte daquilo era verdade. Nos últimos dias, Brandon tinha percebido que seus amigos estavam estranhos com ele, a verdade é que todos andavam mesmo falando mal dele pelas costas. Ele não sabia o que nem por que, mas falavam e isso o magoava muito.</p>
<center><h4>--*--</h4></center>
<p>- Confesso que eu estava com medo. Jurava que esse tal de blogueiro ia começar a falar de mim.
<p>Samantha estava lendo o post do blog pelo celular no banheiro feminino. Emily estava ao seu lado vendo ela rir da desgraça de Brandon.
<p>- Acha que ele vai só falar do Brandon? – Emily limpava o canto dos olhos, parecia que tinha acabado de chorar.
<p>- Enquanto ele não falar de mim...
<p>- O que vai fazer se ele começar a falar?
<p>- Eu vou caçar ele, nem que tenha que ameaçar cada um dessa escola.
<p>- Nem todo mundo tem medo de você. – Emily falou baixinho.
<p>- Mas o blogueiro deve ter senão não estaria se escondendo, e você também tem, não é? – Samantha ouviu.
<p>- Eu... – Emily não sabia o que dizer.
<p>- Olha só, garota. – Samantha segurou firme o braço de Emily. A garota nem lutou, sabia que não conseguiria se soltar. – É bom mesmo ter medo de mim, porque você só está bem porque está sendo útil.
<p>- Como assim? – Emily estava quase chorando de novo.
<p>- No minuto que você não servir para nada, sua cabeça vai parar na privada, ouviu bem?
<p>Samantha jogou Emily no chão do banheiro e depois saiu de lá. Emily se lembrou da primeira e única vez que tentou lutar contra Samantha. É claro que ela levou a pior, Samantha tinha quase o dobro do tamanho dela e só o seu olhar já estremecia todo o corpo de Emily. Ela não podia lutar, a única coisa que ela podia fazer era aguentar.</p>
<center><h4>--*--</h4></center>
<p>Quando se tratava de briga, Jason se considerava o briguento número um. Naquele exato momento, ele e sua melhor amiga Lisa estavam sentados de frente a diretora na sala dela. Lisa parecia assustada, estava toda encolhida na cadeira e quase chorando, mas Jason estava calmo, não tinha sido a primeira vez que ele se sentava ali e nem seria a última, pensou ele.
<p>- O que aconteceu hoje foi muito grave. – A diretora pegou as fichas dos dois alunos que estavam na sua frente.
<p>- A gente sente muito. – Lisa logo falou.
<p>- Não tivemos culpa. – Jason olhou para a sua mão. Ainda estava segurando o pano cheio de sangue que ele usou para limpar a mão.
<p>- Ah, não tiveram? – A diretora encarou Jason para assustá-lo. Não deu certo.
<p>- Aquele imbecil estava perseguindo a Lisa.
<p>- Por que não chamaram a polícia? Você virou policial agora?
<p>- Eu falei com os meus pais. – Lisa achou melhor começar a falar. – Eles acharam que eu estava exagerando.
<p>- Ele podia fazer alguma coisa com ela. – Jason estava achando tudo aquilo uma injustiça. Ele estava certo. – A escola deveria ter percebido isso.
<p>- Você ficou com medo e pediu para o seu amigo te defender? – A diretora se dirigiu a Lisa.
<p>- Bom...
<p>- Ela não tem culpa de nada. – Jason falou logo. – Eu fui falar com ele e eu bati nele, ninguém me pediu, eu fiz porque eu quis.
<p>- Jason! – Lisa falou baixinho.
<p>- O garoto está na enfermaria. Ele pode te processar.
<p>- Pelo quê? O errado é ele. Não tenho culpa se ele é péssimo de briga.
<p>- Olha, a gente pede desculpas para ele. – Lisa não queria entrar em confusão.
<p>- Ela não tem nada a ver com isso. – Jason falou com a diretora. – Pode liberá-la.
<p>- Jason, não.
<p>A diretora mandou Lisa sair da sala e isso a deixou ainda mais nervosa. Ela queria muito saber qual tinha sido a punição de Jason e já estava se sentindo culpada por ele estar passando por isso por causa dela.
<p>Depois de alguns minutos, Jason saiu da sala da diretora. Lisa até ficou mais calma, ele não parecia muito atingido pela decisão da diretora, talvez nem tivesse sido castigado.
<p>- O que ela disse? – Lisa falou ansiosa.
<p>- Nada demais.
<p>- O que você vai ter que fazer? Ela te deu detenção?
<p>- Não.
<p>- Que ótimo. – Lisa comemorou. – Então deu tudo certo.
<p>- É, eu só fui expulso.
<p>- O quê? – Lisa não acreditou no que eu ouvi.
<p>- Relaxa, não é nada demais.
<p>- Como assim, não é nada demais? É tudo. Você...
<p>- Não pira, tá bom? Eu estou bem.
<p>- Mas... – Lisa ficou sem palavras, mas não estava conseguindo aceitar aquela decisão nem a reação do amigo.</p>
<center><h4>--*--</h4></center>
<p>- Você foi expulso?!
<p>Jason sabia que seu pai ia gritar quando ele desse a grande notícia por isso nem se assustou quando chegou em casa e ouviu os gritos.
<p>- Fui, coisas ruins acontecem com pessoas boas. Não sabemos por que. – Jason não ligou para a raiva do pai, já estava acostumado.
<p>- Querido, o que você fez? – Sua mãe entrou em desespero, ela andava de um lado para o outro na cozinha com a mão na testa.
<p>- Nada demais, eu só bati em um cara que estava perseguindo a Lisa.
<p>- O quê? – O desespero só aumentou.
<p>- Esse imbecil foi expulso porque bancou o herói! – Jason só observava seu pai ficando vermelho de raiva. – Conseguiu uma namorada pelo menos?
<p>- Quê? – Jason fingiu não ouvir.
<p>- E agora, o que a gente vai fazer?!
<p>- Existem outras escolas na cidade, não é tão grande coisa.
<p>- A diretora me ligou. – O pai explicou. – Ela me disse que os pais do garoto vão te processar, nenhuma escola vai te aceitar com um processo na sua ficha.
<p>- Não é o fim do mundo. – Jason não entendia a raiva do pai.
<p>- Você é um idiota!
<p>- Querido. – Jason começou a olhar para a sua mãe que começava a chorar. Ele odiava quando ela fazia isso. No que um choro iria adiantar naquela hora?
<p>- Não importa o quanto você me xingue, eu não me arrependo do que eu fiz. – Jason estava furioso, mas não gritou. Não era por respeito aos pais, mas sim porque não queria descer ao nível daquele homem que ele achava ridículo.
<p>- Você não se arrepende, porque é um inconsequente. Um garoto imbecil que não pensa no que faz.
<p>- Vai me xingar de mais o que? – Jason enfrentou o pai com o olhar.
<p>- Eu não vou te xingar de mais nada. O que eu deveria fazer era não me importar com o seu processo e deixar você ser preso.
<p>- Então deixa, eu não pedi para você me defender.
<p>Jason se afastou do pai e saiu de casa.
<p>- Jason, volta aqui, ainda não terminamos!
<p>Mas Jason já tinha batido a porta bem forte ao sair.</p>
<center><h4>--*--</h4></center>
<p>Lisa encontrou Jason andando pela rua. Isso foi bom, porque ela estava mesmo indo falar com ele. Estava muito preocupada.
<p>- O que foi?
<p>Jason era muito bom em guardar suas emoções para si mesmo, mas Lisa sempre sabia quando algo não estava bem.
<p>- Eu contei para o meu pai que eu fui expulso, ele ficou uma fera como sempre.
<p>- O que você vai fazer?
<p>- Bom, eu já perdi esse ano, mas tudo bem, eu não tinha planos para a formatura mesmo.
<p>- Você ainda pode entrar em outra escola para terminar o ano.
<p>- Nenhuma escola vai me aceitar, eu estou sendo processado e esses processos demoram. Relaxa, vamos nos formar juntos o ano que vem. – Jason sorriu.
<p>- Para de fingir que está tudo bem e falar que está tudo bem. Não está. – Lisa estava quase descontrolada. – Você bateu em um cara e foi expulso por minha causa.
<p>- A culpa não foi sua.
<p>- Se eu for falar com a diretora e dizer que eu pedi para você bater nele, talvez ela...
<p>- Mas isso não foi o que aconteceu e isso só vai piorar para você também, não vai me ajudar. Eu sou uma bomba relógio e resolvi explodir nele, foi isso que aconteceu.
<p>- Mas...
<p>- Mas nada. E se fosse para escolher, eu faria de novo. O cara é um imbecil e além do mais, ninguém mexe com a minha garota.
<p>- Não é justo. – Lisa abraçou Jason.
<p>- Olha, eu não estou com raiva por isso. Eu já entrei em muitas brigas, foi um milagre eu não ter sido expulso antes.
<p>- Por que está com raiva então?
<p>- Eu sei que é ridículo, mas eu esperava que ele pelo menos me entendesse e não me crucificasse. Mesmo que exagerada, eu fiz uma coisa boa.
<p>- Eu sinto muito pelo seu pai.
<p>- Ele é um babaca e minha mãe só sabe chorar.
<p>- Ainda bem que você não puxou a ele.
<p>- Somos mais parecidos do que pensa. – Jason respirou fundo. – Olha, quer saber, eu preciso relaxar.
<p>- Podemos ir ao cinema.
<p>- Ou podemos ir de carro até a montanha.
<p>- Para quê?
<p>- Ainda tem a chave do lugar onde seu pai guarda as bebidas?
<p>- Isso não vai acabar bem.
<p>- Eu já estou sendo processado, o que de pior pode acontecer?
<p>- Você ser preso.
<p>- É, também tem isso. Mas quem liga?
<p>- Eu ligo. – Lisa quase gritou.
<p>- Que bom, porque eu não. – Jason sorriu. – Vamos pegar as bebidas?</p>
<center><h4>--*--</h4></center>
<p>Jason e Lisa chegaram a tempo de poder ver o pôr do sol na montanha. Muitos casais iam lá, mas naquele dia estava vazio, talvez por ser no meio da semana e nem ser uma data comemorativa. A noite estava linda e muito quente.
<p>- Mesmo bravo, o seu pai te emprestou o carro?
<p>- Eu roubei o carro. Você não é a única mão leve. – Jason se sentou no chão sem se importar de ficar sujo de terra do lugar
<p>- Ele vai ficar doido. – Lisa havia colocado um pano no chão para ela se sentar ao lado de Jason.
<p>- Olha a minha cara de preocupação.
<p>Lisa percebeu que Jason já estava meio bêbado. Ele sempre tinha sido fraco para bebida.
<p>- Vai com calma, tá bom? Eu não quero você gritando no meio da rua.
<p>- Por que você não está bêbada?
<p>- Porque eu estou tomando suco. – Lisa mostrou seu copo para o Jason. – Alguém precisa dirigir de volta.
<p>- Olha ela toda responsável. – Jason começou a rir. – Nunca dirigiu bêbada?
<p>- Não na montanha. Imagine nós dois bêbados, eu ao invés de dar ré, pisar no acelerador. Vamos cair lá embaixo.
<p>- Iria ser uma morte épica. Digna de um filme de ação.
<p>- Você bêbado é muito bobo. – Lisa começou a rir.
<p>- E muito mais relaxado. – Jason não estava indo com calma, uma garrafa de uísque já estava vazia. – Posso te fazer uma pergunta?
<p>- Claro.
<p>- Por que você disse não?
<p>- O quê? – Lisa não entendeu a pergunta.
<p>- Quando nos conhecemos, eu fui até você e pedi um beijo. – Jason ficou mais perto de Lisa. – Por que você recusou?
<p>- Isso de novo?
<p>- Eu quero saber. Afinal, olha só para mim, eu sou incrível.
<p>- É, você é. – Lisa estava rindo. – Sei lá, você só não faz o meu tipo.
<p>- Você não gosta de caras lindos e maravilhosos? – Jason já estava falando meio mole.
<p>- Não se trata de beleza. Sei lá.
<p>- Sabe que se um dia se arrepender, eu vou estar aqui, não sabe?
<p>- Mesmo correndo o risco de estragar a nossa amizade?
<p>- Quem liga para a nossa amizade?
<p>- Eu ligo. – Lisa bateu no ombro de Jason.
<p>- É claro que eu também ligo, mas no minuto que você quiser, eu vou estar aqui esperando. – Jason se aproximou mais de Lisa.
<p>- Bom saber. – Lisa se afastou.
<p>Jason começou a rir e voltou a beber.
<p>- Você é um idiota, sabia? – Lisa revirou os olhos. – Por isso que todo mundo diz que você só fala comigo porque quer ficar comigo.
<p>- É engraçado fazer isso.
<p>- Me deixa constrangida.
<p>- Ah, qual é? Sou eu. Acha mesmo que eu ia ficar a fim de você depois de te ver com gripe?
<p>- Cala essa boca. – Lisa bateu nas costas dele.</p>
<center><h4>--*--</h4></center>
<p>As luzes da casa de Jason já estavam todas apagadas quando Lisa estacionou o carro em frente a ela.
<p>- Se você entrar em silêncio, ninguém vai acordar. – Lisa ajudou Jason a sair do carro.
<p>- Acho que quando eu entrar, eu vou dar um grito. Gosto de recepção. – Jason sussurrou.
<p>- Você gosta é de encrenca.
<p>- Isso também.
<p>- Querido, não precisa sussurrar agora. – Lisa começou a rir.
<p>- Sabe, Lisa. – Jason fez uma cara séria. – Aquelas bebidas estavam muito boas. – Jason começou a rir.
<p>- Eu imagino. – Lisa começou a guiar Jason até a porta da sua casa com um pouco de dificuldade. Ele era muito grande e pesado para ela empurrar.
<p>- Devagar, eu quase caí ali. -  Jason fingiu estar tropeçando.
<p>- Eu estou vendo. – Lisa segurava o riso. – Me dê as suas chaves. – Lisa abriu devagar a porta da frente depois que Jason entregou a ela as chaves. – Agora entra logo.
<p>- Não recebo nenhum beijo de boa noite?
<p>- Você até merece.
<p>- Eu mereço, não é?
<p>- Mas não vai acontecer isso hoje.
<p>- Eu sei porque não quer me beijar. – Jason segurou a mão de Lisa para ela não ir embora. – No minuto que me beijar, não vai conseguir parar.
<p>- É exatamente por isso. – Lisa sempre ouvia isso de Jason, já estava acostumada.
<p>- Qual é? É só um beijo, eu nem vou me lembrar amanhã.
<p>- Essa teoria seria válida se você estivesse bêbado de verdade. – Lisa empurrou Jason na parede e começou a rir.
<p>- O que me entregou? – Jason começou a rir.
<p>- Ah, o efeito forçado? O lugar molhado onde você jogava a bebida?
<p>- Pela minha defesa, eu tomei o primeiro e o último copo.
<p>- Eu devia ter jogado a garrafa na sua cabeça. Tentou abusar de mim.
<p>- Nossa, que exagero. Eu só estava curtindo com a sua cara. Eu amo fazer isso.
<p>- Olha, entre logo em casa antes que eu te dê um tapa na sua cara.
<p>- Sabe, Lisa. – Jason ficou sério. – Essa noite foi incrível, me fez relaxar de verdade, mesmo eu não ficando bêbado realmente.
<p>- Mas eu ainda...
<p>- Não quero que se culpe. Meu dever é te proteger, é para isso que serve os amigos. Eu nunca me perdoaria se ele fizesse algo com você.
<p>- Eu sei.
<p>- Então relaxa, eu sei lidar com as consequências.
<p>- Você disse que nenhuma escola da cidade vai te aceitar
<p>- O país tem várias cidades.
<p>- Vai para outra cidade? Porque eu...
<p>- Eu vou dar um jeito. Sou mais forte do que você pensa.
<p>- Eu já vi você brigar, vai por mim, eu sei o quanto você é forte.
<p>Lisa o abraçou.
<p>- Que bom que eu tenho você. – Ela falou.
<p>- Que bom que gosta, porque eu não vou a lugar nenhum. – Jason sorriu para Lisa.</p>
<center><h4>--*--</h4></center>
<p>Jason levou Lisa para casa e depois voltou para a sua. Ele não esperava que alguém estivesse acordado, mas estava errado.
<p>- Achei que só voltaria amanhã.
<p>Antes mesmo dele acender a luz da cozinha, seu pai apareceu no meio do escuro.
<p>- Minha vontade era de não voltar nunca.
<p>- E voltou por que? – Seu pai falou em tom de deboche.
<p>- Não se preocupe, quando eu começar a trabalhar e...
<p>- Vai trabalhar de quê? O que você sabe fazer além de entrar em problemas?
<p>- Você não sabe de nada.
<p>- Ah, eu não sei? Eu sei de muitas coisas como por exemplo, o quanto você é mal-agradecido.
<p>- Eu sol mal-agradecido? – Jason poderia rir senão estivesse tão indignado.
<p>- Eu te dei tudo. Um teto, comida, dinheiro para você gastar com garotas mais vazias que você e você...
<p>- Tem razão. Você é um ótimo pai e eu sou um idiota.
<p>- Onde você estava?
<p>- Eu estava bebendo. – Jason desafiou o pai.
<p>- Olha, é assim que se começa. Agora só posso torcer para um dia entrar no seu quarto e encontrar você tendo uma overdose.
<p>- Bom, para aguentar você, só com drogas mesmo.
<p>Jason saiu da cozinha, subiu as escadas e se trancou no seu quarto. Como ele queria ir para bem longe daquele homem.</p>
<center><h4>--*--</h4></center>
<p>Brandon estava trancado no seu quarto.
<p>Aquele dia foi pior do que ele esperava, mas ainda teve algo bom. Ele estava decidindo o que escreveria para o post do dia seguinte. Bom, conteúdo é o que não faltava.
<p>Estava todo mundo querendo saber quem era o blogueiro, mas Brandon sabia que a identidade dele nunca seria revelada, até porque todo mundo queria saber até onde o indivíduo chegaria. Brandon sabia que não podia ter limites, afinal ninguém merecia misericórdia naquela escola a não ser Temperance. Ele, na verdade, já tinha concluído que não escreveria sobre ela.
<p>Como aquele blog afetaria as pessoas? Bom, Brandon queria descobrir. Ele estava cansado de confiar na pessoa errada, de ser e ver vítimas de bullying, de valentões sempre se dando bem. Aquele blog acabaria com aquilo. Ele faria o que nunca teve coragem de fazer pessoalmente: lutar contra os outros.
<p>- <i>“Bom dia, pessoas. Estão prontos para descobrir a verdade de um amigo de vocês hoje? Vocês sabiam que todo mundo dessa escola está ajudando a sustentar o vício em heroína do Jefferson? Isso mesmo, o dinheirinho que ele rouba de vocês todo dia no almoço, ele dá tudo para o seu traficante pessoal, que vergonha. Se eu fosse vocês, evitaria isso, não queremos uma overdose nas nossas consciências. Ou vocês, sei lá, poderiam começar a comprar drogas também para encarar os chatos da escola, afinal, o nosso querido Brandon ainda está entre nós, não é?”.</i>
<p>Brandon voltou a ler cada palavra umas duas vezes para ver se o texto tinha ficado bom. Se tudo desse certo, Jefferson não ia roubar de mais ninguém, muito menos dele. Alguém pode descobrir que é você. – Uma voz na cabeça dele dizia isso o tempo todo. Ele esconderia isso de Temperance para sempre? Ela iria odiá-lo se descobrisse. Mas ele não podia contar para ela, ela não iria entender. Além do mais, ele a ajudaria também, aquela Samantha seria a próxima da lista dele. Ele seria um benfeitor, não teria consequências.
<p>- “Tesouro dos Segredos Obscuros.”. – Brandon terminou de digitar e depois postou.
<p>Estava tudo muito bom, Brandon finalmente tinha um propósito, mas o que ele não sabia é que isso teria sim consequências. E foi a pior.
<p>Como Brandon, um blogueiro que ajudava todo mundo acabou virando um fofoqueiro que causava intriga? Isso, nem ele sabia mais. Aquilo tinha tomado conta dele.
<p>Acontece que o plano inicial não tinha dado certo. Com o blogueiro falando mal de Brandon, todo mundo se afastou dele, ninguém se aproximou com uma mão para ajudar ou palavras legais além de Temperance que sempre vinha com o mesmo discurso de “não ligue para isso”. A raiva tomou conta do garoto, já que ele criou aquele blog exatamente para ferir aquelas pessoas que falavam mal dele e ele que acabou sendo ferido. De repente, aquela raiva virou ódio com todo mundo.
<p>Brandon nunca teve a experiência de ficar isolado um dia todo naquela escola até o dia em que Temperance precisou faltar na aula. Aquele dia foi o pior dia da vida dele. “Os amigos” que ele tinha, mal olhavam na cara dele e o falatório continuava. Não era só os valentões que mereciam ser expostos, todos tinham o mal e todos precisavam pagar tendo seus segredos revelados e sendo julgados por quem eles realmente eram.
<p>Dois anos depois, naquele quarto, Brandon não tinha mais raiva. Não tinha mais nada. Só tinha a dor de ter perdido de novo todos os amigos. A vida tinha dado uma segunda chance quando Lisa e Jason surgiram, mas ele estragou tudo de novo, e terceiras chances não existiam.
<p>Agora ele não tinha mais raiva nem dor. Estava em paz.</p>
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
            if (condicao + 1 > 25)
            {
                Navigation.PushModalAsync(new Capitulo6Page(condicao + 1));
            }
            else
            {
                Navigation.PushModalAsync(new Capitulo5Page(condicao + 1));
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