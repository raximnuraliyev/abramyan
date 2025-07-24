//  Begin18.Three points A, B, C are given on the real axis, the point C is located
//  between the points A and B. Find the product of the length of AC and the
//  length of BC.
namespace begin_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            double A, B, C;
            A = Convert.ToDouble(Console.ReadLine());
            B = Convert.ToDouble(Console.ReadLine());
            C = Convert.ToDouble(Console.ReadLine());
            double AC = Math.Abs(A - C);
            double BC = Math.Abs(B - C);
            double sum = AC* BC;
            Console.WriteLine(sum);

        }
    }
}
