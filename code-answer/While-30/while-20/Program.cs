//While20.An integer N (> 0) is given. Determine whether its decimal representation
//contains a digit ‖2‖ or not, and output True or False respectively. Use the
//operators of integer division and taking the remainder after integer division.

namespace while_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            int r = 0;
            int total = 0;
            bool boolian = false;

            while (n > 0)
            {
                s = n % 10;
                boolian = s == 2 || true;
                r = s;
                total += r;
                total *= 10;
                n = n / 10;

            }
            Console.WriteLine($"result: {total / 10}");
            Console.WriteLine($"answer: {boolian}");
        }
    }
}
