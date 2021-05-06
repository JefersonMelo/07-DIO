using Api_Catalogo.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api_Catalogo.Repositories
{
    public interface ILivroRepository : IDisposable
    {
        Task<List<Livro>> Obter(int pagina, int quantidade);
        Task<Livro> Obter(Guid id);
        Task<List<Livro>> Obter(string nomeAutor, string titulo);
        Task Inserir(Livro livro);
        Task AtualizarDescricao(Livro livro);
        Task Atualizar(Livro livro);
        Task Remover(Guid id);
    }
}
