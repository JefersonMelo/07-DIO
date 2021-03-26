using System;

namespace Api.Data.Collections
{
    public class ArquivoVideo
    {
        public DateTime DataLancamento { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public string Sinpse { get; set; }
        public string CodigoBarras { get; set; }

        public ArquivoVideo(DateTime dataLancamento, string titulo, string genero, string sinpse, string codigoBarras)
        {
            DataLancamento = dataLancamento;
            Titulo = titulo;
            Genero = genero;
            Sinpse = sinpse;
            CodigoBarras = codigoBarras;
        }
    }
}
