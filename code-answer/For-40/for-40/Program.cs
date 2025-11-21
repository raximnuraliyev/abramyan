//For40.Integers A and B (A < B) are given. Output all integers in the range A to B,
//with the number A being output once, the number A + 1 being output twice,
//and so on.

namespace for_40
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

            // n - 5
            //1 * 1 * 1 * 1 * 1
            //2 * 2 * 2 * 2
            //3 * 3 * 3
            //4 * 4
            //5

            for (double i = a; i <= b; i++)
            {
                k = i - a + 1;
                for (double j = 1; j <= k; j++)
                {

                    //Console.WriteLine($"* {k} ");
                    Console.WriteLine($"* {i} ");
                    //Console.WriteLine($" ");
                }
            }
        }
    }
}
