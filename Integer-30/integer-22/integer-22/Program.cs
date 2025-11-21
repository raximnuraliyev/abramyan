//Integer22.From the beginning of the day N seconds have passed (N is integer). Find
//an amount of seconds passed from the beginning of the last hour.

namespace integer_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N seconds: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int h = n % 3600;
            Console.WriteLine(h);

        }
    }
}
