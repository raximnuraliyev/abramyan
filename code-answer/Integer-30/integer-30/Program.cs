namespace integer_30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = (a / 100) % 100;
            Console.WriteLine(b + 1);
        }
    }
}