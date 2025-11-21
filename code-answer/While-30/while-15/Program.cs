//While15.A principal of 1000 euro is invested at a rate of P percent compounded
//annually. A real number P is given, 0 < P < 25. Find, how many years K it will
//take for an investment to exceed 1100 euro. Output K (as an integer) and the
//compound amount S of the principal at the end of K years (as a real number).
namespace while_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("P: ");
            double p = Convert.ToInt32(Console.ReadLine());
            double k = 1;
            double euro = 1000;
            double i = 1;
            double s = 0;
            double percentage = 0;

            while (p < 25 && s < 1100)
            {
                percentage = p / 100;
                i += percentage;
                s += euro * Math.Pow(i, 2);
                k++;
            }
            Console.WriteLine($"s = {s}");
            Console.WriteLine($"k: {k}");
        }
    }
}
