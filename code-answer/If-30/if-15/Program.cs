//If15.Given three real numbers, output the sum of two largest values.
namespace if_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A: ");
            int a = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("B: ");
            int b = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("C: ");
            int c = Convert.ToInt32 (Console.ReadLine());

            int mn = int.MaxValue;
            int mx = int.MinValue;
            int mm = 0;

            if (a < mn)
            {
                mn = a;
            }
            if (a > mx)
            {
                mx = a;
            }
            if (b < mn)
            {
                mn = b;
            }
            if (b > mx)
            {
                mx = b;
            }
            if (c < mn)
            {
                mn = c;
            }
            if (c > mx)
            {
                mx = c;
            }
            if (a < mx && b == mx && c == mn)
            {
                mm = a;
            }
            else if(a < mx && b == mn && c == mx)
            {
                mm = a;
            }
            else if (b < mx && a == mx && c == mn)
            {
                mm = b;
            }
            else if (b < mx && a == mn && c == mx)
            {
                mm = b;
            }
            else if (c < mx && a == mx && b == mn)
            {
                mm = c;
            }
            else if (c < mx && a == mn && b == mx)
            {
                mm = c;
            }
            Console.WriteLine($"{mx} and {mm}");
        }
    }
}
