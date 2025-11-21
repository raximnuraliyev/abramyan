//For35.An integer N (> 2) is given. A sequence of integers AK is defined as:
//A1 = 1, A2 = 2, A3 = 3, AK = AK−1 + AK−2 − 2·AK−3, K = 4, 5, … .
//Output terms A1, A2, …, AN of the sequence.

namespace for_35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N: ");
            double n = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("F: ");
            //double a = Convert.ToDouble(Console.ReadLine());
            //double f = 1;
            double a = 1;
            double b = 2;
            double c = 3;

            double d = 0;

            for (double i = 1; i <= n-3; i++)
            {
                a = b;
                b = c;
                c = d;
                c = (d + b - 2 * a);
                //Console.WriteLine($"i: {i}");
                Console.WriteLine($"a: {a}");
                //Console.WriteLine($"f: {f}");
                //Console.WriteLine($"k: {k}");
            }
        }
    }
}
