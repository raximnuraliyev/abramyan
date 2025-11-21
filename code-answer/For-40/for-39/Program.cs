//For39.Positive integers A and B (A < B) are given. Output all integers in the range A
//to B, with an integer of a value K being output K times (for example, the
//number 3 must be output 3 times).

namespace for_39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double k = 0;

            //a < b
            // a = 2
            // b = 4
            //2
            //2
            //2
            //3
            //3
            //3
            //4
            //4
            //4
            //4

            for (double i = a; i <= b; i++)
            {
                k = i;
                for (double j = 1; j <= i; j++)
                {
                    Console.WriteLine($"iteration: {k}");
                    Console.WriteLine($" ");
                }
            }
        }
    }
}
