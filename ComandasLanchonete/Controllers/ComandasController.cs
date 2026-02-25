using ComandasLanchonete.Models;
using ComandasLanchonete.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ComandasLanchonete.Controllers
{
    [Authorize]
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
            catch(Exception  ex) 
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<ComandaModel> GetComanda(int id)
        {
            try
            {
                return Ok(_comandasService.GetComandaById(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult<ComandaModel> CreateComanda([FromBody] ComandaModel newComanda)
        {
            try
            {
                return Ok(_comandasService.CreateComanda(newComanda));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public ActionResult UpdateComanda(int id, [FromBody] ComandaModel comanda)
        {
            try
            {
                comanda.Id = id;
                _comandasService.UpdateComanda(comanda);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
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
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
