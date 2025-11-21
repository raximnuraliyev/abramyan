//Integer13.A three-digit integer is given. Output an integer obtained from the given
//one by moving its left digit to the right side.

namespace integer_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A: ");
            int a = Convert.ToInt32(Console.ReadLine());

            int b = a / 100;
            int c = (a % 100) / 10;
            int d = a % 10;
            Console.Write(d);
            Console.Write(c);
            Console.Write(b);
        }
    }
}
