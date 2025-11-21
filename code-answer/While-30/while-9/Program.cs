//While9.Given an integer N (> 1), find the smallest integer K such that the inequality
//3K > N is fulfilled.

namespace while_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int k = 1;
            int i = 0;
            while (n > k)
            {
                k *= 3;
                i++;
            }
            Console.WriteLine(i);
        }
    }
}
