//While19.An integer N (> 0) is given. Output an integer obtained from the given one
//by reading it from right to left. Use the operators of integer division and taking
//the remainder after integer division.

namespace while_19
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

            while (n > 0)
            {
                s = n % 10;
                r = s;
                total += r;
                total *= 10;
                n = n / 10;

            }
            Console.WriteLine($"result: {total/10}");
        }
    }
}
