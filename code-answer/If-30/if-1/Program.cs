//If1.An integer is given. If the integer is positive then increase it by 1, otherwise do
//not change it. Output the obtained integer.
namespace if_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A: ");
            int a = Convert.ToInt16(Console.ReadLine());
            if (a > 1)
            {
                a++;
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(a);
            }
        }
    }
}
