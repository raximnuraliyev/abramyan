//If21.Integer coordinates of a point in the coordinate plane are given. If the point
//coincides with the origin of coordinates then output 0, otherwise if the point14
//lies on the x-axis or y-axis then output 1 or 2 respectively. If the point does not
//lie on the coordinate axes then output 3.

namespace if_21
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
            else if (x > 0 && y == 0)
            {
                Console.WriteLine("1");
            }
            else if (x == 0 && y < 0)
            {
                Console.WriteLine("2");
            }
            else if (x >= 0 && y >= 0)
            {
                Console.WriteLine("3");
            }
            else
            {
                Console.WriteLine("error!!!");
            }
        }
    }
}
