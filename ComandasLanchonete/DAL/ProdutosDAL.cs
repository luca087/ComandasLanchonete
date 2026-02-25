using ComandasLanchonete.DAL.Models;

namespace ComandasLanchonete.DAL
{
    public class ProdutosDAL
    {
        public ProdutoDALModel CreateProduto(ProdutoDALModel produto)
        {
            return new ProdutoDALModel();
        } 

        public IEnumerable<ProdutoDALModel> GetProdutos()
        {
            return new List<ProdutoDALModel>();
        }

        public void UpdateProduto(ProdutoDALModel produto)
        {
            
        }

        public void DeleteProduto(int id)
        {
            
        }
    }
}
