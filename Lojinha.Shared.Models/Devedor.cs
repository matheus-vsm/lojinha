using Lojinha.Shared.Models.Enums;

namespace Lojinha.Shared.Models
{
    public class Devedor
    {
        public int Id { get; set; }
        //adicionar id cliente
        // adicionar id venda
        
        public double DividaInicial { get; set; }
        public double DividaAtual { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public DateTime? DataFim { get; set; }
        public StatusDevedor Status { get; set; }
    }
}
