//Boolean19.Verify the following proposition: ―Among three given integers there is
//at least one pair of opposite ones ‖

namespace boolean_19
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
            //a = a % 10;
            //b = b * -1;
            //c = c % 10;
            Console.WriteLine((a % 10 == b * -1 || b * -1 == c % 10 || a * -1 == c % 10)||
                              (a * -1 == b % 10 || b % 10 == c * -1 || a % 10 == c * -1));
        }
    }
}
