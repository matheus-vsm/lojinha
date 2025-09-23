using Lojinha.API.Endpoints;
using Lojinha.Banco;
using Lojinha.Shared.Models;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Evita loopings na serialização JSON
builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options =>
    options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder.Services.AddDbContext<LojinhaContext>();
builder.Services.AddScoped<DAL<Cliente>>(); // Injeção de dependência do DAL<Cliente>
builder.Services.AddScoped<DAL<CategoriaProduto>>();
builder.Services.AddScoped<DAL<CategoriaPublico>>();

// Necessário para o Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.AddEndPointsCliente();
app.AddEndPointsCategoriaProduto();
app.AddEndPointsCategoriaPublico();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Run();
