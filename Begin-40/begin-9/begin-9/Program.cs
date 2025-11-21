//Begin9.Given two nonnegative numbers a and b, find their geometrical mean (a square root of their product): (a·b)1/2.
namespace begin_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("B:");
            double b = Convert.ToDouble(Console.ReadLine());

            double gMean = (a * b);
            double gp = Math.Pow(gMean, 1 / 2);
            Console.WriteLine($"mean: {gMean * gp}");
        }
    }
}
// FAILED