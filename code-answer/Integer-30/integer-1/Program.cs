//Integer1.A distance L is given in centimeters. Find the amount of full meters of this
//distance (1 m = 1000 cm). Use the operator of integer division.

namespace integer_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("L: ");
            int l = Convert.ToInt32(Console.ReadLine());
            int m = l / 100;
            Console.WriteLine(m);
        }
    }
}
