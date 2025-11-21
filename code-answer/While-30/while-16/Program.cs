//While16.The skier began trainings having run 10 km. Each next day he increased the
//run distance by P percent from the distance of the last day. A real number P is
//given, 0 < P < 50). Find, how many days K it will take for a total run to exceed
//200 km. Output K (as an integer) and the total run S (as a real number).

namespace while_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("P: ");
            double p = Convert.ToInt32(Console.ReadLine());
            double k = 1;
            double d = 10;
            double s = 10;
            double percentage = 0;

            while (p < 50 && s < 200)
            {
                percentage = p / 100;
                d = d * (1 + percentage);
                s += d;
                k++;
            }
            Console.WriteLine($"s = {s}");
            Console.WriteLine($"k: {k}");
        }
    }
}
