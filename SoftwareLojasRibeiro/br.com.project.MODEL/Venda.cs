using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareLojasRibeiro.br.com.project.MODEL
{
    public class Venda
    {
        public string Id { get; set; }
        public string Id_Cliente { get; set; }
        public DateTime Data_Venda { get; set; }
        public double Total_Venda { get; set; }
        public double Desconto { get; set; }
        public string Forma_Pagamento { get; set; }
        public double Valor_Pago { get; set; }
        public string Status { get; set; }
        public string Observacoes { get; set; }
    }
}
