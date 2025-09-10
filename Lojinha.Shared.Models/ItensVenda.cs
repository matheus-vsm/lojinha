using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lojinha.Shared.Models
{
    public class ItensVenda
    {
        public int Id { get; set; }
        //adicionar id venda
        //adicionar id produto
        public int Quantidade { get; set; }
        public double PrecoUnitario { get; set; }
        public double Subtotal { get; set; }
    }
}
