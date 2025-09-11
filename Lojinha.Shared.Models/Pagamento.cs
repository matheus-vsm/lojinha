using Lojinha.Shared.Models.Enums;

namespace Lojinha.Shared.Models
{
    public class Pagamento
    {
        public int Id { get; set; }
        //adicionar id venda
        public FormaPagamento FormaPagamento { get; set; }
        public double ValorPago { get; set; }
    }
}
