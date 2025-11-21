//If24.Given a real independent variable x, find the value of a real function f defined
//as:

//f(x) = 2·sin(x), if x > 0,
//6 − x, if x ≤ 0.

namespace if_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("X1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            double f;
            double f2;
            f = 2 * Math.Sin(x1);
            f2 = 6 - x1;
            if (x1 > 0)
            {
                f = 2 * Math.Sin(x1);
                Console.WriteLine(f);
            }
            else if (x1 <= 0)
            {
                f2 = 6 - x1;
                Console.WriteLine(f2);
            }
        }
    }
}
