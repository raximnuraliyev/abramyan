//  Integer12.A three-digit integer is given. Output an integer obtained from the given
//  one by reading it from right to left.
namespace integer_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("three-digit: ");
            int a = Convert.ToInt32(Console.ReadLine());

            int last = a % 10;
            int middle = a % 100 / 10;
            int first = a / 100;
            Console.WriteLine($"last: {last}, middle: {middle},first: {first}");
        }
    }
}
