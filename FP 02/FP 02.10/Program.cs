namespace FP_02._10;

class Program
{
    static void Main(string[] args)
    {
        double primNumero;
        double segNumero;

        Console.Write("Insira o primeiro número: ");
        primNumero = Convert.ToDouble(Console.ReadLine());
        Console.Write("Insira o segundo número: ");
        segNumero = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("O primeiro número somado ao segundo é: {0}.", primNumero + segNumero);
        Console.WriteLine("O primeiro número subtraído pelo segundo é: {0}.", primNumero - segNumero);
        Console.WriteLine("O primeiro número multiplicado pelo segundo é: {0}.", primNumero * segNumero);
        Console.WriteLine("O primeiro número dividido do segundo é: {0}.", primNumero / segNumero);


    }
}
