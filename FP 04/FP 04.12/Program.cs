namespace FP_04._12;

class Program
{
    static void Main(string[] args)
    {
        double altura, pesoIdeal;
        char sexo;


        Console.Write("Insira sua altura: ");
        altura = Convert.ToDouble(Console.ReadLine());
        Console.Write("Insira seu sexo (H ou M): ");
        sexo = Convert.ToChar(Console.ReadLine());
        switch (sexo)
        {
            case 'h':
            case 'H':
                pesoIdeal = (72.7 * altura) - 58;
                Console.WriteLine("O seu peso ideal é: {0} kg.", pesoIdeal);
                break;
            case 'm':    
            case 'M':
                pesoIdeal = (62.7 * altura) - 44.7;
                Console.WriteLine("O seu peso ideal é: {0} kg.", pesoIdeal);
                break;
        }
    }
}
