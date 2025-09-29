using Lojinha.Shared.Models.Enums;

namespace Lojinha.API.Requests;

public record CategoriaRequest(string Nome, string Descricao, DateTime DataCadastro, Status Status);
