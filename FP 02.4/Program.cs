namespace Fp_02._4;

class Program
{
    static void Main(string[] args)
    {
        int numero;

        Console.Write("Insira um número inteiro: ");
        numero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("O antecessor do número inserido é {0} e seu sucessor, {1}.", numero - 1, numero + 1);
    }
}
