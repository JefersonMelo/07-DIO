using System;

namespace CadastroSeries
{
    class Program
    {
        static Menu menu = new Menu();
        static Listar listar = new Listar();
        static Excluir excluir = new Excluir();
        static Inserir inserir = new Inserir();
        static Atualizar atualizar = new Atualizar();        
        static Visualizar visualizar = new Visualizar();

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
                        listar.ListarSeries();
                        break;
                    case '2':
                        inserir.InserirSerie();
                        break;
                    case '3':
                        atualizar.AtualizarSerie();
                        break;
                    case '4':
                        excluir.ExcluirSerie();
                        break;
                    case '5':
                        visualizar.VisualizarSerie();
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
