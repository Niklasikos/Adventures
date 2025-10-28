namespace adventures;

class Program
{
    private static string? Name;

    // main functie
    static void Main(string[] args)
    {
        ConsoleStart();
    }

    // functie om text in de midde van een terminal te displayen
    static void WriteCentered(string text, int verticalOffset = 0)
    {
        int width = Console.WindowWidth;
        int height = Console.WindowHeight;

        text = text.Replace("\r", "").Replace("\n", "");
        if (text.Length > width) text = text[..width];

        int left = Math.Max(0, (width - text.Length) / 2);
        int top = Math.Max(0, (height / 2) + verticalOffset);

        Console.SetCursorPosition(left, top);
        Console.Write(text);
    }

    static void ConsoleStart()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Title = "Adventures";
        Console.Clear();
        WriteCentered("..........Adventures..........", -2);
        WriteCentered("Press Enter to continue", 2);
        Console.ReadLine();
        Console.Clear();
        WriteCentered("............ CONTROLS & RULES ............", -3);
        WriteCentered("Most inputs are not case-sensitive (y = Y).", -1);
        WriteCentered("Press Enter to confirm or continue.", 0);
        WriteCentered("Numbers: whole integers only.", 1);
        WriteCentered("For Names/Input: write normal string inputs/names.", 2);
        Console.ForegroundColor = ConsoleColor.Yellow;
        WriteCentered("Yellow text is for Item/s", 3);
        Console.ForegroundColor = ConsoleColor.Cyan;
        WriteCentered("Cyan text is for Input/s", 4);
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        WriteCentered("Good luck, adventurer!", 8);
        Console.ReadLine();
        Console.Clear();
        StartGameQuestion();
    }

    // vraagd de user of hij spelen wil of niet
    static void StartGameQuestion()
    {
        Console.WriteLine("Do you want to start an adventure? (y/n)");
        string? keuze = Console.ReadLine()?.ToLower();

        if (keuze == "y")
        {
            NameQuestion();
        }
        else if (keuze == "n")
        {
            Console.WriteLine("see you next time adventurer");
            Console.WriteLine("PRESS ENTER TO EXIT");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("i couldnt understand adventurer, please choose one of the choices");
            StartGameQuestion();
        }

    }

    // vraagd de user na een naam
    static void NameQuestion()
    {
        Console.Clear();
        Console.WriteLine("Shall the Game begin");
        Console.WriteLine("");
        Console.WriteLine("But first let me know your Name adventurer:");
        Name = Console.ReadLine();
        Console.WriteLine($"Good to meet you {Name}.");
        Console.ReadLine();
        Console.Clear();
        Intro();
    }

    // het intro van het game
    static void Intro()
    {
        Console.WriteLine($"now {Name} let me first tell you a Story. A story of two kingdoms");
        Console.ReadLine();
    }
}
