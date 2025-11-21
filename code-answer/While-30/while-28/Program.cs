//While28.A real number ε (> 0) is given. A sequence of real numbers AK is defined
//as:
//A1 = 2, AK = 2 + 1 / AK−1, K = 2, 3, … .
//Find the first index K such that the inequality |AK − AK−1| < ε is fulfilled. Output
//the index K and the terms AK−1 and AK.

namespace while_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("e: ");
            double e = Convert.ToDouble(Console.ReadLine());

            double prev = 2;
            double curr = 2 + 1.0 / prev;
            int k = 2;

            while (Math.Abs(curr - prev) >= e)
            {
                prev = curr;
                curr = 2 + 1.0 / prev;
                k++;
            }

            Console.WriteLine("k = " + k);
            Console.WriteLine("a(k-1) = " + prev);
            Console.WriteLine("a(k)   = " + curr);

        }
    }
}
