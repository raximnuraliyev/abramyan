//  Begin29.The angle value α in degrees (0 ≤ α < 360) is given. Convert this value into
//  radians. Take into account that 180° = π radians. Use 3.14 for a value of π.
using System.Drawing;
using System.Runtime.CompilerServices;

namespace begin_29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("A: ");
            double a = Convert.ToDouble(Console.ReadLine());

            //angle = (0 < a < 360);
            double pi = 3.14;
            double radians = 180;

            double answer = (pi * a) / radians;
            Console.WriteLine("answer: " + answer);
        }
    }
}
