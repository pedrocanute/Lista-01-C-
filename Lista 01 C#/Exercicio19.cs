public class Exercicio19
{
    public static void Executar()
    {
        //Leia:
        //● nome
        //● sobrenome
        //● empresa
        //Gere um e-mail no formato:
        //nome.sobrenome @empresa.com
        //Tudo em minúsculo e sem espaços.
        //📌 Exemplo: Entrada: João / Silva / Senac Saída: joao.silva @senac.com

        Console.WriteLine("Digite seu primeiro nome:");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite seu sobrenome:");
        string sobrenome = Console.ReadLine();
        Console.WriteLine("Digite o nome da empresa:");
        string empresa = Console.ReadLine();

        Console.WriteLine(nome.ToLower().Trim() + "." + sobrenome.ToLower().Trim() + "@" + empresa.ToLower().Trim() + ".com");
    }
}