//While5.Given an integer N (> 0) that equals 2 raised to some integer power: N = 2K,
//find the exponent K of the power.

namespace while_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int k = 1;
            //int s = 0;
            while (n >= 2 * k)
            {
                //s *= 2 * k;
                k++;
            }
            Console.WriteLine(k-1);
        }
    }
}
