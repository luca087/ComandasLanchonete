using ComandasLanchonete.Models;
using Microsoft.AspNetCore.Mvc;

namespace ComandasLanchonete.Controllers
{
    [ApiController]
    [Route("comandas")]
    public class ComandasController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Comanda>> GetComandas()
        {
            return Ok(new List<Comanda>());
        }

        [HttpGet("{id}")]
        public ActionResult<Comanda> GetComanda(int id)
        {
            return Ok(new Comanda());
        }

        [HttpPost]
        public ActionResult<Comanda> CreateComanda([FromBody] Comanda newComanda)
        {
            return Ok(newComanda);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateComanda(int id, [FromBody] Comanda comanda)
        {
            return Ok(comanda);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteComanda(int id)
        {
            return Ok("");
        }
    }
}
