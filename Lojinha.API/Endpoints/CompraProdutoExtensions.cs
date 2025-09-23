using Lojinha.Banco;
using Lojinha.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lojinha.API.Endpoints
{
    public static class CompraProdutoExtensions
    {
        public static void AddEndPointsCompraProduto(this WebApplication app)
        {
            var compraProdutoGroup = app.MapGroup("/CompraProduto")
                              .WithTags("Compra Produto")
                              .WithOpenApi();

            app.MapGet("ComprasProdutos", ([FromServices] DAL<CompraProduto> dal) =>
            {
                return Results.Ok(dal.Listar());
            }).WithTags("Compra Produto").WithOpenApi();

            compraProdutoGroup.MapGet("/{id}", ([FromServices] DAL<CompraProduto> dal, int id) =>
            {
                var compra = dal.BuscarPorId(id);
                if (compra == null)
                {
                    return Results.NotFound("Compra não encontrada!");
                }
                return Results.Ok(compra);
            });

            compraProdutoGroup.MapPost("", ([FromServices] DAL<CompraProduto> dal, [FromBody] CompraProduto compra) =>
            {
                dal.Adicionar(compra);
                return Results.Created($"/CompraProduto/{compra.Id}", compra);
            });

            compraProdutoGroup.MapDelete("/{id}", ([FromServices] DAL<CompraProduto> dal, int id) =>
            {
                var compra = dal.BuscarPorId(id);
                if (compra == null)
                {
                    return Results.NotFound("Compra não encontrada!");
                }
                dal.Deletar(compra);
                return Results.Ok("Compra deletada com sucesso!");
            });

            compraProdutoGroup.MapPut("/{id}", ([FromServices] DAL<CompraProduto> dal, int id, [FromBody] CompraProduto compra) =>
            {
                var cp = dal.BuscarPorId(id);
                if (cp == null)
                {
                    return Results.NotFound("Compra não encontrada!");
                }
                cp.Observacoes = compra.Observacoes;
                dal.Atualizar(cp);
                return Results.Ok("Compra atualizada com sucesso!");
            });
        }
    }
}
