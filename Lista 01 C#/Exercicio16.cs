public class Exercicio16
{
    public static void Executar()
    {
        //Leia:
        //● nome
        //● idade
        //● cidade
        //● profissão
        //Exiba uma frase em formato de ficha:
        //📌 Exemplo: Nome: João | Idade: 22 | Cidade: São Paulo | Profissão: Programador
        Console.WriteLine("====FICHA PROFISSIONAL====");
        Console.WriteLine("Digite seu nome completo:");
        string nomeDigitado = Console.ReadLine();
        Console.WriteLine("Digite sua idade:");
        int idade = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite sua cidade:");
        string cidade = Console.ReadLine();
        Console.WriteLine("Digite sua profissao:");
        string profissao = Console.ReadLine();

        Console.WriteLine($"Nome: {nomeDigitado} | Idade: {idade} anos | Cidade: {cidade} | Profissao: {profissao}");

    }
}