//Boolean10.Given two integers A and B, verify the following proposition: ―Exactly
//one of the numbers A and B is odd ‖

namespace boolean_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((a % 2 == 0 || b % 2 != 0) || (a % 2 != 0 || b % 2 == 0));

        }
    }
}
