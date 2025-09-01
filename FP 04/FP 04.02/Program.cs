namespace FP_04._02;

class Program
{
    static void Main(string[] args)
    {
        int numero;

        Console.Write("Insira um número inteiro: ");
        numero = Convert.ToInt32(Console.ReadLine());
        if (numero % 2 == 0)
        {
            Console.WriteLine("O número é divisivel por 2.");
        }
        else
        {
            Console.WriteLine("O número não é divisível por 2.");
        }
        Console.ReadKey();
    }
}
