namespace integer_29
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

            int d = a / c;
            int e = b / c;
            int ans = d * e;
            Console.WriteLine(ans);
        }
    }
}
