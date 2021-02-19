using System;

namespace CadastroSeries
{
    public class Atualizar
    {
        public Atualizar( ) { }

        static SerierepositorioSeries repositorioSeries = new SerierepositorioSeries();

        public void AtualizarSerie( )// Opção 3
        {
            Console.Write("\nDigite o Id da Série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            // https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
            // https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("\nDigite o Gênero Entre as Opções Acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("\nDigite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("\nDigite o Ano de Início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("\nDigite a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

            Serie atualizaSerie = new Serie(id: indiceSerie,
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);

            repositorioSeries.Atualizar(indiceSerie, atualizaSerie);
        }
    }
}
