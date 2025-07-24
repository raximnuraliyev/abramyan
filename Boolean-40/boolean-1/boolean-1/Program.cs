//Boolean1.Given integer A, verify the following proposition: ―The number A is
//positive‖.

namespace boolean_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            };

        }
    }
}
