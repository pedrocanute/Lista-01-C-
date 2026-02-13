public class Exercicio6
{
    public static void Executar()
    {
        //Leia base e altura e calcule a área. 
        //Fórmula: área = base * altura 
        Console.WriteLine("Digite um numero base de um triangulo:");
        double baseTriangulo = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a altura de um triangulo:");
        double altura = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"A area do triangulo eh: {CalcularArea(baseTriangulo, altura):F2}.");
    }

    public static double CalcularArea(double baseTriangulo, double altura)
    {
        return (baseTriangulo * altura) / 2;  
    }
}