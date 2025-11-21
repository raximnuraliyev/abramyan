//Integer6.A two-digit integer is given. Output its left digit (a tens digit) and then its
//right digit (a ones digit). Use the operator of integer division for obtaining the
//tens digit and the operator of taking remainder for obtaining the ones digit.

namespace integer_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A: ");
            int a = Convert.ToInt32(Console.ReadLine());

            int b = a % 10;
            Console.WriteLine($"{b}");
        }
    }
}
