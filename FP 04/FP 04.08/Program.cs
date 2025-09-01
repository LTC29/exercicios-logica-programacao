namespace FP_04._08;

class Program
{
    static void Main(string[] args)
    {
        int codigoProduto;

        Console.Write("Digite o código do produto: ");
        codigoProduto = Convert.ToInt32(Console.ReadLine());
        if (codigoProduto >= 1 && codigoProduto <= 20)
        {
            Console.WriteLine("O produto tem origem na Europa.");
        }
        else if (codigoProduto >= 21 && codigoProduto <= 40)
        {
            Console.WriteLine("O produto tem origem na Ásia.");

        }
        else if (codigoProduto >= 41 && codigoProduto <= 60)
        {
            Console.WriteLine("O produto tem origem na América.");
        }
        else if (codigoProduto >= 61 && codigoProduto <= 80)
        {
            Console.WriteLine("O produto tem origem na África.");
        }
        else if (codigoProduto > 80)
        {
            Console.WriteLine("O produto tem origem no Paraguai.");
        }
    }
}
