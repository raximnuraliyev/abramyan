//Integer11.A three-digit integer is given. Find the sum and the product of its digits.
namespace integer_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("three-digit: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (a != 0) {
                int last = a % 10;
                sum += last;
                a /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
