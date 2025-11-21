/*
For28. A real number X (|X| < 1) and an integer N (> 0) are given. Compute the
   expression
   1 + X/2 − 1·X2/(2·4) + 1·3·X3/(2·4·6) − … +
   + (−1)N−1·1·3·…·(2·N−3)·XN/(2·4·…·(2·N)).
   The result is an approximate value of the square root of 1 + X.
*/
namespace for_28
{
    internal class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            double sign = 1;
            double mult_even = 1;
            double mult_odd = 1;
            double s = 1;

            for (int i = 1; i <= n; i++)
            {
                sign *= -1;
                mult_even = (2 * i -3);
                mult_odd = i * 2;
                double eq = sign * mult_even * Math.Pow(x,i) / mult_odd;
                s += eq;

                Console.WriteLine($"s:    {s}");
                Console.WriteLine($"sign: {sign}");
            }
            Console.WriteLine($" ");
            Console.WriteLine($"s:    {s}");
            Console.WriteLine($"mult even: {mult_even}");
            Console.WriteLine($"mult odd: {mult_odd}");
            Console.WriteLine($"sign: {sign}");

        }
    }
}
//1 + 0.25 - 0.03125 + 0.0078125 = 1.2265625
