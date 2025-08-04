using System;
using System.Collections.Generic;
using System.Linq.Expressions; //for List<t>
/*
public class Program2
{
    public static void Main()
    {
        List<string> moves = new List<string>
        {
            "Scorpion Lock",
            "Powerbomb",
            "Superkick",
            "Brainbuster",
            "Chokeslam",
            "Suplerplex",
            "Canadian Destroyer"
        };

        int index = moves.FindIndex(move => move.StartsWith("Super"));

        if (index != -1)
        {
            Console.WriteLine($"{moves[index]}");
        }

        var movesWithO = moves.Where(move => move.ToLower().Contains("o")).ToList();

        foreach (string move in moves)
        {
            Console.WriteLine($"Every move that the letter 'o': {move}");
        }

        bool longerThan12 = moves.Any(move => move.Length > 12);
        Console.WriteLine(longerThan12);

        var movesWithSlam = moves.Where(move => move.ToLower().Contains("slam")).ToList();

        foreach (string move in movesWithSlam)
        {
            Console.WriteLine(move);
        }

        string[] legends = { "Sting", "Hogan", "Savage", "Flair", "Goldberg" };

        legends.Where(legend => legend.StartsWith("G") || legend.StartsWith("S")).ToList().ForEach(Console.WriteLine);
        string name = WrestlerName();

        List<string> moves = new List<string>();

        //Make a loop? So every time this question is asked it adds the name to the list until it's been asked
        //until the player says done?
        while (true)
        {
            Console.WriteLine("Type 'add' to add a move, 'remove' to remove one, or 'done' to finish:");
            string command = Console.ReadLine().ToLower();

            if (command == "done")
            {
                break;
            }

            else if (command == "add")
            {
                Console.WriteLine("Please enter a move name:");
                string moveName = Console.ReadLine();

                if (!moves.Contains(moveName, StringComparer.OrdinalIgnoreCase))
                {
                    moves.Add(moveName);
                }
                else
                {
                    Console.WriteLine("Move is already in your list!");
                }
            }

            else if (command == "remove")
            {
                Console.WriteLine("Please enter a move to remove:");
                string moveName = Console.ReadLine();
                int index = moves.FindIndex(move => move.Equals(moveName, StringComparison.OrdinalIgnoreCase));
                if (index != -1)
                {
                    moves.RemoveAt(index);
                }
                else
                {
                    Console.WriteLine("Move is not in list please try again!");
                }
            }

            Console.WriteLine($"\n{name}'s moves:");
            foreach (string move in moves)
            {
                Console.WriteLine($"- {move}");
            }
        }
    }

    public static string WrestlerName()
    {
        Console.WriteLine("Please Enter the Wrestler's Name:");
        string input = Console.ReadLine();

        return input;
    }

    public static void lambdaChallenges()
    {
        List<string> moves = new List<string>
        {
            "Scorpion Lock",
            "Powerbomb",
            "Superkick",
            "Brainbuster",
            "Chokeslam",
            "Suplerplex",
            "Canadian Destroyer"
        };

        int index = moves.FindIndex(move => move.StartsWith("Super"));

        if (index != -1)
        {
            Console.WriteLine($"{moves[index]}");
        }

        var movesWithO = moves.Where(move => move.ToLower().Contains("o")).ToList();

        foreach (string move in moves)
        {
            Console.WriteLine($"Every move that the letter 'o': {move}");
        }

        bool longerThan12 = moves.Any(move => move.Length > 12);
        Console.WriteLine(longerThan12);

        moves.Where(move => move.ToLower().Contains("slam")).ToList();

        foreach (string move in moves)
        {
            Console.WriteLine(move);
        }
    }
    
}
*/