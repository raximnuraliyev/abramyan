//For25.A real number X (|X| < 1) and an integer N (> 0) are given. Compute the
//expression
//X − X2/2 + X3/3 − … + (−1)N−1·XN/N.
//The result is an approximate value of ln(1 + X).

using System.Threading.Channels;

namespace for_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            double s = 0;
            double sign = -1;
            double mult = 0;

            for (double i = 1; i <= n; i++)
            {
                mult += 1;
                double eq = sign * (Math.Pow(x,i)) / mult;
                s += eq;
                sign *= -1;
            }
            Console.WriteLine($" ");
            Console.WriteLine($"   s: {s}");
            Console.WriteLine($"mult: {mult}");
            Console.WriteLine($"sign: {sign}");
        }
    }
}
