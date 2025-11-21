//Boolean29.Given real numbers x, y, x1, y1, x2, y2, verify the following proposition:
//―The point(x, y) is inside of the rectangle whose left top vertex is (x1, y1), right
//bottom vertex is (x2, y2), and sides are parallel to coordinate axes‖

namespace boolean_29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("X1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("X2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("X: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((x1 < x && x2 > x)&& (y1 > y && y2 < y));
        }
    }
}
