using Lojinha.API.Converters;
using Lojinha.API.Requests;
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
            var categoriaResponse = new CategoriaPublicoConverter().EntityListToResponseList(dal.Listar());
            return Results.Ok(categoriaResponse);
        }).WithTags("Categoria Publico").WithOpenApi();

        catPublicoGroup.MapGet("/{nome}", ([FromServices] DAL<CategoriaPublico> dal, string nome) =>
        {
            var categoria = dal.BuscarPor(c => c.Nome.ToUpper().Equals(nome.ToUpper()));
            if (categoria == null) return Results.NotFound("Categoria não encontrada!");

            var categoriaResponse = new CategoriaPublicoConverter().EntityToResponse(categoria);
            return Results.Ok(categoriaResponse);
        });

        catPublicoGroup.MapPost("", ([FromServices] DAL<CategoriaPublico> dal, [FromBody] CategoriaRequest categoriaRequest) =>
        {
            var categoria = new CategoriaPublico(categoriaRequest.Nome, categoriaRequest.Descricao, categoriaRequest.DataCadastro, categoriaRequest.Status);
            dal.Adicionar(categoria);

            var categoriaResponse = new CategoriaPublicoConverter().EntityToResponse(categoria);
            return Results.Created($"/CategoriaProduto/{categoria.Id}", categoriaResponse);
        });

        catPublicoGroup.MapDelete("/{id}", ([FromServices] DAL<CategoriaPublico> dal, int id) =>
        {
            var categoria = dal.BuscarPorId(id);
            if (categoria == null) return Results.NotFound("Categoria não encontrada!");
            dal.Deletar(categoria);

            return Results.Ok("Categoria deletada com sucesso!");
        });

        catPublicoGroup.MapPut("/{id}", ([FromServices] DAL<CategoriaPublico> dal, int id, [FromBody] CategoriaRequestEdit categoriaRequestEdit) =>
        {
            var categoria = dal.BuscarPorId(id);
            if (categoria == null) return Results.NotFound("Categoria não encontrada!");
            categoria.Nome = categoriaRequestEdit.Nome;
            categoria.Descricao = categoriaRequestEdit.Descricao;
            categoria.Status = categoriaRequestEdit.Status;
            dal.Atualizar(categoria);

            var categoriaResponse = new CategoriaPublicoConverter().EntityToResponse(categoria);
            return Results.Ok($"Categoria atualizada com sucesso! \n{categoriaResponse}");
        });
    }
}
