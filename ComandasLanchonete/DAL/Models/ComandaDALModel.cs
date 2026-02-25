using ComandasLanchonete.Models.BaseModels;

namespace ComandasLanchonete.DAL.Models
{
    public class ComandaDALModel : ComandaBaseModel
    {
        public ICollection<ProdutoDALModel> Produtos { get; set; }
        public ComandaDALModel() { }
        public ComandaDALModel(ComandaBaseModel comandaBaseModel) : base(comandaBaseModel) { }
    }
}