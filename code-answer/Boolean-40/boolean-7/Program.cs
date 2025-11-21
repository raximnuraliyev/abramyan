//Boolean7.Given three integers A, B, C, verify the following proposition: ―The
//number B is between A and C ‖

namespace boolean_7
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

            Console.WriteLine(a<b &&  b<c);
        }
    }
}
