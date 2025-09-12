using Lojinha.Shared.Models.Enums;

namespace Lojinha.Shared.Models
{
    public class Pagamento
    {
        public int Id { get; set; }
        public int VendaId { get; set; }
        public Venda? Venda { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
        public decimal ValorPago { get; set; }
    }
}
