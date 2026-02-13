public class Exercicio8
{
    public static void Executar()
    {
        //Leia nome e sobrenome separadamente e depois exiba o nome completo em uma frase.
        //"Seu nome completo é: João Silva"
        Console.WriteLine("Digite seu primeiro nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite seu sobrenome: ");
        string sobrenome = Console.ReadLine();
        Concatenar(nome, sobrenome);
    }

    public static void Concatenar(string nome, string sobrenome)
    {
        Console.WriteLine("Seu nome completo é: " + nome + " " + sobrenome);
    }
}