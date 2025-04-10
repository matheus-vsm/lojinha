using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareLojasRibeiro.br.com.project.MODEL
{
    public class Devedores
    {
        public string Id { get; set; }
        public string Id_Cliente { get; set; }
        public string Id_Venda { get; set; }
        public double Divida { get; set; }
        //public double Divida_Inicial { get; set; }
        //public double Divida_Atual { get; set; }
        public DateTime Data_Inicio { get; set; }
        public DateTime Data_Atualizacao { get; set; }
        public DateTime? Data_Fim { get; set; }
    }
}
