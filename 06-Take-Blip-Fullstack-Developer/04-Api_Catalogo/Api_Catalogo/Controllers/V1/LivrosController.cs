using Api_Catalogo.Exceptions;
using Api_Catalogo.InputModel;
using Api_Catalogo.Services;
using Api_Catalogo.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Catalogo.Controllers.V1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        private readonly ILivroService _livroService;

        public LivrosController(ILivroService livroService)
        {
            _livroService = livroService;
        }

        /// <summary>
        /// Buscar todos os livros de forma paginada
        /// </summary>
        /// <remarks>
        /// Não é possível retornar os livros sem paginação
        /// </remarks>
        /// <param name="pagina">Indica qual página está sendo consultada. Mínimo 1</param>
        /// <param name="quantidade">Indica a quantidade de reistros por página. Mínimo 1 e máximo 50</param>
        /// <response code="200">Retorna a lista de livros</response>
        /// <response code="204">Caso não haja livros</response>   
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LivroViewModel>>> Obter([FromQuery, Range(1, int.MaxValue)] int pagina = 1, [FromQuery, Range(1, 50)] int quantidade = 5)
        {
            var livros = await _livroService.Obter(pagina, quantidade);

            if ( livros.Count() == 0 )
                return NoContent();

            return Ok(livros);
        }

        /// <summary>
        /// Buscar um livro pelo seu Id
        /// </summary>
        /// <param name="idLivro">Id do livro buscado</param>
        /// <response code="200">Retorna o livro filtrado</response>
        /// <response code="204">Caso não haja livro com este id</response>   
        [HttpGet("{idLivro:guid}")]
        public async Task<ActionResult<LivroViewModel>> Obter([FromRoute] Guid idLivro)
        {
            var livro = await _livroService.Obter(idLivro);

            if ( livro == null )
                return NoContent();

            return Ok(livro);
        }

        /// <summary>
        /// Inserir um livro no catálogo
        /// </summary>
        /// <param name="livroInputModel">Dados do livro a ser inserido</param>
        /// <response code="200">Cao o livro seja inserido com sucesso</response>
        /// <response code="422">Caso já exista um livro com mesmo NomeAutor para a mesma Titulo</response>   
        [HttpPost]
        public async Task<ActionResult<LivroViewModel>> InserirLivro([FromBody] LivroInputModel livroInputModel)
        {
            try
            {
                var livro = await _livroService.Inserir(livroInputModel);

                return Ok(livro);
            }
            catch ( LivroJaCadastradoException ex )
            {
                return UnprocessableEntity("Já existe um livro com este NomeAutor para esta Titulo");
            }
        }

        /// <summary>
        /// Atualizar um livro no catálogo
        /// </summary>
        /// /// <param name="idLivro">Id do livro a ser atualizado</param>
        /// <param name="livroInputModel">Novos dados para atualizar o livro indicado</param>
        /// <response code="200">Cao o livro seja atualizado com sucesso</response>
        /// <response code="404">Caso não exista um livro com este Id</response>   
        [HttpPut("{idLivro:guid}")]
        public async Task<ActionResult> AtualizarLivro([FromRoute] Guid idLivro, [FromBody] LivroInputModel livroInputModel)
        {
            try
            {
                await _livroService.Atualizar(idLivro, livroInputModel);

                return Ok();
            }
            catch ( LivroNaoCadastradoException ex )
            {
                return NotFound("Não existe este livro");
            }
        }

        ///// <summary>
        ///// Atualizar a descrição de um livro
        ///// </summary>
        ///// /// <param name="idLivro">Id do livro a ser atualizado</param>
        ///// <param name="descricao">Nova descrição do livro</param>
        ///// <response code="200">Caso a descrição seja atualizado com sucesso</response>
        ///// <response code="404">Caso não exista um livro com este Id</response>   
        //[HttpPatch("{idLivro:guid}/descricao/{descricao:string}")]
        //public async Task<ActionResult> AtualizarLivroDescricao([FromRoute] Guid idLivro, [FromRoute] string descricao)
        //{
        //    try
        //    {
        //        await _livroService.AtualizarDescricao(idLivro, descricao);
        //        return Ok();
        //    }
        //    catch ( LivroNaoCadastradoException ex )
        //    {
        //        return NotFound("Este livro não existe!");
        //    }
        //}

        /// <summary>
        /// Atualizar o preço de um livro
        /// </summary>
        /// /// <param name="idLivro">Id do livro a ser atualizado</param>
        /// <param name="preco">Novo preço do livro</param>
        /// <response code="200">Cao o preço seja atualizado com sucesso</response>
        /// <response code="404">Caso não exista um livro com este Id</response>   
        [HttpPatch("{idLivro:guid}/preco/{preco:double}")]
        public async Task<ActionResult> AtualizarLivro([FromRoute] Guid idLivro, [FromRoute] double preco)
        {
            try
            {
                await _livroService.AtualizarPreco(idLivro, preco);
                return Ok();
            }
            catch ( LivroNaoCadastradoException ex )
            {
                return NotFound("Não existe este livro");
            }
        }

        /// <summary>
        /// Excluir um livro
        /// </summary>
        /// /// <param name="idLivro">Id do livro a ser excluído</param>
        /// <response code="200">Cao o preço seja atualizado com sucesso</response>
        /// <response code="404">Caso não exista um livro com este Id</response>   
        [HttpDelete("{idLivro:guid}")]
        public async Task<ActionResult> ApagarLivro([FromRoute] Guid idLivro)
        {
            try
            {
                await _livroService.Remover(idLivro);

                return Ok();
            }
            catch ( LivroNaoCadastradoException ex )
            {
                return NotFound("Não existe este livro");
            }
        }

    }
}
