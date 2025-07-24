//Boolean3.Given integer A, verify the following proposition: ―The number A is even.

namespace boolean_3 {
    internal class Program {
        static void Main(string[] args)
        {
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
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
