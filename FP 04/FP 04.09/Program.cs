namespace FP_04._09;

class Program
{
    static void Main(string[] args)
    {
        int formaPagamento;
        Console.Write("Forma de pagamento: \n - À vista. \n - Cheque para trinta dias. \n - Em duas vezes. \n - Em quatro vezes. \n - A partir de cinco vezes. \nEntre com sua opção: ");
        formaPagamento = Convert.ToInt32(Console.ReadLine());
        if (formaPagamento == 1)
        {
            Console.WriteLine("Desconto de 20%.");
        }
        else if (formaPagamento == 2 || formaPagamento == 3 || formaPagamento == 4)
        {
            Console.WriteLine("Mesmo preço a vista.");
        }
        else if (formaPagamento == 5)
        {
            Console.WriteLine("Juros de 3% ao mês.");
        }
        else if (formaPagamento == 6)
        {
            Console.WriteLine("Juros de 5% ao mês.");
        }
        else if (formaPagamento < 1 || formaPagamento > 6)
        {
            Console.WriteLine("Opção inválida.");
        }
    }
}
