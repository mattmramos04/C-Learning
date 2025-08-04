using System;
using System.Collections.Generic;

public class Wrestler
{
    public string Name;
    public int Age;
    public List<string> moves = new List<string>();

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

        foreach (Wrestler w in roster)
        {
            Console.WriteLine(w.Name);
            w.PrintMoveList();
        }
    }
}