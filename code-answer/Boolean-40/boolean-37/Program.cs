//Boolean37.Given coordinates x1, y1, x2, y2 of two chessboard squares (as integers in
//the range 1 to 8), verify the following proposition: ―A king can move from one
//square to another during one turn ‖

namespace boolean_37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            int dx = Math.Abs(x1 - x2);
            int dy = Math.Abs(y1 - y2);
            Console.WriteLine((dx <= 1)&&(dy <= 1));

        }
    }
}
