//Boolean13.Given three integers A, B, C, verify the following proposition: ―At least
//one of the numbers A, B, C is positive‖

namespace boolean_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("C: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((a % 2 == 0 || b % 2 == 0 || c % 2 != 0)|| (a % 2 == 0 || b % 2 != 0 || c % 2 == 0) || (a % 2 != 0 || b % 2 == 0 || c % 2 == 0));
        }
    }
}
