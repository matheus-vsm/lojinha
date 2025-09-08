using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lojinha.Shared.Models
{
    public class CategoriaPublico
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Status { get; set; }

        public CategoriaPublico() { }

        public CategoriaPublico(string nome, string descricao, DateTime datacadastro, bool status)
        {
            Nome = nome;
            Descricao = descricao;
            DataCadastro = datacadastro;
            Status = status;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Nome: {Nome}, Descrição: {Descricao}, Data de Cadastro: {DataCadastro.ToShortDateString()}, Status: {(Status ? "Ativo" : "Inativo")}";
        }
    }
}
