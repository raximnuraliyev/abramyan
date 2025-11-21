//For19.Given an integer N (> 0), find the value of a following product:
//N! = 1·2·…·N
//(N–factorial).To avoid the integer overflow, compute the product using a real
//variable and output the result as a real number

namespace for_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double sum = 0;

            for (double i = 0; i <= n; i++)
            {
                sum += i;
                sum *= sum;
                Console.WriteLine(sum);
            }
        }
    }
}
