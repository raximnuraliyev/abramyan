//Integer19.From the beginning of the day N seconds have passed (N is integer). Find
//an amount of full minutes passed from the beginning of the day

namespace integer_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int m = a / 60;
            Console.WriteLine(m);

        }
    }
}
