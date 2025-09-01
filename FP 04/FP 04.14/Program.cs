namespace FP_04._14;

class Program
{
    static void Main(string[] args)
    {
        char sinal;
        Console.Write("Insira um sinal:");
        sinal = Convert.ToChar(Console.ReadLine());
        switch (sinal)
        {
            case '-':
                Console.WriteLine("Sinal de menor.");
                break;
            case '+':
                Console.WriteLine("Sinal de maior.");
                break;
            case '=':
                Console.WriteLine("Sinal de igual.");
                break;
            default:
                Console.WriteLine("Outro caractere.");
                break;
        }
        
    }
}
