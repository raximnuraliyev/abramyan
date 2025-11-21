//For3.Given two integers A and B (A < B), output in descending order all integers in
//the range A to B (excluding A and B). Also output the amount N of these
//integers.

namespace for_3
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
            for (int i = b; i >= a; i--)
            {
                count++;
                Console.WriteLine(i);
            }
            Console.WriteLine(count);
        }
    }
}
