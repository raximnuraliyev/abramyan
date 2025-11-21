//For13.Given an integer N (> 0), find the value of the following expression of
//N terms with alternating signs:
//1.1 − 1.2 + 1.3 − … .
//Do not use conditional statements.

namespace for_13 {
    internal class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            double sum = 0;
            double sign = 1;
            for (double i = 1; i <= n; i++)
            {
                double reminder = ((i / 10) + 1);
                sum += reminder * sign;
                sign = sign*(-1);


                Console.WriteLine(" ");
                Console.WriteLine($"i: {i}");
                Console.WriteLine($"sum: {sum}");
                Console.WriteLine($"sign: {sign}");
                Console.WriteLine($"reminder: {reminder}");
                Console.WriteLine($"n: {n}");
            }
        }
    }
}