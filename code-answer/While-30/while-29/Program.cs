//While29.A real number ε (> 0) is given. A sequence of real numbers AK is defined
//as:
//A1 = 1, A2 = 2, AK = (AK−2 + 2·AK−1)/3, K = 3, 4, … .
//Find the first index K such that the inequality |AK − AK−1| < ε is fulfilled. Output
//the index K and the terms AK−1 and AK.
namespace while_29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("e: ");
            double e = Convert.ToDouble(Console.ReadLine());

            double A_prev2 = 1.0;   // A1
            double A_prev1 = 2.0;   // A2
            double A_k = 0;

            int K = 3;

            while (Math.Abs(A_prev1 - A_prev2) >= e)
            {
                A_k = (A_prev2 + 2 * A_prev1) / 3.0;
                A_prev2 = A_prev1;
                A_prev1 = A_k;

                K++;
            }

            Console.WriteLine("K = " + (K - 1));
            Console.WriteLine("A(K-1) = " + A_prev2);
            Console.WriteLine("A(K) = " + A_prev1);

        }
    }
}
