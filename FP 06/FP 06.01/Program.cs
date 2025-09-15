namespace FP_06._01;

class Program
{
    static void Main(string[] args)
    {
        int soma = 0, tamanho = 10, quantidadeAcimaDaMedia = 0;
        double media;
        int[] idades = new int[tamanho];
        Console.Write("Digite a idade dos 10 alunos: ");

        for (int i = 0; i < tamanho; i++)
        {
            idades[i] = Convert.ToInt32(Console.ReadLine());
            soma = soma + idades[i];
        }
        media = soma / 10;
        for (int i = 0; i < tamanho; i++)
        {
            if (idades[i] > media)
            {
                quantidadeAcimaDaMedia++;
            }
        }
        Console.WriteLine("{0} alunos possuem idade acima da média, que no caso, é {1}", quantidadeAcimaDaMedia, media);
    }
}
