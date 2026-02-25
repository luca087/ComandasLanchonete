using ComandasLanchonete.Models;
using ComandasLanchonete.Services;
using Microsoft.AspNetCore.Mvc;

namespace ComandasLanchonete.Controllers
{
    [ApiController]
    [Route("FurbWeb/v1/usuarios")]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuariosService _usuariosService;

        public UsuarioController(UsuariosService usuariosService)
        {
            _usuariosService = usuariosService;
        }

        [HttpPost]
        public ActionResult CreateUsuario(UserModel userModel)
        {
            try
            {
                _usuariosService.CreateUsuario(userModel);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);  
            }
        }
    }
}
