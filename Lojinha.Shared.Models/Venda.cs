using Lojinha.Shared.Models.Enums;

namespace Lojinha.Shared.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal TotalVenda { get; set; }
        public decimal? Desconto { get; set; }
        public decimal ValorPago { get; set; }
        public StatusVenda Status { get; set; }
        public string? Observacoes { get; set; }
        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }
        public Devedor? Devedor { get; set; }
        public int? FuncionarioId { get; set; }
        public Funcionario? Funcionario { get; set; }
        public ICollection<ItemVenda> ItensVendas { get; set; } = [];
        public ICollection<Pagamento> Pagamentos { get; set; } = [];

        public Venda() { }

        public Venda(DateTime dataVenda, decimal totalVenda, decimal desconto, decimal valorPago, StatusVenda status, string? observacoes, int clienteId, int funcionarioId, ICollection<ItemVenda> itens, ICollection<Pagamento> pagamentos)
        {
            DataVenda = dataVenda;
            TotalVenda = totalVenda;
            Desconto = desconto;
            ValorPago = valorPago;
            Status = status;
            Observacoes = observacoes;
            ClienteId = clienteId;
            FuncionarioId = funcionarioId;
            ItensVendas = itens;
            Pagamentos = pagamentos;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Data da Venda: {DataVenda.ToShortDateString()}, Total da Venda: {TotalVenda:C}, Desconto: {Desconto:C}, Valor Pago: {ValorPago:C}, Status: {Status}, Observações: {Observacoes}";
        }
    }
}
