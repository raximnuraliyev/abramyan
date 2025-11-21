//For32.An integer N (> 0) is given. A sequence of real numbers AK is defined as:
//A0 = 1, AK = (AK−1 + 1)/ K, K = 1, 2, … .
//Output terms A1, A2, …, AN of the sequence.

namespace for_32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N: ");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("A: ");
            double a = Convert.ToDouble(Console.ReadLine());
            //double a = 1;
            double k = 1;

            for (double i = 1; i <= n; i++)
            {

                a = k + 1 / i;
                k = a - 1;
                //Console.WriteLine($"i: {i}");
                Console.WriteLine($"a: {a}");
                //Console.WriteLine($"k: {k}");
            }
        }
    }
}
