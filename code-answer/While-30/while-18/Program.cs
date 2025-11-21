//While18.Given an integer N (> 0), find the amount and the sum of its digits. Use the
//operators of integer division and taking the remainder after integer division.
namespace while_18
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
                n = n / 10;

            }
            Console.WriteLine($"result: {total}");
        }
    }
}
