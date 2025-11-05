namespace FP08_01;

class Program
{
    static void Main(string[] args)
    {
        double[,] matriz1 = new double[3, 3];
        double[,] matriz2 = new double[3, 3];
        LeMatriz(matriz1);
        LeMatriz(matriz2);
        SomaMatriz(matriz1, matriz2);
    }

    static void LeMatriz(double[,] matriz)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("Insira o {0}º número da {1}º linha: ", j + 1, i + 1);
                matriz[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
    static void SomaMatriz(double[,] matriz1, double[,] matriz2)
    {
        double soma = 0;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                soma += matriz1[i, j];
            }
        }
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                soma += matriz2[i, j];
            }
        }
        Console.WriteLine("A soma das duas matrizes é: {0}", soma);
    }
}
