namespace boolean_39
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
            Console.WriteLine();
            Console.WriteLine((((x1 % 2 == 0) != (x2 % 2 == 0)) || ((x1 % 2 != 0) != (x2 % 2 != 0))) && (((y1 % 2 == 0) != (y2 % 2 == 0)) || ((y1 % 2 != 0) != (y2 % 2 != 0))) || (Math.Abs(x1 - x2)) == (Math.Abs(y1 - y2)));
        }
    }
}
