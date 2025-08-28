namespace FP_03._07;

class Program
{
    static void Main(string[] args)
    {
        int tempoExperimento;

        Console.Write("Insira o tempo total do experimento em segundos: ");
        tempoExperimento = Convert.ToInt32(Console.ReadLine());
        TempoRelogio(tempoExperimento);
        Console.ReadKey();

    }

    static void TempoRelogio(int tempototal)
    {
        int horas = tempototal / 3600;
        int minutos = (tempototal % 3600) / 60; // resto das horas, em segundos / 60
        int segundos = tempototal % 60;
        Console.WriteLine("{0:D2}:{1:D2}:{2:D2}", horas, minutos, segundos);
    }
}
