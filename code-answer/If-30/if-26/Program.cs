//If26.Given a real independent variable x, find the value of a real function f defined
//as:
//−x, if x ≤ 0,
//f(x) = x2, if 0 < x < 2,
//4, if x ≥ 2.

namespace if_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            if(x <= 0)
            {
                x = -x;
                Console.WriteLine(x);
            }
            else if(0 < x && x < 2)
            {
                double f = Math.Pow(x, 2);
                Console.WriteLine(f);
            }
            else if(x >= 2)
            {
                Console.WriteLine(4);
            }
        }
    }
}
