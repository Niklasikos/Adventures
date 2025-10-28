using System.Diagnostics;

namespace test;

class Program
{
    static string? Name;
    static void Main(string[] args)
    {
        Console.Clear();
        Console.ReadLine();
        StartGameQuestion();
    }

    static void StartGameQuestion()
    {
        Console.WriteLine("Do you want to start an adventure? (y/n)");
        string? keuze = Console.ReadLine();

        if (keuze == "y")
        {
            Start();
        }
        else if (keuze == "n")
        {
            Console.WriteLine("see you next time adventurer");
        }
        else 
        {
            Console.WriteLine("i couldnt understand adventurer, please choose one of the choices");
            StartGameQuestion();
        }
        
    }
    static void Start()
    {
        Console.WriteLine("Shall de Game begin");
        Console.WriteLine("But first let me know your Name adventurer:");
        string? Name = Console.ReadLine();
        Console.WriteLine("Good to meet you " + Name + ".");
    }

    Debug.Log(Name);
}
