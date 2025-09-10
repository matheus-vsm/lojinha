using Lojinha.Shared.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lojinha.Shared.Models
{
    public class Venda
    {
        public int Id { get; set; }
        //adicionar id cliente

        public DateTime DataVenda { get; set; }
        public double TotalVenda { get; set; }
        public double? Desconto { get; set; }
        public double ValorPago { get; set; }
        public StatusVenda Status { get; set; }
        public string? Observacoes { get; set; }

        public Venda() { }

        public Venda(DateTime dataVenda, double totalVenda, double desconto, double valorPago, StatusVenda status, string? observacoes)
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
