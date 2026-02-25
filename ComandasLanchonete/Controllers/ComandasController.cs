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
        public ActionResult<IEnumerable<ComandaModel>> GetComandas()
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
        public ActionResult<ComandaModel> GetComanda(int id)
        {
            return Ok(new ComandaModel());
        }

        [HttpPost]
        public ActionResult<ComandaModel> CreateComanda([FromBody] ComandaModel newComanda)
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
        public ActionResult UpdateComanda(int id, [FromBody] ComandaModel comanda)
        {
            try
            {
                _comandasService.UpdateComanda(new ComandaModel(comanda){Id = id});
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
