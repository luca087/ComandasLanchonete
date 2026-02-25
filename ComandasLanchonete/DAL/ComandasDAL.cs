using ComandasLanchonete.DAL.Models;
using ComandasLanchonete.Models;

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
            _context.Comandas.Add(comanda);
            _context.SaveChanges();
            return comanda;
        } 

        public IEnumerable<ComandaDALModel> GetComandas()
        {
            return _context.Comandas;
        }

        public void UpdateComanda(ComandaDALModel comanda)
        {
            
        }

        public void DeleteComanda(int id)
        {
            
        }
    }
}
