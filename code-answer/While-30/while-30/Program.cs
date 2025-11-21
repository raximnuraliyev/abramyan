//While30.Three positive real numbers A, B, C are given. A rectangle of size A × B
//contains the greatest possible amount of squares with side C (without
//overlaps). Find the amount of squares placed on the rectangle. Do not use the
//operators of multiplication and division.

//find how many squares of size C × C can fit inside the rectangle without overlaps.
namespace while_30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A rectangle w: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B rectangle h: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("C square: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            int j = 0;
            int save_c1 = c;
            int save_c2 = c;
            int c1 = c;
            int c2 = c;
            int main = 0;

            while (a >= c1)
            {
                c1 = c1 + save_c1;
                i++;
            }
            Console.WriteLine($"i: {i}");

            while (b >= c2)
            {
                c2 = c2 + save_c2;
                j++;
            }
            Console.WriteLine($"j: {j}");

            int save_main = i;
            while (save_main > 0)
            {
                int save_main2 = j;
                while(save_main2 > 0)
                {
                    main++;
                    save_main2--;
                }
                save_main--;
            }
            Console.WriteLine(main);

        }
    }
}
