using ComandasLanchonete.Models.BaseModels;

namespace ComandasLanchonete.DAL.Models
{
    public class ProdutoDALModel : ProdutoBaseModel
    {
        public int ComandaId { get; set; }
        public ProdutoDALModel(ProdutoBaseModel produtoBaseModel):base(produtoBaseModel)
        {
            
        }
    }
}