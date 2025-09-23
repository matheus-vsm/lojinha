using Lojinha.Banco;
using Lojinha.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lojinha.API.Endpoints;

public static class CategoriaProdutoExtensions
{
    public static void AddEndPointsCategoriaProduto(this WebApplication app)
    {
        var catProdutoGroup = app.MapGroup("/CategoriaProduto")
                          .WithTags("Categoria Produto")
                          .WithOpenApi();

        app.MapGet("/CategoriasProdutos", ([FromServices] DAL<CategoriaProduto> dal) =>
        {
            return Results.Ok(dal.Listar());
        }).WithTags("Categoria Produto").WithOpenApi();

        catProdutoGroup.MapGet("/{nome}", ([FromServices] DAL<CategoriaProduto> dal, string nome) =>
        {
            var categoria = dal.BuscarPor(c => c.Nome.ToUpper().Equals(nome.ToUpper()));
            if (categoria == null)
            {
                return Results.NotFound("Categoria não encontrada!");
            }
            return Results.Ok(categoria);
        });

        catProdutoGroup.MapPost("", ([FromServices] DAL<CategoriaProduto> dal, [FromBody] CategoriaProduto categoria) =>
        {
            dal.Adicionar(categoria);
            return Results.Created($"/CategoriaProduto/{categoria.Id}", categoria);
        });

        catProdutoGroup.MapDelete("/{id}", ([FromServices] DAL<CategoriaProduto> dal, int id) =>
        {
            var categoria = dal.BuscarPorId(id);
            if (categoria == null)
            {
                return Results.NotFound("Categoria não encontrada!");
            }
            dal.Deletar(categoria);
            return Results.Ok("Categoria deletada com sucesso!");
        });

        catProdutoGroup.MapPut("/{id}", ([FromServices] DAL<CategoriaProduto> dal, int id, [FromBody] CategoriaProduto categoria) =>
        {
            var cp = dal.BuscarPorId(id);
            if (cp == null)
            {
                return Results.NotFound("Categoria não encontrada!");
            }
            cp.Nome = categoria.Nome;
            cp.Descricao = categoria.Descricao;
            cp.Status = categoria.Status;
            dal.Atualizar(cp);
            return Results.Ok("Categoria atualizada com sucesso!");
        });
    }
}
