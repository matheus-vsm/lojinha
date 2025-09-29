namespace Lojinha.Shared.Models;

public class CompraProduto
{
    public int Id { get; set; }
    public DateTime Data { get; set; }
    public decimal Total { get; set; }
    public string? Observacoes { get; set; }
    public ICollection<ItemCompraProduto> Itens { get; set; } = []; //= new List<>();

    public CompraProduto() { }
    public CompraProduto(DateTime dataCompra, decimal totalCompra, string? observacoes, ICollection<ItemCompraProduto> itens)
    {
        Data = dataCompra;
        Total = totalCompra;
        Observacoes = observacoes;
        Itens = itens;
    }

    public override string ToString()
    {
        return $"Id: {Id}, Data da Compra: {Data.ToShortDateString()}, Total da Compra: {Total:C}, Observações: {Observacoes}";
    }
}
