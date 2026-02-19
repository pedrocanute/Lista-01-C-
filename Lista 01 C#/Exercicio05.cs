public class Exercicio05
{
    public static void Executar()
    {
        //Leia dois números e mostre: 
        //soma, subtracao, multiplicacao, divisao

        Console.WriteLine("Digite um numero:");
        double numero1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite outro numero:");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Soma: {numero1} + {numero2} = {Somar(numero1, numero2):F1}.");
        Console.WriteLine($"Subtracao: {numero1} - {numero2} = {Subtrair(numero1, numero2):F1}.");
        Console.WriteLine($"Multiplicacao: {numero1} x {numero2} = {Multiplicar(numero1, numero2):F1}.");
        Console.WriteLine($"Divisao: {numero1} / {numero2} = {Dividir(numero1, numero2):F1}.");
    }

    public static double Somar(double numero1, double numero2)
    {
        return numero1 + numero2;
    }

    public static double Subtrair(double numero1, double numero2)
    {
        return numero1 - numero2;
    }

    public static double Multiplicar(double numero1, double numero2)
    {
        return numero1 * numero2;
    }

    public static double Dividir(double numero1, double numero2) 
    {
        if (numero2 == 0) 
        {
            Console.WriteLine("Nao eh possivel dividir por 0.");
            return 0;
        }
        return numero1 / numero2;
    }
}