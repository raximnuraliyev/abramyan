//  Begin24.Variables A, B, C are given. Change values of the variables by moving the
//  given value of A into the variable C, the given value of C into the variable B,
//  and the given value of B into the variable A. Output the new values of A, B, C.

namespace begin_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.Write("a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c: ");
            c = Convert.ToDouble(Console.ReadLine());

            a = a + b + c;
            c = a - b - c;
            b = a - b - c;
            a = a - b - c;

            Console.WriteLine($"a: {a}");
            Console.WriteLine($"b: {b}");
            Console.WriteLine($"c: {c}");
        }
    }
}
