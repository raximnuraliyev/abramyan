//  Begin28.Given a number A, compute a power A15 using five multiplying operators
//  for computing A2, A3, A5, A10, A15 sequentially. Output all obtained powers of
//  the number A.
namespace begin_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("A: ");
            double a = Convert.ToDouble(Console.ReadLine());

            a = Math.Pow(a, 2);
            Console.WriteLine("a2: " + a);
            a = Math.Pow(a, 3);
            Console.WriteLine("a3: " + a);
            a = Math.Pow(a, 5);
            Console.WriteLine("a5: " + a);
            a = Math.Pow(a, 10);
            Console.WriteLine("a10: " + a);
            a = Math.Pow(a, 15);
            Console.WriteLine("a15: " + a);
        }
    }
}
