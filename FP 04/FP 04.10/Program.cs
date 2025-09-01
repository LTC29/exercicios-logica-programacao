namespace FP_04._10;

class Program
{
    static void Main(string[] args)
    {
        int primeiroNum, segundoNum;

        Console.Write("Primeiro número: ");
        primeiroNum = Convert.ToInt32(Console.ReadLine());
        Console.Write("Segundo número: ");
        segundoNum = Convert.ToInt32(Console.ReadLine());
        if (segundoNum != 0)
        {
            Console.WriteLine("A Divisão do primeiro número pelo segundo é igual a {0} com resto {1}.", primeiroNum / segundoNum, primeiroNum % segundoNum);
        }
        else
        {
            Console.WriteLine("Impossível dividir por 0.");
        }
        Console.ReadKey();
    }
}
