//Integer17.An integer greater than 999 is given. Using one operator of integer
//division and one operator of taking the remainder find a hundreds digit of the
//given integer.

namespace integer_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A: ");
            int a = Convert.ToInt32(Console.ReadLine());

            int b = a / 100;
            Console.WriteLine(b);
        }
    }
}
