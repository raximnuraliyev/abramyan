//Boolean18.Verify the following proposition: ―Among three given integers there is
//at least one pair of equal ones ‖

namespace boolean_18
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
            Console.WriteLine((a == b)|| (a == c) || (b == c));
        }
    }
}
