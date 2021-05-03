using Catalogo_Api.Exceptions;
using Catalogo_Api.ImputModel;
using Catalogo_Api.Services;
using Catalogo_Api.ViewModel;
using Microsoft.AspNetCore.Http;
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

        [HttpPost]
        public async Task<ActionResult<LivroViewModel>> Inserir([FromBody] LivroImputModel livroImputModel)
        {
            try
            {
                var jogo = await _livroService.Inserir(livroImputModel);
                return Ok(jogo);
            }
            catch ( LivroJaCadastradoException ex )
            {
                return UnprocessableEntity("Já Existe um Livro com esse Título desta editora");
            }            
        }

        [HttpPut("{idLivro:guid}")]
        public async Task<ActionResult> Atualizar([FromRoute] Guid idLivro, [FromBody] LivroImputModel livroImputModel)
        {
            try
            {
                await _livroService.Atualizar(idLivro, livroImputModel);
                return Ok();
            }
            catch ( LivroNaoCadastradoException ex )
            {
                return NotFound("Este livro não existe!");
            }
        }

        [HttpPatch("{idLivro:guid}/prefacio/{prefacio:string}")]
        public async Task<ActionResult> Atualizar([FromRoute] Guid idLivro, [FromRoute] string prefacio)
        {
            try
            {
                await _livroService.Atualizar(idLivro, prefacio);
                return Ok();
            }
            catch ( LivroNaoCadastradoException ex )
            {
                return NotFound("Este livro não existe!");
            }
        }

        [HttpPatch("{idLivro:guid}/classificacao/{classificacao:int}")]
        public async Task<ActionResult> Atualizar([FromRoute] Guid idLivro, [FromRoute] int classificacao)
        {
            try
            {
                await _livroService.Atualizar(idLivro, classificacao);
                return Ok();
            }
            catch ( LivroNaoCadastradoException ex )
            {
                return NotFound("Este livro não existe!");
            }
        }

        [HttpPatch("{idLivro:guid}/preco/{preco:double}")]
        public async Task<ActionResult> Atualizar([FromRoute] Guid idLivro, [FromRoute] double preco)
        {
            try
            {
                await _livroService.Atualizar(idLivro, preco);
                return Ok();
            }
            catch ( LivroNaoCadastradoException ex )
            {
                return NotFound("Este livro não existe!");
            }
        }

        [HttpDelete("{idLivro:guid}")]
        public async Task<ActionResult> Apagar([FromRoute] Guid idLivro)
        {
            try
            {
                await _livroService.Remover(idLivro);
                return Ok();
            }
            catch ( Exception )
            {

                throw;
            }            
        }
    }
}
