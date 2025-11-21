//If20.Three points A, B, C on the real axis are given. Determine whether B or C is
//closer to A. Output the nearest point and its distance from A.

namespace if_20
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


            if (b > a && c > b)
            {
                Console.WriteLine($"B: {b} is close to {a}");
            }
            else if (c > a && b > c)
            {
                Console.WriteLine($"C: {c} is close to {a}");
            }
            else if (c < b)
            {
                Console.WriteLine($"B: {b} is close to {a}");
            }
            else if (c > b)
            {
                Console.WriteLine($"C: {c} is close to {a}");
            }
            else if (a == c && b == a)
            {
                Console.WriteLine($"C: {c} and B: {b} is equal to {a}");
            }
        }
    }
}
