//  Begin12.The legs a and b of a right triangle are given. Find the hypotenuse c and the
//  perimeter P of the triangle:
//  c = (a2 + b2)1 / 2, P = a + b + c.

namespace begin_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("b: ");
            double b = double.Parse(Console.ReadLine());
            
            double c = Math.Sqrt((Math.Pow(a,2) + Math.Pow(b,2)));
            Console.WriteLine(c);

            double P = a + b + c;
            Console.WriteLine(P);
        }
    }
}
