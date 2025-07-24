//  Begin25.Given an independent variable x, find the value of a function
//  y = 3x6 − 6x2 − 7.
namespace begin_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = (3 * Math.Pow(x,6)) - (6 * Math.Pow(x,2)) - 7;
            Console.WriteLine(y);
        }
    }
}
