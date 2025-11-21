//  Begin21.The coordinates(x1, y1), (x2, y2), (x3, y3) of the triangle vertices are given.
//  Find the perimeter and the area of the triangle using the formula for distance
//  between two points in the plane(see Begin20).The area of a triangle with
//  sides a, b, c can be found by Heron’s formula:
//  S = (p·(p − a)·(p − b)·(p − c))1/2,
//  where p = (a + b + c)/2 is the half-perimeter.

namespace begin_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("x1: ");
            //double x1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("x2: ");
            //double x2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("y1: ");
            //double y1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("y2: ");
            //double y2 = Convert.ToDouble(Console.ReadLine());

            double a, b, c;
            Console.WriteLine("a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("c: ");
            c = Convert.ToDouble(Console.ReadLine());
            double P = (a + b + c) / 2;
            double S = Math.Sqrt(P * (P - a) * (P - b) * (P - c));
            Console.WriteLine("P: " + P);
            Console.WriteLine("S: " + S);
        }
    }
}
