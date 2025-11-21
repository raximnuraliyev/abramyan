//Integer5.Two positive integers A and B are given (A > B). Segment of length A
//contains the greatest possible amount of inside segments of length B (without
//overlaps). Find the length of unused part of the segment A. Use the operator of
//taking the remainder after integer division.

namespace integer_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int c = a % b;              
               
            Console.WriteLine(c);
        }
    }
}
