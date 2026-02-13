public class Exercicio10
{
    public static void Executar()
    {
        //Leia uma frase e exiba:
        //ela em maiúsculo (ToUpper())
        //ela em minúsculo (ToLower())
        //a frase com espaços removidos no início e no fim (Trim())

        Console.WriteLine("Digite uma frase qualquer: ");
        string frase = Console.ReadLine();

        DeixarMaiusculo(frase);
        DeixarMinusculo(frase);
        RemoverEspaco(frase);

    }

    public static void DeixarMaiusculo(string frase)
    {
        Console.WriteLine(frase.ToUpper());
    }

    public static void DeixarMinusculo(string frase)
    {
        Console.WriteLine(frase.ToLower());
    }

    public static void RemoverEspaco(string frase)
    {
        Console.WriteLine(frase.Trim());
    }
}