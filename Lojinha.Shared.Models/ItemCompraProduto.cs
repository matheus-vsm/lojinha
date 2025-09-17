namespace Lojinha.Shared.Models
{
    public class ItemCompraProduto
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoCusto { get; set; }
        public decimal Subtotal => Quantidade * PrecoCusto;
        // Produto já existe → só usa o ProdutoId. Produto novo → cadastra ele antes/durante a compra.
        public int ProdutoId { get; set; }
        public Produto? Produto { get; set; }
        public int CompraProdutoId { get; set; }
        public CompraProduto? CompraProduto { get; set; }
        public int FornecedorId { get; set; }
        public Fornecedor? Fornecedor { get; set; }

        public ItemCompraProduto() { }
        public ItemCompraProduto(int quantidade, decimal precoCusto, int produtoId, int fornecedorId)
        {
            Quantidade = quantidade;
            PrecoCusto = precoCusto;
            ProdutoId = produtoId;
            FornecedorId = fornecedorId;
        }
    }
}
