namespace FP_05._01;

class Program
{
    static void Main(string[] args)
    {
        int num;
        num = 0;

        while (num <= 100)
        {
            if (num % 2 == 0)
            {
                Console.Write("{0} | ", num);
                num++;
            }
            else
            {
                num++;
            }
        } 

        /*
        int num;

        for (num = 0; num <=100; num = num+2)
        {
            Console.WriteLine("{0}", num);
        }
        */
    }
}
