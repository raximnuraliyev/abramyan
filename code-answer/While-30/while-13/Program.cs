//While13.A real number A (> 1) is given. Find the smallest doubleeger K such that the
//sum 1 + 1/2 + … + 1/K is greater than A. Output K and the corresponding sum.

namespace while_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            double k = 1;
            double i = 1;
            double s = 1;
            while (s < a)
            {
                k++;
                s += (i/k);
            }
            //Console.WriteLine($"sum: {i}");
            Console.WriteLine($"s = {s}");
        }
    }
}
