namespace FP08_04;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Tamanho das linhas/colunas da matriz quadrada: ");
        int tam = Convert.ToInt32(Console.ReadLine());
        double[,] matriz = new double[tam, tam];
        for (int i = 0; i < tam; i++)
        {
            for (int j = 0; j < tam; j++)
            {
                matriz[i, j] = Convert.ToDouble(Console.ReadLine());
            }
        }
        double soma = SomaElementosDaMatriz(matriz, tam);
        Console.WriteLine("Soma dos elementos da matriz é {0}", soma);
    }

    static double SomaElementosDaMatriz(double[,] matriz, int tam)
    {
        double soma = 0;
        for (int i = 0; i < tam; i++)
        {
            for (int j = 0; j < tam; j++)
            {
                soma += matriz[i, j];
            }
        }
        return soma;
    }
}
