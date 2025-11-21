//Boolean33.Given three integers a, b, c, verify the following proposition: ―A triangle
//with the sides a, b, c exists‖

namespace boolean_33
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
            Console.WriteLine((a*a) == ((b*b)+(c*c)));
        }
    }
}
