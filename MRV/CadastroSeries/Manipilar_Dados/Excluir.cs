using System;

namespace CadastroSeries
{
    public class Excluir
    {
        public Excluir( ) { }

        static SerierepositorioSeries repositorioSeries = new SerierepositorioSeries();

        public void ExcluirSerie( )// Opção 4
        {
            Console.Write("\nDigite o Id da Série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            repositorioSeries.Excluir(indiceSerie);
        }
    }
}
