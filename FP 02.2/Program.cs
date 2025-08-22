namespace FP_02._2;

class Program
{
    static void Main(string[] args)
    {
        //double salarioMin = 1518.00;
        double salarioUser;
        //double quantSalarios;

        Console.Write("Digite seu salário atual: ");
        salarioUser = Convert.ToDouble(Console.ReadLine());
        //quantSalarios = salarioUser / salarioMin;
        //quantSalarios = Math.Round(quantSalarios, 2);
        Console.Write("Você ganha {0} Salário(s) Mínimo(s).", salarioUser / 1518);

        //O comentado é a forma destrinchada de fazer, no caso, declarando mais variáveis.
    }
}
