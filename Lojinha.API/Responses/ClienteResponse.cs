using Lojinha.Shared.Models.Enums;

namespace Lojinha.API.Responses;

public record ClienteResponse(int Id, string Nome, string Cpf, string Rg, string Email, string Telefone, DateTime? DataNascimento, string Endereco, string Cep, Status Status);
