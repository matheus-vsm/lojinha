using Lojinha.Shared.Models.Enums;

namespace Lojinha.Shared.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Cpf { get; set; } = string.Empty;
        public string Rg { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public DateTime? DataNascimento { get; set; }
        public string Endereco { get; set; } = string.Empty;
        public string Cep { get; set; } = string.Empty;
        public string Login { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty;
        public DateTime DataCadastro { get; set; }
        public Status Status { get; set; }

        public Funcionario() { }

        public Funcionario(string nome, string cpf, string rg, string email, string telefone, DateTime? dataNascimento, string endereco, string cep, string login, string senha, string tipo, DateTime dataCadastro, Status status)
        {
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            Email = email;
            Telefone = telefone;
            DataNascimento = dataNascimento;
            Endereco = endereco;
            Cep = cep;
            Login = login;
            Senha = senha;
            Tipo = tipo;
            DataCadastro = dataCadastro;
            Status = status;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Nome: {Nome}, Cpf: {Cpf}, Rg: {Rg}, Email: {Email}, Telefone: {Telefone}, DataNascimento: {DataNascimento}, Endereco: {Endereco}, Cep: {Cep}, Login: {Login}, Senha: {Senha}, Tipo: {Tipo}, DataCadastro: {DataCadastro}, Status: {Status}";
        }
    }
}
