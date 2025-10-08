using Microsoft.AspNetCore.Mvc;

namespace CSharpModule.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotaController : Controller
    {
        public class Venda
        {
            public int Id { get; set; }
            public string Cliente { get; set; }
            public decimal Valor { get; set; }
        }

        [HttpPost]
        public IActionResult GerarNota([FromBody] Venda venda)
        {
            string xml = $"<nota><id>{venda.Id}</id><cliente>{venda.Cliente}</cliente><valor>{venda.Valor}</valor></nota>";

            return Ok(new { sucesso = true, xml });
        }
    }
}
