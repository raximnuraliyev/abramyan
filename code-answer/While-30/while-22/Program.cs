//While22.An integer N (> 1) is given. If it is a prime number, i. e., it has not positive
//divisors except 1 and itself, then output True, otherwise output False.
namespace while_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 2;
            bool boolian = true;

            while (i < n && boolian)
            {
                boolian = n % i != 0;
                i++;
            }
            Console.WriteLine($"answer: {boolian}");
        }
    }
}
