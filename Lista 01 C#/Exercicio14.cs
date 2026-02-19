public class Exercicio14
{
    public static void Executar()
    {
        //Leia o nome completo de uma pessoa (ex: "João de Souza Silva") e exiba as iniciais.
        //Saída esperada: M.T.S
        //(Dica: Split e concatenação)

        Console.WriteLine("Digite seu nome completo:");
        string nomeDigitado = Console.ReadLine();
        SepararInput(nomeDigitado);
    }

    public static void SepararInput(string input)
    {
        string[] resultado = input.Split(" ");
        ImprimirIniciais(resultado);
    }

    public static void ImprimirIniciais(string[] resultado) 
    {
        foreach (string nome in resultado) 
        {
            char inicial = char.ToUpper(nome[0]);
            Console.Write(inicial + ".");
        }
    }
}