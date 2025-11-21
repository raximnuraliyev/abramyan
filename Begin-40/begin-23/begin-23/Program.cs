//  Begin23.Variables A, B, C are given. Change values of the variables by moving the
//  given value of A into the variable B, the given value of B into the variable C,
//  and the given value of C into the variable A. Output the new values of A, B, C.
namespace begin_23
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
            
            //a = a + b;
            //b = a - b;
            //a = a - b;

            //b = b + c;
            //c = b - c;
            //b = b - c;

            a = a + b + c;
            b = a - b - c;
            c = a - b - c;
            a = a - b - c;

            Console.WriteLine($"a: {a}");
            Console.WriteLine($"b: {b}");
            Console.WriteLine($"c: {c}");
        }
    }
}
