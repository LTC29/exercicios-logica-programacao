namespace FP_03._12;

class Program
{
    static void Main(string[] args)
    {
        double prova1, prova2, media;
        media = 5.0;

        Console.Write("Insira a nota da primeira prova: ");
        prova1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Insira a nota da segunda prova: ");
        prova2 = Convert.ToDouble(Console.ReadLine());
        PontosParaAprovacao(prova1, prova2, media);
        Console.ReadKey();
    }

    static void PontosParaAprovacao(double p1, double p2, double media)
    {
        double p3 = (4*media - p1 - p2) / 2;
        Console.WriteLine("Para aprovação, é necessário alcançar {0} pontos na terceira prova.", p3);
    }
}
