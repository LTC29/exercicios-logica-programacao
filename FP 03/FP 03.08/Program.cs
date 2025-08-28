namespace FP_03._08;

class Program
{
    static void Main(string[] args)
    {
        double raio, volume;
        Console.Write("Insira o raio da esfera: ");
        raio = Convert.ToDouble(Console.ReadLine());
        volume = VolumeEsfera(raio);
        Console.WriteLine("Volume da esfera: {0}", volume);
        Console.ReadKey();
        
    }

    static double VolumeEsfera(double r)
    {
        double pi = 3.14;
        double v = (4 * pi * (Math.Pow(r, 3))) / 3;
        return v;
    }
}
