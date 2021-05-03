using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalogo_Api.ViewModel
{
    public class TrailerViewModel
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Editora { get; set; }
        public string Sinopse { get; set; }
        public int Classificacao { get; set; }
        public double Preco { get; set; }
    }
}
