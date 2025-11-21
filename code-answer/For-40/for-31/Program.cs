//For31.An integer N (> 0) is given. A sequence of real numbers AK is defined as:
//A0 = 2, AK = 2 + 1 / AK−1, K = 1, 2, … .
//Output terms A1, A2, …, AN of the sequence.
namespace for_31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N: ");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("A: ");
            double a = Convert.ToDouble(Console.ReadLine());



            for (double i = 1; i <= n; i++)
            {
                a = 2 + 1 / a;
                Console.WriteLine(a);
            }
        }
    }
}
