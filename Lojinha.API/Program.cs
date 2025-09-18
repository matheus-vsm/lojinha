using Lojinha.Banco;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<LojinhaContext>();

builder.Services.AddSwaggerGen();

var app = builder.Build();

if(app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Run();
