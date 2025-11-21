//If11.The values of two integer variables A and B are given. If the values are not
//equal then assign the larger value to each variable, otherwise assign zero value
//to each variable. Output the new values of the variables A and B.

// a != b
// a > b or b > a
// else a = 0 and b = 0
namespace if_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a != b)
            {
                if (a > b)
                {
                    Console.WriteLine(a + " " + b);
                }
                else
                {
                    Console.WriteLine(""+ b +' '+a);
                }
            }
            else
            {
                a = 0;
                b = 0;
                Console.WriteLine($"{a} {b}");
            }
        }
    }
}
