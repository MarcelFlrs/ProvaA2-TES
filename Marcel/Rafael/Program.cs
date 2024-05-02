using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Rafael.models;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDataContext>();
var app = builder.Build();

app.MapGet("/", () => "Api de funcionários");



app.MapPost("api/funcionario/cadastrar", ([FromBody] Funcionario funcionario, [FromServices] AppDataContext ctx) =>
{
    Funcionario? funcionarios = ctx.Funcionarios.FirstOrDefault
        (X => X.Nome == funcionario.Nome);
    if (funcionarios is null)
    {
        ctx.Funcionarios.Add(funcionario);
        ctx.SaveChanges();
        return Results.Created("", funcionario);
    }
    return Results.BadRequest("Já existe um funcionário com este nome");
});

app.MapGet("api/funcionario/listar", ([FromServices] AppDataContext ctx) =>
{
    if (ctx.Funcionarios.Any())
    {
        return Results.Ok(ctx.Funcionarios.ToList());
    }
    return Results.NotFound("Não existem funcionários");
});

app.MapPost("api/folha/cadastrar", ([FromBody] Folha folha, [FromServices] AppDataContext ctx) =>
{
    Folha? folhas = ctx.Folhas.FirstOrDefault
        (X => X.folhaId == folha.folhaId);
    if (folhas is null)
    {
        ctx.Folhas.Add(folha);
        ctx.SaveChanges();
        return Results.Created("", folha);
    }
    return Results.BadRequest("Já existe uma folha com este Id");
});

app.MapGet("api/folha/listar", ([FromServices] AppDataContext ctx) =>
{
    if (ctx.Folhas.Any())
    {
        return Results.Ok(ctx.Folhas.ToList());
    }
    return Results.NotFound("Não existem folhas");
});





app.Run();
