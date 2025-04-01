using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareLojasRibeiro.br.com.project.MODEL
{
    public class CompraProdutos
    {
        public string Id { get; set; }
        public string Id_Fornecedor { get; set; }
        public DateTime Data_Compra { get; set; }
        public double Total_Compra { get; set; }
        public string Observacoes { get; set; }
    }
}
