using InsoniaLiteraria04.Global;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace InsoniaLiteraria04.MenusViewModel
{
    public class MenuApenasDanceViewModel
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

        public MenuApenasDanceViewModel()
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
                Imagem = "apenasdanceseta.jpg"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo1,
                Descricao = "O Baile",
                Titulo = "CAPÍTULO 1",
                Imagem = "menuapenasdance.JPG"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo2,
                Descricao = "A Carta",
                Titulo = "CAPÍTULO 2",
                Imagem = "menuapenasdance.JPG"
            });

            ListaMenu = menuItems;

        }

    }
}
