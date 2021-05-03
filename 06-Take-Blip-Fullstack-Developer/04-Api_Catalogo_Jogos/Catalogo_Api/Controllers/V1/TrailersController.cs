using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalogo_Api.Controllers.V1
{
    [Route("api/V1/[controller]")]
    [ApiController]
    public class TrailersController : ControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<object>> Obter( )
        {
            return Ok();
        }

        [HttpGet("{idTrailer:guid}")]
        public async Task<ActionResult<object>> Obter(Guid idTrailer)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult<object>> Inserir(object trailer)
        {
            return Ok();
        }

        [HttpPut("{idTrailer:guid}")]
        public async Task<ActionResult<object>> Atualizar(Guid idTrailer, object trailer)
        {
            return Ok();
        }

        [HttpPatch("{idTrailer:guid}/sinopse/{sinopse:string}")]
        public async Task<ActionResult<object>> Atualizar(Guid idTrailer, string sinopse)
        {
            return Ok();
        }

        [HttpDelete("{idTrailer:guid}")]
        public async Task<ActionResult<object>> Apagar(Guid idTrailer)
        {
            return Ok();
        }
    }
}
