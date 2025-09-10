namespace FP_05._11;

class Program
{
    static void Main(string[] args)
    {
        int numeroInserido, menorNumero;
        Console.Write("Digite um número: ");
        numeroInserido = Convert.ToInt32(Console.ReadLine());

        if (numeroInserido != 0)
        {
            menorNumero = numeroInserido;
            while (numeroInserido != 0)
            {
                Console.Write("Digite um número: ");
                numeroInserido = Convert.ToInt32(Console.ReadLine());
                if (numeroInserido < menorNumero && numeroInserido !=0)
                {
                    menorNumero = numeroInserido;
                }
            }

            Console.WriteLine("Menor número do conjunto é {0}", menorNumero);
        } 
        
    }
}
