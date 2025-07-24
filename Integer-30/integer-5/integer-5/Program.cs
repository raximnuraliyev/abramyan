/*

Integer5. Two positive integers A and B are given (A > B). Segment of length A
contains the greatest possible amount of inside segments of length B (without
overlaps). Find the length of unused part of the segment A. Use the operator of
taking the remainder after integer division
 
*/
namespace integer_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("B: ");
            int B = Convert.ToInt32(Console.ReadLine());

            int answer = A % B;
            Console.WriteLine(answer);
        }
    }
}
