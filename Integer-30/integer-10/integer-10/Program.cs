//  Integer10.A three-digit integer is given. Output its last digit (a ones digit) and then
//  its middle digit (a tens digit)
namespace integer_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int three_digit = Convert.ToInt32(Console.ReadLine());

            int a = three_digit % 100 / 10;
            //int aa = a * 10;
            int b = three_digit % 10;
            Console.WriteLine($"a= {a}, b= {b}");
        }
    }
}
