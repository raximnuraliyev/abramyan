/*      Begin7. Given the radius R of a circle, find the length L of the circumference and the area S of the circle:
                                    L = 2·π·R, S = π·R2.   Use 3.14 for a value of π.  
*/
namespace begin_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Radius: ");
            double R = Convert.ToDouble(Console.ReadLine());

            double pi = 3.14;
            double L = 2 * pi * R;
            Console.WriteLine($"The length of the circumference: {L}");

            double S = pi * Math.Pow(R, 2);
            Console.WriteLine($"The area of the circle: {S}");
        }
    }
}
