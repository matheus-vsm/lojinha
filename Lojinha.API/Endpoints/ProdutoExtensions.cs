using Lojinha.Banco;
using Lojinha.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lojinha.API.Endpoints;

public static class ProdutoExtensions
{
    public static void AddEndPointsProduto(this WebApplication app)
    {
        var produtoGroup = app.MapGroup("/Produto")
                      .WithTags("Produto")
                      .WithOpenApi();

        app.MapGet("/Produtos", ([FromServices] DAL<Produto> dal) =>
        {
            return Results.Ok(dal.Listar());
        }).WithTags("Produto").WithOpenApi();

        produtoGroup.MapGet("/{id}", ([FromServices] DAL<Produto> dal, int id) =>
        {
            var produto = dal.BuscarPorId(id);
            if (produto == null)
            {
                return Results.NotFound("Produto não encontrado!");
            }
            return Results.Ok(produto);
        });

        produtoGroup.MapPost("", ([FromServices] DAL<Produto> dal, [FromBody] Produto produto) =>
        {
            dal.Adicionar(produto);
            return Results.Created($"/Produto/{produto.Id}", produto); // Retorna o código 201 (Created) e a URL do novo recurso criado no Location do header da resposta
        });
        
        produtoGroup.MapDelete("/{id}", ([FromServices] DAL<Produto> dal, int id) =>
        {
            var produto = dal.BuscarPorId(id);
            if (produto == null)
            {
                return Results.NotFound("Produto não encontrado!");
            }
            dal.Deletar(produto);
            return Results.Ok("Produto deletado com sucesso!");
        });

        produtoGroup.MapPut("/{id}", ([FromServices] DAL<Produto> dal, int id, [FromBody] Produto produto) =>
        {
            var p = dal.BuscarPorId(id);
            if (p == null)
            {
                return Results.NotFound("Produto não encontrado!");
            }
            p.Nome = produto.Nome;
            p.Marca = produto.Marca;
            p.Cor = produto.Cor;
            p.Tamanho = produto.Tamanho;
            p.Descricao = produto.Descricao;
            p.Preco = produto.Preco;
            p.Estoque = produto.Estoque;
            p.Status = produto.Status;
            p.CategoriaId = produto.CategoriaId;
            dal.Atualizar(p);
            return Results.Ok("Produto atualizado com sucesso!");
        });
    }
}
