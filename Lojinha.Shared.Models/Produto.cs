using Lojinha.Shared.Models.Enums;

namespace Lojinha.Shared.Models
{
    public class Produto
    {
        public int Id { get; set; }
        //adicionar categoria produto
        //adicionar categoria publico

        //public virtual CategoriaProduto CategoriaProduto { get; set; }
        //public virtual CategoriaPublico CategoriaPublico { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Marca { get; set; } = string.Empty;
        public string Cor { get; set; } = string.Empty;
        public string? Tamanho { get; set; }
        public string? Descricao { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
        public Status Status { get; set; }
        public ICollection<ItemCompraProduto> ItensCompra { get; set; }

        public Produto() { }
        public Produto(string nome, string marca, string cor, string tamanho, string? descricao, decimal preco, int estoque, Status status)
        {
            Nome = nome;
            Marca = marca;
            Cor = cor;
            Tamanho = tamanho;
            Descricao = descricao;
            Preco = preco;
            Estoque = estoque;
            Status = status;
        }
        public Produto(string nome, string marca, string cor, string tamanho, string? descricao)
        {
            Nome = nome;
            Marca = marca;
            Cor = cor;
            Tamanho = tamanho;
            Descricao = descricao;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Nome: {Nome}, Marca: {Marca}, Cor: {Cor}, Tamanho: {Tamanho}, Descrição: {Descricao}, Preço: {Preco:C}, Estoque: {Estoque}, Status: {Status}";
        }
    }
}
