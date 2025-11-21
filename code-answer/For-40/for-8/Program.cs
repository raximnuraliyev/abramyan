//For8.Given two integers A and B (A < B), find the product of all integers in the
//range A to B inclusive.

namespace for_8
{
    internal class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int count = 1;
            for (int i = a; i <= b; i++)
            {
                count *= i;
                Console.WriteLine($"count: {count}");
                Console.WriteLine(" ");
                Console.WriteLine($"i: {i}");
                //Console.WriteLine(count + i);
            }
        }
    }
}
