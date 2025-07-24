//  Begin30.The angle value α in radians (0 ≤ α < 2·π) is given. Convert this value into
//  degrees. Take into account that 180° = π radians. Use 3.14 for a value of π.
using System.Transactions;

namespace begin_30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("A: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double pi = 3.14;
            double radians = 180;

            double answer = (2*pi * a) / radians;
            Console.WriteLine(answer);
        }
    }
}
