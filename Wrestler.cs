using System;
using System.Collections.Generic;
using System.IO;

public class Wrestler
{
    public string Name;
    public int Age;
    public List<string> moves = new List<string>();

    public virtual void CutPromo()
    {
        Console.WriteLine("I'm calling you out buster!");
    }

    //Constructor
    public Wrestler(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void AddMove(string move)
    {
        moves.Add(move);
    }

    public void PrintMoveList()
    {
        Console.WriteLine($"{Name}'s moves are:");
        foreach (string move in moves)
        {
            Console.WriteLine(move);
        }
        Console.WriteLine();
    }

    public static void Main()
    {
        List<Wrestler> roster = new List<Wrestler>();

        Wrestler Matt = new Wrestler("Matthew", 20);
        Matt.AddMove("West Coast Pop");
        Matt.AddMove("Summersault");

        Wrestler Invincible = new Wrestler("Invincible", 27);
        Invincible.AddMove("Running Slam");
        Invincible.AddMove("5 Star Frog Splash");
        Invincible.AddMove("Diving Dropkick");

        Wrestler Cael = new Wrestler("Cael", 21);
        Cael.AddMove("Armbar");
        Cael.AddMove("Crucifix");

        roster.Add(Matt);
        roster.Add(Invincible);
        roster.Add(Cael);
        LegendWrestler Draven = new LegendWrestler("Draven", 64, "2008");

        //Draven.CutPromo();
        //Draven.PrintMoveList();

        /*Commenting this out incase you don't like that, bubba
        roster.Add(Draven);
        */

        roster.Add(new LegendWrestler("Draven", 64, "2008"));
        roster.Add(new Manager("Paul", 55, Matt.Name));

        /*
        foreach (Wrestler w in roster)
        {
            Console.WriteLine(w.Name);
            w.CutPromo();
        }

        Matt.SaveToFile();
        Draven.SaveToFile();
        Matt.ReadAllFile();
        Draven.ReadAllFile();
        */
        Wrestler fromFile = Wrestler.LoadFromFile("matthew_data.txt");
        fromFile.PrintMoveList();
    }

    public void SaveToFile()
    {
        string content = $"Name: {Name}\nAge: {Age}\nMoves:\n";
        foreach(string move in moves)
        {
            content += $"- {move}\n";
        }
        File.WriteAllText($"{Name.ToLower()}_data.txt", content);
    }

    public void ReadAllFile()
    {
        string fileName = $"{Name.ToLower()}_data.txt";

        if (File.Exists(fileName))
        {
            string data = File.ReadAllText(fileName);
            Console.WriteLine(data);
        }
        else
        {
            Console.WriteLine($"No save file found for {Name}");
        }
    }

    public static Wrestler LoadFromFile(string fileName)
    {
        string[] lines = File.ReadAllLines(fileName);

        string name = lines[0].Split(": ")[1];

        int age = int.Parse(lines[1].Split(": ")[1]);

        Wrestler loaded = new Wrestler(name, age);

        for (int i = 3; i < lines.Length; i++)
        {
            string move = lines[i].Substring(2);
            loaded.AddMove(move);
        }

        return loaded;
    }
}