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
            int entradaGenero, entradaAno, indice;
            string entradaTitulo, entradaDescricao;


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
                                menu.OpcaoGenero();// Retorna a Lista de Gêneros -->enum
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
                        Console.WriteLine(menu.ImprimirMenu());
                        Console.Write("Opção: ");
                        menu.OpcaoUsuario = char.Parse(Console.ReadLine().ToUpper());

                        switch (menu.OpcaoUsuario)
                        {
                            case '1':
                                listar.ListarFilmes();
                                break;

                            case '2':
                                menu.OpcaoGenero();// Retorna a Lista de Gêneros -->enum
                                entradaGenero = int.Parse(Console.ReadLine());
                                Console.Write("\nDigite o Título do Filme: ");
                                entradaTitulo = Console.ReadLine();
                                Console.Write("\nDigite o Ano de Início do Filme: ");
                                entradaAno = int.Parse(Console.ReadLine());
                                Console.Write("\nDigite a Descrição do Filme: ");
                                entradaDescricao = Console.ReadLine();
                                inserir.InserirFilme(entradaGenero, entradaTitulo, entradaAno, entradaDescricao);
                                break;

                            case '3':
                                Console.Write("\nDigite o Id do Filme: ");
                                indice = int.Parse(Console.ReadLine());
                                menu.OpcaoGenero();// Retorna a Lista de Gêneros -->enum
                                Console.Write("\nDigite o Gênero Entre as Opções Acima: ");
                                entradaGenero = int.Parse(Console.ReadLine());
                                Console.Write("\nDigite o Título da Filme: ");
                                entradaTitulo = Console.ReadLine();
                                Console.Write("\nDigite o Ano de Início da Filme: ");
                                entradaAno = int.Parse(Console.ReadLine());
                                Console.Write("\nDigite a Descrição da Filme: ");
                                entradaDescricao = Console.ReadLine();
                                atualizar.AtualizarFilme(indice, entradaGenero, entradaTitulo, entradaAno, entradaDescricao);
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
