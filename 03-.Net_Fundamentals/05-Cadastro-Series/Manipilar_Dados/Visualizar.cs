using System;

namespace CadastroSeries
{
    public class Visualizar
    {
        public Visualizar( ) { }

        //static SerierepositorioSeries repositorioSeries = new SerierepositorioSeries();
        //static RepositorioSeriesFilmes repFilmes = new RepositorioSeriesFilmes();

        // Manipular Séries Opção 5
        public void VisualizarSerie( )
        {
            SerierepositorioSeries repositorioSeries = new SerierepositorioSeries();

            Console.Write("\nDigite o Id da Série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = repositorioSeries.RetornarId(indiceSerie);

            Console.WriteLine(serie);
        }

        // Manipular Filmes Opção 5
        public void VisualizarFilme( )
        {
            RepositorioSeriesFilmes repFilmes = new RepositorioSeriesFilmes();

            Console.Write("\nDigite o Id do Filme: ");
            int indice = int.Parse(Console.ReadLine());

            var filme = repFilmes.RetornarId(indice);

            Console.WriteLine(filme);
        }
    }
}
