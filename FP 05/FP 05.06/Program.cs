namespace FP_05._06;

class Program
{
    static void Main(string[] args)
    {
        int num;
        double equacao = 0;
        Console.Write("Número: ");
        num = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            equacao = 1.0 / i + equacao;
        }
        Console.WriteLine(equacao);
    }
}
