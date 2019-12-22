using InsoniaLiteraria04.Database;
using InsoniaLiteraria04.EsseMundoView;
using InsoniaLiteraria04.Global;
using InsoniaLiteraria04.Helper;
using InsoniaLiteraria04.Model;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InsoniaLiteraria04.AnjoMorteView
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
            mostrarCapituloSalvo("AnjoMorte", "Capitulo" + numero.ToString());

            if (numero == 0)
            {
                lblTitulo.Text = "Prólogo";
                htmlPage.Html = @"<html><body>
<p>Meu nome é Lisa Penelope Tompkins, sou a garota que perdeu os pais em um acidente de carro logo após o enterro de seu irmão mais velho, quando tinha apenas catorze anos. Então você deve estar pensando “que garota azarada”.  Bem, espere para ver o resto da história.
<p>Eu tenho vinte e seis anos e acabei de me mudar da casa de minha tia Tania. Quando fechei a porta da casa de minha tia hoje cedo, eu finalmente percebi que as pessoas pararam de me deixar quando parei de me agarrar a elas.
<p>Não me leve a mal! Eu não sou uma dessas pessoas extremamente necessitadas de atenção e cuidados. Ainda assim, de vez em quando, seria legal saber que alguém precisa de mim e que sente minha falta quando estou distante.
<p>Quando eu perdi meus pais, também perdi meus amigos, professores, colegas da escola e todos que eu conhecia. Fui forçada a me mudar de Wilmington, Carolina do Norte, nos Estados Unidos, para a capital do menor estado brasileiro, indo viver na casa da irmã de minha mãe. Mesmo com todas essas perdas, eu não queria ter me afastado do lugar onde eu havia crescido, o que complicou, ainda mais, a vida de meus tios quando cheguei a casa deles.</p>
</body></html>";
            }

            if (numero == 1)
            {
                lblTitulo.Text = "Capítulo 1";
                htmlPage.Html = @"<html><body>
<p><i>“Alguém uma vez disse que a morte não é a maior perda da vida. 
<br>A maior perda é o que morre dentro de nós quando ainda estamos vivos. 
<br>Poderia te dizer quem disse isso, mas quem se importa?”
<br><b>Haley James Scott/One Tree Hill</b></i></p>
<br>
<p>A data era seis de fevereiro do ano de dois mil e quatro, eu voltava da reunião semanal da banda harmônica do colégio acompanhada de Jesse, meu amigo de infância, nós éramos vizinhos, por isso, sempre voltávamos juntos para casa depois da aula. Entrei apressada em minha casa fugindo do frio que fazia lá fora, acabei não notando que o carro dos meus pais não estava estacionado em frente a garagem.
<p>- Mãe, cheguei! – Gritei ao pé da escada, mas não recebi resposta. – Mãe? Pai? Vocês estão em casa? – Tornei a chamar procurando por eles pela casa.
<p>Ao chegar a cozinha encontrei uma folha de papel presa por um ímã à porta da geladeira, era um bilhete de minha mãe: Fomos ao hospital. Josh teve complicações. Te ligamos quando tivermos notícias. O jantar está no forno, é só esquentar. Peguei o telefone que estava sobre a mesa da cozinha e disquei o número do celular de meu pai.
<p>- Droga! – A ligação não completou por causa do mal tempo. Era inverno nos Estados Unidos e naquele dia estava nevando muito.
<p>Josh era meu irmão mais velho, um ano antes ele havia passado mal durante uma aula na faculdade, seus amigos o levaram ao pronto socorro do campus onde os médicos o diagnosticaram com anemia aguda. Nossos pais o levaram a um especialista para tratar da anemia, no entanto, após analisar os resultados da bateria de exames que havia solicitado, o médico concluiu que a anemia de Josh, na verdade, era apenas um sintoma de algo mais grave.
<p>Aos vinte anos meu irmão foi diagnosticado com leucemia. No último ano ele havia sido internado no hospital várias vezes. A mais recente tinha ocorrido alguns dias antes do Natal. Seus rins tinham parado de funcionar, o que impediu que ele deixasse o hospital como das outras vezes. Josh ficou no hospital mais de um mês.
<p>No início eu não queria sair do lado dele, mas algumas semanas após sua internação, durante uma de minhas visitas diárias, vi meu irmão em agonia, gritando e chorando por causa de dores nos ossos e em todo o corpo. Desde então, eu não o visitava, não suportava a ideia de vê-lo sofrendo tanto sem que eu pudesse ajuda-lo. E então o bilhete de minha mãe dizendo que ele “teve complicações”.</p>
<br>
<p>COMPLICAÇÕES.</p>
<br>
<p>Um ano acompanhando as idas e vindas de Josh ao hospital tinha me ensinado a me apavorar ao ouvir esse termo. Bem... eu estava certa sobre isso!
<p>Meu irmão morreu dois dias depois, aos vinte e um anos de idade. Meus pais não conseguiram me dar a notícia. Jesse, meu amigo de infância, que se voluntariou para me contar a respeito. A sensação que tive foi de que morreria junto com ele, infelizmente, sua morte era só o começo do meu sofrimento.
<p>Durante o velório eu fiquei a maior parte do tempo no quintal de minha casa. Não suportava olhar para as pessoas e receber delas olhares de compaixão fingida, elas agiam como se soubessem pelo que eu estava passando. Talvez a única além de mim que entendesse de verdade a dor que aquilo causava fosse Claire, a namorada de Josh. Ela e mamãe nunca se deram muito bem, mas a morte dele parecia tê-las unido, as duas estavam abraçadas se apoiando uma na outra ao lado do caixão da última vez que as vi.
<p>Eu não fui ao enterro, não porque não quisesse me despedir uma última vez de meu irmão, mas porque acabei cochilando sentada no antigo balanço onde Josh costumava me balançar quando eu era criança, quando acordei todos já haviam partido para o cemitério e eu tinha apenas uma leve noção de que Jesse estava sentado nos degraus que levavam de volta para o interior de minha casa, me observando.
<p>Já era noite quando eu criei forças para levantar dali e entrar, estava nevando e mesmo assim eu fiquei sentada do lado de fora durante horas. Encontrei Jesse na cozinha tentando fazer chocolate quente, o agradeci, mas tomei seu lugar antes que o loirinho pusesse fogo em toda a casa. Ele foi até o balcão da cozinha e ligou a TV, nenhum de nós prestava realmente atenção na programação até que ela foi interrompida para transmitir ao vivo um acidente de carro que tinha ocorrido a alguns quarteirões de minha casa.
<p>A repórter informou que um dos carros que trabalhava na retirada da neve da estrada havia perdido os freios e deslizado ladeira a baixo atingindo dois carros que passavam por uma rua perpendicular a aquela.
<p>-... testemunhas afirmam que os carros voltavam de um enterro, os passageiros de um dos carros não resistiram e morreram antes da chegada dos bombeiros... – A repórter continuava a transmissão.
<p>- Lisa? Você está bem? – Jesse me perguntou quando ouviu eu derrubar o copo com chocolate quente, fazendo-o espedaçar pelo chão. – Lisa?
<p>- Jesse, o carro... o ca-carro... – Eu tentava dizer.
<p>- Que carro, Lisa? Do que você está falando? – Ele perguntava preocupado ao ver meu olhar de desespero.
<p>- O carro dos meus pais. – Foi o que eu consegui dizer e apontei para a TV que mostrava de perto os veículos envolvidos no tal acidente. Meus olhos não cessavam as lágrimas, Jesse me segurou evitando que eu caísse no chão cheio de cacos de vidro.
<p>Me soltei dos braços de Jesse e fui em direção a porta da frente, saí em disparada para o local do acidente com ele a meu encalço. Eu esperava que fosse só confusão da minha mente, que quando eu chegasse no endereço dado pela repórter não seria o carro dos meus pais que estaria lá. No entanto, mais uma vez naquela semana, eu estava certa.
<p>Eu odiava estar certa! Odiava estar certa sobre as complicações de Josh. Odiava estar certa sobre o carro que vi na tela da TV. Eu me odiava.
<p>O outro carro envolvido no acidente era o dos pais de Claire, estranhei quando Josh me disse que só eles dois estavam no carro e que haviam sofrido apenas alguns arranhões.
<p>- Cadê a Claire? – Perguntei a Jesse.
<p>- Lisa... – Ele não precisou completar a frase, o olhar dele denunciava o que ele não conseguia me dizer.
<p>Eu não suportei, nesse momento eu entrei em desespero, eu gritei aos prantos nos braços dele que apenas me abraçava e tentava me acalmar. Lembro de ele dizer que Claire estava no carro com os meus pais na hora do acidente e que ela estava voltando com eles para me ver. Eu não sei como Jesse conseguiu saber dessas coisas, afinal era apenas uma criança como eu, mas naquele momento nada disso me importava.
<p>Tudo o que eu conseguia me importar era com a dor que estava sentindo. Tinha acabado de perder meu irmão, meus pais e minha cunhada em um mínimo espaço de tempo. Era como se o anjo da morte estivesse ao meu lado com uma arma carregada e apontada para a cabeça das pessoas que eu amava, toda vez que eu pensava sobre alguma delas elas acabavam mortas de uma forma trágica.
<p>Talvez as pessoas pensem: a morte não é sempre trágica? Nem sempre! Existem pessoas que morrem quando estão bem velhinhas e já tiveram uma vida longa e produtiva, pessoas que dedicam suas vidas a cuidar dessas outras por toda a vida e se dão o direito de também descansar ao lado dos seus entes queridos. Existem também religiosos que acreditam que a morte é uma dádiva, assim como os solados quando ela vem através do combate e da guerra. Para essas pessoas e seus familiares a morte não é vista como uma tragédia, ela é recebida de bom grado e representa o final de um ciclo.
<p>Então, as pessoas perguntariam: o que é uma morte trágica? É quando um rapaz de vinte e poucos anos é levado para o outro lado por uma doença que agiu silenciosa e foi descoberta tardiamente. Ou quando um acidente de carro leva os pais e a cunhada de uma menininha de catorze anos que acabou de perder seu irmão mais velho. Ou quando uma vida é tirada por um marginal que prefere viver do crime que se esforçar trabalhando em um emprego digno. A morte trágica é quando uma dessas coisas ou todas elas acontecem e além de acabar com a vida daqueles que ela leva também destrói a vida daqueles que estavam ao seu redor.</p>
</body></html>";
            }

            if (numero == 2)
            {
                lblTitulo.Text = "Capítulo 2";
                htmlPage.Html = @"<html><body>
<p><i>“A mais lamentável de todas as perdas é a perda do tempo.”
<br><b>Philip Chesterfield</b></i></p>
<br>
<p>As semanas seguintes se passaram como um borrão para mim. Tudo o que lembro é que o enterro de meus pais foi adiado por alguns dias até que a irmã de minha mãe pudesse vir do Brasil para cuidar de tudo, já que eu era menor de idade e a única outra pessoa que poderia se responsabilizar por isso era meu irmão, mas ele também estava morto.
<p>Minha vida se resumiu em: ignorar os “Eu sinto muito!” de todos os colegas de trabalho, amigos, conhecidos e vizinhos dos meus pais; ignorar quaisquer palavras de socorro que Tania, irmã de minha mãe, dissesse, não importando que isso a magoasse; gritar com Jesse para que ele me deixasse sozinha; e depois me agarrar a ele e encharcar sua camisa com lágrimas. 
<p>Tia Tania tentava conversar comigo, puxar assunto sobre o colégio e a minha vida nos Estados Unidos durante as refeições, mas tudo o que ela recebia como resposta era o silêncio. Olhar para ela me deixava ainda mais triste. Seu cabelo loiro perfeitamente preso em um rabo de cavalo majestoso e sua postura, digna de grandes bailarinas, me faziam lembrar de minha mãe. Elas eram muito semelhantes, até mesmo na forma firme e carinhosa de falar. Naquela época eu não conhecia minha tia muito bem e isso me deixava irritada, porque eu me pegava observando suas ações que me pareciam tão familiares e me davam mais saudade de minha mãe.
<p>Durante a noite eu tinha dificuldade para dormir, ficava agarrada ao meu travesseiro chorando e lamentando todas as vezes que eu deixei de participar de coisas junto com meus pais e com Josh por birra, então eu apagava de exaustão.
<p>Uma manhã eu acordei com batidas na porta do meu quarto, me levantei xingando quem quer que estivesse se atrevendo a me incomodar e dei de cara com minha tia segurando uma mochila em uma das mãos e um enorme copo de vitamina de frutas na outra:
<p>- O que você quer? - Perguntei ignorando seu ar determinado e voltando para minha cama.
<p>- Levanta dessa cama e vai tomar um banho, está na hora de você ir para a aula. O Jesse está te esperando lá em baixo, disse que só sai daqui com você.
<p>- Avise a ele que hoje ele não vai assistir aula. - Me virei na cama, ficando de costas para ela esperando que ela desistisse de me fazer ir à escola.
<p>- Não, senhora! - Tia Tania disse, já puxando minhas cobertas me fazendo escorregar da cama para o chão. - Eu sou responsável por você agora, isso quer dizer que você tem que fazer o que eu digo, quer queira quer não. Agora, trate de tomar essa vitamina e se arrumar, vocês já estão atrasados. - Ela saiu do quarto batendo o pé sem nem mesmo esperar uma resposta.
<p>- DROGA! - Gritei alto para garantir que ela ouvisse.
<p>A mulher já havia percebido, em tão pouco tempo, que usar o Jesse era a melhor forma de me obrigar a fazer o que eu não queria. Alguns dias antes tinha feito a mesma coisa para me convencer a ir ao ensaio da banda. Mesmo com meus argumentos de que não fazia sentido eu retomar quaisquer atividades que eu costumava praticar se em pouco tempo eu estaria de mudando com ela para o Brasil, Tania foi imbatível e agora fazia o mesmo em relação aos meus estudos.
<p>E foi assim que eu fui obrigada a voltar a minha rotina, uma chantagem após a outra. Eu até me sentia um pouco mal pelo Jesse, o coitado era o mais novo objeto de uso de minha tia contra o meu luto. Até cheguei a questioná-lo, certa vez, do porque de ele se deixar levar sempre que minha tia o chamava para me obrigar a sair de casa:
<p>- Jesse, você não cansa de ser usado por minha tia? - A gente estava saindo de casa para ir ao cinema com o pessoal da escola.
<p>- Na verdade, eu que me ofereci para ajudá-la. - Ele confessou, sem jeito, passando as mãos pelos cabelos loiros e sorrindo sem graça. - A ideia de te chantagear com a minha presença foi minha, eu sabia que você não me faria perder os ensaios ou as aulas por puro capricho.
<p>- Você é inacreditável! - Falei, fingindo estar magoada.
<p>Depois de caminharmos em silêncio por alguns minutos ele voltou a falar:
<p>- Eu não acredito que você vai mesmo embora para o Brasil. - Ele vinha tentando me animar quanto a viagem, mas aqueles olhos azuis, que sempre se enchiam de lágrimas quando tocava no assunto da mudança, o denunciavam.
<p>- Nem eu! - Concordei abaixando a cabeça.
<p>- Vocês já sabem quando vão? - Ele perguntou.
<p>- Daqui três dias. - O informei.
<p>- Já? – Jesse me olhou surpreso. - Não achei que seria tão rápido.
<p>- Pois é! Tia Tânia precisa voltar para o trabalho e para a família dela. O marido dela é advogado e está cuidando dos problemas jurídicos que envolvem a minha ida para o Brasil.
<p>- Pelo menos você vai poder conhecer seus primos. - Jesse, como sempre, tentava me fazer ver o lado positivo das coisas.
<p>Essa foi a última vez que eu e Jesse conversamos de verdade. Os três dias seguintes eu fiquei muito ocupada empacotando minhas coisas para a viagem. Tia Tânia passava os dias catalogando os pertences de meus pais e de meu irmão para poder enviá-los ao depósito que ela havia providenciado uns dias antes. Durante todo o tempo Jesse não apareceu em minha casa ou me ligou, eu sabia que ele estava triste por eu estar partindo e preferi deixá-lo em paz para que nós dois pudéssemos começar a nos acostumar com a ausência um do outro.
<p>Mais tarde eu percebi que esse foi mais um momento em que eu perdi tempo, ao invés de aproveitar os momentos que me restavam com alguém que eu gostava, eu banquei a insensível e fingi que não era nada de mais.
<p>Quanto tempo é necessário para se perceber que você esteve lamentando as coisas erradas? Uma semana? Um mês? Anos? Depende de quanto tempo você leva para perceber que tudo o que você conseguiu foi perder tempo, perder chances de mudar as coisas, perder pequenos ou grandes momentos, perder novas experiências.</p>
</body></html>";
            }

            if (numero == 3)
            {
                lblTitulo.Text = "Capítulo 3";
                htmlPage.Html = @"<html><body>
<p><i>“Eu estou aqui sozinho, não queria partir. Meu coração não se move, está incompleto.”
<br><b>No Air (Jordin Sparks, participação de Chris Brown)</b></i></p>
<br>
<p>Eu estava no Brasil há pouco mais de uma semana e sentia tanta falta de Jesse que parecia que ele estava morto como meus pais e meu irmão. Apesar de morar com minha tia e a família dela eu ainda me sentia sozinha. Era como se meu corpo estivesse no Brasil e minha alma estivesse presa em Wilmington.
<p>Tia Tania obrigou seu enteado, Rodrigo, de dezesseis anos, a me ajudar a arrumar meu novo quarto, o que ele fez com relutância. Eu não o culpava por estar emburrado, minha chegada repentina tinha o obrigado a dividir o quarto com seu irmão mais novo, Adriel, de quatro anos. Mas não custava nada ele ser educado e ao menos perguntar se eu estava bem.
<p>Alguém pode estar se perguntando: não era ela que estava ignorando as perguntas e palavras solidárias? As pessoas que falam essas coisas, na maioria das vezes não se importam de verdade com o que você vai responder, elas só perguntam por educação e para se sentir melhores consigo mesmas, para poderem encostar a cabeça no travesseiro a noite e dormir com o sentimento de dever cumprido. Por que eu não as respondia? Porque elas não se importavam e, se elas não se importavam, elas não precisavam saber a minha resposta. Isso não quer dizer que Rodrigo não poderia ter sido um pouco mais solidário com a minha nova realidade.
<p>Bom, meu quase-primo, Rodrigo, conseguiu passar cinco horas carregando coisas da sala para meu novo quarto sem me direcionar uma palavra que não fosse relacionada ao local onde eu queria que ele deixasse a caixa que ele estivesse carregando. Ao contrário dele, meu priminho, Adriel, me bombardeava com perguntas bobas que todas as crianças de quatro anos fazem e fazia de tudo para chamar minha atenção. Ele até fez um desenho para mim, onde nós dois estávamos brincando e o irmão dele ao fundo com os fones no ouvido.
<p>A cidade que minha tia morava se chama Aracaju, é a capital do menor estado brasileiro, Sergipe. Não era uma cidade muito grande, mas era agradável e aconchegante, apesar do calor intenso que fazia naquela região, ao qual eu não estava nem um pouco habituada. Ao menos nós estávamos localizados no litoral do país, o que me permitia ir à praia sempre que queria fugir de tudo e ficar sozinha, o que significa que eu gastei muito protetor solar.
<p>Nos primeiros meses ali, minha tia me obrigava a passar protetor solar toda vez que eu sonhava em por o pé fora de casa. Isso me irritava bastante, mas eu o fazia mesmo assim, para evitar discussões e porque eu sabia que alguém que era quase transparente de tão branca e que a única parte do corpo que não parecia leite eram os olhos e cabelos negros, que herdei de meu pai, não sobreviveria nem dez minutos sem proteção contra o sol daquele lugar.
<p>Esses momentos eram um dos poucos em que eu via Rodrigo demonstrar algum tipo de emoção, que nesse caso, era zombar da minha cara coberta de protetor solar. A convivência com ele foi melhorando com o tempo, nós ainda não éramos amigos, mas ao menos ele se dispunha a me cumprimentar com um “Bom dia!” pela manhã e a acenar com a cabeça e sorrir de lado quando passava por mim nos corredores do colégio.
<p>Embora eu desconfie que ele só fazia isso pra se divertir com a cara que eu fazia quando as meninas da minha turma corriam em minha direção eufóricas para saber como eu conhecia o garoto mais cobiçado do terceiro ano. Como meu português não era dos melhores (eu havia aprendido o idioma desde criança, por causa de minha mãe, mas nunca havia precisado usá-lo com tanta frequência, até esse ponto) eu acabava xingando elas em inglês e saía emburrada na direção contrária a que ele tinha tomado. As garotas, em sua maioria, me chamavam de mal-educada, elas entendiam o que eu falava graças a ótima estrutura curricular do colégio no qual minha tia insistiu em me matricular.
<p>De acordo com o calendário escolar brasileiro, eu estava cursando o segundo ano do ensino médio e Rodrigo o terceiro, e último, ano. Não diferente de como era nos Estados Unidos, eu mantive minha performance de aluna exemplar, menos nas matérias que envolviam conhecimento gramatical, Língua Portuguesa e Redação, ao menos em Literatura eu conseguia me virar bem.
<p>O colégio achou de bom tom informar a Tia Tania que eu estava falhando nessas matérias, logo quando estávamos prestes a entrar de férias no meio do ano. Foi então que minha tia teve a magnífica ideia, a qual nós dois odiamos, de fazer Rodrigo me dar aulas de Português todas as tardes até o final das férias.
<p>Rodrigo chiou e esperneou durante horas (eu também, mas isso não vem ao caso), mas de nada adiantou, no final Tia Tania apelou para o orgulho dele, o acusando de não ser tão bom em tudo como todos achavam no colégio, sentindo-se ofendido, ele aceitou a incumbência de ser meu tutor com a condição de que não precisaria olhar na minha cara durante os finais de semana.
<p>Até aqui, vocês devem estar chamando minha tia de chantagista, mas esse é basicamente o modus operandi dela quando se trata de conseguir o que quer, minha mãe era exatamente igual, sempre apelava para o ponto fraco das pessoas, deve ser uma habilidade genética ou algo do tipo. Eu não sei bem explicar, já que herdei muito mais coisas de meu pai que de minha mãe, inclusive o talento de saber que tinha perdido a briga antes de fazer papel de trouxa. O que não quer dizer que eu sempre soube a hora de parar de discutir, como eu já disse, Rodrigo não foi o único a não gostar da ideia.
<p>Então vieram as férias de junho, para outros isso era sinônimo de diversão e relaxamento, para mim era sinônimo de castigo e tortura. Eu conseguia escapar de quase tudo apelando para o lado sentimental das pessoas, não que eu gostasse de me fazer de coitada por perder a família de forma tão trágica, mas porque as pessoas enxergavam a tragédia antes de me enxergar. Naquele momento, eu achava que o tal Anjo da Morte e minha tia poderiam ser grandes amigos, os dois pareciam se divertir bastante às custas do meu sofrimento.
<p>- Ei, emburradinha! - Rodrigo me chamava e eu tentava fingir que ele não estava ali. - Olha, não adianta você ficar de birra, eu gosto dessa situação tanto quanto você. Por isso, me poupe o discurso, levanta dessa cama e se arruma.
<p>- Me arrumar pra quê? Essa roupa não está boa o bastante para ser a nova Padawan do Mestre Rodrigo? - Indaguei com ironia.
<p>- À biblioteca vamos nós. - Meu português estava melhor, ainda assim eu demorei alguns segundos para perceber que ele estava falando igual ao Mestre Yoda. Eu fechei a cara de novo, ia ser difícil continuar odiando uma pessoa que respondia a suas ironias à altura e que entendia suas referências a Star Wars. - Anda!
<p>- Tá bom! Dá licença, pra eu poder trocar de roupa? - Falei o empurrando para fora do meu quarto. Eu já começava a achar que minhas férias iam ser um inferno.
<p>Ele me levou à Biblioteca Epifânio Dória, num bairro chamado Treze de Julho, passamos algumas horas lá. O pior era que eu não tinha muito do que reclamar, ele realmente parecia ser bom em tudo o que fazia. Durante duas semanas nós fazíamos a mesma coisa, de segunda à sexta, após o almoço, pegávamos um ônibus e íamos até lá. Ele me explicava coisas como concordância verbal, formação de frase e tipos de advérbios.
<p>No final da tarde, ele me levava até a sessão de histórias infantis e me deixava escolher uma, eu tinha que ler a história e fazer um resumo escrito que ele corrigiria no dia seguinte. Na segunda sexta-feira das férias ele não me levou à sessão infantil e eu estranhei.
<p>- Sem leitura para o final de semana?
<p>- Vai sonhando! - Ele falou rindo. - Na verdade, eu tenho um presente pra você, pelo seu bom desempenho e por ter sido uma aluna boazinha a maior parte do tempo.
<p>- Um presente? - Perguntei um tanto desconfiada. Rodrigo confirmou com a cabeça.
<p>- Mas você só vai saber o que é quando chegarmos em casa. - Ele riu do bico que fiz, infeliz por ter que esperar até chegar em casa para ganhar meu presente. - Agora vamos, já está escurecendo e eu mal posso esperar para me ver livre de você por um final de semana inteirinho. - Eu fiz careta para ele que continuou rindo da minha infantilidade.
<p>Meu professor de meio tempo se aproveitou da minha ansiedade para se divertir ao me torturar adiando a entrega do meu presente para depois do jantar.
<p>- Lisa, não coma tão rápido. Vai acabar se engasgando. - Tia Tania me advertia. - O que deu em você? Nunca te vi com tanta fome.
<p>Eu não a respondi, apenas continuei a engolir meu cuscuz com queijo dando uma golada ou outra no café para não engasgar. Quando terminei meu jantar os outros ainda não estavam nem na metade, eu passei a encarar Rodrigo que comia lentamente, saboreando cada partícula de milho do seu cuscuz e cada molécula de lactose contida em seu queijo. Provavelmente, estava fazendo aquilo para me tirar do sério e eu aceitei o desafio. Passados cinco minutos, a comida dele parecia estar rendendo em seu prato, quanto mais ele comia mais faltava para ele comer.
<p> É sério isso? - Perguntei irritada. Minha tia se sobressaltou com meu ataque súbito e se engasgou com sua comida, Jorge, seu marido, correu para ajudá-la, dando tapinhas de leve em suas costas para ajudá-la a desobstruir as vias aéreas. Eu tinha uma leve noção de que aquilo era cientificamente ineficiente, mas não quis falar nada. Depois de alguns minutos de alvoroço, os quais meu infame professor permaneceu quieto com um meio sorriso no rosto, Tia Tania falou com a voz ainda afetada pelo engasgo recente:
<p>- O que foi isso? - Ela soou controlada e sem perder a postura, como sempre. O pequeno Adriel foi mais rápido que eu em responder, me surpreendendo que ele soubesse o que se passava.
<p>- Rodrigo está deixando Lisa doida por causa do presente. - Ele falou com ar de satisfação por saber o que estava acontecendo e sua mãe não.
<p>- Que presente? - A mãe dele continuava não entendendo nada.
<p>- Não é nada, tia. - Respondi e pedi licença me levantando da mesa e indo para meu quarto a passos largos.
<p>Uma hora depois ouvi alguém bater na porta do meu quarto, ao entreabrir a porta uma cabeleira castanho-escura lisa entrou em meu campo de visão, seu olhar penetrante parecia me desafiar a não deixá-lo entrar e ficar sem saber o que ele tinha para mim. Mas eu sabia que não seria capaz de ficar nem mais um minuto sem saber o que era, optei por deixá-lo entrar.
<p>- O quê? - Perguntei ao notar ele me observando como se eu fosse um extraterrestre.
<p>- Sem briga, discussão, tapas, nada? Assim você me desaponta! Talvez eu deva deixar para entregar isso só amanhã. - Ele ameaçou sair do quarto levando consigo o embrulho retangular que trazia.
<p>- Ei! - Eu me coloquei entre ele e a porta fazendo ele rir. - Você não vai a lugar algum antes de me entregar o meu presente. - Tentei soar ameaçadora, mas tudo que consegui foi fazê-lo rir mais.
<p>- Tudo bem, vai, está aqui o seu presente! - Ele me entregou e sentou na minha cama me observando abrir o embrulho desesperadamente. Segundo ele, eu parecia uma criança abrindo o presente que Papai Noel tinha deixado para ela na noite de Natal. Era um livro, mas dessa vez não era uma bobagem para crianças. - A Estrela Sobe. - Li o título em voz alta.
<p>-Isso! Quero ver se você já consegue ler algo que não tenha princesas e vovozinhas para serem salvas. - Ele falou sério. - A escrita pode ser um pouco rebuscada, devido a época em que a história se passa, mas eu espero, de verdade, que você não tenha problemas e que você goste. A história é bem interessante.
<p>Eu não ouvia de verdade o que ele estava falando sobre o livro, minha cabeça já estava absorta em suposições a respeito do que se passava naquela história. Rodrigo se levantou para sair do meu quarto e eu o abracei em um impulso, ainda estava eufórica pelo presente, não ganhava um desde meu aniversário no ano anterior, já que passamos o Natal e meu aniversário desse ano no hospital com Josh.
<p>No início ele se surpreendeu, mas acabou retribuindo o abraço. Eu vi tia Tania passando pelo corredor e me soltei dos braços dele.
<p>- Obrigada! - Disse sorrindo. Ele apenas acenou com a cabeça sorrindo de lado, como fazia quando me encontrava nos corredores do colégio.
<p>- Boa noite, Lisa!</p>
</body></html>";
            }

            if (numero == 4)
            {
                lblTitulo.Text = "Capítulo 4";
                htmlPage.Html = @"<html><body>
<p><i>“Amor é um conhecido. Amor é um demônio. Não há anjo malvado além do amor.”
<br>Trabalhos de Amor Perdidos
<br><b>(William Shakespeare)</b></i></p>
<br>
<p>Rodrigo tinha razão em dizer que a escrita do livro era um tanto rebuscada, mas era compreensível, já que a história retratava a sociedade carioca da década de 1930. Eu me ocupei de ler A Estrela Sobe assim que ele deixou meu quarto, passei horas lendo a história, até que adormeci. Durante a noite, sonhei com cantoras de rádio e empresários rechonchudos, com bigodes iguais ao do Leôncio, um personagem do desenho animado que meu primo, Adriel, vivia assistindo, chamado Pica-Pau.
<p>Então, os sonhos ficaram um tanto confusos. Uma mulher que se parecia extremamente com Leniza Maier, a personagem principal do livro que estava lendo, estava grávida e entrava em um carro. De repente, o carro em que ela estava entrava numa estrada coberta por neve e era atingido por alguma coisa que o destruía.
<p>Acordei com leves sacudidas nos meus ombros e uma voz distante que chamava por meu nome. Esfreguei os olhos com as costas das mãos para adaptá-los à luz que invadia o quarto através da janela. Ainda aturdida, limpei o suor que molhava meu rosto por causa do pesadelo, embora possa ter sido pelo calor que fazia naquela cidade, mesmo durante o inverno. Com esforço, focalizei a pessoa sentada à beirada da minha cama, Rodrigo me encarava ansioso.
<p>-Você está bem? – Ele me perguntou.
<p>- Sim, claro, estou bem. – Respondi com a voz um pouco trêmula. – O que está fazendo aqui?
<p>- Estava passando pelo corredor quando ouvi você gritar, achei que tinha acontecido alguma coisa.
<p>- Foi só um pesadelo.
<p>- Quer falar a respeito? – Rodrigo perguntou, mas eu neguei com a cabeça. – Tudo bem! – Meu estômago roncou denunciando o quanto eu estava faminta. – Pelo visto alguém acordou com o apetite de um animal. Mamãe e papai saíram para passear com Adriel. Tem pão na mesa e suco na geladeira. – Ele falou se levantando.
<p>- Humpf! Odeio pão!
<p>- A outra opção é jejuar até meus pais voltarem, o que provavelmente não acontecerá até a hora do jantar.
<p>- Como assim? Eles não vão voltar para o almoço? – Perguntei curiosa.
<p>- Lisa, você tem noção de que horas são? – Balancei a cabeça, mais uma vez, negando ao olhar para ele, que agora estava recostado na porta aberta de meu quarto, apoiado apenas em uma das pernas. – Já passa de uma da tarde, dorminhoca.
<p>Arregalei os olhos, surpresa, ao ouvir que horas eram. Me levantei e peguei o relógio de pulso, que tinha ganhado de Jesse no meu aniversário de treze anos, apenas para constatar que Rodrigo falava a verdade. Me virei para ele, que permanecera no mesmo lugar, com a pose despreocupada de sempre, ele me encarava e fazia uma careta involuntária, que, após dias de tortura ao lado dele, comecei a reconhecer como a expressão que fazia quando tentava tomar uma decisão que não o agradava.
<p>- O que foi? – Perguntei o despertando do transe.
<p>- Vai fazer o que hoje? – Ele perguntou.
<p>- Ham, não sei. – Respondi sinceramente. – Planejava ler o livro que você me deu, mas fiz isso durante a madrugada. – Ele respirou fundo, como que cedendo a algum pensamento que passava por sua mente.
<p>- Se arruma, vamos para o shopping. E não demora, se não, posso me arrepender de te levar.
<p>O vi saindo para o corredor, esperei até que sua cabeleira castanha desaparecesse em direção a sala para começar a me arrumar. Procurei por uma roupa apresentável em meu guarda-roupa e fui para o banho, me sentia um tanto ansiosa, mas não sabia porquê.
<p>Passamos a tarde no shopping, como ele havia prometido. Primeiro ele me levou até um McDonald’s, assim que nossos pedidos ficaram prontos, devorei o meu como se fosse a melhor refeição do mundo. Rodrigo me olhava, abismado com a velocidade em que consegui comer tudo o que pedi.
<p>- Você parece um moleque comendo, como se estivesse desesperada para engolir o que tem na boca e poder morder mais um pedaço do sanduíche.
<p>- Que é? Eu estou com fome. – Retruquei de boca cheia. Vi Rodrigo balançar a cabeça sorrindo, enquanto eu dava outra mordida no sanduíche e bebia mais do refrigerante.
<p>Depois de comer, encontramos com alguns amigos de Rodrigo que o chamaram para jogar nas maquinas de videogame do playground do shopping. Ele insistiu que eu fosse com eles, mas eu declinei do convite e fiquei dando voltas pelas lojas de roupas e livrarias durante algumas horas. Por fim, acabei indo encontrar com eles no playground, fiquei os observando disputar em duplas na máquina de dança, Rodrigo, como era de se esperar do senhor perfeição, era ótimo nisso, na verdade era um dos melhores entre seus amigos.
<p>Quando voltamos para casa já estava anoitecendo e eu tinha, surpreendentemente, me divertido, apesar de ter passado o dia todo com meu quase-primo implicante. Meus tios não entenderam nada, quando Rodrigo contou que havia passado a tarde comigo e nenhum de nós havia matado ao outro. Pelo visto, eles estavam prestes a chamar a polícia para nos encontrar, caso demorássemos mais alguns minutos para aparecer em casa.
<p>O difícil foi encarar a cara de triunfo de tia Tania cada vez que ela puxava conversa com a gente. Ela não parava de sorrir e sua expressão parecia dizer: Vocês estão se dando bem, eu venci! Essa expressão permaneceu intacta todo o final de semana e o tempo que restava de férias, que não era muito. No fim das contas, ela estava certa, nós estávamos nos dando bem, mais até do que eu seria capaz de admitir na época.
<p>Nas duas semanas que nos restavam de férias, minha tia nos liberou das lições de português, desde que eu prometesse ler mais dois livros, preparasse resumos e entregasse a seu enteado, que deveria corrigi-los em troca de se ver livre de mim quando bem entendesse. No entanto, ele não se afastou de mim, como achei que faria assim que tivesse chance. Rodrigo continuou me levando junto com ele para todo lugar que ia com sua galera, que àquela altura tinha se tornado minha galera também. Até descobri que uma das meninas que andava com eles era da minha turma do colégio e nós acabamos nos tornando amigas.
<p>- Ei, Lisa, me espera! – Ouvi Bia, minha nova amiga, gritar da calçada do outro lado da rua, quando eu estava prestes a entrar no colégio, com Rodrigo, quando as aulas retornaram.
<p>Ela correu em nossa direção e começamos a andar, os três, lado a lado conversando sobre alguma coisa que Daví, um amigo de Rodrigo, havia aprontado no final de semana e tinha lhe rendido um castigo. Enquanto andávamos, eu não podia deixar de notar os olhares tortos e comentários que nós despertávamos ao passar. Não que eu e Bia fossemos dignas de sermos alvo das conversas paralelas nos corredores do colégio, mas nós éramos duas garotas andando ao lado do cara mais cobiçado do pedaço.
<p>Quando o sinal tocou, indicando o início da primeira aula, nós pegamos nossas mochilas que estavam jogadas de qualquer jeito aos nossos pés e antes que Rodrigo se afastasse de mim e de Bia eu o chamei:
<p>- Ei, me faz um favor?
<p>- Hum... claro. O que você precisa? – Ele perguntou confuso.
<p>- Se, por acaso, eu e Bia não aparecermos no refeitório durante o recreio, me prometa que você vai chamar a diretoria e revirar essa escola atrás da gente. – Apontei para as meninas ao nosso redor que fuzilavam a nós duas com os olhos.
<p>- Ah, tudo bem, fazer o que? Acho que Tania não iria me amar como filho se soubesse que deixei a sobrinha dela ser lixada por essa patricinhas ridículas. – Ele suspirou em falso desapontamento. Rodrigo se aproximou mais de mim e falou em meu ouvido. – Mas eu aposto que você dá conta delas sozinha. – E para a surpresa de todos naquele corredor, inclusive a minha, ele me beijou na bochecha antes de sair caminhando despreocupado, sorrindo de lado. Enquanto eu o olhava abismada, Bia me puxava para a sala antes que fossemos abatidas ali mesmo.
<p>O resto do dia e da semana não foram diferentes, na verdade a situação se estendeu por todo o semestre. Eu esperava que todos encontrassem algo melhor do que falar, mas Rodrigo não cooperava para isso. Sempre provocando a fúria das garotas que formavam seu fã-clube, andando com os braços em volta dos meus ombros, gritando por mim no corredor, piscando para mim durante os treinos do time de futebol e todas as outras formas constrangedoras e improváveis que ele achou para confrontá-las e me matar de vergonha.
<p>- Sabia que uma de suas namoradas me encurralou no vestiário depois do treino de vôlei? – Perguntei a ele quando caminhávamos para a saída da escola, onde Bia e a galera nos esperavam. – Disse que se eu não me afastasse do namorado dela, vulgo você, ela me faria ser expulsa desse colégio antes de eu conseguir soletrar onomatopeia.
<p>- E o que você fez? – Ele perguntou, fazendo pouco caso da situação. Eu sabia que ele as provocava de propósito e para isso ele me usava, mas não me importava. Ou melhor, eu me importava até demais com ele, com meus tios, com o pequeno Adriel e até com os amigos dele, que também eram meus agora. Por isso, não ligava quando ele fazia isso.
<p>- Na verdade, nada. – Ele me olhou desconfiado, sabia que eu não era de ficar quieta. – Eu estava aturdida por descobrir que ela conhecia a existência da palavra onomatopeia. Embora eu duvide que ela saiba o significado.
<p>- E você sabe? – Ele me provocou.
<p>- Figura de linguagem que indica a reprodução escrita de sons e ruídos naturais. – Falei com convicção.
<p>- Olha só, quem virou um dicionário ambulante! Parabéns! – Ele falou passando o braço ao redor dos meus ombros.
<p>- Eu tive um professor mais ou menos durante as férias. – Emendei com um sorriso travesso.
<p>- Ah, quer dizer que eu sou um professor mais ou menos? Eu vou te mostrar quem é o professor mais ou menos. – E me atacou, me fazendo cócegas, enquanto eu gritava, em meio a risadas, para que ele parasse com aquilo. Até que alguém parou em frente a nós, desviando nossa atenção.
<p>- Aí, a galera quer saber se vocês estão a fim de ir para a casa do Daví? – Era o colega de turma de Rodrigo, do qual eu sempre esquecia o nome – O pai dele comprou um aparelho de karaokê e todo mundo vai para lá.
<p>- Por mim, tudo bem. O que você acha, Lisa? – Rodrigo me perguntou.
<p>- Não, valeu. Prometi a tia Tania que ficaria com Adriel hoje, para ela poder finalizar alguma coisa do trabalho com Jorge. – Respondi já me afastando, indo em direção contrária a que eu tinha visto a cabeleira ruiva de Bia, antes, onde eu sabia que os outros estavam esperando por nós.
<p>Ouvi, vagamente, Rodrigo falar algo para o amigo e vir em minha direção. Eu estava meio ciente de sua presença ao meu lado durante o caminho de volta para casa. Podia sentir seu olhar em minhas costas quando entramos em casa e eu segui para meu quarto sem dizer uma única palavra, batendo a porta ao passar.
<p>Não saí do quarto o resto do dia, nem mesmo para jantar. Tia Tania bateu algumas vezes na porta do quarto tentando me convencer a sair para comer, mas acabou desistindo. Mais uma vez naquela noite sonhei e em seguida o sonho acabou virando um pesadelo a respeito do acidente dos meus pais e a morte de meu irmão.
<p>Fui despertada na manhã seguinte pelo cheiro de café preto e bolo de cenoura que impregnava o quarto. Ao abrir os olhos, vi Rodrigo empoleirado no parapeito da janela do quarto, sua silhueta formando uma réstia alongada no piso. Ele me encarava com determinação. Na mesinha de estudos uma bandeja confirmava o que o cheiro que me despertou prometia: café e bolo de cenoura.
<p>- Prefere falar agora ou depois que comer? – Rodrigo quebrou o silêncio.
<p>- Prefiro não falar. – Olhei em sua direção e vi que ele não desistiria. – Mas, pelo visto, não tenho essa opção. – Ele negou com a cabeça. – Então, vou comer primeiro.
<p>Enrolei o máximo que pude o meu café da manhã, na esperança que Rodrigo desistisse de me fazer falar e fosse embora, mas ele me fitava desafiadoramente, como quando me fez esperar por ele para receber meu presente. Seu olhar me dizia que ele esperaria o dia todo, mas só sairia dali quando eu falasse o que ele queria saber.
<p>- Então? – Falou quando eu terminei meu café da manhã. – Por que você não quis ir para a casa de Daví com todo mundo? E, principalmente, por que você mentiu sobre ter que ficar com Adriel?
<p>- <i>Nothing at all.</i> Eu só não estava afim de barulho e sabia que eles iriam ficar insistindo que eu fosse se eu não mentisse. – Assim como estou fazendo agora, pensei.
<p>- Nem vem com: não foi nada. Eu te conheço bem o bastante para saber quando está mentindo. Me fala, vai!
<p>- Todos os anos, no aniversário de Josh, que por sinal seria daqui alguns dias, meus pais nos levavam para um bar com karaokê, que pertencia a um dos clientes da empresa dele. Eu, Josh, meu amigo, Jesse e Claire, namorada de Josh, passávamos a noite toda desafinando as músicas e acabando com as letras, enquanto tomávamos canecas seguidas de chocolate quente, para combater o frio que se iniciava em novembro. Mas esse ano, meus pais não estão vivos para nos levar lá, nem Josh ou Claire e eu estou em um continente distante de Jesse. Então, não, eu não estava afim de ir para o karaokê. Satisfeito? – Me virei, dando as costas para ele, para esconder as lágrimas que ameaçavam cair.
<p>Pela sombra no chão, vi Rodrigo descer da janela e vir em minha direção, me alcançando no exato momento em que não consegui segurar as lágrimas e desabei no choro. Ele me segurou e nós dois escorregamos para o chão, onde permanecemos um longo tempo. Eu chorando em seus braços, enquanto ele, encostado aos pés da cama, acariciava meus cabelos e os afastava do meu rosto ensopado.
<p>Não sei por quanto tempo ficamos naquela posição, até que Adriel apareceu na entrada do quarto, anunciando que o almoço estava servido e que sua mãe estava nos chamando para comer. Nós nos levantamos, eu fui até o banheiro e lavei meu rosto, na tentativa de apagar os últimos vestígios do choro, quando saí, encontrei Rodrigo me esperando no corredor.
<p>- O que ainda está fazendo aí? – Perguntei.
<p>- O que sua tia pediu: garantindo que você compareça, ao menos, às refeições. – Respondeu, colocando uma mão em cada um de meus ombros, ele me empurrou em direção à cozinha.</p>
</body></html>";
            }

            if (numero == 5)
            {
                lblTitulo.Text = "Capítulo 5";
                htmlPage.Html = @"<html><body>
<p><i>“Talvez eu esteja apenas sonhando que minha esperança vai me manter forte.”
<br><b>The Reason I Go On (Céline Dion)</b></i></p>
<br>
<p>Faltando apenas algumas semanas para terminar o ano letivo eu passei a ter problemas de insônia, o stress das provas finais estava me deixando maluca. Após horas deitada, em tentativas frustradas de agarrar no sono, eu me levantava de mau humor no meio da madrugada, atravessava o apartamento de meus tios em silêncio, sem me preocupar em vestir outra coisa que não fosse meu pijama, e descia para a área externa do prédio.
<p>Havia um parquinho, para as crianças, próximo ao prédio em que morávamos, eu me sentava em um dos balanços e ficava observando as estrelas, enquanto sentia a brisa bater em meu rosto. Vez ou outra, minha atenção era desviada para a portaria do condomínio quando algum morador chegava ou saía.
<p>Depois de um final de semana cansativo, me preparando para a prova final de Língua Portuguesa, meu sono parecia se esconder de mim, como uma brincadeira sem graça de pique-esconde promovida pelo meu velho amigo anjo, que deveria estar, mais uma vez, se divertindo a minhas custas. Enquanto eu tentava decifrar as constelações, sentada no balanço do parquinho, uma cabeleira castanha tampou minha visão do céu, eu pisquei focalizando o rosto de Rodrigo.
<p>- Você não deveria estar descansando para a prova de amanhã? – Ele perguntou, sentando-se ao meu lado e imitando minha posição anterior de observadora de estrelas.
<p>- Não consigo dormir! – Respondi, observando ele, que agora estava de olhos fechados ainda com a cabeça inclinada para o céu, percebi, em seu rosto iluminado pelo brilho da lua, linhas escuras que se estendiam sob a sombra dos longos cílios. – Pelo visto, eu não sou a única. O que não faz nenhum sentido, já que você está aprovado em todas as disciplinas com mérito desde as avaliações anteriores.
<p>Um vestígio de sorriso surgiu nos lábios do rapaz, mas logo despareceu, talvez eu não tivesse sido capaz de notar se já não estivesse tão familiarizada com seu sorriso de lado. Estranhei, no entanto, o fato dele ter contido o sorriso, nunca tinha visto ele fazê-lo até aquele momento.
<p>- Você está bem? – Perguntei, minha voz denunciando mais preocupação do que eu pretendia.
<p>Rodrigo demorou mais alguns instantes de olhos fechados, sentindo a brisa que batia em seu rosto e balançava os fios do cabelo que agora estavam um pouco compridos demais, mas que lhe davam um ar de descaso que o deixava ainda mais bonito. Me repreendi por esses pensamentos, estava parecendo uma das garotas que vivam correndo atrás dele pelos corredores do colégio.
<p>- Papai recebeu uma carta na última sexta-feira – disse virando-se para me encarar, seus olhos pareciam cansados e tristes.
<p>- E daí? Seu pai é um advogado famoso, recebe um monte de cartas diariamente.
<p>- Essa não era uma carta de trabalho – falou, enquanto mexia freneticamente em uma linha que se soltava da costura da camisa branca que fazia conjunto com a calça azul escura do pijama. Assim como eu sempre fazia, ele não havia se preocupado em calçar os pés ao sair do apartamento.
<p>- Tudo bem! Então sobre o que era? – Perguntei, sem entender o que a carta tinha a ver com a insônia dele.
<p>- Era uma carta de admissão na NCSU.
<p>- Seu pai vai voltar para a faculdade? Na Carolina do Norte? Por que... – Minhas perguntas se perderam ao mesmo tempo que ele negava com a cabeça e a compreensão me atingia como um balde de água fria. – Espera, você foi aceito na Universidade Estadual da Carolina do Norte? – Ele confirmou com um movimento rápido de cabeça. – Mas como? Eu não sabia que você tinha vontade de ir para lá ou que tivesse feito a prova de admissão. – Tentei não soar traída por ele ter me escondido isso.
<p>- Eu não queria, não de verdade. – Ele soou cansado. – Esse sempre foi o sonho de meus pais, desde antes da doença da mamãe. Fiz o exame de admissão quando Tania foi ficar com você em Wilmington, papai me levou a Raleigh enquanto cuidava dos papeis da sua vinda para o Brasil. Adriel ficou com meus avós maternos, Tania e mamãe eram amigas na época da faculdade e vovó a adora.
<p>- Se você não queria ir, então porque não falou para seu pai?
<p> Jorge, pai de Rodrigo, era um homem fechado e sério, mas nunca me pareceu uma pessoa injusta, ele não o forçaria a fazer isso se ele não quisesse. Ele balançou a cabeça e tive a impressão de ter visto uma lágrima se formar no canto do olho quando ele levantou do balanço, ficando de costas para mim.
<p>- Você, acima de todas as pessoas, deveria entender. – Falou, sem disfarçar a magoa na voz. – Era o sonho dela. O sonho de Marta. Eu preciso fazer isso... por ela.
<p>Olhando para ele, que ainda estava de costas para mim, vi seus ombros estremecerem, ele estava chorando. Nunca tinha o visto triste, sempre estampando um sorriso no rosto, e ali estava ele desmoronando em minha frente.
<p>Mesmo em choque por aquela notícia de que ele iria embora, me forcei a fazer a única coisa que estava ao meu alcance naquele momento, levantei do balanço e fui até ele, dando passos lentos e incertos, até estar perto o suficiente para tocar em seu ombro. Ele se virou ao meu toque e me olhou no fundo dos olhos, os dele transmitiam mais que tristeza, transmitiam dúvida e medo. Sustentando meu olhar, Rodrigo se aproximou de mim, tão rápido que eu não teria sido capaz de prever seus movimentos, mesmo se pudesse. Ele me beijou. De início, eu fiquei paralisada de surpresa, mas logo estava retribuindo ao beijo dele.
<p>O beijo dele tinha gosto de pasta de dentes e era salgado por causa das lágrimas, mas eu não me importava, naquele momento tudo que importava era estar nos braços dele enquanto ele me beijava e me trazia cada vez mais para perto do seu abraço.</p>
<center><h4>--*--</h4></center>
<p>Na manhã seguinte mal nos cumprimentamos. Tia Tânia ficava olhando de um para o outro sem entender porque estávamos tão quietos durante o trajeto até o colégio. Quando ela estacionou em frente à escola Rodrigo saltou sem se despedir dela e saiu caminhando sem me esperar, como sempre fazia.
<p>Eu vi ele desviar de Bia sem lhe dar bom dia e ela olhando em minha direção com cara de incompreensão, eu dei de ombros, fingindo não saber o motivo dele estar assim, e segui para a sala, ligeiramente ciente da presença dela caminhando ao meu lado.
<p>As aulas pareciam não ter mais fim naquela manhã, a prova seria no último horário e minha cabeça estava voando, sempre em direção ao que tinha acontecido algumas horas antes, no parquinho do condomínio. Senti alguém me cutucando nas costas:
<p>- O que você tem? – Bia perguntou sussurrando enquanto a prova era passada de um aluno para outro nas filas.
<p>- Nada. – Respondi me ajeitando na cadeira, fingindo me concentrar nas questões ao ouvir o professor anunciar o início do exame.
<p>Foi difícil me concentrar nas perguntas da prova, meu pensamento continuava em Rodrigo, na mudança dele para outro país, no beijo que ele me deu e, principalmente, nele me evitando toda vez que me avistava nos corredores do colégio. Quando entreguei minha prova, aproveitei que Bia ainda não tinha finalizado a dela para fugir antes que ela me enchesse de perguntas.
<p>Não encontrei com Rodrigo nos corredores do colégio ou em todo o caminho de volta para casa. Quando entrei no apartamento de meus tios assumi que estivesse sozinha, devido a calmaria do lugar, segui para meu quarto, abandonei a mochila ao pé da porta e me joguei na cama sem me preocupar em trocar de roupa.
<p>Dormi por algumas horas, mas não foi um sono tranquilo, pela primeira vez em meses eu voltei a ter pesadelos com o acidente dos meus pais, mas dessa vez eles estavam misturados ao beijo que Rodrigo me deu e a imagem dele me dando as costas num corredor vazio.
<p>Acordei com a cabeça latejando de dor, me esforcei para levantar e me deparei com uma figura esguia e comprida sentada de costas para mim na beirada de minha cama. Ele se virou para mim, sua cara não estava muito melhor que a noite anterior, mas agora ele sustentava o sorriso de lado e eu tentava me forçar a não retribuir.
<p>- Oi! – Rodrigo cumprimentou, também não tinha se livrado do uniforme do colégio e sua mochila, eu notei ao desviar o olhar do dele, estava largada junto a minha no chão do quarto.
<p>- Oi. – Respondi secamente.
<p>- Podemos conversar?
<p>Apesar de seus olhos estarem secos e a voz não soar tão trêmula quanto antes, ele ainda mostrava incerteza ao falar e parecia prestes a desabar a qualquer instante.
<p>- Sobre o que? – Eu não estava facilitando, mas ele que tinha começado ao fugir de mim no colégio.
<p>Ele enfiou uma das mãos no bolso do jeans e retirou de lá um par de ingressos, jogando-os em cima da cama.
<p>- Eu tinha comprado eles há uma semana, mas não tinha certeza se você iria aceitar ir comigo. – Falou apontando para os ingressos que estampavam TURMA DE FORMANDOS DE 2004 – BAILE DE FORMATURA. – Acho que agora não faz mais diferença, provavelmente não estarei aqui quando acontecer. Pode ficar com eles, convide alguém para ir com você ou os venda, tanto faz.
<p>- Foi isso que você veio fazer aqui? – Peguei os ingressos e os joguei na direção dele. – Me falar para arranjar um par, que não fosse você, para ir ao baile da sua formatura? Porque se foi, pode leva-los de volta, eu não quero ir... não sem você.
<p>- Lisa, me ouça... – Ele começou, mas eu o interrompi.
<p>- Não! Me ouça você. – Eu estava, agora, com os olhos marejados, mas me forcei a segurar as lágrimas. – Você tem que falar com seu pai, com Tia Tania, deve ter um jeito, talvez você possa adiar seu ingresso na universidade, por favor, eu não posso ficar sem você, não agora.
<p>Apesar de todo meu esforço, as lágrimas começaram a rolar e Rodrigo virou uma silhueta borrada vindo em minha direção. Um instante depois ele estava me abraçando, me consolando, quando eu deveria ser a pessoa a estar o ajudando a passar por aquilo, afinal, era ele que estava sendo enviado para longe de casa, para longe da família. Depois do que pareceu uma eternidade, ele me afastou um pouco me segurando pelos ombros, me forçando a olhar em seus olhos.
<p>- Ei! Eu tenho uma ideia. – Ele parecia calmo, embora eu soubesse que provavelmente estivesse só fingindo para não me preocupar. – Posso falar com papai, tentar adiar a viagem por algumas semanas, ficar com vocês até o final das festas de fim de ano. Tudo bem?
<p>Eu balancei a cabeça em confirmação, mas não estava tudo bem e ele sabia. Em menos de um ano eu tinha perdido meus pais e meu irmão para sempre, tinha sido tirada de minha casa, dos meus amigos e trazida para uma casa estranha em outro continente. Tive que acostumar a me comunicar de forma diferente, com pessoas diferentes, fazer novas amizades. E agora a pessoa que mais tinha me ajudado a me encaixar nessa nova vida, a pessoa com quem eu mais me importava e que me compreendia estava indo embora.
<p>- Ok! Então... – Ele começou a falar, mas hesitou antes de continuar. – Sobre o baile... você quer ir?</p>
</body></html>";
            }

            if (numero == 6)
            {
                lblTitulo.Text = "Capítulo 6";
                htmlPage.Html = @"<html><body>
<p><i>“Amor é um conhecido. Amor é um demônio. Não há anjo malvado além do amor.”
<br>Trabalhos de Amor Perdidos
<br><b>(William Shakespeare)</b></i></p>
<br>
<p>Com o final das provas as pessoas começaram a faltar, cada vez com maior frequência, nas duas semanas finais de aulas. Eu era a única de minha classe que continuou marcando presença em todas as aulas, bom... eu e Bia, mas ela dormia a maior parte do tempo e quando estava acordada se empenhava em me perturbar com perguntas sobre Rodrigo e o beijo.
<p>-O baile será daqui dois dias, está ansiosa?
<p>-Bia, pela milionésima vez essa semana, não, eu não estou ansiosa!
<p>-Mentirosa! - Bia rebateu, balançando perigosamente no galho de uma árvore em que havia se empoleirado. - Vou continuar perguntando, até você admitir. - Falou ao saltar da árvore pousando ao meu lado.
<p>Nós estávamos passando o tempo em um parque público na Zona Sul da cidade, os pais dela estavam trabalhando, como sempre, e eu estava fugindo de minha tia, que não falava em outra coisa se não o baile e a formatura do filho.
<p>-Ah! Isso aqui é muito chato! Temos que fazer alguma coisa. Ideias? - Quis saber Bia.
<p>-Hum... nenhuma! Vamos para minha casa, a essa hora tia Tânia já deve ter saído para buscar Adriel na escola.
<p>-Nah! Vai você, eu vou para minha casa, infernizar minha irmã até convencê-la a me deixar entrar no baile de sábado, eu sei que ela ganhou um ingresso extra por ser professora e parte da comissão organizadora da festa.
<p>-Não entendo esse desejo todo de ir num baile de formatura que não seja o seu – falei emburrada – mas boa sorte em sua luta.
<p>Entre milhares de fotos que tia Tânia nos forçou a tirar, uma cerimônia tediosa, mais fotos, uma banda ruim e ainda mais fotos, o baile de formatura da turma de 2004 foi um saco.
<p>-Fugindo dos flashes? - Rodrigo me encontrou no parquinho ainda com o vestido do baile.
<p>-O que você acha? - Respondi com um meio sorriso forçado.
<p>-Ei, o que foi? - Ele me abraçou por trás e beijou o topo da minha cabeça.
<p>-Nada! I'm just tired!
<p>-Nada? Só está cansada? Você é uma péssima mentirosa. - Rodrigo me virou em seus braços para que eu ficasse de frente para ele.
<p>-Eu não estou mentindo! - Me defendi.
<p>-Toda vez que você mente, você fica nervosa e começa a falar em inglês.
<p>-<i/>I'm not...</i> - Interrompi ao perceber que ele estava certo, então revirei os olhos ao ver um sorriso zombeteiro em seu rosto. - Ok! Eu estava pensando nas festas de fim de ano, será o primeiro natal sem minha família e logo depois você...
<p>-Logo depois eu vou embora.
<p>Rodrigo concluiu minha fala, me abraçando mais forte. Passamos alguns momentos em silêncio, tudo o que eu ouvia eram as batidas do coração dele contra meu ouvido e sua respiração compassada.
<p>-Eu sei que você acha que vai ficar sozinha, que está sozinha. Mas não é verdade. Você tem a mamãe, o papai, tem Adriel, que te ama mesmo você sendo malvada com ele quando estão brincando. Também tem a Bia e o pessoal do colégio. E tem a mim. Não importa o quão longe estejamos um do outro, você sempre terá a mim, porque eu te...
<p>-Por favor, não diga que me ama! - O interrompi. Ele me olhou, confuso e cansado. - Nós somos apenas crianças estúpidas que namoram escondidas...
<p>-Porque você quer! - Dessa vez, ele me interrompeu.
<p>-Que seja! Você é mais velho que eu, está indo embora para outro país e não sabe quando vai voltar. Então, por favor, não diga! - Meus olhos já lacrimejavam a essa altura.
<p>-Shhhh... Tudo bem, eu não digo. - Falou em redenção. - Mas isso não quer dizer que não seja a verdade, não quer dizer que não é como me sinto e isso - ele levantou meu rosto para que eu pudesse olhar para ele – você não pode mudar.
<p>Eu me estiquei e o beijei, na esperança de por fim naquele assunto, pelo menos por aquela noite. Me aninhei ainda mais em seus braços. Mais nada foi dito aquela noite, ficamos abraçados no parquinho até o sol dar os primeiros sinais do amanhecer, quando voltamos para casa e seguimos para nossos quartos.</p>
</body></html>";
            }
        }

        public void clkAbrirComentar(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MyPopupPage("AnjoMorte", condicao.ToString()));
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

        public void clkIrMenu(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MenusView.MenuAnjoMortePage());
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
                    Historia = "AnjoMorte"
                }, UserLocalData.userUID, "AnjoMorte", "Capitulo" + capitulo);

                if (condicao==0 && status=="true")
                {
                    var listAsync = await service.mostrarQuantidadeLeituras("AnjoMorte");

                    if (listAsync != null)
                    {
                        var contagem = Convert.ToInt32(listAsync.Quantidade);

                        await service.SomarLeituras(new QuantidadeLeituras()
                        {
                            Quantidade = contagem + 1
                        }, "AnjoMorte");
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