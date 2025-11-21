//Boolean17.Given a positive integer, verify the following proposition: ―The integer
//is a three-digit odd number‖

namespace boolean_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A:");
            int a = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine(a % 2 != 0);
        }
    }
}
