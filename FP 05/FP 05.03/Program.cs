namespace FP_05._03;

class Program
{
    static void Main(string[] args)
    {
        int num, divisores;
        Console.Write("Insira um número inteiro: ");
        num = Convert.ToInt32(Console.ReadLine());

        divisores = 0; //contador
        
        for (int controle = 1; controle <= num; controle++)
        {
            if (num % controle == 0)
            {
                divisores++;
            }
        }
        if (divisores == 2)
        {
            Console.WriteLine("Numero é primo.");
        }
        else
        {
            Console.WriteLine("Número não é primo.");
        }


    }
}
