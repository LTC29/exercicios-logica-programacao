namespace FP_02._11;

class Program
{
    static void Main(string[] args)
    {
        double massa;
        double altura;
        double imc;

        Console.Write("Insira o seu peso em kg: ");
        massa = Convert.ToDouble(Console.ReadLine());
        Console.Write("Insira sua altura em metros: ");
        altura = Convert.ToDouble(Console.ReadLine());
        imc = massa / Math.Pow(altura, 2);

        Console.WriteLine("Seu IMC é {0:N2}.", imc);
    }
}
