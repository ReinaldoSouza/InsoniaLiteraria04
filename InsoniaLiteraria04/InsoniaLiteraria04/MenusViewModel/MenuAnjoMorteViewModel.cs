using InsoniaLiteraria04.Global;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace InsoniaLiteraria04.MenusViewModel
{
    public class MenuAnjoMorteViewModel
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

        public MenuAnjoMorteViewModel()
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
                Imagem = "anjomorteseta.jpg"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Prologo,
                Descricao = null,
                Titulo = "PRÓLOGO",
                Imagem = "menuanjomorte.jpg"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo1,
                Descricao = null,
                Titulo = "CAPÍTULO 1",
                Imagem = "menuanjomorte.jpg"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo2,
                Descricao = null,
                Titulo = "CAPÍTULO 2",
                Imagem = "menuanjomorte.jpg"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo3,
                Descricao = null,
                Titulo = "CAPÍTULO 3",
                Imagem = "menuanjomorte.jpg"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo4,
                Descricao = null,
                Titulo = "CAPÍTULO 4",
                Imagem = "menuanjomorte.jpg"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo5,
                Descricao = null,
                Titulo = "CAPÍTULO 5",
                Imagem = "menuanjomorte.jpg"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo6,
                Descricao = null,
                Titulo = "CAPÍTULO 6",
                Imagem = "menuanjomorte.jpg"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo7,
                Descricao = null,
                Titulo = "CAPÍTULO 7",
                Imagem = "menuanjomorte.jpg"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo8,
                Descricao = null,
                Titulo = "CAPÍTULO 8",
                Imagem = "menuanjomorte.jpg"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo9,
                Descricao = null,
                Titulo = "CAPÍTULO 9",
                Imagem = "menuanjomorte.jpg"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo10,
                Descricao = null,
                Titulo = "CAPÍTULO 10",
                Imagem = "menuanjomorte.jpg"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo11,
                Descricao = null,
                Titulo = "CAPÍTULO 11",
                Imagem = "menuanjomorte.jpg"
            });

            ListaMenu = menuItems;
        }
    }
}
