using Lojinha.Shared.Models.Enums;

namespace Lojinha.Shared.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty; // não nullable → obrigatório
        public string Cpf { get; set; } = string.Empty;
        public string Rg { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public DateTime? DataNascimento { get; set; } // nullable → opcional
        public string Endereco { get; set; } = string.Empty;
        public string Cep { get; set; } = string.Empty;
        public Status Status { get; set; } = Status.Ativo;
        public ICollection<Venda> Vendas { get; set; } = [];
        public int DevedorId { get; set; }
        public Devedor? Devedor { get; set; }

        public Cliente() { }

        public Cliente(string nome, string cpf, string rg, string email, string telefone, DateTime? dataNascimento, string endereco, string cep)
        {
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            Email = email;
            Telefone = telefone;
            DataNascimento = dataNascimento;
            Endereco = endereco;
            Cep = cep;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Nome: {Nome}, Cpf: {Cpf}, Rg: {Rg}, Email: {Email}, Telefone: {Telefone}, DataNascimento: {DataNascimento}, Endereco: {Endereco}, Cep: {Cep}, Status: {Status}";
        }
    }
}
