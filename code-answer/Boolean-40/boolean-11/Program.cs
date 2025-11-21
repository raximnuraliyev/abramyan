//Boolean11.Given two integers A and B, verify the following proposition: ―The
//numbers A and B have equal parity ‖

namespace boolean_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(a == b);

        }
    }
}
