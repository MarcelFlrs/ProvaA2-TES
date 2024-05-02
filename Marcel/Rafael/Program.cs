using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Rafael.models;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDataContext>();
var app = builder.Build();

app.MapGet("/", () => "Api de funcionários");

List<Funcionario> funcionarios = new List<Funcionario>();


app.MapPost("/funcionario/cadastrar", ([FromBody] Funcionario funcionario)=>{
    funcionarios.Add(funcionario);
    return Results.Created("", funcionario);

});







app.Run();
