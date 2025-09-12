using Lojinha.Shared.Models.Enums;

namespace Lojinha.Shared.Models
{
    public class Venda
    {
        public int Id { get; set; }
        //adicionar id cliente

        public DateTime DataVenda { get; set; }
        public decimal TotalVenda { get; set; }
        public decimal? Desconto { get; set; }
        public decimal ValorPago { get; set; }
        public StatusVenda Status { get; set; }
        public string? Observacoes { get; set; }
        public ICollection<Pagamento> Pagamentos { get; set; }
        public Devedor? Devedor { get; set; }

        public Venda() { }

        public Venda(DateTime dataVenda, decimal totalVenda, decimal desconto, decimal valorPago, StatusVenda status, string? observacoes)
        {
            DataVenda = dataVenda;
            TotalVenda = totalVenda;
            Desconto = desconto;
            ValorPago = valorPago;
            Status = status;
            Observacoes = observacoes;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Data da Venda: {DataVenda.ToShortDateString()}, Total da Venda: {TotalVenda:C}, Desconto: {Desconto:C}, Valor Pago: {ValorPago:C}, Status: {Status}, Observações: {Observacoes}";
        }
    }
}
