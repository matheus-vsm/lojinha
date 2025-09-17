using Lojinha.Shared.Models.Enums;

namespace Lojinha.Shared.Models
{
    public class Devedor
    {
        public int Id { get; set; }        
        public decimal DividaInicial { get; set; }
        public decimal DividaAtual { get; set; }
        public DateTime DataInicio { get; private set; }
        public DateTime DataAtualizacao { get; set; }
        public DateTime? DataFim { get; set; }
        public StatusDevedor Status { get; set; }
        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }
        public ICollection<Venda> Vendas { get; set; } = [];

        public Devedor() { }
        public Devedor(decimal dividaInicial, decimal dividaAtual, DateTime dataInicio, DateTime dataAtualizacao, DateTime? dataFim, StatusDevedor status, int clienteId, ICollection<Venda> vendas)
        {
            DividaInicial = dividaInicial;
            DividaAtual = dividaAtual;
            DataInicio = dataInicio;
            DataAtualizacao = dataAtualizacao;
            DataFim = dataFim;
            Status = status;
            ClienteId = clienteId;
            Vendas = vendas;
        }
    }
}
