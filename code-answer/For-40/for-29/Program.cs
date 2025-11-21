//For29. An integer N (> 1) and two points A, B (A < B) on the real axis are given. The
//segment [A, B] is divided into N sub-segments of equal length. Output the
//length H of each sub-segment and then output the sequence of points
//A, A + H, A + 2·H, A + 3·H, …, B,
//which forms a partition of the segment [A, B].For29. An integer N (> 1) and two points A, B (A < B) on the real axis are given. The
namespace for_29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int length = 1;
            int H = 1;


            for (int i = 1; i <= n; i++)
            {
                length = b - a;
                length /= n;
                b *= length;
                H += length;
            }
            Console.WriteLine($"{a}, {b}, {H}");
        }
    }
}
