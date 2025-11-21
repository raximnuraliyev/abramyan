/*

Integer6. A two-digit integer is given. Output its left digit (a tens digit) and then its
right digit (a ones digit). Use the operator of integer division for obtaining the
tens digit and the operator of taking remainder for obtaining the ones digit 
 
*/


namespace integer_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("two-digit integer: ");
            int td_int = Convert.ToInt32(Console.ReadLine());

            int tens = td_int / 10;

            int ones = td_int % 10;

            Console.WriteLine($"tens: {tens}, ones: {ones}");
        }
    }
}
