using Catalogo_Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalogo_Api.Repositories
{
    public class LivroRepository : ILivroRepositoriy
    {
        public Task Atualizar(Livro livro)
        {
            throw new NotImplementedException();
        }

        public void Dispose( )
        {
            throw new NotImplementedException();
        }

        public Task<Livro> Inserir(Livro livro)
        {
            throw new NotImplementedException();
        }

        public Task<List<Livro>> Obter(int pagina, int quantidade)
        {
            throw new NotImplementedException();
        }

        public Task<List<Livro>> Obter(string autor, string editora)
        {
            throw new NotImplementedException();
        }

        public Task<Livro> Obter(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Remover(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
