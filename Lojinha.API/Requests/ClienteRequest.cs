namespace Lojinha.API.Requests;

public record ClienteRequest(string Nome, string Cpf, string Rg, string Email, string Telefone, DateTime? DataNascimento, string Endereco, string Cep);
