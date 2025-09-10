namespace FP_05._12;

class Program
{
    static void Main(string[] args)
    {
        double celsius, fahr;
        Console.WriteLine("{0,12} | {1,-12}", "Fahrenheit", "Celsius");
        for (double i = 50; i <= 150; i++)
        {
            fahr = i;
            celsius = 5.0 / 9.0 * (fahr - 32.0);
            Console.WriteLine("{0,12} | {1,-12:N2}", fahr, celsius);
        }

    }

}
