namespace FP08_03;

class Program
{
    static void Main(string[] args)
    {
        int tam = 5;
        int[,] matriz = new int[tam, tam];
        /*for (int i = 0; i < tam; i++)
        {
            for (int j = 0; j < tam; j++)
            {
                Console.Write("Num: ");
                matriz[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }*/
        Identidade(matriz);
    }

    static void Identidade(int[,] matriz)
    {
        int marcador = 0;
        int tam = 5;
        for (int i = 0; i < tam; i++)
        {
            for (int j = 0; j < tam; j++)
            {
                if (i == marcador && j == marcador)
                {
                    matriz[i, j] = 1;
                }
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
            marcador++;
        }
    }
}
