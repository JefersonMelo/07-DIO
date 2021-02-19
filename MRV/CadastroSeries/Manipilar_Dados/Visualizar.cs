using System;

namespace CadastroSeries
{
    public class Visualizar
    {
        static SerieRepositorio repositorio = new SerieRepositorio();

        public void VisualizarSerie( )// Opção 5
        {
            Console.Write("\nDigite o Id da Série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = repositorio.RetornarId(indiceSerie);

            Console.WriteLine(serie);
        }
    }
}
