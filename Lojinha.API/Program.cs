using Lojinha.API.Endpoints;
using Lojinha.Banco;
using Lojinha.Shared.Models;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Evita loopings na serializa��o JSON
builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options =>
    options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder.Services.AddDbContext<LojinhaContext>();
builder.Services.AddScoped<DAL<Cliente>>(); // Inje��o de depend�ncia do DAL<Cliente>

// Necess�rio para o Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.AddEndPointsCliente();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Run();
