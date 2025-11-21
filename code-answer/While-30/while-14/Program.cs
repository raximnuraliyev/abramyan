//While14.A real number A (> 1) is given. Find the largest integer K such that the sum
//1 + 1/2 + … + 1/K is less than A. Output K and the corresponding sum

namespace while_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            double k = 0;
            double s = 0;
            double i = 1;

            while (s + 1 / (k + 1) < a)
            {
                k++;
                s += i / k;
            }
            Console.WriteLine($"k: {k}");
            Console.WriteLine($"s = {s}");
        }
    }
}
