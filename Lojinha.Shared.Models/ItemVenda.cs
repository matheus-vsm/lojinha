namespace Lojinha.Shared.Models;

public class ItemVenda
{
    public int Id { get; set; }
    public int Quantidade { get; set; }
    public decimal PrecoUnitario { get; set; }
    public decimal Subtotal { get; private set; }
    public int VendaId { get; set; }
    public Venda? Venda { get; set; }
    public int ProdutoId { get; set; }
    public Produto? Produto { get; set; }

    public ItemVenda() { }
    public ItemVenda(int quantidade, decimal precoUnitario, int produtoId)
    {
        Quantidade = quantidade;
        PrecoUnitario = precoUnitario;
        ProdutoId = produtoId;
    }
}
