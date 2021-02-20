using System;

namespace CadastroSeries
{
    public class Menu
    {
        public Menu( ) { }

        public Menu( char op )
        {
            this.OpcaoUsuario = op;
        }

        public char OpcaoUsuario { get; set; }

        public string ImprimirMenu( )
        {
            return $"\nInforme Uma Opção:\n" +
                   $"1- Listar\n" +
                   $"2- Inserir Novo\n" +
                   $"3- Atualizar\n" +
                   $"4- Excluir\n" +
                   $"5- Visualizar\n" +
                   $"C- Limpar Tela\n" +
                   $"X- Sair";
        }

        public string EscolherTipoVideo( )
        {
            return $"\nEscolha Uma Opção:\n" +
                   $"F- Filmes\n" +
                   $"S- Séries\n" +
                   /*$"I- Infantil\n" +*/
                   /*$"A- Adulto\n" +*/
                   $"X- Sair";
        }

        public void OpcaoGenero( )
        {
            Console.WriteLine();
            // https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
            // https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o Gênero Entre as Opções Acima: ");
        }
    }
}
