////Proc1.Write a procedure PowerA3(A, B) that computes the third degree of a real
////number A and assigns the result to a real variable B (A is an input parameter,
////B is an output parameter). Using this procedure, find the third degree of five
////given real numbers.

//namespace proc_1
//{
//    internal class Program
//    {
//        // Procedure: computes A^3 and assigns it to output parameter B
//        static void PowerA3(double A, out double B)
//        {
//            // compute cube by direct multiplication
//            B = A * A * A;
//        }
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter 5 real numbers (one per line):");

//            for (int i = 1; i <= 5; i++)
//            {
//                string input = Console.ReadLine();
//                if (!double.TryParse(input, out double a))
//                {
//                    Console.WriteLine("Invalid number, try again.");
//                    i--; // repeat this iteration
//                    continue;
//                }

//                // call the procedure with an output parameter
//                PowerA3(a, out double b);

//                Console.WriteLine($"Number #{i}: A = {a}, A^3 = {b}");
//            }

//            Console.WriteLine("Done.");

//        }
//    }
//}


//using System;
//using System.Collections.Generic;

//class GraphLabels {
//    static void Main()
//    {
//        // We'll represent vertices with characters: 'A', 'B', 'C', 'D'
//        // adjacencyList maps each vertex label to its list of neighbors.
//        Dictionary<char, List<char>> adjacencyList = new Dictionary<char, List<char>>();

//        // Initialize the dictionary with each vertex and an empty neighbor list.
//        adjacencyList['A'] = new List<char>();
//        adjacencyList['B'] = new List<char>();
//        adjacencyList['C'] = new List<char>();
//        adjacencyList['D'] = new List<char>();

//        // Add undirected edges (using labels instead of numbers)
//        AddUndirectedEdge('A', 'B'); // A - B
//        AddUndirectedEdge('A', 'C'); // A - C
//        AddUndirectedEdge('B', 'C'); // B - C
//        AddUndirectedEdge('C', 'D'); // C - D

//        // Print adjacency list to verify graph structure
//        Console.WriteLine("Adjacency list:");
//        foreach (var kv in adjacencyList)
//        {
//            char vertex = kv.Key;
//            List<char> neighbors = kv.Value;
//            Console.WriteLine($"{vertex}: {string.Join(", ", neighbors)}");
//        }

//        // Local function that adds an undirected edge between u and v
//        void AddUndirectedEdge(char u, char v)
//        {
//            // Add v to u's neighbor list if it's not already there
//            if (!adjacencyList[u].Contains(v))
//                adjacencyList[u].Add(v);

//            // Add u to v's neighbor list if it's not already there
//            if (!adjacencyList[v].Contains(u))
//                adjacencyList[v].Add(u);
//        }
//    }
//}


using System;

public class Program {
    // Entry point
    public static void Main(string[] args)
    {
        var s = new Student("Ajax", "ajax@example.com", 80);
        s.Introduce();
    }
}

public class Student {
    private string _name;
    private string _email;
    private int _age;

    public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name cannot be empty.");
            _name = value;
        }
    }

    public string Email
    {
        get => _email;
        set
        {
            if (!value.Contains("@"))
                throw new ArgumentException("Invalid email.");
            _email = value;
        }
    }

    public int Age
    {
        get => _age;
        set
        {
            if (value < 0 || value > 120)
                throw new ArgumentOutOfRangeException("Age must be realistic.");
            _age = value;
        }
    }

    public Student(string name, string email, int age)
    {
        Name = name;
        Email = email;
        Age = age;
    }
public void Introduce()
{
    Console.WriteLine($"Hey, I'm {Name}, I'm {Age}, and you can reach me at {Email}.");
}
}
