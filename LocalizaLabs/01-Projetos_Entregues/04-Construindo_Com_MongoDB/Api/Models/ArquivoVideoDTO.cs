using System;

namespace Api.Models
{
    public class ArquivoVideoDTO
    {
        public DateTime DataLancamento { get; set; }
        public string Genero { get; set; }
        public string Sinpse { get; set; }
        public string CodigoBarras { get; set; }
    }
}
