//For11.Given an integer N (> 0), find the value of a following sum (as an integer):
//N2 + (N + 1)2 + (N + 2)2 + … +(2·N)2

namespace for_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            double count = 0;
            for (int i = n; i <= n * 2; i++)
            {
                count += i*i;

                //count = Math.Pow((count),2);
                Console.WriteLine(" ");
                Console.WriteLine($"i: {i}");
                Console.WriteLine($"count: {count}");
            }
        }
    }
}
