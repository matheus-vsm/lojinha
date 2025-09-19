using Lojinha.Banco;
using Lojinha.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lojinha.API.Endpoints;

public static class ClienteExtensions
{
    public static void AddEndPointsCliente(this WebApplication app)
    {
        app.MapGet("/Clientes", ([FromServices] DAL<Cliente> dal) =>
        {
            return Results.Ok(dal.Listar());
        });

        app.MapGet("/Cliente/{nome}", ([FromServices] DAL<Cliente> dal, string nome) =>
        {
            var cliente = dal.BuscarPor(c => c.Nome.ToUpper().Equals(nome.ToUpper()));
            if (cliente == null)
            {
                return Results.NotFound("Cliente não encontrado!");
            }
            return Results.Ok(cliente);
        });

        app.MapPost("/Cliente", ([FromServices] DAL<Cliente> dal, [FromBody] Cliente cliente) =>
        {
            dal.Adicionar(cliente);
            return Results.Created($"/Cliente/{cliente.Id}", cliente); // Retorna o código 201 (Created) e a URL do novo recurso criado no Location do header da resposta
        });

        app.MapDelete("/Cliente/{id}", ([FromServices] DAL<Cliente> dal, int id) =>
        {
            var cliente = dal.BuscarPorId(id);
            if (cliente == null)
            {
                return Results.NotFound("Cliente não encontrado!");
            }
            dal.Deletar(cliente);
            return Results.Ok("Cliente deletado com sucesso!");
        });

        app.MapPut("/Cliente/{id}", ([FromServices] DAL<Cliente> dal, int id, [FromBody] Cliente cliente) =>
        {
            var c = dal.BuscarPorId(id);
            if (c == null)
            {
                return Results.NotFound("Cliente não encontrado!");
            }
            //cliente.Id = c.Id; // Garante que o Id do cliente a ser atualizado é o mesmo do cliente buscado no banco
            c.Nome = cliente.Nome;
            dal.Atualizar(cliente);
            return Results.Ok("Cliente atualizado com sucesso!");
        });
    }
}
