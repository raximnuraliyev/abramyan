//Boolean5.Given two integers A and B, verify the following proposition: ―The
//inequality A ≥ 0 is fulfilled or the inequality B < −2 is fulfilled‖.

namespace boolean_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(a >= 0 || b < -2);
        }
    }
}
