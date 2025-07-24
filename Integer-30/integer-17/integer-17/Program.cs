//  Integer17.An integer greater than 999 is given. Using one operator of integer
//  division and one operator of taking the remainder find a hundreds digit of the
//  given integer.

namespace integer_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("four digit: ");
            int a = Convert.ToInt32(Console.ReadLine());

            int r = (a % 1000) / 100;
            Console.WriteLine(r);
        }
    }
}
