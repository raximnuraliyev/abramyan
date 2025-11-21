//Integer4.Two positive integers A and B are given (A > B). Segment of length A
//contains the greatest possible amount of inside segments of length B (without
//overlaps). Find the amount of segments B placed on the segment A. Use the
//operator of integer division.

namespace integer_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("B:");
            int b = Convert.ToInt32(Console.ReadLine());

            int c = a/b;
            Console.WriteLine(c);
        }
    }
}
