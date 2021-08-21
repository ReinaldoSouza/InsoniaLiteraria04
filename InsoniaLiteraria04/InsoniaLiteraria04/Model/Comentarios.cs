using System;

namespace InsoniaLiteraria04.Model
{
    public class Comentarios
    {
        public string Id { get; set; }
        public string Usuario_id { get; set; }
        public string Usuario { get; set; }
        public string Mensagem { get; set; }
        public string Data { get; set; }
        public string Imagem { get; set; }
        public string Respostas { get; set;  }
        public bool Excluir { get; set; }
    }
}
