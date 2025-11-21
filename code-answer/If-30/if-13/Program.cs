//If13.Given three real numbers, output the value between the minimum and the maximum.
namespace if_13
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
            
            int mm = 0;

            // medium
            if (a > b)
            {
                if (c < b)
                {
                    if(c < a)
                    {
                        mm = b;
                    }
                }
            }
            else if(b < c)
            {
                mm = c;
            }
            if(a < b)
            {
                if(b > c)
                {
                    mm = c;
                }
                else
                {
                    mm = b;
                }
            }
            if(a < b) 
            { 
                if(b > c) 
                { 
                    if (a > c) 
                    { 
                        mm = a; 
                    } 
                } 
            }
            Console.WriteLine(mm + ": MID");
        }
    }
}
