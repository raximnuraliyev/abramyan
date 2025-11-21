//Integer20.From the beginning of the day N seconds have passed (N is integer). Find
//an amount of full hours passed from the beginning of the day
namespace integer_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int m = a / 3600;
            Console.WriteLine(m);
        }
    }
}
