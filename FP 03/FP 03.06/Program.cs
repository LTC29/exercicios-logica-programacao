namespace FP_03._06;

class Program
{
    static void Main(string[] args)
    {
      double x1, x2, y1, y2, x3, y3, primeiroVert, segundoVert, terceiroVert, perimetro;

        Console.Write("Insira a primeira coordenada x1 do primeiro vertice: ");
        x1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Insira a segunda coordenada y1 do primeiro vertice: ");
        y1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Insira a primeira coordenada x2 do segundo vertice: ");
        x2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Insira a segunda coordenada y2 do segundo vert: ");
        y2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Insira a primeira coordenada x3do terceiro vertice: ");
        x3 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Insira a segunda coordenada y3 do terceiro vert: ");
        y3 = Convert.ToDouble(Console.ReadLine());
        primeiroVert = DistanciaEntrePontos(x1, y1, x2, y2);
        segundoVert = DistanciaEntrePontos(x1, y1, x3, y3);
        terceiroVert = DistanciaEntrePontos(x2, y2, x3, y3);
        perimetro = primeiroVert+segundoVert+terceiroVert;
        Console.WriteLine("A distância entre dois pontos é {0} unidades.", perimetro);
        Console.ReadKey();
    }
    static double DistanciaEntrePontos(double x1, double y1, double x2, double y2)
    {
        double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        return distancia;
    }
}
