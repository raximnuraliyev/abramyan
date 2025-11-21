//For33.An integer N (> 0) is given. An integer-valued sequence of the Fibonacci
//numbers FK is defined as:
//F1 = 1, F2 = 1, FK = FK−2 + FK−1, K = 3, 4, … .
//Output terms F1, F2, …, FN of the sequence.

namespace for_33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N: ");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("F: ");
            //double a = Convert.ToDouble(Console.ReadLine());
            double f = 1;
            double a = 1;
            double b = 1;
            double c = 0;

            for (double i = 1; i <= n - 2; i++)
            {
                c = a;
                a = b;
                b = c;
                a = b + a;
                //Console.WriteLine($"i: {i}");
                Console.WriteLine($"a: {a}");
                //Console.WriteLine($"f: {f}");
                //Console.WriteLine($"k: {k}");
            }
        }
    }
}
