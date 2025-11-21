//If8.Given two real numbers, output the larger value and then the smaller value of
//them.
namespace if_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine($"{a} {b}");
            }
            else
            {
                Console.WriteLine($"{b} {a}");
            }
        }
    }
}
