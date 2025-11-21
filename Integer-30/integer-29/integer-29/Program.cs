//Integer29.Three positive integers A, B, C are given. A rectangle of the size A × B
//contains the greatest possible amount of inside squares with the side length C
//(without overlaps). Find the amount of squares placed on the rectangle and the
//area of unused part of the rectangle.

namespace integer_29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D;
            A = Convert.ToInt32(Console.ReadLine());
            B = Convert.ToInt32(Console.ReadLine());
            C = Convert.ToInt32(Console.ReadLine());
            D = (A * B) / (C * C);
            Console.WriteLine(D);
        }
    }
}
