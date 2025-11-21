//For20.An integer N (> 0) is given. Using one loop-statement compute the sum
//1! + 2! + 3! + … + N!,
//where N! (N–factorial) is the product of all integers in the range 1 to N:
//N! = 1·2·…·N.To avoid the integer overflow, compute the sum using real
//variables and output the result as a real number

namespace for_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            double mult = 1;

            for (double i = 1; i <= n; i++)
            {
                mult *= i;
                sum += mult;

                Console.WriteLine($"sum {sum}");
            }
        }
    }
}
