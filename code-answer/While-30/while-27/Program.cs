//While27.Given an integer N (> 1) that is a Fibonacci number: N = FK, find its order
//number K (see the Fibonacci numbers definition in While24).

namespace while_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 1;
            int b = 1;
            int k = 2;

            while (b < n)
            {
                int temp = b;
                b = a + b;
                a = temp;
                k++;
            }
            Console.WriteLine(b);
            Console.WriteLine(k);

        }
    }
}
