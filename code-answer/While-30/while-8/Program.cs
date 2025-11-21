//While8.Given an integer N (> 0), find the largest integer K such that its square is not
//greater than N: K2 ≤ N. Do not use the operation of extracting a root.

namespace while_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int k = 1;
            while ((k * k)+1 < n)
            {
                k++;
            }
            Console.WriteLine(k);
        }
    }
}
