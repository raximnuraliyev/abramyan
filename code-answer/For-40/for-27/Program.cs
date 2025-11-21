/*
For27. A real number X (|X| < 1) and an integer N (> 0) are given. Compute the
expression
X + 1·X3/(2·3) + 1·3·X5/(2·4·5) + … + 1·3·…·(2·N−1)·X2·N+1/(2·4·…·(2·N)·(2·N+1)).
*/
namespace for_27
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
            /*double sign = -1;*/
            double mult = 0;

            for (double i = 1; i <= 2 * n + 1; i += 2)
            {
                /*sign *= -1;*/
                mult += 1;
                double eq = 1 * (Math.Pow(x, i)) / (mult * i);
                s += eq;
                /*Console.WriteLine($"   s: {s}");*/
            }
            Console.WriteLine($" ");
            Console.WriteLine($"s:    {s}");
            Console.WriteLine($"mult: {mult}");
            /*Console.WriteLine($"sign: {sign}");*/
        }
    }
}
