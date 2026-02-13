public class Exercicio12
{
    public static void Executar()
    {
        //Leia um número inteiro representando segundos e converta para:
        //hora, minutos e segundos restantes
        //Exemplo: Entrada: 3665
        //Saida: 01:01:05 (use divisao inteira e %)

        Console.WriteLine("Digite um numero representando segundo");
        int numeroDigitado = Int32.Parse(Console.ReadLine());
        ConverterSegundo(numeroDigitado);

    }

    public static void ConverterSegundo(int segundo)
    {
        int hora = segundo / 3600;
        int minuto = (segundo % 3600) / 60;
        int segundoRestante = segundo % 60;
        Console.WriteLine($"{hora:D2}:{minuto:D2}:{segundoRestante:D2}");
    }
}