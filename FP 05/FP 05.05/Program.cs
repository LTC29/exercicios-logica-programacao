namespace FP_05._05;

class Program
{
    static void Main(string[] args)
    {

        //numerador começa em 2
        //denominador começa em 50 e subtrai 2
        //expoente vai de 1 a 25

        int denominador, expoente;
        double s;

        denominador = 50;
        s = 0;
        expoente = 1;
        while (expoente <= 25)
        {

            s = Math.Pow(2, expoente) / denominador + s;
            denominador = denominador - 2;
            expoente++;
        }
        Console.WriteLine("O resultado final é {0}", s);

        /*
        s = 0;
        for (expoente = 1; expoente <= 25; expoente++)
        {
            
            s = (Math.Pow(2, expoente) / denominador) + s;
            denominador = denominador - 2;
            //Console.WriteLine("{0}", s);
        }
        Console.WriteLine("O resultado final é {0}", s);
        */

    }
}
