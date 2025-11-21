//Begin3.The sides a and b of a rectangle are given. Find the area S = a·b and the perimeter P = 2·(a + b) of the rectangle.
namespace begin_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of side a of the rectangle: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the length of side b of the rectangle: ");
            double b = Convert.ToDouble(Console.ReadLine());
            
            double area = a * b;
            Console.WriteLine($"The area of the rectangle is: {area}");

            double perimeter = 2 * (a + b);
            Console.WriteLine($"The perimeter of the rectangle is: {perimeter}");

            Console.WriteLine("Press any key to exit.");

        }
    }
}
