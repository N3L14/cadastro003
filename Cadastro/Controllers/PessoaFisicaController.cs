using Cadastro.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cadastro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaFisicaController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<PessoaFisicaModel>> PessoaFisica()
        {
            return Ok();
        }

        [HttpGet]
        public ActionResult<List<PessoaFisicaModel>> PessoaFisicaId()
        {
            return Ok();
        }


    }
}
