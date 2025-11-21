//For5.Given the price of 1 kg of sweets (as a real number), output the cost of 0.1,
//0.2, …, 1 kg of these sweets.

namespace for_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sweets");
            float kg = 1f;
            Console.WriteLine("price: ");
            float price = 0.0f;
            price = float.Parse(Console.ReadLine());

            Console.WriteLine("times: ");
            //int N = Convert.ToInt32(Console.ReadLine());
            int N = 10;
            int count = 0;

            for (float i = kg; i <= N; i++)
            {
                count++;
                Console.WriteLine($"kg: {i/10}");
                Console.WriteLine($"price: {(i/10)* price}");
            }
            Console.WriteLine($"count: {count}");
        }
    }
}
