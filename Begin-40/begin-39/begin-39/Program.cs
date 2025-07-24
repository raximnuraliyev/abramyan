//  Begin39.Solve a quadratic equation A·x2 + B·x + C = 0 with given coefficients A, B,
//  C (A and the discriminant of the equation are positive). Output the smaller
//  equation root and then the larger one. Roots of the quadratic equation may be
//  found by formula
//  x1, 2 = (−B ± (D)1/2)/(2·A),
//  where D = B2 − 4·A·C is a discriminant.
namespace begin_39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c,x1,x2,D;
            Console.Write("A:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("B:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("C:");
            c = Convert.ToDouble(Console.ReadLine());

            D = Math.Pow(b,2) - 4 * a * c;
            x1 = ((-1) * b + Math.Sqrt(D)) / (2 * a);
            x2 = ((-1) * b - Math.Sqrt(D)) / (2 * a);

            Console.WriteLine($"x1: {x1}");
            Console.WriteLine($"x2: {x2}");
            // not solved
        }
    }
}
