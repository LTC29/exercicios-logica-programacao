namespace FP07_09;

using System.Text;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("String: ");
        string original = Minuscula(Console.ReadLine());
        Console.Write("K: ");
        int k = Convert.ToInt32(Console.ReadLine());
        StringBuilder criptografada = new StringBuilder();
        for (int i = 0; i < original.Length; i++)
        {
            if (original[i] >= 'a' && original[i] <= 'z')
            {
                criptografada.Append(Convert.ToChar(original[i] + k));
            }
            else
            {
                criptografada.Append('a');
            }
        }
        Console.WriteLine(criptografada);
    }

        static string Minuscula(string original)
        {
            StringBuilder minuscula = new StringBuilder();
        for (int i = 0; i < original.Length; i++)
        {
            if (original[i] >= 'A' && original[i] <= 'Z')
            {
                minuscula.Append(Convert.ToChar(original[i] + 32));
            }
            else
            {
                minuscula.Append(original[i]);
            }
        }
            return minuscula.ToString();
        }
    }

