//Boolean6.Given three integers A, B, C, verify the following proposition: ―The
//double inequality A < B < C is fulfilled‖.
namespace boolean_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if (a < b && b < c)
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
