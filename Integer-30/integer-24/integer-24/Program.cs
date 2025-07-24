//Integer24.Days of week are numbered as: 0 — Sunday, 1 — Monday, 2 —
//Tuesday, …, 6 — Saturday. An integer K in the range 1 to 365 is given. Find
//the number of day of week for K-th day of year provided that in this year
//January 1 was Monday.

namespace integer_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("K- from 1 to 365: ");
            int k = Convert.ToInt32(Console.ReadLine());

            int day = k % 7;

            Console.WriteLine($"the {day} of day of week for {k}-th day of 2025 year");

        }
    }
}
