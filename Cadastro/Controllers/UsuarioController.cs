using Cadastro.Models;
using Cadastro.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Cadastro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IPessoaFisicaRepositorio _pessoaFisicaRepositorio;


        [HttpGet]
        public ActionResult<List<UsuarioModel>> BuscarUsuarios()
        {
            return Ok();
        }


    }
}
