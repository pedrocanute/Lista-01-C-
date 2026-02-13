public class Exercicio3
{
    public static void Executar()
    {
        //Leia 3 notas (double) e calcule a média. 
        //Depois exiba a média formatada com 2 casas decimais. 
        Console.WriteLine("Digite a 1a nota:");
        double nota1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a 2a nota:");
        double nota2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a 3a nota:");
        double nota3 = Convert.ToDouble(Console.ReadLine());

        double media = CalcularMedia(nota1, nota2, nota3);

        Console.WriteLine($"Sua media eh: {media:F2}.");
    }

    public static double CalcularMedia(double nota1, double nota2, double nota3)
    {
        return (nota1 + nota2 + nota3) / 3;
    }
}