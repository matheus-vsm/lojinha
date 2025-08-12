using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lojinha.Modelos
{
    public class Funcionario
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Cpf { get; set; }
        public required string Rg { get; set; }
        public required string Email { get; set; }
        public required string Telefone { get; set; }
        public DateTime? DataNascimento { get; set; }
        public required string Endereco { get; set; }
        public required string Cep { get; set; }
        public bool Status { get; set; }

        public Funcionario() { }

        public Funcionario(string nome, string cpf, string rg, string email, string telefone, DateTime? dataNascimento, string endereco, string cep, bool status)
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
            return $"Id: {Id}, Nome: {Nome}, CPF: {Cpf}, RG: {Rg}, Email: {Email}, Telefone: {Telefone}, Data de Nascimento: {DataNascimento?.ToShortDateString()}, Endereço: {Endereco}, CEP: {Cep}, Status: {(Status ? "Ativo" : "Inativo")}";
        }
    }
}
