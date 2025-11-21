//Integer12.A three-digit integer is given. Output an integer obtained from the given
//one by reading it from right to left

namespace integer_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = a % 10;
            int c = (a % 100) / 10;
            int d = a / 100;
            Console.Write(b);
            Console.Write(c);
            Console.Write(d);

        }
    }
}
