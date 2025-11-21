//  Begin20.The coordinates(x1, y1) and(x2, y2) of two points are given. Find the
//  distance between the points:
//  ((x2 − x1)2 + (y2 − y1)2)1/2.

namespace begin_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            double answer = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("answer: " + answer);
        }
    }
}
