//For17.A real number A and an integer N (> 0) are given. Using one loop-statement
//compute the sum
//1 + A + A2 + A3 + … + AN

namespace for_17
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("A: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = -1;
            for (int i = 0; i <= n; i++)
            {
                sum += a*a;


                Console.WriteLine(" ");
                Console.WriteLine($"i: {i}");
                Console.WriteLine($"sum: {sum}");
                Console.WriteLine($"n: {n}");
                Console.WriteLine($"a: {a}");
            }
        }
    }
}
