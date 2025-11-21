namespace for_38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N: ");
            double n = Convert.ToDouble(Console.ReadLine());

            double eq = 0;
            double s = 0;

            for (double i = 1; i <= n; i++)
            {
                eq = i;
                for (double j = n; j >= 1; j--)
                {
                    eq *= i;
                    Console.WriteLine($"iteration: {eq}");
                }
                s += eq;
            }
            Console.WriteLine($"answer: {s}");
        }
    }
}
