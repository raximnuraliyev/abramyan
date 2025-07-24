//  Begin17.Three points A, B, C are given on the real axis. Find the length of AC, the
//  length of BC, and the sum of these lengths.
namespace begin_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("A:");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.Write("B:");
            double B = Convert.ToDouble(Console.ReadLine());
            Console.Write("C:");
            double C = Convert.ToDouble(Console.ReadLine());
            double length_of_AC = Math.Abs(A - C);
            Console.WriteLine("Length of AC: "+length_of_AC);
            double length_of_BC = Math.Abs(B - C);
            Console.WriteLine("Length of AC: " + length_of_BC);
            double sum = length_of_AC + length_of_BC;
            Console.WriteLine("sum: "+sum);
        }
    }
}
