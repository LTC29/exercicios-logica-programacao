namespace _9;

class Program
{
    static void Main(string[] args)
    {
        int num, fatorial = 1;
        double equacao = 1.0;

        Console.Write("Número: ");
        num = Convert.ToInt32(Console.ReadLine());

        if (num == 0 || num == 1)
        {
            Console.WriteLine("Resultado é 1.");
        }
        else
        {
            for (int i = 1; i <= num; i++) //fatorial funciona de cima pra baixo, mas a série de euler, precisa de baixo pra cima
            {

                fatorial = fatorial * i;
                equacao = 1.0 / fatorial + equacao;

            }
            Console.WriteLine("Fatorial de {0} é {1} e o resultado da equação é {2}", num, fatorial, equacao);
        }
    }
}
