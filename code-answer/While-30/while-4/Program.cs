//While4.An integer N (> 0) is given. If it equals 3 raised to some integer power then
//output True, otherwise output False.

namespace while_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (n >= i * 3)
            {
                i *= 3;
            }
            Console.WriteLine($"n: {n}");
            Console.WriteLine($"i: {i}");
            Console.WriteLine(n == i);
        }
    }
}
