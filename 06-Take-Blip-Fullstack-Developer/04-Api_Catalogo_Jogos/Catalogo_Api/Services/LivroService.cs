using Catalogo_Api.Entities;
using Catalogo_Api.Exceptions;
using Catalogo_Api.ImputModel;
using Catalogo_Api.Services;
using Catalogo_Api.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalogo_Api.Repositories
{
    public class LivroService : ILivroService
    {
        private readonly ILivroRepository _livroRepositoriy;

        public LivroService(ILivroRepository livroRepositoriy)
        {
            _livroRepositoriy = livroRepositoriy;
        }

        public async Task<List<LivroViewModel>> Obter(int pagina, int quantidade)
        {
            var livros = await _livroRepositoriy.Obter(pagina, quantidade);

            return livros.Select(livro => new LivroViewModel
            {
                Id = livro.Id,
                Autor = livro.Autor,
                Titulo = livro.Titulo,
                Editora = livro.Editora,
                Prefacio = livro.Prefacio,                
                Classificacao = livro.Classificacao,
                Preco = livro.Preco
            }).ToList();
        }

        public async Task<LivroViewModel> Obter(Guid id)
        {
            var livro = await _livroRepositoriy.Obter(id);

            if ( livro == null )
            {
                return null;
            }

            return new LivroViewModel
            {
                Id = livro.Id,
                Autor = livro.Autor,
                Titulo = livro.Titulo,
                Editora = livro.Editora,
                Prefacio = livro.Prefacio,                
                Classificacao = livro.Classificacao,
                Preco = livro.Preco
            };
        }

        public async Task<LivroViewModel> Inserir(LivroImputModel livro)
        {
            var entidadeLivro = await _livroRepositoriy.Obter(livro.Autor, livro.Editora);

            if ( entidadeLivro.Count > 0 )
            {
                throw new LivroJaCadastradoException();
            }

            var InsertLivro = new Livro
            {
                Id = Guid.NewGuid(),
                Autor = livro.Autor,
                Titulo = livro.Titulo,
                Editora = livro.Editora,
                Prefacio = livro.Prefacio,
                Classificacao = livro.Classificacao,
                Preco = livro.Preco
            };

            await _livroRepositoriy.Inserir(InsertLivro);

            return new LivroViewModel
            {
                Id = InsertLivro.Id,
                Autor = livro.Autor,
                Titulo = livro.Titulo,
                Editora = livro.Editora,                
                Prefacio = livro.Prefacio,
                Classificacao = livro.Classificacao,
                Preco = livro.Preco
            };
        }

        public async Task Atualizar(Guid id, LivroImputModel livro)
        {
            var entidadeLivro = await _livroRepositoriy.Obter(id);

            if ( entidadeLivro == null )
            {
                throw new NotImplementedException();
            }
            entidadeLivro.Autor = livro.Autor;
            entidadeLivro.Titulo = livro.Titulo;
            entidadeLivro.Editora = livro.Editora;
            entidadeLivro.Prefacio = livro.Prefacio;
            entidadeLivro.Classificacao = livro.Classificacao;
            entidadeLivro.Preco = livro.Preco;

            await _livroRepositoriy.Atualizar(entidadeLivro);

        }

        public async Task Atualizar(Guid id, double preco)
        {
            var entidadeLivro = await _livroRepositoriy.Obter(id);

            if ( entidadeLivro == null )
            {
                throw new NotImplementedException();
            }

            entidadeLivro.Preco = preco;

            await _livroRepositoriy.Atualizar(entidadeLivro);
        }

        public async Task Atualizar(Guid id, string prefacio)
        {
            var entidadeLivro = await _livroRepositoriy.Obter(id);

            if ( entidadeLivro == null )
            {
                throw new NotImplementedException();
            }

            entidadeLivro.Prefacio = prefacio;

            await _livroRepositoriy.Atualizar(entidadeLivro);
        }

        public async Task Atualizar(Guid id, int classificacao)
        {
            var entidadeLivro = await _livroRepositoriy.Obter(id);

            if ( entidadeLivro == null )
            {
                throw new NotImplementedException();
            }

            entidadeLivro.Classificacao = classificacao;

            await _livroRepositoriy.Atualizar(entidadeLivro);
        }

        public async Task Remover(Guid id)
        {
            var entidadeLivro = await _livroRepositoriy.Obter(id);

            if ( entidadeLivro == null )
            {
                throw new NotImplementedException();
            }

            await _livroRepositoriy.Remover(id);

        }

        public void Dispose( )
        {
            _livroRepositoriy?.Dispose();
        }
    }
}
