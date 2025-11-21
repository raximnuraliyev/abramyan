//For7.Given two integers A and B (A < B), find the sum of all integers in the range A
//to B inclusive.

namespace for_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A: ");
            int a = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("B: ");
            int b = Convert.ToInt32 (Console.ReadLine());

            int count = 0;
            for (int i = a; i <= b; i++)
            {
                count = count + i;
                Console.WriteLine(count);
                Console.WriteLine(" ");
                //Console.WriteLine(count + i);
            }
        }
    }
}
