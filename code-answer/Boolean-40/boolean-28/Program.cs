//Boolean28.Given two real numbers x, y, verify the following proposition: ―The
//point with coordinates (x, y) is in the first or third coordinate quarter‖
namespace boolean_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("X: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((x > 0 && y > 0) || (x < 0 && y < 0));

        }
    }
}
