using InsoniaLiteraria04.Database;
using InsoniaLiteraria04.Global;
using InsoniaLiteraria04.Helper;
using InsoniaLiteraria04.Model;
using Rg.Plugins.Popup.Services;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InsoniaLiteraria04.EsseMundoView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Capitulo2Page : ContentPage
	{
        public int condicao;
        DBFire service;

        public Capitulo2Page (int numero)
		{
			InitializeComponent ();
            service = new DBFire();
            condicao = numero;
            mostrarCapituloSalvo("EsseMundoVaiMudar", "Capitulo" + numero.ToString());

            if (numero == 7)
            {
                lblTitulo.Text = "Capítulo 7 - Você Não Pode Se Esconder de Seus Fantasmas";
                htmlPage.Html = @"<html>
<body>
<p><i>“Porque é um novo dia, vamos ir para longe
<br>Juntar tudo, cortar e sacudir o peso morto
<br>Você sabe o que dizem
<br>Não se pode se esconder de seus fantasmas”
<br><b>Ghost – American Authors</b></i></p>
<br>
<p>“Passado. Muitas frases envolvendo essa palavra causam uma sensação estranha para o ser humano. Não se pode mudar o passado. Um dia o passado volta para te pegar. Fugir do passado é inútil. E tantas outras. É verdade quando dizem isso, o passado sempre volta à tona, quer você queira ou não. Mas as pessoas mudam, será que é certo julgar alguém por suas ações de anos atrás? Eu não sabia nem entendia coisas que eu sei hoje, isso é normal. Pessoas crescem, evoluem, mudam. Mas será que todas são assim? Eu acho que não.”.</p>
<br>
<p>Will foi até a cozinha pegar um copo de água quando chegou em casa depois de levar Emily de volta para sua casa. Sua mãe o esperava sentada em uma das cadeiras perto do balcão.
<p>- Você parece muito feliz.
<p>- Eu estou, mãe.
<p>- Acho que ela é especial, você nunca trouxe ninguém aqui em casa.
<p>- Isso não é verdade. – Will riu sem graça.
<p>- Giovanna não conta. Conhecíamos ela bem antes de começarem a namorar.
<p>- Bom, então é verdade.
<p>- Por que a trouxe? – Will não soube se era uma pergunta retórica.
<p>- Como assim? Não queria que eu a trouxesse?
<p>- Não, querido, não é isso. É que eu gostaria de saber o que você está sentindo.
<p>- Eu estou me sentindo bem. 
<p>- Nossa, é difícil conversar sobre isso com você, sabia? Ela é a razão para você sair cedo e animado para ir à escola?
<p>- Pode ser.
<p>- Como ela é?
<p>- Você sabe como ela é. Ela esteve aqui não faz nem vinte e quatro horas. 
<p>- Eu não quero saber fisicamente. Eu estou perguntando como você a vê.
<p>- Ela me deixa seguro e ao mesmo tempo muito nervoso. Acho que essa é a melhor definição, mas ela é perfeita.
<p>- E como está na escola?
<p>- Minhas notas? – Ele franziu a testa.
<p>- Filho.
<p>- Estão pegando um pouco no nosso pé. Acho que por causa da história com a Giovanna e tudo mais.
<p>- E já contou para Emily sobre isso?
<p>- Ainda não, mas eu quero.
<p>- Talvez devesse contar logo. Antes que fique tudo muito mais sério.
<p>- Tem razão.
<p>- Eu sempre tenho.
<p>Karen se aproximou do filho, deu a ele um beijo de boa noite e saiu da cozinha. Aquela conversa deu algo para Will pensar. Até então, ele e Emily haviam sido muito sinceros um com o outro, claro que ainda havia muitas coisas que eles não sabiam um do outro, mas... Will passou a noite simulando situações de Emily descobrindo o que aconteceu e na visão dele, em nenhuma das vezes aquilo acabava bem.</p>
<center><h4>--*--</h4></center>
<p>- Acha que ela tem razão? Que eu devo contar para a Emily logo?
<p>Quando estava confuso ou nervoso, Will sempre pedia conselhos para Jason e Sebastian. E essas conversas sempre aconteciam em uma pequena quadra pública e quase abandonada no quarteirão onde eles passavam quase toda tarde arremessando uma bola de futebol americano um para o outro.
<p>- Eu acho que sim. – A resposta de Jason era a óbvia. Will já esperava por isso.
<p>- Eu acho que não. – Sebastian quase sempre discordava.
<p>- Por que não? 
<p>- Você sabe o porquê. – Sebastian falou logo. – Esse negócio de contar sobre o seu passado... Nunca dá certo. Quando eu conto para as pessoas sobre o meu passado, elas geralmente vão embora.
<p>- Mas o lance do Will é diferente. – Jason comentou. – Sem falar que sabemos sobre o seu passado e estamos aqui. Contar a verdade é sempre a melhor escolha.
<p>- Vocês são uma exceção.
<p>- Emily pode ser uma exceção. – Will falou.
<p>- Pode ser, mas também não pode. Você mesmo disse que ela é toda certinha e tal. Pode fazer um caso maior do que realmente é. 
<p>- Sebastian tem um ponto. – Will olhou para Jason.
<p>- Então você não vai contar? – Jason já fez cara feia.
<p>- Não sei. Por um lado, eu quero contar e ser sincero com ela, mas por outro lado, se eu contar, posso estragar tudo.
<p>- Talvez seja melhor mesmo você contar. – Sebastian mudou de opinião.
<p>- Como assim? – Will franziu a testa.
<p>- Todo mundo sabe o que aconteceu. Em alguma hora, Emily vai ouvir de alguém e vai ser bem pior. Pode até mesmo ouvir da Giovanna. Ela já tentou dizer que você não presta para Emily e você mesmo disse que ela está uma fera. É só ligar os pontos.
<p>- Concordo. – Jason falou.
<p>- Agora vocês concordam um com o outro?
<p>- Você deve contar porque é a coisa certa a se fazer. – Jason alertou.
<p>- Olha quem fala, você já mentiu para uma garota dizendo que seu pai estava viajando a negócios.
<p>- Ninguém gosta de dizer que foi deixado pelo pai.
<p>- Ou que é viciado. – Sebastian completou.
<p>- Eu não devia ter pedido a opinião de vocês.</p>
<center><h4>--*--</h4></center>
<p>Quando Will encontrou Emily no corredor da escola logo na segunda-feira de manhã, ele estava determinado a contar para ela, mas quando a viu colocou na cabeça que não poderia fazer aquilo naquele momento. Na verdade, foi só uma desculpa para esperar mais um pouco.
<p>- Oi, tudo bem? – Will a beijou.
<p>- Tudo. Eu só queria dizer que eu conheci seus pais e não fugi.
<p>- É o seu jeito de dizer que agora é a minha vez?
<p>- Minha mãe está ansiosa. – Ela sorriu. – Meu pai nem tanto.
<p>- Ele vai gostar de mim quando me conhecer melhor. Eu sou adorável.
<p>- É, você é um pouco mesmo.
<p>- E se ele não gostar?
<p>- Não interessa. Eu gosto.
<p>- É o mínimo que eu posso pedir. – Ele brincou. – Que tal hoje à noite?
<p>- Nossa, você é mesmo valente.
<p>- O que você chama de valente, eu chamo de doido.
<p>Ela começou a rir.</p>
<center><h4>--*--</h4></center>
<p>- Quer dizer que ela vai te levar para conhecer os pais? – Amanda e Will estavam no pátio esperando a aula começar.
<p>- Qual é o problema? Ela conheceu os nossos.
<p>- É. Vocês estão namorando. – Amanda fez gracinha. – Entretanto, o Sebastian me disse que você está com alguns problemas.
<p>- Aquele linguarudo.
<p>- Ele só me disse porque queria uma terceira opinião. 
<p>- O que tem a dizer então?
<p>- Você deve contar. 
<p>- Sério?
<p>- Se fosse comigo, eu ia gostar de saber. E ela vai descobrir de qualquer jeito, melhor que seja por você.
<p>- Mas ela é tão diferente, tão correta e...
<p>- Se ela gostar mesmo de você, vai entender. Até porque já faz tanto tempo.
<p>- É que se eu estivesse no lugar dela, eu não entenderia. Foi muito ruim.
<p>- Você fala isso porque se culpa demais. E porque é muito dramático, nem é grande coisa.
<p>- Amanda.
<p>- Só sei que ficar com essa dúvida não vai ser bom. É melhor contar agora no começo, e se isso acabar de um jeito ruim, pelo menos você não se apegou tanto. 
<p>- Eu estou com medo.
<p>- Você já se apegou, não é? – Amanda riu. – O que essa Emily tem, hein?
<p>- Ela é a Emily. Eu não sei.
<center><h4>--*--</h4></center>
<p>- Minha mãe está nervosa com o que fazer no jantar. – Emily e Will estavam almoçando juntos.
<p>- Por quê?
<p>- Não me diga que esqueceu?
<p>- Ah, claro. A gente combinou de ir lá hoje à noite. Foi mal. – Ele franziu um pouco a testa. Era outro sinal.
<p>- Está tudo bem? – Emily percebeu que havia alguma coisa errada.
<p>- Está sim, é que eu tive uma prova e estava bem difícil.
<p>- E desde quando você se preocupa com provas?
<p>- É que essa foi diferente
<p>- Sabe que pode me contar o que quiser, não sabe?
<p>- Eu estou bem, é sério.
<p>- Tudo bem, se você quiser, podemos marcar outro dia.
<p>- Que tal a gente sair sozinho hoje e ir amanhã ver seus pais? Daria mais tempo para a sua mãe pensar no jantar. – Will sorriu para tentar disfarçar a tensão.
<p>- Aonde pensa em me levar?
<p>- Você sabia que o terraço do prédio da gravadora que meu pai trabalha é um ótimo lugar para se ver o sol se pondo?
<p>- Não, eu nunca fui lá.
<p>- Te pego às cinco?
<p>- Combinado.
<p>- Ah, e fala para a sua mãe que eu não tenho frescura, ela pode fazer qualquer coisa que eu vou comer duas vezes ou mais.
<p>- Bom saber.</p>
<center><h4>--*--</h4></center>
<p>Emily estava guardando seus livros no armário para ir embora da escola quando foi abordada por Giovanna. Ela parecia nervosa.
<p>- Ainda está saindo com o Will? – A voz de Giovanna estava firme.
<p>- Bom dia para você também. 
<p>- Eu não estou para brincadeira. Responde à pergunta.
<p>- Você é amiga dele, pergunte a ele. Se bem que amiga é um termo bem relativo. – Emily fez pouco caso da garota.
<p>- Como assim?
<p>- Na minha primeira semana aqui, você se aproximou com a sua amiga Ashley e disse que o Will não prestava. Imagina a minha surpresa quando encontrei vocês duas sentadas naquela mesa de bar no outro dia agindo como se todos fossem amigos. 
<p>- Por que não me dedurou então?
<p>- Porque você não me interessa. Tem uma coisa engraçada chamada primeira impressão. A sua foi péssima. 
<p>- Você não acreditou em mim. 
<p>- Eu geralmente não acredito em pessoas sem nome que querem criar um boato de mal gosto e sem fundamento nenhum. 
<p>- Há quanto tempo você conhece o Will? Dois meses?
<p>- Não te interessa. – Emily também já estava perdendo a paciência.
<p>- Eu conheço ele há sete anos. Eu sei tudo sobre ele. 
<p>- Isso não é uma competição. 
<p>- Ele já foi meu namorado. 
<p>Emily tentou disfarçar a sua expressão de surpresa. 
<p>- Quer saber por que a gente terminou?
<p>- Foi você que espalhou aquela foto, não foi? – Como uma luz acendendo, de repente tudo fez sentido para Emily.
<p>- Não. De verdade. Eu também me surpreendi quando vi. Quer um conselho?
<p>- Não.
<p>- Não confie nele. Ele me traiu. A escola toda soube, foi humilhante. Ele é um canalha. 
<p>- E por que você ainda se importa? Eu não sou idiota, eu sei que você não está aqui para me ajudar. Você só quer que eu me afaste dele para você ter uma segunda chance. Quer ser traída de novo? Por quê?
<p>- Cala a boca.
<p>- Você que veio conversar comigo. Só queria falar e não ouvir? Olha, eu não dou a mínima para o seu namoro fracassado e muito menos para você. Eu não vou duvidar do meu namorado por causa de uma ex frustrada.
<p>- Não diga que eu não avisei.
<p>- Não vou. Até porque se eu acabar magoada, não vai ser com você que eu vou conversar. – Emily fechou a porta do seu armário e saiu andando.</p>
<center><h4>--*--</h4></center>
<p>- Por que adiou conhecer os pais da Emily hoje? – Jason e Will estavam voltando para casa depois da escola fazendo o caminho de sempre.
<p>- A Amanda tem razão. Eu preciso contar tudo antes que fique muito sério.
<p>- Eu também te disse quase isso, por que só a Amanda tem razão? – Jason fez cara feia. – Como vai contar?
<p>- Vou tentar deixar o encontro mais romântico possível e então...
<p>- Vai jogar uma bomba em cima dela. 
<p>- Bom, se esse for o nosso último encontro, pelo menos que seja bom.
<p>- Então só vai contar no final da noite? – Jason não estava gostando dessa ideia.
<p>- A ideia é essa.
<p>- Olha, ainda tem uma grande chance de ela não ligar para isso. 
<p>- Na verdade, quanto mais eu penso, mais essa chance diminui. Eu já disse tantas coisas para ela que, sei lá, ela deve me achar um príncipe encantado. 
<p>- Nossa, meio egocêntrico da sua parte. – Jason riu. 
<p>- Sempre quando eu vejo a Giovanna, eu digo para mim mesmo que o que eu fiz não foi tão ruim quanto parece e que a culpa não foi só minha. Só assim eu consigo encará-la e falar com ela. O que eu vou ter que dizer quando eu contar a verdade para Emily? Que eu não vou fazer isso com ela? Que eu mudei? Que eu não sou mais assim? Ninguém acredita nessas coisas. 
<p>- Olha, eu não sei bem o que dizer. Mas às vezes, a gente desperta o melhor das pessoas. Todos nós temos defeitos e mais defeitos, mas não é isso que afasta ou termina relacionamentos. 
<p>- O que é então?
<p>- É quando a gente desiste de fazer por onde. É quando a gente cansa de tentar. É quando não vale mais a pena. 
<p>- Ela é só uma garota, não é? Não é o fim do mundo. 
<p>- Tudo depende do ponto de vista.</p>
<center><h4>--*--</h4></center>
<p>A hora chegou mais rápido do que Will gostaria, mas mesmo assim ele não se atrasou. Às cinco horas ele estava em frente à casa de Emily tentando torcer pelo melhor, mais nervoso do que antes. Quando ele a viu saindo de casa, por alguma razão, ficou mais calmo. Ela não vestia nenhuma veste de evento de premiação famosa, mas mesmo assim, aos olhos dele, continuava maravilhosa. Ela sorriu, ele pegou na sua mão e foram andando.
<p>O prédio já estava vazio quando chegaram. O expediente já tinha acabado, só havia os seguranças na portaria.
<p>- Todo mundo sai às quatro e meia. – Will informou para Emily quando entraram. Pela sua cara, ela estava estranhando não ter mais ninguém por ali.
<p>- Você pode entrar aqui a qualquer hora?
<p>- Não, mas meu pai pode. Tudo o que eu precisava era de um cartão. – Ele mostrou para a namorada um cartão magnético com a foto e o nome de seu pai.
<p>Seguiram pelo hall de entrada da gravadora e foram direto para o elevador com Will guiando o tempo todo. Quando o elevador começou a subir, ele sentiu um frio na barriga e se calou um pouco. Emily percebeu que havia algo errado e então o olhou como se estivesse preocupada. Ele desviou o olhar e mirou para o painel de controle onde mostrava o andar que o elevador estava.
<p>2º andar... 3º andar... Will olhava para aqueles números esperando por um sinal... 4º andar... 5º andar... Um sinal de que ele estava fazendo a coisa certa, de que tudo ia dar certo no final... 6º andar... 7º andar...
<p>Então o elevador parou. Will não percebeu logo de cara, seus devaneios momentâneos não permitiram.
<p>- O que está acontecendo? – Emily olhou para os botões do painel. – Por paramos?
<p>- Eu... não sei. Não fazia parte do plano. – Will começou a apertar o botão para abrir a porta, mas nada aconteceu.
<p>- Eu não acredito que estamos presos aqui.
<p>- Você não é claustrofóbica, é? – Will começou a entrar em pânico.
<p>- Não, mas não quer dizer que eu goste de ficar presa em um elevador. – Ela apertava o botão de emergência sem parar. – O que a gente faz agora?
<p>- É só chamar os seguranças. – Will, mais calmo, pegou o telefone que estava pregado em uma das paredes do elevador, mas estava sem linha.
<p>Então a luz apagou.
<p>- É sério? – Will olhou para o teto na esperança de ver Deus rindo da cara dele. – A energia do prédio deve ter acabado. Aqui tem gerador, deve voltar em alguns minutos.
<p>- O que a gente faz até lá?
<p>- Esperamos. – Will se sentou no chão. Pegou seu celular e ligou a lanterna. Conseguiu ver o rosto de Emily bem preocupado. – Desculpa, ficar preso no elevador não era a minha ideia de encontro. – Ele sorriu.
<p>- Tudo bem. – Emily se sentou de frente dele. – Só que vai ficar um pouco quente aqui a qualquer momento.
<p>- É, eu estou sem respirar. – Will fingiu ficar sem ar.
<p>- Quer parar de brincar? – Emily riu. – O que tem lá em cima? Além do pôr do sol que a gente vai perder.
<p>- Eu comprei comida. Tem uma mesa com velas. O primeiro encontro romântico que a gente nunca teve.
<p>- Devia ter deixado a comida no elevador. Por garantia. – Ela brincou.
<p>- Vou pensar nisso na próxima vez.
<p>- O quê? Eu não entro com você em outro elevador. Vou de escada. 
<p>- Eu tenho a maldição dos elevadores agora?
<p>- Pode ser, vai saber. 
<p>- A gente precisa fazer alguma coisa para passar o tempo. Será que aqui tem câmeras de emergência? Seria meio desconfortável nosso vídeo vazar. 
<p>- Cala a boca. – Os dois soltaram gargalhadas. – Posso te fazer uma pergunta?
<p>- Até duas.
<p>- Você e a Giovanna já namoraram?
<p>A expressão de descontração de Will mudou na hora.
<p>- Quem te disse isso?
<p>- Importa?
<p>- A gente já namorou. Já faz um tempo.
<p>- E por que não me disse?
<p>- Eu ia te contar. É que...
<p>- Will, eu não ligo para as outras com quem você namorou. Eu não sou esse tipo de garota. É que você é amigo dela, eu só gostaria de... saber. 
<p>- Ela falou com você, não falou?
<p>- Falou. 
<p>- Não era assim que eu queria te contar. 
<p>- Tudo bem.
<p>- Não, não só isso. Emily, eu não sou a melhor pessoa do mundo. Eu... às vezes exagero e faço coisas que me arrependo depois.
<p>- Todo mundo faz isso, Will. É normal.
<p>- É, só que o normal não quer dizer que é o certo. Me desculpa.
<p>- Pelo quê? – Emily se sentou mais perto dele.
<p>- Por isso.</p>
</body>
</html>";
            }

            if (numero == 8)
            {
                lblTitulo.Text = "Capítulo 8 - Príncipe Nada Encantado";
                htmlPage.Html = @"<html>
<body>
<p><i>“Se as paredes pudessem falar
<br>Eu seria o príncipe nada encantado
<br>E isso está te enlouquecendo, amor.”
<br><b>Prince Of Nothing Charming – Tyler Hilton</b></i></p>
<br>
<p>“Um ano atrás, eu achava que tinha tudo. Eu era praticamente o cara mais popular da escola, e quem não gostaria de ser popular, não é mesmo? Principalmente no colegial onde tudo gira em torno da popularidade. E eu tinha uma namorada. Era estranho como esse namoro funcionava, às vezes parecia que não, pelo menos para mim, mas para a Giovanna, estava tudo bem, estava tudo tão bem que eu até me assustava às vezes. Minha vida era boa. Eu tinha muitos amigos, não que eu não tenha amigos agora, mas é engraçado como pessoas desaparecem da sua vida de uma hora para outra.
<p>Eu conheço a Giovanna há muito tempo e eu sempre senti que ela queria mais do que só a minha amizade. Eu não me lembro exatamente de como tudo aconteceu, eu só lembro que um dia, a gente saiu junto e acabou rolando. Não vou dizer que o tempo que ficamos juntos foi ruim, na verdade até que foi bom. A gente se divertia muito e nos dávamos muito bem talvez porque a gente tinha sido amigo antes então nos conhecíamos bem, mas ainda assim existiam as brigas e elas às vezes saíam um pouco do controle de nós dois.
<p>O problema era o ciúme. Era sempre o ciúme. Eu não podia conversar com outra pessoa que ela se irritava. Ela sempre queria ser a minha primeira opção em tudo. Eu sempre ouvia coisas da minha irmã do tipo: “ela é maluca” e no final sempre acabávamos tendo a mesma conversa.”.</p>
<br>
<p>- Eu não acredito que você ainda está com ela. – Amanda sempre vinha com esse papo. – Isso só pode ser um problema psicológico seu masoquista, porque eu não consigo entender.
<p>- Eu gosto dela. – Will sempre respondia isso.
<p>- Não pode gostar.
<p>- Você não pode dizer isso. – Will riu.
<p>- Vocês não são saudáveis um para o outro. Quer dizer, que se dane ela, ela não é saudável para você. Ela só te leva para baixo.
<p>- Não diz isso.
<p>- É a verdade. Vocês vivem gritando um com outro e dando um tempo e eu sempre tenho vontade de dar na sua cara. Aparentemente, ela não é saudável nem para mim. 
<p>- Você nunca gostou dela, esse é o seu problema.
<p>- Não é nada. Meu problema é ela ser uma cobra. Não gosta de ninguém a não ser de você. Acho que nem dela ela gosta.
<p>- Eu poderia dizer que você está com ciúmes de irmã. Isso é normal. – Will brincou para deixar a irmã com mais raiva.
<p>- Você sabe que não é isso. Até porque... você não está feliz, está?
<p>- Eu estou sim. Na maior parte do tempo.
<p>- Dormir com ela é tão bom assim que compensa todas as outras coisas ruins?
<p>- Eu não vou falar disso com você. – Will revirou os olhos.
<p>- Você a ama?
<p>- O quê? – Amanda pegou Will de surpresa.
<p>- Perguntei se você a ama.
<p>- Eu não sei. Não é uma coisa que dá para saber assim tão rápido.
<p>- Vocês já estão juntos há bastante tempo. Dá sim pra saber.
<p>- Bom, ela diz que me ama. O tempo todo, na verdade. É bom ouvir e aparentemente ela gosta de falar isso.
<p>- Você está se escutando? É ridículo. Você não namora alguém só porque gosta de ouvir ela dizer que te ama. Você namora alguém para...
<p>- Somos adolescente, Amanda. É só um namoro bobo, é só isso.
<p>- Empurrar com a barriga não é uma opção boa. Na verdade, é um desrespeito. 
<p>No final da conversa, Amanda sempre saia bufando, pisando firme.</p>
<center><h4>--*--</h4></center>
<p>“Amanda sempre me perguntava se eu amava a Giovanna e eu nunca soube o que dizer. Giovanna sempre me dizia que me amava, mas por algum motivo, eu não conseguia retribuir com sinceridade. Eu gostava e me importava muito com ela, mas não chegava a ser amor. Quer dizer, amor não podia ser daquele jeito, porque se fosse, ia ser um sentimento bem superestimado. 
<p>Naquela época, eu ia até a gruta toda noite, me sentava em uma das pedras com o meu violão no colo e começava a compor músicas. Giovana nunca soube desse meu lance com a música e além do mais, não tinha o porquê de ela saber. Ela não ligava para isso. Ela tinha um plano todo na cabeça de como a nossa vida seria depois do ensino médio.”.</p>
<br>
<p>- Eu sei que você vai me odiar por isso, mas a Amanda tem razão.
<p>Se havia alguém que pegasse no pé de Will mais que Amanda, esse alguém era Jason, e Sebastian vinha logo atrás dele. Mais de uma vez, enquanto estavam arremessando a bola um para o outro em uma quadra abandonada no quarteirão, os amigos de Will falavam a mesma coisa.
<p>- Eu só queria entender porque vocês não gostam que eu fique com ela.
<p>- Porque ninguém merece ficar com a Giovanna – Sebastian ria enquanto arremessava a bola para mim.
<p>- Vocês exageram demais. Eu estou bem com ela.
<p>- Se você diz, não é? – Jason chegou até a rir.
<p>- Olha, eu não tenho nada a perder. Estamos juntos e está bem por agora. Não é como se eu fosse me casar a qualquer momento.
<p>- Ela acha que você vai pedir ela em casamento a qualquer momento. Eu já ouvi ela falando sobre isso com a Ashley. – Sebastian continuava rindo.
<p>- Isso não é verdade.
<p>- Will, vocês não estão na mesma página. – Jason não conseguia não levar aquilo à sério. – Vocês não sentem a mesma coisa e isso nunca vai dar certo. Vocês brigam o tempo todo e ela vive fazendo joguinhos emocionais e chantagens só para te convencer.
<p>- Eu não sou idiota, está bem? Eu estou com ela porque eu quero, não porque ela está me manipulando. – Will ficou bravo.
<p>- Chega a ser engraçado o jeito como você está acomodado com isso. – Sebastian não entendia.
<p>- Ela nunca fez nada que me fizesse pensar em terminar com ela.
<p>- A verdade é que vocês estão juntos, mas isso não significa nada para você. É triste. O pior é que ela também pode se magoar muito. – Sebastian parou de rir.
<p>- Ela me ama, deveria ser o suficiente.
<p>- Mas você não. – Jason continuou. – Você não sente nada por ela a não ser afeto, e isso não vai mudar. E tudo bem, você não pode escolher amar uma pessoa. O sentimento simplesmente vem. 
<p>- Como sabe? Você nunca teve uma namorada. – Will costumava atacar as pessoas quando começava a se sentir incomodado e na defensiva. – Me desculpa, foi sem querer.
<p>- Tudo bem. – Mas Jason se calou e só focou nos arremessos.</p>
<center><h4>--*--</h4></center>
<p>“Toda quinta-feira, Giovanna gostava que almoçássemos juntos. Era meio que uma tradição, porque ela dizia que foi em uma quinta-feira que nos conhecemos ou alguma coisa assim. Se eu esquecesse ou tivesse que fazer algo na hora, ela ficava uma fera. No começo era até legal, ter uma coisa só nossa, mas depois de um tempo, eu comecei a ir só por obrigação e... na parte da conversa, ela tinha que fazer todo o trabalho.”.</p>
<br>
<p>- Eu estava pensando que a gente podia sair no sábado. – Giovanna vivia com uma agenda anotando sempre alguma coisa.
<p>- No sábado não vai dar. – Will respondeu sem rodeios.
<p>- Por que não? – Ela arregalou os olhos.
<p>- Domingo é aniversario do Seb. A gente sempre comemora junto com o Jason primeiro para depois fazer a festa no dia seguinte. Você sabe disso, fazemos todo ano.
<p>- Ah, mas você tem uma namorada agora. Deixa o Sebastian comemorar com o Jason e você deseja felicidades para ele no dia seguinte.
<p>- O Sebastian é meu irmão, isso não mudou só porque eu tenho uma namorada. Eu não vou deixar de sair com ele. Nós podemos sair qualquer outro dia.
<p>- Semana que vem eu vou estar muito ocupada, minha tia vai vir do interior e minha mãe gosta de fazer um monte de coisas para ela e...
<p>- Saímos semana que vem então. – Will a cortou.
<p>- Não! Faz muito tempo que a gente não sai só nós dois. Sempre tem que ter seus irmãos ou o Jason ou seus pais. 
<p>- Sinto muito, mas não posso.
<p>- Eu entenderia se fosse com o Chris ou o Kevin ou a Amanda, mas... Sebastian nem é o seu irmão de verdade. – Giovanna insistiu.
<p>- Eu já disse que não posso. – Will respirou fundo e voltou a comer.
<p>- Eu vou te esperar às seis na praia, se você não parecer... – Ela estava com um tom estranho na voz.
<p>- Eu não vou aparecer. Já disse.
<p>- Eu sou a sua namorada! – Giovanna aumentou a voz.
<p>- E ele é meu irmão. – Will continuou calmo.
<p>- Mas ele... Você vai se arrepender.
<p>- Não vou, não.
<p>- Por que você sempre me deixa em segundo plano? Eu não sou sua segunda opção. – Giovanna adorava fazer um drama.
<p>- Eu realmente não quero falar sobre isso agora. Eu estou com fome e quero comer. Se você só está aqui para arrumar briga, eu vou embora. – Era incrível como Giovanna conseguia tirar ele do sério.
<p>- Eu faço tudo por você, em compensação, só o que eu peço é que esteja livre quando eu quiser sair com você.
<p>- Eu já disse que não quero brigar.
<p>- Então coopera comigo. – Ela já estava quase gritando.
<p>- Muito bem, você conseguiu. – Will jogou os talheres no seu prato.
<p>- O quê?
<p>- Você conseguiu me fazer perder a fome. – Will se levantou da mesa e saiu deixando Giovanna falando sozinha coisas que ele sabia muito bem o que era.</p>
<center><h4>--*--</h4></center>
<p>- Não precisava ter cancelado com a Giovanna. – Sebastian sempre vinha com aquele jeito de “por mim, tudo bem”.
<p>- Precisava sim. Essa é a nossa tradição. Você só faz aniversário uma vez por ano. 
<p>- A Giovanna passou um pouco dos limites.
<p>- Muito obrigado, Jason. – Will se surpreendeu com Jason concordando com ele.
<p>- Ela sabe que a gente faz isso todo ano. – Jason continuou.
<p>- Certeza que ela só fez isso para me irritar.
<p>- Bom, eu não quero falar sobre isso no meu aniversário. – Sebastian finalmente se rendeu. 
<p>Os três estavam no terraço da gravadora sentados em cima do pequeno muro que tinha sido erguido não fazia muito tempo. Estavam todos com um copo de refrigerante na mão. Era uma noite muito quente
<p>- O que quer falar então? – Will perguntou.
<p>- Se lembram de quando nos conhecemos? – Sebastian adorava uma nostalgia.
<p>- Claro, Will e eu estávamos jogando futebol na quadra perto de casa e você apareceu pedindo pra jogar também.
<p>- Todo magricelo. – Will riu. – Quem diria que um dia nos tornaríamos irmãos? 
<p>- A vida é engraçada às vezes. – Jason respirou fundo – Na verdade, hoje temos uma surpresa para você. – Ele não conseguiu se aguentar.
<p>- Que surpresa? – Sebastian ficou curioso.
<p>- Parabéns para você. – Amanda chegou seguida de Chris e Kevin com um bolo cheio de velinhas acesas e cantando. – Nessa data querida, muitas felicidades, muitos anos de vida.
<p>Sebastian se virou quase que instantaneamente e pulou em direção a irmã sorrindo de felicidade. 
<p>- Eu não acredito que fizeram isso!
<p>- A ideia foi do Jason. – Amanda colocou o bolo no chão e correu para abraçar Sebastian. – Parabéns, maninho.
<p>- Valeu, pessoal. – Sebastian abraçou um por um e agradecia o tempo todo.
<p>- Por favor, me diz que não foi você que fez o bolo, Mandy. – Will provocou a irmã.
<p>- Não, eu comprei. – Chris avisou rindo. – Podemos comer sem nos preocupar.
<p>- Vocês são muito sem graças. – Amanda fingiu estar ofendida.
<p>Sebastian cortou o bolo, mas ninguém se lembrou de levar pratos, então todos começaram a comer com a mão mesmo. Minutos depois, estavam todos sujos de bolo. As mãos, os rostos e as roupas, mas todos com um sorriso no rosto. Geralmente, aniversários eram as únicas datas que eles agiam assim.
<p>- Então é isso que estão fazendo?
<p>Todos pararam de comer quando ouviram a voz brava de Giovanna no terraço.
<p>- Não me lembro de ter convidado a Giovanna. – Amanda comentou irritada.
<p>- Giovanna, o que faz aqui? – Will se levantou do chão limpando a mão na bermuda e foi em direção a namorada que estava parada em frente a porta do elevador.
<p>- Eu esperei você.
<p>- Como é que é? – Will franziu a testa.
<p>- Eu fiquei na praia por duas horas esperando, mas você me deixou plantada.
<p>- Não deixei, não. Eu avisei que não iria.
<p>- Achei que mudaria de ideia.
<p>- Por que eu faria isso? – Ele a encarou.
<p>- Porque eu sou a sua namorada. Você deveria preferir ficar comigo!
<p>- Hoje é aniversário do meu irmão. – Will tentou manter a calma.
<p>- Ele não é o seu irmão! – Giovanna começou a gritar. – É só um drogado que você achou na rua! Como pode preferir ficar com ele do que comigo?</p>
<br>
<p>“Todos ficaram quietos desde o começo e senti naquela hora que estavam esperando para ouvir o que eu ia dizer depois daquilo que ela disse. Devo confessar que aquilo me surpreendeu e me decepcionou. Eu sabia que a Giovanna era irritante e tudo mais, mas não achava que ela fosse falar algo daquele jeito só para magoar. Ela gostava do Sebastian, sempre o tratou bem. Eu nunca pensei que ela agiria daquele jeito com ele. Eu odiava quando alguém falava alguma coisa parecida do meu irmão. Era demais pra mim.”</p>
<br>
<p>- Você não tem o direito de dizer isso. – Will ficou sério.
<p>- Eu estou magoada.
<p>- Porque você quer.
<p>- Will, você me deixou pra ficar com um... doente. – Giovanna tentou amenizar o xingamento.
<p>- Esse doente é meu irmão, e pra mim, ele é muito mais importante que você.
<p>- Will...
<p>- Acabou. – Will e Giovanna brigavam e terminavam o tempo todo, mas por algum motivo, Giovanna percebeu que naquela vez ia ser diferente.
<p>- Will, por favor.
<p>- Sai daqui.
<p>- Will! – Giovanna gritou desesperada.
<p>- Eu não quero mais te ver. – Ele continuou calmo. 
<p>- Não, por favor. – Ela o abraçou bem forte e começou a chorar no pescoço dele. – Eu sinto muito. Eu agi sem pensar. Amanhã eu vou estar mais calma e...
<p>Will fechou os olhos, respirou fundo e tirou os braços de Giovanna de cima dele e se afastou.
<p>- Não me interessa.
<p>- Não faz isso. A gente se ama. Não vale a pena... Você tem outra? – Ela começou a ficar paranoica.
<p>- Ainda não. 
<p>Ela começou a chorar. Ninguém disse mais nada.</p>
<center><h4>--*--</h4></center>
<p>“Ninguém falou sobre o que havia acontecido no dia seguinte. Minha mãe fez outro bolo na manhã do domingo e comemoramos de novo o aniversário do Sebastian no almoço. Eu sentia que às vezes Amanda ou o próprio Sebastian queriam começar a falar sobre o rompimento até porque eu também sabia que ele estava se sentindo culpado, mas logo mudavam de ideia e ficavam calados ou falavam de outra coisa aleatória. Eu me senti estranho o dia todo, um pouco mais vazio do que normalmente eu me sentia. Eu não estava mais com a Giovanna e era estranho. Ninguém mais ia me amar. Era isso que eu sentia.”.</p>
<br>
<p>Giovanna estava esperando por Will em frente ao seu armário logo na segunda de manhã.
<p>- Oi. 
<p>- Oi. – Will já esperava que ela fosse abordá-lo a qualquer momento, mas mesmo assim não queria estar ali naquela hora.
<p>- Me desculpa. Eu não quis ofender o Sebastian. – Ela falava com um tom bem delicado.
<p>- Tudo bem. – Ele queria acabar com aquela conversa o mais rápido possível.
<p>- Podemos sair nesse fim de semana se você quiser ou um outro, você decide.
<p>- Não podemos, não.
<p>- Mas, Will...
<p>- Você sente muito, eu também sinto, está tudo bem, mas eu não quero voltar com você. 
<p>- Eu sei que eu te magoei e...
<p>- Giovanna, acabou. A gente se desculpar não vai mudar nada.
<p>- Mas... – Will achou que ela fosse chorar, mas então a expressão no rosto dela mudou de triste para raiva em questão de segundos. – Você é um hipócrita. Se acha perfeito? Melhor do que eu?
<p>- Eu nunca disse isso. Só não quero mais ficar com você. Eu cansei.
<p>- Eu me desculpei.
<p>- E eu aceito as suas desculpas, mas não quer dizer que vamos continuar juntos. Se você quiser continuar...
<p>- Não diz “amizade”. Não podemos ser amigos. Eu te... Não fica bravo comigo. – Giovanna voltou a ficar triste.
<p>- Eu não estou bravo.
<p>- Eu te amo.
<p>- Você vai encontrar alguém melhor.
<p>- Diz que me ama também.
<p>- Eu sinto muito.
<p>- Você vai se arrepender. – Giovanna limpou as lágrimas do rosto e saiu andando pelos corredores batendo os pés de raiva.</p>
<br>
<p>“Eu conhecia a Giovanna praticamente a minha vida toda e aquele término com certeza foi o mais difícil, talvez porque a gente era amigo e eu sabia que isso não ia mais rolar, mas já estava passando da hora disso acontecer. Só que eu sempre fui péssimo para encarar um término. Eu não estava com cabeça para ir para a aula. Na verdade, eu precisava relaxar. Precisava esquecer a Giovanna. Precisava fazer o que eu fazia de melhor. Seguir em frente.
<p>Duas horas depois, não se falava de outra coisa. William Jones tinha acabado de terminar com Giovanna e já tinha matado aula e ficado com outra garota no banheiro masculino. Interessante como boatos voam mais rápido que aviões. Em menos de um dia, eu deixei de ter uma namorada, meus amigos resolveram desaparecer e minha popularidade virou uma má reputação. Mas para falar a verdade, eu não me importei muito com isso, não. A partir daquele dia, meus relacionamentos ficaram mais fáceis, não passavam de uma semana, não tinha drama nem brigas, estávamos sempre na mesma sintonia, não era para ser nada sério. Quando enjoávamos um do outro, a gente se despedia e pronto e eu estava muito bem com isso.
<p>Mas isso foi há um ano. Agora, eu estava preso em um elevador, com a Emily. Ela não era qualquer garota para mim, ela era mais. Agora sabia de tudo e me olhava fixamente. Estava tudo escuro, mas eu ainda conseguia ver o seu rosto. Parecia decepcionada, chocada e com certeza sem palavras, já que não abriu a boca desde que eu comecei a contar toda a história. Eu não sabia o que ia acontecer. A decisão cabia a ela e isso embrulhava o meu estômago.”.</p>
</body>
</html>";
            }

            if (numero == 9)
            {
                lblTitulo.Text = "Capítulo 9 - Eu Atiro Em Tudo O Que Eu Já Amei";
                htmlPage.Html = @"<html>
<body>
<p><i>“Me desculpe por tudo, por tudo o que eu fiz
<br>Desde o segundo que eu nasci, parece que eu tinha uma arma carregada
<br>Então eu atiro, atiro, atiro em tudo o que eu já amei
<br>Então eu atiro, atiro, atiro em cada coisa que eu já amei.”
<br><b>Shots – Imagine Dragons</b></i></p>
<br>
<p>“Pode ser que você já teve tantas experiências ruins que aquilo ficou grudado na sua cabeça e não importa o que aconteça, aquela voz de ‘nunca vai dar certo’ fica se repetindo como se a sua mente tivesse um grande eco. Mas você sabe o que foi que deu errado? Às vezes, nem foi culpa sua ou pelo menos não totalmente.”.</p>
<br>
<p>Emily ficou em silêncio durante toda a história. Will esperava que ela fosse dizer ou perguntar alguma coisa, mas ela não fez. E quando ele terminou de contar, ela continuou em silêncio. 
<p>Will se sentou no chão de novo, colocou as mãos no rosto e esperou. 
<p>- Eu... – Emily começou a falar. 
<p>- Quanto tempo mais vamos ficar aqui? – Will evitou olhar para Emily e encarou a porta do elevador. – Eu já estou ficando com calor.
<p>- Will, eu sei que precisamos falar sobre isso.
<p>- Na verdade, não. Eu já falei tudo o que eu precisava falar. Eu sei que você não esperava e...
<p>- Não é isso. 
<p>- Eu sei que a hora foi péssima e... 
<p>- Will, está tudo bem.
<p>- Não está, não. Você ouviu quando eu disse que não senti nada por aquelas garotas?
<p>- Will.
<p>- Eu não consigo respirar aqui. – Will se levantou e começou a andar de um lado para o outro. 
<p>- Vamos ficar calmos. – Emily começou a andar atrás dele. – Isso foi... Will, olha para mim.
<p>- Eu não consigo.
<p>De repente as luzes se acenderam. Will começou a apertar todos os botões do painel, mas o elevador continuava parado. 
<p>- Acho que vai levar um tempo para o elevador reiniciar. – Emily disse.
<p>- Eu só quero dar o fora daqui.
<p>- O que vai acontecer? – Emily pegou na mão dele.
<p>- Como assim?
<p>- Quando a porta abrir. O que vai acontecer?
<p>- Eu não...
<p>O elevador, então, tremeu e começou a descer.
<p>- Queria não ter te contado.
<p>- Mas você contou.
<p>A porta se abriu mostrando o hall da gravadora. 
<p>- Eu sinto muito. – Ele puxou a sua mão e saiu correndo do elevador. 
<p>- Aparentemente, eu também. 
<p>Emily falou sozinha.</p>
<center><h4>--*--</h4></center>
<p>- O que ainda faz acordada? – Quando Will chegou em casa, Amanda estava esperando por ele no sofá. Já estava tarde, todos já deveriam estar dormindo. 
<p>- Eu estava te esperando. Queria saber como foi.
<p>- Foi ótimo. Marcamos até o casamento. – Ele se sentou ao lado dela.
<p>- Foi tão ruim assim?
<p>- Mais.
<p>- Terminaram?
<p>- Eu acho que sim.
<p>- Você acha?
<p>- Não falamos muito depois. 
<p>- Will, o que exatamente aconteceu?
<p>- Eu contei tudo, todos os detalhes, e depois... eu nem consegui olhar para a cara dela. Eu fiquei com tanta vergonha e... 
<p>- Saiu correndo. – Amanda adivinhou.
<p>- Eu evito confrontos.
<p>- Você é ridículo. – Amanda fechou a cara. – Nem esperou ela dizer o que tinha para dizer.
<p>- O que ela ia dizer? Fui embora antes de ela me xingar e me bater. Eu preferi nos poupar disso.
<p>- Você não sabe. Contou que a Giovanna é uma ridícula? Que ela fez por merecer?
<p>- Ah, até parece, Mandy. Eu tenho vergonha disso. Eu sei que a decepcionei. E agora... eu estraguei tudo. 
<p>- Você pode arrumar.
<p>- Não. Não dá para apagar. Eu não posso fazer mais nada.
<p>- O que você fez não te define. Você é mais do que isso, é uma boa pessoa, e eu sei que ela sabe disso. 
<p>- Eu não tive tempo de mostrar para ela essa boa pessoa que eu sou. – Will respirou fundo um pouco desanimado.
<p>- Ela sabe, e eu tenho certeza que ela está pensando nessa pessoa agora.
<p>- Como tem certeza?
<p>- Quando você gosta muito de uma pessoa, você sempre vê o lado bom dela, independentemente de qualquer coisa e ela gosta muito de você. Muito mesmo. 
<p>- Se você está dizendo.
<p>Mas Will não acreditava muito nisso.</p>
<center><h4>--*--</h4></center>
<p>Will saiu de casa no outro dia como se fosse um bandido.
<p>Olhava de um lado para o outro tentando evitar se encontrar com Emily em qualquer lugar ou ter tempo de fugir. Ia ser um dia difícil, os dois moravam na mesma cidade, estudavam na mesma escola. Precisava de sorte.
<p>- Você não quer se encontrar com ela? Para ao menos conversar?
<p>Jason, Sebastian e Will estavam em um dos corredores da escola indo para a sala de aula. 
<p>- Não, Jason. Não depois de ontem à noite. – Ele havia acabado de contar para seus amigos o que tinha acontecido. Como ele contou a história e o que aconteceu depois disso.
<p>- Você não deixou ela falar nada. Talvez ela só ia dizer que estava tudo bem. – Sebastian tentou animá-lo.
<p>- Eu não acho.
<p>- Por que você tem que ser tão pessimista? Talvez o Sebastian esteja certo.
<p>- Vamos falar de outra coisa? – Will tentou mudar de assunto.
<p>- Claro, podemos falar do quanto você é medroso. – Sebastian não entendeu o comentário de Jason. 
<p>- O quê? – Will perguntou.
<p>- Você gosta mesmo dela e está com medo de voltarem e perder ela de novo. 
<p>- Quer acabar com isso logo antes que fique muito sério. – Sebastian completou depois de entender.
<p>- Vocês não sabem de nada.
<p>- Está apaixonado por ela. – Jason insistiu. 
<p>- É, estou. É uma droga.</p>
<center><h4>--*--</h4></center>
<p>- Eu sabia que essa tal de Giovanna era uma vadia assim que eu a vi pela primeira vez. 
<p>Era o primeiro dia de aula de Quinn. Ela e a irmã estavam andando pelos corredores a procura do seu armário. 
<p>- É, ela não me mostrou ser uma pessoa legal também. – Emily falou sem muita emoção.
<p>- O que vai fazer agora? Ontem à noite, você estava bem abalada. 
<p>- Ele me contou tudo e foi embora. A gente nem... Ainda desligou o celular para eu não conseguir ligar para ele.
<p>- Agora você está com raiva.
<p>- Eu não estou com raiva. – Emily parecia estar com raiva. – Eu só... Aquelas fotos, as piadas e comentários pelas minhas costas, não era por causa que a escola é fofoqueira, é porque todo mundo me considera uma grande piada. 
<p>- Essas garotas são hipócritas, Emily. Tenho certeza que nenhuma delas se sentiu uma piada quando ficou com ele. Se duvidar, até pediram para fazer no mesmo banheiro. 
<p>- Eu só... eu só queria conversar com ele. Entender as coisas, ele nem me deu chance. 
<p>- Ele está envergonhado. Isso prova que ele não é ruim, já a vadia da ex dele, essa sim não deve ter um pingo de vergonha na cara. 
<p>- Ela o amava. – Emily a repreendeu.
<p>- Isso não é desculpa, Emily. 
<p>- Eu só preciso falar com ele. 
<p>- E eu preciso de um cara bonito que me acompanhe no meu primeiro dia de aula e se apaixone por mim. Eu nem ligo se ele já transou no banheiro, a gente pode até se encontrar lá mais tarde também. – Quinn riu.
<p>- Ai, fica quieta. 
<p>Emily tentou ligar para Will de novo, mas não conseguiu. Na sua primeira aula, esperou encontrar Amanda para fazer algumas perguntas, mas a garota também não apareceu. Por um minuto, ela achou que a irmã do namorado também estava fugindo dela, mas depois chegou a conclusão de que seria ridículo. 
<p>- Como foram suas primeiras aulas?
<p>- Horríveis, mas fiz amigos. – Quinn sorriu. 
<p>- Novidade.
<p>As duas estavam almoçando em uma mesa isolada no refeitório. Era onde geralmente Emily almoçava com Will.
<p>- E quanto a você?
<p>- Eu ia falar com a Amanda na primeira aula, mas ela não apareceu. O Will não responde as minhas mensagens e nem está almoçando com os irmãos dele. – Emily apontou disfarçadamente para a mesa onde os irmãos Jones estavam almoçando com os amigos. 
<p>- Vai ver ele morreu.
<p>- Para de graça.
<p>- Eu só estou tentando me divertir com a situação.
<p>- Mas não tem graça nenhuma. 
<p>- É claro que tem, estão fazendo um grande caso por nada. Você está namorando um dramático profissional, hein.
<p>- Você não entende? Ele deve estar achando que eu não entenderia. Que eu sou...
<p>- Uma certinha que só sabe julgar os erros dos outros.
<p>- Exatamente, mas eu não sou assim.
<p>- É, sim. – Quinn jogou uma batata no rosto da irmã.
<p>- Você sabe que eu não sou. 
<p>- Já me julgou várias vezes.
<p>- Você é minha irmã. Meu dever é te julgar. 
<p>- E o meu dever é te dizer o que deve fazer já que sou mais velha. 
<p>- Mas sou mais inteligente.
<p>- Isso não quer dizer nada. Olha, você tem que falar com ele. 
<p>- Ele não me responde. – Emily mostrou a tela do seu celular para a irmã, a chamada estava indo para a secretária eletrônica de novo.
<p>- Então vai na casa dele. Vai aonde você acha que ele deve estar, sei lá. Você tem que ir atrás do que quer, pelo menos uma vez na vida. Seu papai não vai fazer isso para você.
<p>As duas estavam tão entretidas na conversa que nem perceberam que havia alguém se aproximando. 
<p>- Você sabe onde está o Will?
<p>Emily se assustou quando ouviu a voz de Giovanna. Quinn fechou a cara e encarou a garota. 
<p>- Não, eu não sei. – Emily respondeu. Ela sabia que Giovanna tinha se aproximado só para provocar.
<p>- Ele te contou, não foi? Agora sumiu envergonhado. 
<p>- Olha só, garota... – Quinn começou a falar.
<p>- Quinn, para. – Emily olhou feio para a irmã. – Giovanna, é, ele me contou, mas eu não dou a mínima. 
<p>- Quer ser a próxima?
<p>- Para, tá. O ama tanto assim? Ele te magoou e você ainda... – Emily a encarou. – Você não tem amor próprio? 
<p>- Você não sabe de nada.
<p>- Sei o suficiente.
<p>Giovanna fez bico e deu as costas para elas.
<p>- Olha só, gostei de ver. – Quinn começou a rir. – Só faltou dar um tapa na cara dela.</p>
<center><h4>--*--</h4></center>
<p>Emily saiu mais cedo da sala na última aula. Correu para guardar seus livros no armário e foi para o portão esperar. Ela tinha quase certeza que Will não estava na escola, mas preferiu garantir.
<p>Vinte minutos depois, nenhum sinal dele. Ela estava quase desistindo quando viu Jason e Sebastian passando pelo portão distraídos.
<p>- Cadê o Will? Eu preciso falar com ele. 
<p>Emily foi correndo até os dois.
<p>- Ah, a gente não sabe. Ele apareceu para primeira aula e depois foi embora. – Jason falou em tom de desaprovação.
<p>- Ele não está atendendo o celular.
<p>- Imaginamos que ele faria isso, por isso nem ligamos. – Sebastian tentou um tom mais descontraído. – Ele gosta de ficar sozinho às vezes, para pensar.
<p>- É, só que isso não funciona comigo. Alguém de vocês tem um carro?
<p>- Sou filho de mãe solteira, mal tenho uma mochila.
<p>- Eu posso pegar o carro do meu pai, mas... – Sebastian estava um pouco desconfiado. – Para onde vamos?
<p>- Palm Springs.</p>
<center><h4>--*--</h4></center>
<p>Os três ficaram em silêncio na maior parte da viagem. Sebastian olhava disfarçadamente para Emily, que estava ao seu lado, o tempo todo esperando a hora que ele acharia certa para fazer a pergunta que queria fazer desde que entraram no carro.
<p>- Para onde estamos indo exatamente? – Ele finalmente falou. – Palm Springs é grande e... Eu estou dirigindo e queria saber se...
<p>- Eu falo quando estivermos chegando. É um bar.
<p>- O bar do Will? – Jason falou do banco de trás.
<p>- O bar que ele canta?
<p>- Vocês sabem sobre isso? – Emily ficou surpresa. – Ele me disse que...
<p>- Ele não sabe que a gente sabe. – Jason explicou. 
<p>- Somos curiosos. – Sebastian riu. – E ele é muito bom, a gente não podia perder. Como sabe que ele está lá?
<p>- Porque só tem outro lugar que ele estaria, mas ele sabe que eu o procuraria lá primeiro.
<p>Emily se lembrou da “gruta”.
<p>- Você vai perdoá-lo ou vai brigar com ele? – Sebastian também queria muito fazer essa pergunta fazia tempo. – Eu posso dar meia-volta.
<p>- Olha, eu fiquei surpresa, não vou mentir, mas... não é uma coisa que eu tenha que perdoar. As pessoas mudam. 
<p>- Nem sempre. – Sebastian falou. – Mas isso não tem nada a ver com o Will, é só uma experiência minha. 
<p>- O Will me contou como foi a briga dele com a... – Emily também tinha uma pergunta. – Ele disse que ela te chamou de... – Ela falava com cautela. – O que aconteceu?
<p>- Ah... – Sebastian não conseguiu disfarçar o constrangimento e o incomodo. – É uma história muito... muito...
<p>- Entendi. – Emily percebeu que tinha acabado de tocar em um assunto delicado então resolveu mudar de assunto o mais rápido possível. – E quanto a você, Jason? Quando vai contar para a Amanda que gosta dela?
<p>- O quê? – Jason ficou surpreso. – O Will te...
<p>- Não, ele não me falou nada. Eu só percebi. Naquele dia, na lanchonete, você estava...
<p>- É, ele é tão obvio. – Sebastian riu junto com Emily.
<p>- Existem vários fatores que eu preciso analisar antes de fazer qualquer coisa. – Jason continuou sério. 
<p>- Às vezes, você só precisa falar, sem fatores para analisar. Olha só para mim, eu estou em um carro com dois “desconhecidos” indo para outra cidade só para... só para tentar de novo. Eu nunca fiz isso na minha vida. 
<p>- E por que está fazendo agora? – Sebastian perguntou. 
<p>- Eu não sei. Eu só senti. – Emily não conseguia explicar. 
<p>Eles chegaram em Palm Springs depois de um tempo, e não demorou muito até Sebastian estacionar na esquina perto do bar. 
<p>O bar estava mais cheio do que quando Emily esteve lá pela primeira vez, mas não queria dizer que estava lotado. Ela conseguiu ouvir a voz de Will assim que entrou pela porta. Ele estava sentado no palco sozinho tocando seu violão e parecia que já estava lá por horas. Quando olhou para frente e viu Emily, Sebastian e Jason um pouco afastados o observando, ele não conseguiu disfarçar a surpresa e o descontentamento, mas continuou cantando até a música acabar.</p>
<center><h4>--*--</h4></center>
<p>Foram os dez minutos mais estranhos daquele dia. Will desceu do palco, pegou as chaves do carro com Sebastian e saiu do bar com os três atrás dele. Em silêncio, os quatro entraram no carro e Will começou a dirigir. Ele parou em frente a uma praça e desceu do carro. Emily desceu também com a cara fechada e foi atrás dele em direção a praça.
<p>- Vai continuar agindo feito uma criança birrenta? – Emily gritou para ele parar de andar.
<p>- O que está fazendo aqui? – Ele se virou para ela.
<p>- Você não atendeu as minhas ligações. 
<p>- Achei que isso era um... achei que tinha deixado bem claro.
<p>- Então, o quê? Está terminando comigo? – Emily falou como se aquela ideia fosse algo absurdo.
<p>- Não, eu... Você terminou comigo.
<p>- Quando exatamente eu fiz isso? Quando você saiu correndo ontem? Porque eu não tive tempo de falar nada. 
<p>- Sua cara disse tudo. 
<p>- A “minha cara” estava tentando absorver toda aquela história. Só isso. O que você queria que eu fizesse? Começasse a rir?
<p>- Ah, é? Então você não me considera um idiota nojento que só faz besteira? Porque eu ouvi muito isso nos últimos meses.
<p>- Ah, um idiota você é, com toda a certeza. – Emily respirou fundo. – Você pretendia mesmo me contar tudo aquilo ontem ou só escapou?
<p>- Pretendia. 
<p>- Por que não me contou antes? Por que não me contou quando eu perguntei sobre as fofocas?
<p>- Porque... – Will não sabia o que dizer. – Porque eu sou um covarde, porque você me via de um jeito e eu não queria que mudasse. E agora você... Eu estrago tudo, Emily. Esse sou eu de verdade.
<p>- Eu não ligo.
<p>- Você não pode dizer isso. Não pode dizer que está tudo bem.
<p>- Não está tudo bem. – Emily falou logo. – Mas você fugindo e não me atendendo... Isso não ajuda em nada. É assim que vai ser? Vai fugir sempre que tivermos um problema?
<p>- Acho que sim.
<p>- Will!
<p>- Eu achei que... Achei que nunca entenderia. Você é tão... “Emily”.
<p>- Isso é um elogio? – Ela franziu a testa.
<p>- Você é diferente, é inteligente e correta e sem falhas.
<p>- Mas eu tenho falhas. Eu não consigo me lembrar de nenhuma agora, mas... – Ela sorriu e fez ele sorrir também. – Eu não ligo para o Will de um ano atrás, eu ligo para o Will de agora. 
<p>- O Will de agora continua sendo uma droga. 
<p>- Eu não acredito nisso. Você me ajudou quando nem me conhecia direito e...
<p>- Eu só fiz isso porque queria ficar com você. Se você fosse feia, eu teria jogado suas malas na rua e pregado pegadinhas em você fazendo com que se perdesse toda no primeiro dia de aula. É assim que eu sou. 
<p>- Ainda assim. – Ela voltou a rir junto com ele. - Eu quero ficar com você, agora lide com isso.
<p>- Mas eu...
<p>- Eu sei, tem muitas falhas, para começar com a roupa que você usa, vamos ter que mudar isso. – Ela brincou. – Você não pode decidir isso por mim e não pode fugir o tempo todo.
<p>- Eu evito confrontos.
<p>- É, eu percebi. 
<p>- Me desculpe.
<p>- Não precisa se desculpar, eu já disse que...
<p>- Não, não por isso. Por fugir. Eu prometo que eu nunca mais vou fazer isso.
<p>- “Nunca” é uma palavra muito forte.
<p>- Eu sei. – Ele sorriu.</p>
<br>
<p>“O ser humano, na maioria das vezes não sabe o que é um meio termo. Ou você coloca toda a culpa do ocorrido em alguém e o transforma no demônio encarnado ou você simplesmente carrega a culpa toda para si e decide que nunca mais vai ser feliz, como meio que uma punição. Nunca é culpa dos dois, nunca é culpa de ninguém. O legal é quando você percebe que só precisava de alguém dizendo que não dá a mínima para sua culpa, alguém te dizendo que você pode sim ter uma segunda chance. Alguém que te diz que vai resolver esse problema com você porque é assim que tem que ser. Esse é o seu recomeço.”.
</body>
</html>";
            }

            if (numero == 10)
            {
                lblTitulo.Text = "Capítulo 10 - De Mãos Vazias";
                htmlPage.Html = @"<html>
<body>
<p><i>“Se você viesse até mim de mãos vazias
<br>Eu agitaria o seu oceano para te levar para casa
<br>E se você viesse até mim de coração vazio
<br>Eu encontraria os pedaços para te completar”
<br><b>Empty Handed – Lea Michele</b></i></p>
<br>
<p>“Têm dias que você se sente a melhor pessoa do mundo e parece que tudo na sua vida dá certo. Às vezes é uma sensação passageira, mas não importa muito, a maioria das coisas é. Mas você se lembra como essa sensação acaba? É quando você percebe que não é tão bom assim, que tem defeitos e nem tudo está dando certo. Às vezes, você vai além e descobre que, além de não sentir mais aquilo, você não sente mais nada, você está vazio. E o que você faz? Faz de tudo para voltar a se sentir completo de novo, mesmo que quando a sensação chegar, ela seja passageira. Isso não importa para você. Nunca importou.”.</p>
<br>
<p>Will estava mais feliz do que nunca. Tinha momentos que nem conseguia parar de sorrir e naquele dia, almoçando com os seus irmãos, ele estava tendo um daqueles momentos. Emily estava na biblioteca terminando um trabalho de história, ele não sabia bem, então estava ausente na mesa, mas ela era o assunto principal.
<p>- Então está tudo bem? – Amanda perguntou já sabendo a resposta.
<p>- Está. – Ele sorriu.
<p>- Você se preocupou à toa. – Sebastian falou com a boca cheia de purê de batatas.
<p>- Não que a gente não tenha falado muito para você sobre isso. – Amanda completou.
<p>- Eu tenho que confessar... – Chris veio com o seu tom de deboche. – Eu achei que depois de descobrir tudo, ela te daria um soco, porque a Emily não tem cara de dar só um tapa, ela parece ser brava. Pensei em te ver de olho roxo. 
<p>- Alguém vai ficar de olho roxo daqui a pouco e não vai ser eu. – Will olhou para o irmão usando o mesmo tom de voz dele.
<p>- Para mim, ela é maluca, mas tudo bem. – Amanda riu.
<p>- Ou só está apaixonada. – Jason bateu no braço de Will. – Assim como você. 
<p>- Calem a boca. – Will negou com a cabeça.
<p>- Então vocês estão sérios agora? – Chris quis confirmar.
<p>- É, estamos. 
<p>- Que bom. Você parece feliz com ela. – Will se surpreendeu com o comentário de Chris. – Diferente de quando estava com você-sabe-quem. 
<p>- É, ninguém merece namorar o Voldemort em pessoa.
<p>Todos riram da piada de Amanda.</p>
<center><h4>--*--</h4></center>
<p>A biblioteca já estava praticamente vazia quando Will entrou lá no final do dia. Emily estava sentada em uma das mesas bem afastada rodeada por livros e fazendo anotações no caderno sem parar, bem concentrada.
<p>- Tudo bem tirar 7, sabia? – Will puxou uma cadeira da mesa ao lado e se sentou perto dela.
<p>- Eu me recuso a tirar 7.
<p>- É, aparentemente você tem uma falha, é nerd demais.
<p>- Ficou surpreso? – Ela riu.
<p>- Nem um pouco.
<p>- Eu gosto de ficar aqui. Eu nunca fui de ter muitos amigos, então... na outra escola, eu sempre ficava na biblioteca lendo nas horas vagas.
<p>- Você não precisa fazer isso aqui. Eu arrumo alguns amigos para você.
<p>- Se for tipo a sua ex-namorada maluca, eu dispenso.
<p>- Nossa. Magoou. – Will colocou a mão no peito para brincar.
<p>- Sabe, eu tenho uma pergunta.
<p>- Pode fazer. – Ele cruzou os braços e a encarou.
<p>- Como vocês conseguem fazer isso? Quer dizer, depois de tudo... Como isso funciona realmente?
<p>- Na verdade, não funciona. – Ele riu. – A gente mal conversa diretamente um com o outro. Só nos falamos porque temos amigos em comum. Ela é a melhor amiga da namorada do Chris e o Chris é meu irmão, eu tenho que aguentar. Às vezes, ela faz alguns comentários estranhos, mas eu já me acostumei.
<p>- Mas e quanto a ela? Se fosse no meu caso, eu nunca mais iria querer ver a sua cara, talvez até me certificaria que ninguém mais visse.
<p>- Você ia me matar? 
<p>- Seria uma das opções. – Ela riu.
<p>- Nossa, que medo.
<p>- É bom que tenha mesmo. – Ela bateu de leve no ombro dele indicando o fim da brincadeira.
<p>- Olha, eu acho que eu ainda estou te devendo uma coisa.
<p>- O quê?
<p>- O lance de ir conhecer os seus pais ainda está de pé?
<p>- Depende. É o que você quer?
<p>- Eu quero ficar com você. Se isso é uma consequência, eu enfrento.
<p>- Até parece que está indo para a guerra.
<p>- E não estou? – Will franziu a testa.
<p>- Depende do humor do meu pai.
<p>- Então vamos torcer para ele estar no seu melhor dia.<p>
<center><h4>--*--</h4></center>
<p>Will passou o caminho todo para a casa de Emily perguntando coisas sobre seus pais, queria estar preparado. Eles eram de Nashville também e tinham se conhecido bem novos. O nome da mãe dela era Patrícia e do pai era Harry. Seu pai era engenheiro civil e atualmente estava trabalhando em uma construção de um hotel no centro de Los Angeles de uma construtora bem famosa. Will tremeu, não sabia nada de engenharia. Ele não curtia futebol, ainda bem porque Will também não sabia quase nada sobre o esporte. Estava ficando cada vez mais difícil. Sua mãe era professora, mas largou seu emprego na cidade anterior e não estava conseguindo achar outro lá. Ela gostava muito de música, isso era um ponto positivo e cozinhava muito bem.
<p>Quando chegaram na casa, Will hesitou ao passar pelo portão. Ele sempre chegava só até ali. Quando entraram, ele sentiu um frio na barriga que nunca sentiu antes, nunca tinha ido na casa da namorada conhecer os pais dela, ele não fazia isso. Emily segurou a mão dele bem firme e sussurrou um “relaxa” um pouco nervosa também. 
<p>Patrícia estava na cozinha, ainda de avental, preparando algo para o jantar. Ela estava tão entretida com o que estava fazendo que não percebeu quando entraram.
<p>- Oi, mãe. – Emily se pronunciou.
<p>A mãe se virou e seus olhos foram direto para Will. Ele teria ficado mais nervoso do que já estava se ela estivesse séria Sorte que pelo menos estava sorrindo.
<p>- Você deve ser o William. – Ela enxugou as mãos em um pano de prato em cima do fogão e foi me abraçar. – Seja bem-vindo.
<p>- Pode ser só Will, senhora. – Ele ficou sem graça depois do abraço. 
<p>- Pode me chamar só de Patrícia. Nada de senhora, dona e essas coisas. E parece que a Emily tinha razão sobre você.
<p>- Obrigado, eu acho. – Ele sorriu ainda mais sem graça do que antes.
<p>Will observou alguns traços daquela mulher. Era muito parecida com Emily e aparentava ser muito mais nova do que realmente era. Claro que ele não ia dizer isso, iria parecer um elogio genérico e ridículo, preferiu ficar calado.
<p>- Não repare na bagunça. Eu estou preparando algo para gente comer. O que você prefere? – Ela perguntou. 
<p>- Ah, eu não ligo muito para isso. Eu como qualquer coisa. Não que a sua comida seja qualquer coisa, eu não quis dizer isso, eu só quis dizer que eu não sou enjoado para comer, mesmo que seja algo ruim, eu como, não que a sua comida vai ser ruim, é que...
<p>- Ela já entendeu, Will. – Emily riu.
<p>Eles ouviram o barulho de alguém descendo as escadas. Quinn foi até a cozinha com uma expressão de divertimento no rosto.
<p>- Olha só, minha irmã trouxe o namorado para o abate. – Ela riu. 
<p>- Não precisa dizer isso, eu nem estou nervoso. – Will riu.</p>
<center><h4>--*--</h4></center>
<p>Quando Will se sentou no sofá e começou a conversar coisas aleatórias com Emily e Quinn, ele se sentiu mais calmo. Tentou esquecer do que aquele momento realmente significava. Deu certo.
<p>Harry chegou quando Patrícia já estava arrumando a mesa para o jantar. Will voltou a ficar nervoso, talvez até mais do que quando tinha chegado. Ele se levantou do sofá quase que instantaneamente e se afastou um pouco de Emily.
<p>- Pai, esse é o Will. – Emily os apresentou assim que ele entrou na sala. 
<p>- Muito prazer, senhor. – Will estendeu a mão.
<p>- Boa noite. – Por um minuto, Will achou que o homem não ia apertar a sua mão e aparentemente até Harry pensou em não apertar, mas depois de um tempo, ele acabou apertando. – Sou Harry. – Ele deu um meio sorriso bem rápido e foi ajudar a sua esposa a colocar a mesa.
<p>- Relaxa, ele é assim mesmo. – Emily tentou confortar o namorado.
<p>- Tudo bem, eu acho que só com essa troca de olhares ele já me adorou. – Will jogou um sarcasmo para se sentir melhor.
<p>- Bobo.
<p>O jantar estava ótimo. Patrícia era realmente uma ótima cozinheira. Will tentou ao máximo ser educado, não comer rápido e sem modos, causar uma boa impressão. Às vezes, ele sentia que Harry o observava, mas tentava evitar o contato visual.
<p>- A comida estava ótima, Patrícia. – Will falou assim que terminou de comer. 
<p>- Muito obrigada. – Ela sorriu. – É uma das coisas que eu gosto muito de fazer.
<p>- Acho que você se daria bem com a minha mãe então. – Will achava muito mais fácil falar com Patrícia do que com Harry, ele ficava menos nervoso. – Ela também adora...
<p>- Como é a sua família? – Will se assustou com a pergunta de Harry.
<p>- Ah... Grande. – Ele riu para tentar criar uma descontração. – Eu tenho cinco irmãos e é uma bagunça. Meus pais são legais. Acho que iam gostar de se conhecerem. Podemos um dia...
<p>- Como você é com seus irmãos?
<p>- Ah, a gente se dá bem, na maioria das vezes, mas somos família, não é? Apesar dos pesares, é a coisa mais importante para nós.
<p>- Isso é verdade. – Harry deu outro meio sorriso. – Eu me lembro de quando eu conheci a Patrícia. Foi amor à primeira vista, naquele momento eu sabia que queria formar uma família com ela.
<p>- Que legal. – Will estava com medo do rumo daquela conversa.
<p>- E você, Will, o que acha do amor?
<p>- O quê? – Ele arregalou os olhos surpreso.
<p>- Pai... – Emily fez “que não” com a cabeça.
<p>- É uma pergunta simples. – Ele insistiu.
<p>- Bom, na verdade... – Will respirou fundo. – O amor é um sentimento muito importante para as pessoas. – Era como se ele estivesse tentando enrolar em uma prova para ganhar pelo menos um 5.
<p>- Você sabe o que é isso?
<p>- Mais ou menos, eu acho. Quer dizer, quem sabe bem dessas coisas na minha idade, não é?
<p>- Pouca gente. – Ele concordou. – Sabe quantos anos eu tinha quando eu conhecia a Patrícia? Quatorze. 
<p>- Nossa, que incrível. Isso o que vocês têm... é muito...
<p>Will não sabia mais o que falar. Ele olhou para Emily, ela tentou confortá-lo com o olhar, mas não deu muito certo. Ele já estava se sentindo derrotado naquela noite.</p>
<center><h4>--*--</h4></center>
<p>- Não foi tão ruim.
<p>- Você está brincando? “Eu conheci a Patrícia com quatorze anos.”. O que ele queria que eu dissesse?
<p>Will e Emily foram passear na praia depois do jantar. Ele precisava de um pouco de ar, suas pernas ainda estavam um pouco bambas enquanto os dois andavam pela areia molhada descalços.
<p>- Sabe, uma vez o namorado da Quinn saiu correndo. Pelo menos, você aguentou até o fim.
<p>- Ponto para mim, então. – Ele falou desanimado.
<p>- Você foi ótimo.
<p>- Eu não diria isso. 
<p>- Ah, Will, para. – Emily parecia bem calma. Já estava acostumada com as ações do seu pai diariamente. 
<p>- Eu não sei fazer isso. Namoro. Pelo menos, não direito. 
<p>- O que isso quer dizer?
<p>- O que você espera da gente? Eu não olhei para você pela primeira vez e já soube que queria criar uma família. Eu nem sei se eu quero criar uma família. – Ele parecia desesperado.
<p>- Will, eu tenho dezesseis anos. A última coisa que eu quero fazer agora é criar uma família. Relaxa. Essa história do meu pai, ele nos conta o tempo todo quando quer dar um sermão, bronca ou no Natal. 
<p>- Mas...
<p>- Quer esquecer isso, por favor?
<p>- Eu nunca amei de verdade, eu nem sei como é isso. Eu nem sei se eu vou amar um dia. Não me entenda mal, eu gosto muito de você e tal, mas...
<p>- Will...
<p>- E se você começar a me amar e eu não conseguir retribuir? E se depois de todo esse tempo, eu não conseguir te dar nada em troca?
<p>- Will, me escuta. – Ela pegou na mão dele. – Relaxa.
<p>- Eu não quero te decepcionar.
<p>- Você não vai. Olha, eu também nunca amei ninguém. Eu também não sei fazer isso. Estamos no mesmo barco.
<p>- Mas você é uma garota. Garotas amam fácil.
<p>- Quer levar um soco? – Ela brincou.
<p>- Bem que o Chris disse que você não era só de tapas. – Ele riu. – Você não está com medo? Eu não sou esse tipo de cara.
<p>- Que tipo?
<p>- Que faz serenata, que grita na multidão e se declara. Eu não sou assim.
<p>- Você nunca fez esse tipo de coisa, não é por isso que eu gosto de você.
<p>- Então por que você gosta? Minha irmã acha que você é louca.
<p>- Talvez eu seja. Que tal a gente ir com calma, uma coisa de cada vez. Hoje a gente dá uma volta, amanhã a gente pensa em casamento e criar família. – Ela gargalhou.
<p>- Engraçadinha.
<p>- Vamos aprender juntos. E não diga que não tem nada para me dar em troca, não é verdade. Você é a melhor companhia que alguém poderia ter.
<p>- Sabe que esse elogio vai dobrar o meu ego, não sabe?
<p>- E você nunca vai esquecer isso.
<p>- Nunca. – Ele sorriu.</p>
<br>
<p>“E se você acordasse um dia e descobrisse que é incapaz de amar? Que não importa o que você faça, isso nunca ia mudar? Você tentaria de novo amar alguém ou simplesmente desistiria e aceitaria? Você estaria disposto a passar o resto da sua vida sem amor? Mas se você nunca amou então não sabe o que é, logo não pode sentir falta de algo que nunca teve, certo? Certo? Para algumas pessoas sim, mas eu acho que é errado. Eu nem sei o que eu faria nessa situação, mas eu sei o que eu sentiria, um pouco de tristeza, um pequeno vazio. Não importa o que os corações partidos dizem, não há nada melhor do que amar e ser amado. Se você tem isso dentro de você, não perca tempo e sinta e nunca diga que você está vazio e que não tem nada para dar em troca, porque você tem. Você tem um coração.”.</p>
</body>
</html>";
            }

            if (numero == 11)
            {
                lblTitulo.Text = "Capítulo 11 - Eu Acredito Que Podemos Fazer Isso";
                htmlPage.Html = @"<html><body>
<p><i>“Eu acredito nos meus bons tempos
<br>Eu acredito na minha música
<br>Eu acredito no que podemos alcançar, é
<br>Eu acredito que podemos fazer isso”
<br><b>I Believe We Can Do It – Tyler Hilton</b></i></p>
<br>
<p>Jason e Will estavam tomando café juntos em uma cafeteria perto do quarteirão das suas casas na manhã seguinte ao jantar traumático na casa de Emily. Will preferiu contar para o amigo todos os detalhes pessoalmente, traria mais impacto do que uma simples mensagem de “Tô vivo!” na noite anterior.
<p>- Não pode ter sido tão ruim assim. – Pela experiência que Jason tinha, ele sabia que o amigo era exagerado às vezes, então não acreditou na história toda logo de cara.
<p>- Olha, a Emily foi perfeita, e a Quinn e a mãe... mas o pai, tenho calafrios só de pensar no nome dele.
<p>- Acho que ele só está preocupado com a filha.
<p>- Mas foi um exagero. Ele foi muito grosso. Parecia o demônio. 
<p>- Está exagerando.
<p>- Não. Você devia estar lá para ver. Ele começou a falar de amor e como o casamento dele é perfeito e como ele descobriu que amava a mulher dele assim que a viu e perguntou se eu sentia o mesmo pela Emily. Eu nem sei o que eu quero comer amanhã, quanto mais se eu quero me casar. – Will mal respirava para falar e estava quase atropelando as palavras.
<p>- E a sua insegurança só piorou as coisas, não é?
<p>- Um pouco. Eu quase saí correndo de lá chorando.
<p>- Mas e no final, como ficou entre você e a Emily?
<p>- Ela foi maravilhosa. Sem falar que...
<p>- O quê?
<p>- Eu passei a noite pensando nisso. Quando eu penso nela ou quando quero expressar o que eu sinto, dizer “eu gosto” parece ser pouco agora. Não é o suficiente. Entende o que eu digo?
<p>- Mais do que você pensa.
<p>- Como você consegue?
<p>- O quê? – Jason não entendeu a pergunta.
<p>- Ter todos esses sentimentos e guardar só para você. Quando eu vejo a Emily, eu só quero dizer o quanto ela é importante para mim. Já você vê a Amanda e se cala completamente. 
<p>- Para você é mais fácil.
<p>- Ou você só complica. 
<p>- Pode ser. 
<p>Jason sabia que tudo aquilo era muito mais complicado na sua cabeça, mas ele não conseguia evitar, era mais forte do que ele.</p>
<center><h4>--*--</h4></center>
<p>- Eu estava pensando que a gente podia tentar de novo em um outro dia. – Emily e Will estavam caminhando pelo pátio da escola enquanto não dava o horário para a aula.
<p>- Desculpa, Ems, mas eu só vou entrar na sua casa de novo depois de receber uma benção.
<p>- Exagerado. – Ela riu. – Não foi tão ruim assim. Ele até falou de você depois que eu voltei para casa.
<p>- Falou o quê? Que eu sou o seu par perfeito? – Disse ele esperançoso.
<p>- Não exatamente. Quer dizer, nada relacionado a isso. Ele não te odiou. – Ela falou logo.
<p>- Olha, se você quer que eu vá lá de novo, eu vou. 
<p>- É sério? – Ela ficou surpresa. 
<p>- Eu faria tudo por esse rosto. – Ele sorriu.
<p>- Cale a boca. – Ela riu sem graça.
<p>- Mas sério, você não quer que eu volte lá tão cedo, quer? – Ele quase suplicou com o olhar.
<p>- Não, eu estava só brincando. Na verdade, eu acho que a gente podia fazer outra coisa.
<p>- Se a sua “outra coisa” é dar amassos no banco de trás do meu carro, eu vou curtir bastante. 
<p>- Quem sabe outro dia.
<p>- Tem outra ideia melhor? Porque nada vai superar os amassos. 
<p>- Podemos ir jantar naquele restaurante novo que abriu perto da praia. Ouvi dizer que eles são obrigados a te dar pães de graça até você parar de pedir.
<p>- Pães de graça? Acho que isso é melhor que amassos. – Will gostou da ideia. 
<p>- Então é isso, vai me trocar por pães?
<p>- Certeza que quando eu pedir para beijá-los, não vão negar.
<p>- Eles não falam.
<p>- Exatamente. 
<p>- Então quer que eu pare de falar? – Emily mostrou uma cara feia, mas estava quase rindo.
<p>- Não, eu adoro ouvir sua voz. Mas eu tenho que confessar, quando você começa a falar sem parar, eu meio que me desligo na metade da conversa. 
<p>- Você me diz as coisas mais românticas do mundo.
<p>- É um dom.</p>
<center><h4>--*--</h4></center>
<p>- Você devia ter visto. Ele ficou com cara de assustado o jantar todo. 
<p>Quinn estava contando pela centésima vez para Amanda todos os detalhes do jantar de Will na casa dela na noite passada enquanto almoçavam juntas no refeitório da escola. Amanda não parava de rir das imitações de Quinn das expressões que o irmão fez naquela noite. 
<p>- Nossa, eu imagino o desconforto que foi para o Will, ele odeia essas coisas. – Amanda estava gargalhando.
<p>- Na verdade, eu acho o meu pai um exagerado. Até de casamento, ele falou. Um hipócrita. 
<p>- Você não curte muito o seu pai, não é? Ainda está brava porque teve que ir embora da sua cidade natal?
<p>- Queria que fosse só isso, mas fica para outra conversa. Estamos aqui para se divertir com o seu irmão. – Quinn riu. Ela sabia disfarçar muito bem. Fazer com que um assunto sério virasse algo sem importância. 
<p>- Tudo bem então. 
<p>Amanda não era muito de insistir em uma conversa quando percebia que a pessoa não queria falar sobre isso, a não ser que essa pessoa fosse Will. Não demorou muito até Jason e Sebastian se sentarem junto delas para almoçar também. A mesa se completou com Chris, Ashley, Kevin e Giovanna. 
<p>- Sabe o que a gente podia fazer hoje? A gente podia sair. – Quinn sugeriu depois de um tempo. – Ouvi falar de um bar bem legal perto de Santa Mônica.
<p>- Eu dispenso. – Jason falou logo.
<p>- Ah, qual é? É sexta feira. Vocês não podem ser tão caretas assim. Vamos, Amanda. – Ela tentou conseguir uma cumplice.
<p>- Bom, eu topo. Não tenho mais nada para fazer. 
<p>- Ótimo, consegui uma. – Quinn comemorou. 
<p>- Will e Emily vão também? – Chris perguntou.
<p>- Da última vez que todos se reuniram, não foi muito bom. – Quinn riu. – Não. A Emily me disse que já tem planos com o Will hoje. Seria só nós.
<p>Chris olhou para Ashley e então os dois concordaram em ir com a cabeça. Jason voltou atrás e aceitou também junto com Sebastian.
<p>- Esse tal bar é legal? Porque eu não vou perder o meu tempo... – Giovanna falou de cara fechada.
<p>- E quem disse que a gente quer que você vá? – Amanda disse sem rodeios. – Fica em casa, faça um bem para a sociedade. 
<p>- Ah, qual é, Amanda? – Quinn falou séria. – Se ela não for, quem vai ser a chacota da turma? – Depois começou a rir junto com a amiga. 
<p>- Tá legal, gente. Já chega. – Chris odiava essas briguinhas.</p>
<center><h4>--*--</h4></center>
<p>O restaurante era diferente de todos os outros que Will já tinha ido. Era imenso e espaçoso. Não havia mesas e sim um balcão enorme que passava por todo o bar com cadeiras dos dois lados.
<p>- Esse lugar é incrível. – Emily olhava para todos os lados quando se sentou. – Combina comigo.
<p>- Nossa, eu achei que eu era o único egocêntrico da relação.
<p>- Eu estou aprendendo com você.
<p>- Isso não é bom. – Ele começou a rir. 
<p>Will observava cada detalhe do rosto de Emily enquanto ela falava sem parar sobre o seu dia não muito empolgante. Ele não conseguia se ver, mas poderia apostar que estava fazendo a maior cara de bobo enquanto olhava para ela, mas nem ligava. 
<p>- Sabe, eu estava pensando na gente... Em como nós somos.
<p>- Como assim? – Emily perguntou curiosa. 
<p>- Quanto mais eu fico com você, mas eu percebo que somos perfeitos um para o outro. 
<p>- O que te leva a pensar nisso? Cadê a sua base de pesquisa? – Ela fingiu ficar séria. 
<p>- Você ficou meia hora falando e eu não me importei e nem precisei participar da conversa e você não ligou porque não queria ser interrompida. Isso é incrível. 
<p>- Cala a boca. – Ela jogou um pedaço de pão na cara dele, ele abriu a boca e conseguiu pegar e comer o pão. – Você gosta mesmo de pão.
<p>- A melhor coisa desse restaurante, já que a banda é péssima.
<p>Perto das janelas, havia um palco e uma banda estava tocando música ao vivo. Will achava a dicção e a sintonia da banda muito ruim, eles não serviam para isso. Nem parecia que tinham tido um único ensaio.
<p>- Por que você não vai lá e pega o microfone da mão deles e mostra como se faz? – Emily perguntou.
<p>- Você está louca? Esse lugar está lotado de gente e...
<p>- Qual o problema?
<p>- Não. 
<p>- Se você topar, eu canto com você. – Ela sorriu.
<p>- Ah é? Logo você que não consegue lidar com uma encarada qualquer no corredor da escola? – Will ficou feliz com a ideia.
<p>- Eu só disse isso porque sei que não vai topar.
<p>- É um desafio? Então eu topo. 
<p>- Olha, eu só estava brincando. – Emily ficou assustada.
<p>- Vai amarelar agora? É assim que você quer ser lembrada?
<p>- Eu odeio você.
<p>Emily então se levantou decidida. 
<p>- O que você está fazendo? – Will se assustou quando viu Emily toda confiante. – Era brincadeira. Nós dois não queremos fazer isso.
<p>Will se levantou cauteloso e foi atrás de Emily. Ela esperou a música acabar para subir no palco e pegar os microfones dos pedestais sem os cantores, distraídos conversando entre si, perceberem. 
<p>- Olá, pessoal. – O som da voz de Emily nas caixas de som deu um susto nas outras pessoas. Com um microfone em cada mão, ela subiu em uma parte do balcão e começou a andar por ele desviando dos pratos. – Eu peguei esses microfones para... Eu nem sei exatamente o que eu estou fazendo. Até porque eu acabei de me lembrar que eu sou tímida para caramba. 
<p>Will subiu no balcão do lado oposto muito receoso e encarando Emily bem surpreso. 
<p>- Mas eu fui desafiada. E ninguém me desafia e sai impune. – Emily arremessou um dos microfones para Will e ele pegou. 
<p>- Por favor, não joguem tomates na gente. – Will, extremamente sem graça, fez todo mundo rir. – Na verdade, a gente até que canta muito bem. 
<p>- Eu canto melhor. – Ela começou a rir.
<p>- Vamos acabar logo com isso. – Will respirou fundo, fechou os olhos e no silêncio começou a cantar a primeira música que veio na sua cabeça. - <i>Tudo o que eu quero é ficar um pouco mais perto... Tudo o que eu quero saber é se você pode chegar um pouco mais perto.</i>
<p>- <i>Aqui vem o suspiro antes de ficarmos um pouco mais perto.</i> – Emily estava se sentindo mais confiante que nunca e se divertindo muito. – <i>Aqui vem a adrenalina antes de nos tocarmos. Chegue um pouco mais perto.</i>
<p>- Vocês precisam descer daí. – Um dos garçons gritou perto de Will.
<p>- <i>As portas estão abertas, o vento está muito forte...</i>
<p>- <i>O céu noturno está mudando sobre nossas cabeças!</i> – Emily o completou. 
<p>- Cadê a minha banda? Eu quero animação! – Era como se aquela adrenalina tivesse apagado toda a vergonha que Will um dia teve de cantar para um público maior do que estava acostumado. – <i>Nem tudo é só físico! Eu sou do tipo que não vai ficar, oh, tão crítico.
<p>Todos começaram a bater palmas no ritmo da música.
<p>- <i>Então vamos partir para a coisa física! Eu não vou te tratar como se você fosse, oh, comum!</i> – Emily andava de um lado para o outro pelos balcões como se estivesse tendo o melhor momento da sua vida.
<p>- <i>Eu te quero por perto, eu te quero!</i>
<p>- <i>Eu não vou te tratar como se você fosse comum...</i>
<p>- <i>Eu te quero por perto, eu te quero!</i> – Will não parava de olhar para Emily.
<p>- <i>Eu não vou te tratar como se você fosse comum...</i>
<p>Os clientes que conheciam a música se divertiam cantando junto enquanto os outros continuavam com as palmas. A banda tentou acompanha-los com os instrumentos, mas desistiram logo no início, preferiram só assistir ao show.
<br>
<br><i>Aqui vem os sonhos de você comigo
<br>Aqui vem os sonhos
<br>Aqui vem os sonhos de você comigo
<br>Aqui vem os sonhos...</i></p>
<center><h4>--*--</h4></center>
<p>Jason era considerado pelos amigos a pessoa mais tímida e antissocial de todas. Logo, estar em um bar badalado de Los Angeles lotado em uma sexta à noite não era bem o programa que ele escolheria de primeira. 
<p>- Você não está se divertindo. – Sebastian estava com ele no balcão. Eles não bebiam nada. Só observavam o pessoal.
<p>- Você também não. – Jason olhou desanimado para o amigo. 
<p>- Eu nunca me divirto. 
<p>- Vocês são uma droga, sabia?
<p>Quinn se aproximou deles. Ela estava suada e quase sem folego de tanto dançar na pista junto com os outros.
<p>- Vocês não bebem, não dançam. 
<p>- Mas estamos aqui. – Sebastian sorriu desanimado.
<p>- Cadê a Amanda? – Jason perguntou. – Ela estava com você e... 
<p>Antes de terminar a frase, ele a viu. Estava dançando com um desconhecido bem alegre. De repente foi como se Jason tivesse levado um soco no estomago.
<p>- Eu acho que vou embora. 
<p>- Ah, qual é? A gente acabou de chegar. – Quinn reclamou. 
<p>- É, mas eu não me sinto muito bem e...
<p>- Você está bêbado ou... – Então ela parou de falar. – Tudo bem, vamos fazer o seguinte. Eu vou junto, você me leva para casa e então vai embora.
<p>- Não precisa ir comigo. – Jason falou logo.
<p>- Eu sei. Vamos.
<p>Jason olhou para Sebastian e ele o incentivou a ir embora e disse um “eu vou ficar bem” baixinho só para ele escutar. 
<p>Se Sebastian já estava desanimado com Jason do lado, ficar sozinho só deixou tudo pior. Aquela música alta, o barman oferecendo bebida o tempo todo, tudo estava o irritando muito. 
<p>- Você não vai beber nada essa noite? – Giovanna se aproximou dele com um copo cheio de tequila na mão. Esse não parecia ser o primeiro, ela já estava um pouco mais “animada” que o normal. – Ah, é, eu esqueci. Você não bebe. 
<p>- Você tem dezessete, também não deveria beber.
<p>- Vai seguir as regras agora? – Ela sorriu. – Cadê seu amiguinho? Foi embora?
<p>- Giovanna, eu não estou nem um pouco a fim de conversar com você, tá legal? Sai daqui, não somos amigos.
<p>- Jason foi embora, o Will está com a namoradinha. O que sobrou para você? Está tão sozinho quanto eu.
<p>- É uma cantada?
<p>- Não, só estou dizendo “bem-vindo ao fundo do poço” já que também estou lá. A diferença é que eu me livro dele bebendo e me divertindo, você já parte para coisas mais sérias. – Ela riu maldosamente. 
<p>- Eu não estou no fundo do poço. Eu estou muito bem.
<p>- Claro, diga isso várias vezes até acreditar de verdade.
<p>Giovanna tentou beijar o rosto de Sebastian e ele se esquivou. Ela então deixou o copo ainda cheio do lado dele propositalmente e foi para a pista de dança. Ele ficou olhando para o copo fixamente. Se imaginou bebendo todo o seu conteúdo e imaginou o que aconteceria logo após. Segurou o copo, já conseguia sentir o cheio do álcool. 
<p>- Eu viro as costas dois minutos e você já quer se embebedar? – Chris apareceu ao lado dele e Sebastian caiu na real.
<p>- Não é isso, é que...
<p>- Eu sei. Água tônica é horrível. – Chris sorriu. – Podemos tomar juntos, talvez diminua o gosto ruim. 
<p>- Eu não sei se isso vai fazer diferença. – Sebastian riu. – Não precisa fazer isso.
<p>- Claro que preciso. Eu sou seu irmão, esqueceu?
<p>Os dois sorriram um para o outro.</p>
<center><h4>--*--</h4></center>
<p>- Vai me contar por que de repente você quis ir embora do bar? 
<p>Quinn e Jason estavam andando pela rua. Estava escuro e silencioso, não era um bairro muito agitado. 
<p>- Eu só estou cansado, só isso, e eu não curto muito esses lugares. 
<p>- E só piorou quando você viu a Amanda dançando com outro cara, não é?
<p>- Isso não tem nada a ver. – Jason ficou sem graça. 
<p>- Eu vi, tá? E não precisa mentir para mim. Eu não vou contar para ela. 
<p>- Eu gosto da Amanda desde que éramos crianças. Eu nunca consegui me interessar por mais ninguém. É triste.
<p>- Mais triste ainda é você não contar para ela. Qual é o seu problema? – Ela riu.
<p>- Muitos. Insegurança, falta de amor próprio e eu não sei assoviar. 
<p>- Droga, assoviar é uma das maiores qualidades que uma garota procura em um cara. 
<p>Os dois começaram a rir.
<p>- Isso não é tão simples. Ela é irmã do meu melhor amigo e a gente se conhece desde criança e...
<p>- Isso são só desculpas. 
<p>- O Will fala sobre isso sempre que consegue. Então não é falta de aviso. Eu sei quais são as consequências de eu não me declarar. Eu vi uma delas essa noite.
<p>- Sabe, você parece ser um cara muito atencioso e só de olhar para você eu já tenho vontade de me casar. – Jason riu. – Eu sei que a Amanda seria feliz com você.
<p>- Eu nem sei se ela gosta de mim. Eu acho que não. Para ela, eu só sou o melhor amigo nerd do irmão dela. 
<p>- A gente podia namorar.
<p>- O quê? – Jason ficou surpreso.
<p>- Eu também estava apaixonada, mas eu sou uma droga.
<p>- O que aconteceu?
<p>- Fiquei com raiva dos homens. Ele não teve culpa, só estava no caminho da destruição.
<p>- Algum motivo específico? 
<p>- Você já se decepcionou com alguém que deveria cuidar de você?
<p>- Meu pai abandonou minha mãe e eu quando eu tinha dez anos. Ele era meu herói e um dia desapareceu. 
<p>- É, o que me decepcionou ainda está na minha casa e não é nenhum pouco melhor. 
<p>- Sério que é assim que a nossa sexta-feira badalada vai terminar? – Jason riu. – Deveríamos estar nos divertindo.
<p>- É, deveríamos.
<p>Quinn se aproximou mais de Jason e então, sem nenhum aviso, o beijou.
<p>- Essa é a única diversão que você vai ter hoje. – Quinn sorriu.
<p>- N-não... não f-foi o m-meu p-primeiro b-beijo. – Jason gaguejou.
<p>- Eu percebi.</p>
<center><h4>--*--</h4></center>
<p>Will e Emily estavam sentados na areia seca olhando para o mar escuro e agitado da noite. A praia já estava deserta.
<p>- Tudo bem, qual foi a melhor parte dessa noite? A parte que a gente subiu no balcão, cantou... – Emily estava contando os acontecimentos nos dedos.
<p>- Ou a parte que fomos expulsos do restaurante pelos seguranças? – Will a lembrou e os dois começaram a cair na gargalhada. – Pelo menos eu comi bastante pão antes de irmos embora.
<p>- Sabe, eu adorei. Tudo.
<p>- Eu também. Essa foi a maior plateia que eu já tive e a mais importante. É um restaurante bem falado e estava lotado.
<p>- Essa foi a única plateia que eu tive.
<p>- E você foi maravilhosa. Quer montar uma dupla comigo?
<p>- Que proposta tentadora. – Ela voltou a rir.
<p>- Esse foi o melhor encontro da minha vida. 
<p>- Poderíamos fazer de novo semana que vem.
<p>- Eu adoraria.
<p>- Está brincando? Eu estou com tanta vergonha que eu não vou passar perto daquele restaurante nunca mais na minha vida.
<p>- Eu estou com medo até de sair na rua depois disso. 
<p>- E se amanhã formos os mais famosos do Youtube?
<p>- Seria interessante. – Will apoiou a loucura. – Olha, isso tudo me mostrou uma coisa.
<p>- O quê?
<p>- Eu não tenho mais dúvida nenhuma. Se a gente conseguiu subir em um balcão em um restaurante e cantar feito loucos para todo mundo ouvir, eu acredito que podemos fazer qualquer coisa. Podemos fazer isso. Nós dois.
<p>- Até porque eu não acho que exista mais alguém no planeta que teria topado fazer isso comigo. 
<p>- Eu penso a mesma coisa. Eu te adoro. 
<p>- Eu também te adoro. – Ela sorriu.
<p>- Quer dar um mergulho agora?
<p>- O quê? Não. – Emily ficou aterrorizada. – Está muito escuro e tem bichos no mar.
<p>- Ems, tem bichos no mar de dia também. 
<p>- Isso eu não vou fazer, eu sinto muito. 
<p>- Nem se eu pedir com jeitinho? – Ele a beijou de leve nos lábios. 
<p>- Não. 
<p>- Nem se eu... te pegar no colo e te levar até lá?
<p>- O quê?
<p>Will a pegou de surpresa. Se levantou bem rápido, a pegou no colo e correu até o mar.
<p>- Não, Will! Não!
<p>Ela tampava o rosto com as mãos mesmo com seus olhos já fechados. A primeira onda gelada bateu nas costas de Will e Emily sentiu algumas gotas em seu rosto. Ele a colocou no chão e ela pisou seus pés descalços na areia.
<p>- Você é louco, sabia? – Ela tentava usá-lo como escudo contra as ondas.
<p>- Já me disseram isso. – Ele riu.
<p>Então ele pegou na mão dela e se jogou na água. Ela caiu por cima dela. 
<p>- Melhor jeito de acabar o encontro! – Ele gritou.
<p>- É sério? – Emily, mesmo assustada, não conseguia ficar brava. Resolveu então ir na “onda” do namorado. – Você é muito, muito louco!</p>
</body></html>";
            }

            if (numero == 12)
            {
                lblTitulo.Text = "Capítulo 12 - Me Diga Quando For A Hora De Eu Dizer Que Te Amo";
                htmlPage.Html = @"<html><body>
<p><i>“Tudo que eu quero é que você entenda
<br>Que quando eu pego na sua mão
<br>É porque eu quero
<br>Todos nós nascemos em um mundo de dúvidas
<br>Mas não há dúvida
<br>Eu descobri
<br>Eu te amo”
<br><b>When It’s Time – Green Day</b></i></p>
<br>
<p>“Amor. Muitas pessoas acham difícil reconhecer esse sentimento. Não sabem o que é. Às vezes amam e não dizem, às vezes dizem, mas não amam. Se confundem, se enganam, é normal. Amor não é um sentimento fácil de descrever, muito menos de sentir. Ninguém sabe o porquê ou se um dia ficará mais fácil. Espero que fique.”.</p>
<br>
<p>Emily e Will estavam tomando café da manhã juntos em uma cafeteria do bairro. Eles ainda comentavam sobre a experiência de cantar no bar na semana passada uma vez ou outra, mas o assunto do momento era sobre as paixões antigas de cada um. 
<p>- Eu me lembro bem da minha primeira paixão, mas ele, com certeza não deve se lembrar de mim. – Emily fez uma cara de arrependimento por tocar nesse assunto.
<p>- Como sabe? Vai ver você foi inesquecível para ele.
<p>- Ele nem sabia quem eu era direito. Um dia ele chegou perto de mim na escola e me deu um bilhete. Dizia “Você quer ser a minha namorada?” e as alternativas “sim”, “não” e “talvez um dia”. – Ela começou a rir da cara que Will estava fazendo. – Eu fiquei toda feliz achando que ele gostava de mim, mas aí ele falou que era um bilhete do amigo dele. 
<p>- Hum, triangulo amoroso. E o que você fez? – Will segurou a risada.
<p>- Eu amassei o bilhete e chutei a canela dele.
<p>- Nossa, que brava.
<p>- Eu tinha dez anos. – Ela tentou se explicar. 
<p>- Pelo menos foi na canela e não nas bolas. – Will riu. – Minha primeira paixão também foi trágica. Eu tinha nove anos. Pedi a borracha dela emprestada, peguei a tesoura e cortei a borracha em formato de coração e devolvi para ela.
<p>- Ai, que fofo.
<p>- Ela não achou nada fofo. Me deu um tapa na cara. – Emily não foi tão compreensiva com a história do namorado como ele foi com a dela e deu uma gargalhada. – Ela ainda me disse que nunca mais ia me emprestar nada. Foi horrível.
<p>- Eu imagino, mas sabe, eu posso te superar. Eu gostava de um garoto o ano passado e eu achei que ele queria ficar comigo, mas descobri que ele só se aproximou de mim para ficar com a minha irmã.
<p>- Nossa. Pesado. 
<p>- Eu dei um soco nele.
<p>- Você tem alguma história em que não acabe com você batendo em um cara?
<p>- Pensando bem, não. Então toma cuidado. 
<p>- Vou tomar. – Ele riu.
<p>- Tirando a Giovanna e os nomes da lista telefônica, namorou mais alguém?
<p>- Não, namorar mesmo só ela. A lista telefônica foi só um lance. 
<p>- Entendi. – Ela deu uma risada.
<p>- Mas eu já disse para nove garotas “você iluminou meu mundo”. 
<p>- Nossa, seu mundo ficou bem iluminado mesmo, hein? Se estava escuro, por que não comprou uma lanterna?
<p>- Não dá para beijar uma lanterna.
<p>- Nada é impossível, querido. – Ela brincou.
<p>- Olha, quer saber, eu acho que eu vou pegar outro bolinho. – Will mirou o balcão onde estavam os bolos.
<p>- Você já comeu três. De maracujá, baunilha e o com gostas de chocolate.
<p>- Bom, agora eu preciso comer o de doce de leite. É a minha tradição de terça-feira.
<p>- Tradição de terça-feira? É por causa dessas suas coisas malucas que eu te amo. 
<p>- O quê?
<p>- O quê?
<p>- O que você disse?
<p>- Que suas coisas são malucas. – Emily tentou mudar de assunto. 
<p>- Não, você disse... – Então ele pensou melhor. – Eu vou buscar o meu bolinho antes que acabe. 
<p>- Tudo bem. – Ela ficou um pouco nervosa.
<p>Will se levantou um pouco cauteloso e foi até o balcão pedir o bolinho. Quando voltou para a mesa, ele decidiu começar um assunto completamente novo, ela não ia falar de novo mesmo.</p>
<center><h4>--*--</h4></center>
<p>Quando Will chegou em casa, encontrou Amanda sentada nos degraus que davam na porta da frente. 
<p>- O que faz sentada aqui? – Will se sentou ao lado da irmã.
<p>- Nada demais. Chris e Ashley estão na sala namorando. Não é um ambiente muito agradável. – Ela revirou os olhos. – Eu senti saudade de você hoje no café da manhã e em todas as manhãs desde muito tempo.
<p>- Eu estava com a Emily. 
<p>- Fingindo surpresa. – Ela sorriu. 
<p>- Quer parar de encher? Eu gosto de ficar com ela. 
<p>- Tudo bem. 
<p>- Olha, hoje aconteceu uma coisa engraçada. Ela disse que me amava.
<p>- É sério? E por que é engraçado? Isso é bom, não é?
<p>- Eu não sei. Foi como se ela tivesse dito sem perceber e depois tentou retirar dizendo que não disse nada. Foi estranho.
<p>- Eu já sabia que ela era louca só por namorar você, mas agora eu sei que tem outros motivos. 
<p>- Será que ela estava esperando eu dizer “eu te amo também”? – Will ficou pensativo.
<p>- Por que não disse? Você a ama?
<p>- Eu não sei. Acho que sim. Sei lá.
<p>- Vocês, garotos, são uns lixos. Dá vontade de dar um tapa na cara de todos vocês.
<p>- Calma, por que está com tanta raiva?
<p>- Esquece.
<p>- Aconteceu algo que eu não sei?
<p>- Não aconteceu nada. Esse é o problema. O problema é comigo? Eu sou feia? Meu corpo é ruim?
<p>- Bom, tirando a sua chatice, você até que é bonitinha.
<p>- Cala a boca.
<p>- Você perguntou. – Will começou a rir. – Está se sentindo carente, é?
<p>- Um pouco.
<p>- Eu não precisava saber disso. – Will fez uma careta.</p>
<center><h4>--*--</h4></center>
<p>Will mexia no seu celular sentado em uma das mesas que ficava no meio do pátio da escola. Estava esperando o horário da sua aula começar e pensando se valeria matar aula ou não.
<p>- Oi. – Sebastian se sentou ao lado dele e parecia um pouco ansioso quando Will respondeu o cumprimento. – Preciso falar com você.
<p>- Pode falar. – Ele bloqueou o telefone e o colocou no bolso. 
<p>- Sabe no outro dia em que você saiu com a Emily e o resto de nós foi para um bar?
<p>- Sei, aconteceu uma coisa lá?
<p>- Bom...
<p>Sebastian não conseguiu terminar sua frase. Jason apareceu do nada quase sem fôlego e se sentou quase caindo do outro lado de Will.
<p>- O que foi que aconteceu? – Will ficou surpreso com a ação do amigo.
<p>- Eu preciso contar uma coisa para vocês. Eu não queria contar, mas acho melhor contar. – Jason falava muito rápido.
<p>- Fala de uma vez. – Sebastian falou.
<p>- Sabe naquele outro dia que a gente foi em um bar sem você e...
<p>- Sim, eu sei. – Will falou sem emoção. – Seb ia me contar uma coisa sobre esse dia.
<p>- Talvez seja a mesma coisa. – Sebastian falou logo um pouco sem graça. – Fala aí, Jason.
<p>- Eu duvido. 
<p>- Vocês vão falar logo? – Will já estava ficando impaciente. 
<p>- Jason viu a Amanda dançando com outro cara, ficou com raiva e foi embora. 
<p>- Ciúmes?
<p>- Eu não fui embora por isso. Eu não estava me sentindo bem, só isso. Vocês sabem que eu não gosto de bar. 
<p>- Relaxa, esse cara com a Amanda não deve ter dado em nada. Ontem mesmo ela estava reclamando que estava carente e com raiva dos homens. – Will o informou.
<p>- Tá, mas não era sobre isso que eu ia falar. – Jason já estava um pouco incomodado com aquele assunto. – Eu fui embora com a Quinn e no caminho para casa ela me beijou.
<p>- O quê?! – Sebastian e Will falaram juntos.
<p>- Foi do nada, a gente estava conversando e de repente, ela me beijou. Eu acho que correspondi, mas não tenho certeza. 
<p>- Nossa, nem começou a namorar a minha irmã e já está traindo ela. – Will começou a gargalhar. – Relaxa, você não fez nada de errado. Devia ficar com a Quinn, ela poderia animar esse seu esqueleto deprimido.
<p>- Eu não estou interessado na Quinn.
<p>- Mas deveria, ela é uma gata. – Sebastian suspirou.
<p>- E ainda te beijou. Melhor do que a Amanda que dança com outros. – Will complementou. – Jason, é sério agora. – Ele encarou o amigo. – Eu não estou dizendo que você deve ficar com a Quinn, mas se não pretende falar para a Amanda que gosta dela, deveria seguir em frente.
<p>- É. – Sebastian concordou.
<p>- Eu nunca vou ter coragem para falar. Eu só sou o Jason, o amigo bobo do Will e do Sebastian. E ela é a Amanda. 
<p>- A irmã boba do Will e do Sebastian. Casal perfeito. – Will riu.
<p>- Ela nunca se interessaria por mim.
<p>- Quantas vezes eu preciso dizer que ela também está interessada? E por que você se rebaixa tanto? Você é inteligente, divertido, uma boa companhia...
<p>- E é boa pinta também. – Sebastian falou.
<p>- Sabe, por experiência própria, não tem nada melhor do que ser correspondido. – Will voltou a encarar o amigo. – Você precisa contar para saber o que ela sente, se ela não sentir nada, você vai sofrer, mas vai seguir em frente.
<p>- Vamos estar aqui para te ajudar. – Sebastian sorriu.
<p>- E se ela sentir algo, que eu tenho certeza que sente, vai ser incrível. É sempre bom saber que alguém te ama ou... que gosta muito de você, principalmente se você sente o mesmo.
<p>- Vocês estão me dando um conselho? – Jason franziu a testa.
<p>- É, eu sei. Estranho, não é? Geralmente a consciência é você. – Will fez uma piada.</p>
<center><h4>--*--</h4></center>
<p>Will se encontrou com Emily naquela tarde. Ela não tocou mais no assunto “referente ao amor” e nem ele. O clima não ficou estranho, era como se nada tivesse acontecido. Os dois estavam sentados na areia da praia. Não era o dia mais quente do ano, a brisa do mar estava bem gelada.
<p>- Você acredita que eu dei um conselho para o Jason hoje?
<p>- Nossa, ele deve estar bem ruim mesmo, hein, onde estava o Sebastian? – Ela brincou.
<p>- Engraçadinha. Ele também me ajudou, mas a maior parte foi eu.
<p>- O que houve?
<p>- No dia que estavam no bar, ele viu a Amanda com outro cara, ficou com raiva e foi embora.
<p>- Aí a Quinn beijou ele.
<p>- Você soube? – Will riu.
<p>- Ela me contou. Disse que era para dar um incentivo para ele finalmente ganhar coragem e conquistar a garota dos sonhos dele. Ela é louca assim mesmo.
<p>- Ela iria enlouquecer o Jason se os dois ficassem juntos, não é? – Will começou a imaginar como seria.
<p>- Ah, ia sim. Vocês são muito amigos, não é? Você e o Jason.
<p>- Conheço ele praticamente a minha vida toda. Compartilhei mais coisas com ele do que com a minha família e vice-versa.
<p>- Como isso aconteceu?
<p>- A gente se conheceu há uns dez anos. Ele era todo tímido e retraído, não muito diferente de hoje em dia, sempre andava sozinho, mas era muito inteligente, então eu pedi para ele me dar algumas aulas porque eu estava ficando para trás. Uma vez, um grupo de garotos estava querendo bater nele, então eu fui lá e bati em todos.
<p>- Sério? – Ela ficou surpresa.
<p>- Não, eles bateram em nós dois. – Os dois começaram a rir. – Claro que não foi sem briga, a gente correu muito antes de nos pegarem, mas eu prefiro a minha versão.
<p>- Eu nunca tive um amigo assim. Sempre foi a Quinn e eu, para falar a verdade, foi até melhor porque não há nada que a gente não faça uma para outra e eu me sinto completa com ela, mas é engraçado.
<p>- O quê?
<p>- Os laços que vocês formaram.
<p>- Deve ser porque a gente passou por muita coisa junto. Eu estava lá quando o pai dele deixou ele e a mãe por um caso qualquer. O casamento dos dois não era muito bom, mas o Jason sempre falava do pai com muito amor até aquele dia.
<p>- Deve ter sido duro para ele.
<p>- É, foi sim. Lembro que eu ofereci o meu pai para ele e desde criança, eu o via como alguém que precisava de proteção. É um problema que eu tenho. – Will riu.
<p>- Eu acho fofo. 
<p>- Não é nada fora do normal?
<p>- Nem um pouco. Qual foi seu conselho para ele?
<p>- Eu disse que ele devia contar tudo para Amanda, porque é sempre bom saber que a pessoa que você ama também te ama.
<p>- Também acho. – Ela sorriu.
<p>O sol já estava se pondo, parecia que ia ser engolido pelo mar a qualquer momento. Emily olhava para o sol desaparecer como se fosse a coisa mais linda que ela já tinha visto, e enquanto Will a observava só pensava que estava na cara que ela nunca tinha se visto no espelho, ou que não compartilhavam a mesma opinião, porque para ele, ela era a coisa mais linda que qualquer pessoa já tinha visto.</p>
<center><h4>--*--</h4></center>
<p>- Você está bem?
<p>Quinn seguiu Emily até o seu quarto quando ela chegou em casa e estranhou quando ela se jogou na cama e deu um suspiro irritado.
<p>- Eu estou, na verdade. – Emily levantou a cabeça e apoiou os cotovelos no colchão para falar com a irmã que se sentou na sua poltrona ao lado da cama.
<p>- Então...
<p>- Eu amo o Will.
<p>- Nossa! – Quinn ficou impressionada. – Eu sabia que você gostava dele, mas...
<p>- É, eu sei. Tipo... eu acho que já sabia antes e agora eu só confirmei. 
<p>- Você disse a ele?
<p>- Na verdade, meio que escapou dias atrás, mas eu me apavorei e fingi que não disse nada. Aparentemente, ele também se apavorou porque fingiu que não ouviu.
<p>- Garotos são idiotas. Não sabem lidar com isso.
<p>- Acho que eu também não sei. Eu nunca senti isso por alguém e eu achei que seria difícil dizer, mas simplesmente disse. 
<p>- Não. Acho que o mais difícil é sentir. – Quinn riu. – Eu pelo menos nunca senti. 
<p>- Nem quando beijou o Jason? – Emily brincou.
<p>- Foi engraçado. O garoto ficou parado feito estátua. – Quinn deu uma gargalhada. – Ele está muito interessado na Amanda, logo, logo não vai conseguir nem disfarçar.
<p>- Eu te amo.
<p>- De onde isso veio?
<p>- Eu não sei. – Emily riu. – É que é sempre bom saber que a pessoa que você ama também te ama. Então... eu te amo.
<p>- Eu também te amo, sua boba.</p>
<center><h4>--*--</h4></center>
<p>Depois que começou a namorar com Emily, Will percebeu uma coisa: ela passava muito tempo na biblioteca. Era nos intervalos entre as aulas, às vezes no almoço, muitas vezes ficava lá depois da aula. Ele sempre ia para lá quando sabia que ela ainda estava na escola e queria encontrá-la. Logo, ele começou a frequentar a biblioteca mais que o normal também. 
<p>Era engraçado quando ela começava a falar sobre livros ou assuntos históricos e ele ficava concordando como se tivesse lido também, mas ela também não se importava, ela falava mesmo assim. Will não gostava quando ela estava estudando alguma matéria e começava a tentar ensiná-lo também, nesses momentos ele preferia deixá-la sozinha com seus livros, mas ele nunca sabia exatamente se ela lia algo para uma prova ou só por hobby. 
<p>- Por que você está lendo um livro sobre a Guerra Fria? – A mesa onde estavam havia vários livros abertos, o caderno dela estava no meio deles e ela não parava de fazer anotações nele. 
<p>- Eu já te disse, eu tenho uma prova sobre isso amanhã.
<p>- Você me disse ontem tudo sobre a Guerra Fria. Você já sabe de tudo.
<p>- Só não quero deixar passar nenhum detalhe.
<p>- Você já me deu tantos detalhes que eu podia jurar que você até esteve lá.
<p>- Cala a boca. – Ela deu um tapa de leve no ombro dele e começou a rir. 
<p>- Eu nunca pensei que namoraria uma nerd. Vai contra tudo o que eu acredito.
<p>- Sinto muito que esteja decepcionado. 
<p>- Você faz a decepção ser ótima. Agora eu sei porque o Rony continuou gostando da Hermione mesmo ela ficando vinte e quatro horas por dia na biblioteca.
<p>- Você é muito chato, sabia?
<p>- Sério? Porque três dias atrás você disse que me amava. 
<p>- O quê?
<p>Os dois ficaram se olhando em silêncio. Will demonstrou na hora que se arrependeu de ter dito aquilo e Emily parecia muito sem graça e surpresa por ele ter tocado no assunto tão de repente.
<p>- Eu não acredito que eu disse isso, mas agora eu disse, já era. Então... – Will respirou fundo. – Você me ama?
<p>- Eu não disse com essa intenção, eu disse... – Ela não sabia o que dizer.
<p>- Você me ama? – Ele perguntou de novo.
<p>- Will, eu... – Ela o olhou nos olhos. – Eu...
<p>- Olha, você é incrível e toda vez que eu estou com você... Nossa! Você me ama? – Ele voltou a perguntar. – Porque eu te amo. 
<p>- Ama?
<p>- Amo. – De repente ele não ficou mais tão nervoso. – Eu te amo, Ems.  
<p>- Eu também te amo. – Ela sorriu.
<p>- Sabe, na lista de todos os lugares que eu pretendia dizer que te amava, a biblioteca não estava nela.
<p>- Por que não? Esse lugar é o mais romântico. – Ela riu.
<p>- Como não amar você? – Will a beijou.
<p>- Você não pode me beijar aqui. – Ela se afastou bem rápido mesmo depois de ter correspondido o beijo e começou a cochichar.
<p>- Mas é claro que eu posso e sabe por quê?
<p>- Por quê?
<p>- PORQUE EU TE AMO! – Ele deu um grito.
<p>Todo mundo que estava estudando em mesas perto da deles começou a olhar para Will como se ele fosse louco.
<p>- Para. – Emily tentou esconder o rosto de vergonha.
<p>- O que? Nunca viram um cara apaixonado? – As pessoas continuavam encarando. – Agora estão vendo. Eu amo essa garota. – Ele se levantou e apontou para Emily. – E ela também me ama.
<p>Era uma questão de tempo até a bibliotecária tentar expulsá-los do lugar.
<p>- Você também me ama. – Ele continuou afirmando.
<p>- Eu amo. – Ela não gritou, mas todo mundo ouviu. – Agora senta.
<p>Ela puxou a camisa dele e o fez sentar de volta ao seu lado.
<p>- O quê? – Ele começou a rir.
<p>- Você me disse que não era o tipo de cara que gritava na multidão que amava alguém, nem faria serenatas e que não era o mais romântico e tudo mais.
<p>- Acho que eu estava enganado. Porque eu poderia fazer um show agora só para você. 
<p>- Bobo. 
<p>Emily olhou ao seu redor, deixou a vergonha de lado e o beijou. Eles ouviram palmas e gritos, como se todo mundo ainda estivesse ouvindo a conversa dos dois na espera do beijo. Os dois sorriram um para o outro assim que terminaram o beijo. Foi, sim, o melhor “eu te amo” da história.<p>
<br>
<p>“Meu coração bate forte. Minhas mãos suam. Minha adrenalina sobe. Minha mente vai até o céu e volta. Isso é amor para mim. Eu sinto isso, nem sempre na mesma ordem ou todos juntos, quando estou com ela. Eu sinto isso. Ela me transforma em uma pessoa melhor. Sou mais feliz. Sou mais humano. Eu a amo.”.</p>
</body></html>";
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
            if (condicao + 1 > 12)
            {
                Navigation.PushModalAsync(new Capitulo3Page(condicao + 1));
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