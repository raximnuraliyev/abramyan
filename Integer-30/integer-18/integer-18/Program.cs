//  Integer18.An integer greater than 999 is given. Using one operator of integer
//  division and one operator of taking the remainder find a thousands digit of the
//  given integer.

namespace integer_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("four digits: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int r = (a % 10000)/1000;
            Console.WriteLine(r);


        }
    }
}
