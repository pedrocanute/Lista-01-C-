public class Exercicio4
{
    public static void Executar()
    {
        //Leia uma temperatura em Celsius e converta para Fahrenheit usando: 
        //  F = (C * 9/5) + 32
        Console.WriteLine("Digite uma temperatura em Celsius: ");
        double tempDigitada = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"A temperatura em {tempDigitada} graus C (Celsius) vira {ConverterTemp(tempDigitada):F1} graus F (Fahrenheits).");
    }

    public static double ConverterTemp(double temperatura)
    {
        return (temperatura * 9/5) + 32;
    }
}