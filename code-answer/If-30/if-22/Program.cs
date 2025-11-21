//If22.Given coordinates of a point that does not lie on the coordinate axes, find the
//number of a coordinate quarter containing the point.

namespace if_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("X: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x == 0 && y == 0)
            {
                Console.WriteLine("0");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("1");
            }
            else if (x <= 0 && y >= 0)
            {
                Console.WriteLine("2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("3");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("4");
            }
            else
            {
                Console.WriteLine("error!!!");
            }
        }
    }
}
