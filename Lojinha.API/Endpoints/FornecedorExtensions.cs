using Lojinha.Banco;
using Lojinha.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lojinha.API.Endpoints
{
    public static class FornecedorExtensions
    {
        public static void AddEndPointsFornecedor(this WebApplication app)
        {
            var fornecedorGroup = app.MapGroup("/Fornecedor")
                              .WithTags("Fornecedor")
                              .WithOpenApi();

            app.MapGet("/Fornecedores", ([FromServices] DAL<Fornecedor> dal) =>
            {
                return Results.Ok(dal.Listar());
            }).WithTags("Fornecedor").WithOpenApi();

            fornecedorGroup.MapGet("/{id}", ([FromServices] DAL<Fornecedor> dal, int id) =>
            {
                var fornecedor = dal.BuscarPorId(id);
                if (fornecedor == null)
                {
                    return Results.NotFound("Fornecedor não encontrado!");
                }
                return Results.Ok(fornecedor);
            });

            fornecedorGroup.MapPost("", ([FromServices] DAL<Fornecedor> dal, [FromBody] Fornecedor fornecedor) =>
            {
                dal.Adicionar(fornecedor);
                return Results.Created($"/Fornecedor/{fornecedor.Id}", fornecedor); // Retorna o código 201 (Created) e a URL do novo recurso criado no Location do header da resposta
            });

            fornecedorGroup.MapDelete("/{id}", ([FromServices] DAL<Fornecedor> dal, int id) =>
            {
                var fornecedor = dal.BuscarPorId(id);
                if (fornecedor == null)
                {
                    return Results.NotFound("Fornecedor não encontrado!");
                }
                dal.Deletar(fornecedor);
                return Results.Ok("Fornecedor deletado com sucesso!");
            });

            fornecedorGroup.MapPut("/{id}", ([FromServices] DAL<Fornecedor> dal, int id, [FromBody] Fornecedor fornecedor) =>
            {
                var f = dal.BuscarPorId(id);
                if (f == null)
                {
                    return Results.NotFound("Fornecedor não encontrado!");
                }
                //fornecedor.Id = f.Id; // Garante que o Id do fornecedor a ser atualizado é o mesmo do fornecedor buscado no banco
                f.Nome = fornecedor.Nome;
                f.Cnpj = fornecedor.Cnpj;
                f.Email = fornecedor.Email;
                f.Telefone = fornecedor.Telefone;
                f.Celular = fornecedor.Celular;
                f.Cep = fornecedor.Cep;
                f.Endereco = fornecedor.Endereco;
                f.Status = fornecedor.Status;
                dal.Atualizar(f);
                return Results.Ok("Fornecedor atualizado com sucesso!");
            });
        }
    }
}
