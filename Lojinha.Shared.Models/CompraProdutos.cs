namespace Lojinha.Shared.Models
{
    public class CompraProdutos
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Total { get; set; }
        public string? Observacoes { get; set; }
        //adicionar lista de itens compraprodutos

        public CompraProdutos(DateTime dataCompra, double totalCompra, string? observacoes)
        {
            Data = dataCompra;
            Total = totalCompra;
            Observacoes = observacoes;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Data da Compra: {Data.ToShortDateString()}, Total da Compra: {Total:C}, Observações: {Observacoes}";
        }
    }
}
