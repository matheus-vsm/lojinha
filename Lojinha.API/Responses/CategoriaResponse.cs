using Lojinha.Shared.Models.Enums;

namespace Lojinha.API.Responses;

public record CategoriaResponse(int Id, string Nome, string Descricao, Status Status);
