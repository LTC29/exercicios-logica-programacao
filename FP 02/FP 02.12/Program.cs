namespace FP_02._12;

class Program
{
    static void Main(string[] args)
    {
        double comprimento, largura, altura, volume;

        Console.Write("Insira o comprimento da caixa retangular em cm: ");
        comprimento = Convert.ToDouble(Console.ReadLine());
        Console.Write("Insira a largura da caixa retangular em cm: ");
        largura = Convert.ToDouble(Console.ReadLine());
        Console.Write("Insira a altura da caixa retangular em cm: ");
        altura = Convert.ToDouble(Console.ReadLine());

        volume = comprimento * largura * altura;

        Console.WriteLine("O volume da caixa retangular é {0} cm³.", volume);
        Console.ReadKey();
    }
}
