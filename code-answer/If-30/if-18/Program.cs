//If18.Three integers are given. One of them differs from two other equal integers.
//Output the order number of the integer that differs from the others.

// a = 2, b = 2, c = 3, output the c


namespace if_18
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
            if (b == c && a != b && a != c)
            {
                Console.WriteLine($"A is not equal to them: {a}");
            }
            else if (a == c && b != a && b != c)
            {
                Console.WriteLine($"B is not equal to them: {b}");
            }
            else if (a == b && c != a && c != b)
            {
                Console.WriteLine($"C is not equal to them: {c}");
            }
        }
    }
}
