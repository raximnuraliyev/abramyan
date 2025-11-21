//  Begin27.Given a number A, compute a power A8 using three multiplying operators
//  for computing A2, A4, A8 sequentially. Output all obtained powers of the
//  number A.
namespace begin_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("A: ");
            double a = Convert.ToDouble(Console.ReadLine());

            a = Math.Pow(a, 2);
            Console.WriteLine("A2: " + a);
            a = Math.Pow(a, 4);
            Console.WriteLine("A4: " + a);
            a = Math.Pow(a, 8);
            Console.WriteLine("A8: "+a);
        }
    }
}
