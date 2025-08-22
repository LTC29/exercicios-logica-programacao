namespace FP_02._5;

class Program
{
    static void Main(string[] args)
    {
        double preçoProduto;

        Console.Write("Insira o preço do produto a ser descontado: ");
        preçoProduto = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("O preço final do produto descontado em 25% é de {0}.", preçoProduto * 0.75);
    }
}
