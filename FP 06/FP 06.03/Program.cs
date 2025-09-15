using System.Collections.Specialized;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;

namespace FP_06._03;

class Program
{
    static void Main(string[] args)
    {
        int tamanho = 10;
        int[] vetor1 = new int[tamanho];
        int[] vetor2 = new int[tamanho];
        LeValores(vetor1, tamanho);
        LeValores(vetor2, tamanho);
        ImprimeSoma(vetor1, vetor2, tamanho);
    }

    static void LeValores(int[] vet1, int tamanho)
    {
        for (int i = 0; i < tamanho; i++)
        {
            Console.Write("Número inteiro: ");
            vet1[i] = Convert.ToInt32(Console.ReadLine()); //Le os 10 do primeiro vetor, e depois os 10 do segundo.
        }
    }
    static void ImprimeSoma(int[] vet1, int[] vet2, int tamanho)
    {
        int soma = 0, somaTotal = 0;
        for (int i = 0; i < tamanho; i++)
        {
            soma = vet1[i] + vet2[i];
            somaTotal += soma;
            Console.WriteLine("{0} + {1} = {2}", vet1[i], vet2[i], soma);
        }
        Console.WriteLine("Soma total dos elementos = {0}", somaTotal);
    }
}

