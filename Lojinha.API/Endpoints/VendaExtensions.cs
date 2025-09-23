using Lojinha.Banco;
using Lojinha.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lojinha.API.Endpoints;

public static class VendaExtensions
{
    public static void AddEndPointsVenda(this WebApplication app)
    {
        var vendaGroup = app.MapGroup("/Venda")
                  .WithTags("Venda")
                  .WithOpenApi();

        app.MapGet("/Vendas", ([FromServices] DAL<Venda> dal) =>
        {
            return Results.Ok(dal.Listar());
        }).WithTags("Venda").WithOpenApi();

        vendaGroup.MapGet("/{id}", ([FromServices] DAL<Venda> dal, int id) =>
        {
            var venda = dal.BuscarPorId(id);
            if (venda == null)
            {
                return Results.NotFound("Venda não encontrada!");
            }
            return Results.Ok(venda);
        });

        vendaGroup.MapPost("", ([FromServices] DAL<Venda> dal, [FromBody] Venda venda) =>
        {
            dal.Adicionar(venda);
            return Results.Created($"/Venda/{venda.Id}", venda); // Retorna o código 201 (Created) e a URL do novo recurso criado no Location do header da resposta
        });

        vendaGroup.MapDelete("/{id}", ([FromServices] DAL<Venda> dal, int id) =>
        {
            var venda = dal.BuscarPorId(id);
            if (venda == null)
            {
                return Results.NotFound("Venda não encontrada!");
            }
            dal.Deletar(venda);
            return Results.Ok("Venda deletada com sucesso!");
        });

        vendaGroup.MapPut("/{id}", ([FromServices] DAL<Venda> dal, int id, [FromBody] Venda venda) =>
        {
            var v = dal.BuscarPorId(id);
            if (v == null)
            {
                return Results.NotFound("Venda não encontrada!");
            }
            v.TotalVenda = venda.TotalVenda;
            v.Desconto = venda.Desconto;
            v.ValorPago = venda.ValorPago;
            v.Status = venda.Status;
            v.Observacoes = venda.Observacoes;
            v.ClienteId = venda.ClienteId;
            v.DevedorId = venda.DevedorId;
            v.FuncionarioId = venda.FuncionarioId;
            v.Itens = venda.Itens;
            v.Pagamentos = venda.Pagamentos;
            dal.Atualizar(v);
            return Results.Ok(v);
        });
    }
}
