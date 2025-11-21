//While3.Two positive integers N and K are given. Using addition and subtraction
//only, find a quotient of the integer division N on K and also a remainder after
//this division.

namespace while_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("K: ");
            int k = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (n - k >= i-1)
            {
                n -= k;
                i++;
            }
            Console.WriteLine($"/: {i}");
            Console.WriteLine($"%: {n}");
        }
    }
}
