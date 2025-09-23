using Lojinha.Banco;
using Lojinha.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lojinha.API.Endpoints;

public static class FuncionarioExtensions
{
    public static void AddEndPointsFuncionario(this WebApplication app)
    {
        var funcionarioGroup = app.MapGroup("/Funcionario")
                          .WithTags("Funcionario")
                          .WithOpenApi();

        app.MapGet("/Funcionarios", ([FromServices] DAL<Funcionario> dal) =>
        {
            return Results.Ok(dal.Listar());
        }).WithTags("Funcionario").WithOpenApi();

        funcionarioGroup.MapGet("/{id}", ([FromServices] DAL<Funcionario> dal, int id) =>
        {
            var funcionario = dal.BuscarPorId(id);
            if (funcionario == null)
            {
                return Results.NotFound("Funcionário não encontrado!");
            }
            return Results.Ok(funcionario);
        });

        funcionarioGroup.MapPost("", ([FromServices] DAL<Funcionario> dal, [FromBody] Funcionario funcionario) =>
        {
            dal.Adicionar(funcionario);
            return Results.Created($"/Funcionario/{funcionario.Id}", funcionario);
        });

        funcionarioGroup.MapDelete("/{id}", ([FromServices] DAL<Funcionario> dal, int id) =>
        {
            var funcionario = dal.BuscarPorId(id);
            if (funcionario == null)
            {
                return Results.NotFound("Funcionário não encontrado!");
            }
            dal.Deletar(funcionario);
            return Results.Ok("Funcionário deletado com sucesso!");
        });

        funcionarioGroup.MapPut("/{id}", ([FromServices] DAL<Funcionario> dal, int id, [FromBody] Funcionario funcionario) =>
        {
            var f = dal.BuscarPorId(id);
            if (f == null)
            {
                return Results.NotFound("Funcionário não encontrado!");
            }
            f.Nome = funcionario.Nome;
            f.Cpf = funcionario.Cpf;
            f.Rg = funcionario.Rg;
            f.Email = funcionario.Email;
            f.Telefone = funcionario.Telefone;
            f.DataNascimento = funcionario.DataNascimento;
            f.Endereco = funcionario.Endereco;
            f.Cep = funcionario.Cep;
            f.Status = funcionario.Status;
            dal.Atualizar(f);
            return Results.Ok("Funcionário atualizado com sucesso!");
        });
    }
}
