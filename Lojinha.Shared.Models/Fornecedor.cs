using Lojinha.Shared.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lojinha.Shared.Models
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Cnpj { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public string Celular { get; set; } = string.Empty;
        public string Cep { get; set; } = string.Empty;
        public string Endereco { get; set; } = string.Empty;
        public Status Status { get; set; }

        public Fornecedor() { }

        public Fornecedor(string nome, string cnpj, string email, string telefone, string celular, string cep, string endereco, Status status)
        {
            Nome = nome;
            Cnpj = cnpj;
            Email = email;
            Telefone = telefone;
            Celular = celular;
            Cep = cep;
            Endereco = endereco;
            Status = status;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Nome: {Nome}, CNPJ: {Cnpj}, Email: {Email}, Telefone: {Telefone}, Celular: {Celular}, CEP: {Cep}, Endereço: {Endereco}, Status: {Status}";
        }
    }
}
