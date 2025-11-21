//Integer26.Days of week are numbered as: 1 — Monday, 2 — Tuesday, …, 6 —
//Saturday, 7 — Sunday. An integer K in the range 1 to 365 is given. Find the10
//number of day of week for K-th day of year provided that in this year
//January 1 was Tuesday
namespace integer_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = (a + 1) % 7;
            Console.WriteLine(b);
        }
    }
}
