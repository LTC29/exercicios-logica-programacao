namespace FP07_08;

using System.Text;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("String original: ");
        string original = Console.ReadLine().ToLower();
        if (InverteString(original))
        {
            Console.WriteLine("Palíndrome.");
        }
        else
        {
            Console.WriteLine("Não é palíndrome.");
        }
    }

    static bool InverteString(string original)
    {
        StringBuilder inversa = new StringBuilder();
        for (int i = original.Length - 1, j = 0; i >= 0; i--, j++)
        {
            inversa.Append(original[i]);
        }
        int contador = 0;
        for (int i = 0; i < original.Length; i++)
        {
            if (original[i] == inversa[i])
            {
                contador++;
            }
        }
        if (contador == original.Length)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
