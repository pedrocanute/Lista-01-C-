public class Exercicio02
{
    public static void Executar()
    {
        //Leia dois números inteiros e exiba a soma entre eles.
        Console.WriteLine("Digite um numero:");
        int numero1 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Digite outro numero: ");
        int numero2 = Int32.Parse(Console.ReadLine());
        PrintarSoma(numero1, numero2);
    }

    public static void PrintarSoma(int n1, int n2)
    {
        Console.WriteLine($"A soma dos numeros eh: {n1 + n2}.");
    }
}
