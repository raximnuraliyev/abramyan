//For12.Given an integer N (> 0), find the value of a following product of N factors:
//1.1 · 1.2 · 1.3 · … .


namespace for_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            double sum = 1;
            double reminder;
            for (double i = 1; i <= n; i++)
            {
                reminder = ((i / 10)+1);
                sum *= reminder;

                Console.WriteLine(" ");
                Console.WriteLine($"i: {i}");
                Console.WriteLine($"sum: {sum}");
                Console.WriteLine($"reminder: {reminder}");
                Console.WriteLine($"n: {n}");
            }
        }
    }
}