//For21.An integer N (> 0) is given. Using one loop-statement compute the sum
//1 + 1/(1!) + 1/(2!) + 1/(3!) + … + 1/(N!),
//where N! (N–factorial) is the product of all integers in the range 1 to N:
//N! = 1·2·…·N.The result is an approximate value of the constant e = exp(1).

namespace for_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            float mult = 1;
            float sign = 1;
            float sum = 0;
            float result = 1;
            for(float i = 1; i <= n; i++)
            {
                mult *= i;
                sum += mult;
                sign = sign / i;
                result += sign;

                Console.WriteLine(" ");
                Console.WriteLine(sign);
                Console.WriteLine(result);
                Console.WriteLine(sum);
            }

        }
    }
}
