using Lojinha.Shared.Models.Enums;

namespace Lojinha.API.Requests;

public record CategoriaRequestEdit(string Nome, string Descricao, Status Status);
