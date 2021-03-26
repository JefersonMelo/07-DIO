using System;

namespace CadastroSeries
{
    public class Serie : EntidadeBase
    {
        //Atributos
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        //Métodos
        public Serie( int id, Genero genero, string titulo, string descricao, int ano )
        {
            Id = id;
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
            Excluido = false;
        }

        public override string ToString( )
        {
            /*
             * Environment.NewLine 
             * https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
             */

            return $"\nGênero: {Genero + Environment.NewLine}" +
                   $"Título: {Titulo + Environment.NewLine}" +
                   $"Descrição: {Descricao + Environment.NewLine}" +
                   $"Ano de Início: {Ano + Environment.NewLine}" +
                   $"Excluído: {Excluido}";

        }

        public string RetornarTitulo( )
        {
            return Titulo;
        }

        public int RetornarId( )
        {
            return Id;
        }
        public bool RetornarExcluido( )
        {
            return Excluido;
        }

        public void Excluir( )
        {
            Excluido = true;
        }
    }
}
