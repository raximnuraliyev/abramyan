//Boolean21.Given a three-digit integer, verify the following proposition: ―All digits
//of the number are in ascending order ‖

namespace boolean_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("C: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a<b&& b<c);
        }
    }
}
