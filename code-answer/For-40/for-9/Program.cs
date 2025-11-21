//For9.Given two integers A and B (A < B), find the sum of squares of all integers in
//the range A to B inclusive.

namespace for_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            double count = 1;
            for (double i = a; i <= b; i++)
            {
                count = Math.Pow(i,2);
                Console.WriteLine(" ");
                Console.WriteLine($"i: {i}");
                Console.WriteLine($"count: {count}");
            }
        }
    }
}
