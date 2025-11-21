//For15.Given a real number A and an integer N (> 0), find A raised to the power N
//(i. e., the product of N values of A):
//AN = A·A· … ·A.		i	0	double


namespace for_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 1;
            for (int i = 1; i <= n; i++)
            {
                sum *= a;

                Console.WriteLine(" ");
                Console.WriteLine($"i: {i}");
                Console.WriteLine($"n: {n}");
                Console.WriteLine($"a: {a}");
                Console.WriteLine($"sum: {sum}");
            }

        }
    }
}
