namespace FP_03._02;

class Program
{
    static void Main(string[] args)
    {
        double valorProduto;
        double quantidadeDesconto;
        double preçoFinal;

        Console.Write("Insira o valor do produto: ");
        valorProduto = Convert.ToDouble(Console.ReadLine());
        Console.Write("Insira o valor do desconto em %: ");
        quantidadeDesconto = Convert.ToDouble(Console.ReadLine());
        quantidadeDesconto = 1 - (quantidadeDesconto / 100);
        preçoFinal = ValorEmOferta(valorProduto, quantidadeDesconto);
        Console.WriteLine("Valor final: {0}", preçoFinal);
        Console.ReadKey();
    }

    static double ValorEmOferta(double valorProduto, double quantidadeDesconto)
    {
        double valorFinal = valorProduto * quantidadeDesconto;
        return valorFinal;
    }
}
