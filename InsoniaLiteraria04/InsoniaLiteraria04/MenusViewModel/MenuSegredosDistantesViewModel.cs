using InsoniaLiteraria04.Global;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace InsoniaLiteraria04.MenusViewModel
{
    public class MenuSegredosDistantesViewModel
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

        public MenuSegredosDistantesViewModel()
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
                Imagem = "distantesseta.jpg"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Prologo,
                Descricao = "Caixa de Entrada de Temperance",
                Titulo = "PRÓLOGO",
                Imagem = "menudistantes.png"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo1,
                Descricao = "Decepção",
                Titulo = "CAPÍTULO 1",
                Imagem = "menudistantes.png"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo2,
                Descricao = "Vida Nova",
                Titulo = "CAPÍTULO 2",
                Imagem = "menudistantes.png"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo3,
                Descricao = "Segredos",
                Titulo = "CAPÍTULO 3",
                Imagem = "menudistantes.png"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo4,
                Descricao = "Fracasso",
                Titulo = "CAPÍTULO 4",
                Imagem = "menudistantes.png"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo5,
                Descricao = "Coração",
                Titulo = "CAPÍTULO 5",
                Imagem = "menudistantes.png"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo6,
                Descricao = "Time de Dois",
                Titulo = "CAPÍTULO 6",
                Imagem = "menudistantes.png"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo7,
                Descricao = "Aprendizado",
                Titulo = "CAPÍTULO 7",
                Imagem = "menudistantes.png"
            });

            menuItems.Add(new OpcoesMenu
            {
                Codigo = ConstantesEsseMundo.Capitulo8,
                Descricao = "Qualquer Lugar, Menos Aqui",
                Titulo = "CAPÍTULO 8",
                Imagem = "menudistantes.png"
            });

            ListaMenu = menuItems;
        }

    }
}
