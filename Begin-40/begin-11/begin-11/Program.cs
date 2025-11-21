//  Begin11.Two nonzero numbers are given. Find the sum, the difference, the product,
//  and the quotient of their absolute values.
using System.ComponentModel;

namespace begin_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("B: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.ReadKey();



        }
    }
}
