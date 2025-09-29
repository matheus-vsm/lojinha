using Lojinha.API.Converters;
using Lojinha.API.Requests;
using Lojinha.API.Responses;
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
            var categoriaResponse = new CategoriaProdutoConverter().EntityListToResponseList(dal.Listar());
            return Results.Ok(categoriaResponse);
        }).WithTags("Categoria Produto").WithOpenApi();

        catProdutoGroup.MapGet("/{nome}", ([FromServices] DAL<CategoriaProduto> dal, string nome) =>
        {
            var categoria = dal.BuscarPor(c => c.Nome.ToUpper().Equals(nome.ToUpper()));
            if (categoria == null) return Results.NotFound("Categoria não encontrada!");

            var categoriaResponse = new CategoriaProdutoConverter().EntityToResponse(categoria);
            return Results.Ok(categoriaResponse);
        });

        catProdutoGroup.MapPost("", ([FromServices] DAL<CategoriaProduto> dal, [FromBody] CategoriaRequest categoriaRequest) =>
        {
            var categoria = new CategoriaProduto(categoriaRequest.Nome, categoriaRequest.Descricao, categoriaRequest.DataCadastro, categoriaRequest.Status);
            dal.Adicionar(categoria);

            var categoriaResponse = new CategoriaProdutoConverter().EntityToResponse(categoria);
            return Results.Created($"/CategoriaProduto/{categoria.Id}", categoriaResponse);
        });

        catProdutoGroup.MapDelete("/{id}", ([FromServices] DAL<CategoriaProduto> dal, int id) =>
        {
            var categoria = dal.BuscarPorId(id);
            if (categoria == null) return Results.NotFound("Categoria não encontrada!");
            dal.Deletar(categoria);

            return Results.Ok("Categoria deletada com sucesso!");
        });

        catProdutoGroup.MapPut("/{id}", ([FromServices] DAL<CategoriaProduto> dal, int id, [FromBody] CategoriaRequestEdit categoriaRequestEdit) =>
        {
            var categoria = dal.BuscarPorId(id);
            if (categoria == null) return Results.NotFound("Categoria não encontrada!");
            categoria.Nome = categoriaRequestEdit.Nome;
            categoria.Descricao = categoriaRequestEdit.Descricao;
            categoria.Status = categoriaRequestEdit.Status;
            dal.Atualizar(categoria);

            var categoriaResponse = new CategoriaProdutoConverter().EntityToResponse(categoria);
            return Results.Ok($"Categoria atualizada com sucesso! \n{categoriaResponse}");
        });
    }
}
