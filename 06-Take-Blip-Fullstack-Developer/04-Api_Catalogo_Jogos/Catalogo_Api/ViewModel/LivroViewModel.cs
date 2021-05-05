using System;

namespace Catalogo_Api.ViewModel
{
    public class LivroViewModel
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
        public string Prefacio { get; set; }
        public int Classificacao { get; set; }
        public double Preco { get; set; }
    }
}
