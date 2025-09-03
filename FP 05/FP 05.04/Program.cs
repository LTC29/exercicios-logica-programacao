namespace FP_05._04;

class Program
{
    static void Main(string[] args)
    {
        int meses;
        double divida = 10000, aplicacao = 1500;

        //pagar significa que aplicacao - divida >= 0 ou divida - aplicacao > 0
        //com cada mês, divida = divida * 1.025 e aplicacao = aplicacao * 1.04
        meses = 0;
        while (divida - aplicacao > 0)
        {
            aplicacao = aplicacao * 1.04;
            divida = divida * 1.025;
            meses++;
        }
        Console.WriteLine("São necessários {0} meses para quitar a divida.", meses);


    }
}
