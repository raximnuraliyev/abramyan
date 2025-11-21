//If25.Given an integer independent variable x, find the value of an integer function f
//defined as:
//f(x) = 2·x, if x < −2 or x > 2,
//−3·x otherwise.

namespace if_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x: ");
            int x = Convert.ToInt32(Console.ReadLine());
             
            if(x < -2 || x > 2)
            {
                int f = 2 * x;
                Console.WriteLine(f);
            }
            else
            {
                int f = -3 * x;
                Console.WriteLine(f);
            }
        }
    }
}
