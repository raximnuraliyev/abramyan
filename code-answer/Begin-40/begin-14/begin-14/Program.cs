//  Begin14.Given the length L of a circumference, find the radius R and the area S of
//  the circle. Take into account that L = 2·π·R, S = π·R2. Use 3.14 for a value
//  of π.
using System.Security.Cryptography;

namespace begin_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14;
            Console.Write("R: ");
            double R = Convert.ToDouble(Console.ReadLine());
            
            double L = 2 * pi * R;
            Console.WriteLine($"L: {L}");

            double S = pi * Math.Pow(R, 2);
            Console.WriteLine($"S: {S}");

        }
    }
}
