//For37.Given an integer N (> 0), find the sum
//11 + 22 + … + NN.
//To avoid the integer overflow, compute the sum using real variables and
//output the result as a real number.

namespace for_37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N: ");
            double n = Convert.ToDouble(Console.ReadLine());

            double eq = 0;
            double s = 0;

            for (double i = 1; i <= n; i++)
            {
                eq = i;
                for (double j = 1; j < i; j++)
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
