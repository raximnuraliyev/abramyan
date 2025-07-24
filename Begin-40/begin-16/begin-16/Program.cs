//Begin16.Two points with the coordinates x1 and x2 are given on the real axis. Find
//the distance between these points: | x2 − x1 |.
namespace begin_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double answer = Math.Abs( x2 - x1);

            Console.WriteLine(answer);
        }
    }
}
