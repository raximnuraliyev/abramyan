//Integer2.A weight M is given in kilograms. Find the amount of full tons of this
//weight (1 ton = 1000 kg). Use the operator of integer division.

namespace integer_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("M: ");
            int m = Convert.ToInt32(Console.ReadLine());

            int t = m / 1000;
            Console.WriteLine(t);
        }
    }
}
