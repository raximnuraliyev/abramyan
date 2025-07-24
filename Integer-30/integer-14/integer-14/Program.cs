//  Integer14.A three-digit integer is given. Output an integer obtained from the given
//  one by moving its right digit to the left side.
namespace integer_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("three digit: ");
            int three_digit = Convert.ToInt32 (Console.ReadLine());

            int first = three_digit % 10;
            int middle = three_digit % 100 / 10;
            int end = three_digit / 100;

            end = middle;
            middle = first;
            Console.WriteLine($"from right: {end} digit, to the left {middle}");

        }
    }
}
