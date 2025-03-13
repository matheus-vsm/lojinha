using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareLojasRibeiro.br.com.project.MODEL
{
    public class ItensVenda
    {
        public string Id { get; set; }
        public string Id_Venda { get; set; }
        public string Id_Produto { get; set; }
        public int Quantidade { get; set; }
        public double Preco_Unitario { get; set; }
        public double Subtotal { get; set; }
    }
}
