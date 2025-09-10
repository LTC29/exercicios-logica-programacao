namespace FP_05._13;

class Program
{
    static void Main(string[] args)
    {
        int num, fatorial = 1;
        Console.Write("Número: ");
        num = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            fatorial *= i;
        }
        Console.WriteLine("O fatorial de {0} é {1}", num, fatorial);
    }
}
