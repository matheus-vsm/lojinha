using Lojinha.Shared.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lojinha.Shared.Models
{
    public class Cliente
    {
        public int Id { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public string Cpf { get; set; } = string.Empty;
        public string Rg { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public DateTime? DataNascimento { get; set; }
        public string Endereco { get; set; } = string.Empty;
        public string Cep { get; set; } = string.Empty;
        public Status Status { get; set; }

        public Cliente() { }

        public Cliente(string nome, string cpf, string rg, string email, string telefone, DateTime? dataNascimento, string endereco, string cep, Status status)
        {
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            Email = email;
            Telefone = telefone;
            DataNascimento = dataNascimento;
            Endereco = endereco;
            Cep = cep;
            Status = status;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Nome: {Nome}, Cpf: {Cpf}, Rg: {Rg}, Email: {Email}, Telefone: {Telefone}, DataNascimento: {DataNascimento}, Endereco: {Endereco}, Cep: {Cep}, Status: {Status}";
        }
    }
}
