//While2.Two positive real numbers A and B (A > B) are given. A segment of length A
//contains the greatest possible amount of segments of length B (without
//overlaps). Not using multiplication and division, find the amount of
//segments B, which are placed on the segment A.

namespace while_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (a - b > i)
            {
                a -= b;
                i++;
            }
            Console.WriteLine(a);
        }
    }
}
