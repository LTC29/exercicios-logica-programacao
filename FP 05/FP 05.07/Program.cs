using System.Diagnostics.Contracts;
using System.Runtime;

namespace FP_05._07;

class Program
{
    static void Main(string[] args)
    {
        double valorInserido, valorMaior = 0, valorMenor = 0;
        
        for (int controle = 1; controle <= 10; controle++) //pode ser usado controle = 0, controle < 10
        {
            Console.Write("Insira um valor: ");
            valorInserido = Convert.ToDouble(Console.ReadLine());

            if (controle == 1) //no primeiro loop, atribui maior e menor para não ser 0
            {
                valorMaior = valorInserido;
                valorMenor = valorInserido;
            }
            else if (valorInserido > valorMaior)
            {
                valorMaior = valorInserido;
            }
            else if (valorInserido < valorMenor)
            {
                valorMenor = valorInserido;
            }
        }
        Console.WriteLine("O menor valor é {0} e o maior, {1}", valorMenor, valorMaior);
        
        /*
        int contador = 0;
        while (contador < 10)
        {
            Console.Write("Insira um valor: ");
            valorInserido = Convert.ToDouble(Console.ReadLine());
            if (contador == 0){
                valorMaior = valorInserido;
                valorMenor = valorInserido;
            }
            else if (valorInserido > valorMaior)
            {
                valorMaior = valorInserido;
            }
            else if (valorInserido < valorMenor)
            {
                valorMenor = valorInserido;
            }
            contador++;
        }
        Console.WriteLine("O menor valor é {0} e o maior, {1}", valorMenor, valorMaior);
        */
    }
}
