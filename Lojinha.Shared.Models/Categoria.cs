using Lojinha.Shared.Models.Enums;

namespace Lojinha.Shared.Models;

public class Categoria
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public TipoCategoria TipoCategoria { get; set; }
    public DateTime DataCadastro { get; private set; }
    public Status Status { get; set; }
    public ICollection<Produto> Produtos { get; set; } = [];

    public Categoria() { }

    public Categoria(string nome, string descricao, TipoCategoria tipoCategoria, DateTime dataCadastro, Status status)
    {
        Nome = nome;
        Descricao = descricao;
        TipoCategoria = tipoCategoria;
        DataCadastro = dataCadastro;
        Status = status;
    }

    public override string ToString()
    {
        return $"Id: {Id}, Nome: {Nome}, Descrição: {Descricao}, Tipo de Categoria: {TipoCategoria}, Data de Cadastro: {DataCadastro.ToShortDateString()}, Status: {Status}";
    }
}
