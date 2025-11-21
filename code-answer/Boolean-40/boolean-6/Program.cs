//Boolean6.Given three integers A, B, C, verify the following proposition: ―The
//double inequality A < B < C is fulfilled.

namespace boolean_6
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
