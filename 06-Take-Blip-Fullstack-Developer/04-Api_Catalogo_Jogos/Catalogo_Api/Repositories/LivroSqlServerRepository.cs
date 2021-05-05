using Catalogo_Api.Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Catalogo_Api.Repositories
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
                    Autor = ( string )sqlDataReader["Autor"],
                    Titulo = ( string )sqlDataReader["Titulo"],
                    Editora = ( string )sqlDataReader["Editora"],
                    Prefacio = ( string )sqlDataReader["Preacio"],
                    Classificacao = ( int )sqlDataReader["Classificacao"],
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
                    Autor = ( string )sqlDataReader["Autor"],
                    Titulo = ( string )sqlDataReader["Titulo"],
                    Editora = ( string )sqlDataReader["Editora"],
                    Prefacio = ( string )sqlDataReader["Preacio"],
                    Classificacao = ( int )sqlDataReader["Classificacao"],
                    Preco = ( double )sqlDataReader["Preco"]
                };
            }

            await sqlConnection.CloseAsync();

            return livro;
        }

        public async Task<List<Livro>> Obter(string autor, string titulo)
        {
            var livros = new List<Livro>();

            var comando = $"select * from livros where Autor = '{autor}' and Titulo = '{titulo}'";

            await sqlConnection.OpenAsync();
            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
            SqlDataReader sqlDataReader = await sqlCommand.ExecuteReaderAsync();

            while ( sqlDataReader.Read() )
            {
                livros.Add(new Livro
                {
                    Id = ( Guid )sqlDataReader["Id"],
                    Autor = ( string )sqlDataReader["Autor"],
                    Titulo = ( string )sqlDataReader["Titulo"],
                    Editora = ( string )sqlDataReader["Editora"],
                    Prefacio = ( string )sqlDataReader["Preacio"],
                    Classificacao = ( int )sqlDataReader["Classificacao"],
                    Preco = ( double )sqlDataReader["Preco"]
                });
            }

            await sqlConnection.CloseAsync();

            return livros;
        }

        public async Task Inserir(Livro livro)
        {
            var comando = $"insert Livro (Id, Autor, Editora, Prefacio, Classificacao, Preco) values ('{livro.Id}', '{livro.Autor}', '{livro.Editora}', {livro.Prefacio}, {livro.Classificacao}, {livro.Preco.ToString().Replace(",", ".")})";

            await sqlConnection.OpenAsync();
            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            await sqlConnection.CloseAsync();

        }

        public async Task Atualizar(Livro livro)
        {
            var comando = $"update Livros set Autor = '{livro.Autor}', Titulo = '{livro.Titulo}', Editora = '{livro.Editora}', Prefacio = '{livro.Prefacio}', Classificacao = '{livro.Classificacao}', Preco = {livro.Preco.ToString().Replace(",", ".")} where Id = '{livro.Id}'";

            await sqlConnection.OpenAsync();
            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            await sqlConnection.CloseAsync();
        }

        public async Task Remover(Guid id)
        {
            var comando = $"delete from Livros where Id = '{id}'";

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
