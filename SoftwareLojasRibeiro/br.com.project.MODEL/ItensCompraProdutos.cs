using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareLojasRibeiro.br.com.project.MODEL
{
    public class ItensCompraProdutos
    {
        public string Id { get; set; }
        public string Id_Compra { get; set; }
        public string Nome_Produto { get; set; }
        public string Marca { get; set; }
        public string Cor { get; set; }
        public string Tamanho { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco_Custo { get; set; }
        public decimal Preco_Medio { get; set; }
        public decimal Subtotal { get; set; }
    }
}
