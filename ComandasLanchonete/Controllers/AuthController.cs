using ComandasLanchonete.Models;
using Microsoft.AspNetCore.Mvc;

namespace ComandasLanchonete.Controllers
{
    [ApiController]
    [Route("auth")]
    public class AuthController : ControllerBase
    {
        [HttpPost("login")]
        public ActionResult<AuthResult> Login([FromBody]LoginModel loginModel)
        {
            return Ok(new AuthResult());
        }

        [HttpPost("logout")]
        public ActionResult Logout()
        {
            return Ok();
        }
    }
}
