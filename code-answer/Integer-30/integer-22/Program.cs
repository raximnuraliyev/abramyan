//Integer22.From the beginning of the day N seconds have passed (N is integer). Find
//an amount of seconds passed from the beginning of the last hour
namespace integer_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = a * 3600;
            Console.WriteLine(b);
        }
    }
}
