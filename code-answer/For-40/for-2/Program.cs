//For2.Given two integers A and B (A < B), output in ascending order all integers in
//the range A to B (including A and B). Also output the amount N of these
//integers.

namespace for_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            for (int i = a; i < b; i++)
            {
                count++;
                Console.WriteLine(i);
            }
            Console.WriteLine(count);
        }
    }
}
