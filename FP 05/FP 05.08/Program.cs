namespace FP_05._08;

class Program
{
    static void Main(string[] args)
    {
        double alturaChico = 1.5, alturaZe = 1.4;
        int anos = 0;

        while (alturaChico >= alturaZe)
        {
            anos++;
            alturaChico += 0.02;
            alturaZe += 0.03;
        }
        Console.WriteLine("{0} anos para Zé passar de Chico.", anos);
    }
}

