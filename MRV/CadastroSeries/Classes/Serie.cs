using System;
using System.Collections.Generic;
using System.Text;
using CadastroSeries.Enum;

namespace CadastroSeries.Classes
{
    class Serie : EntidadeBase
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
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
        }

        public override string ToString( )
        {
            /*
             * Environment.NewLine 
             * https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
             */
            return $"Gênero: {this.Genero + Environment.NewLine}" +
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

        public void Excluir( )
        {
            this.Excluido = true;
        }
    }
}
