//For22.A real number X and an integer N (> 0) are given. Compute the expression
//1 + X + X2/(2!) + … + XN/(N!)
//(N! = 1·2·…·N). The result is an approximate value of exp(X).

namespace for_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("X: ");
            double x = Convert.ToInt32(Console.ReadLine());

            double mult = 1;
            double sign = 1;
            double sum = 1;
            //double result = 1;

            for (double i = 1; i <= n; i++)
            {
                mult *= n;
                sum += mult;
                sign = sign / mult;

                Console.WriteLine(" ");
                Console.WriteLine(sign);
                //Console.WriteLine(result);
                Console.WriteLine(sum);
            }
        }
    }
}
