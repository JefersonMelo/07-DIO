using System;

namespace Api.Data.Collections
{
    public class ArquivoVideo
    {
        public DateTime DataLancamento { get; set; }
        public string Genero { get; set; }
        public string Sinpse { get; set; }
        public string CodigoBarras { get; set; }

        public ArquivoVideo(string codigoBarras, DateTime dataLancamento, string genero, string sinpse)
        {
            CodigoBarras = codigoBarras;
            DataLancamento = dataLancamento;
            Genero = genero;
            Sinpse = sinpse;            
        }
    }
}
