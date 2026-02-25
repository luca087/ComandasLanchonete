using ComandasLanchonete.DAL.Models;

namespace ComandasLanchonete.DAL
{
    public class UsusariosDAL
    {
        private readonly AppDbContext _context;

        public UsusariosDAL(AppDbContext context)
        {
            _context = context;
        }

        public UserDALModel CreateUsuario(UserDALModel userDALModel)
        {
            _context.Usuarios.Add(userDALModel);
            _context.SaveChanges();
            return userDALModel;
        }

        public IEnumerable<UserDALModel> GetUsuarios()
        {
            return _context.Usuarios.ToList();
        }
    }
}
