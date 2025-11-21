//For30. An integer N (> 1) and two points A, B (A < B) on the real axis are given. The
//segment [A, B] is divided into N sub-segments of equal length. Output the
//length H of each sub-segment and then output the values of a function
//F(X) = 1 − sin(X) at points dividing the segment [A, B]:
//F(A), F(A + H), F(A + 2·H), …, F(B).
namespace for_30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N: ");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("A: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double H = (b - a) / n;


            for (double i = 1; i <= n; i++)
            {
                double x = a + i * H;
                double f = 1 - Math.Sin(x);
                Console.WriteLine($"h: {f}");
            }
        }
    }
}
