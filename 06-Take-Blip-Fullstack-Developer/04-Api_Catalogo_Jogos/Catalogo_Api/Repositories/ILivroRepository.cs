using Catalogo_Api.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Catalogo_Api.Repositories
{
    public interface ILivroRepository : IDisposable
    {
        Task<List<Livro>> Obter(int pagina, int quantidade);
        Task<List<Livro>> Obter(string autor, string editora);
        Task<Livro> Obter(Guid id);
        Task Inserir(Livro livro);
        Task Atualizar(Livro livro);
        Task Remover(Guid id);
    }
}
