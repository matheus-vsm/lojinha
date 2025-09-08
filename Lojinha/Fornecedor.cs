using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lojinha
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Cep { get; set; }
        public string Endereco { get; set; }
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
