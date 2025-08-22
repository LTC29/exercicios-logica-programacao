namespace FP_02._8;

class Program
{
    static void Main(string[] args)
    {
        double valorEnunciado = 2.346728;

        Console.WriteLine("{0:N1}\n{0:N2}\n{0:N3}\n{0:N5}", valorEnunciado); // N significa CASAS decimais; depois da vírgula/ponto.
        Console.ReadKey();
    }
}
