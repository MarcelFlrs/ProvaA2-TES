
namespace Rafael.models;

public class Folha
{
    double salarioBruto;
    double impostoFgts;
    double impostoInss;
    double impostoIrrf;
    double salarioLiquido;


    public Folha()
    {
        folhaId = Guid.NewGuid().ToString();
    }

    public Folha(double valor, int quantidade, int mes, int ano)
    {
        folhaId = Guid.NewGuid().ToString();
        Valor = valor;
        Quantidade = quantidade;
        Mes = mes;
        Ano = ano;
    }


    public Folha(double salarioBruto, double impostoIrrf, double impostoInss, double impostoFgts, double salarioLiquido)
    {
        folhaId = Guid.NewGuid().ToString();
        SalarioBruto = salarioBruto;
        ImpostoIrrf = impostoIrrf;
        ImpostoInss = impostoInss;
        ImpostoFgts = impostoFgts;
        SalarioLiquido = salarioLiquido;
    }


    public double CalcularSalarioBruto()
    {

        salarioBruto = Quantidade * Valor;
        return salarioBruto;
    }

    public double CalcularIrff()
    {
        if (salarioBruto >= 1903.98)
        {
            impostoIrrf = salarioBruto;
        }
        else if (salarioBruto >= 1903.99 && salarioBruto <= 2826.65)
        {
            impostoIrrf = salarioBruto * (7.5 / 100);

        }
        else if (salarioBruto >= 2826.66 && salarioBruto <= 3751.05)
        {
            impostoIrrf = salarioBruto * (15 / 100);

        }
        else if (salarioBruto >= 3751.06 && salarioBruto <= 4664.68)
        {
            impostoIrrf = salarioBruto * (22.5 / 100);

        }
        else if (salarioBruto > 4664.68)
        {
            impostoIrrf = salarioBruto * (27.5 / 100);

        }
        return impostoIrrf;
    }

    public double CalcularInss()
    {
        if (salarioBruto >= 1693.72)
        {
            impostoInss = salarioBruto * (8 / 100);

        }
        else if (salarioBruto >= 1693.73 && salarioBruto <= 2822.90)
        {
            impostoInss = salarioBruto * (9 / 100);

        }
        else if (salarioBruto >= 2822.91 && salarioBruto <= 5645.80)
        {
            impostoInss = salarioBruto * (11 / 100);

        }
        else if (salarioBruto >= 5645.81)
        {
            impostoInss = salarioBruto - 621.03;
        }

        return impostoInss;
    }

    public double CalcularFgts()
    {
        impostoFgts = salarioBruto * (8 / 100);
        return impostoFgts;
    }

    public double CalcularSalarioLiquido()
    {
        salarioLiquido = salarioBruto - impostoIrrf - impostoInss;
        return salarioLiquido;
    }

    public string folhaId { get; set; }
    public double SalarioBruto { get; set; }
    public double ImpostoIrrf { get; set; }
    public double ImpostoInss { get; set; }
    public double ImpostoFgts { get; set; }
    public double SalarioLiquido { get; set; }
    public double Valor { get; set; }
    public int Quantidade { get; set; }
    public int Mes { get; set; }
    public int Ano { get; set; }





}