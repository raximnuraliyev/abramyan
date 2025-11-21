//Boolean15.Given three integers A, B, C, verify the following proposition: ―Exactly
//two of the numbers A, B, C are positive ‖

namespace boolean_15
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

            Console.WriteLine((a % 2 == 0 || b % 2 == 0 || c % 2 != 0) && (a % 2 == 0 || b % 2 != 0 || c % 2 == 0) && (a % 2 != 0 || b % 2 == 0 || c % 2 == 0));
        }
    }
}
