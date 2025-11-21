//For26.A real number X (|X| < 1) and an integer N (> 0) are given. Compute the
//expression
//X − X3/3 + X5/5 − … + (−1)N·X2·N+1/(2·N+1).
//The result is an approximate value of atan(X).

namespace for_26
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
            double mult = 1;

            for (double i = 1; i <= 2*n+1; i+=2)
            {
                sign *= -1;
                double eq = sign * (Math.Pow(x, i)) / mult;
                mult += 2;
                s += eq;
                //Console.WriteLine($"   s: {s}");
            }
            Console.WriteLine($" ");
            Console.WriteLine($"   s: {s}");
            Console.WriteLine($"mult: {mult}");
            Console.WriteLine($"sign: {sign}");
        }
    }
}
