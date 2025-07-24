//  Begin31.A Fahrenheit temperature T is given. Convert it into a centigrade
//  temperature. The centigrade temperature TC and the Fahrenheit temperature TF
//  are connected as:
//  TC = (TF − 32)·5 / 9.
namespace begin_31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("T: ");
            double T = Convert.ToDouble(Console.ReadLine());

            double tf, tc;
            tc = T;
            tf = (tc * 9 / 5) + 32;
            Console.WriteLine("TF: " + tf);
        }
    }
}
