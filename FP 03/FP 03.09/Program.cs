namespace FP_03._09;

class Program
{
    static void Main(string[] args)
    {
        int anos, meses, dias, IdadeEmDias;

        Console.Write("Insira sua idade em Idade, Meses e por fim, dias: ");
        anos = Convert.ToInt32(Console.ReadLine());
        meses = Convert.ToInt32(Console.ReadLine());
        dias = Convert.ToInt32(Console.ReadLine());
        IdadeEmDias = CalculoDias(anos, meses, dias);
        Console.WriteLine("Sua idade total em dias é {0}", IdadeEmDias);
    }

    static int CalculoDias(int anos, int meses, int dias)
    {
        int anosDias = anos * 365;
        int mesesDias = meses * 30;
        int IdadeDias = anosDias + mesesDias + dias;
        return IdadeDias;

        //Meses têm 30 dias e anos 365.
    }
}
