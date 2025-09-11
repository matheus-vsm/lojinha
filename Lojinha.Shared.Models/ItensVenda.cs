namespace Lojinha.Shared.Models
{
    public class ItensVenda
    {
        public int Id { get; set; }
        //adicionar id venda
        //adicionar id produto
        public int Quantidade { get; set; }
        public double PrecoUnitario { get; set; }
        public double Subtotal { get; set; }
    }
}
