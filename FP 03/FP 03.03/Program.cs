namespace FP_03._03;

class Program
{
    static void Main(string[] args)
    {
        double valorProduto;
        double quantiaAcrescimo;
        double valorAcrescentado;

        Console.Write("Insira o valor do produto: ");
        valorProduto = Convert.ToDouble(Console.ReadLine());
        Console.Write("Insira o valor de acréscimo em %: ");
        quantiaAcrescimo = Convert.ToDouble(Console.ReadLine());
        quantiaAcrescimo = 1 + (quantiaAcrescimo / 100);
        valorAcrescentado = AcrescimoEmValor(valorProduto, quantiaAcrescimo);
        Console.WriteLine("Valor total acrescentado: {0}", valorAcrescentado);
        Console.ReadKey();
    }

    static double AcrescimoEmValor(double valorProduto, double quantiaAcrescimo)
    {
        double valorFinal = valorProduto * quantiaAcrescimo;
        return valorFinal;
    }
}
