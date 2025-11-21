//While12.An integer N (> 1) is given. Find the largest integer K such that the sum
//1 + 2 + … + K is less than or equal to N. Output K and the corresponding sum.

namespace while_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int k = 1;
            int i = 0;
            int count = 0;
            while (i < n)
            {
                i += k;
                k++;
                count++;
            }
            Console.WriteLine($"sum: {i}");
            Console.WriteLine($"K = {count}");
        }
    }
}
