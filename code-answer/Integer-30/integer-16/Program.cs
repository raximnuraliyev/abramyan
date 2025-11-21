namespace integer_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = a / 100;
            int c = (a % 100)/10;
            int d = a % 10;
            Console.WriteLine($"{b}{d}{c}");
        }
    }
}
