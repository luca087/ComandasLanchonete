using ComandasLanchonete.Models;
using ComandasLanchonete.Services;
using Microsoft.AspNetCore.Mvc;

namespace ComandasLanchonete.Controllers
{
    [ApiController]
    [Route("auth")]
    public class AuthController : ControllerBase
    {
        private readonly AuthService _authService;

        public AuthController(AuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public ActionResult<AuthResult> Login([FromBody]LoginModel loginModel)
        {
            try
            {
                return Ok(_authService.Login(loginModel));
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("logout")]
        public ActionResult Logout()
        {
            try
            {
                _authService.Logout();
                return Ok();
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
