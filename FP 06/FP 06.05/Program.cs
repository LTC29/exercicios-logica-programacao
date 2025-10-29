namespace FP_06._05;

class Program
{
    static void Main(string[] args)
    {
        int[] gabarito = new int[13];
        int[] aposta = new int[13];
        int abaixoDeDez = 0;

        for (int i = 0; i < gabarito.Length; i++)
        {
            Console.Write("Insira o {0}º valor do gabarito: ", i+1);
            gabarito[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("-----------------------------------------------");

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < aposta.Length; j++)
            {
                Console.Write("Insira o {0}º valor do apostador: ", i + 1);
                aposta[j] = Convert.ToInt32(Console.ReadLine());
            }
            int quantidadeDeAcertos = ConfereAcertos(gabarito, aposta);
            Console.WriteLine("O {0}º apostador teve {1} acertos.", i + 1, quantidadeDeAcertos);
            Console.WriteLine("------------------------------------------------");
            if (quantidadeDeAcertos <= 10)
                abaixoDeDez++;
            ;
        }
        Console.WriteLine("{0}% dos apostadores fizeram abaixo de 10 pontos.", abaixoDeDez * 20);
        Console.WriteLine("------------------------------------------------");   
    }

    static int ConfereAcertos(int[] gabarito, int[] aposta)
    {
        int qtdAcerto = 0;
        for (int i = 0; i < gabarito.Length; i++)
        {
            if (aposta[i] == gabarito[i])
                qtdAcerto++;
        }
        return qtdAcerto;
    }
    

}
