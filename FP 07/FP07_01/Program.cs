namespace FP07_01;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Insira uma string: ");
        string stringInserida = Console.ReadLine();
        int contador = 0;
        char procurado = ' ';
        for (int i = 0; i < stringInserida.Length; i++)
        {
            if (stringInserida[i] == procurado)
                contador++;
        }
        Console.WriteLine("O item procurado aparece {0} vezes.", contador);
    }
}
