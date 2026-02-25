using ComandasLanchonete.DAL.Models;

namespace ComandasLanchonete.DAL
{
    public class ComandasDAL
    {
        private readonly AppDbContext _context;

        public ComandasDAL(AppDbContext context)
        {
            _context = context;
        }

        public ComandaDALModel CreateComanda(ComandaDALModel comanda)
        {
            var entity = _context.Comandas.Add(comanda);
            _context.SaveChanges();
            return entity.Entity;
        }

        public IEnumerable<ComandaDALModel> GetComandas()
        {
            return _context.Comandas;
        }

        public ComandaDALModel GetComandaById(int id)
        {
            return _context.Comandas.Find(id);
        }

        public void UpdateComanda(ComandaDALModel comanda)
        {
            _context.Comandas.Update(comanda);
            _context.SaveChanges();
        }

        public void DeleteComanda(int id)
        {
            var comanda = GetComandaById(id);

            if (comanda != null)
            {
                _context.Comandas.Remove(comanda);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Comanda não existente!");
            }
        }
    }
}
