namespace integer_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("any day of the year: ");
            int k = Convert.ToInt32(Console.ReadLine());
            int y = (k % 7)+1;
            Console.WriteLine(y);

        }
    }
}
