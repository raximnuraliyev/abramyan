//If14.Given three real numbers, output the minimal value and then the maximal value.
namespace if_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("C: ");
            int c = Convert.ToInt32(Console.ReadLine());
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
            // medium
            if (a > b)
            {
                if (c < b)
                {
                    if (c < a)
                    {
                        mm = b;
                    }
                }
            }
            else if (b < c)
            {
                mm = c;
            }
            if (a < b)
            {
                if (b > c)
                {
                    mm = c;
                }
                else
                {
                    mm = b;
                }
            }
            if (a < b)
            {
                if (b > c)
                {
                    if (a > c)
                    {
                        mm = a;
                    }
                }
            }
            Console.WriteLine(mn + ": MIN");
            Console.WriteLine(mm + ": MID");
            Console.WriteLine(mx + ": MAX");
        }
    }
}
