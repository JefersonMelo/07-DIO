using Catalogo_Api.ImputModel;
using Catalogo_Api.ViewModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Catalogo_Api.Services
{
    public interface ILivroService
    {
        Task<List<LivroViewModel>> Obter(int pagina, int quantidade);
        Task<LivroViewModel> Obter(Guid id);
        Task<LivroViewModel> Inserir(LivroImputModel livro);
        Task Atualizar(Guid id, LivroImputModel livro);
        Task Atualizar(Guid id, double preco);
        Task Atualizar(Guid id, string prefacio);
        Task Atualizar(Guid id, int classificacao);
        Task Remover(Guid id);
    }
}
