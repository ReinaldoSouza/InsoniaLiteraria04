using InsoniaLiteraria04.Global;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace InsoniaLiteraria04.MenusViewModel
{
    public class MenuSegredosObscurosViewModel
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

        public MenuSegredosObscurosViewModel()
        {
            this.ListaMenu = new ObservableCollection<OpcoesMenu>();
            CarregarCapitulos();
        }

        private void CarregarCapitulos()
        {

            ListaMenu.Clear();
            ObservableCollection<OpcoesMenu> menuItems = new ObservableCollection<OpcoesMenu>();

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.PrincipalPage,
                Descricao = null,
                Titulo = "Voltar Para a Tela Principal",
                Imagem = "obscuroseta.jpg"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo1,
                Descricao = "Recomeços",
                Titulo = "CAPÍTULO 1",
                Imagem = "menuobscuro.png"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo2,
                Descricao = "Raiva",
                Titulo = "CAPÍTULO 2",
                Imagem = "menuobscuro.png"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo3,
                Descricao = "Distração",
                Titulo = "CAPÍTULO 3",
                Imagem = "menuobscuro.png"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo4,
                Descricao = "Escolhas",
                Titulo = "CAPÍTULO 4",
                Imagem = "menuobscuro.png"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo5,
                Descricao = "Verdade",
                Titulo = "CAPÍTULO 5",
                Imagem = "menuobscuro.png"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo6,
                Descricao = "Traição",
                Titulo = "CAPÍTULO 6",
                Imagem = "menuobscuro.png"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo7,
                Descricao = "Mentira",
                Titulo = "CAPÍTULO 7",
                Imagem = "menuobscuro.png"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo8,
                Descricao = "Amigos",
                Titulo = "CAPÍTULO 8",
                Imagem = "menuobscuro.png"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo9,
                Descricao = "Culpa",
                Titulo = "CAPÍTULO 9",
                Imagem = "menuobscuro.png"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo10,
                Descricao = "Colegas de Quarto",
                Titulo = "CAPÍTULO 10",
                Imagem = "menuobscuro.png"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo11,
                Descricao = "Ajuda",
                Titulo = "CAPÍTULO 11",
                Imagem = "menuobscuro.png"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo12,
                Descricao = "Encontros",
                Titulo = "CAPÍTULO 12",
                Imagem = "menuobscuro.png"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo13,
                Descricao = "Confusão",
                Titulo = "CAPÍTULO 13",
                Imagem = "menuobscuro.png"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo14,
                Descricao = "Suspeitas",
                Titulo = "CAPÍTULO 14",
                Imagem = "menuobscuro.png"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo15,
                Descricao = "Passado",
                Titulo = "CAPÍTULO 15",
                Imagem = "menuobscuro.png"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo16,
                Descricao = "Reconciliação",
                Titulo = "CAPÍTULO 16",
                Imagem = "menuobscuro.png"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo17,
                Descricao = "Mudança de Alvo",
                Titulo = "CAPÍTULO 17",
                Imagem = "menuobscuro.png"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo18,
                Descricao = "Briga",
                Titulo = "CAPÍTULO 18",
                Imagem = "menuobscuro.png"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo19,
                Descricao = "Amor",
                Titulo = "CAPÍTULO 19",
                Imagem = "menuobscuro.png"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo20,
                Descricao = "Revelação",
                Titulo = "CAPÍTULO 20",
                Imagem = "menuobscuro.png"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo21,
                Descricao = "Ódio",
                Titulo = "CAPÍTULO 21",
                Imagem = "menuobscuro.png"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo22,
                Descricao = "Dúvida",
                Titulo = "CAPÍTULO 22",
                Imagem = "menuobscuro.png"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo23,
                Descricao = "Dance",
                Titulo = "CAPÍTULO 23",
                Imagem = "menuobscuro.png"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo24,
                Descricao = "Despedida",
                Titulo = "CAPÍTULO 24",
                Imagem = "menuobscuro.png"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo25,
                Descricao = "Origem",
                Titulo = "CAPÍTULO 25",
                Imagem = "menuobscuro.png"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo26,
                Descricao = "Luto",
                Titulo = "CAPÍTULO 26",
                Imagem = "menuobscuro.png"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo27,
                Descricao = "Decisão",
                Titulo = "CAPÍTULO 27",
                Imagem = "menuobscuro.png"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo28,
                Descricao = "Erro",
                Titulo = "CAPÍTULO 28",
                Imagem = "menuobscuro.png"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo29,
                Descricao = "Formatura",
                Titulo = "CAPÍTULO 29",
                Imagem = "menuobscuro.png"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo30,
                Descricao = "Caminhos Separados",
                Titulo = "CAPÍTULO 30",
                Imagem = "menuobscuro.png"
            });

            ListaMenu = menuItems;
        }
    }
}
