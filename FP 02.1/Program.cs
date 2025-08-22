namespace FP_02._1;

class Program
{
    static void Main(string[] args)
    {
        double tempCelsius;
        //double tempFahrenheit;
        Console.Write("Temperatura em Celsius: ");
        tempCelsius = Convert.ToDouble(Console.ReadLine());
        //tempFahrenheit = (9*tempCelsius+160)/5;
        //Console.WriteLine("Temperatura em Farenheit: {0}", tempFahrenheit);
        Console.WriteLine("Temperatura em Farenheit: {0}", (9 * tempCelsius + 160) / 5);
        
        //O comentado é a forma destrinchada.
    }
}
