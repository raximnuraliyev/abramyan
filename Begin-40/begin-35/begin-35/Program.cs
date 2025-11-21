//  Begin35.    A boat velocity in still water is V km/h, river flow velocity is U km/h
//  (U < V). The boat goes along the lake during T1 h and then goes against stream
//  of the river during T2 h. Positive numbers V, U, T1, T2 are given. Find the
//  distance S covered by the boat (distance = time · velocity).

namespace begin_35
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double V, U, T1, T2, S;
            Console.WriteLine("V km/h: ");
            V = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("U km/h: ");
            U = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("T1 h: ");
            T1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("T2 h: ");
            T2 = Convert.ToDouble(Console.ReadLine());

            double velocity = V - U;

            S = V*T1+(velocity)*T2;

            Console.WriteLine($"The covered distance: {S} by the boat");


        }
    }
}
