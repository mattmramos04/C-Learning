using System;
using System.Collections.Generic;

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

        //LegendWrestler Draven = new LegendWrestler("Draven", 64, "2008");
        //Draven.CutPromo();
        //Draven.PrintMoveList();

        /*Commenting this out incase you don't like that, bubba
        roster.Add(Draven);
        */

        roster.Add(new LegendWrestler("Draven", 64, "2008" ));
        roster.Add(new Manager("Paul", 55, Matt.Name));
        
        foreach (Wrestler w in roster)
        {
            Console.WriteLine(w.Name);
            w.CutPromo();
        }
    }
}