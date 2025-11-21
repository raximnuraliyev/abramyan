//Begin6.The edges a, b, c of a right parallelepiped are given. Find the volume V = a·b·c and the surface area S = 2·(a·b + b·c + a·c) of the right parallelepiped.
namespace begin_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an edge of a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter an edge of b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter an edge of c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double V = a * b * c;
            Console.WriteLine($"The Volume: {V}");

            double S = 2 * (a * b + b * c + a * c);
            Console.WriteLine($"The Surface: {S}");

        }
    }
}
