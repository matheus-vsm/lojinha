using Lojinha.Banco;
using Lojinha.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lojinha.API.Endpoints;

public static class CategoriaPublicoExtensions
{
    public static void AddEndPointsCategoriaPublico(this WebApplication app)
    {
        var catPublicoGroup = app.MapGroup("/CategoriaPublico")
                          .WithTags("Categoria Publico")
                          .WithOpenApi();

        app.MapGet("/CategoriasPublicos", ([FromServices] DAL<CategoriaPublico> dal) =>
        {
            return Results.Ok(dal.Listar());
        }).WithTags("Categoria Publico").WithOpenApi();

        catPublicoGroup.MapGet("/{nome}", ([FromServices] DAL<CategoriaPublico> dal, string nome) =>
        {
            var categoria = dal.BuscarPor(c => c.Nome.ToUpper().Equals(nome.ToUpper()));
            if (categoria == null)
            {
                return Results.NotFound("Categoria não encontrada!");
            }
            return Results.Ok(categoria);
        });

        catPublicoGroup.MapPost("", ([FromServices] DAL<CategoriaPublico> dal, [FromBody] CategoriaPublico categoria) =>
        {
            dal.Adicionar(categoria);
            return Results.Created($"/CategoriaPublico/{categoria.Id}", categoria);
        });

        catPublicoGroup.MapDelete("/{id}", ([FromServices] DAL<CategoriaPublico> dal, int id) =>
        {
            var categoria = dal.BuscarPorId(id);
            if (categoria == null)
            {
                return Results.NotFound("Categoria não encontrada!");
            }
            dal.Deletar(categoria);
            return Results.Ok("Categoria deletada com sucesso!");
        });

        catPublicoGroup.MapPut("/{id}", ([FromServices] DAL<CategoriaPublico> dal, int id, [FromBody] CategoriaPublico categoria) =>
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
