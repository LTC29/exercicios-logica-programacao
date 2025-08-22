using System.Diagnostics.Tracing;

namespace FP_02._7;

class Program
{
    static void Main(string[] args)
    {
        int diaNasc, mesNasc, anoNasc;

        Console.Write("Digite o dia de seu nascimento: ");
        diaNasc = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o número do mês de seu nascimento: ");
        mesNasc = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o ano de seu nascimento: ");
        anoNasc = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Dia: {0}\nMês: {1:D2}\nAno: {2}", diaNasc, mesNasc, anoNasc); 
        //D2 significa quantos zeros (padding) adicionar antes 

    }
}
