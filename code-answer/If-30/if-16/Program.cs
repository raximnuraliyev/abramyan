//If16.The values of three real variables A, B, C are given. If the values are in
//ascending order then double them, otherwise replace the value of each variable
//by its opposite value. Output the new values of the variables A, B, C.
// if ascending like a = 2, b = 5,c = 9 || 2<5<9
// then it should be * 2 so a = 4, b = 10, c = 18
// if not a = -2, b = -5, c = -9


namespace if_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("C: ");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a < b && b < c)
            {
                a *= 2;
                b *= 2;
                c *= 2;
                Console.WriteLine($"A: {a}, B: {b}, C: {c}");
            }
            else if(a > b || b > c || c > a)
            {
                a *= -2;
                b *= -2;
                c *= -2;
                Console.WriteLine($"A: {a}, B: {b}, C: {c}");
            }


        }
    }
}
