namespace Lojinha.Shared.Models
{
    public class ItensCompraProdutos
    {
        public int Id { get; set; }
        //adicionar id compra
        //adicionar id fornecedor
        //public string Nome_Produto { get; set; }
        //public string Marca { get; set; }
        //public string Cor { get; set; }
        //public string Tamanho { get; set; }
        //public string Descricao { get; set; }
        //public int Quantidade { get; set; }
        //public int Id_Cat_Prod { get; set; }
        //public int Id_Cat_Publ { get; set; }

        //public Produto Produto { get; set; }
        //ver como que faz pra desconsiderar o estoque status e preço do produto
        public double PrecoCusto { get; set; }
        public double Subtotal { get; set; }
    }
}
