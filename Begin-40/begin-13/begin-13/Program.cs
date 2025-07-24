//  Begin13. Given the radiuses R1 and R2 of two concentric circles (R1 > R2), find the
//  areas S1 and S2 of the circles and the area S3 of the ring bounded by the circles:6
//  S1 = π·(R1)2, S2 = π·(R2)2, S3 = S1 − S2.
//  Use 3.14 for a value of π.

namespace begin_13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double pi = 3.14;
            Console.Write("R1:");
            double R1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("R2:");
            double R2 = Convert.ToDouble(Console.ReadLine());
            double S1 = pi * Math.Pow(R1,2);
            Console.WriteLine($"S1: {S1}");
            double S2 = pi *Math.Pow(R2,2);
            Console.WriteLine($"S2: {S2}");
            double S3 = S1 - S2;
            Console.WriteLine($"S3: {S3}");
           
            


        }
    }
}
