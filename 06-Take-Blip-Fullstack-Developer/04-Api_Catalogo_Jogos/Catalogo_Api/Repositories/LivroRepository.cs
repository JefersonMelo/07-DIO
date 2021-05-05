using Catalogo_Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalogo_Api.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        private Dictionary<Guid, Livro> livros = new Dictionary<Guid, Livro>()
        {
            {Guid.Parse("0ca314a5-9282-45d8-92c3-2985f2a9fd04"), new Livro{ Id = Guid.Parse("0ca314a5-9282-45d8-92c3-2985f2a9fd04"), Titulo = "Fifa 21", Editora = "EA", Preco = 200, Autor = "AAAA", Classificacao = 12, Prefacio = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"} },
            {Guid.Parse("eb909ced-1862-4789-8641-1bba36c23db3"), new Livro{ Id = Guid.Parse("eb909ced-1862-4789-8641-1bba36c23db3"), Titulo = "Fifa 20", Editora = "EA", Preco = 190, Autor = "BBBB", Classificacao = 18, Prefacio = "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB"} },
            {Guid.Parse("5e99c84a-108b-4dfa-ab7e-d8c55957a7ec"), new Livro{ Id = Guid.Parse("5e99c84a-108b-4dfa-ab7e-d8c55957a7ec"), Titulo = "Fifa 19", Editora = "EA", Preco = 180, Autor = "CCCC", Classificacao = 10, Prefacio = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC"} },
            {Guid.Parse("da033439-f352-4539-879f-515759312d53"), new Livro{ Id = Guid.Parse("da033439-f352-4539-879f-515759312d53"), Titulo = "Fifa 18", Editora = "EA", Preco = 170, Autor = "DDDD", Classificacao = 12, Prefacio = "DDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDD"} },
            {Guid.Parse("92576bd2-388e-4f5d-96c1-8bfda6c5a268"), new Livro{ Id = Guid.Parse("92576bd2-388e-4f5d-96c1-8bfda6c5a268"), Titulo = "Street Fighter V", Editora = "Capcom", Preco = 80, Autor = "EEEE", Classificacao = 12, Prefacio = "EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE"} },
            {Guid.Parse("c3c9b5da-6a45-4de1-b28b-491cbf83b589"), new Livro{ Id = Guid.Parse("c3c9b5da-6a45-4de1-b28b-491cbf83b589"), Titulo = "Grand Theft Auto V", Editora = "Rockstar", Preco = 190, Autor = "FFFF", Classificacao = 12, Prefacio = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF"} }
        };

        public Task<List<Livro>> Obter(int pagina, int quantidade)
        {
            return Task.FromResult(livros.Values.Skip(( pagina - 1 ) * quantidade).Take(quantidade).ToList());
        }

        //Pesquisar mais sobre o Linq
        public Task<List<Livro>> Obter(string autor, string titulo)
        {
            return Task.FromResult(livros.Values.Where(livro => livro.Autor.Equals(autor) && livro.Titulo.Equals(titulo)).ToList());
        }

        public Task<List<Livro>> ObterSemLambda(string autor, string titulo)
        {
            var retorno = new List<Livro>();

            foreach ( var livro in livros.Values )
            {
                if ( livro.Autor.Equals(autor) && livro.Titulo.Equals(titulo) )
                {
                    retorno.Add(livro);
                }
            }
            return Task.FromResult(retorno);
        }

        public Task<Livro> Obter(Guid id)
        {
            if ( !livros.ContainsKey(id) )
            {
                return Task.FromResult<Livro>(null);
            }
            return Task.FromResult(livros[id]);
        }

        public Task<Livro> Inserir(Livro livro)
        {
            livros.Add(livro.Id, livro);
            return ( Task<Livro> )Task.CompletedTask;
        }

        public Task Atualizar(Livro livro)
        {
            livros[livro.Id] = livro;
            return Task.CompletedTask;
        }

        public Task Remover(Guid id)
        {
            livros.Remove(id);
            return Task.CompletedTask;
        }

        public void Dispose( )
        {
            //Fechar conexão com o banco
        }
    }
}
