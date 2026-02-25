using ComandasLanchonete.DAL.Models;

namespace ComandasLanchonete.DAL
{
    public class ProdutosDAL
    {
        private readonly AppDbContext _context;

        public ProdutosDAL(AppDbContext context)
        {
            _context = context;
        }

        public ProdutoDALModel CreateProduto(ProdutoDALModel produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
            return produto;
        } 

        public IEnumerable<ProdutoDALModel> GetProdutos()
        {
            return _context.Produtos.ToList();
        }

        public ProdutoDALModel GetProdutoById(int id)
        {
            return _context.Produtos.Find(id);
        }

        public void UpdateProduto(ProdutoDALModel produto)
        {
            _context.Produtos.Update(produto);
            _context.SaveChanges();
        }

        public void DeleteProduto(int id)
        {
            var produto = GetProdutoById(id);

            if (produto != null)
            {
                _context.Produtos.Remove(produto);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Produto não existente!");
            }
        }
    }
}
