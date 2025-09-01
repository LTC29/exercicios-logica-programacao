namespace FP_04._04;

class Program
{
    static void Main(string[] args)
    {
        int numero;

        Console.Write("Insira um número inteiro: ");
        numero = Convert.ToInt32(Console.ReadLine());
        if (numero % 2 == 0 && numero % 3 == 0 && numero % 5 != 0)
        {
            Console.WriteLine("O número é divisivel por 2 e por 3, mas não por 5.");
        }
        else if (numero % 2 == 0 && numero % 3 == 0)
        {
            Console.WriteLine("O número é divisível por 2 e por 3.");
        }
        else if (numero % 2 == 0 && numero % 3 != 0)
        {
            Console.WriteLine("O número é divisível por 2 mas não por 3.");
        }
        else
        {
            Console.WriteLine("O número não é divisível por 2.");
        }
        Console.ReadKey();
    }
}
