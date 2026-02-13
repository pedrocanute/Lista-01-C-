using System.Numerics;
using System.Runtime.Intrinsics.X86;

public class Exercicio11
{
    public static void Executar()
    {
        //Leia:
        //nome do funcionário
        //salário bruto(double)
        //percentual de desconto(double)
        //Calcule o salário líquido e mostre uma frase completa.
        //Fórmula: salarioLiquido = salarioBruto - (salarioBruto * percentual / 100)

        Console.WriteLine("Digite o nome do funcionario:");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite o salario do funcionario:");
        double salario = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o percentual de desconto:");
        double desconto = Convert.ToDouble(Console.ReadLine());

        double salarioLiquido = CalcularSalario(salario, desconto);

        Console.WriteLine($"O funcionario {nome} recebe R${salario} de salario, possui um percentual de desconto de {desconto}%. Seu Salário Líquido é R${salarioLiquido}.");

    }

    public static double CalcularSalario(double salario, double desconto)
    {
        return salario - (salario * desconto / 100);
    }
}