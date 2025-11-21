//  Integer8.A two-digit integer is given. Output an integer obtained from the given one
//  by exchange of its digits.
using System.Globalization;

namespace integer_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("two-digit integer: ");
            int two_digit = Convert.ToInt32(Console.ReadLine());

            int a = two_digit % 10;
            int b = two_digit / 10;

            int result = a * 10 + b; 
            Console.WriteLine(result);
        }
    }
}
