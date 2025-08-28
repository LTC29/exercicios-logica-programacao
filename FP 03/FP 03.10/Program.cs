namespace FP_03._10;

class Program
{
    static void Main(string[] args)
    {
        double primeiroNum, segundoNum, resultado;

        Console.Write("Insira o primeiro numero real: ");
        primeiroNum = Convert.ToDouble(Console.ReadLine());
        Console.Write("Insira o segundo numero real: ");
        segundoNum = Convert.ToDouble(Console.ReadLine());
        resultado = ResultadoFormula(primeiroNum, segundoNum);
        Console.WriteLine("O resultado da equação é {0}.", resultado);
        Console.ReadKey();

    }

    static double ResultadoFormula(double primNum, double segNum)
    {
        double resultado = Math.Sqrt(Math.Pow(primNum, 2) + Math.Pow(segNum, 2));
        return resultado;
    }
}
