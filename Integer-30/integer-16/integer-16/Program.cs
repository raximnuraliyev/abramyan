//  Integer16.A three-digit integer is given. Output an integer obtained from the given
//  one by exchange a ones digit and a tens digit (for example, 123 will be
//  changed to 132).

using System.Xml;

namespace integer_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("three digit: ");
            int a = Convert.ToInt32(Console.ReadLine());

            int first = a / 100;
            int middle = a % 100 / 10;
            int last = a % 10;
            Console.Write(first);
            Console.Write(last);
            Console.Write(middle);
        }
    }
}
