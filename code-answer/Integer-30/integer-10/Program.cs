//Integer10.A three-digit integer is given. Output its last digit (a ones digit) and then
//its middle digit (a tens digit).


namespace integer_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            int b = (a % 10);
            int c = (a % 100) / 10;
            Console.Write(b);
            Console.Write(c);
        }
    }
}
