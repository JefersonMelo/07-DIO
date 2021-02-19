using System;

namespace CadastroSeries
{
    public class Listar
    {
        public Listar( ) { }

        static SerieRepositorio repositorio = new SerieRepositorio();

        public void ListarSeries( )// Opção 1
        {
            Console.WriteLine("\nListar Séries");

            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("\nNenhuma Série Cadastrada.");
                return;
            }

            foreach (var serie in lista)
            {
                var excluido = serie.RetornarExcluido();

                //Console.WriteLine("#ID {0}: - {1} {2}", serie.RetornarId(), serie.RetornarTitulo(), (excluido ? "*Excluído*" : ""));

                Console.WriteLine($"#ID: {serie.RetornarId()}: - " +
                                  $"{serie.RetornarTitulo()} " +
                                  $"{(excluido ? "*Excluído*" : "")}");
            }
        }
    }
}
