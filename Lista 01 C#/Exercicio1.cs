public class Exercicio1
{
    public static void Executar()
    {
        //Peça para o usuário digitar o nome e depois exiba uma mensagem de boas-vindas.
        Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine();
        Escrever(nome);
       
    }
    public static void Escrever(string nome)
    {
        Console.WriteLine($"Bem-vindo, {nome}!");
    }
}
