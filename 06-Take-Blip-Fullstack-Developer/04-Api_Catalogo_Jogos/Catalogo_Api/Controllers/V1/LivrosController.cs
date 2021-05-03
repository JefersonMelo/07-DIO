using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalogo_Api.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<object>> Obter( )
        {
            return Ok();
        }

        [HttpGet("{idLivro:guid}")]
        public async Task<ActionResult<object>> Obter(Guid idLivro)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult<object>> Inserir(object livro)
        {
            return Ok();
        }

        [HttpPut("{idLivro:guid}")]
        public async Task<ActionResult<object>> Atualizar(Guid idLivro, object livro)
        {
            return Ok();
        }

        [HttpPatch("{idLivro:guid}/sinopse/{sinopse:string}")]
        public async Task<ActionResult<object>> Atualizar(Guid idLivro, string sinopse)
        {
            return Ok();
        }

        [HttpPatch("{idLivro:guid}/classificacao/{classificacao:int}")]
        public async Task<ActionResult<object>> Atualizar(Guid idLivro, int classificacao)
        {
            return Ok();
        }

        [HttpPatch("{idLivro:guid}/preco/{preco:double}")]
        public async Task<ActionResult<object>> Atualizar(Guid idLivro, double preco)
        {
            return Ok();
        }

        [HttpDelete("{idLivro:guid}")]
        public async Task<ActionResult<object>> Apagar(Guid idLivro)
        {
            return Ok();
        }
    }
}
