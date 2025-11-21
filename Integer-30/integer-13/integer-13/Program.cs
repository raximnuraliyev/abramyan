//  Integer13.A three-digit integer is given. Output an integer obtained from the given
//  one by moving its left digit to the right side.
namespace integer_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("three-digit: ");
            int three_digit = Convert.ToInt32(Console.ReadLine());
            
            int last = three_digit % 10;
            int middle = three_digit % 100 / 10;
            int first = three_digit / 100;
            last = middle;
            middle = first;

            Console.WriteLine($"moving left {first} digit, to the right {middle} side.");

        }
    }
}
