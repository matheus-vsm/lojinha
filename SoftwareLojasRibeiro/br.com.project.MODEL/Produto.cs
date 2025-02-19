using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareLojasRibeiro.br.com.project.MODEL
{
    public class Produto
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public string Cor { get; set; }
        public string Tamanho { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
        public int Id_Cat_Prod { get; set; } //int pois o combobox está armazenando os IDs das categorias
        public int Id_Cat_Pub { get; set; }
        //public Categoria Categoria_Prod { get; set; }
        //public Categoria Categoria_Pub { get; set; }

    }
}
