// Boolean23.Given a four-digit integer, verify the following proposition: 
// ―The number is read equally both from left to right and from right to left ‖
namespace boolean_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c,d,e;
            Console.WriteLine("A: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = (a / 1000) % 10;
            d = (a / 100) % 10;
            e = (a / 10) % 10;
            c = a % 10;

            Console.WriteLine((b == c)&&(d==e));
        }
    }
}
