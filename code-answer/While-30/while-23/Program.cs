//While23.Two positive integers A and B are given. Find their greatest common
//divisor (GCD) using the Euclidean algorithm:
//GCD(A, B) = GCD(B, A mod B), if B ≠ 0; GCD(A, 0) = A,
//where ―mod‖ denotes the operator of taking the remainder after integer
//division.

namespace while_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int i = 0;

            while (b != 0)
            {
                i = b;
                b = a % b;
                a = i;
            }
            Console.WriteLine($"answer: {a}");
        }
    }
}
