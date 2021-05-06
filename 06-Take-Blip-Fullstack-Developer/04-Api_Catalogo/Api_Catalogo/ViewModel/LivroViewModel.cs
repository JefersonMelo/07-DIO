using System;

namespace Api_Catalogo.ViewModel
{
    public class LivroViewModel
    {
        public Guid Id { get; set; }
        public string NomeAutor { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
    }
}
