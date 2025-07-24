//  Begin22.Exchange the values of two given variables A and B. Output the new
//  values of A and B.

namespace begin_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("A:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("B:");
            double b = Convert.ToDouble(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"a: {a}");
            Console.WriteLine($"b: {b}");
        }
    }
}
