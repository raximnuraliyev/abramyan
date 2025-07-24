//Begin5.Given the edge a of a cube, find the volume V = a3 and the surface area S = 6·a2 of the cube.
namespace begin_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an edge of a cube (a): ");
            double a = Convert.ToDouble(Console.ReadLine());

            double V = a * 3;
            Console.WriteLine($"The Volume: {V}");

            //Console.WriteLine("Enter the surface of an area(b): ");

            double S = 6 * Math.Pow(a, 2);
            Console.WriteLine($"The Surface: {S}");
        }
    }
}
