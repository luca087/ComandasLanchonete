namespace ComandasLanchonete.Models.BaseModels
{
    public class ComandaBaseModel
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public string NomeCliente { get; set; }
        public string TelefoneCliente { get; set; }
        public ComandaBaseModel(){}
        public ComandaBaseModel(ComandaBaseModel comandaBaseModel)
        {
            Id = comandaBaseModel.Id;
            IdCliente = comandaBaseModel.IdCliente;
            NomeCliente = comandaBaseModel.NomeCliente;
            TelefoneCliente = comandaBaseModel.TelefoneCliente;
        }
    }
}