//If3.An integer is given. If the integer is positive then increase it by 1, if the integer is
//negative then decrease it by 2, if the integer equals 0 then change it to 10.
//Output the obtained integer.
namespace if_3
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
            else if(a == 0)
            {
                a = 10;
            }
            else
            {
                a = a - 2;
            }
            Console.WriteLine(a);
        }
    }
}
