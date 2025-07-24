//Begin2.Given the side a of a square, find the area S of the square: S = a2
namespace begin_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            Console.WriteLine("Enter the side of the square(a): ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("S:" + Math.Pow(a, 2));
        }
    }
}
