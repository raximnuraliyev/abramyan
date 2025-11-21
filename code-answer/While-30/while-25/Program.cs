//While25.Given an integer N (> 1), find the first Fibonacci number greater than N
//(see the Fibonacci numbers definition in While24)
namespace while_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 1;
            int b = 1;

            while (b <= n)
            {
                int temp = b;
                b = a + b;
                a = temp;
            }
            //Console.WriteLine($"answer: {b == n}");
            Console.WriteLine(b);
        }
    }
}
