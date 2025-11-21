//Integer15.A three-digit integer is given. Output an integer obtained from the given
//one by exchange a tens digit and a hundreds digit (for example, 123 will be
//changed to 213).

namespace integer_15
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
            Console.Write(c);
            Console.Write(b);
            Console.Write(d);

        }
    }
}
