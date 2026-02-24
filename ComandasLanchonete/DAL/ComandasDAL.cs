using ComandasLanchonete.DAL.Models;
using ComandasLanchonete.Models;

namespace ComandasLanchonete.DAL
{
    public class ComandasDAL
    {
        public ComandaDALModel CreateComanda(ComandaDALModel comanda)
        {
            return new Comanda();
        } 

        public IEnumerable<ComandaDALModel> GetComandas()
        {
            return new List<ComandaDALModel>();
        }

        public void UpdateComanda(ComandaDALModel comanda)
        {
            
        }

        public void DeleteComanda(int id)
        {
            
        }
    }
}
