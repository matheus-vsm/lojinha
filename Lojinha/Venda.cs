using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lojinha
{
    public class Venda
    {
        public int Id { get; set; }
        public virtual Cliente Cliente { get; set; }
        public DateTime DataVenda { get; set; }
        public double TotalVenda { get; set; }
        public double? Desconto { get; set; }
        public double ValorPago { get; set; }
        public StatusVenda Status { get; set; }
        public string? Observacoes { get; set; }

        public Venda() { }

        public Venda(Cliente cliente, DateTime dataVenda, double totalVenda, double desconto, double valorPago, StatusVenda status, string? observacoes)
        {
            Cliente = cliente;
            DataVenda = dataVenda;
            TotalVenda = totalVenda;
            Desconto = desconto;
            ValorPago = valorPago;
            Status = status;
            Observacoes = observacoes;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Id do Cliente: {Cliente}, Data da Venda: {DataVenda.ToShortDateString()}, Total da Venda: {TotalVenda:C}, Desconto: {Desconto:C}, Valor Pago: {ValorPago:C}, Status: {Status}, Observações: {Observacoes}";
        }
    }

    public enum StatusVenda
    {
        Pendente,
        Pago,
        Cancelado
    }
}
