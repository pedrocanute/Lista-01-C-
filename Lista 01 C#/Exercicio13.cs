public class Exercicio13
{
    public static void Executar()
    {
        //Leia peso e altura, mostre o imc com duas casas decimais
        Console.WriteLine("Digite seu peso:");
        double peso = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite sua altura:");
        double altura = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Seu IMC é {CalcularImc(peso,altura):F2}");
    }

    public static double CalcularImc(double peso, double altura)
    {
        return peso / Math.Pow(altura, 2);
    }
}