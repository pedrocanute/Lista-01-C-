using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class ExercicioTeste
{
    public static void Executar()
    {
        double[,] notas = new double[5, 5];
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine($"Digite a nota {j + 1} do aluno {i + 1}:");
                notas[i, j] = Double.Parse(Console.ReadLine());
            }
        }

        CalcularMedia(notas);
    }

    public static void CalcularMedia(double[,] media) 
    {
        double mediaCalculada = 0;
        int totalNotas = 0;
        for (int i = 0;i < media.GetLength(0);i++)
        {
            for (int j = 0;j < media.GetLength(1);j++)
            {
                mediaCalculada += media[i, j];
                totalNotas++;

            }
            Console.WriteLine($"Média: {mediaCalculada / totalNotas}");
        }
        
    }

}