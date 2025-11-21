//While24.An integer N (> 1) is given. An integer-valued sequence of the Fibonacci
//numbers FK is defined as:
//F1 = 1, F2 = 1, FK = FK−2 + FK−1, K = 3, 4, … .
//Determine whether N is a Fibonacci number or not, and output True or False
//respectively.
namespace while_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 1;
            int b = 1;

            while (b < n)
            {
                int temp = b;
                b = a + b;
                a = temp;
            }
            Console.WriteLine($"answer: {b == n}");
        }
    }
}
