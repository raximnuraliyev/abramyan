//Integer11.A three-digit integer is given. Find the sum and the product of its digits.

namespace integer_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A: ");
            int a = Convert.ToInt32(Console.ReadLine());

            int b = (a % 100) / 10;
            int c = a / 100;
            int d = a % 10;
            Console.WriteLine($"{c+b+d}");
            //Console.WriteLine(c);
            //Console.WriteLine(b);
            //Console.WriteLine(d);
        }
    }
}
