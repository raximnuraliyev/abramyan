//  Begin36.The velocity of the first car is V1 km/h, the velocity of the second car is
//  V2 km/h, the initial distance between the cars is S km. Find the distance
//  between the cars after T hours provided that the distance is increasing. The
//  required distance is equal to a sum of the initial distance and the total distance
//  covered by the both cars (total distance = time · total velocity).

namespace BEGIN_36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double V1, V2, S, T, total;
            Console.Write("V1 km/h: ");
            V1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("V2 km/h: ");
            V2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("S km for initial distance between the cars: ");
            S = Convert.ToDouble(Console.ReadLine());
            Console.Write("T hours: ");
            T = Convert.ToDouble(Console.ReadLine());

            //S = V1 * T + (V1 - V2) * T;
            //total = T * S;

            total = S + V1 * T + V2 * T;

            Console.WriteLine($"Total distance covered by the both cars: {total}");

        }
    }
}
