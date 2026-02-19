public class Exercicio20
{
    public static void Executar()
    {
        //Leia uma senha e exiba:
        //● quantos caracteres tem
        //● se contém pelo menos 1 número
        //● se contém pelo menos 1 letra maiúscula
        //📌 Dica: usar.Any() e char.IsDigit, char.IsUpper

        Console.WriteLine("Digite sua senha:");
        string senha = Console.ReadLine();
        bool possuiNumero = senha.Any(char.IsDigit);
        bool possuiMaiuscula = senha.Any(char.IsUpper);

        Console.WriteLine($"Sua senha tem {senha.Length} caracteres.");
        Console.WriteLine($"Possui pelo menos 1 numero? {(possuiNumero ? "Sim" : "Nao")}");
        Console.WriteLine($"Possui pelo menos 1 maiuscula? {(possuiMaiuscula ? "Sim" : "Nao")}");
    }
}