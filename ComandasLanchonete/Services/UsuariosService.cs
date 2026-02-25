using ComandasLanchonete.DAL;
using ComandasLanchonete.DAL.Models;
using ComandasLanchonete.Models;

namespace ComandasLanchonete.Services
{
    public class UsuariosService
    {
        private readonly UsusariosDAL _ususariosDAL;

        public UsuariosService(UsusariosDAL ususariosDAL)
        {
            _ususariosDAL = ususariosDAL;
        }

        public UserModel CreateUsuario(UserModel userModel)
        {
            var user = new UserDALModel(userModel);
            var salt = PasswordHasher.GenerateSalt();
            user.SenhaSalt = salt;
            user.Senha = PasswordHasher.GenerateHash(user.Senha, salt);

            var result = _ususariosDAL.CreateUsuario(user);

            return new UserModel(result);
        }

        public IEnumerable<UserModel> GetUsuarios()
        {
            return _ususariosDAL.GetUsuarios().Select(x => new UserModel(x)).ToList();
        }
    }
}
