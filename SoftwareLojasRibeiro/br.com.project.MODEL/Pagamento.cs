using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareLojasRibeiro.br.com.project.MODEL
{
    public class Pagamento
    {
        public string Id { get; set; }
        public string Id_Venda { get; set; }
        public string Forma_Pagamento { get; set; }
        public double Valor_Pago { get; set; }
    }
}
