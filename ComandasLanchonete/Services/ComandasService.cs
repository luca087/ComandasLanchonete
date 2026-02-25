using ComandasLanchonete.DAL;
using ComandasLanchonete.DAL.Models;
using ComandasLanchonete.Models;

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
            var result = _comandasDAL.CreateComanda(model);
            comanda.Id = result.Id;
            return comanda;
        }

        public IEnumerable<ComandaModel> GetComandas()
        {
            return _comandasDAL.GetComandas().Select(comanda =>
            new ComandaModel(comanda)
            {
                Produtos = _produtosDAL.GetProdutos().Where(x => x.ComandaId == comanda.Id).Select(x =>
            new ProdutoModel(x)).ToList()
            }).ToList();
        }

        public ComandaModel GetComandaById(int id)
        {
            var comanda = _comandasDAL.GetComandaById(id);
            if (comanda != null)
            {
                var produtos = _produtosDAL.GetProdutos().Where(x => x.ComandaId == id).Select(x => new ProdutoModel(x)).ToList();
                return new ComandaModel(comanda) { Produtos = produtos };
            }
            throw new Exception("Comanda não encontrada");
        }

        public void UpdateComanda(ComandaModel comanda)
        {
            var model = new ComandaDALModel(comanda);
            model.Produtos = comanda.Produtos.Select(x => new ProdutoDALModel(x)
            {
                ComandaId = comanda.Id,
                Comanda = model
            }).ToList();
            _comandasDAL.UpdateComanda(model);
        }

        public void DeleteComanda(int id)
        {
            _comandasDAL.DeleteComanda(id);
        }
    }
}
