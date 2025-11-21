//  Begin37.The velocity of the first car is V1 km/h, the velocity of the second car is
//  V2 km/h, the initial distance between the cars is S km. Find the distance
//  between the cars after T hours provided that at the start time the distance is
//  decreasing. This distance is equal to an absolute value of a difference between
//  the initial distance and the total distance covered by the both cars.
namespace begin_37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double V1, V2, S, T;
            Console.WriteLine("V1 km/h: ");
            V1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("V2 km/h: ");
            V2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("T h: ");
            T = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("S km: ");
            S = Convert.ToDouble(Console.ReadLine());

            double answer = Math.Abs(S-(V1* T + V2 *T));
            //double answer = S + V1 * T + V2 * T;
            Console.WriteLine(answer);
        }
    }
}
