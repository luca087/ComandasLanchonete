using ComandasLanchonete.Models.BaseModels;

namespace ComandasLanchonete.Models
{
    public class ProdutoModel : ProdutoBaseModel
    {
        public ProdutoModel()
        {
                
        }
        public ProdutoModel(ProdutoBaseModel produtoBaseModel):base(produtoBaseModel)
        {
            
        }
    }
}
