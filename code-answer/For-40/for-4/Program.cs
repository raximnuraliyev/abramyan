//For4.Given the price of 1 kg of sweets (as a real number), output the cost of 1, 2, …,
//10 kg of these sweets.

namespace for_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sweets");
            int kg = 1;
            Console.WriteLine("price: ");

            int count = 0;
            float price = 0.0f;
            price = float.Parse(Console.ReadLine());

            for (int i = kg; i <= 10; i++)
            {
                count++;
                Console.WriteLine(i * price);
            }
            Console.WriteLine(count);
        }
    }
}
