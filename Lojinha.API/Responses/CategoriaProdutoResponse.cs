using Lojinha.Shared.Models.Enums;

namespace Lojinha.API.Responses;

public record CategoriaProdutoResponse(string Nome, string Descricao, Status Status);
