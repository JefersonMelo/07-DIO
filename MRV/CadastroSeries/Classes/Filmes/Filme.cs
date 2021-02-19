using System;

namespace CadastroSeries
{
    public class Filme : EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        public Filme( int id, Genero genero, string titulo, string descricao, int ano )
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString( )
        {
            /*
             * Environment.NewLine 
             * https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
             */
            return $"\nGênero: {this.Genero + Environment.NewLine}" +
                   $"Título: {this.Titulo + Environment.NewLine}" +
                   $"Descrição: {this.Descricao + Environment.NewLine}" +
                   $"Ano de Início: {this.Ano + Environment.NewLine}" +
                   $"Excluído: {this.Excluido}";

        }

        public string RetornarTitulo( )
        {
            return this.Titulo;
        }

        public int RetornarId( )
        {
            return this.Id;
        }
        public bool RetornarExcluido( )
        {
            return this.Excluido;
        }

        public void Excluir( )
        {
            this.Excluido = true;
        }
    }
}
