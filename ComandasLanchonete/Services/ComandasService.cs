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
        public ComandaModel CreateComanda(ComandaModel comanda)
        {
            var model = new ComandaDALModel(comanda);
            model.Produtos = comanda.Produtos.Select(x => new ProdutoDALModel(x)
            {
                ComandaId = comanda.Id,
                Comanda = model
                }).ToList();
            _comandasDAL.CreateComanda(model);
            return comanda;
        }

        public IEnumerable<ComandaModel> GetComandas()
        {
            var produtos = _produtosDAL.GetProdutos();
            return _comandasDAL.GetComandas().Select(x=> new ComandaModel(x){Produtos = produtos.Where(x=>x.ComandaId == x.Id).Select(x=>new ProdutoModel(x)).ToList()}).ToList();
        }

        public void UpdateComanda(ComandaModel comanda)
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
