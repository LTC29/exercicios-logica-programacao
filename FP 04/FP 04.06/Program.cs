namespace FP_04._06;

class Program
{
    static void Main(string[] args)
    {
        double numeroA, numeroB;
        char simbolo;

        Console.Write("Insira o primeiro número: ");
        numeroA = Convert.ToDouble(Console.ReadLine());
        Console.Write("Insira o segundo número: ");
        numeroB = Convert.ToDouble(Console.ReadLine());
        Console.Write("Insira o símbolo para operação: ");
        simbolo = Convert.ToChar(Console.ReadLine());

        switch (simbolo)
        {
            case '+':
                Console.WriteLine("A soma de {0} mais {1} é igual a {2}.", numeroA, numeroB, numeroA + numeroB);
                break;
            case '-':
                Console.WriteLine("A subtração de {0} menos {1} é igual a {2}.", numeroA, numeroB, numeroA - numeroB);
                break;
            case '*':
                Console.WriteLine("A mutiplicaçao de {0} e {1} é igual a {2}.", numeroA, numeroB, numeroA * numeroB);
                break;
            case '/':
                Console.WriteLine("A divisão de {0} por {1} é igual a {2}.", numeroA, numeroB, numeroA / numeroB);
                break;
        }
        Console.ReadKey();
    }
}
