namespace FP_02._3;

class Program
{
    static void Main(string[] args)
    {
        double lado1, lado2, lado3;
        double perimTriangulo;

        Console.Write("Tamanho do primeiro lado do triângulo: ");
        lado1 = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
        Console.Write("Tamanho do segundo lado do triângulo: ");
        lado2 = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
        Console.Write("Tamanho do terceiro lado do triângulo: ");
        lado3 = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
        perimTriangulo = lado1 + lado2 + lado3;
        Console.WriteLine("Perímetro do triângulo: {0}", perimTriangulo);
    }
}
