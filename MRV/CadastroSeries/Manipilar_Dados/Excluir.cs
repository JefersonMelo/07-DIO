using System;

namespace CadastroSeries
{
    public class Excluir
    {
        public Excluir( ) { }

        static SerierepositorioSeries repositorioSeries = new SerierepositorioSeries();
        static repositorioSeriesFilmes repFilmes = new repositorioSeriesFilmes();

        // Manipulação em Séries Opção 4
        public void ExcluirSerie( )
        {
            Console.Write("\nDigite o Id da Série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            repositorioSeries.Excluir(indiceSerie);
        }

        // Manipulação em Filmes Opção 4
        public void ExcluirFilme( )// Opção 4
        {
            Console.Write("\nDigite o Id do Filme: ");
            int indiceFilme = int.Parse(Console.ReadLine());

            repFilmes.Excluir(indiceFilme);
        }
    }
}
