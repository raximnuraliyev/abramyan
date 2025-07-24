// Integer7.A two-digit integer is given. Find the sum and the product of its digits.
namespace integer_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Two-digit integer: ");
            int tdi = Convert.ToInt32(Console.ReadLine());

            int c = tdi / 10;
            int b = tdi % 10;

            Console.WriteLine($"sum: {b+c}");
            Console.WriteLine($"work: {b*c}");


            


        }
    }
}
