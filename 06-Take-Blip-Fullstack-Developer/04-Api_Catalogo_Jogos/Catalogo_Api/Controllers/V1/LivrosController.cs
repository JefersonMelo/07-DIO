using Catalogo_Api.ImputModel;
using Catalogo_Api.ViewModel;
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
        public async Task<ActionResult<LivroViewModel>> Obter( )
        {
            return Ok();
        }

        [HttpGet("{idLivro:guid}")]
        public async Task<ActionResult<LivroViewModel>> Obter(Guid idLivro)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult<LivroViewModel>> Inserir(LivroImputModel livro)
        {
            return Ok();
        }

        [HttpPut("{idLivro:guid}")]
        public async Task<ActionResult> Atualizar(Guid idLivro, LivroImputModel livro)
        {
            return Ok();
        }

        [HttpPatch("{idLivro:guid}/prefacio/{prefacio:string}")]
        public async Task<ActionResult> Atualizar(Guid idLivro, string prefacio)
        {
            return Ok();
        }

        [HttpPatch("{idLivro:guid}/classificacao/{classificacao:int}")]
        public async Task<ActionResult> Atualizar(Guid idLivro, int classificacao)
        {
            return Ok();
        }

        [HttpPatch("{idLivro:guid}/preco/{preco:double}")]
        public async Task<ActionResult> Atualizar(Guid idLivro, double preco)
        {
            return Ok();
        }

        [HttpDelete("{idLivro:guid}")]
        public async Task<ActionResult> Apagar(Guid idLivro)
        {
            return Ok();
        }
    }
}
