//While11.An integer N (> 1) is given. Find the smallest integer K such that the sum
//1 + 2 + … + K is greater than or equal to N. Output K and the corresponding
//sum.

namespace while_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int k = 1;
            int i = 0;
            while (n >= k)
            {
                i += k;
                k++;
            }
            Console.WriteLine(i);
        }
    }
}
