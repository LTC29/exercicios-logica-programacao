namespace FP_03._05;

class Program
{
    static void Main(string[] args)
    {
        double x1, x2, y1, y2, distanciaVertice;

        Console.Write("Insira a primeira coordenada x1 do primeiro vertice: ");
        x1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Insira a segunda coordenada y1 do primeiro vertice: ");
        y1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Insira a primeira coordenada x2 do primeiro vertice: ");
        x2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Insira a segunda coordenada y2 do primeiro vert: ");
        y2 = Convert.ToDouble(Console.ReadLine());
        distanciaVertice = DistanciaEntrePontos(x1, y1, x2, y2);
        Console.WriteLine("A distância entre dois pontos é {0} unidades.", distanciaVertice);
        Console.ReadKey();
    }
    static double DistanciaEntrePontos(double x1, double y1, double x2, double y2)
    {
        double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        return distancia;
    }

}
