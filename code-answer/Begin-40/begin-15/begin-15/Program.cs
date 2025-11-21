//  Begin15.Given the area S of a circle, find the diameter D and the length L of the
//  circumference. Take into account that L = π·D, S = π·D2/4. Use 3.14 for a
//  value of π.
namespace begin_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            double pi = 3.14;
            double D = Convert.ToDouble(Console.ReadLine());
            double L = pi * D;
            Console.WriteLine($"L: {L}");
            double S = pi * Math.Pow(D, 2)/4;
            Console.WriteLine($"S: {S}");



        }
    }
}
