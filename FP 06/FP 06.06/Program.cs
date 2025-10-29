namespace FP_06._06;

class Program
{
    static void Main(string[] args)
    {
        int n = 5;
        int[] vetorInserido = new int[n];
        int aux;

        for (int i = 0; i < vetorInserido.Length; i++)
        {
            Console.Write("Insira o {0}º valor do vetor: ", i + 1);
            vetorInserido[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < vetorInserido.Length; i++)
        {
            for (int j = vetorInserido.Length - 1; j > i; j--)
            {
                if (vetorInserido[i] > vetorInserido[j])
                {
                    aux = vetorInserido[i];
                    vetorInserido[i] = vetorInserido[j];
                    vetorInserido[j] = aux;
                }
            }
        }

        for (int i = 0; i < vetorInserido.Length; i++)
        {
            Console.Write("{0} ", vetorInserido[i]);
        }
    }
}
