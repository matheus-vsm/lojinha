using Lojinha.API.Responses;
using Lojinha.Shared.Models;
using Lojinha.Shared.Models.Enums;

namespace Lojinha.API.Converters;

//Ela serve para transformar entidades do domínio/banco (Cliente) em objetos de resposta da API (ClienteResponse).
public class ClienteConverter
{
    //Cliente (entidade) → ClienteResponse (DTO para API)
    public ClienteResponse EntityToResponse(Cliente? cliente) =>
    new ClienteResponse(
        cliente != null ? cliente.Id : 0,
        cliente?.Nome ?? "",
        cliente?.Cpf ?? "",
        cliente?.Rg ?? "",
        cliente?.Email ?? "",
        cliente?.Telefone ?? "",
        cliente?.DataNascimento ?? DateTime.MinValue,
        cliente?.Endereco ?? "",
        cliente?.Cep ?? "",
        cliente?.Status ?? 0
    );


    //LISTA de Cliente → LISTA de ClienteResponse
    public ICollection<ClienteResponse> EntityListToResponseList(IEnumerable<Cliente> listaDeClientes) => listaDeClientes.Select(EntityToResponse).ToList();
}
