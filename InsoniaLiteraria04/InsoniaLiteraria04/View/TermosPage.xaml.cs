using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InsoniaLiteraria04.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TermosPage : ContentPage
    {
        public TermosPage()
        {
            InitializeComponent();
            htmlPage.Html = @"<html>
<head>
<style>
.comum {
  text-align: justify;
  margin: 6;
  text-indent: 2ch;
}
.prime {
  text-align: justify;
  text-justify: inter-word;
  margin: 6;
}
</style></head>
<body>
<center><h3>Política de Privacidade</h3></center>
<center><p><i>Documento atualizado: 28 de Março de 2021</i></p></center>
<center><p><i>Data de vigência: 01 de Abril de 2021</i></p></center>
<p class=prime>Essa <i>Política de Privacidade</i> representa o compromisso que a equipe Insônia Literária tem com a privacidade e proteção de informações, quando lidamos com dados pessoais de usuários que interagem em nosso aplicativo. Elaboramos essa política para ajudar você, usuário, a entender quais informações coletamos, como e para que usamos e quais escolhas você tem sobre ela.</p>
<br>
<p class=prime><b>Dados pessoais coletados pelo aplicativo</b></p>
<p class=comum>Os dados pessoais que possuímos dos usuários são dados fornecidos voluntariamente pelos próprios no processo de criação de conta no aplicativo. São eles: Nome (completo ou não, para nosso aplicativo, não importa), e-mail, uma foto (opcional, o aplicativo em nenhum momento faz reconhecimento de imagem), username (um nome fictício criado pelo próprio usuário, um apelido), e senha (também criada pelo próprio usuário). Recomendamos que a senha criada não esteja relacionada com outras senhas que o usuário possua em outras plataformas. Quando você utiliza do aplicativo Insônia Literária, também gravamos os comentários que você faz e histórias que estão sendo lidas por você, incluindo data e hora que você realizou essas interações.</p>
<br>
<p class=prime><b>Finalidade da coleta de dados pessoais</b></p>
<p class=comum>O aplicativo utiliza os dados pessoais do usuário para as seguintes finalidades:</p>
<ul>
<li>Gerenciar a conta do usuário no Insônia Literária;</li>
<li>Identificar o usuário quando usa o Insônia Literária;</li>
<li>Enviar atualizações (por exemplo, quando seu comentário recebe uma resposta) e novidades por e-mail;</li>
<li>Permitir acesso ao conteúdo do aplicativo;</li>
<li>Permitir interação do usuário com outras pessoas que também possuem o aplicativo através de comentários;</li>
<li>Conduzir análises e pesquisas internamente sobre quem está usando o Insônia Literária e o que essas pessoas estão fazendo no aplicativo. Por exemplo, registrando a frequencia que tal história é visitada, conseguimos entender os gostos do nosso píblico e qual história é mais popular;</li>
<li>Melhorar o aplicativo e oferecer mais recursos
</ul>
<p class=comum>Os serviços de entretenimento fornecidos pelo nosso aplicativo dependem diretamente de alguns dos dados pessoais indicados a cima por isso a necessidade de se criar uma conta. Utilizamos o serviço de propaganda Google Admod. Não compartilhamos dados do usuário com essa plataforma. Toda vez que lhe enviarmos materiais de marketing por e-mail, daremos a você a opção de cancelar o recebimento.</p>
<br>
<p class=prime><b>Compartilhamento de dados pessoais</b></p>
<p class=comum>Podemos compartilhar os dados pessoais dos usuários com terceiros, preservando ao máximo a privacidade do usuário e, sempre que possível, de forma anonimizada. Segue abaixo situações em que podemos compartilhar os dados:</p>
<ul>
<li>Com autoridades públicas, sempre que houver determinação legal, requerimento, requisição ou ordem judicial nesse sentido;</li>
<li>Internamente, com nossas áreas de negócio, para realizar segmentação de perfil (proporcionar experiências personalizadas), enviar publicidade, promover e desenvolver nossos serviços, por exemplo;</li>
<li>Com nossos parceiros comerciais, com quem firmamos obrigações contratuais de segurança e proteção de dados pessoais. Isso inclui empresas de hospedagem de dados e servidores; empresas de autenticação e validação de cadastros; ferramentas de publicidade, marketing, mídia digital e social;</li>
<li>Qualquer usuário pode ver os comentários que você escreveu assim como seu username (apelido), foto e a data de quando aquele comentário foi escrito.</li>
</ul>
<p class=comum>O Insônia Literária é um projeto de nacionalidade Brasileira. Logo, seus dados pessoais não serão compartilhados para fora do país para eventuais sedes. As informações de suas interações em anúncios fornecidos pelo Google Admob são usadas por ele para auditar e melhorar a veiculação desses anúncios de acordo com o seu perfil  </p>
<br>
<p class=prime><b>Os direitos do Usuário</b></p>
<p class=comum>O Insônia Literária garante ao usuário, como titular dos dados pessoais, os seguintes direitos:</p>
<ul>
<li>Requisitar uma cópia dos dados pessoais que nós temos sobre ele através de nosso e-mail;</li>
<li>Excluir os comentários gravados em qualquer momento;</li>
<li>Solicitar a exclusão de todos os seus dados, suspendendo sua conta definitivamente. Salvo os casos em que a lei exigir sua manutenção;</li>
<li>Atualizar, na área “Configurações”, os dados pessoais que estejam incompletos, inexatos ou desatualizados;</li>
<li>Saber com quais entidades públicas e privadas a equipe Insônia Literária compartilha seus dados pessoais;</li>
<li>Se opor às operações realizadas com os seus dados pessoais que não dependam de seu consentimento. Neste caso, é possível solicitar sua interrupção;</li>
<li>Dão dar ou retirar seu consentimento e obter informações sobre as consequências dessa escolha. Nesse caso, os serviços do aplicativo não poderão ser prestados;</li>
<li>Solicitar mais detalhes sobre as informações que coletamos e como e por que as usamos e compartilhamos;</li>
<li>Encerrar sua conta a qualquer momento.</li>
</ul>
<p class=comum>Quando você encerra a sua conta, nos a desativamos, excluimos seus dados e seus históricos. Seu dispositivo móvel lhe permite escolher se suas fotos serão compatilhadas conosco. Em caso de solicitações ou dúvidas sobre os direitos acima, envie um e-mail para insonialiteraria4@gmail.com.</p>
<br>
<p class=prime><b>Confidencialidade e segurança</b></p>
<p class=comum>O usuário também é responsável pelo sigilo dos seus dados pessoais e deve ter sempre ciência de que o compartilhamento de senhas viola esta política e pode comprometer a segurança dos seus dados fornecidos ao aplicativo.
<p class=comum>É muito importante que o usuário se proteja contra o acesso não autorizado ao seu dispositivo móvel ou conta, além de se certificar de sempre clicar em “sair” ao encerrar sua navegação em um dispositivo móvel compartilhado.
<p class=comum>Internamente, os dados pessoais coletados são acessados somente por profissionais autorizados, respeitando os princípios de proporcionalidade, necessidade e relevância, além do compromisso de confidencialidade e preservação da privacidade.
<p class=comum>Ao utilizar nosso aplicativo, o usuário poderá ser conduzido, via link, a sites de terceiros, que poderão coletar suas informações e ter suas próprias políticas de privacidade. Nós recomendamos que o usuário leia as políticas de privacidade de tais sites, sendo de sua responsabilidade aceitá-las ou rejeitá-las.
<p class=comum>A Equipe Insônia Literária não se responsabiliza pelas políticas de privacidade, conteúdos ou serviços dos sites de terceiros</p>
<br>
<p class=prime><b>Como essa política é alterada</b></p>
<p class=comum>Podemos alterar esta política de tempos em tempos e, se o fizermos, ela estará publicada nesse mesmo lugar com as atualizações apontadas. Se continuar usando o Insônia Literária depois que essas alterações entrarem em vigor, você estará concordando com a nova política. Caso as mudanças sejam significativas, poderemos fornecer um aviso mais destacado ou obter sua permissão atrávés de um e-mail, conforme exigido por lei.</p>
<br>
<center><h3>Termos de Uso</h3></center>
<p class=prime>Esses termos de uso são referentes ao seu acesso e uso do aplicativo Insônia Literária. Leia estes termos com atenção e entre em contato conosco caso tenha alguma dúvida. Ao acessar ou utilizar o Insônia Literária, você concorda em seguir estes Termos de Uso e nossa Política de Privacidade.</p>
<br>
<p class=prime><b>Sobre o nosso serviço</b></p>
<p class=comum>O aplicativo Insônia Literária fornece a você, usuário, obras de romance e contos originais, projetados e escritos por Reinaldo de Souza e Carolina Anf desde 2018, para leitura sem nenhum custo adicional. Para fornecer os serviços, precisamos poder identificar você através de alguns dados pessoais que serão solicitados na criação de sua conta no aplicativo. Algumas das coisas que mostramos são promovidas por anunciantes. Como parte do nosso serviço, procuramos garantir que até mesmo o conteúdo promovido seja relevante e interessante para você. Anúncios serão facilmente identificados.</p>
<br>
<p class=prime><b>Quem pode usar o Insônia Literária</b></p>
<p class=comum>Você poderá usar o aplicativo Insônia Literária somente se puder concordar com esses termos. Ao criar sua conta no Insônia Literária, você deve fornecer seus dados corretamente. O uso do Insônia Literária inclui o download de software no seu dispositivo móvel. Você concorda que podemos atualizar automaticamente o software, e estes Termos serão aplicados a todas as atualizações.</p>
<p class=comum><b>Classificação 14 anos, Classificação Indicativa (ClassInd), Brasi</b></p>
<br>
<p class=prime><b>Seu conteúdo</b></p>
<p class=comum>O Insônia Literária permite que você publique comentários. Todos os comentários que você publica são considerados Seu Conteúdo. Você mantém todos os direitos sobre ele e poderá se desfazer deles a hora que desejar. Você é o único responsável pelo conteúdo que você publica.</p>
<p class=comum>Você concede ao Insônia Literária e aos nossos usuários uma licença não exclusiva e livre de direitos autorais válida no Brasil todo para usar, armazenar, exibir, reproduzir, salvar, modificar, criar trabalhos derivados, executar e distribuir Seu Conteúdo no Insônia Literária exclusivamente para os fins de operação, desenvolvimento, fornecimento e utilização do Insônia Literária. Nada contido nestes Termos restringe outros direitos legais que o Insônia Literária possa ter sobre Seu Conteúdo, como sob outras licenças, por exemplo. Nós nos reservamos o direito de remover Seu Conteúdo, ou alterar a maneira como é usado no Insônia Literária, por qualquer motivo. Isso inclui o Seu Conteúdo que acreditamos violar estes Termos, nossas Diretrizes da Comunidade ou quaisquer outras políticas como intenção de prejudicar ou discriminar alguém, conter termo pejorativo ou maldoso. O usuário que o fez será alertado e o conteúdo será excluído. Isso também é valido para conteúdos que contém apologias a estupro, pedofilia, tráfico de drogas ou abusos de qualquer tipo.</p>
<p class=comum>Seu conteúdo poderá permanecer no Insônia Literária mesmo após a desativação de sua conta, diferente de seus dados pessoais que serão excluidos assim que sua conta for desativada.</p>
<p class=comum>A equipe Insônia Literária não tolera nenhum tipo de preconceito ou discriminação.</p>
<br>
<p class=prime><b>Nossos contatos</b></p>
<p class=comum>O Insônia Literária possui um e-mail comercial para contato. Em necessidade de reportar algo, fazer uma sugestão ou mandar um olá, você pode entrar em contato com a equipe pelo e-mail a seguir: insonialiteraria4@gmail.com.</p>
<p class=comum>Possuímos também um conta comercial na rede social <i>Instagram</i>, cujo link está disponível no aplicativo. A conta está ativa e também contém com interações de nossa equipe com seus seguidores. Entre em contato conosco por lá também, caso prefira.</p>
<p class=comum>Caso decida enviar comentários, ideias ou sugestōes, você concorda que somos livres para utilizá-los sem nenhuma restrição ou compensação para você.</p>
<br>
<p class=prime><b>Política de Direitos Autorais</b></p>
<p class=comum>Todas as obras publicadas no Insônia Literária possuem direitos autorais. Assim como não fornecemos conteúdos que não nos pertencem, avisamos que em nenhuma hipótese, esse conteúdo pode ser publicado em outra plataforma ou outro meio por autores que não sejam da equipe Insônia Literária.</p>
<p class=comum>Nós respeitamos os direitos autorais. Queremos que nossos usuários também respeitem.</p>
<br>
<p class=prime><b>Segurança</b></p>
<p class=comum>O Insônia Literária deseja que nossos usuários tenham a melhor experiência no uso do aplicativo, por isso nos preocupamos com a sua segurança. Não medimos esforços para proteger a sua conta e o seu conteúdo, porém não podemos garantir que terceiros não autorizados não sejam capazes de ultrapassar nossas medidas de segurança. Pedimos que mantenha sua senha segura e que nos avise caso ocorra o uso indevido de sua conta por terceiros.</p>
<br>
<p class=prime><b>Links externos</b></p>
<p class=comum>O Insônia Literária possui links de acesso para sites de terceiros, anunciantes ou serviços que estão fora do controle do aplicativo. Não endossamos nem assumimos nenhuma responsabilidade por qualquer site, informações, materiais, produtos ou serviços de terceiros.</p>
<br>
<p class=prime><b>Conflitos</b></p>
<p class=comum>Em qualquer conflito que tenha com o Insônia Literária, você concorda em entrar em contato primeiramente com a equipe do Insônia Literária pelos meios de contato fornecidos nesse termo, para uma tentativa de resolução desse conflito. Se precisarmos entrar em contato com você, faremos isso pelo endereço de e-mail que você forneceu ao criar sua conta no Insônia Literária, por isso o mantenha sempre atualizado. Caso o Insônia Literária não tenha sido capaz de resolver o conflito com você informalmente, cada um de nós concorda em resolver qualquer reivindicação, disputa ou controvérsia (excluindo reivindicações por medidas cautelares ou outros auxílios equitativos) decorrente de, em conexão com ou relacionada a estes Termos por processo arbitral ou tribunal de pequenas causas (para as reivindicações que se qualifiquem).</p>
<br>
<p class=prime><b>Termos gerais</b></p>
<p class=comum>Nós temos o direito de determinar a forma e os meios de lhe fornecer notificações, e você concorda em receber avisos de natureza jurídica eletronicamente, se assim o decidirmos. Poderemos revisar esses Termos de tempos em tempos, e a versão mais atual sempre estará publicada nesse mesmo local. Se uma revisão, a nosso critério, for considerada significativa, nós notificaremos você. Ao continuar a acessar ou usar o Insônia Literária após a efetivação das revisões, você concorda em seguir os novos Termos. Se você não concordar com os novos termos, interrompa o uso do Insônia Literária.</p>
<br>
<p class=prime>Esperamos que a sua estadia por aqui seja duradoura e satisfatória para todos nós. Que você se divirta com o conteúdo que temos para mostrar e que possamos criar vínculos por aqui. Esse é o desejo de toda a equipe Insônia Literária.</p>
</body></html>";
        }

        async void clkFechar(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}