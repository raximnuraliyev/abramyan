//For24.A real number X and an integer N (> 0) are given. Compute the expression
//1 − X2/(2!) + X4/(4!) − … + (−1)N·X2·N/((2·N)!)
//(N! = 1·2·…·N). The result is an approximate value of cos(X).

using System.Security.Cryptography.X509Certificates;

namespace for_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("X: ");
            double x = Convert.ToInt32(Console.ReadLine());

            double s = 1;
            double sign = -1;
            double fact = 1;

            for (double i = 2; i <= 2*n; i+=2)
            {
                fact *= i*(i-1);
                double eq = sign * (Math.Pow(x, i)) / fact;
                s += eq;
                sign *= -1;
            }
            Console.WriteLine($" ");
            Console.WriteLine($"s: {s}");
            Console.WriteLine($"fact: {fact}");
            Console.WriteLine($"sign: {sign}");
        }
    }
}
