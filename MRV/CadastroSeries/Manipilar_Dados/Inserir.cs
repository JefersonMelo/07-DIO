using System;

namespace CadastroSeries
{
    public class Inserir
    {
        static SerieRepositorio repositorio = new SerieRepositorio();

        public void InserirSerie( )// Opção 2
        {
            Console.WriteLine("\nInserir Nova Série");

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

            Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);

            repositorio.Inserir(novaSerie);
        }
    }
}
