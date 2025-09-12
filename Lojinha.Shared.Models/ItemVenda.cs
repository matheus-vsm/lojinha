namespace Lojinha.Shared.Models
{
    public class ItemVenda
    {
        public int Id { get; set; }
        //adicionar id venda
        //adicionar id produto
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
        public decimal Subtotal => Quantidade * PrecoUnitario;
    }
}
