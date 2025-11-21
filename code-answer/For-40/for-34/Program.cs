//For34.An integer N (> 1) is given. A sequence of real numbers AK is defined as:
//A1 = 1, A2 = 2, AK = (AK−2 + 2·AK−1)/3, K = 3, 4, … .
//Output terms A1, A2, …, AN of the sequence.

namespace for_34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N: ");
            double n = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("F: ");
            //double a = Convert.ToDouble(Console.ReadLine());
            //double f = 1;
            double a = 1;
            double b = 2;
            double c = 0;

            for (double i = 1; i <= n - 1; i++)
            {
                c = (a + b*2)/3;
                a = b;
                b = c;
                //Console.WriteLine($"i: {i}");
                Console.WriteLine($"a: {a}");
                //Console.WriteLine($"f: {f}");
                //Console.WriteLine($"k: {k}");
            }
        }
    }
}
