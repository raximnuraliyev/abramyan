//For16.A real number A and an integer N (> 0) are given. Using one loop-statement
//compute and output powers AK for all integer exponents K in the range 1 to N.

namespace for_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 1;
            for (int i = 1; i <= n; i++)
            {
                sum *= a;


                Console.WriteLine(" ");
                Console.WriteLine($"i: {i}");
                Console.WriteLine($"n: {n}");
                Console.WriteLine($"a: {a}");
                Console.WriteLine($"sum: {sum}");
            }
        }
    }
}
