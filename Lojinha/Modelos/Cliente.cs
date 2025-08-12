using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lojinha.Modelos
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public string Cep { get; set; }
        public bool Status { get; set; }

        public Cliente() { }

        public Cliente(string nome, string cpf, string rg, string email, string telefone, DateTime dataNascimento, string endereco, string cep, bool status)
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
            return $"Id: {Id}, Nome: {Nome}, CPF: {Cpf}, RG: {Rg}, Email: {Email}, Telefone: {Telefone}, Data de Nascimento: {DataNascimento.ToShortDateString()}, Endereço: {Endereco}, CEP: {Cep}, Status: {(Status ? "Ativo" : "Inativo")}";
        }
    }
}
