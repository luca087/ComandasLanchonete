using ComandasLanchonete.DAL.Models;
using ComandasLanchonete.Models.BaseModels;

namespace ComandasLanchonete.Models
{
    public class ComandaModel : ComandaBaseModel
    {
        public List<ProdutoModel> Produtos { get; set; }

        public ComandaModel(){}
        public ComandaModel(ComandaBaseModel comandaBaseModel):base(comandaBaseModel){}
    }
}
