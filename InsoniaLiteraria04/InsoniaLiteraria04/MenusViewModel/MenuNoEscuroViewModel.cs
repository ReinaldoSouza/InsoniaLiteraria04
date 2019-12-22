using InsoniaLiteraria04.Global;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace InsoniaLiteraria04.MenusViewModel
{
    public class MenuNoEscuroViewModel
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

        public MenuNoEscuroViewModel()
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
                Imagem = "noescuroseta.jpg"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Prologo,
                Descricao = null,
                Titulo = "PRÓLOGO",
                Imagem = "menuescuro.JPG"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo1,
                Descricao = "Retorno",
                Titulo = "CAPÍTULO 1",
                Imagem = "menuescuro.JPG"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo2,
                Descricao = "A Mulher No Lago",
                Titulo = "CAPÍTULO 2",
                Imagem = "menuescuro.JPG"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo3,
                Descricao = "Máscaras",
                Titulo = "CAPÍTULO 3",
                Imagem = "menuescuro.JPG"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo4,
                Descricao = "A Feira",
                Titulo = "CAPÍTULO 4",
                Imagem = "menuescuro.JPG"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo5,
                Descricao = "Nostalgia",
                Titulo = "CAPÍTULO 5",
                Imagem = "menuescuro.JPG"
            });

            ListaMenu = menuItems;
        }

    }
}
