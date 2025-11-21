namespace if_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("X1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("X2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("X3: ");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y3: ");
            int y3 = Convert.ToInt32(Console.ReadLine());
            int x = 0;
            int y = 0;

            if (x1 >= x2 && x1 >= x3)
            {
                x = x1;
                Console.WriteLine($"x1 is the unique: {x1} so x of missing point {x}");
            }
            else if (x2 >= x1 && x2 >= x3)
            {
                x = x2;
                Console.WriteLine($"x2 is the unique: {x2} so x of missing point {x}");
            }
            else if (x3 >= x2 && x3 >= x1)
            {
                x = x3;
                Console.WriteLine($"x3 is the unique: {x3} so x of missing point {x}");
            }
            if (y1 >= y2 && y1 >= y3)
            {
                y = y1;
                Console.WriteLine($"y1 is the unique: {y1} so x of missing point {y}");
            }
            else if (y2 >= y1 && y2 >= y3)
            {
                y = y2;
                Console.WriteLine($"y2 is the unique: {y2} so x of missing point {y}");
            }
            else if (y3 >= y2 && y3 >= y1)
            {
                y = y3;
                Console.WriteLine($"y3 is the unique: {y3} so x of missing point {y}");
            }
            Console.WriteLine($"missing vertex ({x},{y})");
        }
    }
}
