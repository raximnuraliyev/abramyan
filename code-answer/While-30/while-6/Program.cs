//While6.Given an integer N (> 0), compute the double factorial of N:
//N!! = N·(N−2)·(N−4)·…,
//where the last factor equals 2 if N is an even number, and 1 otherwise. To
//avoid the integer overflow, compute the double factorial using a real variable
//and output the result as a real number.

namespace while_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double i = 1;
            double s = 1;
            while (n > i*2)
            {
                s *= (n - (i * 2));
                i++;
            }
            Console.WriteLine(s*n);
        }
    }
}
