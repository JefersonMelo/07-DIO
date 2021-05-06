using Api_Catalogo.InputModel;
using Api_Catalogo.ViewModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api_Catalogo.Services
{
    public interface ILivroService : IDisposable
    {
        Task<List<LivroViewModel>> Obter(int pagina, int quantidade);
        Task<LivroViewModel> Obter(Guid id);
        Task<LivroViewModel> Inserir(LivroInputModel livro);
        Task Atualizar(Guid id, LivroInputModel livro);
        Task AtualizarDescricao(Guid id, string descricao);
        Task AtualizarPreco(Guid id, double preco);
        Task Remover(Guid id);
    }
}
