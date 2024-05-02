
using System.ComponentModel.DataAnnotations;

namespace Rafael.models;

public class Funcionario
{
    public Funcionario()
    {
        Id = Guid.NewGuid().ToString();
    }

    public Funcionario(string nome, int cpf){
        Id = Guid.NewGuid().ToString();
        Nome = nome;
        Cpf = cpf;
    }


    public string Id{ get ; set; }

    [Required(ErrorMessage ="Este campo é obrigatório!")]
    public string? Nome{ get ; set; }

    [Range(11, 11, ErrorMessage = "Este campo deve conter 11 caracteres!")]
    public int? Cpf{ get ; set; }


}