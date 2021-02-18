using System;

namespace CadastroSeries
{
    class Program
    {
        static ManipulacaoDados manipulacaoDados = new ManipulacaoDados();
        static Menu menu = new Menu();

        static void Main( string[] args )
        {
            do
            {
                Console.WriteLine(menu.ImprimirMenu());
                Console.Write("Opção: ");
                menu.OpcaoUsuario = char.Parse(Console.ReadLine().ToUpper());

                switch (menu.OpcaoUsuario)
                {
                    case '1':
                        manipulacaoDados.ListarSeries();
                        break;
                    case '2':
                        manipulacaoDados.InserirSerie();
                        break;
                    case '3':
                        manipulacaoDados.AtualizarSerie();
                        break;
                    case '4':
                        manipulacaoDados.ExcluirSerie();
                        break;
                    case '5':
                        manipulacaoDados.VisualizarSerie();
                        break;
                    case 'C':
                        Console.Clear();
                        break;

                }

            } while (menu.OpcaoUsuario != 'X');

            Console.WriteLine("Obrigado Por Utilizar Nossos Serviços.");
            Console.ReadLine();
        }
    }
}
