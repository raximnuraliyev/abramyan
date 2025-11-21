//If19.Four integers are given. One of them differs from three other equal integers.
//Output the order number of the integer that differs from the others.

namespace if_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("C: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("D: ");
            int d = Convert.ToInt32(Console.ReadLine());

            if ((b == c && c == d) && (a != b && a != c && a != d))
            {
                Console.WriteLine($"A is not equal to them: {a}");
            }
            else if ((a == c && c == d) && (b != a && b != c && b != d))
            {
                Console.WriteLine($"B is not equal to them: {b}");
            }
            else if ((a == b && b == d) && (c != a && c != b && c != d))
            {
                Console.WriteLine($"C is not equal to them: {c}");
            }
            else if ((a == b && b == c) && (d != a && d != b && d != c))
            {
                Console.WriteLine($"D is not equal to them: {d}");
            }
            else
            {
                Console.WriteLine("At least one should be different!");
            }
        }
    }
}
