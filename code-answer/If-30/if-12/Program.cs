//If12.Given three real numbers, output the minimal value of them.
// min = 0;
// check each and print the min

namespace if_12
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
            int mn = int.MaxValue;
            
            if (a < mn)
            {
                mn = a;
            }
            if (b < mn)
            {
                mn = b;
            }
            if (c < mn)
            {
                mn = c;
            }
            Console.WriteLine(mn);
        }
    }
}
