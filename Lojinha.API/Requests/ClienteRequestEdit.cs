using Lojinha.Shared.Models.Enums;

namespace Lojinha.API.Requests;

public record ClienteRequestEdit(string Nome, string Email, string Telefone, DateTime? DataNascimento, string Endereco, string Cep, Status Status);
