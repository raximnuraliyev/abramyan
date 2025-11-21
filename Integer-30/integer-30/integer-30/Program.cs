//Integer30.Given a year (as a positive integer), find the respective number of the
//century. Note that, for example, 20th century began with the year 1901.

namespace integer_30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = (a / 100) + 1;
            Console.WriteLine(b);
        }
    }
}
