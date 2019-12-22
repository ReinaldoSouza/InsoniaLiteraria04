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
	public partial class PrologoPage : ContentPage
	{
        DBFire service;

        public PrologoPage ()
		{
			InitializeComponent ();
            service = new DBFire();
            mostrarCapituloSalvo("NoEscuro", "Capitulo0");

            htmlPage.Html = @"<html><body>
<center><h3>DIÁRIO POPULAR, 14 DE ABRIL DE 2006<br><b>CONTINUAM AS BUSCAS PELAS REDONDEZAS DA CIDADE ATRÁS DE SUSAN RONDON</b></h3></center>
<p>Escrito por James Arthur. – Seguem as rondas em busca da adolescente Susan Rondon, dezessete anos. A polícia local a declarou desaparecida após denúncia dos pais, há duas semanas. Desde então as buscas seguem firmes pela garota.
<p>Darkey, um povoado minúsculo e atrasado que eu chamo de lar, se encontra mais unido que nunca à procura de Susan, uma jovem promessa para o futuro do povoado, que cuida dos pais e que nunca fica fora de casa mais de duas horas sem avisar a ninguém. 
<p>“Ela havia saído de manhã para estudar com a sua amiga, Lenny, em uma biblioteca a duas quadras daqui. Parou de mandar mensagens duas da tarde e não voltou mais para casa.” Disse a mãe que achou o comportamento da filha muito estranho e ligou para a casa de Lenny e acabou descobrindo que as duas haviam se despedido horas atrás e que Lenny não fazia ideia de onde a amiga poderia ter ido, já que ela havia afirmado que iria direto para casa, pois estar muito cansada.
<p>“Da biblioteca até a casa de Su são menos de dez minutos, eu até estranhei quando me ligaram atrás dela. Fiquei ligando no celular dela que nem uma louca, mas só caia na caixa postal. Entrei em desespero.”. Testemunhou Lenny, também de dezessete anos, aos prantos.
<p>A cidade não é muito grande por isso as buscas pelas ruas de Darkey não demoraram muito. As ultimas informações que saíram é que as equipes de buscas estão com cães farejadores andando no meio do mato que cerca a cidade na esperança de achar pelo menos o corpo para a família poder velar e ter uma conclusão dessa história trágica.</p>
<center><h3>DIÁRIO POPULAR, 27 DE MAIO DE 2006<br><b>CASAL DE RELIGIOSOS ENCONTRADO MORTO NA PRAÇA MAGNOLIA</b></h3></center>
<p>Escrito por James Arthur. – Dois dias depois da equipe de buscas ter encontrado o corpo de Susan Rondon boiando no lago Comma, com as mãos e pernas cortadas e  um grande corte na cabeça feito, provavelmente, por um machado, um casal, Rod e Mariah, foi encontrado morto na praça pública Magnolia hoje às sete da manhã por um civil que fazia sua corrida matinal por aquele local. 
<p>Os cadáveres estavam estirados na grama também sem mãos e pernas e vários cortes afiados pelo resto do corpo. Os dois foram vistos um dia antes saindo da igreja após assistirem o culto das dez da noite. 
<p>Os dois eram pessoas muito queridas pelo povoado, sempre promovendo festas religiosas para evangelização da pequena parte de Darkey que continuava sem acreditar em Deus. 
<p>A população ainda mal conseguiu digerir a imagem de Susan morta e já é obrigada a encarar mais um atentado, dessa vez, duplo. 
<p>O departamento de polícia não quis dar nenhum depoimento sobre o caso, no entanto, uma fonte confiável informou que o departamento de segurança está tomando ações de acordo para proteger a população. 
<p>Enquanto as autoridades em segurança parecem trabalhar na surdina, boatos que um assassino em série está à solta tem assustado os moradores. Até agora não foram confirmadas causas dos assassinatos e, aparentemente, a polícia não tem suspeitos.</p>
<center><h3>DIÁRIO POPULAR, 04 DE SETEMBRO DE 2007<br><b>ASSASSINO EM SÉRIE FAZ MAIS UMA VITIMA!</b></h3></center>
<p>Escrito por James Arthur. – Marcus Dump foi autor de mais um capítulo de terror noturno em Darkey. Após conseguir fugir novamente da caçada policial, cadetes encontraram Anna Beth morta na casa do assassino. 
<p>A jovem repórter, um pouco mais corajosa que eu, conseguiu o inesperado, uma entrevista com o próprio diabo. As fitas de gravação ainda estavam em sua bolsa quando o corpo foi encontrado. 
<p>Gravações de Marcus detalhando cada morte estão sendo analisadas pela polícia que, por sua vez, pediu reforços, acredita-se que a Guarda Nacional esteja chegando ao povoado amanhã pela manhã, com a promessa de pôr um fim de uma vez por todas em Marcus, que já contabiliza dezessete vítimas.
<p>As escolas receberam ordem de cancelar todas as aulas até segunda ordem, o departamento de polícia determinou um toque de recolher a partir das oito da noite. Pessoas fora de casa após esse horário serão levadas a delegacia. Os agentes têm feito rondas na floresta, na busca por qualquer sinal de Marcus, ainda que suas ações não demonstrem que ele esteja preocupado com isso, talvez tendo, até mesmo, desenvolvido um senso de invencibilidade.
<p>“Ele vai cometer um erro e vai ser detido. Isso precisa acontecer.”. Disse o senhor Luiz, o padeiro que recentemente perdeu um de seus sobrinhos para Marcus. 
<p>O povoado de Darkey, que costumava ser o lugar mais seguro de se viver, tem passado por uma onda de medo e apreensão graças às ações descompensadas desse lunático. Ninguém consegue compreende-lo, ou decifrar quais são as motivações que o levam a cometer tais atos. </p>
<center><h3>DIÁRIO POPULAR, 10 DE JANEIRO DE 2008<br><b>MARCUS FINALMENTE É CAPTURADO!</b></h3></center>
<p>Escrito por James Arthur. – Hoje é um dia de comemoração e alívio para os moradores de Darkey. Depois de trinta e seis horas fazendo a família Rose de refém em sua própria casa e mantendo contato com as autoridades, Marcus finalmente foi capturado e levado preso para a delegacia pelo chefe de polícia, Brian. 
<p>Os civis ficaram surpresos quando descobriram que Marcus não havia cometido novos assassinatos durante o período de negociações, deixando toda a família viva, pedindo apenas por uma chance de fugir da cidade, algo que não combina com seu histórico insensível e destemido. 
<p>Até agora não foram liberadas informações sobre o interrogatório. Ninguém sabe se ele será levado a julgamento, espera-se que pena de morte, aqui mesmo ou se será levado para a capital, onde pode ser observado pelos holofotes de todo o país, talvez do mundo. 
<p>A família Rose não quis dar detalhes sobre o que aconteceu dentro da casa durante essas trinta e seis horas e escolheram permanecer em sua residência desde a prisão de Marcus, acredita-se que se preparando para fugir da cidade.
<p>Joseph, o filho mais novo, deve estar realmente muito assustado. Fontes dizem que ele estava sozinho em casa quando Marcus invadiu e que o resto da família só chegou depois de algumas horas. Fotos tiradas de longe mostram muitos hematomas em seu rosto levando a crer que ele lutou com o assassino ou apanhou sem motivo aparente, não se sabe. 
<p>Há quem diga que eles mereceram esse susto. Enquanto todos estavam apreensivos com as histórias das vítimas de Marcus, os Rose se sentiam intocáveis. Joseph burlava o toque de recolher quase todas as noites e os pais simplesmente não conseguiam, ou não queriam, colocar ele dentro de casa. 
<p>A questão é: alguém merece passar por isso que essa família passou, independentemente de qualquer coisa? Não seria esse pensamento um tanto injusto?</p>
<center><h3>DIÁRIO POPULAR, 10 DE FEVEREIRO DE 2008<br><b>INCENDIO NA DELEGACIA MATA QUATRO!</b></h3></center>
<p>Escrito por James Arthur. – A sangrenta história de Marcus Dump finalmente termina. Depois de exatamente um mês trancafiado em uma cela a espera de seu julgamento, a delegacia onde estava sofreu o maior incêndio já visto em Darkey. 
<p>Três policiais que estavam de plantão na delegacia foram mortos e seus restos mortais estão passando por testes da arcada dentária, um quarto corpo, o de Marcus, foi encontrado entre os escombros das celas. 
<p>Com, praticamente, 100% do corpo carbonizado, está sendo quase impossível fazer reconhecimento do corpo, mas como ele era o único detento naquela noite, as autoridades já ligaram o seu nome ao corpo e encerraram o caso do assassino em série.
<p>“Ele teve o que mereceu. Espero que queime no fogo do inferno agora” disse Joanna, mãe de Susan, a primeira vítima conhecida de Marcus.
<p>“Estão dizendo por aí que foi um incêndio culposo. Bom, qualquer um teria motivos para querer matar esse louco” afirma Fernando, um pesqueiro do porto da cidade.
<p>A verdade é que uma delegacia não pega fogo do nada. Tanques de gasolina foram roubados essa tarde de um dos postos de combustíveis e, coincidentemente, a mesmo tipo de substância foi utilizado para alimentar o fogo do lado de fora da delegacia.
<p>Existem especulações em torno do culpado por esse incêndio, mas ainda é muito cedo para poder afirmar qualquer coisa, evitando ameaças processuais ou de morte. Até mesmo porque ninguém tem realmente interesse em saber mesmo quem foi o assassino de Marcus Dump, alguns estão até agradecidos, ainda que a ação tenha levado a morte outras três vítimas das chamas.
<p>No próximo domingo, o Padre Tadeu fará uma missa por todas as vítimas e familiares do incêndio. É hora do povoado de Darkey se reunir e seguir em frente, deixando essa tragédia apenas na lembrança e esperando que situações semelhantes não se repitam.</p>
</body></html>";
        }

        public void clkAbrirComentar(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new EsseMundoView.MyPopupPage("NoEscuro", "0"));
        }

        public void clkIrMenu(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MenusView.MenuNoEscuroPage());
        }

        public void clkAbrirProximo(object sender, EventArgs e)
        {
           Navigation.PushModalAsync(new Capitulo1Page(1));
        }

        public void clkSalvar(object sender, EventArgs e)
        {
            try
            {
                if (chkCapitulo.IsChecked == true)
                {
                    LerCapitulo("0", "true");
                    //var message1 = "CAPÍTULO LIDO";
                    //DependencyService.Get<IMessage>().ShortTime(message1);
                }
                else
                {
                    LerCapitulo("0", "false");
                    //var message = "VOCÊ DESMARCOU UM CAPÍTULO";
                    //DependencyService.Get<IMessage>().ShortTime(message);
                }

            } catch(Exception ex)
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
                    Capitulo = 0,
                    Historia = "NoEscuro"
                }, UserLocalData.userUID, "NoEscuro", "Capitulo" + capitulo);

                if (status == "true")
                {
                    var listAsync = await service.mostrarQuantidadeLeituras("NoEscuro");

                    if (listAsync != null)
                    {
                        var contagem = Convert.ToInt32(listAsync.Quantidade);

                        await service.SomarLeituras(new QuantidadeLeituras()
                        {
                            Quantidade = contagem + 1
                        }, "NoEscuro");
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