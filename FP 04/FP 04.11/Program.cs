namespace FP_04._11;

class Program
{
    static void Main(string[] args)
    {
        double primeiroNum, segundoNum;

        Console.WriteLine("Insira dois números reais: ");
        primeiroNum = Convert.ToDouble(Console.ReadLine());
        segundoNum = Convert.ToDouble(Console.ReadLine());
        if (primeiroNum > 0 && segundoNum > 0)
        {
            Console.WriteLine("Valores são válidos.");
        }
        else
        {
            Console.WriteLine("Valores são inválidos.");
        }
        Console.ReadKey();
    }
}
