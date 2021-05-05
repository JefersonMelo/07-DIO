using Catalogo_Api.Exceptions;
using Catalogo_Api.ImputModel;
using Catalogo_Api.Services;
using Catalogo_Api.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Catalogo_Api.Controllers.V1
{
    [Route("api/[controller]")]
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
        public async Task<ActionResult<IEnumerable<LivroViewModel>>> Obter([FromQuery, Range(1, int.MaxValue)] int pagina = 1, [FromQuery, Range(1, 50)] int quanridade = 5)
        {
            var livros = await _livroService.Obter(pagina, quanridade);
            if ( livros.Count() == 0 )
            {
                return NoContent();
            }
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
            {
                return NoContent();
            }
            return Ok(livro);
        }

        /// <summary>
        /// Inserir um livro no catálogo
        /// </summary>
        /// <param name="livroInputModel">Dados do livro a ser inserido</param>
        /// <response code="200">Cao o livro seja inserido com sucesso</response>
        /// <response code="422">Caso já exista um livro com mesmo nome para a mesma produtora</response>   
        [HttpPost]
        public async Task<ActionResult<LivroViewModel>> Inserir([FromBody] LivroImputModel livroImputModel)
        {
            try
            {
                var livro = await _livroService.Inserir(livroImputModel);
                return Ok(livro);
            }
            catch ( LivroJaCadastradoException )
            {
                return UnprocessableEntity("Já Existe um Livro com esse Título desta editora");
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
        public async Task<ActionResult> Atualizar([FromRoute] Guid idLivro, [FromBody] LivroImputModel livroImputModel)
        {
            try
            {
                await _livroService.Atualizar(idLivro, livroImputModel);
                return Ok();
            }
            catch ( LivroNaoCadastradoException )
            {
                return NotFound("Este livro não existe!");
            }
        }

        /// <summary>
        /// Atualizar o prefácio de um livro
        /// </summary>
        /// /// <param name="idLivro">Id do livro a ser atualizado</param>
        /// <param name="prefacio">Novo prefácio do livro</param>
        /// <response code="200">Cao o prefácio seja atualizado com sucesso</response>
        /// <response code="404">Caso não exista um livro com este Id</response>   
        [HttpPatch("{idLivro:guid}/prefacio/{prefacio:string}")]
        public async Task<ActionResult> Atualizar([FromRoute] Guid idLivro, [FromRoute] string prefacio)
        {
            try
            {
                await _livroService.Atualizar(idLivro, prefacio);
                return Ok();
            }
            catch ( LivroNaoCadastradoException )
            {
                return NotFound("Este livro não existe!");
            }
        }

        /// <summary>
        /// Atualizar o classificação de um livro
        /// </summary>
        /// /// <param name="idLivro">Id do livro a ser atualizado</param>
        /// <param name="classificacao">Nova classificação do livro</param>
        /// <response code="200">Cao a classificação seja atualizado com sucesso</response>
        /// <response code="404">Caso não exista um livro com este Id</response>   
        [HttpPatch("{idLivro:guid}/classificacao/{classificacao:int}")]
        public async Task<ActionResult> Atualizar([FromRoute] Guid idLivro, [FromRoute] int classificacao)
        {
            try
            {
                await _livroService.Atualizar(idLivro, classificacao);
                return Ok();
            }
            catch ( LivroNaoCadastradoException )
            {
                return NotFound("Este livro não existe!");
            }
        }

        /// <summary>
        /// Atualizar o preço de um livro
        /// </summary>
        /// /// <param name="idLivro">Id do livro a ser atualizado</param>
        /// <param name="preco">Novo preço do livro</param>
        /// <response code="200">Cao o preço seja atualizado com sucesso</response>
        /// <response code="404">Caso não exista um livro com este Id</response>   
        [HttpPatch("{idLivro:guid}/preco/{preco:double}")]
        public async Task<ActionResult> Atualizar([FromRoute] Guid idLivro, [FromRoute] double preco)
        {
            try
            {
                await _livroService.Atualizar(idLivro, preco);
                return Ok();
            }
            catch ( LivroNaoCadastradoException )
            {
                return NotFound("Este livro não existe!");
            }
        }

        /// <summary>
        /// Excluir um livro
        /// </summary>
        /// /// <param name="idLivro">Id do livro a ser excluído</param>
        /// <response code="200">Cao o preço seja atualizado com sucesso</response>
        /// <response code="404">Caso não exista um livro com este Id</response>  
        [HttpDelete("{idLivro:guid}")]
        public async Task<ActionResult> Apagar([FromRoute] Guid idLivro)
        {
            try
            {
                await _livroService.Remover(idLivro);
                return Ok();
            }
            catch ( LivroNaoCadastradoException )
            {
                return NotFound("Este Livro Não Existe");
            }
        }
    }
}
