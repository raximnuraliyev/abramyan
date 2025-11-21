/* Integer4.Two positive integers A and B are given (A > B). Segment of length A contains the greatest possible amount of inside segments of length B (withoutoverlaps). 
   Find the amount of segments B placed on the segment A. Use the operator of integer division.
*/

namespace integer_4 {
    internal class Program {
        static void Main(string[] args)
        {
            Console.Write("A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("B: ");
            int B = Convert.ToInt32(Console.ReadLine());

            int answer = A / B;
            Console.WriteLine(answer);


// answer
            //Console.Write("A:");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("B:");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine("Segment A contains " + (int)a / b + " complete segments of B.");
            //Console.ReadKey();
        }
    }
}


