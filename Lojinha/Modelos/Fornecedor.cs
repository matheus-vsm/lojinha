using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lojinha.Modelos
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Cnpj { get; set; }
        public required string Email { get; set; }
        public required string Telefone { get; set; }
        public required string Celular { get; set; }
        public required string Cep { get; set; }
        public required string Endereco { get; set; }
        public bool Status { get; set; }

        public Fornecedor() { }

        public Fornecedor(string nome, string cnpj, string email, string telefone, string celular, string cep, string endereco, bool status)
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
            return $"Id: {Id}, Nome: {Nome}, CNPJ: {Cnpj}, Email: {Email}, Telefone: {Telefone}, Celular: {Celular}, CEP: {Cep}, Endereço: {Endereco}, Status: {(Status ? "Ativo" : "Inativo")}";
        }
    }
}
