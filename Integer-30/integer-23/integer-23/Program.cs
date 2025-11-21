//Integer23.From the beginning of the day N seconds have passed (N is integer). Find
//an amount of full minutes passed from the beginning of the last hour.

namespace integer_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N seconds: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int m = n % 3600 / 60;
            Console.WriteLine(m);

        }
    }
}
