using System;
using System.Collections.Generic;
using System.Text;

namespace InsoniaLiteraria04.Model
{
    public class Resposta
    {
        public string Id { get; set; }
        public string Usuario_id { get; set; }
        public string Usuario { get; set; }
        public string Mensagem { get; set; }
        public string Data { get; set; }
        public bool Excluir { get; set; }
        public string Imagem { get; set; }
    }
}
