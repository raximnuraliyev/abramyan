//Begin8.Given two numbers a and b, find their average: (a + b) / 2
namespace begin_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("B:");
            double b = Convert.ToDouble(Console.ReadLine());

            double average = (a + b) / 2;
            Console.WriteLine($"The average: {average}");
        }
    }
}
