//If4.Three integers are given. Find the amount of positive integers in the input data.
namespace if_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A: ");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("B: ");
            int b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("C: ");
            int c = Convert.ToInt16(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine($"a: {a}");
            }
            if (b > 0)
            {
                Console.WriteLine($"b: {b}");
            }
            if (c > 0)
            {
                Console.WriteLine($"c: {c}");
            }
        }
    }
}
