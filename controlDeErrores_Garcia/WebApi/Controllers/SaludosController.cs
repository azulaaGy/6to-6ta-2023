
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("saludos")]
    [ApiController]
    public class SaludosController : ControllerBase
    {
        [HttpGet("{nombre}")]
        public ActionResult<string> obtenerSaludo(string nombre)
        {
            return $"hola, {nombre}!";
        }
    }
}
