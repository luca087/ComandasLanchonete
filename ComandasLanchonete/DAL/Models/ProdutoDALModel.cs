using ComandasLanchonete.Models.BaseModels;

namespace ComandasLanchonete.DAL.Models
{
    public class ProdutoDALModel : ProdutoBaseModel
    {
        public int ComandaId { get; set; }
        public ComandaDALModel Comanda { get; set; }
        
        public ProdutoDALModel()
        {
                
        }
        public ProdutoDALModel(ProdutoBaseModel produtoBaseModel):base(produtoBaseModel)
        {
            
        }
    }
}