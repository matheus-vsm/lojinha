using Lojinha.Shared.Models.Enums;
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
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public DateTime DataCadastro { get; set; }
        public Status Status { get; set; }

        public CategoriaPublico() { }

        public CategoriaPublico(string nome, string descricao, DateTime datacadastro, Status status)
        {
            Nome = nome;
            Descricao = descricao;
            DataCadastro = datacadastro;
            Status = status;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Nome: {Nome}, Descrição: {Descricao}, Data de Cadastro: {DataCadastro.ToShortDateString()}, Status: {Status}";
        }
    }
}
