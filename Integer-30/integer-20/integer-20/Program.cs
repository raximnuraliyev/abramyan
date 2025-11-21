//  Integer20.From the beginning of the day N seconds have passed (N is integer). Find
//  an amount of full hours passed from the beginning of the day.

namespace integer_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N seconds: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int h = n / 3600;
            //int h = n / 60 / 60;
            Console.Write(h);
        }
    }
}
