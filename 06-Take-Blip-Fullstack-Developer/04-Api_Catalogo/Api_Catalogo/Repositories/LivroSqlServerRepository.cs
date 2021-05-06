using Api_Catalogo.Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Api_Catalogo.Repositories
{
    public class LivroSqlServerRepository : ILivroRepository
    {
        private readonly SqlConnection sqlConnection;

        public LivroSqlServerRepository(IConfiguration configuration)
        {
            sqlConnection = new SqlConnection(configuration.GetConnectionString("Default"));
        }

        public async Task<List<Livro>> Obter(int pagina, int quantidade)
        {
            var livros = new List<Livro>();

            var comando = $"select * from livros order by id offset {( ( pagina - 1 ) * quantidade )} rows fetch next {quantidade} rows only";

            await sqlConnection.OpenAsync();
            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
            SqlDataReader sqlDataReader = await sqlCommand.ExecuteReaderAsync();

            while ( sqlDataReader.Read() )
            {
                livros.Add(new Livro
                {
                    Id = ( Guid )sqlDataReader["Id"],
                    NomeAutor = ( string )sqlDataReader["NomeAutor"],
                    Titulo = ( string )sqlDataReader["Titulo"],
                    Descricao = ( string )sqlDataReader["Descricao"],
                    Preco = ( double )sqlDataReader["Preco"]
                });
            }

            await sqlConnection.CloseAsync();

            return livros;
        }

        public async Task<Livro> Obter(Guid id)
        {
            Livro livro = null;

            var comando = $"select * from livros where Id = '{id}'";

            await sqlConnection.OpenAsync();
            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
            SqlDataReader sqlDataReader = await sqlCommand.ExecuteReaderAsync();

            while ( sqlDataReader.Read() )
            {
                livro = new Livro
                {
                    Id = ( Guid )sqlDataReader["Id"],
                    NomeAutor = ( string )sqlDataReader["NomeAutor"],
                    Titulo = ( string )sqlDataReader["Titulo"],
                    Descricao = ( string )sqlDataReader["Descricao"],
                    Preco = ( double )sqlDataReader["Preco"]
                };
            }

            await sqlConnection.CloseAsync();

            return livro;
        }

        public async Task<List<Livro>> Obter(string NomeAutor, string Titulo)
        {
            var livros = new List<Livro>();

            var comando = $"select * from livros where NomeAutor = '{NomeAutor}' and Titulo = '{Titulo}'";

            await sqlConnection.OpenAsync();
            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
            SqlDataReader sqlDataReader = await sqlCommand.ExecuteReaderAsync();

            while ( sqlDataReader.Read() )
            {
                livros.Add(new Livro
                {
                    Id = ( Guid )sqlDataReader["Id"],
                    NomeAutor = ( string )sqlDataReader["NomeAutor"],
                    Titulo = ( string )sqlDataReader["Titulo"],
                    Descricao = ( string )sqlDataReader["Descricao"],
                    Preco = ( double )sqlDataReader["Preco"]
                });
            }

            await sqlConnection.CloseAsync();

            return livros;
        }

        public async Task Inserir(Livro livro)
        {
            var comando = $"insert livros (Id, NomeAutor, Titulo, Preco) values ('{livro.Id}', '{livro.NomeAutor}', '{livro.Titulo}', {livro.Preco.ToString().Replace(",", ".")})";

            await sqlConnection.OpenAsync();
            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            await sqlConnection.CloseAsync();
        }

        public async Task Atualizar(Livro livro)
        {
            var comando = $"update livros set NomeAutor = '{livro.NomeAutor}', Titulo = '{livro.Titulo}', Preco = {livro.Preco.ToString().Replace(",", ".")} where Id = '{livro.Id}'";

            await sqlConnection.OpenAsync();
            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            await sqlConnection.CloseAsync();
        }

        public async Task AtualizarDescricao(Livro livro)
        {
            var comando = $"update livros set NomeAutor = '{livro.NomeAutor}', Titulo = '{livro.Titulo}', Preco = {livro.Preco.ToString().Replace(",", ".")} where Id = '{livro.Id}'";

            await sqlConnection.OpenAsync();
            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            await sqlConnection.CloseAsync();
        }

        public async Task Remover(Guid id)
        {
            var comando = $"delete from livros where Id = '{id}'";

            await sqlConnection.OpenAsync();
            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            await sqlConnection.CloseAsync();
        }

        public void Dispose( )
        {
            sqlConnection?.Close();
            sqlConnection?.Dispose();
        }
    }
}
