using ComandasLanchonete.Models.BaseModels;

namespace ComandasLanchonete.Models
{
    public class Produto : ProdutoBaseModel
    {
        public Produto(ProdutoBaseModel produtoBaseModel):base(produtoBaseModel)
        {
            
        }
    }
}
