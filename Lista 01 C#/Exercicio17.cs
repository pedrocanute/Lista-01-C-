public class Exercicio17
{
    public static void Executar()
    {
        //Leia um número double e mostre:
        //● parte inteira
        //● parte decimal
        //📌 Exemplo: Entrada: 12.75 Saída: Inteiro: 12, Decimal: 0.75
        //(Dica: casting e subtração)
        Console.WriteLine("Digite um numero decimal:");
        double numeroDigitado = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Entrada: {numeroDigitado} Inteiro: {(int)numeroDigitado} Decimal: {(numeroDigitado - (int)numeroDigitado):F2}");
    }
}