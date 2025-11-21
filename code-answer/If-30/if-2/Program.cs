//If2.An integer is given. If the integer is positive then increase it by 1, otherwise
//decrease it by 2. Output the obtained integer.
namespace if_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A: ");
            int a = Convert.ToInt16(Console.ReadLine());
            if (a > 0)
            {
                a++;
            }
            else
            {
                a = a - 2;
            }
            Console.WriteLine(a);
        }
    }
}
