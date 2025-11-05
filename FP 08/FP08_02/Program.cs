using System.Security.Cryptography.X509Certificates;

namespace FP08_02;

class Program
{
    static void Main(string[] args)
    {
        int tam = 3;
        int[,] matriz = new int[tam, tam];

        for (int i = 0; i < tam; i++)
        {
            for (int j = 0; j < tam; j++)
            {
                Console.Write("Insira o {0}º num da {1}ª linha: ", j + 1, i + 1);
                matriz[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        InverteMatriz(matriz);
    }

    static void InverteMatriz(int[,] matriz1)
    {
        int tam = 3;
        int[,] matriz2 = new int[tam, tam];
        for (int i = 0; i < tam; i++)
        {
            for (int j = 0; j < tam; j++)
            {
                matriz2[i, j] = matriz1[j, i];
                Console.Write(matriz2[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
