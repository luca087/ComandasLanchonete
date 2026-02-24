using ComandasLanchonete.DAL;
using ComandasLanchonete.DAL.Models;
using ComandasLanchonete.Models;
using System.Linq;

namespace ComandasLanchonete.Services
{
    public class ComandasService
    {
        private readonly ComandasDAL _comandasDAL;
        private readonly ProdutosDAL _produtosDAL;

        public ComandasService(ComandasDAL comandasDAL, ProdutosDAL produtosDAL)
        {
            _comandasDAL = comandasDAL;
            _produtosDAL = produtosDAL;
        }
        public Comanda CreateComanda(Comanda comanda)
        {
            _comandasDAL.CreateComanda(new ComandaDALModel(comanda));
            foreach (var produto in comanda.Produtos)
            {
                _produtosDAL.CreateProduto(new ProdutoDALModel(produto)
                {
                    ComandaId = comanda.Id
                });
            }
            return comanda;
        }

        public IEnumerable<Comanda> GetComandas()
        {
            return _comandasDAL.GetComandas().Select(x=> new Comanda(x)).ToList();
        }

        public void UpdateComanda(Comanda comanda)
        {
            _comandasDAL.UpdateComanda(new ComandaDALModel(comanda));
            //update produtos

        }

        public void DeleteComanda(int id)
        {
            _comandasDAL.DeleteComanda(id);
        }
    }
}
