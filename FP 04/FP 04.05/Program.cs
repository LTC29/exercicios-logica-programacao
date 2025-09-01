namespace FP_04._05;

class Program
{
    static void Main(string[] args)
    {
        int diaSemana;

        Console.Write("Insira o dia da semana (1 - domingo; 2 - segunda; etc.): ");
        diaSemana = Convert.ToInt32(Console.ReadLine());

        if (diaSemana < 1 || diaSemana > 7)
        {
            Console.WriteLine("Número/dia inválido.");
        }
        else
        {
            switch (diaSemana)
            {
                case 1:
                    Console.WriteLine("Domingo.");
                    break;
                case 2:
                    Console.WriteLine("Segunda-feira.");
                    break;
                case 3:
                    Console.WriteLine("Terça-feira.");
                    break;
                case 4:
                    Console.WriteLine("Quarta-feira.");
                    break;
                case 5:
                    Console.WriteLine("Quinta-feira.");
                    break;
                case 6:
                    Console.WriteLine("Sexta-feira.");
                    break;
                case 7:
                    Console.WriteLine("Sábado.");
                    break;
            }
        }
        Console.ReadKey();
    }
}
