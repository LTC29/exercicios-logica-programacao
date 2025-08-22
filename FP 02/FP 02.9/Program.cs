namespace FP_02._9;

class Program
{
    static void Main(string[] args)
    {
        double valorProduto, valorDesconto;

        Console.Write("Insira o valor do produto em reais: ");
        valorProduto = Convert.ToDouble(Console.ReadLine());
        Console.Write("Insira o valor do desconto em reais: ");
        valorDesconto = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Valor do produto descontado: {0}", valorProduto - valorDesconto);
        Console.ReadKey();
    }
}
