public class Exercicio09
{
    public static void Executar()
    {
        //Leia uma frase e exiba quantos caracteres ela possui usando .Length
        Console.WriteLine("Digite uma frase");
        string frase = Console.ReadLine();
        Console.WriteLine($"Sua frase tem {ContarCaracter(frase)} caracteres.");
    }

    public static int ContarCaracter(string caracter)
    {
        return caracter.Length;
    }
}