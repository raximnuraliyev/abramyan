//Boolean5.Given two integers A and B, verify the following proposition: ―The
//inequality A ≥ 0 is fulfilled or the inequality B < −2 is fulfilled‖.


namespace boolean_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if(a >= 0 || b < -2)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
