namespace FP07_02;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insira uma string: ");
        string stringInserida = Console.ReadLine();
        int contador = ContaProcurado(stringInserida);
        Console.WriteLine("O item procurado aparece {0} vezes.", contador);
    }

    static int ContaProcurado(string inserida)
    {
        int contador = 0;
        
        for (int i = 0; i < inserida.Length; i++)
        {
            if (inserida[i] == 'a' || inserida[i] == 'e' || inserida[i] == 'i' || inserida[i] == 'o' || inserida[i] == 'u' || inserida[i] == 'A' || inserida[i] == 'E' || inserida[i] == 'I' || inserida[i] == 'O' || inserida[i] == 'U')
                contador++;
        }
        return contador;
    }
}
