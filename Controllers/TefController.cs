using Microsoft.AspNetCore.Mvc;

namespace CSharpModule.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TefController : Controller
    {
        public class Pagamento
        {
            public int IdVenda { get; set; }
            public string Cartao { get; set; }
            public decimal Valor { get; set; }
        }

        [HttpPost]
        public IActionResult ProcessarPagamento([FromBody] Pagamento pagamento)
        {
            // Simula aprovação do pagamento
            var aprovado = true;
            var codigoAutorizacao = aprovado ? "123456" : null;

            return Ok(new
            {
                sucesso = aprovado,
                codigoAutorizacao,
                mensagem = aprovado ? "Pagamento aprovado" : "Pagamento recusado"
            });
        }
    }
}
