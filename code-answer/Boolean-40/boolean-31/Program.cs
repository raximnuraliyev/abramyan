//Boolean31.Given three integers a, b, c that are the sides of a triangle, verify the
//following proposition: ―The triangle with sides a, b, c is isosceles‖

namespace boolean_31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("C: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a == b && a == c && b == c);

        }
    }
}
