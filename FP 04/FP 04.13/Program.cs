using System.Globalization;

namespace FP_04._13;

class Program
{
    static void Main(string[] args)
    {
        double x, y, z;
        Console.Write("Insira o primeiro comprimento (x): ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Insira o segundo comprimento (y): ");
        y = Convert.ToDouble(Console.ReadLine());
        Console.Write("Insira o terceiro comprimento (z): ");
        z = Convert.ToDouble(Console.ReadLine());
        if (x < y + z && y < x + z && z < x + y)
        {
            Console.WriteLine("Um triângulo é formado.");
        }
        else
        {
            Console.WriteLine("Um triângulo não é formado.");
        }
    }
}
