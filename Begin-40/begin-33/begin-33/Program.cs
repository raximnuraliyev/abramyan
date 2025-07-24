//  Begin33.X kg of sweet cost A euro. Find the cost of 1 kg and Y kg of the sweets
//  (positive numbers X, A, Y are given).
namespace begin_33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, a, y;
            Console.WriteLine("X: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("A: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"{x} kg of sweet cost {a} euro.");
            double kg = a / x;
            Console.WriteLine($"1kg costs {kg} euro");
            double ykg = y * kg;
            Console.WriteLine($"{y}kg cost {ykg} euro");


        }
    }
}
