// Begin10. Two nonzero numbers are given. Find the sum, the difference, the product, and the quotient of their squares.
namespace begin_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nonzero A: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("nonzero B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double sum = (a + b) / 2;
            Console.WriteLine($"Sum: {sum}");


        }
    }
}
// FAILED