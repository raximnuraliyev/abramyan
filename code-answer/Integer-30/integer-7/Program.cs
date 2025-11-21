//Integer7.A two-digit integer is given. Find the sum and the product of its digits.

namespace integer_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A: ");
            int a = Convert.ToInt32(Console.ReadLine());

            int b = a % 10;
            int c = (a % 100)/10;
            Console.WriteLine($"sum: {b + c}");
        }
    }
}
