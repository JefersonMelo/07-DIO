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
                Console.WriteLine(menu.FilmeOuSerie());
                Console.Write("Opção: ");
                menu.OpcaoUsuario = char.Parse(Console.ReadLine().ToUpper());

                // Movimentações em Séries
                if (menu.OpcaoUsuario == 'S')
                {
                    do
                    {
                        Console.Write("Opção: ");
                        Console.WriteLine(menu.ImprimirMenu());
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
                    menu.OpcaoUsuario = ' ';
                }

                // Movimentações em Filmes
                else if (menu.OpcaoUsuario == 'F')
                {
                    do
                    {
                        Console.Write("Opção: ");
                        Console.WriteLine(menu.ImprimirMenu());
                        menu.OpcaoUsuario = char.Parse(Console.ReadLine().ToUpper());

                        switch (menu.OpcaoUsuario)
                        {
                            case '1':
                                listar.ListarFilmes();
                                break;
                            case '2':
                                //inserir.InserirFilme();
                                break;
                            case '3':
                                //atualizar.AtualizarFilme();
                                break;
                            case '4':
                                excluir.ExcluirFilme();
                                break;
                            case '5':
                                visualizar.VisualizarFilme();
                                break;
                            case 'C':
                                Console.Clear();
                                break;

                        }

                    } while (menu.OpcaoUsuario != 'X');
                    menu.OpcaoUsuario = ' ';
                }

            } while (menu.OpcaoUsuario != 'X');

            Console.WriteLine("Obrigado Por Utilizar Nossos Serviços.");
            Console.ReadLine();
        }
    }
}
