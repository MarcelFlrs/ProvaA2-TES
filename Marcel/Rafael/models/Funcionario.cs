
using System.ComponentModel.DataAnnotations;

namespace Rafael.models;

public class Funcionario
{
    public Funcionario()
    {
        funcionarioId = Guid.NewGuid().ToString();
    }

    public Funcionario(string nome, string cpf){
        funcionarioId = Guid.NewGuid().ToString();
        Nome = nome;
        Cpf = cpf;
    }


    public string funcionarioId{ get ; set; }

    [Required(ErrorMessage ="Este campo é obrigatório!")]
    public string? Nome{ get ; set; }

    [Range(11, 11, ErrorMessage = "Este campo deve conter 11 caracteres!")]
    public string? Cpf{ get ; set; }


}