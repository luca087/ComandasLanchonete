namespace ComandasLanchonete.Models.BaseModels
{
    public class ProdutoBaseModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        public ProdutoBaseModel()
        {
                
        }

        public ProdutoBaseModel(ProdutoBaseModel produtoBaseModel)
        {
            Id = produtoBaseModel.Id;
            Nome = produtoBaseModel.Nome;
            Preco = produtoBaseModel.Preco;
        }
    }
}