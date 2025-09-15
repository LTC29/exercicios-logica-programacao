using System.Runtime.Serialization.Formatters;

namespace FP_06._02;

class Program
{
    static void Main(string[] args)
    {
        int[] vetor1 = new int[10];
        int[] vetor2 = new int[10];
        int soma = 0;
        int somaTotal = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Número inteiro: ");
            vetor1[i] = Convert.ToInt32(Console.ReadLine());
            vetor2[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < 10; i++)
        {
            soma = vetor1[i] + vetor2[i];
            somaTotal += soma;
            Console.WriteLine("{0} + {1} = {2}, soma total = {3}", vetor1[i], vetor2[i], soma, somaTotal);
        }
    }
}
