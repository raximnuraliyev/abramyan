//If27.Given a real independent variable x, find the value of an integer function f
//defined as:
//0, if x < 0,
//f(x) = 1, if x belongs to[0, 1), [2, 3), …,
//−1, if x belongs to[1, 2), [3, 4), … .

namespace if_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double f = 0;
            if (x < 0)
            {
                f = 0;
            }
            else if (x >= 0 && x <= 1)
            {
                f = 1;
            }
            else if(x >= 1 && x <= 2)
            {
                f = -1;
            }
            else if (x >= 2 && x <= 3)
            {
                f = 1;
            }
            else if (x >= 3 && x <= 4)
            {
                f = -1;
            }
            Console.WriteLine($"{f}");

        }
    }
}
