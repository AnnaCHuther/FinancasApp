using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinancasApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        [HttpPost("Criar")]
        public IActionResult Criar()
        {
            return Ok();
        }

        [HttpPost("Autenticar")]
        public IActionResult Autenticar()
        {
            return Ok();
        }
    }
}
