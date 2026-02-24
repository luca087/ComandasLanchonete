using ComandasLanchonete.Models;
using ComandasLanchonete.Services;
using Microsoft.AspNetCore.Mvc;

namespace ComandasLanchonete.Controllers
{
    [ApiController]
    [Route("comandas")]
    public class ComandasController : ControllerBase
    {
        private readonly ComandasService _comandasService;

        public ComandasController(ComandasService comandasService)
        {
            _comandasService = comandasService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Comanda>> GetComandas()
        {
            try
            {
                return Ok(_comandasService.GetComandas());
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Comanda> GetComanda(int id)
        {
            return Ok(new Comanda());
        }

        [HttpPost]
        public ActionResult<Comanda> CreateComanda([FromBody] Comanda newComanda)
        {
            try
            {
                return Ok(_comandasService.CreateComanda(newComanda));
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public ActionResult UpdateComanda(int id, [FromBody] Comanda comanda)
        {
            try
            {
                _comandasService.UpdateComanda(new Comanda(comanda){Id = id});
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteComanda(int id)
        {
            try
            {
                _comandasService.DeleteComanda(id);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
