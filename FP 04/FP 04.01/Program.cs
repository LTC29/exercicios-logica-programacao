namespace FP_04._01;

class Program
{
    static void Main(string[] args)
    {
        int primeiroNum, segundoNum;

        Console.Write("Insira o primeiro número inteiro: ");
        primeiroNum = Convert.ToInt32(Console.ReadLine());
        Console.Write("Insira o segundo número inteiro: ");
        segundoNum = Convert.ToInt32(Console.ReadLine());
        if (primeiroNum == segundoNum)
        {
            Console.WriteLine("Os números são iguais.");
        }
        else if (primeiroNum > segundoNum)
        {
            Console.WriteLine("O primeiro número é maior que o segundo.");
        }
        else
        {
            Console.WriteLine("O segundo número é maior que o primeiro.");
        }
        Console.ReadKey();

    }
}
