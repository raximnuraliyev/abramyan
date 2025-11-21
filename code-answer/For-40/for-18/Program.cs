//For18.A real number A and an integer N (> 0) are given. Using one loop-statement
//compute the expression
//1 − A + A2 − A3 + … + (−1)N·AN.
//Do not use conditional statements.

namespace for_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            double power = 1;
            double sign = 1;

            for (double i = 0; i <= n; i++)
            {
                sum += sign * power;
                power = power * a;
                sign = sign * (-1);

                Console.WriteLine(" ");
                Console.WriteLine($"sign {sign}");
                Console.WriteLine($"sum {sum}");
                Console.WriteLine($"power {power}");
                Console.WriteLine($"n {n}");
                Console.WriteLine($"a {a}");
            }
        }
    }
}
