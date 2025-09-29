using Lojinha.Shared.Models.Enums;

namespace Lojinha.Shared.Models;

public class Pagamento
{
    public int Id { get; set; }
    public FormaPagamento FormaPagamento { get; set; }
    public decimal ValorPago { get; set; }
    public ICollection<Venda> Vendas { get; set; } = [];

    public Pagamento() { }
    public Pagamento(FormaPagamento formaPagamento, decimal valorPago, ICollection<Venda> vendas)
    {
        FormaPagamento = formaPagamento;
        ValorPago = valorPago;
        Vendas = vendas;
    }
}
