public class Exercicio18
{
    public static void Executar()
    {
        //Leia:
        //● capital inicial
        //● taxa de juros mensal(%)
        //● número de meses
        //Calcule o montante usando:
        //        montante = capital * Math.Pow(1 + taxa / 100, meses)
        //Exiba o resultado formatado em reais.
        Console.WriteLine("===CALCULADORA DE JUROS COMPOSTOS===");
        Console.WriteLine("Digite o valor do capital inicial:");
        double capitalInicial = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a taxa de juros mensal(%):");
        double taxa = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite numero de meses:");
        int meses = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Valor em reais: {((decimal)CalcularJuros(capitalInicial, taxa, meses)):C2}");
    }

    public static double CalcularJuros(double capital, double taxa,int meses)
    {
        return capital * Math.Pow(1 + taxa / 100, meses);
    }
}