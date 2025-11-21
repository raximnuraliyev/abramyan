//If9.The values of two real variables A and B are given. Redistribute the values so
//that A and B have the smaller and the larger value respectively. Output the new
//values of the variables A and B.
namespace if_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = 0;
            if (a > b)
            {
                //c = a;
                //a = b;
                //b = c;
                c = b;
                b = a;
                a = c;
                Console.WriteLine($"{a} {b}");
            }
            else
            {
                Console.WriteLine($"{a} {b}");
            }
        }
    }
}
