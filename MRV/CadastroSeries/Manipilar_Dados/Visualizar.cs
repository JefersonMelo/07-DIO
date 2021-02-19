using System;

namespace CadastroSeries
{
    public class Visualizar
    {
        public Visualizar( ) { }

        static SerierepositorioSeries repositorioSeries = new SerierepositorioSeries();
        static RepositorioSeriesFilmes repFilmes = new RepositorioSeriesFilmes();

        // Manipular Séries Opção 5
        public void VisualizarSerie( )
        {
            Console.Write("\nDigite o Id da Série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = repositorioSeries.RetornarId(indiceSerie);

            Console.WriteLine(serie);
        }

        // Manipular Filmes Opção 5
        public void VisualizarFilme( )
        {
            Console.Write("\nDigite o Id do Filme: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            var filme = repFilmes.RetornarId(indiceSerie);

            Console.WriteLine(filme);
        }
    }
}
