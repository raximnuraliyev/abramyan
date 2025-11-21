//Integer9.A three-digit integer is given. Using one operator of integer division find
//first digit of the given integer (a hundreds digit).

namespace integer_9
{
    internal class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("A: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{a / 100}"); 
        }
    } 
}
