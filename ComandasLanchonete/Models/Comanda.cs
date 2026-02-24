namespace ComandasLanchonete.Models
{
    public class Comanda
    {
        public int IdCliente { get; set; }
        public string NomeCliente { get; set; }
        public string TelefoneCliente { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}
