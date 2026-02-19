public class Exercicio07
{
    public static void Executar()
    {
        //Leia um número inteiro e mostre se ele é par ou ímpar usando o operador %.
        Console.WriteLine("Digite um numero inteiro:");
        int numeroDigitado = Int32.Parse(Console.ReadLine());
        ParImpar(numeroDigitado);

    }
    
    public static void ParImpar(int numero)
    {
        if (numero % 2 == 0)
        {
            Console.WriteLine(numero + " eh par.");
        }
        else
        {
            Console.WriteLine(numero + " eh impar.");
        }

    }
}
