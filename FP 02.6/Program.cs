namespace FP_02._6;

class Program
{
    static void Main(string[] args)
    {
        int tempoTotal;
        int segundos;
        int minutos;
        int horas;

        Console.Write("Insira um intervalo de tempo em segundos: ");
        tempoTotal = Convert.ToInt32(Console.ReadLine());
        horas = tempoTotal / 3600;
        minutos = (tempoTotal % 3600)/60; //Restante das horas (em segundos) dividido por 60 para dar os minutos.
        segundos = tempoTotal % 60; //Restante do tempo total dividido por 60, ou seja, os segundos que sobraram.
        
        Console.WriteLine("{0:D2}:{1:D2}:{2:D2}", horas, minutos, segundos);

    }
}
