//  Begin38.Solve a linear equation A·x + B = 0 with given coefficients A and B (A is
//  not equal to 0).
namespace begin_38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, x, b;
            Console.WriteLine("A: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("B: ");
            b = Convert.ToDouble(Console.ReadLine());
            
            x = (-1)*b/a;
            Console.WriteLine(x);
        }
    }
}
