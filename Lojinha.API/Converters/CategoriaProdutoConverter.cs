using Lojinha.API.Responses;
using Lojinha.Shared.Models;

namespace Lojinha.API.Converters;

public class CategoriaProdutoConverter
{
    public CategoriaResponse EntityToResponse(CategoriaProduto? categoria) =>
    new CategoriaResponse(
        categoria != null ? categoria.Id : 0,
        categoria?.Nome ?? "",
        categoria?.Descricao ?? "",
        categoria?.Status ?? 0
    );

    public ICollection<CategoriaResponse> EntityListToResponseList(IEnumerable<CategoriaProduto> listaDeCategorias) => listaDeCategorias.Select(EntityToResponse).ToList();
}
