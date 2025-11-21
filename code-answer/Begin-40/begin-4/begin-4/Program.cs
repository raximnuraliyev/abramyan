//Begin4.Given the diameter d of a circle, find the length L of the circle: L = π·d.Use 3.14 for a value of π.
namespace begin_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a diameter: ");
            double diameter = Convert.ToDouble(Console.ReadLine());
            
            double pi = 3.14;

            double length = pi * diameter;

            Console.WriteLine($"Answer: {length}");
            
        }
    }
}
