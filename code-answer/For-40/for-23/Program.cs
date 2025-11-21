//For23.A real number X and an integer N (> 0) are given. Compute the expression
//X − X3/(3!) + X5/(5!) − … + (−1)N·X2·N+1/((2·N+1)!)
//(N! = 1·2·…·N). The result is an approximate value of sin(X).

namespace for_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("X: ");
            double x = Convert.ToInt32(Console.ReadLine());

            //double sum = 1;
            //double term = x;


            //for (double i = 1; i <= n; i++)
            //{
            //    term = term * (-1) * x * x / ((2 * i) * (2 * i + 1));
            //    sum += term;

            //    Console.WriteLine(" ");
            //    Console.WriteLine(sum);
            //}

            double sign = -1;
            double fact = 1;
            double s = 0;
            for (double i = 2; i <= 2 * (n + 1); i= i+2)
            {
                sign *= -1;
                fact *= (i-1);
                double eq = sign * (Math.Pow(x, i - 1)) / fact;
                s += eq;
                fact *= i;
            }
            Console.WriteLine($" ");
            Console.WriteLine($"s: {s}");
            Console.WriteLine($"fact: {fact}");
            Console.WriteLine($"sign: {sign}");
        }
    }
}
