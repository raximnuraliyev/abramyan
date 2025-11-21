//Boolean34.Given coordinates x, y of a chessboard square (as integers in the range 1
//to 8), verify the following proposition: ―The chessboard square (x, y) is white‖.
//Note that the left bottom square (1, 1) is black

namespace boolean_34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(((x % 2 != 0) && (y % 2 == 0)) || ((x % 2 == 0) && (y % 2 != 0)));
        }
    }
}
