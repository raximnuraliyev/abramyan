//For10.Given an integer N (> 0), find the value of a following sum (as a real
//number):
//1 + 1 / 2 + 1 / 3 + … +1 / N.

namespace for_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            double count = 0;
            for (double i = 1; i <= n; i++)
            {
                count += i;
                Console.WriteLine(" ");
                Console.WriteLine($"i: {i}");
                Console.WriteLine(count);
                Console.WriteLine($"count: {count / i}");
            }
        }
    }
}
