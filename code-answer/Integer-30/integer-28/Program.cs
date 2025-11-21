//Integer28.Days of week are numbered as: 1 — Monday, 2 — Tuesday, …, 6 —
//Saturday, 7 — Sunday. An integer K in the range 1 to 365 and an integer N in
//the range 1 to 7 are given. Find the number of day of week for K-th day of year
//provided that in this year January 1 was N-th day of week.

namespace integer_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("K (1-365): ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("N (1-7): ");
            int n = Convert.ToInt32(Console.ReadLine());
            n = n - 1;
            int b = (a + n) % 8;
            Console.WriteLine(b);
        }
    }
}
