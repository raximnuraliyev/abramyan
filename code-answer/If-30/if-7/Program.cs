//If7.Given two real numbers, output the order number of the smaller of them.

namespace if_7;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("A: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("B: ");
        int b = Convert.ToInt32(Console.ReadLine());
        if (a > b)
        {
            Console.WriteLine($"{b} {a}");
        }
        else
        {
            Console.WriteLine($"{a} {b}");
        }
    }
}
