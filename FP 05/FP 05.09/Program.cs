namespace FP_05._09;

class Program
{
    static void Main(string[] args)
    {
        double nota1 = 0, nota2 = 0, nota3 = 0, maiorNota = 0, mediaPonderada;
        int matricula;
        do
        {
            Console.Write("Informe sua matrícula: ");
            matricula = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insira a primeira nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Insira a segunda nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Insira a terceira nota: ");
            nota3 = Convert.ToDouble(Console.ReadLine());
            if (nota1 > nota2 && nota1 > nota3)
            {
                maiorNota = nota1;
                nota1 = nota2;
                nota2 = nota3;
            }
            else if (nota2 > nota1 && nota2 > nota3)
            {
                maiorNota = nota2;
                nota2 = nota1;
                nota1 = nota3;
            }
            else if (nota3 > nota1 && nota3 > nota2)
            {
                maiorNota = nota3;
            }

            mediaPonderada = CalcularMediaPonderada(maiorNota, nota1, nota2);
            if (mediaPonderada >= 5)
            {
                Console.WriteLine("Aluno de matrícula {0} está APROVADO! {1}", matricula, mediaPonderada);

            }
            else
            {
                Console.WriteLine("Aluno de matricula {0} está REPROVADO! {1}", matricula, mediaPonderada);
            }
        } while (mediaPonderada >= 5.0);

        static double CalcularMediaPonderada(double maiorNota, double nota1, double nota2)
        {
            double mediaPonderada = ((4.0 * maiorNota) + (3.0 * nota1) + (3.0 * nota2)) / (4.0 + 3.0 + 3.0);
            return mediaPonderada;
        }
    }
}


/*

x = 2
y = 4
z = 6
w


se z for o maior

w = z
z = y
y = x 
x = x (nao usado)

z = x
x = y
y = z
*/