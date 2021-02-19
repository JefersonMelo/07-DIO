using System;

namespace CadastroSeries
{
    public class Listar
    {
        public Listar( ) { }

        static SerierepositorioSeries repositorioSeries = new SerierepositorioSeries();
        static RepositorioSeriesFilmes repFilmes = new RepositorioSeriesFilmes();

        // Manipular Séries Opção 1 
        public void ListarSeries( )
        {
            Console.WriteLine("\nListar Séries");

            var lista = repositorioSeries.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("\nNenhuma Série Cadastrada.");
                return;
            }

            foreach (var serie in lista)
            {
                var excluido = serie.RetornarExcluido();

                Console.WriteLine($"#ID: {serie.RetornarId()}: - " +
                                  $"{serie.RetornarTitulo()} " +
                                  $"{(excluido ? "*Excluído*" : "")}");
            }
        }

        // Manipular Filmes Opção 1 
        public void ListarFilmes( )
        {
            Console.WriteLine("\nListar Filmes");

            var lista = repFilmes.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("\nNenhum Filme Cadastrado.");
                return;
            }

            foreach (var filme in lista)
            {
                var excluido = filme.RetornarExcluido();

                Console.WriteLine($"#ID: {filme.RetornarId()}: - " +
                                  $"{filme.RetornarTitulo()} " +
                                  $"{(excluido ? "*Excluído*" : "")}");
            }
        }
    }
}
