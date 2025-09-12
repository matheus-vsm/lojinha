namespace Lojinha.Shared.Models
{
    public class ItemCompraProduto
    {
        public int Id { get; set; }
        //adicionar id compra
        //adicionar id fornecedor

        // Produto já existe → só usa o ProdutoId. Produto novo → cadastra ele antes/durante a compra.
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoCusto { get; set; }
        public decimal Subtotal => Quantidade * PrecoCusto;
    }
}
