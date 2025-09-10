using Lojinha.Shared.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
