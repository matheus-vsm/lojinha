using Lojinha.Shared.Models.Enums;

namespace Lojinha.Shared.Models;

public class CategoriaProduto
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public DateTime DataCadastro { get; private set; }
    public Status Status { get; set; }
    public ICollection<Produto> Produtos { get; set; } = [];

    public CategoriaProduto() { }

    public CategoriaProduto(string nome, string descricao, DateTime dataCadastro, Status status)
    {
        Nome = nome;
        Descricao = descricao;
        DataCadastro = dataCadastro;
        Status = status;
    }

    public override string ToString()
    {
        return $"Id: {Id}, Nome: {Nome}, Descrição: {Descricao}, Data de Cadastro: {DataCadastro.ToShortDateString()}, Status: {Status}";
    }
}
