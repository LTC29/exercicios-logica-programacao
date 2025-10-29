namespace FP_06._04;

class Program
{
    static void Main(string[] args)
    {
        int[] v = new int[10];
        int[] par = new int[10];
        int[] impar = new int[10];
        int iPar = 0, iImpar = 0;
        for (int i = 0; i < v.Length; i++)
        {
            Console.Write("Insira o {0}º valor: ", i+1);
            v[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("-----------------------------------");
        for (int i = 0; i < v.Length; i++)
        {
            if (v[i] % 2 == 0)
            {
                par[iPar] = v[i];
                iPar++;
            }
            else if (v[i] % 2 != 0)
            {
                impar[iImpar] = v[i];
                iImpar++;
            }
        }
        Console.WriteLine("-----------------------------------");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("{0}º valor do 1º vetor: {1}", i + 1, v[i]);
        }
        Console.WriteLine("-----------------------------------");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("{0}º valor do vetor PAR: {1}", i + 1, par[i]);
        }
        Console.WriteLine("-----------------------------------");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("{0}º valor do vetor ÍMPAR: {1}", i + 1, impar[i]);
        }
        Console.WriteLine("-----------------------------------");
    }
}
