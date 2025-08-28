namespace FP_03._1;

class Program
{
    static void Main(string[] args)
    {
        double valor1, valor2, valor3;
        Console.Write("Insira o primeiro valor: ");
        valor1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Insira o segundo valor: ");
        valor2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Insira o terceiro valor: ");
        valor3 = Convert.ToDouble(Console.ReadLine());
        imprimeMedia(valor1, valor2, valor3);
        Console.ReadKey();


    }
    
    static void imprimeMedia(double valor1, double valor2, double valor3){
        double media = (valor1 + valor2 + valor3)/3;
        Console.WriteLine("Média: {0}", media);
    }

}
