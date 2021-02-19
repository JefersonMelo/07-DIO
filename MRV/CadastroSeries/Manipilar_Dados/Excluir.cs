using System;

namespace CadastroSeries
{
    public class Excluir
    {
        static SerieRepositorio repositorio = new SerieRepositorio();

        public void ExcluirSerie( )// Opção 4
        {
            Console.Write("\nDigite o Id da Série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            repositorio.Excluir(indiceSerie);
        }
    }
}
