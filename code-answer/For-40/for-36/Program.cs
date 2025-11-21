//For36.Given positive integers N and K, find the sum
//1K + 2K + … + NK.
//To avoid the integer overflow, compute the sum using real variables and
//output the result as a real number.

namespace for_36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N: ");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("K: ");
            double k = Convert.ToDouble(Console.ReadLine());

            double eq = 0;
            double s = 0;

            for (double i = 1; i <= n; i++)
            {
                eq = i;
                //eq += Math.Pow(i,k);
                for (double j = 1; j < k; j++)
                {
                    eq *= i;
                Console.WriteLine($"iteration: {eq}");
                }
                s += eq;
            }
            Console.WriteLine($"answer: {s}");
        }
    }
}
