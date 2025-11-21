//For1.Given integers K and N (N > 0), output the number K N times.
namespace for_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("K: ");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(k);
            }
        }
    }
}
