namespace FP_05._14;

class Program
{
    static void Main(string[] args)
    {
        int num, primeiroTermo = 0, segundoTermo = 1, terceiroTermo;
        Console.Write("Número: ");
        num = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i < num; i++)
        {
            
            terceiroTermo = primeiroTermo + segundoTermo;
            primeiroTermo = segundoTermo;
            segundoTermo = terceiroTermo;
            
            
            Console.Write("{0}  ", terceiroTermo);
        }
    }
}

