namespace if_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("C: ");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a < b && b < c)
            {
                a *= 2;
                b *= 2;
                c *= 2;
                Console.WriteLine($"A: {a}, B: {b}, C: {c}");
            }
            else if (a > b && b > c)
            {
                a *= 2;
                b *= 2;
                c *= 2;
                Console.WriteLine($"A: {a}, B: {b}, C: {c}");
            }
            else if((a > b && b < c) || (a < b && b > c))
            {
                a *= -2;
                b *= -2;
                c *= -2;
                Console.WriteLine($"A: {a}, B: {b}, C: {c}");
            }
        }
    }
}
