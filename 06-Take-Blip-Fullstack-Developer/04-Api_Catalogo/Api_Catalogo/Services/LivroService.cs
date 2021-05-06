using Api_Catalogo.Entities;
using Api_Catalogo.Exceptions;
using Api_Catalogo.InputModel;
using Api_Catalogo.Repositories;
using Api_Catalogo.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Catalogo.Services
{
    public class LivroService : ILivroService
    {
        private readonly ILivroRepository _livroRepository;

        public LivroService(ILivroRepository jogoRepository)
        {
            _livroRepository = jogoRepository;
        }

        public async Task<List<LivroViewModel>> Obter(int pagina, int quantidade)
        {
            var livros = await _livroRepository.Obter(pagina, quantidade);

            return livros.Select(livro => new LivroViewModel
            {
                Id = livro.Id,
                NomeAutor = livro.NomeAutor,
                Titulo = livro.Titulo,
                Descricao = livro.Descricao,
                Preco = livro.Preco
            }).ToList();
        }

        public async Task<LivroViewModel> Obter(Guid id)
        {
            var livro = await _livroRepository.Obter(id);

            if ( livro == null )
                return null;

            return new LivroViewModel
            {
                Id = livro.Id,
                NomeAutor = livro.NomeAutor,
                Titulo = livro.Titulo,
                Descricao = livro.Descricao,
                Preco = livro.Preco
            };
        }

        public async Task<LivroViewModel> Inserir(LivroInputModel livro)
        {
            var entidadeLivro = await _livroRepository.Obter(livro.NomeAutor, livro.Titulo);

            if ( entidadeLivro.Count > 0 )
                throw new LivroJaCadastradoException();

            var jogoInsert = new Livro
            {
                Id = Guid.NewGuid(),
                NomeAutor = livro.NomeAutor,
                Titulo = livro.Titulo,
                Descricao = livro.Descricao,
                Preco = livro.Preco
            };

            await _livroRepository.Inserir(jogoInsert);

            return new LivroViewModel
            {
                Id = jogoInsert.Id,
                NomeAutor = livro.NomeAutor,
                Titulo = livro.Titulo,
                Descricao = livro.Descricao,
                Preco = livro.Preco
            };
        }

        public async Task Atualizar(Guid id, LivroInputModel livro)
        {
            var entidadeLivro = await _livroRepository.Obter(id);

            if ( entidadeLivro == null )
                throw new LivroNaoCadastradoException();

            entidadeLivro.NomeAutor = livro.NomeAutor;
            entidadeLivro.Titulo = livro.Titulo;
            entidadeLivro.Descricao = livro.Descricao;
            entidadeLivro.Preco = livro.Preco;

            await _livroRepository.Atualizar(entidadeLivro);
        }

        public async Task AtualizarDescricao(Guid id, string descricao)
        {
            var entidadeLivro = await _livroRepository.Obter(id);

            if ( entidadeLivro == null )
                throw new LivroNaoCadastradoException();

            entidadeLivro.Descricao = descricao;

            await _livroRepository.AtualizarDescricao(entidadeLivro);
        }

        public async Task AtualizarPreco(Guid id, double preco)
        {
            var entidadeLivro = await _livroRepository.Obter(id);

            if ( entidadeLivro == null )
                throw new LivroNaoCadastradoException();

            entidadeLivro.Preco = preco;

            await _livroRepository.Atualizar(entidadeLivro);
        }

        public async Task Remover(Guid id)
        {
            var livro = await _livroRepository.Obter(id);

            if ( livro == null )
                throw new LivroNaoCadastradoException();

            await _livroRepository.Remover(id);
        }

        public void Dispose( )
        {
            _livroRepository?.Dispose();
        }
    }
}
