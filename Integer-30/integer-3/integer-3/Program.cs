//nteger3.A file size is given in bytes. Find the amount of full Kbytes of this size (1 K = 1024 bytes). Use the operator of integer division
namespace integer_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("bytes: ");
            int k = Convert.ToInt32(Console.ReadLine());

            int bytes = k / 1024;
            Console.WriteLine($"{k} K = {bytes} bytes.");


        }
    }
}
