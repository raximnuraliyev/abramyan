//Integer8.A two-digit integer is given. Output an integer obtained from the given one
//by exchange of its digits.

namespace integer_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A: ");
            int a = Convert.ToInt32(Console.ReadLine());

            int b = (a % 100)/10;
            Console.WriteLine(b);
            int c = a % 10;
            Console.WriteLine(c);
            Console.WriteLine($"exchange: {c}{b}");
        }
    }
}
