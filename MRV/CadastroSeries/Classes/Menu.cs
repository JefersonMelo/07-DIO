namespace CadastroSeries
{
    public class Menu
    {
        public Menu( ) { }

        public char OpcaoUsuario { get; set; }

        public string ImprimirMenu( )
        {
            return $"\nInforme Uma Opção:\n" +
                   $"F- Filmes" +
                   $"S- Séries" +
                   $"1- Listar\n" +
                   $"2- Inserir Novo\n" +
                   $"3- Atualizar\n" +
                   $"4- Excluir\n" +
                   $"5- Visualizar\n" +
                   $"C- Limpar Tela\n" +
                   $"X- Sair";
        }

        public Menu( char op ) 
        {
            this.OpcaoUsuario = op;
        }

        //public string MenuIserirAtualizar( )
        //{

        //}

    }
}
