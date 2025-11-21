//  Integer9.A three-digit integer is given. Using one operator of integer division find
//  first digit of the given integer (a hundreds digit).
namespace integer_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int three_digit = Convert.ToInt32 (Console.ReadLine());

            int a = three_digit / 100;
            Console.WriteLine(a);
        }
    }
}
