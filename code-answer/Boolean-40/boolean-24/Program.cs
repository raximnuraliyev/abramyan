//Boolean24.Three real numbers A, B, C are given (A is not equal to 0). By means of
//a discriminant D = B2 − 4·A·C, verify the following proposition: ―The
//quadratic equation A·x2 + B·x + C = 0 has real roots‖

namespace boolean_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            Console.WriteLine("A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("C: ");
            c = Convert.ToInt32(Console.ReadLine());
            d = (b*b) - 4 * a * c;
            Console.WriteLine(d>=0 && a!=0);


        }
    }
}
