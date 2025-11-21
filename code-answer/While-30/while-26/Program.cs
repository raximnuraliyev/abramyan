//While26.Given an integer N (> 1) that is a Fibonacci number: N = FK, output
//previous and next Fibonacci numbers: FK−1 and FK+1 (see the Fibonacci
//numbers definition in While24).
namespace while_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 1;
            int b = 1;

            while (b < n)
            {
                int temp = b;
                b = a + b;
                a = temp;
            }
            int next = b + a;
            Console.WriteLine(a);
            Console.WriteLine(next);

        }
    }
}
