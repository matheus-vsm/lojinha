using Lojinha.Shared.Models.Enums;

namespace Lojinha.Shared.Models;

public class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Marca { get; set; } = string.Empty;
    public string Cor { get; set; } = string.Empty;
    public string Tamanho { get; set; } = string.Empty;
    public string? Descricao { get; set; }
    public decimal Preco { get; set; }
    public int Estoque { get; set; }
    public Status Status { get; set; }
    //public int CategoriaId { get; set; }
    //public Categoria? Categoria { get; set; }
    public int CategoriaProdutoId { get; set; }
    public CategoriaProduto? CategoriaProduto { get; set; }
    public int CategoriaPublicoId { get; set; }
    public CategoriaPublico? CategoriaPublico { get; set; }
    public ICollection<ItemCompraProduto> ItensCompras { get; set; } = [];
    public ICollection<ItemVenda> ItensVendas { get; set; } = [];

    public Produto() { }
    public Produto(string nome, string marca, string cor, string tamanho, string? descricao, decimal preco, int estoque, Status status, int categoriaProdutoId, int categoriaPublicoId)
    {
        Nome = nome;
        Marca = marca;
        Cor = cor;
        Tamanho = tamanho;
        Descricao = descricao;
        Preco = preco;
        Estoque = estoque;
        Status = status;
        CategoriaProdutoId = categoriaProdutoId;
        CategoriaPublicoId = categoriaPublicoId;
    }
    public Produto(string nome, string marca, string cor, string tamanho, string? descricao, int categoriaProdutoId, int categoriaPublicoId)
    {
        Nome = nome;
        Marca = marca;
        Cor = cor;
        Tamanho = tamanho;
        Descricao = descricao;
        CategoriaProdutoId = categoriaProdutoId;
        CategoriaPublicoId = categoriaPublicoId;
    }

    public override string ToString()
    {
        return $"Id: {Id}, Nome: {Nome}, Marca: {Marca}, Cor: {Cor}, Tamanho: {Tamanho}, Descrição: {Descricao}, Preço: {Preco:C}, Estoque: {Estoque}, Status: {Status}";
    }
}
