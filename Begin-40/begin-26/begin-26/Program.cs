//  Begin26.Given an independent variable x, find the value of a function
//  y = 4(x−3)6 − 7(x−3)3 + 2.
namespace begin_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Math.Pow(4 * (x - 3), 6) - Math.Pow((x - 3), 3) + 2;
            Console.WriteLine(y);
        }
    }
}
