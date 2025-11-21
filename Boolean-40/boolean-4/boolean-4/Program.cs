//Boolean4.Given two integers A and B, verify the following proposition: ―The
//inequalities A > 2 and B ≤ 3 both are fulfilled‖.

namespace boolean_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if (a>2 && b <= 3)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
