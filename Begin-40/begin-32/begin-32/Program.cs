//  Begin32.A centigrade temperature T is given. Convert it into a Fahrenheit
//  temperature. The centigrade temperature TC and the Fahrenheit temperature TF
//  are connected as:
//  TC = (TF − 32)·5 / 9.
namespace begin_32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("T: ");
            double T = Convert.ToDouble(Console.ReadLine());

            double tc;
            tc = T;
            tc = (tc - 32) * 5 / 9;
            Console.WriteLine("TC: " + tc);
        }
    }
}
