using ComandasLanchonete.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ComandasLanchonete.Services
{
    public class AuthService
    {
        private readonly UsuariosService _usariosService;
        private readonly JwtConfig _jwtConfig;
        public AuthService(UsuariosService usariosService, JwtConfig jwtConfig)
        {
            _usariosService = usariosService;
            _jwtConfig = jwtConfig;
        }

        public AuthResult Login(LoginModel loginModel)
        {
            var user = _usariosService.GetUsuarios().SingleOrDefault(x => x.Login == loginModel.Login);

            if (user == null)
            {
                throw new Exception("Login ou senha inválidos!");
            }

            var hash = PasswordHasher.GenerateHash(loginModel.Password, user.SenhaSalt);

            if (hash != user.Senha)
            {
                throw new Exception("Login ou senha inválidos!");
            }

            var claims = new[]
        {
            new Claim(ClaimTypes.Name, user.Login)
        };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtConfig.SecretKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var minutes = 15;

            var token = new JwtSecurityToken(
                issuer: _jwtConfig.ValidIssuer,
                audience: _jwtConfig.ValidAudience,
                claims: claims,
                expires: DateTime.Now.AddMinutes(minutes),
                signingCredentials: creds);

            var tokenString = new JwtSecurityTokenHandler().WriteToken(token);

            return new AuthResult()
            {
                Access_Token = tokenString,
                Expires_In = minutes * 60000,
                Token_Type = "Bearer"
            };
        }

        public void Logout()
        {

        }
    }
}
