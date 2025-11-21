//  Begin34.X kg of chocolates cost A euro and Y kg of sugar candies cost B euro
//  (positive numbers X, A, Y, B are given). Find the cost of 1 kg of the chocolates
//  and the cost of 1 kg of the sugar candies. Also determine how many times the
//  chocolates are more expensive than the sugar candies.

namespace begin_34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, a, y, b;
            Console.Write("X for kg of chocolates: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("A (euro) for cost of chocolates: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y for kg of sugar candies: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y (euro) for cost of sugar candies: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{x} kg of chocolates cost {a} euro and {y} kg of sugar candies cost {b} euro");

            double kg_of_chocolates = a / x;
            Console.WriteLine($"{x} kg costs {kg_of_chocolates} euro per kg");
            double kg_of_sugar_candies = b / y;
            Console.WriteLine($"{y}kg cost {kg_of_sugar_candies} euro per kg");

            double d = kg_of_chocolates / kg_of_sugar_candies;
            Console.WriteLine($"Chocolates are {d} times more expensive than the sugar candies");
        }
    }
}
