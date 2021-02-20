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
            int indice;

            do
            {
                Console.WriteLine(menu.EscolherTipoVideo());
                Console.Write("Opção: ");
                menu.OpcaoUsuario = char.Parse(Console.ReadLine().ToUpper());

                // Movimentações em Séries
                if (menu.OpcaoUsuario == 'S')
                {
                    do
                    {
                        Console.WriteLine(menu.ImprimirMenu());
                        Console.Write("Opção: ");
                        menu.OpcaoUsuario = char.Parse(Console.ReadLine().ToUpper());

                        switch (menu.OpcaoUsuario)
                        {
                            case '1':// Listar Série
                                listar.ListarSeries();
                                break;

                            case '2':// Inserir Série
                                menu.OpcaoGenero();// Retorna a Lista de Gêneros -->enum
                                inserir.InserirSerie();
                                break;

                            case '3':// Atualizar
                                Console.Write("\nDigite o Id da Série: ");
                                indice = int.Parse(Console.ReadLine());
                                menu.OpcaoGenero();// Retorna a Lista de Gêneros -->enum 
                                atualizar.AtualizarSerie(indice);
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
                        Console.WriteLine(menu.ImprimirMenu());
                        Console.Write("Opção: ");
                        menu.OpcaoUsuario = char.Parse(Console.ReadLine().ToUpper());

                        switch (menu.OpcaoUsuario)
                        {
                            case '1':
                                listar.ListarFilmes();
                                break;

                            case '2':// Inserir Filme
                                menu.OpcaoGenero();// Retorna a Lista de Gêneros -->enum                             
                                inserir.InserirFilme();
                                break;

                            case '3':// Atualizar Filme
                                Console.Write("\nDigite o Id do Filme: ");
                                indice = int.Parse(Console.ReadLine());
                                menu.OpcaoGenero();// Retorna a Lista de Gêneros -->enum                                
                                atualizar.AtualizarFilme(indice);
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
