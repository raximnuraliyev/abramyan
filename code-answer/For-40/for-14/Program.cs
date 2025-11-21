//For14.Given an integer N (> 0), compute N2 by means of the formula
//N2 = 1 + 3 + 5 + … + (2·N − 1).
//Output the value of the sum after addition of each term. As a result, squares of
//all integers in the range 1 to N will be output.

namespace for_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            double sum = 0;
            double odd = 1;
            for (double i = 1; i <= n; i++)
            {
                sum = sum + odd;
                odd = odd + 2;


                Console.WriteLine(" ");
                Console.WriteLine($"i: {i}");
                Console.WriteLine($"sum: {sum}");
                Console.WriteLine($"odd: {odd}");
                Console.WriteLine($"n: {n}");
            }
        }
    }
}
