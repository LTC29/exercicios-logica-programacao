namespace FP_03._11;

class Program
{
    static void Main(string[] args)
    {
        double v0, s0, a, t;

        Console.Write("Insira a posição inicial da partícula: ");
        s0 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Insira a velocidade inicial da partícula: ");
        v0 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Insira a aceleração da partícula: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Insira o tempo: ");
        t = Convert.ToDouble(Console.ReadLine());
        PosicaoVelocidade(s0, v0, a, t);
        Console.ReadKey();
    }

    static void PosicaoVelocidade(double s0, double v0, double a, double t)
    {
        double s = s0 + v0 * t + (a * t * t) / 2;
        double v = v0 + a * t;
        Console.WriteLine("A posição é {0} e a velocidade é {1}.", s, v);
    }
}



