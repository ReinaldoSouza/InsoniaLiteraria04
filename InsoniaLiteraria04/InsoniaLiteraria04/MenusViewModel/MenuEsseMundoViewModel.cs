using InsoniaLiteraria04.Global;
using System.Collections.ObjectModel;

namespace InsoniaLiteraria04.MenusViewModel
{
    public class MenuEsseMundoViewModel
    {
        public ObservableCollection<OpcoesMenu> ListaMenu { get; set; }

        private OpcoesMenu _menuSelecionado { get; set; }

        public OpcoesMenu MenuSelecionado
        {
            get
            {
                return _menuSelecionado;
            }
            set
            {
                if (_menuSelecionado != value)
                {
                    _menuSelecionado = value;
                }
            }
        }
        
        public MenuEsseMundoViewModel()
        {
            this.ListaMenu = new ObservableCollection<OpcoesMenu>();
            CarregarCapitulos();
        }

        public void CarregarCapitulos()
        {
            ListaMenu.Clear();
            ObservableCollection<OpcoesMenu> menuItems = new ObservableCollection<OpcoesMenu>();

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.PrincipalPage,
                Descricao = null,
                Titulo = "Voltar Para a Tela Principal",
                Imagem = "essemundoseta.jpg"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Prologo,
                Descricao = "Bem Vindo à Minha Vida",
                Titulo = "PRÓLOGO",
                Imagem = "menuessemundo.JPG"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo1,
                Descricao = "Emily",
                Titulo = "CAPÍTULO 1",
                Imagem = "menuessemundo.JPG"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo2,
                Descricao = "O Céu é Mais Azul em Malibu",
                Titulo = "CAPÍTULO 2",
                Imagem = "menuessemundo.JPG"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo3,
                Descricao = "Um Dia Vamos Saber... Por Que Eu Não Fui Feito Para Você... Que Eu Era O Único Para Você",
                Titulo = "CAPÍTULO 3",
                Imagem = "menuessemundo.JPG"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo4,
                Descricao = "Eu Te Desafio A Se Mexer",
                Titulo = "CAPÍTULO 4",
                Imagem = "menuessemundo.JPG"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo5,
                Descricao = "Dizem Por Aí",
                Titulo = "CAPÍTULO 5",
                Imagem = "menuessemundo.JPG"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo6,
                Descricao = "Mas Eu Sou Só Um Humano Comum Com Jeitos Comuns",
                Titulo = "CAPÍTULO 6",
                Imagem = "menuessemundo.JPG"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo7,
                Descricao = "Você Não Pode Se Esconder de Seus Fantasmas",
                Titulo = "CAPÍTULO 7",
                Imagem = "menuessemundo.JPG"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo8,
                Descricao = "Príncipe Nada Encantado",
                Titulo = "CAPÍTULO 8",
                Imagem = "menuessemundo.JPG"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo9,
                Descricao = "Eu Atiro Em Tudo O Que Eu Já Amei",
                Titulo = "CAPÍTULO 9",
                Imagem = "menuessemundo.JPG"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo10,
                Descricao = "De Mãos Vazias",
                Titulo = "CAPÍTULO 10",
                Imagem = "menuessemundo.JPG"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo11,
                Descricao = "Eu Acredito Que Podemos Fazer Isso",
                Titulo = "CAPÍTULO 11",
                Imagem = "menuessemundo.JPG"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo12,
                Descricao = "Me Diga Quando For A Hora De Eu Dizer Que Te Amo",
                Titulo = "CAPÍTULO 12",
                Imagem = "menuessemundo.JPG"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo13,
                Descricao = "Contando Estrelas",
                Titulo = "CAPÍTULO 13",
                Imagem = "menuessemundo.JPG"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo14,
                Descricao = "Às Vezes Eu Queria Poder Te Salvar",
                Titulo = "CAPÍTULO 14",
                Imagem = "menuessemundo.JPG"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo15,
                Descricao = "Você Está Feliz?",
                Titulo = "CAPÍTULO 15",
                Imagem = "menuessemundo.JPG"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo16,
                Descricao = "Estranhos, Farsas Perfeitas",
                Titulo = "CAPÍTULO 16",
                Imagem = "menuessemundo.JPG"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo17,
                Descricao = "O Homem Que Não Podem Mover",
                Titulo = "CAPÍTULO 17",
                Imagem = "menuessemundo.JPG"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo18,
                Descricao = "Com Você Por Perto",
                Titulo = "CAPÍTULO 18",
                Imagem = "menuessemundo.JPG"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo19,
                Descricao = "Cale a Boca e Dance Comigo",
                Titulo = "CAPÍTULO 19",
                Imagem = "menuessemundo.JPG"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo20,
                Descricao = "(Não) Se Esqueça de Mim",
                Titulo = "CAPÍTULO 20",
                Imagem = "menuessemundo.JPG"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo21,
                Descricao = "Por Toda A Noite",
                Titulo = "CAPÍTULO 21",
                Imagem = "menuessemundo.JPG"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo22,
                Descricao = "Então é Natal",
                Titulo = "CAPÍTULO 22",
                Imagem = "menuessemundo.JPG"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo23,
                Descricao = "Mais Um Ano, Você Fez Uma Promessa",
                Titulo = "CAPÍTULO 23",
                Imagem = "menuessemundo.JPG"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo24,
                Descricao = "Seja Lá O Que Precisa Dizer, Diga Agora",
                Titulo = "CAPÍTULO 24",
                Imagem = "menuessemundo.JPG"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo25,
                Descricao = "Eu Quero Que Você Seja Mais Feliz",
                Titulo = "CAPÍTULO 25",
                Imagem = "menuessemundo.JPG"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo26,
                Descricao = "Você Não Fez Nada Para Eu Te Amar Menos",
                Titulo = "CAPÍTULO 26",
                Imagem = "menuessemundo.JPG"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo27,
                Descricao = "Como Se Fôssemos Os Únicos No Mundo",
                Titulo = "CAPÍTULO 27",
                Imagem = "menuessemundo.JPG"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo28,
                Descricao = "Mas É Difícil Quando Se é Jovem",
                Titulo = "CAPÍTULO 28",
                Imagem = "menuessemundo.JPG"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo29,
                Descricao = "Minha Vida Seria Uma Droga Sem Você",
                Titulo = "CAPÍTULO 29",
                Imagem = "menuessemundo.JPG"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo30,
                Descricao = "Eu Vou Te Encontrar Lá",
                Titulo = "CAPÍTULO 30",
                Imagem = "menuessemundo.JPG"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo31,
                Descricao = "Mais Duas Pessoas Sozinhas No Mundo Hoje à Noite",
                Titulo = "CAPÍTULO 31",
                Imagem = "menuessemundo.JPG"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo32,
                Descricao = "Ninguém Vai Fazer O Que Eu Faço Por Você",
                Titulo = "CAPÍTULO 32",
                Imagem = "menuessemundo.JPG"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo33,
                Descricao = "Podemos Começar De Novo Antes Que Acabe?",
                Titulo = "CAPÍTULO 33",
                Imagem = "menuessemundo.JPG"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo34,
                Descricao = "A Vida Em Cores é Assim, Hoje Não Parece Com Nenhum Outro Dia",
                Titulo = "CAPÍTULO 34",
                Imagem = "menuessemundo.JPG"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo35,
                Descricao = "Só Diga Que Não Vai Embora",
                Titulo = "CAPÍTULO 35",
                Imagem = "menuessemundo.JPG"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo36,
                Descricao = "Tudo Está Nas Cicatrizes",
                Titulo = "CAPÍTULO 36",
                Imagem = "menuessemundo.JPG"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo37,
                Descricao = "Até Mesmo Os Melhores Caem Às Vezes",
                Titulo = "CAPÍTULO 37",
                Imagem = "menuessemundo.JPG"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo38,
                Descricao = "Estou Desaparecendo",
                Titulo = "CAPÍTULO 38",
                Imagem = "menuessemundo.JPG"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo39,
                Descricao = "Como Se Fosse O Aniversário Dela",
                Titulo = "CAPÍTULO 39",
                Imagem = "menuessemundo.JPG"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo40,
                Descricao = "E Você Estará Quebrado De Um Jeito Melhor",
                Titulo = "CAPÍTULO 40",
                Imagem = "menuessemundo.JPG"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo41,
                Descricao = "Meu Lugar é Com Você",
                Titulo = "CAPÍTULO 41",
                Imagem = "menuessemundo.JPG"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo42,
                Descricao = "Se Você Topar, Eu Topo",
                Titulo = "CAPÍTULO 42",
                Imagem = "menuessemundo.JPG"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo43,
                Descricao = "Fuja Como Um Criminoso",
                Titulo = "CAPÍTULO 43",
                Imagem = "menuessemundo.JPG"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo44,
                Descricao = "O Eco é A Única Voz Que Está Voltando",
                Titulo = "CAPÍTULO 44",
                Imagem = "menuessemundo.JPG"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo45,
                Descricao = "Eu Não Quero Mais Ficar Triste",
                Titulo = "CAPÍTULO 45",
                Imagem = "menuessemundo.JPG"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo46,
                Descricao = "E Eu Vou Tentar Te Consertar",
                Titulo = "CAPÍTULO 46",
                Imagem = "menuessemundo.JPG"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo47,
                Descricao = "Você e Só Você",
                Titulo = "Epílogo",
                Imagem = "menuessemundo.JPG"
            });

            ListaMenu = menuItems;
        }
    }

    

    
}
