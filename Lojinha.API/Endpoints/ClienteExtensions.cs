using Azure.Core;
using Lojinha.API.Converters;
using Lojinha.API.Requests;
using Lojinha.Banco;
using Lojinha.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lojinha.API.Endpoints;

public static class ClienteExtensions
{
    public static void AddEndPointsCliente(this WebApplication app)
    {
        var clienteGroup = app.MapGroup("/Cliente")
                              .WithTags("Cliente")
                              .WithOpenApi();

        app.MapGet("/Clientes", ([FromServices] DAL<Cliente> dal) =>
        {
            var clienteResponse = new ClienteConverter().EntityListToResponseList(dal.Listar());
            return Results.Ok(clienteResponse);
        }).WithTags("Cliente").WithOpenApi();

        clienteGroup.MapGet("/{nome}", ([FromServices] DAL<Cliente> dal, string nome) =>
        {
            var cliente = dal.BuscarPor(c => c.Nome.ToUpper().Equals(nome.ToUpper()));
            if (cliente == null) return Results.NotFound("Cliente não encontrado!");

            var clienteResponse = new ClienteConverter().EntityToResponse(cliente);
            return Results.Ok(clienteResponse);
        });

        clienteGroup.MapPost("", ([FromServices] DAL<Cliente> dal, [FromBody] ClienteRequest clienteRequest) =>
        {
            var cliente = new Cliente(clienteRequest.Nome, clienteRequest.Cpf, clienteRequest.Rg, clienteRequest.Email, clienteRequest.Telefone, clienteRequest.DataNascimento, clienteRequest.Endereco, clienteRequest.Cep);
            dal.Adicionar(cliente);

            var clienteResponse = new ClienteConverter().EntityToResponse(cliente);
            return Results.Created($"/Cliente/{cliente.Id}", clienteResponse); // Retorna o código 201 (Created) e a URL do novo recurso criado no Location do header da resposta
        });

        clienteGroup.MapDelete("/{id}", ([FromServices] DAL<Cliente> dal, int id) =>
        {
            var cliente = dal.BuscarPorId(id);
            if (cliente == null)
            {
                return Results.NotFound("Cliente não encontrado!");
            }
            dal.Deletar(cliente);
            return Results.Ok("Cliente deletado com sucesso!");
        });

        clienteGroup.MapPut("/{id}", ([FromServices] DAL<Cliente> dal, int id, [FromBody] ClienteRequestEdit clienteRequestEdit) =>
        {
            var cliente = dal.BuscarPorId(id);
            if (cliente == null) return Results.NotFound("Cliente não encontrado!");

            cliente.Nome = clienteRequestEdit.Nome;
            cliente.Email = clienteRequestEdit.Email;
            cliente.Telefone = clienteRequestEdit.Telefone;
            cliente.DataNascimento = clienteRequestEdit.DataNascimento;
            cliente.Endereco = clienteRequestEdit.Endereco;
            cliente.Cep = clienteRequestEdit.Cep;
            
            dal.Atualizar(cliente);

            var clienteResponse = new ClienteConverter().EntityToResponse(cliente);
            return Results.Ok($"Cliente atualizado com sucesso! \n{clienteResponse}");
        });
    }
}
