namespace FP_05._06;

class Program
{
    static void Main(string[] args)
    {
        double n;
        double e;
        Console.Write("Insira o valor de N: ");
        n = Convert.ToDouble(Console.ReadLine());
        
        e = 1;

        for (double i = 2; i <= n; i++) //Começa no 2 visto que se n é 1 já está incluso
        {
            e = e + 1 / i;
            //Console.WriteLine("O resultado final é {0}", e);

        }
        
        Console.WriteLine("O resultado final é {0}", e);
    }
}
