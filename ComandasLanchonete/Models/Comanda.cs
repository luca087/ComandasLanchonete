using ComandasLanchonete.DAL.Models;
using ComandasLanchonete.Models.BaseModels;

namespace ComandasLanchonete.Models
{
    public class Comanda : ComandaBaseModel
    {
        public List<Produto> Produtos { get; set; }

        public Comanda(){}
        public Comanda(ComandaBaseModel comandaBaseModel):base(comandaBaseModel){}
    }
}
