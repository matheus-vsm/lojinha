using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lojinha.Modelos
{
    public class Produto
    {
        public int Id { get; set; }
        public CategoriaProduto CategoriaProduto { get; set; }
        public CategoriaPublico CategoriaPublico { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public string Cor { get; set; }
        public string Tamanho { get; set; }
        public string? Descricao { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
        public bool Status { get; set; }

        public Produto() { }

        public Produto(CategoriaProduto categoriaProduto, CategoriaPublico categoriaPublico, string nome, string marca, string cor, string tamanho, string? descricao, decimal preco, int estoque, bool status)
        {
            CategoriaProduto = categoriaProduto;
            CategoriaPublico = categoriaPublico;
            Nome = nome;
            Marca = marca;
            Cor = cor;
            Tamanho = tamanho;
            Descricao = descricao;
            Preco = preco;
            Estoque = estoque;
            Status = status;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Categoria Produto: {CategoriaProduto?.Nome}, Categoria Público: {CategoriaPublico?.Nome}, Nome: {Nome}, Marca: {Marca}, Cor: {Cor}, Tamanho: {Tamanho}, Descrição: {Descricao}, Preço: {Preco:C}, Estoque: {Estoque}, Status: {(Status ? "Ativo" : "Inativo")}";
        }
    }
}
