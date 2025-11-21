//While17.Given an integer N (> 0), output all digits of the number N starting from the
//right digit (a ones digit). Use the operators of integer division and taking the
//remainder after integer division.

namespace while_17
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

            while ( n > 0 )
            {
                s = n % 10;
                r = s;
                total += r;
                total *= 10;
                n = n / 10;

            }
            Console.WriteLine($"s = {s}");
            Console.WriteLine($"r: {r}");
            Console.WriteLine($"result: {total/10}");
        }
    }
}
