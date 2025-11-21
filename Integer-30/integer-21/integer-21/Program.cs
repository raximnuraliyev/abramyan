//Integer21.From the beginning of the day N seconds have passed (N is integer). Find
//an amount of seconds passed from the beginning of the last minute.
namespace integer_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N seconds: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int m = n % 60;
            Console.Write(m);

        }
    }
}
