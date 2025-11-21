//Integer14.A three-digit integer is given. Output an integer obtained from the given
//one by moving its right digit to the left side

namespace integer_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A: ");
            int a = Convert.ToInt32(Console.ReadLine());

            int b = a % 10;
            Console.Write(b);
            int c = (a %100)/10;
            Console.Write(c);
            int d = a / 100;
            Console.Write(d);
        }
    }
}
