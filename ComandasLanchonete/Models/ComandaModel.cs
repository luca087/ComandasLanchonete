using ComandasLanchonete.DAL.Models;
using ComandasLanchonete.Models.BaseModels;
using Microsoft.IdentityModel.Tokens;

namespace ComandasLanchonete.Models
{
    public class ComandaModel : ComandaBaseModel
    {
        public List<ProdutoModel> Produtos { get; set; } = new List<ProdutoModel>();

        public ComandaModel(){}
        public ComandaModel(ComandaBaseModel comandaBaseModel):base(comandaBaseModel){}

        public void Validate()
        {
            var validationErrorMsg = "";

            if (NomeCliente.IsNullOrEmpty())
            {
                validationErrorMsg += "\nNome do cliente vazio!";
            }
            if (TelefoneCliente.IsNullOrEmpty())
            {
                validationErrorMsg += "\nTelefone do cliente vazio!";
            }
            foreach (var produto in Produtos)
            {
                if (produto.Nome.IsNullOrEmpty())
                {
                    validationErrorMsg += "\nProduto com nome vazio!";
                }
            }
            if(validationErrorMsg != string.Empty)
            {
                throw new Exception(validationErrorMsg);
            }

        }
    }
}
