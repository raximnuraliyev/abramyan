//  Begin40.Solve a system of linear equations
//  A1·x + B1·y = C1,
//  A2·x + B2·y = C2
//  with given coefficients A1, B1, C1, A2, B2, C2 provided that the system has the
//  only solution. Use the following formulas:
//  x = (C1·B2 − C2·B1)/D, y = (A1·C2 − A2·C1)/D,
//  where D = A1·B2 − A2·B1.

namespace begin_40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A1, B1, C1, A2, B2, C2, x, y, d;

            Console.Write("A1: ");
            A1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("A2: ");
            A2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("B1: ");
            B1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("B2: ");
            B2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("C1: ");
            C1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("C2: ");
            C2 = Convert.ToDouble(Console.ReadLine());

            d = A1 * B2 - A2 * B1;
            Console.WriteLine(d);
            x = (C1 * B2 - C2 * B2) / d;
            Console.WriteLine(x);
            y = (A1 * C2 - A2 * C1) / d;
            Console.WriteLine(y);
        }
    }
}
