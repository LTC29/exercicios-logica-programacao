namespace FP_03._04;

class Program
{
    static void Main(string[] args)
    {
        double primeiroNum, segundoNum;
        Console.Write("Insira o primeiro número: ");
        primeiroNum = Convert.ToDouble(Console.ReadLine());
        Console.Write("Insira o segundo número: ");
        segundoNum = Convert.ToDouble(Console.ReadLine());
        OperacoesBasicas(primeiroNum, segundoNum);
        Console.ReadKey();
    }

    static void OperacoesBasicas (double primeiroNum, double segundoNum){
        Console.WriteLine("A soma dos dois números é: {0}", primeiroNum+segundoNum);
        Console.WriteLine("O produto dos dois números é: {0}", primeiroNum*segundoNum);
        Console.WriteLine("A diferença dos dois números é: {0}", primeiroNum-segundoNum);
        Console.WriteLine("O quociente dos dois números é: {0}", primeiroNum/segundoNum);
        Console.WriteLine("O resto da divisão entre dos dois números é: {0}", primeiroNum%segundoNum);
    }
}
