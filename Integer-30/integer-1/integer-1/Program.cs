//Integer1.A distance L is given in centimeters. Find the amount of full meters of this distance (1 m = 1000 cm). Use the operator of integer division.
namespace integer_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("L: ");

            int L = Convert.ToInt32(Console.ReadLine());

            int m = L / 100;
            Console.WriteLine(m);
            Console.ReadLine();

        }
    }
}
//answer
            //Console.Write("L:");
            //int L = Convert.ToInt32(Console.ReadLine());
            //int Lm = L / 100;
            //Console.WriteLine("Lm:" + Lm);
            //Console.ReadKey();